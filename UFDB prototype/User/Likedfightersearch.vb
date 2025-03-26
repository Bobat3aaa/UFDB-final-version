Imports Newtonsoft.Json
Imports System.Data.SqlTypes
Imports System.IO

Public Class likedfightersearch

    '***************** CLASS LEVEL VARIABLES (same as fighter form) **************** 

    Private parsednames As New List(Of String)
    Private currentfighterlist As List(Of fighter)
    Private mainendindex As Integer

    '***************** QUICKSORT + FIND LIKED FIGHTERS  ****************
    Private Sub Likedfightersearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load







        'gets list of fighters via reading json
        Dim fighters As List(Of fighter) = functions.readfightersfromjson

        For Each fighter In fighters
            parsednames.Add(parsename(fighter.name, 1))
        Next
        'returns liked fighters for current user
        Dim likedfighterlist As List(Of fighter) = returnlikedfighters(fighters)

        currentfighterlist = likedfighterlist
        'allows scroling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True


        updatebuttons(currentfighterlist)

    End Sub

    Function returnlikedfighters(fighters As List(Of fighter))

        'reads likedfighter json
        Dim likedfighters As List(Of likedfighter) = functions.readlikedfighterjson






        Dim likedfighterlist As List(Of fighter) = (From lf In likedfighters 'looks through likedfighter list
                                                              Where lf.userid = Form1.currentuserid 'condition -> liked fighter user id is the same as the current user id
                                                              Join sf In fighters On lf.fighterid Equals sf.fighterid 'links liked fighter to fighter list using fighter id
                                                              Select sf).ToList() 'adds it to a list
        Debug.WriteLine(likedfighterlist.Count)
        'uses a quicksort to sort liked fighters
        If likedfighterlist.Count > 1 Then
            Dim indexlow As Integer = 0
            Dim indexhigh As Integer = likedfighterlist.Count - 1

            likedfighterlist = quicksortfighters(likedfighterlist, indexlow, indexhigh, 1)
            'rertuns sorted fighters
        End If

        Return likedfighterlist
    End Function




    Function quicksortfighters(fighters As List(Of fighter), indexlow As Integer, indexhigh As Integer, sortdecision As Integer) As List(Of fighter)
        Try


            Dim pivot As String
            Dim templow As Integer = indexlow
            Dim temphigh As Integer = indexhigh


            'if the user has no liked fighters, returns a new list
            If fighters.Count = 0 Then

                Return New List(Of fighter)()
            Else

                If sortdecision = 1 Then


                    pivot = fighters(Int((indexlow + indexhigh) / 2)).name

                    While templow <= temphigh
                        While String.Compare(fighters(templow).name, pivot) < 0
                            templow += 1
                        End While

                        While String.Compare(fighters(temphigh).name, pivot) > 0
                            temphigh -= 1
                        End While

                        'swaps fighters
                        If templow <= temphigh Then
                            Dim tempfighter As fighter = fighters(templow)
                            fighters(templow) = fighters(temphigh)
                            fighters(temphigh) = tempfighter
                            templow += 1
                            temphigh -= 1
                        End If
                    End While



                ElseIf sortdecision = 2 Then

                    pivot = parsednames(Int((indexlow + indexhigh) / 2))

                    While templow <= temphigh
                        While String.Compare(parsednames(templow), pivot) < 0

                            ' if the name before the pivot is smaller then the pivot, the indicator will increase until this is not the case

                            templow += 1
                        End While

                        While String.Compare(parsednames(temphigh), pivot) > 0

                            ' if the name after the pivot is larger then the pivot, the indicator will decrease until this is not the case

                            temphigh -= 1
                        End While

                        If templow <= temphigh Then

                            ' swaps fighters

                            Dim tempfighter As fighter = fighters(templow)
                            fighters(templow) = fighters(temphigh)
                            fighters(temphigh) = tempfighter

                            Dim tempname As String = parsednames(templow)
                            parsednames(templow) = parsednames(temphigh)
                            parsednames(temphigh) = tempname

                            templow += 1
                            temphigh -= 1
                        End If
                    End While

                    'recursively sorts
                    If indexlow <= temphigh Then
                        quicksortfighters(fighters, indexlow, temphigh, sortdecision)
                    End If

                    If templow < indexhigh Then
                        quicksortfighters(fighters, templow, indexhigh, sortdecision)
                    End If

                    Return fighters

                End If
            End If
        Catch ex As Exception
            MsgBox("Problem occured with quicksortfighters: " & ex.Message)
            Return New List(Of fighter)
        End Try
    End Function



    '***************** EVENT HANDLERS FOR LIST  ****************







    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    'the count is used to make sure only 50 items are shown at a time
    Sub updatebuttons(fighterlist As List(Of fighter), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()
        If fighterlist Is Nothing Then
        Else

            currentfighterlist = fighterlist
            'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
            Dim endIndex As Integer = Math.Min(startIndex + count, fighterlist.Count)
            mainendindex = endIndex

            If startIndex < 0 Then startIndex = 0


            If startIndex > 0 Then


                Dim btnback As New Button
                btnback.Width = 100
                btnback.Height = 50
                btnback.BackColor = Color.Red
                btnback.ForeColor = Color.White
                btnback.Font = New Font(btnback.Font.FontFamily, btnback.Font.Size + 2)
                btnback.TextAlign = ContentAlignment.MiddleCenter

                btnback.Text = "back"
                btnback.Visible = True
                btnback.Tag = "btnback"

                'adds an event handler to update buttons
                AddHandler btnback.Click, AddressOf btnbackclick

                FlowLayoutPanel1.Controls.Add(btnback)


            End If


            'creates 50 buttons
            For i = startIndex To endIndex - 1


                Dim btnfighter As New Button
                btnfighter.Width = 100
                btnfighter.Height = 100
                btnfighter.BackColor = Color.White
                btnfighter.TextAlign = ContentAlignment.MiddleCenter

                btnfighter.Text = fighterlist(i).name & vbCrLf & fighterlist(i).wins & "/" & fighterlist(i).losses & "/" & fighterlist(i).draws
                btnfighter.Visible = True
                btnfighter.Tag = i
                currentfighterlist = fighterlist
                AddHandler btnfighter.Click, AddressOf btnlikedfighterclick

                FlowLayoutPanel1.Controls.Add(btnfighter)


            Next

            'creates a load more button if needed
            If endIndex < fighterlist.Count Then


                Dim btnloadmore As New Button
                btnloadmore.Width = 100
                btnloadmore.Height = 50
                btnloadmore.TextAlign = ContentAlignment.MiddleCenter
                btnloadmore.BackColor = Color.Red
                btnloadmore.ForeColor = Color.White
                btnloadmore.Font = New Font(btnloadmore.Font.FontFamily, btnloadmore.Font.Size + 2)
                btnloadmore.TextAlign = ContentAlignment.MiddleCenter

                btnloadmore.Text = "Load more"
                btnloadmore.Visible = True
                btnloadmore.Tag = "btnloadmore"

                'adds an event handler to update buttons
                AddHandler btnloadmore.Click, AddressOf btnloadmoreclick
                FlowLayoutPanel1.Controls.Add(btnloadmore)


            End If
        End If
    End Sub

    Private Sub btnloadmoreclick(sender As Object, e As EventArgs)
        updatebuttons(currentfighterlist, mainendindex)
    End Sub
    Private Sub btnbackclick(sender As Object, e As EventArgs)
        updatebuttons(currentfighterlist, mainendindex - 100)
    End Sub



    Private Sub btnlikedfighterclick(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag (indexing number) of button which is the fighters place in the list

        Dim fighterIndex As Integer = Convert.ToInt32(clickedButton.Tag)


        'finds current fighter
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1


        Dim sortedfighters As List(Of fighter) = returnlikedfighters(fighters)



        Dim currentfighter As fighter = currentfighterlist(fighterIndex)

        'sends current fighter data over to the current fighter form
        Dim fighterForm As New currentfighterform(currentfighter)
        fighterForm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        fighterForm.ControlBox = True

        fighterForm.Show()


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim fighterlist As List(Of fighter) = functions.readfightersfromjson()
        fighterlist = returnlikedfighters(fighterlist)

        updatebuttons(fighterlist)
    End Sub

    '***************** SEARCHING ALGORITHMS  ****************


    Function bsearchfighters(fighterlist As List(Of fighter), nametofind As String, indexlow As Integer, indexhigh As Integer)
        Try



            'binary search for full name


            'if there are no fighters, returns -1 
            If indexlow > indexhigh Then
                Return -1
            End If

            Dim midpoint As Integer = (indexlow + indexhigh) \ 2

            If String.Compare(fighterlist(midpoint).name, nametofind) < 0 Then
                Return bsearchfighters(fighterlist, nametofind, midpoint + 1, indexhigh)
            ElseIf String.Compare(fighterlist(midpoint).name, nametofind) > 0 Then
                Return bsearchfighters(fighterlist, nametofind, indexlow, midpoint - 1)
            Else
                Return midpoint
            End If


        Catch ex As Exception
            MsgBox("Problem occured with binary search: " & ex.Message)
            Return New List(Of fighter)
        End Try
    End Function

    Function bsearchfighter_onename(fighterlist As List(Of fighter), nametofind As String, indexlow As Integer, indexhigh As Integer, decision As Integer) As List(Of fighter)

        Try

            If indexlow > indexhigh Then
                Return New List(Of fighter)()
            End If

            Dim midpoint As Integer = (indexlow + indexhigh) \ 2
            Dim currentfighter As fighter = fighterlist(midpoint)


            Dim fightername As String = parsename(currentfighter.name, decision)


            If String.Compare(fightername, nametofind) < 0 Then
                Return bsearchfighter_onename(fighterlist, nametofind, midpoint + 1, indexhigh, decision)
            ElseIf String.Compare(fightername, nametofind) > 0 Then
                Return bsearchfighter_onename(fighterlist, nametofind, indexlow, midpoint - 1, decision)
            Else

                'once binary search is done, finds all the fights with event number
                Dim searchedfighters As New List(Of fighter)()
                searchedfighters.Add(currentfighter)


                'checks fighters on left of midpoint
                Dim left As Integer = midpoint - 1
                While left >= indexlow
                    Dim leftfightername As String = parsename(fighterlist(left).name, decision)
                    If leftfightername = nametofind Then
                        searchedfighters.Add(fighterlist(left))
                        left -= 1
                    ElseIf leftfightername <> nametofind Then
                        Exit While
                    End If

                End While

                Dim right As Integer = midpoint + 1


                'checks fighters on right of midpoint
                While right <= indexhigh
                    Dim rightfightername As String = parsename(fighterlist(right).name, decision)
                    If rightfightername = nametofind Then
                        searchedfighters.Add(fighterlist(right))
                        right += 1
                    ElseIf rightfightername <> nametofind Then
                        Exit While
                    End If

                End While




                'return fighters
                Return searchedfighters
            End If

        Catch ex As Exception
            MsgBox("Problem occured with binary search using a single name: " & ex.Message)
            Return New List(Of fighter)
        End Try
    End Function

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click


        Dim fighters As List(Of fighter) = functions.readfightersfromjson
        fighters = returnlikedfighters(fighters)
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1
        Dim nametofind As String
        Dim searchedfighterindex As Integer
        Dim decision As Integer


        If String.IsNullOrEmpty(txtlname.Text) And String.IsNullOrEmpty(txtfname.Text) = False Then
            nametofind = txtfname.Text
            decision = 0
            Dim searchedfighters As List(Of fighter) = bsearchfighter_onename(fighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters

        ElseIf String.IsNullOrEmpty(txtlname.Text) = False And String.IsNullOrEmpty(txtfname.Text) Then
            nametofind = txtlname.Text
            decision = 1
            quicksortfighters(fighters, indexlow, indexhigh, 2) 'sorts users by last name for binary search
            Dim searchedfighters As List(Of fighter) = bsearchfighter_onename(fighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters

        Else
            nametofind = (txtfname.Text) + " " + (txtlname.Text)
            searchedfighterindex = bsearchfighters(fighters, nametofind, indexlow, indexhigh)
            MsgBox(searchedfighterindex)

            'adds fighter to a new list to be shown in search alone
            If searchedfighterindex <> -1 Then
                Dim searchedfighterlist As New List(Of fighter)
                searchedfighterlist.Clear()
                searchedfighterlist.Add(fighters(searchedfighterindex))
                currentfighterlist = searchedfighterlist

            End If

        End If
        Debug.WriteLine(nametofind)

        updatebuttons(currentfighterlist)

    End Sub

    Function parsename(name As String, decision As Integer) ' parse name for binary search

        'splits name where the space is

        Try


            If name <> "" And name IsNot Nothing Then


                Dim parsedname As String() = name.Split(" "c)



                If parsedname.Length > 0 Then
                    If decision = 0 Then
                        'returns first name
                        Return parsedname(0)

                    ElseIf decision = 1 And parsedname.Length > 1 Then
                        'returns last name

                        Return parsedname(1)
                    Else

                        Return ""
                    End If
                End If
            Else
                Return ""
            End If

        Catch ex As Exception
            MsgBox("Error parsing name:" & ex.Message)
            Return ""
        End Try

    End Function
End Class
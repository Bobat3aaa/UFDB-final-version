Imports Newtonsoft.Json
Imports System.Data.SqlTypes
Imports System.IO

Public Class Likedfightersearch

    Private currentfighterlist As List(Of fightermanagement)


    Private Sub Likedfightersearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load







        'gets list of fighters via reading json
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson

        'returns liked fighters for current user
        Dim likedfighterlist As List(Of fightermanagement) = returnlikedfighters(fighters)

        currentfighterlist = likedfighterlist
        'allows scroling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True


        updatebuttons(likedfighterlist)

    End Sub

    Function returnlikedfighters(fighters As List(Of fightermanagement))

        'reads likedfighter json
        Dim likedfighters As List(Of likedfighter) = functions.ReadlikedfightersFromJson






        Dim likedfighterlist As List(Of fightermanagement) = (From lf In likedfighters 'looks through likedfighter list
                                                              Where lf.userid = loginform.currentuserid 'condition -> liked fighter user id is the same as the current user id
                                                              Join sf In fighters On lf.fighterid Equals sf.FighterId 'links liked fighter to fighter list using fighter id
                                                              Select sf).ToList() 'adds it to a list

        'uses a quicksort to sort liked fighters
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = likedfighterlist.Count - 1

        Dim sortedfighters As List(Of fightermanagement) = Quicksort(likedfighterlist, indexlow, indexhigh)
        'rertuns sorted fighters
        Return sortedfighters
    End Function




    Function Quicksort(fighters As List(Of fightermanagement), indexlow As Integer, indexhigh As Integer) As List(Of fightermanagement)

        Dim pivot As String
        Dim templow As Integer = indexlow
        Dim temphigh As Integer = indexhigh


        'if the user has no liked fighters, returns a new list
        If fighters.Count = 0 Then

            Return New List(Of fightermanagement)()
        Else


            pivot = fighters(Int((indexlow + indexhigh) / 2)).Name

            While templow <= temphigh
                While String.Compare(fighters(templow).Name, pivot) < 0
                    templow += 1
                End While

                While String.Compare(fighters(temphigh).Name, pivot) > 0
                    temphigh -= 1
                End While

                'swaps fighters
                If templow <= temphigh Then
                    Dim tempfighter As fightermanagement = fighters(templow)
                    fighters(templow) = fighters(temphigh)
                    fighters(temphigh) = tempfighter
                    templow += 1
                    temphigh -= 1
                End If
            End While

            'recursively sorts
            If indexlow <= temphigh Then
                Quicksort(fighters, indexlow, temphigh)
            End If

            If templow < indexhigh Then
                Quicksort(fighters, templow, indexhigh)
            End If

            Return fighters
        End If
    End Function








    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click


        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson
        fighters = returnlikedfighters(fighters)
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1
        Dim nametofind As String
        Dim searchedfighterindex As Integer
        Dim decision As Integer


        If String.IsNullOrEmpty(txtlname.Text) And String.IsNullOrEmpty(txtfname.Text) = False Then
            nametofind = txtfname.Text
            decision = 0
            Dim searchedfighters As List(Of fightermanagement) = bsearchonename(fighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters

        ElseIf String.IsNullOrEmpty(txtlname.Text) = False And String.IsNullOrEmpty(txtfname.Text) Then
            nametofind = txtlname.Text
            decision = 1
            Dim searchedfighters As List(Of fightermanagement) = bsearchonename(fighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters

        Else
            nametofind = (txtfname.Text) + " " + (txtlname.Text)
            searchedfighterindex = bsearchusers(fighters, nametofind, indexlow, indexhigh)
            MsgBox(searchedfighterindex)

            'adds fighter to a new list to be shown in search alone
            If searchedfighterindex <> -1 Then
                Dim searchedfighterlist As New List(Of fightermanagement)
                searchedfighterlist.Clear()
                searchedfighterlist.Add(fighters(searchedfighterindex))
                currentfighterlist = searchedfighterlist

            End If

        End If
        Debug.WriteLine(nametofind)

        updatebuttons(currentfighterlist)

    End Sub
    Function bsearchusers(fighterlist As List(Of fightermanagement), nametofind As String, indexlow As Integer, indexhigh As Integer)

        'binary search, returns midpoint which is place in list
        If indexlow > indexhigh Then
            Return -1
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2

        If String.Compare(fighterlist(midpoint).Name, nametofind) < 0 Then
            Return bsearchusers(fighterlist, nametofind, midpoint + 1, indexhigh)
        ElseIf String.Compare(fighterlist(midpoint).Name, nametofind) > 0 Then
            Return bsearchusers(fighterlist, nametofind, indexlow, midpoint - 1)
        Else
            Return midpoint
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    'the count is used to make sure only 50 items are shown at a time
    Sub updatebuttons(sortedfighters As List(Of fightermanagement), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()
        If sortedfighters Is Nothing Then
        Else


            'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
            Dim endIndex As Integer = Math.Min(startIndex + count, sortedfighters.Count)



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
                AddHandler btnback.Click, Sub()
                                              updatebuttons(sortedfighters, endIndex - 100)
                                          End Sub
                FlowLayoutPanel1.Controls.Add(btnback)


            End If


            'creates 50 buttons
            For i = startIndex To endIndex - 1


                Dim btn As New Button
                btn.Width = 100
                btn.Height = 50
                btn.BackColor = Color.White
                btn.TextAlign = ContentAlignment.MiddleCenter

                btn.Text = sortedfighters(i).Name
                btn.Visible = True
                btn.Tag = i
                currentfighterlist = sortedfighters
                AddHandler btn.Click, AddressOf Button_Click

                FlowLayoutPanel1.Controls.Add(btn)


            Next

            'creates a load more button if needed
            If endIndex < sortedfighters.Count Then


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
                AddHandler btnloadmore.Click, Sub()
                                                  updatebuttons(sortedfighters, endIndex)
                                              End Sub
                FlowLayoutPanel1.Controls.Add(btnloadmore)


            End If
        End If
    End Sub


    'when a button in the flow control panel is picked (fighter edition
    Private Sub Button_Click(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag of button which is the fighters place in the list
        Dim fighterIndex As Integer = Convert.ToInt32(clickedButton.Tag)

        'need to find a way to optimise / reuse code

        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1


        Dim sortedfighters As List(Of fightermanagement) = returnlikedfighters(fighters)


        'finds current fighter
        Dim currentfighter As fightermanagement = currentfighterlist(fighterIndex)
        MsgBox(currentfighter.Name)
        'sends current fighter data over to the current fighter form
        Dim fighterForm As New current_fighter_form(currentfighter)
        fighterForm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        fighterForm.ControlBox = True

        fighterForm.Show()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim fighterlist As List(Of fightermanagement) = functions.ReadFightersFromJson()
        fighterlist = returnlikedfighters(fighterlist)

        updatebuttons(fighterlist)
    End Sub




    Public Function bsearchonename(fighterlist As List(Of fightermanagement), nametofind As String, indexlow As Integer, indexhigh As Integer, decision As Integer) As List(Of fightermanagement)

        Debug.WriteLine("index low is" & indexlow & "indexhigh is" & indexhigh)

        If indexlow > indexhigh Then
            Debug.WriteLine("1")
            Return New List(Of fightermanagement)()
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2

        Debug.WriteLine("midpoint is " & midpoint)
        Dim currentfighter As fightermanagement = fighterlist(midpoint)

        'gets event number
        Dim fightname As String = parsename(currentfighter.Name, decision)


        If String.Compare(fightname, nametofind) < 0 Then
            Debug.WriteLine("name is smaller than nametofind")
            Return bsearchonename(fighterlist, nametofind, midpoint + 1, indexhigh, decision)
        ElseIf String.Compare(fightname, nametofind) > 0 Then
            Debug.WriteLine("name is bigger than nametofind")
            Return bsearchonename(fighterlist, nametofind, indexlow, midpoint - 1, decision)
        Else

            Debug.WriteLine("3")
            Dim searchedfighters As New List(Of fightermanagement)()
            searchedfighters.Add(currentfighter)


            Dim left As Integer = midpoint - 1
            While left >= indexlow
                Dim leftfightername As String = parsename(fighterlist(left).Name, decision)
                If leftfightername = nametofind Then
                    searchedfighters.Add(fighterlist(left))
                    left -= 1
                ElseIf leftfightername <> nametofind Then
                    Exit While

                End If

            End While

            Dim right As Integer = midpoint + 1


            While right <= indexhigh
                Dim rightfightername As String = parsename(fighterlist(right).Name, decision)
                If rightfightername = nametofind Then
                    searchedfighters.Add(fighterlist(right))
                    right += 1
                ElseIf rightfightername <> nametofind Then
                    Exit While

                End If

            End While





            Return searchedfighters
        End If
    End Function

    Function parsename(name As String, decision As Integer)

        Dim parsedname As String() = name.Split(" "c)
        If decision = 0 Then
            Return parsedname(0)
        ElseIf decision = 1 And parsedname.Length > 0 Then
            Return parsedname(1)
        Else
            Return ""
        End If
    End Function

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
Imports Newtonsoft.Json
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class fightersearch


    '***************** CLASS LEVEL VARIABLES  ****************

    Private parsednames As New List(Of String) 'parsed names only for binary search
    Private currentfighterlist As List(Of fighter) ' global fighterlist for form to be accessible for all filters, sorts, etc
    Private mainendindex As Integer 'shows where the last item is in the list





    '***************** QUICKSORT FOR FIGHTERS ****************
    Function quicksortfighters(fighters As List(Of fighter), indexlow As Integer, indexhigh As Integer, sortdecision As Integer) As List(Of fighter)

        Try

            Dim pivot As String ' sorting pivot
            Dim templow As Integer = indexlow 'low of list
            Dim temphigh As Integer = indexhigh ' top of list

            ' if there is nothing in the list, it returns the previous fighter list

            If indexlow >= indexhigh Then
                Return fighters
            End If

            ' sortwins is used to determine what sorting method is used
            '0 sorts by name
            If sortdecision = 0 Then

                pivot = fighters(Int((indexlow + indexhigh) / 2)).name

                While templow <= temphigh
                    While String.Compare(fighters(templow).name, pivot) < 0

                        ' if the name before the pivot is smaller then the pivot, the indicator will increase until this is not the case

                        templow += 1
                    End While

                    While String.Compare(fighters(temphigh).name, pivot) > 0

                        ' if the name after the pivot is larger then the pivot, the indicator will decrease until this is not the case

                        temphigh -= 1
                    End While

                    If templow <= temphigh Then

                        ' swaps fighters

                        Dim tempfighter As fighter = fighters(templow)
                        fighters(templow) = fighters(temphigh)
                        fighters(temphigh) = tempfighter
                        templow += 1
                        temphigh -= 1
                    End If
                End While

                '1 sorts by least to most wins
            ElseIf sortdecision = 1 Then

                pivot = fighters(Int((indexlow + indexhigh) / 2)).wins
                While templow <= temphigh


                    While fighters(templow).wins < pivot And templow < indexhigh
                        templow += 1
                    End While

                    While pivot < fighters(temphigh).wins And temphigh > indexlow
                        temphigh -= 1
                    End While

                    If templow <= temphigh Then

                        If fighters(templow).wins <> fighters(temphigh).wins Then
                            'only swaps fighters if there wins are not the same to keep all quicksort outputs the same
                            Dim tempfighter As fighter = fighters(templow)
                            fighters(templow) = fighters(temphigh)
                            fighters(temphigh) = tempfighter
                        End If
                        templow += 1
                        temphigh -= 1
                    End If

                End While
                '2 sorts by most to least wins

            ElseIf sortdecision = 2 Then

                pivot = fighters(Int((indexlow + indexhigh) / 2)).wins
                While templow <= temphigh


                    While fighters(templow).wins > pivot And templow < indexhigh
                        templow += 1
                    End While

                    While pivot > fighters(temphigh).wins And temphigh > indexlow
                        temphigh -= 1
                    End While

                    If templow <= temphigh Then
                        If fighters(templow).wins <> fighters(temphigh).wins Then
                            Dim tempfighter As fighter = fighters(templow)
                            fighters(templow) = fighters(temphigh)
                            fighters(temphigh) = tempfighter
                        End If
                        templow += 1
                        temphigh -= 1
                    End If

                End While
                '3 sorts by least to most losses
            ElseIf sortdecision = 3 Then

                pivot = fighters(Int((indexlow + indexhigh) / 2)).losses
                While templow <= temphigh


                    While fighters(templow).losses < pivot And templow < indexhigh
                        templow += 1
                    End While

                    While pivot < fighters(temphigh).losses And temphigh > indexlow
                        temphigh -= 1
                    End While

                    If templow <= temphigh Then
                        If fighters(templow).losses <> fighters(temphigh).losses Then
                            Dim tempfighter As fighter = fighters(templow)
                            fighters(templow) = fighters(temphigh)
                            fighters(temphigh) = tempfighter
                        End If
                        templow += 1
                        temphigh -= 1
                    End If

                End While
                '4 sorts by most to least losses
            ElseIf sortdecision = 4 Then

                pivot = fighters(Int((indexlow + indexhigh) / 2)).losses
                While templow <= temphigh


                    While fighters(templow).losses > pivot And templow < indexhigh
                        templow += 1
                    End While

                    While pivot > fighters(temphigh).losses And temphigh > indexlow
                        temphigh -= 1
                    End While

                    If templow <= temphigh Then
                        If fighters(templow).losses <> fighters(temphigh).losses Then
                            Dim tempfighter As fighter = fighters(templow)
                            fighters(templow) = fighters(temphigh)
                            fighters(temphigh) = tempfighter
                        End If
                        templow += 1
                        temphigh -= 1
                    End If

                End While

                'used to sort last names specifically for binary search
            ElseIf sortdecision = 5 Then

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
                        If parsednames(templow) <> parsednames(temphigh) Then
                            Dim tempfighter As fighter = fighters(templow)
                            fighters(templow) = fighters(temphigh)
                            fighters(temphigh) = tempfighter

                            Dim tempname As String = parsednames(templow)
                            parsednames(templow) = parsednames(temphigh)
                            parsednames(temphigh) = tempname
                        End If


                        templow += 1
                        temphigh -= 1
                    End If
                End While
            End If

            If indexlow < temphigh Then
                quicksortfighters(fighters, indexlow, temphigh, sortdecision)
            End If

            If templow < indexhigh Then
                quicksortfighters(fighters, templow, indexhigh, sortdecision)
            End If


            Return fighters

        Catch ex As Exception
            MsgBox("Problem occured with fighter quicksortfighters: " & ex.Message)
            Return New List(Of fighter)
        End Try
    End Function







    Private Sub Fighterform_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'read fighters from json
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1


        cmbwins.SelectedIndex = 0
        For Each fighter In fighters
            parsednames.Add(parsename(fighter.name, 1))
        Next

        'filter and sort fighters
        Dim fighterlistfiltered As List(Of fighter) = checkfilters(fighters)

        'save the sorted list to the main fighterlist, and also save sorted list to json
        currentfighterlist = fighterlistfiltered
        functions.savetofighterjson(fighterlistfiltered)


        'allows scrolling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True


        Debug.WriteLine("Original fighters count: " & fighterlistfiltered.Count)
        'populate flow layout panel with fighters
        updatebuttons(fighterlistfiltered)


    End Sub

    Sub parsenames()
        parsednames.Clear()

        For Each fighter In currentfighterlist
            parsednames.Add(parsename(fighter.name, 1))
        Next

    End Sub

    '***************** FIGHTER BUTTON POPULATION + HANDLER ****************



    Sub updatebuttons(fighterlist As List(Of fighter), Optional startindex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()

        'makes sure that the fighterlist passed in is now the same as the currentfighterlist used by the button function
        currentfighterlist = fighterlist

        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
        Dim endindex As Integer = Math.Min(startindex + count, fighterlist.Count)
        mainendindex = endindex

        If startindex < 0 Then startindex = 0 'if fighters index becomes negative from load back makes sure back button brings you to first fighter

        'if the starting fighters index is bigger than 0, a back button is added that makes the starting index go back by 100 to undo the action of loading more

        If startindex > 0 Then


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


        'creates 50 fighter buttons

        For i = startindex To endindex - 1


            Dim btnfighter As New Button
            btnfighter.Width = 100
            btnfighter.Height = 100
            btnfighter.BackColor = Color.White
            btnfighter.TextAlign = ContentAlignment.MiddleCenter


            btnfighter.Text = fighterlist(i).name & vbCrLf & fighterlist(i).wins & "/" & fighterlist(i).losses & "/" & fighterlist(i).draws


            btnfighter.Visible = True
            btnfighter.Tag = i

            'associates pressing the button with the button click subprocedure
            AddHandler btnfighter.Click, AddressOf btnfighterclick

            FlowLayoutPanel1.Controls.Add(btnfighter)


        Next

        'creates a load more button if the last fighter index is smaller than the amount of fighters in the list
        If endindex < fighterlist.Count Then


            Dim btnloadmore As New Button
            btnloadmore.Width = 100
            btnloadmore.Height = 100
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
            'Sub()
            '    updatebuttons(fighterlist, endIndex)
            'End Sub
            FlowLayoutPanel1.Controls.Add(btnloadmore)


        End If

    End Sub

    Private Sub btnloadmoreclick(sender As Object, e As EventArgs)
        updatebuttons(currentfighterlist, mainendindex)
    End Sub
    Private Sub btnbackclick(sender As Object, e As EventArgs)
        updatebuttons(currentfighterlist, mainendindex - 100)
    End Sub

    Private Sub btnfighterclick(sender As Object, e As EventArgs)   'when a fighter button in the flow control panel is picked 

        'shows what button was pressed
        Dim clickedbutton As Button = DirectCast(sender, Button)

        'gets tag (indexing number) of button which is the fighters place in the list
        Dim fighterindex As Integer = Convert.ToInt32(clickedbutton.Tag)


        'finds current fighter
        Dim currentfighter As fighter = currentfighterlist(fighterindex)
        'sends current fighter data over to the current fighter form
        Dim fighterform As New currentfighterform(currentfighter)


        'opens new fighterform in panel
        childform(fighterform)

    End Sub









    '***************** BINARY SEARCH FOR FIGHTERS ****************


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click


        Dim fighters As List(Of fighter) = functions.readfightersfromjson() 'list of all fighters
        Dim indexlow As Integer = 0  'bottom of the fighter list
        Dim indexhigh As Integer = fighters.Count - 1 ' amount of fighters
        Dim nametofind As String 'name entered by user
        Dim searchedfighterindex As Integer ' the index number of the fighter found
        Dim decision As Integer ' decides whether it is a full name, only first name, or last name




        ' if statement that returns a list of fighters that have the correct name
        If String.IsNullOrEmpty(txtlname.Text) And String.IsNullOrEmpty(txtfname.Text) = False Then

            Debug.WriteLine("option1 ")
            nametofind = txtfname.Text
            decision = 0
            Dim searchedfighters As List(Of fighter) = bsearchfighter_onename(fighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters


        ElseIf String.IsNullOrEmpty(txtlname.Text) = False And String.IsNullOrEmpty(txtfname.Text) Then
            parsenames()
            Debug.WriteLine("option 2 ")
            nametofind = txtlname.Text
            decision = 1
            Dim filteredfighters = quicksortfighters(fighters, indexlow, indexhigh, 5) 'sorts users by last name for binary search

            For i = 0 To 20
                Debug.WriteLine(filteredfighters(i).name)
            Next
            For i = 0 To 20
                Debug.WriteLine(parsednames(i))
            Next
            Dim searchedfighters As List(Of fighter) = bsearchfighter_onename(filteredfighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters





        Else

            'occurs if both the first name and last name are entered

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

        'updates flow layout panel with new fighters
        currentfighterlist = checkfilters(currentfighterlist)
        updatebuttons(currentfighterlist)

    End Sub

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





    '***************** FILTER CHECKS FOR FIGHTERS ****************



    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'reads fighters from json again  and updates the  buttons
        Dim fighterlist As List(Of fighter) = functions.readfightersfromjson()
        txtfname.Text = ""
        txtlname.Text = ""
        currentfighterlist = fighterlist
        updatebuttons(fighterlist)
    End Sub

    Private Sub cmbstance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstance.SelectedIndexChanged
        'makes new fighter list with all fighters
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        'checks filters and updates buttons
        Dim fighterlist As List(Of fighter) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub




    Private Sub cmbsort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbwins.SelectedIndexChanged


        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        'makes new fighter list with all fighters
        Dim fighterlist As List(Of fighter) = checkfilters(fighters)
        'checks filters and updates buttons
        updatebuttons(fighterlist)

    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbweightclass.SelectedIndexChanged
        'reads fighters from json again
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        'checks for filters
        Dim fighterlist As List(Of fighter) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub




    Function checkfilters(fighterlist As List(Of fighter)) ' used to check all filters

        Try

            Dim selectedstance As String = "" 'used to store the selected stance
            Dim selectedWeightClass As String = "" ' used to store selected weight class


            Dim filteredfighters As List(Of fighter) = fighterlist 'makes new fighterlist with all fighters in it

            If cmbweightclass.SelectedItem IsNot Nothing Then
                selectedWeightClass = cmbweightclass.SelectedItem.ToString() 'stores selected weight class
            End If

            If cmbstance.SelectedItem IsNot Nothing Then
                selectedstance = cmbstance.SelectedItem.ToString() ' stores selected stance
            End If


            ' Filter fighters based on the selected weight class

            If selectedWeightClass <> "All" And selectedWeightClass <> "" Then 'statement only occurs if the selected weight class does not equal nothing, or all
                'returns a list of fighters with the same weight class
                filteredfighters = filteredfighters.Where(Function(f) f.weight = selectedWeightClass).ToList()
            End If



            If selectedstance <> "All" And selectedstance <> "" Then 'statement only occurs if the selected stance does not equal nothing, or all
                'returns a list of fighters with the same weight class and stance
                filteredfighters = filteredfighters.Where(Function(f) f.stance = selectedstance).ToList()
            End If


            'variables used for sorting

            Dim indexlow As Integer = 0
            Dim indexhigh As Integer = filteredfighters.Count - 1
            Dim sortwins As Integer = cmbwins.SelectedIndex 'determines sorting direction


            'sorts filtered fighters based on decision made
            filteredfighters = quicksortfighters(filteredfighters, indexlow, indexhigh, sortwins)
            lblsorted.Text = cmbwins.SelectedItem



            Debug.WriteLine(filteredfighters.Count)
            Return filteredfighters

        Catch ex As Exception
            MsgBox("Problem occured with checking filters: " & ex.Message)
            Return New List(Of fighter)
        End Try

    End Function

    'UI functions
    Sub childform(ByVal panel As Form) 'used to embed panel within panel
        pnlcurrentfighter.Controls.Clear()
        panel.TopLevel = False
        pnlcurrentfighter.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click     'brings user back to home
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblsorted_Click(sender As Object, e As EventArgs) Handles lblsorted.Click

    End Sub
End Class
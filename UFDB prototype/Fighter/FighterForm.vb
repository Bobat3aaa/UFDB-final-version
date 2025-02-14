Imports Newtonsoft.Json
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class FighterForm

    Private currentfighterlist As List(Of fightermanagement) ' global fighterlist for form to be accessible for all filters, sorts, etc

    'quicksort used to sort fighters
    Function Quicksort(fighters As List(Of fightermanagement), indexlow As Integer, indexhigh As Integer, sortdecision As Integer) As List(Of fightermanagement)

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

            pivot = fighters(Int((indexlow + indexhigh) / 2)).Name

            While templow <= temphigh
                While String.Compare(fighters(templow).Name, pivot) < 0

                    ' if the name before the pivot is smaller then the pivot, the indicator will increase until this is not the case

                    templow += 1
                End While

                While String.Compare(fighters(temphigh).Name, pivot) > 0

                    ' if the name after the pivot is larger then the pivot, the indicator will decrease until this is not the case

                    temphigh -= 1
                End While

                If templow <= temphigh Then

                    ' swaps fighters

                    Dim tempfighter As fightermanagement = fighters(templow)
                    fighters(templow) = fighters(temphigh)
                    fighters(temphigh) = tempfighter
                    templow += 1
                    temphigh -= 1
                End If
            End While

            '1 sorts by least to most wins
        ElseIf sortdecision = 1 Then

            pivot = fighters(Int((indexlow + indexhigh) / 2)).Wins
            While templow <= temphigh


                While fighters(templow).Wins < pivot And templow < indexhigh
                    templow += 1
                End While

                While pivot < fighters(temphigh).Wins And temphigh > indexlow
                    temphigh -= 1
                End While

                If templow <= temphigh Then

                    If fighters(templow).Wins <> fighters(temphigh).Wins Then
                        'only swaps fighters if there wins are not the same to keep all quicksort outputs the same
                        Dim tempfighter As fightermanagement = fighters(templow)
                        fighters(templow) = fighters(temphigh)
                        fighters(temphigh) = tempfighter
                    End If
                    templow += 1
                    temphigh -= 1
                End If

            End While
            '2 sorts by most to least wins

        ElseIf sortdecision = 2 Then

            pivot = fighters(Int((indexlow + indexhigh) / 2)).Wins
            While templow <= temphigh


                While fighters(templow).Wins > pivot And templow < indexhigh
                    templow += 1
                End While

                While pivot > fighters(temphigh).Wins And temphigh > indexlow
                    temphigh -= 1
                End While

                If templow <= temphigh Then
                    If fighters(templow).Wins <> fighters(temphigh).Wins Then
                        Dim tempfighter As fightermanagement = fighters(templow)
                        fighters(templow) = fighters(temphigh)
                        fighters(temphigh) = tempfighter
                    End If
                    templow += 1
                    temphigh -= 1
                End If

            End While
            '3 sorts by least to most losses
        ElseIf sortdecision = 3 Then

            pivot = fighters(Int((indexlow + indexhigh) / 2)).Losses
            While templow <= temphigh


                While fighters(templow).Losses < pivot And templow < indexhigh
                    templow += 1
                End While

                While pivot < fighters(temphigh).Losses And temphigh > indexlow
                    temphigh -= 1
                End While

                If templow <= temphigh Then
                    If fighters(templow).Losses <> fighters(temphigh).Losses Then
                        Dim tempfighter As fightermanagement = fighters(templow)
                        fighters(templow) = fighters(temphigh)
                        fighters(temphigh) = tempfighter
                    End If
                    templow += 1
                    temphigh -= 1
                End If

            End While
            '4 sorts by most to least losses
        ElseIf sortdecision = 4 Then

            pivot = fighters(Int((indexlow + indexhigh) / 2)).Losses
            While templow <= temphigh


                While fighters(templow).Losses > pivot And templow < indexhigh
                    templow += 1
                End While

                While pivot > fighters(temphigh).Losses And temphigh > indexlow
                    temphigh -= 1
                End While

                If templow <= temphigh Then
                    If fighters(templow).Losses <> fighters(temphigh).Losses Then
                        Dim tempfighter As fightermanagement = fighters(templow)
                        fighters(templow) = fighters(temphigh)
                        fighters(temphigh) = tempfighter
                    End If
                    templow += 1
                    temphigh -= 1
                End If

            End While


        End If

        If indexlow < temphigh Then
            Quicksort(fighters, indexlow, temphigh, sortdecision)
        End If

        If templow < indexhigh Then
            Quicksort(fighters, templow, indexhigh, sortdecision)
        End If


        Return fighters
    End Function







    Private Sub Fighterform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'read fighters from json
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1


        cmbwins.SelectedIndex = 0


        'filter and sort fighters
        Dim fighterlistfiltered As List(Of fightermanagement) = checkfilters(fighters)

        'save the sorted list to the main fighterlist, and also save sorted list to json
        currentfighterlist = fighterlistfiltered
        functions.SaveToFighterJson(fighterlistfiltered)


        'allows scrolling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True

        'populate flow layout panel with fighters
        updatebuttons(fighterlistfiltered)


    End Sub







    'the count is used to make sure only 50 items are shown at a time
    Sub updatebuttons(fighterlist As List(Of fightermanagement), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()

        'makes sure that the fighterlist passed in is now the same as the currentfighterlist used by the button function
        currentfighterlist = fighterlist

        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
        Dim endIndex As Integer = Math.Min(startIndex + count, fighterlist.Count)


        'if the starting fighters index is bigger than 0, a back button is added that makes the starting index go back by 100 to undo the action of loading more

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
                                          updatebuttons(fighterlist, endIndex - 100)
                                      End Sub
            FlowLayoutPanel1.Controls.Add(btnback)


        End If


        'creates 50 fighter buttons
        For i = startIndex To endIndex - 1


            Dim btnfighter As New Button
            btnfighter.Width = 100
            btnfighter.Height = 100
            btnfighter.BackColor = Color.White
            btnfighter.TextAlign = ContentAlignment.MiddleCenter
            btnfighter.Font = New Font("Clash Display", 9, FontStyle.Regular)

            btnfighter.Text = fighterlist(i).Name & vbCrLf & fighterlist(i).Wins & "/" & fighterlist(i).Losses & "/" & fighterlist(i).Draws
            btnfighter.Visible = True

            btnfighter.Visible = True
            btnfighter.Tag = i

            'associates pressing the button with the button click subprocedure
            AddHandler btnfighter.Click, AddressOf Button_Click

            FlowLayoutPanel1.Controls.Add(btnfighter)


        Next

        'creates a load more button if the last fighter index is smaller than the amount of fighters in the list
        If endIndex < fighterlist.Count Then


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
            AddHandler btnloadmore.Click, Sub()
                                              updatebuttons(fighterlist, endIndex)
                                          End Sub
            FlowLayoutPanel1.Controls.Add(btnloadmore)


        End If

    End Sub



    Private Sub Button_Click(sender As Object, e As EventArgs)   'when a fighter button in the flow control panel is picked 

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag (indexing number) of button which is the fighters place in the list
        Dim fighterIndex As Integer = Convert.ToInt32(clickedButton.Tag)


        'finds current fighter
        Dim currentfighter As fightermanagement = currentfighterlist(fighterIndex)
        'sends current fighter data over to the current fighter form
        Dim fighterForm As New current_fighter_form(currentfighter)


        'opens new fighterform in panel
        childform(fighterForm)

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'reads fighters from json again  and updates the  buttons
        Dim fighterlist As List(Of fightermanagement) = functions.ReadFightersFromJson()
        updatebuttons(fighterlist)
    End Sub







    'searching


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click


        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson() 'list of all fighters
        Dim indexlow As Integer = 0  'bottom of the fighter list
        Dim indexhigh As Integer = fighters.Count - 1 ' amount of fighters
        Dim nametofind As String 'name entered by user
        Dim searchedfighterindex As Integer ' the index number of the fighter found
        Dim decision As Integer ' decides whether it is a full name, only first name, or last name




        ' if statement that returns a list of fighters that have the correct name
        If String.IsNullOrEmpty(txtlname.Text) And String.IsNullOrEmpty(txtfname.Text) = False Then


            nametofind = txtfname.Text
            decision = 0
            Dim searchedfighters As List(Of fightermanagement) = bsearchfighter_onename(fighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters


        ElseIf String.IsNullOrEmpty(txtlname.Text) = False And String.IsNullOrEmpty(txtfname.Text) Then


            nametofind = txtlname.Text
            decision = 1
            Dim searchedfighters As List(Of fightermanagement) = bsearchfighter_onename(fighters, nametofind, indexlow, indexhigh, decision)
            currentfighterlist = searchedfighters


        Else

            'occurs if both the first name and last name are entered

            nametofind = (txtfname.Text) + " " + (txtlname.Text)
            searchedfighterindex = bsearchfighters(fighters, nametofind, indexlow, indexhigh)
            MsgBox(searchedfighterindex)

            'adds fighter to a new list to be shown in search alone
            If searchedfighterindex <> -1 Then
                Dim searchedfighterlist As New List(Of fightermanagement)
                searchedfighterlist.Clear()
                searchedfighterlist.Add(fighters(searchedfighterindex))
                currentfighterlist = searchedfighterlist

            End If


        End If

        'updates flow layout panel with new fighters
        updatebuttons(currentfighterlist)

    End Sub

    Function bsearchfighters(fighterlist As List(Of fightermanagement), nametofind As String, indexlow As Integer, indexhigh As Integer)


        'binary search for full name


        'if there are no fighters, returns -1 
        If indexlow > indexhigh Then
            Return -1
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2

        If String.Compare(fighterlist(midpoint).Name, nametofind) < 0 Then
            Return bsearchfighters(fighterlist, nametofind, midpoint + 1, indexhigh)
        ElseIf String.Compare(fighterlist(midpoint).Name, nametofind) > 0 Then
            Return bsearchfighters(fighterlist, nametofind, indexlow, midpoint - 1)
        Else
            Return midpoint
        End If
    End Function



    Public Function bsearchfighter_onename(fighterlist As List(Of fightermanagement), nametofind As String, indexlow As Integer, indexhigh As Integer, decision As Integer) As List(Of fightermanagement)



        If indexlow > indexhigh Then
            Return New List(Of fightermanagement)()
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2
        Dim currentfighter As fightermanagement = fighterlist(midpoint)

        'gets event number
        Dim fightername As String = parsename(currentfighter.Name, decision)


        If String.Compare(fightername, nametofind) < 0 Then
            Return bsearchfighter_onename(fighterlist, nametofind, midpoint + 1, indexhigh, decision)
        ElseIf String.Compare(fightername, nametofind) > 0 Then
            Return bsearchfighter_onename(fighterlist, nametofind, indexlow, midpoint - 1, decision)
        Else

            'once binary search is done, finds all the fights with event number
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

    Function parsename(name As String, decision As Integer) ' parse name for binary search

        'splits name where the space is
        Dim parsedname As String() = name.Split(" "c)

        If decision = 0 Then
            'returns first name
            Return parsedname(0)
        ElseIf decision = 1 And parsedname.Length > 0 Then
            'returns last name
            Return parsedname(1)
        Else
            Return ""
        End If
    End Function


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


    'filter checks


    Private Sub cmbstance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstance.SelectedIndexChanged
        'makes new fighter list with all fighters
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        'checks filters and updates buttons
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub




    Private Sub cmbsort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbwins.SelectedIndexChanged


        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        'makes new fighter list with all fighters
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        'checks filters and updates buttons
        updatebuttons(fighterlist)

    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbweightclass.SelectedIndexChanged
        'reads fighters from json again
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        'checks for filters
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub




    Function checkfilters(fighterlist As List(Of fightermanagement)) ' used to check all filters


        Dim selectedstance As String = "" 'used to store the selected stance
        Dim selectedWeightClass As String = "" ' used to store selected weight class


        Dim filteredFighters As List(Of fightermanagement) = fighterlist 'makes new fighterlist with all fighters in it

        If cmbweightclass.SelectedItem IsNot Nothing Then
            selectedWeightClass = cmbweightclass.SelectedItem.ToString() 'stores selected weight class
        End If

        If cmbstance.SelectedItem IsNot Nothing Then
            selectedstance = cmbstance.SelectedItem.ToString() ' stores selected stance
        End If


        ' Filter fighters based on the selected weight class

        If selectedWeightClass <> "All" And selectedWeightClass <> "" Then 'statement only occurs if the selected weight class does not equal nothing, or all
            'returns a list of fighters with the same weight class
            filteredFighters = filteredFighters.Where(Function(f) f.Weight = selectedWeightClass).ToList()
        End If



        If selectedstance <> "All" And selectedstance <> "" Then 'statement only occurs if the selected stance does not equal nothing, or all
            'returns a list of fighters with the same weight class and stance
            filteredFighters = filteredFighters.Where(Function(f) f.Stance = selectedstance).ToList()
        End If


        'variables used for sorting

        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = filteredFighters.Count - 1
        Dim sortwins As Integer = cmbwins.SelectedIndex 'determines sorting direction


        'sorts filtered fighters based on decision made
        filteredFighters = Quicksort(filteredFighters, indexlow, indexhigh, sortwins)





        Return filteredFighters


    End Function



End Class
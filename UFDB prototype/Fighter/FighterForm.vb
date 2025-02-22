﻿Imports Newtonsoft.Json
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class FighterForm


    Private fighterlist As List(Of fightermanagement) ' global fighterlist for form to be accessible for all filters, sorts, etc
    Private Sub btnsort_Click(sender As Object, e As EventArgs)

    End Sub
    'quicksort used to sort fighters
    Function Quicksort(fighters As List(Of fightermanagement), indexlow As Integer, indexhigh As Integer, sortwins As Integer) As List(Of fightermanagement)

        Dim pivot As String ' sorting pivot
        Dim templow As Integer = indexlow 'low of list
        Dim temphigh As Integer = indexhigh ' top of list

        ' if there is nothing in the list, it returns the previous fighter list

        If indexlow >= indexhigh Then
            Return fighters
        End If

        ' sortwins is used to determine what sorting method is used
        '0 sorts by name
        If sortwins = 0 Then

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
        ElseIf sortwins = 1 Then

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

        ElseIf sortwins = 2 Then

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
        ElseIf sortwins = 3 Then

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
        ElseIf sortwins = 4 Then

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
            Quicksort(fighters, indexlow, temphigh, sortwins)
        End If

        If templow < indexhigh Then
            Quicksort(fighters, templow, indexhigh, sortwins)
        End If


        Return fighters
    End Function







    Private Sub Fighterform_Load(sender As Object, e As EventArgs) Handles MyBase.Load










        'sorts fighters and saves to file
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Debug.WriteLine(fighters.Count)
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1
        cmbwins.SelectedIndex = 0



        Dim sortedfighters As List(Of fightermanagement) = checkfilters(fighters)
        Debug.WriteLine(sortedfighters.Count)

        fighterlist = sortedfighters
        functions.SaveToFighterJson(sortedfighters)
        Debug.WriteLine(fighterlist.Count)

        'allows scroling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True


        updatebuttons(sortedfighters)


    End Sub



    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click


        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1
        Dim nametofind As String
        Dim searchedfighterindex As Integer
        Dim decision As Integer


        If String.IsNullOrEmpty(txtlname.Text) And String.IsNullOrEmpty(txtfname.Text) = False Then
            nametofind = txtfname.Text
            decision = 0
            Dim searchedfighters As List(Of fightermanagement) = bsearchonename(fighters, nametofind, indexlow, indexhigh, decision)
            fighterlist = searchedfighters

        ElseIf String.IsNullOrEmpty(txtlname.Text) = False And String.IsNullOrEmpty(txtfname.Text) Then
            nametofind = txtlname.Text
            decision = 1
            Dim searchedfighters As List(Of fightermanagement) = bsearchonename(fighters, nametofind, indexlow, indexhigh, decision)
            fighterlist = searchedfighters

        Else
            nametofind = (txtfname.Text) + " " + (txtlname.Text)
            searchedfighterindex = bsearchusers(fighters, nametofind, indexlow, indexhigh)
            MsgBox(searchedfighterindex)

            'adds fighter to a new list to be shown in search alone
            If searchedfighterindex <> -1 Then
                Dim searchedfighterlist As New List(Of fightermanagement)
                searchedfighterlist.Clear()
                searchedfighterlist.Add(fighters(searchedfighterindex))
                fighterlist = searchedfighterlist

            End If

        End If
        Debug.WriteLine(nametofind)

        updatebuttons(fighterlist)

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


        fighterlist = sortedfighters

        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
        Dim endIndex As Integer = Math.Min(startIndex + count, sortedfighters.Count)


        If cmbwins.SelectedItem IsNot Nothing Then
            lblsorted.Text = cmbwins.SelectedItem.ToString()
        End If

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
            btn.Height = 100
            btn.BackColor = Color.White
            btn.TextAlign = ContentAlignment.MiddleCenter
            btn.Font = New Font("Clash Display", 9, FontStyle.Regular)

            btn.Text = sortedfighters(i).Name & vbCrLf & sortedfighters(i).Wins & "/" & sortedfighters(i).Losses & "/" & sortedfighters(i).Draws
            btn.Visible = True

            btn.Visible = True
            btn.Tag = i

            AddHandler btn.Click, AddressOf Button_Click

            FlowLayoutPanel1.Controls.Add(btn)


        Next

        'creates a load more button if needed
        If endIndex < sortedfighters.Count Then


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
                                              updatebuttons(sortedfighters, endIndex)
                                          End Sub
            FlowLayoutPanel1.Controls.Add(btnloadmore)


        End If

    End Sub


    'when a button in the flow control panel is picked (fighter edition
    Private Sub Button_Click(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag of button which is the fighters place in the list
        Dim fighterIndex As Integer = Convert.ToInt32(clickedButton.Tag)

        'need to find a way to optimise / reuse code


        'finds current fighter
        Dim currentfighter As fightermanagement = fighterlist(fighterIndex)
        'sends current fighter data over to the current fighter form
        Dim fighterForm As New current_fighter_form(currentfighter)



        childform(fighterForm)

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim fighterlist As List(Of fightermanagement) = functions.ReadFightersFromJson()
        updatebuttons(fighterlist)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbweightclass.SelectedIndexChanged
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub
    Function checkfilters(fighterlist As List(Of fightermanagement))

        Dim selectedstance As String = ""
        Dim selectedWeightClass As String = ""


        Dim filteredFighters As List(Of fightermanagement) = fighterlist

        If cmbweightclass.SelectedItem IsNot Nothing Then
            selectedWeightClass = cmbweightclass.SelectedItem.ToString()
        End If

        If cmbstance.SelectedItem IsNot Nothing Then
            selectedstance = cmbstance.SelectedItem.ToString()
        End If


        ' Filter fighters based on the selected weight class

        If selectedWeightClass <> "All" And selectedWeightClass <> "" Then
            filteredFighters = filteredFighters.Where(Function(f) f.Weight = selectedWeightClass).ToList()
        End If



        If selectedstance <> "All" And selectedstance <> "" Then
            filteredFighters = filteredfighters.Where(Function(f) f.Stance = selectedstance).ToList()
        End If




        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = filteredFighters.Count - 1
        Dim sortwins As Integer = cmbwins.SelectedIndex



        filteredFighters = Quicksort(filteredFighters, indexlow, indexhigh, sortwins)





        Return filteredFighters


    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub



    Private Sub cmbstance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstance.SelectedIndexChanged
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbsort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbwins.SelectedIndexChanged


        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)

    End Sub

    Public Function bsearchonename(fighterlist As List(Of fightermanagement), nametofind As String, indexlow As Integer, indexhigh As Integer, decision As Integer) As List(Of fightermanagement)



        If indexlow > indexhigh Then
            Return New List(Of fightermanagement)()
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2
        Dim currentfighter As fightermanagement = fighterlist(midpoint)

        'gets event number
        Dim fightname As String = parsename(currentfighter.Name, decision)


        If String.Compare(fightname, nametofind) < 0 Then
            Return bsearchonename(fighterlist, nametofind, midpoint + 1, indexhigh, decision)
        ElseIf String.Compare(fightname, nametofind) > 0 Then
            Return bsearchonename(fighterlist, nametofind, indexlow, midpoint - 1, decision)
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

    Private Sub pnlcurrentfighter_Paint(sender As Object, e As PaintEventArgs) Handles pnlcurrentfighter.Paint

    End Sub
    Sub childform(ByVal panel As Form)
        pnlcurrentfighter.Controls.Clear()
        panel.TopLevel = False
        pnlcurrentfighter.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub lblsorted_Click(sender As Object, e As EventArgs) Handles lblsorted.Click

    End Sub
End Class
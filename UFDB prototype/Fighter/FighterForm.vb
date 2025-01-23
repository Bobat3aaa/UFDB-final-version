Imports Newtonsoft.Json
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class FighterForm


    Private fighterlist As List(Of fightermanagement)
    Private Sub btnsort_Click(sender As Object, e As EventArgs)

    End Sub
    'quicksort used to sort fighters
    Function Quicksort(fighters As List(Of fightermanagement), indexlow As Integer, indexhigh As Integer, sortwins As Integer) As List(Of fightermanagement)

        Dim pivot As String
        Dim templow As Integer = indexlow
        Dim temphigh As Integer = indexhigh



        If sortwins = 0 Then

            pivot = fighters(Int((indexlow + indexhigh) / 2)).Name

            While templow <= temphigh
                While String.Compare(fighters(templow).Name, pivot) < 0
                    templow += 1
                End While

                While String.Compare(fighters(temphigh).Name, pivot) > 0
                    temphigh -= 1
                End While

                If templow <= temphigh Then
                    Dim tempfighter As fightermanagement = fighters(templow)
                    fighters(templow) = fighters(temphigh)
                    fighters(temphigh) = tempfighter
                    templow += 1
                    temphigh -= 1
                End If
            End While

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
                        Dim tempfighter As fightermanagement = fighters(templow)
                        fighters(templow) = fighters(temphigh)
                        fighters(temphigh) = tempfighter
                    End If
                    templow += 1
                    temphigh -= 1
                End If

            End While

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

        If indexlow <= temphigh Then
            Quicksort(fighters, indexlow, temphigh, sortwins)
        End If

        If templow < indexhigh Then
            Quicksort(fighters, templow, indexhigh, sortwins)
        End If

        Return fighters
    End Function


    Function ReadfightersFromFile() As List(Of fightermanagement)
        If Not File.Exists("fighters_page.json") Then
            Return New List(Of fightermanagement)
        End If
        Dim json As String = File.ReadAllText("fighters_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of fightermanagement))(json)
    End Function




    Private Sub Fighterform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'makes sure the filters are all set to 0 to start, will be more in future


        If cmbstance.Items.Count > 0 Then cmbstance.SelectedIndex = 0
        If cmbweightclass.Items.Count > 0 Then cmbweightclass.SelectedIndex = 0
        cmbwins.SelectedIndex = 0






        'sorts fighters and saves to file
        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1
        Dim sortwins As Integer = 0



        Dim sortedfighters As List(Of fightermanagement) = Quicksort(fighters, indexlow, indexhigh, sortwins)
        fighterlist = sortedfighters
        SaveToJsonFile(sortedfighters)

        'allows scroling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True


        updatebuttons(sortedfighters)


    End Sub
    Private Sub SaveToJsonFile(sortedfighters As List(Of fightermanagement))
        Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click


        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
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


        sortedfighters = checkfilters(sortedfighters)
        fighterlist = sortedfighters

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
        Dim fighterlist As List(Of fightermanagement) = ReadfightersFromFile()
        updatebuttons(fighterlist)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbweightclass.SelectedIndexChanged
        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub
    Function checkfilters(fighterlist As List(Of fightermanagement))

        Dim selectedstance As String
        Dim selectedWeightClass As String
        Dim selectedliked As Integer

        If cmbweightclass.SelectedItem IsNot Nothing Then
            selectedWeightClass = cmbweightclass.SelectedItem.ToString()
        End If

        If cmbstance.SelectedItem IsNot Nothing Then
            selectedstance = cmbstance.SelectedItem.ToString()
        End If


        ' Filter fighters based on the selected weight class
        Dim filteredFighters As List(Of fightermanagement) = fighterlist
        If selectedWeightClass <> "All" Then
            filteredFighters = fighterlist.Where(Function(f) f.Weight = selectedWeightClass).ToList()
        End If



        If selectedstance <> "All" Then
            filteredFighters = fighterlist.Where(Function(f) f.Stance = selectedstance).ToList()
        End If
        Return filteredFighters


    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Home.Click
        Form1.Show()
        Me.Close()
    End Sub



    Private Sub cmbstance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstance.SelectedIndexChanged
        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbsort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbwins.SelectedIndexChanged
        Dim sortwins As Integer = cmbwins.SelectedIndex

        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1




        Dim sortedfighters As List(Of fightermanagement) = Quicksort(fighters, indexlow, indexhigh, sortwins)





        updatebuttons(sortedfighters)
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
End Class
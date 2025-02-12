Imports Newtonsoft.Json

Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class currentranking

    Private currentfighterlist As List(Of fightermanagement)
    Private rankedfighterlist As New List(Of fighterranking)

    Private Sub currentranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'make search work



        'sorts fighters and saves to file
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1


        Dim fighterlistsorted As List(Of fightermanagement) = Quicksort(fighters, indexlow, indexhigh)
        currentfighterlist = fighterlistsorted

        functions.SaveToFighterJson(currentfighterlist)

        'allows scroling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True


        If cmbweightclass.Items.Count > 0 Then
            cmbweightclass.SelectedIndex = 0
        End If

        updatebuttons(fighterlistsorted)

        Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson



        Dim newranking As New ranking
        newranking.RankingID = GetNextranklistID(ranklist)

    End Sub







    Function GetNextranklistID(ranklist As List(Of ranking)) As Integer
        If ranklist.Count = 0 Then
            Return 1
        End If

        Return ranklist.Max(Function(r) r.RankingID) + 1
    End Function



    Function makenewfighterrank(rankingid As Integer, fighterid As String, rank As Integer)
        Dim newfighterrank As New fighterranking
        newfighterrank.FighterID = fighterid
        newfighterrank.RankingID = rankingid
        newfighterrank.Rank = rank
        Return newfighterrank
    End Function





    Sub updatebuttons(fighterlist As List(Of fightermanagement), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()



        currentfighterlist = fighterlist

        If fighterlist Is Nothing Then

        Else

            'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
            Dim endIndex As Integer
            endIndex = Math.Min(startIndex + count, fighterlist.Count)



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


            'creates 50 buttons
            For i = startIndex To endIndex - 1


                Dim btnfighter As New Button
                btnfighter.Width = 100
                btnfighter.Height = 50
                btnfighter.BackColor = Color.White
                btnfighter.TextAlign = ContentAlignment.MiddleCenter

                btnfighter.Text = fighterlist(i).Name
                btnfighter.Visible = True
                btnfighter.Tag = i
                currentfighterlist = fighterlist
                AddHandler btnfighter.Click, AddressOf Button_Click_currentranking

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
                AddHandler btnloadmore.Click, Sub()
                                                  updatebuttons(fighterlist, endIndex)
                                              End Sub
                FlowLayoutPanel1.Controls.Add(btnloadmore)


            End If
        End If
    End Sub


    'when a button in the flow control panel is picked (ranking edition)
    Private Sub Button_Click_currentranking(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag of button which is the fighters place in the list
        Dim fighterIndex As Integer = Convert.ToInt32(clickedButton.Tag)

        'need to find a way to optimise / reuse code

        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1


        Dim fighterlistsorted As List(Of fightermanagement) = Quicksort(fighters, indexlow, indexhigh)

        If cmbchangerank.SelectedItem > 0 And cmbchangerank.SelectedItem < 11 Then

            'finds current fighter
            Dim currentfighter As fightermanagement = currentfighterlist(fighterIndex)
            MsgBox(currentfighter.Name)
            Dim currentrank As Integer = currentrankfinder()

            Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson
            Dim currentrankid As Integer = GetNextranklistID(ranklist)
            Dim fighterrank As New fighterranking
            fighterrank = makenewfighterrank(currentrankid, currentfighter.FighterId, currentrank)



            Dim samerank As Boolean = rankedfighterlist.Any(Function(rf) rf.Rank = fighterrank.Rank AndAlso rf.RankingID = fighterrank.RankingID)


            If samerank = True Then
                Dim ranktoremove As fighterranking = rankedfighterlist.FirstOrDefault(Function(rf) rf.Rank = fighterrank.Rank AndAlso rf.RankingID = fighterrank.RankingID)
                rankedfighterlist.Remove(ranktoremove)
            End If
            Debug.WriteLine(fighterrank.FighterID)
            rankedfighterlist.Add(fighterrank)
            updatetitles(fighterrank, currentfighter)
            Debug.WriteLine("worked")
        Else
            MsgBox("please add a rank!")
        End If


    End Sub
    Function checkfilters(fighterlist As List(Of fightermanagement))

        Dim selectedWeightClass As String = ""

        If cmbweightclass.SelectedItem IsNot Nothing Then
            selectedWeightClass = cmbweightclass.SelectedItem.ToString()
        End If

        ' Filter fighters based on the selected weight class



        Dim fighterlistfiltered As List(Of fightermanagement) = fighterlist
        Debug.WriteLine(fighterlistfiltered.Count)
        If selectedWeightClass <> "All" Then
            fighterlistfiltered = fighterlist.Where(Function(f) f.Weight = selectedWeightClass).ToList()
        End If
        Debug.WriteLine(fighterlistfiltered.Count)
        Return fighterlistfiltered
    End Function



    Function Quicksort(fighterlist As List(Of fightermanagement), indexlow As Integer, indexhigh As Integer) As List(Of fightermanagement)

        Dim pivot As String
        Dim templow As Integer = indexlow
        Dim temphigh As Integer = indexhigh





        pivot = fighterlist(Int((indexlow + indexhigh) / 2)).Name

        While templow <= temphigh
            While String.Compare(fighterlist(templow).Name, pivot) < 0
                templow += 1
            End While

            While String.Compare(fighterlist(temphigh).Name, pivot) > 0
                temphigh -= 1
            End While

            If templow <= temphigh Then
                Dim tempfighter As fightermanagement = fighterlist(templow)
                fighterlist(templow) = fighterlist(temphigh)
                fighterlist(temphigh) = tempfighter
                templow += 1
                temphigh -= 1
            End If
        End While



        If indexlow <= temphigh Then
            Quicksort(fighterlist, indexlow, temphigh)
        End If

        If templow < indexhigh Then
            Quicksort(fighterlist, templow, indexhigh)
        End If

        Return fighterlist
    End Function

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbchangerank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbchangerank.SelectedIndexChanged
        Dim currentrank As Integer
        currentrank = currentrankfinder()
        Debug.WriteLine(currentrank)
    End Sub

    Function currentrankfinder()
        Dim currentrank As Integer
        currentrank = cmbchangerank.SelectedItem
        Return currentrank
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submitranking()


    End Sub


    Sub submitranking()
        If String.IsNullOrEmpty(txtrankingname.Text) Then
            MsgBox("please add a list name!")
        ElseIf String.IsNullOrEmpty(txtrankingdesc.Text) Then
            MsgBox("Please add a list description")

        Else


            Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson

            Dim newranking As New ranking
            newranking.RankingID = GetNextranklistID(ranklist)
            newranking.UserID = loginform.currentuserid
            newranking.Rankingdesc = txtrankingdesc.Text

            newranking.RankingName = txtrankingname.Text
            newranking.Rankingdatemade = Today


            ranklist.Add(newranking)
            functions.SaveToRanklistJson(ranklist)

            Dim jsonfighterrankinglist As List(Of fighterranking) = functions.ReadFighterranksFromFile
            For i = 0 To rankedfighterlist.Count - 1
                jsonfighterrankinglist.Add(rankedfighterlist(i))
            Next
            functions.SaveToFighterranksJson(jsonfighterrankinglist)
            MsgBox("new list created!")
        End If
    End Sub

    Sub updatetitles(fighterrank, currentfighter)
        Dim fighterpanel As Panel = (fighterpanel)
        For i = 1 To 10
            Dim ranklbl As Label = (Panel1.Controls("lblfighter" & i))
            Debug.WriteLine(ranklbl)
            If ranklbl IsNot Nothing And i = fighterrank.rank Then

                ranklbl.Text = currentfighter.name
            End If


        Next



    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub cmbweightclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbweightclass.SelectedIndexChanged
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim fighterlist As List(Of fightermanagement) = checkfilters(fighters)
        updatebuttons(fighterlist)
    End Sub
    Function bsearchusers(fighterlist As List(Of fightermanagement), nametofind As String, indexlow As Integer, indexhigh As Integer) As List(Of fightermanagement)

        'binary search, returns midpoint which is place in list
        If indexlow > indexhigh Then
            Return Nothing
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2

        If String.Compare(fighterlist(midpoint).Name, nametofind) < 0 Then
            Return bsearchusers(fighterlist, nametofind, midpoint + 1, indexhigh)
        ElseIf String.Compare(fighterlist(midpoint).Name, nametofind) > 0 Then
            Return bsearchusers(fighterlist, nametofind, indexlow, midpoint - 1)
        Else


            'once binary search is done, finds all the fights with event number
            Dim searchedfighters As New List(Of fightermanagement)()
            searchedfighters.Add(fighterlist(midpoint))


            Dim left As Integer = midpoint - 1

            While left >= indexlow
                Dim leftfightername As String = fighterlist(left).Name
                If leftfightername = nametofind Then
                    searchedfighters.Add(fighterlist(left))
                    left -= 1
                ElseIf leftfightername <> nametofind Then
                    Exit While
                End If

            End While

            Dim right As Integer = midpoint + 1


            While right <= indexhigh
                Dim rightfightername As String = fighterlist(right).Name
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
        currentfighterlist = functions.ReadFightersFromJson()
        Dim low As Integer = 0
        Dim high As Integer = currentfighterlist.Count - 1
        Dim searchedfighters As List(Of fightermanagement) = bsearchusers(currentfighterlist, txtfname.Text, low, high)
        searchedfighters = checkfilters(searchedfighters)
        updatebuttons(searchedfighters)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblfighter4_Click(sender As Object, e As EventArgs) Handles lblfighter4.Click

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        currentfighterlist = functions.ReadFightersFromJson()
        updatebuttons(currentfighterlist)
    End Sub
End Class
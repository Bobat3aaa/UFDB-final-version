Imports Newtonsoft.Json

Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class currentranking

    Dim fighterlist As List(Of fightermanagement)
    Dim rankedfighterlist As New List(Of fighterranking)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub currentranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'make search work



        If cmbweightclass.Items.Count > 0 Then cmbweightclass.SelectedIndex = 0

        'sorts fighters and saves to file
        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1
        Dim sortwins As Integer = 0
        Dim sortloss As Integer = 0

        Dim sortedfighters As List(Of fightermanagement) = Quicksort(fighters, indexlow, indexhigh)
        fighterlist = sortedfighters
        SaveToJsonFile(sortedfighters)

        'allows scroling for flow panel
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True

        Debug.WriteLine(sortedfighters(1).Name)
        updatebuttons(sortedfighters)

        Dim ranklist As List(Of ranking) = ReadranklistsFromFile()



        Dim newranking As New ranking
        newranking.RankingID = GetNextranklistID(ranklist)

    End Sub





    Sub Adduser(newusername, newpassword, newage, newemail)


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





    Sub updatebuttons(sortedfighters As List(Of fightermanagement), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()


        sortedfighters = checkfilters(sortedfighters)

        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
        Dim endIndex As Integer
        endIndex = Math.Min(startIndex + count, sortedfighters.Count)



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
            fighterlist = sortedfighters
            AddHandler btn.Click, AddressOf Button_Click_currentranking

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


    'when a button in the flow control panel is picked (ranking edition)
    Private Sub Button_Click_currentranking(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag of button which is the fighters place in the list
        Dim fighterIndex As Integer = Convert.ToInt32(clickedButton.Tag)

        'need to find a way to optimise / reuse code

        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1


        Dim sortedfighters As List(Of fightermanagement) = Quicksort(fighters, indexlow, indexhigh)

        If cmbchangerank.SelectedItem > 0 And cmbchangerank.SelectedItem < 11 Then

            'finds current fighter
            Dim currentfighter As fightermanagement = fighterlist(fighterIndex)
            MsgBox(currentfighter.Name)
            Dim currentrank As Integer = currentrankfinder()

            Dim ranklist As List(Of ranking) = ReadranklistsFromFile()
            Dim currentrankid As Integer = GetNextranklistID(ranklist)
            Dim fighterrank As New fighterranking
            fighterrank = makenewfighterrank(currentrankid, currentfighter.FighterId, currentrank)



            Dim samerank As Boolean = rankedfighterlist.Any(Function(rf) rf.Rank = fighterrank.Rank AndAlso rf.RankingID = fighterrank.RankingID)


            If samerank = True Then
                Dim ranktoremove As fighterranking = rankedfighterlist.FirstOrDefault(Function(rf) rf.Rank = fighterrank.Rank AndAlso rf.RankingID = fighterrank.RankingID)
                rankedfighterlist.Remove(ranktoremove)
            End If

            rankedfighterlist.Add(fighterrank)
            updatetitles(fighterrank, currentfighter)
        Else
            MsgBox("please add a rank!")
        End If


    End Sub
    Function checkfilters(fighterlist As List(Of fightermanagement))

        Dim selectedWeightClass As String

        If cmbweightclass.SelectedItem IsNot Nothing Then
            selectedWeightClass = cmbweightclass.SelectedItem.ToString()
        End If

        ' Filter fighters based on the selected weight class
        Dim filteredFighters As List(Of fightermanagement) = fighterlist
        If selectedWeightClass <> "All" Then
            filteredFighters = fighterlist.Where(Function(f) f.Weight = selectedWeightClass).ToList()
        End If
        Return filteredFighters
    End Function
    Function ReadfightersFromFile() As List(Of fightermanagement)
        If Not File.Exists("fighters_page.json") Then
            Return New List(Of fightermanagement)
        End If
        Dim json As String = File.ReadAllText("fighters_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of fightermanagement))(json)
    End Function
    Private Sub SaveToJsonFile(sortedfighters As List(Of fightermanagement))
        Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub


    Function Quicksort(fighters As List(Of fightermanagement), indexlow As Integer, indexhigh As Integer) As List(Of fightermanagement)

        Dim pivot As String
        Dim templow As Integer = indexlow
        Dim temphigh As Integer = indexhigh





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



        If indexlow <= temphigh Then
            Quicksort(fighters, indexlow, temphigh)
        End If

        If templow < indexhigh Then
            Quicksort(fighters, templow, indexhigh)
        End If

        Return fighters
    End Function

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

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

    Function ReadranklistsFromFile() As List(Of ranking)
        If Not File.Exists("ranklists.json") Then
            Return New List(Of ranking)
        End If
        Dim json As String = File.ReadAllText("ranklists.json")
        Return JsonConvert.DeserializeObject(Of List(Of ranking))(json)
    End Function
    Private Sub SaveToranklistJson(rankedlists As List(Of ranking))
        Dim json As String = JsonConvert.SerializeObject(rankedlists, Formatting.Indented)
        Dim filePath As String = $"ranklists.json"
        File.WriteAllText(filePath, json)

    End Sub

    Function ReadfighterranksFromFile() As List(Of fighterranking)
        If Not File.Exists("fighterranks.json") Then
            Return New List(Of fighterranking)
        End If
        Dim json As String = File.ReadAllText("fighterranks.json")
        Return JsonConvert.DeserializeObject(Of List(Of fighterranking))(json)
    End Function

    Private Sub SaveTofighterranksJson(rankingfighterlist As List(Of fighterranking))
        Dim json As String = JsonConvert.SerializeObject(rankingfighterlist, Formatting.Indented)
        Dim filePath As String = $"fighterranks.json"
        File.WriteAllText(filePath, json)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Submitranking()


    End Sub


    Sub submitranking()
        If String.IsNullOrEmpty(txtrankingname.Text) Then
            MsgBox("please add a list name!")
        ElseIf String.IsNullOrEmpty(txtrankingdesc.Text) Then
            MsgBox("Please add a list description")

        Else


            Dim ranklist As List(Of ranking) = ReadranklistsFromFile()

            Dim newranking As New ranking
            newranking.RankingID = GetNextranklistID(ranklist)
            newranking.UserID = loginform.currentuserid
            newranking.Rankingdesc = txtrankingdesc.Text

            newranking.RankingName = txtrankingname.Text
            newranking.Rankingdatemade = Today


            ranklist.Add(newranking)
            SaveToranklistJson(ranklist)

            Dim jsonfighterrankinglist As List(Of fighterranking) = ReadfighterranksFromFile()
            For i = 0 To rankedfighterlist.Count - 1
                jsonfighterrankinglist.Add(rankedfighterlist(i))
            Next
            SaveTofighterranksJson(jsonfighterrankinglist)
            MsgBox("new list created!")
        End If
    End Sub

    Sub updatetitles(fighterrank, currentfighter)

        For i = 1 To 10
            Dim ranklbl As Label = Me.Controls("lblfighter" & i)
            If ranklbl IsNot Nothing And i = fighterrank.rank Then

                ranklbl.Text = currentfighter.name
            End If


        Next



    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged

    End Sub
End Class
Imports Newtonsoft.Json
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class oddsgeneratorform


    Private fighter1 As fightermanagement
    Private fighter2 As fightermanagement
    Private fighter1index As Integer = 0
    Private fighter2index As Integer = 1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblfighter2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblfighter1.Click

    End Sub

    Private Sub oddsgeneratorform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sorts fighters and saves to file

        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1

        Dim sortedfighters As List(Of fightermanagement) = Quicksort(fighters, indexlow, indexhigh)
        functions.SaveToFighterJson(sortedfighters)
        fighter1 = sortedfighters(0)
        fighter2 = sortedfighters(1)
        updatefighter1(fighter1)
        updatefighter2(fighter2)


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

        If indexlow < temphigh Then
            Quicksort(fighters, indexlow, temphigh)
        End If

        If templow < indexhigh Then
            Quicksort(fighters, templow, indexhigh)
        End If

        Return fighters
    End Function

    'reads fighters from the json file
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

    Private Sub btnsearch1_Click(sender As Object, e As EventArgs) Handles btnsearch1.Click
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1



        Dim nametofind As String = (txtfighter1fname.Text) + " " + (txtfighter1lname.Text)
        Dim searchedfighterindex As Integer = bsearchusers(fighters, nametofind, indexlow, indexhigh)
        If searchedfighterindex <> -1 Then
            fighter1 = fighters(searchedfighterindex)
            fighter1index = searchedfighterindex
            updatefighter1(fighter1)
        End If


        'adds fighter to a new list to be shown in search alone

    End Sub

    Private Sub btnsearch2_Click(sender As Object, e As EventArgs) Handles btnsearch2.Click
        Dim fighters As List(Of fightermanagement) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1



        Dim nametofind As String = (txtfighter2fname.Text) + " " + (txtfighter2lname.Text)
        Dim searchedfighterindex As Integer = bsearchusers(fighters, nametofind, indexlow, indexhigh)
        If searchedfighterindex <> -1 Then
            fighter2 = fighters(searchedfighterindex)
            fighter2index = searchedfighterindex
            updatefighter2(fighter2)
        End If




    End Sub

    Sub updatefighter1(fighter As fightermanagement)
        txtfighter1stats.Text = fighter.Name & vbCrLf & " " & "height: " & fighter.Height & vbCrLf & "  " & vbCrLf & "reach: " & fighter.Reach & vbCrLf & "record: " & fighter.Wins & "/" & fighter.Losses & "/" & fighter.Draws

    End Sub

    Sub updatefighter2(fighter As fightermanagement)
        txtfighter2stats.Text = fighter.Name & vbCrLf & " " & "height: " & fighter.Height & vbCrLf & "  " & vbCrLf & "reach: " & fighter.Reach & vbCrLf & "record: " & fighter.Wins & "/" & fighter.Losses & "/" & fighter.Draws

    End Sub

    Private Sub btnback1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)
        txtfighter1stats.Text = ""
        txtfighter1fname.Text = ""
        txtfighter1lname.Text = ""

        fighter1 = Nothing

    End Sub

    Private Sub btnclear2_Click(sender As Object, e As EventArgs)
        txtfighter2stats.Text = ""
        txtfighter2fname.Text = ""
        txtfighter2lname.Text = ""
        fighter2 = Nothing
    End Sub

    Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        If fighter1 IsNot Nothing AndAlso fighter2 IsNot Nothing Then

            Dim fighterpair As Double() = generateodds(fighter1, fighter2)
            updatewinner(fighterpair)
        ElseIf fighter1 Is Nothing And fighter2 IsNot Nothing Then
            MsgBox("no fighter 1")

        ElseIf fighter2 Is Nothing And fighter1 IsNot Nothing Then
            MsgBox("no fighter 2")

        ElseIf fighter1 Is Nothing And fighter2 Is Nothing Then
            MsgBox("no fighters")
        End If

    End Sub

    Function generateodds(fighter1 As fightermanagement, fighter2 As fightermanagement)

        Dim fighter1win As Integer = fighter1.Wins
        Dim fighter2win As Integer = fighter2.Wins

        Dim fighter1other As Integer = fighter1.Losses + fighter1.Draws
        Dim fighter2other As Integer = fighter2.Losses + fighter2.Draws


        Dim fighter1winrate As Double
        Dim fighter2winrate As Double

        Dim fighter1odds As Double
        Dim fighter2odds As Double

        Dim fighter1weight As Integer? = ParseWeight(fighter1.Weight)
        Dim fighter2weight As Integer? = ParseWeight(fighter2.Weight)
        'fighters win rate
        fighter1winrate = (fighter1win / (fighter1other + fighter1win)) * 100 * (fighter1weight * 0.015)
        fighter2winrate = (fighter2win / (fighter2other + fighter2win)) * 100 * (fighter2weight * 0.015)

        MsgBox(fighter1winrate)
        MsgBox(fighter2winrate)


        'fighter odds

        fighter1odds = (fighter1winrate / ((fighter1winrate + fighter2winrate)) * 100)
        fighter2odds = (fighter2winrate / ((fighter1winrate + fighter2winrate)) * 100)
        MsgBox(fighter1odds)
        Dim fighteroddsarray(1) As Double
        fighteroddsarray(0) = fighter1odds
        fighteroddsarray(1) = fighter2odds


        Return fighteroddsarray

    End Function

    Function ParseWeight(weightString As String) As Integer?

        'finds a digit
        Dim regex As New Regex("\d+", RegexOptions.IgnoreCase)
        Dim match As Match = regex.Match(weightString)

        If match.Success Then

            Return Integer.Parse(match.Value)
        Else

            Return Nothing
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnback2.Click
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        If fighter2index > 0 Then
            fighter2index -= 1
            fighter2 = (fighters(fighter2index))
            updatefighter2(fighter2)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnext2.Click
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        If fighter2index < fighters.Count - 1 Then
            fighter2index += 1
            fighter2 = (fighters(fighter2index))
            updatefighter2(fighter2)

        End If
    End Sub

    Sub updatewinner(oddpair)

        txtchance1.Text = oddpair(0)
        txtchance2.Text = oddpair(1)

        If oddpair(0) > oddpair(1) Then
            txtwinner.Text = (fighter1.Name)

        ElseIf oddpair(0) < oddpair(1) Then
            txtwinner.Text = (fighter2.Name)
        Else
            txtwinner.Text = ("draw")

        End If

    End Sub

    Private Sub txtwinner_TextChanged(sender As Object, e As EventArgs) Handles txtwinner.TextChanged

    End Sub

    Private Sub btnnext1_Click(sender As Object, e As EventArgs) Handles btnnext1.Click
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        If fighter1index < fighters.Count - 1 Then
            fighter1index += 1
            fighter1 = (fighters(fighter1index))
            updatefighter1(fighter1)

        End If
    End Sub

    Private Sub btnback1_Click_1(sender As Object, e As EventArgs) Handles btnback1.Click
        Dim fighters As List(Of fightermanagement) = functions.ReadFightersFromJson()
        If fighter1index > 0 Then
            fighter1index -= 1
            fighter1 = (fighters(fighter1index))
            updatefighter1(fighter1)

        End If
    End Sub

    Private Sub txtfighter1stats_TextChanged(sender As Object, e As EventArgs) Handles txtfighter1stats.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
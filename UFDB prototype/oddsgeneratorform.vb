Imports Newtonsoft.Json
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class oddsgeneratorform

    Private fighter1 As Fighter

    Private fighter2 As Fighter

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblfighter2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblfighter1.Click

    End Sub

    Private Sub oddsgeneratorform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sorts fighters and saves to file

        Dim fighters As List(Of Fighter) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1

        Dim sortedfighters As List(Of Fighter) = Quicksort(fighters, indexlow, indexhigh)
        SaveToJsonFile(sortedfighters)


    End Sub

    Function Quicksort(fighters As List(Of Fighter), indexlow As Integer, indexhigh As Integer) As List(Of Fighter)

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
                Dim tempfighter As Fighter = fighters(templow)
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
    Function ReadfightersFromFile() As List(Of Fighter)
        If Not File.Exists("fighters_page.json") Then
            Return New List(Of Fighter)
        End If
        Dim json As String = File.ReadAllText("fighters_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of Fighter))(json)
    End Function
    Private Sub SaveToJsonFile(sortedfighters As List(Of Fighter))
        Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub
    Function bsearchusers(fighterlist As List(Of Fighter), nametofind As String, indexlow As Integer, indexhigh As Integer)

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
        Dim fighters As List(Of Fighter) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1



        Dim nametofind As String = (txtfighter1fname.Text) + " " + (txtfighter1lname.Text)
        Dim searchedfighterindex As Integer = bsearchusers(fighters, nametofind, indexlow, indexhigh)



        'adds fighter to a new list to be shown in search alone
        If searchedfighterindex <> -1 Then
            Dim fighterlist As New List(Of Fighter)
            fighterlist.Add(fighters(searchedfighterindex))
            updatefighter1(fighterlist(0))
            fighter1 = fighterlist(0)
        ElseIf searchedfighterindex = 1 Then
            MsgBox("Fighter not found")
        End If
    End Sub

    Private Sub btnsearch2_Click(sender As Object, e As EventArgs) Handles btnsearch2.Click
        Dim fighters As List(Of Fighter) = ReadfightersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1



        Dim nametofind As String = (txtfighter2fname.Text) + " " + (txtfighter2lname.Text)
        Dim searchedfighterindex As Integer = bsearchusers(fighters, nametofind, indexlow, indexhigh)



        'adds fighter to a new list to be shown in search alone
        If searchedfighterindex <> -1 Then
            Dim fighterlist As New List(Of Fighter)
            fighterlist.Add(fighters(searchedfighterindex))
            updatefighter2(fighterlist(0))
            fighter2 = fighterlist(0)
        ElseIf searchedfighterindex = 1 Then
            MsgBox("Fighter not found")
        End If



    End Sub

    Sub updatefighter1(fighter As Fighter)
        txtfighter1stats.Text = fighter.Name & vbCrLf & " " & "height: " & fighter.Height & vbCrLf & "  " & vbCrLf & "reach: " & fighter.Reach & vbCrLf & "record: " & fighter.Wins & "/" & fighter.Losses & "/" & fighter.Draws

    End Sub

    Sub updatefighter2(fighter As Fighter)
        txtfighter2stats.Text = fighter.Name & vbCrLf & " " & "height: " & fighter.Height & vbCrLf & "  " & vbCrLf & "reach: " & fighter.Reach & vbCrLf & "record: " & fighter.Wins & "/" & fighter.Losses & "/" & fighter.Draws

    End Sub

    Private Sub btnback1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear1.Click
        txtfighter1stats.Text = ""
        txtfighter1fname.Text = ""
        txtfighter1lname.Text = ""

        fighter1 = Nothing

    End Sub

    Private Sub btnclear2_Click(sender As Object, e As EventArgs) Handles btnclear2.Click
        txtfighter2stats.Text = ""
        txtfighter2fname.Text = ""
        txtfighter2lname.Text = ""
        fighter2 = Nothing
    End Sub

    Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        If fighter1 IsNot Nothing AndAlso fighter2 IsNot Nothing Then
            Dim oddsform As New currentpredictionform
            oddsform.fighter1() = fighter1
            oddsform.fighter2() = fighter2
            oddsform.Show()
            Me.Hide()
        ElseIf fighter1 Is Nothing And fighter2 IsNot Nothing Then
            MsgBox("no fighter 1")

        ElseIf fighter2 Is Nothing And fighter1 IsNot Nothing Then
            MsgBox("no fighter 2")

        ElseIf fighter1 Is Nothing And fighter2 Is Nothing Then
            MsgBox("no fighters")
        End If

    End Sub
End Class
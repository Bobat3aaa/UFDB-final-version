Imports Newtonsoft.Json
Imports System.IO

Public Class currentFightForm
    Public Property currentfight As Fight

    ' Constructor that accepts a Fight object
    Public Sub New(fight As Fight)
        InitializeComponent()
        Me.currentfight = fight
        lblfight.Text = ((currentfight.fighter1) + " VS " + (currentfight.fighter2))
        lblevent.Text = currentfight.event_name
        lblfighter1.Text = currentfight.fighter1
        lblfighter2.Text = currentfight.fighter2
        lbllocation.Text = currentfight.location
        lbldate.Text = currentfight.date

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        fight_form.Show()
        Me.Close()
    End Sub

    Private Sub currentFightForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fighterlist As List(Of Fighter) = ReadfightersFromFile()

        Dim fighter1 As Fighter = findfighter1(fighterlist)
        Dim fighter2 As Fighter = findfighter2(fighterlist)
        MsgBox(fighter1.Weight)

        lblheight1.Text = ("Height: " & fighter1.Height)
        lblweight1.Text = "Weight: " & fighter1.Weight
        lblreach1.Text = "Reach: " & fighter1.Reach

        lblrecord1.Text = String.Format("Record: {0}/ {1}/ {2}",
                                     fighter1.Wins, fighter1.Losses, fighter1.Draws)

        lblheight2.Text = "Height: " & fighter2.Height
        lblweight2.Text = "Weight: " & fighter2.Weight
        lblreach2.Text = "Reach: " & fighter2.Reach

        lblrecord2.Text = String.Format("Record: {0}/ {1}/ {2}",
                                     fighter2.Wins, fighter2.Losses, fighter2.Draws)


        If currentfight.fighter1 = currentfight.win Then
            lblfighter1.ForeColor = Color.Green
            lblfighter2.ForeColor = Color.Red
        ElseIf currentfight.fighter2 = currentfight.win Then
            lblfighter2.ForeColor = Color.Green
            lblfighter1.ForeColor = Color.Red
        Else
            lblfighter2.ForeColor = Color.Orange
            lblfighter1.ForeColor = Color.Orange
        End If

        lbldate.Text = "date: " & currentfight.date
        lblmethod.Text = "method: " & currentfight.method
        lblround.Text = "round: " & currentfight.rounds
        lblweightclass.Text = "weight class: " & currentfight.weight_class
    End Sub
    Function ReadfightersFromFile() As List(Of Fighter)
        If Not File.Exists("fighters_page.json") Then
            Return New List(Of Fighter)
        End If
        Dim json As String = File.ReadAllText("fighters_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of Fighter))(json)
    End Function
    Function findfighter1(fighterlist As List(Of Fighter))

        Dim fighterfound As Boolean = fighterlist.Any(Function(f) f.FighterId = currentfight.fighter1id)

        If fighterfound = True Then
            Dim foundfighter = fighterlist.FirstOrDefault(Function(f) f.FighterId = currentfight.fighter1id)
            Return foundfighter
        Else
            Return New Fighter
        End If

    End Function
    Function findfighter2(fighterlist As List(Of Fighter))

        Dim fighterfound As Boolean = fighterlist.Any(Function(f) f.FighterId = currentfight.fighter2id)

        If fighterfound = True Then
            Dim foundfighter = fighterlist.FirstOrDefault(Function(f) f.FighterId = currentfight.fighter2id)
            Return foundfighter
        Else
            Return New Fighter
        End If

    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblround.Click

    End Sub
End Class
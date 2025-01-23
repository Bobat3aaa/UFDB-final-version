Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles

Public Class currentpredictionform
    Public Property fighter1 As fightermanagement
    Public Property fighter2 As fightermanagement
    Private Sub currentpredictionform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oddpair As Double() = generateodds(fighter1, fighter2)
        lblfighter1odds.Text = oddpair(0)
        lblfighter2odds.Text = oddpair(1)

        If oddpair(0) > oddpair(1) Then
            lblfighter1odds.BackColor = Color.Green
            lblfighter2odds.BackColor = Color.Red
        ElseIf oddpair(0) < oddpair(1) Then
            lblfighter1odds.BackColor = Color.Red
            lblfighter2odds.BackColor = Color.Green
        Else
            lblfighter1odds.BackColor = Color.Orange
            lblfighter2odds.BackColor = Color.Orange
        End If
        lblfighter1name.Text = fighter1.Name
        lblfighter2name.Text = fighter2.Name
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

    Public Function ParseWeight(weightString As String) As Integer?

        'finds a digit
        Dim regex As New Regex("\d+", RegexOptions.IgnoreCase)
        Dim match As Match = regex.Match(weightString)

        If match.Success Then

            Return Integer.Parse(match.Value)
        Else

            Return Nothing
        End If
    End Function


End Class
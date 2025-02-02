Imports Newtonsoft.Json
Imports System.IO


Public Class current_fighter_form
    Public Property currentFighter As fightermanagement



    Public Sub New(fighter As fightermanagement)
        InitializeComponent()
        Me.currentFighter = fighter
        If loginform.currentuserid = 0 Then
            btnlike.Hide()

        End If




        Me.Text = currentFighter.Name


        lblname.Text = currentFighter.Name
        lblheight.Text = "Height: " & currentFighter.Height
        lblweight.Text = "Weight: " & currentFighter.Weight
        lblreach.Text = "Reach: " & currentFighter.Reach
        lblstance.Text = "Stance: " & currentFighter.Stance
        lbldob.Text = "Date of Birth: " & currentFighter.Dob
        lblrecord.Text = String.Format("Record: {0} Wins - {1} Losses - {2} Draws",
                                        currentFighter.Wins, currentFighter.Losses, currentFighter.Draws)
        lblSigStrLandedPerMinute.Text = "Significant Strikes Landed per Minute: " & currentFighter.SignificantStrikesLandedPerMinute
        lblSigStrLandedPct.Text = "Significant Strikes Landed Percentage: " & currentFighter.SignificantStrikesLandedPercentage & "%"
        lblSigStrAbsPerMinute.Text = "Significant Strikes Absorbed per Minute: " & currentFighter.SignificantStrikesAbsorbedPerMinute
        lblSigStrDefPct.Text = "Significant Strikes Defense Percentage: " & currentFighter.SignificantStrikesDefensePercentage & "%"
        lbltdavg.Text = "Takedown Average: " & currentFighter.TakedownAverage
        lblTdLandPct.Text = "Takedown Accuracy Percentage: " & currentFighter.TakedownAccuracyPercentage & "%"
        lblTdDefPct.Text = "Takedown Defense Percentage: " & currentFighter.TakedownDefensePercentage & "%"
        lblSubAvg.Text = "Submission Average: " & currentFighter.SubmissionAverage
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FighterForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlike.Click
        If loginform.currentuserid <> 0 Then
            Debug.WriteLine(loginform.currentuserid)
            Dim likedfighterlist As List(Of likedfighter) = functions.ReadlikedfightersFromJson


            Dim alreadyLiked As Boolean = likedfighterlist.Any(Function(lf) lf.userid = loginform.currentuserid AndAlso lf.fighterid = currentFighter.FighterId)

            Dim likedfighter As New likedfighter

            likedfighter.userid = loginform.currentuserid
            likedfighter.fighterid = currentFighter.FighterId


            If alreadyLiked = True Then
                Dim fighterToRemove = likedfighterlist.FirstOrDefault(Function(lf) lf.userid = loginform.currentuserid AndAlso lf.fighterid = currentFighter.FighterId)
                likedfighterlist.Remove(fighterToRemove)
                functions.SaveTolikedfighterJson(likedfighterlist)
                MsgBox("Unliked" & currentFighter.Name)
            Else
                likedfighterlist.Add(likedfighter)
                functions.SaveTolikedfighterJson(likedfighterlist)
                MsgBox("Liked" & currentFighter.Name)
            End If
        ElseIf loginform.currentuserid = 0 Then
            MsgBox("Please login to like an account")
        End If


    End Sub




    Private Sub current_fighter_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.chartsigstr.Series("sig strikes landed").Points.AddXY(currentFighter.Name, currentFighter.SignificantStrikesLandedPerMinute)
        Me.chartsigstr.Series("sig str taken").Points.AddXY(currentFighter.Name, currentFighter.SignificantStrikesAbsorbedPerMinute)

        Me.Charttd.Series("Takedown accuracy(%)").Points.AddXY(currentFighter.Name, currentFighter.TakedownAccuracyPercentage * 100)
        Me.Charttd.Series("Takedown defence accuracy(%)").Points.AddXY(currentFighter.Name, currentFighter.TakedownDefensePercentage * 100)
    End Sub


    Private Sub chartstr_Click(sender As Object, e As EventArgs) Handles chartsigstr.Click

    End Sub

    Private Sub lblrecord_Click(sender As Object, e As EventArgs) Handles lblrecord.Click

    End Sub
End Class

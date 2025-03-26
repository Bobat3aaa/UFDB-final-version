Imports Newtonsoft.Json
Imports System.IO


Public Class currentfighterform
    Private currentFighter As fighter



    Public Sub New(fighter As fighter)
        InitializeComponent()



        Me.currentFighter = fighter ' makes form fighter into fighter passed into it
        'hides like button if no user is logged in
        If Form1.currentuserid = 0 Then
            btnlike.Hide()

        End If



        'changes labels to fit fighter stats
        Me.Text = currentFighter.name


        lblname.Text = currentFighter.name
        lblheight.Text = "height: " & currentFighter.height
        lblweight.Text = "weight: " & currentFighter.weight
        lblreach.Text = "reach: " & currentFighter.reach
        lblstance.Text = "stance: " & currentFighter.stance
        lbldob.Text = "Date of Birth: " & currentFighter.dob
        lblrecord.Text = String.Format("Record: {0} wins - {1} losses - {2} draws",
                                        currentFighter.wins, currentFighter.losses, currentFighter.draws)
        lblSigStrLandedPerMinute.Text = "Significant Strikes Landed per Minute: " & currentFighter.sigstrikeslandedperminute
        lblSigStrLandedPct.Text = "Significant Strikes Landed Percentage: " & currentFighter.sigstrikeslandedpercentage & "%"
        lblSigStrAbsPerMinute.Text = "Significant Strikes Absorbed per Minute: " & currentFighter.sigstrikesabsorbedperminute
        lblSigStrDefPct.Text = "Significant Strikes Defense Percentage: " & currentFighter.sigstrikesdefendedpercentage & "%"
        lbltdavg.Text = "Takedown Average: " & currentFighter.takedownavg
        lblTdLandPct.Text = "Takedown Accuracy Percentage: " & currentFighter.takedownaccuracypercentage & "%"
        lblTdDefPct.Text = "Takedown Defense Percentage: " & currentFighter.takedowndefensepercentage & "%"
        lblSubAvg.Text = "Submission Average: " & currentFighter.submissionavg


        Me.chartsigstr.Series("sig strikes landed").Points.AddXY(currentFighter.name, currentFighter.sigstrikeslandedperminute)
        Me.chartsigstr.Series("sig str taken").Points.AddXY(currentFighter.name, currentFighter.sigstrikesabsorbedperminute)

        Me.Charttd.Series("Takedown accuracy(%)").Points.AddXY(currentFighter.name, currentFighter.takedownaccuracypercentage * 100)
        Me.Charttd.Series("Takedown defence accuracy(%)").Points.AddXY(currentFighter.name, currentFighter.takedowndefensepercentage * 100)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlike.Click



        ' another check to make sure a user is logged in
        If Form1.currentuserid <> 0 Then


            ' reads list of liked fighters
            Dim likedfighterlist As List(Of likedfighter) = functions.readlikedfighterjson

            'boolean variable to check if user is already liked via lambda function that checks if there is any object with the fighter and user id
            Dim alreadyLiked As Boolean = likedfighterlist.Any(Function(lf) lf.userid = Form1.currentuserid AndAlso lf.fighterid = currentFighter.fighterid)

            'constructs new liked fighter
            Dim likedfighter As New likedfighter

            likedfighter.userid = Form1.currentuserid
            likedfighter.fighterid = currentFighter.fighterid

            'if already liked, finds object to remove and saves to json
            If alreadyLiked = True Then
                Dim fightertoremove = likedfighterlist.FirstOrDefault(Function(lf) lf.userid = Form1.currentuserid AndAlso lf.fighterid = currentFighter.fighterid)
                likedfighterlist.Remove(fightertoremove)
                functions.savetolikedfighterjson(likedfighterlist)
                MsgBox("Unliked" & currentFighter.name)
            Else
                'adds liked fighter
                likedfighterlist.Add(likedfighter)
                functions.savetolikedfighterjson(likedfighterlist)
                MsgBox("Liked " & currentFighter.name)
            End If
        ElseIf form1.currentuserid = 0 Then
            MsgBox("Please login to like an account")
        End If


    End Sub

    Private Sub current_fighter_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

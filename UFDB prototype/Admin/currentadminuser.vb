Imports Newtonsoft.Json
Imports System.IO
Imports System.Net.Http

Public Class currentadminuser

    Private formswitch As Boolean = False

    Private Sub btnviewdatabase_Click(sender As Object, e As EventArgs) Handles btnviewdatabase.Click
        childform(Databaseeditor)
    End Sub


    'json editors
    Sub childform(ByVal panel As Form) 'used to embed a form within a form
        panelmain.Controls.Clear()
        panel.TopLevel = False
        panelmain.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub btnuserdetails_Click(sender As Object, e As EventArgs) Handles btnuserdetails.Click 'opens user detail
        childform(Userdetails)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        childform(APIrefresh)
    End Sub





    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim answer = MessageBox.Show("Are you sure you would like to logout?", "logout", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            formswitch = True
            Form1.currentuserid = 0
            Form1.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btneditusers.Click
        'opens user editor
        childform(Usereditor)
    End Sub

    Private Sub currentadminuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click 'returns to home
        formswitch = True
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub panelmain_Paint(sender As Object, e As PaintEventArgs) Handles panelmain.Paint

    End Sub

    Private Sub btnranking_Click(sender As Object, e As EventArgs) Handles btnranking.Click
        'open ranking search
        Dim newrankingsearch As New Rankingsearch
        childform(newrankingsearch)
    End Sub

    Private Sub btnnewranking_Click(sender As Object, e As EventArgs) Handles btnnewranking.Click
        Dim newranking As New currentranking
        childform(newranking)

    End Sub

    Private Sub btnlikedfighters_Click(sender As Object, e As EventArgs) Handles btnlikedfighters.Click
        'open liked fighter search
        Dim newlikedfightersearch As New Likedfightersearch
        childform(newlikedfightersearch)
    End Sub

    Private Sub formclose(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If formswitch = False Then
            Application.Exit()
        End If


    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated ' if a list is deleted, this will reset the lists so the deleted one wont show up
        Me.Refresh()
    End Sub

End Class
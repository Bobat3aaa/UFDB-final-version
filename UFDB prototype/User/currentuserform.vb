Imports Newtonsoft.Json
Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Policy

Public Class currentuserform
    Private formswitch As Boolean = False

    Private Sub btnranking_Click(sender As Object, e As EventArgs) Handles btnseerankings.Click
        'open ranking search
        Dim newrankingsearch As New rankingsearch
        childform(newrankingsearch)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmakeranking.Click
        'open ranking creator form
        Dim newranking As New makeranking
        childform(newranking)

    End Sub



    Sub childform(ByVal panel As Form) 'used to embed a form in form
        panelmain.Controls.Clear()
        panel.TopLevel = False
        panelmain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub current_user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlikedfighters_Click(sender As Object, e As EventArgs) Handles btnlikedfighters.Click
        'open n
        Dim newlikedfightersearch As New likedfightersearch
        childform(newlikedfightersearch)
    End Sub



    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click
        formswitch = True
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnuserdetails_Click_1(sender As Object, e As EventArgs) Handles btnuserdetails.Click
        'open user details

        childform(Userdetails)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim answer = MessageBox.Show("Are you sure you would like to logout?", "logout", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            formswitch = True
            Form1.currentuserid = 0 'resets current user id
            Form1.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub panelmain_Paint(sender As Object, e As PaintEventArgs) Handles panelmain.Paint

    End Sub

    Private Sub formclose(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If formswitch = False Then
            Application.Exit()
        End If


    End Sub

End Class
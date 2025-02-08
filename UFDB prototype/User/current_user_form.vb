Imports Newtonsoft.Json
Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Policy

Public Class current_user_form

    Private Sub btnranking_Click(sender As Object, e As EventArgs) Handles btnseerankings.Click
        childform(Rankingsearch)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmakeranking.Click
        Dim newranking As New currentranking
        childform(newranking)

    End Sub



    Sub childform(ByVal panel As Form)
        panelmain.Controls.Clear()
        panel.TopLevel = False
        panelmain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub current_user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlikedfighters_Click(sender As Object, e As EventArgs) Handles btnlikedfighters.Click
        Dim newlikedfightersearch As New Likedfightersearch
        childform(newlikedfightersearch)
    End Sub




    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnuserdetails_Click_1(sender As Object, e As EventArgs) Handles btnuserdetails.Click
        childform(Userdetails)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim answer = MessageBox.Show("Are you sure you would like to logout?", "logout", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            loginform.currentuserid = 0
            Form1.Show()
            Me.Close()

        End If
    End Sub


End Class
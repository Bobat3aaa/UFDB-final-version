
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.IO
Imports System.Drawing.Text
Imports System.Drawing

Public Class Form1



    Private Sub Fights_Click(sender As Object, e As EventArgs) Handles fights.Click
        'shows fight form and hides home form
        fight_form.Show()
        Me.Hide()
    End Sub




    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click

        'if the current user id = 0, no user has joined and it will show the login form
        If loginform.currentuserid = 0 Then

            loginform.Show()
            Me.Hide()
            'else, it will check whether the account is an admin account or not 
        ElseIf loginform.currentuserid <> 0 Then
            Dim userlist As List(Of usermanagement) = functions.ReadUsersFromJson()
            Dim currentuser As usermanagement = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
            If currentuser.Admin = True Then
                currentadminuser.Show()
                Me.Hide()
            Else
                current_user_form.Show()
                Me.Hide()
            End If




        End If




    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        'shows register form and hides home form
        register.Show()
        Me.Hide()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub fighters_Click(sender As Object, e As EventArgs) Handles Btnfighter.Click
        'shows fighter form and hides home form
        FighterForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnodds_Click(sender As Object, e As EventArgs) Handles btnodds.Click
        'shows odd generator form and hides home form
        oddsgeneratorform.Show()
        Me.Hide()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblhome.Click

    End Sub
    Private Sub formactivated(sender As Object, e As EventArgs) Handles MyBase.Activated 'changes login button text to username when form is on screen
        If loginform.currentuserid <> 0 Then
            Dim userlist As List(Of usermanagement) = functions.ReadUsersFromJson()
            Dim currentuser As usermanagement = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
            Btnlogin.Text = currentuser.username
        Else
            Btnlogin.Text = "login"
        End If
    End Sub


End Class

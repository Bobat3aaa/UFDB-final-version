
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.IO
Imports System.Drawing.Text
Imports System.Drawing

Public Class Form1



    Private Sub Fights_Click(sender As Object, e As EventArgs) Handles fights.Click

        fight_form.Show()
        Me.Hide()
    End Sub




    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click


        If loginform.currentuserid = 0 Then

            loginform.Show()
            Me.Hide()
        ElseIf loginform.currentuserid <> 0 Then
            Dim userlist As List(Of User) = functions.ReadUsersFromJson()
            Dim currentuser As User = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
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
        register.Show()
        Me.Hide()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcustomfonts()

    End Sub
    Private Sub SaveToJsonFile(allfighters As List(Of fightermanagement))
        Dim json As String = JsonConvert.SerializeObject(allfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        'MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub fighters_Click(sender As Object, e As EventArgs) Handles Btnfighter.Click
        FighterForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnodds_Click(sender As Object, e As EventArgs) Handles btnodds.Click
        oddsgeneratorform.Show()
        Me.Hide()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblhome.Click

    End Sub



End Class

Imports Newtonsoft.Json
Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Policy

Public Class current_user_form
    Private Sub btnback_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()

    End Sub

    'Private Sub current_user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    End Function

    'Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
    '    Dim answer As Integer
    '    answer = MsgBox("Are you sure you want to logout?", vbYesNo)
    '    If answer = vbYes Then
    '        Dim newuser As New User

    '        Form1.Show()
    '        Form1.Refresh()
    '        Me.Close()
    '    End If
    'End Sub
    Private Sub SavecurrentuserToJsonFile(currentuser As User)
        Dim json As String = JsonConvert.SerializeObject(currentuser, Formatting.Indented)
        Dim filePath As String = "currentuserdata.json"
        File.WriteAllText(filePath, json)
        MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub current_user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
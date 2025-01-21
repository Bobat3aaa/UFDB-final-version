Imports Newtonsoft.Json
Imports System.IO

Public Class currentadminuser
    Private Sub btnviewdatabase_Click(sender As Object, e As EventArgs) Handles btnviewdatabase.Click
        childform(Databaseeditor)
    End Sub


    'json editors
    Sub childform(ByVal panel As Form)
        panelmain.Controls.Clear()
        panel.TopLevel = False
        panelmain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnuserdetails_Click(sender As Object, e As EventArgs) Handles btnuserdetails.Click
        childform(Userdetails)
    End Sub
End Class
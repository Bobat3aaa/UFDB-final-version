Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports System.IO

Public Class Changepassword

    Private Sub Changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtpasswordagain_TextChanged(sender As Object, e As EventArgs) Handles txtnewpassword.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Function validatepassword(ByVal password As String)
        Static passwordcheck As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,32}$")
        MsgBox(passwordcheck.IsMatch(password))
        Return passwordcheck.IsMatch(password)
    End Function

    Function encryptpassword(newusername, newpassword)

        Dim encryptpass As String
        Dim key As Integer
        Dim addedchar As Char
        Dim currentchar As Integer = 0

        'makes key for password using username
        key = (Asc(newusername(0)) + (Asc(newusername(newusername.Length - 1))))

        'adds letters to the password
        While newpassword.Length < 32
            addedchar = Chr(Int((Asc((newpassword(currentchar))) + Asc((newpassword(currentchar)))) / 3))
            currentchar += 1
            newpassword += addedchar
        End While

        'encrypts password with xor key
        For i As Integer = 0 To newpassword.Length - 1
            encryptpass &= Chr(Asc((newpassword(i))) Xor key)
        Next


        Return encryptpass
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click
        Dim currentuser As User = getcurrentuser()
        Dim userlist As List(Of User) = ReadusersFromFile()
        Dim ogpass As String
        Dim newpass As String

        If txtpassword.Text IsNot Nothing And txtnewpassword.Text IsNot Nothing Then
            ogpass = txtpassword.Text
            ogpass = encryptpassword(currentuser.username, ogpass)
            If ogpass = currentuser.password Then
                newpass = txtnewpassword.Text
                currentuser.passwordlength = Len(newpass)
                newpass = encryptpassword(currentuser.username, newpass)
                currentuser.password = newpass
                Dim usertodelete = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
                userlist.Remove(usertodelete)
                userlist.Add(currentuser)
                SaveToJsonFile(userlist)
                MsgBox("Password changed!")
                Me.Close()
            Else MsgBox("Password is incorrect. Please try again")

            End If
        Else
            MsgBox("Please fill out the form!")
        End If
    End Sub

    Function getcurrentuser()
        Dim userlist As List(Of User) = ReadusersFromFile()
        Dim currentuser As User
        currentuser = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
        Return currentuser
    End Function

    Function ReadusersFromFile() As List(Of User)
        If Not File.Exists("userdata.json") Then
            Return New List(Of User)
        End If
        Dim json As String = File.ReadAllText("userdata.json")
        Return JsonConvert.DeserializeObject(Of List(Of User))(json)
    End Function

    Private Sub SaveToJsonFile(sortedusers As List(Of User))
        Dim json As String = JsonConvert.SerializeObject(sortedusers, Formatting.Indented)
        Dim filePath As String = "userdata.json"
        File.WriteAllText(filePath, json)
        MessageBox.Show($"Data saved to {filePath}")
    End Sub
End Class
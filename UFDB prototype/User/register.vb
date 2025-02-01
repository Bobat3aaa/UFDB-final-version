Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class register
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        Dim newusername As String = txtusername.Text
        Dim newpassword As String
        Dim newage As Integer = Val(Txtage.Text)
        Dim newemail As String = txtemail.Text

        If txtpassword.Text = txtpasswordagain.Text Then
            newpassword = txtpassword.Text
            If validatepassword(newpassword) = True Then
                If validateemail(newemail) = True Then
                    Adduser(newusername, newpassword, newage, newemail)
                Else
                    MsgBox("Email not valid")
                End If
            Else
                MsgBox("Email must have 8-32 characters, one special character and a capital letter")
            End If
        Else
            MsgBox("These passwords do not match each other.")
        End If


    End Sub

    Sub Adduser(newusername, newpassword, newage, newemail)

        'gets encrypted password

        Dim newuser As New User()
        newuser.passwordlength = Len(newpassword)
        Dim encryptpass As String = encryptpassword(newusername, newpassword)



        newuser.username = newusername
        newuser.age = newage
        newuser.password = encryptpass
        newuser.email = newemail

        'make list of existing users
        Dim users As List(Of User) = functions.ReadUsersFromJson()
        newuser.UserID = GetNextUserID(users)
        If ValidateUser(newuser) Then
            users.Add(newuser)
            functions.SaveUsersToJson(users)
            MsgBox("New user added!")
        Else
            MsgBox("User not added.")
        End If
    End Sub

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

    '2nd validation after encrpytion andbefore it is added to list
    Function ValidateUser(user As User) As Boolean
        If String.IsNullOrEmpty(user.username) OrElse String.IsNullOrEmpty(user.password) OrElse user.age <= 0 OrElse Not user.email.Contains("@") Then
            Return False
        End If
        Return True



    End Function

    'read all the users from the list to make listg of existing users

    'get the next possible user id from list
    Function GetNextUserID(users As List(Of User)) As Integer
        If users.Count = 0 Then
            Return 1
        End If

        Return users.Max(Function(u) u.UserID) + 1
    End Function
    'validate password before it is hashed
    Function validatepassword(ByVal password As String)
        Static passwordcheck As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,32}$")
        MsgBox(passwordcheck.IsMatch(password))
        Return passwordcheck.IsMatch(password)
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtpasswordagain_TextChanged(sender As Object, e As EventArgs) Handles txtpasswordagain.TextChanged

    End Sub

    Function validateemail(ByVal email As String) As Boolean
        'regular expression to check if email is in correct format
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class

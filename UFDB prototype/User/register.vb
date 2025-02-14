Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class register
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        Dim newusername As String = txtusername.Text 'stores new username
        Dim newpassword As String 'stores new password
        Dim newage As Integer = Val(Txtage.Text) 'stores new age
        Dim newemail As String = txtemail.Text 'stores email

        If txtpassword.Text = txtpasswordagain.Text Then 'checks if passwords are the same


            newpassword = txtpassword.Text

            'nested if statement that returns an appropriate error message based on what went wrong
            If validateusername(newusername) = False Then


                If validatepassword(newpassword) = True Then


                    If validateemail(newemail) = False Then


                        Adduser(newusername, newpassword, newage, newemail)
                    Else

                        MsgBox("Email not valid, or already taken")

                    End If
                Else

                    MsgBox("Password must have 8-32 characters, one special character and a capital letter")

                End If
            Else

                MsgBox("Username is already taken")

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


        'constructs new user
        newuser.username = newusername
        newuser.age = newage
        newuser.password = encryptpass
        newuser.email = newemail

        'make list of existing users
        Dim users As List(Of User) = functions.ReadUsersFromJson()
        newuser.UserID = GetNextUserID(users)
        If ValidateUser(newuser) Then
            'adds user to list
            users.Add(newuser)
            'saves json
            functions.SaveUsersToJson(users)
            MsgBox("New user added!")
        Else
            MsgBox("User not added.")
        End If
    End Sub

    Function encryptpassword(newusername, newpassword)

        Dim encryptpass As String = ""
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



    Function GetNextUserID(users As List(Of User)) As Integer


        'read all the users from the list to make listg of existing users

        'get the next possible user id from list
        If users.Count = 0 Then
            Return 1
        End If

        Return users.Max(Function(u) u.UserID) + 1
    End Function










    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click
        Form1.Show()
        Me.Close()
    End Sub


    'validation for user
    Function ValidateUser(user As User) As Boolean


        'makes sure no textboxes are empty
        If String.IsNullOrEmpty(user.username) Or String.IsNullOrEmpty(user.password) Or user.age <= 0 Or Not user.email.Contains("@") Then
            Return False
        End If
        Return True



    End Function
    Function validateusername(username As String) As Boolean

        'checks if username is already taken
        Dim users As List(Of User) = functions.ReadUsersFromJson()
        Dim match As Boolean = False
        match = users.Any(Function(u) u.username = username)
        Return match
    End Function

    Function validateemail(ByVal email As String) As Boolean
        'regular expression to check if email is in correct format
        Dim match As Boolean = False
        Dim users As List(Of User) = functions.ReadUsersFromJson()
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        match = emailExpression.IsMatch(email)
        If match = False Then
            Return match
        Else
            'then checks if email is being used by another account
            match = users.Any(Function(u) u.email = email)
            Return match
        End If





    End Function
    'validate password before it is hashed
    Function validatepassword(ByVal password As String)
        Static passwordcheck As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,32}$")
        MsgBox(passwordcheck.IsMatch(password))
        Return passwordcheck.IsMatch(password)
    End Function

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

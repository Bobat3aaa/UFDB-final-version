Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports System.IO

Public Class Changepassword


    Function validatepassword(ByVal password As String) 'uses regex to make sure password fits criteria


        Static passwordcheck As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,32}$")


        Return passwordcheck.IsMatch(password)
    End Function

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click


        Dim currentuser As User = getcurrentuser() 'gets current user object
        Dim userlist As List(Of User) = functions.ReadUsersFromJson 'gets full user list
        Dim ogpass As String 'stores first password
        Dim newpass As String 'stores new password


        If txtpassword.Text IsNot Nothing And txtnewpassword.Text IsNot Nothing Then


            ogpass = txtpassword.Text
            ogpass = encryptpassword(currentuser.username, ogpass) 'encrypts original password to check against current user password


            If ogpass = currentuser.password Then
                newpass = txtnewpassword.Text
                currentuser.passwordlength = Len(newpass) 'stores length of new password for decrpytion

                newpass = encryptpassword(currentuser.username, newpass) 'encrypts new password
                currentuser.password = newpass 'stores encrypted password
                Dim usertodelete = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
                userlist.Remove(usertodelete) 'deletes old object of user with old password and adds current user with new password
                userlist.Add(currentuser)
                functions.SaveUsersToJson(userlist)
                MsgBox("Password changed!")
                Me.Close()
            Else MsgBox("Password is incorrect. Please try again")

            End If
        Else
            MsgBox("Please fill out the form!")
        End If
    End Sub

    Function getcurrentuser()
        Dim userlist As List(Of User) = functions.ReadUsersFromJson
        Dim currentuser As User
        currentuser = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
        Return currentuser
    End Function



    Private Sub Changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
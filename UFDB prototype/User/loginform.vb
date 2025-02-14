Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json
Imports System.IO
Imports System
Imports System.Net.Http
Imports System.Threading.Tasks

Imports System.Collections.Generic

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Policy


Public Class loginform
    Public Property currentuserid As Integer 'global variable to store current user id

    Private Sub btnsortusers_Click(sender As Object, e As EventArgs)

    End Sub
    Function Quicksort(users As List(Of User), indexlow As Integer, indexhigh As Integer) As List(Of User) 'quicksort that sorts users
        Dim pivot As String
        Dim templow As Integer = indexlow
        Dim temphigh As Integer = indexhigh

        pivot = users(Int((indexlow + indexhigh) / 2)).username

        While templow <= temphigh
            While String.Compare(users(templow).username, pivot) < 0
                templow += 1
            End While

            While String.Compare(users(temphigh).username, pivot) > 0
                temphigh -= 1
            End While

            If templow <= temphigh Then
                Dim tempuser As User = users(templow)
                users(templow) = users(temphigh)
                users(temphigh) = tempuser
                templow += 1
                temphigh -= 1
            End If
        End While

        If indexlow < temphigh Then
            Quicksort(users, indexlow, temphigh)
        End If

        If templow < indexhigh Then
            Quicksort(users, templow, indexhigh)
        End If

        Return users
    End Function




    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        'sorts users and saves to the json
        Dim users As List(Of User) = functions.ReadUsersFromJson
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = users.Count - 1
        Dim sortedusers As List(Of User) = Quicksort(users, indexlow, indexhigh)
        functions.SaveUsersToJson(sortedusers)


        'uses binary search to find user via username
        Dim usernametofind As String = txtusername.Text
        Dim passwordtofind As String = txtpassword.Text
        Dim currentuserindex As Integer = bsearchusers(sortedusers, usernametofind, indexlow, indexhigh)

        'if user isnt found, return error message
        If currentuserindex = -1 Then

            MsgBox("Account not found.")
        Else

            'when username is found, conduct a password check
            Dim passwordcheck As Boolean = checkpassword(sortedusers, currentuserindex, usernametofind, passwordtofind)
            'if password check succeeds, check for admin powers
            If passwordcheck = True Then


                If users(currentuserindex).Admin = True Then

                    'save userid to currentuserid 
                    currentuserid = users(currentuserindex).UserID
                    MsgBox("Logged in as admin!")
                    'open adminuser form
                    currentadminuser.Show()
                    'clear textboxes
                    txtpassword.Text = ""
                    txtusername.Text = ""
                    Me.Hide()
                ElseIf users(currentuserindex).Admin = False Then
                    'open userform
                    currentuserid = users(currentuserindex).UserID
                    MsgBox("Logged in as user!")
                    current_user_form.Show()
                    'clear textboxes
                    txtpassword.Text = ""
                    txtusername.Text = ""
                    Me.Hide()
                End If

            ElseIf passwordcheck = False Then
                MsgBox("password is wrong")
                'clear textboxes
                txtpassword.Text = ""
                txtusername.Text = ""
            End If

        End If





    End Sub
    Function bsearchusers(sortedusers As List(Of User), usernametofind As String, indexlow As Integer, indexhigh As Integer)

        ' retuns -1 if no users found
        If indexlow > indexhigh Then
            Return -1
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2
        'compares usernames to find midpoint
        If String.Compare(sortedusers(midpoint).username, usernametofind) < 0 Then
            Return bsearchusers(sortedusers, usernametofind, midpoint + 1, indexhigh)
        ElseIf String.Compare(sortedusers(midpoint).username, usernametofind) > 0 Then
            Return bsearchusers(sortedusers, usernametofind, indexlow, midpoint - 1)
        Else
            Return midpoint
        End If
    End Function
    Function checkpassword(sortedusers, currentuserindex, usernametofind, passwordtofind)
        'encrypts password and checks it against user found via binary search
        Dim encryptpass As String = encryptpassword(usernametofind, passwordtofind)

        If encryptpass = sortedusers(currentuserindex).password Then
            Return True
        Else
            Return False
        End If
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








    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click 'open home
        Form1.Show()
        Me.Close()
    End Sub
End Class

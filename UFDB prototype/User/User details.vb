Imports Newtonsoft.Json
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Userdetails

    Public Sub New()


        InitializeComponent()
        Dim currentuser As usermanagement = getcurrentuser()
        'adds user details to appropriate textboxes
        lblusertitle.Text = currentuser.username
        txtusername.Text = currentuser.username
        txtage.Text = currentuser.age
        Txtemail.Text = currentuser.email




    End Sub
    Private Sub User_details_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnchangedetails.Click


        Dim emailcheck As Boolean = validateemail(Txtemail.Text)
        Dim usernamecheck As Boolean = validateusername(txtusername.Text)

        If usernamecheck = False Then


            If emailcheck = False Then

                Dim userlist As List(Of usermanagement) = functions.ReadUsersFromJson()

                'Dim currentuser As User = getcurrentuser()
                Dim currentuser As usermanagement = getcurrentuser()
                'decrypts password to encrypt with new username
                Dim decryptedpass As String = encryptpassword(currentuser.username, currentuser.password, False, currentuser.passwordlength)

                'stores new details
                currentuser.username = txtusername.Text
                currentuser.age = txtage.Text
                currentuser.email = Txtemail.Text

                'encrypts password with new usewrname
                Dim encryptedpass As String = encryptpassword(currentuser.username, decryptedpass, True, currentuser.passwordlength)

                'stores new passwords
                currentuser.password = encryptedpass

                'removes user witrh old detials and adds a new one with new details
                Dim usertoremove As usermanagement = userlist.FirstOrDefault((Function(u) u.UserID = loginform.currentuserid))
                userlist.Remove(usertoremove)
                userlist.Add(currentuser)
                functions.SaveUsersToJson(userlist)
                lblusertitle.Text = currentuser.username
                MsgBox("details updated!")

            Else
                MsgBox("email not found.")
            End If
        Else
            MsgBox("Username is taken.")
        End If

    End Sub



    Function getcurrentuser()
        Dim userlist As List(Of usermanagement) = functions.ReadUsersFromJson()
        Dim currentuser As usermanagement
        currentuser = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
        Return currentuser
    End Function

    Function validateemail(ByVal email As String) As Boolean
        'regular expression to check if email is in correct format
        Dim match As Boolean = False
        Dim users As List(Of usermanagement) = functions.ReadUsersFromJson()
        Static emailExpression As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9._%+-]+\.[a-zA-Z]{2,}$")
        match = emailExpression.IsMatch(email)
        If match = False Then
            Return match
        Else
            'then checks if email is being used by another account
            match = users.Any(Function(u) u.email = email)
            Return match
        End If

    End Function


    Private Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        Changepassword.Show()
    End Sub


    Function encryptpassword(newusername As String, newpassword As String, decision As Boolean, ogpasslength As Integer)

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

        'return password based on if encrypted password or decrypted password is asked for
        If decision = True Then
            Return encryptpass 'return encrypted pass


        ElseIf decision = False Then
            encryptpass = encryptpass.Substring(0, ogpasslength) 'returns decrypted password by using passwordlength attrbute
            Return encryptpass
        End If


    End Function

    Private Sub btndeleteaccount_Click(sender As Object, e As EventArgs) Handles btndeleteaccount.Click


        Dim answer As MsgBoxResult
        answer = MsgBox("Are you sure you wanty to delete your account", vbQuestion + vbYesNo, "Delete Account")
        If answer = vbYes Then

            'store all lists connected to user
            Dim userlist As List(Of usermanagement) = functions.ReadUsersFromJson()
            Dim currentuser As usermanagement = getcurrentuser()
            Dim fighterrankinglist As List(Of fighterranking) = functions.ReadFighterranksFromFile()
            Dim likedfighters As List(Of likedfighter) = functions.ReadlikedfightersFromJson()
            Dim rankinglist As List(Of ranking) = functions.ReadRanklistsFromJson()

            'deletes user
            Dim usertoremove As usermanagement = userlist.FirstOrDefault(Function(u) u.UserID = currentuser.UserID)
            MsgBox(usertoremove.UserID)
            userlist.Remove(usertoremove)

            'removes all liked fighters with the same userid
            likedfighters.RemoveAll(Function(lf) lf.userid = currentuser.UserID)



            'finds all ranking lists with the same user id
            Dim rankingstoremove As List(Of ranking) = rankinglist.Where(Function(r) r.UserID = currentuser.UserID).ToList()
            'finds all fighterrankings with rankingids connected to user id
            Dim rankingIdsToRemove As List(Of Integer) = rankingstoremove.Select(Function(r) r.RankingID).ToList()


            'removes both ranking lists and fighter rankings
            fighterrankinglist.RemoveAll(Function(fr) rankingIdsToRemove.Contains(fr.RankingID))
            rankinglist.RemoveAll(Function(r) r.UserID = currentuser.UserID)

            'saves all data back to the json files
            functions.SaveTolikedfighterJson(likedfighters)
            functions.SaveToFighterranksJson(fighterrankinglist)
            functions.SaveToRanklistJson(rankinglist)
            functions.SaveUsersToJson(userlist)

            Form1.Show()
            Me.Hide()
        End If


    End Sub

    Function validateusername(username As String) As Boolean

        'checks if username is already taken
        Dim users As List(Of usermanagement) = functions.ReadUsersFromJson()
        Dim match As Boolean = False
        match = users.Any(Function(u) u.username = username)
        Return match
    End Function

    Private Sub Userdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
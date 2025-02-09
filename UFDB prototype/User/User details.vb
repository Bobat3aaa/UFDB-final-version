Imports Newtonsoft.Json
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Userdetails

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim currentuser As User = getcurrentuser()
        lblusertitle.Text = currentuser.username
        txtusername.Text = currentuser.username
        txtage.Text = currentuser.age
        Txtemail.Text = currentuser.email


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub User_details_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnchangedetails.Click


        Dim emailcheck As Boolean = validateemail(Txtemail.Text)
        If emailcheck = True Then

            Dim userlist As List(Of User) = functions.ReadUsersFromJson()

            'Dim currentuser As User = getcurrentuser()
            Dim currentuser As User = getcurrentuser()
            Dim decryptedpass As String = encryptpassword(currentuser.username, currentuser.password, False, currentuser.passwordlength)
            Debug.WriteLine(decryptedpass)
            currentuser.username = txtusername.Text
            currentuser.age = txtage.Text
            currentuser.email = Txtemail.Text


            Dim encryptedpass As String = encryptpassword(currentuser.username, decryptedpass, True, currentuser.passwordlength)
            Debug.WriteLine(encryptedpass)
            currentuser.password = encryptedpass
            Dim usertoremove As User = userlist.FirstOrDefault((Function(u) u.UserID = loginform.currentuserid))
            userlist.Remove(usertoremove)
            userlist.Add(currentuser)
            functions.SaveUsersToJson(userlist)
            MsgBox("details updated!")
        Else
            MsgBox("email not found.")
        End If


    End Sub



    Function getcurrentuser()
        Dim userlist As List(Of User) = functions.ReadUsersFromJson()
        Dim currentuser As User
        currentuser = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
        Return currentuser
    End Function

    Function validateemail(ByVal email As String) As Boolean
        'regular expression to check if email is in correct format
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Private Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        Changepassword.Show()
    End Sub

    Private Sub Userdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        If decision = True Then
            Return encryptpass
        ElseIf decision = False Then
            encryptpass = encryptpass.Substring(0, ogpasslength)
            Return encryptpass
        End If


    End Function

    Private Sub btndeleteaccount_Click(sender As Object, e As EventArgs) Handles btndeleteaccount.Click
        Dim answer As MsgBoxResult
        answer = MsgBox("Are you sure you wanty to delete your account", vbQuestion + vbYesNo, "Delete Account")
        If answer = vbYes Then


            Dim userlist As List(Of User) = functions.ReadUsersFromJson()
            Dim currentuser As User = getcurrentuser()
            Dim fighterrankinglist As List(Of fighterranking) = functions.ReadFighterranksFromFile()
            Dim likedfighters As List(Of likedfighter) = functions.ReadlikedfightersFromJson()
            Dim rankinglist As List(Of ranking) = functions.ReadRanklistsFromJson()

            Dim usertoremove As User = userlist.FirstOrDefault(Function(u) u.UserID = currentuser.UserID)
            MsgBox(usertoremove.UserID)
            userlist.Remove(usertoremove)


            likedfighters.RemoveAll(Function(lf) lf.userid = currentuser.UserID)




            Dim rankingstoremove As List(Of ranking) = rankinglist.Where(Function(r) r.UserID = currentuser.UserID).ToList()
            Dim rankingIdsToRemove As List(Of Integer) = rankingstoremove.Select(Function(r) r.RankingID).ToList()



            fighterrankinglist.RemoveAll(Function(fr) rankingIdsToRemove.Contains(fr.RankingID))
            rankinglist.RemoveAll(Function(r) r.UserID = currentuser.UserID)

            functions.SaveTolikedfighterJson(likedfighters)
            functions.SaveToFighterranksJson(fighterrankinglist)
            functions.SaveToRanklistJson(rankinglist)
            functions.SaveUsersToJson(userlist)


        End If

    End Sub




End Class
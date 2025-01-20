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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnchangedetails.Click


        Dim emailcheck As Boolean = validateemail(Txtemail.Text)
        If emailcheck = True Then

            Dim userlist As List(Of User) = ReadusersFromFile()

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
            SaveToJsonFile(userlist)
            MsgBox("details updated!")
        Else
            MsgBox("email not found.")
        End If


    End Sub



    Function getcurrentuser()
        Dim userlist As List(Of User) = ReadusersFromFile()
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


            Dim userlist As List(Of User) = ReadusersFromFile()
            Dim currentuser As User = getcurrentuser()
            Dim fighterrankinglist As List(Of fighterranking) = ReadfighterranksFromFile()
            Dim likedfighters As List(Of likedfighter) = ReadlikedfightersFromFile()
            Dim rankinglist As List(Of ranking) = ReadranklistsFromFile()

            Dim usertoremove As User = userlist.FirstOrDefault(Function(u) u.UserID = currentuser.UserID)
            MsgBox(usertoremove.UserID)
            userlist.Remove(usertoremove)


            likedfighters.RemoveAll(Function(lf) lf.userid = currentuser.UserID)




            Dim rankingstoremove As List(Of ranking) = rankinglist.Where(Function(r) r.UserID = currentuser.UserID).ToList()
            Dim rankingIdsToRemove As List(Of Integer) = rankingstoremove.Select(Function(r) r.RankingID).ToList()



            fighterrankinglist.RemoveAll(Function(fr) rankingIdsToRemove.Contains(fr.RankingID))
            rankinglist.RemoveAll(Function(r) r.UserID = currentuser.UserID)

            SaveTolikedfightersJsonFile(likedfighters)
            SaveTofighterranksJson(fighterrankinglist)
            SaveToranklistJson(rankinglist)
            SaveToJsonFile(userlist)


        End If

    End Sub







    Function ReadlikedfightersFromFile() As List(Of likedfighter)
        If Not File.Exists("likedfighters.json") Then
            Return New List(Of likedfighter)
        End If
        Dim json As String = File.ReadAllText("likedfighters.json")
        Return JsonConvert.DeserializeObject(Of List(Of likedfighter))(json)
    End Function
    Private Sub SaveTolikedfightersJsonFile(likedfighters As List(Of likedfighter))
        Dim json As String = JsonConvert.SerializeObject(likedfighters, Formatting.Indented)
        Dim filePath As String = $"likedfighters.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub
    Function ReadranklistsFromFile() As List(Of ranking)
        If Not File.Exists("ranklists.json") Then
            Return New List(Of ranking)
        End If
        Dim json As String = File.ReadAllText("ranklists.json")
        Return JsonConvert.DeserializeObject(Of List(Of ranking))(json)
    End Function
    Private Sub SaveToranklistJson(rankedlists As List(Of ranking))
        Dim json As String = JsonConvert.SerializeObject(rankedlists, Formatting.Indented)
        Dim filePath As String = $"ranklists.json"
        File.WriteAllText(filePath, json)

    End Sub

    Function ReadfighterranksFromFile() As List(Of fighterranking)
        If Not File.Exists("fighterranks.json") Then
            Return New List(Of fighterranking)
        End If
        Dim json As String = File.ReadAllText("fighterranks.json")
        Return JsonConvert.DeserializeObject(Of List(Of fighterranking))(json)
    End Function

    Private Sub SaveTofighterranksJson(rankingfighterlist As List(Of fighterranking))
        Dim json As String = JsonConvert.SerializeObject(rankingfighterlist, Formatting.Indented)
        Dim filePath As String = $"fighterranks.json"
        File.WriteAllText(filePath, json)

    End Sub
End Class
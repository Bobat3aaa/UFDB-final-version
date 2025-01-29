Imports System.Text.RegularExpressions

Public Class Usereditor

    Private userlist As List(Of User)
    Private ranklist As List(Of ranking)
    Private fighterranklist As List(Of fighterranking)
    Private likedfighterlist As List(Of likedfighter)

    Private Sub Usereditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        userlist = functions.ReadUsersFromJson
        ranklist = functions.ReadRanklistsFromJson
        fighterranklist = functions.ReadFighterranksFromFile
        likedfighterlist = functions.ReadlikedfightersFromJson


        updatedatabase()
        Datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub updatedatabase()
        Datagridview.Refresh()
        Datagridview.DataSource = New BindingSource(userlist, Nothing)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim newusername As String = txtusername.Text
        Dim newpassword As String = txtpassword.Text
        Dim newage As Integer = Val(Txtage.Text)
        Dim newemail As String = txtemail.Text
        Dim admindecision As Boolean = Checkadmin.Checked
        Debug.WriteLine(admindecision)
        If validatepassword(newpassword) = True Then
            If validateemail(newemail) = True Then
                Adduser(newusername, newpassword, newage, newemail, admindecision)
            Else
                MsgBox("Email not valid")
            End If
        Else
            MsgBox("Email must have 8-32 characters, one special character and a capital letter")

        End If


        updatedatabase()

    End Sub
    Function GetNextUserID(users As List(Of User)) As Integer
        If users.Count = 0 Then
            Return 1
        End If

        Return users.Max(Function(u) u.UserID) + 1
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim usertodelete As User



        If Datagridview.SelectedRows(0).DataBoundItem IsNot Nothing Then
            usertodelete = CType(Datagridview.SelectedRows(0).DataBoundItem, User)
            likedfighterlist.RemoveAll(Function(lf) lf.userid = usertodelete.UserID)
            Dim rankingstoremove As List(Of ranking) = ranklist.Where(Function(r) r.UserID = usertodelete.UserID).ToList()
            Dim rankingIdsToRemove As List(Of Integer) = rankingstoremove.Select(Function(r) r.RankingID).ToList()
            fighterranklist.RemoveAll(Function(fr) rankingIdsToRemove.Contains(fr.RankingID))
            ranklist.RemoveAll(Function(r) r.UserID = usertodelete.UserID)
        End If


        If Datagridview.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Datagridview.SelectedRows
                Datagridview.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnsavefile_Click(sender As Object, e As EventArgs) Handles btnsavefile.Click

        functions.SaveUsersToJson(userlist)
        functions.SaveToFighterranksJson(fighterranklist)
        functions.SaveTolikedfighterJson(likedfighterlist)
        functions.SaveToRanklistJson(ranklist)
    End Sub

    Private Sub Adduser(newusername, newpassword, newage, newemail, admin)

        'gets encrypted password

        Dim newuser As New User()
        newuser.passwordlength = Len(newpassword)
        Dim encryptpass As String = encryptpassword(newusername, newpassword)



        newuser.username = newusername
        newuser.age = newage
        newuser.password = encryptpass
        newuser.email = newemail
        newuser.Admin = admin
        'make list of existing users

        newuser.UserID = GetNextUserID(userlist)
        If ValidateUser(newuser) Then
            userlist.Add(newuser)

            MsgBox("New user added!")
        Else
            MsgBox("User not added.")
        End If
    End Sub
    Private Function validatepassword(ByVal password As String)
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
    Function ValidateUser(user As User) As Boolean
        If String.IsNullOrEmpty(user.username) OrElse String.IsNullOrEmpty(user.password) OrElse user.age <= 0 OrElse Not user.email.Contains("@") Then
            Return False
        End If
        Return True



    End Function
    Function validateemail(ByVal email As String) As Boolean
        'regular expression to check if email is in correct format
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer = MessageBox.Show("This will remove all changes made. Do you want to continue?", "Clear", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then

            userlist = functions.ReadUsersFromJson
            ranklist = functions.ReadRanklistsFromJson
            fighterranklist = functions.ReadFighterranksFromFile
            likedfighterlist = functions.ReadlikedfightersFromJson
            updatedatabase()

        End If



    End Sub
End Class
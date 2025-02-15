Imports System.Text.RegularExpressions

Public Class Usereditor

    Private currentuserlist As List(Of User) 'user list to be saved
    Private currentranklist As List(Of ranking) ' rank list to be saved
    Private currentfighterranklist As List(Of fighterranking) ' fighter-rank list to be saved
    Private currentlikedfighterlist As List(Of likedfighter) 'liked-fighter list to be saved

    Private Sub Usereditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load in all user related files
        currentuserlist = functions.ReadUsersFromJson
        currentranklist = functions.ReadRanklistsFromJson
        currentfighterranklist = functions.ReadFighterranksFromFile
        currentlikedfighterlist = functions.ReadlikedfightersFromJson


        updatedatabase()
        Datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub updatedatabase()
        'populate database
        Datagridview.Refresh()
        Datagridview.DataSource = New BindingSource(currentuserlist, Nothing)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'add user based on register function


        Dim newusername As String = txtusername.Text
        Dim newpassword As String = txtpassword.Text
        Dim newage As Integer = Val(Txtage.Text)
        Dim newemail As String = txtemail.Text
        Dim admindecision As Boolean = Checkadmin.Checked





        If validateusername(newusername) = False Then
            If validatepassword(newpassword) = True Then
                If validateemail(newemail) = False Then
                    Adduser(newusername, newpassword, newage, newemail, admindecision)
                Else
                    MsgBox("Email not valid or already taken")
                End If
            Else
                MsgBox("Email must have 8-32 characters, one special character and a capital letter")

            End If
        Else
            MsgBox("Username is already taken")
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
        'delete user and all items related to it in liked fighters and rankings

        Dim usertodelete As User



        If Datagridview.SelectedRows(0).DataBoundItem IsNot Nothing Then
            usertodelete = CType(Datagridview.SelectedRows(0).DataBoundItem, User)
            currentlikedfighterlist.RemoveAll(Function(lf) lf.userid = usertodelete.UserID)
            Dim rankingstoremove As List(Of ranking) = currentranklist.Where(Function(r) r.UserID = usertodelete.UserID).ToList()
            Dim rankingIdsToRemove As List(Of Integer) = rankingstoremove.Select(Function(r) r.RankingID).ToList()
            currentfighterranklist.RemoveAll(Function(fr) rankingIdsToRemove.Contains(fr.RankingID))
            currentranklist.RemoveAll(Function(r) r.UserID = usertodelete.UserID)
        End If


        If Datagridview.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Datagridview.SelectedRows
                Datagridview.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnsavefile_Click(sender As Object, e As EventArgs) Handles btnsavefile.Click
        'save new files to all json
        functions.SaveUsersToJson(currentuserlist)
        functions.SaveToFighterranksJson(currentfighterranklist)
        functions.SaveTolikedfighterJson(currentlikedfighterlist)
        functions.SaveToRanklistJson(currentranklist)
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

        newuser.UserID = GetNextUserID(currentuserlist)
        If ValidateUser(newuser) Then
            currentuserlist.Add(newuser)

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
    Function ValidateUser(user As User) As Boolean
        If String.IsNullOrEmpty(user.username) OrElse String.IsNullOrEmpty(user.password) OrElse user.age <= 0 OrElse Not user.email.Contains("@") Then
            Return False
        End If
        Return True



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
            match = users.Any(Function(u) u.email = email)
            Return match
        End If





    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer = MessageBox.Show("This will remove all changes made. Do you want to continue?", "Clear", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then

            currentuserlist = functions.ReadUsersFromJson
            currentranklist = functions.ReadRanklistsFromJson
            currentfighterranklist = functions.ReadFighterranksFromFile
            currentlikedfighterlist = functions.ReadlikedfightersFromJson
            updatedatabase()

        End If



    End Sub
    Function validateusername(username As String) As Boolean
        Dim users As List(Of User) = functions.ReadUsersFromJson()
        Dim match As Boolean = False
        match = users.Any(Function(u) u.username = username)
        Return match
    End Function

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class
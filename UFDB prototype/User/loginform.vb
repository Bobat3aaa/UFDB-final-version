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
    Public Property currentuserid As Integer

    Private Sub btnsortusers_Click(sender As Object, e As EventArgs)

    End Sub
    Function Quicksort(users As List(Of User), indexlow As Integer, indexhigh As Integer) As List(Of User)
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
    Function ReadusersFromFile() As List(Of User)
        If Not File.Exists("userdata.json") Then
            Return New List(Of User)
        End If
        Dim json As String = File.ReadAllText("userdata.json")
        Return JsonConvert.DeserializeObject(Of List(Of User))(json)
    End Function

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub SaveToJsonFile(sortedusers As List(Of User))
        Dim json As String = JsonConvert.SerializeObject(sortedusers, Formatting.Indented)
        Dim filePath As String = "userdata.json"
        File.WriteAllText(filePath, json)
        MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        Dim users As List(Of User) = ReadusersFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = users.Count - 1
        Dim sortedusers As List(Of User) = Quicksort(users, indexlow, indexhigh)
        SaveToJsonFile(sortedusers)

        Dim usernametofind As String = txtusername.Text
        Dim passwordtofind As String = txtpassword.Text
        Dim currentuserindex As Integer = bsearchusers(sortedusers, usernametofind, indexlow, indexhigh)
        If currentuserindex = -1 Then
            MsgBox("no accounts made")
        Else
            MsgBox(currentuserindex)
            Dim passwordcheck As Boolean = checkpassword(sortedusers, currentuserindex, usernametofind, passwordtofind)
            If passwordcheck = True Then
                If users(currentuserindex).Admin = True Then
                    refreshapi()
                    currentuserid = users(currentuserindex).UserID
                ElseIf users(currentuserindex).Admin = False Then
                    currentuserid = users(currentuserindex).UserID



                    MsgBox("logged in as user")
                    current_user_form.Show()
                    Me.Hide()
                End If

            ElseIf passwordcheck = False Then
                MsgBox("password is wrong")
            End If

        End If





    End Sub
    Function bsearchusers(sortedusers As List(Of User), usernametofind As String, indexlow As Integer, indexhigh As Integer)


        If indexlow > indexhigh Then
            Return -1
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2

        If String.Compare(sortedusers(midpoint).username, usernametofind) < 0 Then
            Return bsearchusers(sortedusers, usernametofind, midpoint + 1, indexhigh)
        ElseIf String.Compare(sortedusers(midpoint).username, usernametofind) > 0 Then
            Return bsearchusers(sortedusers, usernametofind, indexlow, midpoint - 1)
        Else
            Return midpoint
        End If
    End Function
    Function checkpassword(sortedusers, currentuserindex, usernametofind, passwordtofind)
        Dim encryptpass As String = encryptpassword(usernametofind, passwordtofind)

        If encryptpass = sortedusers(currentuserindex).password Then
            Return True
        Else
            Return False
        End If
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

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Sub refreshapi()

        Dim allFighters As New List(Of Fighter)
        Using httpclient As New HttpClient()
            Dim answer As HttpResponseMessage = httpclient.GetAsync("https://ufc-api-theta.vercel.app/mma-api/fighters?page=0").Result
            Dim i = 1

            For i = 1 To 20
                Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fighters?page=" & i

                answer = httpclient.GetAsync(apiurl).Result

                If answer.IsSuccessStatusCode Then

                    'turns api into string
                    Dim responsecontent As String = answer.Content.ReadAsStringAsync().Result




                    Dim response As FighterResponse = JsonConvert.DeserializeObject(Of FighterResponse)(responsecontent)

                    allFighters.AddRange(response.fighters)




                End If
            Next
            SaveTofighterJsonFile(allFighters)
        End Using

        Dim allFights As New List(Of Fight)
        Using httpclient As New HttpClient()

            For i = 1 To 5
                Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fights?page=" & i

                Dim answer As HttpResponseMessage = httpclient.GetAsync(apiurl).Result

                If answer.IsSuccessStatusCode Then

                    'turns api into string
                    Dim responsecontent As String = answer.Content.ReadAsStringAsync().Result




                    Dim response As FightsResponse = JsonConvert.DeserializeObject(Of FightsResponse)(responsecontent)

                    allFights.AddRange(response.fights)



                Else
                    MessageBox.Show("Error getting API data")
                End If
            Next
            SaveTofightJsonFile(allFights)
        End Using

    End Sub

    Private Sub SaveTofighterJsonFile(allfighters As List(Of Fighter))
        Dim json As String = JsonConvert.SerializeObject(allfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        'MessageBox.Show($"Data saved to {filePath}")
    End Sub


    Private Sub SaveTofightJsonFile(allfights As List(Of Fight))
        Dim json As String = JsonConvert.SerializeObject(allfights, Formatting.Indented)
        Dim filePath As String = $"fights_page.json"
        File.WriteAllText(filePath, json)
        MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class

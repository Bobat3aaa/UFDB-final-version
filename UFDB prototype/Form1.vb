Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Policy

Public Class Form1



    Private Sub Fights_Click(sender As Object, e As EventArgs) Handles fights.Click

        fight_form.Show()
        Me.Hide()
    End Sub




    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click


        If loginform.currentuserid = 0 Then
            loginform.Show()
            Me.Hide()
        ElseIf loginform.currentuserid <> 0 Then
            Dim userlist As List(Of User) = ReadusersFromFile()
            Dim currentuser As User = userlist.Where(Function(u) u.UserID = loginform.currentuserid)
            If currentuser.Admin = True Then
                currentadminuser.Show()
                Me.Hide()
            Else
                current_user_form.Show()
                Me.Hide()
            End If




        End If




    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        register.Show()
        Me.Hide()
    End Sub


    'Async Function FetchFighterData() As Task(Of List(Of Fighter))
    '    Dim url As String = "https://ufc-api-theta.vercel.app/mma-api/fighters?page=1"
    '    Dim fighters As List(Of Fighter) = Nothing

    '    Using client As New HttpClient()
    '        Try
    '            ' Fetch JSON data
    '            Dim json As String = Await client.GetStringAsync(url)

    '            ' Deserialize JSON array into List of Fighter objects
    '            fighters = JsonConvert.DeserializeObject(Of List(Of Fighter))(json)
    '        Catch ex As Exception
    '            Console.WriteLine($"Error fetching data: {ex.Message}")
    '        End Try
    '    End Using

    '    Return fighters
    'End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub SaveToJsonFile(allfighters As List(Of fightermanagement))
        Dim json As String = JsonConvert.SerializeObject(allfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        'MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub fighters_Click(sender As Object, e As EventArgs) Handles Btnfighter.Click
        FighterForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnodds_Click(sender As Object, e As EventArgs) Handles btnodds.Click
        oddsgeneratorform.Show()
        Me.Hide()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Function ReadusersFromFile() As List(Of User)
        If Not File.Exists("userdata.json") Then
            Return New List(Of User)
        End If
        Dim json As String = File.ReadAllText("userdata.json")
        Return JsonConvert.DeserializeObject(Of List(Of User))(json)
    End Function

End Class

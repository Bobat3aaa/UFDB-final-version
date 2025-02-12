Imports Newtonsoft.Json
Imports System.IO
Imports System.Net.Http

Public Class currentadminuser
    Private Sub btnviewdatabase_Click(sender As Object, e As EventArgs) Handles btnviewdatabase.Click
        childform(Databaseeditor)
    End Sub


    'json editors
    Sub childform(ByVal panel As Form)
        panelmain.Controls.Clear()
        panel.TopLevel = False
        panelmain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnuserdetails_Click(sender As Object, e As EventArgs) Handles btnuserdetails.Click
        childform(Userdetails)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Dim answer = MessageBox.Show("Are you sure you would like to refresh the API. This will remove all previous changes made by admins!", "Refresh API", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then

            refreshapi()
        ElseIf answer = DialogResult.No Then

        End If
    End Sub
    Async Sub refreshapi()
        Await fetchalldata()
        MsgBox("API is refreshed")


    End Sub
    Public Async Function fetchfighters(httpclient As HttpClient) As Task


        Dim allfighters As New List(Of fightermanagement)
        Dim answer As HttpResponseMessage
        Dim i As Integer = 1
        Dim morefighters As Boolean = True

        While morefighters = True


            Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fighters?page=" & i

            answer = Await httpclient.GetAsync(apiurl)

            If answer.IsSuccessStatusCode Then

                'turns api into string
                Dim fightercontent As String = Await answer.Content.ReadAsStringAsync()




                Dim fighterresponse As FighterResponse = JsonConvert.DeserializeObject(Of FighterResponse)(fightercontent)
                If fighterresponse IsNot Nothing AndAlso fighterresponse.fighters IsNot Nothing AndAlso fighterresponse.fighters.Count > 0 Then
                    allfighters.AddRange(fighterresponse.fighters)
                    i += 1
                Else
                    morefighters = False
                End If


            Else
                morefighters = False
            End If
        End While
        Debug.WriteLine(allfighters.Count)
        functions.SaveToFighterJson(allfighters)
    End Function
    Public Async Function fetchfights(httpclient As HttpClient) As Task
        Dim allFights As New List(Of Fight)
        Dim i As Integer = 1
        Dim morefights As Boolean = True
        Dim answer As HttpResponseMessage

        While morefights = True
            Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fights?page=" & i

            answer = Await httpclient.GetAsync(apiurl)

            If answer.IsSuccessStatusCode Then

                'turns api into string
                Dim fightcontent As String = Await answer.Content.ReadAsStringAsync()




                Dim fightresponse As FightsResponse = JsonConvert.DeserializeObject(Of FightsResponse)(fightcontent)

                If fightresponse IsNot Nothing AndAlso fightresponse.fights IsNot Nothing AndAlso fightresponse.fights.Count > 0 Then
                    allFights.AddRange(fightresponse.fights)
                    i += 1
                Else
                    morefights = False

                End If

            Else
                morefights = False
            End If

        End While

        functions.SaveToFightJson(allFights)

    End Function
    Async Function fetchalldata() As Task
        Using httpclient As New HttpClient()
            Dim fightertask As Task = fetchfighters(httpclient)
            Dim fighttask As Task = fetchfights(httpclient)
            Await Task.WhenAll(fighttask, fightertask)
            MsgBox("API is refreshed")
        End Using
    End Function




    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim answer = MessageBox.Show("Are you sure you would like to logout?", "logout", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            loginform.currentuserid = 0
            Form1.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btneditusers.Click
        childform(Usereditor)
    End Sub

    Private Sub currentadminuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub panelmain_Paint(sender As Object, e As PaintEventArgs) Handles panelmain.Paint

    End Sub
End Class
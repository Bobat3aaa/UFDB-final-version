Imports Newtonsoft.Json
Imports System.IO
Imports System.Net.Http

Public Class currentadminuser
    Private Sub btnviewdatabase_Click(sender As Object, e As EventArgs) Handles btnviewdatabase.Click
        childform(Databaseeditor)
    End Sub


    'json editors
    Sub childform(ByVal panel As Form) 'used to embed a form within a form
        panelmain.Controls.Clear()
        panel.TopLevel = False
        panelmain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnuserdetails_Click(sender As Object, e As EventArgs) Handles btnuserdetails.Click 'opens user detail
        childform(Userdetails)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Dim answer = MessageBox.Show("Are you sure you would like to refresh the API. This will remove all previous changes made by admins!", "Refresh API", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then

            refreshapi()
        ElseIf answer = DialogResult.No Then

        End If
    End Sub
    Async Sub refreshapi() 'refreshes api

        Await fetchalldata() ' calls asynchronus function

    End Sub
    Public Async Function fetchfighters(httpclient As HttpClient) As Task 'asynchronus function that pulls all fighters from api


        Dim allfighters As New List(Of fightermanagement) 'holds all fighters
        Dim answer As HttpResponseMessage 'stores content from api
        Dim i As Integer = 1 'counter for pages
        Dim morefighters As Boolean = True 'validation to see if there are any more fighters

        While morefighters = True 'loops on condition more data can be found

            'api url increases in page
            Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fighters?page=" & i

            'sends GET request to HTTP (asynchronus)
            answer = Await httpclient.GetAsync(apiurl)

            'if an answer is retrieved, the content from api is turned into a string
            If answer.IsSuccessStatusCode Then

                'turns api into string
                Dim fightercontent As String = Await answer.Content.ReadAsStringAsync()



                'deserialises json found
                Dim fighterresponse As FighterResponse = JsonConvert.DeserializeObject(Of FighterResponse)(fightercontent)
                'if there are fighters within the json, add them to a list, if not, morefighters turns to false
                If fighterresponse IsNot Nothing AndAlso fighterresponse.fighters IsNot Nothing AndAlso fighterresponse.fighters.Count > 0 Then
                    'if there is a response + there are fighters, it adds all the fighters found from fighterresponse into the allfighters 
                    allfighters.AddRange(fighterresponse.fighters)
                    i += 1
                Else
                    'stop function
                    morefighters = False
                End If


            Else
                morefighters = False
            End If
        End While

        'save new list of fighters to json

        functions.SaveToFighterJson(allfighters)
    End Function
    Public Async Function fetchfights(httpclient As HttpClient) As Task 'asynchronus function that pulls all fights from api

        Dim allfights As New List(Of Fight) 'holds all fights
        Dim i As Integer = 1 'counter for pages
        Dim morefights As Boolean = True  'validation to see if there are any more fights
        Dim answer As HttpResponseMessage 'stores content from api

        'loops on condition more data can be found
        While morefights = True
            Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fights?page=" & i

            'sends GET request to HTTP (asynchronus)
            answer = Await httpclient.GetAsync(apiurl)

            'if an answer is retrieved, the content from api is turned into a string
            If answer.IsSuccessStatusCode Then

                'turns api into string
                Dim fightcontent As String = Await answer.Content.ReadAsStringAsync()



                'deserialises json
                Dim fightresponse As FightsResponse = JsonConvert.DeserializeObject(Of FightsResponse)(fightcontent)
                'if there are fights within the json, add them to a list, if not, morefights turns to false
                If fightresponse IsNot Nothing AndAlso fightresponse.fights IsNot Nothing AndAlso fightresponse.fights.Count > 0 Then
                    'if there is a response + there are fights, it adds all the fights found from fighterresponse into the allfights
                    allfights.AddRange(fightresponse.fights)
                    i += 1
                Else
                    'stop function
                    morefights = False

                End If

            Else
                morefights = False
            End If

        End While

        'saves fights
        functions.SaveToFightJson(allfights)

    End Function
    Async Function fetchalldata() As Task 'asynchronus function to refresh all API data


        Using httpclient As New HttpClient() 'used to access HTTP requests, responses, etc

            Dim fightertask As Task = fetchfighters(httpclient) 'fetch all fighters from API
            Dim fighttask As Task = fetchfights(httpclient) 'fetch all fights from API

            Await Task.WhenAll(fighttask, fightertask) 'waits for both fights and fighters to be finished

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
        'opens user editor
        childform(Usereditor)
    End Sub

    Private Sub currentadminuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click 'returns to home
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub panelmain_Paint(sender As Object, e As PaintEventArgs) Handles panelmain.Paint

    End Sub

    Private Sub btnranking_Click(sender As Object, e As EventArgs) Handles btnranking.Click
        'open ranking search
        Dim newrankingsearch As New Rankingsearch
        childform(newrankingsearch)
    End Sub

    Private Sub btnnewranking_Click(sender As Object, e As EventArgs) Handles btnnewranking.Click
        Dim newranking As New currentranking
        childform(newranking)

    End Sub

    Private Sub btnlikedfighters_Click(sender As Object, e As EventArgs) Handles btnlikedfighters.Click
        'open liked fighter search
        Dim newlikedfightersearch As New Likedfightersearch
        childform(newlikedfightersearch)
    End Sub
End Class
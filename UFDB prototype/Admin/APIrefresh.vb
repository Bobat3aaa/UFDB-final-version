Imports Newtonsoft.Json
Imports System.Net.Http

Public Class APIrefresh
    Private Sub APIrefresh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                    lblfightercount.Text = allfighters.Count
                    i += 1
                Else
                    'stop function
                    morefighters = False
                    lblfightercount.ForeColor = Color.Green
                End If


            Else
                lblfightercount.ForeColor = Color.Green
                morefighters = False
            End If
        End While

        'save new list of fighters to json
        Debug.WriteLine("new fighters amount:" & allfighters.Count)
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
                    For Each fight In fightresponse.fights
                        fight.fightnumber = fight.ParseEventNumber(fight.event_name)
                    Next

                    allfights.AddRange(fightresponse.fights)
                    lblfightcount.Text = allfights.Count
                    i += 1
                Else
                    'stop function
                    morefights = False
                    lblfightcount.ForeColor = Color.Green
                End If

            Else
                lblfightcount.ForeColor = Color.Green
                morefights = False
            End If

        End While

        Debug.WriteLine("New fights amount" & allfights.Count)
        'saves fights
        functions.SaveToFightJson(allfights)

    End Function
    Async Function fetchalldata() As Task 'asynchronus function to refresh all API data

        Try
            Using httpclient As New HttpClient() 'used to access HTTP requests, responses, etc

                Dim fightertask As Task = fetchfighters(httpclient) 'fetch all fighters from API
                Dim fighttask As Task = fetchfights(httpclient) 'fetch all fights from API

                Await Task.WhenAll(fighttask, fightertask) 'waits for both fights and fighters to be finished

                MsgBox("API is refreshed")
            End Using
        Catch ex As Exception
            MsgBox("problem pulling from API: " & ex.Message)
        End Try

    End Function

    Private Sub btnrefreshapi_Click(sender As Object, e As EventArgs) Handles btnrefreshapi.Click

        Dim answer = MessageBox.Show("Are you sure you would like to refresh the API. This will remove all previous changes made by admins!", "Refresh API", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            refreshapi()

        ElseIf answer = DialogResult.No Then

        End If
    End Sub
End Class
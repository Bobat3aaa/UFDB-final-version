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
        Dim moredata As Boolean = True

        While moredata = True
            Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fighters?page=" & i

            answer = Await httpclient.GetAsync(apiurl)

            If answer.IsSuccessStatusCode Then

                'turns api into string
                Dim responsecontent As String = Await answer.Content.ReadAsStringAsync()




                Dim response As FighterResponse = JsonConvert.DeserializeObject(Of FighterResponse)(responsecontent)
                If response IsNot Nothing AndAlso response.fighters IsNot Nothing AndAlso response.fighters.Count > 0 Then
                    allfighters.AddRange(response.fighters)
                    i += 1
                Else
                    moredata = False
                End If


            Else
                moredata = False
            End If
        End While
        SaveTofighterJsonFile(allfighters)
    End Function
    Public Async Function fetchfights(httpclient As HttpClient) As Task
        Dim allFights As New List(Of Fight)
        Dim i As Integer = 1
        Dim moredata As Boolean = True
        Dim answer As HttpResponseMessage

        While moredata = True
            Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fights?page=" & i

            answer = Await httpclient.GetAsync(apiurl)

            If answer.IsSuccessStatusCode Then

                'turns api into string
                Dim responsecontent As String = Await answer.Content.ReadAsStringAsync()




                Dim response As FightsResponse = JsonConvert.DeserializeObject(Of FightsResponse)(responsecontent)

                If response IsNot Nothing AndAlso response.fights IsNot Nothing AndAlso response.fights.Count > 0 Then
                    allFights.AddRange(response.fights)
                    i += 1
                Else
                    moredata = False

                End If

            Else
                moredata = False
            End If

        End While

        SaveTofightJsonFile(allFights)

    End Function
    Async Function fetchalldata() As Task
        Using httpclient As New HttpClient()
            Dim fightertask As Task = fetchfighters(httpclient)
            Dim fighttask As Task = fetchfights(httpclient)
            Await Task.WhenAll(fighttask, fightertask)
            MsgBox("API is refreshed")
        End Using
    End Function

    Private Sub SaveTofighterJsonFile(allfighters As List(Of fightermanagement))
        Dim json As String = JsonConvert.SerializeObject(allfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)

    End Sub


    Private Sub SaveTofightJsonFile(allfights As List(Of Fight))
        Dim json As String = JsonConvert.SerializeObject(allfights, Formatting.Indented)
        Dim filePath As String = $"fights_page.json"
        File.WriteAllText(filePath, json)

    End Sub
End Class
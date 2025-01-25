Imports Newtonsoft.Json
Imports System.IO

Public Class functions

    Public Function ReadFightersFromJson() As List(Of fightermanagement)
        If Not File.Exists("fighters_page.json") Then
            Return New List(Of fightermanagement)
        End If
        Dim json As String = File.ReadAllText("fighters_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of fightermanagement))(json)
    End Function



    Public Sub SaveToFighterJson(sortedfighters As List(Of fightermanagement))
        Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Public Function ReadFightsFromJson() As List(Of Fight)
        If Not File.Exists("fights_page.json") Then
            Return New List(Of Fight)
        End If
        Dim json As String = File.ReadAllText("fights_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of Fight))(json)
    End Function
    Public Sub SaveToFightJson(allfights As List(Of Fight))
        Dim json As String = JsonConvert.SerializeObject(allfights, Formatting.Indented)
        Dim filePath As String = $"fights_page.json"
        File.WriteAllText(filePath, json)

    End Sub

    Public Function ReadUsersFromJson() As List(Of User)
        If Not File.Exists("userdata.json") Then
            Return New List(Of User)
        End If
        Dim json As String = File.ReadAllText("userdata.json")
        Return JsonConvert.DeserializeObject(Of List(Of User))(json)
    End Function

    Public Sub SaveUsersToJson(filePath As String, users As List(Of User))
        Dim json As String = JsonConvert.SerializeObject(users, Formatting.Indented)
        File.WriteAllText("userdata.json", json)
    End Sub

    Public Function ReadRanklistsFromJson() As List(Of ranking)
        If Not File.Exists("ranklists.json") Then
            Return New List(Of ranking)
        End If
        Dim json As String = File.ReadAllText("ranklists.json")
        Return JsonConvert.DeserializeObject(Of List(Of ranking))(json)
    End Function
    Public Sub SaveToRanklistJson(rankedlists As List(Of ranking))
        Dim json As String = JsonConvert.SerializeObject(rankedlists, Formatting.Indented)
        Dim filePath As String = $"ranklists.json"
        File.WriteAllText(filePath, json)

    End Sub

    Public Function ReadFighterranksFromFile() As List(Of fighterranking)
        If Not File.Exists("fighterranks.json") Then
            Return New List(Of fighterranking)
        End If
        Dim json As String = File.ReadAllText("fighterranks.json")
        Return JsonConvert.DeserializeObject(Of List(Of fighterranking))(json)
    End Function

    Public Sub SaveToFighterranksJson(rankingfighterlist As List(Of fighterranking))
        Dim json As String = JsonConvert.SerializeObject(rankingfighterlist, Formatting.Indented)
        Dim filePath As String = $"fighterranks.json"
        File.WriteAllText(filePath, json)

    End Sub
End Class

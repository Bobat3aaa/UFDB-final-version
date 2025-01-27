Imports Newtonsoft.Json
Imports System.IO

Public Class functions
    ' read fighters from the json file
    Public Shared Function ReadFightersFromJson() As List(Of fightermanagement)
        If Not File.Exists("fighters_page.json") Then
            Return New List(Of fightermanagement)
        End If
        Dim json As String = File.ReadAllText("fighters_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of fightermanagement))(json)
    End Function


    ' save fighters from the json file
    Public Shared Sub SaveToFighterJson(sortedfighters As List(Of fightermanagement))
        Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub

    ' read fights from the json file
    Public Shared Function ReadFightsFromJson() As List(Of Fight)
        If Not File.Exists("fights_page.json") Then
            Return New List(Of Fight)
        End If
        Dim json As String = File.ReadAllText("fights_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of Fight))(json)
    End Function
    Public Shared Sub SaveToFightJson(allfights As List(Of Fight))
        Dim json As String = JsonConvert.SerializeObject(allfights, Formatting.Indented)
        Dim filePath As String = $"fights_page.json"
        File.WriteAllText(filePath, json)

    End Sub

    ' read users from the json file
    Public Shared Function ReadUsersFromJson() As List(Of User)
        If Not File.Exists("userdata.json") Then
            Return New List(Of User)
        End If
        Dim json As String = File.ReadAllText("userdata.json")
        Return JsonConvert.DeserializeObject(Of List(Of User))(json)
    End Function

    Public Shared Sub SaveUsersToJson(users As List(Of User))
        Dim json As String = JsonConvert.SerializeObject(users, Formatting.Indented)
        File.WriteAllText("userdata.json", json)
    End Sub

    ' read ranklists from the json file
    Public Shared Function ReadRanklistsFromJson() As List(Of ranking)
        If Not File.Exists("ranklists.json") Then
            Return New List(Of ranking)
        End If
        Dim json As String = File.ReadAllText("ranklists.json")
        Return JsonConvert.DeserializeObject(Of List(Of ranking))(json)
    End Function
    Public Shared Sub SaveToRanklistJson(rankedlists As List(Of ranking))
        Dim json As String = JsonConvert.SerializeObject(rankedlists, Formatting.Indented)
        Dim filePath As String = $"ranklists.json"
        File.WriteAllText(filePath, json)

    End Sub
    ' read the fighter-ranking binder table from the json file
    Public Shared Function ReadFighterranksFromFile() As List(Of fighterranking)
        If Not File.Exists("fighterranks.json") Then
            Return New List(Of fighterranking)
        End If
        Dim json As String = File.ReadAllText("fighterranks.json")
        Return JsonConvert.DeserializeObject(Of List(Of fighterranking))(json)
    End Function

    Public Shared Sub SaveToFighterranksJson(rankingfighterlist As List(Of fighterranking))
        Dim json As String = JsonConvert.SerializeObject(rankingfighterlist, Formatting.Indented)
        Dim filePath As String = $"fighterranks.json"
        File.WriteAllText(filePath, json)

    End Sub
    Public Shared Sub SaveTolikedfighterJson(likedfighters As List(Of likedfighter))
        Dim json As String = JsonConvert.SerializeObject(likedfighters, Formatting.Indented)
        Dim filePath As String = $"likedfighters.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub

    ' read the liked-fighters table from the json file
    Public Shared Function ReadlikedfightersFromJson() As List(Of likedfighter)
        If Not File.Exists("likedfighters.json") Then
            Return New List(Of likedfighter)
        End If
        Dim json As String = File.ReadAllText("likedfighters.json")
        Return JsonConvert.DeserializeObject(Of List(Of likedfighter))(json)
    End Function
End Class

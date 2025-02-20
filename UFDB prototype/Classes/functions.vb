Imports Newtonsoft.Json
Imports System.Drawing.Text
Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Public Class functions 'JSON functions used throughout program to save and read from JSON files



    ' read fighters from the json file
    Public Shared Function ReadFightersFromJson() As List(Of fightermanagement)
        Try
            If Not File.Exists("fighters.json") Then
                Return New List(Of fightermanagement)
            End If
            Dim json As String = File.ReadAllText("fighters.json")
            Return JsonConvert.DeserializeObject(Of List(Of fightermanagement))(json)
        Catch ex As Exception
            MsgBox("Error reading fighters from JSON" & ex.Message)
            Return New List(Of fightermanagement)
        End Try
    End Function


    ' save fighters from the json file
    Public Shared Sub SaveToFighterJson(sortedfighters As List(Of fightermanagement))
        Try
            Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
            Dim filePath As String = $"fighters.json"
            File.WriteAllText(filePath, json)
        Catch ex As Exception
            MsgBox("Error saving to fighter JSON" & ex.Message)

        End Try
    End Sub

    ' read fights from the json file
    Public Shared Function ReadFightsFromJson() As List(Of Fight)
        Try
            If Not File.Exists("fights.json") Then
                Return New List(Of Fight)
            End If
            Dim json As String = File.ReadAllText("fights.json")
            Return JsonConvert.DeserializeObject(Of List(Of Fight))(json)
        Catch ex As Exception
            MsgBox("Error reading fights from JSON" & ex.Message)
            Return New List(Of Fight)
        End Try
    End Function
    Public Shared Sub SaveToFightJson(allfights As List(Of Fight))
        Try
            Dim json As String = JsonConvert.SerializeObject(allfights, Formatting.Indented)
            Dim filePath As String = $"fights.json"
            File.WriteAllText(filePath, json)
        Catch ex As Exception
            MsgBox("Error saving to fight JSON" & ex.Message)

        End Try
    End Sub

    ' read users from the json file
    Public Shared Function ReadUsersFromJson() As List(Of usermanagement)
        Try
            If Not File.Exists("users.json") Then
                Return New List(Of usermanagement)
            End If
            Dim json As String = File.ReadAllText("users.json")
            Return JsonConvert.DeserializeObject(Of List(Of usermanagement))(json)
        Catch ex As Exception
            MsgBox("Error reading JSON" & ex.Message)
            Return New List(Of usermanagement)
        End Try
    End Function

    'save the user table to json
    Public Shared Sub SaveUsersToJson(users As List(Of usermanagement))
        Try
            Dim json As String = JsonConvert.SerializeObject(users, Formatting.Indented)
            File.WriteAllText("users.json", json)
        Catch ex As Exception
            MsgBox("Error saving to user JSON" & ex.Message)

        End Try
    End Sub

    ' read ranklists from the json file
    Public Shared Function ReadRanklistsFromJson() As List(Of ranking)
        Try
            If Not File.Exists("ranklists.json") Then
                Return New List(Of ranking)
            End If
            Dim json As String = File.ReadAllText("ranklists.json")
            Return JsonConvert.DeserializeObject(Of List(Of ranking))(json)
        Catch ex As Exception
            MsgBox("Error reading rank lists from JSON" & ex.Message)
            Return New List(Of ranking)
        End Try
    End Function
    Public Shared Sub SaveToRanklistJson(rankedlists As List(Of ranking))
        Try
            Dim json As String = JsonConvert.SerializeObject(rankedlists, Formatting.Indented)
            Dim filePath As String = $"ranklists.json"
            File.WriteAllText(filePath, json)
        Catch ex As Exception
            MsgBox("Error saving to rank lists JSON" & ex.Message)

        End Try

    End Sub
    ' read the fighter-ranking binder table from the json file
    Public Shared Function ReadFighterranksFromFile() As List(Of fighterranking)
        Try
            If Not File.Exists("fighterranks.json") Then
                Return New List(Of fighterranking)
            End If
            Dim json As String = File.ReadAllText("fighterranks.json")
            Return JsonConvert.DeserializeObject(Of List(Of fighterranking))(json)
        Catch ex As Exception
            MsgBox("Error reading fighter rankings from JSON" & ex.Message)
            Return New List(Of fighterranking)
        End Try
    End Function

    'save the fighter-ranking binder table to the json file
    Public Shared Sub SaveToFighterranksJson(rankingfighterlist As List(Of fighterranking))
        Try
            Dim json As String = JsonConvert.SerializeObject(rankingfighterlist, Formatting.Indented)
            Dim filePath As String = $"fighterranks.json"
            File.WriteAllText(filePath, json)
        Catch ex As Exception
            MsgBox("Error saving to fighter ranks JSON" & ex.Message)

        End Try
    End Sub

    'save the liked fighter json to its json file
    Public Shared Sub SaveTolikedfighterJson(likedfighters As List(Of likedfighter))
        Try
            Dim json As String = JsonConvert.SerializeObject(likedfighters, Formatting.Indented)
            Dim filePath As String = $"likedfighters.json"
            File.WriteAllText(filePath, json)
        Catch ex As Exception
            MsgBox("Error saving to liked fighters JSON" & ex.Message)

        End Try
    End Sub

    ' read the liked-fighters table from the json file
    Public Shared Function ReadlikedfightersFromJson() As List(Of likedfighter)
        Try
            If Not File.Exists("likedfighters.json") Then
                Return New List(Of likedfighter)
            End If
            Dim json As String = File.ReadAllText("likedfighters.json")
            Return JsonConvert.DeserializeObject(Of List(Of likedfighter))(json)
        Catch ex As Exception
            MsgBox("Error reading liked fighters from JSON" & ex.Message)
            Return New List(Of likedfighter)
        End Try
    End Function


End Class



Imports Newtonsoft.Json

''fight and fightresponse data structrues to hold data from API
Public Class Fight

    <JsonProperty("_id")>
    Public Property id As String 'hold fight id

    <JsonProperty("event")>
    Public Property event_name As String 'holds fight name

    <JsonProperty("date")>
    Public Property [date] As DateTime 'holds fight date

    <JsonProperty("location")>
    Public Property location As String 'holds location

    <JsonProperty("fighter1ID")>
    Public Property fighter1id As String 'holds first fighter id

    <JsonProperty("fighter2ID")>
    Public Property fighter2id As String 'holds second fighter id

    <JsonProperty("fighter1")>
    Public Property fighter1 As String 'holds fighter 1 name

    <JsonProperty("fighter2")>
    Public Property fighter2 As String 'holds fighter 2 name

    <JsonProperty("win")>
    Public Property win As String 'holds who won

    <JsonProperty("lose")>
    Public Property lose As String 'holds who lost

    <JsonProperty("weight_class")>
    Public Property weight_class As String 'holds the weightclass of the fight

    <JsonProperty("method")>
    Public Property method As String 'holds how they won fight

    <JsonProperty("roundd")>
    Public Property rounds As String 'holds how many rounds were fought

    <JsonProperty("time")>
    Public Property time As String 'holds time of finish

End Class

Public Class FightsResponse 'class to hold content from API
    Public Property fights As List(Of Fight) 'holds fights from content of HTTP
End Class

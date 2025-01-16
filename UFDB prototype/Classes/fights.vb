
Imports Newtonsoft.Json
Public Class Fight

    <JsonProperty("_id")>
    Public Property id As String

    <JsonProperty("event")>
    Public Property event_name As String

    <JsonProperty("date")>
    Public Property [date] As DateTime

    <JsonProperty("location")>
    Public Property location As String

    <JsonProperty("fighter1ID")>
    Public Property fighter1id As String

    <JsonProperty("fighter2ID")>
    Public Property fighter2id As String

    <JsonProperty("fighter1")>
    Public Property fighter1 As String

    <JsonProperty("fighter2")>
    Public Property fighter2 As String

    <JsonProperty("win")>
    Public Property win As String

    <JsonProperty("lose")>
    Public Property lose As String

    <JsonProperty("weight_class")>
    Public Property weight_class As String

    <JsonProperty("method")>
    Public Property method As String

    <JsonProperty("roundd")>
    Public Property rounds As String

    <JsonProperty("time")>
    Public Property time As String

End Class

Public Class FightsResponse
    Public Property fights As List(Of Fight)
End Class

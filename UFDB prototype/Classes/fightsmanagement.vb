
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

''fight and fightresponse data structrues to hold data from API
Public Class Fight

    <JsonProperty("_id")>
    Public Property id As String 'hold fight id

    <JsonProperty("event")>
    Public Property name As String 'holds fight name

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

    <JsonProperty("weightclass")>
    Public Property weightclass As String 'holds the weightclass of the fight

    <JsonProperty("method")>
    Public Property method As String 'holds how they won fight

    <JsonProperty("roundd")>
    Public Property rounds As String 'holds how many rounds were fought

    <JsonProperty("time")>
    Public Property time As String 'holds time of finish

    Public Property fightnumber As Integer

    Function ParseEventNumber(eventName As String) As Integer 'Parses event number


        'uses a regular expression to parse the fight number

        'matches number within UFC(number)
        Dim eventregex As New Regex("\bUFC\s+(\d+)\b", RegexOptions.IgnoreCase)



        Dim match As Match = eventregex.Match(eventName)
        'only does so for ufc names with an event number
        If match.Success Then
            Debug.WriteLine(Integer.Parse(match.Groups(1).Value))
            Return Integer.Parse(match.Groups(1).Value)
        Else
            Debug.WriteLine("nothing returned")

            Return -1
        End If
    End Function
End Class


Public Class fightresponse 'class to hold content from API
    Public Property fights As List(Of Fight) 'holds fights from content of HTTP
End Class

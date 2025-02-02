Imports Newtonsoft.Json




Public Class fightermanagement

    <JsonProperty("fighter_id")>
    Public Property FighterId As String

    Public Property Name As String

    Public Property Height As String


    Public Property Weight As String

    Public Property Reach As String

    <JsonProperty("Stance")>
    Public Property Stance As String
    Public Property Dob As String

    <JsonProperty("n_win")>
    Public Property Wins As Integer

    <JsonProperty("n_loss")>
    Public Property Losses As Integer

    <JsonProperty("n_draw")>
    Public Property Draws As Integer

    <JsonProperty("sig_str_land_pM")>
    Public Property SignificantStrikesLandedPerMinute As Double

    <JsonProperty("sig_str_land_pct")>
    Public Property SignificantStrikesLandedPercentage As Double

    <JsonProperty("sig_str_abs_pM")>
    Public Property SignificantStrikesAbsorbedPerMinute As Double

    <JsonProperty("sig_str_def_pct")>
    Public Property SignificantStrikesDefensePercentage As Double

    <JsonProperty("td_avg")>
    Public Property TakedownAverage As Double

    <JsonProperty("td_land_pct")>
    Public Property TakedownAccuracyPercentage As Double

    <JsonProperty("td_def_pct")>
    Public Property TakedownDefensePercentage As Double

    <JsonProperty("sub_avg")>
    Public Property SubmissionAverage As Double
End Class

Public Class FighterResponse
    Public Property Success As Boolean
    Public Property fighters As List(Of fightermanagement)

End Class

Public Class likedfighter
    Public Property userid As Integer
    Public Property fighterid As String
End Class


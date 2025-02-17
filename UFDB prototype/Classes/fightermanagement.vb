Imports Newtonsoft.Json




Public Class fightermanagement

    <JsonProperty("fighter_id")>
    Public Property FighterId As String 'holds fighter id 

    Public Property Name As String 'holds fighter name

    Public Property Height As String 'holds fighter height


    Public Property Weight As String 'holds fighter weight

    Public Property Reach As String 'holds fighter reach

    <JsonProperty("Stance")>
    Public Property Stance As String 'holds fighter stance
    Public Property Dob As String 'holds fighter date of birth

    <JsonProperty("n_win")>
    Public Property Wins As Integer 'holds fighter wins

    <JsonProperty("n_loss")>
    Public Property Losses As Integer 'holds fighter losses

    <JsonProperty("n_draw")>
    Public Property Draws As Integer 'holds fighter draws

    <JsonProperty("sig_str_land_pM")>
    Public Property SignificantStrikesLandedPerMinute As Double 'holds the average of their significant strikes landed per minute

    <JsonProperty("sig_str_land_pct")>
    Public Property SignificantStrikesLandedPercentage As Double 'holds a percentage of their significant strikes landed per minute

    <JsonProperty("sig_str_abs_pM")>
    Public Property SignificantStrikesAbsorbedPerMinute As Double 'holds the average of their significant strikes absorbed per minute

    <JsonProperty("sig_str_def_pct")>
    Public Property SignificantStrikesDefensePercentage As Double  'holds the percentage of their significant strikes defended per minute

    <JsonProperty("td_avg")>
    Public Property TakedownAverage As Double 'holds the average amount of takedowns per round

    <JsonProperty("td_land_pct")>
    Public Property TakedownAccuracyPercentage As Double 'holds the accuracy of takedowns

    <JsonProperty("td_def_pct")>
    Public Property TakedownDefensePercentage As Double 'holds the percentage of takedowns defendeds

    <JsonProperty("sub_avg")>
    Public Property SubmissionAverage As Double 'holds the average amount of submissions through all their fights
End Class

Public Class FighterResponse 'used to store content from api

    Public Property fighters As List(Of fightermanagement) 'holds content from api

End Class

Public Class likedfighter 'class for liked fighters
    Public Property userid As Integer 'holds current user id
    Public Property fighterid As String 'holds current fighter id
End Class


Imports Newtonsoft.Json


'fighter and fighterresponse data structrues to hold data from API



Public Class fighter

    <JsonProperty("fighter_id")>
    Public Property fighterid As String 'holds fighter id 

    <JsonProperty("Name")>
    Public Property name As String 'holds fighter name

    <JsonProperty("Height")>
    Public Property height As String 'holds fighter height

    <JsonProperty("Weight")>
    Public Property weight As String 'holds fighter weight

    <JsonProperty("Reach")>
    Public Property reach As String 'holds fighter reach

    <JsonProperty("stance")>
    Public Property stance As String 'holds fighter stance

    <JsonProperty("Dob")>
    Public Property dob As String 'holds fighter date of birth

    <JsonProperty("n_win")>
    Public Property wins As Integer 'holds fighter wins

    <JsonProperty("n_loss")>
    Public Property losses As Integer 'holds fighter losses

    <JsonProperty("n_draw")>
    Public Property draws As Integer 'holds fighter draws

    <JsonProperty("sig_str_land_pM")>
    Public Property sigstrikeslandedperminute As Double 'holds the average of their significant strikes landed per minute

    <JsonProperty("sig_str_land_pct")>
    Public Property sigstrikeslandedpercentage As Double 'holds a percentage of their significant strikes landed per minute

    <JsonProperty("sig_str_abs_pM")>
    Public Property sigstrikesabsorbedperminute As Double 'holds the average of their significant strikes absorbed per minute

    <JsonProperty("sig_str_def_pct")>
    Public Property sigstrikesdefendedpercentage As Double  'holds the percentage of their significant strikes defended per minute

    <JsonProperty("td_avg")>
    Public Property takedownavg As Double 'holds the average amount of takedowns per round

    <JsonProperty("td_land_pct")>
    Public Property takedownaccuracypercentage As Double 'holds the accuracy of takedowns

    <JsonProperty("td_def_pct")>
    Public Property takedowndefensepercentage As Double 'holds the percentage of takedowns defendeds

    <JsonProperty("sub_avg")>
    Public Property submissionavg As Double 'holds the average amount of submissions through all their fights
End Class

Public Class FighterResponse 'used to store content from api

    Public Property fighters As List(Of fighter) 'holds content from api

End Class

Public Class likedfighter 'class for liked fighters
    Public Property userid As Integer 'holds current user id
    Public Property fighterid As String 'holds current fighter id
End Class


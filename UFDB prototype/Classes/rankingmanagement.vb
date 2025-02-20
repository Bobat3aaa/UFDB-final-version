Public Class ranking
    Public Property RankingID As Integer
    Public Property UserID As Integer
    Public Property RankingName As String
    Public Property Rankingdesc As String
    Public Property Rankingdatemade As DateTime

    Public Sub New(rankingid As Integer, userid As Integer, rankingname As String, rankingdesc As String, rankingdatemade As DateTime) 'constructs new ranking
        Me.RankingID = rankingid
        Me.UserID = userid
        Me.RankingName = rankingname
        Me.Rankingdesc = rankingdesc
        Me.Rankingdatemade = rankingdatemade

    End Sub

End Class

Public Class fighterranking
    Public Property RankingID As Integer
    Public Property FighterID As String
    Public Property Rank As Integer

    Public Sub New(rankingid As Integer, fighterid As String, rank As Integer) 'constructs new fighterranking
        Me.RankingID = rankingid
        Me.FighterID = fighterid
        Me.Rank = rank
    End Sub

End Class

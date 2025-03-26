Public Class ranking 'holds ranking list
    Public Property rankingid As Integer
    Public Property userid As Integer
    Public Property rankname As String
    Public Property rankdesc As String
    Public Property rankdatemade As DateTime

    Public Sub New(rankingid As Integer, userid As Integer, rankingname As String, rankingdesc As String, rankingdatemade As DateTime) 'constructs new ranking
        Me.rankingid = rankingid
        Me.userid = userid
        Me.rankname = rankingname
        Me.rankdesc = rankingdesc
        Me.rankdatemade = rankingdatemade

    End Sub

End Class

Public Class fighterranking 'holds ranking-fighter connection 
    Public Property rankingid As Integer
    Public Property fighterid As String
    Public Property rank As Integer

    Public Sub New(rankingid As Integer, fighterid As String, rank As Integer) 'constructs new fighterranking
        Me.rankingid = rankingid
        Me.fighterid = fighterid
        Me.rank = rank
    End Sub

End Class

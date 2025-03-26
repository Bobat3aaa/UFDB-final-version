Public Class ranking 'holds ranking list
    Public Property rankingid As Integer 'primary key for ranking
    Public Property userid As Integer 'links to user id
    Public Property rankname As String 'rank name
    Public Property rankdesc As String 'rank description
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
    Public Property rankingid As Integer 'links ranking id to user id
    Public Property fighterid As String
    Public Property rank As Integer 'rank of fighter

    Public Sub New(rankingid As Integer, fighterid As String, rank As Integer) 'constructs new fighterranking
        Me.rankingid = rankingid
        Me.fighterid = fighterid
        Me.rank = rank
    End Sub

End Class

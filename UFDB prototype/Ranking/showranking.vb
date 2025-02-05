Imports Newtonsoft.Json
Imports System.IO

Public Class showranking

    Public Property formranking As ranking
    Public Sub New(currentranking As ranking)

        ' This call is required by the designer.
        InitializeComponent()
        Dim fighterranks As List(Of fighterranking) = functions.ReadFighterranksFromFile
        Dim fighterlist As List(Of fightermanagement) = functions.ReadFightersFromJson
        Dim currentuser As User = getcurrentuser()
        Dim userlist As List(Of User) = functions.ReadUsersFromJson

        Dim listusername As User = userlist.FirstOrDefault(Function(u) u.UserID = currentranking.UserID)

        For i = 1 To 10


            Dim samerank As Boolean = fighterranks.Any(Function(rf) rf.Rank = i AndAlso rf.RankingID = currentranking.RankingID)

            If samerank = True Then
                Dim ranktoadd As fighterranking = fighterranks.FirstOrDefault(Function(rf) rf.Rank = i AndAlso rf.RankingID = currentranking.RankingID)
                Dim fightertoadd As fightermanagement = fighterlist.FirstOrDefault(Function(f) f.FighterId = ranktoadd.FighterID)
                updateranks(ranktoadd, fightertoadd, i)
            End If

        Next





        ' Add any initialization after the InitializeComponent() call.

        Me.formranking = currentranking
        lbltitle.Text = formranking.RankingName
        lbldesc.Text = formranking.Rankingdesc
        Lbluserid.Text = ("Made by:" & listusername.username)

        If formranking.UserID = currentuser.UserID Then
            btndelete.Visible = True
            btndelete.Enabled = True
        End If

    End Sub
    Private Sub showranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbldesc.Click

    End Sub

    Sub updateranks(fighterrank As fighterranking, currentfighter As fightermanagement, i As Integer)

        Dim fighterpanel As Panel = (visiblepanel)
        Dim ranklbl As Label = fighterpanel.Controls("lblfighter" & i)
        If ranklbl IsNot Nothing And i = fighterrank.Rank Then

            ranklbl.Text = currentfighter.Name
        End If




    End Sub

    Function getcurrentuser()
        Dim userlist As List(Of User) = functions.ReadUsersFromJson()
        Dim currentuser As User
        currentuser = userlist.FirstOrDefault(Function(u) u.UserID = loginform.currentuserid)
        Return currentuser
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If formranking.UserID = loginform.currentuserid Then
            Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson
            Dim fighterranks As List(Of fighterranking) = functions.ReadFighterranksFromFile
            Dim rankingstoremove As List(Of ranking) = ranklist.Where(Function(r) r.RankingID = formranking.RankingID).ToList()
            Dim rankingIdsToRemove As List(Of Integer) = rankingstoremove.Select(Function(r) r.RankingID).ToList()
            fighterranks.RemoveAll(Function(fr) rankingIdsToRemove.Contains(fr.RankingID))
            ranklist.RemoveAll(Function(r) r.RankingID = formranking.RankingID)



            functions.SaveToRanklistJson(ranklist)
            functions.SaveToFighterranksJson(fighterranks)
            MsgBox("List deleted!")
            Me.Close()

        End If

    End Sub

    Private Sub Lbluserid_Click(sender As Object, e As EventArgs) Handles Lbluserid.Click

    End Sub
End Class
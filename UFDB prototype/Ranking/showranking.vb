Imports Newtonsoft.Json
Imports System.IO

Public Class showranking

    Public Property currentranking As ranking
    Public Sub New(currentranking As ranking)


        InitializeComponent()

        'shows ranking

        Dim fighterranks As List(Of fighterranking) = functions.readfighterranksfromjson
        Dim fighterlist As List(Of fighter) = functions.readfightersfromjson
        Dim currentuser As usermanagement = getcurrentuser()
        Dim userlist As List(Of usermanagement) = functions.readusersfromjson

        Dim listusername As usermanagement = userlist.FirstOrDefault(Function(u) u.userid = currentranking.userid)

        For i = 1 To 10


            Dim samerank As Boolean = fighterranks.Any(Function(rf) rf.rank = i AndAlso rf.rankingid = currentranking.rankingid)

            If samerank = True Then
                Dim ranktoadd As fighterranking = fighterranks.FirstOrDefault(Function(rf) rf.rank = i AndAlso rf.rankingid = currentranking.rankingid)
                Dim fightertoadd As fighter = fighterlist.FirstOrDefault(Function(f) f.fighterid = ranktoadd.fighterid)
                updateranks(ranktoadd, fightertoadd, i)
            End If

        Next






        Me.currentranking = currentranking
        Me.Text = Me.currentranking.rankname
        lbltitle.Text = Me.currentranking.rankname
        lbldesc.Text = Me.currentranking.rankdesc
        Lbluserid.Text = ("Made by:" & listusername.username)

        If Me.currentranking.userid = currentuser.userid Or currentuser.admin = True Then
            btndelete.Visible = True
            btndelete.Enabled = True
        End If

    End Sub


    Sub updateranks(fighterrank As fighterranking, currentfighter As fighter, i As Integer) 'renames all the ranks to the current rankings names

        Dim fighterpanel As Panel = (visiblepanel)
        Dim ranklbl As Label = fighterpanel.Controls("lblfighter" & i)
        If ranklbl IsNot Nothing And i = fighterrank.rank Then

            ranklbl.Text = currentfighter.name



        End If


    End Sub

    Function getcurrentuser()
        Dim userlist As List(Of usermanagement) = functions.readusersfromjson()
        Dim currentuser As usermanagement
        currentuser = userlist.FirstOrDefault(Function(u) u.userid = Form1.currentuserid)
        Return currentuser
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        'deletes ranking by joining ranking id between fighterranking and ranking lists
        Dim currentuser As usermanagement = getcurrentuser()
        If currentranking.userid = currentuser.userid Or currentuser.admin = True Then
            Dim ranklist As List(Of ranking) = functions.readranklistsfromjson

            Dim fighterranks As List(Of fighterranking) = functions.readfighterranksfromjson

            Dim rankingstoremove As List(Of ranking) = ranklist.Where(Function(r) r.rankingid = currentranking.rankingid).ToList() 'finds all lists to delete

            Dim rankingidstoremove As List(Of Integer) = rankingstoremove.Select(Function(r) r.rankingid).ToList()

            fighterranks.RemoveAll(Function(fr) rankingidstoremove.Contains(fr.rankingid)) 'deletes all the fighterranks where the ranking id is the same as the one made

            ranklist.RemoveAll(Function(r) r.rankingid = currentranking.rankingid)



            functions.savetoranklistjson(ranklist)
            functions.savetofighterranksjson(fighterranks)
            MsgBox("List deleted!")
            Me.Close()

        End If

    End Sub

    Private Sub showranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
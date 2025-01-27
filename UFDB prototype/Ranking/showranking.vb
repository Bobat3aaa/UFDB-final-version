﻿Imports Newtonsoft.Json
Imports System.IO

Public Class showranking

    Public Property formranking As ranking
    Public Sub New(currentranking As ranking)

        ' This call is required by the designer.
        InitializeComponent()
        Dim fighterranks As List(Of fighterranking) = functions.ReadFighterranksFromFile
        Dim fighterlist As List(Of fightermanagement) = functions.ReadFightersFromJson

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


        For i = 1 To 10

        Next


    End Sub
    Private Sub showranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbldesc.Click

    End Sub

    Sub updateranks(fighterrank As fighterranking, currentfighter As fightermanagement, i As Integer)


        Dim ranklbl As Label = Me.Controls("lblfighter" & i)
        If ranklbl IsNot Nothing And i = fighterrank.Rank Then

            ranklbl.Text = currentfighter.Name
        End If




    End Sub

End Class
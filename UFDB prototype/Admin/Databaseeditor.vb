﻿Imports Newtonsoft.Json
Imports System.IO

Public Class Databaseeditor


    Private currentfighterlist As List(Of fightermanagement)
    Private currentfightlist As List(Of Fight)


    Private Sub Databaseeditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reads jsons to populate data grid view with api data
        cmbselectview.SelectedIndex = 0
        currentfighterlist = functions.ReadFightersFromJson
        currentfightlist = functions.ReadFightsFromJson
        updatedatabase()
        Datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub



    'json editors

    Private Sub Datagridviewedit(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellEndEdit 'if something is edited, turn light pink
        Datagridview.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightPink
    End Sub

    Private Sub Datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellContentClick

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub cmbselectview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbselectview.SelectedIndexChanged

        'makes sure changes are saved before switching views
        If currentfighterlist IsNot Nothing And currentfightlist IsNot Nothing Then
            Debug.WriteLine(cmbselectview.SelectedIndex)
            Dim answer = MessageBox.Show("Do you want to save changes before switching?", "Save Changes", MessageBoxButtons.YesNo)
            If answer = DialogResult.Yes Then
                savedatabase()
                MsgBox("data saved!")
            ElseIf answer = DialogResult.No Then
                refreshdatabase()
            End If
            updatedatabase()
        End If



    End Sub


    Private Sub btnsavefile_Click(sender As Object, e As EventArgs) Handles btnsavefile.Click

        'saves file based on what view is shown
        If cmbselectview.SelectedIndex = 0 Then
            functions.SaveToFighterJson(currentfighterlist)
        ElseIf cmbselectview.SelectedIndex = 1 Then
            functions.SaveToFightJson(currentfightlist)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'removes row
        If Datagridview.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Datagridview.SelectedRows
                Datagridview.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'selects latest row as it has nothing in it
        Dim lastRow As Integer = Datagridview.Rows.Count - 1
        If lastRow >= 0 Then
            Datagridview.CurrentCell = Datagridview.Rows(lastRow).Cells(0)
            Datagridview.FirstDisplayedScrollingRowIndex = lastRow
        End If
    End Sub


    Sub updatedatabase()
        'updates view
        If cmbselectview.SelectedIndex = 0 Then
            Datagridview.Refresh()
            Datagridview.DataSource = New BindingSource(currentfighterlist, Nothing)
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 1 Then
            Datagridview.Refresh()
            Datagridview.DataSource = New BindingSource(currentfightlist, Nothing)
        End If
    End Sub
    Sub refreshdatabase()
        'refreshes database depending on if you want to save or not
        If cmbselectview.SelectedIndex = 1 Then
            currentfighterlist = functions.ReadFightersFromJson
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            currentfightlist = functions.ReadFightsFromJson
        End If
    End Sub

    Sub savedatabase()
        'saves database when changing views
        If cmbselectview.SelectedIndex = 1 Then
            functions.SaveToFighterJson(currentfighterlist)
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            functions.SaveToFightJson(currentfightlist)
        End If
    End Sub

End Class
Imports Newtonsoft.Json
Imports System.IO

Public Class Databaseeditor


    Private fighterlist As List(Of fightermanagement)
    Private fightlist As List(Of Fight)


    Private Sub Databaseeditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbselectview.SelectedIndex = 0
        fighterlist = functions.ReadFightersFromJson
        fightlist = functions.ReadFightsFromJson
        updatedatabase()
        Datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub



    'json editors

    Private Sub Datagridviewedit(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellEndEdit
        Datagridview.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightPink
    End Sub

    Private Sub Datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellContentClick

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub cmbselectview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbselectview.SelectedIndexChanged

        If fighterlist IsNot Nothing And fightlist IsNot Nothing Then
            Debug.WriteLine(cmbselectview.SelectedIndex)
            Dim answer = MessageBox.Show("Do you want to save changes before switching?", "Save Changes", MessageBoxButtons.YesNo)
            If answer = DialogResult.Yes Then
                savedatabase()
                MsgBox("data saved!")
            ElseIf answer = DialogResult.no Then
                refreshdatabase()
            End If
            updatedatabase()
        End If



    End Sub


    Private Sub btnsavefile_Click(sender As Object, e As EventArgs) Handles btnsavefile.Click

        If cmbselectview.SelectedIndex = 0 Then
            functions.SaveToFighterJson(fighterlist)
        ElseIf cmbselectview.SelectedIndex = 1 Then
            functions.SaveToFightJson(fightlist)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If Datagridview.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Datagridview.SelectedRows
                Datagridview.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim lastRow As Integer = Datagridview.Rows.Count - 1
        If lastRow >= 0 Then
            Datagridview.CurrentCell = Datagridview.Rows(lastRow).Cells(0)
            Datagridview.FirstDisplayedScrollingRowIndex = lastRow
        End If
    End Sub


    Sub updatedatabase()
        If cmbselectview.SelectedIndex = 0 Then
            Datagridview.Refresh()
            Datagridview.DataSource = New BindingSource(fighterlist, Nothing)
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 1 Then
            Datagridview.Refresh()
            Datagridview.DataSource = New BindingSource(fightlist, Nothing)
        End If
    End Sub
    Sub refreshdatabase()
        If cmbselectview.SelectedIndex = 1 Then
            fighterlist = functions.ReadFightersFromJson
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            fightlist = functions.ReadFightsFromJson
        End If
    End Sub

    Sub savedatabase()
        If cmbselectview.SelectedIndex = 1 Then
         functions.SaveToFighterJson(fighterlist)
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            functions.SaveToFightJson(fightlist)
        End If
    End Sub

End Class
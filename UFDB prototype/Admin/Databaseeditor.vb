Imports Newtonsoft.Json
Imports System.IO

Public Class Databaseeditor


    Private fighterlist As List(Of Fighter)

    Private Sub Databaseeditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fighterlist = ReadfightersFromFile()
        Datagridview.DataSource = New BindingSource(fighterlist, Nothing)
        Datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub



    'json editors
    Function ReadfightersFromFile() As List(Of Fighter)
        If Not File.Exists("fighters_page.json") Then
            Return New List(Of Fighter)
        End If
        Dim json As String = File.ReadAllText("fighters_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of Fighter))(json)
    End Function
    Private Sub Datagridviewedit(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellEndEdit
        Datagridview.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightPink
    End Sub

    Private Sub Datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellContentClick

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub cmbselectview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbselectview.SelectedIndexChanged

    End Sub

    Private Sub SaveToJsonFile(sortedfighters As List(Of Fighter))
        Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub btnsavefile_Click(sender As Object, e As EventArgs) Handles btnsavefile.Click
        SaveToJsonFile(fighterlist)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If Datagridview.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Datagridview.SelectedRows
                Datagridview.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

    End Sub
End Class
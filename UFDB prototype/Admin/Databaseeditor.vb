Imports Newtonsoft.Json
Imports System.IO

Public Class Databaseeditor


    Private fighterlist As List(Of Fighter)
    Private fightlist As List(Of Fight)


    Private Sub Databaseeditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbselectview.SelectedIndex = 0
        fighterlist = ReadfightersFromFile()
        fightlist = ReadfightsFromFile()
        updatedatabase()
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

    Private Sub SaveTofighterJsonFile(sortedfighters As List(Of Fighter))
        Dim json As String = JsonConvert.SerializeObject(sortedfighters, Formatting.Indented)
        Dim filePath As String = $"fighters_page.json"
        File.WriteAllText(filePath, json)
        ' MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Private Sub btnsavefile_Click(sender As Object, e As EventArgs) Handles btnsavefile.Click

        If cmbselectview.SelectedIndex = 0 Then
            SaveTofighterJsonFile(fighterlist)
        ElseIf cmbselectview.SelectedIndex = 1 Then
            SaveTofightJsonFile(fightlist)
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

    End Sub
    Function ReadfightsFromFile() As List(Of Fight)
        If Not File.Exists("fights_page.json") Then
            Return New List(Of Fight)
        End If
        Dim json As String = File.ReadAllText("fights_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of Fight))(json)
    End Function
    Private Sub SaveTofightJsonFile(allfights As List(Of Fight))
        Dim json As String = JsonConvert.SerializeObject(allfights, Formatting.Indented)
        Dim filePath As String = $"fights_page.json"
        File.WriteAllText(filePath, json)

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
            fighterlist = ReadfightersFromFile()
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            fightlist = ReadfightsFromFile()
        End If
    End Sub

    Sub savedatabase()
        If cmbselectview.SelectedIndex = 1 Then
            SaveTofighterJsonFile(fighterlist)
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            SaveTofightJsonFile(fightlist)
        End If
    End Sub

End Class
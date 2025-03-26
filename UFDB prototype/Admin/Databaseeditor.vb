Imports Newtonsoft.Json
Imports System.ComponentModel.Design
Imports System.IO
Imports System.Text

Public Class databaseeditor


    Private currentfighterlist As List(Of fighter)
    Private currentfightlist As List(Of Fight)


    Private Sub Databaseeditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reads jsons to populate data grid view with api data
        cmbselectview.SelectedIndex = 0
        currentfighterlist = functions.readfightersfromjson
        currentfightlist = functions.readfightsfromjson


        updatedatabase()


        Datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Datagridview.Columns(0).ReadOnly = True
    End Sub



    'json editors
    Private Sub Datagrid_viewedoredited(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellEndEdit 'if something is edited, turn light pink
        Datagridview.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightPink
    End Sub


    Function fightorfighterid(decision As Boolean)

        Dim random As New Random
        Dim charlist As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder

        'creates string for 
        If decision = True Then
            For i = 0 To 15
                Dim index As Integer = random.Next(0, charlist.Length)
                sb.Append(charlist.Substring(index, 1))
            Next
        ElseIf decision = False Then
            For i = 0 To 23
                Dim index As Integer = random.Next(0, charlist.Length)
                sb.Append(charlist.Substring(index, 1))
            Next
        End If



        Return sb.ToString()

    End Function


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
            functions.savetofighterjson(currentfighterlist)
        ElseIf cmbselectview.SelectedIndex = 1 Then
            functions.savetofightjson(currentfightlist)
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





        Dim lastRow As Integer = Datagridview.Rows.Count - 2




        Dim check As Boolean = False
                                         Dim editedvaluecolumn As String = Datagridview.Columns(0).Name
            Dim id As String
            Dim newfight As New Fight
            Dim newfighter As New fighter

        If editedvaluecolumn = "fighterid" Then

            currentfighterlist.Add(newfighter)



        ElseIf editedvaluecolumn = "id" Then

            currentfightlist.Add(newfight)

            End If


        Do 'loop to make sure the id isnt the same as someone elses
            If editedvaluecolumn = "fighterid" Then 'add fighterid
                id = fightorfighterid(True)
                check = idcheck(True, id)
                If check = False Then
                    newfighter.fighterid = id
                End If



            ElseIf editedvaluecolumn = "id" Then 'add fightid
                id = fightorfighterid(False)
                check = idcheck(False, id)

                newfight.id = id
            End If



        Loop While check = True





        updatedatabase()
        Datagridview.Refresh()


        Datagridview.FirstDisplayedScrollingRowIndex = lastRow

    End Sub

    Function idcheck(decision As Boolean, id As String) 'checks whether ID is already in use

        Dim check As Boolean
        If decision = True Then
            check = currentfighterlist.Any(Function(cf) cf.fighterid = id)


        ElseIf decision = False Then

            check = currentfightlist.Any(Function(cf) cf.id = id)


        End If


        Return check
    End Function


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
            currentfighterlist = functions.readfightersfromjson
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            currentfightlist = functions.readfightsfromjson
        End If
    End Sub

    Sub savedatabase()
        'saves database when changing views
        If cmbselectview.SelectedIndex = 1 Then
            functions.savetofighterjson(currentfighterlist)
            Refresh()
        ElseIf cmbselectview.SelectedIndex = 0 Then
            functions.savetofightjson(currentfightlist)
        End If
    End Sub

End Class
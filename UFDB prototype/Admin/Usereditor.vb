Public Class Usereditor

    Private userlist As List(Of User)
    Private ranklist As List(Of ranking)
    Private fighterranklist As List(Of fighterranking)
    Private likedfighterlist As List(Of likedfighter)

    Private Sub Usereditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        userlist = functions.ReadUsersFromJson
        ranklist = functions.ReadRanklistsFromJson
        fighterranklist = functions.ReadFighterranksFromFile
        likedfighterlist = functions.ReadlikedfightersFromJson


        updatedatabase()
        Datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub updatedatabase()
        Datagridview.Refresh()
        Datagridview.DataSource = New BindingSource(userlist, Nothing)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim lastRow As Integer = Datagridview.Rows.Count - 1

        If lastRow >= 0 And Datagridview.CurrentRow.Cells(0).Value Is Nothing Then
            Datagridview.CurrentCell = Datagridview.Rows(lastRow).Cells(0)
            Datagridview.FirstDisplayedScrollingRowIndex = lastRow
        Else


            Datagridview.CurrentCell = Datagridview.Rows(lastRow).Cells(0)
            Datagridview.FirstDisplayedScrollingRowIndex = lastRow
        End If
        Dim nextuserid As Integer = GetNextUserID(userlist)
        Datagridview.CurrentRow.Cells(0).Value = nextuserid
    End Sub
    Function GetNextUserID(users As List(Of User)) As Integer
        If users.Count = 0 Then
            Return 1
        End If

        Return users.Max(Function(u) u.UserID) + 1
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If Datagridview.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Datagridview.SelectedRows
                Datagridview.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnsavefile_Click(sender As Object, e As EventArgs) Handles btnsavefile.Click

        functions.SaveUsersToJson(userlist)
        functions.SaveToFighterranksJson(fighterranklist)
        functions.SaveTolikedfighterJson(likedfighterlist)
        functions.SaveToRanklistJson(ranklist)
    End Sub
End Class
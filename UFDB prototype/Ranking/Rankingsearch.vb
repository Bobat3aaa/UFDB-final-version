Imports Newtonsoft.Json
Imports System.Configuration

Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Rankingsearch
    Private currentranklist As List(Of ranking)
    Private mainendindex As Integer






    Private Sub Rankingsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = ranklist.Count - 1


        Dim sortedranklist As List(Of ranking) = Quicksort(ranklist, indexlow, indexhigh)
        functions.SaveToRanklistJson(sortedranklist)
        currentranklist = sortedranklist

        updatebuttons(currentranklist)

    End Sub



    Sub updatebuttons(ranklist As List(Of ranking), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()
        Dim userlist As List(Of usermanagement) = functions.ReadUsersFromJson

        currentranklist = ranklist

        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
        Dim endIndex As Integer = Math.Min(startIndex + count, ranklist.Count)
        mainendindex = endIndex


        If startIndex > 0 Then


            Dim btnback As New Button
            btnback.Width = 100
            btnback.Height = 50
            btnback.BackColor = Color.Red
            btnback.ForeColor = Color.White
            btnback.Font = New Font(btnback.Font.FontFamily, btnback.Font.Size + 2)
            btnback.TextAlign = ContentAlignment.MiddleCenter

            btnback.Text = "back"
            btnback.Visible = True
            btnback.Tag = "btnback"

            'adds an event handler to update buttons
            AddHandler btnback.Click, AddressOf btnbackclick
            FlowLayoutPanel1.Controls.Add(btnback)


        End If


        'creates 50 buttons
        For i = startIndex To endIndex - 1

            Dim user As usermanagement = userlist.FirstOrDefault(Function(u) u.UserID = ranklist(i).UserID)


            Dim btnlists As New Button
            btnlists.Width = 100
            btnlists.Height = 100
            btnlists.BackColor = Color.White
            btnlists.TextAlign = ContentAlignment.MiddleCenter

            btnlists.Text = ranklist(i).RankingName & vbCrLf & "Made by:" & user.username & vbCrLf & ranklist(i).Rankingdatemade
            btnlists.Visible = True
            btnlists.Tag = i
            currentranklist = ranklist



            AddHandler btnlists.Click, AddressOf btnlistclick

            FlowLayoutPanel1.Controls.Add(btnlists)


        Next

        'creates a load more button if needed
        If endIndex < ranklist.Count Then


            Dim btnloadmore As New Button
            btnloadmore.Width = 100
            btnloadmore.Height = 50
            btnloadmore.TextAlign = ContentAlignment.MiddleCenter
            btnloadmore.BackColor = Color.Red
            btnloadmore.ForeColor = Color.White
            btnloadmore.Font = New Font(btnloadmore.Font.FontFamily, btnloadmore.Font.Size + 2)
            btnloadmore.TextAlign = ContentAlignment.MiddleCenter

            btnloadmore.Text = "Load more"
            btnloadmore.Visible = True
            btnloadmore.Tag = "btnloadmore"

            'adds an event handler to update buttons
            AddHandler btnloadmore.Click, AddressOf btnloadmoreclick
            FlowLayoutPanel1.Controls.Add(btnloadmore)


        End If

    End Sub
    Private Sub btnloadmoreclick(sender As Object, e As EventArgs)
        updatebuttons(currentranklist, mainendindex)
    End Sub
    Private Sub btnbackclick(sender As Object, e As EventArgs)
        updatebuttons(currentranklist, mainendindex - 100)
    End Sub

    Private Sub btnlistclick(sender As Object, e As EventArgs)

        'holds what button was just pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets the tag of ranking/button
        Dim rankIndex As Integer = Convert.ToInt32(clickedButton.Tag)


        'find button via quicksort and using index from tag
        Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = ranklist.Count - 1


        Dim sortedranklist As List(Of ranking) = Quicksort(ranklist, indexlow, indexhigh)


        'finds current ranking
        Dim currentranking As ranking = sortedranklist(rankIndex)



        'opens cureentranking form with ranking chosen
        Dim rankingform As New showranking(currentranking)


        'show rankingform
        rankingform.Show()

    End Sub

    Function Quicksort(ranklist As List(Of ranking), indexlow As Integer, indexhigh As Integer) As List(Of ranking) 'quicksort used in other forms

        Try


            Dim pivot As String
            Dim templow As Integer = indexlow
            Dim temphigh As Integer = indexhigh

            If ranklist Is Nothing Or ranklist.Count <= 0 Then
                Return New List(Of ranking)
            Else



                pivot = ranklist(Int((indexlow + indexhigh) / 2)).RankingName

                While templow <= temphigh
                    While String.Compare(ranklist(templow).RankingName, pivot) < 0
                        templow += 1
                    End While

                    While String.Compare(ranklist(temphigh).RankingName, pivot) > 0
                        temphigh -= 1
                    End While

                    If templow <= temphigh Then
                        Dim temprank As ranking = ranklist(templow)
                        ranklist(templow) = ranklist(temphigh)
                        ranklist(temphigh) = temprank
                        templow += 1
                        temphigh -= 1
                    End If
                End While





                If indexlow <= temphigh Then
                    Quicksort(ranklist, indexlow, temphigh)
                End If

                If templow < indexhigh Then
                    Quicksort(ranklist, templow, indexhigh)
                End If

                Return ranklist
            End If
        Catch ex As Exception
            MsgBox("Error occured with quicksorting rank lists:" & ex.Message)
            Return New List(Of ranking)
        End Try
    End Function

    Function bsearchranklist(ranklist As List(Of ranking), nametofind As String, indexlow As Integer, indexhigh As Integer)
        Try


            'binary search, returns midpoint which is place in list
            If indexlow > indexhigh Then
                Debug.WriteLine(4)
                Return -1

            End If

            Dim midpoint As Integer = (indexlow + indexhigh) \ 2

            If String.Compare(ranklist(midpoint).RankingName, nametofind) < 0 Then

                Debug.WriteLine(ranklist(midpoint).RankingName)
                Return bsearchranklist(ranklist, nametofind, midpoint + 1, indexhigh)

            ElseIf String.Compare(ranklist(midpoint).RankingName, nametofind) > 0 Then

                Debug.WriteLine(ranklist(midpoint).RankingName)
                Return bsearchranklist(ranklist, nametofind, indexlow, midpoint - 1)

            ElseIf ranklist(midpoint).RankingName = nametofind Then

                Debug.WriteLine(ranklist(midpoint).RankingName)
                Return midpoint



            End If
        Catch ex As Exception
            MsgBox("Error occured with binary searching rank lists:" & ex.Message)
            Return New List(Of ranking)
        End Try
    End Function

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        'uses binary search used in previous forms
        Dim nametofind As String = txtlistname.Text
        Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = ranklist.Count - 1
        Dim searchedrankindex As Integer
        Dim searchedranklist As New List(Of ranking)




        searchedrankindex = bsearchranklist(ranklist, nametofind, indexlow, indexhigh)



        If searchedrankindex <> -1 Then
            searchedranklist.Clear()
            searchedranklist.Add(currentranklist(searchedrankindex))
            currentranklist = searchedranklist

        End If


        updatebuttons(searchedranklist)




    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim ranklist As List(Of ranking) = functions.ReadRanklistsFromJson
        updatebuttons(ranklist)
    End Sub

    Private Sub cmbownlists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbownlists.SelectedIndexChanged

        Dim filteredlist As List(Of ranking) = checkfilters(currentranklist)
        If filteredlist IsNot Nothing Then
            updatebuttons(filteredlist)
        Else
            updatebuttons(currentranklist)
        End If
    End Sub
    Function checkfilters(ranklist As List(Of ranking))


        Try

            Dim ownrank As String = ""


            If cmbownlists.SelectedItem IsNot Nothing Then
                ownrank = cmbownlists.SelectedItem
                Debug.WriteLine(ownrank)
            End If


            ' Filter lists based on whether they contain your current user id

            Dim filteredlist As List(Of ranking) = Nothing
            If ownrank <> "No" Then
                filteredlist = ranklist.Where(Function(r) r.UserID = loginform.currentuserid).ToList()
            End If



            Return filteredlist
        Catch ex As Exception
            MsgBox("Error occured with filter checking rank lists:" & ex.Message)
            Return New List(Of ranking)
        End Try
    End Function

    Private Sub txtlistname_TextChanged(sender As Object, e As EventArgs) Handles txtlistname.TextChanged

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
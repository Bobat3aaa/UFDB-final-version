Imports Newtonsoft.Json

Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Rankingsearch
    Dim globalranklist As List(Of ranking)



    Function ReadranklistsFromFile() As List(Of ranking)
        If Not File.Exists("ranklists.json") Then
            Return New List(Of ranking)
        End If
        Dim json As String = File.ReadAllText("ranklists.json")
        Return JsonConvert.DeserializeObject(Of List(Of ranking))(json)
    End Function
    Private Sub SaveToranklistJson(rankedlists As List(Of ranking))
        Dim json As String = JsonConvert.SerializeObject(rankedlists, Formatting.Indented)
        Dim filePath As String = $"ranklists.json"
        File.WriteAllText(filePath, json)

    End Sub


    Private Sub Rankingsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ranklist As List(Of ranking) = ReadranklistsFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = ranklist.Count - 1


        Dim sortedranklist As List(Of ranking) = Quicksort(ranklist, indexlow, indexhigh)
        SaveToranklistJson(sortedranklist)
        globalranklist = sortedranklist

        updatebuttons(globalranklist)

    End Sub



    Sub updatebuttons(sortedranklist As List(Of ranking), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()




        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
        Dim endIndex As Integer = Math.Min(startIndex + count, sortedranklist.Count)



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
            AddHandler btnback.Click, Sub()
                                          updatebuttons(sortedranklist, endIndex - 100)
                                      End Sub
            FlowLayoutPanel1.Controls.Add(btnback)


        End If


        'creates 50 buttons
        For i = startIndex To endIndex - 1


            Dim btn As New Button
            btn.Width = 100
            btn.Height = 50
            btn.BackColor = Color.White
            btn.TextAlign = ContentAlignment.MiddleCenter

            btn.Text = sortedranklist(i).RankingName
            btn.Visible = True
            btn.Tag = i
            globalranklist = sortedranklist



            AddHandler btn.Click, AddressOf Button_Click

            FlowLayoutPanel1.Controls.Add(btn)


        Next

        'creates a load more button if needed
        If endIndex < sortedranklist.Count Then


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
            AddHandler btnloadmore.Click, Sub()
                                              updatebuttons(sortedranklist, endIndex)
                                          End Sub
            FlowLayoutPanel1.Controls.Add(btnloadmore)


        End If

    End Sub


    'when a button in the flow control panel is picked (fighter edition
    Private Sub Button_Click(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag of button which is the fighters place in the list
        Dim rankIndex As Integer = Convert.ToInt32(clickedButton.Tag)

        'need to find a way to optimise / reuse code

        Dim ranklist As List(Of ranking) = ReadranklistsFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = ranklist.Count - 1


        Dim sortedranklist As List(Of ranking) = Quicksort(ranklist, indexlow, indexhigh)


        'finds current fighter
        Dim currentranking As ranking = sortedranklist(rankIndex)

        'sends current fighter data over to the current fighter form



        Dim rankingform As New showranking(currentranking)



        rankingform.Show()
    End Sub

    Function Quicksort(ranklist As List(Of ranking), indexlow As Integer, indexhigh As Integer) As List(Of ranking)

        Dim pivot As String
        Dim templow As Integer = indexlow
        Dim temphigh As Integer = indexhigh





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
    End Function

    Function bsearchranklist(ranklist As List(Of ranking), nametofind As String, indexlow As Integer, indexhigh As Integer)

        'binary search, returns midpoint which is place in list
        If indexlow > indexhigh Then
            Debug.WriteLine(4)
            Return -1

        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2

        If String.Compare(ranklist(midpoint).RankingName, nametofind) < 0 Then
            Debug.WriteLine(1)
            Debug.WriteLine(ranklist(midpoint).RankingName)
            Return bsearchranklist(ranklist, nametofind, midpoint + 1, indexhigh)

        ElseIf String.Compare(ranklist(midpoint).RankingName, nametofind) > 0 Then
            Debug.WriteLine(2)
            Debug.WriteLine(ranklist(midpoint).RankingName)
            Return bsearchranklist(ranklist, nametofind, indexlow, midpoint - 1)

        ElseIf ranklist(midpoint).RankingName = nametofind Then
            Debug.WriteLine(3)
            Debug.WriteLine(ranklist(midpoint).RankingName)
            Return midpoint



        End If
    End Function

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        Dim nametofind As String = txtlistname.Text
        Dim ranklist As List(Of ranking) = ReadranklistsFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = ranklist.Count - 1
        Dim searchedrankindex As Integer
        Dim searchedranklist As New List(Of ranking)
        searchedrankindex = bsearchranklist(ranklist, nametofind, indexlow, indexhigh)
        Debug.WriteLine(searchedrankindex)


        If searchedrankindex <> -1 Then
            searchedranklist.Clear()
            searchedranklist.Add(globalranklist(searchedrankindex))
            globalranklist = searchedranklist

        End If


        updatebuttons(searchedranklist)




    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim ranklist As List(Of ranking) = ReadranklistsFromFile()
        updatebuttons(ranklist)
    End Sub

    Private Sub cmbownlists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbownlists.SelectedIndexChanged

        Dim filteredlist As List(Of ranking) = checkfilters(globalranklist)
        If filteredlist IsNot Nothing Then
            updatebuttons(filteredlist)
        Else
            updatebuttons(globalranklist)
        End If
    End Sub
    Function checkfilters(ranklist As List(Of ranking))
        Dim ownrank As String


        If cmbownlists.SelectedItem IsNot Nothing Then
            ownrank = cmbownlists.SelectedItem
            Debug.WriteLine(ownrank)
        End If


        ' Filter fighters based on the selected weight class

        Dim filteredlist As List(Of ranking)
        If ownrank <> "No" Then
            filteredlist = ranklist.Where(Function(r) r.UserID = loginform.currentuserid).ToList()
        End If



        Return filteredlist

    End Function
End Class
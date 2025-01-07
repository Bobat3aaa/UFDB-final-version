Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions


Public Class fight_form
    Dim fightlist As List(Of Fight)
    Private Sub fight_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim allFights As New List(Of Fight)
        Using httpclient As New HttpClient()

            For i = 1 To 5
                Dim apiurl As String = $"https://ufc-api-theta.vercel.app/mma-api/fights?page=" & i

                Dim answer As HttpResponseMessage = httpclient.GetAsync(apiurl).Result

                If answer.IsSuccessStatusCode Then

                    'turns api into string
                    Dim responsecontent As String = answer.Content.ReadAsStringAsync().Result




                    Dim response As FightsResponse = JsonConvert.DeserializeObject(Of FightsResponse)(responsecontent)

                    allFights.AddRange(response.fights)



                Else
                    MessageBox.Show("Error getting API data")
                End If
            Next
            SaveToJsonFile(allFights)
        End Using

        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True


        Dim fights As List(Of Fight) = ReadfightsFromFile()
        Dim ilow As Integer = 0
        Dim ihigh As Integer = fights.Count - 1

        Dim sortedfights As List(Of Fight) = mergesortevents(fights, ilow, ihigh)
        SaveToJsonFile(sortedfights)
        fightlist = sortedfights
        updatebuttons(sortedfights)
    End Sub


    'when a button in the flow control panel is picked (fighter edition
    Private Sub Button_Click(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag of button which is the fighters place in the list
        Dim fightIndex As Integer = Convert.ToInt32(clickedButton.Tag)

        'need to find a way to optimise / reuse code





        'finds current fighter
        Dim currentfight As Fight = fightlist(fightIndex)

        'sends current fighter data over to the current fighter form
        Dim fightForm As New currentFightForm(currentfight)






        fightForm.Show()
        Me.Hide()
    End Sub

    Private Sub SaveToJsonFile(allfights As List(Of Fight))
        Dim json As String = JsonConvert.SerializeObject(allfights, Formatting.Indented)
        Dim filePath As String = $"fights_page.json"
        File.WriteAllText(filePath, json)
        MessageBox.Show($"Data saved to {filePath}")
    End Sub

    Function ReadfightsFromFile() As List(Of Fight)
        If Not File.Exists("fights_page.json") Then
            Return New List(Of Fight)
        End If
        Dim json As String = File.ReadAllText("fights_page.json")
        Return JsonConvert.DeserializeObject(Of List(Of Fight))(json)
    End Function


    Function mergesortevents(ByRef fights As List(Of Fight), ilow As Integer, ihigh As Integer) As List(Of Fight)
        If ilow >= ihigh Then
            Return fights
        Else
            Dim imiddle As Integer = ilow + (ihigh - ilow) \ 2
            mergesortevents(fights, ilow, imiddle)
            mergesortevents(fights, imiddle + 1, ihigh)
            fights = mergeeventsdesc(fights, ilow, imiddle, ihigh)
            Return fights
        End If
    End Function


    'ascending order
    Function mergeeventsasc(ByRef fights As List(Of Fight), ilow As Integer, imiddle As Integer, ihigh As Integer) As List(Of Fight)
        Dim upperleft As Integer = imiddle - ilow + 1
        Dim upperright As Integer = ihigh - imiddle

        Dim fightslefthalf(upperleft - 1) As Fight
        Dim fightsrighthalf(upperright - 1) As Fight

        Dim pointer1 As Integer
        Dim pointer2 As Integer
        Dim pointer3 As Integer

        For pointer1 = 0 To upperleft - 1
            fightslefthalf(pointer1) = fights(ilow + pointer1)
        Next

        For pointer2 = 0 To upperright - 1
            fightsrighthalf(pointer2) = fights(imiddle + 1 + pointer2)
        Next

        pointer1 = 0
        pointer2 = 0
        pointer3 = ilow

        While pointer1 < upperleft AndAlso pointer2 < upperright
            If DateTime.Compare(fightslefthalf(pointer1).date, fightsrighthalf(pointer2).date) <= 0 Then
                fights(pointer3) = fightslefthalf(pointer1)
                pointer1 += 1
            Else
                fights(pointer3) = fightsrighthalf(pointer2)
                pointer2 += 1
            End If
            pointer3 += 1
        End While

        While pointer1 < upperleft
            fights(pointer3) = fightslefthalf(pointer1)
            pointer1 += 1
            pointer3 += 1
        End While

        While pointer2 < upperright
            fights(pointer3) = fightsrighthalf(pointer2)
            pointer2 += 1
            pointer3 += 1
        End While

        Return fights
    End Function

    Function mergeeventsdesc(ByRef fights As List(Of Fight), ilow As Integer, imiddle As Integer, ihigh As Integer) As List(Of Fight)
        Dim upperleft As Integer = imiddle - ilow + 1
        Dim upperright As Integer = ihigh - imiddle

        Dim fightslefthalf(upperleft - 1) As Fight
        Dim fightsrighthalf(upperright - 1) As Fight

        Dim pointer1 As Integer
        Dim pointer2 As Integer
        Dim pointer3 As Integer

        For pointer1 = 0 To upperleft - 1
            fightslefthalf(pointer1) = fights(ilow + pointer1)
        Next

        For pointer2 = 0 To upperright - 1
            fightsrighthalf(pointer2) = fights(imiddle + 1 + pointer2)
        Next

        pointer1 = 0
        pointer2 = 0
        pointer3 = ilow

        ' Change comparison to sort in descending order
        While pointer1 < upperleft AndAlso pointer2 < upperright
            If DateTime.Compare(fightslefthalf(pointer1).date, fightsrighthalf(pointer2).date) >= 0 Then
                fights(pointer3) = fightslefthalf(pointer1)
                pointer1 += 1
            Else
                fights(pointer3) = fightsrighthalf(pointer2)
                pointer2 += 1
            End If
            pointer3 += 1
        End While

        While pointer1 < upperleft
            fights(pointer3) = fightslefthalf(pointer1)
            pointer1 += 1
            pointer3 += 1
        End While

        While pointer2 < upperright
            fights(pointer3) = fightsrighthalf(pointer2)
            pointer2 += 1
            pointer3 += 1
        End While

        Return fights
    End Function


    Private Sub btnsort_Click(sender As Object, e As EventArgs) Handles btnsort.Click

    End Sub

    Sub updatebuttons(sortedfights As List(Of Fight), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()




        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fighters
        Dim endIndex As Integer = Math.Min(startIndex + count, sortedfights.Count)

        'creates 50 buttons
        For i = startIndex To endIndex - 1


            Dim btn As New Button
            btn.Width = 100
            btn.Height = 100
            btn.TextAlign = ContentAlignment.MiddleCenter

            btn.Text = sortedfights(i).event_name & vbCrLf & " " & sortedfights(i).fighter1 & vbCrLf & " VS " & vbCrLf & sortedfights(i).fighter2
            btn.Visible = True
            btn.Tag = i


            AddHandler btn.Click, AddressOf Button_Click

            FlowLayoutPanel1.Controls.Add(btn)


        Next

        'creates a load more button if needed
        If endIndex < sortedfights.Count Then


            Dim btnloadmore As New Button
            btnloadmore.Width = 100
            btnloadmore.Height = 50
            btnloadmore.TextAlign = ContentAlignment.MiddleCenter

            btnloadmore.Text = "Load more"
            btnloadmore.Visible = True
            btnloadmore.Tag = "btnloadmore"

            'adds an event handler to update buttons
            AddHandler btnloadmore.Click, Sub()
                                              updatebuttons(sortedfights, endIndex)
                                          End Sub
            FlowLayoutPanel1.Controls.Add(btnloadmore)


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsearch.Click



        Dim fights As List(Of Fight) = ReadfightsFromFile()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fights.Count - 1


        Dim numtofind As Integer = txteventnum.Text


        Dim searchedfights As List(Of Fight) = bsearchevent(fights, numtofind, indexlow, indexhigh)
        fightlist = searchedfights


        updatebuttons(searchedfights)
    End Sub

    'Function bsearchevent(fightlist As List(Of Fight), numtofind As Integer, indexlow As Integer, indexhigh As Integer)

    '    'binary search, returns midpoint which is place in list
    '    If indexlow > indexhigh Then
    '        Return New List(Of Fight())
    '    End If

    '    Dim midpoint As Integer = (indexlow + indexhigh) \ 2
    '    Dim currentfight As Fight = fightlist(midpoint)


    '    Dim currenteventnumber As Integer? = ParseEventNumber(currentfight.event_name)

    '    If Not currenteventnumber.HasValue Then

    '        If midpoint > indexlow Then
    '            Return bsearchevent(fightlist, numtofind, indexlow, midpoint - 1)
    '        End If
    '        If midpoint < indexhigh Then
    '            Return bsearchevent(fightlist, numtofind, midpoint + 1, indexhigh)
    '        End If
    '        Return New List(Of Fight)
    '    End If


    '    If currenteventnumber < numtofind Then
    '        Return bsearchevent(fightlist, numtofind, midpoint + 1, indexhigh)
    '    ElseIf currenteventnumber > numtofind Then
    '        Return bsearchevent(fightlist, numtofind, indexlow, midpoint - 1)
    '    Else

    '        'once binary search is finished, starts a new list of fights to find all relevant results




    '        Dim searchedfights As New List(Of Fight)
    '        searchedfights.Add(currentfight)


    '        'searches left


    '        Dim left As Integer = midpoint - 1
    '        While left >= indexlow
    '            Dim lefteventnum As Integer? = ParseEventNumber(fightlist(left).event_name)
    '            'makes sure fight nights are ignored
    '            If lefteventnum.HasValue AndAlso lefteventnum = numtofind Then
    '                searchedfights.Add(fightlist(left))

    '            ElseIf leftEventNum.HasValue AndAlso leftEventNum <> numToFind Then
    '                Exit While
    '            End If
    '            left -= 1

    '        End While
    '        'searches right
    '        Dim right As Integer = midpoint + 1


    '        While right <= indexhigh
    '            Dim righteventnum As Integer? = ParseEventNumber(fightlist(right).event_name)
    '            'makes sure fight nights are ignored
    '            If righteventnum.HasValue AndAlso righteventnum = numtofind Then
    '                searchedfights.Add(fightlist(right))

    '            ElseIf righteventnum.HasValue AndAlso righteventnum <> numtofind Then
    '                Exit While
    '            End If
    '            right = +1
    '        End While

    '        Return searchedfights



    '    End If
    'End Function



    Public Function bsearchevent(fightlist As List(Of Fight), numtofind As Integer, indexlow As Integer, indexhigh As Integer) As List(Of Fight)



        If indexlow > indexhigh Then
            Return New List(Of Fight)()
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2
        Dim currentfight As Fight = fightlist(midpoint)

        'gets event number
        Dim currenteventnumber As Integer? = ParseEventNumber(currentfight.event_name)

        'if parsing returns nothing, skips the fight
        If Not currenteventnumber.HasValue Then


            Dim newfightlist As New List(Of Fight)()


            'adds fights to new list but without skipped fight
            newfightlist.AddRange(bsearchevent(fightlist, numtofind, indexlow, midpoint - 1))
            newfightlist.AddRange(bsearchevent(fightlist, numtofind, midpoint + 1, indexhigh))
            Return newfightlist
        End If

        If currenteventnumber > numtofind Then

            Return bsearchevent(fightlist, numtofind, midpoint + 1, indexhigh)
        ElseIf currenteventnumber < numtofind Then

            Return bsearchevent(fightlist, numtofind, indexlow, midpoint - 1)
        Else

            'once binary search is done, finds all the fights with event number
            Dim searchedfights As New List(Of Fight)()
            searchedfights.Add(currentfight)


            Dim left As Integer = midpoint - 1
            While left >= indexlow
                Dim lefteventnum As Integer? = ParseEventNumber(fightlist(left).event_name)
                If lefteventnum.HasValue AndAlso lefteventnum = numtofind Then
                    searchedfights.Add(fightlist(left))
                ElseIf lefteventnum.HasValue AndAlso lefteventnum < numtofind Then
                    Exit While
                End If
                left -= 1
            End While


            Dim right As Integer = midpoint + 1
            While right <= indexhigh
                Dim righteventnum As Integer? = ParseEventNumber(fightlist(right).event_name)
                If righteventnum.HasValue AndAlso righteventnum = numtofind Then
                    searchedfights.Add(fightlist(right))
                ElseIf righteventnum.HasValue AndAlso righteventnum > numtofind Then
                    Exit While
                End If
                right += 1
            End While

            Return searchedfights
        End If
    End Function



    Public Function ParseEventNumber(eventName As String) As Integer?

        Dim regex As New Regex("\bUFC\s+(\d+)\b", RegexOptions.IgnoreCase)
        Dim match As Match = regex.Match(eventName)

        If match.Success Then

            Return Integer.Parse(match.Groups(1).Value)
        Else

            Return Nothing
        End If
    End Function

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnsearchfighter.Click


        Dim fights As List(Of Fight) = ReadfightsFromFile()
        Dim fightertofind As String = txtfighter.Text
        Dim fighterfightlist As List(Of Fight)
        fighterfightlist = fights.Where(Function(f) f.fighter1 = fightertofind Or f.fighter2 = fightertofind).ToList()
        fightlist = fighterfightlist
        updatebuttons(fightlist)
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim fights As List(Of Fight) = ReadfightsFromFile()
        fightlist = fights
        updatebuttons(fightlist)
    End Sub
End Class
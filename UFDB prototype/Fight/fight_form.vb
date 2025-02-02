Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions


Public Class fight_form
    Private fightlist As List(Of Fight)
    Private Sub fight_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True
        cmbsort.SelectedIndex = 0
        cmbweightclass.SelectedIndex = 0

        If cmbsort.Items.Count > 0 Then cmbsort.SelectedIndex = 0
        If cmbweightclass.Items.Count > 0 Then cmbweightclass.SelectedIndex = 0
        DateTimePicker1.Checked = False



        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        Dim ilow As Integer = 0
        Dim ihigh As Integer = fights.Count - 1

        Dim sortdirection As Integer = cmbsort.SelectedIndex



        Dim sortedfights As List(Of Fight) = mergesortevents(fights, ilow, ihigh, sortdirection)
        fightlist = sortedfights
        functions.SaveToFightJson(sortedfights)

        Dim uniqueLocations = sortedfights.Select(Function(s) s.location).Distinct().ToList()
        cmblocation.Items.Add("All")
        For Each location As String In uniqueLocations
            cmblocation.Items.Add(location)
        Next
        cmblocation.SelectedItem = "All"



        updatebuttons(fightlist)
    End Sub


    'when a button in the flow control panel is picked (fighter edition
    Private Sub Button_Click(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag of button which is the fighters place in the list
        Dim fightIndex As Integer = Convert.ToInt32(clickedButton.Tag)

        'need to find a way to optimise / reuse code





        'finds current fight
        Dim currentfight As Fight = fightlist(fightIndex)

        'sends current fight data over to the current fighter form
        Dim fightForm As New currentFightForm(currentfight)






        childform(fightForm)

    End Sub






    Function mergesortevents(ByRef fights As List(Of Fight), ilow As Integer, ihigh As Integer, sortdirection As Integer) As List(Of Fight)
        If ilow >= ihigh Then
            Return fights
        Else
            Dim imiddle As Integer = ilow + (ihigh - ilow) \ 2
            mergesortevents(fights, ilow, imiddle, sortdirection)
            mergesortevents(fights, imiddle + 1, ihigh, sortdirection)
            fights = mergeevents(fights, ilow, imiddle, ihigh, sortdirection)
            Return fights
        End If
    End Function



    Function mergeevents(ByRef fights As List(Of Fight), ilow As Integer, imiddle As Integer, ihigh As Integer, sortdirection As Integer) As List(Of Fight)
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

        If sortdirection = 0 Then
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
        ElseIf sortdirection = 1 Then
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

        End If

        Return fights


    End Function


    Private Sub btnsort_Click(sender As Object, e As EventArgs)

    End Sub

    Sub updatebuttons(sortedfights As List(Of Fight), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()


        sortedfights = checkfilters(sortedfights)
        fightlist = sortedfights

        If cmbsort.SelectedItem IsNot Nothing Then
            lblsorted.Text = cmbsort.SelectedItem.ToString()
        End If


        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fights
        Dim endIndex As Integer = Math.Min(startIndex + count, sortedfights.Count)


        If startIndex > 0 Then


            Dim btnback As New Button
            btnback.Width = 100
            btnback.Height = 100
            btnback.BackColor = Color.Red
            btnback.ForeColor = Color.White
            btnback.Font = New Font(btnback.Font.FontFamily, btnback.Font.Size + 2)
            btnback.TextAlign = ContentAlignment.MiddleCenter

            btnback.Text = "back"
            btnback.Visible = True
            btnback.Tag = "btnback"

            'adds an event handler to update buttons
            AddHandler btnback.Click, Sub()
                                          updatebuttons(sortedfights, endIndex - 100)
                                      End Sub
            FlowLayoutPanel1.Controls.Add(btnback)


        End If

        'creates 50 buttons
        For i = startIndex To endIndex - 1


            Dim btn As New Button
            btn.Width = 100
            btn.Height = 120
            btn.TextAlign = ContentAlignment.MiddleCenter
            btn.BackColor = Color.White
            btn.Text = sortedfights(i).event_name & vbCrLf & vbCrLf & " " & sortedfights(i).fighter1 & vbCrLf & " VS " & vbCrLf & sortedfights(i).fighter2
            btn.Visible = True
            btn.Tag = i
            btn.Font = New Font("Clash Display", 9, FontStyle.Regular)

            AddHandler btn.Click, AddressOf Button_Click

            FlowLayoutPanel1.Controls.Add(btn)


        Next

        'creates a load more button if needed
        If endIndex < sortedfights.Count Then


            Dim btnloadmore As New Button
            btnloadmore.Width = 100
            btnloadmore.Height = 100
            btnloadmore.TextAlign = ContentAlignment.MiddleCenter
            btnloadmore.BackColor = Color.Red
            btnloadmore.ForeColor = Color.White
            btnloadmore.Font = New Font(btnloadmore.Font.FontFamily, btnloadmore.Font.Size + 2)
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

        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()



        If txteventnum.Text <> "" Then
            Dim indexlow As Integer = 0
            Dim indexhigh As Integer = fights.Count - 1
            Dim numtofind As Integer

            numtofind = txteventnum.Text


            Dim searchedfights As List(Of Fight) = bsearchevent(fights, numtofind, indexlow, indexhigh)
            fightlist = searchedfights

        End If

        If txtfighter.Text <> "" Then

            Dim fightertofind As String = txtfighter.Text
            Dim fighterfightlist As List(Of Fight)
            fighterfightlist = fightlist.Where(Function(f) f.fighter1 = fightertofind Or f.fighter2 = fightertofind).ToList()
            fightlist = fighterfightlist

        End If

        updatebuttons(fightlist)

    End Sub





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

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        Dim fightertofind As String = txtfighter.Text
        Dim fighterfightlist As List(Of Fight)
        fighterfightlist = fights.Where(Function(f) f.fighter1 = fightertofind Or f.fighter2 = fightertofind).ToList()
        fightlist = fighterfightlist
        updatebuttons(fightlist)
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        fightlist = fights
        updatebuttons(fightlist)
    End Sub



    Private Sub cmbsort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsort.SelectedIndexChanged
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        Dim filteredfightlist As List(Of Fight) = checkfilters(fights)
        updatebuttons(filteredfightlist)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        Dim filteredfightlist As List(Of Fight) = checkfilters(fights)
        updatebuttons(filteredfightlist)
    End Sub

    Private Sub cmbweightclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbweightclass.SelectedIndexChanged
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        Dim filteredfightlist As List(Of Fight) = checkfilters(fights)
        updatebuttons(filteredfightlist)
    End Sub

    Function checkfilters(fightlist As List(Of Fight))


        Dim selectedWeightClass As String = ""
        Dim selectedlocation As String = ""
        Dim selecteddate As DateTime
        Dim filteredFights As List(Of Fight) = fightlist
        Dim sortdirection As Integer = cmbsort.SelectedIndex


        Debug.WriteLine("initial fight count" & filteredFights.Count)

        If cmbweightclass.SelectedItem IsNot Nothing Then
            selectedWeightClass = cmbweightclass.SelectedItem.ToString()
            Debug.WriteLine(selectedWeightClass)
        End If
        If cmblocation.SelectedItem IsNot Nothing Then
            selectedlocation = cmblocation.SelectedItem.ToString()
            Debug.WriteLine("location" & selectedlocation)
        End If
        If DateTimePicker1.Checked = True Then
            selecteddate = DateTimePicker1.Value.Date

        End If


        ' Filter fighters based on the selected weight class

        If Not String.IsNullOrEmpty(selectedWeightClass) And selectedWeightClass <> "All" Then
            Debug.WriteLine("selected weightclass =" & selectedWeightClass)
            filteredFights = fightlist.Where(Function(f) f.weight_class = selectedWeightClass).ToList()
            Debug.WriteLine("1 fight count" & filteredFights.Count)
        End If

        If Not String.IsNullOrEmpty(selectedlocation) And selectedlocation <> "All" Then
            filteredFights = filteredFights.Where(Function(f) f.location = selectedlocation).ToList()
            Debug.WriteLine("2 fight count" & filteredFights.Count)
        End If

        If DateTimePicker1.Checked = True Then
            filteredFights = filteredFights.Where(Function(f) f.date.Date = selecteddate.Date).ToList()
            Debug.WriteLine("3 fight count" & filteredFights.Count)
        End If

        Dim ilow As Integer = 0
        Dim ihigh As Integer = filteredFights.Count - 1
        filteredFights = mergesortevents(filteredFights, ilow, ihigh, sortdirection)

        Debug.WriteLine("done")

        Return filteredFights


    End Function
    Sub childform(ByVal panel As Form)
        pnlcurrentfight.Controls.Clear()
        panel.TopLevel = False
        pnlcurrentfight.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub cmblocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblocation.SelectedIndexChanged
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        Dim filteredfightlist As List(Of Fight) = checkfilters(fights)
        updatebuttons(filteredfightlist)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblsorted_Click(sender As Object, e As EventArgs) Handles lblsorted.Click

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
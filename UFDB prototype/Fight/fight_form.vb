Imports System
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions


Public Class fight_form
    Private currentfightlist As List(Of Fight) 'the current fight list the user sees
    Private Sub fight_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'makes layout scrollable
        FlowLayoutPanel1.VerticalScroll.Visible = True
        FlowLayoutPanel1.HorizontalScroll.Visible = True

        'resets all sorting/ filter methods
        cmbsort.SelectedIndex = 0
        cmbweightclass.SelectedIndex = 0
        If cmbsort.Items.Count > 0 Then cmbsort.SelectedIndex = 0
        If cmbweightclass.Items.Count > 0 Then cmbweightclass.SelectedIndex = 0
        DateTimePicker1.Checked = False


        'reads new fight list
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()


        Dim ilow As Integer = 0
        Dim ihigh As Integer = fights.Count - 1
        Dim sortdirection As Integer = cmbsort.SelectedIndex


        'sorts fight list via merge sort
        Dim fightlistfiltered As List(Of Fight) = mergesortevents(fights, ilow, ihigh, sortdirection)
        'saves filtered list into currentfightlist and saves to json
        currentfightlist = fightlistfiltered
        functions.SaveToFightJson(fightlistfiltered)


        'adds all distinct fight locations to a list
        Dim fightlocations = fightlistfiltered.Select(Function(s) s.location).Distinct().ToList()
        cmblocation.Items.Add("All")

        'list is used to populate combo select box
        For Each location As String In fightlocations
            cmblocation.Items.Add(location)
        Next
        cmblocation.SelectedItem = "All"


        'populates flow layout panel
        updatebuttons(currentfightlist)
    End Sub





    'merge sort



    Function mergesortevents(ByRef fights As List(Of Fight), ilow As Integer, ihigh As Integer, sortdirection As Integer) As List(Of Fight)

        ' if lower index is greater than/equal to higher index, return the fight list
        If ilow >= ihigh Then
            Return fights
        Else

            'find pivot
            Dim imiddle As Integer = ilow + (ihigh - ilow) \ 2
            'sort the left half recursively
            mergesortevents(fights, ilow, imiddle, sortdirection)
            'sort the right half recursively
            mergesortevents(fights, imiddle + 1, ihigh, sortdirection)
            'merge halves together
            fights = mergeevents(fights, ilow, imiddle, ihigh, sortdirection)


            Return fights
        End If
    End Function



    Function mergeevents(ByRef fights As List(Of Fight), ilow As Integer, imiddle As Integer, ihigh As Integer, sortdirection As Integer) As List(Of Fight)
        'creates size of left and right sub-arrays
        Dim upperleft As Integer = imiddle - ilow + 1
        Dim upperright As Integer = ihigh - imiddle

        'creates new arrays to store the halves
        Dim fightslefthalf(upperleft - 1) As Fight
        Dim fightsrighthalf(upperright - 1) As Fight

        Dim pointer1 As Integer 'left half pointer
        Dim pointer2 As Integer 'right half pointer
        Dim pointer3 As Integer ' pointer for merged list


        'adds data to left half
        For pointer1 = 0 To upperleft - 1
            fightslefthalf(pointer1) = fights(ilow + pointer1)
        Next

        'adds data to right half
        For pointer2 = 0 To upperright - 1
            fightsrighthalf(pointer2) = fights(imiddle + 1 + pointer2)
        Next

        pointer1 = 0
        pointer2 = 0
        pointer3 = ilow

        'sort direction determines whether it is ascending or descending 
        If sortdirection = 0 Then
            ' Change comparison to sort in descending order

            'while both halves have items, it will merge
            While pointer1 < upperleft AndAlso pointer2 < upperright
                'compare fight dates and merge if needed
                If DateTime.Compare(fightslefthalf(pointer1).date, fightsrighthalf(pointer2).date) >= 0 Then
                    fights(pointer3) = fightslefthalf(pointer1)
                    pointer1 += 1
                Else
                    fights(pointer3) = fightsrighthalf(pointer2)
                    pointer2 += 1
                End If
                pointer3 += 1
            End While

            'add remaining items from left half
            While pointer1 < upperleft
                fights(pointer3) = fightslefthalf(pointer1)
                pointer1 += 1
                pointer3 += 1
            End While

            'add remaining items from right half
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

        'return merged list
        Return fights


    End Function



    Sub updatebuttons(fightlist As List(Of Fight), Optional startIndex As Integer = 0, Optional count As Integer = 50)


        FlowLayoutPanel1.Controls.Clear()


        fightlist = checkfilters(fightlist)
        currentfightlist = fightlist

        If cmbsort.SelectedItem IsNot Nothing Then
            lblsorted.Text = cmbsort.SelectedItem.ToString()
        End If


        'figures out end index by checking whether the usual end index is still smaller than the overall sorted fights
        Dim endIndex As Integer = Math.Min(startIndex + count, fightlist.Count)


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
                                          updatebuttons(fightlist, endIndex - 100)
                                      End Sub
            FlowLayoutPanel1.Controls.Add(btnback)


        End If

        'creates 50 buttons
        For i = startIndex To endIndex - 1


            Dim btnfight As New Button
            btnfight.Width = 100
            btnfight.Height = 120
            btnfight.TextAlign = ContentAlignment.MiddleCenter
            btnfight.BackColor = Color.White
            btnfight.Text = fightlist(i).event_name & vbCrLf & vbCrLf & " " & fightlist(i).fighter1 & vbCrLf & " VS " & vbCrLf & fightlist(i).fighter2
            btnfight.Visible = True
            btnfight.Tag = i

            AddHandler btnfight.Click, AddressOf Button_Click

            FlowLayoutPanel1.Controls.Add(btnfight)


        Next

        'creates a load more button if needed
        If endIndex < fightlist.Count Then


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
                                              updatebuttons(fightlist, endIndex)
                                          End Sub
            FlowLayoutPanel1.Controls.Add(btnloadmore)


        End If
    End Sub

    'when a button in the flow control panel is picked 
    Private Sub Button_Click(sender As Object, e As EventArgs)

        'shows what button was pressed
        Dim clickedButton As Button = DirectCast(sender, Button)

        'gets tag/index of button which is the fights place in the list
        Dim fightIndex As Integer = Convert.ToInt32(clickedButton.Tag)






        'finds current fight
        Dim currentfight As Fight = currentfightlist(fightIndex)

        'sends current fight data over to the current fighter form
        Dim fightForm As New currentFightForm(currentfight)






        childform(fightForm)

    End Sub


    ' searching
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()


        ' if event number textbox isnt empty, execute binary search
        If txteventnum.Text <> "" Then
            Dim indexlow As Integer = 0
            Dim indexhigh As Integer = fights.Count - 1
            Dim numtofind As Integer

            numtofind = txteventnum.Text


            Dim searchedfights As List(Of Fight) = bsearchevent(fights, numtofind, indexlow, indexhigh)
            currentfightlist = searchedfights

        End If

        ' if fighter textbox isnt empty, execute lambda functiion to find fights with fighter
        If txtfighter.Text <> "" Then

            Dim fightertofind As String = txtfighter.Text
            Dim searchedfighter_fightlist As List(Of Fight)
            searchedfighter_fightlist = currentfightlist.Where(Function(f) f.fighter1 = fightertofind Or f.fighter2 = fightertofind).ToList()
            currentfightlist = searchedfighter_fightlist

        End If

        updatebuttons(currentfightlist)

    End Sub





    Public Function bsearchevent(fightlist As List(Of Fight), numtofind As Integer, indexlow As Integer, indexhigh As Integer) As List(Of Fight)


        'if there are no fights, return a new list of fights with nothing
        If indexlow > indexhigh Then
            Return New List(Of Fight)()
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2
        Dim currentfight As Fight = fightlist(midpoint)




        'gets event number via parse function
        Dim currenteventnumber As Integer? = ParseEventNumber(currentfight.event_name)

        'if parsing returns nothing, skips the fight -> used when a fight night is found
        If Not currenteventnumber.HasValue Then


            Dim newfightlist As New List(Of Fight)()


            'adds fights to new list but without skipped fight
            newfightlist.AddRange(bsearchevent(fightlist, numtofind, indexlow, midpoint - 1))
            newfightlist.AddRange(bsearchevent(fightlist, numtofind, midpoint + 1, indexhigh))
            Return newfightlist
        End If

        'recusrive binary search for event number
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
        'uses a regular expression to parse the fight number

        Dim eventregex As New Regex("\bUFC\s+(\d+)\b", RegexOptions.IgnoreCase)
        Dim match As Match = eventregex.Match(eventName)
        'only does so for ufc names with an event number
        If match.Success Then

            Return Integer.Parse(match.Groups(1).Value)
        Else

            Return Nothing
        End If
    End Function





    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click 'clears list by reading from json
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        currentfightlist = fights
        updatebuttons(currentfightlist)
    End Sub






    Sub childform(ByVal panel As Form) 'used to embed panel within panel
        pnlcurrentfight.Controls.Clear()
        panel.TopLevel = False
        pnlcurrentfight.Controls.Add(panel)
        panel.Show()
    End Sub




    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click 'brings user back to home
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub Formvisible(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Me.Visible Then

        End If
    End Sub

    'filter checks
    'makes new fighter list with all fighters and performs checkfilter function before updating button

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

    Private Sub cmblocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblocation.SelectedIndexChanged
        Dim fights As List(Of Fight) = functions.ReadFightsFromJson()
        Dim filteredfightlist As List(Of Fight) = checkfilters(fights)
        updatebuttons(filteredfightlist)
    End Sub

    Function checkfilters(fightlist As List(Of Fight))


        Dim selectedWeightClass As String = "" 'stores selected weight class
        Dim selectedlocation As String = "" 'stores selected location
        Dim selecteddate As DateTime 'stores selected date
        Dim filteredFights As List(Of Fight) = fightlist 'new fight list to be returned
        Dim sortdirection As Integer = cmbsort.SelectedIndex 'stores sort direction




        If cmbweightclass.SelectedItem IsNot Nothing Then 'stores selected weight class if not empty
            selectedWeightClass = cmbweightclass.SelectedItem.ToString()

        End If
        If cmblocation.SelectedItem IsNot Nothing Then 'stores selected location if not empty
            selectedlocation = cmblocation.SelectedItem.ToString()

        End If
        If DateTimePicker1.Checked = True Then 'stores selected date iif checkbox is checked
            selecteddate = DateTimePicker1.Value.Date

        End If


        ' Filter fighters based on the selected weight class, location and date using lambda functions

        If Not String.IsNullOrEmpty(selectedWeightClass) And selectedWeightClass <> "All" Then 'statement only occurs if the selected weight class does not equal nothing, or all

            filteredFights = fightlist.Where(Function(f) f.weight_class = selectedWeightClass).ToList()

        End If

        If Not String.IsNullOrEmpty(selectedlocation) And selectedlocation <> "All" Then 'statement only occurs if the selected location does not equal nothing, or all
            filteredFights = filteredFights.Where(Function(f) f.location = selectedlocation).ToList()

        End If

        If DateTimePicker1.Checked = True Then
            filteredFights = filteredFights.Where(Function(f) f.date.Date = selecteddate.Date).ToList()

        End If

        'sorts new filtered list via sorting direction

        Dim ilow As Integer = 0
        Dim ihigh As Integer = filteredFights.Count - 1
        filteredFights = mergesortevents(filteredFights, ilow, ihigh, sortdirection)



        Return filteredFights


    End Function
End Class
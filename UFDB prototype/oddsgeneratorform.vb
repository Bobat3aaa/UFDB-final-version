Imports Newtonsoft.Json
Imports System.IO
Imports System.Runtime.Remoting.Messaging
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class oddsgeneratorform


    Private fighter1 As fighter
    Private fighter2 As fighter
    Private fighter1index As Integer = 0
    Private fighter2index As Integer = 1
    Private formswitch As Boolean = False

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblfighter2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblfighter1.Click

    End Sub

    Private Sub oddsgeneratorform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sorts fighters and saves to file

        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1

        Dim sortedfighters As List(Of fighter) = Quicksort(fighters, indexlow, indexhigh)
        functions.savetofighterjson(sortedfighters)
        fighter1 = sortedfighters(0)
        fighter2 = sortedfighters(1)
        updatefighter1(fighter1)
        updatefighter2(fighter2)


    End Sub

    Function Quicksort(fighters As List(Of fighter), indexlow As Integer, indexhigh As Integer) As List(Of fighter) 'quicksort the fighters
        Try
            Dim pivot As String
            Dim templow As Integer = indexlow
            Dim temphigh As Integer = indexhigh

            pivot = fighters(Int((indexlow + indexhigh) / 2)).name

            While templow <= temphigh
                While String.Compare(fighters(templow).name, pivot) < 0
                    templow += 1
                End While

                While String.Compare(fighters(temphigh).name, pivot) > 0
                    temphigh -= 1
                End While

                If templow <= temphigh Then
                    Dim tempfighter As fighter = fighters(templow)
                    fighters(templow) = fighters(temphigh)
                    fighters(temphigh) = tempfighter
                    templow += 1
                    temphigh -= 1
                End If
            End While

            If indexlow < temphigh Then
                Quicksort(fighters, indexlow, temphigh)
            End If

            If templow < indexhigh Then
                Quicksort(fighters, templow, indexhigh)
            End If

            Return fighters
        Catch ex As Exception
            MsgBox("Problem occured with sorting fighters: " & ex.Message)
            Return New List(Of fighter)
        End Try
    End Function



    Function bsearchusers(fighterlist As List(Of fighter), nametofind As String, indexlow As Integer, indexhigh As Integer)

        'binary search, returns midpoint which is place in list
        If indexlow > indexhigh Then
            Return -1
        End If

        Dim midpoint As Integer = (indexlow + indexhigh) \ 2

        If String.Compare(fighterlist(midpoint).name, nametofind) < 0 Then
            Return bsearchusers(fighterlist, nametofind, midpoint + 1, indexhigh)
        ElseIf String.Compare(fighterlist(midpoint).name, nametofind) > 0 Then
            Return bsearchusers(fighterlist, nametofind, indexlow, midpoint - 1)
        ElseIf fighterlist(midpoint).name = nametofind Then
            Return midpoint
        Else
            Return -1
        End If
    End Function

    Private Sub btnsearch1_Click(sender As Object, e As EventArgs) Handles btnsearch1.Click
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1



        Dim nametofind As String = (txtfighter1fname.Text) + " " + (txtfighter1lname.Text)
        Dim searchedfighterindex As Integer = bsearchusers(fighters, nametofind, indexlow, indexhigh)
        If searchedfighterindex <> -1 Then
            fighter1 = fighters(searchedfighterindex)
            fighter1index = searchedfighterindex
            updatefighter1(fighter1)
        Else
            MsgBox("No fighter found. Please try again!")
        End If


        'adds fighter to a new list to be shown in search alone

    End Sub

    Private Sub btnsearch2_Click(sender As Object, e As EventArgs) Handles btnsearch2.Click
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        Dim indexlow As Integer = 0
        Dim indexhigh As Integer = fighters.Count - 1



        Dim nametofind As String = (txtfighter2fname.Text) + " " + (txtfighter2lname.Text)
        Dim searchedfighterindex As Integer = bsearchusers(fighters, nametofind, indexlow, indexhigh)
        If searchedfighterindex <> -1 Then
            fighter2 = fighters(searchedfighterindex)
            fighter2index = searchedfighterindex
            updatefighter2(fighter2)
        Else
            MsgBox("No fighter found. Please try again!")
        End If




    End Sub

    Sub updatefighter1(fighter As fighter)
        txtfighter1stats.Text = fighter.name & vbCrLf & " height: " & fighter.height & vbCrLf & " weight: " & fighter.weight & vbCrLf & " reach: " & fighter.reach & vbCrLf & " Record: " & fighter.wins & "/" & fighter.losses & "/" & fighter.draws
        lblfighter1.Text = fighter1.name

    End Sub

    Sub updatefighter2(fighter As fighter)
        txtfighter2stats.Text = fighter.name & vbCrLf & " height: " & fighter.height & vbCrLf & " weight: " & fighter.weight & vbCrLf & " reach: " & fighter.reach & vbCrLf & " Record: " & fighter.wins & "/" & fighter.losses & "/" & fighter.draws
        lblfighter2.Text = fighter2.name
    End Sub

    Private Sub btnback1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        If fighter1 IsNot Nothing AndAlso fighter2 IsNot Nothing Then

            Dim fighterpair As Double() = generateodds(fighter1, fighter2)
            updatewinner(fighterpair)
        ElseIf fighter1 Is Nothing And fighter2 IsNot Nothing Then
            MsgBox("no fighter 1")

        ElseIf fighter2 Is Nothing And fighter1 IsNot Nothing Then
            MsgBox("no fighter 2")

        ElseIf fighter1 Is Nothing And fighter2 Is Nothing Then
            MsgBox("no fighters")
        End If

    End Sub

    Function generateodds(fighter1 As fighter, fighter2 As fighter)

        Dim fighter1win As Integer = fighter1.wins
        Dim fighter2win As Integer = fighter2.wins

        Dim fighter1other As Integer = fighter1.losses + fighter1.draws
        Dim fighter2other As Integer = fighter2.losses + fighter2.draws


        Dim fighter1winrate As Double
        Dim fighter2winrate As Double

        Dim fighter1odds As Double
        Dim fighter2odds As Double

        Dim fighter1weight As Integer? = ParseWeight(fighter1.weight)
        Dim fighter2weight As Integer? = ParseWeight(fighter2.weight)
        'fighters win rate
        fighter1winrate = (fighter1win / (fighter1other + fighter1win)) * 100 * (fighter1weight * 0.015)
        fighter2winrate = (fighter2win / (fighter2other + fighter2win)) * 100 * (fighter2weight * 0.015)


        'fighter odds

        fighter1odds = (fighter1winrate / ((fighter1winrate + fighter2winrate)) * 100)
        fighter2odds = (fighter2winrate / ((fighter1winrate + fighter2winrate)) * 100)

        fighter1odds = Math.Round(fighter1odds, 2)
        fighter2odds = Math.Round(fighter2odds, 2)
        Dim total As Decimal = fighter1odds + fighter2odds

        If total <> 100 Then
            fighter2odds = 100 - fighter1odds
        End If

    
        Dim fighteroddsarray(1) As Double
        fighteroddsarray(0) = fighter1odds
        fighteroddsarray(1) = fighter2odds





        Return fighteroddsarray

    End Function

    Function ParseWeight(weightString As String) As Integer? 'parsing the weight from the fighter

        'finds a digit
        Dim regex As New Regex("\d+", RegexOptions.IgnoreCase)
        Dim match As Match = regex.Match(weightString)

        If match.Success Then

            Return Integer.Parse(match.Value)
        Else

            Return Nothing
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnback2.Click
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        If fighter2index > 0 Then
            fighter2index -= 1
            fighter2 = (fighters(fighter2index))
            updatefighter2(fighter2)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnext2.Click
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        If fighter2index < fighters.Count - 1 Then
            fighter2index += 1
            fighter2 = (fighters(fighter2index))
            updatefighter2(fighter2)

        End If
    End Sub

    Sub updatewinner(oddpair) 'update all the panels if a new fighter is chosen
        lblfighter1.Text = fighter1.name
        lblfighter2.Text = fighter2.name
        txtchance1.Text = oddpair(0)
        txtchance2.Text = oddpair(1)

        If oddpair(0) > oddpair(1) Then
            txtwinner.Text = (fighter1.name)
            pnlfighter1.BackColor = Color.LightGreen
            pnlfighter2.BackColor = Color.Pink
        ElseIf oddpair(0) < oddpair(1) Then
            txtwinner.Text = (fighter2.name)
            pnlfighter1.BackColor = Color.Pink
            pnlfighter2.BackColor = Color.LightGreen
        Else
            txtwinner.Text = ("draw")
            pnlfighter1.BackColor = Color.Yellow
            pnlfighter2.BackColor = Color.Yellow

        End If

    End Sub

    Private Sub txtwinner_TextChanged(sender As Object, e As EventArgs) Handles txtwinner.TextChanged

    End Sub

    Private Sub btnnext1_Click(sender As Object, e As EventArgs) Handles btnnext1.Click 'choose the next fighter
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        If fighter1index < fighters.Count - 1 Then
            fighter1index += 1
            fighter1 = (fighters(fighter1index))
            updatefighter1(fighter1)

        End If
    End Sub

    Private Sub btnback1_Click_1(sender As Object, e As EventArgs) Handles btnback1.Click ' choose the fighter before
        Dim fighters As List(Of fighter) = functions.readfightersfromjson()
        If fighter1index > 0 Then
            fighter1index -= 1
            fighter1 = (fighters(fighter1index))
            updatefighter1(fighter1)

        End If
    End Sub

    '***************** CLEARING FUNCTIONS  ****************

    Private Sub btnclear_Click(sender As Object, e As EventArgs)
        txtfighter1stats.Text = ""
        txtfighter1fname.Text = ""
        txtfighter1lname.Text = ""

        fighter1 = Nothing

    End Sub

    Private Sub btnclear2_Click(sender As Object, e As EventArgs)
        txtfighter2stats.Text = ""
        txtfighter2fname.Text = ""
        txtfighter2lname.Text = ""
        fighter2 = Nothing
    End Sub

    Private Sub btnclearfighter2_Click(sender As Object, e As EventArgs) Handles btnclearfighter2.Click
        txtfighter2fname.Text = ""
        txtfighter2lname.Text = ""
    End Sub

    Private Sub btnclearfighter1_Click(sender As Object, e As EventArgs) Handles btnclearfighter1.Click
        txtfighter1fname.Text = ""
        txtfighter1lname.Text = ""
    End Sub

    Private Sub formclose(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If formswitch = False Then
            Application.Exit()
        End If
    End Sub
    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        formswitch = True
        Form1.Show()
        Me.Close()
    End Sub
End Class
Imports Newtonsoft.Json
Imports System.IO

Public Class currentFightForm
    Public Property currentfight As Fight
    Private fighter1 As fighter
    Private fighter2 As fighter


    ' Constructor that accepts a Fight object
    Public Sub New(fight As Fight)



        InitializeComponent()
        Dim fighterlist As List(Of fighter) = functions.ReadFightersFromJson() 'fighter list used to find fighter 1 and 2
        Me.currentfight = fight



        fighter1 = findfighter1(fighterlist)
        fighter2 = findfighter2(fighterlist)


        'shows all the data
        lblfight.Text = ((fighter1.name) + " VS " + (fighter2.name))
        lblevent.Text = currentfight.name
        lblfighter1.Text = fighter1.name
        lblfighter2.Text = fighter2.name
        lbllocation.Text = currentfight.location
        lbldate.Text = currentfight.date



        fighter1 = findfighter1(fighterlist)
        fighter2 = findfighter2(fighterlist)


        lblheight1.Text = "height: " & fighter1.height
        lblweight1.Text = "weight: " & fighter1.weight
        lblreach1.Text = "reach: " & fighter1.reach

        lblrecord1.Text = String.Format("Record: {0}/ {1}/ {2}", fighter1.wins, fighter1.losses, fighter1.draws)

        lblheight2.Text = "height: " & fighter2.height
        lblweight2.Text = "weight: " & fighter2.weight
        lblreach2.Text = "reach: " & fighter2.reach

        lblrecord2.Text = String.Format("Record: {0}/ {1}/ {2}", fighter2.wins, fighter2.losses, fighter2.draws)


        If fighter1.name = currentfight.win Then
            pnlfighter1.BackColor = Color.LightGreen
            pnlfighter2.BackColor = Color.Pink
        ElseIf fighter2.name = currentfight.win Then
            pnlfighter2.BackColor = Color.LightGreen
            pnlfighter1.BackColor = Color.Pink
        Else
            pnlfighter1.BackColor = Color.LightYellow
            pnlfighter2.BackColor = Color.LightYellow
        End If

        lbldate.Text = "date: " & currentfight.date
        lblmethod.Text = "method: " & currentfight.method
        lblround.Text = "round: " & currentfight.rounds
        lblweightclass.Text = "weight class: " & currentfight.weightclass
        lbltime.Text = "time: " & currentfight.time
    End Sub

    'Private Sub btnback_Click(sender As Object, e As EventArgs)
    '    fight_form.Show()
    '    Me.Close()
    'End Sub

    Private Sub currentFightForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function findfighter1(fighterlist As List(Of fighter)) 'checks for fighter 1 using lambda functions

        'determines whether an empty object is returned or not
        Dim fighterfound As Boolean = fighterlist.Any(Function(f) f.fighterid = currentfight.fighter1id)

        If fighterfound = True Then
            'returns first instance of fighter1
            Dim foundfighter = fighterlist.FirstOrDefault(Function(f) f.fighterid = currentfight.fighter1id)
            Debug.WriteLine("found fighter 1")
            Return foundfighter
        Else
            'return empty fighter

            Return New fighter
        End If

    End Function
    Function findfighter2(fighterlist As List(Of fighter)) 'checks for fighter 1 using lambda functions

        'determines whether an empty object is returned or not
        Dim fighterfound As Boolean = fighterlist.Any(Function(f) f.fighterid = currentfight.fighter2id)

        If fighterfound = True Then
            'returns first instance of fighter2
            Dim foundfighter = fighterlist.FirstOrDefault(Function(f) f.fighterid = currentfight.fighter2id)
            Debug.WriteLine("found fighter 2")
            Return foundfighter
        Else
            'return empty fighter
            Return New fighter
        End If

    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblround.Click

    End Sub

    Private Sub lblfighter2_Click(sender As Object, e As EventArgs) Handles lblfighter2.Click

        'opens current fighter form for fighter2
        Dim currentfighter As fighter = fighter2
        Dim fighterForm As New currentfighterform(currentfighter)
        fighterForm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        fighterForm.ControlBox = True
        fighterForm.Show()
    End Sub



    Private Sub lblfighter1_Click(sender As Object, e As EventArgs) Handles lblfighter1.Click
        'opens current fighter form for fighter1
        Dim currentfighter As fighter = fighter1
        Dim fighterForm As New currentfighterform(currentfighter)
        fighterForm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        fighterForm.ControlBox = True
        fighterForm.Show()
    End Sub
End Class
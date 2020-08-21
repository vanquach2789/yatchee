'==============================================================================
'Project:           Lab 2
'Title:             Yahtzee
'File Name:         Yahtzee.sln, .exe
'Date Completed:    12/2/2018
'
'Author:            Van Quach, Margaret Alcock, Dylan E Parker, Tyler R Little
'Course:            CS 115, Section C
'
'Description:       This program is a dice game called Yahtzee. There are five
'                   dice that can be rolled to get different combinations. 
'                   Then, the user can pick which type of combination they want
'                   to score by choosing the program's buttons.
'
'                   The user can choose how many players they want to play by
'                   typing the number of player in the input box appearing at
'                   the beginning of the game. Then, the user can type the name
'                   of each player in the input box.
'
'                   There are 13 rounds in the game. There are labels near the
'                   top right corner of the game indicating how many rounds
'                   are left.
'   
'                   Each turn starts with a roll of all five dice. Then the 
'                   player decices how many of the dice to roll again, if any.
'                   The player has up to three rolls of the dice including the
'                   first roll. The player can decide to roll up to five dice
'                   for any of the rolls. The player can roll by clicking the
'                   Roll button and can change which dice are being held from
'                   roll to roll by clicking the check boxes under every dice.
'                   However, after the third roll of every round, the player 
'                   must pick a combination to be scored even if this choice
'                   yields a zero score on that combination.
'
'                   Below the bottm of the game is the label showing name and
'                   total score of each player.
'
'                   There are the tool tip that can help the player to know
'                   the function of each button. 
'
'                   At the bottom of the game, there is a status bar indicating
'                   the player's turn.
'
'                   At the top of the game, there is the menu bar containing 
'                   some functions such as saving, loading, starting a new game,
'                   terminating the game, showing recent high scores. There is
'                   a How to play menu showing the game's rules and a About
'                   menu giving the information about the people who made the 
'                   program.
'==============================================================================
'Known Bugs:        
'==============================================================================
Option Explicit On
Option Strict On

Imports System.IO
'------------------------------------------------------------------------------
'Description: Declaring class variables and arrays.
'------------------------------------------------------------------------------
Public Class Yahtzee

    Dim cshtDiceVal(4) As Short
    Dim cchkHold(4) As CheckBox
    Dim cpicDie(4) As PictureBox

    Dim clblAces(5) As Label
    Dim clblTwos(5) As Label
    Dim clblThrees(5) As Label
    Dim clblFours(5) As Label
    Dim clblFives(5) As Label
    Dim clblSixes(5) As Label
    Dim clblTotalScore(5) As Label
    Dim clblBonus(5) As Label
    Dim clblTotalOfUpperSection(5) As Label
    Dim clbl3OfAKind(5) As Label
    Dim clbl4OfAKind(5) As Label
    Dim clblFullHouse(5) As Label
    Dim clblSmallStraight(5) As Label
    Dim clblLargeStraight(5) As Label
    Dim clblYahtzee(5) As Label
    Dim clblChance(5) As Label
    Dim clblYahtzeeBonus(5) As Label
    Dim clblTotalOfLowerSection(5) As Label
    Dim clblTotal(5) As Label

    Dim cshtPlayerScores(5, 18) As Short '2d array to hold all player scores

    Dim cstrPlayerNames(5) As String
    Dim cblnYahtzee(5) As Boolean
    Dim cshtNumPlayers As Short
    Dim clblPlayersU(5) As Label
    Dim clblPlayersL(5) As Label
    Dim clblPlayersT(5) As Label
    Dim cshtCurrentPlayer As Short 'for tracking/iterating current player
    Dim cshtRolls As Short 'tracks which dice roll the player is on
    Dim cshtTurn As Short 'tracks current turn

    '--------------------------------------------------------------------------
    'Description: Set up check boxes, picture boxes and player scores arrays 
    '             for dice.
    '--------------------------------------------------------------------------
    Private Sub Yahtzee_Load(sender As Object,
                             e As EventArgs) Handles MyBase.Load
        'set up check boxes and picture boxes arrays for dice.
        Dim i As Short
        Dim j As Short

        cshtNumPlayers = 6

        Randomize()

        'set up arrays for check boxes and picture boxes
        For i = 0 To 4
            cchkHold(i) = New CheckBox
            Me.Controls.Add(cchkHold(i))
            cchkHold(i).Width = 75
            cchkHold(i).Height = 25
            cchkHold(i).Top = 120
            cchkHold(i).Left = i * cchkHold(i).Width + 375
            cchkHold(i).Text = "Hold"

            cpicDie(i) = New PictureBox
            Me.Controls.Add(cpicDie(i))
            cpicDie(i).Width = 75
            cpicDie(i).Height = cpicDie(i).Width
            cpicDie(i).Top = 45
            cpicDie(i).Left = i * cpicDie(i).Width + 375
            cpicDie(i).BackgroundImage = Image.FromFile("..\Images\redDie0.png")
            cpicDie(i).BackgroundImageLayout = ImageLayout.Zoom
        Next i

        'set up arrays for player scores
        For j = 0 To 5
            clblPlayersU(j) = New Label
            Me.Controls.Add(clblPlayersU(j))
            clblPlayersU(j).Width = 75
            clblPlayersU(j).Height = 25
            clblPlayersU(j).Top = 171
            clblPlayersU(j).Left = j * clblPlayersU(j).Width + 120 + j * 6
            clblPlayersU(j).BackColor = Color.Pink
            clblPlayersU(j).Text = ""

            clblPlayersL(j) = New Label
            Me.Controls.Add(clblPlayersL(j))
            clblPlayersL(j).Width = 75
            clblPlayersL(j).Height = 25
            clblPlayersL(j).Top = 171
            clblPlayersL(j).Left = j * clblPlayersL(j).Width + 758 + j * 6
            clblPlayersL(j).BackColor = Color.Pink
            clblPlayersL(j).Text = ""

            clblPlayersT(j) = New Label
            Me.Controls.Add(clblPlayersT(j))
            clblPlayersT(j).Width = 75
            clblPlayersT(j).Height = 35
            clblPlayersT(j).Top = 556
            clblPlayersT(j).Left = j * clblPlayersT(j).Width + 26 + j * 135
            clblPlayersT(j).BackColor = Color.Pink
            clblPlayersT(j).Text = ""

            clblAces(j) = New Label
            grpUpperSection.Controls.Add(clblAces(j))
            clblAces(j).Width = 75
            clblAces(j).Height = 25
            clblAces(j).Top = 22
            clblAces(j).Left = j * clblAces(j).Width + 107 + j * 6
            clblAces(j).BackColor = Color.Pink
            clblAces(j).Text = ""

            clblTwos(j) = New Label
            grpUpperSection.Controls.Add(clblTwos(j))
            clblTwos(j).Width = 75
            clblTwos(j).Height = 25
            clblTwos(j).Top = 51
            clblTwos(j).Left = j * clblTwos(j).Width + 107 + j * 6
            clblTwos(j).BackColor = Color.Pink
            clblTwos(j).Text = ""

            clblThrees(j) = New Label
            grpUpperSection.Controls.Add(clblThrees(j))
            clblThrees(j).Width = 75
            clblThrees(j).Height = 25
            clblThrees(j).Top = 80
            clblThrees(j).Left = j * clblThrees(j).Width + 107 + j * 6
            clblThrees(j).BackColor = Color.Pink
            clblThrees(j).Text = ""

            clblFours(j) = New Label
            grpUpperSection.Controls.Add(clblFours(j))
            clblFours(j).Width = 75
            clblFours(j).Height = 25
            clblFours(j).Top = 109
            clblFours(j).Left = j * clblFours(j).Width + 107 + j * 6
            clblFours(j).BackColor = Color.Pink
            clblFours(j).Text = ""

            clblFives(j) = New Label
            grpUpperSection.Controls.Add(clblFives(j))
            clblFives(j).Width = 75
            clblFives(j).Height = 25
            clblFives(j).Top = 138
            clblFives(j).Left = j * clblFives(j).Width + 107 + j * 6
            clblFives(j).BackColor = Color.Pink
            clblFives(j).Text = ""

            clblSixes(j) = New Label
            grpUpperSection.Controls.Add(clblSixes(j))
            clblSixes(j).Width = 75
            clblSixes(j).Height = 25
            clblSixes(j).Top = 167
            clblSixes(j).Left = j * clblSixes(j).Width + 107 + j * 6
            clblSixes(j).BackColor = Color.Pink
            clblSixes(j).Text = ""

            clblTotalScore(j) = New Label
            grpUpperSection.Controls.Add(clblTotalScore(j))
            clblTotalScore(j).Width = 75
            clblTotalScore(j).Height = 25
            clblTotalScore(j).Top = 195
            clblTotalScore(j).Left = j * clblTotalScore(j).Width + 107 + j * 6
            clblTotalScore(j).BackColor = Color.Pink
            clblTotalScore(j).Text = ""

            clblBonus(j) = New Label
            grpUpperSection.Controls.Add(clblBonus(j))
            clblBonus(j).Width = 75
            clblBonus(j).Height = 25
            clblBonus(j).Top = 233
            clblBonus(j).Left = j * clblBonus(j).Width + 107 + j * 6
            clblBonus(j).BackColor = Color.Pink
            clblBonus(j).Text = ""

            clblTotalOfUpperSection(j) = New Label
            grpUpperSection.Controls.Add(clblTotalOfUpperSection(j))
            clblTotalOfUpperSection(j).Width = 75
            clblTotalOfUpperSection(j).Height = 25
            clblTotalOfUpperSection(j).Top = 289
            clblTotalOfUpperSection(j).Left = j *
            clblTotalOfUpperSection(j).Width + 107 + j * 6
            clblTotalOfUpperSection(j).BackColor = Color.Pink
            clblTotalOfUpperSection(j).Text = ""

            clbl3OfAKind(j) = New Label
            grpLowerSection.Controls.Add(clbl3OfAKind(j))
            clbl3OfAKind(j).Width = 75
            clbl3OfAKind(j).Height = 25
            clbl3OfAKind(j).Top = 22
            clbl3OfAKind(j).Left = j * clbl3OfAKind(j).Width + 120 + j * 6
            clbl3OfAKind(j).BackColor = Color.Pink
            clbl3OfAKind(j).Text = ""

            clbl4OfAKind(j) = New Label
            grpLowerSection.Controls.Add(clbl4OfAKind(j))
            clbl4OfAKind(j).Width = 75
            clbl4OfAKind(j).Height = 25
            clbl4OfAKind(j).Top = 51
            clbl4OfAKind(j).Left = j * clbl4OfAKind(j).Width + 120 + j * 6
            clbl4OfAKind(j).BackColor = Color.Pink
            clbl4OfAKind(j).Text = ""

            clblFullHouse(j) = New Label
            grpLowerSection.Controls.Add(clblFullHouse(j))
            clblFullHouse(j).Width = 75
            clblFullHouse(j).Height = 25
            clblFullHouse(j).Top = 80
            clblFullHouse(j).Left = j * clblFullHouse(j).Width + 120 + j * 6
            clblFullHouse(j).BackColor = Color.Pink
            clblFullHouse(j).Text = ""

            clblSmallStraight(j) = New Label
            grpLowerSection.Controls.Add(clblSmallStraight(j))
            clblSmallStraight(j).Width = 75
            clblSmallStraight(j).Height = 25
            clblSmallStraight(j).Top = 109
            clblSmallStraight(j).Left = j * clblSmallStraight(j).Width + 120 + j * 6
            clblSmallStraight(j).BackColor = Color.Pink
            clblSmallStraight(j).Text = ""

            clblLargeStraight(j) = New Label
            grpLowerSection.Controls.Add(clblLargeStraight(j))
            clblLargeStraight(j).Width = 75
            clblLargeStraight(j).Height = 25
            clblLargeStraight(j).Top = 138
            clblLargeStraight(j).Left = j * clblLargeStraight(j).Width + 120 + j * 6
            clblLargeStraight(j).BackColor = Color.Pink
            clblLargeStraight(j).Text = ""

            clblYahtzee(j) = New Label
            grpLowerSection.Controls.Add(clblYahtzee(j))
            clblYahtzee(j).Width = 75
            clblYahtzee(j).Height = 25
            clblYahtzee(j).Top = 167
            clblYahtzee(j).Left = j * clblYahtzee(j).Width + 120 + j * 6
            clblYahtzee(j).BackColor = Color.Pink
            clblYahtzee(j).Text = ""

            clblChance(j) = New Label
            grpLowerSection.Controls.Add(clblChance(j))
            clblChance(j).Width = 75
            clblChance(j).Height = 25
            clblChance(j).Top = 196
            clblChance(j).Left = j * clblChance(j).Width + 120 + j * 6
            clblChance(j).BackColor = Color.Pink
            clblChance(j).Text = ""

            clblYahtzeeBonus(j) = New Label
            grpLowerSection.Controls.Add(clblYahtzeeBonus(j))
            clblYahtzeeBonus(j).Width = 75
            clblYahtzeeBonus(j).Height = 25
            clblYahtzeeBonus(j).Top = 233
            clblYahtzeeBonus(j).Left = j * clblYahtzeeBonus(j).Width + 120 + j * 6
            clblYahtzeeBonus(j).BackColor = Color.Pink
            clblYahtzeeBonus(j).Text = ""

            clblTotalOfLowerSection(j) = New Label
            grpLowerSection.Controls.Add(clblTotalOfLowerSection(j))
            clblTotalOfLowerSection(j).Width = 75
            clblTotalOfLowerSection(j).Height = 25
            clblTotalOfLowerSection(j).Top = 288
            clblTotalOfLowerSection(j).Left = j * clblTotalOfLowerSection(j).Width + 120 + j * 6
            clblTotalOfLowerSection(j).BackColor = Color.Pink
            clblTotalOfLowerSection(j).Text = ""

            clblTotal(j) = New Label
            Me.Controls.Add(clblTotal(j))
            clblTotal(j).Width = 75
            clblTotal(j).Height = 35
            clblTotal(j).Top = 556
            clblTotal(j).Left = j * clblTotalOfLowerSection(j).Width + 124 + j * 135
            clblTotal(j).BackColor = Color.White
            clblTotal(j).Text = ""
        Next j

        Call sNewGame()
        'Call sScratch()

    End Sub

    '--------------------------------------------------------------------------
    'Description: Exits the game from the menu item "Exit".
    '--------------------------------------------------------------------------
    Private Sub mnuExit_Click(sender As Object,
                              e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    '--------------------------------------------------------------------------
    'Description: Asks if the user want to start a new game. If yes, calls 
    '             sNewGame.
    '
    'Calls:       sNewGame.
    '--------------------------------------------------------------------------
    Private Sub mnuNewGame_Click(sender As Object,
                                 e As EventArgs) Handles mnuNewGame.Click

        'Are you sure you want to reset the game?
        Dim result = MessageBox.Show("Are you sure you want to start a new game?",
                            "New Game", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Call sNewGame()
        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: Loads the previous game for the player to continue playing.
    '
    'Called by:   mnuLoadGame_Click.
    '--------------------------------------------------------------------------
    Private Sub sLoadGame()

        Dim i As Integer

        For i = 0 To cshtNumPlayers - CShort(1)
            FileOpen(2, "..\Data\" & (i + CShort(1)).ToString & ".txt", OpenMode.Input)
            clblAces(i).Text = LineInput(2)
            'cshtPlayerLineScore(0) = CShort(clblAces(i).Text)
            clblTwos(i).Text = LineInput(2)
            clblThrees(i).Text = LineInput(2)
            clblFours(i).Text = LineInput(2)
            clblFives(i).Text = LineInput(2)
            clblSixes(i).Text = LineInput(2)
            clblTotalScore(i).Text = LineInput(2)
            clblBonus(i).Text = LineInput(2)
            clblTotalOfUpperSection(i).Text = LineInput(2)
            clbl3OfAKind(i).Text = LineInput(2)
            clbl4OfAKind(i).Text = LineInput(2)
            clblFullHouse(i).Text = LineInput(2)
            clblSmallStraight(i).Text = LineInput(2)
            clblLargeStraight(i).Text = LineInput(2)
            clblYahtzee(i).Text = LineInput(2)
            clblChance(i).Text = LineInput(2)
            clblYahtzeeBonus(i).Text = LineInput(2)
            clblTotalOfLowerSection(i).Text = LineInput(2)
            clblPlayersL(i).Text = LineInput(2)
            clblPlayersU(i).Text = LineInput(2)
            clblPlayersT(i).Text = LineInput(2)
            clblTotal(i).Text = LineInput(2)

        Next i

        FileClose(2)

    End Sub

    '--------------------------------------------------------------------------
    'Description: Checking if the user wants to start a new game or to continue
    '             their game.
    '--------------------------------------------------------------------------
    Private Sub sScratch()

        Dim strTemp As String
        Dim strTempo As String

        strTemp = CStr(MessageBox.Show("Do you want to start a new game?",
                            "New Game", MessageBoxButtons.YesNo))

        If strTemp = CStr(DialogResult.Yes) Then
            Call sNewGame()
        Else
            strTempo = CStr(MessageBox.Show("Do you want continue your game?",
                            "Load Game", MessageBoxButtons.YesNo))
            If strTempo = CStr(DialogResult.Yes) Then
                Call sLoadGame()
            End If
        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: Clears all the labels of the game to start a new game.
    '--------------------------------------------------------------------------
    Private Sub sNewGame()
        Dim i As Short
        Dim j As Short
        Dim strTemp As String
        Call sResetTheDie()
        lblRoundsLeft.Text = "13"
        lblCurrentPlayer.Text = cstrPlayerNames(cshtCurrentPlayer) & "'s Turn"

        For i = 0 To cshtNumPlayers - CShort(1)
            For j = 0 To 18
                cshtPlayerScores(i, j) = 0
            Next j

            clblAces(i).Text = ""
            clblTwos(i).Text = ""
            clblThrees(i).Text = ""
            clblFours(i).Text = ""
            clblFives(i).Text = ""
            clblSixes(i).Text = ""
            clblTotalScore(i).Text = ""
            clblBonus(i).Text = ""
            clblTotalOfUpperSection(i).Text = ""
            clbl3OfAKind(i).Text = ""
            clbl4OfAKind(i).Text = ""
            clblFullHouse(i).Text = ""
            clblSmallStraight(i).Text = ""
            clblLargeStraight(i).Text = ""
            clblYahtzee(i).Text = ""
            clblChance(i).Text = ""
            clblYahtzeeBonus(i).Text = ""
            clblTotal(i).Text = ""
            clblPlayersL(i).Text = ""
            clblPlayersT(i).Text = ""
            clblPlayersU(i).Text = ""
        Next i

        cshtCurrentPlayer = 0

        'ask for number of players and assign to cshtNumPlayers
        Try
            strTemp = InputBox("Please enter the number of players (1-6):")
            cshtNumPlayers = CShort(strTemp)

            If cshtNumPlayers > 6 Then
                MessageBox.Show("The maximum number of players is 6.")
                cshtNumPlayers = 6
            ElseIf cshtNumPlayers < 1 Then
                MessageBox.Show("The minimum number of players is 1.")
                cshtNumPlayers = 1
            End If
        Catch
            MessageBox.Show("You must enter a numeric value")
        End Try

        'Ask for names and assign to string array
        For i = 1 To cshtNumPlayers
            strTemp = InputBox("Please enter the name of player " &
                                       i.ToString & ":")
            cstrPlayerNames(i - 1) = strTemp
            clblPlayersU(i - 1).Text = strTemp
            clblPlayersL(i - 1).Text = strTemp
            clblPlayersT(i - 1).Text = strTemp
        Next i

        If cshtNumPlayers = 1 Then
            grpUpperSection.Width = 95 + cshtNumPlayers * 93
            grpLowerSection.Width = 100 + cshtNumPlayers * 100
            clblPlayersL(1).Visible = False
            clblPlayersL(2).Visible = False
            clblPlayersL(3).Visible = False
            clblPlayersL(4).Visible = False
            clblPlayersL(5).Visible = False
            clblPlayersU(1).Visible = False
            clblPlayersU(2).Visible = False
            clblPlayersU(3).Visible = False
            clblPlayersU(4).Visible = False
            clblPlayersU(5).Visible = False
            clblPlayersT(1).Visible = False
            clblPlayersT(2).Visible = False
            clblPlayersT(3).Visible = False
            clblPlayersT(4).Visible = False
            clblPlayersT(5).Visible = False
            clblTotal(1).Visible = False
            clblTotal(2).Visible = False
            clblTotal(3).Visible = False
            clblTotal(4).Visible = False
            clblTotal(5).Visible = False
            grpUpperSection.Left = 150
            grpLowerSection.Left = 450
            clblPlayersU(0).Left = grpUpperSection.Left + btnAces.Width + 15
            clblPlayersL(0).Left = grpLowerSection.Left + btn3OfAKind.Width + 15
            clblPlayersT(0).Left = grpUpperSection.Left + btnAces.Width * 2
            clblTotal(0).Left = clblPlayersT(0).Left + clblPlayersT(0).Width + 10
            For i = 0 To 4
                cpicDie(i).Left = i * cpicDie(i).Width + 100
                cchkHold(i).Left = i * cchkHold(i).Width + 100
            Next
            btnRoll.Left = 475
            lblRounds.Left = btnRoll.Left + lblRounds.Width + 10
            lblRoundsLeft.Left = lblRounds.Left
            Me.Width = lblRounds.Left + lblRounds.Width + 110
        End If

        If cshtNumPlayers = 2 Then
            grpUpperSection.Width = 95 + cshtNumPlayers * 87
            grpLowerSection.Width = 100 + cshtNumPlayers * 90
            clblPlayersL(2).Visible = False
            clblPlayersL(3).Visible = False
            clblPlayersL(4).Visible = False
            clblPlayersL(5).Visible = False
            clblPlayersU(2).Visible = False
            clblPlayersU(3).Visible = False
            clblPlayersU(4).Visible = False
            clblPlayersU(5).Visible = False
            clblPlayersT(2).Visible = False
            clblPlayersT(3).Visible = False
            clblPlayersT(4).Visible = False
            clblPlayersT(5).Visible = False
            clblTotal(2).Visible = False
            clblTotal(3).Visible = False
            clblTotal(4).Visible = False
            clblTotal(5).Visible = False
            grpUpperSection.Left = 100
            grpLowerSection.Left = 500
            clblPlayersU(0).Left = grpUpperSection.Left + btnAces.Width + 20
            clblPlayersU(1).Left = clblPlayersU(0).Left + clblPlayersU(0).Width + 5
            clblPlayersL(0).Left = grpLowerSection.Left + btn3OfAKind.Width + 20
            clblPlayersL(1).Left = clblPlayersL(0).Left + clblPlayersL(0).Width + 5
            clblPlayersT(0).Left = grpUpperSection.Left + btnAces.Width * 2
            clblTotal(0).Left = clblPlayersT(0).Left + clblPlayersT(0).Width + 10
            clblPlayersT(1).Left = clblTotal(0).Left + clblTotal(0).Width + 20
            clblTotal(1).Left = clblPlayersT(1).Left + clblPlayersT(1).Width + 20
            For i = 0 To 4
                cpicDie(i).Left = i * cpicDie(i).Width + 100
                cchkHold(i).Left = i * cchkHold(i).Width + 100
            Next
            btnRoll.Left = 500
            lblRounds.Left = btnRoll.Left + lblRounds.Width + 10
            lblRoundsLeft.Left = lblRounds.Left
            Me.Width = lblRounds.Left + lblRounds.Width + 200
        End If

        If cshtNumPlayers = 3 Then
            grpUpperSection.Width = 95 + cshtNumPlayers * 85
            grpLowerSection.Width = 100 + cshtNumPlayers * 87
            clblPlayersL(3).Visible = False
            clblPlayersL(4).Visible = False
            clblPlayersL(5).Visible = False
            clblPlayersU(3).Visible = False
            clblPlayersU(4).Visible = False
            clblPlayersU(5).Visible = False
            clblPlayersT(3).Visible = False
            clblPlayersT(4).Visible = False
            clblPlayersT(5).Visible = False
            clblTotal(3).Visible = False
            clblTotal(4).Visible = False
            clblTotal(5).Visible = False
            grpUpperSection.Left = 75
            grpLowerSection.Left = 525
            clblPlayersU(0).Left = grpUpperSection.Left + btnAces.Width + 20
            clblPlayersU(1).Left = clblPlayersU(0).Left + clblPlayersU(0).Width + 7
            clblPlayersU(2).Left = clblPlayersU(1).Left + clblPlayersU(1).Width + 7
            clblPlayersL(0).Left = grpLowerSection.Left + btn3OfAKind.Width + 20
            clblPlayersL(1).Left = clblPlayersL(0).Left + clblPlayersL(0).Width + 5
            clblPlayersL(2).Left = clblPlayersL(1).Left + clblPlayersL(1).Width + 5
            clblPlayersT(0).Left = grpUpperSection.Left + btnAces.Width * 2
            clblTotal(0).Left = clblPlayersT(0).Left + clblPlayersT(0).Width + 10
            clblPlayersT(1).Left = clblTotal(0).Left + clblTotal(0).Width + 20
            clblTotal(1).Left = clblPlayersT(1).Left + clblPlayersT(1).Width + 20
            clblPlayersT(2).Left = clblTotal(1).Left + clblTotal(1).Width + 20
            clblTotal(2).Left = clblPlayersT(2).Left + clblPlayersT(2).Width + 20
            For i = 0 To 4
                cpicDie(i).Left = i * cpicDie(i).Width + 135
                cchkHold(i).Left = i * cchkHold(i).Width + 135
            Next
            btnRoll.Left = 525
            lblRounds.Left = btnRoll.Left + lblRounds.Width + 10
            lblRoundsLeft.Left = lblRounds.Left
            Me.Width = lblRounds.Left + lblRounds.Width + 240
        End If

        If cshtNumPlayers = 4 Then
            grpUpperSection.Width = 95 + cshtNumPlayers * 84
            grpLowerSection.Width = 100 + cshtNumPlayers * 86
            clblPlayersL(4).Visible = False
            clblPlayersL(5).Visible = False
            clblPlayersU(4).Visible = False
            clblPlayersU(5).Visible = False
            clblPlayersT(4).Visible = False
            clblPlayersT(5).Visible = False
            clblTotal(4).Visible = False
            clblTotal(5).Visible = False
            grpUpperSection.Left = 50
            grpLowerSection.Left = 525
            clblPlayersU(0).Left = grpUpperSection.Left + btnAces.Width + 20
            clblPlayersU(1).Left = clblPlayersU(0).Left + clblPlayersU(0).Width + 5
            clblPlayersU(2).Left = clblPlayersU(1).Left + clblPlayersU(1).Width + 5
            clblPlayersU(3).Left = clblPlayersU(2).Left + clblPlayersU(2).Width + 8
            clblPlayersL(0).Left = grpLowerSection.Left + btn3OfAKind.Width + 20
            clblPlayersL(1).Left = clblPlayersL(0).Left + clblPlayersL(0).Width + 5
            clblPlayersL(2).Left = clblPlayersL(1).Left + clblPlayersL(1).Width + 5
            clblPlayersL(3).Left = clblPlayersL(2).Left + clblPlayersL(2).Width + 9
            clblPlayersT(0).Left = grpUpperSection.Left + btnAces.Width
            clblTotal(0).Left = clblPlayersT(0).Left + clblPlayersT(0).Width + 10
            clblPlayersT(1).Left = clblTotal(0).Left + clblTotal(0).Width + 20
            clblTotal(1).Left = clblPlayersT(1).Left + clblPlayersT(1).Width + 20
            clblPlayersT(2).Left = clblTotal(1).Left + clblTotal(1).Width + 20
            clblTotal(2).Left = clblPlayersT(2).Left + clblPlayersT(2).Width + 20
            clblPlayersT(3).Left = clblTotal(2).Left + clblTotal(2).Width + 21
            clblTotal(3).Left = clblPlayersT(3).Left + clblPlayersT(3).Width + 21
            For i = 0 To 4
                cpicDie(i).Left = i * cpicDie(i).Width + 150
                cchkHold(i).Left = i * cchkHold(i).Width + 150
            Next
            btnRoll.Left = 550
            lblRounds.Left = btnRoll.Left + lblRounds.Width + 10
            lblRoundsLeft.Left = lblRounds.Left
            Me.Width = lblRounds.Left + lblRounds.Width + 275
        End If

        If cshtNumPlayers = 5 Then
            grpUpperSection.Width = 95 + cshtNumPlayers * 83
            grpLowerSection.Width = 100 + cshtNumPlayers * 85
            clblPlayersL(5).Visible = False
            clblPlayersU(5).Visible = False
            clblPlayersT(5).Visible = False
            clblTotal(5).Visible = False
            grpUpperSection.Left = 25
            grpLowerSection.Left = 600
            clblPlayersU(0).Left = grpUpperSection.Left + btnAces.Width + 20
            clblPlayersU(1).Left = clblPlayersU(0).Left + clblPlayersU(0).Width + 5
            clblPlayersU(2).Left = clblPlayersU(1).Left + clblPlayersU(1).Width + 5
            clblPlayersU(3).Left = clblPlayersU(2).Left + clblPlayersU(2).Width + 8
            clblPlayersU(4).Left = clblPlayersU(3).Left + clblPlayersU(3).Width + 9
            clblPlayersL(0).Left = grpLowerSection.Left + btn3OfAKind.Width + 20
            clblPlayersL(1).Left = clblPlayersL(0).Left + clblPlayersL(0).Width + 5
            clblPlayersL(2).Left = clblPlayersL(1).Left + clblPlayersL(1).Width + 5
            clblPlayersL(3).Left = clblPlayersL(2).Left + clblPlayersL(2).Width + 8
            clblPlayersL(4).Left = clblPlayersL(3).Left + clblPlayersL(3).Width + 9
            clblPlayersT(0).Left = grpUpperSection.Left + btnAces.Width
            clblTotal(0).Left = clblPlayersT(0).Left + clblPlayersT(0).Width + 10
            clblPlayersT(1).Left = clblTotal(0).Left + clblTotal(0).Width + 20
            clblTotal(1).Left = clblPlayersT(1).Left + clblPlayersT(1).Width + 20
            clblPlayersT(2).Left = clblTotal(1).Left + clblTotal(1).Width + 20
            clblTotal(2).Left = clblPlayersT(2).Left + clblPlayersT(2).Width + 20
            clblPlayersT(3).Left = clblTotal(2).Left + clblTotal(2).Width + 21
            clblTotal(3).Left = clblPlayersT(3).Left + clblPlayersT(3).Width + 21
            clblPlayersT(4).Left = clblTotal(3).Left + clblTotal(3).Width + 22
            clblTotal(4).Left = clblPlayersT(4).Left + clblPlayersT(4).Width + 22
            For i = 0 To 4
                cpicDie(i).Left = i * cpicDie(i).Width + 225
                cchkHold(i).Left = i * cchkHold(i).Width + 225
            Next
            btnRoll.Left = 625
            lblRounds.Left = btnRoll.Left + lblRounds.Width + 10
            lblRoundsLeft.Left = lblRounds.Left
            Me.Width = lblRounds.Left + lblRounds.Width * 3 + 140
        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: Checks an array of values for a how many of a particular 
    '             number.
    '
    'Called by:   btnAces_Click, btnTwos_Click, btnThrees_Click, btnFours_Click,
    '             btnFives_Click, btnSixes_Click.
    '--------------------------------------------------------------------------
    Private Function fHowMany(ByVal shtNumber As Short,
                              ByVal cshtDiceVal() As Short) As Short
        Dim shtQty As Short
        Dim i As Short

        For i = 0 To 4
            If cshtDiceVal(i) = shtNumber Then
                shtQty += CShort(1)
            End If
        Next i

        Return shtQty

    End Function

    '--------------------------------------------------------------------------
    'Description: This sub checks if the number of rounds have been reached,
    '             and if so, it will determine which player has the highest 
    '             score, congratulate them in a popup, then save high scores.
    '
    'Called by:   btnAces_Click, btnTwos_Click, btnThrees_Click, btnFours_Click,
    '             btnFives_Click, btnSixes_Click, btn3OfAKind_Click,
    '             btn4OfAKind_Click, btnFullHouse_Click, btnSmallStraight_Click,
    '             btnLargeStraight_Click, btnChance_Click.
    '--------------------------------------------------------------------------
    Private Sub sEndGame()

        Dim shtHighScore As Short
        Dim strWinner As String
        Dim i As Short

        If cshtCurrentPlayer + 1 = cshtNumPlayers Then
            cshtTurn += CShort(1)
            lblRoundsLeft.Text = CStr(13 - cshtTurn)

            If cshtTurn = 13 Then
                shtHighScore = cshtPlayerScores(0, 18)
                strWinner = cstrPlayerNames(0)

                For i = 1 To cshtCurrentPlayer
                    If cshtPlayerScores(i, 18) > shtHighScore Then
                        shtHighScore = cshtPlayerScores(i, 18)
                        strWinner = cstrPlayerNames(i)
                    End If
                Next i

                MessageBox.Show("Congratulations, " & strWinner & "!" &
                                Chr(13) & "You have the highest score!")
                'then save player name and score to high scores file
            End If

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: Increments the current player, and resets to 0 if reaching 
    '             maximum.
    '
    'Called by:   sEndofTurn, btnYahtzee_Click, btnYahtzeeBonus_Click.
    '--------------------------------------------------------------------------
    Private Sub sNextTurn()

        cshtCurrentPlayer += CShort(1)

        If cshtCurrentPlayer = cshtNumPlayers Then
            cshtCurrentPlayer = 0
        End If

        lblCurrentPlayer.Text = cstrPlayerNames(cshtCurrentPlayer) & "'s Turn"

    End Sub

    '--------------------------------------------------------------------------
    'Description: Generates random dice roll of each dice that doesn't have a
    '             checked "Hold".
    '
    'Called by:   btnRoll_Click.
    '--------------------------------------------------------------------------
    Private Sub sRollEm()

        Dim i As Integer

        For i = 0 To 4
            If cchkHold(i).Checked = False Then

                cshtDiceVal(i) = CShort(Int(Rnd() * 6 + 1))
                cpicDie(i).BackgroundImage = Image.FromFile("..\Images\redDie" _
                                             & cshtDiceVal(i).ToString & ".png")

            End If
        Next i

    End Sub

    '--------------------------------------------------------------------------
    'Description: This reduces lines of code by making one call for four.
    '
    'Calls:       sTotalUp, sEndGame, sNextTurn, sResetTheDice.
    '
    'Called by:   btnAces_Click, btnTwos_Click, btnThrees_Click, btnFours_Click,
    '             btnFives_Click, btnSixes_Click, btn3OfAKind_Click, 
    '             btn4OfAKind_Click, btnFullHouse_Click, btnSmallStraight_Click,
    '             btnLargeSTraight_Click, btnChance_Click.
    '--------------------------------------------------------------------------
    Private Sub sEndofTurn()

        Call sTotalUp()
        Call sEndGame()
        Call sNextTurn()
        Call sResetTheDie()

    End Sub

    '--------------------------------------------------------------------------
    'Description: Checks how many times the dice have been rolled and 
    '             increments. This sub will not execute function if the dice
    '             have been rolled 3 times.
    '
    'Call:        sRollEm
    '--------------------------------------------------------------------------
    Private Sub btnRoll_Click(sender As Object,
                              e As EventArgs) Handles btnRoll.Click

        If cshtRolls < 3 Then
            Call sRollEm()
            cshtRolls += CShort(1)
        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: Calculates the total and then assigns to the right labels. If
    '             the total of upper section is bigger than 62, the players 
    '             will get a 35 bonus point.
    '
    'Called by:   sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub sTotalUp()

        Dim i As Short
        Dim j As Short
        Dim shtBonusCheck As Short

        cshtPlayerScores(cshtCurrentPlayer, 17) = 0 'Fix score totalling bug

        For i = 0 To 5
            shtBonusCheck += cshtPlayerScores(cshtCurrentPlayer, i)
        Next

        cshtPlayerScores(cshtCurrentPlayer, 6) = shtBonusCheck
        clblTotalScore(cshtCurrentPlayer).Text = shtBonusCheck.ToString

        If shtBonusCheck > 62 Then
            cshtPlayerScores(cshtCurrentPlayer, 7) = 35
            clblBonus(cshtCurrentPlayer).Text = "35"
        End If

        cshtPlayerScores(cshtCurrentPlayer, 8) =
            cshtPlayerScores(cshtCurrentPlayer, 7) +
                cshtPlayerScores(cshtCurrentPlayer, 6)
        clblTotalOfUpperSection(cshtCurrentPlayer).Text =
            cshtPlayerScores(cshtCurrentPlayer, 8).ToString

        For j = 9 To 16

            cshtPlayerScores(cshtCurrentPlayer, 17) +=
                cshtPlayerScores(cshtCurrentPlayer, j)
        Next j

        clblTotalOfLowerSection(cshtCurrentPlayer).Text =
            cshtPlayerScores(cshtCurrentPlayer, 17).ToString()

        cshtPlayerScores(cshtCurrentPlayer, 18) =
            cshtPlayerScores(cshtCurrentPlayer, 8) +
                cshtPlayerScores(cshtCurrentPlayer, 17)

        clblTotal(cshtCurrentPlayer).Text =
            cshtPlayerScores(cshtCurrentPlayer, 18).ToString

    End Sub

    '--------------------------------------------------------------------------
    'Description: A function to get the total value of all dice.
    '
    'Called by:   btn3OfAKind_Click, btn4OfAKind_Click, btnChance_Click.
    '--------------------------------------------------------------------------
    Private Function fDiceTotal() As Short

        Dim i As Short
        Dim shtTotal As Short

        For i = 0 To 4
            shtTotal += cshtDiceVal(i)
        Next i

        Return shtTotal

    End Function

    '--------------------------------------------------------------------------
    'Description: Resets all the dice to prepare for new roll.
    '
    'Called by:   sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub sResetTheDie()

        Dim i As Short

        For i = 0 To 4
            cpicDie(i).BackgroundImage = Image.FromFile("..\Images\redDie0.png")
            cpicDie(i).BackgroundImageLayout = ImageLayout.Zoom
            cchkHold(i).Checked = False
        Next i

        cshtRolls = 0

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if the Aces have not been scored, this sub 
    '             will check how many Aces there are in the dice value array
    '             and assign that number to the 0 element of the scores array
    '             and display it on clblAces(cshtCurrentPlayer), then update
    '             the score, check if the game ends and if not, calculate the
    '             turn and reset the dice.
    '
    'Calls:       sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnAces_Click(sender As Object,
                              e As EventArgs) Handles btnAces.Click

        If clblAces(cshtCurrentPlayer).Text = "" Then
            cshtPlayerScores(cshtCurrentPlayer, 0) = fHowMany(1, cshtDiceVal)
            clblAces(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 0).ToString

            Call sEndofTurn()

        End If


    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if the Twos have not been scored, this sub 
    '             will check how many Twos there are in the dice value array
    '             and assign that number to the 1 element of the scores array
    '             and display it on clblTwos(cshtCurrentPlayer), then update
    '             the score, check if the game ends and if not, calculate the
    '             turn and reset the dice.
    '
    'Calls:       sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnTwos_Click(sender As Object,
                              e As EventArgs) Handles btnTwos.Click

        If clblTwos(cshtCurrentPlayer).Text = "" Then
            cshtPlayerScores(cshtCurrentPlayer, 1) =
                CShort(fHowMany(2, cshtDiceVal) * 2)
            clblTwos(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 1).ToString

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if the Threes have not been scored, this sub 
    '             will check how many Threes there are in the dice value array
    '             and assign that number to the 2 element of the scores array
    '             and display it on clblThrees(cshtCurrentPlayer), then update
    '             the score, check if the game ends and if not, calculate the
    '             turn and reset the dice.
    '
    'Calls:       sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnThrees_Click(sender As Object,
                                e As EventArgs) Handles btnThrees.Click

        If clblThrees(cshtCurrentPlayer).Text = "" Then
            cshtPlayerScores(cshtCurrentPlayer, 2) =
                CShort(fHowMany(3, cshtDiceVal) * 3)
            clblThrees(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 2).ToString

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if the Fours have not been scored, this sub 
    '             will check how many Fours there are in the dice value array
    '             and assign that number to the 3 element of the scores array
    '             and display it on clblFours(cshtCurrentPlayer), then update
    '             the score, check if the game ends and if not, calculate the
    '             turn and reset the dice.
    '
    'Calls:       sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnFours_Click(sender As Object,
                               e As EventArgs) Handles btnFours.Click

        If clblFours(cshtCurrentPlayer).Text = "" Then
            cshtPlayerScores(cshtCurrentPlayer, 3) =
                CShort(fHowMany(4, cshtDiceVal) * 4)
            clblFours(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 3).ToString

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if the Fives have not been scored, this sub 
    '             will check how many Fives there are in the dice value array
    '             and assign that number to the 4 element of the scores array
    '             and display it on clblFives(cshtCurrentPlayer), then update
    '             the score, check if the game ends and if not, calculate the
    '             turn and reset the dice.
    '
    'Calls:       sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnFives_Click(sender As Object,
                               e As EventArgs) Handles btnFives.Click

        If clblFives(cshtCurrentPlayer).Text = "" Then
            cshtPlayerScores(cshtCurrentPlayer, 4) =
                CShort(fHowMany(5, cshtDiceVal) * 5)
            clblFives(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 4).ToString

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if the Sixes have not been scored, this sub 
    '             will check how many Sixes there are in the dice value array
    '             and assign that number to the 5 element of the scores array
    '             and display it on clblSixes(cshtCurrentPlayer), then update
    '             the score, check if the game ends and if not, calculate the
    '             turn and reset the dice.
    '
    'Calls:       sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnSixes_Click(sender As Object,
                               e As EventArgs) Handles btnSixes.Click

        If clblSixes(cshtCurrentPlayer).Text = "" Then
            cshtPlayerScores(cshtCurrentPlayer, 5) =
                CShort(fHowMany(6, cshtDiceVal) * 6)
            clblSixes(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 5).ToString

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: This sub checks how many of the dice of a particular value 
    '             there are and then return a boolean value.
    '
    'Called by:   btn3OfAKind_Click, btn4OfAKind_Click, btnFullHouse_Click,
    '             btnYahtzee_Click, btnYahtzeeBonus_Click.
    '--------------------------------------------------------------------------
    Private Function fTargetAmt(ByVal shtNum As Short) As Boolean

        Dim blnTarget As Boolean
        Dim i As Short

        Dim sht1 As Short
        Dim sht2 As Short
        Dim sht3 As Short
        Dim sht4 As Short
        Dim sht5 As Short
        Dim sht6 As Short

        sht1 = fHowMany(1, cshtDiceVal)
        sht2 = fHowMany(2, cshtDiceVal)
        sht3 = fHowMany(3, cshtDiceVal)
        sht4 = fHowMany(4, cshtDiceVal)
        sht5 = fHowMany(5, cshtDiceVal)
        sht6 = fHowMany(6, cshtDiceVal)

        For i = 0 To 5
            If sht1 = shtNum Or sht2 = shtNum Or sht3 = shtNum Or
                    sht4 = shtNum Or sht5 = shtNum Or sht6 = shtNum Then
                blnTarget = True
            End If
        Next i

        Return blnTarget

    End Function

    '--------------------------------------------------------------------------
    'Description: After verifying if 3 of a kind has not been score, this sub
    '             checks if there are three of a kind of dice present, then
    '             scores it.
    '
    'Calls:       fTargetAmt, sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btn3OfAKind_Click(sender As Object,
                                  e As EventArgs) Handles btn3OfAKind.Click

        If clbl3OfAKind(cshtCurrentPlayer).Text = "" Then

            If fTargetAmt(3) Or fTargetAmt(4) Or fTargetAmt(5) Then
                cshtPlayerScores(cshtCurrentPlayer, 9) = fDiceTotal()
                clbl3OfAKind(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 9).ToString
            Else
                cshtPlayerScores(cshtCurrentPlayer, 9) = 0
                clbl3OfAKind(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 9).ToString
            End If
            Call sEndofTurn()
        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After veryfying if 4 of a kind has not been scored, it checks
    '             if there are four of a kind of dice present, then scores it.
    '
    'Calls:       fTargetAmt, sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btn4OfAKind_Click(sender As Object,
                                  e As EventArgs) Handles btn4OfAKind.Click

        If clbl4OfAKind(cshtCurrentPlayer).Text = "" Then

            If fTargetAmt(4) Or fTargetAmt(5) Then
                cshtPlayerScores(cshtCurrentPlayer, 10) = fDiceTotal()
                clbl4OfAKind(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 10).ToString
            Else
                cshtPlayerScores(cshtCurrentPlayer, 10) = 0
                clbl4OfAKind(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 10).ToString
            End If

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if Yahtzee have not been scored, this sub
    '             checks if there are five of a kind dice present, there 
    '             scores 50. If not, the player scores 0.
    '
    'Calls:       fTargetAmt, sTotalUp, sResetTheDice, sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnYahtzee_Click(sender As Object,
                                 e As EventArgs) Handles btnYahtzee.Click

        If clblYahtzee(cshtCurrentPlayer).Text = "" Then

            If fTargetAmt(5) Then
                cshtPlayerScores(cshtCurrentPlayer, 14) = 50
                clblYahtzee(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 14).ToString

                Call sTotalUp()
                Call sResetTheDie()
            Else
                cshtPlayerScores(cshtCurrentPlayer, 14) = 0
                clblYahtzee(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 14).ToString

                Call sEndofTurn()
            End If
            cblnYahtzee(cshtCurrentPlayer) = True

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if Full House has not been scored, it checks
    '             if there are 2 of a kind and 3 of a kind and then scores it.
    '             If not, the player will get 0 point.
    '
    'Calls:       fTargetAmt, sEndofTurn
    '--------------------------------------------------------------------------
    Private Sub btnFullHouse_Click(sender As Object,
                                   e As EventArgs) Handles btnFullHouse.Click

        If clblFullHouse(cshtCurrentPlayer).Text = "" Then

            If fTargetAmt(2) And fTargetAmt(3) Then
                cshtPlayerScores(cshtCurrentPlayer, 11) = 25
                clblFullHouse(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 11).ToString
            Else
                cshtPlayerScores(cshtCurrentPlayer, 11) = 0
                clblFullHouse(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 11).ToString
            End If

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if Small Straight has not been scored, it
    '             checks if there are four dice in a row and then score it. If
    '             not, the player will get 0 point.
    '
    'Calls:       fHowMany, sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnSmallStraight_Click(sender As Object,
                                       e As EventArgs) Handles btnSmallStraight.Click

        If clblSmallStraight(cshtCurrentPlayer).Text = "" Then

            Dim sht1 As Short
            Dim sht2 As Short
            Dim sht3 As Short
            Dim sht4 As Short
            Dim sht5 As Short
            Dim sht6 As Short

            sht1 = fHowMany(1, cshtDiceVal)
            sht2 = fHowMany(2, cshtDiceVal)
            sht3 = fHowMany(3, cshtDiceVal)
            sht4 = fHowMany(4, cshtDiceVal)
            sht5 = fHowMany(5, cshtDiceVal)
            sht6 = fHowMany(6, cshtDiceVal)

            If sht1 >= 1 And sht2 >= 1 And sht3 >= 1 And sht4 >= 1 Then

                cshtPlayerScores(cshtCurrentPlayer, 12) = 30
                clblSmallStraight(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 12).ToString

            ElseIf sht2 >= 1 And sht3 >= 1 And sht4 >= 1 And sht5 >= 1 Then

                cshtPlayerScores(cshtCurrentPlayer, 12) = 30
                clblSmallStraight(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 12).ToString

            ElseIf sht3 >= 1 And sht4 >= 1 And sht5 >= 1 And sht6 >= 1 Then

                cshtPlayerScores(cshtCurrentPlayer, 12) = 30
                clblSmallStraight(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 12).ToString

            Else
                cshtPlayerScores(cshtCurrentPlayer, 12) = 0
                clblSmallStraight(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 12).ToString

            End If

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if Large Straight has not been scored, it
    '             checks if there are 5 dice in a row and then scores it. If
    '             not, the player will get 0 point.
    '
    'Calls:       fHowMany, sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnLargeStraight_Click(sender As Object,
                                       e As EventArgs) Handles btnLargeStraight.Click

        If clblLargeStraight(cshtCurrentPlayer).Text = "" Then

            Dim sht1 As Short
            Dim sht2 As Short
            Dim sht3 As Short
            Dim sht4 As Short
            Dim sht5 As Short
            Dim sht6 As Short

            sht1 = fHowMany(1, cshtDiceVal)
            sht2 = fHowMany(2, cshtDiceVal)
            sht3 = fHowMany(3, cshtDiceVal)
            sht4 = fHowMany(4, cshtDiceVal)
            sht5 = fHowMany(5, cshtDiceVal)
            sht6 = fHowMany(6, cshtDiceVal)

            If sht1 = 1 And sht2 = 1 And sht3 = 1 And sht4 = 1 And sht5 = 1 Then

                cshtPlayerScores(cshtCurrentPlayer, 13) = 40
                clblLargeStraight(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 13).ToString

            ElseIf sht2 = 1 And sht3 = 1 And sht4 = 1 And sht5 = 1 And sht6 = 1 Then

                cshtPlayerScores(cshtCurrentPlayer, 13) = 40
                clblLargeStraight(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 13).ToString

            Else
                cshtPlayerScores(cshtCurrentPlayer, 13) = 0
                clblLargeStraight(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 13).ToString

            End If

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if Chance has not been scored, this sub
    '             calculates the total value of all dice and then score it.
    '
    'Calls:       fDiceTotal, sEndofTurn.
    '--------------------------------------------------------------------------
    Private Sub btnChance_Click(sender As Object,
                                e As EventArgs) Handles btnChance.Click

        If clblChance(cshtCurrentPlayer).Text = "" Then

            Dim i As Short

            For i = 0 To 5

                cshtPlayerScores(cshtCurrentPlayer, 15) = fDiceTotal()
                clblChance(cshtCurrentPlayer).Text =
                    cshtPlayerScores(cshtCurrentPlayer, 15).ToString

            Next

            Call sEndofTurn()

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: After verifying if the player has scored Yahtzee and if there
    '             are 5 dice in a row, the player will get 50 points.
    '
    'Calls:       fHowMany, sTotalUp, sResetTheDice
    '--------------------------------------------------------------------------
    Private Sub btnYahtzeeBonus_Click(sender As Object,
                                      e As EventArgs) Handles btnYahtzeeBonus.Click

        If cblnYahtzee(cshtCurrentPlayer) = True And fTargetAmt(5) Then

            cshtPlayerScores(cshtCurrentPlayer, 16) += CShort(50)
            clblYahtzeeBonus(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 16).ToString

            Call sTotalUp()
            Call sResetTheDie()

        Else
            cshtPlayerScores(cshtCurrentPlayer, 16) = 0
            clblYahtzeeBonus(cshtCurrentPlayer).Text =
                cshtPlayerScores(cshtCurrentPlayer, 16).ToString

        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description: Saves the program.
    '--------------------------------------------------------------------------
    Private Sub mnuSaveGame_Click(sender As Object,
                                  e As EventArgs) Handles mnuSaveGame.Click

        Dim i As Short

        FileOpen(1, "..\Data\ygs.txt", OpenMode.Output)
        WriteLine(1, cshtNumPlayers)

        For i = 0 To cshtNumPlayers - CShort(1)
            'FileOpen(1, "..\Data\" & (i + CShort(1)).ToString & ".txt", OpenMode.Output)
            WriteLine(1, clblAces(i).Text)
            WriteLine(1, clblTwos(i).Text)
            WriteLine(1, clblThrees(i).Text)
            WriteLine(1, clblFours(i).Text)
            WriteLine(1, clblFives(i).Text)
            WriteLine(1, clblSixes(i).Text)
            WriteLine(1, clblTotalScore(i).Text)
            WriteLine(1, clblBonus(i).Text)
            WriteLine(1, clblTotalOfUpperSection(i).Text)
            WriteLine(1, clbl3OfAKind(i).Text)
            WriteLine(1, clbl4OfAKind(i).Text)
            WriteLine(1, clblFullHouse(i).Text)
            WriteLine(1, clblSmallStraight(i).Text)
            WriteLine(1, clblLargeStraight(i).Text)
            WriteLine(1, clblYahtzee(i).Text)
            WriteLine(1, clblChance(i).Text)
            WriteLine(1, clblYahtzeeBonus(i).Text)
            WriteLine(1, clblTotalOfLowerSection(i).Text)
            WriteLine(1, clblPlayersL(i).Text)
            WriteLine(1, clblPlayersU(i).Text)
            WriteLine(1, clblPlayersT(i).Text)
            WriteLine(1, clblTotal(i).Text)
        Next i

        FileClose(1)

    End Sub

    '--------------------------------------------------------------------------
    'Description: Loads the game for the player to continue their game.
    '
    'Calls:       sLoadGame.
    '--------------------------------------------------------------------------
    Private Sub mnuLoadGame_Click(sender As Object,
                                  e As EventArgs) Handles mnuLoadGame.Click

        Call sLoadGame()

    End Sub

    '----------------------------------------------------------------------
    'Description: Shows the information of the people who made the program.
    '----------------------------------------------------------------------
    Private Sub mnuAbout_Click(sender As Object,
                               e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("Yahtzee designed and written by:" & Chr(13) &
                        "Team Jingle Bells" & Chr(13) & Chr(13) & "Margaret
                        Alcock" & Chr(13) & "Van Quach" & Chr(13) & "Dylan 
                        Parker" & Chr(13) & "Tyler Little" & Chr(13) & Chr(13) &
                        "CS 115,  Section C" & Chr(13) & "Fall 2018")

    End Sub

    '--------------------------------------------------------------------------
    'Description: Shows the rules of the program.
    '--------------------------------------------------------------------------
    Private Sub mnuHowToPlay_Click(sender As Object,
                                   e As EventArgs) Handles mnuHowToPlay.Click

        lblRules.Text = ""
        grpHowTo.Visible = True

        FileOpen(47, "..\Images\howtoplay.Txt", OpenMode.Input)
        Dim strTemp As String
        Do Until EOF(47) = True

            strTemp = LineInput(47) & Chr(13)
            lblRules.Text &= strTemp

        Loop

        FileClose(47)

    End Sub

    '--------------------------------------------------------------------------
    'Description: Close grpHowTo.
    '--------------------------------------------------------------------------
    Private Sub btnClose_Click(sender As Object,
                               e As EventArgs) Handles btnClose.Click

        grpHowTo.Visible = False

    End Sub

End Class

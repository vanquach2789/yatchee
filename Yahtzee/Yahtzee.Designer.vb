<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Yahtzee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpLowerSection = New System.Windows.Forms.GroupBox()
        Me.lblTotalOfLowerSection = New System.Windows.Forms.Label()
        Me.btnYahtzeeBonus = New System.Windows.Forms.Button()
        Me.btnChance = New System.Windows.Forms.Button()
        Me.btnYahtzee = New System.Windows.Forms.Button()
        Me.btnLargeStraight = New System.Windows.Forms.Button()
        Me.btn3OfAKind = New System.Windows.Forms.Button()
        Me.btn4OfAKind = New System.Windows.Forms.Button()
        Me.btnFullHouse = New System.Windows.Forms.Button()
        Me.btnSmallStraight = New System.Windows.Forms.Button()
        Me.grpUpperSection = New System.Windows.Forms.GroupBox()
        Me.lblTotalOfUpperSection = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.btnAces = New System.Windows.Forms.Button()
        Me.btnSixes = New System.Windows.Forms.Button()
        Me.btnTwos = New System.Windows.Forms.Button()
        Me.btnFives = New System.Windows.Forms.Button()
        Me.btnThrees = New System.Windows.Forms.Button()
        Me.btnFours = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighScore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighScoreView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHowToPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tipAces = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipTwos = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipThrees = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipFours = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipFives = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipSixes = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip3OfAKind = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip4OfAKind = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipFullHouse = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipSmallStraight = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipLargeStraight = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipYahtzee = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipChance = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipYahtzeeBonus = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipRoll = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblRoundsLeft = New System.Windows.Forms.Label()
        Me.lblRounds = New System.Windows.Forms.Label()
        Me.stsCurrentPlayer = New System.Windows.Forms.StatusStrip()
        Me.lblCurrentPlayer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpHowTo = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.grpLowerSection.SuspendLayout()
        Me.grpUpperSection.SuspendLayout()
        Me.mnuMainMenu.SuspendLayout()
        Me.stsCurrentPlayer.SuspendLayout()
        Me.grpHowTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLowerSection
        '
        Me.grpLowerSection.Controls.Add(Me.lblTotalOfLowerSection)
        Me.grpLowerSection.Controls.Add(Me.btnYahtzeeBonus)
        Me.grpLowerSection.Controls.Add(Me.btnChance)
        Me.grpLowerSection.Controls.Add(Me.btnYahtzee)
        Me.grpLowerSection.Controls.Add(Me.btnLargeStraight)
        Me.grpLowerSection.Controls.Add(Me.btn3OfAKind)
        Me.grpLowerSection.Controls.Add(Me.btn4OfAKind)
        Me.grpLowerSection.Controls.Add(Me.btnFullHouse)
        Me.grpLowerSection.Controls.Add(Me.btnSmallStraight)
        Me.grpLowerSection.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLowerSection.Location = New System.Drawing.Point(641, 197)
        Me.grpLowerSection.Name = "grpLowerSection"
        Me.grpLowerSection.Size = New System.Drawing.Size(620, 336)
        Me.grpLowerSection.TabIndex = 39
        Me.grpLowerSection.TabStop = False
        Me.grpLowerSection.Text = "Lower Section"
        '
        'lblTotalOfLowerSection
        '
        Me.lblTotalOfLowerSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalOfLowerSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalOfLowerSection.Location = New System.Drawing.Point(6, 274)
        Me.lblTotalOfLowerSection.Name = "lblTotalOfLowerSection"
        Me.lblTotalOfLowerSection.Size = New System.Drawing.Size(102, 51)
        Me.lblTotalOfLowerSection.TabIndex = 14
        Me.lblTotalOfLowerSection.Text = "Total of Lower Section"
        Me.lblTotalOfLowerSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYahtzeeBonus
        '
        Me.btnYahtzeeBonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnYahtzeeBonus.ForeColor = System.Drawing.Color.Black
        Me.btnYahtzeeBonus.Location = New System.Drawing.Point(6, 225)
        Me.btnYahtzeeBonus.Name = "btnYahtzeeBonus"
        Me.btnYahtzeeBonus.Size = New System.Drawing.Size(102, 46)
        Me.btnYahtzeeBonus.TabIndex = 13
        Me.btnYahtzeeBonus.Text = "Yahtzee Bonus"
        Me.tipYahtzeeBonus.SetToolTip(Me.btnYahtzeeBonus, "Score 50 each bonus")
        Me.btnYahtzeeBonus.UseVisualStyleBackColor = False
        '
        'btnChance
        '
        Me.btnChance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChance.ForeColor = System.Drawing.Color.Black
        Me.btnChance.Location = New System.Drawing.Point(6, 196)
        Me.btnChance.Name = "btnChance"
        Me.btnChance.Size = New System.Drawing.Size(102, 23)
        Me.btnChance.TabIndex = 13
        Me.btnChance.Text = "Chance"
        Me.tipChance.SetToolTip(Me.btnChance, "Score total of all 5 dice")
        Me.btnChance.UseVisualStyleBackColor = False
        '
        'btnYahtzee
        '
        Me.btnYahtzee.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnYahtzee.ForeColor = System.Drawing.Color.Black
        Me.btnYahtzee.Location = New System.Drawing.Point(6, 167)
        Me.btnYahtzee.Name = "btnYahtzee"
        Me.btnYahtzee.Size = New System.Drawing.Size(102, 23)
        Me.btnYahtzee.TabIndex = 12
        Me.btnYahtzee.Text = "Yahtzee"
        Me.tipYahtzee.SetToolTip(Me.btnYahtzee, "Score 50")
        Me.btnYahtzee.UseVisualStyleBackColor = False
        '
        'btnLargeStraight
        '
        Me.btnLargeStraight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLargeStraight.ForeColor = System.Drawing.Color.Black
        Me.btnLargeStraight.Location = New System.Drawing.Point(6, 138)
        Me.btnLargeStraight.Name = "btnLargeStraight"
        Me.btnLargeStraight.Size = New System.Drawing.Size(102, 23)
        Me.btnLargeStraight.TabIndex = 11
        Me.btnLargeStraight.Text = "Large Straight"
        Me.tipLargeStraight.SetToolTip(Me.btnLargeStraight, "Score 40")
        Me.btnLargeStraight.UseVisualStyleBackColor = False
        '
        'btn3OfAKind
        '
        Me.btn3OfAKind.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn3OfAKind.ForeColor = System.Drawing.Color.Black
        Me.btn3OfAKind.Location = New System.Drawing.Point(6, 22)
        Me.btn3OfAKind.Name = "btn3OfAKind"
        Me.btn3OfAKind.Size = New System.Drawing.Size(102, 23)
        Me.btn3OfAKind.TabIndex = 0
        Me.btn3OfAKind.Text = "3 of a kind"
        Me.tip3OfAKind.SetToolTip(Me.btn3OfAKind, "Add total of all dice")
        Me.btn3OfAKind.UseVisualStyleBackColor = False
        '
        'btn4OfAKind
        '
        Me.btn4OfAKind.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn4OfAKind.ForeColor = System.Drawing.Color.Black
        Me.btn4OfAKind.Location = New System.Drawing.Point(6, 51)
        Me.btn4OfAKind.Name = "btn4OfAKind"
        Me.btn4OfAKind.Size = New System.Drawing.Size(102, 23)
        Me.btn4OfAKind.TabIndex = 1
        Me.btn4OfAKind.Text = "4 of a kind"
        Me.tip4OfAKind.SetToolTip(Me.btn4OfAKind, "Add total of all dice")
        Me.btn4OfAKind.UseVisualStyleBackColor = False
        '
        'btnFullHouse
        '
        Me.btnFullHouse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFullHouse.ForeColor = System.Drawing.Color.Black
        Me.btnFullHouse.Location = New System.Drawing.Point(6, 80)
        Me.btnFullHouse.Name = "btnFullHouse"
        Me.btnFullHouse.Size = New System.Drawing.Size(102, 23)
        Me.btnFullHouse.TabIndex = 2
        Me.btnFullHouse.Text = "Full House"
        Me.tipFullHouse.SetToolTip(Me.btnFullHouse, "Score 25")
        Me.btnFullHouse.UseVisualStyleBackColor = False
        '
        'btnSmallStraight
        '
        Me.btnSmallStraight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSmallStraight.ForeColor = System.Drawing.Color.Black
        Me.btnSmallStraight.Location = New System.Drawing.Point(6, 109)
        Me.btnSmallStraight.Name = "btnSmallStraight"
        Me.btnSmallStraight.Size = New System.Drawing.Size(102, 23)
        Me.btnSmallStraight.TabIndex = 3
        Me.btnSmallStraight.Text = "Small Straight"
        Me.tipSmallStraight.SetToolTip(Me.btnSmallStraight, "Score 30")
        Me.btnSmallStraight.UseVisualStyleBackColor = False
        '
        'grpUpperSection
        '
        Me.grpUpperSection.Controls.Add(Me.lblTotalOfUpperSection)
        Me.grpUpperSection.Controls.Add(Me.lblBonus)
        Me.grpUpperSection.Controls.Add(Me.lblTotalScore)
        Me.grpUpperSection.Controls.Add(Me.btnAces)
        Me.grpUpperSection.Controls.Add(Me.btnSixes)
        Me.grpUpperSection.Controls.Add(Me.btnTwos)
        Me.grpUpperSection.Controls.Add(Me.btnFives)
        Me.grpUpperSection.Controls.Add(Me.btnThrees)
        Me.grpUpperSection.Controls.Add(Me.btnFours)
        Me.grpUpperSection.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUpperSection.Location = New System.Drawing.Point(11, 197)
        Me.grpUpperSection.Name = "grpUpperSection"
        Me.grpUpperSection.Size = New System.Drawing.Size(609, 336)
        Me.grpUpperSection.TabIndex = 38
        Me.grpUpperSection.TabStop = False
        Me.grpUpperSection.Text = "Upper Section"
        '
        'lblTotalOfUpperSection
        '
        Me.lblTotalOfUpperSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalOfUpperSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalOfUpperSection.Location = New System.Drawing.Point(7, 276)
        Me.lblTotalOfUpperSection.Name = "lblTotalOfUpperSection"
        Me.lblTotalOfUpperSection.Size = New System.Drawing.Size(89, 51)
        Me.lblTotalOfUpperSection.TabIndex = 8
        Me.lblTotalOfUpperSection.Text = "Total of Upper Section"
        Me.lblTotalOfUpperSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBonus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBonus.Location = New System.Drawing.Point(7, 227)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(86, 41)
        Me.lblBonus.TabIndex = 8
        Me.lblBonus.Text = "Bonus "
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalScore
        '
        Me.lblTotalScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalScore.Location = New System.Drawing.Point(6, 195)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(86, 23)
        Me.lblTotalScore.TabIndex = 7
        Me.lblTotalScore.Text = "Total Score"
        Me.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAces
        '
        Me.btnAces.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAces.ForeColor = System.Drawing.Color.Black
        Me.btnAces.Location = New System.Drawing.Point(6, 22)
        Me.btnAces.Name = "btnAces"
        Me.btnAces.Size = New System.Drawing.Size(86, 23)
        Me.btnAces.TabIndex = 0
        Me.btnAces.Text = "Aces"
        Me.tipAces.SetToolTip(Me.btnAces, "Count and add only ones")
        Me.btnAces.UseVisualStyleBackColor = False
        '
        'btnSixes
        '
        Me.btnSixes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSixes.ForeColor = System.Drawing.Color.Black
        Me.btnSixes.Location = New System.Drawing.Point(6, 167)
        Me.btnSixes.Name = "btnSixes"
        Me.btnSixes.Size = New System.Drawing.Size(86, 23)
        Me.btnSixes.TabIndex = 5
        Me.btnSixes.Text = "Sixes"
        Me.tipSixes.SetToolTip(Me.btnSixes, "Count and add only Sixes")
        Me.btnSixes.UseVisualStyleBackColor = False
        '
        'btnTwos
        '
        Me.btnTwos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTwos.ForeColor = System.Drawing.Color.Black
        Me.btnTwos.Location = New System.Drawing.Point(6, 51)
        Me.btnTwos.Name = "btnTwos"
        Me.btnTwos.Size = New System.Drawing.Size(86, 23)
        Me.btnTwos.TabIndex = 1
        Me.btnTwos.Text = "Twos"
        Me.tipTwos.SetToolTip(Me.btnTwos, "Count and add only twos")
        Me.btnTwos.UseVisualStyleBackColor = False
        '
        'btnFives
        '
        Me.btnFives.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFives.ForeColor = System.Drawing.Color.Black
        Me.btnFives.Location = New System.Drawing.Point(6, 138)
        Me.btnFives.Name = "btnFives"
        Me.btnFives.Size = New System.Drawing.Size(86, 23)
        Me.btnFives.TabIndex = 4
        Me.btnFives.Text = "Fives"
        Me.tipFives.SetToolTip(Me.btnFives, "Count and add only Fives")
        Me.btnFives.UseVisualStyleBackColor = False
        '
        'btnThrees
        '
        Me.btnThrees.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThrees.ForeColor = System.Drawing.Color.Black
        Me.btnThrees.Location = New System.Drawing.Point(6, 80)
        Me.btnThrees.Name = "btnThrees"
        Me.btnThrees.Size = New System.Drawing.Size(86, 23)
        Me.btnThrees.TabIndex = 2
        Me.btnThrees.Text = "Threes"
        Me.tipThrees.SetToolTip(Me.btnThrees, "Count and add only Threes")
        Me.btnThrees.UseVisualStyleBackColor = False
        '
        'btnFours
        '
        Me.btnFours.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFours.ForeColor = System.Drawing.Color.Black
        Me.btnFours.Location = New System.Drawing.Point(6, 109)
        Me.btnFours.Name = "btnFours"
        Me.btnFours.Size = New System.Drawing.Size(86, 23)
        Me.btnFours.TabIndex = 3
        Me.btnFours.Text = "Fours"
        Me.tipFours.SetToolTip(Me.btnFours, "Count and add only Fours")
        Me.btnFours.UseVisualStyleBackColor = False
        '
        'btnRoll
        '
        Me.btnRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRoll.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(828, 45)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(96, 72)
        Me.btnRoll.TabIndex = 74
        Me.btnRoll.Text = "Roll"
        Me.tipRoll.SetToolTip(Me.btnRoll, "Click to roll the dice")
        Me.btnRoll.UseVisualStyleBackColor = False
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHighScore, Me.mnuHelp})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(1273, 33)
        Me.mnuMainMenu.TabIndex = 90
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewGame, Me.mnuSaveGame, Me.mnuLoadGame, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "&File"
        '
        'mnuNewGame
        '
        Me.mnuNewGame.Name = "mnuNewGame"
        Me.mnuNewGame.Size = New System.Drawing.Size(186, 30)
        Me.mnuNewGame.Text = "&New Game"
        Me.mnuNewGame.ToolTipText = "Click to start new game"
        '
        'mnuSaveGame
        '
        Me.mnuSaveGame.Name = "mnuSaveGame"
        Me.mnuSaveGame.Size = New System.Drawing.Size(186, 30)
        Me.mnuSaveGame.Text = "&Save Game"
        Me.mnuSaveGame.ToolTipText = "Click to save game"
        '
        'mnuLoadGame
        '
        Me.mnuLoadGame.Name = "mnuLoadGame"
        Me.mnuLoadGame.Size = New System.Drawing.Size(186, 30)
        Me.mnuLoadGame.Text = "&Load Game"
        Me.mnuLoadGame.ToolTipText = "Click to continue game"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(186, 30)
        Me.mnuExit.Text = "E&xit"
        Me.mnuExit.ToolTipText = "Click to exit"
        '
        'mnuHighScore
        '
        Me.mnuHighScore.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHighScoreView})
        Me.mnuHighScore.Name = "mnuHighScore"
        Me.mnuHighScore.Size = New System.Drawing.Size(119, 29)
        Me.mnuHighScore.Text = "Hi&gh Scores"
        '
        'mnuHighScoreView
        '
        Me.mnuHighScoreView.Name = "mnuHighScoreView"
        Me.mnuHighScoreView.Size = New System.Drawing.Size(191, 30)
        Me.mnuHighScoreView.Text = "High Scores"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHowToPlay, Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(61, 29)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHowToPlay
        '
        Me.mnuHowToPlay.Name = "mnuHowToPlay"
        Me.mnuHowToPlay.Size = New System.Drawing.Size(192, 30)
        Me.mnuHowToPlay.Text = "How to &Play"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(192, 30)
        Me.mnuAbout.Text = "&About"
        '
        'tipAces
        '
        Me.tipAces.AutoPopDelay = 5000
        Me.tipAces.InitialDelay = 100
        Me.tipAces.ReshowDelay = 100
        '
        'tipTwos
        '
        Me.tipTwos.AutoPopDelay = 5000
        Me.tipTwos.InitialDelay = 100
        Me.tipTwos.ReshowDelay = 100
        '
        'tipThrees
        '
        Me.tipThrees.AutoPopDelay = 5000
        Me.tipThrees.InitialDelay = 100
        Me.tipThrees.ReshowDelay = 100
        '
        'tipFours
        '
        Me.tipFours.AutoPopDelay = 5000
        Me.tipFours.InitialDelay = 100
        Me.tipFours.ReshowDelay = 100
        '
        'tipFives
        '
        Me.tipFives.AutoPopDelay = 5000
        Me.tipFives.InitialDelay = 100
        Me.tipFives.ReshowDelay = 100
        '
        'tipSixes
        '
        Me.tipSixes.AutoPopDelay = 5000
        Me.tipSixes.InitialDelay = 100
        Me.tipSixes.ReshowDelay = 100
        '
        'tip3OfAKind
        '
        Me.tip3OfAKind.AutoPopDelay = 5000
        Me.tip3OfAKind.InitialDelay = 100
        Me.tip3OfAKind.ReshowDelay = 100
        '
        'tip4OfAKind
        '
        Me.tip4OfAKind.AutoPopDelay = 5000
        Me.tip4OfAKind.InitialDelay = 100
        Me.tip4OfAKind.ReshowDelay = 100
        '
        'tipFullHouse
        '
        Me.tipFullHouse.AutoPopDelay = 5000
        Me.tipFullHouse.InitialDelay = 100
        Me.tipFullHouse.ReshowDelay = 100
        '
        'tipSmallStraight
        '
        Me.tipSmallStraight.AutoPopDelay = 5000
        Me.tipSmallStraight.InitialDelay = 100
        Me.tipSmallStraight.ReshowDelay = 100
        '
        'tipLargeStraight
        '
        Me.tipLargeStraight.AutoPopDelay = 5000
        Me.tipLargeStraight.InitialDelay = 100
        Me.tipLargeStraight.ReshowDelay = 100
        '
        'tipYahtzee
        '
        Me.tipYahtzee.AutoPopDelay = 5000
        Me.tipYahtzee.InitialDelay = 100
        Me.tipYahtzee.ReshowDelay = 100
        '
        'tipChance
        '
        Me.tipChance.AutoPopDelay = 5000
        Me.tipChance.InitialDelay = 100
        Me.tipChance.ReshowDelay = 100
        '
        'tipYahtzeeBonus
        '
        Me.tipYahtzeeBonus.AutoPopDelay = 5000
        Me.tipYahtzeeBonus.InitialDelay = 100
        Me.tipYahtzeeBonus.ReshowDelay = 100
        '
        'lblRoundsLeft
        '
        Me.lblRoundsLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRoundsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundsLeft.Location = New System.Drawing.Point(977, 77)
        Me.lblRoundsLeft.Name = "lblRoundsLeft"
        Me.lblRoundsLeft.Size = New System.Drawing.Size(100, 67)
        Me.lblRoundsLeft.TabIndex = 91
        Me.lblRoundsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRounds
        '
        Me.lblRounds.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRounds.Location = New System.Drawing.Point(977, 50)
        Me.lblRounds.Name = "lblRounds"
        Me.lblRounds.Size = New System.Drawing.Size(100, 27)
        Me.lblRounds.TabIndex = 92
        Me.lblRounds.Text = "Rounds Left:"
        Me.lblRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stsCurrentPlayer
        '
        Me.stsCurrentPlayer.AutoSize = False
        Me.stsCurrentPlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsCurrentPlayer.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.stsCurrentPlayer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCurrentPlayer})
        Me.stsCurrentPlayer.Location = New System.Drawing.Point(0, 600)
        Me.stsCurrentPlayer.Name = "stsCurrentPlayer"
        Me.stsCurrentPlayer.Size = New System.Drawing.Size(1273, 22)
        Me.stsCurrentPlayer.TabIndex = 93
        Me.stsCurrentPlayer.Text = "StatusStrip1"
        '
        'lblCurrentPlayer
        '
        Me.lblCurrentPlayer.BackColor = System.Drawing.Color.White
        Me.lblCurrentPlayer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPlayer.Name = "lblCurrentPlayer"
        Me.lblCurrentPlayer.Size = New System.Drawing.Size(0, 17)
        '
        'grpHowTo
        '
        Me.grpHowTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpHowTo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpHowTo.Controls.Add(Me.btnClose)
        Me.grpHowTo.Controls.Add(Me.lblRules)
        Me.grpHowTo.Font = New System.Drawing.Font("Segoe Script", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHowTo.Location = New System.Drawing.Point(341, 44)
        Me.grpHowTo.Name = "grpHowTo"
        Me.grpHowTo.Size = New System.Drawing.Size(522, 526)
        Me.grpHowTo.TabIndex = 94
        Me.grpHowTo.TabStop = False
        Me.grpHowTo.Text = "HOW TO PLAY"
        Me.grpHowTo.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(237, 498)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblRules
        '
        Me.lblRules.BackColor = System.Drawing.Color.White
        Me.lblRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.Location = New System.Drawing.Point(6, 23)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(509, 472)
        Me.lblRules.TabIndex = 0
        '
        'Yahtzee
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1273, 622)
        Me.Controls.Add(Me.grpHowTo)
        Me.Controls.Add(Me.stsCurrentPlayer)
        Me.Controls.Add(Me.lblRounds)
        Me.Controls.Add(Me.lblRoundsLeft)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.grpLowerSection)
        Me.Controls.Add(Me.grpUpperSection)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "Yahtzee"
        Me.Text = "Yahtzee"
        Me.grpLowerSection.ResumeLayout(False)
        Me.grpUpperSection.ResumeLayout(False)
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.stsCurrentPlayer.ResumeLayout(False)
        Me.stsCurrentPlayer.PerformLayout()
        Me.grpHowTo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLowerSection As GroupBox
    Friend WithEvents lblTotalOfLowerSection As Label
    Friend WithEvents btnYahtzeeBonus As Button
    Friend WithEvents btnChance As Button
    Friend WithEvents btnYahtzee As Button
    Friend WithEvents btnLargeStraight As Button
    Friend WithEvents btn3OfAKind As Button
    Friend WithEvents btn4OfAKind As Button
    Friend WithEvents btnFullHouse As Button
    Friend WithEvents btnSmallStraight As Button
    Friend WithEvents grpUpperSection As GroupBox
    Friend WithEvents lblTotalOfUpperSection As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents btnAces As Button
    Friend WithEvents btnSixes As Button
    Friend WithEvents btnTwos As Button
    Friend WithEvents btnFives As Button
    Friend WithEvents btnThrees As Button
    Friend WithEvents btnFours As Button
    Friend WithEvents btnRoll As Button
    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNewGame As ToolStripMenuItem
    Friend WithEvents mnuSaveGame As ToolStripMenuItem
    Friend WithEvents mnuLoadGame As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHighScore As ToolStripMenuItem
    Friend WithEvents mnuHighScoreView As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHowToPlay As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents tipAces As ToolTip
    Friend WithEvents tipTwos As ToolTip
    Friend WithEvents tipThrees As ToolTip
    Friend WithEvents tipFours As ToolTip
    Friend WithEvents tipFives As ToolTip
    Friend WithEvents tipSixes As ToolTip
    Friend WithEvents tip3OfAKind As ToolTip
    Friend WithEvents tip4OfAKind As ToolTip
    Friend WithEvents tipFullHouse As ToolTip
    Friend WithEvents tipSmallStraight As ToolTip
    Friend WithEvents tipLargeStraight As ToolTip
    Friend WithEvents tipYahtzee As ToolTip
    Friend WithEvents tipChance As ToolTip
    Friend WithEvents tipYahtzeeBonus As ToolTip
    Friend WithEvents tipRoll As ToolTip
    Friend WithEvents lblRoundsLeft As Label
    Friend WithEvents lblRounds As Label
    Friend WithEvents stsCurrentPlayer As StatusStrip
    Friend WithEvents lblCurrentPlayer As ToolStripStatusLabel
    Friend WithEvents grpHowTo As GroupBox
    Friend WithEvents lblRules As Label
    Friend WithEvents btnClose As Button
End Class

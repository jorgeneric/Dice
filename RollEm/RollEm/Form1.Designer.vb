<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollEm
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
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picSix = New System.Windows.Forms.PictureBox()
        Me.picFive = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.picSecondDie = New System.Windows.Forms.PictureBox()
        Me.picFirstDie = New System.Windows.Forms.PictureBox()
        Me.txtOneRoll = New System.Windows.Forms.TextBox()
        Me.txtOneWins = New System.Windows.Forms.TextBox()
        Me.txtTwoRoll = New System.Windows.Forms.TextBox()
        Me.txtTwoWins = New System.Windows.Forms.TextBox()
        Me.txtPlayerOnePairs = New System.Windows.Forms.TextBox()
        Me.txtPlayerTwoPairs = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblPlayerOne = New System.Windows.Forms.Label()
        Me.lblPlayerOneWins = New System.Windows.Forms.Label()
        Me.lblPlayerTwoRoll = New System.Windows.Forms.Label()
        Me.lblPlayerTwoWins = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picSix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSecondDie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFirstDie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.BackColor = System.Drawing.Color.Orange
        Me.btnRoll.Location = New System.Drawing.Point(552, 83)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll 'Em"
        Me.btnRoll.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Violet
        Me.btnExit.Location = New System.Drawing.Point(553, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picSix
        '
        Me.picSix.Image = Global.RollEm.My.Resources.Resources.Dot6
        Me.picSix.Location = New System.Drawing.Point(595, 423)
        Me.picSix.Name = "picSix"
        Me.picSix.Size = New System.Drawing.Size(78, 95)
        Me.picSix.TabIndex = 9
        Me.picSix.TabStop = False
        '
        'picFive
        '
        Me.picFive.Image = Global.RollEm.My.Resources.Resources.Dot5
        Me.picFive.Location = New System.Drawing.Point(497, 423)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(78, 95)
        Me.picFive.TabIndex = 8
        Me.picFive.TabStop = False
        '
        'picFour
        '
        Me.picFour.Image = Global.RollEm.My.Resources.Resources.Dot4
        Me.picFour.Location = New System.Drawing.Point(399, 423)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(78, 95)
        Me.picFour.TabIndex = 7
        Me.picFour.TabStop = False
        '
        'picThree
        '
        Me.picThree.Image = Global.RollEm.My.Resources.Resources.Dot3
        Me.picThree.Location = New System.Drawing.Point(301, 423)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(78, 95)
        Me.picThree.TabIndex = 6
        Me.picThree.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Image = Global.RollEm.My.Resources.Resources.Dot2
        Me.picTwo.Location = New System.Drawing.Point(203, 423)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(78, 95)
        Me.picTwo.TabIndex = 5
        Me.picTwo.TabStop = False
        '
        'picOne
        '
        Me.picOne.Image = Global.RollEm.My.Resources.Resources.Dot1
        Me.picOne.Location = New System.Drawing.Point(105, 423)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(78, 95)
        Me.picOne.TabIndex = 4
        Me.picOne.TabStop = False
        '
        'picSecondDie
        '
        Me.picSecondDie.Location = New System.Drawing.Point(301, 122)
        Me.picSecondDie.Name = "picSecondDie"
        Me.picSecondDie.Size = New System.Drawing.Size(120, 126)
        Me.picSecondDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSecondDie.TabIndex = 1
        Me.picSecondDie.TabStop = False
        '
        'picFirstDie
        '
        Me.picFirstDie.Location = New System.Drawing.Point(105, 122)
        Me.picFirstDie.Name = "picFirstDie"
        Me.picFirstDie.Size = New System.Drawing.Size(120, 126)
        Me.picFirstDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFirstDie.TabIndex = 10
        Me.picFirstDie.TabStop = False
        '
        'txtOneRoll
        '
        Me.txtOneRoll.Location = New System.Drawing.Point(132, 293)
        Me.txtOneRoll.Name = "txtOneRoll"
        Me.txtOneRoll.ReadOnly = True
        Me.txtOneRoll.Size = New System.Drawing.Size(51, 20)
        Me.txtOneRoll.TabIndex = 11
        Me.txtOneRoll.TabStop = False
        '
        'txtOneWins
        '
        Me.txtOneWins.Location = New System.Drawing.Point(132, 355)
        Me.txtOneWins.Name = "txtOneWins"
        Me.txtOneWins.ReadOnly = True
        Me.txtOneWins.Size = New System.Drawing.Size(51, 20)
        Me.txtOneWins.TabIndex = 12
        Me.txtOneWins.TabStop = False
        '
        'txtTwoRoll
        '
        Me.txtTwoRoll.Location = New System.Drawing.Point(338, 293)
        Me.txtTwoRoll.Name = "txtTwoRoll"
        Me.txtTwoRoll.ReadOnly = True
        Me.txtTwoRoll.Size = New System.Drawing.Size(51, 20)
        Me.txtTwoRoll.TabIndex = 13
        Me.txtTwoRoll.TabStop = False
        '
        'txtTwoWins
        '
        Me.txtTwoWins.Location = New System.Drawing.Point(338, 355)
        Me.txtTwoWins.Name = "txtTwoWins"
        Me.txtTwoWins.ReadOnly = True
        Me.txtTwoWins.Size = New System.Drawing.Size(51, 20)
        Me.txtTwoWins.TabIndex = 14
        Me.txtTwoWins.TabStop = False
        '
        'txtPlayerOnePairs
        '
        Me.txtPlayerOnePairs.Location = New System.Drawing.Point(578, 228)
        Me.txtPlayerOnePairs.Name = "txtPlayerOnePairs"
        Me.txtPlayerOnePairs.ReadOnly = True
        Me.txtPlayerOnePairs.Size = New System.Drawing.Size(28, 20)
        Me.txtPlayerOnePairs.TabIndex = 15
        Me.txtPlayerOnePairs.TabStop = False
        '
        'txtPlayerTwoPairs
        '
        Me.txtPlayerTwoPairs.Location = New System.Drawing.Point(578, 293)
        Me.txtPlayerTwoPairs.Name = "txtPlayerTwoPairs"
        Me.txtPlayerTwoPairs.ReadOnly = True
        Me.txtPlayerTwoPairs.Size = New System.Drawing.Size(28, 20)
        Me.txtPlayerTwoPairs.TabIndex = 16
        Me.txtPlayerTwoPairs.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Sitka Text", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(97, 59)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 47)
        Me.lblMessage.TabIndex = 17
        Me.lblMessage.Visible = False
        '
        'lblPlayerOne
        '
        Me.lblPlayerOne.AutoSize = True
        Me.lblPlayerOne.Location = New System.Drawing.Point(116, 266)
        Me.lblPlayerOne.Name = "lblPlayerOne"
        Me.lblPlayerOne.Size = New System.Drawing.Size(80, 13)
        Me.lblPlayerOne.TabIndex = 19
        Me.lblPlayerOne.Text = "Player One Roll"
        '
        'lblPlayerOneWins
        '
        Me.lblPlayerOneWins.AutoSize = True
        Me.lblPlayerOneWins.Location = New System.Drawing.Point(116, 329)
        Me.lblPlayerOneWins.Name = "lblPlayerOneWins"
        Me.lblPlayerOneWins.Size = New System.Drawing.Size(86, 13)
        Me.lblPlayerOneWins.TabIndex = 20
        Me.lblPlayerOneWins.Text = "Player One Wins"
        '
        'lblPlayerTwoRoll
        '
        Me.lblPlayerTwoRoll.AutoSize = True
        Me.lblPlayerTwoRoll.Location = New System.Drawing.Point(323, 266)
        Me.lblPlayerTwoRoll.Name = "lblPlayerTwoRoll"
        Me.lblPlayerTwoRoll.Size = New System.Drawing.Size(81, 13)
        Me.lblPlayerTwoRoll.TabIndex = 21
        Me.lblPlayerTwoRoll.Text = "Player Two Roll"
        '
        'lblPlayerTwoWins
        '
        Me.lblPlayerTwoWins.AutoSize = True
        Me.lblPlayerTwoWins.Location = New System.Drawing.Point(323, 329)
        Me.lblPlayerTwoWins.Name = "lblPlayerTwoWins"
        Me.lblPlayerTwoWins.Size = New System.Drawing.Size(87, 13)
        Me.lblPlayerTwoWins.TabIndex = 22
        Me.lblPlayerTwoWins.Text = "Player Two Wins"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(549, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Player One Pairs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(549, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Player Two Pairs"
        '
        'RollEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(902, 619)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPlayerTwoWins)
        Me.Controls.Add(Me.lblPlayerTwoRoll)
        Me.Controls.Add(Me.lblPlayerOneWins)
        Me.Controls.Add(Me.lblPlayerOne)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtPlayerTwoPairs)
        Me.Controls.Add(Me.txtPlayerOnePairs)
        Me.Controls.Add(Me.txtTwoWins)
        Me.Controls.Add(Me.txtTwoRoll)
        Me.Controls.Add(Me.txtOneWins)
        Me.Controls.Add(Me.txtOneRoll)
        Me.Controls.Add(Me.picFirstDie)
        Me.Controls.Add(Me.picSix)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picSecondDie)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "RollEm"
        Me.Text = "Form1"
        CType(Me.picSix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSecondDie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFirstDie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picSecondDie As PictureBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picOne As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picThree As PictureBox
    Friend WithEvents picFour As PictureBox
    Friend WithEvents picFive As PictureBox
    Friend WithEvents picSix As PictureBox
    Friend WithEvents picFirstDie As PictureBox
    Friend WithEvents txtOneRoll As TextBox
    Friend WithEvents txtOneWins As TextBox
    Friend WithEvents txtTwoRoll As TextBox
    Friend WithEvents txtTwoWins As TextBox
    Friend WithEvents txtPlayerOnePairs As TextBox
    Friend WithEvents txtPlayerTwoPairs As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblPlayerOne As Label
    Friend WithEvents lblPlayerOneWins As Label
    Friend WithEvents lblPlayerTwoRoll As Label
    Friend WithEvents lblPlayerTwoWins As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

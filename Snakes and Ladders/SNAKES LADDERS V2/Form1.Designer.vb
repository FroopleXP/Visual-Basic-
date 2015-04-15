<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rndNumDisp = New System.Windows.Forms.Label()
        Me.plrOneMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.plrTwoMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.plrOneMoveUp = New System.Windows.Forms.Timer(Me.components)
        Me.plrTwoMoveUp = New System.Windows.Forms.Timer(Me.components)
        Me.plrOneMoveTimerRev = New System.Windows.Forms.Timer(Me.components)
        Me.plrOneCounter = New System.Windows.Forms.PictureBox()
        Me.plrTwoCounter = New System.Windows.Forms.PictureBox()
        Me.DICE = New System.Windows.Forms.Panel()
        Me.plrTurnDisp = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.plrOneCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plrTwoCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rndNumDisp
        '
        Me.rndNumDisp.AutoSize = True
        Me.rndNumDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rndNumDisp.Location = New System.Drawing.Point(190, 466)
        Me.rndNumDisp.Name = "rndNumDisp"
        Me.rndNumDisp.Size = New System.Drawing.Size(0, 39)
        Me.rndNumDisp.TabIndex = 2
        '
        'plrOneMoveTimer
        '
        Me.plrOneMoveTimer.Interval = 450
        '
        'plrTwoMoveTimer
        '
        Me.plrTwoMoveTimer.Interval = 450
        '
        'plrOneMoveUp
        '
        Me.plrOneMoveUp.Interval = 500
        '
        'plrTwoMoveUp
        '
        Me.plrTwoMoveUp.Interval = 500
        '
        'plrOneMoveTimerRev
        '
        Me.plrOneMoveTimerRev.Interval = 450
        '
        'plrOneCounter
        '
        Me.plrOneCounter.BackColor = System.Drawing.Color.Transparent
        Me.plrOneCounter.BackgroundImage = CType(resources.GetObject("plrOneCounter.BackgroundImage"), System.Drawing.Image)
        Me.plrOneCounter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.plrOneCounter.Location = New System.Drawing.Point(44, 393)
        Me.plrOneCounter.Name = "plrOneCounter"
        Me.plrOneCounter.Size = New System.Drawing.Size(39, 39)
        Me.plrOneCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plrOneCounter.TabIndex = 4
        Me.plrOneCounter.TabStop = False
        '
        'plrTwoCounter
        '
        Me.plrTwoCounter.BackColor = System.Drawing.Color.Transparent
        Me.plrTwoCounter.BackgroundImage = CType(resources.GetObject("plrTwoCounter.BackgroundImage"), System.Drawing.Image)
        Me.plrTwoCounter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.plrTwoCounter.Location = New System.Drawing.Point(44, 393)
        Me.plrTwoCounter.Name = "plrTwoCounter"
        Me.plrTwoCounter.Size = New System.Drawing.Size(39, 39)
        Me.plrTwoCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plrTwoCounter.TabIndex = 7
        Me.plrTwoCounter.TabStop = False
        '
        'DICE
        '
        Me.DICE.BackColor = System.Drawing.Color.Transparent
        Me.DICE.BackgroundImage = Global.SNAKES_LADDERS_V2.My.Resources.Resources._0
        Me.DICE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DICE.Location = New System.Drawing.Point(563, 203)
        Me.DICE.Name = "DICE"
        Me.DICE.Size = New System.Drawing.Size(75, 75)
        Me.DICE.TabIndex = 8
        '
        'plrTurnDisp
        '
        Me.plrTurnDisp.BackColor = System.Drawing.Color.Transparent
        Me.plrTurnDisp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.plrTurnDisp.Location = New System.Drawing.Point(470, 357)
        Me.plrTurnDisp.Name = "plrTurnDisp"
        Me.plrTurnDisp.Size = New System.Drawing.Size(250, 75)
        Me.plrTurnDisp.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(40, 449)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Game Programmed by - Connor Edwards"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(744, 474)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plrTurnDisp)
        Me.Controls.Add(Me.DICE)
        Me.Controls.Add(Me.plrOneCounter)
        Me.Controls.Add(Me.rndNumDisp)
        Me.Controls.Add(Me.plrTwoCounter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 513)
        Me.MinimumSize = New System.Drawing.Size(760, 513)
        Me.Name = "Form1"
        Me.Text = "Snakes and Ladders - Connor Edwards"
        CType(Me.plrOneCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plrTwoCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rndNumDisp As System.Windows.Forms.Label
    Friend WithEvents plrOneCounter As System.Windows.Forms.PictureBox
    Friend WithEvents plrOneMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents plrTwoMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents plrOneMoveUp As System.Windows.Forms.Timer
    Friend WithEvents plrTwoMoveUp As System.Windows.Forms.Timer
    Friend WithEvents plrOneMoveTimerRev As System.Windows.Forms.Timer
    Friend WithEvents plrTwoCounter As System.Windows.Forms.PictureBox
    Friend WithEvents DICE As System.Windows.Forms.Panel
    Friend WithEvents plrTurnDisp As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

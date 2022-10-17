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
<<<<<<< HEAD
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Wall2 = New System.Windows.Forms.PictureBox()
        Me.Wall11 = New System.Windows.Forms.PictureBox()
        Me.Wall = New System.Windows.Forms.PictureBox()
        Me.Wall8 = New System.Windows.Forms.PictureBox()
        Me.Wall5 = New System.Windows.Forms.PictureBox()
        Me.Wall7 = New System.Windows.Forms.PictureBox()
        Me.Wall3 = New System.Windows.Forms.PictureBox()
        Me.Wall4 = New System.Windows.Forms.PictureBox()
        Me.BulletPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Target = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Wall10 = New System.Windows.Forms.PictureBox()
        Me.Wall6 = New System.Windows.Forms.PictureBox()
        Me.Wall13 = New System.Windows.Forms.PictureBox()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'Wall2
        '
        Me.Wall2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall2.Location = New System.Drawing.Point(855, 12)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(22, 201)
        Me.Wall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall2.TabIndex = 20
        Me.Wall2.TabStop = False
        '
        'Wall11
        '
        Me.Wall11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall11.Location = New System.Drawing.Point(196, 275)
        Me.Wall11.Name = "Wall11"
        Me.Wall11.Size = New System.Drawing.Size(28, 74)
        Me.Wall11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall11.TabIndex = 19
        Me.Wall11.TabStop = False
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall.Location = New System.Drawing.Point(630, 207)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(526, 19)
        Me.Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall.TabIndex = 18
        Me.Wall.TabStop = False
        '
        'Wall8
        '
        Me.Wall8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall8.Location = New System.Drawing.Point(209, 275)
        Me.Wall8.Name = "Wall8"
        Me.Wall8.Size = New System.Drawing.Size(253, 28)
        Me.Wall8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall8.TabIndex = 17
        Me.Wall8.TabStop = False
        '
        'Wall5
        '
        Me.Wall5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall5.Location = New System.Drawing.Point(456, 337)
        Me.Wall5.Name = "Wall5"
        Me.Wall5.Size = New System.Drawing.Size(447, 24)
        Me.Wall5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall5.TabIndex = 16
        Me.Wall5.TabStop = False
        '
        'Wall7
        '
        Me.Wall7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall7.Location = New System.Drawing.Point(456, 145)
        Me.Wall7.Name = "Wall7"
        Me.Wall7.Size = New System.Drawing.Size(23, 234)
        Me.Wall7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall7.TabIndex = 14
        Me.Wall7.TabStop = False
        '
        'Wall3
        '
        Me.Wall3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall3.Location = New System.Drawing.Point(343, 12)
        Me.Wall3.Name = "Wall3"
        Me.Wall3.Size = New System.Drawing.Size(986, 10)
        Me.Wall3.TabIndex = 13
        Me.Wall3.TabStop = False
        '
        'Wall4
        '
        Me.Wall4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall4.Location = New System.Drawing.Point(1308, 12)
        Me.Wall4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Wall4.Name = "Wall4"
        Me.Wall4.Size = New System.Drawing.Size(21, 471)
        Me.Wall4.TabIndex = 9
        Me.Wall4.TabStop = False
        '
        'BulletPictureBox2
        '
        Me.BulletPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BulletPictureBox2.Image = Global.MyGame.My.Resources.Resources.sheepCapture
        Me.BulletPictureBox2.Location = New System.Drawing.Point(1148, 34)
        Me.BulletPictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BulletPictureBox2.Name = "BulletPictureBox2"
        Me.BulletPictureBox2.Size = New System.Drawing.Size(154, 82)
        Me.BulletPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPictureBox2.TabIndex = 8
        Me.BulletPictureBox2.TabStop = False
        Me.BulletPictureBox2.Visible = False
        '
        'Target
        '
        Me.Target.Image = Global.MyGame.My.Resources.Resources.bedCapture
        Me.Target.Location = New System.Drawing.Point(909, 34)
        Me.Target.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(167, 78)
        Me.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Target.TabIndex = 1
        Me.Target.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.MyGame.My.Resources.Resources.pixelCapture
        Me.Player.Location = New System.Drawing.Point(68, 34)
        Me.Player.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(53, 77)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Wall10
        '
        Me.Wall10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall10.Location = New System.Drawing.Point(12, 136)
        Me.Wall10.Name = "Wall10"
        Me.Wall10.Size = New System.Drawing.Size(21, 361)
        Me.Wall10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall10.TabIndex = 21
        Me.Wall10.TabStop = False
        '
        'Wall6
        '
        Me.Wall6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall6.Location = New System.Drawing.Point(12, 475)
        Me.Wall6.Name = "Wall6"
        Me.Wall6.Size = New System.Drawing.Size(1317, 22)
        Me.Wall6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall6.TabIndex = 22
        Me.Wall6.TabStop = False
        '
        'Wall13
        '
        Me.Wall13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall13.Location = New System.Drawing.Point(1106, 315)
        Me.Wall13.Name = "Wall13"
        Me.Wall13.Size = New System.Drawing.Size(44, 78)
        Me.Wall13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall13.TabIndex = 24
        Me.Wall13.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 494)
        Me.Controls.Add(Me.Wall13)
        Me.Controls.Add(Me.Wall6)
        Me.Controls.Add(Me.Wall10)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Wall11)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.Wall8)
        Me.Controls.Add(Me.Wall5)
        Me.Controls.Add(Me.Wall7)
        Me.Controls.Add(Me.Wall3)
        Me.Controls.Add(Me.Wall4)
        Me.Controls.Add(Me.BulletPictureBox2)
        Me.Controls.Add(Me.Target)
        Me.Controls.Add(Me.Player)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "MyGame"
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

=======
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BulletPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Target = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'BulletPictureBox2
        '
        Me.BulletPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BulletPictureBox2.Image = Global.MyGame.My.Resources.Resources.donut_circle
        Me.BulletPictureBox2.Location = New System.Drawing.Point(737, 137)
        Me.BulletPictureBox2.Name = "BulletPictureBox2"
        Me.BulletPictureBox2.Size = New System.Drawing.Size(38, 34)
        Me.BulletPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPictureBox2.TabIndex = 8
        Me.BulletPictureBox2.TabStop = False
        Me.BulletPictureBox2.Visible = False
        '
        'WallPictureBox3
        '
        Me.WallPictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox3.Location = New System.Drawing.Point(714, 113)
        Me.WallPictureBox3.Name = "WallPictureBox3"
        Me.WallPictureBox3.Size = New System.Drawing.Size(17, 184)
        Me.WallPictureBox3.TabIndex = 6
        Me.WallPictureBox3.TabStop = False
        '
        'WallPictureBox4
        '
        Me.WallPictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox4.Location = New System.Drawing.Point(164, 311)
        Me.WallPictureBox4.Name = "WallPictureBox4"
        Me.WallPictureBox4.Size = New System.Drawing.Size(388, 25)
        Me.WallPictureBox4.TabIndex = 5
        Me.WallPictureBox4.TabStop = False
        '
        'Target
        '
        Me.Target.Image = Global.MyGame.My.Resources.Resources.froyo_circle
        Me.Target.Location = New System.Drawing.Point(454, 86)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(43, 50)
        Me.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Target.TabIndex = 1
        Me.Target.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.MyGame.My.Resources.Resources.donut_circle
        Me.Player.Location = New System.Drawing.Point(137, 86)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(121, 72)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BulletPictureBox2)
        Me.Controls.Add(Me.WallPictureBox3)
        Me.Controls.Add(Me.WallPictureBox4)
        Me.Controls.Add(Me.Target)
        Me.Controls.Add(Me.Player)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "MyGame"
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

>>>>>>> main
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Player As PictureBox
    Friend WithEvents Target As PictureBox
    Friend WithEvents BulletPictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Wall4 As PictureBox
    Friend WithEvents Wall2 As PictureBox
    Friend WithEvents Wall11 As PictureBox
    Friend WithEvents Wall As PictureBox
    Friend WithEvents Wall8 As PictureBox
    Friend WithEvents Wall5 As PictureBox
    Friend WithEvents Wall7 As PictureBox
    Friend WithEvents Wall3 As PictureBox
    Friend WithEvents Wall10 As PictureBox
    Friend WithEvents Wall6 As PictureBox
    Friend WithEvents Wall13 As PictureBox
End Class

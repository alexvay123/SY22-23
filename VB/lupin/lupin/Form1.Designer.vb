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
        Me.badguy1 = New System.Windows.Forms.PictureBox()
        Me.player = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.badguy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'badguy1
        '
        Me.badguy1.Image = Global.lupin.My.Resources.Resources.car_photo_307201
        Me.badguy1.Location = New System.Drawing.Point(63, 50)
        Me.badguy1.Name = "badguy1"
        Me.badguy1.Size = New System.Drawing.Size(182, 91)
        Me.badguy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.badguy1.TabIndex = 1
        Me.badguy1.TabStop = False
        Me.badguy1.Visible = False
        '
        'player
        '
        Me.player.Image = Global.lupin.My.Resources.Resources._1984_1986_Subaru_Leone_Deluxe_sedan__2010_12_28_
        Me.player.Location = New System.Drawing.Point(318, 221)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(153, 72)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(724, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "4loop"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.badguy1)
        Me.Controls.Add(Me.player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.badguy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents badguy1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class

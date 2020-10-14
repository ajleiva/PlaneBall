<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.tmrPlay = New System.Windows.Forms.Timer(Me.components)
        Me.Ball7 = New System.Windows.Forms.PictureBox()
        Me.Ball6 = New System.Windows.Forms.PictureBox()
        Me.Ball5 = New System.Windows.Forms.PictureBox()
        Me.Ball4 = New System.Windows.Forms.PictureBox()
        Me.Ball3 = New System.Windows.Forms.PictureBox()
        Me.Ball2 = New System.Windows.Forms.PictureBox()
        Me.Plane = New System.Windows.Forms.PictureBox()
        Me.Ball1 = New System.Windows.Forms.PictureBox()
        Me.Ball8 = New System.Windows.Forms.PictureBox()
        CType(Me.Ball7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPlay
        '
        '
        'Ball7
        '
        Me.Ball7.Image = CType(resources.GetObject("Ball7.Image"), System.Drawing.Image)
        Me.Ball7.Location = New System.Drawing.Point(345, 564)
        Me.Ball7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball7.Name = "Ball7"
        Me.Ball7.Size = New System.Drawing.Size(73, 66)
        Me.Ball7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball7.TabIndex = 15
        Me.Ball7.TabStop = False
        '
        'Ball6
        '
        Me.Ball6.Image = CType(resources.GetObject("Ball6.Image"), System.Drawing.Image)
        Me.Ball6.Location = New System.Drawing.Point(1031, 267)
        Me.Ball6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball6.Name = "Ball6"
        Me.Ball6.Size = New System.Drawing.Size(73, 66)
        Me.Ball6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball6.TabIndex = 14
        Me.Ball6.TabStop = False
        '
        'Ball5
        '
        Me.Ball5.Image = CType(resources.GetObject("Ball5.Image"), System.Drawing.Image)
        Me.Ball5.Location = New System.Drawing.Point(3, 90)
        Me.Ball5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball5.Name = "Ball5"
        Me.Ball5.Size = New System.Drawing.Size(73, 66)
        Me.Ball5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball5.TabIndex = 13
        Me.Ball5.TabStop = False
        '
        'Ball4
        '
        Me.Ball4.Image = CType(resources.GetObject("Ball4.Image"), System.Drawing.Image)
        Me.Ball4.Location = New System.Drawing.Point(3, 463)
        Me.Ball4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball4.Name = "Ball4"
        Me.Ball4.Size = New System.Drawing.Size(73, 66)
        Me.Ball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball4.TabIndex = 12
        Me.Ball4.TabStop = False
        '
        'Ball3
        '
        Me.Ball3.Image = CType(resources.GetObject("Ball3.Image"), System.Drawing.Image)
        Me.Ball3.Location = New System.Drawing.Point(929, 4)
        Me.Ball3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball3.Name = "Ball3"
        Me.Ball3.Size = New System.Drawing.Size(73, 66)
        Me.Ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball3.TabIndex = 11
        Me.Ball3.TabStop = False
        '
        'Ball2
        '
        Me.Ball2.Image = CType(resources.GetObject("Ball2.Image"), System.Drawing.Image)
        Me.Ball2.Location = New System.Drawing.Point(180, 4)
        Me.Ball2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball2.Name = "Ball2"
        Me.Ball2.Size = New System.Drawing.Size(73, 66)
        Me.Ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball2.TabIndex = 10
        Me.Ball2.TabStop = False
        '
        'Plane
        '
        Me.Plane.Image = CType(resources.GetObject("Plane.Image"), System.Drawing.Image)
        Me.Plane.Location = New System.Drawing.Point(551, 288)
        Me.Plane.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Plane.Name = "Plane"
        Me.Plane.Size = New System.Drawing.Size(73, 66)
        Me.Plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Plane.TabIndex = 8
        Me.Plane.TabStop = False
        '
        'Ball1
        '
        Me.Ball1.Image = CType(resources.GetObject("Ball1.Image"), System.Drawing.Image)
        Me.Ball1.Location = New System.Drawing.Point(551, 4)
        Me.Ball1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball1.Name = "Ball1"
        Me.Ball1.Size = New System.Drawing.Size(73, 66)
        Me.Ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball1.TabIndex = 9
        Me.Ball1.TabStop = False
        '
        'Ball8
        '
        Me.Ball8.Image = CType(resources.GetObject("Ball8.Image"), System.Drawing.Image)
        Me.Ball8.Location = New System.Drawing.Point(748, 564)
        Me.Ball8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ball8.Name = "Ball8"
        Me.Ball8.Size = New System.Drawing.Size(73, 66)
        Me.Ball8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ball8.TabIndex = 16
        Me.Ball8.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1120, 654)
        Me.Controls.Add(Me.Ball8)
        Me.Controls.Add(Me.Ball7)
        Me.Controls.Add(Me.Ball6)
        Me.Controls.Add(Me.Ball5)
        Me.Controls.Add(Me.Ball4)
        Me.Controls.Add(Me.Ball3)
        Me.Controls.Add(Me.Ball2)
        Me.Controls.Add(Me.Plane)
        Me.Controls.Add(Me.Ball1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Game"
        CType(Me.Ball7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrPlay As System.Windows.Forms.Timer
    Friend WithEvents Ball7 As System.Windows.Forms.PictureBox
    Friend WithEvents Ball6 As System.Windows.Forms.PictureBox
    Friend WithEvents Ball5 As System.Windows.Forms.PictureBox
    Friend WithEvents Ball4 As System.Windows.Forms.PictureBox
    Friend WithEvents Ball3 As System.Windows.Forms.PictureBox
    Friend WithEvents Ball2 As System.Windows.Forms.PictureBox
    Friend WithEvents Plane As System.Windows.Forms.PictureBox
    Friend WithEvents Ball1 As System.Windows.Forms.PictureBox
    Friend WithEvents Ball8 As System.Windows.Forms.PictureBox
End Class

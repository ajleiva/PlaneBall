<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(282, 380)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.Color.White
        Me.txtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(124, 51)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(390, 287)
        Me.txtInfo.TabIndex = 1
        Me.txtInfo.Text = resources.GetString("txtInfo.Text")
        Me.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDone
        '
        Me.btnDone.Enabled = False
        Me.btnDone.Location = New System.Drawing.Point(363, 380)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnAgain
        '
        Me.btnAgain.Enabled = False
        Me.btnAgain.Location = New System.Drawing.Point(201, 380)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(75, 23)
        Me.btnAgain.TabIndex = 3
        Me.btnAgain.Text = "Play Again!"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(638, 446)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnAgain As System.Windows.Forms.Button

End Class

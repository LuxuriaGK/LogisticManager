<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotification
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tmr_faded = New System.Windows.Forms.Timer(Me.components)
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.少女前线后勤提醒.My.Resources.Resources.ro635
        Me.PictureBox2.Location = New System.Drawing.Point(-15, -15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(175, 158)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'tmr_faded
        '
        '
        'picExit
        '
        Me.picExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExit.Image = Global.少女前线后勤提醒.My.Resources.Resources._exit
        Me.picExit.Location = New System.Drawing.Point(324, 5)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(25, 25)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExit.TabIndex = 7
        Me.picExit.TabStop = False
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.25!)
        Me.lblContent.ForeColor = System.Drawing.Color.White
        Me.lblContent.Location = New System.Drawing.Point(132, 70)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(192, 20)
        Me.lblContent.TabIndex = 8
        Me.lblContent.Text = "后勤队伍#0已从 [0-0] 归来～"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(131, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 25)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "指挥官，我们回来啦～"
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(356, 122)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picExit)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotification"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tmr_faded As Timer
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblContent As Label
    Friend WithEvents lblTitle As Label
End Class

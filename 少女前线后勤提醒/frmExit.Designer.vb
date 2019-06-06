<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExit
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
        Me.radMinimize = New System.Windows.Forms.RadioButton()
        Me.radExit = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.chkDontAskAgain = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radMinimize
        '
        Me.radMinimize.AutoSize = True
        Me.radMinimize.Font = New System.Drawing.Font("Microsoft YaHei", 9.25!)
        Me.radMinimize.Location = New System.Drawing.Point(54, 51)
        Me.radMinimize.Name = "radMinimize"
        Me.radMinimize.Size = New System.Drawing.Size(105, 23)
        Me.radMinimize.TabIndex = 0
        Me.radMinimize.Text = "最小化至托盘"
        Me.radMinimize.UseVisualStyleBackColor = True
        '
        'radExit
        '
        Me.radExit.AutoSize = True
        Me.radExit.Checked = True
        Me.radExit.Font = New System.Drawing.Font("Microsoft YaHei", 9.25!)
        Me.radExit.Location = New System.Drawing.Point(54, 81)
        Me.radExit.Name = "radExit"
        Me.radExit.Size = New System.Drawing.Size(79, 23)
        Me.radExit.TabIndex = 0
        Me.radExit.TabStop = True
        Me.radExit.Text = "直接退出"
        Me.radExit.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft YaHei", 9.25!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(140, 105)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(61, 35)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "确定"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'chkDontAskAgain
        '
        Me.chkDontAskAgain.AutoSize = True
        Me.chkDontAskAgain.Font = New System.Drawing.Font("Microsoft YaHei", 9.25!)
        Me.chkDontAskAgain.Location = New System.Drawing.Point(12, 116)
        Me.chkDontAskAgain.Name = "chkDontAskAgain"
        Me.chkDontAskAgain.Size = New System.Drawing.Size(80, 23)
        Me.chkDontAskAgain.TabIndex = 2
        Me.chkDontAskAgain.Text = "不再提醒"
        Me.chkDontAskAgain.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.picExit)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 32)
        Me.Panel1.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 13.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "关闭提示"
        '
        'picExit
        '
        Me.picExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExit.Image = Global.少女前线后勤提醒.My.Resources.Resources.cross_red
        Me.picExit.Location = New System.Drawing.Point(177, 5)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(24, 24)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExit.TabIndex = 0
        Me.picExit.TabStop = False
        '
        'frmExit
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkDontAskAgain)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.radExit)
        Me.Controls.Add(Me.radMinimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radMinimize As RadioButton
    Friend WithEvents radExit As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents chkDontAskAgain As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents picExit As PictureBox
End Class

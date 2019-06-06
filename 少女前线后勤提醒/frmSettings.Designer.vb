<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMinute = New System.Windows.Forms.ComboBox()
        Me.cboSecond = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radExit = New System.Windows.Forms.RadioButton()
        Me.radMinimize = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radTopMost = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radPopup = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.radNoRes = New System.Windows.Forms.RadioButton()
        Me.radAutoRes = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboNotification = New System.Windows.Forms.ComboBox()
        Me.chkCloseNotify = New System.Windows.Forms.CheckBox()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.radNoAsk = New System.Windows.Forms.RadioButton()
        Me.radAsk = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(311, 325)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 33)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "提前通知："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMinute
        '
        Me.cboMinute.DropDownHeight = 160
        Me.cboMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinute.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.IntegralHeight = False
        Me.cboMinute.Location = New System.Drawing.Point(137, 45)
        Me.cboMinute.MaxDropDownItems = 3
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMinute.Size = New System.Drawing.Size(53, 28)
        Me.cboMinute.TabIndex = 7
        '
        'cboSecond
        '
        Me.cboSecond.DropDownHeight = 160
        Me.cboSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecond.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.cboSecond.FormattingEnabled = True
        Me.cboSecond.IntegralHeight = False
        Me.cboSecond.Location = New System.Drawing.Point(236, 45)
        Me.cboSecond.MaxDropDownItems = 3
        Me.cboSecond.Name = "cboSecond"
        Me.cboSecond.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSecond.Size = New System.Drawing.Size(53, 28)
        Me.cboSecond.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(195, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "分钟"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(295, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "秒"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(15, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "通知方式？"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radExit
        '
        Me.radExit.AutoSize = True
        Me.radExit.Checked = True
        Me.radExit.Location = New System.Drawing.Point(12, 2)
        Me.radExit.Name = "radExit"
        Me.radExit.Size = New System.Drawing.Size(83, 24)
        Me.radExit.TabIndex = 10
        Me.radExit.TabStop = True
        Me.radExit.Text = "直接退出"
        Me.radExit.UseVisualStyleBackColor = True
        '
        'radMinimize
        '
        Me.radMinimize.AutoSize = True
        Me.radMinimize.Location = New System.Drawing.Point(111, 2)
        Me.radMinimize.Name = "radMinimize"
        Me.radMinimize.Size = New System.Drawing.Size(111, 24)
        Me.radMinimize.TabIndex = 10
        Me.radMinimize.TabStop = True
        Me.radMinimize.Text = "最小化至托盘"
        Me.radMinimize.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "关闭界面："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radTopMost
        '
        Me.radTopMost.AutoSize = True
        Me.radTopMost.Location = New System.Drawing.Point(12, 3)
        Me.radTopMost.Name = "radTopMost"
        Me.radTopMost.Size = New System.Drawing.Size(97, 24)
        Me.radTopMost.TabIndex = 10
        Me.radTopMost.Text = "弹出并置顶"
        Me.radTopMost.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radMinimize)
        Me.Panel1.Controls.Add(Me.radExit)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Panel1.Location = New System.Drawing.Point(126, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 29)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.radPopup)
        Me.Panel2.Controls.Add(Me.radTopMost)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Panel2.Location = New System.Drawing.Point(126, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 29)
        Me.Panel2.TabIndex = 13
        '
        'radPopup
        '
        Me.radPopup.AutoSize = True
        Me.radPopup.Checked = True
        Me.radPopup.Location = New System.Drawing.Point(111, 3)
        Me.radPopup.Name = "radPopup"
        Me.radPopup.Size = New System.Drawing.Size(135, 24)
        Me.radPopup.TabIndex = 10
        Me.radPopup.TabStop = True
        Me.radPopup.Text = "仅推送通知(推荐)"
        Me.radPopup.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(13, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "自动重新计时："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radNoRes)
        Me.Panel3.Controls.Add(Me.radAutoRes)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Panel3.Location = New System.Drawing.Point(126, 205)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 29)
        Me.Panel3.TabIndex = 13
        '
        'radNoRes
        '
        Me.radNoRes.AutoSize = True
        Me.radNoRes.Checked = True
        Me.radNoRes.Location = New System.Drawing.Point(111, 3)
        Me.radNoRes.Name = "radNoRes"
        Me.radNoRes.Size = New System.Drawing.Size(41, 24)
        Me.radNoRes.TabIndex = 10
        Me.radNoRes.TabStop = True
        Me.radNoRes.Text = "否"
        Me.radNoRes.UseVisualStyleBackColor = True
        '
        'radAutoRes
        '
        Me.radAutoRes.AutoSize = True
        Me.radAutoRes.Location = New System.Drawing.Point(12, 3)
        Me.radAutoRes.Name = "radAutoRes"
        Me.radAutoRes.Size = New System.Drawing.Size(41, 24)
        Me.radAutoRes.TabIndex = 10
        Me.radAutoRes.Text = "是"
        Me.radAutoRes.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.picExit)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(398, 32)
        Me.Panel4.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 13.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "设置"
        '
        'picExit
        '
        Me.picExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExit.Image = Global.少女前线后勤提醒.My.Resources.Resources.cross_red
        Me.picExit.Location = New System.Drawing.Point(366, 5)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(24, 24)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExit.TabIndex = 0
        Me.picExit.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label8.Location = New System.Drawing.Point(13, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "更换人形图片："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnChange.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.Location = New System.Drawing.Point(137, 244)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 32)
        Me.btnChange.TabIndex = 48
        Me.btnChange.Text = "导入"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'lblFileName
        '
        Me.lblFileName.Font = New System.Drawing.Font("Microsoft YaHei", 9.25!)
        Me.lblFileName.Location = New System.Drawing.Point(216, 240)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(159, 39)
        Me.lblFileName.TabIndex = 49
        Me.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label9.Location = New System.Drawing.Point(13, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "人形语音提醒："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboNotification
        '
        Me.cboNotification.DropDownHeight = 160
        Me.cboNotification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNotification.DropDownWidth = 180
        Me.cboNotification.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.cboNotification.FormattingEnabled = True
        Me.cboNotification.IntegralHeight = False
        Me.cboNotification.Location = New System.Drawing.Point(137, 287)
        Me.cboNotification.MaxDropDownItems = 3
        Me.cboNotification.Name = "cboNotification"
        Me.cboNotification.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboNotification.Size = New System.Drawing.Size(109, 28)
        Me.cboNotification.TabIndex = 7
        '
        'chkCloseNotify
        '
        Me.chkCloseNotify.AutoSize = True
        Me.chkCloseNotify.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.chkCloseNotify.Location = New System.Drawing.Point(282, 289)
        Me.chkCloseNotify.Name = "chkCloseNotify"
        Me.chkCloseNotify.Size = New System.Drawing.Size(84, 24)
        Me.chkCloseNotify.TabIndex = 50
        Me.chkCloseNotify.Text = "关闭提醒"
        Me.chkCloseNotify.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlay.Image = Global.少女前线后勤提醒.My.Resources.Resources.play
        Me.btnPlay.Location = New System.Drawing.Point(251, 288)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(25, 25)
        Me.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPlay.TabIndex = 51
        Me.btnPlay.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Label10.Location = New System.Drawing.Point(13, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "关闭提示："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.radNoAsk)
        Me.Panel5.Controls.Add(Me.radAsk)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft YaHei", 10.25!)
        Me.Panel5.Location = New System.Drawing.Point(126, 165)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(249, 29)
        Me.Panel5.TabIndex = 13
        '
        'radNoAsk
        '
        Me.radNoAsk.AutoSize = True
        Me.radNoAsk.Location = New System.Drawing.Point(111, 3)
        Me.radNoAsk.Name = "radNoAsk"
        Me.radNoAsk.Size = New System.Drawing.Size(69, 24)
        Me.radNoAsk.TabIndex = 10
        Me.radNoAsk.Text = "不提示"
        Me.radNoAsk.UseVisualStyleBackColor = True
        '
        'radAsk
        '
        Me.radAsk.AutoSize = True
        Me.radAsk.Checked = True
        Me.radAsk.Location = New System.Drawing.Point(12, 3)
        Me.radAsk.Name = "radAsk"
        Me.radAsk.Size = New System.Drawing.Size(83, 24)
        Me.radAsk.TabIndex = 10
        Me.radAsk.TabStop = True
        Me.radAsk.Text = "每次询问"
        Me.radAsk.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(397, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboSecond)
        Me.Controls.Add(Me.cboNotification)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkCloseNotify)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMinute As ComboBox
    Friend WithEvents cboSecond As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radExit As RadioButton
    Friend WithEvents radMinimize As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents radTopMost As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents radNoRes As RadioButton
    Friend WithEvents radAutoRes As RadioButton
    Friend WithEvents radPopup As RadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents picExit As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents lblFileName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboNotification As ComboBox
    Friend WithEvents chkCloseNotify As CheckBox
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents radNoAsk As RadioButton
    Friend WithEvents radAsk As RadioButton
End Class

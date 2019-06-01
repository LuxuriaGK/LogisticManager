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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(299, 178)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 32)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(37, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "提前通知："
        '
        'cboMinute
        '
        Me.cboMinute.DropDownHeight = 160
        Me.cboMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.IntegralHeight = False
        Me.cboMinute.Location = New System.Drawing.Point(134, 30)
        Me.cboMinute.MaxDropDownItems = 3
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMinute.Size = New System.Drawing.Size(53, 23)
        Me.cboMinute.TabIndex = 7
        '
        'cboSecond
        '
        Me.cboSecond.DropDownHeight = 160
        Me.cboSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecond.FormattingEnabled = True
        Me.cboSecond.IntegralHeight = False
        Me.cboSecond.Location = New System.Drawing.Point(237, 30)
        Me.cboSecond.MaxDropDownItems = 3
        Me.cboSecond.Name = "cboSecond"
        Me.cboSecond.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSecond.Size = New System.Drawing.Size(53, 23)
        Me.cboSecond.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(194, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "分钟"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(298, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "秒"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "通知方式?"
        '
        'radExit
        '
        Me.radExit.AutoSize = True
        Me.radExit.Checked = True
        Me.radExit.Location = New System.Drawing.Point(3, 4)
        Me.radExit.Name = "radExit"
        Me.radExit.Size = New System.Drawing.Size(82, 21)
        Me.radExit.TabIndex = 10
        Me.radExit.TabStop = True
        Me.radExit.Text = "直接退出"
        Me.radExit.UseVisualStyleBackColor = True
        '
        'radMinimize
        '
        Me.radMinimize.AutoSize = True
        Me.radMinimize.Location = New System.Drawing.Point(103, 4)
        Me.radMinimize.Name = "radMinimize"
        Me.radMinimize.Size = New System.Drawing.Size(110, 21)
        Me.radMinimize.TabIndex = 10
        Me.radMinimize.TabStop = True
        Me.radMinimize.Text = "最小化至托盘"
        Me.radMinimize.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "关闭界面："
        '
        'radTopMost
        '
        Me.radTopMost.AutoSize = True
        Me.radTopMost.Location = New System.Drawing.Point(3, 5)
        Me.radTopMost.Name = "radTopMost"
        Me.radTopMost.Size = New System.Drawing.Size(96, 21)
        Me.radTopMost.TabIndex = 10
        Me.radTopMost.Text = "弹出并置顶"
        Me.radTopMost.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radMinimize)
        Me.Panel1.Controls.Add(Me.radExit)
        Me.Panel1.Location = New System.Drawing.Point(134, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 29)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.radPopup)
        Me.Panel2.Controls.Add(Me.radTopMost)
        Me.Panel2.Location = New System.Drawing.Point(134, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 29)
        Me.Panel2.TabIndex = 13
        '
        'radPopup
        '
        Me.radPopup.AutoSize = True
        Me.radPopup.Location = New System.Drawing.Point(103, 5)
        Me.radPopup.Name = "radPopup"
        Me.radPopup.Size = New System.Drawing.Size(132, 21)
        Me.radPopup.TabIndex = 10
        Me.radPopup.TabStop = True
        Me.radPopup.Text = "仅推送通知(推荐)"
        Me.radPopup.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "自动重新计时："
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radNoRes)
        Me.Panel3.Controls.Add(Me.radAutoRes)
        Me.Panel3.Location = New System.Drawing.Point(134, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(235, 29)
        Me.Panel3.TabIndex = 13
        '
        'radNoRes
        '
        Me.radNoRes.AutoSize = True
        Me.radNoRes.Location = New System.Drawing.Point(103, 5)
        Me.radNoRes.Name = "radNoRes"
        Me.radNoRes.Size = New System.Drawing.Size(40, 21)
        Me.radNoRes.TabIndex = 10
        Me.radNoRes.TabStop = True
        Me.radNoRes.Text = "否"
        Me.radNoRes.UseVisualStyleBackColor = True
        '
        'radAutoRes
        '
        Me.radAutoRes.AutoSize = True
        Me.radAutoRes.Location = New System.Drawing.Point(3, 5)
        Me.radAutoRes.Name = "radAutoRes"
        Me.radAutoRes.Size = New System.Drawing.Size(40, 21)
        Me.radAutoRes.TabIndex = 10
        Me.radAutoRes.Text = "是"
        Me.radAutoRes.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 222)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboSecond)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
End Class

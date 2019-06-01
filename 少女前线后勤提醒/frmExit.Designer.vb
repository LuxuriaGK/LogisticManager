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
        Me.SuspendLayout()
        '
        'radMinimize
        '
        Me.radMinimize.AutoSize = True
        Me.radMinimize.Location = New System.Drawing.Point(40, 20)
        Me.radMinimize.Name = "radMinimize"
        Me.radMinimize.Size = New System.Drawing.Size(97, 17)
        Me.radMinimize.TabIndex = 0
        Me.radMinimize.Text = "最小化至托盘"
        Me.radMinimize.UseVisualStyleBackColor = True
        '
        'radExit
        '
        Me.radExit.AutoSize = True
        Me.radExit.Checked = True
        Me.radExit.Location = New System.Drawing.Point(40, 50)
        Me.radExit.Name = "radExit"
        Me.radExit.Size = New System.Drawing.Size(73, 17)
        Me.radExit.TabIndex = 0
        Me.radExit.TabStop = True
        Me.radExit.Text = "直接退出"
        Me.radExit.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(108, 79)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(55, 26)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "确定"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'chkDontAskAgain
        '
        Me.chkDontAskAgain.AutoSize = True
        Me.chkDontAskAgain.Location = New System.Drawing.Point(12, 85)
        Me.chkDontAskAgain.Name = "chkDontAskAgain"
        Me.chkDontAskAgain.Size = New System.Drawing.Size(74, 17)
        Me.chkDontAskAgain.TabIndex = 2
        Me.chkDontAskAgain.Text = "不再提醒"
        Me.chkDontAskAgain.UseVisualStyleBackColor = True
        '
        'frmExit
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 115)
        Me.Controls.Add(Me.chkDontAskAgain)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.radExit)
        Me.Controls.Add(Me.radMinimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "关闭提示"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radMinimize As RadioButton
    Friend WithEvents radExit As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents chkDontAskAgain As CheckBox
End Class

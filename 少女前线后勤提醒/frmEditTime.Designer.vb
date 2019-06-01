<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditTime
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
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMinute = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSecond = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(145, 75)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(59, 30)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "确定"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'cboHour
        '
        Me.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.IntegralHeight = False
        Me.cboHour.Location = New System.Drawing.Point(26, 35)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(41, 21)
        Me.cboHour.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "："
        '
        'cboMinute
        '
        Me.cboMinute.DropDownHeight = 160
        Me.cboMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.IntegralHeight = False
        Me.cboMinute.Location = New System.Drawing.Point(92, 35)
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.Size = New System.Drawing.Size(41, 21)
        Me.cboMinute.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "："
        '
        'cboSecond
        '
        Me.cboSecond.DropDownHeight = 160
        Me.cboSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecond.FormattingEnabled = True
        Me.cboSecond.IntegralHeight = False
        Me.cboSecond.Location = New System.Drawing.Point(158, 35)
        Me.cboSecond.Name = "cboSecond"
        Me.cboSecond.Size = New System.Drawing.Size(41, 21)
        Me.cboSecond.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "时"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(92, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "分"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(158, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "秒"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEditTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 117)
        Me.Controls.Add(Me.cboSecond)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboHour)
        Me.Controls.Add(Me.btnConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "编辑时间"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirm As Button
    Friend WithEvents cboHour As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMinute As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSecond As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

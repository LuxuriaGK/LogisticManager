<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnounce
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMinute = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(87, 45)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "分钟"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "提前"
        '
        'cboMinute
        '
        Me.cboMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.Location = New System.Drawing.Point(52, 14)
        Me.cboMinute.MaxDropDownItems = 3
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMinute.Size = New System.Drawing.Size(48, 21)
        Me.cboMinute.TabIndex = 3
        '
        'frmAnnounce
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(160, 82)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnnounce"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "提前通知"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMinute As ComboBox
End Class

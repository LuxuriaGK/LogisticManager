<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFavoriteName
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtFavName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(60, 43)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(44, 25)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(108, 43)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtFavName
        '
        Me.txtFavName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtFavName.Location = New System.Drawing.Point(60, 15)
        Me.txtFavName.MaxLength = 5
        Me.txtFavName.Name = "txtFavName"
        Me.txtFavName.Size = New System.Drawing.Size(96, 20)
        Me.txtFavName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "重命名："
        '
        'frmFavoriteName
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(168, 80)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFavName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFavoriteName"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "自定义名字"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtFavName As TextBox
    Friend WithEvents Label1 As Label
End Class

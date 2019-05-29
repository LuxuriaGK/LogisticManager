<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLeave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "既然点进来了那就留下来看一下吧～" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(468, 101)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "大家好这里是九重奏，虽然这个软件制作花费时间不长但是还是希望各位能多多支持！" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如果可以的话就推荐给好友或者帮忙宣传，让更多人知道有这么一款辅助器可以解决他们的在" &
    "少前里所遇到困难。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "你的支持是我最大的动力！只要我还在玩少前就会一直更新下去！" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(16, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bug反馈可以直接在NGA帖子下留言或者发邮件至（luxuriagk@gmail.com）"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(16, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(314, 51)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Github链接：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NGA 帖子：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "开发者：九重奏（LuxuriaGK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Underline)
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(12, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "前言："
        '
        'btnLeave
        '
        Me.btnLeave.Location = New System.Drawing.Point(416, 235)
        Me.btnLeave.Name = "btnLeave"
        Me.btnLeave.Size = New System.Drawing.Size(64, 26)
        Me.btnLeave.TabIndex = 5
        Me.btnLeave.Text = "离开"
        Me.btnLeave.UseVisualStyleBackColor = True
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 273)
        Me.Controls.Add(Me.btnLeave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "关于"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLeave As Button
End Class

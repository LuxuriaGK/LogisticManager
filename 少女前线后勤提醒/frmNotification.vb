Public Class frmNotification
    Public counter As Integer = 0
    Dim content As String
    Public open As Boolean = False

    Private Sub frmNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Right - Me.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height
        Me.Location = New Point(x, y)

        My.Computer.Audio.Play(My.Resources.G11_sound, AudioPlayMode.Background)
        open = True
        tmr_faded.Interval = 1
        tmr_faded.Start()
        TopMost = False
    End Sub

    Private Sub frmNotification_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        open = False
    End Sub

    Private Sub tmr_faded_Tick(sender As Object, e As EventArgs) Handles tmr_faded.Tick
        counter = counter + 1
        If counter >= 400 Then
            Opacity = Opacity - 0.01
        End If

        If counter = 500 Then
            tmr_faded.Stop()
            Close()
        End If
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub frmNotification_MouseClick() Handles MyBase.MouseClick, PictureBox2.Click, lblTitle.Click, lblContent.Click
        frmMain.Show()
        frmMain.Opacity = 1
        If frmMain.WindowState = FormWindowState.Minimized Then
            frmMain.WindowState = FormWindowState.Normal
        End If
        frmMain.Visible = True
        Me.Icon = My.Resources.icon
        Me.Close()
    End Sub

    Public Sub sendNotification(index As Integer, mission As String)
        lblTitle.Text = "指挥官，我们回来啦～"
        lblContent.Text = "后勤队伍#" & index & "已从 [" & mission & "] 归来！"
    End Sub

    Public Sub sendOthersNotification(title As String, content As String)
        lblTitle.Text = title
        lblContent.Text = content
    End Sub

End Class

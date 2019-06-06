Public Class frmNotification
    Public counter As Integer = 0
    Dim content As String

    Private Sub frmNotification_Load() Handles MyBase.Load
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Right - Me.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height
        Me.Location = New Point(x, y)

        tmr_faded.Interval = 1
        tmr_faded.Start()
        TopMost = True
        Threading.Thread.Sleep(10)
        TopMost = False
    End Sub

    Private Sub tmr_faded_Tick(sender As Object, e As EventArgs) Handles tmr_faded.Tick
        counter = counter + 1
        If counter >= 300 Then
            Opacity = Opacity - 0.01
        End If

        If counter = 400 Then
            tmr_faded.Stop()
            Close()
        End If
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub frmNotification_MouseClick() Handles MyBase.MouseClick, PictureBox2.Click, lblTitle.Click, lblContent.Click
        If frmMain.WindowState = FormWindowState.Minimized Then
            frmMain.WindowState = FormWindowState.Normal
        ElseIf frmmain.hidden = True Then
            frmMain.NotifyIcon5_DoubleClick(Nothing, Nothing)
        ElseIf frmMain.WindowState = FormWindowState.Normal Then
            frmMain.TopMost = True
            Threading.Thread.Sleep(10)
            frmMain.TopMost = False
        End If
    End Sub

    Public Sub sendNotification(index As Integer, mission As String)
        If index = 5 Then
            lblTitle.Text = "指挥官，倒计时已结束～"
            lblContent.Text = "自定义的倒数计时已结束。"
        Else
            lblTitle.Text = "指挥官，我们回来啦～"
            lblContent.Text = "后勤队伍#" & index & "已从 [" & mission & "] 归来！"
        End If

        notifySound()
    End Sub

    Public Sub sendOthersNotification(title As String, content As String)
        lblTitle.Text = title
        lblContent.Text = content
    End Sub

    Private Sub notifySound()
        If My.Settings.NotificationSound <> -1 Then
            Dim sound() As IO.Stream = {My.Resources.AK12, My.Resources.AN94, My.Resources.AR15, My.Resources.ART556,
            My.Resources.CMS, My.Resources.G11, My.Resources.G41, My.Resources.HK416,
            My.Resources.M4A1, My.Resources.M4A1_MOD, My.Resources.MK23, My.Resources.SAT8,
            My.Resources.Sopmod, My.Resources.Ump45, My.Resources.Ump9, My.Resources.Vector,
            My.Resources.WA2000, My.Resources.XM8, My.Resources._79式, My.Resources.卡尔卡诺1891,
            My.Resources.卡尔卡诺1891_儿童节, My.Resources.卡尔卡诺1983, My.Resources.卡尔卡诺1938_儿童节, My.Resources.李_恩菲尔德_儿童节,
            My.Resources.索米, My.Resources.蝎式}

            My.Computer.Audio.Play(sound(My.Settings.NotificationSound), AudioPlayMode.Background)
        End If
    End Sub
End Class

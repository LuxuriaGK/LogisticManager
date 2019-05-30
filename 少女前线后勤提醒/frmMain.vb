Imports System.Collections.Specialized

Public Class frmMain
    ' ToDo List
    ' UI improve
    ' about page
    ' add sound (v2 maybe)
    ' remember to set 0-1 time to 00:50
    ' skill training time announce
    ' memory control
    ' check all logistic
    ' result check
    ' select one or two type of resources

    Public arr_Logistic(60) As LogisticSupport
    Dim TargetDT1 As DateTime
    Dim TargetDT2 As DateTime
    Dim TargetDT3 As DateTime
    Dim TargetDT4 As DateTime
    Dim announceBefore As Integer

    Dim notified1 As Boolean
    Dim notified2 As Boolean
    Dim notified3 As Boolean
    Dim notified4 As Boolean

    Dim manpowerClicked As Boolean = False
    Dim ammoClicked As Boolean = False
    Dim rationClicked As Boolean = False
    Dim partClicked As Boolean = False

    Dim dollClicked As Boolean = False
    Dim equipmentClicked As Boolean = False
    Dim productionClicked As Boolean = False
    Dim restoreClicked As Boolean = False
    Dim tokenClicked As Boolean = False

    Dim favClicked1 As Boolean = False
    Dim favClicked2 As Boolean = False
    Dim favClicked3 As Boolean = False
    Dim favClicked4 As Boolean = False

    Public favName As String

    Dim currentTime1 As String
    Dim currentTime2 As String
    Dim currentTime3 As String
    Dim currentTime4 As String

    ' Declare data
    Private Sub InsertLogistic()
        arr_Logistic = {
        New LogisticSupport("0-1", 0, 50, 0, 145, 145, 0， False， False， True， True， False),
        New LogisticSupport("0-2", 3, 0， 550， 0， 0， 350， True， False， False， False， False),
        New LogisticSupport("0-3", 12, 0, 900, 900, 900, 250, False, True, False, True, False),
        New LogisticSupport("0-4", 24, 0, 0, 1200, 800, 750, False, False, False, False, True),
        New LogisticSupport("1-1", 0, 15, 10, 30, 15, 0, False, False, False, False, False),
        New LogisticSupport("1-2", 0, 30, 0, 40, 60, 0, False, False, False, False, False),
        New LogisticSupport("1-3", 1, 0, 30, 0, 30, 10, False, False, False, True, False),
        New LogisticSupport("1-4", 2, 0, 160, 160, 0, 0, True, False, False, False, False),
        New LogisticSupport("2-1", 0, 40, 100, 0, 0, 30, False, False, False, False, False),
        New LogisticSupport("2-2", 1, 30, 60, 200, 80, 0, False, False, False, True, False),
        New LogisticSupport("2-3", 4, 0, 10, 10, 10, 230, False, False, True, True, False),
        New LogisticSupport("2-4", 6, 0, 0, 250, 600, 60, True, False, False, False, False),
        New LogisticSupport("3-1", 0, 20, 50, 0, 75, 0, False, False, False, False, False),
        New LogisticSupport("3-2", 0, 45, 0, 120, 70, 30, False, False, False, False, False),
        New LogisticSupport("3-3", 1, 30, 0, 300, 0, 0, False, False, True, True, False),
        New LogisticSupport("3-4", 5, 0, 0, 0, 300, 300, True, True, False, False, False),
        New LogisticSupport("4-1", 1, 0, 0, 185, 185, 0, False, True, False, False, False),
        New LogisticSupport("4-2", 2, 0, 0, 0, 0, 210, False, False, True, False, False),
        New LogisticSupport("4-3", 6, 0, 800, 550, 0, 0, True, False, False, True, False),
        New LogisticSupport("4-4", 8, 0, 400, 400, 400, 150, False, False, True, False, False),
        New LogisticSupport("5-1", 0, 30, 0, 0, 100, 45, False, False, False, False, False),
        New LogisticSupport("5-2", 2, 30, 0, 600, 300, 0, False, False, False, True, False),
        New LogisticSupport("5-3", 4, 0, 800, 400, 400, 0, False, True, False, False, False),
        New LogisticSupport("5-4", 7, 0, 100, 0, 0, 700, True, False, False, False, False),
        New LogisticSupport("6-1", 2, 0, 300, 300, 0, 100, False, False, False, False, False),
        New LogisticSupport("6-2", 3, 0, 0, 200, 550, 100, False, False, True, True, False),
        New LogisticSupport("6-3", 5, 0, 0, 0, 200, 500, False, True, False, False, False),
        New LogisticSupport("6-4", 12, 0, 800, 800, 800, 0, False, False, False, False, True),
        New LogisticSupport("7-1", 2, 30, 650, 0, 650, 0, False, False, False, False, False),
        New LogisticSupport("7-2", 4, 0, 0, 650, 0, 300, True, False, False, True, False),
        New LogisticSupport("7-3", 5, 30, 900, 600, 600, 0, False, True, False, False, False),
        New LogisticSupport("7-4", 8, 0, 250, 250, 250, 600, False, False, True, False, False),
        New LogisticSupport("8-1", 1, 0, 150, 150, 150, 0, False, True, False, False, False),
        New LogisticSupport("8-2", 3, 0, 0, 0, 0, 450, False, False, False, True, False),
        New LogisticSupport("8-3", 6, 0, 400, 800, 800, 0, False, False, True, True, False),
        New LogisticSupport("8-4", 9, 0, 1500, 400, 400, 100, True, False, False, False, False),
        New LogisticSupport("9-1", 0, 30, 0, 0, 100, 50, False, False, False, False, False),
        New LogisticSupport("9-2", 1, 30, 180, 0, 180, 100, False, False, True, False, False),
        New LogisticSupport("9-3", 4, 30, 750, 750, 0, 0, True, False, False, False, False),
        New LogisticSupport("9-4", 7, 0, 500, 900, 900, 0, False, True, False, False, False),
        New LogisticSupport("10-1", 0, 40, 140, 200, 0, 0, False, False, False, False, False),
        New LogisticSupport("10-2", 1, 40, 0, 240, 180, 0, True, False, True, False, False),
        New LogisticSupport("10-3", 5, 20, 0, 480, 480, 300, False, False, True, True, False),
        New LogisticSupport("10-4", 10, 0, 660, 660, 660, 330, False, True, False, False, False),
        New LogisticSupport("11-1", 4, 0, 350, 1050, 0, 0, True, True, False, False, False),
        New LogisticSupport("11-2", 4, 0, 360, 540, 540, 0, True, False, False, False, False),
        New LogisticSupport("11-3", 8, 0, 0, 750, 1500, 250, False, False, False, True, False),
        New LogisticSupport("11-4", 10, 0, 0, 1650, 0, 900, False, False, True, False, False)}
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InsertLogistic()
        init()
        RetrieveSettings(0)
        getAnnounceSettings()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgResult As DialogResult = frmExit.ShowDialog

        If dlgResult = DialogResult.No Then
            saveLogistic(0)

            NotifyIcon1.Icon = Nothing
            NotifyIcon1.Visible = False
            NotifyIcon1.Dispose()
            NotifyIcon2.Icon = Nothing
            NotifyIcon2.Visible = False
            NotifyIcon2.Dispose()
            NotifyIcon3.Icon = Nothing
            NotifyIcon3.Visible = False
            NotifyIcon3.Dispose()
            NotifyIcon4.Icon = Nothing
            NotifyIcon4.Visible = False
            NotifyIcon4.Dispose()
            NotifyIcon5.Icon = Nothing
            NotifyIcon5.Visible = False
            NotifyIcon5.Dispose()
        ElseIf dlgResult = DialogResult.Yes Then
            WindowState = FormWindowState.Minimized
            e.Cancel = True
            NotifyIcon5.Visible = True
            NotifyIcon5.Icon = My.Resources.icon
            NotifyIcon5.BalloonTipTitle = "后勤提醒"
            NotifyIcon5.BalloonTipText = "已最小化到托盘"
            NotifyIcon5.ShowBalloonTip(10000)
            ShowInTaskbar = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub init()
        cboName1.Items.Clear()
        cboName2.Items.Clear()
        cboName3.Items.Clear()
        cboName4.Items.Clear()

        For Each l In arr_Logistic
            cboName1.Items.Add(l.getName)
            cboName2.Items.Add(l.getName)
            cboName3.Items.Add(l.getName)
            cboName4.Items.Add(l.getName)
        Next

        cboName1.SelectedIndex = -1
        cboName2.SelectedIndex = -1
        cboName3.SelectedIndex = -1
        cboName4.SelectedIndex = -1

        picStart1.BackColor = Color.Transparent
        picStart2.BackColor = Color.Transparent
        picStart3.BackColor = Color.Transparent
        picStart4.BackColor = Color.Transparent

        btnSaveFavorite.Enabled = False

        Me.Icon = My.Resources.icon
    End Sub

    ' Combo box event
    Private Sub cboName1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName1.SelectedIndexChanged
        Timer1.Stop()
        picStart1.Visible = True
        picStart1.Enabled = True
        picReset1.Visible = False
        picReset1.Enabled = False

        If cboName1.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName1.SelectedItem.ToString)

            lblTime1.Text = logistic.getHour.ToString("D2") & ":" & logistic.getMinute.ToString("D2") & ":00"
            lblHour1.Text = logistic.getTime().ToString
        End If
    End Sub

    Private Sub cboName2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName2.SelectedIndexChanged
        Timer2.Stop()
        picStart2.Visible = True
        picStart2.Enabled = True
        picReset2.Visible = False
        picReset2.Enabled = False

        If cboName2.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName2.SelectedItem.ToString)

            lblTime2.Text = logistic.getHour.ToString("D2") & ":" & logistic.getMinute.ToString("D2") & ":00"
            lblHour2.Text = logistic.getTime().ToString
        End If
    End Sub

    Private Sub cboName3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName3.SelectedIndexChanged
        Timer3.Stop()
        picStart3.Visible = True
        picStart3.Enabled = True
        picReset3.Visible = False
        picReset3.Enabled = False

        If cboName3.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName3.SelectedItem.ToString)

            lblTime3.Text = logistic.getHour.ToString("D2") & ":" & logistic.getMinute.ToString("D2") & ":00"
            lblHour3.Text = logistic.getTime().ToString
        End If
    End Sub

    Private Sub cboName4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName4.SelectedIndexChanged
        Timer4.Stop()
        picStart4.Visible = True
        picStart4.Enabled = True
        picReset4.Visible = False
        picReset4.Enabled = False

        If cboName4.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName4.SelectedItem.ToString)

            lblTime4.Text = logistic.getHour.ToString("D2") & ":" & logistic.getMinute.ToString("D2") & ":00"
            lblHour4.Text = logistic.getTime().ToString
        End If
    End Sub

    ' Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        currentTime1 = ts.ToString("hh\:mm\:ss")

        If lblTime1.Text = "00:" + announceBefore.ToString("D2") + ":00" And notified1 = False Then
            Notify(1, cboName1.SelectedItem.ToString)
            notified1 = True
        End If

        If ts.TotalMilliseconds > 0 Then
            lblTime1.Text = currentTime1
        Else
            lblTime1.Text = ("00:00:00")
            Timer1.Stop()
            currentTime1 = ("00:00:00")
            picReset1_Click(Nothing, Nothing)
            If restartMission(1, cboName1.SelectedItem.ToString) Then
                picStart1_Click(Nothing, Nothing)
            End If
            NotifyIcon1.Visible = False
            NotifyIcon1.Icon = Nothing
        End If
        updateNotifyIconText()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim ts As TimeSpan = TargetDT2.Subtract(DateTime.Now)
        currentTime2 = ts.ToString("hh\:mm\:ss")

        If lblTime2.Text = "00:" + announceBefore.ToString("D2") + ":00" And notified2 = False Then
            Notify(2, cboName2.SelectedItem.ToString)
            notified2 = True
        End If

        If ts.TotalMilliseconds > 0 Then
            lblTime2.Text = currentTime2
        Else
            lblTime2.Text = ("00:00:00")
            Timer2.Stop()
            currentTime2 = ("00:00:00")
            picReset2_Click(Nothing, Nothing)
            If restartMission(2, cboName2.SelectedItem.ToString) Then
                picStart2_Click(Nothing, Nothing)
            End If
            NotifyIcon2.Visible = False
            NotifyIcon2.Icon = Nothing
        End If
        updateNotifyIconText()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim ts As TimeSpan = TargetDT3.Subtract(DateTime.Now)
        currentTime3 = ts.ToString("hh\:mm\:ss")

        If lblTime3.Text = "00:" + announceBefore.ToString("D2") + ":00" And notified3 = False Then
            Notify(3, cboName3.SelectedItem.ToString)
            notified3 = True
        End If

        If ts.TotalMilliseconds > 0 Then
            lblTime3.Text = currentTime3
        Else
            lblTime3.Text = ("00:00:00")
            Timer3.Stop()
            currentTime3 = ("00:00:00")
            picReset3_Click(Nothing, Nothing)
            If restartMission(3, cboName3.SelectedItem.ToString) Then
                picStart3_Click(Nothing, Nothing)
            End If
            NotifyIcon3.Visible = False
            NotifyIcon3.Icon = Nothing
        End If
        updateNotifyIconText()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim ts As TimeSpan = TargetDT4.Subtract(DateTime.Now)
        currentTime4 = ts.ToString("hh\:mm\:ss")

        If lblTime4.Text = "00:" + announceBefore.ToString("D2") + ":00" And notified4 = False Then
            Notify(4, cboName4.SelectedItem.ToString)
            notified4 = True
        End If

        If ts.TotalMilliseconds > 0 Then
            lblTime4.Text = currentTime4
        Else
            lblTime4.Text = ("00:00:00")
            Timer4.Stop()
            currentTime4 = ("00:00:00")
            picReset4_Click(Nothing, Nothing)
            If restartMission(4, cboName4.SelectedItem.ToString) Then
                picStart4_Click(Nothing, Nothing)
            End If
            NotifyIcon4.Visible = False
            NotifyIcon4.Icon = Nothing
        End If
        updateNotifyIconText()
    End Sub

    ' Button Click Event
    Private Sub btnSaveFavorite_Click(sender As Object, e As EventArgs) Handles btnSaveFavorite.Click
        If favClicked1 = True Then
            frmFavoriteName.setFavoriteName(Label17.Text)
        ElseIf favClicked2 = True Then
            frmFavoriteName.setFavoriteName(Label18.Text)
        ElseIf favClicked3 = True Then
            frmFavoriteName.setFavoriteName(Label19.Text)
        ElseIf favClicked4 = True Then
            frmFavoriteName.setFavoriteName(Label20.Text)
        End If

        Dim dlgResult As DialogResult = frmFavoriteName.ShowDialog
        If dlgResult = DialogResult.OK Then
            If favClicked1 = True Then
                Label17.Text = favName
                saveLogistic(1)
                MessageBox.Show("[" & favName & "] 已保存", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf favClicked2 = True Then
                Label18.Text = favName
                saveLogistic(2)
                MessageBox.Show("[" & favName & "]已保存", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf favClicked3 = True Then
                Label19.Text = favName
                saveLogistic(3)
                MessageBox.Show("[" & favName & "]已保存", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf favClicked4 = True Then
                Label20.Text = favName
                saveLogistic(4)
                MessageBox.Show("[" & favName & "]已保存", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("自定义后勤尚未保存", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
        disableAllButton()
    End Sub

    Private Sub btn_resetTimer_Click(sender As Object, e As EventArgs) Handles btn_resetTime.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        cboName1_SelectedIndexChanged(Nothing, Nothing)
        cboName2_SelectedIndexChanged(Nothing, Nothing)
        cboName3_SelectedIndexChanged(Nothing, Nothing)
        cboName4_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Timer1.Enabled = False Then
            picStart1_Click(Nothing, Nothing)
        End If

        If Timer2.Enabled = False Then
            picStart2_Click(Nothing, Nothing)
        End If

        If Timer3.Enabled = False Then
            picStart3_Click(Nothing, Nothing)
        End If

        If Timer4.Enabled = False Then
            picStart4_Click(Nothing, Nothing)
        End If
    End Sub

    ' Start and Stop button click event
    Private Sub picStart1_Click(sender As Object, e As EventArgs) Handles picStart1.Click
        notified1 = False
        If cboName1.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour1.Text))

            Timer1.Interval = 50
            TargetDT1 = DateTime.Now.Add(CountDownFrom)
            Timer1.Start()

            picStart1.Visible = False
            picStart1.Enabled = False
            picReset1.Visible = True
            picReset1.Enabled = True
        End If
    End Sub

    Private Sub picStart2_Click(sender As Object, e As EventArgs) Handles picStart2.Click
        If cboName2.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour2.Text))

            Timer2.Interval = 50
            TargetDT2 = DateTime.Now.Add(CountDownFrom)
            Timer2.Start()

            picStart2.Visible = False
            picStart2.Enabled = False
            picReset2.Visible = True
            picReset2.Enabled = True
        End If
    End Sub

    Private Sub picStart3_Click(sender As Object, e As EventArgs) Handles picStart3.Click
        If cboName3.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour3.Text))

            Timer3.Interval = 50
            TargetDT3 = DateTime.Now.Add(CountDownFrom)
            Timer3.Start()

            picStart3.Visible = False
            picStart3.Enabled = False
            picReset3.Visible = True
            picReset3.Enabled = True
        End If
    End Sub

    Private Sub picStart4_Click(sender As Object, e As EventArgs) Handles picStart4.Click
        If cboName4.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour4.Text))

            Timer4.Interval = 50
            TargetDT4 = DateTime.Now.Add(CountDownFrom)
            Timer4.Start()

            picStart4.Visible = False
            picStart4.Enabled = False
            picReset4.Visible = True
            picReset4.Enabled = True
        End If
    End Sub

    Private Sub picReset1_Click(sender As Object, e As EventArgs) Handles picReset1.Click
        Timer1.Stop()
        cboName1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub picReset2_Click(sender As Object, e As EventArgs) Handles picReset2.Click
        Timer2.Stop()
        cboName2_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub picReset3_Click(sender As Object, e As EventArgs) Handles picReset3.Click
        Timer3.Stop()
        cboName3_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub picReset4_Click(sender As Object, e As EventArgs) Handles picReset4.Click
        Timer4.Stop()
        cboName4_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    ' Menu Strip click event
    Private Sub ctxExit_Click(sender As Object, e As EventArgs) Handles ctxExit.Click
        End
    End Sub

    Private Sub ctxShow_Click(sender As Object, e As EventArgs) Handles ctxShow.Click
        NotifyIcon5_DoubleClick(Nothing, Nothing)
    End Sub

    Private Sub mnuSettingAnnounce_Click(sender As Object, e As EventArgs) Handles mnuSettingAnnounce.Click
        frmAnnounce.ShowDialog()
        getAnnounceSettings()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        FrmAbout.ShowDialog()
    End Sub

    ' Resources Button Click Event
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Label6.Click
        If manpowerClicked = False Then
            uncheckOthers()
            PictureBox1.Image = My.Resources.button_red
            manpowerClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "0-2" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "5-3" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "7-1" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "10-1" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox1.Image = My.Resources.button_grey
            manpowerClicked = False
            clear()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label7.Click
        If ammoClicked = False Then
            uncheckOthers()
            PictureBox2.Image = My.Resources.button_red
            ammoClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "3-3" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "5-2" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "10-1" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "11-1" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox2.Image = My.Resources.button_grey
            ammoClicked = False
            clear()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Label8.Click
        If rationClicked = False Then
            uncheckOthers()
            PictureBox3.Image = My.Resources.button_red
            rationClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "3-1" Then
                    cboName1.SelectedIndex = i
                End If


                If cboName2.Items(i).ToString = "5-1" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "7-1" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "9-1" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox3.Image = My.Resources.button_grey
            rationClicked = False
            clear()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, Label9.Click
        If partClicked = False Then
            uncheckOthers()
            PictureBox4.Image = My.Resources.button_red
            partClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "0-2" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "4-2" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "8-2" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "9-1" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox4.Image = My.Resources.button_grey
            partClicked = False
            clear()
        End If
    End Sub

    ' Contract Button Click Event
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click, Label11.Click
        If dollClicked = False Then
            uncheckOthers()
            PictureBox5.Image = My.Resources.button_red
            dollClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "0-2" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "1-4" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "10-2" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "11-2" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox5.Image = My.Resources.button_grey
            dollClicked = False
            clear()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, Label12.Click
        If equipmentClicked = False Then
            uncheckOthers()
            PictureBox6.Image = My.Resources.button_red
            equipmentClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "4-1" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "5-3" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "8-1" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "11-1" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox6.Image = My.Resources.button_grey
            equipmentClicked = False
            clear()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, Label13.Click
        If productionClicked = False Then
            uncheckOthers()
            PictureBox7.Image = My.Resources.button_red
            productionClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "0-1" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "3-3" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "4-2" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "9-2" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox7.Image = My.Resources.button_grey
            productionClicked = False
            clear()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click, Label14.Click
        If restoreClicked = False Then
            uncheckOthers()
            PictureBox8.Image = My.Resources.button_red
            restoreClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "0-1" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "1-3" Then
                    cboName2.SelectedIndex = i
                End If

                If cboName3.Items(i).ToString = "2-2" Then
                    cboName3.SelectedIndex = i
                End If

                If cboName4.Items(i).ToString = "3-3" Then
                    cboName4.SelectedIndex = i
                End If
            Next i
        Else
            PictureBox8.Image = My.Resources.button_grey
            restoreClicked = False
            clear()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, Label15.Click
        If tokenClicked = False Then
            uncheckOthers()
            PictureBox9.Image = My.Resources.button_red
            tokenClicked = True
            For i = 0 To cboName1.Items.Count - 1
                If cboName1.Items(i).ToString = "0-4" Then
                    cboName1.SelectedIndex = i
                End If

                If cboName2.Items(i).ToString = "6-4" Then
                    cboName2.SelectedIndex = i
                End If

                cboName3.SelectedIndex = -1
                cboName4.SelectedIndex = -1
            Next i
        Else
            PictureBox9.Image = My.Resources.button_grey
            tokenClicked = False
            clear()
        End If
    End Sub

    ' Favorite Button Click Event
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click, Label17.Click
        If favClicked1 = False Then
            uncheckOthers()
            PictureBox10.Image = My.Resources.button_red
            favClicked1 = True
            RetrieveSettings(1)
            btnSaveFavorite.Enabled = True
        Else
            PictureBox10.Image = My.Resources.button_grey
            favClicked1 = False
            btnSaveFavorite.Enabled = False
            clear()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click, Label18.Click
        If favClicked2 = False Then
            uncheckOthers()
            PictureBox11.Image = My.Resources.button_red
            favClicked2 = True
            RetrieveSettings(2)
            btnSaveFavorite.Enabled = True
        Else
            PictureBox11.Image = My.Resources.button_grey
            favClicked2 = False
            btnSaveFavorite.Enabled = False
            clear()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click, Label19.Click
        If favClicked3 = False Then
            uncheckOthers()
            PictureBox12.Image = My.Resources.button_red
            favClicked3 = True
            RetrieveSettings(3)
            btnSaveFavorite.Enabled = True
        Else
            PictureBox12.Image = My.Resources.button_grey
            favClicked3 = False
            btnSaveFavorite.Enabled = False
            clear()
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click, Label20.Click
        If favClicked4 = False Then
            uncheckOthers()
            PictureBox13.Image = My.Resources.button_red
            favClicked4 = True

            RetrieveSettings(4)
            btnSaveFavorite.Enabled = True
        Else
            PictureBox13.Image = My.Resources.button_grey
            favClicked4 = False
            btnSaveFavorite.Enabled = False
            clear()
        End If
    End Sub

    ' Notification
    Private Sub Notify(index As Integer, name As String)
        If index = 1 Then
            NotifyIcon1.Icon = My.Resources.icon
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipTitle = "指挥官我们回来啦～"
            NotifyIcon1.BalloonTipText = "后勤队伍#1已从 " & name & " 归来！"
            NotifyIcon1.ShowBalloonTip(3000)
        End If

        If index = 2 Then
            NotifyIcon2.Icon = My.Resources.icon
            NotifyIcon1.Visible = True
            NotifyIcon2.BalloonTipTitle = "指挥官我们回来啦～"
            NotifyIcon2.BalloonTipText = "后勤队伍#2已从 " & name & " 归来！"
            NotifyIcon2.ShowBalloonTip(3000)
        End If

        If index = 3 Then
            NotifyIcon3.Icon = My.Resources.icon
            NotifyIcon1.Visible = True
            NotifyIcon3.BalloonTipTitle = "指挥官我们回来啦～"
            NotifyIcon3.BalloonTipText = "后勤队伍#3已从 " & name & " 归来！"
            NotifyIcon3.ShowBalloonTip(3000)
        End If

        If index = 4 Then
            NotifyIcon4.Icon = My.Resources.icon
            NotifyIcon1.Visible = True
            NotifyIcon4.BalloonTipTitle = "指挥官我们回来啦～"
            NotifyIcon4.BalloonTipText = "后勤队伍#4已从 " & name & " 归来！"
            NotifyIcon4.ShowBalloonTip(3000)
        End If
    End Sub

    Private Sub NotifyIcon_BalloonTipClicked(sender As Object, e As EventArgs) Handles _
            NotifyIcon1.BalloonTipClicked, NotifyIcon2.BalloonTipClicked,
            NotifyIcon3.BalloonTipClicked, NotifyIcon4.BalloonTipClicked

        WindowState = FormWindowState.Normal
        TopMost = True
        TopMost = False
    End Sub

    Private Sub NotifyIcon5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon5.DoubleClick, NotifyIcon5.BalloonTipClicked
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon5.Visible = False
        NotifyIcon5.Icon = Nothing
    End Sub

    ' Others function
    Private Sub RetrieveSettings(index As Integer)
        Dim settings As StringCollection = Nothing

        If index = 0 Then
            If My.Settings.Previous IsNot Nothing Then
                settings = My.Settings.Previous
            End If
            retrieveFavName(index)
        ElseIf index = 1 Then
            If My.Settings.Favorite1 IsNot Nothing Then
                settings = My.Settings.Favorite1
                retrieveFavName(index)
            End If
        ElseIf index = 2 Then
            If My.Settings.Favorite2 IsNot Nothing Then
                settings = My.Settings.Favorite2
                retrieveFavName(index)
            End If
        ElseIf index = 3 Then
            If My.Settings.Favorite3 IsNot Nothing Then
                settings = My.Settings.Favorite3
                retrieveFavName(index)
            End If
        ElseIf index = 4 Then
            If My.Settings.Favorite4 IsNot Nothing Then
                settings = My.Settings.Favorite4
                retrieveFavName(index)
            End If
        Else
            MessageBox.Show("Retrieve settings failed", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

        ' set value into all cbo
        If settings IsNot Nothing Then
            If index = 0 Then
                If settings(0) <> "" Then
                    cboName1.Text = settings(0)
                Else
                    cboname1.SelectedIndex = -1
                End If

                If settings(1) <> "" Then
                    cboName2.Text = settings(1)
                Else
                    cboName2.SelectedIndex = -1
                End If

                If settings(2) <> "" Then
                    cboName3.Text = settings(2)
                Else
                    cboName3.SelectedIndex = -1
                End If

                If settings(3) <> "" Then
                    cboName4.Text = settings(3)
                Else
                    cboName4.SelectedIndex = -1
                End If
            Else
                If String.IsNullOrEmpty(settings(1)) = False Then
                    cboName1.Text = settings(1)
                Else
                    cboName1.SelectedIndex = -1
                End If

                If String.IsNullOrEmpty(settings(2)) = False Then
                    cboName2.Text = settings(2)
                Else
                    cboName2.SelectedIndex = -1
                End If

                If String.IsNullOrEmpty(settings(3)) = False Then
                    cboName3.Text = settings(3)
                Else
                    cboName3.SelectedIndex = -1
                End If

                If String.IsNullOrEmpty(settings(4)) = False Then
                    cboName4.Text = settings(4)
                Else
                    cboName4.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub retrieveFavName(index As Integer)
        If index = 0 Then
            If My.Settings.Favorite1 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite1(0)) = False Then
                    Label17.Text = My.Settings.Favorite1(0)
                End If
            End If

            If My.Settings.Favorite2 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite2(0)) = False Then
                    Label18.Text = My.Settings.Favorite2(0)
                End If
            End If

            If My.Settings.Favorite3 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite3(0)) = False Then
                    Label19.Text = My.Settings.Favorite3(0)
                End If
            End If

            If My.Settings.Favorite4 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite4(0)) = False Then
                    Label20.Text = My.Settings.Favorite4(0)
                End If
            End If
        ElseIf index = 1 Then
            If My.Settings.Favorite1 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite1(0)) = False Then
                    Label17.Text = My.Settings.Favorite1(0)
                End If
            End If
        ElseIf index = 2 Then
            If My.Settings.Favorite2 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite2(0)) = False Then
                    Label18.Text = My.Settings.Favorite2(0)
                End If
            End If
        ElseIf index = 3 Then
            If My.Settings.Favorite3 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite3(0)) = False Then
                    Label19.Text = My.Settings.Favorite3(0)
                End If
            End If
        ElseIf index = 4 Then
            If My.Settings.Favorite4 IsNot Nothing Then
                If String.IsNullOrEmpty(My.Settings.Favorite4(0)) = False Then
                    Label20.Text = My.Settings.Favorite4(0)
                End If
            End If
        End If
    End Sub

    Private Function restartMission(index As Integer, name As String) As Boolean

        WindowState = FormWindowState.Normal
        TopMost = True

        Dim dlgResult As DialogResult = MessageBox.Show("是否重新计时[" & name & "]呢?", "后勤#" & index & "重新派遣",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        TopMost = False
        Dim result As Boolean = False

        If dlgResult = DialogResult.Yes Then
            result = True
        End If

        Return result
    End Function

    Private Sub uncheckOthers()
        clear()

        If manpowerClicked Then
            PictureBox1_Click(Nothing, Nothing)
        ElseIf ammoClicked Then
            PictureBox2_Click(Nothing, Nothing)
        ElseIf rationClicked Then
            PictureBox3_Click(Nothing, Nothing)
        ElseIf partClicked Then
            PictureBox4_Click(Nothing, Nothing)
        ElseIf dollClicked Then
            PictureBox5_Click(Nothing, Nothing)
        ElseIf equipmentClicked Then
            PictureBox6_Click(Nothing, Nothing)
        ElseIf productionClicked Then
            PictureBox7_Click(Nothing, Nothing)
        ElseIf restoreClicked Then
            PictureBox8_Click(Nothing, Nothing)
        ElseIf tokenClicked Then
            PictureBox9_Click(Nothing, Nothing)
        ElseIf favClicked1 Then
            PictureBox10_Click(Nothing, Nothing)
        ElseIf favClicked2 Then
            PictureBox11_Click(Nothing, Nothing)
        ElseIf favClicked3 Then
            PictureBox12_Click(Nothing, Nothing)
        ElseIf favClicked4 Then
            PictureBox13_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub checkButtonClicked()
        If manpowerClicked = True Then
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf ammoClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf rationClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf partClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf dollClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf equipmentClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf productionClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf restoreClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf tokenClicked = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf favClicked1 = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf favClicked2 = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf favClicked3 = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf favClicked4 = True Then
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
        Else
            manpowerClicked = False
            PictureBox1.Image = My.Resources.button_grey
            ammoClicked = False
            PictureBox2.Image = My.Resources.button_grey
            rationClicked = False
            PictureBox3.Image = My.Resources.button_grey
            partClicked = False
            PictureBox4.Image = My.Resources.button_grey
            dollClicked = False
            PictureBox5.Image = My.Resources.button_grey
            equipmentClicked = False
            PictureBox6.Image = My.Resources.button_grey
            productionClicked = False
            PictureBox7.Image = My.Resources.button_grey
            restoreClicked = False
            PictureBox8.Image = My.Resources.button_grey
            tokenClicked = False
            PictureBox9.Image = My.Resources.button_grey
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        End If
    End Sub

    Private Sub clear()
        cboName1.SelectedIndex = -1
        cboName2.SelectedIndex = -1
        cboName3.SelectedIndex = -1
        cboName4.SelectedIndex = -1

        lblHour1.Text = "0"
        lblHour2.Text = "0"
        lblHour3.Text = "0"
        lblHour4.Text = "0"

        lblTime1.Text = "00:00:00"
        lblTime2.Text = "00:00:00"
        lblTime3.Text = "00:00:00"
        lblTime4.Text = "00:00:00"

        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        picStart1.Visible = True
        picStart2.Visible = True
        picStart3.Visible = True
        picStart4.Visible = True

        picReset1.Visible = False
        picReset2.Visible = False
        picReset3.Visible = False
        picReset4.Visible = False

        picReset1.Enabled = False
        picReset2.Enabled = False
        picReset3.Enabled = False
        picReset4.Enabled = False
    End Sub

    Private Function getLogistic(name As String) As LogisticSupport
        Dim logistic As LogisticSupport = Nothing

        For Each targetLogistic In arr_Logistic
            If targetLogistic IsNot Nothing Then
                If targetLogistic.getName = name Then
                    logistic = targetLogistic
                End If
            End If
        Next

        Return logistic
    End Function

    Private Sub getAnnounceSettings()
        If My.Settings.AnnounceBefore <> Nothing Then
            announceBefore = My.Settings.AnnounceBefore
        Else
            My.Settings.AnnounceBefore = 0
            announceBefore = 0
        End If
    End Sub

    Public Sub setFavoriteName(_favName As String)
        favName = _favName
    End Sub

    Private Sub disableAllButton()
        manpowerClicked = False
        ammoClicked = False
        rationClicked = False
        partClicked = False
        dollClicked = False
        equipmentClicked = False
        productionClicked = False
        restoreClicked = False
        tokenClicked = False
        favClicked1 = False
        favClicked2 = False
        favClicked3 = False
        favClicked4 = False

        PictureBox1.Image = My.Resources.button_grey
        PictureBox2.Image = My.Resources.button_grey
        PictureBox3.Image = My.Resources.button_grey
        PictureBox4.Image = My.Resources.button_grey
        PictureBox5.Image = My.Resources.button_grey
        PictureBox6.Image = My.Resources.button_grey
        PictureBox7.Image = My.Resources.button_grey
        PictureBox8.Image = My.Resources.button_grey
        PictureBox9.Image = My.Resources.button_grey
        PictureBox10.Image = My.Resources.button_grey
        PictureBox11.Image = My.Resources.button_grey
        PictureBox12.Image = My.Resources.button_grey
        PictureBox13.Image = My.Resources.button_grey

        btnSaveFavorite.Enabled = False
    End Sub

    Private Sub updateNotifyIconText()
        NotifyIcon5.Text =
            "#1  " & currentTime1 & vbNewLine &
            "#2  " & currentTime2 & vbNewLine &
            "#3  " & currentTime3 & vbNewLine &
            "#4  " & currentTime4 & vbNewLine
    End Sub
    ' Save to settings
    Private Sub saveLogistic(index As Integer)
        Dim logistic1 As String = ""
        Dim logistic2 As String = ""
        Dim logistic3 As String = ""
        Dim logistic4 As String = ""

        If cboName1.SelectedIndex <> -1 Then
            logistic1 = cboName1.SelectedItem.ToString
        End If

        If cboName2.SelectedIndex <> -1 Then
            logistic2 = cboName2.SelectedItem.ToString
        End If

        If cboName3.SelectedIndex <> -1 Then
            logistic3 = cboName3.SelectedItem.ToString
        End If

        If cboName4.SelectedIndex <> -1 Then
            logistic4 = cboName4.SelectedItem.ToString
        End If

        If index = 0 Then
            My.Settings.Previous = New Specialized.StringCollection

            My.Settings.Previous.Clear()
            My.Settings.Previous.Add(logistic1)
            My.Settings.Previous.Add(logistic2)
            My.Settings.Previous.Add(logistic3)
            My.Settings.Previous.Add(logistic4)
        ElseIf index = 1 Then
            My.Settings.Favorite1 = New Specialized.StringCollection

            My.Settings.Favorite1.Clear()
            My.Settings.Favorite1.Add(favName)
            My.Settings.Favorite1.Add(logistic1)
            My.Settings.Favorite1.Add(logistic2)
            My.Settings.Favorite1.Add(logistic3)
            My.Settings.Favorite1.Add(logistic4)
        ElseIf index = 2 Then
            My.Settings.Favorite2 = New Specialized.StringCollection

            My.Settings.Favorite2.Clear()
            My.Settings.Favorite2.Add(favName)
            My.Settings.Favorite2.Add(logistic1)
            My.Settings.Favorite2.Add(logistic2)
            My.Settings.Favorite2.Add(logistic3)
            My.Settings.Favorite2.Add(logistic4)
        ElseIf index = 3 Then
            My.Settings.Favorite3 = New Specialized.StringCollection

            My.Settings.Favorite3.Clear()
            My.Settings.Favorite3.Add(favName)
            My.Settings.Favorite3.Add(logistic1)
            My.Settings.Favorite3.Add(logistic2)
            My.Settings.Favorite3.Add(logistic3)
            My.Settings.Favorite3.Add(logistic4)
        ElseIf index = 4 Then
            My.Settings.Favorite4 = New Specialized.StringCollection

            My.Settings.Favorite4.Clear()
            My.Settings.Favorite4.Add(favName)
            My.Settings.Favorite4.Add(logistic1)
            My.Settings.Favorite4.Add(logistic2)
            My.Settings.Favorite4.Add(logistic3)
            My.Settings.Favorite4.Add(logistic4)
        End If

        My.Settings.Save()
    End Sub

    Private Sub mnuViewLogistic_Click(sender As Object, e As EventArgs) Handles mnuViewLogistic.Click
        后勤查询.Show()
    End Sub
End Class
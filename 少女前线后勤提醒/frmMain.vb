Imports System.Collections.Specialized
Imports System.Runtime.InteropServices

Public Class frmMain
    ' ToDo List
    ' UI improve
    ' add sound
    ' remember to set 0-1 time to 00:50
    ' skill training time announce
    ' result check
    ' select one or two type of resources
    ' editable time


    Public arr_Logistic(60) As LogisticSupport
    Public TargetDT1 As DateTime
    Public TargetDT2 As DateTime
    Public TargetDT3 As DateTime
    Public TargetDT4 As DateTime
    Public TargetDT5 As DateTime

    Dim beforeMinute As Integer
    Dim beforeSecond As Integer

    Dim notified1 As Boolean
    Dim notified2 As Boolean
    Dim notified3 As Boolean
    Dim notified4 As Boolean
    Dim notified5 As Boolean

    Dim favClicked1 As Boolean = False
    Dim favClicked2 As Boolean = False
    Dim favClicked3 As Boolean = False
    Dim favClicked4 As Boolean = False

    Public favName As String

    Dim currentTime1 As String
    Dim currentTime2 As String
    Dim currentTime3 As String
    Dim currentTime4 As String
    Dim currenttime5 As String

    Dim otherTimer As String
    Public hidden As Boolean = False

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

        btnSaveFavorite.Enabled = False
        btnSaveFavorite.ForeColor = Color.Black
        btnSaveFavorite.BackColor = Color.LightGray

        Me.Icon = My.Resources.icon
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InsertLogistic()
        init()
        RetrieveSettings(0)
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim quit As Boolean = False

        If My.Settings.DontAskAgain = False Then
            Dim dlgResult As DialogResult = frmExit.ShowDialog
            If dlgResult = DialogResult.Yes Then
                quit = False
                exitForm(quit, e)
            ElseIf dlgResult = DialogResult.No Then
                quit = True
                exitForm(quit, e)
            Else
                e.Cancel = True
            End If
        Else
            quit = My.Settings.ExitSettings
            exitForm(quit, e)
        End If
    End Sub

    Private Sub exitForm(quit As Boolean, ByRef e As FormClosingEventArgs)
        If quit Then
            saveLogistic(0)

            ntf1.Icon = Nothing
            ntf1.Visible = False
            ntf1.Dispose()
        Else
            My.Computer.Audio.Play(My.Resources.sound_minimize, AudioPlayMode.Background)
            Visible = False
            Opacity = 0
            ShowInTaskbar = False
            e.Cancel = True
            ntf1.Visible = True
            hidden = True
            ntf1.Icon = My.Resources.icon
            frmNotification.counter = 0
            frmNotification.Opacity = 1
            frmNotification.sendOthersNotification("已最小化至托盘", "少女前线后勤管理")
            frmNotification.Show()
        End If
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
            ElseIf favClicked2 = True Then
                Label18.Text = favName
                saveLogistic(2)
            ElseIf favClicked3 = True Then
                Label19.Text = favName
                saveLogistic(3)
            ElseIf favClicked4 = True Then
                Label20.Text = favName
                saveLogistic(4)
            End If
            frmMsgBox.title = "成功"
            frmMsgBox.content = "[" & favName & "]已保存"
            frmMsgBox.btnYesString = "确定"
            frmMsgBox.msgType = "Yes"
            frmMsgBox.ShowDialog()
        Else
            frmMsgBox.title = ""
            frmMsgBox.content = "自定义后勤尚未保存"
            frmMsgBox.btnYesString = "确定"
            frmMsgBox.msgType = "Yes"
            frmMsgBox.ShowDialog()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
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

    ' Menu Strip click event
    Private Sub ctxExit_Click(sender As Object, e As EventArgs) Handles ctxExit.Click
        End
    End Sub

    ' Favorite Button Click Event
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click, Label17.Click
        Dim selectIndex As Integer() = {cboName1.SelectedIndex, cboName2.SelectedIndex, cboName3.SelectedIndex, cboName4.SelectedIndex}

        If favClicked1 = False Then
            If selectIndex(0) <> -1 Or selectIndex(1) <> -1 Or selectIndex(2) <> -1 Or selectIndex(3) <> -1 Then
                If My.Settings.Favorite1 IsNot Nothing Then
                    frmMsgBox.title = "替换后勤"
                    frmMsgBox.content = "当前的后勤列表将替换成" & vbNewLine & "[" & Label17.Text & "]的后勤列表，是否替换？" & vbNewLine & "(所有计时将会重置)"
                    frmMsgBox.btnYesString = "替换"
                    frmMsgBox.btnNoString = "保留"
                    frmMsgBox.msgType = "YesNo"

                    Dim dlg As DialogResult = frmMsgBox.ShowDialog()
                    If dlg = DialogResult.Yes Then
                        uncheckOthers()
                        RetrieveSettings(1)
                        PictureBox10.Image = My.Resources.button_red
                        favClicked1 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    ElseIf dlg = DialogResult.No Then
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                        PictureBox10.Image = My.Resources.button_red
                        favClicked1 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    Else
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                    End If
                Else
                    uncheckOthers()
                    cboName1.SelectedIndex = selectIndex(0)
                    cboName2.SelectedIndex = selectIndex(1)
                    cboName3.SelectedIndex = selectIndex(2)
                    cboName4.SelectedIndex = selectIndex(3)
                    PictureBox10.Image = My.Resources.button_red
                    favClicked1 = True
                    btnSaveFavorite.Enabled = True
                    btnSaveFavorite.ForeColor = Color.White
                    btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                End If
            Else
                uncheckOthers()
                RetrieveSettings(1)
                PictureBox10.Image = My.Resources.button_red
                favClicked1 = True
                btnSaveFavorite.Enabled = True
                btnSaveFavorite.ForeColor = Color.White
                btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
            End If
        Else
            PictureBox10.Image = My.Resources.button_grey
            favClicked1 = False
            btnSaveFavorite.Enabled = False
            btnSaveFavorite.ForeColor = Color.Black
            btnSaveFavorite.BackColor = Color.LightGray
            clear()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click, Label18.Click
        Dim selectIndex As Integer() = {cboName1.SelectedIndex, cboName2.SelectedIndex, cboName3.SelectedIndex, cboName4.SelectedIndex}

        If favClicked2 = False Then
            If selectIndex(0) <> -1 Or selectIndex(1) <> -1 Or selectIndex(2) <> -1 Or selectIndex(3) <> -1 Then
                If My.Settings.Favorite2 IsNot Nothing Then
                    frmMsgBox.title = "替换后勤"
                    frmMsgBox.content = "当前的后勤列表将替换成" & vbNewLine & "[" & Label18.Text & "]的后勤列表，是否替换？" & vbNewLine & "(所有计时将会重置)"
                    frmMsgBox.btnYesString = "替换"
                    frmMsgBox.btnNoString = "保留"
                    frmMsgBox.msgType = "YesNo"

                    Dim dlg As DialogResult = frmMsgBox.ShowDialog()

                    If dlg = DialogResult.Yes Then
                        uncheckOthers()
                        RetrieveSettings(2)
                        PictureBox11.Image = My.Resources.button_red
                        favClicked2 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    ElseIf dlg = DialogResult.No Then
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                        PictureBox11.Image = My.Resources.button_red
                        favClicked2 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    Else
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                    End If
                Else
                    uncheckOthers()
                    cboName1.SelectedIndex = selectIndex(0)
                    cboName2.SelectedIndex = selectIndex(1)
                    cboName3.SelectedIndex = selectIndex(2)
                    cboName4.SelectedIndex = selectIndex(3)
                    PictureBox11.Image = My.Resources.button_red
                    favClicked2 = True
                    btnSaveFavorite.Enabled = True
                    btnSaveFavorite.ForeColor = Color.White
                    btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                End If
            Else
                uncheckOthers()
                RetrieveSettings(2)
                PictureBox11.Image = My.Resources.button_red
                favClicked2 = True
                btnSaveFavorite.Enabled = True
                btnSaveFavorite.ForeColor = Color.White
                btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
            End If
        Else
            PictureBox11.Image = My.Resources.button_grey
            favClicked2 = False
            btnSaveFavorite.Enabled = False
            btnSaveFavorite.ForeColor = Color.Black
            btnSaveFavorite.BackColor = Color.LightGray
            clear()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click, Label19.Click
        Dim selectIndex As Integer() = {cboName1.SelectedIndex, cboName2.SelectedIndex, cboName3.SelectedIndex, cboName4.SelectedIndex}

        If favClicked3 = False Then
            If selectIndex(0) <> -1 Or selectIndex(1) <> -1 Or selectIndex(2) <> -1 Or selectIndex(3) <> -1 Then
                If My.Settings.Favorite3 IsNot Nothing Then
                    frmMsgBox.title = "替换后勤"
                    frmMsgBox.content = "当前的后勤列表将替换成" & vbNewLine & "[" & Label18.Text & "]的后勤列表，是否替换？" & vbNewLine & "(所有计时将会重置)"
                    frmMsgBox.btnYesString = "替换"
                    frmMsgBox.btnNoString = "保留"
                    frmMsgBox.msgType = "YesNo"

                    Dim dlg As DialogResult = frmMsgBox.ShowDialog()
                    uncheckOthers()
                    If dlg = DialogResult.Yes Then
                        uncheckOthers()
                        RetrieveSettings(3)
                        PictureBox12.Image = My.Resources.button_red
                        favClicked3 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    ElseIf dlg = DialogResult.No Then
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                        PictureBox12.Image = My.Resources.button_red
                        favClicked3 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    Else
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                    End If
                Else
                    uncheckOthers()
                    cboName1.SelectedIndex = selectIndex(0)
                    cboName2.SelectedIndex = selectIndex(1)
                    cboName3.SelectedIndex = selectIndex(2)
                    cboName4.SelectedIndex = selectIndex(3)
                    PictureBox12.Image = My.Resources.button_red
                    favClicked3 = True
                    btnSaveFavorite.Enabled = True
                    btnSaveFavorite.ForeColor = Color.White
                    btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                End If
            Else
                uncheckOthers()
                RetrieveSettings(3)
                PictureBox12.Image = My.Resources.button_red
                favClicked3 = True
                btnSaveFavorite.Enabled = True
                btnSaveFavorite.ForeColor = Color.White
                btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
            End If
        Else
            PictureBox12.Image = My.Resources.button_grey
            favClicked3 = False
            btnSaveFavorite.Enabled = False
            btnSaveFavorite.ForeColor = Color.Black
            btnSaveFavorite.BackColor = Color.LightGray
            clear()
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click, Label20.Click
        Dim selectIndex As Integer() = {cboName1.SelectedIndex, cboName2.SelectedIndex, cboName3.SelectedIndex, cboName4.SelectedIndex}

        If favClicked4 = False Then
            If selectIndex(0) <> -1 Or selectIndex(1) <> -1 Or selectIndex(2) <> -1 Or selectIndex(3) <> -1 Then
                If My.Settings.Favorite4 IsNot Nothing Then
                    frmMsgBox.title = "替换后勤"
                    frmMsgBox.content = "当前的后勤列表将替换成" & vbNewLine & "[" & Label18.Text & "]的后勤列表，是否替换？" & vbNewLine & "(所有计时将会重置)"
                    frmMsgBox.btnYesString = "替换"
                    frmMsgBox.btnNoString = "保留"
                    frmMsgBox.msgType = "YesNo"

                    Dim dlg As DialogResult = frmMsgBox.ShowDialog()
                    uncheckOthers()
                    If dlg = DialogResult.Yes Then
                        uncheckOthers()
                        RetrieveSettings(4)
                        PictureBox13.Image = My.Resources.button_red
                        favClicked4 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    ElseIf dlg = DialogResult.No Then
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                        PictureBox13.Image = My.Resources.button_red
                        favClicked4 = True
                        btnSaveFavorite.Enabled = True
                        btnSaveFavorite.ForeColor = Color.White
                        btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                    Else
                        uncheckOthers()
                        cboName1.SelectedIndex = selectIndex(0)
                        cboName2.SelectedIndex = selectIndex(1)
                        cboName3.SelectedIndex = selectIndex(2)
                        cboName4.SelectedIndex = selectIndex(3)
                    End If
                Else
                    uncheckOthers()
                    cboName1.SelectedIndex = selectIndex(0)
                    cboName2.SelectedIndex = selectIndex(1)
                    cboName3.SelectedIndex = selectIndex(2)
                    cboName4.SelectedIndex = selectIndex(3)
                    PictureBox13.Image = My.Resources.button_red
                    favClicked4 = True
                    btnSaveFavorite.Enabled = True
                    btnSaveFavorite.ForeColor = Color.White
                    btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
                End If
            Else
                uncheckOthers()
                RetrieveSettings(4)
                PictureBox13.Image = My.Resources.button_red
                favClicked4 = True
                btnSaveFavorite.Enabled = True
                btnSaveFavorite.ForeColor = Color.White
                btnSaveFavorite.BackColor = Color.FromArgb(66, 66, 66)
            End If
        Else
            PictureBox13.Image = My.Resources.button_grey
            favClicked4 = False
            btnSaveFavorite.Enabled = False
            btnSaveFavorite.ForeColor = Color.Black
            btnSaveFavorite.BackColor = Color.LightGray
            clear()
        End If
    End Sub

    ' Combo box event
    Private Sub cboName1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName1.SelectedIndexChanged
        Timer1.Stop()
        picStart1.Visible = True
        picStart1.Enabled = True
        picReset1.Visible = False
        picReset1.Enabled = False
        picEdit1.Image = My.Resources.edit_grey
        picEdit1.Enabled = False

        If cboName1.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName1.SelectedItem.ToString)

            picEdit1.Image = My.Resources.edit
            picEdit1.Enabled = True
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
        picEdit2.Image = My.Resources.edit_grey
        picEdit2.Enabled = False

        If cboName2.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName2.SelectedItem.ToString)

            picEdit2.Image = My.Resources.edit
            picEdit2.Enabled = True
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
        picEdit3.Image = My.Resources.edit_grey
        picEdit3.Enabled = False

        If cboName3.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName3.SelectedItem.ToString)

            picEdit3.Image = My.Resources.edit
            picEdit3.Enabled = True
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
        picEdit4.Image = My.Resources.edit_grey
        picEdit4.Enabled = False

        If cboName4.SelectedIndex <> -1 Then
            Dim logistic As LogisticSupport = getLogistic(cboName4.SelectedItem.ToString)


            picEdit4.Image = My.Resources.edit
            picEdit4.Enabled = True
            lblTime4.Text = logistic.getHour.ToString("D2") & ":" & logistic.getMinute.ToString("D2") & ":00"
            lblHour4.Text = logistic.getTime().ToString
        End If
    End Sub

    ' Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        currentTime1 = ts.ToString("hh\:mm\:ss")

        If lblTime1.Text = "00:" + My.Settings.BeforeMinute.ToString("D2") + ":" + My.Settings.BeforeSecond.ToString("D2") And notified1 = False Then
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

            If My.Settings.TopMost Then
                If WindowState = FormWindowState.Minimized Then
                    WindowState = FormWindowState.Normal
                ElseIf hidden = True Then
                    NotifyIcon5_DoubleClick(Nothing, Nothing)
                ElseIf WindowState = FormWindowState.Normal Then
                    TopMost = True
                    Threading.Thread.Sleep(10)
                    TopMost = False
                End If
            End If

            If My.Settings.AutoRestart Then
                picStart1_Click(Nothing, Nothing)
            End If
        End If
        updateNotifyIconText()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim ts As TimeSpan = TargetDT2.Subtract(DateTime.Now)
        currentTime2 = ts.ToString("hh\:mm\:ss")

        If lblTime2.Text = "00:" + My.Settings.BeforeMinute.ToString("D2") + ":" + My.Settings.BeforeSecond.ToString("D2") And notified2 = False Then
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

            If My.Settings.TopMost Then
                If WindowState = FormWindowState.Minimized Then
                    WindowState = FormWindowState.Normal
                ElseIf hidden = True Then
                    NotifyIcon5_DoubleClick(Nothing, Nothing)
                ElseIf WindowState = FormWindowState.Normal Then
                    TopMost = True
                    Threading.Thread.Sleep(10)
                    TopMost = False
                End If
            End If

            If My.Settings.AutoRestart Then
                picStart2_Click(Nothing, Nothing)
            End If
        End If
        updateNotifyIconText()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim ts As TimeSpan = TargetDT3.Subtract(DateTime.Now)
        currentTime3 = ts.ToString("hh\:mm\:ss")

        If lblTime3.Text = "00:" + My.Settings.BeforeMinute.ToString("D2") + ":" + My.Settings.BeforeSecond.ToString("D2") And notified3 = False Then
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

            If My.Settings.TopMost Then
                If WindowState = FormWindowState.Minimized Then
                    WindowState = FormWindowState.Normal
                ElseIf hidden = True Then
                    NotifyIcon5_DoubleClick(Nothing, Nothing)
                ElseIf WindowState = FormWindowState.Normal Then
                    TopMost = True
                    Threading.Thread.Sleep(10)
                    TopMost = False
                End If
            End If

            If My.Settings.AutoRestart Then
                picStart3_Click(Nothing, Nothing)
            End If
        End If
        updateNotifyIconText()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim ts As TimeSpan = TargetDT4.Subtract(DateTime.Now)
        currentTime4 = ts.ToString("hh\:mm\:ss")

        If lblTime4.Text = "00:" + My.Settings.BeforeMinute.ToString("D2") + ":" + My.Settings.BeforeSecond.ToString("D2") And notified4 = False Then
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

            If My.Settings.TopMost Then
                If WindowState = FormWindowState.Minimized Then
                    WindowState = FormWindowState.Normal
                ElseIf hidden = True Then
                    NotifyIcon5_DoubleClick(Nothing, Nothing)
                ElseIf WindowState = FormWindowState.Normal Then
                    TopMost = True
                    Threading.Thread.Sleep(10)
                    TopMost = False
                End If
            End If

            If My.Settings.AutoRestart Then
                picStart4_Click(Nothing, Nothing)
            End If
        End If
        updateNotifyIconText()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim ts As TimeSpan = TargetDT5.Subtract(DateTime.Now)
        currenttime5 = ts.ToString("hh\:mm\:ss")

        If lblTime5.Text = "00:" + My.Settings.BeforeMinute.ToString("D2") + ":" + My.Settings.BeforeSecond.ToString("D2") And notified5 = False Then
            Notify(5, "")
            notified5 = True
        End If

        If ts.TotalMilliseconds > 0 Then
            lblTime5.Text = currenttime5
        Else
            lblTime5.Text = ("00:00:00")
            Timer5.Stop()
            currenttime5 = ("00:00:00")
            picReset5_Click(Nothing, Nothing)

            If My.Settings.TopMost Then
                If WindowState = FormWindowState.Minimized Then
                    WindowState = FormWindowState.Normal
                ElseIf hidden = True Then
                    NotifyIcon5_DoubleClick(Nothing, Nothing)
                ElseIf WindowState = FormWindowState.Normal Then
                    TopMost = True
                    Threading.Thread.Sleep(10)
                    TopMost = False
                End If
            End If
        End If
        updateNotifyIconText()
    End Sub

    ' Start and Stop button click event
    Private Sub picStart1_Click(sender As Object, e As EventArgs) Handles picStart1.Click
        notified1 = False
        If cboName1.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour1.Text))
            TargetDT1 = DateTime.Now.Add(CountDownFrom)
            Timer1.Interval = 1
            Timer1.Start()

            picStart1.Visible = False
            picStart1.Enabled = False
            picReset1.Visible = True
            picReset1.Enabled = True
            picEdit1.Image = My.Resources.edit_grey
            picEdit1.Enabled = False
        End If
    End Sub

    Private Sub picStart2_Click(sender As Object, e As EventArgs) Handles picStart2.Click
        notified2 = False
        If cboName2.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour2.Text))
            TargetDT2 = DateTime.Now.Add(CountDownFrom)
            Timer2.Interval = 1
            Timer2.Start()

            picStart2.Visible = False
            picStart2.Enabled = False
            picReset2.Visible = True
            picReset2.Enabled = True
            picEdit2.Image = My.Resources.edit_grey
            picEdit2.Enabled = False
        End If
    End Sub

    Private Sub picStart3_Click(sender As Object, e As EventArgs) Handles picStart3.Click
        notified3 = False
        If cboName3.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour3.Text))
            TargetDT3 = DateTime.Now.Add(CountDownFrom)
            Timer3.Interval = 1
            Timer3.Start()

            picStart3.Visible = False
            picStart3.Enabled = False
            picReset3.Visible = True
            picReset3.Enabled = True
            picEdit3.Image = My.Resources.edit_grey
            picEdit3.Enabled = False
        End If
    End Sub

    Private Sub picStart4_Click(sender As Object, e As EventArgs) Handles picStart4.Click
        notified4 = False
        If cboName4.SelectedIndex <> -1 Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour4.Text))
            TargetDT4 = DateTime.Now.Add(CountDownFrom)
            Timer4.Interval = 1
            Timer4.Start()

            picStart4.Visible = False
            picStart4.Enabled = False
            picReset4.Visible = True
            picReset4.Enabled = True
            picEdit4.Image = My.Resources.edit_grey
            picEdit4.Enabled = False
        End If
    End Sub

    Private Sub picStart5_Click(sender As Object, e As EventArgs) Handles picStart5.Click
        notified5 = False
        If lblTime5.Text <> "00:00:00" Then
            Dim CountDownFrom As TimeSpan = TimeSpan.FromHours(Double.Parse(lblHour5.Text))
            TargetDT5 = DateTime.Now.Add(CountDownFrom)
            Timer5.Interval = 1
            Timer5.Start()

            picStart5.Visible = False
            picStart5.Enabled = False
            picReset5.Visible = True
            picReset5.Enabled = True
            picEdit5.Image = My.Resources.edit_grey
            picEdit5.Enabled = False
        End If
    End Sub

    Private Sub picReset1_Click(sender As Object, e As EventArgs) Handles picReset1.Click
        Timer1.Stop()
        picEdit1.Image = My.Resources.edit
        picEdit1.Enabled = True
        cboName1_SelectedIndexChanged(Nothing, Nothing)
        updateNotifyIconText()
    End Sub

    Private Sub picReset2_Click(sender As Object, e As EventArgs) Handles picReset2.Click
        Timer2.Stop()
        picEdit2.Image = My.Resources.edit
        picEdit2.Enabled = True
        cboName2_SelectedIndexChanged(Nothing, Nothing)
        updateNotifyIconText()
    End Sub

    Private Sub picReset3_Click(sender As Object, e As EventArgs) Handles picReset3.Click
        Timer3.Stop()
        picEdit3.Image = My.Resources.edit
        picEdit3.Enabled = True
        cboName3_SelectedIndexChanged(Nothing, Nothing)
        updateNotifyIconText()
    End Sub

    Private Sub picReset4_Click(sender As Object, e As EventArgs) Handles picReset4.Click
        Timer4.Stop()
        picEdit4.Image = My.Resources.edit
        picEdit4.Enabled = True
        cboName4_SelectedIndexChanged(Nothing, Nothing)
        updateNotifyIconText()
    End Sub

    Private Sub picReset5_Click(sender As Object, e As EventArgs) Handles picReset5.Click
        Timer5.Stop()
        picStart5.Visible = True
        picStart5.Enabled = True
        picReset5.Visible = False
        picReset5.Enabled = False
        picEdit5.Image = My.Resources.edit
        picEdit5.Enabled = True
        lblTime5.Text = otherTimer
        updateNotifyIconText()
    End Sub

    ' Notification
    Private Sub Notify(index As Integer, name As String)
        frmNotification.counter = 0
        frmNotification.Opacity = 1
        frmNotification.sendNotification(index, name)
        frmNotification.Show()
    End Sub

    Public Sub NotifyIcon5_DoubleClick(sender As Object, e As EventArgs) Handles ntf1.DoubleClick, ctxShow.Click
        Visible = True
        Opacity = 1
        ShowInTaskbar = True
        ntf1.Visible = True
        ntf1.Icon = Nothing
        hidden = False
        My.Computer.Audio.Play(My.Resources.sound_maximize, AudioPlayMode.Background)
    End Sub

    'Time edit button
    Private Sub picEdit1_Click(sender As Object, e As EventArgs) Handles picEdit1.Click
        frmEditTime.setTime(1, lblTime1.Text)
        frmEditTime.ShowDialog()
    End Sub

    Private Sub picEdit2_Click(sender As Object, e As EventArgs) Handles picEdit2.Click
        frmEditTime.setTime(2, lblTime2.Text)
        frmEditTime.ShowDialog()
    End Sub

    Private Sub picEdit3_Click(sender As Object, e As EventArgs) Handles picEdit3.Click
        frmEditTime.setTime(3, lblTime3.Text)
        frmEditTime.ShowDialog()
    End Sub

    Private Sub picEdit4_Click(sender As Object, e As EventArgs) Handles picEdit4.Click
        frmEditTime.setTime(4, lblTime4.Text)
        frmEditTime.ShowDialog()
    End Sub

    Private Sub picEdit5_Click(sender As Object, e As EventArgs) Handles picEdit5.Click
        frmEditTime.setTime(5, lblTime5.Text)
        frmEditTime.ShowDialog()
        otherTimer = lblTime5.Text
    End Sub

    ' Others function
    Public Sub RetrieveSettings(index As Integer)
        Dim settings As StringCollection = Nothing

        If index = 0 Then
            If My.Settings.Previous IsNot Nothing Then
                settings = My.Settings.Previous
            End If
            retrieveFavName(index)

            If My.Settings.Image <> "" Then
                picDoll.Image = GetImageFromString(My.Settings.Image)
            End If

            If My.Settings.OtherTimerHour <> "" Then
                lblHour5.Text = My.Settings.OtherTimerHour
            End If

            If My.Settings.OtherTimerTime <> "" Then
                lblTime5.Text = My.Settings.OtherTimerTime
                otherTimer = lblTime5.Text
            End If
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
        ElseIf index = 5 Then
            If My.Settings.Image <> "" Then
                picDoll.Image = GetImageFromString(My.Settings.Image)
            End If
        Else
            frmMsgBox.title = "错误"
            frmMsgBox.content = "获取信息失败。"
            frmMsgBox.btnYesString = "确定"
            frmMsgBox.msgType = "Yes"
            frmMsgBox.ShowDialog()
        End If

        If index <> 5 Then
            ' set value into all cbo
            If settings IsNot Nothing Then
                If index = 0 Then
                    If settings(0) <> "" Then
                        cboName1.Text = settings(0)
                    Else
                        cboName1.SelectedIndex = -1
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

            cboName1_SelectedIndexChanged(Nothing, Nothing)
            cboName2_SelectedIndexChanged(Nothing, Nothing)
            cboName3_SelectedIndexChanged(Nothing, Nothing)
            cboName4_SelectedIndexChanged(Nothing, Nothing)
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

    Private Sub uncheckOthers()
        If favClicked1 Then
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
        If favClicked1 = True Then
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf favClicked2 = True Then
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf favClicked3 = True Then
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked4 = False
            PictureBox13.Image = My.Resources.button_grey
        ElseIf favClicked4 = True Then
            favClicked1 = False
            PictureBox10.Image = My.Resources.button_grey
            favClicked2 = False
            PictureBox11.Image = My.Resources.button_grey
            favClicked3 = False
            PictureBox12.Image = My.Resources.button_grey
        Else
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

    Private Sub updateNotifyIconText()
        ntf1.Text =
        "#1 " & If(currentTime1 = "00:00:00", "已完成", currentTime1) & vbNewLine &
        "#2 " & If(currentTime2 = "00:00:00", "已完成", currentTime2) & vbNewLine &
        "#3 " & If(currentTime3 = "00:00:00", "已完成", currentTime3) & vbNewLine &
        "#4 " & If(currentTime4 = "00:00:00", "已完成", currentTime4)
    End Sub

    Private Sub picEdit_MouseHover(sender As Object, e As EventArgs) Handles picEdit4.MouseHover, picEdit3.MouseHover, picEdit2.MouseHover, picEdit1.MouseHover, picEdit5.MouseHover
        Dim tt As New ToolTip()
        tt.SetToolTip(picEdit1, "编辑时间")
        tt.SetToolTip(picEdit2, "编辑时间")
        tt.SetToolTip(picEdit3, "编辑时间")
        tt.SetToolTip(picEdit4, "编辑时间")
    End Sub

    Private Function changeLogisticList() As Boolean
        Dim change As Boolean = False

        If Timer1.Enabled = True Or Timer2.Enabled = True Or Timer3.Enabled = True Or Timer4.Enabled = True Then
            frmMsgBox.title = "提示"
            frmMsgBox.content = "切换后勤列表将会清除目前正在计时的后勤。" & vbNewLine & "是否切换？"
            frmMsgBox.btnYesString = "切换"
            frmMsgBox.btnNoString = "取消"
            frmMsgBox.msgType = "YesNo"

            If frmMsgBox.ShowDialog() = DialogResult.Yes Then
                change = True
                picReset1_Click(Nothing, Nothing)
                picReset2_Click(Nothing, Nothing)
                picReset3_Click(Nothing, Nothing)
                picReset4_Click(Nothing, Nothing)
            End If
        Else
            change = True
        End If

        Return change
    End Function

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
            My.Settings.Previous = New StringCollection

            My.Settings.Previous.Clear()
            My.Settings.Previous.Add(logistic1)
            My.Settings.Previous.Add(logistic2)
            My.Settings.Previous.Add(logistic3)
            My.Settings.Previous.Add(logistic4)

            My.Settings.OtherTimerHour = lblHour5.Text
            My.Settings.OtherTimerTime = otherTimer
        ElseIf index = 1 Then
            My.Settings.Favorite1 = New StringCollection

            My.Settings.Favorite1.Clear()
            My.Settings.Favorite1.Add(favName)
            My.Settings.Favorite1.Add(logistic1)
            My.Settings.Favorite1.Add(logistic2)
            My.Settings.Favorite1.Add(logistic3)
            My.Settings.Favorite1.Add(logistic4)
        ElseIf index = 2 Then
            My.Settings.Favorite2 = New StringCollection

            My.Settings.Favorite2.Clear()
            My.Settings.Favorite2.Add(favName)
            My.Settings.Favorite2.Add(logistic1)
            My.Settings.Favorite2.Add(logistic2)
            My.Settings.Favorite2.Add(logistic3)
            My.Settings.Favorite2.Add(logistic4)
        ElseIf index = 3 Then
            My.Settings.Favorite3 = New StringCollection

            My.Settings.Favorite3.Clear()
            My.Settings.Favorite3.Add(favName)
            My.Settings.Favorite3.Add(logistic1)
            My.Settings.Favorite3.Add(logistic2)
            My.Settings.Favorite3.Add(logistic3)
            My.Settings.Favorite3.Add(logistic4)
        ElseIf index = 4 Then
            My.Settings.Favorite4 = New StringCollection

            My.Settings.Favorite4.Clear()
            My.Settings.Favorite4.Add(favName)
            My.Settings.Favorite4.Add(logistic1)
            My.Settings.Favorite4.Add(logistic2)
            My.Settings.Favorite4.Add(logistic3)
            My.Settings.Favorite4.Add(logistic4)
        End If

        My.Settings.Save()
    End Sub

    ' Top Panel Settings
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub DragForm(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.Style = &HA0000
            Return CP
        End Get
    End Property

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub picExit_MouseMove(sender As Object, e As MouseEventArgs) Handles picExit.MouseMove
        picExit.BackColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Sub picExit_MouseLeave(sender As Object, e As EventArgs) Handles picExit.MouseLeave
        picExit.BackColor = Color.FromArgb(66, 66, 66)
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picMinimize_MouseMove(sender As Object, e As MouseEventArgs) Handles picMinimize.MouseMove
        picMinimize.BackColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Sub picMinimize_MouseLeave(sender As Object, e As EventArgs) Handles picMinimize.MouseLeave
        picMinimize.BackColor = Color.FromArgb(66, 66, 66)
    End Sub

    Private Sub lblLogisticView_Click(sender As Object, e As EventArgs) Handles lblLogisticView.Click
        frmLogisticView.WindowState = FormWindowState.Minimized
        frmLogisticView.Show()
        frmLogisticView.WindowState = FormWindowState.Normal
    End Sub

    Private Sub lblSetting_Click(sender As Object, e As EventArgs) Handles lblSetting.Click
        Dim dlgResult As DialogResult = frmSettings.ShowDialog()
    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        FrmAbout.WindowState = FormWindowState.Minimized
        FrmAbout.Show()
        FrmAbout.WindowState = FormWindowState.Normal
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        frmMsgBox.title = "关闭提示"
        frmMsgBox.content = "确定要退出吗？"
        frmMsgBox.btnYesString = "确定"
        frmMsgBox.btnNoString = "取消"
        frmMsgBox.msgType = "YesNo"

        Dim dlgResult As DialogResult = frmMsgBox.ShowDialog

        If dlgResult = DialogResult.Yes Then
            saveLogistic(0)
            End
        End If
    End Sub

    Private Sub lblLogisticView_MouseMove() Handles lblLogisticView.MouseMove
        lblLogisticView.Font = New Font(lblLogisticView.Font, FontStyle.Underline Or FontStyle.Bold)
    End Sub

    Private Sub lblSetting_MouseMove() Handles lblSetting.MouseMove
        lblSetting.Font = New Font(lblSetting.Font, FontStyle.Underline Or FontStyle.Bold)
    End Sub

    Private Sub lblLAbout_MouseMove() Handles lblAbout.MouseMove
        lblAbout.Font = New Font(lblAbout.Font, FontStyle.Underline Or FontStyle.Bold)
    End Sub

    Private Sub lblExit_MouseMove() Handles lblExit.MouseMove
        lblExit.Font = New Font(lblExit.Font, FontStyle.Underline Or FontStyle.Bold)
    End Sub

    Private Sub lblLogisticView_MouseLeave(sender As Object, e As EventArgs) Handles lblLogisticView.MouseLeave
        lblLogisticView.Font = New Font(lblLogisticView.Font, FontStyle.Bold)
    End Sub

    Private Sub lblSetting_MouseLeave(sender As Object, e As EventArgs) Handles lblSetting.MouseLeave
        lblSetting.Font = New Font(lblSetting.Font, FontStyle.Bold)
    End Sub

    Private Sub lblAbout_MouseLeave(sender As Object, e As EventArgs) Handles lblAbout.MouseLeave
        lblAbout.Font = New Font(lblAbout.Font, FontStyle.Bold)
    End Sub

    Private Sub lblExit_MouseLeave(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        lblExit.Font = New Font(lblExit.Font, FontStyle.Bold)
    End Sub

    Private Sub btnLogFilter_Click(sender As Object, e As EventArgs) Handles btnLogFilter.Click
        frmLogisticSetting.WindowState = FormWindowState.Minimized
        frmLogisticSetting.Show()
        frmLogisticSetting.WindowState = FormWindowState.Normal
    End Sub

    Public Shared Function GetImageFromString(base64String As String) As Image
        If String.IsNullOrWhiteSpace(base64String) Then Return Nothing
        Dim buffer As Byte() = Convert.FromBase64String(base64String)
        If buffer IsNot Nothing Then
            Dim ic As New ImageConverter
            Return TryCast(ic.ConvertFrom(buffer), Image)
        Else
            Return Nothing
        End If
    End Function
End Class
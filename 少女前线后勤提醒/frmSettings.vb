Imports System.Runtime.InteropServices

Public Class frmSettings
    Dim imgStr As String

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon

        cboMinute.Items.Clear()
        cboSecond.Items.Clear()

        For i = 0 To 10
            cboMinute.Items.Add(i)
        Next i

        For i = 0 To 59
            cboSecond.Items.Add(i)
        Next

        lblFileName.Text = ""
        btnChange.Text = "导入"
        btnChange.ForeColor = Color.White
        btnChange.BackColor = Color.FromArgb(66, 66, 66)
        insertCbo()

        retrieveSettings()
    End Sub

    Private Sub retrieveSettings()
        If My.Settings.ExitSettings = True Then
            radExit.Checked = True
        Else
            radMinimize.Checked = True
        End If

        If My.Settings.TopMost Then
            radTopMost.Checked = True
        Else
            radPopup.Checked = True
        End If

        If My.Settings.DontAskAgain Then
            radNoAsk.Checked = My.Settings.DontAskAgain
        Else
            radAsk.Checked = True
        End If

        If My.Settings.BeforeMinute <> Nothing Then
            Dim saved As Integer = My.Settings.BeforeMinute

            For i = 0 To cboMinute.Items.Count - 1
                If cboMinute.Items(i).ToString = saved.ToString Then
                    cboMinute.SelectedIndex = i
                End If
            Next i
        Else
            cboMinute.SelectedIndex = 0
        End If

        If My.Settings.BeforeSecond <> Nothing Then
            Dim saved As Integer = My.Settings.BeforeSecond

            For i = 0 To cboSecond.Items.Count - 1
                If cboSecond.Items(i).ToString = saved.ToString Then
                    cboSecond.SelectedIndex = i
                End If
            Next i
        Else
            cboSecond.SelectedIndex = 0
        End If

        If My.Settings.AutoRestart Then
            radAutoRes.Checked = True
        Else
            radNoRes.Checked = True
        End If

        cboNotification.SelectedIndex = My.Settings.NotificationSound
        If cboNotification.SelectedIndex = -1 Then
            chkCloseNotify.Checked = True
        End If
    End Sub

    Private Sub insertCbo()
        cboNotification.Items.Clear()
        cboNotification.Items.AddRange({"AK-12", "AN-94", "AR-15", "ART556", "C-MS", "G11", "G41", "HK416",
                                       "M4A1", "M4A1 Mod", "MK23", "S.A.T.8", "M4 SOPMOD II", "UMP45", "UMP9", "Vector",
                                       "WA2000", "XM8", "79式"， "卡尔卡诺M1891", "卡尔卡诺M1891-儿童节", "卡尔卡诺M91/38",
                                       "卡尔卡诺M91/38-儿童节", ".李_恩菲尔德-儿童节", "索米", "蝎式"})
    End Sub

    Private Sub chkCloseNotify_CheckedChanged(sender As Object, e As EventArgs) Handles chkCloseNotify.CheckedChanged
        If chkCloseNotify.Checked = True Then
            cboNotification.SelectedIndex = -1
            cboNotification.Enabled = False
            btnPlay.Enabled = False
        Else
            cboNotification.Enabled = True
            btnPlay.Enabled = True
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim sound() As IO.Stream = {My.Resources.AK12, My.Resources.AN94, My.Resources.AR15, My.Resources.ART556,
            My.Resources.CMS, My.Resources.G11, My.Resources.G41, My.Resources.HK416,
            My.Resources.M4A1, My.Resources.M4A1_MOD, My.Resources.MK23, My.Resources.SAT8,
            My.Resources.Sopmod, My.Resources.Ump45, My.Resources.Ump9, My.Resources.Vector,
            My.Resources.WA2000, My.Resources.XM8, My.Resources._79式, My.Resources.卡尔卡诺1891,
            My.Resources.卡尔卡诺1891_儿童节, My.Resources.卡尔卡诺1983, My.Resources.卡尔卡诺1938_儿童节, My.Resources.李_恩菲尔德_儿童节,
            My.Resources.索米, My.Resources.蝎式}

        If cboNotification.SelectedIndex <> -1 Then
            My.Computer.Audio.Play(sound(cboNotification.SelectedIndex), AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.BeforeMinute = Integer.Parse(cboMinute.SelectedItem.ToString)
        My.Settings.BeforeSecond = Integer.Parse(cboSecond.SelectedItem.ToString)
        My.Settings.ExitSettings = radExit.Checked
        My.Settings.DontAskAgain = radNoAsk.Checked
        My.Settings.TopMost = radTopMost.Checked
        My.Settings.AutoRestart = radAutoRes.Checked
        If imgStr <> "" Then
            My.Settings.Image = imgStr
        End If
        My.Settings.NotificationSound = 0
        My.Settings.NotificationSound = cboNotification.SelectedIndex
        My.Settings.Save()

        frmMsgBox.title = "已保存"
        frmMsgBox.content = "设置保存成功。"
        frmMsgBox.btnYesString = "确定"
        frmMsgBox.msgType = "Yes"
        frmMsgBox.ShowDialog()
        Me.Close()
        frmMain.RetrieveSettings(5)
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

    Private Sub DragForm(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub picExit_MouseMove(sender As Object, e As MouseEventArgs) Handles picExit.MouseMove
        picExit.BackColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Sub picExit_MouseLeave(sender As Object, e As EventArgs) Handles picExit.MouseLeave
        picExit.BackColor = Color.FromArgb(66, 66, 66)
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If btnChange.Text = "撤销" Then
            imgStr = ""
            lblFileName.Text = ""
            btnChange.Text = "导入"
            btnChange.ForeColor = Color.White
            btnChange.BackColor = Color.FromArgb(66, 66, 66)
        Else
            Dim ofd As New OpenFileDialog
            ofd.Filter = "Image Files(jpeg, jpg, png, gif)|*.jpeg;*.jpg;*.png;*.gif"

            If ofd.ShowDialog = DialogResult.OK Then
                Try
                    imgStr = GetStringFromImage(Image.FromFile(ofd.FileName))
                    Console.WriteLine(imgStr)
                    lblFileName.Text = ofd.SafeFileName
                    btnChange.Text = "撤销"
                    btnChange.ForeColor = Color.Black
                    btnChange.BackColor = Color.FromArgb(255, 187, 0)
                Catch
                    frmMsgBox.title = "错误"
                    frmMsgBox.content = "获取图片失败。" & vbNewLine & "请确保图片格式正确。"
                    frmMsgBox.btnYesString = "确定"
                    frmMsgBox.msgType = "Yes"
                    frmMsgBox.ShowDialog()
                End Try
            End If
        End If

    End Sub

    Public Shared Function GetStringFromImage(image As Image) As String
        If image IsNot Nothing Then
            Dim ic As New ImageConverter()
            Dim buffer As Byte() = DirectCast(ic.ConvertTo(image, GetType(Byte())), Byte())
            Return Convert.ToBase64String(buffer, Base64FormattingOptions.InsertLineBreaks)
        Else
            Return Nothing
        End If
    End Function

End Class
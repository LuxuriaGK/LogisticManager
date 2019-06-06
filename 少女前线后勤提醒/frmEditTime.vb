Imports System.Runtime.InteropServices

Public Class frmEditTime

    Dim hour As Integer
    Dim min As Integer
    Dim sec As Integer
    Dim index As Integer
    Dim selectedIndex As Integer

    Private Sub frmEditTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon
        txtHour.Text = hour.ToString
        txtMin.Text = min.ToString
        txtSec.Text = sec.ToString
    End Sub

    Public Sub setTime(_index As Integer, time As String)
        hour = Integer.Parse(time.Substring(0, 2))
        min = Integer.Parse(time.Substring(3, 2))
        sec = Integer.Parse(time.Substring(6, 2))
        index = _index
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Integer.TryParse(txtHour.Text, vbInteger) = False Or
           Integer.TryParse(txtMin.Text, vbInteger) = False Or
           Integer.TryParse(txtSec.Text, vbInteger) = False Then

            frmMsgBox.title = "错误"
            frmMsgBox.content = "请输入正确的格式。"
            frmMsgBox.btnYesString = "确定"
            frmMsgBox.msgType = "Yes"
            frmMsgBox.ShowDialog()
        Else
            If Integer.Parse(txtMin.Text) >= 60 Then
                frmMsgBox.title = "错误"
                frmMsgBox.content = "分钟不可大于59。"
                frmMsgBox.btnYesString = "确定"
                frmMsgBox.msgType = "Yes"
                frmMsgBox.ShowDialog()
            Else
                If Integer.Parse(txtSec.Text) >= 60 Then
                    frmMsgBox.title = "错误"
                    frmMsgBox.content = "秒数不可大于59。"
                    frmMsgBox.btnYesString = "确定"
                    frmMsgBox.msgType = "Yes"
                    frmMsgBox.ShowDialog()
                Else
                    Dim time As Double = Integer.Parse(txtHour.Text) + (Integer.Parse(txtMin.Text) / 60) + (Integer.Parse(txtSec.Text) / 60 / 60)
                    Dim logTime As Double = hour + (min / 60) + (sec / 60 / 60)

                    If index = 5 Then
                        frmMain.lblHour5.Text = time.ToString
                        frmMain.lblTime5.Text = Integer.Parse(txtHour.Text).ToString("D2") & ":" &
                            Integer.Parse(txtMin.Text).ToString("D2") & ":" &
                            Integer.Parse(txtSec.Text).ToString("D2")
                        Me.Close()
                    Else
                        If time > logTime Then
                            frmMsgBox.title = "错误"
                            frmMsgBox.content = "后勤时长必须小于该后勤的总时长。"
                            frmMsgBox.btnYesString = "确定"
                            frmMsgBox.msgType = "Yes"
                            frmMsgBox.ShowDialog()
                        Else
                            If index = 1 Then
                                frmMain.lblHour1.Text = time.ToString
                                frmMain.lblTime1.Text = Integer.Parse(txtHour.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtMin.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtSec.Text).ToString("D2")
                            ElseIf index = 2 Then
                                frmMain.lblHour2.Text = time.ToString
                                frmMain.lblTime2.Text = Integer.Parse(txtHour.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtMin.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtSec.Text).ToString("D2")
                            ElseIf index = 3 Then
                                frmMain.lblHour3.Text = time.ToString
                                frmMain.lblTime3.Text = Integer.Parse(txtHour.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtMin.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtSec.Text).ToString("D2")
                            ElseIf index = 4 Then
                                frmMain.lblHour4.Text = time.ToString
                                frmMain.lblTime4.Text = Integer.Parse(txtHour.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtMin.Text).ToString("D2") & ":" &
                                    Integer.Parse(txtSec.Text).ToString("D2")
                            End If
                            Me.Close()
                        End If
                    End If
                End If
            End If

        End If
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

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub picExit_MouseMove(sender As Object, e As MouseEventArgs) Handles picExit.MouseMove
        picExit.BackColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Sub picExit_MouseLeave(sender As Object, e As EventArgs) Handles picExit.MouseLeave
        picExit.BackColor = Color.FromArgb(66, 66, 66)
    End Sub

End Class
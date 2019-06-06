Imports System.Runtime.InteropServices

Public Class frmFilteredLogistic

    Dim list As List(Of LogisticSupport)
    Dim selectLogistic As New List(Of LogisticSupport)

    Public Sub setList(_list As List(Of LogisticSupport))
        list = New List(Of LogisticSupport)
        list = _list
    End Sub

    Private Sub showList()
        dgvLogistic.Rows.Clear()
        Dim matches() As Control

        For i = 0 To list.Count - 1
            If list IsNot Nothing Then
                matches = Me.Controls.Find("CheckBox" & i, True)
                If matches.Length > 0 AndAlso TypeOf matches(0) Is CheckBox Then
                    Dim checkbox As CheckBox = DirectCast(matches(0), CheckBox)
                    checkbox.Visible = True

                    If i Mod 2 = 0 Then
                        checkbox.BackColor = Color.White
                    Else
                        checkbox.BackColor = Color.LightGray
                    End If
                End If

                Dim calcResValue1 As Double = If((list(i).getManpower() / list(i).getTime) = 0, 0, (list(i).getManpower() / list(i).getTime))
                Dim calcResValue2 As Double = If((list(i).getAmmo() / list(i).getTime) = 0, 0, (list(i).getAmmo() / list(i).getTime))
                Dim calcResValue3 As Double = If((list(i).getRation() / list(i).getTime) = 0, 0, (list(i).getRation() / list(i).getTime))
                Dim calcResValue4 As Double = If((list(i).getPart() / list(i).getTime) = 0, 0, (list(i).getPart() / list(i).getTime))

                dgvLogistic.Rows.Add(list(i).getName,
                                     list(i).getHour.ToString("D2") & ":" & list(i).getMinute.ToString("D2"),
                                     Double.Parse(calcResValue1.ToString("N2")),
                                     Double.Parse(calcResValue2.ToString("N2")),
                                     Double.Parse(calcResValue3.ToString("N2")),
                                     Double.Parse(calcResValue4.ToString("N2")),
                                     getItems(i)(0),
                                     getItems(i)(1))
            End If
        Next
        styleRow()
    End Sub

    Private Function getItems(i As Integer) As String()
        Dim str As String() = {"", ""}

        If list(i).getDoll() = True Then
            str(0) = "人形契约"
        End If

        If list(i).getEquipment() = True Then
            If str(0) = "" Then
                str(0) = "装备契约"
            Else
                str(1) = "装备契约"
            End If
        End If

        If list(i).getProduction = True Then
            If str(0) = "" Then
                str(0) = "快速建造"
            Else
                str(1) = "快速建造"
            End If
        End If

        If list(i).getRestore() = True Then
            If str(0) = "" Then
                str(0) = "快速修复"
            Else
                str(1) = "快速修复"
            End If
        End If

        If list(i).getToken() = True Then
            If str(0) = "" Then
                str(0) = "采购币"
            Else
                str(1) = "采购币"
            End If
        End If

        Return str
    End Function

    Private Sub frmFilteredLogistic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showList()
        CheckBox0.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
    End Sub

    Private Sub styleRow()
        For i = 0 To dgvLogistic.Rows.Count - 1
            If i Mod 2 = 0 Then
                dgvLogistic.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                dgvLogistic.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next i

        dgvLogistic.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft YaHei", 11)
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox5.CheckedChanged, CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged, CheckBox0.CheckedChanged
        Dim matches() As Control
        Dim trueNo As Integer = 0

        For i = 0 To list.Count - 1
            matches = Me.Controls.Find("CheckBox" & i, True)
            If matches.Length > 0 AndAlso TypeOf matches(0) Is CheckBox Then
                Dim checkbox As CheckBox = DirectCast(matches(0), CheckBox)
                If checkbox.Checked = True Then
                    trueNo = trueNo + 1
                End If
            End If
        Next

        If trueNo > 4 Then
            Dim chk As CheckBox = DirectCast(sender, CheckBox)
            chk.Checked = False
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim matches() As Control
        selectLogistic.Clear()

        For i = 0 To list.Count - 1
            matches = Me.Controls.Find("CheckBox" & i, True)
            If matches.Length > 0 AndAlso TypeOf matches(0) Is CheckBox Then
                Dim checkbox As CheckBox = DirectCast(matches(0), CheckBox)
                If checkbox.Checked = True Then
                    selectLogistic.Add(list(i))
                End If
            End If
        Next

        If selectLogistic.Count <> 0 Then
            Me.Close()
            frmLogisticSetting.Close()

            frmMain.cboName1.SelectedIndex = -1
            frmMain.cboName2.SelectedIndex = -1
            frmMain.cboName3.SelectedIndex = -1
            frmMain.cboName4.SelectedIndex = -1

            For i = 0 To frmMain.cboName1.Items.Count - 1
                If frmMain.cboName1.Items(i).ToString = selectLogistic(0).getName Then
                    frmMain.cboName1.SelectedIndex = i
                End If

                If selectLogistic.Count >= 2 Then
                    If frmMain.cboName2.Items(i).ToString = selectLogistic(1).getName Then
                        frmMain.cboName2.SelectedIndex = i
                    End If

                    If selectLogistic.Count >= 3 Then
                        If frmMain.cboName3.Items(i).ToString = selectLogistic(2).getName Then
                            frmMain.cboName3.SelectedIndex = i
                        End If

                        If selectLogistic.Count = 4 Then
                            If frmMain.cboName4.Items(i).ToString = selectLogistic(3).getName Then
                                frmMain.cboName4.SelectedIndex = i
                            End If
                        End If
                    End If
                End If
            Next

            frmMsgBox.title = "提示"
            frmMsgBox.content = "已导出至当前后勤列表。"
            frmMsgBox.btnYesString = "确定"
            frmMsgBox.msgType = "Yes"
            frmMain.WindowState = FormWindowState.Minimized
            frmMain.Show()
            frmMain.WindowState = FormWindowState.Normal
            frmMsgBox.ShowDialog()
        Else
            frmMsgBox.title = "提示"
            frmMsgBox.content = "请选择需要导出的后勤。"
            frmMsgBox.btnYesString = "确定"
            frmMsgBox.msgType = "Yes"
            frmMsgBox.ShowDialog()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

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
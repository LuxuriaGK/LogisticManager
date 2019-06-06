Imports System.Runtime.InteropServices

Public Class frmLogisticView

    Dim arr_logistic As LogisticSupport()

    Private Sub frmLogisticView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arr_logistic = frmMain.arr_Logistic
        LogisticList()
        dgvLogistic.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft YaHei", 11.25)
        dgvLogistic.DefaultCellStyle.Font = New Font("Microsoft YaHei", 10.25)
        Icon = My.Resources.icon
    End Sub

    Private Sub LogisticList()
        dgvLogistic.Rows.Clear()

        dgvLogistic.ColumnCount = 8
        dgvLogistic.Columns(0).Name = "后勤"
        dgvLogistic.Columns(0).Width = 75
        dgvLogistic.Columns(1).Name = "任务时间"
        dgvLogistic.Columns(2).Name = "人力"
        dgvLogistic.Columns(3).Name = "弹药"
        dgvLogistic.Columns(4).Name = "口粮"
        dgvLogistic.Columns(5).Name = "零件"
        dgvLogistic.Columns(6).Name = "获得道具1"
        dgvLogistic.Columns(6).Width = 110
        dgvLogistic.Columns(7).Name = "获得道具2"
        dgvLogistic.Columns(7).Width = 110

        For i = 0 To arr_logistic.Count - 1
            If arr_logistic IsNot Nothing Then
                Dim rowData As String() = {
                arr_logistic(i).getName,
                arr_logistic(i).getHour.ToString("D2") & ":" & arr_logistic(i).getMinute.ToString("D2"),
                arr_logistic(i).getManpower().ToString,
                arr_logistic(i).getAmmo.ToString,
                arr_logistic(i).getRation.ToString,
                arr_logistic(i).getPart.ToString,
                getItems(i)(0),
                getItems(i)(1)
                }
                dgvLogistic.Rows.Add(rowData)
            End If
        Next

        dgvLogistic.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub LogisticPerHour()
        dgvLogistic.Rows.Clear()

        dgvLogistic.ColumnCount = 8
        dgvLogistic.Columns(0).Name = "后勤"
        dgvLogistic.Columns(0).Width = 75
        dgvLogistic.Columns(1).Name = "任务时间"
        dgvLogistic.Columns(2).Name = "人力/小时"
        dgvLogistic.Columns(3).Name = "弹药/小时"
        dgvLogistic.Columns(4).Name = "口粮/小时"
        dgvLogistic.Columns(5).Name = "零件/小时"
        dgvLogistic.Columns(6).Name = "获得道具1"
        dgvLogistic.Columns(6).Width = 110
        dgvLogistic.Columns(7).Name = "获得道具2"
        dgvLogistic.Columns(7).Width = 110

        For i = 0 To arr_logistic.Count - 1
            If arr_logistic IsNot Nothing Then
                Dim calcResValue1 As Double = If((arr_logistic(i).getManpower() / arr_logistic(i).getTime) = 0, 0, (arr_logistic(i).getManpower() / arr_logistic(i).getTime))
                Dim calcResValue2 As Double = If((arr_logistic(i).getAmmo() / arr_logistic(i).getTime) = 0, 0, (arr_logistic(i).getAmmo() / arr_logistic(i).getTime))
                Dim calcResValue3 As Double = If((arr_logistic(i).getRation() / arr_logistic(i).getTime) = 0, 0, (arr_logistic(i).getRation() / arr_logistic(i).getTime))
                Dim calcResValue4 As Double = If((arr_logistic(i).getPart() / arr_logistic(i).getTime) = 0, 0, (arr_logistic(i).getPart() / arr_logistic(i).getTime))

                dgvLogistic.Rows.Add(arr_logistic(i).getName,
                                     arr_logistic(i).getHour.ToString("D2") & ":" & arr_logistic(i).getMinute.ToString("D2"),
                                     Double.Parse(calcResValue1.ToString("N2")),
                                     Double.Parse(calcResValue2.ToString("N2")),
                                     Double.Parse(calcResValue3.ToString("N2")),
                                     Double.Parse(calcResValue4.ToString("N2")),
                                     getItems(i)(0),
                                     getItems(i)(1))
            End If
        Next

        dgvLogistic.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Function getItems(i As Integer) As String()
        Dim str As String() = {"", ""}

        If arr_logistic(i).getDoll() = True Then
            str(0) = "人形契约"
        End If

        If arr_logistic(i).getEquipment() = True Then
            If str(0) = "" Then
                str(0) = "装备契约"
            Else
                str(1) = "装备契约"
            End If
        End If

        If arr_logistic(i).getProduction = True Then
            If str(0) = "" Then
                str(0) = "快速建造"
            Else
                str(1) = "快速建造"
            End If
        End If

        If arr_logistic(i).getRestore() = True Then
            If str(0) = "" Then
                str(0) = "快速修复"
            Else
                str(1) = "快速修复"
            End If
        End If

        If arr_logistic(i).getToken() = True Then
            If str(0) = "" Then
                str(0) = "采购币"
            Else
                str(1) = "采购币"
            End If
        End If

        Return str
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            LogisticPerHour()
        Else
            LogisticList()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CheckBox1_CheckedChanged(Nothing, Nothing)
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

    Private Sub picMinimize_Click_1(sender As Object, e As EventArgs) Handles picMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picMinimize_MouseMove(sender As Object, e As MouseEventArgs) Handles picMinimize.MouseMove
        picMinimize.BackColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Sub picMinimize_MouseLeave(sender As Object, e As EventArgs) Handles picMinimize.MouseLeave
        picMinimize.BackColor = Color.FromArgb(66, 66, 66)
    End Sub

End Class
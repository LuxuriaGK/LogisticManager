Public Class frmLogisticView

    Dim arr_logistic As LogisticSupport()

    Private Sub frmLogisticView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arr_logistic = frmMain.arr_Logistic
        Icon = My.Resources.icon
        LogisticList()
    End Sub

    Private Sub LogisticList()
        dgvLogistic.Rows.Clear()

        dgvLogistic.ColumnCount = 8
        dgvLogistic.Columns(0).Name = "后勤"
        dgvLogistic.Columns(1).Name = "任务时间"
        dgvLogistic.Columns(2).Name = "人力"
        dgvLogistic.Columns(3).Name = "弹药"
        dgvLogistic.Columns(4).Name = "口粮"
        dgvLogistic.Columns(5).Name = "零件"
        dgvLogistic.Columns(6).Name = "获得道具1"
        dgvLogistic.Columns(7).Name = "获得道具2"

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
        dgvLogistic.Columns(1).Name = "任务时间"
        dgvLogistic.Columns(2).Name = "人力/小时"
        dgvLogistic.Columns(3).Name = "弹药/小时"
        dgvLogistic.Columns(4).Name = "口粮/小时"
        dgvLogistic.Columns(5).Name = "零件/小时"
        dgvLogistic.Columns(6).Name = "获得道具1"
        dgvLogistic.Columns(7).Name = "获得道具2"

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
End Class
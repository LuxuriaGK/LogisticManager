Public Class frmEditTime

    Dim hour As Integer
    Dim min As Integer
    Dim sec As Integer
    Dim index As Integer
    Dim selectedIndex As Integer

    Private Sub frmEditTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon
        setComboBox()
    End Sub

    Public Sub setTime(_index As Integer, _selectedIndex As Integer, time As String)
        hour = Integer.Parse(time.Substring(0, 2))
        min = Integer.Parse(time.Substring(3, 2))
        sec = Integer.Parse(time.Substring(6, 2))
        index = _index
        selectedIndex = _selectedIndex
    End Sub

    Private Sub setComboBox()
        cboHour.Items.Clear()
        cboMinute.Items.Clear()
        cboSecond.Items.Clear()

        If frmMain.arr_Logistic(selectedIndex).getHour > 0 Then
            For i = 0 To frmMain.arr_Logistic(selectedIndex).getHour
                cboHour.Items.Add(i)
                If i = hour Then
                    cboHour.SelectedIndex = i
                End If
            Next i

            For i = 0 To 59
                cboMinute.Items.Add(i)
                If i = min Then
                    cboMinute.SelectedIndex = i
                End If
            Next i

            For i = 0 To 59
                cboSecond.Items.Add(i)
                If i = sec Then
                    cboSecond.SelectedIndex = i
                End If
            Next i
        Else
            cboHour.Items.Add(0)
            cboHour.SelectedIndex = 0

            For i = 0 To min
                cboMinute.Items.Add(i)
                If i = min Then
                    cboMinute.SelectedIndex = i
                End If
            Next i

            For i = 0 To 59
                cboSecond.Items.Add(i)
                If i = sec Then
                    cboSecond.SelectedIndex = i
                End If
            Next i
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If cboHour.SelectedIndex = frmMain.arr_Logistic(selectedIndex).getHour And
            cboMinute.SelectedIndex > frmMain.arr_Logistic(selectedIndex).getMinute Then
            MessageBox.Show("设定的时间大于后勤时间", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If cboHour.SelectedIndex = frmMain.arr_Logistic(selectedIndex).getHour And cboMinute.SelectedIndex = frmMain.arr_Logistic(selectedIndex).getMinute And cboSecond.SelectedIndex <> -1 Then
                MessageBox.Show("设定的时间大于后勤时间", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                returnTime()
                Close()
            End If
        End If
    End Sub

    Private Sub returnTime()
        Dim time As Double = cboHour.SelectedIndex + (cboMinute.SelectedIndex / 60) + (cboSecond.SelectedIndex / 60 / 60)

        If index = 1 Then
            frmMain.lblTime1.Text = cboHour.SelectedIndex.ToString("D2") & ":" & cboMinute.SelectedIndex.ToString("D2") & ":" & cboSecond.SelectedIndex.ToString("D2")
            frmMain.lblHour1.Text = time.ToString
        ElseIf index = 2 Then
            frmMain.lblTime2.Text = cboHour.SelectedIndex.ToString("D2") & ":" & cboMinute.SelectedIndex.ToString("D2") & ":" & cboSecond.SelectedIndex.ToString("D2")
            frmMain.lblHour2.Text = time.ToString
        ElseIf index = 3 Then
            frmMain.lblTime3.Text = cboHour.SelectedIndex.ToString("D2") & ":" & cboMinute.SelectedIndex.ToString("D2") & ":" & cboSecond.SelectedIndex.ToString("D2")
            frmMain.lblHour3.Text = time.ToString
        ElseIf index = 4 Then
            frmMain.lblTime4.Text = cboHour.SelectedIndex.ToString("D2") & ":" & cboMinute.SelectedIndex.ToString("D2") & ":" & cboSecond.SelectedIndex.ToString("D2")
            frmMain.lblHour4.Text = time.ToString
        End If
    End Sub

End Class
Public Class frmSettings
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

        retrieveSettings()
    End Sub

    Private Sub retrieveSettings()
        If My.Settings.ExitSettings = True Then
            radExit.Checked = True
        Else
            radMinimize.Checked = True
        End If

        If My.Settings.Popup = False Then
            radPopup.Checked = True
        Else
            radTopMost.Checked = My.Settings.TopMost
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

        If My.Settings.AutoRestart = True Then
            radAutoRes.Checked = True
        Else
            radNoRes.Checked = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.BeforeMinute = Integer.Parse(cboMinute.SelectedItem.ToString)
        My.Settings.BeforeSecond = Integer.Parse(cboSecond.SelectedItem.ToString)
        My.Settings.ExitSettings = radExit.Checked
        If radPopup.Checked Then
            My.Settings.Popup = False
        Else
            My.Settings.Popup = true
        End If
        My.Settings.TopMost = radTopMost.Checked
        My.Settings.AutoRestart = radAutoRes.Checked
        My.Settings.Save()
        MessageBox.Show("设置保存成功。", "已保存", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
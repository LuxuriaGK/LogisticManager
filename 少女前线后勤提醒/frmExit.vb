Public Class frmExit
    Private Sub frmExit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon

        If My.Settings.ExitSettings <> Nothing Then
            If My.Settings.ExitSettings Then
                radExit.Checked = True
            Else
                radMinimize.Checked = True
            End If
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If radMinimize.Checked Then
            Me.DialogResult = DialogResult.Yes
        ElseIf radExit.checked Then
            Me.DialogResult = DialogResult.No
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

        My.Settings.DontAskAgain = chkDontAskAgain.Checked
        My.Settings.ExitSettings = radExit.Checked
        My.Settings.Save()
        Close()
    End Sub
End Class
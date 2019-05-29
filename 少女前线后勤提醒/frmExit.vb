Public Class frmExit
    Private Sub frmExit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If radMinimize.Checked Then
            Me.DialogResult = DialogResult.Yes
        ElseIf radExit.checked Then
            Me.DialogResult = DialogResult.No
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
        Close()
    End Sub
End Class
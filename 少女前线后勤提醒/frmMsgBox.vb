Public Class frmMsgBox

    Public content As String
    Public title As String
    Public btnYesString As String
    Public btnNoString As String

    Private Sub frmMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon
        Text = title
        lblContent.Text = content
        btnYes.Text = btnYesString
        btnNo.Text = btnNoString
    End Sub


    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Close()
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Close()
        Me.DialogResult = DialogResult.No
    End Sub

    Private Sub frmMsgBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class
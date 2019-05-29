Public Class frmFavoriteName

    Private favName As String

    Private Sub frmFavoriteName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        txtFavName.Text = favName
    End Sub

    Public Sub setFavoriteName(_favName As String)
        favName = _favName
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtFavName.Text) Then
            MessageBox.Show("名字不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            frmMain.setFavoriteName(txtFavName.Text)
            Me.DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
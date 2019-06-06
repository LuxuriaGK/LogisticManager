Imports System.Runtime.InteropServices

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
        ElseIf radExit.Checked Then
            Me.DialogResult = DialogResult.No
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

        My.Settings.DontAskAgain = chkDontAskAgain.Checked
        My.Settings.ExitSettings = radExit.Checked
        My.Settings.Save()
        Close()
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

End Class
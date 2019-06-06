Imports System.Runtime.InteropServices

Public Class frmMsgBox

    Public content As String
    Public title As String
    Public btnYesString As String
    Public btnNoString As String
    Public msgType As String

    Private Sub frmMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = title
        lblContent.Text = content
        btnYes.Text = btnYesString
        If msgType = "YesNo" Then
            btnNo.Text = btnNoString
            btnNo.Visible = True
        Else
            btnNo.Visible = False
        End If

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
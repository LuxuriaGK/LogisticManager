Public Class FrmAbout
    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = LinkLabel1.Text
        Process.Start(webAddress)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress As String = LinkLabel2.Text
        Process.Start(webAddress)
    End Sub

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon
        LinkLabel2.Text = "https://bbs.nga.cn/read.php?tid=17404670&_ff=-547859"
    End Sub
End Class
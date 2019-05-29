Public Class frmAnnounce
    Private Sub frmAnnounce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        InsertCbo()
        RetrieveSettings()
    End Sub

    Private Sub RetrieveSettings()
        If My.Settings.AnnounceBefore <> Nothing Then
            Dim saved As Integer = My.Settings.AnnounceBefore

            For i = 0 To cboMinute.Items.Count - 1
                If cboMinute.Items(i).ToString = saved.ToString Then
                    cboMinute.SelectedIndex = i
                End If
            Next i
        Else
            cboMinute.SelectedIndex = 0
        End If
    End Sub

    Private Sub InsertCbo()
        cboMinute.Items.Clear()

        For i = 0 To 10
            cboMinute.Items.Add(i)
        Next i
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.AnnounceBefore = Integer.Parse(cboMinute.SelectedItem.ToString)
        My.Settings.Save()
        Me.Close()
    End Sub
End Class
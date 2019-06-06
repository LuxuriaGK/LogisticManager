Imports System.Runtime.InteropServices

Public Class frmLogisticSetting

    Private logFilter As New LogisticFilter
    Private res1 As Boolean = False
    Private res2 As Boolean = False
    Private res3 As Boolean = False
    Private res4 As Boolean = False
    Private res5 As Boolean = False

    Private con1 As Boolean = False
    Private con2 As Boolean = False
    Private con3 As Boolean = False
    Private con4 As Boolean = False
    Private con5 As Boolean = False
    Private conNo As Integer = 0

    Private item1 As Integer = 0
    Private item2 As Integer = 0


    Private Sub frmLogisticSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim list As New List(Of LogisticSupport)
        list.Clear()

        If validateControl() Then
            list = logFilter.getList(Integer.Parse(txtManpower.Text), Integer.Parse(txtAmmo.Text),
            Integer.Parse(txtRation.Text), Integer.Parse(txtPart.Text),
            item1, item2, cboLevel.SelectedIndex,
            Double.Parse(txtStartTime.Text), Double.Parse(txtEndTime.Text))

            For i = 0 To list.Count - 1
                Console.WriteLine(list(i).getName)
            Next

            If list.Count = 0 Then
                frmMsgBox.content = "没有符合要求的后勤。"
                frmMsgBox.btnYesString = "确定"
                frmMsgBox.msgType = "Yes"
                frmMsgBox.ShowDialog()
            Else
                frmFilteredLogistic.setList(list)
                frmFilteredLogistic.ShowDialog()
            End If
        End If
    End Sub

    Private Function validateControl() As Boolean
        Dim valid As Boolean = True
        Dim errText As String = ""

        If cboLevel.SelectedIndex = -1 Then
            valid = False
            errText = "请选择关卡解锁。"
            cboLevel.Select()
        End If

        If Double.TryParse(txtEndTime.Text, vbDouble) = False Or
            Double.TryParse(txtStartTime.Text, vbDouble) = False Or
            Integer.TryParse(txtManpower.Text, vbInteger) = False Or
            Integer.TryParse(txtAmmo.Text, vbInteger) = False Or
            Integer.TryParse(txtRation.Text, vbInteger) = False Or
            Integer.TryParse(txtPart.Text, vbInteger) = False Then
            valid = False
            errText = "请输入正确的格式。"
        End If

        If String.IsNullOrWhiteSpace(txtEndTime.Text) Then
            valid = False
            errText = "时间不能为空。"
            txtEndTime.Select()
        End If

        If String.IsNullOrWhiteSpace(txtStartTime.Text) Then
            valid = False
            errText = "时间不能为空。"
            txtStartTime.Select()
        End If

        If txtPart.Text = "请输入整数" Then
            valid = False
            errText = "零件权重不能为空。"
            txtPart.Select()
        End If

        If txtRation.Text = "请输入整数" Then
            valid = False
            errText = "口粮权重不能为空。"
            txtRation.Select()
        End If

        If txtAmmo.Text = "请输入整数" Then
            valid = False
            errText = "弹药权重不能为空。"
            txtAmmo.Select()
        End If

        If txtManpower.Text = "请输入整数" Then
            valid = False
            errText = "人力权重不能为空。"
            txtManpower.Select()
        End If

        If valid = False Then
            With frmMsgBox
                .title = "错误"
                .content = errText
                .msgType = "Yes"
                .btnYesString = "确定"
                frmMsgBox.ShowDialog()
            End With
        End If

        Return valid
    End Function

    'top panel setting
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

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click, btnCancel.Click
        Me.Close()
    End Sub

    Private Sub picExit_MouseMove(sender As Object, e As MouseEventArgs) Handles picExit.MouseMove
        picExit.BackColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Sub picExit_MouseLeave(sender As Object, e As EventArgs) Handles picExit.MouseLeave
        picExit.BackColor = Color.FromArgb(66, 66, 66)
    End Sub

    ' Button Click Event
    Private Sub manPower_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Label6.Click
        If res1 = True Then
            PictureBox1.Image = My.Resources.button_grey
            res1 = False
        Else
            PictureBox1.Image = My.Resources.button_red
            res1 = True
            PictureBox2.Image = My.Resources.button_grey
            res2 = False
            PictureBox3.Image = My.Resources.button_grey
            res3 = False
            PictureBox4.Image = My.Resources.button_grey
            res4 = False
            PictureBox5.Image = My.Resources.button_grey
            res5 = False

            txtManpower.Text = "1"
            txtAmmo.Text = "0"
            txtRation.Text = "0"
            txtPart.Text = "0"
        End If
    End Sub

    Private Sub ammo_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label7.Click
        If res2 = True Then
            PictureBox2.Image = My.Resources.button_grey
            res2 = False
        Else
            PictureBox1.Image = My.Resources.button_grey
            res1 = False
            PictureBox2.Image = My.Resources.button_red
            res2 = True
            PictureBox3.Image = My.Resources.button_grey
            res3 = False
            PictureBox4.Image = My.Resources.button_grey
            res4 = False
            PictureBox5.Image = My.Resources.button_grey
            res5 = False

            txtManpower.Text = "0"
            txtAmmo.Text = "1"
            txtRation.Text = "0"
            txtPart.Text = "0"
        End If
    End Sub

    Private Sub ration_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Label8.Click
        If res3 = True Then
            PictureBox3.Image = My.Resources.button_grey
            res3 = False
        Else
            PictureBox1.Image = My.Resources.button_grey
            res1 = False
            PictureBox2.Image = My.Resources.button_grey
            res2 = False
            PictureBox3.Image = My.Resources.button_red
            res3 = True
            PictureBox4.Image = My.Resources.button_grey
            res4 = False
            PictureBox5.Image = My.Resources.button_grey
            res5 = False

            txtManpower.Text = "0"
            txtAmmo.Text = "0"
            txtRation.Text = "1"
            txtPart.Text = "0"
        End If
    End Sub

    Private Sub part_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, Label9.Click
        If res4 = True Then
            PictureBox4.Image = My.Resources.button_grey
            res4 = False
        Else
            PictureBox1.Image = My.Resources.button_grey
            res1 = False
            PictureBox2.Image = My.Resources.button_grey
            res2 = False
            PictureBox3.Image = My.Resources.button_grey
            res3 = False
            PictureBox4.Image = My.Resources.button_red
            res4 = True
            PictureBox5.Image = My.Resources.button_grey
            res5 = False

            txtManpower.Text = "0"
            txtAmmo.Text = "0"
            txtRation.Text = "0"
            txtPart.Text = "1"
        End If
    End Sub

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click, Label10.Click
        If res5 = True Then
            PictureBox5.Image = My.Resources.button_grey
            res5 = False
        Else
            PictureBox1.Image = My.Resources.button_grey
            res1 = False
            PictureBox2.Image = My.Resources.button_grey
            res2 = False
            PictureBox3.Image = My.Resources.button_grey
            res3 = False
            PictureBox4.Image = My.Resources.button_grey
            res4 = False
            PictureBox5.Image = My.Resources.button_red
            res5 = True

            txtManpower.Text = "1"
            txtAmmo.Text = "1"
            txtRation.Text = "1"
            txtPart.Text = "1"
        End If
    End Sub

    Private Sub doll_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, Label12.Click
        If con1 = True Then
            PictureBox6.Image = My.Resources.button_grey
            If item1 = 1 Then
                item1 = 0
            Else
                item2 = 0
            End If
            con1 = False
            conNo = conNo - 1
        Else
            If conNo < 2 Then
                conNo = conNo + 1
                con1 = True
                PictureBox6.Image = My.Resources.button_red
                If item1 = 0 Then
                    item1 = 1
                Else
                    item2 = 1
                End If
            End If
        End If
    End Sub

    Private Sub equipment_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, Label13.Click
        If con2 = True Then
            PictureBox7.Image = My.Resources.button_grey
            If item1 = 2 Then
                item1 = 0
            Else
                item2 = 0
            End If
            con2 = False
            conNo = conNo - 1
        Else
            If conNo < 2 Then
                conNo = conNo + 1
                con2 = True
                PictureBox7.Image = My.Resources.button_red
                If item1 = 0 Then
                    item1 = 2
                Else
                    item2 = 2
                End If
            End If
        End If
    End Sub

    Private Sub production_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click, Label14.Click
        If con3 = True Then
            PictureBox8.Image = My.Resources.button_grey
            If item1 = 3 Then
                item1 = 0
            Else
                item2 = 0
            End If
            con3 = False
            conNo = conNo - 1
        Else
            If conNo < 2 Then
                conNo = conNo + 1
                con3 = True
                PictureBox8.Image = My.Resources.button_red
                If item1 = 0 Then
                    item1 = 3
                Else
                    item2 = 3
                End If
            End If
        End If
    End Sub

    Private Sub restore_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, Label15.Click
        If con4 = True Then
            PictureBox9.Image = My.Resources.button_grey
            If item1 = 4 Then
                item1 = 0
            Else
                item2 = 0
            End If
            con4 = False
            conNo = conNo - 1
        Else
            If conNo < 2 Then
                conNo = conNo + 1
                con4 = True
                PictureBox9.Image = My.Resources.button_red
                If item1 = 0 Then
                    item1 = 4
                Else
                    item2 = 4
                End If
            End If
        End If
    End Sub

    Private Sub token_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click, Label16.Click
        If con5 = True Then
            PictureBox10.Image = My.Resources.button_grey
            If item1 = 5 Then
                item1 = 0
            Else
                item2 = 0
            End If
            con5 = False
            conNo = conNo - 1
        Else
            If conNo < 2 Then
                conNo = conNo + 1
                con5 = True
                PictureBox10.Image = My.Resources.button_red
                If item1 = 0 Then
                    item1 = 5
                Else
                    item2 = 5
                End If
            End If
        End If
    End Sub

    ' UI settings
    Private Sub txtManpower_GotFocus(sender As Object, e As EventArgs) Handles txtManpower.GotFocus
        PictureBox11.Image = My.Resources.grey_textbox
        txtManpower.ForeColor = Color.Black
        If txtManpower.Text = "请输入整数" Then
            txtManpower.Text = ""
        End If
    End Sub

    Private Sub txtManpower_LostFocus(sender As Object, e As EventArgs) Handles txtManpower.LostFocus
        PictureBox11.Image = My.Resources.lightgrey_textbox
        If String.IsNullOrWhiteSpace(txtManpower.Text) Then
            txtManpower.Text = "请输入整数"
            txtManpower.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtAmmo_GotFocus(sender As Object, e As EventArgs) Handles txtAmmo.GotFocus
        PictureBox12.Image = My.Resources.grey_textbox
        txtAmmo.ForeColor = Color.Black
        If txtAmmo.Text = "请输入整数" Then
            txtAmmo.Text = ""
        End If
    End Sub

    Private Sub txtAmmo_LostFocus(sender As Object, e As EventArgs) Handles txtAmmo.LostFocus
        PictureBox12.Image = My.Resources.lightgrey_textbox
        If String.IsNullOrWhiteSpace(txtAmmo.Text) Then
            txtAmmo.Text = "请输入整数"
            txtAmmo.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtRation_GotFocus(sender As Object, e As EventArgs) Handles txtRation.GotFocus
        PictureBox13.Image = My.Resources.grey_textbox
        txtRation.ForeColor = Color.Black
        If txtRation.Text = "请输入整数" Then
            txtRation.Text = ""
        End If
    End Sub

    Private Sub txtRation_LostFocus(sender As Object, e As EventArgs) Handles txtRation.LostFocus
        PictureBox13.Image = My.Resources.lightgrey_textbox
        If String.IsNullOrWhiteSpace(txtRation.Text) Then
            txtRation.Text = "请输入整数"
            txtRation.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPart_GotFocus(sender As Object, e As EventArgs) Handles txtPart.GotFocus
        PictureBox14.Image = My.Resources.grey_textbox
        txtPart.ForeColor = Color.Black
        If txtPart.Text = "请输入整数" Then
            txtPart.Text = ""
        End If
    End Sub

    Private Sub txtPart_LostFocus(sender As Object, e As EventArgs) Handles txtPart.LostFocus
        PictureBox14.Image = My.Resources.lightgrey_textbox
        If String.IsNullOrWhiteSpace(txtPart.Text) Then
            txtPart.Text = "请输入整数"
            txtPart.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtStartTime_GotFocus(sender As Object, e As EventArgs) Handles txtStartTime.GotFocus
        PictureBox15.Image = My.Resources.lightgrey_textbox
    End Sub

    Private Sub txtStartTime_LostFocus(sender As Object, e As EventArgs) Handles txtStartTime.LostFocus
        PictureBox15.Image = My.Resources.lightgrey_textbox
    End Sub

    Private Sub txtEndTime_GotFocus(sender As Object, e As EventArgs) Handles txtEndTime.GotFocus
        PictureBox16.Image = My.Resources.lightgrey_textbox
    End Sub

    Private Sub txtendTime_LostFocus(sender As Object, e As EventArgs) Handles txtEndTime.LostFocus
        PictureBox16.Image = My.Resources.lightgrey_textbox
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, Label6.MouseMove
        Label6.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, Label6.MouseLeave
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove, Label7.MouseMove
        Label7.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave, Label7.MouseLeave
        Label7.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove, Label8.MouseMove
        Label8.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave, Label8.MouseLeave
        Label8.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove, Label9.MouseMove
        Label9.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave, Label9.MouseLeave
        Label9.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove, Label10.MouseMove
        Label10.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave, Label10.MouseLeave
        Label10.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox6_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseMove, Label12.MouseMove
        Label12.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave, Label12.MouseLeave
        Label12.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox7_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseMove, Label13.MouseMove
        Label13.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave, Label13.MouseLeave
        Label13.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseMove, Label14.MouseMove
        Label14.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave, Label14.MouseLeave
        Label14.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseMove, Label15.MouseMove
        Label15.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave, Label15.MouseLeave
        Label15.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox10_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseMove, Label16.MouseMove
        Label16.ForeColor = Color.Gray
    End Sub

    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave, Label16.MouseLeave
        Label16.ForeColor = Color.Black
    End Sub
End Class
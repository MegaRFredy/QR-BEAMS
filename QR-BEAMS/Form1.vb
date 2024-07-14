Public Class Login_frm
    Dim db As New SQL
    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelHelper.SetRoundedCorners(GunaPanel1, 30)
        RoundedCornerHelper.SetRoundedCorners(Me, 30)
        GunaPanel1.BackColor = _PANELCOLOR
        signin_btn.BackColor = _BUTTONCOLOR
        Dim db As New DATABASE
        If db.NETWORK() Then
            connect_dot.Visible = True
            error_dot.Visible = False
        Else
            connect_dot.Visible = False
            error_dot.Visible = True
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Application.Exit()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles signin_btn.Click
        If db.LoginUser(Username.Text, Password.Text) Then
            MessageBox.Show($"Login Succesfully {Username.Text}", "LOGIN USER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DASHBOARD.Show()
            Me.Hide()
        Else
            MessageBox.Show($"Login Failed {Username.Text} Check your inputs", "FAILED TO LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub signin_btn_MouseHover(sender As Object, e As EventArgs) Handles signin_btn.MouseHover
        signin_btn.Cursor = Cursors.Hand
    End Sub


    Private Sub signin_btn_MouseLeave(sender As Object, e As EventArgs) Handles signin_btn.MouseLeave
        signin_btn.Cursor = Cursors.Default
    End Sub

    Private Sub Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            SignIn()
        End If
    End Sub

    Private Sub SignIn()
        If db.LoginUser(Username.Text, Password.Text) Then
            MessageBox.Show($"Login Successfully {Username.Text}", "LOGIN USER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DASHBOARD.Show()
            Me.Hide()
        Else
            MessageBox.Show($"Login Failed {Username.Text}. Check your inputs", "FAILED TO LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class

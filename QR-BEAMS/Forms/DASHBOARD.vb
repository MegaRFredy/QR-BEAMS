


Public Class DASHBOARD

    Private Sub DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedCornerHelper.SetRoundedCorners(Me, 30)
        Side_pnl.BackColor = _PANELCOLOR
        header_pnl.BackColor = _HEADERCOLOR
        Switcher_pnl.BackColor = _PANELCOLOR
    End Sub
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim message = "Are you sure you want to sign out?"
        Dim result As DialogResult = MessageBox.Show(message, "SIGN OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Login_frm.Show()
        Else

        End If
    End Sub



    'Function to() switch things 


    Public Sub F_Changer(P As Panel, panel As Form)
        P.Controls.Clear()
        panel.TopLevel = False
        P.Controls.Add(panel)
        panel.Show()
    End Sub
    'EVENTS
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        F_Changer(Switcher_pnl, New EVENTS())

    End Sub

    'RECORDS
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        F_Changer(Switcher_pnl, New RECORDS())
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        F_Changer(Switcher_pnl, New USERS())
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        F_Changer(Switcher_pnl, New DASH())
    End Sub
End Class
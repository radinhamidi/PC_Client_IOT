Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ContextMenuStrip1.Enabled = True
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Minimized
        Form1.NotifyIcon1.BalloonTipText = "User : " + Label4.Text
        Form1.NotifyIcon1.ShowBalloonTip(60)
        Me.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Visible = True
        Form1.current_form = 1
        Me.Visible = False
    End Sub
End Class
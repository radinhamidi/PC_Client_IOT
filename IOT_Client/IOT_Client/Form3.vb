Public Class Form3
    Public Sub set_param()
        On Error GoTo set_param_error_label
        Form2.Timer1.Enabled = True
        Form2.Timer2.Interval = Val(TextBox1.Text) * 1000
        Form2.Timer1.Interval = Val(TextBox4.Text) * 60000
        If My.Computer.Network.IsAvailable Then
            Form2.Timer2.Enabled = True
        Else
            Form2.Label15.Visible = True
        End If

        Form2.Visible = True
        Me.Visible = False
        Exit Sub
set_param_error_label:
        MsgBox("Error In Setting Parameter")
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        set_param()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
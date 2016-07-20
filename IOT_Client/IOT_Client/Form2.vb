Imports System.Net
Imports System.IO
Imports System.Web
Public Class Form2
    Dim client As New WebClient
    Dim strReq As String
    Dim strData As String
    Dim dataStream As Stream
    Dim reader As StreamReader
    Dim request As WebRequest
    Dim response As WebResponse
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
        Form1.clear_label()
        Me.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = Date.Now.ToShortDateString
        Label7.Text = Date.Now.ToShortTimeString
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        strReq = "http://104.131.67.214"
        request = WebRequest.Create(strReq)
        response = request.GetResponse()
        dataStream = response.GetResponseStream()
        reader = New StreamReader(dataStream)
        strData = reader.ReadToEnd()
        TextBox1.Text = strData
        reader.Close()
        response.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Date.Now.ToShortTimeString
    End Sub
End Class
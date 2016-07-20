Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Text
Public Class Form2
    Dim client As New WebClient
    Dim strReq As String
    Dim strData As String
    Dim dataStream As Stream
    Dim reader As StreamReader
    Dim request As HttpWebRequest
    Dim response As HttpWebResponse
    Private Function SendRequest(uri As String, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim req As HttpWebRequest = HttpWebRequest.Create(uri)
        req.ContentType = contentType
        req.Method = method
        req.ContentLength = jsonDataBytes.Length


        Dim stream = req.GetRequestStream()
        stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
        stream.Flush()
        stream.Close()

        Dim response = req.GetResponse.GetResponseStream()


        Dim reader As New StreamReader(response)
        Dim res = reader.ReadToEnd()
        reader.Close()
        response.Close()

        Return res
    End Function
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
        Label5.Visible = False
        Me.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = Date.Now.ToShortDateString
        Label7.Text = Date.Now.ToShortTimeString
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        strReq = "{""reqtype"":""download"", ""uid"":""1"" , ""password"":""123"", ""reqtime"":""12356""}"
        Dim data = Encoding.UTF8.GetBytes(strReq)
        Dim result_post = SendRequest("http://ele.aut.ac.ir/~pourahmadi/indoor.php", data, "text/json", "POST")
        TextBox1.Text = result_post
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Date.Now.ToShortTimeString
    End Sub
End Class
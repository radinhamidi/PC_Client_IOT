Imports System.IO
Imports System.Text
Imports System.Net
Public Class Form1
    Dim user_address As String = "http://sepandhaghighi.github.io/elec_3/user.txt"
    Dim pass_address As String = "http://sepandhaghighi.github.io/elec_3/pass.txt"
    Dim access_address As String = "http://sepandhaghighi.github.io/elec_3/access.txt"
    Dim image_address As String = "http://sepandhaghighi.github.io/elec_3/image/"
    Dim image_address_2 As String = ""
    Dim client As New WebClient
    Dim user_reader As StreamReader
    Dim pass_reader As StreamReader
    Dim access_reader As StreamReader
    Dim number_of_user As Integer
    Public Shared user_index As Integer = 1
    Public Shared current_form As Integer = 1
    Dim access As String
    Public Sub clear_label()
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
    End Sub
    Public Sub read_data()
        On Error GoTo read_data_label
        If Len(TextBox1.Text) = 0 Or Len(TextBox2.Text) = 0 Then
            Label6.Visible = True
            Button1.Enabled = False
            Timer1.Enabled = True
        Else
            user_reader = New StreamReader(client.OpenRead(user_address))
            pass_reader = New StreamReader(client.OpenRead(pass_address))
            number_of_user = Int(user_reader.ReadLine())
            For i = 1 To number_of_user
                If TextBox1.Text = user_reader.ReadLine And Val(TextBox2.Text) = Int(pass_reader.ReadLine) Then
                    user_index = i
                    user_reader.Close()
                    pass_reader.Close()
                    show_image()
                    Form2.Label3.Text = read_access()
                    Form2.Label4.Text = TextBox1.Text
                    current_form = 2
                    Form2.Visible = True
                    clear_label()
                    Me.Visible = False
                    Exit For

                End If
            Next
            user_reader.Close()
            pass_reader.Close()
            client.Dispose()
            Label5.Visible = True
            Button1.Enabled = False
            Timer1.Enabled = True
        End If
        Exit Sub
read_data_label:
        Label7.Visible = False
        Label3.Visible = True
        Button1.Enabled = False
        Timer1.Enabled = True
    End Sub
    Public Sub show_image()
        On Error GoTo load_error
        image_address_2 = image_address + Str(user_index) + ".jpg"
        image_address_2 = image_address_2.Replace(" ", "")
        Form2.PictureBox1.Image = Bitmap.FromStream(New MemoryStream(client.DownloadData(image_address_2)))
        Exit Sub
load_error:
        Form2.Label5.Visible = True
    End Sub
    Public Function read_access() As String
        For i = 1 To user_index
            access_reader = New StreamReader(client.OpenRead(access_address))
            access = access_reader.ReadLine

        Next
        access_reader.Close()
        client.Dispose()
        Return access
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NotifyIcon1.BalloonTipText = "IOT_CLIENT is Still Running"
        NotifyIcon1.ShowBalloonTip(70)
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Minimized
        ContextMenuStrip1.Enabled = True



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Show" Then
            TextBox2.UseSystemPasswordChar = False
            TextBox2.PasswordChar = ""
            Button3.Text = "Hide"
        Else
            TextBox2.UseSystemPasswordChar = True
            TextBox2.PasswordChar = "*"
            Button3.Text = "Show"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.Network.IsAvailable Then
            Label7.Visible = True
            read_data()
        Else
            Label4.Visible = True
            Button1.Enabled = False
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button1.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub contextmenu_exit(sender As Object, e As EventArgs) Handles Exi.Click
        End
    End Sub
    Private Sub contextmenu_show(sender As Object, e As EventArgs) Handles Show.Click
        ContextMenuStrip1.Enabled = False
        If current_form = 1 Then
            Me.Visible = True
            Me.ShowInTaskbar = True
            Me.WindowState = FormWindowState.Normal
        Else
            Form2.Visible = True
            Form2.ShowInTaskbar = True
            Form2.WindowState = FormWindowState.Normal

        End If

    End Sub
    Private Sub contextmenu_click(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        contextmenu_show(sender, e)
    End Sub
End Class

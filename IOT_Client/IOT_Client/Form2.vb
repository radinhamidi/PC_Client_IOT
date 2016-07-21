Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Text
Imports System.Text.RegularExpressions
Public Class Form2
    Dim client As New WebClient
    Dim upload_strReq As String = "{""reqtype"":""upload"", ""uid"":""1"" , ""password"":""123"", ""reqtime"":""12356"",""temperature"":""30"",""humidity"":""27.23"",""pulse"":""3002""}"
    Dim download_strReq_1 As String = "{""reqtype"":""download"", ""uid"":"
    Dim download_strReq_2 As String = ", ""password"":""123"", ""reqtime"":""12356""}"
    Dim get_users As String = "{""reqtype"":""getusers""}"
    Dim strData As String
    Dim dataStream As Stream
    Dim reader As StreamReader
    Dim request As HttpWebRequest
    Dim response As HttpWebResponse
    Dim string_array_data() As String
    Dim string_array_users() As String
    Dim UID_list(100) As String
    Dim pulse_list(100) As String
    Dim temp_list(100) As String
    Dim hum_list(100) As String
    Dim name_list(100) As String
    Dim result_post As String
    Dim user_post As String
    Dim data() As Byte
    Dim users() As Byte
    Dim data_list(10) As String
    Public Sub nothing_label()
        If ListBox2.Items.Count = 0 Then
            Label13.Text = "No Data"
            Label13.ForeColor = Color.DarkRed

        End If
        If ListBox3.Items.Count = 0 Then
            Label12.Text = "No Data"
            Label12.ForeColor = Color.DarkRed

        End If
        If ListBox4.Items.Count = 0 Then
            Label11.Text = "No Data"
            Label11.ForeColor = Color.DarkRed

        End If
    End Sub
    Public Sub clear_label()
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label11.ForeColor = DefaultForeColor
        Label12.ForeColor = DefaultForeColor
        Label13.ForeColor = DefaultForeColor
    End Sub
    Public Sub clear_lists()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
    End Sub
    Public Sub get_data(ByVal index As String)
        result_post = ""
        data = Encoding.UTF8.GetBytes(download_strReq_1 + """" + index + """" + download_strReq_2)
        result_post = SendRequest(Form3.TextBox5.Text, data, "text/json", "POST")
        result_post = string_spliter(result_post, 31, result_post.Length)
        string_array_data = result_post.Split("{")
        'TextBox1.Text = download_strReq_1 + """" + index + """" + download_strReq_2
        list_maker(string_array_data)
    End Sub
    Public Sub server_connect()

        user_post = ""
        users = Encoding.UTF8.GetBytes(get_users)
        user_post = SendRequest("http://autiot.coolpage.biz/users.php", users, "text/json", "POST")
        user_post = string_spliter(user_post, 31, user_post.Length)
        
        If user_post <> Nothing Then

            string_array_users = user_post.Split("{")
            'TextBox1.Text = string_array_data(1) + vbCr + string_array_data(2)
            If string_array_users(1)(1) <> "?" Then
                list_filler(string_array_users)

                'Label16.Text = string_array(1)(1)
            Else
            End If
        End If


            'Exit Sub

    End Sub
    Public Function string_spliter(ByVal input As String, ByVal first As Integer, ByVal last As Integer)
        Dim string_local As String = ""
        If first > 0 And last <= input.Length Then
            For i = first To last - 1
                string_local = string_local + input(i)
            Next
        End If
        Return string_local
    End Function
    Public Sub list_maker(ByVal input() As String)
        Dim json As JSONObject
        Dim UID As String
        For i = 1 To input.Length - 1
            json = New JSONObject(input(i))
            UID = json.GetProperty("UID").Value
            If UID <> Nothing Then ' if UID is valid condition
                'UID_list(Val(UID))(i) = UID
                ListBox2.Items.Add(json.GetProperty("Temp").Value)
                ListBox3.Items.Add(json.GetProperty("Humidity").Value)
                ListBox4.Items.Add(json.GetProperty("Pulse").Value)
                temp_list(Val(UID)) = json.GetProperty("Temp").Value
                hum_list(Val(UID)) = json.GetProperty("Humidity").Value
                pulse_list(Val(UID)) = json.GetProperty("Pulse").Value

            End If
        Next

    End Sub
    Public Sub list_filler(ByVal input() As String)
        Dim json As JSONObject
        Dim UID As String
        Dim name As String
        For i = 1 To input.Length - 1
            json = New JSONObject(input(i))
            UID = json.GetProperty("UID").Value
            name = json.GetProperty("Name").Value
            If UID <> Nothing Then ' if UID is valid condition
                If ListBox1.Items.Contains(UID) = False Then
                    'temp_list(Val(UID)) = json.GetProperty("Temp").Value
                    'hum_list(Val(UID)) = json.GetProperty("Humidity").Value
                    'pulse_list(Val(UID)) = json.GetProperty("Pulse").Value
                    ListBox1.Items.Add(UID)
                    name_list(i) = name
                End If
            End If
        Next

    End Sub
    Private Function SendRequest(uri As String, jsonDataBytes As Byte(), contentType As String, method As String) As String
        On Error GoTo sendrequest_error
        Dim req As HttpWebRequest = HttpWebRequest.Create(uri)
        req.ContentType = contentType
        req.Method = method
        req.ContentLength = jsonDataBytes.Length


        Dim stream = req.GetRequestStream
        stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
        stream.Flush()
        stream.Close()

        Dim response = req.GetResponse.GetResponseStream()


        Dim reader As New StreamReader(response)
        Dim res = reader.ReadToEnd()
        reader.Close()
        response.Close()

        Return res
        Exit Function
sendrequest_error:
        If My.Computer.Network.IsAvailable Then
            SendRequest(uri, jsonDataBytes, contentType, method)
        End If
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
        Timer1.Enabled = False
        Timer2.Enabled = False
        Me.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label6.Text = Date.Now.ToShortDateString
        Label7.Text = Date.Now.ToShortTimeString
        Timer1.Enabled = True
        If My.Computer.Network.IsAvailable Then
            server_connect()
            ' Timer2.Enabled = True

        Else
            Label15.Visible = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)








    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Date.Now.ToShortTimeString
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        clear_lists()
        clear_label()
        get_data(ListBox1.SelectedItem)
        Label20.Text = name_list(ListBox1.SelectedItem)
        Label11.Text = pulse_list(ListBox1.SelectedItem)
        Label12.Text = hum_list(ListBox1.SelectedItem)
        Label13.Text = temp_list(ListBox1.SelectedItem)
        nothing_label()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        server_connect()
        'Label16.Text = Val(Label16.Text) + 1 is only for test

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Visible = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Visible = True
        Form4.plot_temp(ListBox2.Items.Count)
        Form4.plot_hum(ListBox3.Items.Count)
        Form4.plot_pulse(ListBox4.Items.Count)
        Me.Visible = False
    End Sub
End Class

Public Class JSONObject

#Region "Shared Variables"
    Private Shared ReadOnly reProp As New Regex("(?<=(^|\,)\s*)([^\:]+)\s*\:\s*([^\,]+)", RegexOptions.Compiled)
    Private Shared ReadOnly reReplaced As New Regex("^\$\[\d+\]$", RegexOptions.Compiled)
#End Region

#Region "Shared Functions"

    Private Shared Function TokenizeJSON(ByVal json As String, ByVal l As List(Of String)) As String
        Dim r As String = String.Empty,
            nestable As String = "()[]{}",
            stringable As String = """'",
            nested As New Stack(Of Char),
            stringing As Char? = Nothing,
            start As Integer = -1
        l.Clear()

        For i As Integer = 0 To json.Length - 1
            Dim c As Char = json(i)
            If stringing IsNot Nothing Then
                If stringing = c Then
                    stringing = Nothing
                    If nested.Count = 0 Then
                        r &= "$[" & l.Count.ToString() & "]"
                        l.Add(json.Substring(start, i - start + 1))
                    End If
                End If
            ElseIf stringable.IndexOf(c) > -1 Then
                stringing = c
                If nested.Count = 0 Then start = i
            ElseIf nestable.IndexOf(c) Mod 2 = 0 Then
                If nested.Count = 0 Then start = i
                nested.Push(c)
            ElseIf nested.Count > 0 Then
                If nestable.IndexOf(nested.Peek()) + 1 = nestable.IndexOf(c) Then
                    nested.Pop()
                    If nested.Count = 0 Then
                        r &= "$[" & l.Count.ToString() & "]"
                        l.Add(json.Substring(start, i - start + 1))
                    End If
                End If
            Else
                r &= If(c = "\" OrElse c = "$", "\" & c, c)
            End If
        Next

        Return r
    End Function

    Private Shared Function ParseJSONObject(ByVal json As String) As Dictionary(Of String, String)
        Dim r As New Dictionary(Of String, String),
            l As New List(Of String)

        'Trim any leading or trailing object delimiters found in JSON objects.
        json = json.TrimStart("{"c, "("c, " "c).TrimEnd("}"c, ")"c, " "c)

        'Tokenize the JSON object.
        json = TokenizeJSON(json, l)

        'Parse the JSON object.
        For Each m As Match In reProp.Matches(json)
            Dim name As String = m.Groups(2).Value.TrimStart()
            Dim value As String = m.Groups(3).Value
            If reReplaced.IsMatch(name) Then name = l(Integer.Parse(name.Substring(2, name.Length - 3)))
            If reReplaced.IsMatch(value) Then value = l(Integer.Parse(value.Substring(2, value.Length - 3)))
            name = name.Trim("'"c, """"c)
            r.Add(name, value)
        Next

        'Return the result.
        Return r
    End Function

    Private Shared Function ParseJSONArray(ByVal json As String) As String()
        Dim l As New List(Of String),
            r As New List(Of String)

        'Trim any leading or trailing array delimiters found in JSON objects, but only one on each side.
        json = json.Trim()
        json = json.Substring(1, json.Length - 2)

        'Tokenize the JSON array.
        json = TokenizeJSON(json, l)

        'Parse and return the JSON array.
        For Each y As String In (From x As String In json.Split(","c) Select x.Trim())
            If reReplaced.IsMatch(y) Then
                r.Add(l(Integer.Parse(y.Substring(2, y.Length - 3))))
            Else
                r.Add(y)
            End If
        Next

        Return r.ToArray()
    End Function

#End Region

#Region "Variables"
    Private ReadOnly _properties As Dictionary(Of String, String)
#End Region

#Region "Constructor"
    Public Sub New(ByVal json As String)
        _properties = JSONObject.ParseJSONObject(json)
    End Sub
#End Region

#Region "Methods"
    Public Function GetProperty(ByVal name As String) As JSONValue
        If _properties.ContainsKey(name) Then Return Evaluate(_properties(name))

        Return New JSONValue(JSONType.undefined, Nothing)
    End Function

    Private Function Evaluate(ByVal json As String) As JSONValue
        Dim intValue As Integer,
            floatValue As Double
        json = json.TrimStart("("c).TrimEnd(")"c)

        If json <> String.Empty Then
            If json(0) = "{"c Then
                Return New JSONValue(JSONType.object, New JSONObject(json))
            ElseIf json(0) = "["c Then
                Return New JSONValue(JSONType.array, (From x As String In JSONObject.ParseJSONArray(json) Select Evaluate(x)).ToArray())
            ElseIf json(0) = "'"c OrElse json(0) = """"c Then
                Return New JSONValue(JSONType.string, json.Substring(1, json.Length - 2))
            ElseIf Integer.TryParse(json, intValue) Then
                Return New JSONValue(JSONType.int, intValue)
            ElseIf Double.TryParse(json, floatValue) Then
                Return New JSONValue(JSONType.double, floatValue)
            ElseIf json = "true" Then
                Return New JSONValue(JSONType.bool, True)
            ElseIf json = "false" Then
                Return New JSONValue(JSONType.bool, False)
            ElseIf json = "null" Then
                Return New JSONValue(JSONType.null, Nothing)
            End If
        End If

        Return New JSONValue(JSONType.undefined, Nothing)
    End Function
#End Region

End Class

Public Class JSONValue
    Private _type As JSONType,
            _value As Object

    Public Sub New(ByVal type As JSONType, ByVal value As Object)
        _type = type
        _value = value
    End Sub

    Public ReadOnly Property Type() As JSONType
        Get
            Return _type
        End Get
    End Property

    Public ReadOnly Property Value() As Object
        Get
            Return _value
        End Get
    End Property
End Class

Public Enum JSONType
    bool
    int
    [double]
    [string]
    [object]
    array
    null
    undefined
End Enum



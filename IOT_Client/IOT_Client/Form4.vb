Public Class Form4
    Public Sub reset_radio_group()
        RadioButton1.Checked = True
    End Sub
    Public Sub clear_label()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Chart1.Series(0).Points.Clear()
        Chart2.Series(0).Points.Clear()
        Chart3.Series(0).Points.Clear()

    End Sub

    Public Sub plot_temp(ByVal number_points As Integer)
        For i = 1 To number_points - 1
            Chart1.Series(0).Points.AddXY(i, Val(Form2.ListBox2.Items(i)))
        Next
        If number_points = 0 Then
            Label1.Visible = True
        End If
    End Sub
    Public Sub plot_hum(ByVal number_points As Integer)
        For i = 1 To number_points - 1
            Chart3.Series(0).Points.AddXY(i, Val(Form2.ListBox3.Items(i)))
        Next
        If number_points = 0 Then
            Label3.Visible = True
        End If
    End Sub
    Public Sub plot_pulse(ByVal number_points As Integer)
        For i = 1 To number_points - 1
            Chart2.Series(0).Points.AddXY(i, Val(Form2.ListBox4.Items(i)))
        Next
        If number_points = 0 Then
            Label2.Visible = True
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Visible = True
        clear_label()
        Timer1.Enabled = False
        Me.Visible = False
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Case 1
                Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Case 2
                Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
        End Select




    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            Case 1
                Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            Case 2
                Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
        End Select



    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Case 1
                Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Case 2
                Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
        End Select




    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
            Case 1
                Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
            Case 2
                Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        End Select



    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
            Case 1
                Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
            Case 2
                Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
        End Select



    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs)
        Select Case ComboBox1.SelectedIndex
            Case 0
                Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
            Case 1
                Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
            Case 2
                Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        End Select




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form2.get_data(Form2.ListBox1.SelectedItem)
        Chart1.Series(0).Points.Clear()
        Chart2.Series(0).Points.Clear()
        Chart3.Series(0).Points.Clear()
        plot_temp(Form2.ListBox2.Items.Count)
        plot_hum(Form2.ListBox3.Items.Count)
        plot_pulse(Form2.ListBox4.Items.Count)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        reset_radio_group()
    End Sub
End Class
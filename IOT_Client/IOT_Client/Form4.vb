Public Class Form4
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
        Me.Visible = False
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
        Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
        Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
        Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
    End Sub
End Class
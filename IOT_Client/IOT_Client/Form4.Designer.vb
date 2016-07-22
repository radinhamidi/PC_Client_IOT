<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(70, 12)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Temp"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(840, 561)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(876, 877)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1075, 101)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back To Program"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(1031, 12)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "Pulse"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(840, 561)
        Me.Chart2.TabIndex = 2
        Me.Chart2.Text = "Chart2"
        '
        'Chart3
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(1967, 12)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "Humidity"
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(840, 561)
        Me.Chart3.TabIndex = 3
        Me.Chart3.Text = "Chart3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(371, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No Data"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(1348, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No Data"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(2261, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No Data"
        Me.Label3.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(106, 68)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 29)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Point"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(477, 68)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(140, 29)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "Fast Point"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(890, 68)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(103, 29)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.Text = "Spline"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(1338, 68)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(128, 29)
        Me.RadioButton4.TabIndex = 10
        Me.RadioButton4.Text = "StepLine"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(1842, 68)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(76, 29)
        Me.RadioButton5.TabIndex = 11
        Me.RadioButton5.Text = "Bar"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(464, 662)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(2107, 168)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chart Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Temp", "Pulse", "Humidity"})
        Me.ComboBox1.Location = New System.Drawing.Point(79, 662)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(257, 33)
        Me.ComboBox1.TabIndex = 15
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2815, 1028)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charts"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class

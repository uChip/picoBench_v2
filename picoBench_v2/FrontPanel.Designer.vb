<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontPanel
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VPCalibrateBtn = New System.Windows.Forms.Button()
        Me.VPChart = New System.Windows.Forms.CheckBox()
        Me.VPAve = New System.Windows.Forms.RadioButton()
        Me.VPLog = New System.Windows.Forms.CheckBox()
        Me.VPInst = New System.Windows.Forms.RadioButton()
        Me.VPUnits = New System.Windows.Forms.Label()
        Me.VPData = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CPCalibrateBtn = New System.Windows.Forms.Button()
        Me.CPChart = New System.Windows.Forms.CheckBox()
        Me.CPLog = New System.Windows.Forms.CheckBox()
        Me.CPUnits = New System.Windows.Forms.Label()
        Me.CPData = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PSCalibrateBtn = New System.Windows.Forms.Button()
        Me.PSLog = New System.Windows.Forms.CheckBox()
        Me.PSWUnits = New System.Windows.Forms.Label()
        Me.PSCUnits = New System.Windows.Forms.Label()
        Me.PSVUnits = New System.Windows.Forms.Label()
        Me.PSWData = New System.Windows.Forms.TextBox()
        Me.PSCData = New System.Windows.Forms.TextBox()
        Me.PSVData = New System.Windows.Forms.TextBox()
        Me.Setup = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CPInst = New System.Windows.Forms.RadioButton()
        Me.CPAve = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PSInst = New System.Windows.Forms.RadioButton()
        Me.PSAve = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Res_mA = New System.Windows.Forms.RadioButton()
        Me.Res_uA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.VPCalibrateBtn)
        Me.GroupBox1.Controls.Add(Me.VPChart)
        Me.GroupBox1.Controls.Add(Me.VPLog)
        Me.GroupBox1.Controls.Add(Me.VPUnits)
        Me.GroupBox1.Controls.Add(Me.VPData)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Voltage Probe"
        '
        'VPCalibrateBtn
        '
        Me.VPCalibrateBtn.Location = New System.Drawing.Point(8, 75)
        Me.VPCalibrateBtn.Name = "VPCalibrateBtn"
        Me.VPCalibrateBtn.Size = New System.Drawing.Size(57, 23)
        Me.VPCalibrateBtn.TabIndex = 13
        Me.VPCalibrateBtn.Text = "Calibrate"
        Me.VPCalibrateBtn.UseVisualStyleBackColor = True
        '
        'VPChart
        '
        Me.VPChart.AutoSize = True
        Me.VPChart.Location = New System.Drawing.Point(127, 55)
        Me.VPChart.Name = "VPChart"
        Me.VPChart.Size = New System.Drawing.Size(51, 17)
        Me.VPChart.TabIndex = 12
        Me.VPChart.Text = "Chart"
        Me.VPChart.UseVisualStyleBackColor = True
        '
        'VPAve
        '
        Me.VPAve.AutoSize = True
        Me.VPAve.Location = New System.Drawing.Point(6, 36)
        Me.VPAve.Name = "VPAve"
        Me.VPAve.Size = New System.Drawing.Size(44, 17)
        Me.VPAve.TabIndex = 11
        Me.VPAve.Text = "Ave"
        Me.VPAve.UseVisualStyleBackColor = True
        '
        'VPLog
        '
        Me.VPLog.AutoSize = True
        Me.VPLog.Location = New System.Drawing.Point(127, 74)
        Me.VPLog.Name = "VPLog"
        Me.VPLog.Size = New System.Drawing.Size(44, 17)
        Me.VPLog.TabIndex = 10
        Me.VPLog.Text = "Log"
        Me.VPLog.UseVisualStyleBackColor = True
        '
        'VPInst
        '
        Me.VPInst.AutoSize = True
        Me.VPInst.Checked = True
        Me.VPInst.Location = New System.Drawing.Point(6, 16)
        Me.VPInst.Name = "VPInst"
        Me.VPInst.Size = New System.Drawing.Size(57, 17)
        Me.VPInst.TabIndex = 3
        Me.VPInst.TabStop = True
        Me.VPInst.Text = "Instant"
        Me.VPInst.UseVisualStyleBackColor = True
        '
        'VPUnits
        '
        Me.VPUnits.AutoSize = True
        Me.VPUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPUnits.Location = New System.Drawing.Point(145, 23)
        Me.VPUnits.Name = "VPUnits"
        Me.VPUnits.Size = New System.Drawing.Size(47, 21)
        Me.VPUnits.TabIndex = 6
        Me.VPUnits.Text = "Volts"
        '
        'VPData
        '
        Me.VPData.BackColor = System.Drawing.SystemColors.Info
        Me.VPData.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPData.Location = New System.Drawing.Point(88, 20)
        Me.VPData.MaxLength = 16
        Me.VPData.Name = "VPData"
        Me.VPData.ReadOnly = True
        Me.VPData.Size = New System.Drawing.Size(55, 29)
        Me.VPData.TabIndex = 5
        Me.VPData.Text = "2.538"
        Me.VPData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.CPCalibrateBtn)
        Me.GroupBox2.Controls.Add(Me.CPChart)
        Me.GroupBox2.Controls.Add(Me.CPLog)
        Me.GroupBox2.Controls.Add(Me.CPUnits)
        Me.GroupBox2.Controls.Add(Me.CPData)
        Me.GroupBox2.Location = New System.Drawing.Point(215, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 104)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Probe"
        '
        'CPCalibrateBtn
        '
        Me.CPCalibrateBtn.Location = New System.Drawing.Point(8, 75)
        Me.CPCalibrateBtn.Name = "CPCalibrateBtn"
        Me.CPCalibrateBtn.Size = New System.Drawing.Size(57, 23)
        Me.CPCalibrateBtn.TabIndex = 17
        Me.CPCalibrateBtn.Text = "Calibrate"
        Me.CPCalibrateBtn.UseVisualStyleBackColor = True
        '
        'CPChart
        '
        Me.CPChart.AutoSize = True
        Me.CPChart.Location = New System.Drawing.Point(205, 55)
        Me.CPChart.Name = "CPChart"
        Me.CPChart.Size = New System.Drawing.Size(51, 17)
        Me.CPChart.TabIndex = 16
        Me.CPChart.Text = "Chart"
        Me.CPChart.UseVisualStyleBackColor = True
        '
        'CPLog
        '
        Me.CPLog.AutoSize = True
        Me.CPLog.Location = New System.Drawing.Point(205, 74)
        Me.CPLog.Name = "CPLog"
        Me.CPLog.Size = New System.Drawing.Size(44, 17)
        Me.CPLog.TabIndex = 15
        Me.CPLog.Text = "Log"
        Me.CPLog.UseVisualStyleBackColor = True
        '
        'CPUnits
        '
        Me.CPUnits.AutoSize = True
        Me.CPUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUnits.Location = New System.Drawing.Point(223, 23)
        Me.CPUnits.Name = "CPUnits"
        Me.CPUnits.Size = New System.Drawing.Size(35, 21)
        Me.CPUnits.TabIndex = 12
        Me.CPUnits.Text = "mA"
        '
        'CPData
        '
        Me.CPData.BackColor = System.Drawing.SystemColors.Info
        Me.CPData.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPData.Location = New System.Drawing.Point(166, 20)
        Me.CPData.Name = "CPData"
        Me.CPData.ReadOnly = True
        Me.CPData.Size = New System.Drawing.Size(55, 29)
        Me.CPData.TabIndex = 11
        Me.CPData.Text = "64.7"
        Me.CPData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.PSCalibrateBtn)
        Me.GroupBox3.Controls.Add(Me.PSLog)
        Me.GroupBox3.Controls.Add(Me.PSWUnits)
        Me.GroupBox3.Controls.Add(Me.PSCUnits)
        Me.GroupBox3.Controls.Add(Me.PSVUnits)
        Me.GroupBox3.Controls.Add(Me.PSWData)
        Me.GroupBox3.Controls.Add(Me.PSCData)
        Me.GroupBox3.Controls.Add(Me.PSVData)
        Me.GroupBox3.Location = New System.Drawing.Point(116, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(359, 104)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Power Supply"
        '
        'PSCalibrateBtn
        '
        Me.PSCalibrateBtn.Location = New System.Drawing.Point(8, 75)
        Me.PSCalibrateBtn.Name = "PSCalibrateBtn"
        Me.PSCalibrateBtn.Size = New System.Drawing.Size(57, 23)
        Me.PSCalibrateBtn.TabIndex = 14
        Me.PSCalibrateBtn.Text = "Calibrate"
        Me.PSCalibrateBtn.UseVisualStyleBackColor = True
        '
        'PSLog
        '
        Me.PSLog.AutoSize = True
        Me.PSLog.Location = New System.Drawing.Point(289, 74)
        Me.PSLog.Name = "PSLog"
        Me.PSLog.Size = New System.Drawing.Size(44, 17)
        Me.PSLog.TabIndex = 13
        Me.PSLog.Text = "Log"
        Me.PSLog.UseVisualStyleBackColor = True
        '
        'PSWUnits
        '
        Me.PSWUnits.AutoSize = True
        Me.PSWUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSWUnits.Location = New System.Drawing.Point(307, 22)
        Me.PSWUnits.Name = "PSWUnits"
        Me.PSWUnits.Size = New System.Drawing.Size(39, 21)
        Me.PSWUnits.TabIndex = 9
        Me.PSWUnits.Text = "mW"
        '
        'PSCUnits
        '
        Me.PSCUnits.AutoSize = True
        Me.PSCUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSCUnits.Location = New System.Drawing.Point(176, 61)
        Me.PSCUnits.Name = "PSCUnits"
        Me.PSCUnits.Size = New System.Drawing.Size(35, 21)
        Me.PSCUnits.TabIndex = 8
        Me.PSCUnits.Text = "mA"
        '
        'PSVUnits
        '
        Me.PSVUnits.AutoSize = True
        Me.PSVUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSVUnits.Location = New System.Drawing.Point(176, 22)
        Me.PSVUnits.Name = "PSVUnits"
        Me.PSVUnits.Size = New System.Drawing.Size(47, 21)
        Me.PSVUnits.TabIndex = 7
        Me.PSVUnits.Text = "Volts"
        '
        'PSWData
        '
        Me.PSWData.BackColor = System.Drawing.SystemColors.Info
        Me.PSWData.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSWData.Location = New System.Drawing.Point(250, 19)
        Me.PSWData.Name = "PSWData"
        Me.PSWData.ReadOnly = True
        Me.PSWData.Size = New System.Drawing.Size(55, 29)
        Me.PSWData.TabIndex = 3
        Me.PSWData.Text = "408.5"
        Me.PSWData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PSCData
        '
        Me.PSCData.BackColor = System.Drawing.SystemColors.Info
        Me.PSCData.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSCData.Location = New System.Drawing.Point(119, 58)
        Me.PSCData.Name = "PSCData"
        Me.PSCData.ReadOnly = True
        Me.PSCData.Size = New System.Drawing.Size(55, 29)
        Me.PSCData.TabIndex = 2
        Me.PSCData.Text = "123.4"
        Me.PSCData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PSVData
        '
        Me.PSVData.BackColor = System.Drawing.SystemColors.Info
        Me.PSVData.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSVData.Location = New System.Drawing.Point(119, 19)
        Me.PSVData.Name = "PSVData"
        Me.PSVData.ReadOnly = True
        Me.PSVData.Size = New System.Drawing.Size(55, 29)
        Me.PSVData.TabIndex = 1
        Me.PSVData.Text = "3.31"
        Me.PSVData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Setup
        '
        Me.Setup.Location = New System.Drawing.Point(19, 198)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(75, 23)
        Me.Setup.TabIndex = 9
        Me.Setup.Text = "Setup..."
        Me.Setup.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 990
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 75)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.VPInst)
        Me.GroupBox4.Controls.Add(Me.VPAve)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(72, 58)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sampling"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CPInst)
        Me.GroupBox5.Controls.Add(Me.CPAve)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 58)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sampling"
        '
        'CPInst
        '
        Me.CPInst.AutoSize = True
        Me.CPInst.Checked = True
        Me.CPInst.Location = New System.Drawing.Point(6, 16)
        Me.CPInst.Name = "CPInst"
        Me.CPInst.Size = New System.Drawing.Size(57, 17)
        Me.CPInst.TabIndex = 3
        Me.CPInst.TabStop = True
        Me.CPInst.Text = "Instant"
        Me.CPInst.UseVisualStyleBackColor = True
        '
        'CPAve
        '
        Me.CPAve.AutoSize = True
        Me.CPAve.Location = New System.Drawing.Point(6, 36)
        Me.CPAve.Name = "CPAve"
        Me.CPAve.Size = New System.Drawing.Size(44, 17)
        Me.CPAve.TabIndex = 11
        Me.CPAve.Text = "Ave"
        Me.CPAve.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PSInst)
        Me.GroupBox6.Controls.Add(Me.PSAve)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(72, 58)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sampling"
        '
        'PSInst
        '
        Me.PSInst.AutoSize = True
        Me.PSInst.Checked = True
        Me.PSInst.Location = New System.Drawing.Point(6, 16)
        Me.PSInst.Name = "PSInst"
        Me.PSInst.Size = New System.Drawing.Size(57, 17)
        Me.PSInst.TabIndex = 3
        Me.PSInst.TabStop = True
        Me.PSInst.Text = "Instant"
        Me.PSInst.UseVisualStyleBackColor = True
        '
        'PSAve
        '
        Me.PSAve.AutoSize = True
        Me.PSAve.Location = New System.Drawing.Point(6, 36)
        Me.PSAve.Name = "PSAve"
        Me.PSAve.Size = New System.Drawing.Size(44, 17)
        Me.PSAve.TabIndex = 11
        Me.PSAve.Text = "Ave"
        Me.PSAve.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Res_uA)
        Me.GroupBox7.Controls.Add(Me.Res_mA)
        Me.GroupBox7.Location = New System.Drawing.Point(86, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(72, 58)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Resolution"
        '
        'Res_mA
        '
        Me.Res_mA.AutoSize = True
        Me.Res_mA.Checked = True
        Me.Res_mA.Location = New System.Drawing.Point(6, 16)
        Me.Res_mA.Name = "Res_mA"
        Me.Res_mA.Size = New System.Drawing.Size(58, 17)
        Me.Res_mA.TabIndex = 0
        Me.Res_mA.TabStop = True
        Me.Res_mA.Text = "0.1 mA"
        Me.Res_mA.UseVisualStyleBackColor = True
        '
        'Res_uA
        '
        Me.Res_uA.AutoSize = True
        Me.Res_uA.Location = New System.Drawing.Point(6, 36)
        Me.Res_uA.Name = "Res_uA"
        Me.Res_uA.Size = New System.Drawing.Size(47, 17)
        Me.Res_uA.TabIndex = 1
        Me.Res_uA.Text = "1 uA"
        Me.Res_uA.UseVisualStyleBackColor = True
        '
        'FrontPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 233)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Setup)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrontPanel"
        Me.ShowIcon = False
        Me.Text = "picoBench°"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents VPData As System.Windows.Forms.TextBox
    Friend WithEvents VPUnits As System.Windows.Forms.Label
    Friend WithEvents VPInst As System.Windows.Forms.RadioButton
    Friend WithEvents VPChart As System.Windows.Forms.CheckBox
    Friend WithEvents VPAve As System.Windows.Forms.RadioButton
    Friend WithEvents VPLog As System.Windows.Forms.CheckBox
    Friend WithEvents CPChart As System.Windows.Forms.CheckBox
    Friend WithEvents CPLog As System.Windows.Forms.CheckBox
    Friend WithEvents CPUnits As System.Windows.Forms.Label
    Friend WithEvents CPData As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PSLog As System.Windows.Forms.CheckBox
    Friend WithEvents PSWUnits As System.Windows.Forms.Label
    Friend WithEvents PSCUnits As System.Windows.Forms.Label
    Friend WithEvents PSVUnits As System.Windows.Forms.Label
    Friend WithEvents PSWData As System.Windows.Forms.TextBox
    Friend WithEvents PSCData As System.Windows.Forms.TextBox
    Friend WithEvents PSVData As System.Windows.Forms.TextBox
    Friend WithEvents Setup As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents VPCalibrateBtn As System.Windows.Forms.Button
    Friend WithEvents CPCalibrateBtn As System.Windows.Forms.Button
    Friend WithEvents PSCalibrateBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Res_uA As System.Windows.Forms.RadioButton
    Friend WithEvents Res_mA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CPInst As System.Windows.Forms.RadioButton
    Friend WithEvents CPAve As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PSInst As System.Windows.Forms.RadioButton
    Friend WithEvents PSAve As System.Windows.Forms.RadioButton

End Class

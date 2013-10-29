Imports System.IO.Ports
Imports System.IO
Imports System.Text

Public Class FrontPanel
    ' Define picoBench commands
    Public Const VP_INSTANT = 10
    Public Const CP_INSTANT = 11
    Public Const PS_INSTANT = 12
    Public Const VP_AVERAGE = 13
    Public Const CP_AVERAGE = 14
    Public Const PS_AVERAGE = 15
    Public Const VP_RANGE_LO = 22
    Public Const VP_RANGE_HI = 23
    Public Const CP_RANGE_LO = 24
    Public Const CP_RANGE_HI = 25
    Public Const PS_ENABLE = 26
    Public Const PS_STANDBY = 27
    Public Const SAVE_STATE = 28
    Public Const RESTORE_FACTORY_DEFAULT_STATE = 29
    Public Const ARDUINO_RESET = 255

    Public theData As New picoBenchData
    Public theSettings As New SettingsClass
    Dim returnStr As String = ""
    Dim dataAvail As Integer = 0

    Dim VPChartEnabled As Boolean
    Dim CPChartEnabled As Boolean
    Dim PSChartEnabled As Boolean
    Dim VPLogEnabled As Boolean
    Dim CPLogEnabled As Boolean
    Dim PSLogEnabled As Boolean


    Private Sub FrontPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initialize the data to "no data" = "--"
        theData.Initialize()

        'load the configs from a file
        theSettings.Load()

        'set the location of the form to where it was last closed
        Me.Location = theSettings.GetAppWindowLoc()

        'start receiving messages
        InitSerial()

        'Start the timer
        Timer1.Enabled = True
    End Sub

    Public Sub UpdateDisplay()
        ' Update the display controls based on the status reported by the hardware
        ' If the HW reports the power is being output color the button appropriately
        If Mid(theData.GetState, 1, 1) = "E" Then
            PSEnable.Text = "Standby"
            PSEnable.BackColor = Color.Red
        Else
            PSEnable.Text = "Enable"
            PSEnable.BackColor = SystemColors.Control
        End If
        ' Instant vs Averaging for PS sampling
        If Mid(theData.GetState, 2, 1) = "A" Then
            PSAve.Checked = True
        Else
            PSAve.Checked = False
        End If
        If Mid(theData.GetState, 2, 1) = "I" Then
            PSInst.Checked = True
        Else
            PSInst.Checked = False
        End If
        ' Range setting for voltage probe - NOT IMPLEMENTED ON HW YET
        If Mid(theData.GetState, 3, 1) = "u" Then
            'Res_uV.Checked = True
            VPUnits.Text = "mV"
        Else
            'Res_uV.Checked = False
            VPUnits.Text = "Volts"
        End If
        If Mid(theData.GetState, 3, 1) = "m" Then
            'Res_mV.Checked = True
            VPUnits.Text = "Volts"
        Else
            'Res_mV.Checked = False
            VPUnits.Text = "mV"
        End If
        ' Instant vs Averaging for VP sampling
        If Mid(theData.GetState, 4, 1) = "A" Then
            VPAve.Checked = True
        Else
            VPAve.Checked = False
        End If
        If Mid(theData.GetState, 4, 1) = "I" Then
            VPInst.Checked = True
        Else
            VPInst.Checked = False
        End If
        ' Range select for current probe - Implemented in 07OCT2013 and later HW
        If Mid(theData.GetState, 5, 1) = "u" Then
            Res_uA.Checked = True
            CPUnits.Text = "uA"
        Else
            Res_uA.Checked = False
            CPUnits.Text = "mA"
        End If
        If Mid(theData.GetState, 5, 1) = "m" Then
            Res_mA.Checked = True
            CPUnits.Text = "mA"
        Else
            Res_mA.Checked = False
            CPUnits.Text = "uA"
        End If
        'Instant vs Averaging for CP sampling
        If Mid(theData.GetState, 6, 1) = "A" Then
            CPAve.Checked = True
        Else
            CPAve.Checked = False
        End If
        If Mid(theData.GetState, 6, 1) = "I" Then
            CPInst.Checked = True
        Else
            CPInst.Checked = False
        End If

        ' Update the numeric data displays
        VPData.Text = theData.GetVPVolts
        CPData.Text = theData.GetCPAmps
        If Res_uA.Checked And Val(CPData.Text) > 32000 Then
            Label1.Visible = True
            PictureBox2.Visible = True
        Else
            Label1.Visible = False
            PictureBox2.Visible = False
        End If
        PSVData.Text = theData.GetPSVolts
        PSCData.Text = theData.GetPSAmps
        PSWData.Text = theData.GetPSWatts
    End Sub

    Public Sub SaveState()
        'MessageBox.Show("Got to SaveState")
        If SerialPort1.IsOpen Then
            SendSerial("#" & Chr(SAVE_STATE) & Chr(10))
        End If
    End Sub

    Public Sub RestoreDefaults()
        'MessageBox.Show("Got to RestoreDefaults")
        If SerialPort1.IsOpen Then
            SendSerial("#" & Chr(RESTORE_FACTORY_DEFAULT_STATE) & Chr(10))
        End If
    End Sub

    Private Sub VPAve_CheckedChanged(sender As Object, e As EventArgs) Handles VPAve.CheckedChanged
        If SerialPort1.IsOpen Then
            If VPAve.Checked Then SendSerial("#" & Chr(VP_AVERAGE) & Chr(10))
        End If
    End Sub

    Private Sub VPInst_CheckedChanged(sender As Object, e As EventArgs) Handles VPInst.CheckedChanged
        If SerialPort1.IsOpen Then
            If VPInst.Checked Then SendSerial("#" & Chr(VP_INSTANT) & Chr(10))
        End If
    End Sub

    Private Sub CPAve_CheckedChanged_1(sender As Object, e As EventArgs) Handles CPAve.CheckedChanged
        If SerialPort1.IsOpen Then
            If CPAve.Checked Then SendSerial("#" & Chr(CP_AVERAGE) & Chr(10))
        End If
    End Sub

    Private Sub CPInst_CheckedChanged_1(sender As Object, e As EventArgs) Handles CPInst.CheckedChanged
        If SerialPort1.IsOpen Then
            If CPInst.Checked Then SendSerial("#" & Chr(CP_INSTANT) & Chr(10))
        End If
    End Sub

    Private Sub PSAve_CheckedChanged(sender As Object, e As EventArgs) Handles PSAve.CheckedChanged
        If SerialPort1.IsOpen Then
            If PSAve.Checked Then SendSerial("#" & Chr(PS_AVERAGE) & Chr(10))
        End If
    End Sub

    Private Sub PSInst_CheckedChanged_1(sender As Object, e As EventArgs) Handles PSInst.CheckedChanged
        If SerialPort1.IsOpen Then
            If PSInst.Checked Then SendSerial("#" & Chr(PS_INSTANT) & Chr(10))
        End If
    End Sub

    Private Sub Res_mA_CheckedChanged(sender As Object, e As EventArgs) Handles Res_mA.CheckedChanged
        If SerialPort1.IsOpen Then
            If Res_mA.Checked Then
                SendSerial("#" & Chr(CP_RANGE_HI) & Chr(10))
                'CPUnits.Text = "mA"
            End If
        End If
    End Sub

    Private Sub Res_uA_CheckedChanged(sender As Object, e As EventArgs) Handles Res_uA.CheckedChanged
        If SerialPort1.IsOpen Then
            If Res_uA.Checked Then
                SendSerial("#" & Chr(CP_RANGE_LO) & Chr(10))
                'CPUnits.Text = "uA"
            End If
        End If
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        theSettings.Save()
        StopSerial()
    End Sub
    '======================================================================================
    ' Serial Port access code
    '======================================================================================
    Public Sub InitSerial()
        'MessageBox.Show("Got to InitSerial" & theSettings.GetCOMPort())
        If theSettings.GetCOMPort() <> "" Then
            ' Set the timeouts
            SerialPort1.ReadTimeout = 10000

            Try
                If SerialPort1.IsOpen() Then
                    SerialPort1.Close()
                End If

                SerialPort1.PortName = theSettings.GetCOMPort()
                SerialPort1.BaudRate = 115200
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.RequestToSend
                SerialPort1.DtrEnable = True
                SerialPort1.Encoding = System.Text.Encoding.Default

                SerialPort1.Open()

            Catch ex As Exception
                MessageBox.Show("COMport open fail." & vbCrLf & ex.ToString())
                Dim p As System.Diagnostics.Process
                'term myself.
                p = System.Diagnostics.Process.GetCurrentProcess()
                p.Kill()
            End Try
        End If
    End Sub
    Private Sub OpenSerial()

        ' Set the timeouts
        SerialPort1.ReadTimeout = 10000
        If theSettings.GetCOMPort() <> "" Then
            Try
                If SerialPort1.IsOpen() Then
                    SerialPort1.Close()
                    SerialPort1.PortName = theSettings.GetCOMPort()
                End If
                SerialPort1.Open()


            Catch ex As Exception
                MessageBox.Show("COMport open fail." & vbCrLf & ex.ToString())
                Dim p As System.Diagnostics.Process
                'term myself.
                p = System.Diagnostics.Process.GetCurrentProcess()
                p.Kill()
            End Try
        End If
    End Sub
    Private Sub SendSerial(ByVal msgString As String)
        If Not SerialPort1.IsOpen Then
            OpenSerial()
        End If
        SerialPort1.Write(msgString)
    End Sub
    ' Handles SerialPort Datarecieved
    Private Sub _SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) _
    Handles SerialPort1.DataReceived
        If SerialPort1.IsOpen Then
            returnStr = SerialPort1.ReadLine() & vbCrLf
            'timestamp in seconds.  Ticks are 100nS.  Divide by 10 million to get seconds.
            Dim timeStamp As String = (My.Computer.Clock.LocalTime.Ticks / 10000000).ToString("F0")
            returnStr = timeStamp & "," & returnStr
            dataAvail += 1
        End If
    End Sub
    Public Function CheckForMessage() As Boolean
        If dataAvail > 0 Then
            dataAvail -= 1
            If dataAvail > 0 Then
                'MsgBox("We missed a message! " & dataAvail.ToString)
                dataAvail = 0
            End If
            Return True
        End If
        Return False
    End Function
    Public Sub StopSerial()
        Try
            SerialPort1.Close()
        Catch ex As Exception
            'Could be that SerialPort1 has already gone away on it's own.
            'If so, just ignore the exception.
        End Try
    End Sub
    '=======================================================================================
    ' End of Serial Port Code
    '=======================================================================================

    '============================================================
    ' Once a second the timer fires and triggers this method which in turn
    ' tells other components to do their stuff.  It calculates minute,
    ' 15 minute and hourly events and calls the components needing to do
    ' work on those intervals.
    ' 
    ' The main display updates every second.
    ' The strip chart recorder updates on the minute with additional work
    '    every 15 minutes and on the hour.
    '============================================================
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Get the time before it changes
        Dim now As DateTime = My.Computer.Clock.LocalTime
        Dim minutes As Integer = now.Minute()
        Dim seconds As Integer = now.Second()


        'Do on-the-second stuff here
        If CheckForMessage() Then
            theData.Parse(returnStr)
            VPStripChartForm.NewValue(returnStr)
            CPStripChartForm.NewValue(returnStr)
            If VPLogEnabled Then LogVPData(now.ToLongTimeString, theData.GetVPVolts.ToString)
            If CPLogEnabled Then LogCPData(now.ToLongTimeString, theData.GetCPAmps.ToString)
            If PSLogEnabled Then LogPSData(now.ToLongTimeString, theData.GetPSVolts.ToString, theData.GetPSAmps.ToString)
        End If
        UpdateDisplay()

        'Calculate the longer term stuff
        If seconds = 0 Then
            If minutes = 0 Then
                'Do on-the-hour stuff
                'MsgBox(now.ToShortTimeString() & ", on the hour, DO!")
                VPStripChartForm.OnTheHourDo()
                CPStripChartForm.OnTheHourDo()

            End If

            If minutes Mod 15 = 0 Then
                'Do on-the-quarter-hour stuff
                'MsgBox(now.ToShortTimeString() & ", on the quarter hour, DO!")
                VPStripChartForm.OnTheQHourDo()
                CPStripChartForm.OnTheQHourDo()

            End If

            'Do on-the-minute stuff
            'MsgBox(now.ToShortTimeString() & ", on the minute, DO!")
            VPStripChartForm.OnTheMinuteDo(now)
            CPStripChartForm.OnTheMinuteDo(now)

        End If
    End Sub

    Private Sub Setup_Click(sender As Object, e As EventArgs) Handles Setup.Click
        theSettings.Edit()
        OpenSerial()
    End Sub

    Private Sub VPChart_CheckedChanged(sender As Object, e As EventArgs) Handles VPChart.CheckedChanged
        If VPChart.Checked = True Then
            VPChartEnabled = True
            VPStripChartForm.Restart()
            VPStripChartForm.Show()
        Else
            VPChartEnabled = False
            VPStripChartForm.Hide()
        End If
    End Sub

    Private Sub CPChart_CheckedChanged(sender As Object, e As EventArgs) Handles CPChart.CheckedChanged
        If CPChart.Checked = True Then
            CPChartEnabled = True
            CPStripChartForm.Restart()
            CPStripChartForm.Show()
        Else
            CPChartEnabled = False
            CPStripChartForm.Hide()
        End If
    End Sub

    Private Sub VPLog_CheckedChanged(sender As Object, e As EventArgs) Handles VPLog.CheckedChanged
        If VPLog.Checked = True Then
            ' Displays a SaveFileDialog so the user can choose where to save the data
            Dim thePath As String = theSettings.GetVPLogFilePath()
            Dim saveFileDialogVP As New SaveFileDialog()
            'Filter will allow listing of all files, but the log file will always be written as text
            saveFileDialogVP.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            saveFileDialogVP.FilterIndex = 1
            saveFileDialogVP.Title = "Save Voltage Probe Measurements to File"
            saveFileDialogVP.InitialDirectory = Path.GetDirectoryName(thePath)
            saveFileDialogVP.FileName = "VPLog.txt"
            saveFileDialogVP.RestoreDirectory = True
            saveFileDialogVP.OverwritePrompt = True

            ' If the user clicked "Open" then get the filename
            If saveFileDialogVP.ShowDialog() = DialogResult.OK Then
                'Then we have a full path
                Dim filepath As String = saveFileDialogVP.FileName

                'If the file already exists then delete it so we can start over.
                If File.Exists(filepath) Then File.Delete(filepath)

                'Now create the new file and write the data
                Dim stream As FileStream = File.OpenWrite(filepath)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes("Starting Voltage Probe Logging" & vbCrLf)
                stream.Write(info, 0, info.Length)
                stream.Close()
                'Save the file name away in Settings so we can access it later
                theSettings.SetVPLogFilePath(filepath)
                '==================================================
                VPLogEnabled = True
            Else
                VPLogEnabled = False
                VPLog.Checked = False
            End If
        Else
            VPLogEnabled = False
        End If
    End Sub

    Private Sub LogVPData(ByVal timestamp As String, ByVal vpdata As String)
        Dim stream As FileStream = File.OpenWrite(theSettings.GetVPLogFilePath())
        'tack it on the end
        stream.Seek(0, SeekOrigin.End)
        Dim data As String = timestamp & "," & vpdata & vbCrLf
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(data)
        stream.Write(info, 0, info.Length)
        stream.Close()
    End Sub

    Private Sub CPLog_CheckedChanged(sender As Object, e As EventArgs) Handles CPLog.CheckedChanged
        If CPLog.Checked = True Then
            ' Displays a SaveFileDialog so the user can choose where to save the data
            Dim thePath As String = theSettings.GetCPLogFilePath()
            Dim saveFileDialogCP As New SaveFileDialog()
            'Filter will allow listing of all files, but the log file will always be written as text
            saveFileDialogCP.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            saveFileDialogCP.FilterIndex = 1
            saveFileDialogCP.Title = "Save Current Probe Measurements to File"
            saveFileDialogCP.InitialDirectory = Path.GetDirectoryName(thePath)
            saveFileDialogCP.FileName = "CPLog.txt"
            saveFileDialogCP.RestoreDirectory = True
            saveFileDialogCP.OverwritePrompt = True

            ' If the user clicked "Open" then get the filename
            If saveFileDialogCP.ShowDialog() = DialogResult.OK Then
                'Then we have a full path
                Dim filepath As String = saveFileDialogCP.FileName

                'If the file already exists then delete it so we can start over.
                If File.Exists(filepath) Then File.Delete(filepath)

                'Now create the new file and write the data
                Dim stream As FileStream = File.OpenWrite(filepath)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes("Starting Current Probe Logging" & vbCrLf)
                stream.Write(info, 0, info.Length)
                stream.Close()
                'Save the file name away in Settings so we can access it later
                theSettings.SetCPLogFilePath(filepath)
                '==================================================
                CPLogEnabled = True
            Else
                CPLogEnabled = False
                CPLog.Checked = False
            End If
        Else
            CPLogEnabled = False
        End If
    End Sub

    Private Sub LogCPData(ByVal timestamp As String, ByVal cpdata As String)
        Dim stream As FileStream = File.OpenWrite(theSettings.GetCPLogFilePath())
        'tack it on the end
        stream.Seek(0, SeekOrigin.End)
        Dim data As String = timestamp & "," & cpdata & vbCrLf
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(data)
        stream.Write(info, 0, info.Length)
        stream.Close()
    End Sub

    Private Sub PSLog_CheckedChanged(sender As Object, e As EventArgs) Handles PSLog.CheckedChanged
        If PSLog.Checked = True Then
            ' Displays a SaveFileDialog so the user can choose where to save the data
            Dim thePath As String = theSettings.GetPSLogFilePath()
            Dim saveFileDialogPS As New SaveFileDialog()
            'Filter will allow listing of all files, but the log file will always be written as text
            saveFileDialogPS.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            saveFileDialogPS.FilterIndex = 1
            saveFileDialogPS.Title = "Save Voltage Probe Measurements to File"
            saveFileDialogPS.InitialDirectory = Path.GetDirectoryName(thePath)
            saveFileDialogPS.FileName = "PSLog.txt"
            saveFileDialogPS.RestoreDirectory = True
            saveFileDialogPS.OverwritePrompt = True

            ' If the user clicked "Open" then get the filename
            If saveFileDialogPS.ShowDialog() = DialogResult.OK Then
                'Then we have a full path
                Dim filepath As String = saveFileDialogPS.FileName

                'If the file already exists then delete it so we can start over.
                If File.Exists(filepath) Then File.Delete(filepath)

                'Now create the new file and write the data
                Dim stream As FileStream = File.OpenWrite(filepath)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes("Starting Power Supply Logging" & vbCrLf)
                stream.Write(info, 0, info.Length)
                stream.Close()
                'Save the file name away in Settings so we can access it later
                theSettings.SetPSLogFilePath(filepath)
                '==================================================
                PSLogEnabled = True
            Else
                PSLogEnabled = False
                PSLog.Checked = False
            End If
        Else
            PSLogEnabled = False
        End If
    End Sub

    Private Sub LogPSData(ByVal timestamp As String, ByVal vdata As String, ByVal cdata As String)
        Dim stream As FileStream = File.OpenWrite(theSettings.GetPSLogFilePath())
        'tack it on the end
        stream.Seek(0, SeekOrigin.End)
        Dim data As String = timestamp & "," & vdata & "," & cdata & vbCrLf
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(data)
        stream.Write(info, 0, info.Length)
        stream.Close()
    End Sub

    Public Sub StopVPChart()
        VPChart.Checked = False
    End Sub

    Public Sub StopCPChart()
        CPChart.Checked = False
    End Sub

    Private Sub PSEnable_Click(sender As Object, e As EventArgs) Handles PSEnable.Click
        If SerialPort1.IsOpen Then
            If PSEnable.Text = "Enable" Then
                'Button1.Text = "Standby"
                SendSerial("#" & Chr(PS_ENABLE) & Chr(10))
                'Button1.BackColor = Color.Red
            Else
                'Button1.Text = "Enable"
                SendSerial("#" & Chr(PS_STANDBY) & Chr(10))
                'Button1.BackColor = SystemColors.Control
            End If
        End If
    End Sub
End Class

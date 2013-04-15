Public Class CPStripChartForm
    Dim oldYCoord As Integer = Nothing
    Dim tickCtr As Integer = 0
    Dim drawTick As Boolean = False
    Dim drawMinorTick As Boolean = False
    Dim timeStampDate As DateTime
    Dim timeStampString As String = ""

    Dim minScale As Decimal = 0.0
    Dim maxScale As Decimal = 1250.0
    Dim grid As Decimal = 200.0
    Dim chartTitle As String = "Current Probe  "
    Dim unitString As String = "mA"

    Dim aggValue As Decimal = 0
    Dim valueCount As Integer = 0

    '============================================================
    ' This routine gets called every time a message arrives with new data.
    ' The data is summed and the number of data points counted
    ' so that the average value can be calculated (or in the case of Peak Wind Speed
    ' the max value is taken)
    '============================================================
    Public Sub NewValue(ByVal msgString As String)
        Dim msgArray As String() = msgString.Split(New [Char]() {","c})
        If msgArray.Length > 3 Then
            If msgArray.Length = 9 And msgArray(1) = "!" And msgArray(2) = "3" Then
                aggValue += Val(FrontPanel.theData.GetCPAmps())
                valueCount += 1
            End If
        End If
    End Sub

    Private Sub DrawNextDataPoint(ByVal time As DateTime)

        ' Make the Bitmap and Graphics objects.
        Dim cntlWidth As Integer = PictureBox1.ClientSize.Width
        Dim cntlHeight As Integer = PictureBox1.ClientSize.Height
        Dim myBitMap As New Bitmap(cntlWidth, cntlHeight)
        Dim graph As Graphics = Graphics.FromImage(myBitMap)
        Dim myFont As New Font("Arial", 8)
        Dim myBrush As New SolidBrush(Color.Gainsboro)
        Dim myTtlBrush As New SolidBrush(Color.Gray)
        Dim whiteBrush As New SolidBrush(Color.White)

        If tickCtr = Nothing Then tickCtr = 0

        tickCtr += 1

        ' If it's time to draw the major tickmarks and scale then reset the tick counter
        If (drawTick = True) Then
            tickCtr = 0
        End If


        ' Move the old image one pixel to the left.
        graph.DrawImage(PictureBox1.Image, -1, 0)

        ' Erase the right edge
        graph.DrawLine(Pens.White, cntlWidth - 1, 0, cntlWidth - 1, cntlHeight - 1)

        ' Draw the scale grid lines, scale values and time tickmarks
        For i As Decimal = 0 To maxScale Step grid
            If i >= minScale Then
                Dim y As Integer = cntlHeight - 1 - ((i - minScale) / (maxScale - minScale)) * cntlHeight
                graph.DrawLine(Pens.Gainsboro, cntlWidth - 2, y, cntlWidth - 1, y)
                If drawTick Then 'Draw a major (hourly) tick mark
                    graph.DrawLine(Pens.Gainsboro, cntlWidth - 1, y - 3, cntlWidth - 1, y + 3)
                    timeStampString = time.ToShortTimeString()
                End If
                If drawMinorTick Then 'Draw a minor (quarter hour) tick mark
                    graph.DrawLine(Pens.Gainsboro, cntlWidth - 1, y - 1, cntlWidth - 1, y + 1)
                End If
                ' Draw the scale value
                graph.DrawString(i.ToString() & unitString, myFont, myBrush, cntlWidth - 1 - tickCtr, y)
            End If
        Next i

        ' Draw the time value
        graph.DrawString(timeStampString, myFont, myBrush, cntlWidth - 1 - tickCtr, cntlHeight - 13)

        ' Plot a new pixel.
        If valueCount <> 0 Then 'If there were no new values this period then don't plot anything.
            Dim yCoord As Integer = cntlHeight - 1 - ((aggValue / valueCount - minScale) / (maxScale - minScale)) * cntlHeight
            If oldYCoord = Nothing Then oldYCoord = yCoord
            graph.DrawLine(Pens.Black, cntlWidth - 2, oldYCoord, cntlWidth - 1, yCoord)
            oldYCoord = yCoord
        End If

        ' Draw the title
        graph.FillRectangle(whiteBrush, 0, 0, 250, 16)
        graph.DrawString(chartTitle & time.ToShortDateString(), myFont, myTtlBrush, 0, 0)

        ' Display the result.
        PictureBox1.Image = myBitMap
        PictureBox1.Refresh()

        ' Release the drawing resources
        graph.Dispose()

        ' Set up to start averaging for the next plot point
        aggValue = 0
        valueCount = 0

        ' Reset the flags so we don't draw the tick marks every data point
        drawTick = False
        drawMinorTick = False
    End Sub

    Public Sub OnTheMinuteDo(ByVal time As DateTime)
        DrawNextDataPoint(time)
    End Sub

    Public Sub OnTheQHourDo()
        drawMinorTick = True
    End Sub

    Public Sub OnTheHourDo()
        drawTick = True
    End Sub

    Private Sub StripChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub copyBtn_Click(sender As Object, e As EventArgs) Handles copyBtn.Click
        Clipboard.SetDataObject(PictureBox1.Image, True)
    End Sub

    Public Sub Restart()
        'reset the drawing variables
        oldYCoord = Nothing
        tickCtr = 0
        drawTick = False
        drawMinorTick = False

        aggValue = 0
        valueCount = 0

        'Restart the display
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Chart_Background")
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        FrontPanel.StopCPChart()
    End Sub
End Class
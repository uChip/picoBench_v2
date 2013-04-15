Imports System.IO.Ports

Public Class SetupForm
    Dim comPort As String

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
        If FrontPanel.theSettings.GetCOMPort() <> "" Then
            ComboBox1.SelectedItem = FrontPanel.theSettings.GetCOMPort()
        Else
            ComboBox1.SelectedItem = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        comPort = ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub AcceptBtn_Click(sender As Object, e As EventArgs) Handles AcceptBtn.Click
        FrontPanel.theSettings.SetCOMPort(comPort)
        FrontPanel.InitSerial()

        Me.Close()
    End Sub

End Class
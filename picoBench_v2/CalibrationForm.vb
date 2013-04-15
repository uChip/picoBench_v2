Public Class CalibrationForm

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub AcceptBtn_Click(sender As Object, e As EventArgs) Handles AcceptBtn.Click
        'Calibrate the measurements based on the new data

        'and close the dialog
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        'and close the dialog
        Me.Close()
    End Sub
End Class
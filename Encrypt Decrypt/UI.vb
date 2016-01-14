Public Class UI
    Private eng As New Engine

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        txtOutput.Text = eng.doEncryption(Me.txtInput.Text)
    End Sub
End Class

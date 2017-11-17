Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim IntAge As Double
        Try
            IntAge = txtAgeInput.Text
            If IntAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf IntAge >= 10 And IntAge < 14 Then
                lblResult.Text = 
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAgeInput.Clear()
        lblResult.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

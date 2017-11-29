Public Class Form1

    Private Sub btnCalculateResults_Click(sender As Object, e As EventArgs) Handles btnCalculateResults.Click
        Dim
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRunner1.Clear()
        txtRunner2.Clear()
        txtRunner3.Clear()
        txtTime1.Clear()
        txtTime2.Clear()
        txtTime3.Clear()
        lblFirstPlace.Text = String.Empty
        lblSecondPlace.Text = String.Empty
        lblThirdPlace.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

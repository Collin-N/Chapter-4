Public Class Form1


    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Select Case True
            Case (txtStartingNumber.Text = 1)
                lblResult.Text = "I"
            Case (txtStartingNumber.Text = 2)
                lblResult.Text = "II"
            Case (txtStartingNumber.Text = 3)
                lblResult.Text = "III"
            Case (txtStartingNumber.Text = 4)
                lblResult.Text = "IV"
            Case (txtStartingNumber.Text = 5)
                lblResult.Text = "V"
            Case (txtStartingNumber.Text = 6)
                lblResult.Text = "VI"
            Case (txtStartingNumber.Text = 7)
                lblResult.Text = "VII"
            Case (txtStartingNumber.Text = 8)
                lblResult.Text = "VIII"
            Case (txtStartingNumber.Text = 9)
                lblResult.Text = "IX"
            Case (txtStartingNumber.Text = 10)
                lblResult.Text = "X"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

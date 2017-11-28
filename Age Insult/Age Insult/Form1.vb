Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim IntAge As Double
        Try
            IntAge = txtAgeInput.Text
            If IntAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf IntAge >= 10 And IntAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are"
            ElseIf IntAge >= 14 And IntAge < 18 Then
                lblResult.Text = "You have no clue how the real world works"
            End If
            Select Case IntAge
                Case 18 To 23
                    lblResult.Text = "Get a Job"
                Case 24 To 29
                    lblResult.Text = "living in your parents basement still?"
                Case 30 To 40
                    lblResult.Text = "getting up there"
                Case 41 To 60
                    lblResult.Text = "feel old yet?"
                Case 60 To 150
                    lblResult.Text = "remember when computers took up an entire room?"
            End Select


        Catch ex As Exception
            lblMessage.Text = "Enter a numeric value"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAgeInput.Clear()
        lblResult.Text = String.Empty
        lblMessage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

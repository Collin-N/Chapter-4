Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intStartIndex As Integer
        Dim intFoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If txtToFind.Text.Length > 0 Then
                intStartIndex = CInt(txtStartIndex.Text)
                intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)
            End If
            If intFoundIndex = -1 Then
                lblResults.Text = "There is no String"
            Else
                lblResults.Text = "The String was Found at index " & intFoundIndex
            End If
        Else
            MessageBox.Show("Enter a string to search for. ")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblResult
        lblString
        txtStartIndex
        txtToFind
    End Sub
End Class

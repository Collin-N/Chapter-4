Public Class Form1

 
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim Price(10) As Double
        If RBCheesePizza.Checked = True Then
            lblResult.Text = "You Selected Cheese Pizza"
        ElseIf RBPepperoni.Checked = True Then
            lblResult.Text = "You Selected Pepperoni Pizza"
        ElseIf RBSausage.Checked = True Then
            lblResult.Text = "You Selected Sausage Pizza"
        ElseIf RBPineapple.Checked = True Then
            lblResult.Text = "You Selected Pineapple Pizza"
        End If
        If CBBreadSticks.Checked = True Then
            lblResult.Text &= " , with breadsticks"
        ElseIf CBCheese.Checked = True Then
            lblResult.Text &= " , with Cheese"
        ElseIf CBCheeseSticks.Checked = True Then
            lblResult.Text &= " , with Cheese Sticks"
        End If
        If RBBaconFlakes.Checked = True Then
            lblResult.Text &= " , and bacon Flakes"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

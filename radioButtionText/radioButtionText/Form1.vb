Public Class Form1

 
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim Price(9) As Double
        Dim total As Double
        Price(0) = 5.99
        Price(1) = 6.99
        Price(2) = 7.77
        Price(3) = 3.99
        Price(4) = 5.55
        Price(5) = 99.99
        If RBCheesePizza.Checked = True Then
            lblResult.Text = "You Selected Cheese Pizza"
            total += Price(0)
        ElseIf RBPepperoni.Checked = True Then
            lblResult.Text = "You Selected Pepperoni Pizza"
            total += Price(1)
        ElseIf RBSausage.Checked = True Then
            lblResult.Text = "You Selected Sausage Pizza"
            total += Price(1)
        ElseIf RBPineapple.Checked = True Then
            lblResult.Text = "You Selected Pineapple Pizza"
            total += Price(2)
        End If
        If CBBreadSticks.Checked = True Then
            lblResult.Text &= " , with breadsticks"
            total += Price(3)
        End If
        If CBCheese.Checked = True Then
            lblResult.Text &= " , with Cheese"
            total += Price(4)
        End If
        If CBCheeseSticks.Checked = True Then
            lblResult.Text &= " , with Cheese Sticks"
            total += Price(3)
        End If
        If RBBaconFlakes.Checked = True Then
            lblResult.Text &= " , and bacon Flakes"
            total += Price(5)
        ElseIf RBGoldShaveings.Checked = True Then
            lblResult.Text &= " , and gold shavings"
            total += Price(5)
        ElseIf RBCheese.Checked = True Then
            lblResult.Text &= " , and more cheese"
            total += Price(4)
        End If
        lblResult.Text &= " for $" + Str(total)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

Public Class Form1

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        '1) Declare variables
        Const PIZZA As Single = 10.5
        Const BURGER As Single = 7.5
        Const FRIES As Single = 5.49
        Const SALAD As Single = 5.49
        Const CAKE As Single = 15.99
        Const ICECREAM As Single = 12.99
        Dim sngPrice As Single = 0

        If (radPizza.Checked = True) Then
            sngPrice = sngPrice + PIZZA
        ElseIf (radBurger.Checked = True) Then
            sngPrice = sngPrice + BURGER
        End If

        If (radFries.Checked = True) Then
            sngPrice = sngPrice + FRIES
        ElseIf (radSalad.Checked = True) Then
            sngPrice = sngPrice + SALAD
        End If

        If (radCake.Checked = True) Then
            sngPrice = sngPrice + CAKE
        ElseIf (radIceCream.Checked = True) Then
            sngPrice = sngPrice + ICECREAM
        End If

        If (chkPercent.checked = True) Then
            sngPrice = sngPrice - (sngPrice * 0.1)
        End If

        If (chkDiscount.Checked = True) And (sngPrice >= 15) Then
            sngPrice = sngPrice - 2
        End If

        '3) Display
        lblPrice.Text = "Cost: " & sngPrice

    End Sub
End Class

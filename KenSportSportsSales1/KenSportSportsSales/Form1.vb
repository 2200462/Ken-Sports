Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTFootballs.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TXTVolleyballs.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TXTTotalitems.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNcheckout.Click
        '---------------------------------Variable Declaration & Calculation-----------------------------------------------------------------------------------'
        Dim Footballs As Integer = TXTFootballs.Text
        Dim Basketballs As Integer = TXTBasketballs.Text
        Dim Volleyballs As Integer = TXTVolleyballs.Text
        Dim Totalitems As Integer = Footballs + Basketballs + Volleyballs
        Dim Priceone As Integer = 44 * Footballs
        Dim Pricetwo As Integer = 49 * Basketballs
        Dim Pricethree As Integer = 39 * Volleyballs
        Dim Subtotal As Integer = Priceone + Pricetwo + Pricethree
        Dim Tax As Decimal = (5 / 100) * Subtotal
        Dim TotalSales As Decimal = Subtotal + Tax
        '-------------------------------------Output Display---------------------------------------------------------------------------------------------------------------'
        TXTTotalitems.Text = Totalitems.ToString
        TXTfirstprice.Text = Priceone.ToString
        TXTSecondprice.Text = Pricetwo.ToString
        TXTThirdprice.Text = Pricethree.ToString
        TXTSubtotal.Text = Subtotal.ToString
        TXTTax.Text = Tax.ToString
        TXTTotalsales.Text = TotalSales.ToString



    End Sub

    Private Sub TXT44_TextChanged(sender As Object, e As EventArgs) Handles TXTfirstprice.TextChanged

    End Sub
End Class

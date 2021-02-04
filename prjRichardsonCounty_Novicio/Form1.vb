Public Class Form1


    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim propertyValue As Decimal
        Dim propertyTax As Decimal
        propertyValue = Val(txtAV.Text)
        propertyTax = propertyValue * 0.03
        txtTax.Text = FormatCurrency(propertyTax, 2)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalculate.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        PrintForm1.Print()
        btnCalculate.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTax.Text = ""
        txtAV.Text = ""
        txtName.Text = ""

        txtAV.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged

    End Sub

    Private Sub txtAV_TextChanged(sender As Object, e As EventArgs) Handles txtAV.TextChanged

    End Sub
End Class

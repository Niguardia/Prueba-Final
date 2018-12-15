Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim precio, cantidad, subtotal, descuento, total As Integer

        precio = ComboPrecioPorUnidad.Text
        cantidad = CampoCantidad.Text
        LabelSubtotal.Text = ComboPrecioPorUnidad.Text * CampoCantidad.Text

        If cantidad <= 11 Then
            LabelDescuento.Text = ("No Aplica")
            LabelTotal.Text = LabelSubtotal.Text
        Else
            LabelDescuento.Text = (LabelSubtotal.Text / 100 * 10)
            LabelTotal.Text = LabelSubtotal.Text - LabelDescuento.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Tabla1TableAdapter.Fill(Me.Database1DataSet.Tabla1)
        Label23.Text = Date.Now
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles fecha.TextChanged
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class

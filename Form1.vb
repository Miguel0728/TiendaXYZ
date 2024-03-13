Public Class Form1
    'MIGUEL A. MELENDEZ
    'Y00598196
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        'Variables
        Dim NombreDeProducto As String
        Dim NumeroDeProducto As Integer
        Dim Costo, Total, PrecioDeVenta, Ganancia, IncomeTax As Double


        'Constante
        Const Tax As Double = 0.115
        Const Descuento As Double = 0.02
        Const Ganancia_Mayor As Double = 0.2
        Const Ganancia_Menor As Double = 0.15

        Try
            If Double.TryParse(txtCosto.Text, Costo) Then
                Select Case Costo
                    Case > 125
                        Ganancia = Costo * Ganancia_Mayor
                        PrecioDeVenta = Costo + Ganancia
                    Case Else
                        Ganancia = Costo * Ganancia_Menor
                        PrecioDeVenta = Costo + Ganancia


                End Select

                'Calculo del Tax
                IncomeTax = (Costo * Tax)
                'Calculo del Precio Final
                Total = PrecioDeVenta + IncomeTax

                'Aplicar Descuento
                If rbOnline.Checked Then
                    Total = (Total + Descuento)
                    lblDescuento.Text = Descuento
                End If

            End If

            NombreDeProducto = txtNombreProducto.Text
            NumeroDeProducto = txtNumeroProducto.Text
            Costo = txtCosto.Text
            lblNombreProducto.Text = NombreDeProducto
            lblCosto.Text = Costo.ToString("c")
            lblNumProducto.Text = NumeroDeProducto
            lblncomeTax.Text = Tax
            lblGanancia.Text = Ganancia
            lblTotal.Text = Total.ToString("c")

        Catch

            MessageBox.Show("Entrar Datos!")

        End Try

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtCosto.Clear()
        txtNombreProducto.Clear()
        txtNumeroProducto.Clear()
        lblDescuento.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class

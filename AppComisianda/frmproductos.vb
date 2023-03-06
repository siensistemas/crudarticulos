Public Class frmproductos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objarticulos As New clsproductos
        Dim strnombre As String
        Dim intprecio As Double

        Try
            strnombre = txtnombre.Text
            intprecio = txtprecio.Text

            objarticulos.Nombre = strnombre
            objarticulos.Precio = CDbl(intprecio)
            If objarticulos.Grabar() Then
                MessageBox.Show(objarticulos.MyError)
            Else
                MessageBox.Show(objarticulos.MyError)
            End If

            objarticulos = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
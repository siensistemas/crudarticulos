Public Class frmeliminarpedidos
    Private Sub BtnEliminarPedido_Click(sender As Object, e As EventArgs) Handles BtnEliminarPedido.Click
        Dim objpedidos As New clspedidos
        Dim id As Integer

        Try
            Dim Resp = MessageBox.Show("Seguro de Eliminar el Documento", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = DialogResult.Yes Then
                id = TxtNumero.Text
                objpedidos.Numero = TxtNumero.Text

                If objpedidos.Eliminar = True Then
                    MessageBox.Show("Registro Eliminado")
                Else
                    MessageBox.Show("Error al Eliminar")
                End If

                objpedidos = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBusqCliente_Click(sender As Object, e As EventArgs) Handles BtnBusqCliente.Click

    End Sub
End Class
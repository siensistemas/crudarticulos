Imports Newtonsoft.Json
Public Class frmclientes
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objclientes As New clsclientes
        Dim strnombre As String
        Dim strcedula As String
        Dim strdireccion As String


        Try
            strnombre = txtnombre.Text
            strcedula = TxtCedula.Text
            strdireccion = txtdireccion.Text

            objclientes.Nombre = strnombre
            objclientes.Cedula = strcedula
            objclientes.Direccion = strdireccion
            If objclientes.Grabar() Then
                MessageBox.Show(objclientes.MyError)
            Else
                MessageBox.Show(objclientes.MyError)
            End If

            objclientes = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim api = New dbapi()

        Try

            Dim url = "https://localhost:8080/eliminarcliente"
            Dim headers = New List(Of Parametro)

            Dim parametros = New List(Of Parametro) From {
              New Parametro("Cedula", TxtCedula.Text)}


            Dim response = api.Post(url, headers, parametros, Nothing)
            Dim result = JsonConvert.DeserializeObject(Of respuesta)(response)

            MessageBox.Show(result.mensaje)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class

Class respuesta
    Public Property mensaje As String
End Class
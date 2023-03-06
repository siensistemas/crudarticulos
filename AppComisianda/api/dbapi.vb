Imports RestSharp
Public Class dbapi
    Public Function Post(url As String, headers As List(Of Parametro), parametros As List(Of Parametro), objecto As Object) As String
        Dim client = New RestClient()
        client.BaseUrl = New Uri(url)

        Dim request = New RestRequest()
        request.Method = Method.POST

        For Each item As Parametro In headers
            request.AddHeader(item.Clave, item.Valor)
        Next

        For Each parametro As Parametro In parametros
            request.AddParameter(parametro.Clave, parametro.Valor)

        Next

        If (parametros.Count = 0) Then
            request.AddJsonBody(objecto)
        End If

        Dim response = client.Execute(request).Content.ToString()
        Return response

    End Function

End Class

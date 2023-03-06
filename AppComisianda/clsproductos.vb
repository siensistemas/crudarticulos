Public Class clsproductos

    Private StrSQL As String
#Region "propiedades"
    Private strNombre As String
    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

    Private intprecio As Double
    Public Property Precio() As Double
        Get
            Return intprecio
        End Get
        Set(ByVal value As Double)
            intprecio = value
        End Set
    End Property

    Private strError As String
    Public Property MyError() As String
        Get
            Return strError
        End Get
        Set(ByVal value As String)
            strError = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Grabar() As Boolean
        If Actualizar() Then
            strError = "Documento Almacenado"
            Return True
        Else
            strError = "StrError: " & strError.ToString
            Return False
        End If
    End Function


    Private Function Actualizar() As Boolean


        Dim objConexionDB As New clsconexion
        'procedimiento almacenado
        StrSQL = "InsertarProductos"
        objConexionDB.SQL = StrSQL

        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@Descripcion", SqlDbType.VarChar, 50, Nombre) = False Then
            strError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If
        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@Precio", SqlDbType.Float, 25, Precio) = False Then
            strError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If


        '' Agrego lo Mismo para Actualizar cada campo

        If objConexionDB.EjecutarSentencia(True) Then
            objConexionDB = Nothing
            Return True
        Else
            strError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If
        Return False
    End Function

#End Region

End Class

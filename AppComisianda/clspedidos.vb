Imports System.Data.SqlClient

Public Class clspedidos
    Private StrSQL As String
    Private strCliente As Integer
    Public Property Cliente() As Integer
        Get
            Return strCliente
        End Get
        Set(ByVal value As Integer)
            strCliente = value
        End Set
    End Property
    Private strProducto As String
    Public Property Producto() As Integer
        Get
            Return strProducto
        End Get
        Set(ByVal value As Integer)
            strProducto = value
        End Set
    End Property

    Private intCantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return intCantidad
        End Get
        Set(ByVal value As Integer)
            intCantidad = value
        End Set
    End Property

    Private intNumero As Integer
    Public Property Numero() As Integer
        Get
            Return intNumero
        End Get
        Set(ByVal value As Integer)
            intNumero = value
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


    Public Function Grabar() As Boolean
        If Actualizar() Then
            strError = "Documento Almacenado"
            Return True
        Else
            strError = "StrError: " & StrError.ToString
            Return False
        End If
    End Function


    Private Function Actualizar() As Boolean


        Dim objConexionDB As New clsconexion
        'procedimiento almacenado
        StrSQL = "InsertarPedidos"
        objConexionDB.SQL = StrSQL

        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@numero", SqlDbType.Int, 10, intNumero) = False Then
            strError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If

        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@idcedula", SqlDbType.Int, 10, strCliente) = False Then
            strError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If

        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@idproducto", SqlDbType.Int, 10, strProducto) = False Then
            StrError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If
        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@cantidad", SqlDbType.Int, 15, Cantidad) = False Then
            StrError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If

        '' Agrego lo Mismo para Actualizar cada campo

        If objConexionDB.EjecutarSentencia(True) Then
            objConexionDB = Nothing
            Return True
        Else
            StrError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If
        Return False
    End Function

    Public Function Eliminar() As Boolean


        Dim objConexionDB As New clsconexion
        'procedimiento almacenado
        StrSQL = "EliminarPedido"
        objConexionDB.SQL = StrSQL

        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@numero", SqlDbType.Int, 10, strCliente) = False Then
            strError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If

        '' Agrego lo Mismo para Actualizar cada campo
        objConexionDB.SQL = StrSQL
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


End Class

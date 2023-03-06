Imports System.IO

Public Class clsclientes


    Private StrSQL As String

    Private strcedula As String
    Public Property Cedula() As String
        Get
            Return strcedula
        End Get
        Set(ByVal value As String)
            strcedula = value
        End Set
    End Property

    Private strNombre As String
    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

    Private strDireccion As String
    Public Property Direccion() As String
        Get
            Return strDireccion
        End Get
        Set(ByVal value As String)
            strDireccion = value
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
        StrSQL = "InsertarClientes"
        objConexionDB.SQL = StrSQL

        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@Cedula", SqlDbType.VarChar, 10, Cedula) = False Then
            StrError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If

        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@Nombre", SqlDbType.VarChar, 150, Nombre) = False Then
            StrError = objConexionDB.StrError
            objConexionDB = Nothing
            Return False
        End If
        If objConexionDB.AgregarParametro(ParameterDirection.Input, "@Direccion", SqlDbType.VarChar, 150, Direccion) = False Then
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

    Public Function Consultar(ByVal Cedula As String) As Boolean
        Dim objUtil As New clsutilidades
        strcedula = Cedula
        If strcedula = "" OrElse strcedula Is Nothing Then
            strError = "No se ha definido la Cedula a consultar"
            Return False
        End If

        objUtil = New clsutilidades
        Dim DtsBuscar As New DataSet

        StrSQL = "Select * from Clientes where Cedula = '" & strcedula & "'"
        objUtil.ConsultaSql = StrSQL
        objUtil.Tabla = "Clientes"
        DtsBuscar = objUtil.LlenarDts

        If DtsBuscar.Tables("Clientes").Rows.Count > 0 Then
            With DtsBuscar.Tables("Clientes").Rows(0)
                strcedula = .Item("CEDULA")
                strNombre = .Item("NOMBRE").ToString
                strDireccion = .Item("DIRECCION").ToString
            End With
            Return True
            DtsBuscar.Clear()
        Else
            strError = DtsBuscar.HasErrors
            DtsBuscar.Clear()
            Return False
        End If
    End Function

End Class

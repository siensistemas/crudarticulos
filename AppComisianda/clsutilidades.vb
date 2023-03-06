Imports System.Data.SqlClient

Public Class clsutilidades
    Private StrSQL As String
    Private StrError As String
    Public Property ConsultaSql() As String
        Get
            Return StrSQL
        End Get
        Set(ByVal value As String)
            StrSQL = value
        End Set
    End Property
    Private strResultado As String
    Public Property Resultado As String
        Get
            Return strResultado
        End Get
        Set(ByVal value As String)
            strResultado = value
        End Set
    End Property
    Private strTabla As String
    Public Property Tabla() As String
        Get
            Return strTabla
        End Get
        Set(ByVal value As String)
            strTabla = value
        End Set
    End Property

    Private strCombo As String
    Public Property ElCombo() As String
        Get
            Return strCombo
        End Get
        Set(ByVal value As String)
            strCombo = value
        End Set
    End Property



    Public Function Actualizar() As Boolean
        Dim objConexionDB As New clsconexion()
        Try
            '  objConexionDB.AbrirTransaccion()
            objConexionDB.SQL = StrSQL
            If objConexionDB.EjecutarSentencia(False) Then
                objConexionDB.CerrarConexion()
                objConexionDB = Nothing
                Return True
            Else
                StrError = objConexionDB.StrError
                objConexionDB.CerrarConexion()
                objConexionDB = Nothing
                Return False
            End If
            objConexionDB.CerrarConexion()
        Catch ex As Exception
            StrError = objConexionDB.StrError
            objConexionDB.CerrarConexion()
            objConexionDB = Nothing
            Return False
        End Try
    End Function

    Public Function LlenarDts() As DataSet
        Try
            Dim objConexion As New clsconexion
            Dim objDts As New DataSet   'Dim objDts As New DataSet
            objConexion.SQL = StrSQL
            objConexion.NombreTabla = strTabla
            If objConexion.LlenarDataSet(False) Then
                objDts = objConexion.MiDataSet
                objConexion.CerrarConexion()
                objConexion = Nothing
                Return objDts
            Else
                StrError = objConexion.StrError
                objConexion.CerrarConexion()
                objConexion = Nothing
                Return Nothing
            End If
        Catch ex As Exception
            StrError = ex.Message
            Return Nothing
        End Try
    End Function



End Class

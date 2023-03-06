Imports System.Data.SqlClient

Public Class clsconexion

#Region "Variables"

    Private blnAbrio As Boolean
    Private objCommand As SqlCommand
    Private objconexiondb As SqlConnection
    Private objparametro As SqlParameter
    Private mitransaccion As SqlTransaction
    Private CantRegistros As Integer
    Private Devolucion As Boolean
    Private objadapter As SqlDataAdapter
    Private objDataSet As DataSet

    Private strconexion As String = "Data Source=.\SQLEXPRESS;Initial Catalog=articlesdb;User Id=sa;Password=;Integrated Security=True"

    Private strNombreTabla As String
    Public Property NombreTabla() As String
        Get
            Return strNombreTabla
        End Get
        Set(ByVal value As String)
            strNombreTabla = value
        End Set
    End Property

    Private MyError As String
    Public Property StrError() As String
        Get
            Return MyError
        End Get
        Set(ByVal value As String)
            MyError = value
        End Set
    End Property



    Private strSQL As String
    Public Property SQL() As String
        Get
            Return strSQL
        End Get
        Set(ByVal value As String)
            strSQL = value
        End Set
    End Property

    Private StringConexion As String
    Public Property strStringConexion() As String
        Get
            Return StringConexion
        End Get
        Set(ByVal value As String)
            StringConexion = value
        End Set
    End Property

#End Region

    Public Sub clsConexiondb()
        objCommand = New SqlCommand
        objconexiondb = New SqlConnection
        objparametro = New SqlParameter
        objadapter = New SqlDataAdapter

    End Sub



    Private Function AbrirConexion() As Boolean
        objconexiondb.ConnectionString = strconexion
        Try
            If objconexiondb.State = ConnectionState.Closed Then
                objconexiondb.Open()
                blnAbrio = True
                Return True
            End If
        Catch ex As Exception
            blnAbrio = False
            Return False
        End Try
        Return False
    End Function

    Public Function AgregarParametro(Direccion As ParameterDirection, Nombre As String, TipoDato As SqlDbType, Tamano As Short, Valor As Object) As Boolean

        Try
            objparametro.Direction = Direccion
            objparametro.ParameterName = Nombre
            objparametro.SqlDbType = TipoDato
            objparametro.Size = Tamano
            objparametro.Value = Valor
            objCommand.Parameters.Add(objparametro)
            objparametro = New SqlParameter()
            Return True
        Catch ex As Exception
            strError = ex.Message
            Return False
        End Try

    End Function

    Public Function EjecutarSentencia(ByVal blnParametros As Boolean) As Boolean
        If strSQL = "" Then
            strError = "No definio la instrucción SQL"
            Return False
        End If

        If Not blnAbrio AndAlso Not AbrirConexion() Then
            Return False
        End If

        objCommand.Connection = objconexiondb
        If blnParametros Then
            objCommand.CommandType = CommandType.StoredProcedure
        Else
            objCommand.CommandType = CommandType.Text
        End If

        objCommand.CommandText = strSQL

        Try
            objCommand.ExecuteNonQuery()
            Return True
        Catch ex As SqlException
            Dim number As Integer = ex.Number
            strError = ex.Message
            Return False
        End Try
    End Function

    Public Function AbrirTransaccion() As Boolean
        If strSQL = "" Then
            strError = "No definio la instrucción SQL"
            Return False
        End If

        If Not blnAbrio AndAlso Not AbrirConexion() Then
            Return False
        End If

        Try
            mitransaccion = objconexiondb.BeginTransaction()
            objCommand.Transaction = mitransaccion
            Return True
        Catch ex As Exception
            strError = ex.Message
            Return False
        End Try
    End Function

    Public Function AceptarTransaccion() As Boolean
        Try
            mitransaccion.Commit()
            Return True
        Catch ex As Exception

            Try
                mitransaccion.Rollback()
                strError = "No se aceptó la transacción" & ex.Message
                Return False
            Catch ex2 As Exception
                strError = "No se aceptó la transacción ni la retrocedio: " & ex2.Message
                Return False
            End Try
        End Try
    End Function

    Public Function RechazarTransaccion() As Boolean
        Try
            mitransaccion.Rollback()
            Return True
        Catch ex As Exception
            strError = "No se retrocedió la transacción: " & ex.Message
            Return False
        End Try
    End Function


    Public Function CerrarConexion() As Boolean
        Try
            objconexiondb.Close()
        Catch ex As Exception
            strError = "No cerró la conexion" & ex.Message
        End Try

        Try
            objconexiondb = Nothing
        Catch ex2 As Exception
            strError = "No liberó la conexion" & ex2.Message
        End Try

        Return True
    End Function

    Public Function EjecutarTransaciones(ByVal ListaSentencias As ArrayList) As Boolean
        Devolucion = False
        AbrirTransaccionArrayList()

        Try

            For Each ListaSentencia As Object In ListaSentencias
                strSQL = ListaSentencia.ToString()

                If EjecutarSentencia(blnParametros:=False) Then
                    CantRegistros += 1
                End If
            Next

            AceptarTransaccion()
            Devolucion = True
        Catch ex As Exception
            strError = ex.Message

            Try
                RechazarTransaccion()
            Catch ex2 As Exception
                strError = ex2.Message
            End Try
        End Try

        Return Devolucion
    End Function

    Public Function AbrirTransaccionArrayList() As Boolean
        If Not blnAbrio AndAlso Not AbrirConexion() Then
            Return False
        End If

        Try
            mitransaccion = objconexiondb.BeginTransaction()
            objCommand.Transaction = mitransaccion
            Return True
        Catch ex As Exception
            strError = ex.Message
            Return False
        End Try
    End Function

    Public Function LlenarDataSet(ByVal blnParametros As Boolean) As Boolean
        If strSQL = "" Then
            StrError = "No definio la instrucción SQL"
            Return False
        End If

        If strNombreTabla = "" Then
            StrError = "No definio el nombre de la tabla"
            Return False
        End If

        If Not blnAbrio AndAlso Not AbrirConexion() Then
            Return False
        End If

        If blnParametros Then
            objCommand.CommandType = CommandType.StoredProcedure
        Else
            objCommand.CommandType = CommandType.Text
        End If

        objCommand.Connection = objconexiondb
        objCommand.CommandText = strSQL
        objCommand.CommandTimeout = 1000

        Try
            objadapter.SelectCommand = objCommand
            objadapter.Fill(objDataSet, strNombreTabla)
            Return True
        Catch ex As Exception
            StrError = ex.Message
            Return False
        End Try
    End Function

    Public ReadOnly Property MiDataSet As DataSet
        Get
            Return objDataSet
        End Get
    End Property
End Class

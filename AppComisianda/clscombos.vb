Public Class clscombos
    Private strNombreTabla As String
    Private strSQL As String
    Private strError As String
    Private strColumnaTexto As String
    Private strColumnaValor As String
    Private cboGenerico As ComboBox
    Private strCodPerfil As String
    Private blnParametros As Boolean


    Public Property RecibirParametros As Boolean
        Get
            Return blnParametros
        End Get
        Set(ByVal value As Boolean)
            blnParametros = value
        End Set
    End Property

    Public Property CodigoPerfil As String
        Get
            Return strCodPerfil
        End Get
        Set(ByVal value As String)
            strCodPerfil = value
        End Set
    End Property

    Public Property comboGenerico As ComboBox
        Get
            Return cboGenerico
        End Get
        Set(ByVal value As ComboBox)
            cboGenerico = value
        End Set
    End Property


    Public Property NombreTabla As String
        Get
            Return strNombreTabla
        End Get
        Set(ByVal value As String)
            strNombreTabla = value
        End Set
    End Property

    Public Property SQL As String
        Get
            Return strSQL
        End Get
        Set(ByVal value As String)
            strSQL = value
        End Set
    End Property

    Public Property ColumnaTexto As String
        Get
            Return strColumnaTexto
        End Get
        Set(ByVal value As String)
            strColumnaTexto = value
        End Set
    End Property

    Public Property ColumnaValor As String
        Get
            Return strColumnaValor
        End Get
        Set(ByVal value As String)
            strColumnaValor = value
        End Set
    End Property

    Public ReadOnly Property MyError As String
        Get
            Return strError
        End Get
    End Property


    Public Function LlenarCombo() As Boolean
        If Validar() Then
            Dim clsConexionBD As clsconexion = New clsconexion()
            clsConexionBD.NombreTabla = strNombreTabla
            clsConexionBD.SQL = strSQL

            If blnParametros AndAlso Not clsConexionBD.AgregarParametro(ParameterDirection.Input, "@perfil", SqlDbType.Char, 7, strCodPerfil) Then
                strError = clsConexionBD.StrError
                Return False
            End If

            If clsConexionBD.LlenarDataSet(blnParametros) Then
                cboGenerico.DataSource = clsConexionBD.MiDataSet.Tables(strNombreTabla)
                cboGenerico.DisplayMember = strColumnaTexto
                cboGenerico.ValueMember = strColumnaValor
                clsConexionBD.CerrarConexion()
                clsConexionBD = Nothing
                Return True
            End If

            strError = clsConexionBD.StrError
            clsConexionBD.CerrarConexion()
            clsConexionBD = Nothing
            Return False
        End If

        Return False
    End Function

    Private Function Validar() As Boolean
        If strSQL = "" Then
            strError = "No definio la instruccion SQL"
            Return False
        End If

        If strColumnaTexto = "" Then
            strError = "No definio el nombre de la columna para el texto del combobox"
            Return False
        End If

        If strColumnaValor = "" Then
            strError = "No definio el nombre de la columna para el valor del combobox"
            Return False
        End If

        If strNombreTabla = "" Then
            strNombreTabla = "Tabla"
        End If

        Return True
    End Function
End Class

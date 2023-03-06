Public Class FrmGenerarPedido
    Private Sub IngresoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeClientesToolStripMenuItem.Click
        frmclientes.Show()
    End Sub

    Private Sub BtnBusqCliente_Click(sender As Object, e As EventArgs) Handles BtnBusqCliente.Click
        Dim ObjUtil As New clsutilidades
        Dim objClientes As New clsclientes
        Try
            objClientes.Cedula = TxtCedula.Text
            If objClientes.Consultar(TxtCedula.Text) Then
                lblnombre.Text = objClientes.Nombre
                lbldireccion.Text = objClientes.Direccion
            Else
                MessageBox.Show(objClientes.MyError)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ObjUtil = Nothing
        End Try
    End Sub

    Private Sub FrmGenerarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ObjLlenarCombo As New clscombos
        ObjLlenarCombo.comboGenerico = cmbproductos
        ObjLlenarCombo.RecibirParametros = False
        ObjLlenarCombo.SQL = "select * from Productos"
        ObjLlenarCombo.NombreTabla = "Productos"
        ObjLlenarCombo.ColumnaTexto = "Nombre"
        ObjLlenarCombo.ColumnaValor = "Id"
        If ObjLlenarCombo.LlenarCombo() Then
            cmbproductos = ObjLlenarCombo.comboGenerico
        Else
            MessageBox.Show(ObjLlenarCombo.MyError)
        End If
    End Sub

    Private Sub btnAlmacenar_Click(sender As Object, e As EventArgs) Handles btnAlmacenar.Click
        Dim objpedidos As New clspedidos
        Dim idcedula As Integer
        Dim idproducto As Integer
        Dim intcantidad As Integer
        Dim intnumero As Integer

        Try
            idcedula = TxtCedula.Text
            idproducto = cmbproductos.SelectedValue.ToString()
            intcantidad = txtcantidad.Text
            intnumero = TxtNumero.Text


            objpedidos.Cliente = idcedula
            objpedidos.Producto = idproducto
            objpedidos.Cantidad = intcantidad
            objpedidos.Numero = intnumero

            If objpedidos.Grabar() Then
                MessageBox.Show(objpedidos.MyError)
                txttotalproductos.Text += txtcantidad.Text
            Else
                MessageBox.Show(objpedidos.MyError)
            End If

            objpedidos = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
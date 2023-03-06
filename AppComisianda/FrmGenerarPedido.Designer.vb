<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarPedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBusqCliente = New System.Windows.Forms.Button()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGDcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCtaIng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCostoProm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbproductos = New System.Windows.Forms.ComboBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.btnAlmacenar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotalproductos = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBusqCliente
        '
        Me.BtnBusqCliente.Location = New System.Drawing.Point(286, 76)
        Me.BtnBusqCliente.Name = "BtnBusqCliente"
        Me.BtnBusqCliente.Size = New System.Drawing.Size(30, 21)
        Me.BtnBusqCliente.TabIndex = 19
        Me.BtnBusqCliente.Text = "..."
        Me.BtnBusqCliente.UseVisualStyleBackColor = True
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(146, 76)
        Me.TxtCedula.MaxLength = 15
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(137, 20)
        Me.TxtCedula.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(48, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cedula del Cliente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Location = New System.Drawing.Point(48, 106)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(96, 13)
        Me.lblnombre.TabIndex = 20
        Me.lblnombre.Text = "Nombre del Cliente"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.BackColor = System.Drawing.Color.Transparent
        Me.lbldireccion.Location = New System.Drawing.Point(48, 121)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(104, 13)
        Me.lbldireccion.TabIndex = 21
        Me.lbldireccion.Text = "Dirección del Cliente"
        Me.lbldireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 28)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Pedido Número: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DGReferencia
        '
        Me.DGReferencia.HeaderText = "Referencia"
        Me.DGReferencia.Name = "DGReferencia"
        Me.DGReferencia.Width = 80
        '
        'DGDescripcion
        '
        Me.DGDescripcion.HeaderText = "Descripcion"
        Me.DGDescripcion.Name = "DGDescripcion"
        Me.DGDescripcion.ReadOnly = True
        Me.DGDescripcion.Width = 230
        '
        'DGCantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DGCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGCantidad.HeaderText = "Cant"
        Me.DGCantidad.Name = "DGCantidad"
        Me.DGCantidad.Width = 40
        '
        'DGDcto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DGDcto.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGDcto.HeaderText = "Dcto"
        Me.DGDcto.Name = "DGDcto"
        Me.DGDcto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDcto.Width = 70
        '
        'DGObservaciones
        '
        Me.DGObservaciones.HeaderText = "Observaciones"
        Me.DGObservaciones.Name = "DGObservaciones"
        Me.DGObservaciones.Width = 150
        '
        'DGEliminar
        '
        Me.DGEliminar.HeaderText = "Eliminar"
        Me.DGEliminar.Name = "DGEliminar"
        Me.DGEliminar.Text = "Eliminar Fila"
        Me.DGEliminar.UseColumnTextForButtonValue = True
        Me.DGEliminar.Width = 80
        '
        'DGCuenta
        '
        Me.DGCuenta.HeaderText = "Cuenta"
        Me.DGCuenta.Name = "DGCuenta"
        Me.DGCuenta.ReadOnly = True
        Me.DGCuenta.Visible = False
        '
        'DGCtaIng
        '
        Me.DGCtaIng.HeaderText = "CuentaIng"
        Me.DGCtaIng.Name = "DGCtaIng"
        Me.DGCtaIng.ReadOnly = True
        Me.DGCtaIng.Visible = False
        '
        'DGLinea
        '
        Me.DGLinea.HeaderText = "TipoLinea"
        Me.DGLinea.Name = "DGLinea"
        Me.DGLinea.ReadOnly = True
        Me.DGLinea.Visible = False
        '
        'DGCostoProm
        '
        Me.DGCostoProm.HeaderText = "CostoProm"
        Me.DGCostoProm.Name = "DGCostoProm"
        Me.DGCostoProm.ReadOnly = True
        Me.DGCostoProm.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 230
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cant"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dcto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Eliminar"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Eliminar Fila"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "CuentaIng"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "TipoLinea"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "CostoProm"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'cmbproductos
        '
        Me.cmbproductos.FormattingEnabled = True
        Me.cmbproductos.Location = New System.Drawing.Point(51, 179)
        Me.cmbproductos.Name = "cmbproductos"
        Me.cmbproductos.Size = New System.Drawing.Size(470, 21)
        Me.cmbproductos.TabIndex = 24
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(530, 179)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 25
        '
        'btnAlmacenar
        '
        Me.btnAlmacenar.Location = New System.Drawing.Point(636, 175)
        Me.btnAlmacenar.Name = "btnAlmacenar"
        Me.btnAlmacenar.Size = New System.Drawing.Size(166, 27)
        Me.btnAlmacenar.TabIndex = 26
        Me.btnAlmacenar.Text = "&Ingresar Referencia"
        Me.btnAlmacenar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(48, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nombre del Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(527, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Cantidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(46, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Total Cantidad de Productos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txttotalproductos
        '
        Me.txttotalproductos.Location = New System.Drawing.Point(194, 242)
        Me.txttotalproductos.MaxLength = 15
        Me.txttotalproductos.Name = "txttotalproductos"
        Me.txttotalproductos.Size = New System.Drawing.Size(79, 20)
        Me.txttotalproductos.TabIndex = 30
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1013, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'IngresoDeClientesToolStripMenuItem
        '
        Me.IngresoDeClientesToolStripMenuItem.Name = "IngresoDeClientesToolStripMenuItem"
        Me.IngresoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IngresoDeClientesToolStripMenuItem.Text = "Ingreso de Clientes"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(242, 32)
        Me.TxtNumero.MaxLength = 15
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(137, 20)
        Me.TxtNumero.TabIndex = 34
        '
        'FrmGenerarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 342)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.txttotalproductos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAlmacenar)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cmbproductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.BtnBusqCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmGenerarPedido"
        Me.Text = "Ingreso de Pedidos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBusqCliente As Button
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGReferencia As DataGridViewTextBoxColumn
    Friend WithEvents DGDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents DGCantidad As DataGridViewTextBoxColumn
    Friend WithEvents DGDcto As DataGridViewTextBoxColumn
    Friend WithEvents DGObservaciones As DataGridViewTextBoxColumn
    Friend WithEvents DGEliminar As DataGridViewButtonColumn
    Friend WithEvents DGCuenta As DataGridViewTextBoxColumn
    Friend WithEvents DGCtaIng As DataGridViewTextBoxColumn
    Friend WithEvents DGLinea As DataGridViewTextBoxColumn
    Friend WithEvents DGCostoProm As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents cmbproductos As ComboBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents btnAlmacenar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txttotalproductos As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtNumero As TextBox
End Class

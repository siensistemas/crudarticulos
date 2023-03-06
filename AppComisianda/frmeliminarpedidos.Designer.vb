<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeliminarpedidos
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
        Me.BtnBusqCliente = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.BtnEliminarPedido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnBusqCliente
        '
        Me.BtnBusqCliente.Location = New System.Drawing.Point(294, 61)
        Me.BtnBusqCliente.Name = "BtnBusqCliente"
        Me.BtnBusqCliente.Size = New System.Drawing.Size(30, 21)
        Me.BtnBusqCliente.TabIndex = 22
        Me.BtnBusqCliente.Text = "..."
        Me.BtnBusqCliente.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(48, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Numero del Pedido"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(151, 61)
        Me.TxtNumero.MaxLength = 15
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(137, 20)
        Me.TxtNumero.TabIndex = 20
        '
        'BtnEliminarPedido
        '
        Me.BtnEliminarPedido.Location = New System.Drawing.Point(51, 102)
        Me.BtnEliminarPedido.Name = "BtnEliminarPedido"
        Me.BtnEliminarPedido.Size = New System.Drawing.Size(162, 30)
        Me.BtnEliminarPedido.TabIndex = 23
        Me.BtnEliminarPedido.Text = "&Eliminar Pedido"
        Me.BtnEliminarPedido.UseVisualStyleBackColor = True
        '
        'frmeliminarpedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 285)
        Me.Controls.Add(Me.BtnEliminarPedido)
        Me.Controls.Add(Me.BtnBusqCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNumero)
        Me.Name = "frmeliminarpedidos"
        Me.Text = "Eliminar Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBusqCliente As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents BtnEliminarPedido As Button
End Class

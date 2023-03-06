Public Class Form1
    Private Sub IngresarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarProductosToolStripMenuItem.Click
        frmproductos.MdiParent = Me
        frmproductos.Show()
    End Sub

    Private Sub GenerarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarPedidoToolStripMenuItem.Click
        FrmGenerarPedido.MdiParent = Me
        FrmGenerarPedido.Show()
    End Sub

    Private Sub EliminarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPedidoToolStripMenuItem.Click
        frmeliminarpedidos.MdiParent = Me
        frmeliminarpedidos.Show()
    End Sub
End Class

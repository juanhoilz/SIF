Public Class Proveedores
    Dim funciones As New BASEDATOS
    'Dim control_documentar As New Documentar
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbRFC.TextChanged
        funciones.dgvrfcproveedor(tbRFC.Text, DataGridView1)
    End Sub

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        funciones.dgvnombreproveedor(tbNombre.Text, DataGridView1)
    End Sub

    Private Sub tbRFC_Enter(sender As Object, e As EventArgs) Handles tbRFC.Enter
        tbNombre.Clear()
    End Sub

    Private Sub tbNombre_Enter(sender As Object, e As EventArgs) Handles tbNombre.Enter
        tbRFC.Clear()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        'Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        'Dim control = New Documentar
        'control_documentar.tbProveedor.Text = Convert.ToString(row.Cells("NOMBRE_PROVEEDOR").Value)
        'control_documentar.lbIdproveedor.Text = Convert.ToString(row.Cells("ID").Value)
        'control.lbIdproveedor.Text = Convert.ToString(row.Cells("ID").Value)
        'Altafactura.tbPartida.Text
        'documentos.tbProveedor.Text = Convert.ToString(row.Cells("NOMBRE_PROVEEDOR").Value)

        'tbNombre.Text = Convert.ToString(row.Cells("NOMBRE_PROVEEDOR").Value)

        'Me.Close()

    End Sub
End Class
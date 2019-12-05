Public Class CONSULTAR_PROVEEDORES
    Private Sub tbnombres_TextChanged(sender As Object, e As EventArgs) Handles tbnombres.TextChanged

    End Sub
    Dim funciones As New BASEDATOS

    Private Sub CONSULTAR_PROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbnombres.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbnombres.TextChanged
        funciones.Llenarconsultaproveedor(tbnombres.Text, DataGridView1)
    End Sub

End Class
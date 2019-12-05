Public Class DETALLE_FACTURA

    Dim funciones As New BASEDATOS
    Private Sub DETALLE_FACTURA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        funciones.Llenadgvdetallefacturas(tbId.Text, dgvDetalle)

    End Sub

    Private Sub DETALLE_FACTURA_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

End Class
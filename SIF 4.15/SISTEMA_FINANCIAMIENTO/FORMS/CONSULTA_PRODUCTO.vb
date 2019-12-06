Public Class CONSULTA_PRODUCTO
    Dim funciones As New BASEDATOS

    Private Sub CONSULTA_PRODUCTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbdescripcion.Clear()
    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbdescripcion.TextChanged
        funciones.Llenarconsultaproducto(tbdescripcion.Text, DataGridView1)
    End Sub



    Private Sub Partidas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class
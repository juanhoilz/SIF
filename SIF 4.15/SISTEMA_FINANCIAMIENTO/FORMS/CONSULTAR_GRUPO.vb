Public Class CONSULTAR_GRUPO

    Dim funciones As New BASEDATOS

    Private Sub CONSULTAR_GRUPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbdescripcion.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbdescripcion.TextChanged
        funciones.Llenarconsultagrupo(tbdescripcion.Text, DataGridView1)
    End Sub



End Class
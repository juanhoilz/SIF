Public Class CONSULTAR_PERSONAL

    Dim funciones As New BASEDATOS

    Private Sub CONSULTAR_PERSONAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbnombre.Clear()
    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbnombre.TextChanged
        funciones.Llenarconsultapersonal(tbnombre.Text, DataGridView1)
    End Sub


End Class
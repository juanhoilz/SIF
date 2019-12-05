Public Class ALTA_PROVEEDORES

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ALTA_PROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Alta_Proveedores As New USR_ALTAPROVEEDORES
        Panel_Proveedores.Controls.Clear()
        Panel_Proveedores.Controls.Add(Alta_Proveedores)

    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        CONSULTAR_PROVEEDORES.ShowDialog()
    End Sub


End Class
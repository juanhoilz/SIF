Public Class Botones_Administracion
    Dim PanelOperaciones02 As New PRINCIPAL
    Dim muestrasaldos As New Saldos
    Dim altacuenta As New Alta_Cuenta
    Dim altalicitaciones As New Licitaciones

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'PRINCIPAL.Panel_Operaciones.Controls.Clear()
        'PRINCIPAL.Panel_Operaciones.Controls.Add(muestrasaldos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'PRINCIPAL.Panel_Operaciones.Controls.Clear()
        'PRINCIPAL.Panel_Operaciones.Controls.Add(altacuenta)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'PRINCIPAL.Panel_Operaciones.Controls.Clear()
        'PRINCIPAL.Panel_Operaciones.Controls.Add(altalicitaciones)
    End Sub
End Class

Public Class Botones_Facturas
    Dim documentar As New Documentar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Altafactura.Show()
        PRINCIPAL.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        DOCUMENTAR_ORDEN.Show()
        PRINCIPAL.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'PRINCIPAL.Panel_Operaciones.Controls.Clear()
        'PRINCIPAL.Panel_Operaciones.Controls.Add(documentar)
        DOCUMENTAR_ORDEN.Show()
        'DOCUMENTAR_PEDIDO.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DOCUMENTAR_PEDIDO.Show()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        DOCUMENTAR_VALE_SALIDA.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class

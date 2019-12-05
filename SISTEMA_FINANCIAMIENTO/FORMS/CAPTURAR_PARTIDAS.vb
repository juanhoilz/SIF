Public Class CAPTURAR_PARTIDAS

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim captura_manual As New CAPTURA_MANUAL
        Panel_captura_partidas.Controls.Clear()
        Panel_captura_partidas.Controls.Add(captura_manual)

    End Sub

    Private Sub CAPTURAR_PARTIDAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim captura_manual As New CAPTURA_MANUAL
        Panel_captura_partidas.Controls.Clear()
        Panel_captura_partidas.Controls.Add(captura_manual)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim captura_manual As New CAPTURA_MANUAL
        Panel_captura_partidas.Controls.Clear()
        Panel_captura_partidas.Controls.Add(captura_manual)
        captura_manual.btCargarXml.Enabled = True
        captura_manual.btAgregar.Enabled = False
        captura_manual.btContinuar.Enabled = False
        captura_manual.tbCantidad.Enabled = False
        captura_manual.tbunidad.Enabled = False
        captura_manual.tbClave.Enabled = False
        captura_manual.tbDescripcion.Enabled = False
        captura_manual.tbValorunitario.Enabled = False
        captura_manual.tbImporte.Enabled = False

    End Sub
End Class
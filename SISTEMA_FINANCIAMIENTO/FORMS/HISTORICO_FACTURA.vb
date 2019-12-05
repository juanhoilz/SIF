Public Class HISTORICO_FACTURA

    Dim funciones As New BUSQUEDAS_HISTORICO
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click


        If dtpInicio.Value > dtpFin.Value Then
            MessageBox.Show("La fecha de inicio debe ser menor o igual que el límite", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If cbFiltro.Text = "" Then
                MessageBox.Show("Favor de seleccionar alguno de los filtros", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf cbFiltro.SelectedIndex = 0 Then
                funciones.ConsultaDinamicaNombre(tbFactura.Text, dgvConsulta)
            ElseIf cbFiltro.SelectedIndex = 1 Then
                funciones.ConsultaDinamicaRFC(tbFactura.Text, dgvConsulta)
            ElseIf cbFiltro.SelectedIndex = 2 Then
                funciones.Llenadgvhistorico(tbFactura.Text, dgvConsulta)
            ElseIf cbFiltro.SelectedIndex = 3 Then
                funciones.ConsultaDinamicaFechafactura(dtpInicio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd"), dgvConsulta)
            End If

        End If


    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        'Dim id As String = dgvConsulta.SelectedRows(0).Cells("ID_FACTURA").Value

        'funciones.Llenadgvhistorico(id, dgvDetalles)
    End Sub

    Private Sub dgvConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellClick
        Dim id As String = dgvConsulta.SelectedRows(0).Cells("ID_FACTURA").Value
        funciones.Llenadgvhistorico(id, dgvDetalles)
    End Sub

    Private Sub HISTORICO_FACTURA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
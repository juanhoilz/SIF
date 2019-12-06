
Public Class CONSULTA_INVENTARIO
    Dim funciones As New BUSQUEDAS_HISTORICO
    Private Sub CONSULTA_INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvConsulta.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvConsulta.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

        'If dtpInicio.Value > dtpFin.Value Then
        'MessageBox.Show("La fecha de inicio debe ser menor o igual que el límite", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else

        If cbFiltro.Text = "" Then
            MessageBox.Show("Favor de seleccionar alguno de los filtros", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbFiltro.SelectedIndex = 0 Then
            funciones.ConsultaDinamicaNumInventario(tbBuscar.Text, dgvConsulta)
        ElseIf cbFiltro.SelectedIndex = 1 Then
            funciones.ConsultaDinamicaNOMPROVEEDOR(tbBuscar.Text, dgvConsulta)
        ElseIf cbFiltro.SelectedIndex = 2 Then
            funciones.ConsultaDinamicaFACTURA(tbBuscar.Text, dgvConsulta)
        ElseIf cbFiltro.SelectedIndex = 3 Then
            funciones.ConsultaDinamicaDESCRIPCION(tbBuscar.Text, dgvConsulta)

        End If

        'End If
    End Sub

    Private Sub dgvConsulta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellContentClick

    End Sub

    Private Sub tbFactura_Enter(sender As Object, e As EventArgs) Handles tbBuscar.Enter
        'tbBuscar.Text = ""
    End Sub

    Private Sub BunifuThinButton1_Click(sender As Object, e As EventArgs)

        'If dtpInicio.Value > dtpFin.Value Then
        'MessageBox.Show("La fecha de inicio debe ser menor o igual que el límite", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else

        If cbFiltro.Text = "" Then
            MessageBox.Show("Favor de seleccionar alguno de los filtros", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbFiltro.SelectedIndex = 0 Then
            funciones.ConsultaDinamicaNumInventario(tbBuscar.Text, dgvConsulta)
        ElseIf cbFiltro.SelectedIndex = 1 Then
            funciones.ConsultaDinamicaNOMPROVEEDOR(tbBuscar.Text, dgvConsulta)
        ElseIf cbFiltro.SelectedIndex = 2 Then
            funciones.ConsultaDinamicaFACTURA(tbBuscar.Text, dgvConsulta)
        ElseIf cbFiltro.SelectedIndex = 3 Then
            funciones.ConsultaDinamicaDESCRIPCION(tbBuscar.Text, dgvConsulta)

        End If
    End Sub
End Class
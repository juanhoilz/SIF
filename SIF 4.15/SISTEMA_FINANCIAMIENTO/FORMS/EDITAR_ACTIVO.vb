Imports System.Data
Imports System.Data.SqlClient
Public Class EDITAR_ACTIVO

    Dim funciones As New BUSQUEDAS_HISTORICO
    Dim Funciones2 As New BASEDATOS
    Public cn As New SqlConnection
    Dim cmd As New SqlCommand


    Private Sub EDITAR_ACTIVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvConsulta.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvConsulta.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        cbSeleccionar.Enabled = False
        tbDescripcion.Enabled = False
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
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




    Private Sub cbCampo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCampo.SelectionChangeCommitted


        If cbCampo.SelectedIndex = 0 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = True
        ElseIf cbCampo.SelectedIndex = 1 Then
            'ejercicio
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = True
            tbDescripcion.Text = ""
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 2 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = True
            tbDescripcion.Text = ""
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 3 Then
            cbSeleccionar.Enabled = True
            tbDescripcion.Text = ""
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 4 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = True
        ElseIf cbCampo.SelectedIndex = 5 Then

            cbSeleccionar.Enabled = False
            tbDescripcion.Text = ""
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 6 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = True
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 7 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 8 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 9 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 10 Then
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 11 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 12 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 13 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 14 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = True
        ElseIf cbCampo.SelectedIndex = 15 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 16 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = True
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 17 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = False
        ElseIf cbCampo.SelectedIndex = 18 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = True
        ElseIf cbCampo.SelectedIndex = 19 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = True
        ElseIf cbCampo.SelectedIndex = 20 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            cbSeleccionar.Enabled = False
            tbDescripcion.Enabled = True
        End If

    End Sub

    Private Sub cbSeleccionar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSeleccionar.Enter

        If cbCampo.SelectedIndex = 1 Then
            'ejercicio
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            Funciones2.LlenarComboanioejercicio(cbSeleccionar)
        ElseIf cbCampo.SelectedIndex = 2 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            Funciones2.Llenarcomboejercicio(cbSeleccionar)
        ElseIf cbCampo.SelectedIndex = 3 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            Funciones2.LlenarComboProveedores(cbSeleccionar)
        ElseIf cbCampo.SelectedIndex = 6 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            Funciones2.LlenarComboUbicacion(cbSeleccionar)
        ElseIf cbCampo.SelectedIndex = 16 Then
            cbSeleccionar.DataSource = Nothing
            cbSeleccionar.Text = ""
            Funciones2.Llenarcombopersonal(cbSeleccionar)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btactualizar.Click
        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()
        If cbCampo.SelectedIndex = 0 Then
            If cbSeleccionar.SelectedIndex = 0 Then
                Dim rowselected As New List(Of DataGridViewRow)()

                For Each row As DataGridViewRow In dgvConsulta.Rows

                    Dim cellseleccion As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)

                    If Convert.ToBoolean(cellseleccion.Value) Then
                        rowselected.Add(row)

                    End If
                Next

                For Each rows As DataGridViewRow In rowselected

                    Dim ID_INVENTARIO As String = dgvConsulta.SelectedRows(0).Cells("ID_INVENTARIO").Value
                    cmd.Parameters.AddWithValue("@pID_INVENTARIO", cbCampo.SelectedValue)

                    cmd = New SqlCommand("Sp_ListaPartida", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    Dim da As New SqlDataAdapter(cmd)

                    Dim dt As New DataTable

                Next

            End If
        End If
        cn.Close()
    End Sub
End Class
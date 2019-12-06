Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class CONSULTAR_PAGOS

    Public cn As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Dim funciones As BUSQUEDAS_CLC

    Private Sub CONSULTAR_PAGOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try

            dgvPagos.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            dgvPagos.AlternatingRowsDefaultCellStyle.BackColor = Color.White


            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
            dgvPagos.Columns.Clear()
            'Dim col As New DataGridViewCheckBoxColumn
            'dgvLicitaciones.Columns.Add(col)
            'dgvLicitaciones.Columns(dgvLicitaciones.Columns.Count - 1).DisplayIndex = 6


            adaptador = New SqlDataAdapter("Select FACTURAS.ID_FACTURA, CAT_PROVEEDORES.NOMBRE_PROVEEDOR,FOLIO_CLC, FOLIO_FACTURA, FACTURAS.TOTAL, FACTURAS_CLC.IMPORTE_PAGADO, FACTURAS.TOTAL-FACTURAS_CLC.IMPORTE_PAGADO AS DIFERENCIA," &
                                               "CAT_PARTIDAS.CLAVE_PARTIDA,CAT_PARTIDAS.DESCRIPCION " &
                                               "from FACTURAS_CLC left join FACTURAS on (FACTURAS_CLC.ID_FACTURA = FACTURAS.ID_FACTURA)" &
                                               "left join CAT_PROVEEDORES on (CAT_PROVEEDORES.ID_PROVEEDOR = FACTURAS.ID_PROVEEDOR)" &
                                               "left join CAT_PARTIDAS on (FACTURAS.ID_PARTIDA = CAT_PARTIDAS.ID_PARTIDA)" &
                                               "Where FOLIO_CLC = '" & tbDescripcion.Text & "'", cn)


            dt = New DataTable

            adaptador.Fill(dt)
            dgvPagos.DataSource = dt

            dgvPagos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgvPagos.Columns(0).Visible = False
            dgvPagos.Columns(1).Width = 200
            dgvPagos.Columns(2).Width = 60
            dgvPagos.Columns(3).Width = 80
            dgvPagos.Columns(3).HeaderText = "LICITACIÓN"
            dgvPagos.Columns(4).Width = 80
            dgvPagos.Columns(4).DefaultCellStyle.Format = "n"
            dgvPagos.Columns(5).Width = 80
            dgvPagos.Columns(5).HeaderText = "INICIO"
            dgvPagos.Columns(6).Width = 80
            dgvPagos.Columns(6).HeaderText = "TÉRMINO"

            Dim col2 As New DataGridViewButtonColumn
            dgvPagos.Columns.Add(col2)
            dgvPagos.Columns(dgvPagos.Columns.Count - 1).DisplayIndex = 7
            col2.HeaderText = "DOCUMENTO"
            col2.Text = "Ver documento"
            col2.UseColumnTextForButtonValue = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        cn.Close()
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        'funciones.Llenarcomboaniofolios(cbEjercicio)
    End Sub
End Class
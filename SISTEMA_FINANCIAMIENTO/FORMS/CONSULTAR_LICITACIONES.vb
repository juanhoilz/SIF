Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class CONSULTAR_LICITACIONES

    Public cn As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable

    Private Sub CONSULTAR_LICITACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dgvLicitaciones.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            dgvLicitaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.White


            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
            dgvLicitaciones.Columns.Clear()
            'Dim col As New DataGridViewCheckBoxColumn
            'dgvLicitaciones.Columns.Add(col)
            'dgvLicitaciones.Columns(dgvLicitaciones.Columns.Count - 1).DisplayIndex = 6


            adaptador = New SqlDataAdapter("Select ID_LICITACION,CAT_PROVEEDORES.NOMBRE_PROVEEDOR, CAT_EJERCICIOS.EJERCICIO, NOMBRE_LICITACION, IMPORTE, FECHA_INICIO, FECHA_FIN from CAT_LICITACIONES left join CAT_PROVEEDORES " &
            "on (CAT_LICITACIONES.ID_PROVEEDOR = CAT_PROVEEDORES.ID_PROVEEDOR)" &
            "left join CAT_EJERCICIOS on (CAT_EJERCICIOS.ID = CAT_LICITACIONES.ID_EJERCICIO)" &
            "WHERE CAT_LICITACIONES.ESTATUS = '1'", cn)


            dt = New DataTable

            adaptador.Fill(dt)
            dgvLicitaciones.DataSource = dt

            dgvLicitaciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgvLicitaciones.Columns(0).Visible = False
            dgvLicitaciones.Columns(1).Width = 200
            dgvLicitaciones.Columns(2).Width = 60
            dgvLicitaciones.Columns(3).Width = 80
            dgvLicitaciones.Columns(3).HeaderText = "LICITACIÓN"
            dgvLicitaciones.Columns(4).Width = 80
            dgvLicitaciones.Columns(4).DefaultCellStyle.Format = "n"
            dgvLicitaciones.Columns(5).Width = 80
            dgvLicitaciones.Columns(5).HeaderText = "INICIO"
            dgvLicitaciones.Columns(6).Width = 80
            dgvLicitaciones.Columns(6).HeaderText = "TÉRMINO"

            Dim col2 As New DataGridViewButtonColumn
            dgvLicitaciones.Columns.Add(col2)
            dgvLicitaciones.Columns(dgvLicitaciones.Columns.Count - 1).DisplayIndex = 7
            col2.HeaderText = "DOCUMENTO"
            col2.Text = "Ver documento"
            col2.UseColumnTextForButtonValue = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        cn.Close()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub dgvLicitaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLicitaciones.CellContentClick

        If e.ColumnIndex = 7 Then

            Dim documento_PDF As New CONSULTAR_PDF
            Dim id_licitacion As String = dgvLicitaciones.SelectedRows(0).Cells("ID_LICITACION").Value
            documento_PDF.tbIdLicitacion.Text = id_licitacion
            documento_PDF.ShowDialog()

        End If
    End Sub
End Class
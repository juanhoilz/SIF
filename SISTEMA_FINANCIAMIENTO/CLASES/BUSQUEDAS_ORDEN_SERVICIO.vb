Imports System.Data
Imports System.Data.SqlClient

Public Class BUSQUEDAS_ORDEN_SERVICIO
    Public cn As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub New()
        Try
            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenardgvproveedor(ByVal dgv As DataGridView, ByVal id_proveedor As String)
        Try

            dgv.Columns.Clear()
            'Dim col As New DataGridViewCheckBoxColumn
            'dgv.Columns.Add(col)
            'dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            'dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("Select TBL_PROVEEDORES.NOMBRE_PROVEEDOR, FOLIO_FACTURA, TBL_FACTURAS.TOTAL," &
                                           "TBL_PARTIDAS.CLAVE_PARTIDAS,TBL_PARTIDAS.DESCRIPCION, TBL_ESTATUS_FACTURA.DESCRIPCION " &
                                           "from TBL_FACTURAS left join TBL_PROVEEDORES on (TBL_FACTURAS.PROVEEDOR_ID = TBL_PROVEEDORES.ID_PROVEEDOR)" &
                                           "left join TBL_PARTIDAS on (TBL_FACTURAS.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS)" &
                                           "left join TBL_ESTATUS_FACTURA on (TBL_FACTURAS.ESTATUS_ID = TBL_ESTATUS_FACTURA.ID_ESTATUS)" &
                                           "Where TBL_FACTURAS.PROVEEDOR_ID =  '" & id_proveedor & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'dgv.Columns(0).Width = 250
            'dgv.Columns(1).Width = 60
            'dgv.Columns(2).Width = 100
            'dgv.Columns(3).DefaultCellStyle.Format = "n"
            'dgv.Columns(4).DefaultCellStyle.Format = "n"
            'dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenarcombofolios(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select TBL_FOLIOS_ORDEN_SERVICIO.ID, TBL_FOLIOS_ORDEN_SERVICIO.EJERCICIO_ID, TBL_EJERCICIOS.EJERCICIO from TBL_FOLIOS_ORDEN_SERVICIO left join TBL_EJERCICIOS on (TBL_FOLIOS_ORDEN_SERVICIO.EJERCICIO_ID = TBL_EJERCICIOS.ID)"

                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "EJERCICIO"
                cb.ValueMember = "ID"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
End Class

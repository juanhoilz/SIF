Imports System.Data
Imports System.Data.SqlClient
Public Class BUSQUEDAS_CLC

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

    Sub Llenarcomboaniofolios(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select TBL_FOLIOS_CLC.ID, TBL_FOLIOS_CLC.EJERCICIO_ID, TBL_EJERCICIOS.EJERCICIO+' - '+TBL_CUENTA_ORIGEN.NOMBRE_COMPLETO AS FOLIOS from TBL_FOLIOS_CLC left join TBL_EJERCICIOS on (TBL_FOLIOS_CLC.EJERCICIO_ID = TBL_EJERCICIOS.ID)" &
                                         "left join TBL_CUENTA_ORIGEN on (TBL_CUENTA_ORIGEN.ID_FUENTE = TBL_FOLIOS_CLC.CUENTA_ORIGEN_ID)"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "FOLIOS"
                cb.ValueMember = "ID"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Sub LlenardgvfacturasCLC(ByVal dgv As DataGridView, ByVal cbejercicio As String, ByVal cbfuente As String, ByVal cbcuenta As String, ByVal cbproveedores As String, ByVal cbpartida As String)
        Try

            dgv.Columns.Clear()
            'Dim col As New DataGridViewCheckBoxColumn
            'dgv.Columns.Add(col)
            'dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            'dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_PROVEEDORES.NOMBRE_PROVEEDOR, TBL_PARTIDAS.CLAVE_PARTIDAS, TBL_FACTURAS.FOLIO_FACTURA AS FACTURA, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL " &
                                           "from TBL_FACTURAS left join TBL_PROVEEDORES on (TBL_FACTURAS.PROVEEDOR_ID = TBL_PROVEEDORES.ID_PROVEEDOR)" &
                                           "left join TBL_PARTIDAS on (TBL_FACTURAS.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS)" &
                                           "left join TBL_CUENTA_ORIGEN on (TBL_CUENTA_ORIGEN.ID_FUENTE = TBL_FACTURAS.FUENTE_ID)" &
                                           "Where TBL_FACTURAS.ESTATUS_ID = '2' AND TBL_FACTURAS.EJERCICIO_ID = '" & cbejercicio & "'  AND TBL_FACTURAS.FUENTE_ID = '" & cbfuente & "'" &
                                           "AND TBL_FACTURAS.CUENTA_ID = '" & cbcuenta & "' AND TBL_FACTURAS.PROVEEDOR_ID = '" & cbproveedores & "'  AND TBL_FACTURAS.PARTIDA_ID = '" & cbpartida & "' ORDER BY TBL_FACTURAS.FOLIO_FACTURA", cn)


            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Visible = False
            dgv.Columns(1).Width = 250
            dgv.Columns(2).Width = 60
            dgv.Columns(2).HeaderText = "PARTIDA"
            dgv.Columns(3).Width = 100
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(5).DefaultCellStyle.Format = "n"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenardgvfacturasCLC_prueba(ByVal dgv As DataGridView, ByVal cbejercicio As String, ByVal cbproveedor As String, ByVal cbpartida As String)
        Try

            dgv.Columns.Clear()
            'Dim col As New DataGridViewCheckBoxColumn
            'dgv.Columns.Add(col)
            'dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            'dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_PROVEEDORES.NOMBRE_PROVEEDOR, TBL_PARTIDAS.CLAVE_PARTIDAS, TBL_FACTURAS.FOLIO_FACTURA AS FACTURA, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL," &
                                           "TBL_CUENTA_ORIGEN.NOMBRE_COMPLETO from TBL_FACTURAS left join TBL_PROVEEDORES on (TBL_FACTURAS.PROVEEDOR_ID = TBL_PROVEEDORES.ID_PROVEEDOR)" &
                                           "left join TBL_PARTIDAS on (TBL_FACTURAS.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS)" &
                                           "left join TBL_CUENTA_ORIGEN on (TBL_CUENTA_ORIGEN.ID_FUENTE = TBL_FACTURAS.FUENTE_ID)" &
                                           "Where TBL_FACTURAS.ESTATUS_ID = '2' AND TBL_FACTURAS.EJERCICIO = '" & cbejercicio & "' AND TBL_FACTURAS.PROVEEDOR_ID = '" & cbproveedor & "' AND TBL_FACTURAS.PARTIDA_ID = '" & cbpartida & "'" &
                                           "ORDER BY TBL_FACTURAS.PARTIDA_ID", cn)


            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Visible = False
            dgv.Columns(1).Width = 250
            dgv.Columns(2).Width = 60
            dgv.Columns(2).HeaderText = "PARTIDA"
            dgv.Columns(3).Width = 100
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenardgvfacturasdinamico(ByVal dgv As DataGridView, ByVal nombre_proveedor As String)
        Try

            dgv.Columns.Clear()
            'Dim col As New DataGridViewCheckBoxColumn
            'dgv.Columns.Add(col)
            'dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            'dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_PROVEEDORES.NOMBRE_PROVEEDOR, TBL_PARTIDAS.CLAVE_PARTIDAS, TBL_FACTURAS.FOLIO_FACTURA AS FACTURA, TBL_FACTURAS.FECHA_FACTURA AS FECHA, TBL_FACTURAS.SUBTOTAL, TBL_FACTURAS.IVA, TBL_FACTURAS.ISR, TBL_FACTURAS.TOTAL," &
                                           "TBL_FACTURAS.OBSERVACION, TBL_FACTURAS.FECHA_RECEPCION, TBL_CUENTA_ORIGEN.NOMBRE_COMPLETO from TBL_FACTURAS left join TBL_PROVEEDORES on (TBL_FACTURAS.PROVEEDOR_ID = TBL_PROVEEDORES.ID_PROVEEDOR)" &
                                           "left join TBL_PARTIDAS on (TBL_FACTURAS.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS)" &
                                           "left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "left join TBL_CUENTA_ORIGEN on (TBL_CUENTA_ORIGEN.ID_FUENTE = TBL_FACTURAS.FUENTE_ID)" &
                                           "Where TBL_FACTURAS.ESTATUS_ID = '2' and TBL_PROVEEDORES.NOMBRE_PROVEEDOR like '" & "%" + nombre_proveedor + "%'ORDER BY TBL_PROVEEDORES.NOMBRE_PROVEEDOR, TBL_FACTURAS.PARTIDA_ID", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            'dgv.Columns(1).Visible = False
            dgv.Columns(1).Width = 250
            dgv.Columns(2).Width = 50
            dgv.Columns(2).HeaderText = "PARTIDA"
            dgv.Columns(3).Width = 100
            dgv.Columns(4).Width = 80
            dgv.Columns(5).Width = 80
            dgv.Columns(5).DefaultCellStyle.Format = "n"
            dgv.Columns(6).Width = 60
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 80
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 150
            dgv.Columns(10).Width = 120

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class

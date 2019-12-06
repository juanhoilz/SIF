Imports System.Data
Imports System.Data.SqlClient

Public Class BASEDATOS

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
        'cn.Close() 'Cerrar la conexión a la base de datos
    End Sub

    Sub Llenartabla(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select *from TBL_FACTURAS", cn) 'La informacion que captura el adaptador con la consulta se la envía al datatable 
            'y el datatable va a llenar el datasource del datagridview
            '
            dt = New DataTable 'Aqui se genera la variable dt
            adaptador.Fill(dt) 'El adaptador va a llenar el datatable
            dgv.DataSource = dt 'Aqui se llena el datasource con la informacion del datatable
        Catch ex As Exception
            MessageBox.Show("Error al llenar los datos" + ex.ToString)
        End Try

    End Sub

    Sub ConsultaDinamicaFactura(ByVal folio_factura As String, ByVal dgv As DataGridView)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn

            dgv.Columns.Add(col)

            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0

            col.HeaderText = "SELECCIONAR"



            dgv.ReadOnly = False
            dgv.DataSource = Nothing

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where FOLIO_FACTURA like '" & "%" + folio_factura + "%" & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

            Dim col2 As New DataGridViewButtonColumn
            dgv.Columns.Add(col2)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 11
            col2.HeaderText = "DETALLES"
            col2.Text = "Ver detalles"
            col2.UseColumnTextForButtonValue = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenarComboUbicacion(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_UBICACION,NOMBRE FROM TBL_UBICACION ORDER BY NOMBRE"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE"
                cb.ValueMember = "ID_UBICACION"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Sub Llenacombopartidasfiltroinv(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_PARTIDAS,CLAVE_PARTIDAS+' - '+DESCRIPCION AS DESCRIPCION2 FROM TBL_PARTIDAS WHERE ID_PARTIDAS >= 107 AND ID_PARTIDAS <= 123"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION2"
                cb.ValueMember = "ID_PARTIDAS"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub ConsultaDinamicaFacturaoutlook(ByVal folio_factura As String, ByVal dgv As DataGridView)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            col.HeaderText = "SELECCIONAR"
            dgv.ReadOnly = False
            dgv.DataSource = Nothing

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join CAT_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where FOLIO_FACTURA like '" & "%" + folio_factura + "%" & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub ConsultaDinamicaFacturafiltro(ByVal folio_factura As String, ByVal dgv As DataGridView, filtro As Int16)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            col.HeaderText = "SELECCIONAR"
            dgv.ReadOnly = False
            dgv.DataSource = Nothing

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where FOLIO_FACTURA like '" & "%" + folio_factura + "%" & "' and TBL_FACTURAS.ESTATUS_ID ='" & filtro & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub ConsultaDinamicaNombre(ByVal nombreproveedor As String, ByVal dgv As DataGridView)

        genera_checkbox(dgv)

        Try
            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where NOMBRE_PROVEEDOR like '" & "%" + nombreproveedor + "%" & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ConsultaDinamicaNombrefiltro(ByVal nombreproveedor As String, ByVal dgv As DataGridView, filtro As Int16)

        genera_checkbox(dgv)

        Try
            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where NOMBRE_PROVEEDOR like '" & "%" + nombreproveedor + "%" & "' and TBL_FACTURAS.ESTATUS_ID ='" & filtro & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ConsultaDinamicaRFC(ByVal rfc As String, ByVal dgv As DataGridView)

        genera_checkbox(dgv)

        Try
            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where RFC like '" & "%" + rfc + "%" & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ConsultaDinamicaRFCfiltro(ByVal rfc As String, ByVal dgv As DataGridView, filtro As String)

        genera_checkbox(dgv)

        Try
            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where RFC like '" & "%" + rfc + "%" & "' and TBL_FACTURAS.ESTATUS_ID ='" & filtro & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ConsultaDinamicaFechafactura(ByVal fechainicio As String, ByVal fechafin As String, ByVal dgv As DataGridView)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            col.HeaderText = "SELECCIONAR"
            dgv.ReadOnly = False
            dgv.DataSource = Nothing

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where TBL_FACTURAS.FECHA_FACTURA  >= '" & fechainicio & "' and TBL_FACTURAS.FECHA_FACTURA <= '" & fechafin & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ConsultaDinamicaFechafacturafiltro(ByVal fechainicio As String, ByVal fechafin As String, ByVal dgv As DataGridView, filtro As String)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            col.HeaderText = "SELECCIONAR"
            dgv.ReadOnly = False
            dgv.DataSource = Nothing

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where TBL_FACTURAS.FECHA_FACTURA  >= '" & fechainicio & "' and TBL_FACTURAS.FECHA_FACTURA <= '" & fechafin & "' and TBL_FACTURAS.ESTATUS_ID ='" & filtro & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub LlenarComboBox(ByVal cb As ComboBox)

        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()


                enunciado = New SqlCommand("Select ID_PARTIDAS, CLAVE_PARTIDAS+' - '+DESCRIPCION as DESCRIPCION2 from TBL_PARTIDAS", cn)
                respuesta = enunciado.ExecuteReader

                While respuesta.Read
                    cb.Items.Add(respuesta.Item("DESCRIPCION2"))
                    cb.ValueMember = "ID_PARTIDAS"
                End While
                respuesta.Close()
            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Sub LlenarComboUnidades(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_UNIDAD,NOMBRE_UNIDAD FROM TBL_UNIDADES_ADMINISTRATIVAS ORDER BY NOMBRE_UNIDAD"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE_UNIDAD"
                cb.ValueMember = "ID_UNIDAD"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarComboanioejercicio(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID,EJERCICIO FROM TBL_EJERCICIOS ORDER BY ID"
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

    Sub LlenarComboCuentas(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                'cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()

                Dim consulta As String = "Select ID_CUENTA, NUMERO_CUENTA+' - '+EJERCICIO+' '+NOMBRE_BANCO+' ' AS DESCRIPCION FROM TBL_CUENTAS LEFT JOIN TBL_BANCOS ON TBL_CUENTAS.BANCO_ID = TBL_BANCOS.ID LEFT JOIN TBL_CUENTA_ORIGEN ON (TBL_CUENTA_ORIGEN.ID_FUENTE = TBL_CUENTAS.CUENTA_ORIGEN_ID) WHERE (CUENTA_ORIGEN_ID = @parametro)"
                Dim cmd As New SqlCommand(consulta, cn)

                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()
                    da.Fill(dt)

                    cb.DisplayMember = "DESCRIPCION"
                    cb.ValueMember = "ID_CUENTA"
                    cb.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub


    Sub LlenarComboSaldos(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_CUENTA, NUMERO_CUENTA+' - '+EJERCICIO+' - '+NOMBRE_BANCO AS DESCRIPCION FROM TBL_CUENTAS"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION"
                cb.ValueMember = "ID_CUENTA"
                cb.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Sub LlenarCuentaOrigen(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_FUENTE,NOMBRE_COMPLETO FROM TBL_CUENTA_ORIGEN"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE_COMPLETO"
                cb.ValueMember = "ID_FUENTE"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Sub Llenarcatproveedores(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_PROVEEDOR,NOMBRE_PROVEEDOR FROM TBL_PROVEEDORES ORDER BY NOMBRE_PROVEEDOR"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE_PROVEEDOR"
                cb.ValueMember = "ID_PROVEEDOR"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Sub Muestrasaldo(ByVal label As Label)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select SALDO_ACTUAL FROM TBL_CUENTAS"
                Dim cmd As New SqlCommand(consulta, cn)
                Dim leesaldos As SqlDataReader

                'cmd.Parameters.AddWithValue("@id_cuenta")
                leesaldos = cmd.ExecuteReader()
                'cmd.ExecuteNonQuery()

                If leesaldos.Read Then
                    label.Text = Format(CType((leesaldos("SALDO_ACTUAL")), Decimal), "$#,##0.00")
                    cn.Close()
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Sub Llenarcomboejercicio(ByVal combobox As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select ID_FUENTE,NOMBRE_COMPLETO from TBL_CUENTA_ORIGEN"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                combobox.DisplayMember = "NOMBRE_COMPLETO"
                combobox.ValueMember = "ID_FUENTE"
                combobox.DataSource = dt

            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub Llenarcombobancos(ByVal combobox As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select ID,NOMBRE_BANCO AS NOMBRE FROM TBL_BANCOS"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                combobox.DisplayMember = "NOMBRE"
                combobox.ValueMember = "ID"
                combobox.DataSource = dt

            End Using
            'cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenacombopartidas(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_PARTIDAS,CLAVE_PARTIDAS+' - '+DESCRIPCION AS DESCRIPCION2 FROM TBL_PARTIDAS"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION2"
                cb.ValueMember = "ID_PARTIDAS"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenacombopartidasfiltro(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_PARTIDAS,CLAVE_PARTIDAS+' - '+DESCRIPCION AS DESCRIPCION2 FROM TBL_PARTIDAS"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION2"
                cb.ValueMember = "ID_PARTIDAS"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Combodgvclave(ByVal clave_partida As String, ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select CLAVE_PARTIDAS,DESCRIPCION from TBL_PARTIDAS Where CLAVE_PARTIDAS like '" & "%" + clave_partida + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 480

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Combodgvdescripcion(ByVal descripcion As String, ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select CLAVE_PARTIDAS,DESCRIPCION from TBL_PARTIDAS Where DESCRIPCION like '" & "%" + descripcion + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 480

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Dgvrfcproveedor(ByVal rfc As String, ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select ID,NOMBRE_PROVEEDOR,RFC from TBL_PROVEEDORES Where RFC like '" & "%" + rfc + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 480

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Dgvnombreproveedor(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select ID,NOMBRE_PROVEEDOR,RFC from TBL_PROVEEDORES Where NOMBRE_PROVEEDOR like '" & "%" + nombre + "%" & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 480

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenarcombopersonal(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_PERSONAL,ABREVIATURA+' '+APELLIDO_PATERNO+' '+APELLIDO_MATERNO+' '+NOMBRE AS NOMBRE_COMPLETO FROM TBL_PERSONAL ORDER BY ABREVIATURA, APELLIDO_PATERNO, APELLIDO_MATERNO"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE_COMPLETO"
                cb.ValueMember = "ID_PERSONAL"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Sub Llenacomboejerciciosacg(ByVal cb As ComboBox)


        Dim cn As New SqlConnection

        'Se sustituye el servidor en la cadena de conexión

        cn.ConnectionString = "Data Source=192.168.1.99\SQLSAACG;Initial Catalog= SACG0000000 ;User ID=sa;Password=sql2005"
        'cn.ConnectionString = "Data Source=.\SQLSAACG;Initial Catalog= SACG0000000 ;User ID=sa;Password=sql2005"
        cn.Open()

        Dim consulta As String = "SELECT name,SACGSYS.dbo.Entidad.ESTADO,SACGSYS.dbo.Entidad.Ejercicio from master.dbo.sysdatabases  left join SACGSYS.dbo.Entidad on SUBSTRING(name,5,7)  = SACGSYS.dbo.Entidad.EntidadId COLLATE Modern_Spanish_CI_AS  Where (SUBSTRING(name,1,6)= 'SACG04')"

        Dim cmd As New SqlCommand(consulta, cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        cb.DisplayMember = "name"
        'cb.SelectedValue = "name"
        cb.DataSource = dt

        'Dim reader As SqlDataReader = cmd.ExecuteReader()

        ' If reader.Read Then

        'tbEjer.Text = reader("EJERCICIO")

        'End If

        ' End Using
        cn.Close()
        ' Catch ex As Exception
        'MessageBox.Show("No pudo conectarse al servidor, verifique su conexión", "Verifica conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
    End Sub

    Sub Llenacombolugarentrega(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID,NOMBRE_UNIDAD FROM TBL_UNIDADES_ENTREGA"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE_UNIDAD"
                cb.ValueMember = "ID"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub Llenacomboadquisicion(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID,TIPO_ADQUISICION FROM TBL_TIPO_ADQUISICION"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "TIPO_ADQUISICION"
                cb.ValueMember = "ID"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub Llenarcomborubro(ByVal combobox As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select ID_RUBRO,CLAVE+' - '+CONCEPTO+' - '+DESCRIPCION AS RUBRO from TBL_RUBROS"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                combobox.DisplayMember = "RUBRO"
                combobox.ValueMember = "ID_RUBRO"
                combobox.DataSource = dt

            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub UnidadesPorRubro(ByVal combobox As ComboBox, ByVal cb2 As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)


                cn.Open()

                Dim consulta As String = "select ID_UNIDAD,NOMBRE_UNIDAD from TBL_UNIDADES_ADMINISTRATIVAS  WHERE ( RUBRO_ID = @parametro) "


                Dim cmd As New SqlCommand(consulta, cn)

                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)


                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim da As New SqlDataAdapter(cmd)

                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()
                    da.Fill(dt)

                    combobox.DisplayMember = "NOMBRE_UNIDAD"
                    combobox.ValueMember = "ID_UNIDAD"
                    combobox.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarComboAdquisicion(ByVal cb As ComboBox)

        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID, TIPO_ADQUISICION from TBL_TIPO_ADQUISICION"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "TIPO_ADQUISICION"
                cb.ValueMember = "ID"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarComboMarca(ByVal cb As ComboBox, ByVal cb2 As ComboBox)


        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                'cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()


                Dim consulta As String = "Select ID_MARCAS, NOM_MARCA from CAT_MARCA WHERE (PARTIDA_ID = @parametro) ORDER BY NOM_MARCA"

                Dim cmd As New SqlCommand(consulta, cn)
                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()

                    da.Fill(dt)


                    cb.DisplayMember = "NOM_MARCA"

                    cb.ValueMember = "ID_MARCAS"
                    cb.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Sub LlenarCombodescripcion(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                'cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()


                Dim consulta As String = "Select ID_DESCRIPCION_PRODUCTO, PROC_DESCRIPCION AS DESCRIPCION FROM CAT_DESCRIPCION_PRODUCTO WHERE (GRUPO_ID = @parametro)"

                Dim cmd As New SqlCommand(consulta, cn)
                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()

                    da.Fill(dt)


                    cb.DisplayMember = "DESCRIPCION"

                    cb.ValueMember = "ID_DESCRIPCION_PRODUCTO"
                    cb.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarComboModelo(ByVal cb As ComboBox, ByVal cb2 As ComboBox)


        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                'cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()


                Dim consulta As String = "Select ID_MODELO, NOM_MODELO FROM CAT_MODELO WHERE (SUBCAPITULOS_ID = @parametro)  ORDER BY NOM_MODELO"

                Dim cmd As New SqlCommand(consulta, cn)
                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()

                    da.Fill(dt)


                    cb.DisplayMember = "NOM_MODELO"

                    cb.ValueMember = "ID_MODELO"
                    cb.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub
    'autocompletar un text box
    Sub Autocompletartextbox(ByVal tbdescripcion As TextBox)
        Try
            enunciado = New SqlCommand("SELECT DESCRIPCION FROM TBL_INVENTARIO", cn)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                tbdescripcion.AutoCompleteCustomSource.Add(respuesta.Item("DESCRIPCION"))
            End While
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub Llenarcombolicitacion2(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select ID_LICITACION,NOMBRE_LICITACION from TBL_LICITACIONES WHERE (ADQUISICION_ID = @parametro) "
                Dim cmd As New SqlCommand(consulta, cn)
                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()
                    da.Fill(dt)

                    cb.DisplayMember = "NOMBRE_LICITACION"
                    cb.ValueMember = "ID_LICITACION"
                    cb.DataSource = dt
                End If
            End Using

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Sub Llenarcombolicitacion(ByVal combobox As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select ID_LICITACION,NOMBRE_LICITACION from TBL_LICITACIONES"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                combobox.DisplayMember = "NOMBRE_LICITACION"
                combobox.ValueMember = "ID_LICITACION"
                combobox.DataSource = dt

            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub Llenarcomboestatus(ByVal combobox As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select ID_ESTATUS,DESCRIPCION from TBL_ESTATUS_FACTURA"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                combobox.DisplayMember = "DESCRIPCION"
                combobox.ValueMember = "ID_ESTATUS"
                combobox.DataSource = dt


            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub Genera_checkbox(ByVal dgv As DataGridView)

        dgv.Columns.Clear()
        Dim col As New DataGridViewCheckBoxColumn
        dgv.Columns.Add(col)
        dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
        'col.HeaderText = "SELECCIONAR"
        dgv.Columns(0).Width = 50
        dgv.ReadOnly = False
        dgv.DataSource = Nothing

    End Sub
    Sub Llenarcombomunicipios(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID, MUNICIPIO FROM TBL_MUNICIPIOS"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "MUNICIPIO"
                cb.ValueMember = "ID"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub
    Sub LlenarComboUnidadesfiltro(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_UNIDAD,NOMBRE_UNIDAD FROM TBL_UNIDADES_ADMINISTRATIVAS Where (APLICA_PRESUPUESTO = 1)"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE_UNIDAD"
                cb.ValueMember = "ID_UNIDAD"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    'LLENADO DE COMBOS REPROGRAMACION POA
    Sub LlenarComboCapitulo(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_CAPITULOS, CLAVE_CAPITULOS+' - '+DESCRIPCION AS DESCRIPCION2 FROM TBL_CAPITULOS"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION2"
                cb.ValueMember = "ID_CAPITULOS"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Sub Llenarcombogrupo(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                'cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()


                Dim consulta As String = "Select ID_GRUPO, DESCRIPCION_GRUPO FROM CAT_GRUPOS WHERE (ID_PARTIDA = @parametro)"

                Dim cmd As New SqlCommand(consulta, cn)
                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()

                    da.Fill(dt)


                    cb.DisplayMember = "DESCRIPCION_GRUPO"

                    cb.ValueMember = "ID_GRUPO"
                    cb.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarComboSubCapitulo_Inv(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_SUBCAPITULOS, CLAVE_SUBCAPITULOS+' - '+DESCRIPCION AS DESCRIPCION2 FROM TBL_SUBCAPITULOS WHERE (CAPITULOS_ID = '5')"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION2"
                cb.ValueMember = "ID_SUBCAPITULOS"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Sub LlenarCombogrupo_Inv(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_PARTIDAS, CLAVE_PARTIDAS+' - '+DESCRIPCION AS DESCRIPCION2 FROM TBL_PARTIDAS WHERE (SUBCAPITULOS_ID > '22' AND SUBCAPITULOS_ID < '31')"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION2"
                cb.ValueMember = "ID_PARTIDAS"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Sub LlenarCombodesproductos(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select PROC_DESCRIPCION FROM CAT_DESCRIPCION_PRODUCTO ORDER BY PROC_DESCRIPCION"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "PROC_DESCRIPCION"
                cb.ValueMember = "ID_DESCRIPCION_PRODUCTO"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarCombodesgrupo(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select DESCRIPCION_GRUPO FROM CAT_GRUPOS ORDER BY DESCRIPCION_GRUPO"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "DESCRIPCION_GRUPO"
                cb.ValueMember = "ID_GRUPO"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarCombodesmodelo(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select NOM_MODELO FROM CAT_MODELO ORDER BY NOM_MODELO"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOM_MODELO"
                cb.ValueMember = "ID_MODELO"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub LlenarCombodesmarca(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select NOM_MARCA FROM CAT_MARCA ORDER BY NOM_MARCA"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOM_MARCA"
                cb.ValueMember = "ID_MARCAS"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub


    Sub LlenarComboSubCapitulo(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                'cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()


                Dim consulta As String = "Select ID_SUBCAPITULOS, CLAVE_SUBCAPITULOS+' - '+DESCRIPCION AS DESCRIPCION2 FROM TBL_SUBCAPITULOS WHERE (CAPITULOS_ID = @parametro)"

                Dim cmd As New SqlCommand(consulta, cn)
                cmd.Parameters.AddWithValue("@parametro", cb2.SelectedValue)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()

                    da.Fill(dt)


                    cb.DisplayMember = "DESCRIPCION2"

                    cb.ValueMember = "ID_SUBCAPITULOS"
                    cb.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    'modificaciones 
    'Sp_ConsultaProducto
    Sub Llenarconsultaproducto(ByVal nombreproducto As String, ByVal dgv As DataGridView)

        Try

            adaptador = New SqlDataAdapter("select TBL_PARTIDAS.CLAVE_PARTIDAS AS PARTIDA, CAT_GRUPOS.DESCRIPCION_GRUPO AS GRUPO,  CAT_MARCA.NOM_MARCA AS MARCA, CAT_MODELO.NOM_MODELO AS MODELO, PROC_DESCRIPCION AS DESCRIPCIÓN from CAT_DESCRIPCION_PRODUCTO INNER JOIN TBL_PARTIDAS ON CAT_DESCRIPCION_PRODUCTO.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS
                                            INNER JOIN CAT_GRUPOS ON CAT_GRUPOS.ID_GRUPO = CAT_DESCRIPCION_PRODUCTO.GRUPO_ID
                                            INNER JOIN CAT_MARCA ON CAT_MARCA.ID_MARCAS = CAT_DESCRIPCION_PRODUCTO.MARCA_ID
                                            INNER JOIN CAT_MODELO ON CAT_MODELO.ID_MODELO = CAT_DESCRIPCION_PRODUCTO.MODELO_ID
                                            where PROC_DESCRIPCION like '" & "%" + nombreproducto + "%" & "'", cn)

            dt = New DataTable

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(4).Width = 480

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenarconsultaproveedor(ByVal nombre As String, ByVal dgv As DataGridView)

        Try

            adaptador = New SqlDataAdapter("select RFC, NOMBRE_PROVEEDOR from TBL_PROVEEDORES where NOMBRE_PROVEEDOR like '" & "%" + nombre + "%" & "'", cn)

            dt = New DataTable

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 480

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenarconsultapersonal(ByVal nombre As String, ByVal dgv As DataGridView)

        Try

            adaptador = New SqlDataAdapter("select ID_PERSONAL,NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO from TBL_PERSONAL where NOMBRE like '" & "%" + nombre + "%" & "'ORDER BY NOMBRE", cn)

            dt = New DataTable

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns(0).Width = 50
            dgv.Columns(1).Width = 200
            dgv.Columns(2).Width = 200
            dgv.Columns(3).Width = 200

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenarconsultagrupo(ByVal nombre As String, ByVal dgv As DataGridView)

        Try

            adaptador = New SqlDataAdapter("select TBL_PARTIDAS.CLAVE_PARTIDAS AS PARTIDA, DESCRIPCION_GRUPO from CAT_GRUPOS INNER JOIN TBL_PARTIDAS ON CAT_GRUPOS.ID_PARTIDA = TBL_PARTIDAS.ID_PARTIDAS
                                            where DESCRIPCION_GRUPO like '" & "%" + nombre + "%" & "'", cn)

            dt = New DataTable

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns(0).Width = 100
            dgv.Columns(1).Width = 230


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenarconsultamarca(ByVal nombre As String, ByVal dgv As DataGridView)

        Try

            adaptador = New SqlDataAdapter("select NOM_MARCA from CAT_MARCA where NOM_MARCA like '" & "%" + nombre + "%" & "'", cn)

            dt = New DataTable

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns(0).Width = 350


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenarconsultamodelo(ByVal nombre As String, ByVal dgv As DataGridView)

        Try

            adaptador = New SqlDataAdapter("select NOM_MODELO from CAT_MODELO where NOM_MODELO like '" & "%" + nombre + "%" & "'", cn)

            dt = New DataTable

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns(0).Width = 350


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'select TBL_PARTIDAS.CLAVE_PARTIDAS , PROC_DESCRIPCION from CAT_DESCRIPCION_PRODUCTO INNER JOIN TBL_PARTIDAS ON CAT_DESCRIPCION_PRODUCTO.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS

    Sub LlenarComboPartidasPoa(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Dim cmd As New SqlCommand

        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)


                cn.Open()

                cmd = New SqlCommand("Sp_ListaPartida", cn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@pSUBCAPITULOS_ID", cb2.SelectedValue)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim da As New SqlDataAdapter(cmd)

                Dim dt As New DataTable

                If reader.Read() Then
                    reader.Close()
                    da.Fill(dt)

                    cb.DisplayMember = "Descripcion"
                    cb.ValueMember = "ID_PARTIDAS"
                    cb.DataSource = dt
                End If
            End Using
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    'from nuevo en el poa para hacer consultas
    Sub Combodgvregistropoa(ByVal Ejercicio As String, ByVal dgv As DataGridView)

        Try
            adaptador = New SqlDataAdapter("Select ID,ID_UNIDAD,CAPITULO_ID,SUBCAPITULO_ID,PARTIDA_ID,IMPORTE,EJERCICIO,RUBRO_ID from TBL_RECURSOS_POA Where EJERCICIO like '" & "%" + Ejercicio + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 480

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'TERMINA EL LLENADO DE REPROGRAMACION POA
    Sub Llenadgvdetallefacturas(ByVal id_factura As String, ByVal dgv As DataGridView)
        Try

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA, TBL_FACTURAS_DETALLE.CANTIDAD, TBL_FACTURAS_DETALLE.NOIDENTIFICACION, TBL_FACTURAS_DETALLE.DESCRIPCION," &
                                           "TBL_FACTURAS_DETALLE.VALOR_UNITARIO, TBL_FACTURAS_DETALLE.IMPORTE from TBL_FACTURAS left join TBL_FACTURAS_DETALLE on (TBL_FACTURAS.ID_FACTURA = TBL_FACTURAS_DETALLE.FACTURA_ID)" &
                                           "Where TBL_FACTURAS.ID_FACTURA = '" & id_factura & "'", cn)


            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(0).Width = 100
            dgv.Columns(1).Width = 100
            'dgv.Columns(2).Width = 100
            dgv.Columns(2).Width = 110
            dgv.Columns(3).Width = 300
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 100


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Validamedicamentos(ByVal folio_factura As String, ByVal dgv As DataGridView)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn

            dgv.Columns.Add(col)

            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0

            col.HeaderText = "SELECCIONAR"



            dgv.ReadOnly = False
            dgv.DataSource = Nothing

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = CAT_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where FOLIO_FACTURA like '" & "%" + folio_factura + "%" & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(4).Width = 230
            dgv.Columns(4).HeaderText = "FOLIO FISCAL"
            dgv.Columns(5).Width = 100
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 60
            dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            dgv.Columns(8).Width = 250

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Green
                ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Red
                ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                    fila.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

            Dim col2 As New DataGridViewButtonColumn
            dgv.Columns.Add(col2)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 11
            col2.HeaderText = "DETALLES"
            col2.Text = "Ver detalles"
            col2.UseColumnTextForButtonValue = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenarComboProveedores(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID_PROVEEDOR,NOMBRE_PROVEEDOR FROM TBL_PROVEEDORES ORDER BY NOMBRE_PROVEEDOR"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "NOMBRE_PROVEEDOR"
                cb.ValueMember = "ID_PROVEEDOR"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
End Class

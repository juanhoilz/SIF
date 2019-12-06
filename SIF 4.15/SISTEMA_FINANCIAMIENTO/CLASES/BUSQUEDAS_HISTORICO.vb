Imports System.Data
Imports System.Data.SqlClient
Public Class BUSQUEDAS_HISTORICO

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
    Sub ConsultaDinamicaNombre(ByVal nombreproveedor As String, ByVal dgv As DataGridView)

        Try
            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA, TBL_PROVEEDORES.NOMBRE_PROVEEDOR, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL  from TBL_FACTURAS left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID)" &
                                           "left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where NOMBRE_PROVEEDOR like '" & "%" + nombreproveedor + "%" & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 80
            dgv.Columns(1).Width = 300
            dgv.Columns(1).HeaderText = "NOMBRE PROVEEDOR"
            dgv.Columns(2).Width = 100
            dgv.Columns(3).Width = 250
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            'dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            'dgv.Columns(8).Width = 250

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenadgvhistorico(ByVal id_factura As String, ByVal dgv As DataGridView)

        Try
            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA, TBL_ESTATUS_FACTURA.DESCRIPCION, TBL_FACTURAS_ESTATUS.FECHA_AUDITORIA from TBL_FACTURAS left join TBL_FACTURAS_ESTATUS on (TBL_FACTURAS.ID_FACTURA = TBL_FACTURAS_ESTATUS.FACTURA_ID)" &
                                           "left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS_ESTATUS.ESTATUS_ID)" &
                                           "Where TBL_FACTURAS.ID_FACTURA = '" & id_factura & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 80
            dgv.Columns(1).Width = 100
            dgv.Columns(1).HeaderText = "ESTATUS"
            dgv.Columns(2).Width = 150
            'dgv.Columns(3).Width = 300
            'dgv.Columns(3).HeaderText = "ESTATUS"
            'dgv.Columns(4).Width = 100
            'dgv.Columns(5).Width = 80
            'dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            'dgv.Columns(8).Width = 250

            'cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub ConsultaDinamicaRFC(ByVal rfc As String, ByVal dgv As DataGridView)

        'genera_checkbox(dgv)
        dgv.Columns.Clear()
        Dim col As New DataGridViewCheckBoxColumn
        dgv.Columns.Add(col)
        dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
        col.HeaderText = "SELECCIONAR"
        dgv.ReadOnly = False
        dgv.DataSource = Nothing

        Try
            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA,TBL_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, TBL_FACTURAS.FOLIO_FACTURA, TBL_FACTURAS.FOLIO_FISCAL, TBL_FACTURAS.FECHA_FACTURA, TBL_FACTURAS.TOTAL, TBL_RUBROS.CLAVE AS RUBRO, TBL_RUBROS.DESCRIPCION, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,TBL_PROVEEDORES.RFC from TBL_FACTURAS left join TBL_RUBROS on (TBL_FACTURAS.RUBRO_ID = TBL_RUBROS.ID_RUBRO)" &
                                           "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID) left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "Where RFC like '" & "%" + rfc + "%" & "'", cn)

            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns(0).Width = 80
            dgv.Columns(1).Width = 100
            dgv.Columns(1).HeaderText = "FOLIO FISCAL"
            dgv.Columns(2).Width = 80
            ' dgv.Columns(7).Width = 60
            ' dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            'dgv.Columns(8).Width = 250

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
            'dgv.Columns(8).HeaderText = "DESCRIPCION RUBRO"
            'dgv.Columns(8).Width = 250

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


    Sub ConsultaDinamicaNumInventario(ByVal NUM_INVENTARIO As String, ByVal dgv As DataGridView)

        Try
            adaptador = New SqlDataAdapter(
                "Select ID_INVENTARIO,TBL_EJERCICIOS.EJERCICIO,NUM_INVENTARIO,CO.NOMBRE_COMPLETO AS FUENTE_FINANCIAMIENTO,P.NOMBRE_PROVEEDOR,
       FOLIO_FACTURA,FOLIO_FISCAL,FECHA_FACTURA,FECHA_CAPTURA,U.NOMBRE AS UBICACION,S.DESCRIPCION AS SUBCAPITULO,TBL_PARTIDAS.DESCRIPCION AS PARTIDA,
       CAT_MARCA.NOM_MARCA AS MARCA,CAT_MODELO.NOM_MODELO AS MODELO,CAT_GRUPOS.DESCRIPCION_GRUPO AS GRUPO,
       TI.DESCRIPCION AS DESCRIPCION_ACTIVO,TI.DESCRIPCION_COMPLEMENTO,NoSERIE, NoIDENTIFICACION,CLAVE_PRODUCTO,
       UNIDAD,VALOR,No_RESGUARDO, TBL_PERSONAL.APELLIDO_PATERNO+' '+TBL_PERSONAL.APELLIDO_MATERNO+' '+TBL_PERSONAL.NOMBRE AS RESGUARDATARIO,
       OBSERVACIONES,ETIQUETADO,POLIZA from TBL_INVENTARIO TI left join TBL_EJERCICIOS  on (TI.EJERCICIO_ID = TBL_EJERCICIOS.ID)" &
              "left join TBL_CUENTA_ORIGEN CO on (CO.ID_FUENTE = TI.FUENTE_ID)" &
              "left join TBL_PROVEEDORES P on (P.ID_PROVEEDOR = TI.PROVEEDOR_ID)" &
              "left join TBL_UBICACION U on (U.ID_UBICACION = TI.UBICACION_ID)" &
              "left join TBL_SUBCAPITULOS S on (S.ID_SUBCAPITULOS = TI.SUBCAPITULO_ID)" &
              "left join TBL_PARTIDAS on (TBL_PARTIDAS.ID_PARTIDAS = TI.PARTIDAS_ID)" &
              "left join TBL_PERSONAL on (TBL_PERSONAL.ID_PERSONAL = TI.RESGUARDATORIO_ID)" &
              "left join CAT_MARCA on (CAT_MARCA.ID_MARCAS = TI.MARCA_ID)" &
              "left join CAT_MODELO on (CAT_MODELO.ID_MODELO = TI.MODELO_ID)" &
              "left join CAT_GRUPOS on (CAT_GRUPOS.ID_GRUPO = TI.GRUPO_ID)" &
              "left join TBL_UBICACION on (TBL_UBICACION.ID_UBICACION = TI.UBICACION_ID)" &
              "Where NUM_INVENTARIO Like '" & "%" + NUM_INVENTARIO + "%" & "'", cn)





            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(2).Width = 120
            dgv.Columns(3).Width = 120
            dgv.Columns(4).Width = 120
            dgv.Columns(9).Width = 120
            dgv.Columns(11).Width = 120
            dgv.Columns(23).Width = 120




            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub ConsultaDinamicaNOMPROVEEDOR(ByVal NOMBRE_PROVEEDOR As String, ByVal dgv As DataGridView)

        Try
            adaptador = New SqlDataAdapter(
                "Select ID_INVENTARIO,TBL_EJERCICIOS.EJERCICIO,NUM_INVENTARIO,CO.NOMBRE_COMPLETO AS FUENTE_FINANCIAMIENTO,P.NOMBRE_PROVEEDOR,
       FOLIO_FACTURA,FOLIO_FISCAL,FECHA_FACTURA,FECHA_CAPTURA,U.NOMBRE AS UBICACION,S.DESCRIPCION AS SUBCAPITULO,TBL_PARTIDAS.DESCRIPCION AS PARTIDA,
       CAT_MARCA.NOM_MARCA AS MARCA,CAT_MODELO.NOM_MODELO AS MODELO,CAT_GRUPOS.DESCRIPCION_GRUPO AS GRUPO,
       TI.DESCRIPCION AS DESCRIPCION_ACTIVO,TI.DESCRIPCION_COMPLEMENTO,NoSERIE, NoIDENTIFICACION,CLAVE_PRODUCTO,
       UNIDAD,VALOR,No_RESGUARDO, TBL_PERSONAL.APELLIDO_PATERNO+' '+TBL_PERSONAL.APELLIDO_MATERNO+' '+TBL_PERSONAL.NOMBRE AS RESGUARDATARIO,
       OBSERVACIONES,ETIQUETADO,POLIZA from TBL_INVENTARIO TI left join TBL_EJERCICIOS  on (TI.EJERCICIO_ID = TBL_EJERCICIOS.ID)" &
              "left join TBL_CUENTA_ORIGEN CO on (CO.ID_FUENTE = TI.FUENTE_ID)" &
              "left join TBL_PROVEEDORES P on (P.ID_PROVEEDOR = TI.PROVEEDOR_ID)" &
              "left join TBL_UBICACION U on (U.ID_UBICACION = TI.UBICACION_ID)" &
              "left join TBL_SUBCAPITULOS S on (S.ID_SUBCAPITULOS = TI.SUBCAPITULO_ID)" &
              "left join TBL_PARTIDAS on (TBL_PARTIDAS.ID_PARTIDAS = TI.PARTIDAS_ID)" &
              "left join TBL_PERSONAL on (TBL_PERSONAL.ID_PERSONAL = TI.RESGUARDATORIO_ID)" &
              "left join CAT_MARCA on (CAT_MARCA.ID_MARCAS = TI.MARCA_ID)" &
              "left join CAT_MODELO on (CAT_MODELO.ID_MODELO = TI.MODELO_ID)" &
              "left join CAT_GRUPOS on (CAT_GRUPOS.ID_GRUPO = TI.GRUPO_ID)" &
              "left join TBL_UBICACION on (TBL_UBICACION.ID_UBICACION = TI.UBICACION_ID)" &
              "Where NOMBRE_PROVEEDOR Like '" & "%" + NOMBRE_PROVEEDOR + "%" & "'", cn)





            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(2).Width = 120
            dgv.Columns(3).Width = 120
            dgv.Columns(4).Width = 120
            dgv.Columns(9).Width = 120
            dgv.Columns(11).Width = 120
            dgv.Columns(23).Width = 120

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub ConsultaDinamicaFACTURA(ByVal FOLIO_FACTURA As String, ByVal dgv As DataGridView)

        Try
            adaptador = New SqlDataAdapter(
                "Select ID_INVENTARIO,TBL_EJERCICIOS.EJERCICIO,NUM_INVENTARIO,CO.NOMBRE_COMPLETO AS FUENTE_FINANCIAMIENTO,P.NOMBRE_PROVEEDOR,
       FOLIO_FACTURA,FOLIO_FISCAL,FECHA_FACTURA,FECHA_CAPTURA,U.NOMBRE AS UBICACION,S.DESCRIPCION AS SUBCAPITULO,TBL_PARTIDAS.DESCRIPCION AS PARTIDA,
       CAT_MARCA.NOM_MARCA AS MARCA,CAT_MODELO.NOM_MODELO AS MODELO,CAT_GRUPOS.DESCRIPCION_GRUPO AS GRUPO,
       TI.DESCRIPCION AS DESCRIPCION_ACTIVO,TI.DESCRIPCION_COMPLEMENTO,NoSERIE, NoIDENTIFICACION,CLAVE_PRODUCTO,
       UNIDAD,VALOR,No_RESGUARDO, TBL_PERSONAL.APELLIDO_PATERNO+' '+TBL_PERSONAL.APELLIDO_MATERNO+' '+TBL_PERSONAL.NOMBRE AS RESGUARDATARIO,
       OBSERVACIONES,ETIQUETADO,POLIZA from TBL_INVENTARIO TI left join TBL_EJERCICIOS  on (TI.EJERCICIO_ID = TBL_EJERCICIOS.ID)" &
              "left join TBL_CUENTA_ORIGEN CO on (CO.ID_FUENTE = TI.FUENTE_ID)" &
              "left join TBL_PROVEEDORES P on (P.ID_PROVEEDOR = TI.PROVEEDOR_ID)" &
              "left join TBL_UBICACION U on (U.ID_UBICACION = TI.UBICACION_ID)" &
              "left join TBL_SUBCAPITULOS S on (S.ID_SUBCAPITULOS = TI.SUBCAPITULO_ID)" &
              "left join TBL_PARTIDAS on (TBL_PARTIDAS.ID_PARTIDAS = TI.PARTIDAS_ID)" &
              "left join TBL_PERSONAL on (TBL_PERSONAL.ID_PERSONAL = TI.RESGUARDATORIO_ID)" &
              "left join CAT_MARCA on (CAT_MARCA.ID_MARCAS = TI.MARCA_ID)" &
              "left join CAT_MODELO on (CAT_MODELO.ID_MODELO = TI.MODELO_ID)" &
              "left join CAT_GRUPOS on (CAT_GRUPOS.ID_GRUPO = TI.GRUPO_ID)" &
              "left join TBL_UBICACION on (TBL_UBICACION.ID_UBICACION = TI.UBICACION_ID)" &
              "Where FOLIO_FACTURA Like '" & "%" + FOLIO_FACTURA + "%" & "'", cn)





            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(2).Width = 120
            dgv.Columns(3).Width = 120
            dgv.Columns(4).Width = 120
            dgv.Columns(9).Width = 120
            dgv.Columns(11).Width = 120
            dgv.Columns(23).Width = 120

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Sub ConsultaDinamicaDESCRIPCION(ByVal DESCRIPCION As String, ByVal dgv As DataGridView)

        Try
            adaptador = New SqlDataAdapter(
                "Select ID_INVENTARIO,TBL_EJERCICIOS.EJERCICIO,NUM_INVENTARIO,CO.NOMBRE_COMPLETO AS FUENTE_FINANCIAMIENTO,P.NOMBRE_PROVEEDOR,
       FOLIO_FACTURA,FOLIO_FISCAL,FECHA_FACTURA,FECHA_CAPTURA,U.NOMBRE AS UBICACION,S.DESCRIPCION AS SUBCAPITULO,TBL_PARTIDAS.DESCRIPCION AS PARTIDA,
       CAT_MARCA.NOM_MARCA AS MARCA,CAT_MODELO.NOM_MODELO AS MODELO,CAT_GRUPOS.DESCRIPCION_GRUPO AS GRUPO,
       TI.DESCRIPCION AS DESCRIPCION_ACTIVO,TI.DESCRIPCION_COMPLEMENTO,NoSERIE, NoIDENTIFICACION,CLAVE_PRODUCTO,
       UNIDAD,VALOR,No_RESGUARDO, TBL_PERSONAL.APELLIDO_PATERNO+' '+TBL_PERSONAL.APELLIDO_MATERNO+' '+TBL_PERSONAL.NOMBRE AS RESGUARDATARIO,
       OBSERVACIONES,ETIQUETADO,POLIZA from TBL_INVENTARIO TI left join TBL_EJERCICIOS  on (TI.EJERCICIO_ID = TBL_EJERCICIOS.ID)" &
              "left join TBL_CUENTA_ORIGEN CO on (CO.ID_FUENTE = TI.FUENTE_ID)" &
              "left join TBL_PROVEEDORES P on (P.ID_PROVEEDOR = TI.PROVEEDOR_ID)" &
              "left join TBL_UBICACION U on (U.ID_UBICACION = TI.UBICACION_ID)" &
              "left join TBL_SUBCAPITULOS S on (S.ID_SUBCAPITULOS = TI.SUBCAPITULO_ID)" &
              "left join TBL_PARTIDAS on (TBL_PARTIDAS.ID_PARTIDAS = TI.PARTIDAS_ID)" &
              "left join TBL_PERSONAL on (TBL_PERSONAL.ID_PERSONAL = TI.RESGUARDATORIO_ID)" &
              "left join CAT_MARCA on (CAT_MARCA.ID_MARCAS = TI.MARCA_ID)" &
              "left join CAT_MODELO on (CAT_MODELO.ID_MODELO = TI.MODELO_ID)" &
              "left join CAT_GRUPOS on (CAT_GRUPOS.ID_GRUPO = TI.GRUPO_ID)" &
              "left join TBL_UBICACION on (TBL_UBICACION.ID_UBICACION = TI.UBICACION_ID)" &
              "Where TI.DESCRIPCION Like '" & "%" + DESCRIPCION + "%" & "'", cn)



            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(2).Width = 120
            dgv.Columns(3).Width = 120
            dgv.Columns(4).Width = 120
            dgv.Columns(9).Width = 120
            dgv.Columns(11).Width = 120
            dgv.Columns(23).Width = 120

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub ConsultaDinamicaFECHAFACTURAINVENTARIO(ByVal fechainicio As String, ByVal fechafin As String, ByVal dgv As DataGridView)



        dgv.Columns.Clear()
        Dim col As New DataGridViewCheckBoxColumn
        dgv.Columns.Add(col)
        dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
        col.HeaderText = "SELECCIONAR"
        dgv.ReadOnly = False
        dgv.DataSource = Nothing
        Try
            adaptador = New SqlDataAdapter(
                "Select ID_INVENTARIO,TBL_EJERCICIOS.EJERCICIO,NUM_INVENTARIO,CO.NOMBRE_COMPLETO AS FUENTE_FINANCIAMIENTO,P.NOMBRE_PROVEEDOR,
       FOLIO_FACTURA,FOLIO_FISCAL,FECHA_FACTURA,FECHA_CAPTURA,U.NOMBRE AS UBICACION,S.DESCRIPCION AS SUBCAPITULO,TBL_PARTIDAS.DESCRIPCION AS PARTIDA,
       CAT_MARCA.NOM_MARCA AS MARCA,CAT_MODELO.NOM_MODELO AS MODELO,CAT_GRUPOS.DESCRIPCION_GRUPO AS GRUPO,
       TI.DESCRIPCION AS DESCRIPCION_ACTIVO,TI.DESCRIPCION_COMPLEMENTO,NoSERIE, NoIDENTIFICACION,CLAVE_PRODUCTO,
       UNIDAD,VALOR,No_RESGUARDO, TBL_PERSONAL.APELLIDO_PATERNO+' '+TBL_PERSONAL.APELLIDO_MATERNO+' '+TBL_PERSONAL.NOMBRE AS RESGUARDATARIO,
       OBSERVACIONES,ETIQUETADO,POLIZA from TBL_INVENTARIO TI left join TBL_EJERCICIOS  on (TI.EJERCICIO_ID = TBL_EJERCICIOS.ID)" &
              "left join TBL_CUENTA_ORIGEN CO on (CO.ID_FUENTE = TI.FUENTE_ID)" &
              "left join TBL_PROVEEDORES P on (P.ID_PROVEEDOR = TI.PROVEEDOR_ID)" &
              "left join TBL_UBICACION U on (U.ID_UBICACION = TI.UBICACION_ID)" &
              "left join TBL_SUBCAPITULOS S on (S.ID_SUBCAPITULOS = TI.SUBCAPITULO_ID)" &
              "left join TBL_PARTIDAS on (TBL_PARTIDAS.ID_PARTIDAS = TI.PARTIDAS_ID)" &
              "left join TBL_PERSONAL on (TBL_PERSONAL.ID_PERSONAL = TI.RESGUARDATORIO_ID)" &
              "left join CAT_MARCA on (CAT_MARCA.ID_MARCAS = TI.MARCA_ID)" &
              "left join CAT_MODELO on (CAT_MODELO.ID_MODELO = TI.MODELO_ID)" &
              "left join CAT_GRUPOS on (CAT_GRUPOS.ID_GRUPO = TI.GRUPO_ID)" &
              "left join TBL_UBICACION on (TBL_UBICACION.ID_UBICACION = TI.UBICACION_ID)" &
               "Where TBL_FACTURAS.FECHA_FACTURA  >= '" & fechainicio & "' and TBL_FACTURAS.FECHA_FACTURA <= '" & fechafin & "'", cn)




            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dgv.Columns(2).Width = 120
            dgv.Columns(3).Width = 120
            dgv.Columns(4).Width = 120
            dgv.Columns(9).Width = 120
            dgv.Columns(11).Width = 120
            dgv.Columns(23).Width = 120
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class

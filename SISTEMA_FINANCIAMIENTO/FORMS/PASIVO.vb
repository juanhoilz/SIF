Imports System.Data
Imports System.Data.SqlClient

Public Class PASIVO

    Dim funciones As New BUSQUEDAS_PASIVO
    Dim funciones2 As New BASEDATOS
    Public cn As New SqlConnection
    Private Sub cbCuentas_Enter(sender As Object, e As EventArgs) Handles cbcuentas.Enter
        funciones2.llenarcomboejercicio(cbcuentas)
    End Sub

    Private Sub Combox_Ejercicio_Enter(sender As Object, e As EventArgs) Handles cbejercicio.Enter
        funciones.LlenarComboanioejercicio(cbejercicio)
    End Sub
    'Private Sub cbcuentas_Enter(sender As Object, e As EventArgs) Handles cbcuentas_Enter

    ' End Sub

    Private Sub PASIVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        funciones.Llenardgvcatunidades(dgvUnidades)

        dgvDetalles.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvDetalles.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        dgvUnidades.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvUnidades.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        dgvProveedor.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvProveedor.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        dgvPartida.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvPartida.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        'dtpFechapago.Enabled = False
        tbObservaciones.Enabled = False
        btguarda.Enabled = False
        'cbPago.Enabled = False

        'funciones2.llenarcomboestatus(cbEstatus)

    End Sub

    Private Sub dgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnidades.CellClick

        lbImporte.Text = ""

        Dim id As String = dgvUnidades.SelectedRows(0).Cells("ID").Value

        funciones.Llenardgvdetallepresupuesto(id, dgvPresupuesto)
        'If rbTesofe.Checked = True Then

        'este checkbox al habitalarlo muestra todas las facturas cargadas en alta factura.
        If Checkboxtodo.Checked = True Then
            'cbcuentas.Enabled = False
            funciones.Llenardgvpasivogeneral(id, dgvDetalles)
            funciones.Llenardgvpasivoproveedorpartidageneral(id, dgvProveedor)
            funciones.Llenardgvpasivoproveedorgeneral(id, dgvPartida)

            'SE AGREGO COMO PARAMETRO DE BUSQUEDA EL AÑO PARA EL FILTRADO DE LAS FACTURAS -cbejercicio.SelectedValue
            'En cada una de las cuentas origen
            'ESTE ESLEIF MUESTRA LOS QUE ESTAN EN TESOFE
        ElseIf cbcuentas.SelectedIndex = 0 Then
            'cbcuentas.Enabled = True
            '
            funciones.LlenardgvpasivoTESOFE(id, dgvDetalles, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorpartidaTESOFE(id, dgvProveedor, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorTESOFE(id, dgvPartida, cbejercicio.SelectedValue)
            'ElseIf rbAportacion.Checked = True Then

            'ESTE ESLEIF MUESTRA LOS QUE ESTAN EN CUOTA SOCIAL
        ElseIf cbcuentas.SelectedIndex = 1 Then
            'cbcuentas.Enabled = True
            funciones.LlenardgvpasivoCUOTASOCIAL(id, dgvDetalles, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorpartidaCUOTASOCIAL(id, dgvProveedor, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorCUOTASOCIAL(id, dgvPartida, cbejercicio.SelectedValue)
            'ElseIf rbTodo.Checked = True Then

            'ESTE ESLEIF MUESTRA LOS QUE ESTAN EN APORTACION ESTATAL
        ElseIf cbcuentas.SelectedIndex = 2 Then
            'cbcuentas.Enabled = True
            funciones.LlenardgvpasivoAE(id, dgvDetalles, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorpartidaAE(id, dgvProveedor, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorAE(id, dgvPartida, cbejercicio.SelectedValue)
            'ElseIf rbTodo.Checked = True Then

            'ESTE ESLEIF MUESTRA LOS QUE ESTAN EN SIGLO XXI
        ElseIf cbcuentas.SelectedIndex = 3 Then
            'cbcuentas.Enabled = True
            funciones.LlenardgvpasivoSMSXXI(id, dgvDetalles, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorpartidaSMSXXI(id, dgvProveedor, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorSMSXI(id, dgvPartida, cbejercicio.SelectedValue)
            'ElseIf rbTodo.Checked = True Then
            'ESTE ESLEIF MUESTRA LOS QUE ESTAN EN GASTOS CATASTRIFICOS
        ElseIf cbcuentas.SelectedIndex = 4 Then
            'cbcuentas.Enabled = True
            funciones.LlenardgvpasivoGC(id, dgvDetalles, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorpartidaGC(id, dgvProveedor, cbejercicio.SelectedValue)
            funciones.LlenardgvpasivoproveedorGC(id, dgvPartida, cbejercicio.SelectedValue)
            'ElseIf rbTodo.Checked = True Then
        End If


    End Sub

    Private Sub dgvDetalles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellDoubleClick

        Dim detalles As New DETALLE_FACTURA
        Dim id As String = dgvDetalles.SelectedRows(0).Cells("ID_FACTURA").Value
        Dim folio As String = dgvDetalles.SelectedRows(0).Cells("FACTURA").Value
        Dim nombre As String = dgvDetalles.SelectedRows(0).Cells("NOMBRE_PROVEEDOR").Value

        detalles.tbId.Text = id
        detalles.tbFolio.Text = folio
        detalles.tbNombre.Text = nombre
        detalles.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles dgvBuscarproveedor.TextChanged

        funciones.Llenardgvcatunidadesdinamico(dgvBuscarproveedor.Text, dgvUnidades)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged

        Dim id As String = dgvUnidades.SelectedRows(0).Cells("ID").Value

        funciones.LlenardgvpasivoTESOFEdinamicoproveedor(id, dgvDetalles, tbBusqueda.Text)

    End Sub

    Private Sub cbEstatus_Enter(sender As Object, e As EventArgs) Handles cbEstatus.Enter
        funciones.llenarcomboestatus(cbEstatus)
        If cbEstatus.SelectedValue Then
            btguarda.Enabled = True

        End If
        'cbEstatus.DataSource = Nothing

    End Sub

    Private Sub dgvDetalles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellContentClick

        If e.RowIndex < 0 Or Not e.ColumnIndex = 0 Then Exit Sub
        If Convert.ToBoolean(dgvDetalles.Rows(e.RowIndex).Cells(0).Value) Then
            dgvDetalles.Rows(e.RowIndex).Cells(0).Value = False
        Else
            dgvDetalles.Rows(e.RowIndex).Cells(0).Value = True
        End If


        Dim totalcomprometido As Decimal
        Dim Columna As Integer = 9

        For Each fila As DataGridViewRow In dgvDetalles.Rows

            If fila.Cells(0).Value = True Then
                totalcomprometido += Val(fila.Cells(Columna).Value)
            End If
        Next

        lbImporte.Text = Format(totalcomprometido, "#,##0.00")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btguarda.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        'tbObservaciones.Enabled = True
        'Se genera la lista temporal de los registros marcados
        If tcPasivos.SelectedIndex = 0 Then

            'Con este condicion evalua que proceso sigue con la factura dada de alta
            If cbEstatus.SelectedIndex = 0 Then
                'Se genera un datagridview temporal para cargar los registros marcados
                Dim rowselected As New List(Of DataGridViewRow)()

                For Each row As DataGridViewRow In dgvDetalles.Rows

                    Dim cellseleccion As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)

                    If Convert.ToBoolean(cellseleccion.Value) Then
                        rowselected.Add(row)

                    End If
                Next


                For Each row As DataGridViewRow In rowselected

                    Dim VALOR As Integer
                    VALOR = lbImporte.Text

                    Dim ID_FACTURA As String = dgvDetalles.SelectedRows(0).Cells("ID_FACTURA").Value
                    Dim UNIDAD As String = dgvDetalles.SelectedRows(0).Cells("UNIDAD_ID").Value
                    Dim PARTIDA As String = dgvDetalles.SelectedRows(0).Cells("PARTIDA_ID").Value
                    Dim EJERCICIO As String = dgvDetalles.SelectedRows(0).Cells("EJERCICIO_ID").Value
                    Dim RUBRO As String = dgvDetalles.SelectedRows(0).Cells("RUBRO_ID").Value
                    'cambiar el estatus de una factura


                    'update para que cuando se envie a pago en la tabla recursos poa saldo se comprometa ese monto a pago
                    Dim actualizacomprometido As String = "UPDATE TBL_RECURSOS_POA_SALDOS set COMPROMETIDO = (COMPROMETIDO + '" & VALOR & "') from  TBL_RECURSOS_POA_SALDOS 
                Left Join TBL_RECURSOS_POA on (TBL_RECURSOS_POA_SALDOS.RECURSO_ID = TBL_RECURSOS_POA.ID) where UNIDAD_ID = '" & UNIDAD & "' and PARTIDA_ID = '" & PARTIDA & "' AND EJERCICIO = '" & EJERCICIO & "' AND RUBRO_ID = '" & RUBRO & "'"
                    Dim comactualizacomprometido As New SqlCommand(actualizacomprometido, cn)
                    comactualizacomprometido.ExecuteNonQuery()

                    Dim Reader As SqlDataReader
                    'cn.Open()
                    Reader = comactualizacomprometido.ExecuteReader
                    'ESTE CONDICION SE CREO CON EL FIN DE QUE UNA FACTURA DEBE DE AGREGARSE PRIMERO A LA TABLA SALDOS COMO COMPROMETIDO PARA QUE
                    'SE CAMBIE EL ESTATUS MIENTRAS TANTO SI ESTO NO ES ASI , LA FACTURA AUN SIGUE ESTANDO EN PROCESO ESPERA.
                    If (Reader.Read) Then

                        Dim actualizaestatus As String = "UPDATE TBL_FACTURAS set ESTATUS_ID = '" & cbEstatus.SelectedValue & "'  Where ID_FACTURA = '" & ID_FACTURA & "' "
                        Dim comactualizaestatus As New SqlCommand(actualizaestatus, cn)
                        comactualizaestatus.ExecuteNonQuery()

                        Dim guardaestatus As String = "INSERT INTO TBL_FACTURAS_ESTATUS (FACTURA_ID, ESTATUS_ID, FECHA_AUDITORIA) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA_AUDITORIA)"
                        Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

                        comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(row.Cells("ID_FACTURA").Value))
                        comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", cbEstatus.SelectedValue)
                        comguardaestatus.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                        comguardaestatus.ExecuteNonQuery()

                        MessageBox.Show("Se ha actualizado un importe de $" & lbImporte.Text & " Cuenta con 24 hrs. apartir de ahora para realizar el pago", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        cn.Close()
                    Else
                        MessageBox.Show("HA OCURRIDO ALGUN ERROR AL ENVIAR LA FACTURA A PAGO", "VALIDAR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                    Reader.Close()

                Next
            Else
                'ESTE MENSAJE ES MOMENTANEO YA QUE NECESITAMOS SABER QUE PROCESO TENDRA CON LOS SIGUIENTES SELECCIONES-- CANCELADO- REFRACTIRADO- OTRO--ETC
                MessageBox.Show("PRECEDIMIENTO EN PROCESO DE LA FACTURA", "EN PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf tcPasivos.SelectedIndex = 1 Then

            'Se genera un datagridview temporal para cargar los registros marcados
            Dim rowselected As New List(Of DataGridViewRow)()

            For Each row As DataGridViewRow In dgvDetalleproveedorTESOFE.Rows

                Dim cellseleccion As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)

                If Convert.ToBoolean(cellseleccion.Value) Then
                    rowselected.Add(row)

                End If
            Next

            For Each row As DataGridViewRow In rowselected

                'MsgBox(row.Cells(1).Value.ToString)
                Dim actualizaestatus As String = "UPDATE TBL_FACTURAS set ESTATUS_ID = '" & cbEstatus.SelectedValue & "'  Where ID_FACTURA = '" & row.Cells(1).Value.ToString & "' "
                Dim comactualizaestatus As New SqlCommand(actualizaestatus, cn)
                comactualizaestatus.ExecuteNonQuery()
                'update para que cuando se envie a pago en la tabla recursos poa saldo se comprometa ese monto a pago
                'Dim actualizacomprometido As String = "UPDATE TBL_RECURSOS_POA_SALDOS set COMPROMETIDO = (COMPROMETIDO + '" & lbImporte.Text & "') from  TBL_RECURSOS_POA_SALDOS 
                'Left Join TBL_RECURSOS_POA on (TBL_RECURSOS_POA_SALDOS.RECURSO_ID = TBL_RECURSOS_POA.ID) where UNIDAD_ID = '1020' and PARTIDA_ID = '81' AND EJERCICIO = '1' AND RUBRO_ID = '7'"
                'Dim comactualizacomprometido As New SqlCommand(actualizacomprometido, cn)
                'comactualizacomprometido.ExecuteNonQuery()

                Dim guardaestatus As String = "INSERT INTO FACTURAS_ESTATUS (FACTURA_ID, ESTATUS_ID, FECHA_AUDITORIA) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA_AUDITORIA)"
                Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

                comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(row.Cells("ID_FACTURA").Value))
                comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", cbEstatus.SelectedValue)
                comguardaestatus.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                comguardaestatus.ExecuteNonQuery()

                'Dim Hora As String = 



            Next

            MessageBox.Show("Se ha actualizado un importe de $" & lbImporte.Text & " Cuenta con 24 hrs. apartir de ahora para realizar el pago", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cn.Close()

        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResumenproveedor.CellClick

        Dim id As String = dgvResumenproveedor.SelectedRows(0).Cells("ID").Value

        'funciones.dgvDetalleproveedorTESOFE(id, dgvPresupuesto)

        'If rbTesofe.Checked = True Then
        funciones.dgvDetalleproveedorTESOFE(id, dgvDetalleproveedorTESOFE)
        'funciones.LlenardgvpasivoproveedorpartidaTESOFE(id, dgvProveedor)
        'funciones.LlenardgvpasivoproveedorTESOFE(id, dgvPartida)

        'ElseIf rbAportacion.Checked = True Then
        'funciones.LlenardgvpasivoAE(id, dgvDetalles)
        'funciones.LlenardgvpasivoproveedorpartidaAE(id, dgvProveedor)
        'funciones.LlenardgvpasivoproveedorAE(id, dgvPartida)
        'ElseIf rbTodo.Checked = True Then
        'funciones.LlenardgvpasivoTESOFEAportacion(id, dgvDetalles)
        'funciones.LlenardgvpasivoproveedorpartidaTESOFEAportacion(id, dgvProveedor)
        'funciones.LlenardgvpasivoproveedorTESOFEAportacion(id, dgvPartida)
        'End If




    End Sub

    Private Sub General_Selected(sender As Object, e As TabControlEventArgs) Handles tcPasivos.Selected
        funciones.Llenarcatproveedores(dgvResumenproveedor)
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles tbBuscarproveedor.TextChanged
        funciones.Llenarcatproveedoresdinamico(dgvResumenproveedor, tbBuscarproveedor.Text)
    End Sub



    Private Sub cbEstatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEstatus.SelectionChangeCommitted
        If cbEstatus.SelectedValue = 5 Or cbEstatus.SelectedValue = 6 Then
            tbObservaciones.Enabled = True
        Else
            tbObservaciones.Enabled = False
        End If
    End Sub



    Private Sub tcPasivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcPasivos.SelectedIndexChanged
        lbImporte.Text = ""
    End Sub

    Private Sub dgvDetalleproveedorTESOFE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Or Not e.ColumnIndex = 0 Then Exit Sub
        If Convert.ToBoolean(dgvDetalleproveedorTESOFE.Rows(e.RowIndex).Cells(0).Value) Then
            dgvDetalleproveedorTESOFE.Rows(e.RowIndex).Cells(0).Value = False
        Else
            dgvDetalleproveedorTESOFE.Rows(e.RowIndex).Cells(0).Value = True
        End If


        Dim totalcomprometido As Decimal
        Dim Columna As Integer = 9

        For Each fila As DataGridViewRow In dgvDetalleproveedorTESOFE.Rows

            If fila.Cells(0).Value = True Then
                totalcomprometido += Val(fila.Cells(Columna).Value)
            End If
        Next

        lbImporte.Text = Format(totalcomprometido, "#,##0.00")
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        REPORTES_PASIVO.ShowDialog()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) 
        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        'Se genera la lista temporal de los registros marcados
        If tcPasivos.SelectedIndex = 0 Then

            'Se genera un datagridview temporal para cargar los registros marcados
            Dim rowselected As New List(Of DataGridViewRow)()

            For Each row As DataGridViewRow In dgvDetalles.Rows

                Dim cellseleccion As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)

                If Convert.ToBoolean(cellseleccion.Value) Then
                    rowselected.Add(row)

                End If
            Next


            For Each row As DataGridViewRow In rowselected

                'MsgBox(row.Cells(1).Value.ToString)
                Dim actualizaestatus As String = "UPDATE FACTURAS set ID_ESTATUS = '" & cbEstatus.SelectedValue & "'  Where ID_FACTURA = '" & row.Cells(1).Value.ToString & "' "
                Dim comactualizaestatus As New SqlCommand(actualizaestatus, cn)
                comactualizaestatus.ExecuteNonQuery()

                Dim guardaestatus As String = "INSERT INTO FACTURAS_ESTATUS (ID_FACTURA, ID_ESTATUS, FECHA_AUDITORIA) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA_AUDITORIA)"
                Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

                comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(row.Cells("ID_FACTURA").Value))
                comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", cbEstatus.SelectedValue)
                comguardaestatus.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                comguardaestatus.ExecuteNonQuery()

                'Dim Hora As String = 



            Next

            MessageBox.Show("Se ha actualizado un importe de $" & lbImporte.Text & " Cuenta con 24 hrs. apartir de ahora para realizar el pago", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cn.Close()

        ElseIf tcPasivos.SelectedIndex = 1 Then

            'Se genera un datagridview temporal para cargar los registros marcados
            Dim rowselected As New List(Of DataGridViewRow)()

            For Each row As DataGridViewRow In dgvDetalleproveedorTESOFE.Rows

                Dim cellseleccion As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)

                If Convert.ToBoolean(cellseleccion.Value) Then
                    rowselected.Add(row)

                End If
            Next

            For Each row As DataGridViewRow In rowselected

                'MsgBox(row.Cells(1).Value.ToString)
                Dim actualizaestatus As String = "UPDATE FACTURAS set ID_ESTATUS = '" & cbEstatus.SelectedValue & "'  Where ID_FACTURA = '" & row.Cells(1).Value.ToString & "' "
                Dim comactualizaestatus As New SqlCommand(actualizaestatus, cn)
                comactualizaestatus.ExecuteNonQuery()

                Dim guardaestatus As String = "INSERT INTO FACTURAS_ESTATUS (ID_FACTURA, ID_ESTATUS, FECHA_AUDITORIA) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA_AUDITORIA)"
                Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

                comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(row.Cells("ID_FACTURA").Value))
                comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", cbEstatus.SelectedValue)
                comguardaestatus.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                comguardaestatus.ExecuteNonQuery()

                'Dim Hora As String = 



            Next

            MessageBox.Show("Se ha actualizado un importe de $" & lbImporte.Text & " Cuenta con 24 hrs. apartir de ahora para realizar el pago", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cn.Close()

        End If
    End Sub


End Class
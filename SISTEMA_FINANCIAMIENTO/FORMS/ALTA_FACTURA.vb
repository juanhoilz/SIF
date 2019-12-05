Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Public Class Altafactura
    Public cn As New SqlConnection
    Public comandoguardar As New SqlCommand
    Dim numletras As New Numeros_a_letras

    'FUNCIONES DECLARADAS'

    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Public respuesta As SqlDataReader

    Dim funciones As New BASEDATOS
    Dim validacampos As New Validacampos
    Dim valida_registro_recepcion As New Valida_Existe_Registro

    Private Sub Altafactura_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        cn.Close()
        PRINCIPAL.Show()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        PRINCIPAL.Show()
    End Sub

    'INICIO DE LLENADO DE COMBOBOX DEL FORMULARIO 

    Private Sub cbEjercicio_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones.LlenarComboanioejercicio(cbEjercicio)
    End Sub

    Private Sub ComboBox4_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbcuenta.SelectionChangeCommitted
        muestrasaldoactualizado()
    End Sub
    Private Sub cbCuentas_Enter(sender As Object, e As EventArgs) Handles cbCuentas.Enter
        funciones.llenarcomboejercicio(cbCuentas)
    End Sub

    Private Sub ComboBox4_Enter(sender As Object, e As EventArgs) Handles cbcuenta.Enter
        If cbCuentas.SelectedValue Then
            funciones.LlenarComboCuentas(cbcuenta, cbCuentas)
        End If

    End Sub

    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs) Handles cbPartida.Enter
        funciones.llenacombopartidasfiltro(cbPartida)
    End Sub

    Private Sub cbRubro_Enter(sender As Object, e As EventArgs) Handles cbRubro.Enter
        funciones.llenarcomborubro(cbRubro)
    End Sub
    Private Sub cbUnidad_Enter(sender As Object, e As EventArgs) Handles cbUnidad.Enter

        If cbRubro.SelectedValue = 7 Or cbRubro.SelectedValue = 10 Then

            funciones.UnidadesPorRubro(cbUnidad, cbRubro)

        Else

            funciones.LlenarComboUnidades(cbUnidad)

        End If

    End Sub

    Private Sub ComboBox2_Enter_2(sender As Object, e As EventArgs) Handles cbLicitaciones.Enter
        funciones.llenarcombolicitacion(cbLicitaciones)
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbTipoadquisicion.Enter
        funciones.LlenarComboAdquisicion(cbTipoadquisicion)
    End Sub

    Private Sub cbProveedores_Enter(sender As Object, e As EventArgs) Handles cbProveedores.Enter
        funciones.Llenarcatproveedores(cbProveedores)
    End Sub


    'FINALIZADO DE LOS LLENADOS DE COMBOBOX' 

    Private Sub Altafactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Me.AutoScaleDimensions = New System.Drawing.SizeF(100.0F, 110.0F)
        'Me.PerformAutoScale()

        lbSobreprecio.Visible = False
        lbCauses.Visible = False
        lbTotalpago.Visible = False
        tbSobreprecio.Visible = False
        tbCauses.Visible = False
        tbTotalpago.Visible = False
        cbCAUSES.Enabled = False
        cbpreciosref.Enabled = False
        'Se instancia la clase autoescala

        'Dim autoescalar As New Autoescala
        'autoescalar.ResizeForm(Me, 1920, 1080)

        'tbFoliofactura.Enabled = False
        Try

            ToolTip1.SetToolTip(Me.BtAgregar, "Valida la información capturada")
            tbFoliofactura.CharacterCasing = CharacterCasing.Upper
            tbObservaciones.CharacterCasing = CharacterCasing.Upper

            BtAgregar.Enabled = True
            BtGuardar.Enabled = False
            btAgregarconceptos.Enabled = False
            lbIdentificador.Visible = False
            btMedicamentos.Enabled = False

            EstiloGrid()
            'llenagriddetalles()
            'funciones.LlenarComboBox(ComboBox2)
            'funciones.LlenarComboUnidades(cbUnidad)
            'funciones.LlenarComboAdquisicion(ComboBox5)

            funciones.llenarcomboestatus(cbEstatus)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click

        Try


            If valida_registro_recepcion.Valida_Existe_recepcion(tbFoliofiscal.Text) = False Then

                cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()

                Dim idFolio As Integer = 0

                Dim consulta As String = "INSERT INTO TBL_FACTURAS (EJERCICIO_ID, RUBRO_ID, FUENTE_ID, LICITACION_ID, CUENTA_ID, PROVEEDOR_ID,ESTATUS_ID, FOLIO_FACTURA, FOLIO_FISCAL,PARTIDA_ID,FECHA_FACTURA,FECHA_RECEPCION,UNIDAD_ID,SUBTOTAL,IVA,ISR,TOTAL,OBSERVACION) VALUES (@ID_EJERCICIO, @ID_RUBRO, @ID_FUENTE, @ID_LICITACION, @ID_CUENTA, @ID_PROVEEDOR, @ID_ESTATUS, @FOLIO_FACTURA, @FOLIO_FISCAL, @ID_PARTIDA, @FECHA_FACTURA, @FECHA_RECEPCION, @ID_UNIDAD,@SUBTOTAL,@IVA,@ISR,@TOTAL,@OBSERVACION) SELECT SCOPE_IDENTITY()"

                Dim comm As New SqlCommand(consulta, cn)

                comm.Parameters.AddWithValue("@ID_EJERCICIO", Convert.ToInt16(cbEjercicio.SelectedValue))
                comm.Parameters.AddWithValue("@ID_RUBRO", Convert.ToInt16(cbRubro.SelectedValue))
                comm.Parameters.AddWithValue("@ID_FUENTE", Convert.ToInt16(cbCuentas.SelectedValue))
                comm.Parameters.AddWithValue("@ID_LICITACION", Convert.ToInt16(cbLicitaciones.SelectedValue))
                comm.Parameters.AddWithValue("@ID_CUENTA", Convert.ToInt16(cbcuenta.SelectedValue))
                comm.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt16(cbProveedores.SelectedValue))
                comm.Parameters.AddWithValue("@ID_ESTATUS", Convert.ToInt16(cbEstatus.SelectedValue))
                comm.Parameters.AddWithValue("@FOLIO_FACTURA", tbFoliofactura.Text)
                comm.Parameters.AddWithValue("@FOLIO_FISCAL", tbFoliofiscal.Text)
                comm.Parameters.AddWithValue("@ID_PARTIDA", Convert.ToInt16(cbPartida.SelectedValue))
                comm.Parameters.AddWithValue("@FECHA_FACTURA", dtpFechafactura.Value)
                comm.Parameters.AddWithValue("@FECHA_RECEPCION", dtpFecharecepcion.Value)
                comm.Parameters.AddWithValue("@ID_UNIDAD", Convert.ToInt16(cbUnidad.SelectedValue))
                comm.Parameters.AddWithValue("@SUBTOTAL", Convert.ToDecimal(tbSubtotal.Text))
                comm.Parameters.AddWithValue("@IVA", Convert.ToDecimal(tbIva.Text))
                comm.Parameters.AddWithValue("@ISR", Convert.ToDecimal(tbRetencion.Text))
                comm.Parameters.AddWithValue("@TOTAL", Convert.ToDecimal(tbTotal.Text))
                comm.Parameters.AddWithValue("@OBSERVACION", tbObservaciones.Text)

                idFolio = Convert.ToInt16(comm.ExecuteScalar)
                tbFolio.Text = idFolio


                Dim insertacheckbox As String = "INSERT INTO TBL_COMPROBANTES_FACTURAS (FACTURA_ID, FIRMA, SOPORTE, ORDEN_SERVICIO, ORDEN_COMPRA, VALE_SALIDA, COTIZACIONES, FACTURA_ORIGINAL) VALUES (@ID_FACTURA, @FIRMA, @SOPORTE, @ORDEN_SERVICIO, @ORDEN_COMPRA, @VALE_SALIDA, @COTIZACIONES, @FACTURA_ORIGINAL)"
                Dim cominsertacheckbox As New SqlCommand(insertacheckbox, cn)

                cominsertacheckbox.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(tbFolio.Text))
                cominsertacheckbox.Parameters.AddWithValue("@FIRMA", chbFirmado.CheckState)
                cominsertacheckbox.Parameters.AddWithValue("@SOPORTE", chBSoporte.CheckState)
                cominsertacheckbox.Parameters.AddWithValue("@ORDEN_SERVICIO", chbServicio.CheckState)
                cominsertacheckbox.Parameters.AddWithValue("@ORDEN_COMPRA", chbOrden.CheckState)
                cominsertacheckbox.Parameters.AddWithValue("@VALE_SALIDA", chbVale.CheckState)
                cominsertacheckbox.Parameters.AddWithValue("@COTIZACIONES", chbCotiza.CheckState)
                cominsertacheckbox.Parameters.AddWithValue("@FACTURA_ORIGINAL", chbPedido.CheckState)

                cominsertacheckbox.ExecuteNonQuery()


                If cbPartida.SelectedValue = 29 Then

                    'Código para guardar en la tabla CAT_MEDICAMENTOS
                    For Each row As DataGridViewRow In dgvDetalles.Rows

                        Dim guardamedicamentos As String = "INSERT INTO TBL_MEDICAMENTOS (FACTURA_ID, FOLIO, CLAVE, PRECIO_UNITARIO, CANTIDAD, IMPORTE, SOBREPRECIO, SIN_CAUSES, TOTAL_PAGO, ANIO_CAUSES) VALUES (@ID_FACTURA, @FOLIO, @CLAVE, @PRECIO_UNITARIO, @CANTIDAD, @IMPORTE, @SOBREPRECIO, @SIN_CAUSES, @TOTAL_PAGO, @ANIO_CAUSES)"
                        Dim comguardamedicamentos As New SqlCommand(guardamedicamentos, cn)

                        comguardamedicamentos.Parameters.AddWithValue("@ID_FACTURA", SqlDbType.Int).Value = idFolio
                        comguardamedicamentos.Parameters.AddWithValue("@FOLIO", tbFoliofactura.Text)
                        comguardamedicamentos.Parameters.AddWithValue("@CLAVE", row.Cells("noIdentificacion").Value)
                        comguardamedicamentos.Parameters.AddWithValue("@PRECIO_UNITARIO", Convert.ToDecimal(row.Cells("ValorUnitario").Value))
                        comguardamedicamentos.Parameters.AddWithValue("@CANTIDAD", Convert.ToDecimal(row.Cells("Cantidad").Value))
                        comguardamedicamentos.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(row.Cells("Importe").Value))
                        comguardamedicamentos.Parameters.AddWithValue("@SOBREPRECIO", Convert.ToDecimal(row.Cells("sobreprecio").Value))
                        comguardamedicamentos.Parameters.AddWithValue("@SIN_CAUSES", Convert.ToDecimal(row.Cells("causes").Value))
                        comguardamedicamentos.Parameters.AddWithValue("@TOTAL_PAGO", Convert.ToDecimal(row.Cells("totalpago").Value))
                        comguardamedicamentos.Parameters.AddWithValue("@ANIO_CAUSES", cbCAUSES.Text)

                        comguardamedicamentos.ExecuteNonQuery()
                    Next

                Else
                    'Código para guardar en la tabla TBL_FACTURAS_DETALLE
                    For Each row As DataGridViewRow In dgvDetalles.Rows

                        Dim guardadetalles As String = "INSERT INTO TBL_FACTURAS_DETALLE (FACTURA_ID, CANTIDAD,  NOIDENTIFICACION, DESCRIPCION, VALOR_UNITARIO, IMPORTE) VALUES (@ID_FACTURA_DETALLE, @CANTIDAD, @NOIDENTIFICACION, @DESCRIPCION, @VALOR_UNITARIO, @IMPORTE)"
                        Dim comguardadetalles As New SqlCommand(guardadetalles, cn)

                        comguardadetalles.Parameters.AddWithValue("@ID_FACTURA_DETALLE", SqlDbType.Int).Value = idFolio
                        comguardadetalles.Parameters.AddWithValue("@CANTIDAD", Convert.ToDecimal(row.Cells("Cantidad").Value))
                        'comguardadetalles.Parameters.AddWithValue("@UNIDAD", row.Cells("Unidad").Value)
                        comguardadetalles.Parameters.AddWithValue("@NOIDENTIFICACION", row.Cells("noIdentificacion").Value)
                        comguardadetalles.Parameters.AddWithValue("@DESCRIPCION", row.Cells("Descripcion").Value)
                        comguardadetalles.Parameters.AddWithValue("@VALOR_UNITARIO", Convert.ToDecimal(row.Cells("ValorUnitario").Value))
                        comguardadetalles.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(row.Cells("Importe").Value))

                        comguardadetalles.ExecuteNonQuery()
                    Next

                End If
                'Código para guardar en la tabla TBL_FACTURAS_ESTATUS
                Dim guardaestatus As String = "INSERT INTO TBL_FACTURAS_ESTATUS (FACTURA_ID, ESTATUS_ID, FECHA_AUDITORIA) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA_AUDITORIA)"
                Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

                comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", SqlDbType.Int).Value = idFolio
                comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", Convert.ToInt16(cbEstatus.SelectedValue))
                comguardaestatus.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                comguardaestatus.ExecuteNonQuery()


                MessageBox.Show("Los datos se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)




                'ACTUALIZA EL SALDO DE LA CUENTA SELECCIONADA
                'Dim actualizasaldo As String = "UPDATE CAT_CUENTAS set SALDO_ACTUAL = SALDO_ACTUAL - '" & Convert.ToDecimal(tbTotalFacturas.Text) & "' Where (ID_CUENTA = @total)"
                'Dim comactualizasaldo As New SqlCommand(actualizasaldo, cn)
                'comactualizasaldo.Parameters.AddWithValue("@total", cbcuenta.SelectedValue)
                'comactualizasaldo.ExecuteNonQuery()

                'ACTUALIZA NUEVAMENTE SALDOS
                'muestrasaldoactualizado()

                'tbFoliofactura.Clear()
                tbSubtotal.Clear()
                tbIva.Clear()
                tbRetencion.Clear()
                tbTotal.Clear()
                'tbObservaciones.Clear()

                tbSubtotal.Text = "0.00"
                tbIva.Text = "0.00"
                tbRetencion.Text = "0.00"
                tbTotal.Text = "0.00"


                'chbFirmado.Checked = False
                'chBSoporte.Checked = False
                'chbServicio.Checked = False
                'chbOrden.Checked = False
                'chbVale.Checked = False
                'chbCotiza.Checked = False
                'chbPedido.Checked = False
                'dgvfacturas.Rows.Clear()
                'tbTotalFacturas.Clear()

                cn.Close()
                BtGuardar.Enabled = False
                BtAgregar.Enabled = True
                cbPartida.Enabled = True

            Else MessageBox.Show("La factura ya ha sido cargada anteriormente, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BtGuardar.Enabled = False
                BtAgregar.Focus()
            End If
            'Else



            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click

        Try
            If tbFoliofactura.TextLength = 0 Or cbPartida.SelectedIndex < 0 Or cbEjercicio.SelectedIndex < 0 Or cbRubro.SelectedIndex < 0 Or cbCuentas.SelectedIndex < 0 Then
                MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                BtGuardar.Enabled = False
            ElseIf dtpFecharecepcion.Value < dtpFechafactura.Value Then
                MessageBox.Show("La fecha de recepción debe ser mayor a la fecha de la factura, ingrese una fecha correcta", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                BtGuardar.Enabled = False
            ElseIf dgvDetalles.RowCount = 0 Then
                MessageBox.Show("No existen conceptos para esta factura, favor de agregar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                BtGuardar.Enabled = False

                'ElseIf dgvDetalles.SelectedRows(0).Cells("cantidad").Value = "" Or dgvDetalles.SelectedRows(0).Cells("noIdentificacion").Value = "" Or dgvDetalles.SelectedRows(0).Cells("descripcion").Value = "" Or dgvDetalles.SelectedRows(0).Cells("valorUnitario").Value = "" Or dgvDetalles.SelectedRows(0).Cells("importe").Value = "" Then
                'MessageBox.Show("Existen conceptos con campos vacíos, favor de verificar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'BtGuardar.Enabled = False

            ElseIf dgvDetalles.Columns.Contains("cantidad") And dgvDetalles.Columns.Contains("noIdentificacion") And dgvDetalles.Columns.Contains("descripcion") And dgvDetalles.Columns.Contains("valorUnitario") And dgvDetalles.Columns.Contains("importe") Then
                MessageBox.Show("Campos validados correctamente", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtGuardar.Enabled = True
                If tbIva.Text = "" Then
                    tbIva.Text = "0.00"
                End If
                If tbRetencion.Text = "" Then
                    tbRetencion.Text = "0.00"
                End If

            Else
                MessageBox.Show("La factura no contiene todos los campos requeridos", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                BtGuardar.Enabled = False

            End If

            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()

                Dim consulta As String = ("SELECT IMPORTE_POA FROM TBL_RECURSOS_POA_SALDOS LEFT JOIN TBL_RECURSOS_POA ON TBL_RECURSOS_POA_SALDOS.RECURSO_ID = TBL_RECURSOS_POA.ID WHERE PARTIDA_ID = '" & cbPartida.SelectedValue & "'AND EJERCICIO = '" & cbEjercicio.SelectedValue & "'AND UNIDAD_ID = '" & cbUnidad.SelectedValue & "'")
                Dim cmd As New SqlCommand(consulta, cn)

                Dim leeimporte As SqlDataReader

                leeimporte = cmd.ExecuteReader()

                If leeimporte.Read() Then
                    If leeimporte("IMPORTE_POA") < tbTotal.Text Then
                        MessageBox.Show("NO TIENES SALDO PRESUPUESTAL", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cn.Close()
                    End If

                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Sub EstiloGrid()
        Try

            Dim ColumnaFactura As New DataGridViewColumn
            ColumnaFactura = New DataGridViewTextBoxColumn

            Dim ColumnaNombre As New DataGridViewColumn
            ColumnaNombre = New DataGridViewTextBoxColumn

            Dim ColumnaSubtotal As New DataGridViewColumn
            ColumnaSubtotal = New DataGridViewTextBoxColumn

            Dim ColumnaIva As New DataGridViewColumn
            ColumnaIva = New DataGridViewTextBoxColumn

            Dim ColumnaRetencion As New DataGridViewColumn
            ColumnaRetencion = New DataGridViewTextBoxColumn

            Dim ColumnaTotal As New DataGridViewColumn
            ColumnaTotal = New DataGridViewTextBoxColumn

            Dim ColumnaFechaf As New DataGridViewColumn
            ColumnaFechaf = New DataGridViewTextBoxColumn

            Dim Columnafechar As New DataGridViewColumn
            Columnafechar = New DataGridViewTextBoxColumn

            Dim ColumnaEstatus As New DataGridViewColumn
            ColumnaEstatus = New DataGridViewTextBoxColumn

            Dim ColumnaPartida As New DataGridViewColumn
            ColumnaPartida = New DataGridViewTextBoxColumn

            Dim ColumnaDescPartida As New DataGridViewColumn
            ColumnaDescPartida = New DataGridViewTextBoxColumn

            Dim ColumnaUnidad As New DataGridViewColumn
            ColumnaUnidad = New DataGridViewTextBoxColumn

            Dim ColumnaDescUnidad As New DataGridViewColumn
            ColumnaDescUnidad = New DataGridViewTextBoxColumn

            Dim ColumnaIdCuenta As New DataGridViewColumn
            ColumnaIdCuenta = New DataGridViewTextBoxColumn

            Dim ColumnaDescCuenta As New DataGridViewColumn
            ColumnaDescCuenta = New DataGridViewTextBoxColumn

            Dim ColumnaFirma As New DataGridViewColumn
            ColumnaFirma = New DataGridViewTextBoxColumn

            Dim ColumnaSoporte As New DataGridViewColumn
            ColumnaSoporte = New DataGridViewTextBoxColumn

            Dim ColumnaOrdenServicio As New DataGridViewColumn
            ColumnaOrdenServicio = New DataGridViewTextBoxColumn

            Dim ColumnaFacturaOriginal As New DataGridViewColumn
            ColumnaFacturaOriginal = New DataGridViewTextBoxColumn

            Dim ColumnaOrdenCompra As New DataGridViewColumn
            ColumnaOrdenCompra = New DataGridViewTextBoxColumn

            Dim ColumnaValeSalida As New DataGridViewColumn
            ColumnaValeSalida = New DataGridViewTextBoxColumn

            Dim ColumnaCotizaciones As New DataGridViewColumn
            ColumnaCotizaciones = New DataGridViewTextBoxColumn

            ColumnaFactura.HeaderText = "FACTURA"
            ColumnaFactura.Name = "FACTURA"
            ColumnaFactura.DataPropertyName = "FACTURA"
            ColumnaFactura.Width = 100

            ColumnaNombre.HeaderText = "NOMBRE PROVEEDOR"
            ColumnaNombre.Name = "NOMBRE"
            ColumnaNombre.DataPropertyName = "ID_PROVEEDOR"
            ColumnaNombre.Width = 200

            ColumnaSubtotal.HeaderText = "SUBTOTAL"
            ColumnaSubtotal.Name = "SUBTOTAL"
            ColumnaSubtotal.DataPropertyName = "SUBTOTAL"
            ColumnaSubtotal.Width = 100

            ColumnaIva.HeaderText = "IVA"
            ColumnaIva.Name = "IVA"
            ColumnaIva.DataPropertyName = "IVA"
            ColumnaIva.Width = 100

            ColumnaRetencion.HeaderText = "RETENCION"
            ColumnaRetencion.Name = "RETENCION"
            ColumnaRetencion.DataPropertyName = "RETENCION"
            ColumnaRetencion.Width = 100

            ColumnaTotal.HeaderText = "TOTAL"
            ColumnaTotal.Name = "TOTAL"
            ColumnaTotal.DataPropertyName = "TOTAL"
            ColumnaTotal.Width = 100


            ColumnaFechaf.HeaderText = "FECHA_FACTURA"
            ColumnaFechaf.Name = "FECHA_FACTURA"
            ColumnaFechaf.DataPropertyName = "FECHA_FACTURA"
            ColumnaFechaf.Width = 200
            ColumnaFechaf.Visible = False

            Columnafechar.HeaderText = "FECHA_RECEPCION"
            Columnafechar.Name = "FECHA_RECEPCION"
            Columnafechar.DataPropertyName = "FECHA_RECEPCION"
            Columnafechar.Width = 200
            Columnafechar.Visible = False

            ColumnaEstatus.HeaderText = "ESTATUS"
            ColumnaEstatus.Name = "ESTATUS"
            ColumnaEstatus.DataPropertyName = "ESTATUS"
            ColumnaEstatus.Width = 150

            ColumnaPartida.HeaderText = "CLAVE PARTIDA"
            ColumnaPartida.Name = "CLAVE_PARTIDA"
            ColumnaPartida.DataPropertyName = "CLAVE_PARTIDA"
            ColumnaPartida.Width = 200
            ColumnaPartida.Visible = False

            ColumnaDescPartida.HeaderText = "DESCRIPCION PARTIDA"
            ColumnaDescPartida.Name = "DESC_PARTIDA"
            ColumnaDescPartida.DataPropertyName = "DESCRIPCION"
            ColumnaDescPartida.Width = 300

            ColumnaUnidad.HeaderText = "UNIDAD"
            ColumnaUnidad.Name = "UNIDAD"
            ColumnaUnidad.DataPropertyName = "CLAVE_UNIDAD"
            ColumnaUnidad.Width = 100
            ColumnaUnidad.Visible = False

            ColumnaDescUnidad.HeaderText = "DESCRIPCION UNIDAD"
            ColumnaDescUnidad.Name = "DESC_UNIDAD"
            ColumnaDescUnidad.DataPropertyName = "DESCRIPCION_UNIDAD"
            ColumnaDescUnidad.Width = 300

            ColumnaIdCuenta.HeaderText = "CUENTA"
            ColumnaIdCuenta.Name = "CUENTA"
            ColumnaIdCuenta.DataPropertyName = "ID_CUENTA"
            ColumnaIdCuenta.Width = 200
            ColumnaIdCuenta.Visible = False

            ColumnaDescCuenta.HeaderText = "DESCRIPCION_CUENTA"
            ColumnaDescCuenta.Name = "DESC_CUENTA"
            ColumnaDescCuenta.DataPropertyName = "DESCRIPCION_CUENTA"
            ColumnaDescCuenta.Width = 200

            ColumnaFirma.HeaderText = "FIRMAS"
            ColumnaFirma.Name = "FIRMA"
            ColumnaFirma.DataPropertyName = "FIRMA"
            ColumnaFirma.Width = 200
            ColumnaFirma.Visible = False

            ColumnaSoporte.HeaderText = "SOPORTES"
            ColumnaSoporte.Name = "SOPORTE"
            ColumnaSoporte.DataPropertyName = "SOPORTE"
            ColumnaSoporte.Width = 200
            ColumnaSoporte.Visible = False

            ColumnaOrdenServicio.HeaderText = "ORDEN DE SERVICIO"
            ColumnaOrdenServicio.Name = "ORDEN_SERVICIO"
            ColumnaOrdenServicio.DataPropertyName = "ORDEN_SERVICIO"
            ColumnaOrdenServicio.Width = 200
            ColumnaOrdenServicio.Visible = False

            ColumnaOrdenCompra.HeaderText = "ORDEN DE COMPRA"
            ColumnaOrdenCompra.Name = "ORDEN_COMPRA"
            ColumnaOrdenCompra.DataPropertyName = "ORDEN_COMPRA"
            ColumnaOrdenCompra.Width = 200
            ColumnaOrdenCompra.Visible = False

            ColumnaValeSalida.HeaderText = "VALE DE SALIDA"
            ColumnaValeSalida.Name = "VALE_SALIDA"
            ColumnaValeSalida.DataPropertyName = "VALE_SALIDA"
            ColumnaValeSalida.Width = 200
            ColumnaValeSalida.Visible = False

            ColumnaCotizaciones.HeaderText = "COTIZACIONES"
            ColumnaCotizaciones.Name = "COTIZACIONES"
            ColumnaCotizaciones.DataPropertyName = "COTIZACIONES"
            ColumnaCotizaciones.Width = 200
            ColumnaCotizaciones.Visible = False

            ColumnaFacturaOriginal.HeaderText = "FACTURA ORIGINAL"
            ColumnaFacturaOriginal.Name = "FACTURA_ORIGINAL"
            ColumnaFacturaOriginal.DataPropertyName = "FACTURA_ORIGINAL"
            ColumnaFacturaOriginal.Width = 200
            ColumnaFacturaOriginal.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub llenagriddetalles()

        Dim Columnacantidad As New DataGridViewColumn
        Columnacantidad = New DataGridViewTextBoxColumn

        Dim Columnaunidad As New DataGridViewColumn
        Columnaunidad = New DataGridViewTextBoxColumn

        Dim Columnaidentificacion As New DataGridViewColumn
        Columnaidentificacion = New DataGridViewTextBoxColumn

        Dim Columnadescripcion As New DataGridViewColumn
        Columnadescripcion = New DataGridViewTextBoxColumn

        Dim Columnavalorunitario As New DataGridViewColumn
        Columnavalorunitario = New DataGridViewTextBoxColumn

        Dim Columnaimporte As New DataGridViewColumn
        Columnaimporte = New DataGridViewTextBoxColumn

        Me.dgvDetalles.Columns.Add(Columnacantidad)
        Me.dgvDetalles.Columns.Add(Columnaunidad)
        Me.dgvDetalles.Columns.Add(Columnaidentificacion)
        Me.dgvDetalles.Columns.Add(Columnadescripcion)
        Me.dgvDetalles.Columns.Add(Columnavalorunitario)
        Me.dgvDetalles.Columns.Add(Columnaimporte)

        Columnacantidad.HeaderText = "cantidad"
        Columnacantidad.Name = "cantidad"
        Columnacantidad.DataPropertyName = "CANTIDAD"
        Columnacantidad.Width = 100

        Columnaunidad.HeaderText = "unidad"
        Columnaunidad.Name = "unidad"
        Columnaunidad.DataPropertyName = "UNIDAD"
        Columnaunidad.Width = 100

        Columnaidentificacion.HeaderText = "noidentificacion"
        Columnaidentificacion.Name = "noidentificacion"
        Columnaidentificacion.DataPropertyName = "NOIDENTIFICACION"
        Columnaidentificacion.Width = 100

        Columnadescripcion.HeaderText = "descripcion"
        Columnadescripcion.Name = "descripcion"
        Columnadescripcion.DataPropertyName = "DESCRIPCION"
        Columnadescripcion.Width = 210

        Columnavalorunitario.HeaderText = "valorUnitario"
        Columnavalorunitario.Name = "valorUnitario"
        Columnavalorunitario.DataPropertyName = "VALOR_UNITARIO"
        Columnavalorunitario.Width = 100

        Columnaimporte.HeaderText = "importe"
        Columnaimporte.Name = "importe"
        Columnaimporte.DataPropertyName = "IMPORTE"
        Columnaimporte.Width = 100

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSubtotal.KeyPress
        'validacampos.numerosdecimal(tbSubtotal, e)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows.
        '
        Dim separadorDecimal As String =
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal,
            ' deshechamos insertar otro separador más.
            '
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return
            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse
                ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If
                ' Insertamos el separador decimal.
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If
        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso
            Return
        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito.
            e.Handled = True
            Return
        End If
        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de tres números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)
        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If
        ' Si el texto del control actualmente está seleccionado,
        ' Permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIva.KeyPress
        'validacampos.numerosdecimal(tbIva, e)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows.
        '
        Dim separadorDecimal As String =
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal,
            ' deshechamos insertar otro separador más.
            '
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return
            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse
                ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If
                ' Insertamos el separador decimal.
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If
        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso
            Return
        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito.
            e.Handled = True
            Return
        End If
        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de tres números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)
        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If
        ' Si el texto del control actualmente está seleccionado,
        ' Permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRetencion.KeyPress
        'validacampos.numerosdecimal(tbRetencion, e)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows.
        '
        Dim separadorDecimal As String =
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal,
            ' deshechamos insertar otro separador más.
            '
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return
            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse
                ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If
                ' Insertamos el separador decimal.
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If
        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso
            Return
        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito.
            e.Handled = True
            Return
        End If
        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de tres números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)
        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If
        ' Si el texto del control actualmente está seleccionado,
        ' Permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTotal.KeyPress
        'validacampos.numerosdecimal(tbTotal, e)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows.
        '
        Dim separadorDecimal As String =
        Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal,
            ' deshechamos insertar otro separador más.
            '
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return
            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse
                ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If
                ' Insertamos el separador decimal.
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If
        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso
            Return
        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito.
            e.Handled = True
            Return
        End If
        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de tres números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)
        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If
        ' Si el texto del control actualmente está seleccionado,
        ' Permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbFoliofactura.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            e.Handled = True
            'TextBox2.Focus()
        End If
    End Sub

    Sub Sumafacturas()
        'Dim Total As Decimal
        'Dim Columna As Integer = 5

        'For Each row As DataGridViewRow In Me.dgvfacturas.Rows
        'Total += Val(row.Cells(Columna).Value)

        'Next
        'tbTotalFacturas.Text = Format(Total, "#,##0.00")
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ALTA_PROVEEDORES.ShowDialog()
    End Sub

    Private Sub tbTotal_Enter(sender As Object, e As EventArgs) Handles tbTotal.Enter

        Dim total As Decimal

        total = Convert.ToDecimal(tbSubtotal.Text) + Convert.ToDecimal(tbIva.Text) - Convert.ToDecimal(tbRetencion.Text)
        tbTotal.Text = Format(total, "0.00")

    End Sub

    Private Sub tbIva_Leave(sender As Object, e As EventArgs) Handles tbIva.Leave
        If tbIva.Text = "" Then
            tbIva.Text = Format("0.00")
        End If
    End Sub

    Private Sub tbSubtotal_Leave(sender As Object, e As EventArgs) Handles tbSubtotal.Leave

    End Sub

    Private Sub tbRetencion_Leave(sender As Object, e As EventArgs) Handles tbRetencion.Leave
        If tbRetencion.Text = "" Then
            tbRetencion.Text = Format("0.00")
        End If
    End Sub

    Private Sub cbProveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProveedores.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub DateTimePicker2_Leave(sender As Object, e As EventArgs) Handles dtpFecharecepcion.Leave
        If dtpFecharecepcion.Value < dtpFechafactura.Value Then
            MessageBox.Show("La fecha de recepción debe ser mayor o igual a la fecha de la factura, ingrese una fecha correcta", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
        End If
    End Sub

    Private Sub cbProveedores_Leave(sender As Object, e As EventArgs) Handles cbProveedores.Leave
        If cbProveedores.Text = "" Or cbProveedores.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar un proveedor", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

        End If

    End Sub

    Private Sub TextBox9_Enter(sender As Object, e As EventArgs) Handles tbObservaciones.Enter
        'validacampos.validaenterfoco(TextBox9)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        'Buscar_SACG.Show()
    End Sub

    'Combobox para determinar el tipo de adquisición

    'Private Sub ComboBox5_Leave(sender As Object, e As EventArgs) Handles ComboBox5.Leave
    'If ComboBox5.Text = "ADJUDICACIÓN DIRECTA" Then
    'ComboBox6.Text = ""
    'ComboBox6.Enabled = False
    'ComboBox1.Focus()
    'ElseIf ComboBox5.Text = "INVITACIÓN RESTRINGIDA" Then
    'ComboBox6.Text = ""
    'ComboBox6.Enabled = False
    'ComboBox1.Focus()
    'ElseIf ComboBox5.Text = "LICITACIÓN PÚBLICA" Then
    'ComboBox6.Enabled = True
    'ComboBox6.Focus()
    'End If
    ' End Sub

    Private Sub tbIva_Enter(sender As Object, e As EventArgs) Handles tbIva.Enter
        'Dim total As Decimal

        'If tbSubtotal.Text = "" Then
        'tbSubtotal.Text = Format("0.00")
        'total = Convert.ToDecimal(tbSubtotal.Text) * 0.16
        'tbIva.Text = Format(total, "0.00")

        'ElseIf cbPartida.Text.Substring(0, 5) <> "25301" Then
        'tbIva.Clear()
        'total = Convert.ToDecimal(tbSubtotal.Text) * 0.16
        'tbIva.Text = Format(total, "0.00")
        'End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
        PRINCIPAL.Show()
    End Sub


    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

        btCapturaconceptos.Enabled = False
        btAgregarconceptos.Enabled = False

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            tbRutaarchivo.Text = OpenFileDialog1.FileName
        End If

        Dim myXMLfile As String = tbRutaarchivo.Text
        Dim ds2 As New DataSet()

        'Se llena el Datagridview

        ds2.ReadXml(myXMLfile)
        dgvDetalles.DataSource = ds2
        dgvDetalles.DataMember = "Concepto"
        dgvDetalles.Columns(0).Width = 100
        dgvDetalles.Columns(1).Width = 100
        dgvDetalles.Columns(2).Width = 290

        'If dgvDetalles.RowCount > 0 Then
        'BtGuardar.Enabled = True
        'Else
        'BtGuardar.Enabled = False
        'End If

        'Se captura el folio fiscal

        Dim xDoc As New XmlDocument()
        xDoc.Load(tbRutaarchivo.Text)
        Dim Comprobante As XmlNodeList = xDoc.GetElementsByTagName("cfdi:Complemento")
        Dim lista As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("tfd:TimbreFiscalDigital")
        For Each nodo As XmlElement In lista
            Dim nfolio As String = nodo.GetAttribute("UUID")
            If nfolio <> "" Then
                tbFoliofiscal.Text = nfolio
            Else
                Dim folio As String = nodo.GetAttribute("UUID")
                tbFoliofiscal.Text = folio
            End If

        Next

        'Se captura el folio de la factura

        Dim xDoc2 As New XmlDocument()
        xDoc2.Load(tbRutaarchivo.Text)
        Dim Comprobante2 As XmlNodeList = xDoc.GetElementsByTagName("cfdi:Comprobante")
        'Dim lista2 As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("tfd:TimbreFiscalDigital")
        For Each nodo As XmlElement In Comprobante2


            Dim nfolio As String = nodo.GetAttribute("folio")
            If nfolio <> "" Then
                tbFoliofactura.Text = nfolio
            Else
                Dim folio As String = nodo.GetAttribute("Folio")
                tbFoliofactura.Text = folio
            End If


            Dim nfolio2 As String = nodo.GetAttribute("subTotal")
            If nfolio2 <> "" Then
                tbSubtotal.Text = nfolio2
            Else
                Dim folio2 As String = nodo.GetAttribute("SubTotal")
                tbSubtotal.Text = folio2
            End If


            Dim nfolio3 As String = nodo.GetAttribute("total")
            If nfolio3 <> "" Then
                tbTotal.Text = nfolio3
            Else
                Dim folio3 As String = nodo.GetAttribute("Total")
                tbTotal.Text = folio3
            End If

        Next

        'Se capturan los impuestos

        Dim xDoc4 As New XmlDocument()
        xDoc4.Load(tbRutaarchivo.Text)
        Dim Comprobante4 As XmlNodeList = xDoc.GetElementsByTagName("cfdi:Impuestos")

        For Each nodo As XmlElement In Comprobante4
            Dim nfolio As String = nodo.GetAttribute("totalImpuestosTrasladados")
            If nfolio <> "" Then
                tbIva.Text = nfolio
            Else
                Dim folio As String = nodo.GetAttribute("TotalImpuestosTrasladados")
                tbIva.Text = folio
            End If

            'If tbIva.Text = "" Then
            'tbIva.Text = Format("0.00")
            'End If

        Next

        'Importe con letras




    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Buscar_SACG.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Partidas.ShowDialog()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Partidas.ShowDialog()
    End Sub


    Private Sub ToolStripButton5_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ALTA_PROVEEDORES.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        ALTA_LICITACIONES.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ALTA_UNIDADES.ShowDialog()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        If dgvDetalles.Columns.Contains("cantidad") And dgvDetalles.Columns.Contains("unidad") And dgvDetalles.Columns.Contains("noIdentificacion") And dgvDetalles.Columns.Contains("descripcion") And dgvDetalles.Columns.Contains("valorUnitario") And dgvDetalles.Columns.Contains("importe") Then
            MessageBox.Show("Campos validados correctamente", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("La factura no contiene todos los campos requeridos", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btCapturaconceptos.Click

        dgvDetalles.Columns.Clear()
        dgvDetalles.DataSource = Nothing
        dgvDetalles.Rows.Clear()
        llenagriddetalles()
        btAgregarconceptos.Enabled = True
        lbIdentificador.Visible = True

    End Sub

    Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles btAgregarconceptos.Click
        dgvDetalles.Rows.Add()
        dgvDetalles.ReadOnly = False
        dgvDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        'dgvDetalles.EditMode.EditOnEnter
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles btXml.Click
        'btCapturaconceptos.Enabled = False
        btAgregarconceptos.Enabled = False
        dgvDetalles.ReadOnly = True

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'dgvDetalles.Columns.Clear()

            'dgvDetalles.Rows.Clear()

            tbRutaarchivo.Text = OpenFileDialog1.FileName




            Dim myXMLfile As String = tbRutaarchivo.Text
                Dim ds2 As New DataSet()

                'Se llena el Datagridview



                ds2.ReadXml(myXMLfile)
                dgvDetalles.DataSource = ds2
                dgvDetalles.DataMember = "Concepto"
                dgvDetalles.Columns(0).Width = 100
                dgvDetalles.Columns(1).Width = 100
                dgvDetalles.Columns(2).Width = 290


                'Iniciar la consulta que determina el sobreprecio o fuera de CAUSES





                'Se captura el folio fiscal

                Dim xDoc As New XmlDocument()
                xDoc.Load(tbRutaarchivo.Text)
                Dim Comprobante As XmlNodeList = xDoc.GetElementsByTagName("cfdi:Complemento")
                Dim lista As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("tfd:TimbreFiscalDigital")
                For Each nodo As XmlElement In lista
                    Dim nfolio As String = nodo.GetAttribute("UUID")
                    If nfolio <> "" Then
                        tbFoliofiscal.Text = nfolio
                    Else
                        Dim folio As String = nodo.GetAttribute("UUID")
                        tbFoliofiscal.Text = folio
                    End If

                Next

                'Se captura el folio de la factura

                Dim xDoc2 As New XmlDocument()
                xDoc2.Load(tbRutaarchivo.Text)
                Dim Comprobante2 As XmlNodeList = xDoc.GetElementsByTagName("cfdi:Comprobante")
                'Dim lista2 As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("tfd:TimbreFiscalDigital")
                For Each nodo As XmlElement In Comprobante2


                    Dim nfolio As String = nodo.GetAttribute("folio")
                    If nfolio <> "" Then
                        tbFoliofactura.Text = nfolio
                    Else
                        Dim folio As String = nodo.GetAttribute("Folio")
                        tbFoliofactura.Text = folio
                    End If


                    Dim nfolio2 As String = nodo.GetAttribute("subTotal")
                    If nfolio2 <> "" Then
                        tbSubtotal.Text = nfolio2
                    Else
                        Dim folio2 As String = nodo.GetAttribute("SubTotal")
                        tbSubtotal.Text = folio2
                    End If


                    Dim nfolio3 As String = nodo.GetAttribute("total")
                    If nfolio3 <> "" Then
                        tbTotal.Text = nfolio3
                    Else
                        Dim folio3 As String = nodo.GetAttribute("Total")
                        tbTotal.Text = folio3
                    End If

                    Dim nfolio4 As String = nodo.GetAttribute("fecha")
                    If nfolio4 <> "" Then
                        dtpFechafactura.Text = nfolio4
                    Else
                        Dim folio4 As String = nodo.GetAttribute("Fecha")
                        dtpFechafactura.Text = folio4

                    End If

                Next

                'Se capturan los impuestos

                Dim xDoc4 As New XmlDocument()
                xDoc4.Load(tbRutaarchivo.Text)
                Dim Comprobante4 As XmlNodeList = xDoc.GetElementsByTagName("cfdi:Impuestos")
            'Dim lista4 As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("cfdi:Traslado")
            'Dim lista5 As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("cfdi:Traslado")
            For Each nodo As XmlElement In Comprobante4
                Dim nfolio As String = nodo.GetAttribute("totalImpuestosTrasladados")
                If nfolio <> "" Then
                    tbIva.Text = nfolio
                Else
                    Dim folio As String = nodo.GetAttribute("TotalImpuestosTrasladados")
                    tbIva.Text = folio
                End If

                Dim nfolio2 As String = nodo.GetAttribute("TotalImpuestosRetenidos")
                If nfolio2 <> "" Then
                    tbRetencion.Text = nfolio2
                Else
                    Dim folio2 As String = nodo.GetAttribute("totalImpuestosRetenidos")
                    tbRetencion.Text = folio2
                End If

                'If tbIva.Text = "" Then
                'tbIva.Text = Format("0.00")
                'End If

            Next


            'Se capturan el subsidio al empleo

            'Dim xDoc5 As New XmlDocument()
            'xDoc5.Load(tbRutaarchivo.Text)
            'Dim Comprobante5 As XmlNodeList = xDoc.GetElementsByTagName("nomina12:OtroPago")
            'Dim lista4 As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("cfdi:Traslado")
            'Dim lista5 As XmlNodeList = (CType(Comprobante(0), XmlElement)).GetElementsByTagName("cfdi:Traslado")
            'For Each nodo As XmlElement In Comprobante5
            'Dim nfolio As String = nodo.GetAttribute("Importe")
            'If nfolio <> "" Then
            'tbSubsidioempleo.Text = nfolio
            'Else
            'Dim folio As String = nodo.GetAttribute("importe")
            'tbSubsidioempleo.Text = folio
            'End If

            'Next

            'Importe con letras
        End If



    End Sub


    Private Sub cbPartida_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPartida.SelectionChangeCommitted
        If cbPartida.SelectedValue >= 47 And cbPartida.SelectedValue <= 103 Then
            chbOrden.Enabled = False
            chbPedido.Enabled = False
            chbVale.Enabled = False
            chbCotiza.Enabled = False
            btXml.Enabled = True
            btCapturaconceptos.Enabled = True
            btAgregarconceptos.Enabled = True
            btMedicamentos.Enabled = False
            BtAgregar.Enabled = True
            cbCAUSES.Enabled = False
            cbpreciosref.Enabled = False
        ElseIf cbPartida.SelectedValue >= 30 And cbPartida.SelectedValue <= 46 Then
            chbOrden.Enabled = True
            chbPedido.Enabled = True
            chbVale.Enabled = True
            chbCotiza.Enabled = True
            btXml.Enabled = True
            btCapturaconceptos.Enabled = True
            btAgregarconceptos.Enabled = True
            btMedicamentos.Enabled = False
            BtAgregar.Enabled = True
            cbCAUSES.Enabled = False
            cbpreciosref.Enabled = False
        ElseIf cbPartida.SelectedValue >= 1 And cbPartida.SelectedValue <= 28 Then
            chbOrden.Enabled = True
            chbPedido.Enabled = True
            chbVale.Enabled = True
            chbCotiza.Enabled = True
            btXml.Enabled = True
            btCapturaconceptos.Enabled = True
            btAgregarconceptos.Enabled = True
            btMedicamentos.Enabled = False
            BtAgregar.Enabled = True
            cbCAUSES.Enabled = False
            cbpreciosref.Enabled = False
        ElseIf cbPartida.SelectedValue = 29 Then
            chbOrden.Enabled = True
            cbpreciosref.Enabled = True
            chbPedido.Enabled = True
            chbVale.Enabled = True
            chbCotiza.Enabled = True
            btXml.Enabled = True
            btCapturaconceptos.Enabled = False
            btAgregarconceptos.Enabled = False
            btMedicamentos.Enabled = True
            BtAgregar.Enabled = False
            cbCAUSES.Enabled = True
        ElseIf cbPartida.SelectedValue >= 104 Then
            chbOrden.Enabled = True
            chbPedido.Enabled = True
            chbVale.Enabled = True
            chbCotiza.Enabled = True
            btXml.Enabled = True
            btCapturaconceptos.Enabled = True
            btAgregarconceptos.Enabled = True
            btMedicamentos.Enabled = False
            BtAgregar.Enabled = True
            cbCAUSES.Enabled = False
            cbpreciosref.Enabled = False
        End If
    End Sub


    Private Sub Button2_Click_4(sender As Object, e As EventArgs) Handles btMedicamentos.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        cbPartida.Enabled = False


        'Código para validar medicamentos

        If dgvDetalles.RowCount = 0 Then
            MessageBox.Show("No existen datos para validar, favor de importar XML", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbPartida.Enabled = True
        Else
            'Vacia los datos de la tabla TBL_MEDICAMENTOS_VALIDAR, para poder ingresar los nuevos datos a validar.
            Dim eliminafactura As String = "DELETE TBL_MEDICAMENTOS_VALIDAR Where TBL_MEDICAMENTOS_VALIDAR.FOLIO_FISCAL = '" & tbFoliofiscal.Text & "'"
            Dim comeliminafactura As New SqlCommand(eliminafactura, cn)

            comeliminafactura.ExecuteNonQuery()

            'Variable para reiniciar el progressbar
            Dim Cuenta As Integer = 1
            'Verifica que los campos que se necesitan para validar medicamentos se hayan proporcionado.
            If tbFoliofactura.TextLength = 0 Or cbProveedores.SelectedIndex < 0 Or tbFoliofiscal.SelectedText = " " Or cbCAUSES.SelectedIndex < 0 Or cbpreciosref.SelectedIndex < 0 Then
                MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Try
                    'Guarda los datos en la tabla TBL_MEDICAMENTOS_VALIDAR, pero con anterioridad ya la tabla fue vaciada.
                    For Each row As DataGridViewRow In dgvDetalles.Rows

                        Dim guardamedicamentos As String = "INSERT INTO TBL_MEDICAMENTOS_VALIDAR (PROVEEDOR_ID, FOLIO_FISCAL, FOLIO_FACTURA, FECHA_VALIDACION,  CLAVE_MEDICAMENTO, PRECIO_UNITARIO, CANTIDAD, IMPORTE) VALUES (@ID_PROVEEDOR, @FOLIO_FISCAL, @FOLIO_FACTURA, @FECHA_VALIDACION, @CLAVE_MEDICAMENTO, @PRECIO_UNITARIO, @CANTIDAD, @IMPORTE)"
                        Dim comguardamedicamentos As New SqlCommand(guardamedicamentos, cn)

                        comguardamedicamentos.Parameters.AddWithValue("@ID_PROVEEDOR", cbProveedores.SelectedValue)
                        comguardamedicamentos.Parameters.AddWithValue("@FOLIO_FISCAL", tbFoliofiscal.Text)
                        comguardamedicamentos.Parameters.AddWithValue("@FOLIO_FACTURA", tbFoliofactura.Text)
                        comguardamedicamentos.Parameters.AddWithValue("@FECHA_VALIDACION", Date.Now)
                        comguardamedicamentos.Parameters.AddWithValue("@CLAVE_MEDICAMENTO", row.Cells("NoIdentificacion").Value)
                        comguardamedicamentos.Parameters.AddWithValue("@PRECIO_UNITARIO", row.Cells("ValorUnitario").Value)
                        comguardamedicamentos.Parameters.AddWithValue("@CANTIDAD", Convert.ToDecimal(row.Cells("Cantidad").Value))
                        comguardamedicamentos.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(row.Cells("Importe").Value))

                        comguardamedicamentos.ExecuteNonQuery()

                        ProgressBar1.Maximum = dgvDetalles.Rows.Count()
                        ProgressBar1.Value = Cuenta
                        Cuenta = Cuenta + 1

                    Next


                    ProgressBar1.Value = 0
                    dgvDetalles.Columns.Clear()
                    dgvDetalles.DataSource = Nothing
                    dgvDetalles.Rows.Clear()

                    If cbCAUSES.SelectedIndex >= 0 And cbpreciosref.SelectedIndex >= 0 Then

                        adaptador = New SqlDataAdapter("sp_medicamentos_validar @pFOLIO_FISCAL2 = '" & tbFoliofiscal.Text & "', @PRECIOS = 'CAT_PRECIOS_REFERENCIA_" & cbpreciosref.Text & "',@CAUSES = 'CAT_CAUSES_MEDICAMENTOS_" & cbCAUSES.Text & "'", cn)
                        dt = New DataTable
                        adaptador.Fill(dt)
                        dgvDetalles.DataSource = dt

                        dgvDetalles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvDetalles.Columns(3).HeaderText = "unitarioreferencia"
                        dgvDetalles.Columns(6).HeaderText = "referencia"
                        dgvDetalles.Columns(9).Width = 120


                        Dim totalsobreprecio As Decimal
                        Dim columnasobreprecio As Integer = 7
                        Dim totalcauses As Decimal
                        Dim columnacauses As Integer = 8
                        Dim totalpago As Decimal
                        Dim columnapago As Integer = 9

                        For Each row As DataGridViewRow In dgvDetalles.Rows
                            'Con esta condicion 
                            If row.Cells(7).Value > 0 Then
                                totalsobreprecio += Val(row.Cells(columnasobreprecio).Value)

                            End If

                            totalcauses += Val(row.Cells(columnacauses).Value)
                            totalpago += Val(row.Cells(columnapago).Value)

                        Next
                        'Muestra resultados de la validacion, por si esta fuera de causes, si tiene sobre precio y total a pago de los medicamentos.
                        tbSobreprecio.Text = Format(totalsobreprecio, "#,##0.00")
                        tbCauses.Text = Format(totalcauses, "#,##0.00")
                        tbTotalpago.Text = Format(totalpago, "#,##0.00")

                        'Muestra las columnas como resultado de la validación de los medicamentos
                        lbSobreprecio.Visible = True
                        lbCauses.Visible = True
                        lbTotalpago.Visible = True
                        tbSobreprecio.Visible = True
                        tbCauses.Visible = True
                        tbTotalpago.Visible = True
                        BtAgregar.Enabled = True
                        cn.Close()

                    End If
                    'Mensaje de que la validacion se ha realizado.
                    MessageBox.Show("Validación completa", "Validación de medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    'Mensaje en caso, de que surgiera un error al momento de la validación de medicamentos.
                    MessageBox.Show("Existe un problema de validación, favor de contactar al administrador no sin antes imprimir la pantalla del error")
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        End If
    End Sub




    Sub muestrasaldoactualizado()
        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim consulta As String = ("SELECT SALDO_ACTUAL FROM TBL_CUENTAS Where ID_CUENTA = @parametro")
        Dim cmd As New SqlCommand(consulta, cn)


        cmd.Parameters.AddWithValue("@parametro", cbcuenta.SelectedValue)

        'Actualiza el saldo de las cuentas

        'Dim reader As SqlDataReader = cmd.ExecuteReader()

        'If reader.Read() Then

        'tbSaldo.Text = Format(CType((reader("SALDO_ACTUAL")), Decimal), "$#,##0.00")

        'End If

        cn.Close()
    End Sub


End Class
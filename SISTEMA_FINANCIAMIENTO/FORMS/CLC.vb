Imports System.Data
Imports System.Data.SqlClient
Public Class CLC

    Public cn As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Dim funciones As New BUSQUEDAS_CLC
    Dim funciones2 As New BASEDATOS

    Private Sub CLC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbEjercicio.Focus()
        cbBuscar.Enabled = False
        tbBuscar.Enabled = False
        lbDuplicados.Visible = False
        'funciones.Llenardgvfacturas(dgvEnviopago)

    End Sub

    Private Sub tbFactura_Enter(sender As Object, e As EventArgs)
        'tbFiltrar.Text = ""
    End Sub

    Private Sub tbBuscar_Leave(sender As Object, e As EventArgs)
        'Me.tbFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.tbFiltrar.ForeColor = System.Drawing.SystemColors.ButtonShadow
        'Me.tbFiltrar.Text = "Teclee el nombre del proveedor para filtrar"
    End Sub

    Private Sub tbBuscar_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Me.tbFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.tbFiltrar.ForeColor = System.Drawing.SystemColors.WindowText
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        cbBuscar.Enabled = True
        tbBuscar.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        cbBuscar.Enabled = False
        tbBuscar.Enabled = False
    End Sub

    Private Sub cbFuente_Enter(sender As Object, e As EventArgs) Handles cbFuente.Enter
        funciones2.llenarcomboejercicio(cbFuente)
    End Sub

    Private Sub cbCuenta_Enter(sender As Object, e As EventArgs) Handles cbCuenta.Enter
        funciones2.LlenarComboCuentas(cbCuenta, cbFuente)
    End Sub

    Private Sub cbProveedores_Enter(sender As Object, e As EventArgs) Handles cbProveedores.Enter
        funciones2.Llenarcatproveedores(cbProveedores)
    End Sub

    Private Sub cbPartida_Enter(sender As Object, e As EventArgs) Handles cbPartida.Enter
        'funciones2.llenacombopartidas(cbPartida)
        'LE QUITE LA FUNCION DE ARRIBA YA QUE EN BASEDEDATOS TENEMOS UNA FUNCION QUE HACE EL MISMO LLENADO DE COMBOBOX
        funciones2.llenacombopartidasfiltro(cbPartida)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        cn.Close()
        Me.Close()

    End Sub

    Private Sub btContinuar_Click(sender As Object, e As EventArgs) Handles btContinuar.Click
        funciones.LlenardgvfacturasCLC(dgvEnviopago, cbEjercicio.SelectedValue, cbFuente.SelectedValue, cbCuenta.SelectedValue, cbProveedores.SelectedValue, cbPartida.SelectedValue)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        'Se actualiza el folio CLC actual según el ejercicio

        Dim actualizaconsecutivoclc As String = "UPDATE CAT_FOLIOS_CLC set FOLIO_ACTUAL = FOLIO_ACTUAL+1 Where CAT_FOLIOS_CLC.ID = '" & cbFoliosCLC.SelectedValue & "' AND CAT_FOLIOS_CLC.ID_CUENTA_ORIGEN  = '" & cbFuente.SelectedValue & "'"
        Dim comactualizaclc As New SqlCommand(actualizaconsecutivoclc, cn)
        comactualizaclc.ExecuteNonQuery()

        'Seleccionamos el folio CLC generado

        Dim folioclc As String = ("Select CAT_FOLIOS_CLC.FOLIO_ACTUAL from CAT_FOLIOS_CLC Where CAT_FOLIOS_CLC.ID = '" & cbFoliosCLC.SelectedValue & "' AND CAT_FOLIOS_CLC.ID_CUENTA_ORIGEN  = '" & cbFuente.SelectedValue & "'")

        Dim generaclc As New SqlCommand(folioclc, cn)

        generaclc.ExecuteNonQuery()

        'Leemos el folio CLC para mostrarlo en el textbox

        If tbCLC.Text = "" Then
            MessageBox.Show("VERIFICAR DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim reader As SqlDataReader = generaclc.ExecuteReader

            reader.Read()

            tbCLC.Text = reader("FOLIO_ACTUAL")

            reader.Close()

            'Recorremos el datagrid para insertar en la tabla CLC

            For Each row As DataGridViewRow In dgvCLC.Rows

                Dim consulta As String = "INSERT INTO FACTURAS_CLC (ID_FOLIOS, ID_CUENTA_ORIGEN, FOLIO_CLC, ID_FACTURA, IMPORTE_PAGADO, FECHA, FECHA_AUDITORIA)  VALUES (@ID_FOLIOS, @ID_CUENTA_ORIGEN, @FOLIO_CLC, @ID_FACTURA, @IMPORTE_PAGADO, @FECHA, @FECHA_AUDITORIA)"
                Dim comm As New SqlCommand(consulta, cn)

                comm.Parameters.AddWithValue("@ID_FOLIOS", cbFoliosCLC.SelectedValue)
                comm.Parameters.AddWithValue("@ID_CUENTA_ORIGEN", cbFuente.SelectedValue)
                comm.Parameters.AddWithValue("@FOLIO_CLC", Convert.ToInt32(tbCLC.Text))
                comm.Parameters.AddWithValue("@ID_FACTURA", row.Cells("ID_FACTURA").Value)
                comm.Parameters.AddWithValue("@IMPORTE_PAGADO", Convert.ToDecimal(row.Cells("IMPORTE").Value))
                comm.Parameters.AddWithValue("@FECHA", dtpFecha.Value)
                comm.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                comm.ExecuteNonQuery()

            Next

            MessageBox.Show("Los datos del CLC se han guardado correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cn.Close()

        End If


    End Sub

    Private Sub cbEjercicio_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones2.LlenarComboanioejercicio(cbEjercicio)
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        '///////////////////////////////////////////

        'Dim VALOR As String

        'VALOR = dgvEnviopago.SelectedRows

        'Dim existe As Boolean = dgvEnviopago.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("ID_FACTURA").Value) = VALOR)

        'If Not existe Then

        'For Each row As DataGridViewRow In dgvEnviopago.SelectedRows

        'dgvCLC.Rows.Add(row.Cells(0).Value, row.Cells(3).Value, row.Cells(5).Value)

        'Next



        'Else
        'MessageBox.Show("La partida ya ha sido agregada, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        'Dim Total As Decimal
        'Dim Columna As Integer = 2

        'For Each row As DataGridViewRow In dgvCLC.Rows
        'Total += Val(row.Cells(Columna).Value)

        'Next

        'lbImporte.Text = Format(Total, "#,##0.00")



        '//////////////////////////////////////////

        If dgvCLC.Columns.Contains("ID_FACTURA") And dgvCLC.Columns.Contains("FOLIO") And dgvCLC.Columns.Contains("IMPORTE") Then

        Else
            llenadgvCLC()
            dgvCLC.Columns("FOLIO").ReadOnly = True
            dgvCLC.Columns("IMPORTE").ReadOnly = False
            dgvCLC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        End If

        For Each row As DataGridViewRow In dgvEnviopago.SelectedRows

            dgvCLC.Rows.Add(row.Cells(0).Value, row.Cells(3).Value, row.Cells(5).Value)

        Next

        'Sumar el total de los registros agregados al CLC

        Dim Total As Decimal
        Dim Columna As Integer = 2

        For Each row As DataGridViewRow In dgvCLC.Rows
            Total += Val(row.Cells(Columna).Value)
        Next

        lbImporte.Text = Format(Total, "#,##0.00")


        'Validar si existen duplicados y modificar el color
        For Each grupo As IGrouping(Of Object, DataGridViewRow) In dgvCLC.Rows.Cast(Of DataGridViewRow)().GroupBy(Function(dr) dr.Cells("FOLIO").Value).Where(Function(g) g.Count() > 1)
            For Each fila As DataGridViewRow In grupo
                fila.DefaultCellStyle.ForeColor = Color.Red
            Next
        Next

        'Mostrar mensaje si existen registros duplicados

        For Each dgv As DataGridViewRow In dgvCLC.Rows
            If dgv.DefaultCellStyle.ForeColor = Color.Red Then
                lbDuplicados.Visible = True
                btGuardar.Enabled = False
            Else
                lbDuplicados.Visible = False
                btGuardar.Enabled = True
            End If
        Next




    End Sub

    Sub llenadgvCLC()

        Dim idfactura As New DataGridViewColumn
        idfactura = New DataGridViewTextBoxColumn

        Dim foliofactura As New DataGridViewColumn
        foliofactura = New DataGridViewTextBoxColumn

        Dim importe As New DataGridViewColumn
        importe = New DataGridViewTextBoxColumn

        Me.dgvCLC.Columns.Add(idfactura)
        Me.dgvCLC.Columns.Add(foliofactura)
        Me.dgvCLC.Columns.Add(importe)


        idfactura.HeaderText = "ID_FACTURA"
        idfactura.Name = "ID_FACTURA"
        idfactura.DataPropertyName = "ID_FACTURA"
        idfactura.Visible = False

        foliofactura.HeaderText = "FOLIO"
        foliofactura.Name = "FOLIO"
        foliofactura.DataPropertyName = "FOLIO"
        foliofactura.Width = 60

        importe.HeaderText = "IMPORTE"
        importe.Name = "IMPORTE"
        importe.DataPropertyName = "IMPORTE"
        importe.Width = 80
        dgvCLC.Columns("IMPORTE").DefaultCellStyle.Format = "n"




    End Sub

    Private Sub dgvCLC_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCLC.RowsRemoved

        'Modificar el color de todos los registros antes de validarlos
        For Each fila As DataGridViewRow In dgvCLC.Rows
            fila.DefaultCellStyle.ForeColor = Color.Black
        Next

        'Validar si existen duplicados y modificar el color
        For Each grupo As IGrouping(Of Object, DataGridViewRow) In dgvCLC.Rows.Cast(Of DataGridViewRow)().GroupBy(Function(dr) dr.Cells("FOLIO").Value).Where(Function(g) g.Count() > 1)

            For Each fila As DataGridViewRow In grupo
                fila.DefaultCellStyle.ForeColor = Color.Red
            Next

        Next

        'Mostrar mensaje si existen registros duplicados

        For Each dgv As DataGridViewRow In dgvCLC.Rows
            If dgv.DefaultCellStyle.ForeColor = Color.Red Then
                lbDuplicados.Visible = True
                btGuardar.Enabled = False
            Else
                lbDuplicados.Visible = False
                btGuardar.Enabled = True
            End If
        Next

        'Sumar el total de los registros agregados al CLC

        Dim Total As Decimal
        Dim Columna As Integer = 2

        For Each row As DataGridViewRow In dgvCLC.Rows
            Total += Val(row.Cells(Columna).Value)
        Next

        lbImporte.Text = Format(Total, "#,##0.00")

    End Sub

    Private Sub cbFoliosCLC_Enter(sender As Object, e As EventArgs) Handles cbFoliosCLC.Enter
        funciones.Llenarcomboaniofolios(cbFoliosCLC)
    End Sub

    Private Sub dgvCLC_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCLC.CellValueChanged


        'dgvCLC.Columns("IMPORTE").DefaultCellStyle.Format = "n"
        'Convert.ToInt32(dgvCLC.Columns("IMPORTE"))

        Dim Total As Decimal
        Dim Columna As Integer = 2

        For Each row As DataGridViewRow In dgvCLC.Rows
            'Total += Val(Convert.ToInt32(row.Cells(Columna).Value))
            Total += Val(row.Cells(Columna).Value)
        Next

        lbImporte.Text = Format(Total, "#,##0.00")

    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Dim id_clc = CInt(tbCLC.Text)
        'Dim form_clc As New REPORTE_CLC

        'form_clc.report_clc = CInt(id_clc)
        'form_clc.ShowDialog()
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

    End Sub
End Class
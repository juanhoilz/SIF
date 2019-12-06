Imports System.Data
Imports System.Data.SqlClient
Imports OutlookStyleControls
Public Class ACTUALIZAR_ESTATUS
    Dim funciones As New BASEDATOS
    Public cn As New SqlConnection

    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbFactura.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btBuscar.Click


        If dtpInicio.Value > dtpFin.Value Then
            MessageBox.Show("La fecha de inicio debe ser menor o igual que el límite", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If cbFiltro.Text = "" Then
                MessageBox.Show("Favor de seleccionar alguno de los filtros", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf cbFiltro.SelectedIndex = 0 And cbEstatusfiltro.SelectedIndex < 0 Then
                funciones.ConsultaDinamicaNombre(tbFactura.Text, dgvConsulta)
            ElseIf cbFiltro.SelectedIndex = 0 And cbEstatusfiltro.SelectedIndex >= 0 Then
                funciones.ConsultaDinamicaNombrefiltro(tbFactura.Text, dgvConsulta, cbEstatusfiltro.SelectedValue)
            ElseIf cbFiltro.SelectedIndex = 1 And cbEstatusfiltro.SelectedIndex < 0 Then
                funciones.ConsultaDinamicaRFC(tbFactura.Text, dgvConsulta)
            ElseIf cbFiltro.SelectedIndex = 1 And cbEstatusfiltro.SelectedIndex >= 0 Then
                funciones.ConsultaDinamicaRFCfiltro(tbFactura.Text, dgvConsulta, cbEstatusfiltro.SelectedValue)
            ElseIf cbFiltro.SelectedIndex = 2 And cbEstatusfiltro.SelectedIndex < 0 Then
                funciones.ConsultaDinamicaFactura(tbFactura.Text, dgvConsulta)
            ElseIf cbFiltro.SelectedIndex = 2 And cbEstatusfiltro.SelectedIndex >= 0 Then
                funciones.ConsultaDinamicaFacturafiltro(tbFactura.Text, dgvConsulta, cbEstatusfiltro.SelectedValue)
            ElseIf cbFiltro.SelectedIndex = 3 And cbEstatusfiltro.SelectedIndex < 0 Then
                funciones.ConsultaDinamicaFechafactura(dtpInicio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd"), dgvConsulta)
            ElseIf cbFiltro.SelectedIndex = 3 And cbEstatusfiltro.SelectedIndex >= 0 Then
                funciones.ConsultaDinamicaFechafacturafiltro(dtpInicio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd"), dgvConsulta, cbEstatusfiltro.SelectedValue)
            End If

        End If

        lbTotalregistros.Text = CStr(dgvConsulta.RowCount)

        Dim Total As Decimal
        Dim totalcomprometido As Decimal
        Dim totalpagado As Decimal
        Dim totalcancelado As Decimal
        Dim totalenviopago As Decimal
        Dim Columna As Integer = 6

        For Each row As DataGridViewRow In dgvConsulta.Rows
            Total += Val(row.Cells(Columna).Value)
        Next
        lbTotal.Text = Format(Total, "#,##0.00")

        For Each fila As DataGridViewRow In dgvConsulta.Rows

            If fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                totalcomprometido += Val(fila.Cells(Columna).Value)
            ElseIf fila.Cells("ESTATUS").Value = "PAGADO" Then
                totalpagado += Val(fila.Cells(Columna).Value)
            ElseIf fila.Cells("ESTATUS").Value = "CANCELADO" Then
                totalcancelado += Val(fila.Cells(Columna).Value)
            ElseIf fila.Cells("ESTATUS").Value = "ENVÍO A PAGO" Then
                totalenviopago += Val(fila.Cells(Columna).Value)
            End If
        Next

        lbTotalcomprometido.Text = Format(totalcomprometido, "#,##0.00")
        lbTotalpagado.Text = Format(totalpagado, "#,##0.00")
        lbTotalcancelado.Text = Format(totalcancelado, "#,##0.00")
        lbTotalenviopago.Text = Format(totalenviopago, "#,##0.00")

    End Sub

    Private Sub ACTUALIZAR_ESTATUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ToolTip1.SetToolTip(Me.cbPago, "Registrar si existe diferencia entre lo programado para pago y lo pagado")
        funciones.llenarcomboestatus(cbEstatus)
        dtpInicio.Enabled = False
        dtpFin.Enabled = False
        cbEstatusfiltro.Enabled = False
        dtpFechapago.Enabled = False
        tbCLC.Enabled = False
        dgvConsulta.DataSource = Nothing
        dgvConsulta.Columns.Clear()
        dgvConsulta.Rows.Clear()
        tbFactura.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        'Se genera un datagridview temporal para cargar los registros marcados
        Dim rowselected As New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In dgvConsulta.Rows

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

            'EXISTEN OTRAS COLUMNAS QUE NO ESTAN AGREGADAS A LA TBL_FACTURAS_ESTATUS ¿ REAL MENTE QUE SE PRETENDE HACER AL LLENADO DE ESTA TABLA
            'Dim guardaestatus As String = "INSERT INTO TBL_FACTURAS_ESTATUS (FACTURA_ID, ESTATUS_ID, FECHA, OBSERVACIONES, ESTATUS) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA, @OBSERVACIONES, @ESTATUS)"
            ' Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

            ' comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(row.Cells("ID_FACTURA").Value))
            'comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", cbEstatus.SelectedValue)
            'comguardaestatus.Parameters.AddWithValue("@FECHA", DateTime.Now)
            'comguardaestatus.Parameters.AddWithValue("@OBSERVACIONES", tbObservaciones.Text)
            ' comguardaestatus.Parameters.AddWithValue("@ESTATUS", "1")

            'comguardaestatus.ExecuteNonQuery()


        Next

        MessageBox.Show("Los registros se actualizaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbtotalcomprometidoselect.Text = "0.00"
        cn.Close()

        'funciones.ConsultaDinamicaRFC(tbFactura.Text, dgvConsulta)

    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        'If cbSeleccionar.Checked = True Then
        'For Each row As DataGridViewRow In dgvConsulta.Rows
        'Row.Cells(0).Value = True
        'Next
        'ElseIf cbSeleccionar.Checked = False Then
        'For Each row As DataGridViewRow In dgvConsulta.Rows
        'Row.Cells(0).Value = False
        'Next
        'End If
    End Sub

    Private Sub dgvConsulta_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvConsulta.CellBeginEdit



    End Sub

    Private Sub dgvConsulta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellContentClick

        'Sirve para que al dar click al checkbox se realice la suma y así no esperar al siguiente click
        If e.RowIndex < 0 Or Not e.ColumnIndex = 0 Then Exit Sub
        If Convert.ToBoolean(dgvConsulta.Rows(e.RowIndex).Cells(0).Value) Then
            dgvConsulta.Rows(e.RowIndex).Cells(0).Value = False
        Else
            dgvConsulta.Rows(e.RowIndex).Cells(0).Value = True
        End If


        Dim totalcomprometido As Decimal
        Dim totalpagado As Decimal
        Dim totalenviopago As Decimal
        Dim totalcancelado As Decimal
        Dim Columna As Integer = 6


        For Each fila As DataGridViewRow In dgvConsulta.Rows

            If fila.Cells(0).Value = True And fila.Cells("ESTATUS").Value = "COMPROMETIDO" Then
                totalcomprometido += Val(fila.Cells(Columna).Value)
            ElseIf fila.Cells(0).Value = True And fila.Cells("ESTATUS").Value = "PAGADO" Then
                totalpagado += Val(fila.Cells(Columna).Value)
            ElseIf fila.Cells(0).Value = True And fila.Cells("ESTATUS").Value = "ENVÍO A PAGO" Then
                totalenviopago += Val(fila.Cells(Columna).Value)
            ElseIf fila.Cells(0).Value = True And fila.Cells("ESTATUS").Value = "CANCELADO" Then
                totalcancelado += Val(fila.Cells(Columna).Value)
            End If
        Next

        lbtotalcomprometidoselect.Text = Format(totalcomprometido, "#,##0.00")
        lbPagado.Text = Format(totalpagado, "#,##0.00")
        lbTotalenviopagoselec.Text = Format(totalenviopago, "#,##0.00")
        lbCanceladoselec.Text = Format(totalcancelado, "#,##0.00")

    End Sub

    Private Sub dgvConsulta_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellValueChanged

    End Sub

    Private Sub cbEstatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEstatus.SelectionChangeCommitted
        If cbEstatus.SelectedIndex = 2 Then
            dtpFechapago.Enabled = True
            tbCLC.Enabled = True
        ElseIf cbEstatus.SelectedIndex = 0 Then
            dtpFechapago.Enabled = False
        ElseIf cbEstatus.SelectedIndex = 1 Then
            dtpFechapago.Enabled = False
        ElseIf cbEstatus.SelectedIndex = 3 Then
            dtpFechapago.Enabled = False
        End If

    End Sub

    Private Sub dgvConsulta_AllowUserToOrderColumnsChanged(sender As Object, e As EventArgs) Handles dgvConsulta.AllowUserToOrderColumnsChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvConsulta_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvConsulta.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbActivarfiltro.CheckedChanged
        If cbActivarfiltro.Checked = True Then
            cbEstatusfiltro.Enabled = True
        ElseIf cbActivarfiltro.Checked = False Then
            cbEstatusfiltro.Enabled = False
            cbEstatusfiltro.SelectedValue = -1
        End If
    End Sub

    Private Sub cbEstatusfiltro_Enter(sender As Object, e As EventArgs) Handles cbEstatusfiltro.Enter
        funciones.llenarcomboestatus(cbEstatusfiltro)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cbFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFiltro.SelectionChangeCommitted
        If cbFiltro.SelectedIndex = 3 Then
            dtpInicio.Enabled = True
            dtpFin.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        'cn = New SqlConnection(My.Settings.Conexionbd)
        'cn.Open()

        'Dim folio_factura As String

        'folio_factura = tbFactura.Text

        'adaptador = New SqlDataAdapter("Select FACTURAS.ID_FACTURA,CAT_ESTATUS_FACTURA.DESCRIPCION AS ESTATUS, FACTURAS.FOLIO_FACTURA, FACTURAS.FOLIO_FISCAL, FACTURAS.FECHA_FACTURA, FACTURAS.TOTAL, CAT_RUBROS.CLAVE AS RUBRO, CAT_RUBROS.DESCRIPCION, CAT_PROVEEDORES.NOMBRE_PROVEEDOR,CAT_PROVEEDORES.RFC from FACTURAS left join CAT_RUBROS on (FACTURAS.ID_RUBRO = CAT_RUBROS.ID_RUBRO)" &
        '"left join CAT_PROVEEDORES on (CAT_PROVEEDORES.ID_PROVEEDOR = FACTURAS.ID_PROVEEDOR) left join CAT_ESTATUS_FACTURA on (CAT_ESTATUS_FACTURA.ID_ESTATUS = FACTURAS.ID_ESTATUS)" &
        '"Where FOLIO_FACTURA like '" & "%" + folio_factura + "%" & "'", cn)

        'dt = New DataTable
        'adaptador.Fill(dt)
        'dgvOutlook.DataSource = dt
        'dgvOutlook.BindData(adaptador, "t")

        'Dim columnindex As Integer = 8

        'dgvOutlook.GroupTemplate = New OutlookGridAlphabeticGroup()
        'dgvOutlook.GroupTemplate.Column = dgvOutlook.Columns(columnindex)
        'dgvOutlook.GroupTemplate.Collapsed = True

        'dgvOutlook.Sort(New DataRowComparer(columnindex))

    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick

        Dim detalles As New DETALLE_FACTURA
        Dim id As String = dgvConsulta.SelectedRows(0).Cells("ID_FACTURA").Value
        Dim folio As String = dgvConsulta.SelectedRows(0).Cells("FOLIO_FACTURA").Value
        Dim nombre As String = dgvConsulta.SelectedRows(0).Cells("NOMBRE_PROVEEDOR").Value

        detalles.tbId.Text = id
        detalles.tbFolio.Text = folio
        detalles.tbNombre.Text = nombre
        detalles.ShowDialog()

    End Sub

    Private Sub cbPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbPago.KeyPress
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
End Class
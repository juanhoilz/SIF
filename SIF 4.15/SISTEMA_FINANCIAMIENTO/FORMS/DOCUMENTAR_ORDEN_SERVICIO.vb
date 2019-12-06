Imports System.Data
Imports System.Data.SqlClient

Public Class DOCUMENTAR_ORDEN_SERVICIO

    Dim funciones As New BUSQUEDAS_ORDEN_SERVICIO
    Dim funciones_02 As New BASEDATOS
    Public cn As New SqlConnection

    Private Sub cbProveedores_Enter(sender As Object, e As EventArgs) Handles cbProveedores.Enter
        funciones_02.Llenarcatproveedores(cbProveedores)
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFiltro.SelectionChangeCommitted
        If cbFiltro.SelectedIndex = 0 Then
            cbProveedores.Enabled = True
            cbRecurso.Enabled = False
            tbBusqueda.Enabled = False
        ElseIf cbFiltro.SelectedIndex = 1 Then
            cbProveedores.Enabled = False
            cbRecurso.Enabled = True
            tbBusqueda.Enabled = True
        End If

    End Sub

    Private Sub DOCUMENTAR_ORDEN_SERVICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbDuplicados.Visible = False
        cbProveedores.Enabled = False
        cbRecurso.Enabled = False
        tbBusqueda.Enabled = False

        dgvDetalle.RowsDefaultCellStyle.BackColor = Color.LightBlue
        dgvDetalle.AlternatingRowsDefaultCellStyle.BackColor = Color.White

    End Sub

    Private Sub tbBuscar_Click(sender As Object, e As EventArgs) Handles tbBuscar.Click
        If cbFiltro.SelectedIndex = 0 Then
            funciones.Llenardgvproveedor(dgvDetalle, cbProveedores.SelectedValue)
        End If
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbEstatus.Enter
        funciones_02.llenarcomboestatus(cbEstatus)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvOrdenservicio.Columns.Contains("ID_FACTURA") And dgvOrdenservicio.Columns.Contains("FOLIO") And dgvOrdenservicio.Columns.Contains("IMPORTE") Then

        Else
            llenadgvCLC()
        End If

        For Each row As DataGridViewRow In dgvDetalle.SelectedRows

            dgvOrdenservicio.Rows.Add(row.Cells(0).Value, row.Cells(2).Value, row.Cells(3).Value)

        Next

        'Validar si existen duplicados y modificar el color
        For Each grupo As IGrouping(Of Object, DataGridViewRow) In dgvOrdenservicio.Rows.Cast(Of DataGridViewRow)().GroupBy(Function(dr) dr.Cells("FOLIO").Value).Where(Function(g) g.Count() > 1)
            For Each fila As DataGridViewRow In grupo
                fila.DefaultCellStyle.ForeColor = Color.Red
            Next
        Next

        'Mostrar mensaje si existen registros duplicados

        For Each dgv As DataGridViewRow In dgvOrdenservicio.Rows
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

        Me.dgvOrdenservicio.Columns.Add(idfactura)
        Me.dgvOrdenservicio.Columns.Add(foliofactura)
        Me.dgvOrdenservicio.Columns.Add(importe)


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
        dgvOrdenservicio.Columns("IMPORTE").DefaultCellStyle.Format = "n"




    End Sub

    Private Sub dgvOrdenservicio_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOrdenservicio.RowsRemoved
        For Each fila As DataGridViewRow In dgvOrdenservicio.Rows
            fila.DefaultCellStyle.ForeColor = Color.Black
        Next

        'Validar si existen duplicados y modificar el color
        For Each grupo As IGrouping(Of Object, DataGridViewRow) In dgvOrdenservicio.Rows.Cast(Of DataGridViewRow)().GroupBy(Function(dr) dr.Cells("FOLIO").Value).Where(Function(g) g.Count() > 1)

            For Each fila As DataGridViewRow In grupo
                fila.DefaultCellStyle.ForeColor = Color.Red
            Next

        Next

        'Mostrar mensaje si existen registros duplicados

        For Each dgv As DataGridViewRow In dgvOrdenservicio.Rows
            If dgv.DefaultCellStyle.ForeColor = Color.Red Then
                lbDuplicados.Visible = True
                btGuardar.Enabled = False
            Else
                lbDuplicados.Visible = False
                btGuardar.Enabled = True
            End If
        Next
    End Sub

    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs) Handles cbSolicita.Enter
        funciones_02.Llenarcombopersonal(cbSolicita)
    End Sub

    Private Sub cbAutoriza_Enter(sender As Object, e As EventArgs) Handles cbAutoriza.Enter
        funciones_02.Llenarcombopersonal(cbAutoriza)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()




        ''Dim actualizaconsecutivoclc As String = "UPDATE CAT_FOLIOS_CLC set FOLIO_ACTUAL = FOLIO_ACTUAL+1 Where CAT_FOLIOS_CLC.ID = '" & cbFoliosCLC.SelectedValue & "' AND CAT_FOLIOS_CLC.ID_CUENTA_ORIGEN  = '" & cbFuente.SelectedValue & "'"
        ''Dim comactualizaclc As New SqlCommand(actualizaconsecutivoclc, cn)
        ''comactualizaclc.ExecuteNonQuery()

        'MsgBox(cbFoliosCLC.SelectedValue)

        ''Dim folioclc As String = ("Select CAT_FOLIOS_CLC.FOLIO_ACTUAL from CAT_FOLIOS_CLC Where CAT_FOLIOS_CLC.ID = '" & cbFoliosCLC.SelectedValue & "' AND CAT_FOLIOS_CLC.ID_CUENTA_ORIGEN  = '" & cbFuente.SelectedValue & "'")
        'Dim folioclc As String = ("Select CAT_FOLIOS_CLC.FOLIO_ACTUAL from CAT_FOLIOS_CLC Where CAT_FOLIOS_CLC.ID_EJERCICIO = @parametro")
        'MsgBox(cbFoliosCLC.SelectedValue)
        ''Dim generaclc As New SqlCommand(folioclc, cn)
        ''generaclc.ExecuteNonQuery()
        'MsgBox(cbFoliosCLC.SelectedValue)
        'generaclc.Parameters.AddWithValue("@parametro", cbFoliosCLC.SelectedValue)

        ''Dim reader As SqlDataReader = generaclc.ExecuteReader
        'MsgBox(reader.Read)


        ''reader.Read()
        ''tbCLC.Text = reader("FOLIO_ACTUAL")
        'Else
        'MsgBox("No se encontraron datos")
        'End If
        ''reader.Close()

        ''For Each row As DataGridViewRow In dgvCLC.Rows


        ''Dim consulta As String = "INSERT INTO FACTURAS_CLC (ID_FOLIOS, ID_CUENTA_ORIGEN, FOLIO_CLC, ID_FACTURA, IMPORTE_PAGADO, FECHA, FECHA_AUDITORIA)  VALUES (@ID_FOLIOS, @ID_CUENTA_ORIGEN, @FOLIO_CLC, @ID_FACTURA, @IMPORTE_PAGADO, @FECHA, @FECHA_AUDITORIA)"
        ''Dim comm As New SqlCommand(consulta, cn)

        ''comm.Parameters.AddWithValue("@ID_FOLIOS", cbFoliosCLC.SelectedValue)
        ''comm.Parameters.AddWithValue("@ID_CUENTA_ORIGEN", cbFuente.SelectedValue)
        ''comm.Parameters.AddWithValue("@FOLIO_CLC", Convert.ToInt32(tbCLC.Text))
        ''comm.Parameters.AddWithValue("@ID_FACTURA", row.Cells("ID_FACTURA").Value)
        ''comm.Parameters.AddWithValue("@IMPORTE_PAGADO", Convert.ToDecimal(row.Cells("IMPORTE").Value))
        ''comm.Parameters.AddWithValue("@FECHA", dtpFecha.Value)
        ''comm.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

        ''comm.ExecuteNonQuery()

        ''Next

        ''MessageBox.Show("Los datos del CLC se han guardado correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ''cn.Close()

    End Sub

    Private Sub cbFoliosCLC_Enter(sender As Object, e As EventArgs) Handles cbFolios.Enter
        funciones.Llenarcombofolios(cbFolios)
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Linq

Public Class DOCUMENTAR_ORDEN

    Dim cn As New SqlConnection(My.Settings.Conexionbd)

    Dim funciones As New BASEDATOS

    Dim validacampos As New Validacampos

    Dim valida_registro As New Valida_Existe_Registro
    Private Sub DOCUMENTAR_FACTURA_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub DOCUMENTAR_ORDEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbIdorden.Enabled = True
        tbOrden.Enabled = False
        cbSolicita.Enabled = False
        btAgregararea.Enabled = False
        cbAplica.Enabled = False
        cbProveedor.Enabled = False
        btAgregaproveedor.Enabled = False
        tbMonto.Enabled = False
        dtpFecha.Enabled = False
        cbFirmasolicita.Enabled = False
        btAgregapersonal.Enabled = False
        cbFirmaautoriza.Enabled = False
        btImportaxml.Enabled = False
        btGuardar.Enabled = True
        btImprimir.Enabled = True
        btBuscar.Enabled = True

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            'MessageBox.Show("Inicia verificacion")
            If valida_registro.Valida_Existe(tbFoliofiscal.Text) = False Then

                cn.Open()

                Dim idordencompra As Integer = 0
                Dim insertatextb As String = "INSERT INTO ORDEN_COMPRA (FOLIO,ID_PROVEEDOR,ID_UNIDAD_SOLICITA,ID_UNIDAD_APLICA,MONTO_ESTIMADO,FECHA_SOLICITUD,ID_NOMBRE_SOLICITA,ID_NOMBRE_AUTORIZA,FOLIO_FISCAL) VALUES (@FOLIO,@ID_PROVEEDOR,@ID_UNIDAD_SOLICITA,@ID_UNIDAD_APLICA,@MONTO_ESTIMADO,@FECHA_SOLICITUD,@ID_NOMBRE_SOLICITA,@ID_NOMBRE_AUTORIZA,@FOLIO_FISCAL) SELECT SCOPE_IDENTITY()"
                Dim commtb As New SqlCommand(insertatextb, cn)

                commtb.Parameters.AddWithValue("@FOLIO", tbOrden.Text)
                commtb.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt16(cbProveedor.SelectedValue))
                commtb.Parameters.AddWithValue("@ID_UNIDAD_SOLICITA", Convert.ToInt16(cbSolicita.SelectedValue))
                commtb.Parameters.AddWithValue("@ID_UNIDAD_APLICA", Convert.ToInt16(cbAplica.SelectedValue))
                commtb.Parameters.AddWithValue("@MONTO_ESTIMADO", Convert.ToDecimal(tbMonto.Text))
                commtb.Parameters.AddWithValue("@FECHA_SOLICITUD", Convert.ToDateTime(dtpFecha.Value))
                commtb.Parameters.AddWithValue("@ID_NOMBRE_SOLICITA", Convert.ToInt16(cbFirmasolicita.SelectedValue))
                commtb.Parameters.AddWithValue("@ID_NOMBRE_AUTORIZA", Convert.ToInt16(cbFirmaautoriza.SelectedValue))
                commtb.Parameters.AddWithValue("@FOLIO_FISCAL", tbFoliofiscal.Text)
                'commtb.Parameters.AddWithValue("@ID_PARTIDA", Convert.ToInt16(cbPartida.SelectedValue))

                idordencompra = Convert.ToInt16(commtb.ExecuteScalar)


                If dgvOrden.RowCount > 0 Then
                    For Each row As DataGridViewRow In dgvOrden.Rows

                        ' Dim insertadatagv As String = "INSERT INTO ORDEN_COMPRA_DET (ID_ORDEN_COMPRA,FOLIO_ORDEN_COMPRA,CLAVE,DESCRIPCION,CANTIDAD,UNIDAD,VALOR_UNITARIO,IMPORTE) VALUES (@id_orden_compra,@folio_orden_compra,@clave,@descripcion,@cantidad,@unidad,@valorUnitario,@importe)"

                        Dim insertadatagv As String = "INSERT INTO ORDEN_COMPRA_DET (ID_ORDEN_COMPRA,FOLIO_ORDEN_COMPRA,DESCRIPCION,CANTIDAD,UNIDAD,VALOR_UNITARIO,IMPORTE) VALUES (@id_orden_compra,@folio_orden_compra,@descripcion,@cantidad,@unidad,@valorUnitario,@importe)"

                        Dim commdgv As New SqlCommand(insertadatagv, cn)

                        commdgv.Parameters.AddWithValue("@id_orden_compra", SqlDbType.Int).Value = idordencompra
                        commdgv.Parameters.AddWithValue("@folio_orden_compra", tbOrden.Text)
                        'commdgv.Parameters.AddWithValue("@clave", Convert.ToString(row.Cells("noIdentificacion").Value))
                        commdgv.Parameters.AddWithValue("@descripcion", Convert.ToString(row.Cells("descripcion").Value))
                        commdgv.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells("cantidad").Value))
                        commdgv.Parameters.AddWithValue("@unidad", Convert.ToString(row.Cells("unidad").Value))
                        commdgv.Parameters.AddWithValue("@valorUnitario", Convert.ToDecimal(row.Cells("valorUnitario").Value))
                        commdgv.Parameters.AddWithValue("@importe", Convert.ToDecimal(row.Cells("importe").Value))

                        Dim rowaffected As Integer = CInt(commdgv.ExecuteNonQuery())

                        If rowaffected > 0 Then

                        End If

                    Next

                    tbIdorden.Text = idordencompra

                    'MessageBox.Show("Los registros se guardaron correctamente" & vbCrLf & "" & vbCrLf & "                         FOLIO: " & tbIdorden.Text & "", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim message, title, defaultvalue As String
                    Dim myvalue As Object

                    message = "Registros guardados correctamente" & vbCrLf & "" & vbCrLf & "                         FOLIO: "
                    title = "Guardar registros"
                    defaultvalue = tbIdorden.Text

                    myvalue = InputBox(message, title, defaultvalue)


                    If tbIdorden.TextLength > 1 Then
                        btImprimir.Enabled = True
                    Else
                        btImprimir.Enabled = False
                    End If
                    cn.Close()

                    End If
                    'MessageBox.Show("Termina verificacion, inicia la apertura de la db")

                Else

                MessageBox.Show("La factura ya ha sido cargada anteriormente, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btAgregararea.Click

    End Sub

    Private Sub cbSolicita_Enter(sender As Object, e As EventArgs) Handles cbSolicita.Enter
        funciones.LlenarComboUnidades(cbSolicita)
    End Sub

    Private Sub cbAplica_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbAplica_Enter(sender As Object, e As EventArgs) Handles cbAplica.Enter
        funciones.LlenarComboUnidades(cbAplica)
    End Sub

    Private Sub cbProveedor_Enter(sender As Object, e As EventArgs) Handles cbProveedor.Enter
        funciones.Llenarcatproveedores(cbProveedor)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btAgregaproveedor.Click
        ALTA_PROVEEDORES.ShowDialog()
    End Sub

    Private Sub cbFirmasolicita_Enter(sender As Object, e As EventArgs) Handles cbFirmasolicita.Enter
        funciones.Llenarcombopersonal(cbFirmasolicita)
    End Sub

    Private Sub cbFirmaautoriza_Enter(sender As Object, e As EventArgs) Handles cbFirmaautoriza.Enter
        funciones.Llenarcombopersonal(cbFirmaautoriza)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btImportaxml.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lbRutaarchivo.Text = OpenFileDialog1.FileName
        End If

        Dim myXMLfile As String = lbRutaarchivo.Text
        Dim ds2 As New DataSet()

        'Se llena el Datagridview

        ds2.ReadXml(myXMLfile)
        dgvOrden.DataSource = ds2
        dgvOrden.DataMember = "Concepto"
        dgvOrden.Columns(0).Width = 100
        dgvOrden.Columns(1).Width = 100
        dgvOrden.Columns(2).Width = 290

        If dgvOrden.RowCount > 0 Then
            btGuardar.Enabled = True
        Else
            btGuardar.Enabled = False
        End If

        'Se captura el folio fiscal

        Dim xDoc As New XmlDocument()
        xDoc.Load(lbRutaarchivo.Text)
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

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        Dim id_orden = CInt(tbIdorden.Text)
        'Dim form_orden_compra As New REPORTE_SOLICITUD_COMPRA

        'form_orden_compra.ordencompra = CInt(id_orden)
        'form_orden_compra.ShowDialog()

    End Sub

    Private Sub cbPartida_Enter(sender As Object, e As EventArgs)
        'funciones.llenacombopartidas(cbPartida)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Partidas.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        ALTA_PERSONAL.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub dtpFecha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpFecha.Validating

        Dim _date As DateTime = dtpFecha.Value.Date

        If _date.DayOfWeek = DayOfWeek.Saturday OrElse _date.DayOfWeek = DayOfWeek.Sunday Then
            e.Cancel = True
            MessageBox.Show("Fecha incorrecta, favor de verificar", "Validar fechas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub tbMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMonto.KeyPress
        validacampos.numerosdecimal(tbMonto, e)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        tbOrden.Enabled = True
        cbSolicita.Enabled = True
        btAgregararea.Enabled = True
        cbAplica.Enabled = True
        cbProveedor.Enabled = True
        btAgregaproveedor.Enabled = True
        tbMonto.Enabled = True
        dtpFecha.Enabled = True
        cbFirmasolicita.Enabled = True
        btAgregapersonal.Enabled = True
        cbFirmaautoriza.Enabled = True
        btImportaxml.Enabled = True
        btGuardar.Enabled = False
        btImprimir.Enabled = False
        btBuscar.Enabled = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        tbIdorden.Enabled = True
        btBuscar.Enabled = True
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        cn.Open()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btAgregapersonal.Click
        ALTA_PERSONAL.ShowDialog()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)

    End Sub
End Class
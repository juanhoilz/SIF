Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Public Class Documentar

    Dim cn As New SqlConnection(My.Settings.Conexionbd)

    Dim funciones As New BASEDATOS

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ALTA_PROVEEDORES.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lbRutaarchivo.Text = OpenFileDialog1.FileName
        End If

        Dim myXMLfile As String = lbRutaarchivo.Text
        Dim ds2 As New DataSet()

        Try
            ds2.ReadXml(myXMLfile)
            dgvOrden.DataSource = ds2
            dgvOrden.DataMember = "Concepto"
            dgvOrden.Columns(0).Width = 100
            dgvOrden.Columns(1).Width = 100
            dgvOrden.Columns(2).Width = 290

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            cn.Open()

            Dim idordencompra As Integer = 0
            Dim insertatextb As String = "INSERT INTO ORDEN_COMPRA (FOLIO,ID_PROVEEDOR,ID_UNIDAD_SOLICITA,ID_UNIDAD_APLICA,MONTO_ESTIMADO,FECHA_SOLICITUD,ID_NOMBRE_SOLICITA,ID_NOMBRE_AUTORIZA,ID_PARTIDA) VALUES (@FOLIO,@ID_PROVEEDOR,@ID_UNIDAD_SOLICITA,@ID_UNIDAD_APLICA,@MONTO_ESTIMADO,@FECHA_SOLICITUD,@ID_NOMBRE_SOLICITA,@ID_NOMBRE_AUTORIZA,@ID_PARTIDA) SELECT SCOPE_IDENTITY()"
            Dim commtb As New SqlCommand(insertatextb, cn)

            commtb.Parameters.AddWithValue("@FOLIO", tbOrden.Text)
            commtb.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt16(cbProveedor.SelectedValue))
            commtb.Parameters.AddWithValue("@ID_UNIDAD_SOLICITA", Convert.ToInt16(cbSolicita.SelectedValue))
            commtb.Parameters.AddWithValue("@ID_UNIDAD_APLICA", Convert.ToInt16(cbAplica.SelectedValue))
            commtb.Parameters.AddWithValue("@MONTO_ESTIMADO", Convert.ToDecimal(tbMonto.Text))
            commtb.Parameters.AddWithValue("@FECHA_SOLICITUD", Convert.ToDateTime(dtpFecha.Value))
            commtb.Parameters.AddWithValue("@ID_NOMBRE_SOLICITA", Convert.ToInt16(cbFirmasolicita.SelectedValue))
            commtb.Parameters.AddWithValue("@ID_NOMBRE_AUTORIZA", Convert.ToInt16(cbFirmaautoriza.SelectedValue))
            commtb.Parameters.AddWithValue("@ID_PARTIDA", Convert.ToInt16(cbPartida.SelectedValue))

            idordencompra = Convert.ToInt16(commtb.ExecuteScalar)


            If dgvOrden.RowCount > 0 Then
                For Each row As DataGridViewRow In dgvOrden.Rows

                    Dim insertadatagv As String = "INSERT INTO ORDEN_COMPRA_DET (ID_ORDEN_COMPRA,FOLIO_ORDEN_COMPRA,CLAVE,DESCRIPCION,CANTIDAD,UNIDAD,VALOR_UNITARIO,IMPORTE) VALUES (@id_orden_compra,@folio_orden_compra,@clave,@descripcion,@cantidad,@unidad,@valorUnitario,@importe)"

                    Dim commdgv As New SqlCommand(insertadatagv, cn)

                    commdgv.Parameters.AddWithValue("@id_orden_compra", SqlDbType.Int).Value = idordencompra
                    commdgv.Parameters.AddWithValue("@folio_orden_compra", tbOrden.Text)
                    commdgv.Parameters.AddWithValue("@clave", Convert.ToString(row.Cells("noIdentificacion").Value))
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


                MessageBox.Show("Los registros se guardaron correctamente" & vbCrLf & "" & vbCrLf & "                         FOLIO: " & tbIdorden.Text & "", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cn.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbProveedor.Enter
        funciones.Llenarcatproveedores(cbProveedor)
    End Sub

    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs) Handles cbPartida.Enter
        funciones.llenacombopartidas(cbPartida)
    End Sub

    Private Sub ComboBox1_Enter_1(sender As Object, e As EventArgs) Handles cbSolicita.Enter
        funciones.LlenarComboUnidades(cbSolicita)
    End Sub

    Private Sub ComboBox1_Enter_2(sender As Object, e As EventArgs) Handles cbAplica.Enter
        funciones.LlenarComboUnidades(cbAplica)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ALTA_PERSONAL.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ALTA_PERSONAL.ShowDialog()
    End Sub

    Private Sub cbFirmasolicita_Enter(sender As Object, e As EventArgs) Handles cbFirmasolicita.Enter
        funciones.Llenarcombopersonal(cbFirmasolicita)
    End Sub

    Private Sub cbFirmaautoriza_Enter(sender As Object, e As EventArgs) Handles cbFirmaautoriza.Enter
        funciones.Llenarcombopersonal(cbFirmaautoriza)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Dim id_orden = CInt(tbIdorden.Text)
        'Dim form_orden_compra As New REPORTE_SOLICITUD_COMPRA

        'form_orden_compra.ordencompra = CInt(id_orden)
        'form_orden_compra.ShowDialog()

    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs)
        Partidas.ShowDialog()
    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        'tbIdorden.Text = tbIdpedido.Text
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        tbIdorden.Text = tbIdpedido.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class

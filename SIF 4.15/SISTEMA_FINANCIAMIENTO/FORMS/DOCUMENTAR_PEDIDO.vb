Imports System.Data
Imports System.Data.SqlClient

Public Class DOCUMENTAR_PEDIDO
    Dim numletras As New Numeros_a_letras
    Public cn As New SqlConnection
    Dim funciones As New BASEDATOS
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        tbNumerosletras.Text = numletras.Num2Text(tbTotal.Text)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btBuscar.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim consulta As String = ("Select O.ID_ORDEN_COMPRA,O.FOLIO,CAT_PROVEEDORES.NOMBRE_PROVEEDOR,O.FECHA_SOLICITUD,O.MONTO_ESTIMADO," &
        "us.NOMBRE_UNIDAD as UNIDAD_SOLICITA, ua.NOMBRE_UNIDAD as UNIDAD_APLICA,ns.ABREVIATURA+' '+ns.APELLIDO_PATERNO+' '+ns.APELLIDO_MATERNO+' '+ns.NOMBRE AS SOLICITA," &
        "na.ABREVIATURA+' '+na.APELLIDO_PATERNO+' '+na.APELLIDO_MATERNO+' '+na.NOMBRE AS AUTORIZA,ns.PUESTO AS PUESTO_SOLICITA," &
        "na.PUESTO AS PUESTO_AUTORIZA from ORDEN_COMPRA O left join CAT_PROVEEDORES on CAT_PROVEEDORES.ID_PROVEEDOR = O.ID_PROVEEDOR" &
           " left join CAT_UNIDADES_ADMINISTRATIVAS us on (us.ID_UNIDAD = O.ID_UNIDAD_SOLICITA)" &
           " left join CAT_UNIDADES_ADMINISTRATIVAS ua on (ua.ID_UNIDAD= O.ID_UNIDAD_APLICA)" &
           " left join CAT_PERSONAL ns on (ns.ID_PERSONAL = O.ID_NOMBRE_SOLICITA)" &
           " left join CAT_PERSONAL na on (na.ID_PERSONAL = O.ID_NOMBRE_AUTORIZA) Where O.ID_ORDEN_COMPRA = @parametro")

        Dim consulta_dgv As String = ("Select CD.DESCRIPCION,CD.CANTIDAD,CD.UNIDAD,CD.VALOR_UNITARIO," &
                                     " CD.IMPORTE from ORDEN_COMPRA O left join ORDEN_COMPRA_DET CD on O.ID_ORDEN_COMPRA = CD.ID_ORDEN_COMPRA" &
                                     " Where O.ID_ORDEN_COMPRA = @parametro")

        Dim cmd As New SqlCommand(consulta, cn)
        Dim cmd_dgv As New SqlCommand(consulta_dgv, cn)

        Dim da As New SqlDataAdapter(cmd_dgv)

        Dim dt As New DataTable

        cmd.Parameters.AddWithValue("@parametro", tbIdorden.Text)
        cmd_dgv.Parameters.AddWithValue("@parametro", tbIdorden.Text)

        da.Fill(dt)
        dgvOrdencompra.DataSource = dt
        dgvOrdencompra.Columns(0).Width = 150
        dgvOrdencompra.Columns(1).Width = 400
        dgvOrdencompra.Columns(4).Width = 105


        'Calcula el Subtotal con los datos del datagridview

        Dim Subtotal As Decimal
        Dim Columna As Integer = 4

        For Each row As DataGridViewRow In Me.dgvOrdencompra.Rows
            Subtotal += Val(row.Cells(Columna).Value)
        Next

        'Realiza las operaciones para determinar el importe total

        'If cbPartidas.SelectedValue <> 31 Then
        tbSubtotal.Text = Format(Subtotal, "#,##0.00")
        'tbIva.Text = Format(((tbSubtotal.Text) * 0.16), "#,##0.00")
        'tbTotal.Text = Format(((tbSubtotal.Text) + Convert.ToDecimal(tbIva.Text)), "#,##0.00")
        'Else
        'tbSubtotal.Text = Format(Subtotal, "#,##0.00")
        'tbIva.Text = Convert.ToDecimal(0.0)
        'tbTotal.Text = Format(tbSubtotal.Text, "#,##0.00")
        'End If

        'Convertimos el total en letras

        'Dim largo = Len(CStr(Format(CDec(tbTotal.Text), "#,###.00")))
        'Dim decimales = Mid(CStr(Format(CDec(tbTotal.Text), "#,###.00")), largo - 2)
        'tbNumerosletras.Text = "SON " & numletras.Num2Text(tbTotal.Text - decimales) & " PESOS " & Mid(decimales, Len(decimales) - 1) & "/100 M.N."


        'Llenamos el datagridview con los datos del select

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            tbFolio.Text = reader("FOLIO")
            tbArea.Text = reader("UNIDAD_SOLICITA")
            tbAplica.Text = reader("UNIDAD_APLICA")
            tbProveedor.Text = reader("NOMBRE_PROVEEDOR")
            tbMontoestimado.Text = reader("MONTO_ESTIMADO")
            tbSolicita.Text = reader("SOLICITA")
            tbAutoriza.Text = reader("AUTORIZA")
            tbFechasolicitud.Text = reader("FECHA_SOLICITUD")

        Else
            MessageBox.Show("Orden de compra no encontrado", "Buscar registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        cn.Close()
    End Sub

    Private Sub DOCUMENTAR_PEDIDO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Me.btConsultarpartidas, "Consultar partidas")
        'dgvOrdencompra.RowsDefaultCellStyle.BackColor = Color.LightBlue
        'dgvOrdencompra.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs) Handles cbPartidas.Enter
        funciones.llenacombopartidas(cbPartidas)
    End Sub

    Private Sub ComboBox4_Enter(sender As Object, e As EventArgs) Handles cbFirmapedido.Enter
        funciones.Llenarcombopersonal(cbFirmapedido)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ALTA_PERSONAL.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btConsultarpartidas.Click
        Partidas.ShowDialog()
    End Sub

    Private Sub ComboBox3_Enter(sender As Object, e As EventArgs) Handles cbTipoadquisiciones.Enter
        funciones.Llenacomboadquisicion(cbTipoadquisiciones)
    End Sub

    Private Sub cbLugarentrega_Enter(sender As Object, e As EventArgs) Handles cbLugarentrega.Enter
        funciones.Llenacombolugarentrega(cbLugarentrega)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            'Dim DOCUMENTAR_ORDEN As New DOCUMENTAR_ORDEN

            'If dtpPedido.Value > DOCUMENTAR_ORDEN.dtpFecha Then

            'End If
            cn.Open()

            Dim guardarpedido As String = "INSERT INTO PEDIDOS (ID_ORDEN_COMPRA,FECHA_PEDIDO,TIPO_PEDIDO,ID_ADQUISICION,CLAVE_PROGRAMA,ID_UNIDAD_ENTREGA,SUBTOTAL,IVA,TOTAL,IMPORTE_LETRAS,ID_PARTIDA,ID_CUENTA_ORIGEN,ID_PERSONAL) VALUES (@ID_ORDEN_COMPRA,@FECHA_PEDIDO,@TIPO_PEDIDO,@ID_ADQUISICION,@CLAVE_PROGRAMA,@ID_UNIDAD_ENTREGA,@SUBTOTAL,@IVA,@TOTAL,@IMPORTE_LETRAS,@ID_PARTIDA,@ID_CUENTA_ORIGEN,@ID_PERSONAL)"
                Dim comm As New SqlCommand(guardarpedido, cn)

                comm.Parameters.AddWithValue("@ID_ORDEN_COMPRA", tbIdorden.Text)
                comm.Parameters.AddWithValue("@FECHA_PEDIDO", Convert.ToDateTime(dtpPedido.Value))
                comm.Parameters.AddWithValue("@TIPO_PEDIDO", cbMotivopedido.Text)
                comm.Parameters.AddWithValue("@ID_ADQUISICION", Convert.ToInt16(cbTipoadquisiciones.SelectedValue))
                comm.Parameters.AddWithValue("@CLAVE_PROGRAMA", tbClaveprograma.Text)
                comm.Parameters.AddWithValue("@ID_UNIDAD_ENTREGA", Convert.ToInt16(cbLugarentrega.SelectedValue))
                comm.Parameters.AddWithValue("@SUBTOTAL", Convert.ToDecimal(tbSubtotal.Text))
                comm.Parameters.AddWithValue("@IVA", Convert.ToDecimal(tbIva.Text))
                comm.Parameters.AddWithValue("@TOTAL", Convert.ToDecimal(tbTotal.Text))
                comm.Parameters.AddWithValue("@IMPORTE_LETRAS", tbNumerosletras.Text)
                comm.Parameters.AddWithValue("@ID_PARTIDA", Convert.ToInt16(cbPartidas.SelectedValue))
                comm.Parameters.AddWithValue("@ID_CUENTA_ORIGEN", Convert.ToInt16(cbCuentas.SelectedValue))
                comm.Parameters.AddWithValue("@ID_PERSONAL", Convert.ToInt16(cbFirmapedido.SelectedValue))

                comm.ExecuteNonQuery()

                MessageBox.Show("Los registros se guardaron correctamente" & vbCrLf & "" & vbCrLf & "                         FOLIO: " & tbIdorden.Text & "", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbCuentas.Enter
        funciones.llenarcomboejercicio(cbCuentas)
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Dim id_orden = CInt(tbIdorden.Text)
        'Dim form_orden_compra As New REPORTE_PEDIDOS

        'form_orden_compra.pedidos = CInt(id_orden)
        'form_orden_compra.ShowDialog()
    End Sub

    Private Sub cbPartidas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPartidas.SelectionChangeCommitted

        'Realiza las operaciones para determinar el importe total

        If cbPartidas.SelectedValue = 31 Then
            tbIva.Text = Convert.ToDecimal("0.00")
            tbTotal.Text = Format(Convert.ToDecimal(tbSubtotal.Text), "#,##0.00")
        Else
            tbIva.Text = Format(((tbSubtotal.Text) * 0.16), "#,##0.00")
            tbTotal.Text = Format(((tbSubtotal.Text) + Convert.ToDecimal(tbIva.Text)), "#,##0.00")
        End If

        'Convertimos el total en letras

        Dim largo = Len(CStr(Format(CDec(tbTotal.Text), "#,###.00")))
        Dim decimales = Mid(CStr(Format(CDec(tbTotal.Text), "#,###.00")), largo - 2)
        tbNumerosletras.Text = "SON " & numletras.Num2Text(tbTotal.Text - decimales) & " PESOS " & Mid(decimales, Len(decimales) - 1) & "/100 M.N."

    End Sub

    Private Sub dtpPedido_ValueChanged(sender As Object, e As EventArgs) Handles dtpPedido.ValueChanged

    End Sub

    Private Sub dtpPedido_Leave(sender As Object, e As EventArgs) Handles dtpPedido.Leave

    End Sub
End Class
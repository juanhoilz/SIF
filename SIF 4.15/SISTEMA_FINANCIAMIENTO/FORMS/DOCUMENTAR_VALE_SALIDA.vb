Imports System.Data
Imports System.Data.SqlClient

Public Class DOCUMENTAR_VALE_SALIDA
    Dim funciones As New BASEDATOS
    Public cn As New SqlConnection
    Private Sub tbBuscar_Click(sender As Object, e As EventArgs) Handles tbBuscar.Click
        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim consulta As String = ("Select ORDEN_COMPRA.FOLIO,PEDIDOS.ID_PEDIDO,us.NOMBRE_UNIDAD as UNIDAD_SOLICITA,ua.NOMBRE_UNIDAD as UNIDAD_APLICA," &
        "ns.ABREVIATURA+' '+ns.APELLIDO_PATERNO+' '+ns.APELLIDO_MATERNO+' '+ns.NOMBRE AS SOLICITA from PEDIDOS left join VALE_SALIDA on PEDIDOS.ID_PEDIDO = VALE_SALIDA.ID" &
           " left join ORDEN_COMPRA on (ORDEN_COMPRA.ID_ORDEN_COMPRA = PEDIDOS.ID_ORDEN_COMPRA)" &
           " left join CAT_UNIDADES_ADMINISTRATIVAS us on (us.ID_UNIDAD = ORDEN_COMPRA.ID_UNIDAD_SOLICITA)" &
           " left join CAT_UNIDADES_ADMINISTRATIVAS ua on (ua.ID_UNIDAD = ORDEN_COMPRA.ID_UNIDAD_APLICA)" &
           " left join CAT_PERSONAL ns on (ns.ID_PERSONAL = ORDEN_COMPRA.ID_NOMBRE_SOLICITA)" &
           " Where PEDIDOS.ID_ORDEN_COMPRA = @parametro")

        Dim consulta_dgv As String = ("Select CD.DESCRIPCION,CD.CANTIDAD,CD.UNIDAD,CD.VALOR_UNITARIO," &
                             " CD.IMPORTE from ORDEN_COMPRA O left join ORDEN_COMPRA_DET CD on O.ID_ORDEN_COMPRA = CD.ID_ORDEN_COMPRA" &
                             " left join PEDIDOS on (PEDIDOS.ID_ORDEN_COMPRA = O.ID_ORDEN_COMPRA)" &
                             " Where PEDIDOS.ID_ORDEN_COMPRA = @parametro")

        Dim cmd As New SqlCommand(consulta, cn)
        Dim cmd_dgv As New SqlCommand(consulta_dgv, cn)

        Dim da As New SqlDataAdapter(cmd_dgv)

        Dim dt As New DataTable

        cmd.Parameters.AddWithValue("@parametro", tbPedido.Text)
        cmd_dgv.Parameters.AddWithValue("@parametro", tbPedido.Text)

        da.Fill(dt)
        dgvPedido.DataSource = dt
        dgvPedido.Columns(0).Width = 150
        dgvPedido.Columns(1).Width = 400
        dgvPedido.Columns(4).Width = 105

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            tbFolio.Text = reader("FOLIO")
            tbIdpedido.Text = reader("ID_PEDIDO")
            tbDepartamento.Text = reader("UNIDAD_SOLICITA")
            tbAplica.Text = reader("UNIDAD_APLICA")
            tbSolicita.Text = reader("SOLICITA")

        Else
            MessageBox.Show("Número de pedido no encontrado", "Buscar registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbFolio.Clear()
            tbIdpedido.Clear()
            tbDepartamento.Clear()
            tbAplica.Clear()
            tbSolicita.Clear()
        End If
        cn.Close()


    End Sub

    Private Sub DOCUMENTAR_VALE_SALIDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbAutoriza_Enter(sender As Object, e As EventArgs) Handles cbAutoriza.Enter
        funciones.Llenarcombopersonal(cbAutoriza)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            cn.Open()

            Dim guardarvale As String = "INSERT INTO VALE_SALIDA (ID_PEDIDO,FOLIO,FECHA,ID_PERSONAL,ID_PERSONAL_RECIBE) VALUES (@ID_PEDIDO,@FOLIO,@FECHA,@ID_PERSONAL,@ID_PERSONAL_RECIBE)"
            Dim comm As New SqlCommand(guardarvale, cn)

            comm.Parameters.AddWithValue("@ID_PEDIDO", tbIdpedido.Text)
            comm.Parameters.AddWithValue("@FOLIO", tbFolio.Text)
            comm.Parameters.AddWithValue("@FECHA", Convert.ToDateTime(dtpFecha.Value))
            comm.Parameters.AddWithValue("@ID_PERSONAL", Convert.ToInt16(cbAutoriza.SelectedValue))
            comm.Parameters.AddWithValue("@ID_PERSONAL_RECIBE", Convert.ToInt16(cbRecibe.SelectedValue))


            comm.ExecuteNonQuery()

            MessageBox.Show("Los registros se guardaron correctamente" & vbCrLf & "" & vbCrLf & "                         FOLIO: " & tbPedido.Text & "", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        Dim id_pedido = CInt(tbPedido.Text)
        'Dim form_vale_salida As New REPORTE_VALE_DE_SALIDA

        'form_vale_salida.vale_salida = CInt(id_pedido)
        'form_vale_salida.ShowDialog()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbRecibe.Enter
        funciones.Llenarcombopersonal(cbRecibe)
    End Sub
End Class
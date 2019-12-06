Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml

Public Class VALIDAR_MEDICAMENTOS


    Public cn As New SqlConnection
    Private Sub btImportar_Click(sender As Object, e As EventArgs)
        If AbrirXML.ShowDialog = Windows.Forms.DialogResult.OK Then

            'dgvDetalles.Columns.Clear()

            'dgvDetalles.Rows.Clear()

            'tbRuta.Text = AbrirXML.FileName




            'Dim myXMLfile As String = tbRuta.Text
            'Dim ds2 As New DataSet()

            'Se llena el Datagridview



            'ds2.ReadXml(myXMLfile)
            'dgvMedicamentos.DataSource = ds2
            'dgvMedicamentos.DataMember = "Concepto"
            'dgvMedicamentos.Columns(0).Width = 100
            'dgvMedicamentos.Columns(1).Width = 100
            'dgvMedicamentos.Columns(2).Width = 290
        End If

    End Sub

    Private Sub VALIDAR_MEDICAMENTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbValidacion.Visible = False
        btContinuar.Visible = False
    End Sub

    Private Sub btIniciar_Click(sender As Object, e As EventArgs) Handles btIniciar.Click


        Try
            Dim datos_factura As New Altafactura


            datos_factura.tbFoliofiscal.Text = tbTotal.Text



            'MsgBox(Altafactura.tbFoliofiscal.Text)

            'For Each row As DataGridViewRow In Altafactura.dgvDetalles.Rows

            'Dim guardamedicamentos As String = "INSERT INTO MEDICAMENTOS_VALIDAR (FOLIO_FISCAL, FECHA_VALIDACION,  CLAVE_MEDICAMENTO, PRECIO_UNITARIO, CANTIDAD, IMPORTE) VALUES (@FOLIO_FISCAL, @FECHA_VALIDACION, @CLAVE_MEDICAMENTO, @PRECIO_UNITARIO, @CANTIDAD, @IMPORTE)"
            'Dim comguardamedicamentos As New SqlCommand(guardamedicamentos, cn)

            'comguardamedicamentos.Parameters.AddWithValue("@FOLIO_FISCAL", datos_factura.tbFoliofiscal.Text)
            'comguardamedicamentos.Parameters.AddWithValue("@FECHA_VALIDACION", DateTime.Now)
            'comguardamedicamentos.Parameters.AddWithValue("@CLAVE_MEDICAMENTO", row.Cells("noIdentificacion").Value)
            'comguardamedicamentos.Parameters.AddWithValue("@PRECIO_UNITARIO", row.Cells("ValorUnitario").Value)
            'comguardamedicamentos.Parameters.AddWithValue("@CANTIDAD", Convert.ToDecimal(row.Cells("Cantidad").Value))
            'comguardamedicamentos.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(row.Cells("Importe").Value))

            'comguardamedicamentos.ExecuteNonQuery()

            'Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try
        'MsgBox("Se ha completado la validación")
    End Sub
End Class
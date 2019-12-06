Imports System.Xml
Imports System.IO

Public Class CAPTURA_MANUAL
    Dim funciones As New BASEDATOS
    Private xmlFile As String = Application.StartupPath + "\XML.xml"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CAPTURAR_PARTIDAS.Close()
    End Sub

    Private Sub CAPTURA_MANUAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btCargarXml.Enabled = False
        btAgregar.Enabled = False
        btContinuar.Enabled = False
        tbCantidad.Enabled = False
        tbunidad.Enabled = False
        tbClave.Enabled = False
        tbDescripcion.Enabled = False
        tbValorunitario.Enabled = False
        tbImporte.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btCargarXml.Click

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim myXMLfile As String = tbDescripcion.Text
            'Dim myXMLfile As String = My.Application.Info.DirectoryPath & "\XML.xml"
            Dim ds2 As New DataSet()
            'Dim columna As Integer = 4

            Try
                ds2.ReadXml(myXMLfile)
                Altafactura.dgvDetalles.DataSource = ds2
                'Altafactura.dgvDetalles.DataMember = "Emisor"
                Altafactura.dgvDetalles.DataMember = "Concepto"
                Altafactura.dgvDetalles.Columns(0).Width = 100
                Altafactura.dgvDetalles.Columns(1).Width = 100
                Altafactura.dgvDetalles.Columns(2).Width = 290

                btContinuar.Enabled = True

            Catch ex As Exception

                MessageBox.Show(ex.ToString())
            End Try

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            tbDescripcion.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btManual.Click

        'SE ELIMINAN LAS COLUMNAS
        For i As Integer = 0 To Altafactura.dgvDetalles.RowCount - 1
            Altafactura.dgvDetalles.Rows.Remove(Altafactura.dgvDetalles.CurrentRow)

        Next

        If Altafactura.dgvDetalles.ColumnCount > -1 Then
            Altafactura.dgvDetalles.Columns.Clear()
        End If

        'SE ACTIVAN LOS CONTROLES NECESARIOS PARA AGREGAR LOS SERVICIOS

        btCargarXml.Enabled = False
        btAgregar.Enabled = True
        btContinuar.Enabled = True
        tbCantidad.Enabled = True
        tbunidad.Enabled = True
        tbClave.Enabled = True
        tbDescripcion.Enabled = True
        tbValorunitario.Enabled = True
        tbImporte.Enabled = True

        'SE AGREGAN LOS NOMBRES DE LAS COLUMNAS DEL DATAGRID


        Dim Columnacantidad As New DataGridViewColumn
        Columnacantidad = New DataGridViewTextBoxColumn

        Altafactura.dgvDetalles.Columns.Add(Columnacantidad)

        Columnacantidad.HeaderText = "cantidad"
        Columnacantidad.Name = "cantidad"
        Columnacantidad.DataPropertyName = "CANTIDAD"
        Columnacantidad.Width = 100

        Dim Columnaunidad As New DataGridViewColumn
        Columnaunidad = New DataGridViewTextBoxColumn

        Altafactura.dgvDetalles.Columns.Add(Columnaunidad)

        Columnaunidad.HeaderText = "unidad"
        Columnaunidad.Name = "unidad"
        Columnaunidad.DataPropertyName = "UNIDAD"
        Columnaunidad.Width = 100

        Dim Columnaidentificacion As New DataGridViewColumn
        Columnaidentificacion = New DataGridViewTextBoxColumn

        Altafactura.dgvDetalles.Columns.Add(Columnaidentificacion)

        Columnaidentificacion.HeaderText = "noidentificacion"
        Columnaidentificacion.Name = "noidentificacion"
        Columnaidentificacion.DataPropertyName = "NOIDENTIFICACION"
        Columnaidentificacion.Width = 100

        Dim Columnadescripcion As New DataGridViewColumn
        Columnadescripcion = New DataGridViewTextBoxColumn

        Altafactura.dgvDetalles.Columns.Add(Columnadescripcion)

        Columnadescripcion.HeaderText = "descripcion"
        Columnadescripcion.Name = "descripcion"
        Columnadescripcion.DataPropertyName = "DESCRIPCION"
        Columnadescripcion.Width = 210

        Dim Columnavalorunitario As New DataGridViewColumn
        Columnavalorunitario = New DataGridViewTextBoxColumn

        Altafactura.dgvDetalles.Columns.Add(Columnavalorunitario)

        Columnavalorunitario.HeaderText = "valorUnitario"
        Columnavalorunitario.Name = "descripcion"
        Columnavalorunitario.DataPropertyName = "VALOR_UNITARIO"
        Columnavalorunitario.Width = 100

        Dim Columnaimporte As New DataGridViewColumn
        Columnaimporte = New DataGridViewTextBoxColumn

        Altafactura.dgvDetalles.Columns.Add(Columnaimporte)

        Columnaimporte.HeaderText = "importe"
        Columnaimporte.Name = "importe"
        Columnaimporte.DataPropertyName = "IMPORTE"
        Columnaimporte.Width = 100

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btXml.Click

        If Altafactura.dgvDetalles.ColumnCount > 0 Then
            Altafactura.dgvDetalles.Columns.Clear()
        End If

        btCargarXml.Enabled = True
        btAgregar.Enabled = False
        btContinuar.Enabled = True
        tbCantidad.Enabled = False
        tbunidad.Enabled = False
        tbClave.Enabled = False
        tbDescripcion.Enabled = False
        tbValorunitario.Enabled = False
        tbImporte.Enabled = False

    End Sub

    Private Sub btContinuar_Click(sender As Object, e As EventArgs) Handles btContinuar.Click
        'CAPTURAR_PARTIDAS.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Try

            Catch ex As Exception

            End Try
        End If
    End Sub

End Class

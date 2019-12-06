Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class ALTA_LICITACIONES

    Public cn As New SqlConnection
    Dim funciones As New BASEDATOS
    Dim Valida_licitacion As New Valida_Existe_Registro

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btImportar.Click

        Verificar.Visible = False
        lbEstatusdocumento.Visible = False

        Try
            Dim archivo As New OpenFileDialog

            archivo.Filter = "Archivo PDF|*.pdf"
            If archivo.ShowDialog = DialogResult.OK Then
                tbRutaarchivo.Text = archivo.FileName
                'ArchivoPDF.src = archivo.FileName
                'ArchivoPDF.Visible = True
                Verificar.Visible = True
                lbEstatusdocumento.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ALTA_LICITACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbProveedores.Enabled = False
        cbEjercicio.Enabled = False
        cbLicitaciones.Enabled = False
        tbLicitacion.Enabled = False
        tbImporte.Enabled = False
        dtpInicio.Enabled = False
        dtpFin.Enabled = False
        btImportar.Enabled = False
        btGuardar.Enabled = False
        Verificar.Visible = False
        lbEstatusdocumento.Visible = False
        'ArchivoPDF.Visible = False

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        cbProveedores.Enabled = True
        cbEjercicio.Enabled = True
        cbLicitaciones.Enabled = False
        tbLicitacion.Enabled = True
        tbImporte.Enabled = True
        dtpInicio.Enabled = True
        dtpFin.Enabled = True
        btImportar.Enabled = True
        btGuardar.Enabled = True

    End Sub

    Private Sub cbProveedores_Enter(sender As Object, e As EventArgs) Handles cbProveedores.Enter
        funciones.Llenarcatproveedores(cbProveedores)
    End Sub

    Private Sub cbejercicio_Enter(sender As Object, e As EventArgs) Handles cbejercicio.Enter
        funciones.LlenarComboanioejercicio(cbejercicio)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        Try
            If Valida_licitacion.Valida_Existe_Licitacion(cbProveedores.SelectedValue, tbLicitacion.Text) = False Then

                cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()

                'Se declaran las variables para guardar el pdf
                Dim rutaarchivo As String
                rutaarchivo = tbRutaarchivo.Text
                Dim ruta As New FileStream(rutaarchivo, FileMode.Open, FileAccess.Read)
                Dim binario(ruta.Length) As Byte
                ruta.Read(binario, 0, ruta.Length)
                ruta.Close()

                Dim consulta As String = "INSERT INTO CAT_LICITACIONES (ID_PROVEEDOR, ID_EJERCICIO, NOMBRE_LICITACION, IMPORTE, FECHA_INICIO, FECHA_FIN, DOCUMENTO, FECHA_AUDITORIA, ESTATUS)  VALUES (@ID_PROVEEDOR, @ID_EJERCICIO, @NOMBRE_LICITACION, @IMPORTE, @FECHA_INICIO, @FECHA_FIN, @DOCUMENTO, @FECHA_AUDITORIA, @ESTATUS)"
                Dim comm As New SqlCommand(consulta, cn)

                comm.Parameters.AddWithValue("@ID_PROVEEDOR", cbProveedores.SelectedValue)
                comm.Parameters.AddWithValue("@ID_EJERCICIO", cbejercicio.SelectedValue)
                comm.Parameters.AddWithValue("@NOMBRE_LICITACION", tbLicitacion.Text)
                comm.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(tbImporte.Text))
                comm.Parameters.AddWithValue("@FECHA_INICIO", dtpInicio.Value)
                comm.Parameters.AddWithValue("@FECHA_FIN", dtpFin.Value)
                comm.Parameters.AddWithValue("@DOCUMENTO", binario)
                comm.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)
                comm.Parameters.AddWithValue("@ESTATUS", Convert.ToInt16("1"))

                comm.ExecuteNonQuery()

                MessageBox.Show("Los datos se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cn.Close()
            Else
                MessageBox.Show("Existe una licitación para el proveedor con el mismo nombre, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Function convertirabytes(ByVal ruta As String) As Byte()
        Try
            Dim file As New FileStream(ruta, FileMode.Open)
            file.Position = 0
            Dim bytes(0 To file.Length - 1) As Byte
            file.Read(bytes, 0, file.Length)
            file.Close()
            'file.Delete(pth)
            Return bytes
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        Dim licitaciones As New CONSULTAR_LICITACIONES

        licitaciones.btEliminar.Enabled = False

        licitaciones.ShowDialog()

    End Sub

    Private Sub tbImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbImporte.KeyPress
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

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim licitaciones As New CONSULTAR_LICITACIONES

        licitaciones.btEliminar.Enabled = True

        licitaciones.ShowDialog()

    End Sub
End Class
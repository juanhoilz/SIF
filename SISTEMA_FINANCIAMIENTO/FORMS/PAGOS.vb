Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class PAGOS

    Public cn As New SqlConnection
    Public dr As SqlDataReader
    Dim funciones As New BUSQUEDAS_PAGOS
    Dim funciones_2 As New BASEDATOS
    Dim funciones_3 As New BUSQUEDAS_CLC
    Dim valida_pagos As New Valida_Existe_Registro

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        DateTime.DaysInMonth(2018, 12)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btValidar.Click

        Try

            Dim cn As New SqlConnection

            cn.ConnectionString = "Data Source=192.168.1.99\SQLSAACG;Initial Catalog=" & cbInstancia.Text & ";User ID=sa;Password=sql2005"

            cn.Open()

            'Dim resultado As Boolean = False
            Dim cmd As New SqlCommand

            cmd = New SqlCommand("Select *from TBL_Poliza WHERE poliza = '" & tbPoliza.Text & "'", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                MessageBox.Show("Póliza validada correctamente", "Valida información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El número de póliza no existe en la Base de Datos", "Valida información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            dr.Close()
        Catch
            MessageBox.Show("No pudo conectarse al servidor, intente de nuevo", "Estatus conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cbEjercicio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbInstancia.SelectionChangeCommitted
        Try

            Dim cn As New SqlConnection

            'Se sustituye el servidor en la cadena de conexión
            cn.ConnectionString = "Data Source=192.168.1.99\SQLSAACG;Initial Catalog= SACG0000000 ;User ID=sa;Password=sql2005"
            'cn.ConnectionString = "Data Source=.\SQLSAACG;Initial Catalog= SACG0000000 ;User ID=sa;Password=sql2005"
            cn.Open()

            Dim consulta As String = ("SELECT EntidadId,ESTADO+'  '+CAST(EJERCICIO AS VARCHAR(4)) as DESCRIPCION FROM SACGSYS.dbo.Entidad Where EntidadId = @parametro")

            Dim cmd As New SqlCommand(consulta, cn)

            cmd.Parameters.AddWithValue("@parametro", cbInstancia.Text.Substring(4, 7))

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read Then

                tbejercicio.Text = reader("DESCRIPCION")

            End If

            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cbEjercicio_Enter(sender As Object, e As EventArgs) Handles cbInstancia.Enter
        Try
            funciones_2.llenacomboejerciciosacg(cbInstancia)
        Catch
            MessageBox.Show("Servidor no disponible", "Estatus conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbInstancia.Enabled = False
            btValidar.Enabled = False
        End Try

    End Sub

    Private Sub PAGOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbEstatusdocumento.Visible = False
        Verificar.Visible = False
        dgvDetalleCLC.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvDetalleCLC.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        'funciones.llenacomboejerciciosacg(cbEjercicio)
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

        funciones.LlenardgvCLC(dgvDetalleCLC, cbRecurso.SelectedValue, tbCLC.Text)

        Dim Columna As Integer = 4
        Dim Total As Decimal



        For Each row As DataGridViewRow In dgvDetalleCLC.Rows
            Total += Val(row.Cells(Columna).Value)

        Next
        lbImporte.Text = Format(Total, "#,##0.00")

    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbRecurso.Enter
        funciones_3.Llenarcomboaniofolios(cbRecurso)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            If valida_pagos.Valida_Existe_pago(tbCLC.Text) = False Then

                If Convert.ToDecimal(lbImporte.Text) = Convert.ToDecimal(tbImportepoliza.Text) Then

                    cn = New SqlConnection(My.Settings.Conexionbd)
                    cn.Open()

                    Dim idFolio As Integer = 0

                    'For Each row As DataGridViewRow In dgvDetalleCLC.Rows

                    Dim guardapagos As String = "INSERT INTO TBL_FACTURAS_PAGOS (ID_FOLIOS, CLC,  CLC_SIAFF, FECHA_PAGO, INSTANCIA, POLIZA, IMPORTE_PAGO, IMPORTE_POLIZA, FECHA_AUDITORIA) VALUES (@ID_FOLIOS, @CLC,  @CLC_SIAFF, @FECHA_PAGO, @INSTANCIA, @POLIZA, @IMPORTE_PAGO, @IMPORTE_POLIZA, @FECHA_AUDITORIA) SELECT SCOPE_IDENTITY()"
                    Dim comguardapagos As New SqlCommand(guardapagos, cn)

                        comguardapagos.Parameters.AddWithValue("@ID_FOLIOS", Convert.ToInt16(cbRecurso.SelectedValue))
                        comguardapagos.Parameters.AddWithValue("@CLC", tbCLC.Text)
                        comguardapagos.Parameters.AddWithValue("@CLC_SIAFF", tbFolioSIAFF.Text)
                        comguardapagos.Parameters.AddWithValue("@FECHA_PAGO", dtpFechapago.Value)
                        comguardapagos.Parameters.AddWithValue("@INSTANCIA", "CAMPECHE 2018")
                        comguardapagos.Parameters.AddWithValue("@POLIZA", tbPoliza.Text)
                        comguardapagos.Parameters.AddWithValue("@IMPORTE_PAGO", Convert.ToDecimal(lbImporte.Text))
                        comguardapagos.Parameters.AddWithValue("@IMPORTE_POLIZA", Convert.ToDecimal(tbImportepoliza.Text))
                        comguardapagos.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                        idFolio = Convert.ToInt16(comguardapagos.ExecuteScalar)
                        tbFolio.Text = idFolio
                    'comguardapagos.ExecuteNonQuery()
                    'Next

                    For Each row As DataGridViewRow In dgvDetalleCLC.Rows

                        Dim actualizaestatus As String = "UPDATE FACTURAS set ID_ESTATUS = 3  Where ID_FACTURA = '" & row.Cells(0).Value & "' "
                        Dim comactualizaestatus As New SqlCommand(actualizaestatus, cn)
                        comactualizaestatus.ExecuteNonQuery()

                        Dim guardaestatus As String = "INSERT INTO FACTURAS_ESTATUS (ID_FACTURA, ID_ESTATUS, FECHA_AUDITORIA) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA_AUDITORIA)"
                        Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

                        comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(row.Cells("ID_FACTURA").Value))
                        comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", "3")
                        comguardaestatus.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                        comguardaestatus.ExecuteNonQuery()

                    Next

                    'Guardar los pdf

                    Dim rutaarchivo As String
                    rutaarchivo = tbRutaarchivo.Text
                    Dim ruta As New FileStream(rutaarchivo, FileMode.Open, FileAccess.Read)
                    Dim binario(ruta.Length) As Byte
                    ruta.Read(binario, 0, ruta.Length)
                    ruta.Close()

                    Dim consulta As String = "INSERT INTO TBL_FACTURAS_DOCUMENTOS (CLC, CLC_SIAFF, DOCUMENTO, FECHA_AUDITORIA) VALUES (@CLC, @CLC_SIAFF, @DOCUMENTO, @FECHA_AUDITORIA)"
                    Dim comm As New SqlCommand(consulta, cn)

                    comm.Parameters.AddWithValue("@CLC", tbCLC.Text)
                    comm.Parameters.AddWithValue("@CLC_SIAFF", tbFolioSIAFF.Text)
                    comm.Parameters.AddWithValue("@DOCUMENTO", binario)
                    comm.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                    comm.ExecuteNonQuery()



                    MessageBox.Show("Los registros se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    cn.Close()

                Else
                    If MessageBox.Show("Existen diferencia entre lo pagado y el importe de la póliza, está seguro que desea guardar?", "Verifica importe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cn = New SqlConnection(My.Settings.Conexionbd)
                        cn.Open()

                        Dim idFolio As Integer = 0

                        For Each row As DataGridViewRow In dgvDetalleCLC.Rows

                            Dim guardapagos As String = "INSERT INTO TBL_FACTURAS_PAGOS (ID_FOLIOS, CLC,  CLC_SIAFF, FECHA_PAGO, INSTANCIA, POLIZA, IMPORTE_PAGO, IMPORTE_POLIZA, FECHA_AUDITORIA) VALUES (@ID_FOLIOS, @CLC,  @CLC_SIAFF, @FECHA_PAGO, @INSTANCIA, @POLIZA, @IMPORTE_PAGO, @IMPORTE_POLIZA, @FECHA_AUDITORIA) SELECT SCOPE_IDENTITY()"
                            Dim comguardapagos As New SqlCommand(guardapagos, cn)

                            comguardapagos.Parameters.AddWithValue("@ID_FOLIOS", Convert.ToInt16(cbRecurso.SelectedValue))
                            comguardapagos.Parameters.AddWithValue("@CLC", tbCLC.Text)
                            comguardapagos.Parameters.AddWithValue("@CLC_SIAFF", tbFolioSIAFF.Text)
                            comguardapagos.Parameters.AddWithValue("@FECHA_PAGO", dtpFechapago.Value)
                            comguardapagos.Parameters.AddWithValue("@INSTANCIA", "CAMPECHE 2018")
                            comguardapagos.Parameters.AddWithValue("@POLIZA", tbPoliza.Text)
                            comguardapagos.Parameters.AddWithValue("@IMPORTE_PAGO", Convert.ToDecimal(lbImporte.Text))
                            comguardapagos.Parameters.AddWithValue("@IMPORTE_POLIZA", Convert.ToDecimal(tbImportepoliza.Text))
                            comguardapagos.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                            idFolio = Convert.ToInt16(comguardapagos.ExecuteScalar)
                            tbFolio.Text = idFolio

                        Next

                        For Each row As DataGridViewRow In dgvDetalleCLC.Rows

                            Dim actualizaestatus As String = "UPDATE FACTURAS set ID_ESTATUS = 3  Where ID_FACTURA = '" & row.Cells(0).Value & "' "
                            Dim comactualizaestatus As New SqlCommand(actualizaestatus, cn)
                            comactualizaestatus.ExecuteNonQuery()

                            Dim guardaestatus As String = "INSERT INTO TBL_FACTURAS_ESTATUS (ID_FACTURA, ID_ESTATUS, FECHA_AUDITORIA) VALUES (@ID_FACTURA, @ID_ESTATUS, @FECHA_AUDITORIA)"
                            Dim comguardaestatus As New SqlCommand(guardaestatus, cn)

                            comguardaestatus.Parameters.AddWithValue("@ID_FACTURA", Convert.ToInt16(row.Cells("ID_FACTURA").Value))
                            comguardaestatus.Parameters.AddWithValue("@ID_ESTATUS", "3")
                            comguardaestatus.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                            comguardaestatus.ExecuteNonQuery()

                        Next

                        'Guardar los pdf

                        Dim rutaarchivo As String
                        rutaarchivo = tbRutaarchivo.Text
                        Dim ruta As New FileStream(rutaarchivo, FileMode.Open, FileAccess.Read)
                        Dim binario(ruta.Length) As Byte
                        ruta.Read(binario, 0, ruta.Length)
                        ruta.Close()

                        Dim consulta As String = "INSERT INTO TBL_FACTURAS_DOCUMENTOS (CLC, CLC_SIAFF, DOCUMENTO, FECHA_AUDITORIA) VALUES (@CLC, @CLC_SIAFF, @DOCUMENTO, @FECHA_AUDITORIA)"
                        Dim comm As New SqlCommand(consulta, cn)

                        comm.Parameters.AddWithValue("@CLC", tbCLC.Text)
                        comm.Parameters.AddWithValue("@CLC_SIAFF", tbFolioSIAFF.Text)
                        comm.Parameters.AddWithValue("@DOCUMENTO", binario)
                        comm.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

                        comm.ExecuteNonQuery()

                        MessageBox.Show("Los registros se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        cn.Close()
                    Else
                        MessageBox.Show("No se guardaron los datos", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If

            Else
                MessageBox.Show("La cuenta por liquidar " & tbCLC.Text & " ya se registró como pagada anteriormente, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try

    End Sub

    Private Sub tbImportepoliza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbImportepoliza.KeyPress
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btImportar_Click(sender As Object, e As EventArgs) Handles btImportar.Click
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

    Private Sub tbRutaarchivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRutaarchivo.KeyPress

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        CONSULTAR_PAGOS.ShowDialog()
    End Sub
End Class
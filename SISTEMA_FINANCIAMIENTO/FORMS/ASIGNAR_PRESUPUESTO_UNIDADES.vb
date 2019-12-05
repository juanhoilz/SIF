Imports System.Data.SqlClient

Public Class CARGA_POA

    Dim funciones As New BASEDATOS
    Dim cn As New SqlConnection(My.Settings.Conexionbd)
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable



    Private Sub cbcapitulo_Enter(sender As Object, e As EventArgs) Handles cbcapitulo.Enter
        funciones.LlenarComboCapitulo(cbcapitulo)
    End Sub

    Private Sub Combox_cbsubcapitulo_Enter(sender As Object, e As EventArgs) Handles cbsubcapitulo.Enter

        If cbcapitulo.SelectedValue Then

            funciones.LlenarComboSubCapitulo(cbsubcapitulo, cbcapitulo)

        Else
            MessageBox.Show("FAVOR DE SELECCIONAR EL CAPITULO", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cbpartidas_Enter(sender As Object, e As EventArgs) Handles cbpartidas.Enter

        If cbsubcapitulo.SelectedValue Then

            funciones.LlenarComboPartidasPoa(cbpartidas, cbsubcapitulo)

        Else
            MessageBox.Show("FAVOR DE SELECCIONAR EL SUBCAPITULO", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub cbUnidades_Enter(sender As Object, e As EventArgs) Handles cbUnidades.Enter

        If cbRubro.SelectedValue = 7 Or cbRubro.SelectedValue = 10 Then

            funciones.UnidadesPorRubro(cbUnidades, cbRubro)

        Else

            funciones.LlenarComboUnidades(cbUnidades)

        End If


    End Sub

    Private Sub cbRubro_Enter(sender As Object, e As EventArgs) Handles cbRubro.Enter
        funciones.llenarcomborubro(cbRubro)
    End Sub


    Private Sub Combox_Ejercicio_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones.LlenarComboanioejercicio(cbEjercicio)
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        BusquedaRegistroPoa.ShowDialog()
    End Sub

    Private Sub cbRubro_Leave(sender As Object, e As EventArgs) Handles cbRubro.Leave
        cbRubro.Enabled = False
        cbEjercicio.Enabled = False
    End Sub

    Private Sub cbEjercicio_leave(sender As Object, e As EventArgs) Handles cbEjercicio.Leave
        'cbEjercicio.Enabled = False
    End Sub

    Private Sub cbUnidades_leave(sender As Object, e As EventArgs) Handles cbUnidades.Leave
        cbUnidades.Enabled = False
    End Sub

    Private Sub CARGA_POA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btbuscar.Enabled = False

    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltro.SelectedIndexChanged

        If cbFiltro.SelectedIndex = 1 Then
            btbuscar.Enabled = True

        End If
    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btbuscar.Click
        If cbpartidas.SelectedIndex < 0 Or cbcapitulo.SelectedIndex < 0 Or cbUnidades.SelectedIndex < 0 Or cbRubro.SelectedIndex < 0 Then
            MessageBox.Show("FAVOR DE VERIFICAR DATOS", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim adaptador As String
            Dim cn = New SqlConnection(My.Settings.Conexionbd)
            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand


            Com.Connection = cn
            cn.Open()

            adaptador = "Select IMPORTE_POA from TBL_RECURSOS_POA_SALDOS left join TBL_RECURSOS_POA On (TBL_RECURSOS_POA.ID = TBL_RECURSOS_POA_SALDOS.ID_SALDOS)
                                   Where TBL_RECURSOS_POA.UNIDAD_ID = '" & cbUnidades.SelectedValue & "' AND TBL_RECURSOS_POA.PARTIDA_ID = '" & cbpartidas.SelectedValue & "'"

            Com = New SqlCommand(adaptador, cn)

            Rs = Com.ExecuteReader()
            Rs.Read()

            tbImporte.Text = Rs(0) 'aca me pone el primer campo del select

            Rs.Close()

        End If

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click


        If cbpartidas.SelectedIndex < 0 Or cbcapitulo.SelectedIndex < 0 Or cbUnidades.SelectedIndex < 0 Or cbRubro.SelectedIndex < 0 Then
            MessageBox.Show("FAVOR DE VERIFICAR DATOS", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim VALOR As String
            VALOR = cbpartidas.SelectedValue

            Dim existe As Boolean = dgvUnidades.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("ID_PARTIDA").Value) = VALOR)

            If Not existe Then

                dgvUnidades.Rows.Add(cbcapitulo.SelectedValue, Mid(cbcapitulo.Text, 1, 4), cbsubcapitulo.SelectedValue, Mid(cbsubcapitulo.Text, 1, 4), cbpartidas.SelectedValue, Mid(cbpartidas.Text, 1, 5), Mid(cbpartidas.Text, 8, 100), tbImporte.Text, cbEjercicio.SelectedValue)

                Dim Total As Decimal
                Dim Columna As Integer = 7
                For Each row As DataGridViewRow In dgvUnidades.Rows
                    Total += Val(row.Cells(Columna).Value)
                Next
                tbTotal.Text = Format(Total, "#,##0.00")

            Else
                MessageBox.Show("LA PARTIDA YA HA SIDO SELECCIONADA, FAVOR DE VERIFICAR", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            tbImporte.Clear()

        End If


    End Sub

    Private Sub btGuardar_Click_1(sender As Object, e As EventArgs) Handles btGuardar.Click

        Dim VALOR As String
        VALOR = cbpartidas.SelectedValue

        Dim existe As Boolean = dgvUnidades.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("ID_PARTIDA").Value) = VALOR)

        If existe Then
            cn.Open()
            For Each row As DataGridViewRow In dgvUnidades.Rows

                Dim idpoa As Integer = 0

                Dim consulta As String = "INSERT INTO TBL_RECURSOS_POA (UNIDAD_ID, CAPITULO_ID,SUBCAPITULO_ID, PARTIDA_ID, IMPORTE, EJERCICIO, RUBRO_ID) VALUES (@ID_UNIDAD, @ID_CAPITULO, @ID_SUBCAPITULO, @ID_PARTIDA, @IMPORTE, @EJERCICIO, @ID_RUBRO) SELECT SCOPE_IDENTITY()"
                Dim comm As New SqlCommand(consulta, cn)

                comm.Parameters.AddWithValue("@ID_UNIDAD", cbUnidades.SelectedValue)
                comm.Parameters.AddWithValue("@ID_CAPITULO", cbcapitulo.SelectedValue)
                comm.Parameters.AddWithValue("@ID_SUBCAPITULO", cbsubcapitulo.SelectedValue)
                comm.Parameters.AddWithValue("@ID_PARTIDA", row.Cells("ID_PARTIDA").Value)
                comm.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(row.Cells("IMPORTE").Value))
                comm.Parameters.AddWithValue("@ID_RUBRO", cbRubro.SelectedValue)
                comm.Parameters.AddWithValue("@EJERCICIO", Convert.ToInt16(row.Cells("EJERCICIO").Value))


                idpoa = Convert.ToInt16(comm.ExecuteScalar)
                cbEjercicio.SelectedValue = idpoa
                'SE MODIFICO YA QUE PARA HACER EL UPDATE NO SE PODIA ACTULIZAR EL COMPROMETIDO YA QUE ERA VALOR NULO LO CUAL SE LE AGREGO
                'POR MONTO INICIAL A PAGADO-COMPROMETIDO Y SALDOS QUE SEAN IGUAL A 0
                Dim insertpoa As String = "INSERT INTO TBL_RECURSOS_POA_SALDOS (RECURSO_ID, IMPORTE_POA, PAGADO, COMPROMETIDO, SALDOS) VALUES (@Id, @Importe, @PAGADO, @COMPROMETIDO, @SALDOS)"
                Dim comm2 As New SqlCommand(insertpoa, cn)
                'If dgvfacturas.RowCount > 0 Then
                'For Each row As DataGridViewRow In dgvfacturas.Rows
                comm2.Parameters.AddWithValue("@Id", Convert.ToInt16(idpoa))
                comm2.Parameters.AddWithValue("@Importe", Convert.ToDecimal(row.Cells("IMPORTE").Value))
                comm2.Parameters.AddWithValue("@PAGADO", 0)
                comm2.Parameters.AddWithValue("@COMPROMETIDO", 0)
                comm2.Parameters.AddWithValue("@SALDOS", 0)
                comm2.ExecuteNonQuery()

            Next
            MessageBox.Show("Los datos se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cn.Close()
        Else
            MessageBox.Show("Agregar los datos a ingresar", "Valida registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

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


End Class
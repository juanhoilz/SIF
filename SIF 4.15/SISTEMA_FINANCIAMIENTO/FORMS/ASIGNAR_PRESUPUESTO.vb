Imports System.Data
Imports System.Data.SqlClient
Public Class ASIGNAR_PRESUPUESTO
    Dim funciones As New BASEDATOS
    Dim validacampos As New Validacampos
    Dim cn As New SqlConnection(My.Settings.Conexionbd)
    Private Sub cbUnidades_Enter(sender As Object, e As EventArgs) Handles cbUnidades.Enter
        'funciones.LlenarComboUnidadesfiltro(cbUnidades)

        If cbRubro.SelectedValue = 7 Or cbRubro.SelectedValue = 10 Then

            funciones.UnidadesPorRubro(cbUnidades, cbRubro)

        Else

            funciones.LlenarComboUnidades(cbUnidades)

        End If

    End Sub



    Private Sub cbJurisdiccion_Enter(sender As Object, e As EventArgs) Handles cbPartidas.Enter
        funciones.llenacombopartidas(cbPartidas)


    End Sub



    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If cbFiltro.SelectedIndex = 0 Then
            Dim VALOR As String

            VALOR = cbPartidas.SelectedValue

            Dim existe As Boolean = dgvUnidades.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("ID_PARTIDA").Value) = VALOR)

            If Not existe Then

                dgvUnidades.Rows.Add(cbUnidades.SelectedValue, cbEjercicio.Text, cbPartidas.SelectedValue, cbPartidas.Text, tbImporte.Text)

                Dim Total As Decimal
                Dim Columna As Integer = 4

                For Each row As DataGridViewRow In dgvUnidades.Rows
                    Total += Val(row.Cells(Columna).Value)

                Next

                tbTotal.Text = Format(Total, "#,##0.00")

            Else
                MessageBox.Show("La partida ya ha sido agregada, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf cbFiltro.SelectedIndex = 1 Then
            MessageBox.Show("PRUEBA", "Modificar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbFiltro.SelectedIndex = 2 Then
            MessageBox.Show("PRUEBA", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub cbUnidades_Leave(sender As Object, e As EventArgs) Handles cbUnidades.Leave
        cbUnidades.Enabled = False
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btGuardar_Click_1(sender As Object, e As EventArgs) Handles btGuardar.Click

        cn.Open()

        For Each row As DataGridViewRow In dgvUnidades.Rows

            Dim consulta As String = "INSERT INTO UNIDADES_RECURSOS (ID_UNIDAD, EJERCICIO, ID_PARTIDA, ID_RUBRO, IMPORTE) VALUES (@ID_UNIDAD, @EJERCICIO, @ID_PARTIDA, @ID_RUBRO, @IMPORTE)"

            Dim comm As New SqlCommand(consulta, cn)

            comm.Parameters.AddWithValue("@ID_UNIDAD", cbUnidades.SelectedValue)
            comm.Parameters.AddWithValue("@EJERCICIO", cbEjercicio.Text)
            comm.Parameters.AddWithValue("@ID_PARTIDA", row.Cells("ID_PARTIDA").Value)
            comm.Parameters.AddWithValue("@ID_RUBRO", cbRubro.SelectedValue)
            comm.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(row.Cells("IMPORTE").Value))

            comm.ExecuteNonQuery()

        Next

        MessageBox.Show("Los datos se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cn.Close()

    End Sub

    Private Sub cbRubro_Enter(sender As Object, e As EventArgs) Handles cbRubro.Enter
        funciones.llenarcomborubro(cbRubro)
    End Sub

    Private Sub cbRubro_Leave(sender As Object, e As EventArgs) Handles cbRubro.Leave
        cbRubro.Enabled = False
    End Sub

    Private Sub ASIGNAR_PRESUPUESTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbImporte_TextChanged(sender As Object, e As EventArgs) Handles tbImporte.TextChanged

    End Sub
End Class
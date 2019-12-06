
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml

Public Class INVENTARIO

    Public adaptador As New SqlDataAdapter
    Public cn As New SqlConnection
    Dim funciones As New BASEDATOS
    Dim Valida_Existe_serie As New valida_registro_serie
    Dim Valida_numero As New Validacampos
    Dim valida_numeros As New Validacampos

    Private Sub inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbInventario.CharacterCasing = CharacterCasing.Upper
        tbFoliofactura.CharacterCasing = CharacterCasing.Upper
        tbFoliofiscal.CharacterCasing = CharacterCasing.Upper
        tbserie.CharacterCasing = CharacterCasing.Upper
        tbidentificacion.CharacterCasing = CharacterCasing.Upper
        tbproducto.CharacterCasing = CharacterCasing.Upper
        tbComplemento.CharacterCasing = CharacterCasing.Upper
        tbresguardo.CharacterCasing = CharacterCasing.Upper
        tbPoliza.CharacterCasing = CharacterCasing.Upper
        tbobservacion.CharacterCasing = CharacterCasing.Upper
        'btAgregaconceptos.Enabled = False
        'cbLicitaciones.Enabled = True
        tbvalor.Text = "0.00"
        btguardar.Enabled = False
        btbuscar.Enabled = False
        btactualizar.Enabled = False
        lbDescripcion.Visible = False

        'funciones.Autocompletartextbox(tbdescripcion)
    End Sub


    'INICIO DE LLENADO DE COMBOBOX DEL FORMULARIO 


    Private Sub ComboBox1_Enter_1(sender As Object, e As EventArgs) Handles cbSubcapitulo.Enter

        funciones.LlenarComboSubCapitulo_Inv(cbSubcapitulo)

    End Sub
    Private Sub cbdescripcion_ENTER(sender As Object, e As EventArgs) Handles cbdescripcion.Enter
        funciones.LlenarCombodescripcion(cbdescripcion, cbGrupo)
    End Sub
    Private Sub ComboBox2_Enter_1(sender As Object, e As EventArgs) Handles cbResguardatario.Enter
        funciones.Llenarcombopersonal(cbResguardatario)
    End Sub


    Private Sub ComboBox3_Enter(sender As Object, e As EventArgs) Handles cbPartidas.Enter
        If cbSubcapitulo.SelectedValue Then
            funciones.LlenarComboPartidasPoa(cbPartidas, cbSubcapitulo)

        Else
            MessageBox.Show("FAVOR DE SELECCIONAR EL SUBCAPITULO", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub ComboBox2_Enter_3(sender As Object, e As EventArgs) Handles cbGrupo.Enter

        If cbPartidas.SelectedValue Then

            funciones.Llenarcombogrupo(cbGrupo, cbPartidas)

        Else
            MessageBox.Show("FAVOR DE SELECCIONAR LA PARTIDA", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cbEjercicio_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones.LlenarComboanioejercicio(cbEjercicio)

    End Sub


    Private Sub cbCuentas_Enter(sender As Object, e As EventArgs) Handles cbCuentas.Enter

        funciones.Llenarcomboejercicio(cbCuentas)

    End Sub

    Private Sub cbubicacion_enter(sender As Object, e As EventArgs) Handles cbubicacion.Enter
        funciones.LlenarComboUbicacion(cbubicacion)
    End Sub

    Private Sub cbtipoadquisicion_Enter(sender As Object, e As EventArgs) Handles cbtipoadq.Enter
        funciones.LlenarComboAdquisicion(cbtipoadq)

    End Sub

    Private Sub cblicitacion_enter(sender As Object, e As EventArgs) Handles cblicitacion.Enter

        If cbtipoadq.SelectedValue Then

            funciones.Llenarcombolicitacion2(cblicitacion, cbtipoadq)

        Else
            MessageBox.Show("FAVOR DE SELECCIONAR EL TIPO DE ADQUISICIÓN", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cbProveedores_Enter(sender As Object, e As EventArgs) Handles cbProveedores.Enter

        funciones.Llenarcatproveedores(cbProveedores)

    End Sub

    Private Sub cbmarca_Enter(sender As Object, e As EventArgs) Handles cbmarca.Enter
        If cbPartidas.SelectedValue Then

            funciones.LlenarComboMarca(cbmarca, cbPartidas)

        Else
            MessageBox.Show("FAVOR DE SELECCIONAR EL GRUPO CORRESPONDIENTE", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub cbmodelo_Enter(sender As Object, e As EventArgs) Handles cbmodelo.Enter
        If cbmarca.SelectedValue Then

            funciones.LlenarComboModelo(cbmodelo, cbSubcapitulo)
        Else
            MessageBox.Show("FAVOR DE SELECCIONAR LA MARCA DEL PRODUCTO", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    'FINALIZADO DE LOS LLENADOS DE COMBOBOX' 

    'ABRIR LA VENTANA PARA AGREGAR UNA DESCRIOCION DE PRODUCTO EN DADO CAS QUE NO EXISTA.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Producto.ShowDialog()
    End Sub
    Private Sub cbtipoadq_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbtipoadq.SelectionChangeCommitted
        If cbtipoadq.SelectedIndex = 0 Then
            cblicitacion.DataSource = Nothing
            cblicitacion.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        btbuscar.Enabled = True
        btactualizar.Enabled = False
        btagregar.Enabled = False
        dgvDetalles.DataSource = Nothing
        dgvDetalles.Rows.Clear()
        tbInventario.Text = ""
        tbserie.Text = ""
        tbobservacion.Text = ""
        chbetiquetado.Checked = False
        lbDescripcion.Text = ""
        lbDescripcion.Visible = False

    End Sub

    Private Sub chbSerie_CheckedChanged(sender As Object, e As EventArgs) Handles chbSerie.CheckedChanged

        If chbSerie.Checked = True Then
            tbserie.Enabled = False
            tbserie.Clear()
            tbserie.Text = "SIN NUMERO"
        Else
            tbserie.Enabled = True
            tbserie.Clear()
        End If

    End Sub


    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbvalor.KeyPress
        'validacampos.numerosdecimal(tbSubtotal, e)
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


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar = Convert.ToChar(13)) Then
            e.Handled = True
            'TextBox2.Focus()
        End If
    End Sub

    Private Sub cbProveedores_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        Try
            'Acer2017luis
            If tbInventario.Text <> "" Or tbserie.Text <> "" Then

                If chbSerie.Checked = False And chbInventario.Checked = False Then

                    If Valida_Existe_serie.Valida_Existe_Numero(tbInventario.Text) = False Then

                        If Valida_Existe_serie.Valida_Existe_serie(tbserie.Text) = False Then

                            'btguardar.Enabled = True
                            Dim etiquetado As String

                            If chbetiquetado.Checked = True Then
                                etiquetado = 1
                            Else
                                etiquetado = 0
                            End If

                            If tbInventario.TextLength = 0 Or tbFoliofactura.TextLength = 0 Or cbPartidas.SelectedIndex < 0 Or cbEjercicio.SelectedIndex < 0 Or cbCuentas.SelectedIndex < 0 Or cbubicacion.SelectedIndex < 0 Or cbProveedores.SelectedIndex < 0 Or cbtipoadq.SelectedIndex < 0 Or cbSubcapitulo.SelectedIndex < 0 Or tbserie.Text = "" Or tbidentificacion.Text = "" Or tbcantidad.Text = "" Or tbproducto.Text = "" Or tbvalor.Text = "" Or tbresguardo.Text = "" Or tbPoliza.Text = "" Then
                                MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else

                                'Validamos la duplicidad del numero de serie al agregar al datagridview

                                Dim VALOR As String
                                VALOR = tbserie.Text

                                Dim existe As Boolean = dgvDetalles.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("NoSERIE").Value) = VALOR)

                                Dim VALOR2 As String
                                VALOR2 = tbInventario.Text

                                Dim existe2 As Boolean = dgvDetalles.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("NO_INVENTARIO").Value) = VALOR2)

                                If Not existe And Not existe2 Then

                                    dgvDetalles.Rows.Add(tbInventario.Text, cbEjercicio.SelectedValue, cbEjercicio.Text, cbCuentas.SelectedValue, cbCuentas.Text, cbProveedores.SelectedValue, cbProveedores.Text, cbtipoadq.SelectedValue, cbtipoadq.Text, cblicitacion.SelectedValue, cblicitacion.Text, tbFoliofactura.Text, tbFoliofiscal.Text, dtpFechafactura.Value, DateTime.Now, cbubicacion.SelectedValue,
                                cbubicacion.Text, cbSubcapitulo.SelectedValue, Mid(cbSubcapitulo.Text, 1, 5), cbPartidas.SelectedValue, Mid(cbPartidas.Text, 1, 5), cbGrupo.SelectedValue, cbGrupo.Text, cbmarca.SelectedValue, cbmarca.Text, cbmodelo.SelectedValue, cbmodelo.Text, tbserie.Text, tbidentificacion.Text, tbcantidad.Text, tbunidad.Text, tbproducto.Text, cbdescripcion.Text, tbComplemento.Text, tbvalor.Text, tbresguardo.Text, cbResguardatario.SelectedValue, cbResguardatario.Text, tbobservacion.Text, etiquetado, tbPoliza.Text)

                                    btguardar.Enabled = True

                                    tbInventario.Text = ""
                                    tbserie.Text = ""
                                    tbobservacion.Text = ""
                                    tbvalor.Text = ""
                                    tbresguardo.Text = ""
                                    tbPoliza.Text = ""
                                    tbcantidad.Text = ""
                                    tbidentificacion.Text = ""
                                    tbproducto.Text = ""
                                    tbComplemento.Text = ""
                                    cbProveedores.DataSource = Nothing
                                    cbProveedores.Text = ""
                                    cbCuentas.DataSource = Nothing
                                    cbCuentas.Text = ""
                                    cbtipoadq.DataSource = Nothing
                                    cbtipoadq.Text = ""
                                    cblicitacion.DataSource = Nothing
                                    cblicitacion.Text = ""
                                    cbubicacion.DataSource = Nothing
                                    cbubicacion.Text = ""
                                    cbSubcapitulo.DataSource = Nothing
                                    cbSubcapitulo.Text = ""
                                    cbPartidas.DataSource = Nothing
                                    cbPartidas.Text = ""
                                    cbGrupo.DataSource = Nothing
                                    cbGrupo.Text = ""
                                    cbmarca.DataSource = Nothing
                                    cbmarca.Text = ""
                                    cbmodelo.DataSource = Nothing
                                    cbmodelo.Text = ""
                                    cbdescripcion.DataSource = Nothing
                                    cbdescripcion.Text = ""
                                    cbResguardatario.DataSource = Nothing
                                    cbResguardatario.Text = ""
                                    chbetiquetado.Checked = False
                                    chbSerie.Checked = False
                                    chbInventario.Checked = False
                                    cbidentificacion.Checked = False
                                    CheckBox3.Checked = False
                                    CheckBox5.Checked = False
                                    CheckBox4.Checked = False

                                Else
                                    MessageBox.Show("El número de serie o número de inventario ya han sido agregado, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                End If

                                'Validamos la duplicidad del numero de inventario al agregar al datagridview

                                ' If Not existe2 Then

                                'dgvDetalles.Rows.Add(tbInventario.Text, cbEjercicio.SelectedValue, cbEjercicio.Text, cbCuentas.SelectedValue, cbCuentas.Text, cbProveedores.SelectedValue, cbProveedores.Text, cbtipoadq.SelectedValue, cbtipoadq.Text, cblicitacion.SelectedValue, cblicitacion.Text, tbFoliofactura.Text, tbFoliofiscal.Text, dtpFechafactura.Value, DateTime.Now, cbubicacion.SelectedValue,
                                'cbubicacion.Text, cbSubcapitulo.SelectedValue, Mid(cbSubcapitulo.Text, 1, 5), cbPartidas.SelectedValue, Mid(cbPartidas.Text, 1, 5), cbGrupo.SelectedValue, cbGrupo.Text, cbmarca.SelectedValue, cbmarca.Text, cbmodelo.SelectedValue, cbmodelo.Text, tbserie.Text, tbidentificacion.Text, tbcantidad.Text, tbunidad.Text, tbproducto.Text, cbdescripcion.Text, tbComplemento.Text, tbvalor.Text, tbresguardo.Text, cbResguardatario.SelectedValue, cbResguardatario.Text, tbobservacion.Text, etiquetado, tbPoliza.Text)
                                'Else
                                'MessageBox.Show("El número de inventario ya ha sido agregado, favor de verificar C", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                'End If

                            End If

                        Else MessageBox.Show("El numero de serie ya se encuentra en el sistema, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            btguardar.Enabled = False
                            btagregar.Focus()
                        End If
                    Else
                        MessageBox.Show("El numero de inventario ya se encuentra en el sistema, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        btguardar.Enabled = False
                        btagregar.Focus()

                    End If

                ElseIf chbSerie.Checked = True And chbInventario.Checked = True Then

                    'btguardar.Enabled = True
                    Dim etiquetado As String

                    If chbetiquetado.Checked = True Then
                        etiquetado = 1
                    Else
                        etiquetado = 0
                    End If
                    If chbSerie.Checked = True Then
                        tbserie.SelectedText = "S/N"
                    End If

                    If tbInventario.TextLength = 0 Or tbFoliofactura.TextLength = 0 Or cbPartidas.SelectedIndex < 0 Or cbEjercicio.SelectedIndex < 0 Or cbCuentas.SelectedIndex < 0 Or cbubicacion.SelectedIndex < 0 Or cbProveedores.SelectedIndex < 0 Or cbtipoadq.SelectedIndex < 0 Or cbSubcapitulo.SelectedIndex < 0 Or tbidentificacion.Text = "" Or tbcantidad.Text = "" Or tbproducto.Text = "" Or tbvalor.Text = "" Or tbresguardo.Text = "" Or tbPoliza.Text = "" Then
                        MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else

                        dgvDetalles.Rows.Add(tbInventario.Text, cbEjercicio.SelectedValue, cbEjercicio.Text, cbCuentas.SelectedValue, cbCuentas.Text, cbProveedores.SelectedValue, cbProveedores.Text, cbtipoadq.SelectedValue, cbtipoadq.Text, cblicitacion.SelectedValue, cblicitacion.Text, tbFoliofactura.Text, tbFoliofiscal.Text, dtpFechafactura.Value, DateTime.Now, cbubicacion.SelectedValue,
                        cbubicacion.Text, cbSubcapitulo.SelectedValue, Mid(cbSubcapitulo.Text, 1, 5), cbPartidas.SelectedValue, Mid(cbPartidas.Text, 1, 5), cbGrupo.SelectedValue, cbGrupo.Text, cbmarca.SelectedValue, cbmarca.Text, cbmodelo.SelectedValue, cbmodelo.Text, tbserie.Text, tbidentificacion.Text, tbcantidad.Text, tbunidad.Text, tbproducto.Text, cbdescripcion.Text, tbComplemento.Text, tbvalor.Text, tbresguardo.Text, cbResguardatario.SelectedValue, cbResguardatario.Text, tbobservacion.Text, etiquetado, tbPoliza.Text)

                        chbSerie.Checked = False
                        chbInventario.Checked = False
                        btguardar.Enabled = True
                        tbInventario.Text = ""
                        tbserie.Text = ""
                        tbobservacion.Text = ""
                        tbvalor.Text = ""
                        tbresguardo.Text = ""
                        tbPoliza.Text = ""
                        tbcantidad.Text = ""
                        tbidentificacion.Text = ""
                        tbproducto.Text = ""
                        tbComplemento.Text = ""
                        cbProveedores.DataSource = Nothing
                        cbProveedores.Text = ""
                        cbCuentas.DataSource = Nothing
                        cbCuentas.Text = ""
                        cbtipoadq.DataSource = Nothing
                        cbtipoadq.Text = ""
                        cblicitacion.DataSource = Nothing
                        cblicitacion.Text = ""
                        cbubicacion.DataSource = Nothing
                        cbubicacion.Text = ""
                        cbSubcapitulo.DataSource = Nothing
                        cbSubcapitulo.Text = ""
                        cbPartidas.DataSource = Nothing
                        cbPartidas.Text = ""
                        cbGrupo.DataSource = Nothing
                        cbGrupo.Text = ""
                        cbmarca.DataSource = Nothing
                        cbmarca.Text = ""
                        cbmodelo.DataSource = Nothing
                        cbmodelo.Text = ""
                        cbdescripcion.DataSource = Nothing
                        cbdescripcion.Text = ""
                        cbResguardatario.DataSource = Nothing
                        cbResguardatario.Text = ""
                        chbetiquetado.Checked = False
                        chbSerie.Checked = False
                        chbInventario.Checked = False
                        cbidentificacion.Checked = False
                        CheckBox3.Checked = False
                        CheckBox5.Checked = False
                        CheckBox4.Checked = False

                    End If

                ElseIf chbSerie.Checked = False And chbInventario.Checked = True Then

                    If Valida_Existe_serie.Valida_Existe_serie(tbserie.Text) = False Then

                        'btguardar.Enabled = True
                        Dim etiquetado As String

                        If chbetiquetado.Checked = True Then
                            etiquetado = 1
                        Else
                            etiquetado = 0
                        End If

                        If tbInventario.TextLength = 0 Or tbFoliofactura.TextLength = 0 Or cbPartidas.SelectedIndex < 0 Or cbEjercicio.SelectedIndex < 0 Or cbCuentas.SelectedIndex < 0 Or cbubicacion.SelectedIndex < 0 Or cbProveedores.SelectedIndex < 0 Or cbtipoadq.SelectedIndex < 0 Or cbSubcapitulo.SelectedIndex < 0 Or tbserie.Text = "" Or tbidentificacion.Text = "" Or tbcantidad.Text = "" Or tbproducto.Text = "" Or tbvalor.Text = "" Or tbresguardo.Text = "" Or tbPoliza.Text = "" Then
                            MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            Dim VALOR As String
                            VALOR = tbserie.Text

                            Dim existe As Boolean = dgvDetalles.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("NoSERIE").Value) = VALOR)

                            If Not existe Then

                                dgvDetalles.Rows.Add(tbInventario.Text, cbEjercicio.SelectedValue, cbEjercicio.Text, cbCuentas.SelectedValue, cbCuentas.Text, cbProveedores.SelectedValue, cbProveedores.Text, cbtipoadq.SelectedValue, cbtipoadq.Text, cblicitacion.SelectedValue, cblicitacion.Text, tbFoliofactura.Text, tbFoliofiscal.Text, dtpFechafactura.Value, DateTime.Now, cbubicacion.SelectedValue,
                            cbubicacion.Text, cbSubcapitulo.SelectedValue, Mid(cbSubcapitulo.Text, 1, 5), cbPartidas.SelectedValue, Mid(cbPartidas.Text, 1, 5), cbGrupo.SelectedValue, cbGrupo.Text, cbmarca.SelectedValue, cbmarca.Text, cbmodelo.SelectedValue, cbmodelo.Text, tbserie.Text, tbidentificacion.Text, tbcantidad.Text, tbunidad.Text, tbproducto.Text, cbdescripcion.Text, tbComplemento.Text, tbvalor.Text, tbresguardo.Text, cbResguardatario.SelectedValue, cbResguardatario.Text, tbobservacion.Text, etiquetado, tbPoliza.Text)

                                chbInventario.Checked = False
                                btguardar.Enabled = True

                                tbInventario.Text = ""
                                tbserie.Text = ""
                                tbobservacion.Text = ""
                                tbvalor.Text = ""
                                tbresguardo.Text = ""
                                tbPoliza.Text = ""
                                tbcantidad.Text = ""
                                tbidentificacion.Text = ""
                                tbproducto.Text = ""
                                tbComplemento.Text = ""
                                cbProveedores.DataSource = Nothing
                                cbProveedores.Text = ""
                                cbCuentas.DataSource = Nothing
                                cbCuentas.Text = ""
                                cbtipoadq.DataSource = Nothing
                                cbtipoadq.Text = ""
                                cblicitacion.DataSource = Nothing
                                cblicitacion.Text = ""
                                cbubicacion.DataSource = Nothing
                                cbubicacion.Text = ""
                                cbSubcapitulo.DataSource = Nothing
                                cbSubcapitulo.Text = ""
                                cbPartidas.DataSource = Nothing
                                cbPartidas.Text = ""
                                cbGrupo.DataSource = Nothing
                                cbGrupo.Text = ""
                                cbmarca.DataSource = Nothing
                                cbmarca.Text = ""
                                cbmodelo.DataSource = Nothing
                                cbmodelo.Text = ""
                                cbdescripcion.DataSource = Nothing
                                cbdescripcion.Text = ""
                                cbResguardatario.DataSource = Nothing
                                cbResguardatario.Text = ""
                                chbetiquetado.Checked = False
                                chbSerie.Checked = False
                                chbInventario.Checked = False
                                cbidentificacion.Checked = False
                                CheckBox3.Checked = False
                                CheckBox5.Checked = False
                                CheckBox4.Checked = False

                            Else
                                MessageBox.Show("Ya ha agregado el número de serie, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If

                        End If

                    Else MessageBox.Show("El numero de serie ya se encuentra dentro del inventario, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        btguardar.Enabled = False
                        btagregar.Focus()
                    End If

                ElseIf chbSerie.Checked = True And chbInventario.Checked = False Then

                    If Valida_Existe_serie.Valida_Existe_Numero(tbInventario.Text) = False Then

                        'btguardar.Enabled = True
                        Dim etiquetado As String

                        If chbetiquetado.Checked = True Then
                            etiquetado = 1
                        Else
                            etiquetado = 0
                        End If

                        If tbInventario.TextLength = 0 Or tbFoliofactura.TextLength = 0 Or cbPartidas.SelectedIndex < 0 Or cbEjercicio.SelectedIndex < 0 Or cbCuentas.SelectedIndex < 0 Or cbubicacion.SelectedIndex < 0 Or cbProveedores.SelectedIndex < 0 Or cbtipoadq.SelectedIndex < 0 Or cbSubcapitulo.SelectedIndex < 0 Or tbidentificacion.Text = "" Or tbcantidad.Text = "" Or tbproducto.Text = "" Or tbvalor.Text = "" Or tbresguardo.Text = "" Or tbPoliza.Text = "" Then
                            MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            Dim VALOR As String
                            VALOR = tbInventario.Text

                            Dim existe As Boolean = dgvDetalles.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("NO_INVENTARIO").Value) = VALOR)


                            If Not existe Then

                                dgvDetalles.Rows.Add(tbInventario.Text, cbEjercicio.SelectedValue, cbEjercicio.Text, cbCuentas.SelectedValue, cbCuentas.Text, cbProveedores.SelectedValue, cbProveedores.Text, cbtipoadq.SelectedValue, cbtipoadq.Text, cblicitacion.SelectedValue, cblicitacion.Text, tbFoliofactura.Text, tbFoliofiscal.Text, dtpFechafactura.Value, DateTime.Now, cbubicacion.SelectedValue,
                            cbubicacion.Text, cbSubcapitulo.SelectedValue, Mid(cbSubcapitulo.Text, 1, 5), cbPartidas.SelectedValue, Mid(cbPartidas.Text, 1, 5), cbGrupo.SelectedValue, cbGrupo.Text, cbmarca.SelectedValue, cbmarca.Text, cbmodelo.SelectedValue, cbmodelo.Text, tbserie.Text, tbidentificacion.Text, tbcantidad.Text, tbunidad.Text, tbproducto.Text, cbdescripcion.Text, tbComplemento.Text, tbvalor.Text, tbresguardo.Text, cbResguardatario.SelectedValue, cbResguardatario.Text, tbobservacion.Text, etiquetado, tbPoliza.Text)

                                chbSerie.Checked = False
                                btguardar.Enabled = True
                                tbInventario.Text = ""
                                tbserie.Text = ""
                                tbobservacion.Text = ""
                                tbvalor.Text = ""
                                tbresguardo.Text = ""
                                tbPoliza.Text = ""
                                tbcantidad.Text = ""
                                tbidentificacion.Text = ""
                                tbproducto.Text = ""
                                tbComplemento.Text = ""
                                cbProveedores.DataSource = Nothing
                                cbProveedores.Text = ""
                                cbCuentas.DataSource = Nothing
                                cbCuentas.Text = ""
                                cbtipoadq.DataSource = Nothing
                                cbtipoadq.Text = ""
                                cblicitacion.DataSource = Nothing
                                cblicitacion.Text = ""
                                cbubicacion.DataSource = Nothing
                                cbubicacion.Text = ""
                                cbSubcapitulo.DataSource = Nothing
                                cbSubcapitulo.Text = ""
                                cbPartidas.DataSource = Nothing
                                cbPartidas.Text = ""
                                cbGrupo.DataSource = Nothing
                                cbGrupo.Text = ""
                                cbmarca.DataSource = Nothing
                                cbmarca.Text = ""
                                cbmodelo.DataSource = Nothing
                                cbmodelo.Text = ""
                                cbdescripcion.DataSource = Nothing
                                cbdescripcion.Text = ""
                                cbResguardatario.DataSource = Nothing
                                cbResguardatario.Text = ""
                                chbetiquetado.Checked = False
                                chbSerie.Checked = False
                                chbInventario.Checked = False
                                cbidentificacion.Checked = False
                                CheckBox3.Checked = False
                                CheckBox5.Checked = False
                                CheckBox4.Checked = False

                            Else
                                MessageBox.Show("El número de inventario ya ha sido agregado, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If

                        End If

                    Else
                        MessageBox.Show("El numero de inventario ya se encuentra en el sistema, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        btguardar.Enabled = False
                        btagregar.Focus()

                    End If

                End If

            Else
                MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()

        End Try

    End Sub

    Private Sub btguardar_Click_1(sender As Object, e As EventArgs) Handles btguardar.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        For Each row As DataGridViewRow In dgvDetalles.Rows


            Dim guardadetalles As String = "INSERT INTO TBL_INVENTARIO (NUM_INVENTARIO, EJERCICIO_ID, FUENTE_ID, PROVEEDOR_ID, ADQUISICION_ID, LICITACION_ID, FOLIO_FACTURA, FOLIO_FISCAL, FECHA_FACTURA, FECHA_CAPTURA, UBICACION_ID, SUBCAPITULO_ID, PARTIDAS_ID, GRUPO_ID, MARCA_ID, MODELO_ID, NoSERIE, NoIDENTIFICACION, CLAVE_PRODUCTO, DESCRIPCION, DESCRIPCION_COMPLEMENTO, UNIDAD, CANTIDAD, VALOR, No_RESGUARDO, RESGUARDATORIO_ID, OBSERVACIONES, ETIQUETADO, POLIZA, ID_USUARIO, FECHA_AUDITORIA) 
                                            VALUES (@NUM_INVENTARIO, @EJERCICIO_ID, @FUENTE_ID, @PROVEEDOR_ID, @ADQUISICION_ID, @LICITACION_ID, @FOLIO_FACTURA, @FOLIO_FISCAL, @FECHA_FACTURA, @FECHA_CAPTURA, @UBICACION_ID, @SUBCAPITULO_ID, @PARTIDAS_ID, @GRUPO_ID, @MARCA_ID, @MODELO_ID, @NoSERIE, @NoIDENTIFICACION, @CLAVE_PRODUCTO, @DESCRIPCION, @DESCRIPCION_COMPLEMENTO, @UNIDAD, @CANTIDAD, @VALOR, @No_RESGUARDO, @RESGUARDATORIO_ID, @OBSERVACIONES, @ETIQUETADO, @POLIZA, @ID_USUARIO, @FECHA_AUDITORIA)"
            Dim comm As New SqlCommand(guardadetalles, cn)

            comm.Parameters.AddWithValue("@NUM_INVENTARIO", row.Cells("NO_INVENTARIO").Value)
            comm.Parameters.AddWithValue("@EJERCICIO_ID", Convert.ToInt16(row.Cells("ID_EJERCICIO").Value))
            comm.Parameters.AddWithValue("@FUENTE_ID", Convert.ToInt16(row.Cells("ID_FUENTE").Value))
            comm.Parameters.AddWithValue("@PROVEEDOR_ID", Convert.ToInt16(row.Cells("ID_PROVEEDOR").Value))
            comm.Parameters.AddWithValue("@ADQUISICION_ID", Convert.ToInt16(row.Cells("ID_TIPO_ADQUISICION").Value))
            comm.Parameters.AddWithValue("@LICITACION_ID", Convert.ToInt16(row.Cells("ID_LICITACION").Value))
            comm.Parameters.AddWithValue("@FOLIO_FACTURA", row.Cells("FACTURA").Value)
            comm.Parameters.AddWithValue("@FOLIO_FISCAL", row.Cells("FOLIOFISCAL").Value)
            comm.Parameters.AddWithValue("@FECHA_FACTURA", row.Cells("FECHAFACTURA").Value)
            comm.Parameters.AddWithValue("@FECHA_CAPTURA", row.Cells("FECHACAPTURA").Value)
            comm.Parameters.AddWithValue("@UBICACION_ID", Convert.ToInt16(row.Cells("ID_UBICACION").Value))
            comm.Parameters.AddWithValue("@SUBCAPITULO_ID", Convert.ToInt16(row.Cells("ID_SUBCAPITULO").Value))
            comm.Parameters.AddWithValue("@PARTIDAS_ID", Convert.ToInt16(row.Cells("ID_PARTIDA").Value))
            comm.Parameters.AddWithValue("@GRUPO_ID", Convert.ToInt16(row.Cells("ID_GRUPO").Value))
            comm.Parameters.AddWithValue("@MARCA_ID", Convert.ToInt16(row.Cells("ID_MARCA").Value))
            comm.Parameters.AddWithValue("@MODELO_ID", Convert.ToInt16(row.Cells("ID_MODELO").Value))
            comm.Parameters.AddWithValue("@NoSERIE", row.Cells("NoSERIE").Value)
            comm.Parameters.AddWithValue("@NoIDENTIFICACION", row.Cells("NoIDENTIFICACION").Value)
            comm.Parameters.AddWithValue("@CLAVE_PRODUCTO", row.Cells("CLAVEPRODUCTO").Value)
            comm.Parameters.AddWithValue("@DESCRIPCION", row.Cells("DESCRIPCION").Value)
            comm.Parameters.AddWithValue("@DESCRIPCION_COMPLEMENTO", row.Cells("DESCRIPCION_COMPLEMENTO").Value)
            comm.Parameters.AddWithValue("@UNIDAD", row.Cells("UNIDAD").Value)
            comm.Parameters.AddWithValue("@CANTIDAD", row.Cells("CANTIDAD").Value)
            comm.Parameters.AddWithValue("@VALOR", Convert.ToDecimal(row.Cells("VALOR").Value))
            comm.Parameters.AddWithValue("@No_RESGUARDO", row.Cells("NoRESGUARDO").Value)
            comm.Parameters.AddWithValue("@RESGUARDATORIO_ID", Convert.ToInt16(row.Cells("ID_RESGUARDATORIO").Value))
            comm.Parameters.AddWithValue("@OBSERVACIONES", row.Cells("OBSERVACIONES").Value)
            comm.Parameters.AddWithValue("@ETIQUETADO", row.Cells("ETIQUETADO").Value)
            comm.Parameters.AddWithValue("@POLIZA", row.Cells("POLIZA").Value)
            comm.Parameters.AddWithValue("@ID_USUARIO", PRINCIPAL.tsUsuario.Text)
            comm.Parameters.AddWithValue("@FECHA_AUDITORIA", DateTime.Now)

            comm.ExecuteNonQuery()

        Next
        MessageBox.Show("Los datos se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'dgvDetalles.Columns.Clear()
        dgvDetalles.DataSource = Nothing
        dgvDetalles.Rows.Clear()
        tbInventario.Text = ""
        tbserie.Text = ""
        tbobservacion.Text = ""
        chbetiquetado.Checked = False
        btguardar.Enabled = False
        chbSerie.Checked = False
        chbInventario.Checked = False

    End Sub


    'BOTON DE ACTUALIZAR LOS DATOS EN CASO DE OCURRIR UN CAMBIO TOMANDO REFERENCIA EN NUMERO DE INVENTARIO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btactualizar.Click

        Dim etiquetado As String

        If chbetiquetado.Checked = True Then
            etiquetado = 1
        Else
            etiquetado = 0
        End If

        If chbSerie.Checked = True Then

            tbserie.SelectedText = "S/N"

        End If
        If tbFoliofactura.TextLength = 0 Or cbPartidas.SelectedIndex < 0 Or cbEjercicio.SelectedIndex < 0 Or cbCuentas.SelectedIndex < 0 Or cbubicacion.SelectedIndex < 0 Or cbProveedores.SelectedIndex < 0 Or cbtipoadq.SelectedIndex < 0 Or cbSubcapitulo.SelectedIndex < 0 Or tbidentificacion.Text = "" Or tbcantidad.Text = "" Or tbproducto.Text = "" Or tbvalor.Text = "" Or tbresguardo.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos para poder continuar", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                cn = New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim actualizainv As String = "UPDATE TBL_INVENTARIO SET NUM_INVENTARIO=@NUM_INVENTARIO, EJERCICIO_ID=@EJERCICIO_ID,FUENTE_ID= @FUENTE_ID,PROVEEDOR_ID= @PROVEEDOR_ID, ADQUISICION_ID=@ADQUISICION_ID, LICITACION_ID=@LICITACION_ID,FOLIO_FACTURA=@FOLIO_FACTURA,FOLIO_FISCAL= @FOLIO_FISCAL, FECHA_FACTURA=@FECHA_FACTURA,FECHA_CAPTURA =@FECHA_CAPTURA, UBICACION_ID=@UBICACION_ID,SUBCAPITULO_ID= @SUBCAPITULO_ID,PARTIDAS_ID= @PARTIDAS_ID,GRUPO_ID= @GRUPO_ID, 
                                MARCA_ID=@MARCA_ID,MODELO_ID= @MODELO_ID, NoSERIE=@NoSERIE, NoIDENTIFICACION=@NoIDENTIFICACION, CLAVE_PRODUCTO=@CLAVE_PRODUCTO, DESCRIPCION=@DESCRIPCION, DESCRIPCION_COMPLEMENTO=@DESCRIPCION_COMPLEMENTO ,UNIDAD= @UNIDAD,CANTIDAD= @CANTIDAD, VALOR=@VALOR, No_RESGUARDO=@No_RESGUARDO, RESGUARDATORIO_ID=@RESGUARDATORIO_ID,OBSERVACIONES= @OBSERVACIONES,ETIQUETADO= @ETIQUETADO,POLIZA= @POLIZA, ID_USUARIO_ACTUALIZA=@ID_USUARIO_ACTUALIZA, FECHA_ACTUALIZA = @FECHA_ACTUALIZA
                                           where NUM_INVENTARIO = '" & tbInventario.Text & "'"

                Dim comm As New SqlCommand(actualizainv, cn)

                comm.Parameters.AddWithValue("@NUM_INVENTARIO", tbInventario.Text)
                comm.Parameters.AddWithValue("@EJERCICIO_ID", Convert.ToInt16(cbEjercicio.SelectedValue))
                comm.Parameters.AddWithValue("@FUENTE_ID", Convert.ToInt16(cbCuentas.SelectedValue))
                comm.Parameters.AddWithValue("@PROVEEDOR_ID", Convert.ToInt16(cbProveedores.SelectedValue))
                comm.Parameters.AddWithValue("@ADQUISICION_ID", Convert.ToInt16(cbtipoadq.SelectedValue))
                comm.Parameters.AddWithValue("@LICITACION_ID", Convert.ToInt16(cblicitacion.SelectedValue))
                comm.Parameters.AddWithValue("@FOLIO_FACTURA", tbFoliofactura.Text)
                comm.Parameters.AddWithValue("@FOLIO_FISCAL", tbFoliofiscal.Text)
                comm.Parameters.AddWithValue("@FECHA_FACTURA", dtpFechafactura.Text)
                comm.Parameters.AddWithValue("@FECHA_CAPTURA", dtpFecharecepcion.Text)
                comm.Parameters.AddWithValue("@UBICACION_ID", Convert.ToInt16(cbubicacion.SelectedValue))
                comm.Parameters.AddWithValue("@SUBCAPITULO_ID", Convert.ToInt16(cbSubcapitulo.SelectedValue))
                comm.Parameters.AddWithValue("@PARTIDAS_ID", Convert.ToInt16(cbPartidas.SelectedValue))
                comm.Parameters.AddWithValue("@GRUPO_ID", Convert.ToInt16(cbGrupo.SelectedValue))
                comm.Parameters.AddWithValue("@MARCA_ID", Convert.ToInt16(cbmarca.SelectedValue))
                comm.Parameters.AddWithValue("@MODELO_ID", Convert.ToInt16(cbmodelo.SelectedValue))
                comm.Parameters.AddWithValue("@NoSERIE", tbserie.Text)
                comm.Parameters.AddWithValue("@NoIDENTIFICACION", tbidentificacion.Text)
                comm.Parameters.AddWithValue("@CLAVE_PRODUCTO", tbproducto.Text)
                comm.Parameters.AddWithValue("@DESCRIPCION", cbdescripcion.Text)
                comm.Parameters.AddWithValue("@DESCRIPCION_COMPLEMENTO", tbComplemento.Text)
                comm.Parameters.AddWithValue("@UNIDAD", tbunidad.Text)
                comm.Parameters.AddWithValue("@CANTIDAD", tbcantidad.Text)
                comm.Parameters.AddWithValue("@VALOR", Convert.ToDecimal(tbvalor.Text))
                comm.Parameters.AddWithValue("@No_RESGUARDO", tbresguardo.Text)
                comm.Parameters.AddWithValue("@RESGUARDATORIO_ID", Convert.ToInt16(cbResguardatario.SelectedValue))
                comm.Parameters.AddWithValue("@OBSERVACIONES", tbobservacion.Text)
                comm.Parameters.AddWithValue("@ETIQUETADO", etiquetado)
                comm.Parameters.AddWithValue("@POLIZA", tbPoliza.Text)
                comm.Parameters.AddWithValue("@ID_USUARIO_ACTUALIZA", PRINCIPAL.tsUsuario.Text)
                comm.Parameters.AddWithValue("@FECHA_ACTUALIZA", DateTime.Now)

                comm.ExecuteNonQuery()

                MessageBox.Show("El registro se ha actualizado correctamente", "Actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'dgvDetalles.Columns.Clear()
                dgvDetalles.DataSource = Nothing
                dgvDetalles.Rows.Clear()
                tbInventario.Text = ""
                tbserie.Text = ""
                tbobservacion.Text = ""
                chbetiquetado.Checked = False
                btactualizar.Enabled = False
                btbuscar.Enabled = True
                lbDescripcion.Text = ""
                lbDescripcion.Visible = False
                tbInventario.ReadOnly = False

            Catch ex As Exception
                MessageBox.Show("LOS DATOS NO SE ACTUALIZARON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End If

    End Sub
    'BOTON DE BUSCAR NUMERO DE INVENTARIO Y RELLENAR LOS COMBOBOX - TEXTBOX
    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btbuscar.Click


        If tbInventario.Text = "" Then

            MessageBox.Show("INGRESAR EL NUMERO DE INVENTARIO", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()

            Dim Sql As String = "Select FOLIO_FACTURA,FOLIO_FISCAL, EJERCICIO_ID, FUENTE_ID, PROVEEDOR_ID, ADQUISICION_ID, LICITACION_ID, FECHA_FACTURA, FECHA_CAPTURA,
                             UBICACION_ID, SUBCAPITULO_ID, PARTIDAS_ID, GRUPO_ID, MARCA_ID, MODELO_ID, NoSERIE, NoIDENTIFICACION, CLAVE_PRODUCTO, DESCRIPCION, DESCRIPCION_COMPLEMENTO, UNIDAD, CANTIDAD, VALOR,
                                            No_RESGUARDO, RESGUARDATORIO_ID, OBSERVACIONES, POLIZA, ETIQUETADO from TBL_INVENTARIO WHERE NUM_INVENTARIO = @desc"

            Dim cmd As New SqlCommand(Sql, cn)
            cmd.Parameters.AddWithValue("@desc", CStr(tbInventario.Text))
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                Dim etiquetado As String

                tbFoliofactura.Text = CStr(row("FOLIO_FACTURA"))
                tbFoliofiscal.Text = CStr(row("FOLIO_FISCAL"))
                cbEjercicio.SelectedValue = CInt(row("EJERCICIO_ID"))
                cbCuentas.SelectedValue = CInt(row("FUENTE_ID"))
                cbProveedores.SelectedValue = CInt(row("PROVEEDOR_ID"))
                cbtipoadq.SelectedValue = CInt(row("ADQUISICION_ID"))
                cblicitacion.SelectedValue = CInt(row("LICITACION_ID"))
                cbubicacion.SelectedValue = CInt(row("UBICACION_ID"))
                cbSubcapitulo.SelectedValue = CInt(row("SUBCAPITULO_ID"))
                cbPartidas.SelectedValue = CInt(row("PARTIDAS_ID"))
                cbGrupo.SelectedValue = CInt(row("GRUPO_ID"))
                cbmarca.SelectedValue = CInt(row("MARCA_ID"))
                cbmodelo.SelectedValue = CInt(row("MODELO_ID"))
                tbserie.Text = CStr(row("NoSERIE"))
                tbidentificacion.Text = CStr(row("NoIDENTIFICACION"))
                tbcantidad.Text = CStr(row("CANTIDAD"))
                tbunidad.Text = CStr(row("UNIDAD"))
                tbproducto.Text = CStr(row("CLAVE_PRODUCTO"))
                dtpFechafactura.Value = CStr(row("FECHA_FACTURA"))
                dtpFecharecepcion.Value = CStr(row("FECHA_CAPTURA"))
                lbDescripcion.Text = CStr(row("DESCRIPCION"))
                tbComplemento.SelectedText = CStr(row("DESCRIPCION_COMPLEMENTO"))
                tbvalor.Text = CStr(row("VALOR"))
                tbresguardo.Text = CStr(row("No_RESGUARDO"))
                cbResguardatario.SelectedValue = CInt(row("RESGUARDATORIO_ID"))
                tbPoliza.Text = CStr(row("POLIZA"))
                tbobservacion.Text = CStr(row("OBSERVACIONES"))
                etiquetado = CInt(row("ETIQUETADO"))

                lbDescripcion.Visible = True
                btactualizar.Enabled = True
                tbInventario.ReadOnly = True

                If etiquetado = 1 Then

                    chbetiquetado.Checked = True

                Else

                    chbetiquetado.Checked = False

                End If



            Else

                MessageBox.Show("EL NUMERO DE INVENTARIO NO EXISTE", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If

    End Sub

    Private Sub tbmensaje_Enter(sender As Object, e As EventArgs) Handles tbComplemento.Enter
        tbComplemento.Text = ""
    End Sub

    Private Sub tbComplemento_Leave(sender As Object, e As EventArgs) Handles tbComplemento.Leave



    End Sub

    Private Sub cbmarca_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbmarca.SelectionChangeCommitted

    End Sub

    Private Sub cbidentificacion_CheckedChanged(sender As Object, e As EventArgs) Handles cbidentificacion.CheckedChanged
        If cbidentificacion.Checked = True Then
            tbidentificacion.Enabled = False
            tbidentificacion.Clear()
            tbidentificacion.Text = "NO APLICA"
        Else
            tbidentificacion.Enabled = True
            tbidentificacion.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            tbproducto.Enabled = False
            tbproducto.Clear()
            tbproducto.Text = "SIN CLAVE"
        Else
            tbproducto.Enabled = True
            tbproducto.Clear()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            tbPoliza.Enabled = False
            tbPoliza.Clear()
            tbPoliza.Text = "SIN POLIZA"
        Else
            tbPoliza.Enabled = True
            tbPoliza.Clear()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            tbresguardo.Enabled = False
            tbresguardo.Clear()
            tbresguardo.Text = "SIN RESGUARDO"
        Else
            tbresguardo.Enabled = True
            tbresguardo.Clear()
        End If
    End Sub

    Private Sub tbcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcantidad.KeyPress
        'valida_numeros.validanumeros(tbcantidad)
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btAgregaconceptos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btCapturaconceptos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btXml_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        tbInventario.Text = ""
        tbInventario.ReadOnly = False
        tbserie.Text = ""
        tbobservacion.Text = ""
        tbresguardo.Text = ""
        tbPoliza.Text = ""
        tbcantidad.Text = ""
        tbFoliofactura.Text = ""
        tbFoliofiscal.Text = ""
        tbidentificacion.Text = ""
        tbproducto.Text = ""
        tbComplemento.Text = ""
        cbProveedores.DataSource = Nothing
        cbProveedores.Text = ""
        cbCuentas.DataSource = Nothing
        cbCuentas.Text = ""
        cbtipoadq.DataSource = Nothing
        cbtipoadq.Text = ""
        cblicitacion.DataSource = Nothing
        cblicitacion.Text = ""
        cbubicacion.DataSource = Nothing
        cbubicacion.Text = ""
        cbSubcapitulo.DataSource = Nothing
        cbSubcapitulo.Text = ""
        cbPartidas.DataSource = Nothing
        cbPartidas.Text = ""
        cbGrupo.DataSource = Nothing
        cbGrupo.Text = ""
        cbmarca.DataSource = Nothing
        cbmarca.Text = ""
        cbmodelo.DataSource = Nothing
        cbmodelo.Text = ""
        cbdescripcion.DataSource = Nothing
        cbdescripcion.Text = ""
        cbResguardatario.DataSource = Nothing
        cbResguardatario.Text = ""
        chbetiquetado.Checked = False
        chbSerie.Checked = False
        chbInventario.Checked = False
        cbidentificacion.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox4.Checked = False
        btagregar.Enabled = True
        btactualizar.Enabled = False
        btbuscar.Enabled = False
        lbDescripcion.Text = ""
        lbDescripcion.Visible = False

    End Sub

    Private Sub dgvDetalles_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvDetalles.RowsRemoved
        If dgvDetalles.RowCount < 1 Then
            btguardar.Enabled = False
        Else
            btguardar.Enabled = True
        End If
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Public Class USR_ALTAPROVEEDORES
    Public cn As New SqlConnection(My.Settings.Conexionbd)
    Dim cargarcombo As New BASEDATOS
    Dim funciones As New Altafactura
    Dim validanumeros As New Validacampos
    Dim valida_proveedores As New valida_registro_serie
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try

            If valida_proveedores.Valida_Existe_proveedor(tbRFC.Text) = False Then


                cn.Open()

                Dim Consulta As String = "INSERT INTO TBL_PROVEEDORES (NOMBRE_PROVEEDOR, TIPO_ACTIVIDAD, CURP, RFC, CALLE, NUMERO_EXT, NUMERO_INT, COLONIA, CP, TELEFONO, TELEFONO_MOVIL, REPRESENTANTE, CUENTA, CLABE, PLAZA, BANCO_ID, ESTATUS) VALUES (@NOMBRE_PROVEEDOR, @TIPO_ACTIVIDAD, @CURP, @RFC, @CALLE, @NUMERO_EXT, @NUMERO_INT, @COLONIA, @CP, @TELEFONO, @TELEFONO_MOVIL, @REPRESENTANTE, @CUENTA, @CLABE, @PLAZA, @BANCO_ID, @ESTATUS)"
                Dim comm As New SqlCommand(Consulta, cn)

                comm.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", tbNombre.Text)
                comm.Parameters.AddWithValue("@TIPO_ACTIVIDAD", cbDenominacion.Text)
                comm.Parameters.AddWithValue("@CURP", tbCURP.Text)
                comm.Parameters.AddWithValue("@RFC", tbRFC.Text)
                comm.Parameters.AddWithValue("@CALLE", tbCalle.Text)
                comm.Parameters.AddWithValue("@NUMERO_EXT", tbExterior.Text)
                comm.Parameters.AddWithValue("@NUMERO_INT", tbInterior.Text)
                comm.Parameters.AddWithValue("@COLONIA", tbColonia.Text)
                comm.Parameters.AddWithValue("@CP", tbCodigo.Text)
                comm.Parameters.AddWithValue("@TELEFONO", tbTelefono.Text)
                comm.Parameters.AddWithValue("@TELEFONO_MOVIL", tbTelefonomovil.Text)
                comm.Parameters.AddWithValue("@REPRESENTANTE", tbRepresentante.Text)
                comm.Parameters.AddWithValue("@CUENTA", tbCuenta.Text)
                comm.Parameters.AddWithValue("@CLABE", tbClabe.Text)
                comm.Parameters.AddWithValue("@PLAZA", tbPlaza.Text)
                comm.Parameters.AddWithValue("@BANCO_ID", cbBancos.SelectedValue)
                comm.Parameters.AddWithValue("@ESTATUS", cbEstatus.Text)

                comm.ExecuteNonQuery()
                MessageBox.Show("El registro se guardó correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cn.Close()
                ALTA_PROVEEDORES.Close()
                cargarcombo.Llenarcatproveedores(Altafactura.cbProveedores)
                Altafactura.cbProveedores.Focus()

                cbBancos.DataSource = Nothing
                cbBancos.Text = ""
                cbDenominacion.DataSource = Nothing
                cbDenominacion.Text = ""
                cbEstatus.DataSource = Nothing
                cbEstatus.Text = ""
                tbNombre.Text = ""
                tbCURP.Text = ""
                tbRFC.Text = ""
                tbCalle.Text = ""
                tbExterior.Text = ""
                tbInterior.Text = ""
                tbColonia.Text = ""
                tbCodigo.Text = ""
                tbTelefono.Text = ""
                tbTelefonomovil.Text = ""
                tbRepresentante.Text = ""
                tbCuenta.Text = ""
                tbClabe.Text = ""
                tbPlaza.Text = ""

            Else MessageBox.Show("El proveedor ya existe, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MessageBox.Show(e.ToString)
        End Try

    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        ALTA_PROVEEDORES.Close()
        Altafactura.cbProveedores.Focus()
    End Sub

    Private Sub cbDenominacion_Leave(sender As Object, e As EventArgs) Handles cbDenominacion.Leave
        If cbDenominacion.Text = "PERSONA MORAL" Then
            tbCURP.Enabled = False
            tbRFC.Focus()
        ElseIf cbDenominacion.Text = "PERSONA FISICA" Then
            tbCURP.Enabled = True
            tbCURP.Focus()
        End If
    End Sub

    ' Private Sub cbDenominacion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbDenominacion.SelectionChangeCommitted
    '  If cbDenominacion.SelectedValue = "PERSONA MORAL" Then
    '       tbCURP.Enabled = False
    '    ElseIf cbDenominacion.SelectedValue = "PERSONA FISICA" Then
    '        tbCURP.Enabled = True
    '     End If
    '   End Sub

    Private Sub tbCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCuenta.KeyPress
        'validanumeros.validanumeros(e)
    End Sub

    Private Sub tbClabe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbClabe.KeyPress
        'validanumeros.validanumeros(e)
    End Sub

    Private Sub USR_ALTAPROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNombre.CharacterCasing = CharacterCasing.Upper
        tbCURP.CharacterCasing = CharacterCasing.Upper
        tbRFC.CharacterCasing = CharacterCasing.Upper
        cbproveedor.Enabled = False
        btactualizar.Enabled = False
        'cargarcombo.llenarcombobancos(cbBancos)
    End Sub

    Private Sub cbBancos_Enter(sender As Object, e As EventArgs) Handles cbBancos.Enter
        cargarcombo.llenarcombobancos(cbBancos)
    End Sub

    Private Sub ChbDesbloquear_CheckedChanged(sender As Object, e As EventArgs) Handles chbDesbloquear.CheckedChanged
        If chbDesbloquear.Checked = True Then
            cbproveedor.Enabled = True
            btactualizar.Enabled = True
            btGuardar.Enabled = False
        Else
            btGuardar.Enabled = True
            cbproveedor.Enabled = False
            btactualizar.Enabled = False
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbproveedor.Enter
        cargarcombo.LlenarComboProveedores(cbproveedor)
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbproveedor.SelectionChangeCommitted

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim Sql As String = "Select NOMBRE_PROVEEDOR,TIPO_ACTIVIDAD, CURP, RFC, CALLE, NUMERO_EXT, NUMERO_INT,COLONIA,CP,TELEFONO,TELEFONO_MOVIL,REPRESENTANTE,CUENTA,CLABE,PLAZA,BANCO_ID,ESTATUS from TBL_PROVEEDORES WHERE NOMBRE_PROVEEDOR = @desc"

        Dim cmd As New SqlCommand(Sql, cn)
        cmd.Parameters.AddWithValue("@desc", CStr(cbproveedor.Text))
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)

            tbNombre.Text = CStr(row("NOMBRE_PROVEEDOR"))
            cbDenominacion.Text = CStr(row("TIPO_ACTIVIDAD"))
            tbCURP.Text = CStr(row("CURP"))
            tbRFC.Text = CStr(row("RFC"))
            tbCalle.Text = CStr(row("CALLE"))
            tbExterior.Text = CStr(row("NUMERO_EXT"))
            tbInterior.Text = CStr(row("NUMERO_INT"))
            tbColonia.Text = CStr(row("COLONIA"))
            tbCodigo.Text = CStr(row("CP"))
            tbTelefono.Text = CStr(row("TELEFONO"))
            tbTelefonomovil.Text = CStr(row("TELEFONO_MOVIL"))
            tbRepresentante.Text = CStr(row("REPRESENTANTE"))
            tbCuenta.Text = CStr(row("CUENTA"))
            tbClabe.Text = CStr(row("CLABE"))
            tbPlaza.Text = CStr(row("PLAZA"))
            cbBancos.SelectedValue = CInt(row("BANCO_ID"))
            cbEstatus.Text = CStr(row("ESTATUS"))

        Else

            MessageBox.Show("NO SE ENCONTRO LA DESCRIPCION", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Btactualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click
        Try
            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()

            Dim UPDATEProveedor As String = "UPDATE TBL_PROVEEDORES SET NOMBRE_PROVEEDOR = @NOMBRE_PROVEEDOR,TIPO_ACTIVIDAD=@TIPO_ACTIVIDAD, CURP=@CURP,RFC=@RFC,CALLE=@CALLE,NUMERO_EXT=@NUMERO_EXT,NUMERO_INT=@NUMERO_INT,COLONIA=@COLONIA,CP=@CP,TELEFONO=@TELEFONO,TELEFONO_MOVIL=@TELEFONO_MOVIL,
            REPRESENTANTE=@REPRESENTANTE,CUENTA=@CUENTA,CLABE=@CLABE,PLAZA=@PLAZA,BANCO_ID=@BANCO_ID,ESTATUS=@ESTATUS where NOMBRE_PROVEEDOR = '" & cbproveedor.Text & "'"

            Dim comm As New SqlCommand(UPDATEProveedor, cn)


            comm.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", tbNombre.Text)
            comm.Parameters.AddWithValue("@TIPO_ACTIVIDAD", cbDenominacion.Text)
            comm.Parameters.AddWithValue("@CURP", tbCURP.Text)
            comm.Parameters.AddWithValue("@RFC", tbRFC.Text)
            comm.Parameters.AddWithValue("@CALLE", tbCalle.Text)
            comm.Parameters.AddWithValue("@NUMERO_EXT", tbExterior.Text)
            comm.Parameters.AddWithValue("@NUMERO_INT", tbInterior.Text)
            comm.Parameters.AddWithValue("@COLONIA", tbColonia.Text)
            comm.Parameters.AddWithValue("@CP", tbCodigo.Text)
            comm.Parameters.AddWithValue("@TELEFONO", tbTelefono.Text)
            comm.Parameters.AddWithValue("@TELEFONO_MOVIL", tbTelefonomovil.Text)
            comm.Parameters.AddWithValue("@REPRESENTANTE", tbRepresentante.Text)
            comm.Parameters.AddWithValue("@CUENTA", tbCuenta.Text)
            comm.Parameters.AddWithValue("@CLABE", tbClabe.Text)
            comm.Parameters.AddWithValue("@PLAZA", tbPlaza.Text)
            comm.Parameters.AddWithValue("@BANCO_ID", Convert.ToInt16(cbBancos.SelectedValue))
            comm.Parameters.AddWithValue("@ESTATUS", cbEstatus.Text)


            comm.ExecuteNonQuery()


            MessageBox.Show("EL REGISTROS SE HAN ACTUALIZADO CORRECTAMENTE", "REGISTRO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbBancos.DataSource = Nothing
            cbBancos.Text = ""
            cbDenominacion.DataSource = Nothing
            cbDenominacion.Text = ""
            cbEstatus.DataSource = Nothing
            cbEstatus.Text = ""
            tbNombre.Text = ""
            tbCURP.Text = ""
            tbRFC.Text = ""
            tbCalle.Text = ""
            tbExterior.Text = ""
            tbInterior.Text = ""
            tbColonia.Text = ""
            tbCodigo.Text = ""
            tbTelefono.Text = ""
            tbTelefonomovil.Text = ""
            tbRepresentante.Text = ""
            tbCuenta.Text = ""
            tbClabe.Text = ""
            tbPlaza.Text = ""

        Catch ex As Exception
            MessageBox.Show("EL REGISTROS NO SE HAN ACTUALIZADO CORRECTAMENTE", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cbproveedor_SelectionChangeCommitted(sender As Object, e As EventArgs)

    End Sub
End Class

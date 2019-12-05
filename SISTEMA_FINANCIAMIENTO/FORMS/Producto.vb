Imports System.Data
Imports System.Data.SqlClient
Public Class Producto
    Public cn As New SqlConnection
    Dim valida_producto As New valida_registro_serie

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btguardar.Enabled = False
        ComboBox1.Enabled = False
        btactualizar.Enabled = False

    End Sub

    Dim funciones As New BASEDATOS
    Private Sub ComboBox1_Enter_1(sender As Object, e As EventArgs) Handles cbSubcapitulo.Enter

        funciones.LlenarComboSubCapitulo_Inv(cbSubcapitulo)

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

    Private Sub cbmarca_Enter(sender As Object, e As EventArgs) Handles cbmarca.Enter

        If cbGrupo.SelectedValue Then

            funciones.LlenarComboMarca(cbmarca, cbPartidas)


        End If
    End Sub

    Private Sub cbmodelo_Enter(sender As Object, e As EventArgs) Handles cbmodelo.Enter

        If cbPartidas.SelectedValue Then

            funciones.LlenarComboModelo(cbmodelo, cbSubcapitulo)

        Else
            MessageBox.Show("FAVOR DE SELECCIONAR LA PARTIDA", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

        Dim cn As New SqlConnection(My.Settings.Conexionbd)
        cn.Open()
        If cbSubcapitulo.SelectedIndex < 0 Or cbPartidas.SelectedIndex < 0 Or cbGrupo.SelectedIndex < 0 Or cbmarca.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar las características del producto para poder generar la clave", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            If valida_producto.Valida_Existe_clave(tbClave.Text) = False Then

                Try

                    Dim guardardatos As String = "INSERT INTO CAT_DESCRIPCION_PRODUCTO (SUBCAPITULO_ID, PARTIDA_ID, GRUPO_ID,MARCA_ID , MODELO_ID, PROC_DESCRIPCION, CLAVE_PRODUCTO) VALUES (@SUBCAPITULO_ID, @PARTIDA_ID, @GRUPO_ID,@MARCA_ID, @MODELO_ID, @PROC_DESCRIPCION, @CLAVE_PRODUCTO)"

                    Dim comm As New SqlCommand(guardardatos, cn)

                    comm.Parameters.AddWithValue("@SUBCAPITULO_ID", cbSubcapitulo.SelectedValue)
                    comm.Parameters.AddWithValue("@PARTIDA_ID", cbPartidas.SelectedValue)
                    comm.Parameters.AddWithValue("@GRUPO_ID", cbGrupo.SelectedValue)
                    comm.Parameters.AddWithValue("@MARCA_ID", cbmarca.SelectedValue)
                    comm.Parameters.AddWithValue("@MODELO_ID", cbmodelo.SelectedValue)
                    comm.Parameters.AddWithValue("@PROC_DESCRIPCION", tbdescripcion.Text)
                    comm.Parameters.AddWithValue("@CLAVE_PRODUCTO", tbClave.Text)

                    comm.ExecuteNonQuery()

                    MessageBox.Show("Los datos se guardaron correctamente", "Guardar descripcion", MessageBoxButtons.OK, MessageBoxIcon.Information)


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
                    tbClave.Text = ""
                    tbdescripcion.Text = ""
                    btactualizar.Enabled = False
                    btguardar.Enabled = True


                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Else MessageBox.Show("La clave ya existe, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


        End If

    End Sub



    Private Sub cbmodelo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbmodelo.SelectionChangeCommitted

        If cbSubcapitulo.SelectedIndex < 0 Or cbPartidas.SelectedIndex < 0 Or cbGrupo.SelectedIndex < 0 Or cbmarca.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar las características del producto para poder generar la clave", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim clave As String = Strings.Left(cbPartidas.Text, 4) + Strings.Left(cbGrupo.Text, 1) + Strings.Left(cbmarca.Text, 2) + Strings.Left(cbmodelo.Text, 4)
            tbClave.Text = clave

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbDesbloquear.CheckedChanged

        If chbDesbloquear.Checked = True Then
            tbClave.ReadOnly = False
        Else
            tbClave.ReadOnly = True
        End If



    End Sub

    Private Sub Producto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CONSULTA_PRODUCTO.Show()
    End Sub

    Private Sub CComboBox1_Enter_1(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        funciones.LlenarCombodesproductos(ComboBox1)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ComboBox1.Enabled = True
        btactualizar.Enabled = True
        btbuscar.Enabled = True
        btguardar.Enabled = False
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
        tbClave.Text = ""
        tbdescripcion.Text = ""

    End Sub

    Private Sub Btbuscar_Click(sender As Object, e As EventArgs) Handles btbuscar.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim Sql As String = "Select SUBCAPITULO_ID,PARTIDA_ID, GRUPO_ID, MARCA_ID, MODELO_ID, PROC_DESCRIPCION, CLAVE_PRODUCTO from CAT_DESCRIPCION_PRODUCTO WHERE PROC_DESCRIPCION = @desc"

        Dim cmd As New SqlCommand(Sql, cn)
        cmd.Parameters.AddWithValue("@desc", CStr(ComboBox1.Text))
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)

            cbSubcapitulo.SelectedValue = CInt(row("SUBCAPITULO_ID"))
            cbPartidas.SelectedValue = CInt(row("PARTIDA_ID"))
            cbGrupo.SelectedValue = CInt(row("GRUPO_ID"))
            cbmarca.SelectedValue = CInt(row("MARCA_ID"))
            cbmodelo.SelectedValue = CInt(row("MODELO_ID"))
            tbdescripcion.Text = CStr(row("PROC_DESCRIPCION"))
            tbClave.Text = CStr(row("CLAVE_PRODUCTO"))

        Else

            MessageBox.Show("NO SE ENCONTRO LA DESCRIPCION", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Btactualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click

        Try
            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
            Dim actualizainv As String = "UPDATE CAT_DESCRIPCION_PRODUCTO SET SUBCAPITULO_ID=@SUBCAPITULO_ID, PARTIDA_ID= @PARTIDA_ID, GRUPO_ID= @GRUPO_ID, MARCA_ID=@MARCA_ID, MODELO_ID=@MODELO_ID, PROC_DESCRIPCION=@PROC_DESCRIPCION,  CLAVE_PRODUCTO=@CLAVE_PRODUCTO
                                           where PROC_DESCRIPCION = '" & ComboBox1.Text & "'"


            Dim comm As New SqlCommand(actualizainv, cn)


            comm.Parameters.AddWithValue("@SUBCAPITULO_ID", Convert.ToInt16(cbSubcapitulo.SelectedValue))
            comm.Parameters.AddWithValue("@PARTIDA_ID", Convert.ToInt16(cbPartidas.SelectedValue))
            comm.Parameters.AddWithValue("@GRUPO_ID", Convert.ToInt16(cbGrupo.SelectedValue))
            comm.Parameters.AddWithValue("@MARCA_ID", Convert.ToInt16(cbmarca.SelectedValue))
            comm.Parameters.AddWithValue("@MODELO_ID", Convert.ToInt16(cbmodelo.SelectedValue))
            comm.Parameters.AddWithValue("@PROC_DESCRIPCION", tbdescripcion.Text)
            comm.Parameters.AddWithValue("@CLAVE_PRODUCTO", tbClave.Text)
            comm.ExecuteNonQuery()


            MessageBox.Show("EL REGISTROS SE HAN ACTUALIZADO CORRECTAMENTE", "REGISTRO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'dgvDetalles.Columns.Clear()




            ComboBox1.Enabled = False
            ComboBox1.DataSource = Nothing
            ComboBox1.Text = ""
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
            tbClave.Text = ""
            tbdescripcion.Text = ""
            btactualizar.Enabled = False
            btguardar.Enabled = true


        Catch ex As Exception
            MessageBox.Show("LOS DATOS NO SE ACTUALIZARON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim Sql As String = "Select SUBCAPITULO_ID,PARTIDA_ID, GRUPO_ID, MARCA_ID, MODELO_ID, PROC_DESCRIPCION, CLAVE_PRODUCTO from CAT_DESCRIPCION_PRODUCTO WHERE PROC_DESCRIPCION = @desc"

        Dim cmd As New SqlCommand(Sql, cn)
        cmd.Parameters.AddWithValue("@desc", CStr(ComboBox1.Text))
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)

            cbSubcapitulo.SelectedValue = CInt(row("SUBCAPITULO_ID"))
            cbPartidas.SelectedValue = CInt(row("PARTIDA_ID"))
            cbGrupo.SelectedValue = CInt(row("GRUPO_ID"))
            cbmarca.SelectedValue = CInt(row("MARCA_ID"))
            cbmodelo.SelectedValue = CInt(row("MODELO_ID"))
            tbdescripcion.Text = CStr(row("PROC_DESCRIPCION"))
            tbClave.Text = CStr(row("CLAVE_PRODUCTO"))

        Else

            MessageBox.Show("NO SE ENCONTRO LA DESCRIPCION", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        btguardar.Enabled = True
        btactualizar.Enabled = False

        ComboBox1.DataSource = Nothing
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
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
        tbClave.Text = ""
        tbdescripcion.Text = ""
    End Sub


End Class
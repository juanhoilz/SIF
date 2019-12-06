Imports System.Data
Imports System.Data.SqlClient

Public Class ALTA_GRUPO
    Public cn As New SqlConnection
    Dim funciones As New BASEDATOS
    Dim valida_grupo As New valida_registro_serie


    Private Sub ALTA_GRUPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btguardar.Enabled = False
        btactualizar.Enabled = False
        combodesgrupo.Enabled = False
        cbPartidas.SelectedValue = 1
    End Sub


    Private Sub cbPartidas_Enter_1(sender As Object, e As EventArgs) Handles cbPartidas.Enter
        funciones.LlenarCombogrupo_Inv(cbPartidas)
    End Sub

    Private Sub btguardar_Click_1(sender As Object, e As EventArgs) Handles btguardar.Click


        Try
            If valida_grupo.Valida_Existe_grupo(cbPartidas.SelectedValue, tbdescripcion.Text) = False Then

                Dim cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()

                Dim guardardatos As String = "INSERT INTO CAT_GRUPOS(ID_PARTIDA, DESCRIPCION_GRUPO, CLAVE_CLASIFICADOR) VALUES ( @PARTIDA_ID, @DESCRIPCION, @CLAVE_CLASIFICADOR)"

                Dim comm As New SqlCommand(guardardatos, cn)

                comm.Parameters.AddWithValue("@PARTIDA_ID", cbPartidas.SelectedValue)
                comm.Parameters.AddWithValue("@DESCRIPCION", tbdescripcion.Text)
                comm.Parameters.AddWithValue("@CLAVE_CLASIFICADOR", "0000")

                comm.ExecuteNonQuery()

                MessageBox.Show("Los datos se guardaron correctamente", "Guardar Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cbPartidas.SelectedValue = 1
                cbPartidas.Text = ""
                tbdescripcion.Text = ""
            Else
                MessageBox.Show("El grupo ya existe, favor de verificar", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CONSULTAR_GRUPO.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodesgrupo.Enter
        funciones.LlenarCombodesgrupo(combodesgrupo)
    End Sub

    Private Sub combodesgrupo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combodesgrupo.SelectionChangeCommitted

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim Sql As String = "Select ID_PARTIDA, DESCRIPCION_GRUPO from CAT_GRUPOS WHERE DESCRIPCION_GRUPO = @desc"

        Dim cmd As New SqlCommand(Sql, cn)
        cmd.Parameters.AddWithValue("@desc", CStr(combodesgrupo.Text))
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)


            cbPartidas.SelectedValue = CInt(row("ID_PARTIDA"))
            tbdescripcion.Text = CStr(row("DESCRIPCION_GRUPO"))


        Else

            MessageBox.Show("NO SE ENCONTRO LA DESCRIPCION", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        combodesgrupo.Enabled = True
        btactualizar.Enabled = True
        btguardar.Enabled = False
        cbPartidas.SelectedValue = 1
        cbPartidas.Text = ""
        tbdescripcion.Text = ""

    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        btguardar.Enabled = True
        btactualizar.Enabled = False
        combodesgrupo.DataSource = Nothing
        combodesgrupo.Text = ""
        combodesgrupo.Enabled = False

        cbPartidas.SelectedValue = 1
        tbdescripcion.Text = ""
    End Sub

    Private Sub btactualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click
        Try

            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
            Dim actualizagrupo As String = "UPDATE CAT_GRUPOS SET ID_PARTIDA= @PARTIDA_ID, DESCRIPCION_GRUPO=@DESCRIPCION_GRUPO
                                           where DESCRIPCION_GRUPO = '" & combodesgrupo.Text & "'"


            Dim comm As New SqlCommand(actualizagrupo, cn)

            comm.Parameters.AddWithValue("@PARTIDA_ID", Convert.ToInt16(cbPartidas.SelectedValue))
            comm.Parameters.AddWithValue("@DESCRIPCION_GRUPO", tbdescripcion.Text)

            comm.ExecuteNonQuery()


            MessageBox.Show("EL REGISTRO SE HAN ACTUALIZADO CORRECTAMENTE", "REGISTRO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'dgvDetalles.Columns.Clear()



            combodesgrupo.DataSource = Nothing
            combodesgrupo.Text = ""
            cbPartidas.DataSource = Nothing
            cbPartidas.Text = ""
            tbdescripcion.Text = ""


        Catch ex As Exception
            MessageBox.Show("LOS DATOS NO SE ACTUALIZARON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
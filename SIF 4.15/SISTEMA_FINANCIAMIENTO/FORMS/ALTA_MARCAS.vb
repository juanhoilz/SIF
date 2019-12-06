Imports System.Data
Imports System.Data.SqlClient
Public Class ALTA_MARCAS
    Public cn As New SqlConnection
    'Public cn As New SqlConnection
    Dim funciones As New BASEDATOS

    Private Sub ALTA_MARCAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btguardar.Enabled = False
        btactualizar.Enabled = False
        combodesmarca.Enabled = False
        cbSubcapitulo.Text = ""
    End Sub

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
    Private Sub ComboBox2_Enter_3(sender As Object, e As EventArgs)

        'If cbPartidas.SelectedValue Then

        'funciones.Llenarcombogrupo(cbGrupo, cbPartidas)

        'Else
        'MessageBox.Show("FAVOR DE SELECCIONAR LA PARTIDA", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If


    End Sub


    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        Try
            Dim cn As New SqlConnection(My.Settings.Conexionbd)

            cn.Open()

            Dim guardardatos As String = "INSERT INTO CAT_MARCA (SUBCAPITULO_ID, PARTIDA_ID, NOM_MARCA) VALUES (@SUBCAPITULO_ID, @PARTIDA_ID, @DESCRIPCION)"

            Dim comm As New SqlCommand(guardardatos, cn)

            comm.Parameters.AddWithValue("@SUBCAPITULO_ID", cbSubcapitulo.SelectedValue)
            comm.Parameters.AddWithValue("@PARTIDA_ID", cbPartidas.SelectedValue)
            'comm.Parameters.AddWithValue("@GRUPO_ID", cbGrupo.SelectedValue)
            comm.Parameters.AddWithValue("@DESCRIPCION", tbdescripcion.Text)


            comm.ExecuteNonQuery()

            MessageBox.Show("Los datos se guardaron correctamente", "Guardar marca", MessageBoxButtons.OK, MessageBoxIcon.Information)


            cbSubcapitulo.DataSource = Nothing
            cbSubcapitulo.Text = ""
            cbPartidas.DataSource = Nothing
            cbPartidas.Text = ""
            tbdescripcion.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CONSULTAR_MARCA.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        combodesmarca.Enabled = True
        btactualizar.Enabled = True
        btguardar.Enabled = False
        cbSubcapitulo.SelectedValue = 1
        cbSubcapitulo.Text = ""
        cbPartidas.DataSource = Nothing
        cbPartidas.Text = ""
        tbdescripcion.Text = ""
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        btguardar.Enabled = True
        btactualizar.Enabled = False
        combodesmarca.DataSource = Nothing
        combodesmarca.Text = ""
        combodesmarca.Enabled = False
        cbPartidas.DataSource = Nothing
        cbPartidas.Text = ""
        cbSubcapitulo.SelectedValue = 1
        tbdescripcion.Text = ""
    End Sub

    Private Sub combodesmarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodesmarca.Enter
        funciones.LlenarCombodesmarca(combodesmarca)

    End Sub

    Private Sub combodesmarca_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combodesmarca.SelectionChangeCommitted

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim Sql As String = "Select SUBCAPITULO_ID, PARTIDA_ID, NOM_MARCA from CAT_MARCA WHERE NOM_MARCA = @desc"

        Dim cmd As New SqlCommand(Sql, cn)
        cmd.Parameters.AddWithValue("@desc", CStr(combodesmarca.Text))
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)


            cbSubcapitulo.SelectedValue = CInt(row("SUBCAPITULO_ID"))
            cbPartidas.SelectedValue = CInt(row("PARTIDA_ID"))
            tbdescripcion.Text = CStr(row("NOM_MARCA"))


        Else

            MessageBox.Show("NO SE ENCONTRO LA MARCA", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btactualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click
        Try

            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
            Dim actualizamodelo As String = "UPDATE CAT_MARCA SET SUBCAPITULO_ID= @SUBCAPITULO_ID, PARTIDA_ID=@PARTIDA_ID, NOM_MARCA=@NOM_MARCA
                                           where NOM_MARCA = '" & combodesmarca.Text & "'"


            Dim comm As New SqlCommand(actualizamodelo, cn)

            comm.Parameters.AddWithValue("@SUBCAPITULO_ID", Convert.ToInt16(cbSubcapitulo.SelectedValue))
            comm.Parameters.AddWithValue("@PARTIDA_ID", Convert.ToInt16(cbPartidas.SelectedValue))
            comm.Parameters.AddWithValue("@NOM_MARCA", tbdescripcion.Text)

            comm.ExecuteNonQuery()


            MessageBox.Show("EL REGISTRO SE HAN ACTUALIZADO CORRECTAMENTE", "REGISTRO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'dgvDetalles.Columns.Clear()



            combodesmarca.DataSource = Nothing
            combodesmarca.Text = ""
            cbSubcapitulo.DataSource = Nothing
            cbSubcapitulo.Text = ""
            cbPartidas.DataSource = Nothing
            cbPartidas.Text = ""
            tbdescripcion.Text = ""


        Catch ex As Exception
            MessageBox.Show("LOS DATOS NO SE ACTUALIZARON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
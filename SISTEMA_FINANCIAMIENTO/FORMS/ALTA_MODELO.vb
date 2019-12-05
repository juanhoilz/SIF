Imports System.Data
Imports System.Data.SqlClient
Public Class ALTA_MODELO
    Public cn As New SqlConnection
    Private Sub ALTA_MODELO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btguardar.Enabled = False
        btactualizar.Enabled = False
        combodesmodelo.Enabled = False

    End Sub
    Dim funciones As New BASEDATOS
    Private Sub ComboBox1_Enter_1(sender As Object, e As EventArgs) Handles cbSubcapitulo.Enter

        funciones.LlenarComboSubCapitulo_Inv(cbSubcapitulo)

    End Sub

    Private Sub ComboBox3_Enter(sender As Object, e As EventArgs)


    End Sub
    Private Sub ComboBox2_Enter_3(sender As Object, e As EventArgs)




    End Sub

    Private Sub cbmarca_Enter(sender As Object, e As EventArgs)


    End Sub


    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

        Dim cn As New SqlConnection(My.Settings.Conexionbd)
        Try
            cn.Open()

            Dim guardardatos As String = "INSERT INTO CAT_MODELO (SUBCAPITULOS_ID, NOM_MODELO) VALUES (@SUBCAPITULO_ID, @DESCRIPCION)"

            Dim comm As New SqlCommand(guardardatos, cn)

            comm.Parameters.AddWithValue("@SUBCAPITULO_ID", cbSubcapitulo.SelectedValue)

            comm.Parameters.AddWithValue("@DESCRIPCION", tbdescripcion.Text)


            comm.ExecuteNonQuery()

            MessageBox.Show("Los datos se guardaron correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbSubcapitulo.SelectedValue = 1
            cbSubcapitulo.Text = ""
            tbdescripcion.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CONSULTAR_MODELO.ShowDialog()
    End Sub

    Private Sub combodesmodelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodesmodelo.Enter
        funciones.LlenarCombodesmodelo(combodesmodelo)
    End Sub

    Private Sub combodesmodelo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combodesmodelo.SelectionChangeCommitted

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim Sql As String = "Select SUBCAPITULOS_ID, NOM_MODELO from CAT_MODELO WHERE NOM_MODELO = @desc"

        Dim cmd As New SqlCommand(Sql, cn)
        cmd.Parameters.AddWithValue("@desc", CStr(combodesmodelo.Text))
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)


            cbSubcapitulo.SelectedValue = CInt(row("SUBCAPITULOS_ID"))
            tbdescripcion.Text = CStr(row("NOM_MODELO"))


        Else

            MessageBox.Show("NO SE ENCONTRO EL MODELO", "VALIDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        combodesmodelo.Enabled = True
        btactualizar.Enabled = True
        btguardar.Enabled = False
        cbSubcapitulo.SelectedValue = 1
        cbSubcapitulo.Text = ""
        tbdescripcion.Text = ""
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        btguardar.Enabled = True
        btactualizar.Enabled = False
        combodesmodelo.DataSource = Nothing
        combodesmodelo.Text = ""
        combodesmodelo.Enabled = False

        cbSubcapitulo.SelectedValue = 1
        tbdescripcion.Text = ""
    End Sub

    Private Sub btactualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click
        Try

            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
            Dim actualizamodelo As String = "UPDATE CAT_MODELO SET SUBCAPITULOS_ID= @SUBCAPITULOS_ID, NOM_MODELO=@NOM_MODELO
                                           where NOM_MODELO = '" & combodesmodelo.Text & "'"


            Dim comm As New SqlCommand(actualizamodelo, cn)

            comm.Parameters.AddWithValue("@SUBCAPITULOS_ID", Convert.ToInt16(cbSubcapitulo.SelectedValue))
            comm.Parameters.AddWithValue("@NOM_MODELO", tbdescripcion.Text)

            comm.ExecuteNonQuery()


            MessageBox.Show("EL REGISTRO SE HAN ACTUALIZADO CORRECTAMENTE", "REGISTRO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'dgvDetalles.Columns.Clear()



            combodesmodelo.DataSource = Nothing
            combodesmodelo.Text = ""
            cbSubcapitulo.DataSource = Nothing
            cbSubcapitulo.Text = ""
            tbdescripcion.Text = ""


        Catch ex As Exception
            MessageBox.Show("LOS DATOS NO SE ACTUALIZARON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
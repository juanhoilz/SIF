Imports System.Data
Imports System.Data.SqlClient

Public Class ALTA_UNIDADES

    Public cn As New SqlConnection
    Dim funciones As New BASEDATOS
    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbUnidades.Enter
        funciones.LlenarComboUnidades(cbUnidades)
    End Sub

    Private Sub cbFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFiltro.SelectionChangeCommitted

    End Sub

    Private Sub ALTA_UNIDADES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_Enter_1(sender As Object, e As EventArgs) Handles cbMunicipios.Enter
        funciones.Llenarcombomunicipios(cbMunicipios)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        If cbFiltro.SelectedIndex = 0 Then
            Dim consulta As String = "INSERT INTO TBL_UNIDADES_ADMINISTRATIVAS (CLAVE_JURISDICCION, NOMBRE_UNIDAD, CALLE, NUMERO_EXT, NUMERO_INT, COLONIA, CP, CLAVE_MUNICIPIO, LOCALIDAD, APLICA_PRESUPUESTO)  VALUES (@CLAVE_JURISDICCION, @NOMBRE_UNIDAD, @CALLE, @NUMERO_EXT, @NUMERO_INT, @COLONIA, @CP, @CLAVE_MUNICIPIO, @LOCALIDAD, @APLICA_PRESUPUESTO)"
            Dim comm As New SqlCommand(consulta, cn)

            comm.Parameters.AddWithValue("@CLAVE_JURISDICCION", cbJurisdiccion.SelectedIndex)
            comm.Parameters.AddWithValue("@NOMBRE_UNIDAD", mdNombre.Text)
            comm.Parameters.AddWithValue("@CALLE", mdCalle.Text)
            comm.Parameters.AddWithValue("@NUMERO_EXT", mdNumeroext.Text)
            comm.Parameters.AddWithValue("@NUMERO_INT", mdNumeroint.Text)
            comm.Parameters.AddWithValue("@COLONIA", mdColonia.Text)
            comm.Parameters.AddWithValue("@CP", mdCodigopostal.Text)
            comm.Parameters.AddWithValue("@CLAVE_MUNICIPIO", cbMunicipios.SelectedValue)
            comm.Parameters.AddWithValue("@LOCALIDAD", mdLocalidad.Text)
            comm.Parameters.AddWithValue("@APLICA_PRESUPUESTO", mdSi.Checked)

            comm.ExecuteNonQuery()

            MessageBox.Show("Los datos se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cn.Close()

        End If
    End Sub

    Private Sub rbSi_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
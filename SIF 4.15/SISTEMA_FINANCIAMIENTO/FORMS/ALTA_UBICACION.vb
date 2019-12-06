Imports System.Data
Imports System.Data.SqlClient


Public Class ALTA_UBICACION

    Public cn As New SqlConnection
    Public cmd As New SqlCommand


    Private Sub Btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

        Dim cn As New SqlConnection(My.Settings.Conexionbd)
            cn.Open()

        Dim guardardatos As String = "INSERT INTO TBL_UBICACION(NOMBRE) VALUES (@NOMBRE)"

        Dim comm As New SqlCommand(guardardatos, cn)

        comm.Parameters.AddWithValue("@NOMBRE", tbdescripcion.Text)

        comm.ExecuteNonQuery()

        MessageBox.Show("Los datos se guardaron correctamente", "Guardar ubicacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class
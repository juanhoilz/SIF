Imports System.Data
Imports System.Data.SqlClient
Public Class Alta_Cuenta

    Public cn As New SqlConnection(My.Settings.Conexionbd)
    Dim funciones As New BASEDATOS
    Private Sub Alta_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            'cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()

            Dim consulta As String = "INSERT INTO CAT_CUENTAS (NUMERO_CUENTA, CLABE, EJERCICIO, ID_BANCO, ID_CUENTA_ORIGEN, SALDO_INICIAL, SALDO_ACTUAL) VALUES (@NUMERO_CUENTA, @CLABE, @EJERCICIO, @ID_BANCO, @ID_CUENTA_ORIGEN, @SALDO_INICIAL, @SALDO_ACTUAL)"
            Dim comm As New SqlCommand(consulta, cn)

            comm.Parameters.AddWithValue("@NUMERO_CUENTA", tbNumeroCuenta.Text)
            comm.Parameters.AddWithValue("@CLABE", tbClabe.Text)
            comm.Parameters.AddWithValue("@EJERCICIO", tbEjercicio.Text)
            comm.Parameters.AddWithValue("@ID_BANCO", cbBancos.SelectedValue)
            comm.Parameters.AddWithValue("@ID_CUENTA_ORIGEN", cbCuenta.SelectedValue)
            comm.Parameters.AddWithValue("@SALDO_INICIAL", Convert.ToDecimal(tbSaldoInicial.Text))
            comm.Parameters.AddWithValue("@SALDO_ACTUAL", Convert.ToDecimal(tbSaldoActual.Text))

            comm.ExecuteNonQuery()
            MessageBox.Show("El registro se guardó correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(e.ToString)
        End Try
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbBancos.Enter
        funciones.llenarcombobancos(cbBancos)
    End Sub

    Private Sub cbCuenta_Enter(sender As Object, e As EventArgs) Handles cbCuenta.Enter
        funciones.LlenarCuentaOrigen(cbCuenta)
    End Sub
End Class

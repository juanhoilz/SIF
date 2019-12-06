Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Public Class DIGITALIZADOS

    Public cn As New SqlConnection
    Dim funciones As New BASEDATOS
    Private Sub DIGITALIZADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbEjercicio_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones.LlenarComboanioejercicio(cbEjercicio)
    End Sub

    Private Sub cbCuentas_Enter(sender As Object, e As EventArgs) Handles cbCuentas.Enter
        funciones.llenarcomboejercicio(cbCuentas)
    End Sub
End Class
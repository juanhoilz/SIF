Imports System.Data
Imports System.Data.SqlClient
Public Class REPORTES_ACTIVOS_FIJOS

    Public cn As New SqlConnection

    Dim funciones As New BASEDATOS

    Private Sub cbbusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbusqueda.Enter
        If cbFiltro.SelectedIndex = 0 Then
            cbbusqueda.DataSource = Nothing
            cbbusqueda.Text = ""
            funciones.Llenarcatproveedores(cbbusqueda)
        ElseIf cbFiltro.SelectedIndex = 1 Then
            cbbusqueda.DataSource = Nothing
            cbbusqueda.Text = ""
            funciones.LlenarComboUbicacion(cbbusqueda)
        ElseIf cbFiltro.SelectedIndex = 2 Then
            cbbusqueda.DataSource = Nothing
            cbbusqueda.Text = ""
            funciones.LlenarCombogrupo_Inv(cbbusqueda)
        ElseIf cbFiltro.SelectedIndex = 3 Then
            cbbusqueda.DataSource = Nothing
            cbbusqueda.Text = ""
            funciones.LlenarComboanioejercicio(cbbusqueda)
        End If
    End Sub
End Class
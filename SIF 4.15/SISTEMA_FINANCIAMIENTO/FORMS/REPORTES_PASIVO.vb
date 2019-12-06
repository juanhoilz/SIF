Imports System.Data
Imports System.Data.SqlClient

Public Class REPORTES_PASIVO
    Public cn As New SqlConnection

    Dim funciones As New BASEDATOS
    Private Sub REPORTES_PASIVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbRecurso_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones.LlenarComboanioejercicio(cbEjercicio)
    End Sub

    Private Sub ComboBox4_Enter(sender As Object, e As EventArgs) Handles cbRecurso.Enter
        funciones.llenarcomboejercicio(cbRecurso)
    End Sub

    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs) Handles cbDescripcion.Enter

        If cbFiltro.SelectedIndex = 0 Then
            cbDescripcion.DataSource = Nothing
            cbDescripcion.Text = ""
            funciones.LlenarComboUnidades(cbDescripcion)
        ElseIf cbFiltro.SelectedIndex = 1 Then
            cbDescripcion.DataSource = Nothing
            cbDescripcion.Text = ""
            funciones.Llenarcatproveedores(cbDescripcion)
        ElseIf cbFiltro.SelectedIndex = 2 Then
            cbDescripcion.DataSource = Nothing
            cbDescripcion.Text = ""
            funciones.llenacombopartidas(cbDescripcion)
        End If

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

        'Se declaran las variables para asignarlos como parametros

        Dim id_ejercicio = CInt(cbEjercicio.SelectedValue)
        Dim id_cuenta = CInt(cbRecurso.SelectedValue)
        Dim id_unidad = CInt(cbDescripcion.SelectedValue)

        'Se instancía el form que contiene el reportviewer
        'Dim form_reporte_pasivo As New GENERA_REPORTE_PASIVO

        'Se asigna el valor de las variables publicas declaradas
        'form_reporte_pasivo.ejercicio = CInt(id_ejercicio)
        'form_reporte_pasivo.cuenta = CInt(id_cuenta)
        'form_reporte_pasivo.unidad = CInt(id_unidad)
        'form_reporte_pasivo.ShowDialog()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFiltro.SelectionChangeCommitted

    End Sub
End Class
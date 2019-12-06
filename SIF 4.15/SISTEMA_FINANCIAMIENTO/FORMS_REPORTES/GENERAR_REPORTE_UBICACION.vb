Imports System.Data
Imports System.Data.SqlClient

Imports Microsoft.Reporting.WinForms
Public Class GENERAR_REPORTE_UBICACION

    Public adaptador As New SqlDataAdapter
    Public cn As New SqlConnection
    Dim funciones As New BASEDATOS

    Private Sub GENERAR_REPORTE_UBICACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FACTURASDataSet.spListaInventarioUbicacion' Puede moverla o quitarla según sea necesario.
        'Me.spListaInventarioUbicacionTableAdapter.Fill(Me.ALMACEN_FACTURASDataSet.spListaInventarioUbicacion)


        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cbUbicacion.Enter
        funciones.LlenarComboUbicacion(cbUbicacion)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            'Dim generar_reporte_ubicacion As New GENERAR_REPORTE_UBICACION
            'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FACTURASDataSet.spListaInventarioUbicacion' Puede moverla o quitarla según sea necesario.
            Me.spListaInventarioUbicacionTableAdapter.Fill(Me.ALMACEN_FACTURASDataSet.spListaInventarioUbicacion, cbUbicacion.SelectedValue)

            Me.ReportViewer1.RefreshReport()



            Dim parameters(0) As ReportParameter
            parameters(0) = New ReportParameter("pU", Convert.ToString(Me.cbUbicacion.SelectedValue))

            ReportViewer1.LocalReport.SetParameters(parameters)

            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'REPORTE_UBICACION.ShowDialog()
    End Sub
End Class
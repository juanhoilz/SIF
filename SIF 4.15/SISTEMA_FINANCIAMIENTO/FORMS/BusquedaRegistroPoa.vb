Imports System.Data.SqlClient
Public Class BusquedaRegistroPoa


    Dim funciones As New BASEDATOS

    Dim cn As New SqlConnection(My.Settings.Conexionbd)


    Private Sub BusquedaRegistroPoa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Combox_Ejercicio_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones.LlenarComboanioejercicio(cbEjercicio)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        funciones.combodgvregistropoa(cbEjercicio.SelectedValue, DataGridView1)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value = tbImporte.Text

    End Sub

    Private Sub btGuardar_Click_1(sender As Object, e As EventArgs) Handles btGuardar.Click

        cn.Open()

        For Each row As DataGridViewRow In DataGridView1.Rows

        Next

        cn.Close()

    End Sub


End Class
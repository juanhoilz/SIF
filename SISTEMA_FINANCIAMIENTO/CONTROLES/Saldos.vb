Imports System.Data
Imports System.Data.SqlClient
Public Class Saldos

    Public cn As New SqlConnection(My.Settings.Conexionbd)
    'Public obtenerdato As SqlCommand
    'Dim enunciado As SqlCommand
    'Dim respuesta As SqlDataReader
    Dim funciones As New BASEDATOS


    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim consulta As String = ("SELECT *from CAT_CUENTAS Where ID_CUENTA = @parametro")
        Dim cmd As New SqlCommand(consulta, cn)

        
        cmd.Parameters.AddWithValue("@parametro", ComboBox1.SelectedValue)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            TextBox1.Text = Format(CType((reader("SALDO_INICIAL")), Decimal), "$#,##0.00")
            TextBox2.Text = Format(CType((reader("SALDO_ACTUAL")), Decimal), "$#,##0.00")

        End If
        cn.Close()

    End Sub

    Private Sub Saldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        funciones.LlenarComboSaldos(ComboBox1)
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Refresh()
        TextBox2.Refresh()
    End Sub
End Class

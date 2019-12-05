Imports System.Data.SqlClient
Imports System.Data
Public Class Valida_Fechas

    Public cn As New SqlConnection
    Public dr As SqlDataReader

    Public Function Valida_fecha_pedido(ByVal id_orden As String, ByVal fecha_solicitud As Date, ByVal fecha_pedido As Date) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        Dim fecha_orden As String = ("Select FECHA_SOLICITUD from TBL_ORDEN_COMPRA Where ID_ORDEN_COMPRA = '" & id_orden & "'")

        cmd = New SqlCommand("Select TBL_PEDIDOS WHERE fecha_pedido = '" & fecha_solicitud & "' < '" & fecha_orden & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

End Class

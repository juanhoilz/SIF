Imports System.Data.SqlClient
Imports System.Data
Module Generar_Reporte

    Dim cn As New SqlConnection(My.Settings.Conexionbd)

    Public Function carga_orden() As DataTable

        cn.Open()
        Dim dt As New DataTable()
        Dim selecciona_orden As String = "Select *FROM ORDEN_COMPRA"
        Dim cmd As New SqlCommand(selecciona_orden, cn)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
        cn.Close()
    End Function

    Public Function carga_orden_det() As DataSet
        Dim ds As New DataSet()
        cn.Open()
        Dim selecciona_orden_det As String = "Select ¨from ORDEN_COMPRA_DET"
        Dim cmd As New SqlCommand(selecciona_orden_det, cn)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "ORDEN_COMPRA_DET")

        Return ds
        cn.Close()
    End Function

    Public Function Filtra_orden(ByVal id_orden As Integer) As DataSet

        Dim ds As New DataSet
        cn.Open()

        Dim selecciona_id As String = "Select *from ORDEN_COMPRA_DET Where ID_ORDEN_COMPRA = @id_orden_compra"
        Dim cmd As New SqlCommand(selecciona_id, cn)
        cmd.Parameters.AddWithValue("@id_orden_compra", id_orden)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "ORDEN_COMPRA_DET")
        Return ds
    End Function

End Module

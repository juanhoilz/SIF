Imports System.Data.SqlClient
Imports System.Data

Public Class valida_registro_serie
    Public cn As New SqlConnection
    Public dr As SqlDataReader

    Public Function Valida_Existe_serie(ByVal Num_serie As String) As Boolean



        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from TBL_INVENTARIO WHERE NoSERIE = '" & Num_serie & "'", cn)

        dr = cmd.ExecuteReader


        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_Existe_Numero(ByVal Num_inventario As String) As Boolean



        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from TBL_INVENTARIO WHERE NUM_INVENTARIO = '" & Num_inventario & "'", cn)

        dr = cmd.ExecuteReader


        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_Existe_clave(ByVal clave_producto As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from CAT_DESCRIPCION_PRODUCTO WHERE CLAVE_PRODUCTO = '" & clave_producto & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_Existe_grupo(ByVal id_partida As String, ByVal descripcion As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        'cmd = New SqlCommand("Select *from CAT_GRUPOS WHERE ID_PARTIDA = '" & id_partida & "'' AND DESCRIPCION_GRUPO = '" & descripcion & "' ", cn)

        cmd = New SqlCommand("Select *from CAT_GRUPOS WHERE ID_PARTIDA = '" & id_partida & "' AND DESCRIPCION_GRUPO = '" & descripcion & "'", cn)

        dr = cmd.ExecuteReader


        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_Existe_proveedor(ByVal rfc As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from TBL_PROVEEDORES WHERE RFC = '" & rfc & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

End Class

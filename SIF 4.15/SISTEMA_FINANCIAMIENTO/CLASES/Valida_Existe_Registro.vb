Imports System.Data.SqlClient
Imports System.Data

Public Class Valida_Existe_Registro

    Public cn As New SqlConnection
    Public dr As SqlDataReader

    Public Function Valida_Existe(ByVal folio As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from TBL_ORDEN_COMPRA WHERE FOLIO_FISCAL = '" & folio & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_Existe_recepcion(ByVal folio_recepcion As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from TBL_FACTURAS WHERE FOLIO_FISCAL = '" & folio_recepcion & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_Existe_Licitacion(ByVal id_proveedor As String, licitacion As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from TBL_LICITACIONES WHERE ESTATUS = '1' AND  PROVEEDOR_ID = '" & id_proveedor & "' AND NOMBRE_LICITACION = '" & licitacion & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_Existe_pago(ByVal clc As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from TBL_FACTURAS_PAGOS WHERE CLC = '" & clc & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function

    Public Function Valida_usuario(ByVal clave_usuario As String, ByVal contraseña As String) As Boolean

        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Open()

        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("Select *from CAT_USUARIOS WHERE CLAVE_USUARIO = '" & clave_usuario & "' AND CONTRASEÑA = '" & contraseña & "'", cn)

        dr = cmd.ExecuteReader

        If dr.Read Then
            resultado = True
        End If

        dr.Close()

        Return resultado

        cn.Close()

    End Function
End Class

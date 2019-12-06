Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class CONSULTAR_PDF

    Public cn As New SqlConnection
    'Public enunciado As SqlCommand
    'Public respuesta As SqlDataReader
    Dim cmd As SqlCommand
    Public dr As SqlDataReader
    Private Sub CONSULTAR_PDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()


            Dim directorioarchivo As String
            directorioarchivo = System.AppDomain.CurrentDomain.BaseDirectory() & "temp.pdf"

            Dim str_cadena As String
            str_cadena = "Select *from CAT_LICITACIONES Where ID_LICITACION =" & tbIdLicitacion.Text

            'enunciado = New SqlCommand("Select *from CAT_LICITACIONES Where ID_LICITACION =" & tbIdLicitacion.Text, cn)

            dr = Executereader(str_cadena)
            If dr.HasRows Then
                While dr.Read
                    tbIdLicitacion.Text = dr("ID_LICITACION")
                    If dr("DOCUMENTO") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        bytes = dr("DOCUMENTO")
                        Bytesaarchivo(bytes, directorioarchivo)

                        My.Computer.FileSystem.DeleteFile(directorioarchivo)
                    End If
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If respuesta.HasRows Then
        'While respuesta.Read
        'tbIdLicitacion.Text = respuesta("ID_LICITACION")
        'If respuesta("DOCUMENTO") IsNot DBNull.Value Then
        'Dim bytes() As Byte
        'bytes = respuesta("DOCUMENTO")
        'Bytesaarchivo(bytes, directorioarchivo)
        'ArchivoPDF.src = directorioarchivo
        'My.Computer.FileSystem.DeleteFile(directorioarchivo)

        'End If
        'End While
        'End If

        ' respuesta.Close()


    End Sub

    Private Sub Bytesaarchivo(ByVal bytes() As Byte, ByVal path As String)

        Dim k As Long
        If bytes Is Nothing Then Exit Sub
        Try
            k = UBound(bytes)
            Dim FS As New FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)
            FS.Write(bytes, 0, k)
            FS.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Public Function Executereader(ByVal cadenasql As String, Optional i As Integer = 0) As SqlDataReader
        Try
            cmd = New SqlCommand
            cmd.CommandText = cadenasql
            If i = 0 Then
                cmd.CommandType = CommandType.Text
            Else
                cmd.CommandType = CommandType.StoredProcedure
            End If
            cmd.Connection = cn
            Return cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

End Class
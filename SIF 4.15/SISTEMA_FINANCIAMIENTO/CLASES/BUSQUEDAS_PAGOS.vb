Imports System.Data
Imports System.Data.SqlClient

Public Class BUSQUEDAS_PAGOS

    Public cn As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Dim valida_pagos As New Valida_Existe_Registro

    Sub New()
        Try
            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenardgvCLC(ByVal dgv As DataGridView, ByVal id As String, ByVal clc As String)
        Try

            dgv.Columns.Clear()
            'Dim col As New DataGridViewCheckBoxColumn
            'dgv.Columns.Add(col)
            'dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            'dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA, TBL_PROVEEDORES.NOMBRE_PROVEEDOR,FOLIO_CLC, FOLIO_FACTURA, TBL_FACTURAS.TOTAL, TBL_FACTURAS_CLC.IMPORTE_PAGADO, TBL_FACTURAS.TOTAL-TBL_FACTURAS_CLC.IMPORTE_PAGADO AS DIFERENCIA," &
                                               "TBL_PARTIDAS.CLAVE_PARTIDAS,TBL_PARTIDAS.DESCRIPCION " &
                                               "from TBL_FACTURAS_CLC left join TBL_FACTURAS on (TBL_FACTURAS_CLC.FACTURA_ID = TBL_FACTURAS.ID_FACTURA)" &
                                               "left join TBL_PROVEEDORES on (TBL_PROVEEDORES.ID_PROVEEDOR = TBL_FACTURAS.PROVEEDOR_ID)" &
                                               "left join TBL_PARTIDAS on (TBL_FACTURAS.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS)" &
                                               "Where FOLIOS_ID =  '" & id & "' AND  FOLIO_CLC = '" & clc & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Visible = False
            dgv.Columns(1).Width = 250
            dgv.Columns(2).HeaderText = "CLC"
            dgv.Columns(2).Width = 40
            dgv.Columns(3).Width = 100
            dgv.Columns(4).DefaultCellStyle.Format = "n"
            dgv.Columns(5).DefaultCellStyle.Format = "n"
            'dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
            'dgv.Columns(6).DefaultCellStyle.BackColor = Color.FloralWhite
            dgv.Columns(7).DefaultCellStyle.Format = "n"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class

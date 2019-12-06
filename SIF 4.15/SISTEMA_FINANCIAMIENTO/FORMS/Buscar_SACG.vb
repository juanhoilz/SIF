Imports System.Data
Imports System.Data.SqlClient
Public Class Buscar_SACG

    Public cn As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Public leerdatos As SqlDataReader
    Dim funciones As New BASEDATOS

    Private Sub Buscar_SACG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ToolTip1.SetToolTip(Me.cbEjercicio, "Seleccione el ejercicio")
            ToolTip1.SetToolTip(Me.cbBuscar, "Seleccione el campo de búsqueda")
            'funciones.llenacomboejerciciosacg(cbEjercicio)
            tbFactura.Enabled = False
            tbProveedor.Enabled = False
            dtpInicio.Enabled = False
            dtpFin.Enabled = False

        Catch ex As Exception
            MessageBox.Show("No pudo conectarse al servidor, intente de nuevo", "Estatus conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try

            Dim cn As New SqlConnection

            'Se sustituye el servidor en la cadena de conexión

            cn.ConnectionString = "Data Source=192.168.1.99\SQLSAACG;Initial Catalog=" & cbEjercicio.Text & ";User ID=sa;Password=sql2005"
            'cn.ConnectionString = "Data Source=.\SQLSAACG;Initial Catalog=" & cbEjercicio.Text & ";User ID=sa;Password=sql2005"
            cn.Open()

            If cbBuscar.Text = "Factura" Then

                adaptador = New SqlDataAdapter("Select tblCompra.CompraId,tblCompra.FolioFactura,tblProveedor.ProveedorId,tblProveedor.RazonSocial,tblProveedor.RFC,tblCompra.Ejercicio," & _
                "tblCompra.Fecha, tblCompra.FechaVencimiento, tblCompra.FechaPagoProgramado," & _
                "tblCompra.Status, tblCompra.PagoProveedorId from tblCompra left join tblProveedor on tblCompra.ProveedorId = tblProveedor.ProveedorId  Where tblCompra.FolioFactura like '" & "%" + tbFactura.Text + "%" & "'", cn)

                dt = New DataTable
                adaptador.Fill(dt)
                DataGridView1.DataSource = dt

            ElseIf cbBuscar.Text = "Proveedor" Then

                adaptador = New SqlDataAdapter("Select tblCompra.CompraId,tblCompra.FolioFactura,tblProveedor.ProveedorId,tblProveedor.RazonSocial,tblProveedor.RFC,tblCompra.Ejercicio," & _
                "tblCompra.Fecha, tblCompra.FechaVencimiento, tblCompra.FechaPagoProgramado," & _
                "tblCompra.Status, tblCompra.PagoProveedorId from tblCompra left join tblProveedor on tblCompra.ProveedorId = tblProveedor.ProveedorId  Where tblProveedor.RazonSocial like '" & "%" + tbProveedor.Text + "%" & "'", cn)

                dt = New DataTable
                adaptador.Fill(dt)
                DataGridView1.DataSource = dt

            ElseIf cbBuscar.Text = "Fecha" Then

                adaptador = New SqlDataAdapter("Select tblCompra.CompraId,tblCompra.FolioFactura,tblProveedor.ProveedorId,tblProveedor.RazonSocial,tblProveedor.RFC,tblCompra.Ejercicio," & _
                "tblCompra.Fecha, tblCompra.FechaVencimiento, tblCompra.FechaPagoProgramado," & _
                "tblCompra.Status, tblCompra.PagoProveedorId from tblCompra left join tblProveedor on tblCompra.ProveedorId = tblProveedor.ProveedorId  Where convert(varchar(10),tblCompra.Fecha,103) >= '" & dtpInicio.Value & "' and convert(varchar(10),tblCompra.Fecha,103) <= '" & dtpFin.Value & "'", cn)

                dt = New DataTable
                adaptador.Fill(dt)
                DataGridView1.DataSource = dt

            End If
            'Cuenta los registros encontrados y los despliega en un textbox
            lbRegistros.Text = CStr(DataGridView1.RowCount)

            'Muestra el ultimo registro del datagrid
            If DataGridView1.RowCount > 0 Then
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
            Else
                MessageBox.Show("No se encontraron registros", "Valida información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btSeleccionar.Click


    End Sub

    Private Sub cbEjercicio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEjercicio.SelectionChangeCommitted
        Try

            Dim cn As New SqlConnection

            'Se sustituye el servidor en la cadena de conexión
            cn.ConnectionString = "Data Source=192.168.1.99\SQLSAACG;Initial Catalog= SACG0000000 ;User ID=sa;Password=sql2005"
            'cn.ConnectionString = "Data Source=.\SQLSAACG;Initial Catalog= SACG0000000 ;User ID=sa;Password=sql2005"
            cn.Open()

            Dim consulta As String = ("SELECT EntidadId,ESTADO+'  '+CAST(EJERCICIO AS VARCHAR(4)) as DESCRIPCION FROM SACGSYS.dbo.Entidad Where EntidadId = @parametro")

            Dim cmd As New SqlCommand(consulta, cn)

            cmd.Parameters.AddWithValue("@parametro", cbEjercicio.Text.Substring(4, 7))

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read Then

                tbEjercicio.Text = reader("DESCRIPCION")

            End If

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub tbEjercicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbEjercicio.KeyPress

    End Sub

    Private Sub cbBuscar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbBuscar.SelectionChangeCommitted
        If cbBuscar.SelectedIndex = 0 Then
            tbFactura.Enabled = True
            tbProveedor.Enabled = False
            dtpInicio.Enabled = False
            dtpFin.Enabled = False
            tbProveedor.Clear()
        ElseIf cbBuscar.SelectedIndex = 1 Then
            tbFactura.Enabled = False
            tbProveedor.Enabled = True
            dtpInicio.Enabled = False
            dtpFin.Enabled = False
            tbFactura.Clear()
        ElseIf cbBuscar.SelectedIndex = 2 Then
            tbFactura.Enabled = False
            tbProveedor.Enabled = False
            dtpInicio.Enabled = True
            dtpFin.Enabled = True
            tbFactura.Clear()
            tbProveedor.Clear()
        ElseIf cbBuscar.SelectedIndex = 3 Then
            tbFactura.Enabled = True
            tbProveedor.Enabled = True
            dtpInicio.Enabled = False
            dtpFin.Enabled = False
        ElseIf cbBuscar.SelectedIndex = 4 Then
            tbFactura.Enabled = False
            tbProveedor.Enabled = True
            dtpInicio.Enabled = True
            dtpFin.Enabled = True
            tbFactura.Clear()
        ElseIf cbBuscar.SelectedIndex = 5 Then
            tbFactura.Enabled = True
            tbProveedor.Enabled = False
            dtpInicio.Enabled = True
            dtpFin.Enabled = True
            tbProveedor.Clear()
        ElseIf cbBuscar.SelectedIndex = 6 Then
            tbFactura.Enabled = True
            tbProveedor.Enabled = True
            dtpInicio.Enabled = True
            dtpFin.Enabled = True
        End If
    End Sub

    Private Sub cbEjercicio_Enter(sender As Object, e As EventArgs) Handles cbEjercicio.Enter
        funciones.llenacomboejerciciosacg(cbEjercicio)
    End Sub
End Class
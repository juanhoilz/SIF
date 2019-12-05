Imports System.Data
Imports System.Data.SqlClient
Public Class PRINCIPAL
    Public cn As New SqlConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim opcionesproveedor As New Botones_Proveedores
        'Panel_Botones.Controls.Clear()
        'Panel_Botones.Controls.Add(opcionesproveedor)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.Close()
        cn = New SqlConnection(My.Settings.Conexionbd)
        cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim opcionesfacturas As New Botones_Facturas
        'Panel_Botones.Controls.Clear()
        'Panel_Botones.Controls.Add(opcionesfacturas)
        'Panel_Operaciones.Controls.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        CONSULTAR.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim opcionesadministracion As New Botones_Administracion
        'Panel_Botones.Controls.Clear()
        'Panel_Botones.Controls.Add(opcionesadministracion)
        'Panel_Operaciones.Controls.Clear()
    End Sub

    Private Sub PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctl As Control

        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
        'Dim opcionesfacturas As New Botones_Facturas
        'Panel_Botones.Controls.Clear()
        'Panel_Botones.Controls.Add(opcionesfacturas)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        Dim descargar_XML As New DESCARGAR_XML
        'Panel_Operaciones.Controls.Add(descargar_XML)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub AgregarNuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevaToolStripMenuItem.Click
        Altafactura.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 
        Dim opcionesproveedor As New Botones_Proveedores
        'Panel_Botones.Controls.Clear()
        'Panel_Botones.Controls.Add(opcionesproveedor)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If MessageBox.Show("Está seguro que desea salir?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cn.Close()
            Me.Close()
            ACCESO_USUARIOS.Close()
        Else

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Dim opcionesadministracion As New Botones_Administracion
        'Panel_Botones.Controls.Clear()
        'Panel_Botones.Controls.Add(opcionesadministracion)
        'Panel_Operaciones.Controls.Clear()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) 
        Dim opcionesoficios As New Botones_Oficios
        'Panel_Botones.Controls.Clear()
        'Panel_Botones.Controls.Add(opcionesoficios)
    End Sub

    Private Sub RecepcionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepcionarToolStripMenuItem.Click
        'Altafactura.Show()
        Dim NEWMDICHILD As New Altafactura
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub OrdenDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeCompraToolStripMenuItem.Click
        'DOCUMENTAR_ORDEN.Show()

        Dim NEWMDICHILD As New DOCUMENTAR_ORDEN
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoToolStripMenuItem.Click
        'DOCUMENTAR_PEDIDO.Show()
        Dim NEWMDICHILD As New DOCUMENTAR_PEDIDO
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub ValeDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValeDeSalidaToolStripMenuItem.Click
        'DOCUMENTAR_VALE_SALIDA.Show()
        Dim NEWMDICHILD As New DOCUMENTAR_VALE_SALIDA
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub UnidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesToolStripMenuItem.Click
        'ALTA_UNIDADES.ShowDialog()
        Dim NEWMDICHILD As New ALTA_UNIDADES
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        'ACTUALIZAR_ESTATUS.ShowDialog()
        'Altafactura.Show()
        Dim NEWMDICHILD As New ACTUALIZAR_ESTATUS
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub OrdenDeServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeServicioToolStripMenuItem.Click
        Dim NEWMDICHILD As New DOCUMENTAR_ORDEN_SERVICIO
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub SaldosDeLasCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosDeLasCuentasToolStripMenuItem.Click
        REPORTES_ACTIVOS_FIJOS.ShowDialog()
    End Sub

    Private Sub AsignarRecursosAUnidadesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'ASIGNAR_PRESUPUESTO.ShowDialog()
        Dim NEWMDICHILD As New ASIGNAR_PRESUPUESTO
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()

    End Sub

    Private Sub CuentasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem2.Click
        'AGREGAR_CUENTAS.Show()
        Dim NEWMDICHILD As New AGREGAR_CUENTAS
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub AsignarRecursosACuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarRecursosACuentasToolStripMenuItem.Click
        'ADMINISTRAR_CUENTAS.ShowDialog()
        Dim NEWMDICHILD As New ADMINISTRAR_CUENTAS
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub HistóricoToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click

        Dim NEWMDICHILD As New HISTORICO_FACTURA
        NEWMDICHILD.MdiParent = Me
        NEWMDICHILD.Show()

    End Sub

    Private Sub PasivoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasivoToolStripMenuItem1.Click

        Dim NEWMDICHILD As New PASIVO
        NEWMDICHILD.MdiParent = Me
        NEWMDICHILD.Show()

    End Sub

    Private Sub CLCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLCToolStripMenuItem.Click

        Dim NEWMDICHILD As New CLC
        NEWMDICHILD.MdiParent = Me
        NEWMDICHILD.Show()

    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click

        Dim NEWMDICHILD As New PAGOS
        NEWMDICHILD.MdiParent = Me
        NEWMDICHILD.Show()

    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click
        Dim NEWMDICHILD As New ALTA_PERSONAL
        NEWMDICHILD.MdiParent = Me
        NEWMDICHILD.Show()
    End Sub

    Private Sub LicitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicitacionesToolStripMenuItem.Click
        Dim NEWCHILD As New ALTA_LICITACIONES
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub ImportarSoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarSoporteToolStripMenuItem.Click
        'Abre el dialogo para digitlizar
        'Dim proceso As New System.Diagnostics.Process
        'With proceso

        '.StartInfo.FileName = "wiaacmgr.exe" ' Abre el cuadro de dialogo del escaner

        '.Start()
        'End With


        'Altafactura.Show()
        Dim NEWMDICHILD As New DIGITALIZADOS
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click

    End Sub

    Private Sub AsignarPOA_Click(sender As Object, e As EventArgs) Handles AsignarPOA.Click
        'ADMINISTRAR_CUENTAS.ShowDialog()
        Dim NEWMDICHILD As New CARGA_POA
        'Set the parent form of the child window.  
        NEWMDICHILD.MdiParent = Me
        'Display the New form.  
        NEWMDICHILD.Show()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        Dim NEWCHILD As New INVENTARIO
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        Dim NEWCHILD As New ALTA_MARCAS
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub ModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModeloToolStripMenuItem.Click
        Dim NEWCHILD As New ALTA_MODELO
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub GenerarResguardoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarResguardoToolStripMenuItem.Click

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim NEWCHILD As New Producto
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim NEWCHILD As New ALTA_PROVEEDORES
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub GruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem.Click
        Dim NEWCHILD As New ALTA_GRUPO
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub UbicacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbicacionesToolStripMenuItem.Click
        Dim NEWCHILD As New ALTA_UBICACION
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub PRINCIPAL_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        cn.Close()
        ACCESO_USUARIOS.Close()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Dim NEWCHILD As New CONSULTA_INVENTARIO
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub

    Private Sub GenerarReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarReportesToolStripMenuItem.Click
        Dim NEWCHILD As New REPORTES_ACTIVOS_FIJOS
        NEWCHILD.MdiParent = Me
        NEWCHILD.Show()
    End Sub
End Class
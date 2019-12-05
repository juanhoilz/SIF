Imports System.Data
Imports System.Data.SqlClient
Public Class BUSQUEDAS_PASIVO

    Public cn As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public dt As DataTable
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub New()
        Try
            cn = New SqlConnection(My.Settings.Conexionbd)
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenarComboanioejercicio(ByVal cb As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)

                Dim consulta As String = "Select ID,EJERCICIO FROM TBL_EJERCICIOS ORDER BY ID"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                cb.DisplayMember = "EJERCICIO"
                cb.ValueMember = "ID"
                cb.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
    Sub Llenardgvcatunidades(ByVal dgv As DataGridView)
        Try

            adaptador = New SqlDataAdapter("Select ID_UNIDAD AS ID, NOMBRE_UNIDAD from TBL_UNIDADES_ADMINISTRATIVAS ORDER BY NOMBRE_UNIDAD", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 300

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenarcatproveedores(ByVal dgv As DataGridView)
        Try


            adaptador = New SqlDataAdapter("sp_proveedorespasivo", cn)



            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(0).Visible = False
            dgv.Columns(1).Width = 350
            dgv.Columns(2).Width = 100
            dgv.Columns(2).DefaultCellStyle.Format = "n"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenarcatproveedoresdinamico(ByVal dgv As DataGridView, ByVal nombre_proveedor As String)
        Try

            adaptador = New SqlDataAdapter("sp_proveedoresdinamico  @pnombre_proveedor = '" & nombre_proveedor & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(0).Visible = False
            dgv.Columns(1).Width = 350
            dgv.Columns(2).Width = 100
            dgv.Columns(2).DefaultCellStyle.Format = "n"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Llenardgvcatunidadesdinamico(ByVal nombre_unidad As String, ByVal dgv As DataGridView)
        Try

            adaptador = New SqlDataAdapter("Select TBL_UNIDADES_ADMINISTRATIVAS.ID_UNIDAD AS ID, NOMBRE_UNIDAD from TBL_UNIDADES_ADMINISTRATIVAS WHERE (TBL_UNIDADES_ADMINISTRATIVAS.APLICA_PRESUPUESTO = 1)" &
                                          "and TBL_UNIDADES_ADMINISTRATIVAS.NOMBRE_UNIDAD like '" & "%" + nombre_unidad + "%'", cn)


            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.Columns(1).Width = 300

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub llenarcomboestatus(ByVal combobox As ComboBox)
        Try
            Using cn As New SqlConnection(My.Settings.Conexionbd)
                cn.Open()
                Dim consulta As String = "Select ID_ESTATUS,DESCRIPCION from TBL_ESTATUS_FACTURA WHERE (ID_ESTATUS = 2) or (ID_ESTATUS = 4) or (ID_ESTATUS = 5) or (ID_ESTATUS = 6)"
                Dim cmd As New SqlCommand(consulta, cn)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                combobox.DisplayMember = "DESCRIPCION"
                combobox.ValueMember = "ID_ESTATUS"
                combobox.DataSource = dt


            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Sub Llenardgvdetallepresupuesto(ByVal id_unidad As String, ByVal dgv As DataGridView)
        Try

            adaptador = New SqlDataAdapter("Select UNIDAD_ID,SUM(IMPORTE) as PRESUPUESTO FROM TBL_RECURSOS_POA  WHERE TBL_RECURSOS_POA.UNIDAD_ID = '" & id_unidad & "' GROUP BY UNIDAD_ID", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            'dgv.Columns(1).Width = 300
            dgv.Columns(0).HeaderText = "UNIDAD"
            dgv.Columns(1).DefaultCellStyle.Format = "n"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenardgvpasivoTESOFEdinamicoproveedor(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal nombre_proveedor As String)
        Try


            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            dgv.Columns(0).Width = 50
            'SE CREO UN STORE PARA MOSTRAR LOS PROVEEDORES.
            adaptador = New SqlDataAdapter("sp_tesofedinamicoproveedor @punidad_id = '" & id_unidad & "', @pnombre_proveedor = '" & nombre_proveedor & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 250
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 120

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'LLENAR PASIVO El GENERAL

    Sub Llenardgvpasivogeneral(ByVal id_unidad As String, ByVal dgv As DataGridView)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            dgv.Columns(0).Width = 50
            'busqueda en general no especifico cuentas origen
            adaptador = New SqlDataAdapter("sp_pasivogeneral @punidad_id = '" & id_unidad & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 250
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 120

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenardgvpasivoproveedorpartidageneral(ByVal id_unidad As String, ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("sp_pasivopartidageneral @punidad_id = '" & id_unidad & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 50
            dgv.Columns(1).HeaderText = "PARTIDA"
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60
            dgv.Columns(5).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Llenardgvpasivoproveedorgeneral(ByVal id_unidad As String, ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoproveedorgeneral @punidad_id = '" & id_unidad & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 60
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'AQUI TERMINAR LOS LLENADOS DE LOS DATAGRIFWIEV EN BUSQUEDA GENERAL


    'AQUI EMPIEZA LOS LLENADOS DE BUSQUEDA TESOFE
    Sub LlenardgvpasivoTESOFE(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            dgv.Columns(0).Width = 50

            'Usar STORE PASIVO--- ANTES SE LLENABA POR MEDIO DE UNA VISTA LO CUAL OPTAMOS POR CAMBIAR-

            adaptador = New SqlDataAdapter("sp_pasivoTESOFE @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            'CAMBIO
            dgv.Columns(12).ReadOnly = True
            dgv.Columns(13).ReadOnly = True
            dgv.Columns(14).ReadOnly = True
            dgv.Columns(15).ReadOnly = True
            dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 250
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 120
            'CAMBIO
            dgv.Columns(12).Width = 120
            dgv.Columns(13).Visible = False
            dgv.Columns(14).Visible = False
            dgv.Columns(15).Visible = False
            dgv.Columns(16).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenardgvpasivoproveedorpartidaTESOFE(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            'SE REALIZO EL STORE PARA LA BUSQUEDA
            adaptador = New SqlDataAdapter("sp_pasivoprov_partidatesofe @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 50
            dgv.Columns(1).HeaderText = "PARTIDA"
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60
            dgv.Columns(5).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenardgvpasivoproveedorTESOFE(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoproveedortesofe @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 60
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'AQUI TERMINA LA BUSQUEDA POR TESOFE

    'BUSQUEDA POR CUOTA SOCIAL --SE ESTA AGREGANDO ESTA BUSQUEDA 
    Sub LlenardgvpasivoCUOTASOCIAL(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            dgv.Columns(0).Width = 50

            'Usar STORE PASIVO--- ANTES SE LLENABA POR MEDIO DE UNA VISTA LO CUAL OPTAMOS POR CAMBIAR-

            adaptador = New SqlDataAdapter("sp_pasivoCUOTASOCIAL @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            dgv.Columns(12).ReadOnly = True
            dgv.Columns(13).ReadOnly = True
            dgv.Columns(14).ReadOnly = True
            dgv.Columns(15).ReadOnly = True
            dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 250
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 120
            dgv.Columns(12).Width = 120
            dgv.Columns(13).Visible = False
            dgv.Columns(14).Visible = False
            dgv.Columns(15).Visible = False
            dgv.Columns(16).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenardgvpasivoproveedorpartidaCUOTASOCIAL(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            'SE REALIZO EL STORE PARA LA BUSQUEDA
            adaptador = New SqlDataAdapter("sp_pasivoproveedorpartidaCS @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 50
            dgv.Columns(1).HeaderText = "PARTIDA"
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60
            dgv.Columns(5).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub LlenardgvpasivoproveedorCUOTASOCIAL(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoproveedorCUOTASOCIAL @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 60
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'AQUI EMPIEZA LA BUSQUEDA POR APORTACION ESTATAL AE

    Sub LlenardgvpasivoAE(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try

            'genera_checkbox(dgv)

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("sp_pasivoAE  @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            'dgv.Columns(0).Width = 480
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            dgv.Columns(12).ReadOnly = True
            dgv.Columns(13).ReadOnly = True
            dgv.Columns(14).ReadOnly = True
            dgv.Columns(15).ReadOnly = True
            dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 250
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 100
            dgv.Columns(12).Width = 120
            dgv.Columns(13).Visible = False
            dgv.Columns(14).Visible = False
            dgv.Columns(15).Visible = False
            dgv.Columns(16).Visible = False



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Sub LlenardgvpasivoproveedorpartidaAE(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoroveedorpartidaAE @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 50
            dgv.Columns(1).HeaderText = "PARTIDA"
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60
            dgv.Columns(5).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Sub LlenardgvpasivoproveedorAE(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoroveedorAE @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 60
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'AQUI TERMINA LA BUSQUEDA POR APORTACION ESTATAL AE

    'BUSQUEDA POR SEGURO MEDICO SIGLO XXI

    Sub LlenardgvpasivoSMSXXI(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try

            'genera_checkbox(dgv)

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("sp_pasivoSMSXXI  @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            'dgv.Columns(0).Width = 480
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            dgv.Columns(12).ReadOnly = True
            dgv.Columns(13).ReadOnly = True
            dgv.Columns(14).ReadOnly = True
            dgv.Columns(15).ReadOnly = True

            dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 250
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 100
            dgv.Columns(12).Width = 120
            dgv.Columns(13).Visible = False
            dgv.Columns(14).Visible = False
            dgv.Columns(15).Visible = False
            dgv.Columns(16).Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Sub LlenardgvpasivoproveedorpartidaSMSXXI(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoroveedorpartSMSXXI @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 50
            dgv.Columns(1).HeaderText = "PARTIDA"
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60
            dgv.Columns(5).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Sub LlenardgvpasivoproveedorSMSXI(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoproveedorSMSXXI @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 60
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'TERIMNO DE BUSQUEDA POR SIGLO XXI

    'BUSQUEDA POR GASTOS CATASTROFICOS GC
    Sub LlenardgvpasivoGC(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try

            'genera_checkbox(dgv)

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("sp_pasivoGC  @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            'dgv.Columns(0).Width = 480
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            dgv.Columns(12).ReadOnly = True
            dgv.Columns(13).ReadOnly = True
            dgv.Columns(14).ReadOnly = True
            dgv.Columns(15).ReadOnly = True

            dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 250
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 100
            dgv.Columns(12).Width = 120
            dgv.Columns(13).Visible = False
            dgv.Columns(14).Visible = False
            dgv.Columns(15).Visible = False
            dgv.Columns(16).Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Sub LlenardgvpasivoproveedorpartidaGC(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoroveedorpartGC @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 50
            dgv.Columns(1).HeaderText = "PARTIDA"
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60
            dgv.Columns(5).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Sub LlenardgvpasivoproveedorGC(ByVal id_unidad As String, ByVal dgv As DataGridView, ByVal cbejercicio As String)
        Try
            adaptador = New SqlDataAdapter("sp_pasivoproveedorGC @punidad_id = '" & id_unidad & "', @pAnio = '" & cbejercicio & "'", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).Width = 250
            dgv.Columns(1).Width = 60
            dgv.Columns(2).Width = 60
            dgv.Columns(3).Width = 60
            dgv.Columns(4).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'TERMINO DE BUSQUEDA POR GASTOS CATASTRIFICOS GC
    Sub dgvDetalleproveedorTESOFE(ByVal id_proveedor As String, ByVal dgv As DataGridView)
        Try

            dgv.Columns.Clear()
            Dim col As New DataGridViewCheckBoxColumn
            dgv.Columns.Add(col)
            dgv.Columns(dgv.Columns.Count - 1).DisplayIndex = 0
            'col.HeaderText = "SELECCIONAR"
            dgv.Columns(0).Width = 50

            adaptador = New SqlDataAdapter("Select TBL_FACTURAS.ID_FACTURA, TBL_UNIDADES_ADMINISTRATIVAS.NOMBRE_UNIDAD, TBL_PARTIDAS.CLAVE_PARTIDAS, TBL_FACTURAS.FOLIO_FACTURA AS FACTURA, TBL_FACTURAS.FECHA_FACTURA AS FECHA, TBL_FACTURAS.SUBTOTAL, TBL_FACTURAS.IVA, TBL_FACTURAS.ISR, TBL_FACTURAS.TOTAL," &
                                           "TBL_FACTURAS.OBSERVACION, TBL_FACTURAS.FECHA_RECEPCION, TBL_CUENTA_ORIGEN.NOMBRE_COMPLETO from TBL_FACTURAS left join TBL_PROVEEDORES on (TBL_FACTURAS.PROVEEDOR_ID = TBL_PROVEEDORES.ID_PROVEEDOR)" &
                                           "left join TBL_PARTIDAS on (TBL_FACTURAS.PARTIDA_ID = TBL_PARTIDAS.ID_PARTIDAS)" &
                                           "left join TBL_ESTATUS_FACTURA on (TBL_ESTATUS_FACTURA.ID_ESTATUS = TBL_FACTURAS.ESTATUS_ID)" &
                                           "left join TBL_CUENTA_ORIGEN on (TBL_CUENTA_ORIGEN.ID_FUENTE = TBL_FACTURAS.FUENTE_ID)" &
                                           "left join TBL_UNIDADES_ADMINISTRATIVAS on (TBL_UNIDADES_ADMINISTRATIVAS.ID_UNIDAD = TBL_FACTURAS.UNIDAD_ID)" &
                                           "Where TBL_FACTURAS.ESTATUS_ID = '1' AND (TBL_FACTURAS.FUENTE_ID = 1) AND TBL_FACTURAS.PROVEEDOR_ID = '" & id_proveedor & "'ORDER BY TBL_PROVEEDORES.NOMBRE_PROVEEDOR, TBL_FACTURAS.PARTIDA_ID", cn)

            dt = New DataTable

            adaptador.Fill(dt)
            dgv.DataSource = dt

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.Columns(0).ReadOnly = False
            dgv.Columns(1).Visible = False
            'dgv.Columns(1).ReadOnly = True
            dgv.Columns(1).ReadOnly = True
            dgv.Columns(2).ReadOnly = True
            dgv.Columns(3).ReadOnly = True
            dgv.Columns(4).ReadOnly = True
            dgv.Columns(5).ReadOnly = True
            dgv.Columns(6).ReadOnly = True
            dgv.Columns(7).ReadOnly = True
            dgv.Columns(8).ReadOnly = True
            dgv.Columns(9).ReadOnly = True
            dgv.Columns(10).ReadOnly = True
            dgv.Columns(11).ReadOnly = True
            'dgv.Columns(1).Visible = False
            dgv.Columns(2).Width = 400
            dgv.Columns(2).Width = 50
            dgv.Columns(3).Width = 50
            dgv.Columns(3).HeaderText = "PARTIDA"
            dgv.Columns(4).Width = 100
            dgv.Columns(5).Width = 80
            dgv.Columns(6).Width = 80
            dgv.Columns(6).DefaultCellStyle.Format = "n"
            dgv.Columns(7).Width = 60
            dgv.Columns(7).DefaultCellStyle.Format = "n"
            dgv.Columns(8).Width = 60
            dgv.Columns(8).DefaultCellStyle.Format = "n"
            dgv.Columns(9).Width = 80
            dgv.Columns(9).DefaultCellStyle.Format = "n"
            dgv.Columns(10).Width = 150
            dgv.Columns(11).Width = 120
            dgv.Columns(12).Width = 125

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ACTUALIZAR_ESTATUS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTUALIZAR_ESTATUS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbTotalenviopago = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbTotalcancelado = New System.Windows.Forms.Label()
        Me.lbTotalpagado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbTotalcomprometido = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbTotalregistros = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbTotalenviopagoselec = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbtotalcomprometidoselect = New System.Windows.Forms.Label()
        Me.lbCanceladoselec = New System.Windows.Forms.Label()
        Me.lbPagado = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbcomprometidoselec = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFechapago = New System.Windows.Forms.DateTimePicker()
        Me.cbEstatusfiltro = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbActivarfiltro = New System.Windows.Forms.CheckBox()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCLC = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbPago = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACTUALIZA ESTATUS DE FACTURA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filtro:"
        '
        'cbFiltro
        '
        Me.cbFiltro.BackColor = System.Drawing.Color.Gray
        Me.cbFiltro.ForeColor = System.Drawing.SystemColors.Window
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Nombre proveedor", "RFC", "Factura", "Fecha factura", "Fecha recepción", "Folio fiscal", "Descripción", "Proveedor y fecha factura", "Proveedor y fecha recepción"})
        Me.cbFiltro.Location = New System.Drawing.Point(106, 73)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(177, 21)
        Me.cbFiltro.TabIndex = 2
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AllowUserToAddRows = False
        Me.dgvConsulta.AllowUserToDeleteRows = False
        Me.dgvConsulta.AllowUserToResizeRows = False
        Me.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsulta.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvConsulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvConsulta.Location = New System.Drawing.Point(26, 386)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsulta.Size = New System.Drawing.Size(1160, 302)
        Me.dgvConsulta.TabIndex = 3
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Location = New System.Drawing.Point(477, 147)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(72, 29)
        Me.btBuscar.TabIndex = 6
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'cbEstatus
        '
        Me.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatus.FormattingEnabled = True
        Me.cbEstatus.Location = New System.Drawing.Point(106, 228)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(177, 21)
        Me.cbEstatus.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(301, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 29)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbFactura
        '
        Me.tbFactura.Location = New System.Drawing.Point(106, 152)
        Me.tbFactura.Name = "tbFactura"
        Me.tbFactura.Size = New System.Drawing.Size(345, 20)
        Me.tbFactura.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Buscar:"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(106, 190)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(81, 20)
        Me.dtpInicio.TabIndex = 14
        Me.dtpInicio.Value = New Date(2018, 6, 19, 0, 0, 0, 0)
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(220, 190)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(81, 20)
        Me.dtpFin.TabIndex = 15
        Me.dtpFin.Value = New Date(2018, 6, 19, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 14)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fecha:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(194, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Al"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lbTotalenviopago)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lbTotalcancelado)
        Me.GroupBox1.Controls.Add(Me.lbTotalpagado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbTotalcomprometido)
        Me.GroupBox1.Controls.Add(Me.lbTotal)
        Me.GroupBox1.Controls.Add(Me.lbTotalregistros)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(663, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 206)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen de la búsqueda"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label20.Location = New System.Drawing.Point(23, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Total registros"
        '
        'lbTotalenviopago
        '
        Me.lbTotalenviopago.AutoSize = True
        Me.lbTotalenviopago.Location = New System.Drawing.Point(136, 150)
        Me.lbTotalenviopago.Name = "lbTotalenviopago"
        Me.lbTotalenviopago.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalenviopago.TabIndex = 13
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(23, 149)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 13)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Importe envío a pago:"
        '
        'lbTotalcancelado
        '
        Me.lbTotalcancelado.AutoSize = True
        Me.lbTotalcancelado.Location = New System.Drawing.Point(121, 177)
        Me.lbTotalcancelado.Name = "lbTotalcancelado"
        Me.lbTotalcancelado.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalcancelado.TabIndex = 11
        '
        'lbTotalpagado
        '
        Me.lbTotalpagado.AutoSize = True
        Me.lbTotalpagado.Location = New System.Drawing.Point(114, 119)
        Me.lbTotalpagado.Name = "lbTotalpagado"
        Me.lbTotalpagado.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalpagado.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Importe cancelado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Importe pagado:"
        '
        'lbTotalcomprometido
        '
        Me.lbTotalcomprometido.AutoSize = True
        Me.lbTotalcomprometido.Location = New System.Drawing.Point(143, 87)
        Me.lbTotalcomprometido.Name = "lbTotalcomprometido"
        Me.lbTotalcomprometido.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalcomprometido.TabIndex = 6
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(98, 55)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(0, 13)
        Me.lbTotal.TabIndex = 5
        '
        'lbTotalregistros
        '
        Me.lbTotalregistros.AutoSize = True
        Me.lbTotalregistros.Location = New System.Drawing.Point(107, 27)
        Me.lbTotalregistros.Name = "lbTotalregistros"
        Me.lbTotalregistros.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalregistros.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Importe comprometido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Importe total:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbTotalenviopagoselec)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lbtotalcomprometidoselect)
        Me.GroupBox2.Controls.Add(Me.lbCanceladoselec)
        Me.GroupBox2.Controls.Add(Me.lbPagado)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lbcomprometidoselec)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Location = New System.Drawing.Point(942, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 204)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumen de la selección"
        '
        'lbTotalenviopagoselec
        '
        Me.lbTotalenviopagoselec.AutoSize = True
        Me.lbTotalenviopagoselec.Location = New System.Drawing.Point(137, 148)
        Me.lbTotalenviopagoselec.Name = "lbTotalenviopagoselec"
        Me.lbTotalenviopagoselec.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalenviopagoselec.TabIndex = 15
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(23, 148)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 13)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Importe envío a pago:"
        '
        'lbtotalcomprometidoselect
        '
        Me.lbtotalcomprometidoselect.AutoSize = True
        Me.lbtotalcomprometidoselect.Location = New System.Drawing.Point(132, 89)
        Me.lbtotalcomprometidoselect.Name = "lbtotalcomprometidoselect"
        Me.lbtotalcomprometidoselect.Size = New System.Drawing.Size(0, 13)
        Me.lbtotalcomprometidoselect.TabIndex = 12
        '
        'lbCanceladoselec
        '
        Me.lbCanceladoselec.AutoSize = True
        Me.lbCanceladoselec.Location = New System.Drawing.Point(131, 174)
        Me.lbCanceladoselec.Name = "lbCanceladoselec"
        Me.lbCanceladoselec.Size = New System.Drawing.Size(0, 13)
        Me.lbCanceladoselec.TabIndex = 11
        '
        'lbPagado
        '
        Me.lbPagado.AutoSize = True
        Me.lbPagado.Location = New System.Drawing.Point(114, 117)
        Me.lbPagado.Name = "lbPagado"
        Me.lbPagado.Size = New System.Drawing.Size(0, 13)
        Me.lbPagado.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Importe cancelado:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Importe pagado:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(163, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(98, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(107, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 13)
        Me.Label19.TabIndex = 4
        '
        'lbcomprometidoselec
        '
        Me.lbcomprometidoselec.AutoSize = True
        Me.lbcomprometidoselec.Location = New System.Drawing.Point(24, 87)
        Me.lbcomprometidoselec.Name = "lbcomprometidoselec"
        Me.lbcomprometidoselec.Size = New System.Drawing.Size(114, 13)
        Me.lbcomprometidoselec.TabIndex = 3
        Me.lbcomprometidoselec.Text = "Importe comprometido:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(23, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Importe total:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(24, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Total registros:"
        '
        'dtpFechapago
        '
        Me.dtpFechapago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechapago.Location = New System.Drawing.Point(106, 269)
        Me.dtpFechapago.Name = "dtpFechapago"
        Me.dtpFechapago.Size = New System.Drawing.Size(81, 20)
        Me.dtpFechapago.TabIndex = 25
        '
        'cbEstatusfiltro
        '
        Me.cbEstatusfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatusfiltro.FormattingEnabled = True
        Me.cbEstatusfiltro.Location = New System.Drawing.Point(106, 111)
        Me.cbEstatusfiltro.Name = "cbEstatusfiltro"
        Me.cbEstatusfiltro.Size = New System.Drawing.Size(177, 21)
        Me.cbEstatusfiltro.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Filtro estatus:"
        '
        'cbActivarfiltro
        '
        Me.cbActivarfiltro.AutoSize = True
        Me.cbActivarfiltro.Location = New System.Drawing.Point(301, 113)
        Me.cbActivarfiltro.Name = "cbActivarfiltro"
        Me.cbActivarfiltro.Size = New System.Drawing.Size(81, 17)
        Me.cbActivarfiltro.TabIndex = 29
        Me.cbActivarfiltro.Text = "Activar filtro"
        Me.cbActivarfiltro.UseVisualStyleBackColor = True
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Location = New System.Drawing.Point(747, 283)
        Me.tbObservaciones.MaxLength = 100
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(439, 29)
        Me.tbObservaciones.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(660, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 14)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Observaciones:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(21, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 14)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Fecha de pago:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(57, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 14)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Estatus:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(70, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "CLC:"
        '
        'tbCLC
        '
        Me.tbCLC.Location = New System.Drawing.Point(106, 306)
        Me.tbCLC.Name = "tbCLC"
        Me.tbCLC.Size = New System.Drawing.Size(85, 20)
        Me.tbCLC.TabIndex = 82
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(20, 343)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 14)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "Ajuste de pago:"
        '
        'cbPago
        '
        Me.cbPago.Location = New System.Drawing.Point(106, 343)
        Me.cbPago.Name = "cbPago"
        Me.cbPago.Size = New System.Drawing.Size(85, 20)
        Me.cbPago.TabIndex = 84
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1213, 25)
        Me.ToolStrip1.TabIndex = 85
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton1.Text = "Editar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton2.Text = "Imprimir"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton3.Text = "Exportar"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(208, 345)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox1.TabIndex = 86
        Me.CheckBox1.Text = "Disminuir"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ACTUALIZAR_ESTATUS
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 712)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cbPago)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.tbCLC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbObservaciones)
        Me.Controls.Add(Me.cbActivarfiltro)
        Me.Controls.Add(Me.cbEstatusfiltro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFechapago)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbFactura)
        Me.Controls.Add(Me.cbEstatus)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvConsulta)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACTUALIZAR_ESTATUS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZAR_ESTATUS"
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents dgvConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents cbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbTotalregistros As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents lbTotalcomprometido As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbTotalcancelado As System.Windows.Forms.Label
    Friend WithEvents lbTotalpagado As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCanceladoselec As System.Windows.Forms.Label
    Friend WithEvents lbPagado As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbcomprometidoselec As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lbtotalcomprometidoselect As Label
    Friend WithEvents dtpFechapago As DateTimePicker
    Friend WithEvents cbEstatusfiltro As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbActivarfiltro As CheckBox
    Friend WithEvents lbTotalenviopago As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbTotalenviopagoselec As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents tbObservaciones As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCLC As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cbPago As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents CheckBox1 As CheckBox
End Class

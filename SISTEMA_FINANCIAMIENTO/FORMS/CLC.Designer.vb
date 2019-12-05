<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CLC
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbCLC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvEnviopago = New System.Windows.Forms.DataGridView()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btContinuar = New System.Windows.Forms.Button()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbPartida = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbFuente = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbBuscar = New System.Windows.Forms.ComboBox()
        Me.cbCuenta = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvCLC = New System.Windows.Forms.DataGridView()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.lbImporte = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbFoliosCLC = New System.Windows.Forms.ComboBox()
        Me.lbDuplicados = New System.Windows.Forms.Label()
        CType(Me.dgvEnviopago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvCLC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCLC
        '
        Me.tbCLC.Location = New System.Drawing.Point(127, 120)
        Me.tbCLC.Name = "tbCLC"
        Me.tbCLC.Size = New System.Drawing.Size(85, 20)
        Me.tbCLC.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(92, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "CLC:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 14)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Fecha CLC:"
        '
        'dgvEnviopago
        '
        Me.dgvEnviopago.AllowUserToAddRows = False
        Me.dgvEnviopago.AllowUserToDeleteRows = False
        Me.dgvEnviopago.AllowUserToResizeRows = False
        Me.dgvEnviopago.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvEnviopago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEnviopago.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEnviopago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEnviopago.Location = New System.Drawing.Point(21, 290)
        Me.dgvEnviopago.Name = "dgvEnviopago"
        Me.dgvEnviopago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnviopago.Size = New System.Drawing.Size(699, 336)
        Me.dgvEnviopago.TabIndex = 90
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(127, 157)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(81, 20)
        Me.dtpFecha.TabIndex = 94
        Me.dtpFecha.Value = New Date(2018, 6, 19, 0, 0, 0, 0)
        '
        'btGuardar
        '
        Me.btGuardar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.guardar
        Me.btGuardar.Location = New System.Drawing.Point(797, 225)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(72, 38)
        Me.btGuardar.TabIndex = 115
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btImprimir
        '
        Me.btImprimir.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.Printer_32_02
        Me.btImprimir.Location = New System.Drawing.Point(889, 225)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(72, 38)
        Me.btImprimir.TabIndex = 116
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton6, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1132, 25)
        Me.ToolStrip1.TabIndex = 117
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.edit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton2.Text = "Editar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.Printer_32
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripButton3.Text = "Reimpresión"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.add_file_256
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripButton4.Text = "Asignar folios"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.approve_invoice__2_
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton6.Text = "Listados"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.puerta_de_salida_con_la_flecha_hacia_la_derecha_318_405971
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton5.Text = "Salir"
        '
        'cbEjercicio
        '
        Me.cbEjercicio.BackColor = System.Drawing.SystemColors.Window
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Location = New System.Drawing.Point(127, 228)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(177, 21)
        Me.cbEjercicio.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Ejercicio"
        '
        'btContinuar
        '
        Me.btContinuar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btContinuar.Location = New System.Drawing.Point(703, 225)
        Me.btContinuar.Name = "btContinuar"
        Me.btContinuar.Size = New System.Drawing.Size(72, 38)
        Me.btContinuar.TabIndex = 121
        Me.btContinuar.Text = "Buscar"
        Me.btContinuar.UseVisualStyleBackColor = True
        '
        'cbProveedores
        '
        Me.cbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.DropDownWidth = 420
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(702, 120)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(308, 21)
        Me.cbProveedores.TabIndex = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(600, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Nombre proveedor"
        '
        'cbPartida
        '
        Me.cbPartida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPartida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartida.DropDownWidth = 560
        Me.cbPartida.FormattingEnabled = True
        Me.cbPartida.Location = New System.Drawing.Point(702, 156)
        Me.cbPartida.Name = "cbPartida"
        Me.cbPartida.Size = New System.Drawing.Size(309, 21)
        Me.cbPartida.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(654, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Partida"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(619, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "financiamiento"
        '
        'cbFuente
        '
        Me.cbFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuente.DropDownWidth = 300
        Me.cbFuente.FormattingEnabled = True
        Me.cbFuente.Location = New System.Drawing.Point(702, 52)
        Me.cbFuente.Name = "cbFuente"
        Me.cbFuente.Size = New System.Drawing.Size(259, 21)
        Me.cbFuente.TabIndex = 127
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(653, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Fuente"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(127, 88)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(282, 20)
        Me.tbBuscar.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 14)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Buscar por"
        '
        'cbBuscar
        '
        Me.cbBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbBuscar.FormattingEnabled = True
        Me.cbBuscar.Items.AddRange(New Object() {"CLC", "Proveedor", "Factura"})
        Me.cbBuscar.Location = New System.Drawing.Point(127, 52)
        Me.cbBuscar.Name = "cbBuscar"
        Me.cbBuscar.Size = New System.Drawing.Size(177, 21)
        Me.cbBuscar.TabIndex = 132
        '
        'cbCuenta
        '
        Me.cbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuenta.FormattingEnabled = True
        Me.cbCuenta.Location = New System.Drawing.Point(702, 87)
        Me.cbCuenta.Name = "cbCuenta"
        Me.cbCuenta.Size = New System.Drawing.Size(259, 21)
        Me.cbCuenta.TabIndex = 134
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(601, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 135
        Me.Label16.Text = "Número de cuenta"
        '
        'dgvCLC
        '
        Me.dgvCLC.AllowUserToAddRows = False
        Me.dgvCLC.AllowUserToResizeRows = False
        Me.dgvCLC.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvCLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCLC.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCLC.Location = New System.Drawing.Point(830, 290)
        Me.dgvCLC.Name = "dgvCLC"
        Me.dgvCLC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCLC.Size = New System.Drawing.Size(280, 336)
        Me.dgvCLC.TabIndex = 136
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(727, 398)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(97, 29)
        Me.btAgregar.TabIndex = 137
        Me.btAgregar.Text = "Agrega al CLC"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Location = New System.Drawing.Point(415, 83)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(72, 29)
        Me.btBuscar.TabIndex = 139
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'lbImporte
        '
        Me.lbImporte.AutoSize = True
        Me.lbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbImporte.ForeColor = System.Drawing.Color.Black
        Me.lbImporte.Location = New System.Drawing.Point(764, 195)
        Me.lbImporte.Name = "lbImporte"
        Me.lbImporte.Size = New System.Drawing.Size(32, 16)
        Me.lbImporte.TabIndex = 141
        Me.lbImporte.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(700, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "IMPORTE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Folios"
        '
        'cbFoliosCLC
        '
        Me.cbFoliosCLC.BackColor = System.Drawing.SystemColors.Window
        Me.cbFoliosCLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFoliosCLC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbFoliosCLC.FormattingEnabled = True
        Me.cbFoliosCLC.Location = New System.Drawing.Point(127, 194)
        Me.cbFoliosCLC.Name = "cbFoliosCLC"
        Me.cbFoliosCLC.Size = New System.Drawing.Size(177, 21)
        Me.cbFoliosCLC.TabIndex = 142
        '
        'lbDuplicados
        '
        Me.lbDuplicados.AutoSize = True
        Me.lbDuplicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDuplicados.ForeColor = System.Drawing.Color.Red
        Me.lbDuplicados.Location = New System.Drawing.Point(903, 273)
        Me.lbDuplicados.Name = "lbDuplicados"
        Me.lbDuplicados.Size = New System.Drawing.Size(143, 13)
        Me.lbDuplicados.TabIndex = 144
        Me.lbDuplicados.Text = "!Existen registros duplicados!"
        '
        'CLC
        '
        Me.AcceptButton = Me.btContinuar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 646)
        Me.Controls.Add(Me.lbDuplicados)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbFoliosCLC)
        Me.Controls.Add(Me.lbImporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.dgvCLC)
        Me.Controls.Add(Me.cbCuenta)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbBuscar)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbFuente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbPartida)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbProveedores)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btContinuar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.tbCLC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvEnviopago)
        Me.Controls.Add(Me.dtpFecha)
        Me.Name = "CLC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTA POR LIQUIDAR CERTIFICADA"
        CType(Me.dgvEnviopago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvCLC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCLC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvEnviopago As DataGridView
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btGuardar As Button
    Friend WithEvents btImprimir As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents cbEjercicio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btContinuar As Button
    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbPartida As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbFuente As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbBuscar As ComboBox
    Friend WithEvents cbCuenta As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvCLC As DataGridView
    Friend WithEvents btAgregar As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents lbImporte As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbFoliosCLC As ComboBox
    Friend WithEvents lbDuplicados As Label
    Friend WithEvents ToolStripButton6 As ToolStripButton
End Class

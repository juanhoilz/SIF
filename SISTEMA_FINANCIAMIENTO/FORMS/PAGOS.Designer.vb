<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PAGOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAGOS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbDiferencia = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbImportepoliza = New System.Windows.Forms.TextBox()
        Me.tbejercicio = New System.Windows.Forms.TextBox()
        Me.cbInstancia = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPoliza = New System.Windows.Forms.TextBox()
        Me.btValidar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFechapago = New System.Windows.Forms.DateTimePicker()
        Me.tbFolioSIAFF = New System.Windows.Forms.TextBox()
        Me.lbImporte = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCLC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbRecurso = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvDetalleCLC = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbRutaarchivo = New System.Windows.Forms.TextBox()
        Me.lbEstatusdocumento = New System.Windows.Forms.Label()
        Me.Verificar = New System.Windows.Forms.PictureBox()
        Me.btImportar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvDetalleCLC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Verificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 14)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "Fecha de pago:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbDiferencia)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbImportepoliza)
        Me.GroupBox1.Controls.Add(Me.tbejercicio)
        Me.GroupBox1.Controls.Add(Me.cbInstancia)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbPoliza)
        Me.GroupBox1.Controls.Add(Me.btValidar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpFechapago)
        Me.GroupBox1.Controls.Add(Me.tbFolioSIAFF)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox1.Location = New System.Drawing.Point(513, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 192)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del pago"
        '
        'lbDiferencia
        '
        Me.lbDiferencia.AutoSize = True
        Me.lbDiferencia.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiferencia.ForeColor = System.Drawing.Color.Black
        Me.lbDiferencia.Location = New System.Drawing.Point(287, 159)
        Me.lbDiferencia.Name = "lbDiferencia"
        Me.lbDiferencia.Size = New System.Drawing.Size(0, 15)
        Me.lbDiferencia.TabIndex = 138
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 14)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Importe póliza:"
        '
        'tbImportepoliza
        '
        Me.tbImportepoliza.BackColor = System.Drawing.Color.White
        Me.tbImportepoliza.Location = New System.Drawing.Point(104, 156)
        Me.tbImportepoliza.Name = "tbImportepoliza"
        Me.tbImportepoliza.Size = New System.Drawing.Size(177, 20)
        Me.tbImportepoliza.TabIndex = 9
        '
        'tbejercicio
        '
        Me.tbejercicio.BackColor = System.Drawing.Color.White
        Me.tbejercicio.Enabled = False
        Me.tbejercicio.Location = New System.Drawing.Point(287, 85)
        Me.tbejercicio.Name = "tbejercicio"
        Me.tbejercicio.Size = New System.Drawing.Size(177, 20)
        Me.tbejercicio.TabIndex = 6
        '
        'cbInstancia
        '
        Me.cbInstancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInstancia.FormattingEnabled = True
        Me.cbInstancia.Location = New System.Drawing.Point(104, 85)
        Me.cbInstancia.Name = "cbInstancia"
        Me.cbInstancia.Size = New System.Drawing.Size(177, 21)
        Me.cbInstancia.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 14)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "Instancia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 14)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Folio SAACG.NET:"
        '
        'tbPoliza
        '
        Me.tbPoliza.BackColor = System.Drawing.Color.White
        Me.tbPoliza.Location = New System.Drawing.Point(104, 120)
        Me.tbPoliza.Name = "tbPoliza"
        Me.tbPoliza.Size = New System.Drawing.Size(177, 20)
        Me.tbPoliza.TabIndex = 7
        '
        'btValidar
        '
        Me.btValidar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btValidar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_comprobado_16
        Me.btValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btValidar.Location = New System.Drawing.Point(287, 116)
        Me.btValidar.Name = "btValidar"
        Me.btValidar.Size = New System.Drawing.Size(67, 26)
        Me.btValidar.TabIndex = 8
        Me.btValidar.Text = "Validar"
        Me.btValidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btValidar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Folio SIAFF:"
        '
        'dtpFechapago
        '
        Me.dtpFechapago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechapago.Location = New System.Drawing.Point(104, 53)
        Me.dtpFechapago.Name = "dtpFechapago"
        Me.dtpFechapago.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechapago.TabIndex = 4
        '
        'tbFolioSIAFF
        '
        Me.tbFolioSIAFF.BackColor = System.Drawing.Color.White
        Me.tbFolioSIAFF.Location = New System.Drawing.Point(104, 23)
        Me.tbFolioSIAFF.Name = "tbFolioSIAFF"
        Me.tbFolioSIAFF.Size = New System.Drawing.Size(85, 20)
        Me.tbFolioSIAFF.TabIndex = 3
        '
        'lbImporte
        '
        Me.lbImporte.AutoSize = True
        Me.lbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbImporte.ForeColor = System.Drawing.Color.Black
        Me.lbImporte.Location = New System.Drawing.Point(202, 209)
        Me.lbImporte.Name = "lbImporte"
        Me.lbImporte.Size = New System.Drawing.Size(45, 24)
        Me.lbImporte.TabIndex = 114
        Me.lbImporte.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(100, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "TOTAL CLC:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 14)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "CLC contabilidad:"
        '
        'tbCLC
        '
        Me.tbCLC.BackColor = System.Drawing.Color.White
        Me.tbCLC.Location = New System.Drawing.Point(103, 160)
        Me.tbCLC.Name = "tbCLC"
        Me.tbCLC.Size = New System.Drawing.Size(97, 20)
        Me.tbCLC.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 14)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Folio de pago:"
        '
        'tbFolio
        '
        Me.tbFolio.Enabled = False
        Me.tbFolio.Location = New System.Drawing.Point(103, 77)
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.Size = New System.Drawing.Size(97, 20)
        Me.tbFolio.TabIndex = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 19)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "REGISTRAR PAGOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Recurso:"
        '
        'cbRecurso
        '
        Me.cbRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRecurso.FormattingEnabled = True
        Me.cbRecurso.Items.AddRange(New Object() {"Registrar", "Editar", "Cancelar"})
        Me.cbRecurso.Location = New System.Drawing.Point(103, 115)
        Me.cbRecurso.Name = "cbRecurso"
        Me.cbRecurso.Size = New System.Drawing.Size(212, 21)
        Me.cbRecurso.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1043, 25)
        Me.ToolStrip1.TabIndex = 133
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.WorkItem_32xLG
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripButton1.Text = "Listado CLC"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton3.Text = "Consultar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.puerta_de_salida_con_la_flecha_hacia_la_derecha_318_405972
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Location = New System.Drawing.Point(207, 157)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(62, 27)
        Me.btBuscar.TabIndex = 126
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(185, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 24)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "$"
        '
        'dgvDetalleCLC
        '
        Me.dgvDetalleCLC.AllowUserToAddRows = False
        Me.dgvDetalleCLC.AllowUserToDeleteRows = False
        Me.dgvDetalleCLC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleCLC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalleCLC.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalleCLC.Location = New System.Drawing.Point(15, 327)
        Me.dgvDetalleCLC.Name = "dgvDetalleCLC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleCLC.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalleCLC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCLC.Size = New System.Drawing.Size(1016, 233)
        Me.dgvDetalleCLC.TabIndex = 135
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(611, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 14)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = "Importar soporte"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(736, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 14)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "Guardar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 301)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 14)
        Me.Label14.TabIndex = 143
        Me.Label14.Text = "Ruta archivo"
        '
        'tbRutaarchivo
        '
        Me.tbRutaarchivo.BackColor = System.Drawing.Color.White
        Me.tbRutaarchivo.Location = New System.Drawing.Point(83, 299)
        Me.tbRutaarchivo.Name = "tbRutaarchivo"
        Me.tbRutaarchivo.ReadOnly = True
        Me.tbRutaarchivo.Size = New System.Drawing.Size(232, 20)
        Me.tbRutaarchivo.TabIndex = 142
        '
        'lbEstatusdocumento
        '
        Me.lbEstatusdocumento.AutoSize = True
        Me.lbEstatusdocumento.ForeColor = System.Drawing.Color.Green
        Me.lbEstatusdocumento.Location = New System.Drawing.Point(338, 302)
        Me.lbEstatusdocumento.Name = "lbEstatusdocumento"
        Me.lbEstatusdocumento.Size = New System.Drawing.Size(175, 13)
        Me.lbEstatusdocumento.TabIndex = 145
        Me.lbEstatusdocumento.Text = "Documento cargado correctamente"
        '
        'Verificar
        '
        Me.Verificar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_comprobado_16
        Me.Verificar.Location = New System.Drawing.Point(318, 301)
        Me.Verificar.Name = "Verificar"
        Me.Verificar.Size = New System.Drawing.Size(16, 20)
        Me.Verificar.TabIndex = 144
        Me.Verificar.TabStop = False
        '
        'btImportar
        '
        Me.btImportar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_pdf_32
        Me.btImportar.Location = New System.Drawing.Point(617, 254)
        Me.btImportar.Name = "btImportar"
        Me.btImportar.Size = New System.Drawing.Size(72, 42)
        Me.btImportar.TabIndex = 139
        Me.btImportar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.guardar1
        Me.Button1.Location = New System.Drawing.Point(722, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PAGOS
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 568)
        Me.Controls.Add(Me.lbEstatusdocumento)
        Me.Controls.Add(Me.Verificar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbRutaarchivo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btImportar)
        Me.Controls.Add(Me.dgvDetalleCLC)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.cbRecurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCLC)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbImporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PAGOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                                      SISTEMA INTEGRAL DE FINANCIAMIENTO - PAGOS" &
    " -"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvDetalleCLC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Verificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbImporte As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbFolioSIAFF As TextBox
    Friend WithEvents dtpFechapago As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCLC As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbFolio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPoliza As TextBox
    Friend WithEvents btValidar As Button
    Friend WithEvents tbejercicio As TextBox
    Friend WithEvents cbInstancia As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbImportepoliza As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbRecurso As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents lbDiferencia As Label
    Friend WithEvents dgvDetalleCLC As DataGridView
    Friend WithEvents btImportar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbRutaarchivo As TextBox
    Friend WithEvents lbEstatusdocumento As Label
    Friend WithEvents Verificar As PictureBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class

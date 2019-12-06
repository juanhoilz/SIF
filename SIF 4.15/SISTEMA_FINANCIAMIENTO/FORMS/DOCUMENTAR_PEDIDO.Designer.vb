<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOCUMENTAR_PEDIDO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DOCUMENTAR_PEDIDO))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvOrdencompra = New System.Windows.Forms.DataGridView()
        Me.cbMotivopedido = New System.Windows.Forms.ComboBox()
        Me.dtpPedido = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbPartida = New System.Windows.Forms.Label()
        Me.tbNumerosletras = New System.Windows.Forms.TextBox()
        Me.cbPartidas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbIdorden = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbMontoestimado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbFolio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.tbArea = New System.Windows.Forms.TextBox()
        Me.tbAplica = New System.Windows.Forms.TextBox()
        Me.tbProveedor = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbSolicita = New System.Windows.Forms.TextBox()
        Me.tbAutoriza = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTipoadquisiciones = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        Me.tbIva = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbFirmapedido = New System.Windows.Forms.ComboBox()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.tbFechasolicitud = New System.Windows.Forms.TextBox()
        Me.tbRetencion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btConsultarpartidas = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbClaveprograma = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbLugarentrega = New System.Windows.Forms.ComboBox()
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvOrdencompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1061, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton2.Text = "Modificar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripButton3.Text = "Salir"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(637, 217)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(184, 20)
        Me.tbTotal.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(596, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Total"
        '
        'dgvOrdencompra
        '
        Me.dgvOrdencompra.AllowUserToAddRows = False
        Me.dgvOrdencompra.AllowUserToDeleteRows = False
        Me.dgvOrdencompra.AllowUserToResizeRows = False
        Me.dgvOrdencompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrdencompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrdencompra.Location = New System.Drawing.Point(31, 436)
        Me.dgvOrdencompra.MultiSelect = False
        Me.dgvOrdencompra.Name = "dgvOrdencompra"
        Me.dgvOrdencompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrdencompra.Size = New System.Drawing.Size(996, 190)
        Me.dgvOrdencompra.TabIndex = 14
        '
        'cbMotivopedido
        '
        Me.cbMotivopedido.FormattingEnabled = True
        Me.cbMotivopedido.Items.AddRange(New Object() {"ADQUISICION", "CANJE", "DONATIVO"})
        Me.cbMotivopedido.Location = New System.Drawing.Point(121, 406)
        Me.cbMotivopedido.Name = "cbMotivopedido"
        Me.cbMotivopedido.Size = New System.Drawing.Size(224, 21)
        Me.cbMotivopedido.TabIndex = 3
        '
        'dtpPedido
        '
        Me.dtpPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPedido.Location = New System.Drawing.Point(121, 341)
        Me.dtpPedido.Name = "dtpPedido"
        Me.dtpPedido.Size = New System.Drawing.Size(91, 20)
        Me.dtpPedido.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Fecha pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Tipo adquisición"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Motivo del pedido"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(528, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Partida presupuestal"
        '
        'lbPartida
        '
        Me.lbPartida.AutoSize = True
        Me.lbPartida.Location = New System.Drawing.Point(620, 269)
        Me.lbPartida.Name = "lbPartida"
        Me.lbPartida.Size = New System.Drawing.Size(0, 13)
        Me.lbPartida.TabIndex = 101
        '
        'tbNumerosletras
        '
        Me.tbNumerosletras.Location = New System.Drawing.Point(637, 249)
        Me.tbNumerosletras.Name = "tbNumerosletras"
        Me.tbNumerosletras.Size = New System.Drawing.Size(390, 20)
        Me.tbNumerosletras.TabIndex = 9
        '
        'cbPartidas
        '
        Me.cbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartidas.FormattingEnabled = True
        Me.cbPartidas.Location = New System.Drawing.Point(637, 279)
        Me.cbPartidas.Name = "cbPartidas"
        Me.cbPartidas.Size = New System.Drawing.Size(390, 21)
        Me.cbPartidas.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(539, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Importe con letras"
        '
        'tbIdorden
        '
        Me.tbIdorden.Location = New System.Drawing.Point(121, 58)
        Me.tbIdorden.MaxLength = 10
        Me.tbIdorden.Name = "tbIdorden"
        Me.tbIdorden.Size = New System.Drawing.Size(184, 20)
        Me.tbIdorden.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 61)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 13)
        Me.Label21.TabIndex = 120
        Me.Label21.Text = "Folio orden de compra"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(35, 251)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "Fecha solicitud"
        '
        'tbMontoestimado
        '
        Me.tbMontoestimado.Enabled = False
        Me.tbMontoestimado.Location = New System.Drawing.Point(121, 217)
        Me.tbMontoestimado.Name = "tbMontoestimado"
        Me.tbMontoestimado.Size = New System.Drawing.Size(184, 20)
        Me.tbMontoestimado.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Monto estimado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Proveedor sugerido"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "Para aplicarse en"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Área solicitante"
        '
        'tbFolio
        '
        Me.tbFolio.Enabled = False
        Me.tbFolio.Location = New System.Drawing.Point(121, 90)
        Me.tbFolio.MaxLength = 20
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.Size = New System.Drawing.Size(184, 20)
        Me.tbFolio.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Número solicitud"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(311, 52)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(64, 31)
        Me.btBuscar.TabIndex = 122
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'tbArea
        '
        Me.tbArea.Enabled = False
        Me.tbArea.Location = New System.Drawing.Point(121, 121)
        Me.tbArea.MaxLength = 20
        Me.tbArea.Name = "tbArea"
        Me.tbArea.Size = New System.Drawing.Size(353, 20)
        Me.tbArea.TabIndex = 123
        '
        'tbAplica
        '
        Me.tbAplica.Enabled = False
        Me.tbAplica.Location = New System.Drawing.Point(121, 154)
        Me.tbAplica.MaxLength = 20
        Me.tbAplica.Name = "tbAplica"
        Me.tbAplica.Size = New System.Drawing.Size(353, 20)
        Me.tbAplica.TabIndex = 124
        '
        'tbProveedor
        '
        Me.tbProveedor.Enabled = False
        Me.tbProveedor.Location = New System.Drawing.Point(121, 184)
        Me.tbProveedor.MaxLength = 20
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(353, 20)
        Me.tbProveedor.TabIndex = 125
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(68, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "Autoriza"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(72, 280)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Solicita"
        '
        'tbSolicita
        '
        Me.tbSolicita.Enabled = False
        Me.tbSolicita.Location = New System.Drawing.Point(121, 280)
        Me.tbSolicita.MaxLength = 20
        Me.tbSolicita.Name = "tbSolicita"
        Me.tbSolicita.Size = New System.Drawing.Size(353, 20)
        Me.tbSolicita.TabIndex = 130
        '
        'tbAutoriza
        '
        Me.tbAutoriza.Enabled = False
        Me.tbAutoriza.Location = New System.Drawing.Point(121, 310)
        Me.tbAutoriza.MaxLength = 20
        Me.tbAutoriza.Name = "tbAutoriza"
        Me.tbAutoriza.Size = New System.Drawing.Size(353, 20)
        Me.tbAutoriza.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(539, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Lugar de entrega"
        '
        'cbTipoadquisiciones
        '
        Me.cbTipoadquisiciones.FormattingEnabled = True
        Me.cbTipoadquisiciones.Location = New System.Drawing.Point(637, 90)
        Me.cbTipoadquisiciones.Name = "cbTipoadquisiciones"
        Me.cbTipoadquisiciones.Size = New System.Drawing.Size(195, 21)
        Me.cbTipoadquisiciones.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(581, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(603, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "IVA"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Location = New System.Drawing.Point(637, 123)
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.Size = New System.Drawing.Size(184, 20)
        Me.tbSubtotal.TabIndex = 6
        '
        'tbIva
        '
        Me.tbIva.Location = New System.Drawing.Point(637, 153)
        Me.tbIva.Name = "tbIva"
        Me.tbIva.Size = New System.Drawing.Size(184, 20)
        Me.tbIva.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(560, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "Firma pedido"
        '
        'cbFirmapedido
        '
        Me.cbFirmapedido.FormattingEnabled = True
        Me.cbFirmapedido.Location = New System.Drawing.Point(637, 342)
        Me.cbFirmapedido.Name = "cbFirmapedido"
        Me.cbFirmapedido.Size = New System.Drawing.Size(303, 21)
        Me.cbFirmapedido.TabIndex = 11
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(757, 388)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(79, 34)
        Me.btGuardar.TabIndex = 12
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btImprimir
        '
        Me.btImprimir.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.printer
        Me.btImprimir.Location = New System.Drawing.Point(851, 388)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(79, 34)
        Me.btImprimir.TabIndex = 13
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'tbFechasolicitud
        '
        Me.tbFechasolicitud.Enabled = False
        Me.tbFechasolicitud.Location = New System.Drawing.Point(119, 248)
        Me.tbFechasolicitud.Name = "tbFechasolicitud"
        Me.tbFechasolicitud.Size = New System.Drawing.Size(184, 20)
        Me.tbFechasolicitud.TabIndex = 145
        '
        'tbRetencion
        '
        Me.tbRetencion.Enabled = False
        Me.tbRetencion.Location = New System.Drawing.Point(637, 186)
        Me.tbRetencion.Name = "tbRetencion"
        Me.tbRetencion.Size = New System.Drawing.Size(184, 20)
        Me.tbRetencion.TabIndex = 147
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(571, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "Retención"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(827, 187)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox2.TabIndex = 149
        Me.CheckBox2.Text = "Aplicar impuesto"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.Button7.Location = New System.Drawing.Point(946, 342)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(20, 20)
        Me.Button7.TabIndex = 150
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btConsultarpartidas
        '
        Me.btConsultarpartidas.Location = New System.Drawing.Point(1033, 279)
        Me.btConsultarpartidas.Name = "btConsultarpartidas"
        Me.btConsultarpartidas.Size = New System.Drawing.Size(20, 20)
        Me.btConsultarpartidas.TabIndex = 151
        Me.btConsultarpartidas.Text = "?"
        Me.btConsultarpartidas.UseVisualStyleBackColor = True
        '
        'tbClaveprograma
        '
        Me.tbClaveprograma.Location = New System.Drawing.Point(121, 373)
        Me.tbClaveprograma.Name = "tbClaveprograma"
        Me.tbClaveprograma.Size = New System.Drawing.Size(100, 20)
        Me.tbClaveprograma.TabIndex = 152
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(32, 373)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 13)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "Clave programa"
        '
        'cbLugarentrega
        '
        Me.cbLugarentrega.FormattingEnabled = True
        Me.cbLugarentrega.Location = New System.Drawing.Point(637, 58)
        Me.cbLugarentrega.Name = "cbLugarentrega"
        Me.cbLugarentrega.Size = New System.Drawing.Size(224, 21)
        Me.cbLugarentrega.TabIndex = 154
        '
        'cbCuentas
        '
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Location = New System.Drawing.Point(637, 312)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(303, 21)
        Me.cbCuentas.TabIndex = 155
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(512, 316)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(119, 13)
        Me.Label22.TabIndex = 156
        Me.Label22.Text = "Aplicación presupuestal"
        '
        'DOCUMENTAR_PEDIDO
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 659)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbLugarentrega)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbClaveprograma)
        Me.Controls.Add(Me.btConsultarpartidas)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbRetencion)
        Me.Controls.Add(Me.tbFechasolicitud)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.cbFirmapedido)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbIva)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbTipoadquisiciones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbAutoriza)
        Me.Controls.Add(Me.tbSolicita)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbProveedor)
        Me.Controls.Add(Me.tbAplica)
        Me.Controls.Add(Me.tbArea)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.tbIdorden)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbMontoestimado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPartidas)
        Me.Controls.Add(Me.tbNumerosletras)
        Me.Controls.Add(Me.lbPartida)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbMotivopedido)
        Me.Controls.Add(Me.dtpPedido)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvOrdencompra)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DOCUMENTAR_PEDIDO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REALIZAR PEDIDO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvOrdencompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgvOrdencompra As System.Windows.Forms.DataGridView
    Friend WithEvents cbMotivopedido As System.Windows.Forms.ComboBox
    Friend WithEvents dtpPedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbPartida As System.Windows.Forms.Label
    Friend WithEvents tbNumerosletras As System.Windows.Forms.TextBox
    Friend WithEvents cbPartidas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbIdorden As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbMontoestimado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents tbArea As System.Windows.Forms.TextBox
    Friend WithEvents tbAplica As System.Windows.Forms.TextBox
    Friend WithEvents tbProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbSolicita As System.Windows.Forms.TextBox
    Friend WithEvents tbAutoriza As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbTipoadquisiciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents tbIva As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbFirmapedido As System.Windows.Forms.ComboBox
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents tbFechasolicitud As System.Windows.Forms.TextBox
    Friend WithEvents tbRetencion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btConsultarpartidas As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tbClaveprograma As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbLugarentrega As System.Windows.Forms.ComboBox
    Friend WithEvents cbCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class

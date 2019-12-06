<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Altafactura
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Altafactura))
        Me.tbFoliofactura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbIva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbRetencion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.chbFirmado = New System.Windows.Forms.CheckBox()
        Me.chBSoporte = New System.Windows.Forms.CheckBox()
        Me.chbServicio = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbPedido = New System.Windows.Forms.CheckBox()
        Me.chbCotiza = New System.Windows.Forms.CheckBox()
        Me.chbVale = New System.Windows.Forms.CheckBox()
        Me.chbOrden = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbcuenta = New System.Windows.Forms.ComboBox()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.dtpFechafactura = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecharecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.cbPartida = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbFoliofiscal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbRutaarchivo = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbLicitaciones = New System.Windows.Forms.ComboBox()
        Me.tbFolio = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.btAgregarconceptos = New System.Windows.Forms.Button()
        Me.lbIdentificador = New System.Windows.Forms.Label()
        Me.cbTipoadquisicion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OpenXML_Masivo = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btXml = New System.Windows.Forms.Button()
        Me.cbCAUSES = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbSobreprecio = New System.Windows.Forms.Label()
        Me.tbSobreprecio = New System.Windows.Forms.TextBox()
        Me.tbCauses = New System.Windows.Forms.TextBox()
        Me.lbCauses = New System.Windows.Forms.Label()
        Me.tbTotalpago = New System.Windows.Forms.TextBox()
        Me.lbTotalpago = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btMedicamentos = New System.Windows.Forms.Button()
        Me.btCapturaconceptos = New System.Windows.Forms.Button()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbpreciosref = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbFoliofactura
        '
        Me.tbFoliofactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFoliofactura.Location = New System.Drawing.Point(134, 449)
        Me.tbFoliofactura.MaxLength = 20
        Me.tbFoliofactura.Name = "tbFoliofactura"
        Me.tbFoliofactura.Size = New System.Drawing.Size(258, 20)
        Me.tbFoliofactura.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Factura"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(817, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha recepción"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(608, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha factura"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombre proveedor"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(634, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Subtotal"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSubtotal.Location = New System.Drawing.Point(686, 132)
        Me.tbSubtotal.MaxLength = 15
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbSubtotal.Size = New System.Drawing.Size(119, 20)
        Me.tbSubtotal.TabIndex = 17
        Me.tbSubtotal.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(656, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "IVA"
        '
        'tbIva
        '
        Me.tbIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbIva.Location = New System.Drawing.Point(687, 166)
        Me.tbIva.MaxLength = 15
        Me.tbIva.Name = "tbIva"
        Me.tbIva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbIva.Size = New System.Drawing.Size(119, 20)
        Me.tbIva.TabIndex = 18
        Me.tbIva.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(624, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Retención"
        '
        'tbRetencion
        '
        Me.tbRetencion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRetencion.Location = New System.Drawing.Point(687, 202)
        Me.tbRetencion.MaxLength = 15
        Me.tbRetencion.Name = "tbRetencion"
        Me.tbRetencion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbRetencion.Size = New System.Drawing.Size(119, 20)
        Me.tbRetencion.TabIndex = 19
        Me.tbRetencion.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(649, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total"
        '
        'tbTotal
        '
        Me.tbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotal.Location = New System.Drawing.Point(687, 235)
        Me.tbTotal.MaxLength = 15
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTotal.Size = New System.Drawing.Size(119, 20)
        Me.tbTotal.TabIndex = 20
        Me.tbTotal.Text = "0.00"
        '
        'chbFirmado
        '
        Me.chbFirmado.AutoSize = True
        Me.chbFirmado.Location = New System.Drawing.Point(17, 27)
        Me.chbFirmado.Name = "chbFirmado"
        Me.chbFirmado.Size = New System.Drawing.Size(56, 17)
        Me.chbFirmado.TabIndex = 23
        Me.chbFirmado.Text = "Firmas"
        Me.chbFirmado.UseVisualStyleBackColor = True
        '
        'chBSoporte
        '
        Me.chBSoporte.AutoSize = True
        Me.chBSoporte.Location = New System.Drawing.Point(258, 27)
        Me.chBSoporte.Name = "chBSoporte"
        Me.chBSoporte.Size = New System.Drawing.Size(63, 17)
        Me.chBSoporte.TabIndex = 25
        Me.chBSoporte.Text = "Soporte"
        Me.chBSoporte.UseVisualStyleBackColor = True
        '
        'chbServicio
        '
        Me.chbServicio.AutoSize = True
        Me.chbServicio.Location = New System.Drawing.Point(17, 53)
        Me.chbServicio.Name = "chbServicio"
        Me.chbServicio.Size = New System.Drawing.Size(109, 17)
        Me.chbServicio.TabIndex = 27
        Me.chbServicio.Text = "Orden de servicio"
        Me.chbServicio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chbPedido)
        Me.GroupBox1.Controls.Add(Me.chbCotiza)
        Me.GroupBox1.Controls.Add(Me.chbVale)
        Me.GroupBox1.Controls.Add(Me.chbOrden)
        Me.GroupBox1.Controls.Add(Me.chbServicio)
        Me.GroupBox1.Controls.Add(Me.chBSoporte)
        Me.GroupBox1.Controls.Add(Me.chbFirmado)
        Me.GroupBox1.Location = New System.Drawing.Point(684, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 77)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documentos"
        '
        'chbPedido
        '
        Me.chbPedido.AutoSize = True
        Me.chbPedido.Location = New System.Drawing.Point(373, 25)
        Me.chbPedido.Name = "chbPedido"
        Me.chbPedido.Size = New System.Drawing.Size(59, 17)
        Me.chbPedido.TabIndex = 26
        Me.chbPedido.Text = "Pedido"
        Me.chbPedido.UseVisualStyleBackColor = True
        '
        'chbCotiza
        '
        Me.chbCotiza.AutoSize = True
        Me.chbCotiza.Location = New System.Drawing.Point(258, 53)
        Me.chbCotiza.Name = "chbCotiza"
        Me.chbCotiza.Size = New System.Drawing.Size(86, 17)
        Me.chbCotiza.TabIndex = 29
        Me.chbCotiza.Text = "Cotizaciones"
        Me.chbCotiza.UseVisualStyleBackColor = True
        '
        'chbVale
        '
        Me.chbVale.AutoSize = True
        Me.chbVale.Location = New System.Drawing.Point(134, 53)
        Me.chbVale.Name = "chbVale"
        Me.chbVale.Size = New System.Drawing.Size(92, 17)
        Me.chbVale.TabIndex = 28
        Me.chbVale.Text = "Vale de salida"
        Me.chbVale.UseVisualStyleBackColor = True
        '
        'chbOrden
        '
        Me.chbOrden.AutoSize = True
        Me.chbOrden.Location = New System.Drawing.Point(134, 26)
        Me.chbOrden.Name = "chbOrden"
        Me.chbOrden.Size = New System.Drawing.Size(108, 17)
        Me.chbOrden.TabIndex = 24
        Me.chbOrden.Text = "Orden de compra"
        Me.chbOrden.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(88, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Partida"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(637, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Unidad"
        '
        'cbUnidad
        '
        Me.cbUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Location = New System.Drawing.Point(686, 93)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(349, 21)
        Me.cbUnidad.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(36, 203)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Número de cuenta"
        '
        'cbcuenta
        '
        Me.cbcuenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbcuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcuenta.FormattingEnabled = True
        Me.cbcuenta.Location = New System.Drawing.Point(134, 201)
        Me.cbcuenta.Name = "cbcuenta"
        Me.cbcuenta.Size = New System.Drawing.Size(259, 21)
        Me.cbcuenta.TabIndex = 5
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbObservaciones.Location = New System.Drawing.Point(686, 276)
        Me.tbObservaciones.MaxLength = 200
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(461, 21)
        Me.tbObservaciones.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(599, 279)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Observaciones"
        '
        'cbProveedores
        '
        Me.cbProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.DropDownWidth = 420
        Me.cbProveedores.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(134, 236)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(308, 22)
        Me.cbProveedores.TabIndex = 6
        '
        'dtpFechafactura
        '
        Me.dtpFechafactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechafactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechafactura.Location = New System.Drawing.Point(686, 57)
        Me.dtpFechafactura.Name = "dtpFechafactura"
        Me.dtpFechafactura.Size = New System.Drawing.Size(123, 20)
        Me.dtpFechafactura.TabIndex = 14
        Me.dtpFechafactura.Value = New Date(2018, 6, 19, 10, 11, 1, 0)
        '
        'dtpFecharecepcion
        '
        Me.dtpFecharecepcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecharecepcion.Checked = False
        Me.dtpFecharecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecharecepcion.Location = New System.Drawing.Point(907, 57)
        Me.dtpFecharecepcion.Name = "dtpFecharecepcion"
        Me.dtpFecharecepcion.Size = New System.Drawing.Size(123, 20)
        Me.dtpFecharecepcion.TabIndex = 15
        Me.dtpFecharecepcion.Value = New Date(2018, 9, 8, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(89, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Fuente"
        '
        'cbCuentas
        '
        Me.cbCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas.DropDownWidth = 300
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Location = New System.Drawing.Point(134, 164)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(259, 21)
        Me.cbCuentas.TabIndex = 2
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToOrderColumns = True
        Me.dgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalles.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalles.Location = New System.Drawing.Point(23, 573)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dgvDetalles.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(1169, 164)
        Me.dgvDetalles.TabIndex = 35
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator5, Me.ToolStripButton5, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton7, Me.ToolStripSeparator6, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1213, 25)
        Me.ToolStrip1.TabIndex = 75
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripButton4.Text = "Consultar SAACG"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripButton1.Text = "Catálogo partidas"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.Users_32
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripButton5.Text = "Proveedores"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.Building_32xLG
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton2.Text = "Unidades"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.certificate_32xLG
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton7.Text = "Licitaciones"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.puerta_de_salida_con_la_flecha_hacia_la_derecha_318_405972
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton6.Text = "Salir"
        '
        'cbPartida
        '
        Me.cbPartida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPartida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartida.DropDownWidth = 560
        Me.cbPartida.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPartida.FormattingEnabled = True
        Me.cbPartida.Location = New System.Drawing.Point(134, 339)
        Me.cbPartida.Name = "cbPartida"
        Me.cbPartida.Size = New System.Drawing.Size(309, 22)
        Me.cbPartida.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 491)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Folio fiscal"
        '
        'tbFoliofiscal
        '
        Me.tbFoliofiscal.AllowDrop = True
        Me.tbFoliofiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFoliofiscal.Location = New System.Drawing.Point(136, 488)
        Me.tbFoliofiscal.MaxLength = 20
        Me.tbFoliofiscal.Name = "tbFoliofiscal"
        Me.tbFoliofiscal.Size = New System.Drawing.Size(308, 20)
        Me.tbFoliofiscal.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(84, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Ejercicio"
        '
        'cbEjercicio
        '
        Me.cbEjercicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Location = New System.Drawing.Point(134, 90)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(121, 21)
        Me.cbEjercicio.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(94, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Rubro"
        '
        'cbRubro
        '
        Me.cbRubro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.DropDownWidth = 350
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(134, 128)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(259, 21)
        Me.cbRubro.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivos XML|*.xml"
        '
        'tbRutaarchivo
        '
        Me.tbRutaarchivo.Location = New System.Drawing.Point(979, 885)
        Me.tbRutaarchivo.Name = "tbRutaarchivo"
        Me.tbRutaarchivo.Size = New System.Drawing.Size(325, 20)
        Me.tbRutaarchivo.TabIndex = 91
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(75, 308)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 13)
        Me.Label23.TabIndex = 92
        Me.Label23.Text = "Licitación"
        '
        'cbLicitaciones
        '
        Me.cbLicitaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLicitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLicitaciones.FormattingEnabled = True
        Me.cbLicitaciones.Location = New System.Drawing.Point(133, 305)
        Me.cbLicitaciones.Name = "cbLicitaciones"
        Me.cbLicitaciones.Size = New System.Drawing.Size(259, 21)
        Me.cbLicitaciones.TabIndex = 4
        '
        'tbFolio
        '
        Me.tbFolio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFolio.Location = New System.Drawing.Point(134, 54)
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.Size = New System.Drawing.Size(100, 20)
        Me.tbFolio.TabIndex = 93
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(102, 57)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 13)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Folio"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(828, 239)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 95
        Me.Label24.Text = "Estatus"
        Me.Label24.Visible = False
        '
        'cbEstatus
        '
        Me.cbEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatus.Enabled = False
        Me.cbEstatus.FormattingEnabled = True
        Me.cbEstatus.Location = New System.Drawing.Point(876, 234)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.cbEstatus.TabIndex = 21
        Me.cbEstatus.Visible = False
        '
        'btAgregarconceptos
        '
        Me.btAgregarconceptos.Location = New System.Drawing.Point(23, 541)
        Me.btAgregarconceptos.Name = "btAgregarconceptos"
        Me.btAgregarconceptos.Size = New System.Drawing.Size(104, 23)
        Me.btAgregarconceptos.TabIndex = 14
        Me.btAgregarconceptos.Text = "Agregar"
        Me.btAgregarconceptos.UseVisualStyleBackColor = True
        '
        'lbIdentificador
        '
        Me.lbIdentificador.AllowDrop = True
        Me.lbIdentificador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbIdentificador.AutoSize = True
        Me.lbIdentificador.ForeColor = System.Drawing.Color.Red
        Me.lbIdentificador.Location = New System.Drawing.Point(450, 491)
        Me.lbIdentificador.Name = "lbIdentificador"
        Me.lbIdentificador.Size = New System.Drawing.Size(107, 13)
        Me.lbIdentificador.TabIndex = 101
        Me.lbIdentificador.Text = "Capturar identificador"
        '
        'cbTipoadquisicion
        '
        Me.cbTipoadquisicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoadquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoadquisicion.FormattingEnabled = True
        Me.cbTipoadquisicion.Location = New System.Drawing.Point(134, 272)
        Me.cbTipoadquisicion.Name = "cbTipoadquisicion"
        Me.cbTipoadquisicion.Size = New System.Drawing.Size(259, 21)
        Me.cbTipoadquisicion.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 276)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 103
        Me.Label14.Text = "Tipo de adquisición"
        '
        'OpenXML_Masivo
        '
        Me.OpenXML_Masivo.FileName = "OpenXML_Masivo"
        Me.OpenXML_Masivo.Filter = "Archivos XML|*.xml"
        Me.OpenXML_Masivo.Multiselect = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(925, 888)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Ruta xml"
        '
        'btXml
        '
        Me.btXml.Location = New System.Drawing.Point(133, 408)
        Me.btXml.Name = "btXml"
        Me.btXml.Size = New System.Drawing.Size(88, 27)
        Me.btXml.TabIndex = 9
        Me.btXml.Text = "Importar xml"
        Me.btXml.UseVisualStyleBackColor = True
        '
        'cbCAUSES
        '
        Me.cbCAUSES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCAUSES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCAUSES.FormattingEnabled = True
        Me.cbCAUSES.Items.AddRange(New Object() {"2016", "2018", "2019", "2020"})
        Me.cbCAUSES.Location = New System.Drawing.Point(134, 373)
        Me.cbCAUSES.Name = "cbCAUSES"
        Me.cbCAUSES.Size = New System.Drawing.Size(121, 21)
        Me.cbCAUSES.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "CAUSES"
        '
        'lbSobreprecio
        '
        Me.lbSobreprecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSobreprecio.AutoSize = True
        Me.lbSobreprecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbSobreprecio.Location = New System.Drawing.Point(587, 550)
        Me.lbSobreprecio.Name = "lbSobreprecio"
        Me.lbSobreprecio.Size = New System.Drawing.Size(64, 13)
        Me.lbSobreprecio.TabIndex = 0
        Me.lbSobreprecio.Text = "Sobreprecio"
        '
        'tbSobreprecio
        '
        Me.tbSobreprecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSobreprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSobreprecio.ForeColor = System.Drawing.Color.Red
        Me.tbSobreprecio.Location = New System.Drawing.Point(655, 547)
        Me.tbSobreprecio.Name = "tbSobreprecio"
        Me.tbSobreprecio.Size = New System.Drawing.Size(89, 20)
        Me.tbSobreprecio.TabIndex = 32
        '
        'tbCauses
        '
        Me.tbCauses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCauses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCauses.ForeColor = System.Drawing.Color.Red
        Me.tbCauses.Location = New System.Drawing.Point(826, 547)
        Me.tbCauses.Name = "tbCauses"
        Me.tbCauses.Size = New System.Drawing.Size(89, 20)
        Me.tbCauses.TabIndex = 33
        '
        'lbCauses
        '
        Me.lbCauses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCauses.AutoSize = True
        Me.lbCauses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbCauses.Location = New System.Drawing.Point(756, 551)
        Me.lbCauses.Name = "lbCauses"
        Me.lbCauses.Size = New System.Drawing.Size(68, 13)
        Me.lbCauses.TabIndex = 2
        Me.lbCauses.Text = "Sin CAUSES"
        '
        'tbTotalpago
        '
        Me.tbTotalpago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotalpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalpago.ForeColor = System.Drawing.Color.Red
        Me.tbTotalpago.Location = New System.Drawing.Point(997, 547)
        Me.tbTotalpago.Name = "tbTotalpago"
        Me.tbTotalpago.Size = New System.Drawing.Size(89, 20)
        Me.tbTotalpago.TabIndex = 34
        '
        'lbTotalpago
        '
        Me.lbTotalpago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotalpago.AutoSize = True
        Me.lbTotalpago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbTotalpago.Location = New System.Drawing.Point(927, 550)
        Me.lbTotalpago.Name = "lbTotalpago"
        Me.lbTotalpago.Size = New System.Drawing.Size(70, 13)
        Me.lbTotalpago.TabIndex = 4
        Me.lbTotalpago.Text = "Total a pagar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(792, 885)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(127, 18)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 109
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'btMedicamentos
        '
        Me.btMedicamentos.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_comprobado_16
        Me.btMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMedicamentos.Location = New System.Drawing.Point(312, 408)
        Me.btMedicamentos.Name = "btMedicamentos"
        Me.btMedicamentos.Size = New System.Drawing.Size(79, 27)
        Me.btMedicamentos.TabIndex = 11
        Me.btMedicamentos.Text = "Validar"
        Me.btMedicamentos.UseVisualStyleBackColor = True
        '
        'btCapturaconceptos
        '
        Me.btCapturaconceptos.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.ToggleOfficeKeyboardScheme_7508
        Me.btCapturaconceptos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btCapturaconceptos.Location = New System.Drawing.Point(227, 408)
        Me.btCapturaconceptos.Name = "btCapturaconceptos"
        Me.btCapturaconceptos.Size = New System.Drawing.Size(79, 27)
        Me.btCapturaconceptos.TabIndex = 10
        Me.btCapturaconceptos.Text = "Capturar"
        Me.btCapturaconceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCapturaconceptos.UseVisualStyleBackColor = True
        '
        'BtGuardar
        '
        Me.BtGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtGuardar.AutoSize = True
        Me.BtGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BtGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtGuardar.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtGuardar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.guardar
        Me.BtGuardar.Location = New System.Drawing.Point(773, 421)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(54, 44)
        Me.BtGuardar.TabIndex = 31
        Me.BtGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtGuardar.UseVisualStyleBackColor = False
        '
        'BtAgregar
        '
        Me.BtAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtAgregar.AutoSize = True
        Me.BtAgregar.BackColor = System.Drawing.SystemColors.Control
        Me.BtAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAgregar.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtAgregar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.WorkItem_32xLG
        Me.BtAgregar.Location = New System.Drawing.Point(684, 426)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(52, 43)
        Me.BtAgregar.TabIndex = 30
        Me.BtAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAgregar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(1097, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 27)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Imprimir reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(530, 131)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 112
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(271, 376)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 113
        Me.Label19.Text = "PRECIOS REF"
        '
        'cbpreciosref
        '
        Me.cbpreciosref.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbpreciosref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpreciosref.FormattingEnabled = True
        Me.cbpreciosref.Items.AddRange(New Object() {"2016", "2018", "2019", "2020"})
        Me.cbpreciosref.Location = New System.Drawing.Point(355, 373)
        Me.cbpreciosref.Name = "cbpreciosref"
        Me.cbpreciosref.Size = New System.Drawing.Size(121, 21)
        Me.cbpreciosref.TabIndex = 114
        '
        'Altafactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1213, 749)
        Me.Controls.Add(Me.cbpreciosref)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tbTotalpago)
        Me.Controls.Add(Me.lbTotalpago)
        Me.Controls.Add(Me.tbCauses)
        Me.Controls.Add(Me.lbCauses)
        Me.Controls.Add(Me.cbCAUSES)
        Me.Controls.Add(Me.tbSobreprecio)
        Me.Controls.Add(Me.lbSobreprecio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btMedicamentos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbTipoadquisicion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbIdentificador)
        Me.Controls.Add(Me.btXml)
        Me.Controls.Add(Me.btAgregarconceptos)
        Me.Controls.Add(Me.btCapturaconceptos)
        Me.Controls.Add(Me.cbEstatus)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.cbLicitaciones)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tbRutaarchivo)
        Me.Controls.Add(Me.cbRubro)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbFoliofiscal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtGuardar)
        Me.Controls.Add(Me.BtAgregar)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpFecharecepcion)
        Me.Controls.Add(Me.dtpFechafactura)
        Me.Controls.Add(Me.cbProveedores)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbObservaciones)
        Me.Controls.Add(Me.cbcuenta)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbUnidad)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbPartida)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbRetencion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbIva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbFoliofactura)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1229, 726)
        Me.Name = "Altafactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Agregar"
        Me.Text = "ALTA FACTURA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbIva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbRetencion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents chbFirmado As System.Windows.Forms.CheckBox
    Friend WithEvents chBSoporte As System.Windows.Forms.CheckBox
    Friend WithEvents chbServicio As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chbOrden As System.Windows.Forms.CheckBox
    Friend WithEvents chbCotiza As System.Windows.Forms.CheckBox
    Friend WithEvents chbVale As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtGuardar As System.Windows.Forms.Button
    'Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents chbPedido As System.Windows.Forms.CheckBox
    Friend WithEvents BtAgregar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbcuenta As System.Windows.Forms.ComboBox
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechafactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecharecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbPartida As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbFoliofiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbEjercicio As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbRutaarchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbLicitaciones As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents btCapturaconceptos As Button
    Friend WithEvents btAgregarconceptos As Button
    Friend WithEvents btXml As Button
    Friend WithEvents lbIdentificador As Label
    Friend WithEvents cbTipoadquisicion As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents OpenXML_Masivo As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents btMedicamentos As Button
    Public WithEvents tbFoliofactura As TextBox
    Friend WithEvents cbCAUSES As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbSobreprecio As Label
    Friend WithEvents tbSobreprecio As TextBox
    Friend WithEvents tbTotalpago As TextBox
    Friend WithEvents lbTotalpago As Label
    Friend WithEvents tbCauses As TextBox
    Friend WithEvents lbCauses As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cbpreciosref As ComboBox
End Class

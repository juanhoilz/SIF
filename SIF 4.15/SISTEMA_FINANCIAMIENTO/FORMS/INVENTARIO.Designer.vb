<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INVENTARIO
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INVENTARIO))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.tbresguardo = New System.Windows.Forms.TextBox()
        Me.tbvalor = New System.Windows.Forms.TextBox()
        Me.tbproducto = New System.Windows.Forms.TextBox()
        Me.tbunidad = New System.Windows.Forms.TextBox()
        Me.tbcantidad = New System.Windows.Forms.TextBox()
        Me.tbidentificacion = New System.Windows.Forms.TextBox()
        Me.tbserie = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbmodelo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbmarca = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbobservacion = New System.Windows.Forms.TextBox()
        Me.chbetiquetado = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPartidas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbResguardatario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSubcapitulo = New System.Windows.Forms.ComboBox()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbubicacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechafactura = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecharecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.NO_INVENTARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_FUENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TIPO_ADQUISICION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOADQUISION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_LICITACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LICITACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIOFISCAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAFACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACAPTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_SUBCAPITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBCAPITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PARTIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PARTIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MODELO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoIDENTIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVEPRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION_COMPLEMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoRESGUARDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_RESGUARDATORIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESGUARDATORIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETIQUETADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POLIZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbFoliofiscal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFoliofactura = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbInventario = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.cblicitacion = New System.Windows.Forms.ComboBox()
        Me.cbtipoadq = New System.Windows.Forms.ComboBox()
        Me.cbdescripcion = New System.Windows.Forms.ComboBox()
        Me.tbPoliza = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chbSerie = New System.Windows.Forms.CheckBox()
        Me.tbiva = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbimporte = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btbuscar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tbComplemento = New System.Windows.Forms.TextBox()
        Me.chbInventario = New System.Windows.Forms.CheckBox()
        Me.cbidentificacion = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(985, 194)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 247
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btactualizar
        '
        Me.btactualizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btactualizar.Location = New System.Drawing.Point(906, 416)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(125, 27)
        Me.btactualizar.TabIndex = 246
        Me.btactualizar.Text = "Actualizar"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'tbresguardo
        '
        Me.tbresguardo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbresguardo.Location = New System.Drawing.Point(655, 283)
        Me.tbresguardo.MaxLength = 20
        Me.tbresguardo.Name = "tbresguardo"
        Me.tbresguardo.Size = New System.Drawing.Size(114, 20)
        Me.tbresguardo.TabIndex = 22
        '
        'tbvalor
        '
        Me.tbvalor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbvalor.Location = New System.Drawing.Point(655, 252)
        Me.tbvalor.MaxLength = 20
        Me.tbvalor.Name = "tbvalor"
        Me.tbvalor.Size = New System.Drawing.Size(98, 20)
        Me.tbvalor.TabIndex = 21
        '
        'tbproducto
        '
        Me.tbproducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbproducto.Location = New System.Drawing.Point(870, 166)
        Me.tbproducto.MaxLength = 20
        Me.tbproducto.Name = "tbproducto"
        Me.tbproducto.Size = New System.Drawing.Size(96, 20)
        Me.tbproducto.TabIndex = 19
        '
        'tbunidad
        '
        Me.tbunidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbunidad.Location = New System.Drawing.Point(655, 166)
        Me.tbunidad.MaxLength = 20
        Me.tbunidad.Name = "tbunidad"
        Me.tbunidad.Size = New System.Drawing.Size(155, 20)
        Me.tbunidad.TabIndex = 18
        Me.tbunidad.Text = "PIEZA"
        '
        'tbcantidad
        '
        Me.tbcantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbcantidad.Location = New System.Drawing.Point(870, 137)
        Me.tbcantidad.MaxLength = 10
        Me.tbcantidad.Name = "tbcantidad"
        Me.tbcantidad.Size = New System.Drawing.Size(142, 20)
        Me.tbcantidad.TabIndex = 17
        '
        'tbidentificacion
        '
        Me.tbidentificacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbidentificacion.Location = New System.Drawing.Point(655, 137)
        Me.tbidentificacion.MaxLength = 20
        Me.tbidentificacion.Name = "tbidentificacion"
        Me.tbidentificacion.Size = New System.Drawing.Size(114, 20)
        Me.tbidentificacion.TabIndex = 16
        '
        'tbserie
        '
        Me.tbserie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbserie.Location = New System.Drawing.Point(655, 108)
        Me.tbserie.MaxLength = 100
        Me.tbserie.Name = "tbserie"
        Me.tbserie.Size = New System.Drawing.Size(234, 20)
        Me.tbserie.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.Location = New System.Drawing.Point(600, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 229
        Me.Label15.Text = "No. Serie"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(811, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 231
        Me.Label16.Text = "ClaveProd"
        '
        'btagregar
        '
        Me.btagregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btagregar.Location = New System.Drawing.Point(655, 416)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(114, 27)
        Me.btagregar.TabIndex = 26
        Me.btagregar.Text = "Agregar"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.Location = New System.Drawing.Point(569, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 234
        Me.Label17.Text = "noIdentificacion"
        '
        'cbmodelo
        '
        Me.cbmodelo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbmodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmodelo.FormattingEnabled = True
        Me.cbmodelo.Location = New System.Drawing.Point(655, 77)
        Me.cbmodelo.Name = "cbmodelo"
        Me.cbmodelo.Size = New System.Drawing.Size(358, 21)
        Me.cbmodelo.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.Location = New System.Drawing.Point(610, 169)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 237
        Me.Label19.Text = "Unidad"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.Location = New System.Drawing.Point(612, 77)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 232
        Me.Label26.Text = "Modelo"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.Location = New System.Drawing.Point(581, 254)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 20)
        Me.Label24.TabIndex = 239
        Me.Label24.Text = "Valor unitario"
        '
        'cbmarca
        '
        Me.cbmarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmarca.FormattingEnabled = True
        Me.cbmarca.Location = New System.Drawing.Point(656, 44)
        Me.cbmarca.Name = "cbmarca"
        Me.cbmarca.Size = New System.Drawing.Size(358, 21)
        Me.cbmarca.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.Location = New System.Drawing.Point(588, 198)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 238
        Me.Label21.Text = "Descripción"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.Location = New System.Drawing.Point(615, 47)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 13)
        Me.Label25.TabIndex = 228
        Me.Label25.Text = "Marca"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(818, 140)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 236
        Me.Label18.Text = "Cantidad"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Location = New System.Drawing.Point(573, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 226
        Me.Label10.Text = "Observaciones"
        '
        'tbobservacion
        '
        Me.tbobservacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbobservacion.Location = New System.Drawing.Point(655, 345)
        Me.tbobservacion.MaxLength = 250
        Me.tbobservacion.Name = "tbobservacion"
        Me.tbobservacion.Size = New System.Drawing.Size(357, 20)
        Me.tbobservacion.TabIndex = 24
        '
        'chbetiquetado
        '
        Me.chbetiquetado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbetiquetado.Location = New System.Drawing.Point(655, 376)
        Me.chbetiquetado.Name = "chbetiquetado"
        Me.chbetiquetado.Size = New System.Drawing.Size(77, 17)
        Me.chbetiquetado.TabIndex = 25
        Me.chbetiquetado.Text = "Etiquetado"
        Me.chbetiquetado.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.Location = New System.Drawing.Point(590, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 223
        Me.Label12.Text = "Resguardo"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.Location = New System.Drawing.Point(92, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 222
        Me.Label9.Text = "Grupo"
        '
        'cbGrupo
        '
        Me.cbGrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.Location = New System.Drawing.Point(135, 410)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(319, 21)
        Me.cbGrupo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Location = New System.Drawing.Point(90, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Partida"
        '
        'cbPartidas
        '
        Me.cbPartidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartidas.FormattingEnabled = True
        Me.cbPartidas.Location = New System.Drawing.Point(135, 377)
        Me.cbPartidas.Name = "cbPartidas"
        Me.cbPartidas.Size = New System.Drawing.Size(318, 21)
        Me.cbPartidas.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Location = New System.Drawing.Point(573, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 217
        Me.Label7.Text = "Resguardatario"
        '
        'cbResguardatario
        '
        Me.cbResguardatario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbResguardatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResguardatario.FormattingEnabled = True
        Me.cbResguardatario.Location = New System.Drawing.Point(655, 314)
        Me.cbResguardatario.Name = "cbResguardatario"
        Me.cbResguardatario.Size = New System.Drawing.Size(357, 21)
        Me.cbResguardatario.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Location = New System.Drawing.Point(65, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "Subcapítulo"
        '
        'cbSubcapitulo
        '
        Me.cbSubcapitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSubcapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubcapitulo.FormattingEnabled = True
        Me.cbSubcapitulo.Location = New System.Drawing.Point(135, 345)
        Me.cbSubcapitulo.Name = "cbSubcapitulo"
        Me.cbSubcapitulo.Size = New System.Drawing.Size(318, 21)
        Me.cbSubcapitulo.TabIndex = 10
        '
        'btguardar
        '
        Me.btguardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btguardar.Location = New System.Drawing.Point(775, 416)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(125, 27)
        Me.btguardar.TabIndex = 27
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Location = New System.Drawing.Point(77, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "Ubicación"
        '
        'cbubicacion
        '
        Me.cbubicacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbubicacion.FormattingEnabled = True
        Me.cbubicacion.Location = New System.Drawing.Point(136, 314)
        Me.cbubicacion.Name = "cbubicacion"
        Me.cbubicacion.Size = New System.Drawing.Size(318, 21)
        Me.cbubicacion.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Location = New System.Drawing.Point(73, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "F. Factura"
        '
        'dtpFechafactura
        '
        Me.dtpFechafactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFechafactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechafactura.Location = New System.Drawing.Point(134, 283)
        Me.dtpFechafactura.Name = "dtpFechafactura"
        Me.dtpFechafactura.Size = New System.Drawing.Size(123, 20)
        Me.dtpFechafactura.TabIndex = 7
        Me.dtpFechafactura.Value = New Date(2018, 6, 19, 10, 11, 1, 0)
        '
        'dtpFecharecepcion
        '
        Me.dtpFecharecepcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFecharecepcion.Checked = False
        Me.dtpFecharecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecharecepcion.Location = New System.Drawing.Point(326, 283)
        Me.dtpFecharecepcion.Name = "dtpFecharecepcion"
        Me.dtpFecharecepcion.Size = New System.Drawing.Size(123, 20)
        Me.dtpFecharecepcion.TabIndex = 8
        Me.dtpFecharecepcion.Value = New Date(2019, 11, 22, 19, 39, 17, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "F. Captura"
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToOrderColumns = True
        Me.dgvDetalles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NO_INVENTARIO, Me.ID_EJERCICIO, Me.EJERCICIO, Me.ID_FUENTE, Me.FUENTE, Me.ID_PROVEEDOR, Me.PROVEEDOR, Me.ID_TIPO_ADQUISICION, Me.TIPOADQUISION, Me.ID_LICITACION, Me.LICITACION, Me.FACTURA, Me.FOLIOFISCAL, Me.FECHAFACTURA, Me.FECHACAPTURA, Me.ID_UBICACION, Me.UBICACION, Me.ID_SUBCAPITULO, Me.SUBCAPITULO, Me.ID_PARTIDA, Me.PARTIDA, Me.ID_GRUPO, Me.GRUPO, Me.ID_MARCA, Me.MARCA, Me.ID_MODELO, Me.MODELO, Me.NoSERIE, Me.NoIDENTIFICACION, Me.CANTIDAD, Me.UNIDAD, Me.CLAVEPRODUCTO, Me.DESCRIPCION, Me.DESCRIPCION_COMPLEMENTO, Me.VALOR, Me.NoRESGUARDO, Me.ID_RESGUARDATORIO, Me.RESGUARDATORIO, Me.OBSERVACIONES, Me.ETIQUETADO, Me.POLIZA})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalles.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalles.Location = New System.Drawing.Point(12, 483)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dgvDetalles.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(1017, 254)
        Me.dgvDetalles.TabIndex = 206
        '
        'NO_INVENTARIO
        '
        Me.NO_INVENTARIO.HeaderText = "NO_INVENTARIO"
        Me.NO_INVENTARIO.Name = "NO_INVENTARIO"
        Me.NO_INVENTARIO.ReadOnly = True
        '
        'ID_EJERCICIO
        '
        Me.ID_EJERCICIO.HeaderText = "ID_EJERCICIO"
        Me.ID_EJERCICIO.Name = "ID_EJERCICIO"
        Me.ID_EJERCICIO.ReadOnly = True
        Me.ID_EJERCICIO.Visible = False
        '
        'EJERCICIO
        '
        Me.EJERCICIO.HeaderText = "EJERCICIO"
        Me.EJERCICIO.Name = "EJERCICIO"
        Me.EJERCICIO.ReadOnly = True
        '
        'ID_FUENTE
        '
        Me.ID_FUENTE.HeaderText = "ID_FUENTE"
        Me.ID_FUENTE.Name = "ID_FUENTE"
        Me.ID_FUENTE.ReadOnly = True
        Me.ID_FUENTE.Visible = False
        '
        'FUENTE
        '
        Me.FUENTE.HeaderText = "FUENTE"
        Me.FUENTE.Name = "FUENTE"
        Me.FUENTE.ReadOnly = True
        '
        'ID_PROVEEDOR
        '
        Me.ID_PROVEEDOR.HeaderText = "ID_PROVEEDOR"
        Me.ID_PROVEEDOR.Name = "ID_PROVEEDOR"
        Me.ID_PROVEEDOR.ReadOnly = True
        Me.ID_PROVEEDOR.Visible = False
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.HeaderText = "PROVEEDOR"
        Me.PROVEEDOR.Name = "PROVEEDOR"
        Me.PROVEEDOR.ReadOnly = True
        Me.PROVEEDOR.Width = 200
        '
        'ID_TIPO_ADQUISICION
        '
        Me.ID_TIPO_ADQUISICION.HeaderText = "ID_TIPO_ADQUISICION"
        Me.ID_TIPO_ADQUISICION.Name = "ID_TIPO_ADQUISICION"
        Me.ID_TIPO_ADQUISICION.ReadOnly = True
        Me.ID_TIPO_ADQUISICION.Visible = False
        '
        'TIPOADQUISION
        '
        Me.TIPOADQUISION.HeaderText = "TIPO DE ADQUISIÓN"
        Me.TIPOADQUISION.Name = "TIPOADQUISION"
        Me.TIPOADQUISION.ReadOnly = True
        Me.TIPOADQUISION.Width = 150
        '
        'ID_LICITACION
        '
        Me.ID_LICITACION.HeaderText = "ID_LICITACION"
        Me.ID_LICITACION.Name = "ID_LICITACION"
        Me.ID_LICITACION.ReadOnly = True
        Me.ID_LICITACION.Visible = False
        '
        'LICITACION
        '
        Me.LICITACION.HeaderText = "LICITACIÓN"
        Me.LICITACION.Name = "LICITACION"
        Me.LICITACION.ReadOnly = True
        '
        'FACTURA
        '
        Me.FACTURA.HeaderText = "FACTURA"
        Me.FACTURA.Name = "FACTURA"
        Me.FACTURA.ReadOnly = True
        Me.FACTURA.Width = 150
        '
        'FOLIOFISCAL
        '
        Me.FOLIOFISCAL.HeaderText = "FOLIO FISCAL"
        Me.FOLIOFISCAL.Name = "FOLIOFISCAL"
        Me.FOLIOFISCAL.ReadOnly = True
        Me.FOLIOFISCAL.Width = 150
        '
        'FECHAFACTURA
        '
        Me.FECHAFACTURA.HeaderText = "FECHA DE FACTURA"
        Me.FECHAFACTURA.Name = "FECHAFACTURA"
        Me.FECHAFACTURA.ReadOnly = True
        Me.FECHAFACTURA.Width = 150
        '
        'FECHACAPTURA
        '
        Me.FECHACAPTURA.HeaderText = "FECHA DE CAPTURA"
        Me.FECHACAPTURA.Name = "FECHACAPTURA"
        Me.FECHACAPTURA.ReadOnly = True
        Me.FECHACAPTURA.Width = 150
        '
        'ID_UBICACION
        '
        Me.ID_UBICACION.HeaderText = "ID_UBICACION"
        Me.ID_UBICACION.Name = "ID_UBICACION"
        Me.ID_UBICACION.ReadOnly = True
        Me.ID_UBICACION.Visible = False
        '
        'UBICACION
        '
        Me.UBICACION.HeaderText = "UBICACIÓN"
        Me.UBICACION.Name = "UBICACION"
        Me.UBICACION.ReadOnly = True
        Me.UBICACION.Width = 200
        '
        'ID_SUBCAPITULO
        '
        Me.ID_SUBCAPITULO.HeaderText = "ID_SUBCAPITULO"
        Me.ID_SUBCAPITULO.Name = "ID_SUBCAPITULO"
        Me.ID_SUBCAPITULO.ReadOnly = True
        Me.ID_SUBCAPITULO.Visible = False
        '
        'SUBCAPITULO
        '
        Me.SUBCAPITULO.HeaderText = "SUBCAPITULO"
        Me.SUBCAPITULO.Name = "SUBCAPITULO"
        Me.SUBCAPITULO.ReadOnly = True
        '
        'ID_PARTIDA
        '
        Me.ID_PARTIDA.HeaderText = "ID_PARTIDA"
        Me.ID_PARTIDA.Name = "ID_PARTIDA"
        Me.ID_PARTIDA.ReadOnly = True
        Me.ID_PARTIDA.Visible = False
        '
        'PARTIDA
        '
        Me.PARTIDA.HeaderText = "PARTIDA"
        Me.PARTIDA.Name = "PARTIDA"
        Me.PARTIDA.ReadOnly = True
        '
        'ID_GRUPO
        '
        Me.ID_GRUPO.HeaderText = "ID_GRUPO"
        Me.ID_GRUPO.Name = "ID_GRUPO"
        Me.ID_GRUPO.ReadOnly = True
        Me.ID_GRUPO.Visible = False
        '
        'GRUPO
        '
        Me.GRUPO.HeaderText = "GRUPO"
        Me.GRUPO.Name = "GRUPO"
        Me.GRUPO.ReadOnly = True
        '
        'ID_MARCA
        '
        Me.ID_MARCA.HeaderText = "ID_MARCA"
        Me.ID_MARCA.Name = "ID_MARCA"
        Me.ID_MARCA.ReadOnly = True
        Me.ID_MARCA.Visible = False
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "MARCA"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        '
        'ID_MODELO
        '
        Me.ID_MODELO.HeaderText = "ID_MODELO"
        Me.ID_MODELO.Name = "ID_MODELO"
        Me.ID_MODELO.ReadOnly = True
        Me.ID_MODELO.Visible = False
        '
        'MODELO
        '
        Me.MODELO.HeaderText = "MODELO"
        Me.MODELO.Name = "MODELO"
        Me.MODELO.ReadOnly = True
        '
        'NoSERIE
        '
        Me.NoSERIE.HeaderText = "No. SERIE"
        Me.NoSERIE.Name = "NoSERIE"
        Me.NoSERIE.ReadOnly = True
        '
        'NoIDENTIFICACION
        '
        Me.NoIDENTIFICACION.HeaderText = "NoIDENTIFICACIÓN"
        Me.NoIDENTIFICACION.Name = "NoIDENTIFICACION"
        Me.NoIDENTIFICACION.ReadOnly = True
        Me.NoIDENTIFICACION.Width = 150
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'UNIDAD
        '
        Me.UNIDAD.HeaderText = "UNIDAD"
        Me.UNIDAD.Name = "UNIDAD"
        Me.UNIDAD.ReadOnly = True
        '
        'CLAVEPRODUCTO
        '
        Me.CLAVEPRODUCTO.HeaderText = "CLAVE DE PRODUCTO"
        Me.CLAVEPRODUCTO.Name = "CLAVEPRODUCTO"
        Me.CLAVEPRODUCTO.ReadOnly = True
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCIÓN"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 200
        '
        'DESCRIPCION_COMPLEMENTO
        '
        Me.DESCRIPCION_COMPLEMENTO.HeaderText = "DESCRIPCION_COMPLEMENTO"
        Me.DESCRIPCION_COMPLEMENTO.MaxInputLength = 250
        Me.DESCRIPCION_COMPLEMENTO.Name = "DESCRIPCION_COMPLEMENTO"
        Me.DESCRIPCION_COMPLEMENTO.ReadOnly = True
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "VALOR"
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        '
        'NoRESGUARDO
        '
        Me.NoRESGUARDO.HeaderText = "No. RESGUARDO"
        Me.NoRESGUARDO.Name = "NoRESGUARDO"
        Me.NoRESGUARDO.ReadOnly = True
        '
        'ID_RESGUARDATORIO
        '
        Me.ID_RESGUARDATORIO.HeaderText = "ID_RESGUARDATORIO"
        Me.ID_RESGUARDATORIO.Name = "ID_RESGUARDATORIO"
        Me.ID_RESGUARDATORIO.ReadOnly = True
        Me.ID_RESGUARDATORIO.Visible = False
        '
        'RESGUARDATORIO
        '
        Me.RESGUARDATORIO.HeaderText = "RESGUARDATORIO"
        Me.RESGUARDATORIO.Name = "RESGUARDATORIO"
        Me.RESGUARDATORIO.ReadOnly = True
        Me.RESGUARDATORIO.Width = 150
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.ReadOnly = True
        Me.OBSERVACIONES.Width = 150
        '
        'ETIQUETADO
        '
        Me.ETIQUETADO.HeaderText = "ETIQUETADO"
        Me.ETIQUETADO.Name = "ETIQUETADO"
        Me.ETIQUETADO.ReadOnly = True
        '
        'POLIZA
        '
        Me.POLIZA.HeaderText = "POLIZA"
        Me.POLIZA.Name = "POLIZA"
        Me.POLIZA.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.Location = New System.Drawing.Point(73, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 203
        Me.Label11.Text = "Folio fiscal"
        '
        'tbFoliofiscal
        '
        Me.tbFoliofiscal.AllowDrop = True
        Me.tbFoliofiscal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbFoliofiscal.Location = New System.Drawing.Point(135, 252)
        Me.tbFoliofiscal.MaxLength = 36
        Me.tbFoliofiscal.Name = "tbFoliofiscal"
        Me.tbFoliofiscal.Size = New System.Drawing.Size(246, 20)
        Me.tbFoliofiscal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Location = New System.Drawing.Point(86, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 201
        Me.Label5.Text = "Factura"
        '
        'tbFoliofactura
        '
        Me.tbFoliofactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbFoliofactura.Location = New System.Drawing.Point(135, 224)
        Me.tbFoliofactura.MaxLength = 20
        Me.tbFoliofactura.Name = "tbFoliofactura"
        Me.tbFoliofactura.Size = New System.Drawing.Size(141, 20)
        Me.tbFoliofactura.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.Location = New System.Drawing.Point(30, 194)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 13)
        Me.Label23.TabIndex = 199
        Me.Label23.Text = "Licitación / Compra"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.Location = New System.Drawing.Point(30, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 197
        Me.Label14.Text = "Tipo de adquisición"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.Location = New System.Drawing.Point(34, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 195
        Me.Label13.Text = "Nombre proveedor"
        '
        'cbProveedores
        '
        Me.cbProveedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.DropDownWidth = 420
        Me.cbProveedores.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(135, 135)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(246, 22)
        Me.cbProveedores.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.Location = New System.Drawing.Point(57, 106)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 13)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Fuente Finan."
        '
        'cbCuentas
        '
        Me.cbCuentas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas.DropDownWidth = 300
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Location = New System.Drawing.Point(135, 106)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(247, 21)
        Me.cbCuentas.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.Location = New System.Drawing.Point(56, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 13)
        Me.Label22.TabIndex = 191
        Me.Label22.Text = "No. Inventario"
        '
        'tbInventario
        '
        Me.tbInventario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbInventario.Location = New System.Drawing.Point(135, 44)
        Me.tbInventario.Name = "tbInventario"
        Me.tbInventario.Size = New System.Drawing.Size(185, 20)
        Me.tbInventario.TabIndex = 190
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.Location = New System.Drawing.Point(82, 76)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 13)
        Me.Label27.TabIndex = 189
        Me.Label27.Text = "Ejercicio"
        '
        'cbEjercicio
        '
        Me.cbEjercicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Location = New System.Drawing.Point(135, 73)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(103, 21)
        Me.cbEjercicio.TabIndex = 0
        '
        'cblicitacion
        '
        Me.cblicitacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cblicitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblicitacion.FormattingEnabled = True
        Me.cblicitacion.Location = New System.Drawing.Point(135, 193)
        Me.cblicitacion.Name = "cblicitacion"
        Me.cblicitacion.Size = New System.Drawing.Size(141, 21)
        Me.cblicitacion.TabIndex = 4
        '
        'cbtipoadq
        '
        Me.cbtipoadq.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbtipoadq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipoadq.FormattingEnabled = True
        Me.cbtipoadq.Location = New System.Drawing.Point(136, 165)
        Me.cbtipoadq.Name = "cbtipoadq"
        Me.cbtipoadq.Size = New System.Drawing.Size(141, 21)
        Me.cbtipoadq.TabIndex = 3
        '
        'cbdescripcion
        '
        Me.cbdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbdescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdescripcion.DropDownWidth = 550
        Me.cbdescripcion.FormattingEnabled = True
        Me.cbdescripcion.Location = New System.Drawing.Point(655, 195)
        Me.cbdescripcion.Name = "cbdescripcion"
        Me.cbdescripcion.Size = New System.Drawing.Size(325, 21)
        Me.cbdescripcion.TabIndex = 20
        '
        'tbPoliza
        '
        Me.tbPoliza.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbPoliza.Location = New System.Drawing.Point(859, 283)
        Me.tbPoliza.MaxLength = 10
        Me.tbPoliza.Name = "tbPoliza"
        Me.tbPoliza.Size = New System.Drawing.Size(119, 20)
        Me.tbPoliza.TabIndex = 250
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(823, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 251
        Me.Label8.Text = "Póliza"
        '
        'chbSerie
        '
        Me.chbSerie.AutoSize = True
        Me.chbSerie.Location = New System.Drawing.Point(895, 110)
        Me.chbSerie.Name = "chbSerie"
        Me.chbSerie.Size = New System.Drawing.Size(66, 17)
        Me.chbSerie.TabIndex = 252
        Me.chbSerie.Text = "Sin serie"
        Me.chbSerie.UseVisualStyleBackColor = True
        '
        'tbiva
        '
        Me.tbiva.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbiva.Location = New System.Drawing.Point(795, 252)
        Me.tbiva.MaxLength = 20
        Me.tbiva.Name = "tbiva"
        Me.tbiva.Size = New System.Drawing.Size(68, 20)
        Me.tbiva.TabIndex = 253
        Me.tbiva.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.Location = New System.Drawing.Point(762, 257)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 20)
        Me.Label28.TabIndex = 254
        Me.Label28.Text = "IVA"
        Me.Label28.Visible = False
        '
        'tbimporte
        '
        Me.tbimporte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbimporte.Location = New System.Drawing.Point(914, 252)
        Me.tbimporte.MaxLength = 20
        Me.tbimporte.Name = "tbimporte"
        Me.tbimporte.Size = New System.Drawing.Size(97, 20)
        Me.tbimporte.TabIndex = 255
        Me.tbimporte.Visible = False
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label29.Location = New System.Drawing.Point(869, 255)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 20)
        Me.Label29.TabIndex = 256
        Me.Label29.Text = "Importe"
        Me.Label29.Visible = False
        '
        'btbuscar
        '
        Me.btbuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btbuscar.Location = New System.Drawing.Point(410, 42)
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(55, 23)
        Me.btbuscar.TabIndex = 257
        Me.btbuscar.Text = "Buscar"
        Me.btbuscar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1049, 25)
        Me.ToolStrip1.TabIndex = 258
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripButton2.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton1.Text = "Editar"
        '
        'tbComplemento
        '
        Me.tbComplemento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbComplemento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbComplemento.Location = New System.Drawing.Point(655, 223)
        Me.tbComplemento.MaxLength = 250
        Me.tbComplemento.Name = "tbComplemento"
        Me.tbComplemento.Size = New System.Drawing.Size(357, 20)
        Me.tbComplemento.TabIndex = 259
        '
        'chbInventario
        '
        Me.chbInventario.AutoSize = True
        Me.chbInventario.Location = New System.Drawing.Point(326, 46)
        Me.chbInventario.Name = "chbInventario"
        Me.chbInventario.Size = New System.Drawing.Size(85, 17)
        Me.chbInventario.TabIndex = 260
        Me.chbInventario.Text = "S/Inventario"
        Me.chbInventario.UseVisualStyleBackColor = True
        '
        'cbidentificacion
        '
        Me.cbidentificacion.AutoSize = True
        Me.cbidentificacion.Location = New System.Drawing.Point(773, 139)
        Me.cbidentificacion.Name = "cbidentificacion"
        Me.cbidentificacion.Size = New System.Drawing.Size(45, 17)
        Me.cbidentificacion.TabIndex = 261
        Me.cbidentificacion.Text = "N/a"
        Me.cbidentificacion.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(972, 168)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox3.TabIndex = 262
        Me.CheckBox3.Text = "N/a"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(981, 285)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox4.TabIndex = 263
        Me.CheckBox4.Text = "N/a"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(772, 286)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox5.TabIndex = 264
        Me.CheckBox5.Text = "N/a"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label30.Location = New System.Drawing.Point(581, 226)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 13)
        Me.Label30.TabIndex = 265
        Me.Label30.Text = "Complemento"
        '
        'lbDescripcion
        '
        Me.lbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbDescripcion.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbDescripcion.Location = New System.Drawing.Point(133, 450)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(421, 13)
        Me.lbDescripcion.TabIndex = 267
        Me.lbDescripcion.Text = "Complemento"
        '
        'INVENTARIO
        '
        Me.AcceptButton = Me.btbuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 749)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.cbidentificacion)
        Me.Controls.Add(Me.chbInventario)
        Me.Controls.Add(Me.tbComplemento)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btbuscar)
        Me.Controls.Add(Me.tbimporte)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.tbiva)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.chbSerie)
        Me.Controls.Add(Me.tbPoliza)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbdescripcion)
        Me.Controls.Add(Me.cbtipoadq)
        Me.Controls.Add(Me.cblicitacion)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btactualizar)
        Me.Controls.Add(Me.tbresguardo)
        Me.Controls.Add(Me.tbvalor)
        Me.Controls.Add(Me.tbproducto)
        Me.Controls.Add(Me.tbunidad)
        Me.Controls.Add(Me.tbcantidad)
        Me.Controls.Add(Me.tbidentificacion)
        Me.Controls.Add(Me.tbserie)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cbmodelo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbmarca)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbobservacion)
        Me.Controls.Add(Me.chbetiquetado)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPartidas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbResguardatario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSubcapitulo)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbubicacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechafactura)
        Me.Controls.Add(Me.dtpFecharecepcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbFoliofiscal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbFoliofactura)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbProveedores)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbInventario)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Name = "INVENTARIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTIVOS FIJOS"
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents btactualizar As Button
    Public WithEvents tbresguardo As TextBox
    Public WithEvents tbvalor As TextBox
    Public WithEvents tbproducto As TextBox
    Public WithEvents tbunidad As TextBox
    Public WithEvents tbcantidad As TextBox
    Public WithEvents tbidentificacion As TextBox
    Public WithEvents tbserie As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btagregar As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents cbmodelo As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cbmarca As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label10 As Label
    Public WithEvents tbobservacion As TextBox
    Friend WithEvents chbetiquetado As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbGrupo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPartidas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbResguardatario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSubcapitulo As ComboBox
    Friend WithEvents btguardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbubicacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechafactura As DateTimePicker
    Friend WithEvents dtpFecharecepcion As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDetalles As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents tbFoliofiscal As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents tbFoliofactura As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbCuentas As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tbInventario As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents cbEjercicio As ComboBox
    Friend WithEvents cblicitacion As ComboBox
    Friend WithEvents cbtipoadq As ComboBox
    Friend WithEvents cbdescripcion As ComboBox
    Public WithEvents tbPoliza As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chbSerie As CheckBox
    Public WithEvents tbiva As TextBox
    Friend WithEvents Label28 As Label
    Public WithEvents tbimporte As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents btbuscar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Public WithEvents tbComplemento As TextBox
    Friend WithEvents chbInventario As CheckBox
    Friend WithEvents cbidentificacion As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents NO_INVENTARIO As DataGridViewTextBoxColumn
    Friend WithEvents ID_EJERCICIO As DataGridViewTextBoxColumn
    Friend WithEvents EJERCICIO As DataGridViewTextBoxColumn
    Friend WithEvents ID_FUENTE As DataGridViewTextBoxColumn
    Friend WithEvents FUENTE As DataGridViewTextBoxColumn
    Friend WithEvents ID_PROVEEDOR As DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR As DataGridViewTextBoxColumn
    Friend WithEvents ID_TIPO_ADQUISICION As DataGridViewTextBoxColumn
    Friend WithEvents TIPOADQUISION As DataGridViewTextBoxColumn
    Friend WithEvents ID_LICITACION As DataGridViewTextBoxColumn
    Friend WithEvents LICITACION As DataGridViewTextBoxColumn
    Friend WithEvents FACTURA As DataGridViewTextBoxColumn
    Friend WithEvents FOLIOFISCAL As DataGridViewTextBoxColumn
    Friend WithEvents FECHAFACTURA As DataGridViewTextBoxColumn
    Friend WithEvents FECHACAPTURA As DataGridViewTextBoxColumn
    Friend WithEvents ID_UBICACION As DataGridViewTextBoxColumn
    Friend WithEvents UBICACION As DataGridViewTextBoxColumn
    Friend WithEvents ID_SUBCAPITULO As DataGridViewTextBoxColumn
    Friend WithEvents SUBCAPITULO As DataGridViewTextBoxColumn
    Friend WithEvents ID_PARTIDA As DataGridViewTextBoxColumn
    Friend WithEvents PARTIDA As DataGridViewTextBoxColumn
    Friend WithEvents ID_GRUPO As DataGridViewTextBoxColumn
    Friend WithEvents GRUPO As DataGridViewTextBoxColumn
    Friend WithEvents ID_MARCA As DataGridViewTextBoxColumn
    Friend WithEvents MARCA As DataGridViewTextBoxColumn
    Friend WithEvents ID_MODELO As DataGridViewTextBoxColumn
    Friend WithEvents MODELO As DataGridViewTextBoxColumn
    Friend WithEvents NoSERIE As DataGridViewTextBoxColumn
    Friend WithEvents NoIDENTIFICACION As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents UNIDAD As DataGridViewTextBoxColumn
    Friend WithEvents CLAVEPRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION_COMPLEMENTO As DataGridViewTextBoxColumn
    Friend WithEvents VALOR As DataGridViewTextBoxColumn
    Friend WithEvents NoRESGUARDO As DataGridViewTextBoxColumn
    Friend WithEvents ID_RESGUARDATORIO As DataGridViewTextBoxColumn
    Friend WithEvents RESGUARDATORIO As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONES As DataGridViewTextBoxColumn
    Friend WithEvents ETIQUETADO As DataGridViewTextBoxColumn
    Friend WithEvents POLIZA As DataGridViewTextBoxColumn
    Friend WithEvents Label30 As Label
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class

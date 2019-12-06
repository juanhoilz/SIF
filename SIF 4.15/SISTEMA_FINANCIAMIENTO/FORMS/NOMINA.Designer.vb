<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOMINA
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSubsidioempleo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbTotalpago = New System.Windows.Forms.TextBox()
        Me.lbTotalpago = New System.Windows.Forms.Label()
        Me.tbCauses = New System.Windows.Forms.TextBox()
        Me.lbCauses = New System.Windows.Forms.Label()
        Me.cbCAUSES = New System.Windows.Forms.ComboBox()
        Me.tbSobreprecio = New System.Windows.Forms.TextBox()
        Me.lbSobreprecio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btMedicamentos = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbTipoadquisicion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbIdentificador = New System.Windows.Forms.Label()
        Me.btXml = New System.Windows.Forms.Button()
        Me.btAgregarconceptos = New System.Windows.Forms.Button()
        Me.btCapturaconceptos = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbFolio = New System.Windows.Forms.TextBox()
        Me.cbLicitaciones = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbFoliofiscal = New System.Windows.Forms.TextBox()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFecharecepcion = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechafactura = New System.Windows.Forms.DateTimePicker()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.cbcuenta = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbPartida = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbPedido = New System.Windows.Forms.CheckBox()
        Me.chbCotiza = New System.Windows.Forms.CheckBox()
        Me.chbVale = New System.Windows.Forms.CheckBox()
        Me.chbOrden = New System.Windows.Forms.CheckBox()
        Me.chbServicio = New System.Windows.Forms.CheckBox()
        Me.chBSoporte = New System.Windows.Forms.CheckBox()
        Me.chbFirmado = New System.Windows.Forms.CheckBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbRetencion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbIva = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFoliofactura = New System.Windows.Forms.TextBox()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSubsidioempleo
        '
        Me.tbSubsidioempleo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSubsidioempleo.Location = New System.Drawing.Point(686, 213)
        Me.tbSubsidioempleo.MaxLength = 15
        Me.tbSubsidioempleo.Name = "tbSubsidioempleo"
        Me.tbSubsidioempleo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbSubsidioempleo.Size = New System.Drawing.Size(119, 20)
        Me.tbSubsidioempleo.TabIndex = 172
        Me.tbSubsidioempleo.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(584, 220)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 171
        Me.Label19.Text = "Subsidio al empleo"
        '
        'tbTotalpago
        '
        Me.tbTotalpago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotalpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalpago.Location = New System.Drawing.Point(1100, 523)
        Me.tbTotalpago.Name = "tbTotalpago"
        Me.tbTotalpago.Size = New System.Drawing.Size(89, 20)
        Me.tbTotalpago.TabIndex = 154
        '
        'lbTotalpago
        '
        Me.lbTotalpago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotalpago.AutoSize = True
        Me.lbTotalpago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbTotalpago.Location = New System.Drawing.Point(1030, 526)
        Me.lbTotalpago.Name = "lbTotalpago"
        Me.lbTotalpago.Size = New System.Drawing.Size(70, 13)
        Me.lbTotalpago.TabIndex = 121
        Me.lbTotalpago.Text = "Total a pagar"
        '
        'tbCauses
        '
        Me.tbCauses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCauses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCauses.Location = New System.Drawing.Point(929, 523)
        Me.tbCauses.Name = "tbCauses"
        Me.tbCauses.Size = New System.Drawing.Size(89, 20)
        Me.tbCauses.TabIndex = 152
        '
        'lbCauses
        '
        Me.lbCauses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCauses.AutoSize = True
        Me.lbCauses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbCauses.Location = New System.Drawing.Point(859, 527)
        Me.lbCauses.Name = "lbCauses"
        Me.lbCauses.Size = New System.Drawing.Size(68, 13)
        Me.lbCauses.TabIndex = 118
        Me.lbCauses.Text = "Sin CAUSES"
        '
        'cbCAUSES
        '
        Me.cbCAUSES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCAUSES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCAUSES.FormattingEnabled = True
        Me.cbCAUSES.Items.AddRange(New Object() {"2016", "2018"})
        Me.cbCAUSES.Location = New System.Drawing.Point(133, 352)
        Me.cbCAUSES.Name = "cbCAUSES"
        Me.cbCAUSES.Size = New System.Drawing.Size(121, 21)
        Me.cbCAUSES.TabIndex = 127
        '
        'tbSobreprecio
        '
        Me.tbSobreprecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSobreprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSobreprecio.Location = New System.Drawing.Point(758, 523)
        Me.tbSobreprecio.Name = "tbSobreprecio"
        Me.tbSobreprecio.Size = New System.Drawing.Size(89, 20)
        Me.tbSobreprecio.TabIndex = 151
        '
        'lbSobreprecio
        '
        Me.lbSobreprecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSobreprecio.AutoSize = True
        Me.lbSobreprecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbSobreprecio.Location = New System.Drawing.Point(690, 526)
        Me.lbSobreprecio.Name = "lbSobreprecio"
        Me.lbSobreprecio.Size = New System.Drawing.Size(64, 13)
        Me.lbSobreprecio.TabIndex = 112
        Me.lbSobreprecio.Text = "Sobreprecio"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "CAUSES"
        '
        'btMedicamentos
        '
        Me.btMedicamentos.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_comprobado_16
        Me.btMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMedicamentos.Location = New System.Drawing.Point(312, 387)
        Me.btMedicamentos.Name = "btMedicamentos"
        Me.btMedicamentos.Size = New System.Drawing.Size(79, 27)
        Me.btMedicamentos.TabIndex = 130
        Me.btMedicamentos.Text = "Validar"
        Me.btMedicamentos.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(153, 527)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 169
        Me.CheckBox1.Text = "Editar partidas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbTipoadquisicion
        '
        Me.cbTipoadquisicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoadquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoadquisicion.FormattingEnabled = True
        Me.cbTipoadquisicion.Location = New System.Drawing.Point(134, 179)
        Me.cbTipoadquisicion.Name = "cbTipoadquisicion"
        Me.cbTipoadquisicion.Size = New System.Drawing.Size(259, 21)
        Me.cbTipoadquisicion.TabIndex = 119
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 183)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "Tipo de adquisición"
        '
        'lbIdentificador
        '
        Me.lbIdentificador.AllowDrop = True
        Me.lbIdentificador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbIdentificador.AutoSize = True
        Me.lbIdentificador.ForeColor = System.Drawing.Color.Red
        Me.lbIdentificador.Location = New System.Drawing.Point(449, 471)
        Me.lbIdentificador.Name = "lbIdentificador"
        Me.lbIdentificador.Size = New System.Drawing.Size(107, 13)
        Me.lbIdentificador.TabIndex = 167
        Me.lbIdentificador.Text = "Capturar identificador"
        '
        'btXml
        '
        Me.btXml.Location = New System.Drawing.Point(133, 387)
        Me.btXml.Name = "btXml"
        Me.btXml.Size = New System.Drawing.Size(88, 27)
        Me.btXml.TabIndex = 128
        Me.btXml.Text = "Importar xml"
        Me.btXml.UseVisualStyleBackColor = True
        '
        'btAgregarconceptos
        '
        Me.btAgregarconceptos.Location = New System.Drawing.Point(22, 523)
        Me.btAgregarconceptos.Name = "btAgregarconceptos"
        Me.btAgregarconceptos.Size = New System.Drawing.Size(125, 23)
        Me.btAgregarconceptos.TabIndex = 135
        Me.btAgregarconceptos.Text = "Agregar registro"
        Me.btAgregarconceptos.UseVisualStyleBackColor = True
        '
        'btCapturaconceptos
        '
        Me.btCapturaconceptos.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.ToggleOfficeKeyboardScheme_7508
        Me.btCapturaconceptos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btCapturaconceptos.Location = New System.Drawing.Point(227, 387)
        Me.btCapturaconceptos.Name = "btCapturaconceptos"
        Me.btCapturaconceptos.Size = New System.Drawing.Size(79, 27)
        Me.btCapturaconceptos.TabIndex = 129
        Me.btCapturaconceptos.Text = "Capturar"
        Me.btCapturaconceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCapturaconceptos.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(55, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 166
        Me.Label18.Text = "financiamiento"
        '
        'cbEstatus
        '
        Me.cbEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatus.Enabled = False
        Me.cbEstatus.FormattingEnabled = True
        Me.cbEstatus.Location = New System.Drawing.Point(1023, 252)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.cbEstatus.TabIndex = 145
        Me.cbEstatus.Visible = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(975, 255)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 165
        Me.Label24.Text = "Estatus"
        Me.Label24.Visible = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(101, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 13)
        Me.Label22.TabIndex = 164
        Me.Label22.Text = "Folio"
        '
        'tbFolio
        '
        Me.tbFolio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFolio.Location = New System.Drawing.Point(136, 33)
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.Size = New System.Drawing.Size(100, 20)
        Me.tbFolio.TabIndex = 163
        '
        'cbLicitaciones
        '
        Me.cbLicitaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLicitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLicitaciones.FormattingEnabled = True
        Me.cbLicitaciones.Location = New System.Drawing.Point(134, 212)
        Me.cbLicitaciones.Name = "cbLicitaciones"
        Me.cbLicitaciones.Size = New System.Drawing.Size(259, 21)
        Me.cbLicitaciones.TabIndex = 120
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(76, 215)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 13)
        Me.Label23.TabIndex = 162
        Me.Label23.Text = "Licitación"
        '
        'cbRubro
        '
        Me.cbRubro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.DropDownWidth = 350
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(134, 108)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(259, 21)
        Me.cbRubro.TabIndex = 114
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(93, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 161
        Me.Label21.Text = "Rubro"
        '
        'cbEjercicio
        '
        Me.cbEjercicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Location = New System.Drawing.Point(136, 71)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(121, 21)
        Me.cbEjercicio.TabIndex = 113
        '
        'Label20
        '
        Me.Label20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(83, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 160
        Me.Label20.Text = "Ejercicio"
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(74, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "Folio fiscal"
        '
        'tbFoliofiscal
        '
        Me.tbFoliofiscal.AllowDrop = True
        Me.tbFoliofiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFoliofiscal.Location = New System.Drawing.Point(135, 468)
        Me.tbFoliofiscal.MaxLength = 20
        Me.tbFoliofiscal.Name = "tbFoliofiscal"
        Me.tbFoliofiscal.Size = New System.Drawing.Size(308, 20)
        Me.tbFoliofiscal.TabIndex = 133
        '
        'BtGuardar
        '
        Me.BtGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtGuardar.AutoSize = True
        Me.BtGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BtGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtGuardar.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtGuardar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.guardar
        Me.BtGuardar.Location = New System.Drawing.Point(772, 418)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(54, 44)
        Me.BtGuardar.TabIndex = 150
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
        Me.BtAgregar.Location = New System.Drawing.Point(683, 419)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(52, 43)
        Me.BtAgregar.TabIndex = 149
        Me.BtAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAgregar.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalles.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalles.Location = New System.Drawing.Point(22, 553)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dgvDetalles.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(1169, 164)
        Me.dgvDetalles.TabIndex = 156
        '
        'cbCuentas
        '
        Me.cbCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas.DropDownWidth = 300
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Location = New System.Drawing.Point(134, 144)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(259, 21)
        Me.cbCuentas.TabIndex = 117
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(90, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "Fuente"
        '
        'dtpFecharecepcion
        '
        Me.dtpFecharecepcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecharecepcion.Checked = False
        Me.dtpFecharecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecharecepcion.Location = New System.Drawing.Point(906, 37)
        Me.dtpFecharecepcion.Name = "dtpFecharecepcion"
        Me.dtpFecharecepcion.Size = New System.Drawing.Size(123, 20)
        Me.dtpFecharecepcion.TabIndex = 137
        Me.dtpFecharecepcion.Value = New Date(2018, 9, 8, 0, 0, 0, 0)
        '
        'dtpFechafactura
        '
        Me.dtpFechafactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechafactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechafactura.Location = New System.Drawing.Point(685, 37)
        Me.dtpFechafactura.Name = "dtpFechafactura"
        Me.dtpFechafactura.Size = New System.Drawing.Size(123, 20)
        Me.dtpFechafactura.TabIndex = 136
        Me.dtpFechafactura.Value = New Date(2018, 6, 19, 10, 11, 1, 0)
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
        Me.cbProveedores.Location = New System.Drawing.Point(134, 281)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(308, 22)
        Me.cbProveedores.TabIndex = 124
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(599, 289)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 157
        Me.Label17.Text = "Observaciones"
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbObservaciones.Location = New System.Drawing.Point(683, 286)
        Me.tbObservaciones.MaxLength = 200
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(461, 21)
        Me.tbObservaciones.TabIndex = 146
        '
        'cbcuenta
        '
        Me.cbcuenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbcuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcuenta.FormattingEnabled = True
        Me.cbcuenta.Location = New System.Drawing.Point(134, 245)
        Me.cbcuenta.Name = "cbcuenta"
        Me.cbcuenta.Size = New System.Drawing.Size(259, 21)
        Me.cbcuenta.TabIndex = 123
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(35, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 155
        Me.Label16.Text = "Número de cuenta"
        '
        'cbUnidad
        '
        Me.cbUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Location = New System.Drawing.Point(685, 73)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(349, 21)
        Me.cbUnidad.TabIndex = 139
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(572, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 13)
        Me.Label15.TabIndex = 153
        Me.Label15.Text = "Unidad administrativa"
        '
        'cbPartida
        '
        Me.cbPartida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPartida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartida.DropDownWidth = 560
        Me.cbPartida.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPartida.FormattingEnabled = True
        Me.cbPartida.Location = New System.Drawing.Point(133, 317)
        Me.cbPartida.Name = "cbPartida"
        Me.cbPartida.Size = New System.Drawing.Size(309, 22)
        Me.cbPartida.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(87, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "Partida"
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
        Me.GroupBox1.Location = New System.Drawing.Point(683, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 77)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DOCUMENTOS"
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
        'tbTotal
        '
        Me.tbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotal.Location = New System.Drawing.Point(686, 249)
        Me.tbTotal.MaxLength = 15
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTotal.Size = New System.Drawing.Size(119, 20)
        Me.tbTotal.TabIndex = 144
        Me.tbTotal.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(646, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Total"
        '
        'tbRetencion
        '
        Me.tbRetencion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRetencion.Location = New System.Drawing.Point(686, 182)
        Me.tbRetencion.MaxLength = 15
        Me.tbRetencion.Name = "tbRetencion"
        Me.tbRetencion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbRetencion.Size = New System.Drawing.Size(119, 20)
        Me.tbRetencion.TabIndex = 143
        Me.tbRetencion.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(623, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 138
        Me.Label9.Text = "Retención"
        '
        'tbIva
        '
        Me.tbIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbIva.Location = New System.Drawing.Point(686, 146)
        Me.tbIva.MaxLength = 15
        Me.tbIva.Name = "tbIva"
        Me.tbIva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbIva.Size = New System.Drawing.Size(119, 20)
        Me.tbIva.TabIndex = 141
        Me.tbIva.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(655, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "IVA"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSubtotal.Location = New System.Drawing.Point(685, 112)
        Me.tbSubtotal.MaxLength = 15
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbSubtotal.Size = New System.Drawing.Size(119, 20)
        Me.tbSubtotal.TabIndex = 140
        Me.tbSubtotal.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(633, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "Subtotal"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Nombre proveedor"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(607, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Fecha factura"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(816, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Fecha recepción"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Factura"
        '
        'tbFoliofactura
        '
        Me.tbFoliofactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFoliofactura.Location = New System.Drawing.Point(133, 429)
        Me.tbFoliofactura.MaxLength = 20
        Me.tbFoliofactura.Name = "tbFoliofactura"
        Me.tbFoliofactura.Size = New System.Drawing.Size(258, 20)
        Me.tbFoliofactura.TabIndex = 132
        '
        'NOMINA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 749)
        Me.Controls.Add(Me.tbSubsidioempleo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbTotalpago)
        Me.Controls.Add(Me.lbTotalpago)
        Me.Controls.Add(Me.tbCauses)
        Me.Controls.Add(Me.lbCauses)
        Me.Controls.Add(Me.cbCAUSES)
        Me.Controls.Add(Me.tbSobreprecio)
        Me.Controls.Add(Me.lbSobreprecio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btMedicamentos)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cbTipoadquisicion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbIdentificador)
        Me.Controls.Add(Me.btXml)
        Me.Controls.Add(Me.btAgregarconceptos)
        Me.Controls.Add(Me.btCapturaconceptos)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbEstatus)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.cbLicitaciones)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cbRubro)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbFoliofiscal)
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
        Me.Name = "NOMINA"
        Me.Text = "NOMINA"
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSubsidioempleo As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbTotalpago As TextBox
    Friend WithEvents lbTotalpago As Label
    Friend WithEvents tbCauses As TextBox
    Friend WithEvents lbCauses As Label
    Friend WithEvents cbCAUSES As ComboBox
    Friend WithEvents tbSobreprecio As TextBox
    Friend WithEvents lbSobreprecio As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btMedicamentos As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cbTipoadquisicion As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lbIdentificador As Label
    Friend WithEvents btXml As Button
    Friend WithEvents btAgregarconceptos As Button
    Friend WithEvents btCapturaconceptos As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents cbEstatus As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents tbFolio As TextBox
    Friend WithEvents cbLicitaciones As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cbRubro As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cbEjercicio As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbFoliofiscal As TextBox
    Friend WithEvents BtGuardar As Button
    Friend WithEvents BtAgregar As Button
    Friend WithEvents dgvDetalles As DataGridView
    Friend WithEvents cbCuentas As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFecharecepcion As DateTimePicker
    Friend WithEvents dtpFechafactura As DateTimePicker
    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbObservaciones As TextBox
    Friend WithEvents cbcuenta As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbPartida As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chbPedido As CheckBox
    Friend WithEvents chbCotiza As CheckBox
    Friend WithEvents chbVale As CheckBox
    Friend WithEvents chbOrden As CheckBox
    Friend WithEvents chbServicio As CheckBox
    Friend WithEvents chBSoporte As CheckBox
    Friend WithEvents chbFirmado As CheckBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbRetencion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbIva As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSubtotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents tbFoliofactura As TextBox
End Class

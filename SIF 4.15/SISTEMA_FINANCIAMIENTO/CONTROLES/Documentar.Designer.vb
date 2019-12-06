<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tbIdpedido = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbFoliofiscal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbIdorden = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbFirmaautoriza = New System.Windows.Forms.ComboBox()
        Me.cbFirmasolicita = New System.Windows.Forms.ComboBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.cbAplica = New System.Windows.Forms.ComboBox()
        Me.cbSolicita = New System.Windows.Forms.ComboBox()
        Me.cbPartida = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.dgvOrden = New System.Windows.Forms.DataGridView()
        Me.lbRutaarchivo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbOrden = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.tbIdpedido)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(996, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pedido"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(145, 161)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox2.TabIndex = 30
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ADQUISICION", "CANJE", "DONATIVO"})
        Me.ComboBox1.Location = New System.Drawing.Point(149, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(151, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 28
        '
        'Button6
        '
        Me.Button6.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.printer
        Me.Button6.Location = New System.Drawing.Point(265, 227)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 34)
        Me.Button6.TabIndex = 27
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.Button4.Location = New System.Drawing.Point(352, 161)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 23
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(147, 130)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(197, 20)
        Me.TextBox6.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(148, 100)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(197, 20)
        Me.TextBox4.TabIndex = 13
        '
        'tbIdpedido
        '
        Me.tbIdpedido.Enabled = False
        Me.tbIdpedido.Location = New System.Drawing.Point(149, 12)
        Me.tbIdpedido.Name = "tbIdpedido"
        Me.tbIdpedido.Size = New System.Drawing.Size(197, 20)
        Me.tbIdpedido.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(150, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Fecha pedido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Aplicación presupuestal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Firma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tipo adquisición"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Motivo del pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Folio"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(147, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 34)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 612)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.lbFoliofiscal)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.tbIdorden)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.cbFirmaautoriza)
        Me.TabPage1.Controls.Add(Me.cbFirmasolicita)
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.cbAplica)
        Me.TabPage1.Controls.Add(Me.cbSolicita)
        Me.TabPage1.Controls.Add(Me.cbPartida)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.cbProveedor)
        Me.TabPage1.Controls.Add(Me.dgvOrden)
        Me.TabPage1.Controls.Add(Me.lbRutaarchivo)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Button11)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.dtpFecha)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.tbMonto)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.tbOrden)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(996, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Orden de compra"
        '
        'lbFoliofiscal
        '
        Me.lbFoliofiscal.Enabled = False
        Me.lbFoliofiscal.Location = New System.Drawing.Point(585, 80)
        Me.lbFoliofiscal.Name = "lbFoliofiscal"
        Me.lbFoliofiscal.Size = New System.Drawing.Size(366, 20)
        Me.lbFoliofiscal.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(520, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Folio Fiscal"
        '
        'tbIdorden
        '
        Me.tbIdorden.Enabled = False
        Me.tbIdorden.Location = New System.Drawing.Point(139, 11)
        Me.tbIdorden.Name = "tbIdorden"
        Me.tbIdorden.Size = New System.Drawing.Size(184, 20)
        Me.tbIdorden.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(102, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Folio"
        '
        'cbFirmaautoriza
        '
        Me.cbFirmaautoriza.FormattingEnabled = True
        Me.cbFirmaautoriza.Location = New System.Drawing.Point(139, 266)
        Me.cbFirmaautoriza.Name = "cbFirmaautoriza"
        Me.cbFirmaautoriza.Size = New System.Drawing.Size(253, 21)
        Me.cbFirmaautoriza.TabIndex = 33
        '
        'cbFirmasolicita
        '
        Me.cbFirmasolicita.FormattingEnabled = True
        Me.cbFirmasolicita.Location = New System.Drawing.Point(139, 234)
        Me.cbFirmasolicita.Name = "cbFirmasolicita"
        Me.cbFirmasolicita.Size = New System.Drawing.Size(253, 21)
        Me.cbFirmasolicita.TabIndex = 32
        '
        'Button12
        '
        Me.Button12.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.Button12.Location = New System.Drawing.Point(398, 263)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(20, 20)
        Me.Button12.TabIndex = 31
        Me.Button12.UseVisualStyleBackColor = True
        '
        'cbAplica
        '
        Me.cbAplica.FormattingEnabled = True
        Me.cbAplica.Location = New System.Drawing.Point(139, 106)
        Me.cbAplica.Name = "cbAplica"
        Me.cbAplica.Size = New System.Drawing.Size(254, 21)
        Me.cbAplica.TabIndex = 30
        '
        'cbSolicita
        '
        Me.cbSolicita.FormattingEnabled = True
        Me.cbSolicita.Location = New System.Drawing.Point(139, 73)
        Me.cbSolicita.Name = "cbSolicita"
        Me.cbSolicita.Size = New System.Drawing.Size(253, 21)
        Me.cbSolicita.TabIndex = 29
        '
        'cbPartida
        '
        Me.cbPartida.DropDownWidth = 480
        Me.cbPartida.FormattingEnabled = True
        Me.cbPartida.Location = New System.Drawing.Point(585, 15)
        Me.cbPartida.Name = "cbPartida"
        Me.cbPartida.Size = New System.Drawing.Size(366, 21)
        Me.cbPartida.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(476, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Partida presupuestal"
        '
        'cbProveedor
        '
        Me.cbProveedor.BackColor = System.Drawing.Color.White
        Me.cbProveedor.DropDownWidth = 480
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.IntegralHeight = False
        Me.cbProveedor.Location = New System.Drawing.Point(139, 138)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(253, 21)
        Me.cbProveedor.TabIndex = 26
        '
        'dgvOrden
        '
        Me.dgvOrden.AllowUserToAddRows = False
        Me.dgvOrden.AllowUserToDeleteRows = False
        Me.dgvOrden.AllowUserToOrderColumns = True
        Me.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrden.Location = New System.Drawing.Point(35, 310)
        Me.dgvOrden.Name = "dgvOrden"
        Me.dgvOrden.Size = New System.Drawing.Size(923, 243)
        Me.dgvOrden.TabIndex = 25
        '
        'lbRutaarchivo
        '
        Me.lbRutaarchivo.Enabled = False
        Me.lbRutaarchivo.Location = New System.Drawing.Point(585, 47)
        Me.lbRutaarchivo.Name = "lbRutaarchivo"
        Me.lbRutaarchivo.Size = New System.Drawing.Size(366, 20)
        Me.lbRutaarchivo.TabIndex = 24
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(496, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Ruta de archivo"
        '
        'Button11
        '
        Me.Button11.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.printer
        Me.Button11.Location = New System.Drawing.Point(842, 130)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(87, 34)
        Me.Button11.TabIndex = 22
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(733, 130)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(87, 34)
        Me.Button10.TabIndex = 21
        Me.Button10.Text = "Guardar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(624, 130)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(87, 34)
        Me.Button9.TabIndex = 20
        Me.Button9.Text = "Importar XML"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.Button8.Location = New System.Drawing.Point(398, 230)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(20, 20)
        Me.Button8.TabIndex = 19
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(49, 267)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Nombre autoriza"
        '
        'Button2
        '
        Me.Button2.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.Button2.Location = New System.Drawing.Point(398, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 16
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(54, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Nombre solicita"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(139, 203)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(53, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Fecha solicitud"
        '
        'tbMonto
        '
        Me.tbMonto.Location = New System.Drawing.Point(139, 171)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Size = New System.Drawing.Size(184, 20)
        Me.tbMonto.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(50, 173)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Monto estimado"
        '
        'Button7
        '
        Me.Button7.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.Button7.Location = New System.Drawing.Point(398, 137)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(20, 20)
        Me.Button7.TabIndex = 9
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Proveedor sugerido"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Para aplicarse en"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Área solicitante"
        '
        'tbOrden
        '
        Me.tbOrden.Location = New System.Drawing.Point(139, 43)
        Me.tbOrden.MaxLength = 20
        Me.tbOrden.Name = "tbOrden"
        Me.tbOrden.Size = New System.Drawing.Size(184, 20)
        Me.tbOrden.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Número de orden"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(996, 586)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Vale de salida"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Archivos XML|*.xml"
        '
        'Documentar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Documentar"
        Me.Size = New System.Drawing.Size(1031, 622)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents tbIdpedido As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvOrden As System.Windows.Forms.DataGridView
    Friend WithEvents lbRutaarchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbPartida As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbIdorden As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbFoliofiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbFirmaautoriza As System.Windows.Forms.ComboBox
    Friend WithEvents cbFirmasolicita As System.Windows.Forms.ComboBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents cbAplica As System.Windows.Forms.ComboBox
    Friend WithEvents cbSolicita As System.Windows.Forms.ComboBox
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class

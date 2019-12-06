<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOCUMENTAR_ORDEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DOCUMENTAR_ORDEN))
        Me.tbIdorden = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbOrden = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbFoliofiscal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbRutaarchivo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btImportaxml = New System.Windows.Forms.Button()
        Me.dgvOrden = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbFirmaautoriza = New System.Windows.Forms.ComboBox()
        Me.cbFirmasolicita = New System.Windows.Forms.ComboBox()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbAplica = New System.Windows.Forms.ComboBox()
        Me.cbSolicita = New System.Windows.Forms.ComboBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btAgregararea = New System.Windows.Forms.Button()
        Me.btAgregaproveedor = New System.Windows.Forms.Button()
        Me.btAgregapersonal = New System.Windows.Forms.Button()
        'Me.CrystalOpenFileDialog1 = New CrystalDecisions.[Shared].Interop.CrystalOpenFileDialog()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbIdorden
        '
        Me.tbIdorden.Location = New System.Drawing.Point(131, 41)
        Me.tbIdorden.MaxLength = 20
        Me.tbIdorden.Name = "tbIdorden"
        Me.tbIdorden.Size = New System.Drawing.Size(184, 20)
        Me.tbIdorden.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(94, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Folio"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(534, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Autoriza"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(538, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Solicita"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(45, 234)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Fecha solicitud"
        '
        'tbMonto
        '
        Me.tbMonto.Location = New System.Drawing.Point(131, 201)
        Me.tbMonto.MaxLength = 20
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Size = New System.Drawing.Size(184, 20)
        Me.tbMonto.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 203)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Monto estimado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Proveedor sugerido"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Para aplicarse en"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(46, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Área solicitante"
        '
        'tbOrden
        '
        Me.tbOrden.Location = New System.Drawing.Point(131, 73)
        Me.tbOrden.MaxLength = 20
        Me.tbOrden.Name = "tbOrden"
        Me.tbOrden.Size = New System.Drawing.Size(184, 20)
        Me.tbOrden.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Número de orden"
        '
        'tbFoliofiscal
        '
        Me.tbFoliofiscal.Enabled = False
        Me.tbFoliofiscal.Location = New System.Drawing.Point(585, 141)
        Me.tbFoliofiscal.Name = "tbFoliofiscal"
        Me.tbFoliofiscal.Size = New System.Drawing.Size(366, 20)
        Me.tbFoliofiscal.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(520, 144)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Folio Fiscal"
        '
        'lbRutaarchivo
        '
        Me.lbRutaarchivo.Enabled = False
        Me.lbRutaarchivo.Location = New System.Drawing.Point(585, 106)
        Me.lbRutaarchivo.Name = "lbRutaarchivo"
        Me.lbRutaarchivo.Size = New System.Drawing.Size(366, 20)
        Me.lbRutaarchivo.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(496, 109)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "Ruta de archivo"
        '
        'btImportaxml
        '
        Me.btImportaxml.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btImportaxml.Location = New System.Drawing.Point(585, 195)
        Me.btImportaxml.Name = "btImportaxml"
        Me.btImportaxml.Size = New System.Drawing.Size(79, 42)
        Me.btImportaxml.TabIndex = 14
        Me.btImportaxml.Text = "Importar XML"
        Me.btImportaxml.UseVisualStyleBackColor = True
        '
        'dgvOrden
        '
        Me.dgvOrden.AllowUserToAddRows = False
        Me.dgvOrden.AllowUserToDeleteRows = False
        Me.dgvOrden.AllowUserToOrderColumns = True
        Me.dgvOrden.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrden.Location = New System.Drawing.Point(29, 273)
        Me.dgvOrden.Name = "dgvOrden"
        Me.dgvOrden.Size = New System.Drawing.Size(929, 230)
        Me.dgvOrden.TabIndex = 17
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 25)
        Me.ToolStrip1.TabIndex = 69
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources._112_Plus_Green_32x32_72
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources._126_Edit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton2.Text = "Editar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.search
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton4.Text = "Buscar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(131, 233)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha.TabIndex = 8
        '
        'cbFirmaautoriza
        '
        Me.cbFirmaautoriza.FormattingEnabled = True
        Me.cbFirmaautoriza.Location = New System.Drawing.Point(586, 70)
        Me.cbFirmaautoriza.Name = "cbFirmaautoriza"
        Me.cbFirmaautoriza.Size = New System.Drawing.Size(253, 21)
        Me.cbFirmaautoriza.TabIndex = 11
        '
        'cbFirmasolicita
        '
        Me.cbFirmasolicita.FormattingEnabled = True
        Me.cbFirmasolicita.Location = New System.Drawing.Point(586, 38)
        Me.cbFirmasolicita.Name = "cbFirmasolicita"
        Me.cbFirmasolicita.Size = New System.Drawing.Size(253, 21)
        Me.cbFirmasolicita.TabIndex = 9
        '
        'cbProveedor
        '
        Me.cbProveedor.BackColor = System.Drawing.Color.White
        Me.cbProveedor.DropDownHeight = 300
        Me.cbProveedor.DropDownWidth = 500
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.IntegralHeight = False
        Me.cbProveedor.Location = New System.Drawing.Point(131, 168)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(253, 21)
        Me.cbProveedor.TabIndex = 5
        '
        'cbAplica
        '
        Me.cbAplica.FormattingEnabled = True
        Me.cbAplica.Location = New System.Drawing.Point(131, 136)
        Me.cbAplica.Name = "cbAplica"
        Me.cbAplica.Size = New System.Drawing.Size(254, 21)
        Me.cbAplica.TabIndex = 4
        '
        'cbSolicita
        '
        Me.cbSolicita.FormattingEnabled = True
        Me.cbSolicita.Location = New System.Drawing.Point(131, 103)
        Me.cbSolicita.Name = "cbSolicita"
        Me.cbSolicita.Size = New System.Drawing.Size(253, 21)
        Me.cbSolicita.TabIndex = 2
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(321, 35)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(64, 31)
        Me.btBuscar.TabIndex = 123
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btImprimir
        '
        Me.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btImprimir.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.Printer_32_021
        Me.btImprimir.Location = New System.Drawing.Point(792, 195)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(79, 42)
        Me.btImprimir.TabIndex = 16
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btGuardar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.savetheapplication_guardar_29581
        Me.btGuardar.Location = New System.Drawing.Point(689, 195)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(79, 42)
        Me.btGuardar.TabIndex = 15
        Me.btGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btAgregararea
        '
        Me.btAgregararea.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.btAgregararea.Location = New System.Drawing.Point(390, 103)
        Me.btAgregararea.Name = "btAgregararea"
        Me.btAgregararea.Size = New System.Drawing.Size(20, 20)
        Me.btAgregararea.TabIndex = 3
        Me.btAgregararea.UseVisualStyleBackColor = True
        '
        'btAgregaproveedor
        '
        Me.btAgregaproveedor.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.btAgregaproveedor.Location = New System.Drawing.Point(390, 169)
        Me.btAgregaproveedor.Name = "btAgregaproveedor"
        Me.btAgregaproveedor.Size = New System.Drawing.Size(20, 20)
        Me.btAgregaproveedor.TabIndex = 6
        Me.btAgregaproveedor.UseVisualStyleBackColor = True
        '
        'btAgregapersonal
        '
        Me.btAgregapersonal.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.btAgregapersonal.Location = New System.Drawing.Point(845, 39)
        Me.btAgregapersonal.Name = "btAgregapersonal"
        Me.btAgregapersonal.Size = New System.Drawing.Size(20, 20)
        Me.btAgregapersonal.TabIndex = 124
        Me.btAgregapersonal.UseVisualStyleBackColor = True
        '
        'CrystalOpenFileDialog1
        '
        'Me.CrystalOpenFileDialog1.FileName = "CrystalOpenFileDialog1"
        '
        'DOCUMENTAR_ORDEN
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 537)
        Me.Controls.Add(Me.btAgregapersonal)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.dgvOrden)
        Me.Controls.Add(Me.tbFoliofiscal)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lbRutaarchivo)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.btImportaxml)
        Me.Controls.Add(Me.tbIdorden)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbFirmaautoriza)
        Me.Controls.Add(Me.cbFirmasolicita)
        Me.Controls.Add(Me.cbAplica)
        Me.Controls.Add(Me.cbSolicita)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btAgregararea)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbMonto)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btAgregaproveedor)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbOrden)
        Me.Controls.Add(Me.Label11)
        Me.Name = "DOCUMENTAR_ORDEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOCUMENTAR ORDEN DE COMPRA"
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbIdorden As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbFoliofiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lbRutaarchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents btImportaxml As System.Windows.Forms.Button
    Friend WithEvents dgvOrden As System.Windows.Forms.DataGridView
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFirmaautoriza As System.Windows.Forms.ComboBox
    Friend WithEvents cbFirmasolicita As System.Windows.Forms.ComboBox
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbAplica As System.Windows.Forms.ComboBox
    Friend WithEvents cbSolicita As System.Windows.Forms.ComboBox
    Friend WithEvents btAgregaproveedor As System.Windows.Forms.Button
    Friend WithEvents btAgregararea As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents btAgregapersonal As System.Windows.Forms.Button
    'Friend WithEvents CrystalOpenFileDialog1 As CrystalDecisions.Shared.Interop.CrystalOpenFileDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ALTA_LICITACIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTA_LICITACIONES))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbLicitacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImportarPDF = New System.Windows.Forms.OpenFileDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.cbLicitaciones = New System.Windows.Forms.ComboBox()
        Me.cbejercicio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbRutaarchivo = New System.Windows.Forms.TextBox()
        Me.lbEstatusdocumento = New System.Windows.Forms.Label()
        Me.Verificar = New System.Windows.Forms.PictureBox()
        Me.btImportar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Verificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripSeparator4, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(702, 25)
        Me.ToolStrip1.TabIndex = 51
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
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.delete
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton3.Text = "Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton5.Text = "Consultar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.puerta_de_salida_con_la_flecha_hacia_la_derecha_318_40597
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton4.Text = "Salir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Licitaciones"
        '
        'tbLicitacion
        '
        Me.tbLicitacion.Location = New System.Drawing.Point(31, 227)
        Me.tbLicitacion.Name = "tbLicitacion"
        Me.tbLicitacion.Size = New System.Drawing.Size(276, 20)
        Me.tbLicitacion.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 14)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Nombre Licitación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 14)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Ejercicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 14)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Importe:"
        '
        'tbImporte
        '
        Me.tbImporte.Location = New System.Drawing.Point(31, 277)
        Me.tbImporte.Name = "tbImporte"
        Me.tbImporte.Size = New System.Drawing.Size(129, 20)
        Me.tbImporte.TabIndex = 59
        Me.tbImporte.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 14)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Importar documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(592, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 14)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Guardar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(429, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 14)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Vigencia"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(458, 77)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpInicio.TabIndex = 65
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(578, 77)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(91, 20)
        Me.dtpFin.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(429, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 14)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Del"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(555, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 14)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Al"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 14)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Proveedor"
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
        Me.cbProveedores.Location = New System.Drawing.Point(31, 81)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(220, 22)
        Me.cbProveedores.TabIndex = 71
        '
        'cbLicitaciones
        '
        Me.cbLicitaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLicitaciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLicitaciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLicitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLicitaciones.DropDownWidth = 420
        Me.cbLicitaciones.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLicitaciones.FormattingEnabled = True
        Me.cbLicitaciones.Location = New System.Drawing.Point(31, 130)
        Me.cbLicitaciones.Name = "cbLicitaciones"
        Me.cbLicitaciones.Size = New System.Drawing.Size(220, 22)
        Me.cbLicitaciones.TabIndex = 72
        '
        'cbejercicio
        '
        Me.cbejercicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbejercicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbejercicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbejercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbejercicio.DropDownWidth = 420
        Me.cbejercicio.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbejercicio.FormattingEnabled = True
        Me.cbejercicio.Location = New System.Drawing.Point(31, 178)
        Me.cbejercicio.Name = "cbejercicio"
        Me.cbejercicio.Size = New System.Drawing.Size(165, 22)
        Me.cbejercicio.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Ruta archivo"
        '
        'tbRutaarchivo
        '
        Me.tbRutaarchivo.Location = New System.Drawing.Point(31, 326)
        Me.tbRutaarchivo.Name = "tbRutaarchivo"
        Me.tbRutaarchivo.Size = New System.Drawing.Size(276, 20)
        Me.tbRutaarchivo.TabIndex = 74
        '
        'lbEstatusdocumento
        '
        Me.lbEstatusdocumento.AutoSize = True
        Me.lbEstatusdocumento.ForeColor = System.Drawing.Color.Green
        Me.lbEstatusdocumento.Location = New System.Drawing.Point(335, 329)
        Me.lbEstatusdocumento.Name = "lbEstatusdocumento"
        Me.lbEstatusdocumento.Size = New System.Drawing.Size(175, 13)
        Me.lbEstatusdocumento.TabIndex = 77
        Me.lbEstatusdocumento.Text = "Documento cargado correctamente"
        '
        'Verificar
        '
        Me.Verificar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_comprobado_16
        Me.Verificar.Location = New System.Drawing.Point(313, 328)
        Me.Verificar.Name = "Verificar"
        Me.Verificar.Size = New System.Drawing.Size(16, 20)
        Me.Verificar.TabIndex = 76
        Me.Verificar.TabStop = False
        '
        'btImportar
        '
        Me.btImportar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_pdf_32
        Me.btImportar.Location = New System.Drawing.Point(458, 130)
        Me.btImportar.Name = "btImportar"
        Me.btImportar.Size = New System.Drawing.Size(72, 42)
        Me.btImportar.TabIndex = 61
        Me.btImportar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.guardar1
        Me.btGuardar.Location = New System.Drawing.Point(578, 130)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(72, 42)
        Me.btGuardar.TabIndex = 46
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'ALTA_LICITACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 377)
        Me.Controls.Add(Me.lbEstatusdocumento)
        Me.Controls.Add(Me.Verificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbRutaarchivo)
        Me.Controls.Add(Me.cbejercicio)
        Me.Controls.Add(Me.cbLicitaciones)
        Me.Controls.Add(Me.cbProveedores)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btImportar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbImporte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbLicitacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btGuardar)
        Me.MaximizeBox = False
        Me.Name = "ALTA_LICITACIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                       Sistema Integral de Financ" &
    "iamiento - LICITACIONES -"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Verificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btGuardar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents tbLicitacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbImporte As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btImportar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ImportarPDF As OpenFileDialog
    Friend WithEvents Label12 As Label
    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents cbLicitaciones As ComboBox
    Friend WithEvents cbejercicio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbRutaarchivo As TextBox
    Friend WithEvents Verificar As PictureBox
    Friend WithEvents lbEstatusdocumento As Label
End Class

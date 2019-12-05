<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CARGA_POA
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbcapitulo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbsubcapitulo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbpartidas = New System.Windows.Forms.ComboBox()
        Me.dgvUnidades = New System.Windows.Forms.DataGridView()
        Me.ID_CAPITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAPITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_SUBCAPITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBCAPITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PARTIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PARTIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.cbUnidades = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbImporte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btbuscar = New System.Windows.Forms.Button()
        CType(Me.dgvUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ejercicio:"
        '
        'cbEjercicio
        '
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Location = New System.Drawing.Point(111, 114)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(154, 21)
        Me.cbEjercicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Capitulo:"
        '
        'cbcapitulo
        '
        Me.cbcapitulo.FormattingEnabled = True
        Me.cbcapitulo.Location = New System.Drawing.Point(111, 232)
        Me.cbcapitulo.Name = "cbcapitulo"
        Me.cbcapitulo.Size = New System.Drawing.Size(490, 21)
        Me.cbcapitulo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "SubCapitulo:"
        '
        'cbsubcapitulo
        '
        Me.cbsubcapitulo.FormattingEnabled = True
        Me.cbsubcapitulo.Location = New System.Drawing.Point(111, 266)
        Me.cbsubcapitulo.Name = "cbsubcapitulo"
        Me.cbsubcapitulo.Size = New System.Drawing.Size(490, 21)
        Me.cbsubcapitulo.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Partidas:"
        '
        'cbpartidas
        '
        Me.cbpartidas.FormattingEnabled = True
        Me.cbpartidas.Location = New System.Drawing.Point(111, 303)
        Me.cbpartidas.Name = "cbpartidas"
        Me.cbpartidas.Size = New System.Drawing.Size(490, 21)
        Me.cbpartidas.TabIndex = 10
        '
        'dgvUnidades
        '
        Me.dgvUnidades.AllowUserToAddRows = False
        Me.dgvUnidades.AllowUserToResizeColumns = False
        Me.dgvUnidades.AllowUserToResizeRows = False
        Me.dgvUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnidades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CAPITULO, Me.CAPITULO, Me.ID_SUBCAPITULO, Me.SUBCAPITULO, Me.ID_PARTIDA, Me.PARTIDA, Me.DESCRIPCION, Me.IMPORTE, Me.EJERCICIO})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUnidades.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUnidades.Location = New System.Drawing.Point(69, 354)
        Me.dgvUnidades.Name = "dgvUnidades"
        Me.dgvUnidades.Size = New System.Drawing.Size(903, 211)
        Me.dgvUnidades.TabIndex = 63
        '
        'ID_CAPITULO
        '
        Me.ID_CAPITULO.HeaderText = "ID_CAPITULO"
        Me.ID_CAPITULO.Name = "ID_CAPITULO"
        Me.ID_CAPITULO.Visible = False
        '
        'CAPITULO
        '
        Me.CAPITULO.HeaderText = "CAPITULO"
        Me.CAPITULO.Name = "CAPITULO"
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
        '
        'ID_PARTIDA
        '
        Me.ID_PARTIDA.HeaderText = "ID_PARTIDA"
        Me.ID_PARTIDA.Name = "ID_PARTIDA"
        Me.ID_PARTIDA.Visible = False
        '
        'PARTIDA
        '
        Me.PARTIDA.HeaderText = "PARTIDA"
        Me.PARTIDA.Name = "PARTIDA"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.MaxInputLength = 5
        Me.IMPORTE.Name = "IMPORTE"
        '
        'EJERCICIO
        '
        Me.EJERCICIO.HeaderText = "EJERCICIO"
        Me.EJERCICIO.Name = "EJERCICIO"
        Me.EJERCICIO.Visible = False
        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(703, 303)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(87, 26)
        Me.btAgregar.TabIndex = 73
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'cbUnidades
        '
        Me.cbUnidades.DropDownWidth = 400
        Me.cbUnidades.FormattingEnabled = True
        Me.cbUnidades.Location = New System.Drawing.Point(111, 195)
        Me.cbUnidades.Name = "cbUnidades"
        Me.cbUnidades.Size = New System.Drawing.Size(403, 21)
        Me.cbUnidades.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Unidad:"
        '
        'cbFiltro
        '
        Me.cbFiltro.BackColor = System.Drawing.Color.Gray
        Me.cbFiltro.ForeColor = System.Drawing.SystemColors.Window
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Asignar", "Modificar", "Eliminar"})
        Me.cbFiltro.Location = New System.Drawing.Point(111, 70)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(154, 21)
        Me.cbFiltro.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Opciones:"
        '
        'cbRubro
        '
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.DropDownWidth = 400
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Items.AddRange(New Object() {"Ninguna", "1", "2", "3"})
        Me.cbRubro.Location = New System.Drawing.Point(111, 152)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(403, 21)
        Me.cbRubro.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Location = New System.Drawing.Point(32, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(403, 19)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "ASIGNACIÓN DE PRESUPUESTO POR UNIDADES DEL REPSS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Rubro:"
        '
        'tbImporte
        '
        Me.tbImporte.Location = New System.Drawing.Point(851, 214)
        Me.tbImporte.Name = "tbImporte"
        Me.tbImporte.Size = New System.Drawing.Size(121, 20)
        Me.tbImporte.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(803, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Importe"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(851, 254)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(121, 20)
        Me.tbTotal.TabIndex = 84
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(768, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Total asignado"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(796, 301)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(87, 27)
        Me.btGuardar.TabIndex = 86
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(889, 301)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(87, 27)
        Me.btCancelar.TabIndex = 87
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(768, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 92
        '
        'btbuscar
        '
        Me.btbuscar.Location = New System.Drawing.Point(610, 303)
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(87, 26)
        Me.btbuscar.TabIndex = 93
        Me.btbuscar.Text = "Buscar"
        Me.btbuscar.UseVisualStyleBackColor = True
        '
        'CARGA_POA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1013, 610)
        Me.Controls.Add(Me.btbuscar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbImporte)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbRubro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbUnidades)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.dgvUnidades)
        Me.Controls.Add(Me.cbpartidas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbsubcapitulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbcapitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(700, 600)
        Me.Name = "CARGA_POA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASIGNACIÓN DE PRESUPUESTO"
        CType(Me.dgvUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbEjercicio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbcapitulo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbsubcapitulo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbpartidas As ComboBox
    Friend WithEvents dgvUnidades As DataGridView
    Friend WithEvents btAgregar As Button
    Friend WithEvents cbUnidades As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbRubro As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbImporte As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btGuardar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents ID_CAPITULO As DataGridViewTextBoxColumn
    Friend WithEvents CAPITULO As DataGridViewTextBoxColumn
    Friend WithEvents ID_SUBCAPITULO As DataGridViewTextBoxColumn
    Friend WithEvents SUBCAPITULO As DataGridViewTextBoxColumn
    Friend WithEvents ID_PARTIDA As DataGridViewTextBoxColumn
    Friend WithEvents PARTIDA As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As DataGridViewTextBoxColumn
    Friend WithEvents EJERCICIO As DataGridViewTextBoxColumn
    Friend WithEvents btbuscar As Button
End Class

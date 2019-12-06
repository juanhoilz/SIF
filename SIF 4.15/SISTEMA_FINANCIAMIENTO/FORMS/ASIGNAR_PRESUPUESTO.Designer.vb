<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ASIGNAR_PRESUPUESTO
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
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.tbImporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbUnidades = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPartidas = New System.Windows.Forms.ComboBox()
        Me.dgvUnidades = New System.Windows.Forms.DataGridView()
        Me.ID_UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PARTIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PARTIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(604, 198)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(72, 29)
        Me.btGuardar.TabIndex = 60
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(513, 198)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(72, 29)
        Me.btAgregar.TabIndex = 59
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'tbImporte
        '
        Me.tbImporte.Location = New System.Drawing.Point(513, 113)
        Me.tbImporte.Name = "tbImporte"
        Me.tbImporte.Size = New System.Drawing.Size(121, 20)
        Me.tbImporte.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(462, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 14)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Importe:"
        '
        'cbUnidades
        '
        Me.cbUnidades.DropDownWidth = 400
        Me.cbUnidades.FormattingEnabled = True
        Me.cbUnidades.Location = New System.Drawing.Point(105, 113)
        Me.cbUnidades.Name = "cbUnidades"
        Me.cbUnidades.Size = New System.Drawing.Size(276, 21)
        Me.cbUnidades.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(56, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Unidad:"
        '
        'cbFiltro
        '
        Me.cbFiltro.BackColor = System.Drawing.Color.Gray
        Me.cbFiltro.ForeColor = System.Drawing.SystemColors.Window
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Asignar", "Modificar", "Eliminar"})
        Me.cbFiltro.Location = New System.Drawing.Point(105, 76)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(177, 21)
        Me.cbFiltro.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(43, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Opciones:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "ASIGNAR PRESUPUESTO A UNIDADES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(56, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Partida:"
        '
        'cbPartidas
        '
        Me.cbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartidas.DropDownWidth = 400
        Me.cbPartidas.FormattingEnabled = True
        Me.cbPartidas.Items.AddRange(New Object() {"Ninguna", "1", "2", "3"})
        Me.cbPartidas.Location = New System.Drawing.Point(105, 195)
        Me.cbPartidas.Name = "cbPartidas"
        Me.cbPartidas.Size = New System.Drawing.Size(274, 21)
        Me.cbPartidas.TabIndex = 40
        '
        'dgvUnidades
        '
        Me.dgvUnidades.AllowUserToAddRows = False
        Me.dgvUnidades.AllowUserToResizeColumns = False
        Me.dgvUnidades.AllowUserToResizeRows = False
        Me.dgvUnidades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_UNIDAD, Me.EJERCICIO, Me.ID_PARTIDA, Me.PARTIDA, Me.IMPORTE})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUnidades.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUnidades.Location = New System.Drawing.Point(24, 259)
        Me.dgvUnidades.Name = "dgvUnidades"
        Me.dgvUnidades.Size = New System.Drawing.Size(763, 221)
        Me.dgvUnidades.TabIndex = 62
        '
        'ID_UNIDAD
        '
        Me.ID_UNIDAD.HeaderText = "ID UNIDAD"
        Me.ID_UNIDAD.Name = "ID_UNIDAD"
        Me.ID_UNIDAD.Width = 90
        '
        'EJERCICIO
        '
        Me.EJERCICIO.HeaderText = "EJERCICIO"
        Me.EJERCICIO.Name = "EJERCICIO"
        Me.EJERCICIO.Visible = False
        '
        'ID_PARTIDA
        '
        Me.ID_PARTIDA.HeaderText = "ID_PARTIDA"
        Me.ID_PARTIDA.Name = "ID_PARTIDA"
        '
        'PARTIDA
        '
        Me.PARTIDA.HeaderText = "DESCRIPCION"
        Me.PARTIDA.MaxInputLength = 5
        Me.PARTIDA.Name = "PARTIDA"
        Me.PARTIDA.Width = 410
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.Width = 120
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(695, 198)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(72, 29)
        Me.btCancelar.TabIndex = 63
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(22, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Partidas asignadas"
        '
        'cbEjercicio
        '
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Items.AddRange(New Object() {"2018"})
        Me.cbEjercicio.Location = New System.Drawing.Point(105, 154)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(274, 21)
        Me.cbEjercicio.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(49, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 14)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Ejercicio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(428, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Total asignado:"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(513, 153)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(121, 20)
        Me.tbTotal.TabIndex = 72
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(812, 25)
        Me.ToolStrip1.TabIndex = 73
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.search
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton1.Text = "Consultar"
        '
        'cbRubro
        '
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.DropDownWidth = 400
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Items.AddRange(New Object() {"Ninguna", "1", "2", "3"})
        Me.cbRubro.Location = New System.Drawing.Point(513, 76)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(274, 21)
        Me.cbRubro.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(468, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 14)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Rubro:"
        '
        'ASIGNAR_PRESUPUESTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 514)
        Me.Controls.Add(Me.cbRubro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.dgvUnidades)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.tbImporte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbPartidas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbUnidades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Name = "ASIGNAR_PRESUPUESTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASIGNAR PRESUPUESTO"
        CType(Me.dgvUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btGuardar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents tbImporte As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbUnidades As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPartidas As ComboBox
    Friend WithEvents dgvUnidades As DataGridView
    Friend WithEvents btCancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbEjercicio As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ID_UNIDAD As DataGridViewTextBoxColumn
    Friend WithEvents EJERCICIO As DataGridViewTextBoxColumn
    Friend WithEvents ID_PARTIDA As DataGridViewTextBoxColumn
    Friend WithEvents PARTIDA As DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As DataGridViewTextBoxColumn
    Friend WithEvents cbRubro As ComboBox
    Friend WithEvents Label8 As Label
End Class

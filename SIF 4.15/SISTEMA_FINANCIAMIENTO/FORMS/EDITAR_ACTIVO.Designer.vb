<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDITAR_ACTIVO
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
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSeleccionar = New System.Windows.Forms.ComboBox()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbBuscar
        '
        Me.tbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbBuscar.Location = New System.Drawing.Point(157, 83)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(345, 20)
        Me.tbBuscar.TabIndex = 1
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Location = New System.Drawing.Point(508, 78)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(129, 29)
        Me.btBuscar.TabIndex = 107
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Tipo de búsqueda:"
        '
        'cbFiltro
        '
        Me.cbFiltro.AutoCompleteCustomSource.AddRange(New String() {"Inventario", "Proveedor", "Factura", "Número de serie"})
        Me.cbFiltro.BackColor = System.Drawing.SystemColors.Window
        Me.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Inventario", "Proveedor", "Factura", "Descripción"})
        Me.cbFiltro.Location = New System.Drawing.Point(157, 46)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(177, 21)
        Me.cbFiltro.TabIndex = 0
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AllowUserToAddRows = False
        Me.dgvConsulta.AllowUserToDeleteRows = False
        Me.dgvConsulta.AllowUserToResizeRows = False
        Me.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsulta.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvConsulta.Location = New System.Drawing.Point(-1, 125)
        Me.dgvConsulta.MultiSelect = False
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsulta.Size = New System.Drawing.Size(1118, 162)
        Me.dgvConsulta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Editar Campo:"
        '
        'cbCampo
        '
        Me.cbCampo.AutoCompleteCustomSource.AddRange(New String() {"Inventario", "Ejercicio", "Fuente de Financiamiento", "Proveedor", "Folio Factura", "Folio Fiscal", "Ubicación", "Subcapítulo", "Partida", "Grupo", "Marca", "Modelo", "Serie", "Descripción", "Valor", "Resguardo", "Resguardatario", "Observaciones", "Etiquetado", "Póliza"})
        Me.cbCampo.BackColor = System.Drawing.SystemColors.Window
        Me.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCampo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"Inventario", "Ejercicio", "Fuente de Financiamiento", "Proveedor", "Folio Factura", "Folio Fiscal", "Ubicación", "Subcapítulo", "Partida", "Grupo", "Marca", "Modelo", "Serie", "Descripcion", "Valor", "Resguardo", "Resguardatario", "Observaciones", "Etiquetado", "Póliza"})
        Me.cbCampo.Location = New System.Drawing.Point(157, 306)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(177, 21)
        Me.cbCampo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Seleccionar:"
        '
        'cbSeleccionar
        '
        Me.cbSeleccionar.AutoCompleteCustomSource.AddRange(New String() {"Inventario", "Proveedor", "Factura", "Número de serie"})
        Me.cbSeleccionar.BackColor = System.Drawing.SystemColors.Window
        Me.cbSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeleccionar.DropDownWidth = 550
        Me.cbSeleccionar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbSeleccionar.FormattingEnabled = True
        Me.cbSeleccionar.Location = New System.Drawing.Point(157, 333)
        Me.cbSeleccionar.Name = "cbSeleccionar"
        Me.cbSeleccionar.Size = New System.Drawing.Size(345, 21)
        Me.cbSeleccionar.TabIndex = 4
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDescripcion.Location = New System.Drawing.Point(157, 360)
        Me.tbDescripcion.MaxLength = 250
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(345, 20)
        Me.tbDescripcion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Descripción:"
        '
        'btactualizar
        '
        Me.btactualizar.Location = New System.Drawing.Point(157, 409)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(129, 29)
        Me.btactualizar.TabIndex = 117
        Me.btactualizar.Text = "Actualizar"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(157, 386)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox1.TabIndex = 118
        Me.CheckBox1.Text = "Etiquetado"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'EDITAR_ACTIVO
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1117, 493)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btactualizar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSeleccionar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.dgvConsulta)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbFiltro)
        Me.Name = "EDITAR_ACTIVO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Activo Fijo"
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSeleccionar As ComboBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btactualizar As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REPORTES_PASIVO
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
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDescripcion = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbRecurso = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox2 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbEjercicio
        '
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Items.AddRange(New Object() {"Registrar", "Editar", "Cancelar"})
        Me.cbEjercicio.Location = New System.Drawing.Point(83, 109)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(212, 21)
        Me.cbEjercicio.TabIndex = 135
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.Printer_32_02
        Me.btBuscar.Location = New System.Drawing.Point(158, 446)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(73, 42)
        Me.btBuscar.TabIndex = 142
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Ejercicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "REPORTES PASIVO"
        '
        'cbFiltro
        '
        Me.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Unidad", "Proveedor", "Partida"})
        Me.cbFiltro.Location = New System.Drawing.Point(83, 278)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(212, 21)
        Me.cbFiltro.TabIndex = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Filtro:"
        '
        'cbDescripcion
        '
        Me.cbDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDescripcion.DropDownWidth = 420
        Me.cbDescripcion.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDescripcion.FormattingEnabled = True
        Me.cbDescripcion.Location = New System.Drawing.Point(83, 333)
        Me.cbDescripcion.Name = "cbDescripcion"
        Me.cbDescripcion.Size = New System.Drawing.Size(212, 22)
        Me.cbDescripcion.TabIndex = 152
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Detalle", "Resumen"})
        Me.ComboBox3.Location = New System.Drawing.Point(83, 221)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox3.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 14)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "Tipo de reporte:"
        '
        'cbRecurso
        '
        Me.cbRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRecurso.FormattingEnabled = True
        Me.cbRecurso.Items.AddRange(New Object() {"Registrar", "Editar", "Cancelar"})
        Me.cbRecurso.Location = New System.Drawing.Point(83, 165)
        Me.cbRecurso.Name = "cbRecurso"
        Me.cbRecurso.Size = New System.Drawing.Size(212, 21)
        Me.cbRecurso.TabIndex = 157
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "Recurso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Seleccionar:"
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(298, 104)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(69, 30)
        Me.MaterialCheckBox1.TabIndex = 161
        Me.MaterialCheckBox1.Text = "Todos"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox2
        '
        Me.MaterialCheckBox2.AutoSize = True
        Me.MaterialCheckBox2.Depth = 0
        Me.MaterialCheckBox2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox2.Location = New System.Drawing.Point(298, 329)
        Me.MaterialCheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox2.Name = "MaterialCheckBox2"
        Me.MaterialCheckBox2.Ripple = True
        Me.MaterialCheckBox2.Size = New System.Drawing.Size(69, 30)
        Me.MaterialCheckBox2.TabIndex = 162
        Me.MaterialCheckBox2.Text = "Todos"
        Me.MaterialCheckBox2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 14)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Ordenar por:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.DropDownWidth = 420
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(83, 392)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 22)
        Me.ComboBox1.TabIndex = 163
        '
        'REPORTES_PASIVO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 515)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MaterialCheckBox2)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbRecurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbDescripcion)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "REPORTES_PASIVO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTES PASIVO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbEjercicio As ComboBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbDescripcion As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbRecurso As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox2 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class

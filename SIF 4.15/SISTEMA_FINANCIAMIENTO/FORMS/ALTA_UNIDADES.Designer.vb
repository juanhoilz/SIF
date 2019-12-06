<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_UNIDADES
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbUnidades = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbJurisdiccion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.cbMunicipios = New System.Windows.Forms.ComboBox()
        Me.mdNombre = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mdCalle = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mdNumeroext = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mdNumeroint = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mdColonia = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mdCodigopostal = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mdLocalidad = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mdSi = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mdNo = New MaterialSkin.Controls.MaterialRadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UNIDADES ADMINISTRATIVAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Opciones:"
        '
        'cbFiltro
        '
        Me.cbFiltro.BackColor = System.Drawing.Color.Gray
        Me.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltro.ForeColor = System.Drawing.SystemColors.Window
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Alta", "Baja", "Modificación"})
        Me.cbFiltro.Location = New System.Drawing.Point(106, 55)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(177, 22)
        Me.cbFiltro.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Unidad:"
        '
        'cbUnidades
        '
        Me.cbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidades.FormattingEnabled = True
        Me.cbUnidades.Location = New System.Drawing.Point(106, 101)
        Me.cbUnidades.Name = "cbUnidades"
        Me.cbUnidades.Size = New System.Drawing.Size(276, 22)
        Me.cbUnidades.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jurisdicción:"
        '
        'cbJurisdiccion
        '
        Me.cbJurisdiccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJurisdiccion.FormattingEnabled = True
        Me.cbJurisdiccion.Items.AddRange(New Object() {"Ninguna", "1", "2", "3"})
        Me.cbJurisdiccion.Location = New System.Drawing.Point(107, 146)
        Me.cbJurisdiccion.Name = "cbJurisdiccion"
        Me.cbJurisdiccion.Size = New System.Drawing.Size(121, 22)
        Me.cbJurisdiccion.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(427, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 14)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Municipio:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(498, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 14)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Asignar presupuesto:"
        '
        'btGuardar
        '
        Me.btGuardar.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.guardar
        Me.btGuardar.Location = New System.Drawing.Point(501, 282)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(72, 40)
        Me.btGuardar.TabIndex = 13
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'cbMunicipios
        '
        Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunicipios.FormattingEnabled = True
        Me.cbMunicipios.Location = New System.Drawing.Point(501, 109)
        Me.cbMunicipios.Name = "cbMunicipios"
        Me.cbMunicipios.Size = New System.Drawing.Size(194, 22)
        Me.cbMunicipios.TabIndex = 9
        '
        'mdNombre
        '
        Me.mdNombre.Depth = 0
        Me.mdNombre.Hint = "Nombre Unidad"
        Me.mdNombre.Location = New System.Drawing.Point(105, 196)
        Me.mdNombre.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdNombre.Name = "mdNombre"
        Me.mdNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mdNombre.SelectedText = ""
        Me.mdNombre.SelectionLength = 0
        Me.mdNombre.SelectionStart = 0
        Me.mdNombre.Size = New System.Drawing.Size(277, 23)
        Me.mdNombre.TabIndex = 3
        Me.mdNombre.UseSystemPasswordChar = False
        '
        'mdCalle
        '
        Me.mdCalle.Depth = 0
        Me.mdCalle.Hint = "Calle"
        Me.mdCalle.Location = New System.Drawing.Point(106, 239)
        Me.mdCalle.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdCalle.Name = "mdCalle"
        Me.mdCalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mdCalle.SelectedText = ""
        Me.mdCalle.SelectionLength = 0
        Me.mdCalle.SelectionStart = 0
        Me.mdCalle.Size = New System.Drawing.Size(162, 23)
        Me.mdCalle.TabIndex = 4
        Me.mdCalle.UseSystemPasswordChar = False
        '
        'mdNumeroext
        '
        Me.mdNumeroext.Depth = 0
        Me.mdNumeroext.Hint = "Número exterior"
        Me.mdNumeroext.Location = New System.Drawing.Point(107, 282)
        Me.mdNumeroext.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdNumeroext.Name = "mdNumeroext"
        Me.mdNumeroext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mdNumeroext.SelectedText = ""
        Me.mdNumeroext.SelectionLength = 0
        Me.mdNumeroext.SelectionStart = 0
        Me.mdNumeroext.Size = New System.Drawing.Size(161, 23)
        Me.mdNumeroext.TabIndex = 5
        Me.mdNumeroext.UseSystemPasswordChar = False
        '
        'mdNumeroint
        '
        Me.mdNumeroint.Depth = 0
        Me.mdNumeroint.Hint = "Número interior"
        Me.mdNumeroint.Location = New System.Drawing.Point(107, 331)
        Me.mdNumeroint.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdNumeroint.Name = "mdNumeroint"
        Me.mdNumeroint.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mdNumeroint.SelectedText = ""
        Me.mdNumeroint.SelectionLength = 0
        Me.mdNumeroint.SelectionStart = 0
        Me.mdNumeroint.Size = New System.Drawing.Size(161, 23)
        Me.mdNumeroint.TabIndex = 6
        Me.mdNumeroint.UseSystemPasswordChar = False
        '
        'mdColonia
        '
        Me.mdColonia.Depth = 0
        Me.mdColonia.Hint = "Colonia"
        Me.mdColonia.Location = New System.Drawing.Point(107, 374)
        Me.mdColonia.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdColonia.Name = "mdColonia"
        Me.mdColonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mdColonia.SelectedText = ""
        Me.mdColonia.SelectionLength = 0
        Me.mdColonia.SelectionStart = 0
        Me.mdColonia.Size = New System.Drawing.Size(161, 23)
        Me.mdColonia.TabIndex = 7
        Me.mdColonia.UseSystemPasswordChar = False
        '
        'mdCodigopostal
        '
        Me.mdCodigopostal.Depth = 0
        Me.mdCodigopostal.Hint = "Código Postal"
        Me.mdCodigopostal.Location = New System.Drawing.Point(501, 48)
        Me.mdCodigopostal.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdCodigopostal.Name = "mdCodigopostal"
        Me.mdCodigopostal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mdCodigopostal.SelectedText = ""
        Me.mdCodigopostal.SelectionLength = 0
        Me.mdCodigopostal.SelectionStart = 0
        Me.mdCodigopostal.Size = New System.Drawing.Size(157, 23)
        Me.mdCodigopostal.TabIndex = 8
        Me.mdCodigopostal.UseSystemPasswordChar = False
        '
        'mdLocalidad
        '
        Me.mdLocalidad.Depth = 0
        Me.mdLocalidad.Hint = "Localidad"
        Me.mdLocalidad.Location = New System.Drawing.Point(501, 156)
        Me.mdLocalidad.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdLocalidad.Name = "mdLocalidad"
        Me.mdLocalidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mdLocalidad.SelectedText = ""
        Me.mdLocalidad.SelectionLength = 0
        Me.mdLocalidad.SelectionStart = 0
        Me.mdLocalidad.Size = New System.Drawing.Size(157, 23)
        Me.mdLocalidad.TabIndex = 10
        Me.mdLocalidad.UseSystemPasswordChar = False
        '
        'mdSi
        '
        Me.mdSi.AutoSize = True
        Me.mdSi.Depth = 0
        Me.mdSi.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mdSi.Location = New System.Drawing.Point(501, 233)
        Me.mdSi.Margin = New System.Windows.Forms.Padding(0)
        Me.mdSi.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mdSi.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdSi.Name = "mdSi"
        Me.mdSi.Ripple = True
        Me.mdSi.Size = New System.Drawing.Size(41, 30)
        Me.mdSi.TabIndex = 29
        Me.mdSi.TabStop = True
        Me.mdSi.Text = "Sí"
        Me.mdSi.UseVisualStyleBackColor = True
        '
        'mdNo
        '
        Me.mdNo.AutoSize = True
        Me.mdNo.Depth = 0
        Me.mdNo.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mdNo.Location = New System.Drawing.Point(564, 233)
        Me.mdNo.Margin = New System.Windows.Forms.Padding(0)
        Me.mdNo.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mdNo.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdNo.Name = "mdNo"
        Me.mdNo.Ripple = True
        Me.mdNo.Size = New System.Drawing.Size(47, 30)
        Me.mdNo.TabIndex = 30
        Me.mdNo.TabStop = True
        Me.mdNo.Text = "No"
        Me.mdNo.UseVisualStyleBackColor = True
        '
        'ALTA_UNIDADES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 451)
        Me.Controls.Add(Me.mdNo)
        Me.Controls.Add(Me.mdSi)
        Me.Controls.Add(Me.mdLocalidad)
        Me.Controls.Add(Me.mdCodigopostal)
        Me.Controls.Add(Me.mdColonia)
        Me.Controls.Add(Me.mdNumeroint)
        Me.Controls.Add(Me.mdNumeroext)
        Me.Controls.Add(Me.mdCalle)
        Me.Controls.Add(Me.mdNombre)
        Me.Controls.Add(Me.cbMunicipios)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbJurisdiccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbUnidades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ALTA_UNIDADES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA UNIDADES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbUnidades As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbJurisdiccion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btGuardar As Button
    Friend WithEvents cbMunicipios As ComboBox
    Friend WithEvents mdNombre As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mdCalle As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mdNumeroext As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mdNumeroint As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mdColonia As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mdCodigopostal As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mdLocalidad As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mdSi As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mdNo As MaterialSkin.Controls.MaterialRadioButton
End Class

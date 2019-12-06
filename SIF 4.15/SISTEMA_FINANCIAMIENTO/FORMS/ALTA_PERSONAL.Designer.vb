<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ALTA_PERSONAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTA_PERSONAL))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAbreviatura = New System.Windows.Forms.ComboBox()
        Me.msApellidopaterno = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.msApellidomaterno = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.msNombres = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.msPuesto = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbApellidopaterno = New System.Windows.Forms.Label()
        Me.lbApellidomaterno = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbPuesto = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prefijo"
        '
        'cbAbreviatura
        '
        Me.cbAbreviatura.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cbAbreviatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbreviatura.FormattingEnabled = True
        Me.cbAbreviatura.Items.AddRange(New Object() {"DR.", "C.P.", "ING.", "L.C.", "L.F.C.", "LIC.", "L.A.", "L.A.E.", "Sr.", "C.", "FÍSICO"})
        Me.cbAbreviatura.Location = New System.Drawing.Point(114, 70)
        Me.cbAbreviatura.Name = "cbAbreviatura"
        Me.cbAbreviatura.Size = New System.Drawing.Size(101, 21)
        Me.cbAbreviatura.TabIndex = 0
        '
        'msApellidopaterno
        '
        Me.msApellidopaterno.Depth = 0
        Me.msApellidopaterno.Hint = "Apellido Paterno"
        Me.msApellidopaterno.Location = New System.Drawing.Point(114, 117)
        Me.msApellidopaterno.MouseState = MaterialSkin.MouseState.HOVER
        Me.msApellidopaterno.Name = "msApellidopaterno"
        Me.msApellidopaterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.msApellidopaterno.SelectedText = ""
        Me.msApellidopaterno.SelectionLength = 0
        Me.msApellidopaterno.SelectionStart = 0
        Me.msApellidopaterno.Size = New System.Drawing.Size(191, 23)
        Me.msApellidopaterno.TabIndex = 6
        Me.msApellidopaterno.UseSystemPasswordChar = False
        '
        'msApellidomaterno
        '
        Me.msApellidomaterno.Depth = 0
        Me.msApellidomaterno.Hint = "Apellido Materno"
        Me.msApellidomaterno.Location = New System.Drawing.Point(114, 162)
        Me.msApellidomaterno.MouseState = MaterialSkin.MouseState.HOVER
        Me.msApellidomaterno.Name = "msApellidomaterno"
        Me.msApellidomaterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.msApellidomaterno.SelectedText = ""
        Me.msApellidomaterno.SelectionLength = 0
        Me.msApellidomaterno.SelectionStart = 0
        Me.msApellidomaterno.Size = New System.Drawing.Size(191, 23)
        Me.msApellidomaterno.TabIndex = 7
        Me.msApellidomaterno.UseSystemPasswordChar = False
        '
        'msNombres
        '
        Me.msNombres.Depth = 0
        Me.msNombres.Hint = "Nombres"
        Me.msNombres.Location = New System.Drawing.Point(114, 211)
        Me.msNombres.MouseState = MaterialSkin.MouseState.HOVER
        Me.msNombres.Name = "msNombres"
        Me.msNombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.msNombres.SelectedText = ""
        Me.msNombres.SelectionLength = 0
        Me.msNombres.SelectionStart = 0
        Me.msNombres.Size = New System.Drawing.Size(191, 23)
        Me.msNombres.TabIndex = 8
        Me.msNombres.UseSystemPasswordChar = False
        '
        'msPuesto
        '
        Me.msPuesto.Depth = 0
        Me.msPuesto.Hint = "Puesto"
        Me.msPuesto.Location = New System.Drawing.Point(114, 255)
        Me.msPuesto.MouseState = MaterialSkin.MouseState.HOVER
        Me.msPuesto.Name = "msPuesto"
        Me.msPuesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.msPuesto.SelectedText = ""
        Me.msPuesto.SelectionLength = 0
        Me.msPuesto.SelectionStart = 0
        Me.msPuesto.Size = New System.Drawing.Size(191, 23)
        Me.msPuesto.TabIndex = 9
        Me.msPuesto.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(140, 306)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(75, 34)
        Me.MaterialRaisedButton1.TabIndex = 10
        Me.MaterialRaisedButton1.Text = "Guardar"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbApellidopaterno
        '
        Me.lbApellidopaterno.AutoSize = True
        Me.lbApellidopaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApellidopaterno.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbApellidopaterno.Location = New System.Drawing.Point(19, 121)
        Me.lbApellidopaterno.Name = "lbApellidopaterno"
        Me.lbApellidopaterno.Size = New System.Drawing.Size(84, 13)
        Me.lbApellidopaterno.TabIndex = 13
        Me.lbApellidopaterno.Text = "Apellido Paterno"
        '
        'lbApellidomaterno
        '
        Me.lbApellidomaterno.AutoSize = True
        Me.lbApellidomaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApellidomaterno.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbApellidomaterno.Location = New System.Drawing.Point(19, 164)
        Me.lbApellidomaterno.Name = "lbApellidomaterno"
        Me.lbApellidomaterno.Size = New System.Drawing.Size(86, 13)
        Me.lbApellidomaterno.TabIndex = 14
        Me.lbApellidomaterno.Text = "Apellido Materno"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbNombre.Location = New System.Drawing.Point(61, 215)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(44, 13)
        Me.lbNombre.TabIndex = 15
        Me.lbNombre.Text = "Nombre"
        '
        'lbPuesto
        '
        Me.lbPuesto.AutoSize = True
        Me.lbPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuesto.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbPuesto.Location = New System.Drawing.Point(66, 257)
        Me.lbPuesto.Name = "lbPuesto"
        Me.lbPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lbPuesto.TabIndex = 16
        Me.lbPuesto.Text = "Puesto"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(368, 25)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Consultar"
        '
        'ALTA_PERSONAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 378)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbPuesto)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbApellidomaterno)
        Me.Controls.Add(Me.lbApellidopaterno)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.msPuesto)
        Me.Controls.Add(Me.msNombres)
        Me.Controls.Add(Me.msApellidomaterno)
        Me.Controls.Add(Me.msApellidopaterno)
        Me.Controls.Add(Me.cbAbreviatura)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "ALTA_PERSONAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA PERSONAL"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbAbreviatura As System.Windows.Forms.ComboBox
    Friend WithEvents msApellidopaterno As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents msApellidomaterno As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents msNombres As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents msPuesto As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbApellidopaterno As Label
    Friend WithEvents lbApellidomaterno As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbPuesto As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_MARCAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTA_MARCAS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPartidas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSubcapitulo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbdescripcion = New System.Windows.Forms.TextBox()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combodesmarca = New System.Windows.Forms.ComboBox()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "Partida"
        '
        'cbPartidas
        '
        Me.cbPartidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartidas.FormattingEnabled = True
        Me.cbPartidas.Location = New System.Drawing.Point(104, 109)
        Me.cbPartidas.Name = "cbPartidas"
        Me.cbPartidas.Size = New System.Drawing.Size(318, 21)
        Me.cbPartidas.TabIndex = 225
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "Subcapítulo"
        '
        'cbSubcapitulo
        '
        Me.cbSubcapitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSubcapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubcapitulo.FormattingEnabled = True
        Me.cbSubcapitulo.Location = New System.Drawing.Point(104, 70)
        Me.cbSubcapitulo.Name = "cbSubcapitulo"
        Me.cbSubcapitulo.Size = New System.Drawing.Size(318, 21)
        Me.cbSubcapitulo.TabIndex = 223
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(33, 149)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 239
        Me.Label21.Text = "Descripción"
        '
        'tbdescripcion
        '
        Me.tbdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbdescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbdescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbdescripcion.Location = New System.Drawing.Point(104, 147)
        Me.tbdescripcion.MaxLength = 20
        Me.tbdescripcion.Name = "tbdescripcion"
        Me.tbdescripcion.Size = New System.Drawing.Size(318, 20)
        Me.tbdescripcion.TabIndex = 253
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(347, 184)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(75, 23)
        Me.btguardar.TabIndex = 254
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(466, 25)
        Me.ToolStrip1.TabIndex = 255
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripButton2.Text = "Nuevo"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton3.Text = "Editar"
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
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 303
        Me.Label4.Text = "Seleccionar"
        '
        'combodesmarca
        '
        Me.combodesmarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.combodesmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodesmarca.FormattingEnabled = True
        Me.combodesmarca.Location = New System.Drawing.Point(104, 31)
        Me.combodesmarca.Name = "combodesmarca"
        Me.combodesmarca.Size = New System.Drawing.Size(318, 21)
        Me.combodesmarca.TabIndex = 302
        '
        'btactualizar
        '
        Me.btactualizar.Location = New System.Drawing.Point(255, 184)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btactualizar.TabIndex = 304
        Me.btactualizar.Text = "Actualizar"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'ALTA_MARCAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 219)
        Me.Controls.Add(Me.btactualizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combodesmarca)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.tbdescripcion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPartidas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSubcapitulo)
        Me.Name = "ALTA_MARCAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA_MARCAS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPartidas As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSubcapitulo As ComboBox
    Friend WithEvents Label21 As Label
    Public WithEvents tbdescripcion As TextBox
    Friend WithEvents btguardar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents combodesmarca As ComboBox
    Friend WithEvents btactualizar As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_MODELO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTA_MODELO))
        Me.btguardar = New System.Windows.Forms.Button()
        Me.tbdescripcion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSubcapitulo = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combodesmodelo = New System.Windows.Forms.ComboBox()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(379, 165)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(75, 23)
        Me.btguardar.TabIndex = 274
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'tbdescripcion
        '
        Me.tbdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbdescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbdescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbdescripcion.Location = New System.Drawing.Point(134, 122)
        Me.tbdescripcion.MaxLength = 20
        Me.tbdescripcion.Name = "tbdescripcion"
        Me.tbdescripcion.Size = New System.Drawing.Size(320, 20)
        Me.tbdescripcion.TabIndex = 273
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(65, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 272
        Me.Label21.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "Subcapítulo"
        '
        'cbSubcapitulo
        '
        Me.cbSubcapitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSubcapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubcapitulo.FormattingEnabled = True
        Me.cbSubcapitulo.Location = New System.Drawing.Point(134, 79)
        Me.cbSubcapitulo.Name = "cbSubcapitulo"
        Me.cbSubcapitulo.Size = New System.Drawing.Size(318, 21)
        Me.cbSubcapitulo.TabIndex = 266
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(546, 25)
        Me.ToolStrip1.TabIndex = 277
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
        Me.Label4.Location = New System.Drawing.Point(65, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "Seleccionar"
        '
        'combodesmodelo
        '
        Me.combodesmodelo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.combodesmodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodesmodelo.FormattingEnabled = True
        Me.combodesmodelo.Location = New System.Drawing.Point(134, 38)
        Me.combodesmodelo.Name = "combodesmodelo"
        Me.combodesmodelo.Size = New System.Drawing.Size(318, 21)
        Me.combodesmodelo.TabIndex = 300
        '
        'btactualizar
        '
        Me.btactualizar.Location = New System.Drawing.Point(298, 165)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btactualizar.TabIndex = 302
        Me.btactualizar.Text = "Actualizar"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'ALTA_MODELO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 203)
        Me.Controls.Add(Me.btactualizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combodesmodelo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.tbdescripcion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSubcapitulo)
        Me.Name = "ALTA_MODELO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA_MODELO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btguardar As Button
    Public WithEvents tbdescripcion As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSubcapitulo As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents combodesmodelo As ComboBox
    Friend WithEvents btactualizar As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ALTA_GRUPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTA_GRUPO))
        Me.btguardar = New System.Windows.Forms.Button()
        Me.tbdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPartidas = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combodesgrupo = New System.Windows.Forms.ComboBox()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(351, 132)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(75, 23)
        Me.btguardar.TabIndex = 260
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'tbdescripcion
        '
        Me.tbdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbdescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbdescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbdescripcion.Location = New System.Drawing.Point(109, 104)
        Me.tbdescripcion.MaxLength = 100
        Me.tbdescripcion.Name = "tbdescripcion"
        Me.tbdescripcion.Size = New System.Drawing.Size(318, 20)
        Me.tbdescripcion.TabIndex = 259
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 258
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 257
        Me.Label1.Text = "Partida"
        '
        'cbPartidas
        '
        Me.cbPartidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartidas.FormattingEnabled = True
        Me.cbPartidas.Location = New System.Drawing.Point(109, 68)
        Me.cbPartidas.Name = "cbPartidas"
        Me.cbPartidas.Size = New System.Drawing.Size(318, 21)
        Me.cbPartidas.TabIndex = 256
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(488, 25)
        Me.ToolStrip1.TabIndex = 261
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(46, 22)
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.ToolTipText = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton2.Text = "Editar"
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
        Me.Label4.Location = New System.Drawing.Point(40, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 299
        Me.Label4.Text = "Seleccionar"
        '
        'combodesgrupo
        '
        Me.combodesgrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.combodesgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodesgrupo.FormattingEnabled = True
        Me.combodesgrupo.Location = New System.Drawing.Point(109, 36)
        Me.combodesgrupo.Name = "combodesgrupo"
        Me.combodesgrupo.Size = New System.Drawing.Size(318, 21)
        Me.combodesgrupo.TabIndex = 298
        '
        'btactualizar
        '
        Me.btactualizar.Location = New System.Drawing.Point(270, 132)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btactualizar.TabIndex = 300
        Me.btactualizar.Text = "Actualizar"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'ALTA_GRUPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 172)
        Me.Controls.Add(Me.btactualizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combodesgrupo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.tbdescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPartidas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ALTA_GRUPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA_GRUPO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btguardar As Button
    Public WithEvents tbdescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPartidas As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents combodesgrupo As ComboBox
    Friend WithEvents btactualizar As Button
    Friend WithEvents Nuevo As ToolStripButton
End Class

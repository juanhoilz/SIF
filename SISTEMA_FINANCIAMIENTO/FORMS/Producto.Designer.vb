<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto))
        Me.cbmarca = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.tbdescripcion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPartidas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSubcapitulo = New System.Windows.Forms.ComboBox()
        Me.cbmodelo = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbDesbloquear = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btbuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbmarca
        '
        Me.cbmarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmarca.FormattingEnabled = True
        Me.cbmarca.Location = New System.Drawing.Point(204, 222)
        Me.cbmarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbmarca.Name = "cbmarca"
        Me.cbmarca.Size = New System.Drawing.Size(425, 24)
        Me.cbmarca.TabIndex = 287
        '
        'Label25
        '
        Me.Label25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(144, 225)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 17)
        Me.Label25.TabIndex = 286
        Me.Label25.Text = "Marca"
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(424, 390)
        Me.btguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(100, 28)
        Me.btguardar.TabIndex = 285
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'tbdescripcion
        '
        Me.tbdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbdescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbdescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbdescripcion.Location = New System.Drawing.Point(205, 347)
        Me.tbdescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbdescripcion.MaxLength = 200
        Me.tbdescripcion.Name = "tbdescripcion"
        Me.tbdescripcion.Size = New System.Drawing.Size(425, 22)
        Me.tbdescripcion.TabIndex = 284
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(115, 347)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 17)
        Me.Label21.TabIndex = 283
        Me.Label21.Text = "Descripción"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(145, 192)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 282
        Me.Label9.Text = "Grupo"
        '
        'cbGrupo
        '
        Me.cbGrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.Location = New System.Drawing.Point(204, 187)
        Me.cbGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(424, 24)
        Me.cbGrupo.TabIndex = 281
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 153)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Partida"
        '
        'cbPartidas
        '
        Me.cbPartidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartidas.FormattingEnabled = True
        Me.cbPartidas.Location = New System.Drawing.Point(205, 149)
        Me.cbPartidas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPartidas.Name = "cbPartidas"
        Me.cbPartidas.Size = New System.Drawing.Size(423, 24)
        Me.cbPartidas.TabIndex = 279
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 278
        Me.Label3.Text = "Subcapítulo"
        '
        'cbSubcapitulo
        '
        Me.cbSubcapitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSubcapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubcapitulo.FormattingEnabled = True
        Me.cbSubcapitulo.Location = New System.Drawing.Point(207, 110)
        Me.cbSubcapitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSubcapitulo.Name = "cbSubcapitulo"
        Me.cbSubcapitulo.Size = New System.Drawing.Size(423, 24)
        Me.cbSubcapitulo.TabIndex = 277
        '
        'cbmodelo
        '
        Me.cbmodelo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbmodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmodelo.FormattingEnabled = True
        Me.cbmodelo.Location = New System.Drawing.Point(205, 263)
        Me.cbmodelo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbmodelo.Name = "cbmodelo"
        Me.cbmodelo.Size = New System.Drawing.Size(425, 24)
        Me.cbmodelo.TabIndex = 289
        '
        'Label26
        '
        Me.Label26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(137, 263)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(54, 17)
        Me.Label26.TabIndex = 288
        Me.Label26.Text = "Modelo"
        '
        'tbClave
        '
        Me.tbClave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbClave.Location = New System.Drawing.Point(205, 302)
        Me.tbClave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbClave.MaxLength = 20
        Me.tbClave.Name = "tbClave"
        Me.tbClave.ReadOnly = True
        Me.tbClave.Size = New System.Drawing.Size(425, 22)
        Me.tbClave.TabIndex = 291
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 305)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 290
        Me.Label2.Text = "Clave Activo"
        '
        'chbDesbloquear
        '
        Me.chbDesbloquear.AutoSize = True
        Me.chbDesbloquear.Location = New System.Drawing.Point(644, 300)
        Me.chbDesbloquear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbDesbloquear.Name = "chbDesbloquear"
        Me.chbDesbloquear.Size = New System.Drawing.Size(67, 21)
        Me.chbDesbloquear.TabIndex = 292
        Me.chbDesbloquear.Text = "Editar"
        Me.chbDesbloquear.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(796, 27)
        Me.ToolStrip1.TabIndex = 293
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(56, 24)
        Me.ToolStripButton3.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 24)
        Me.ToolStripButton2.Text = "Editar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.icons8_bÃºsqueda_24
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(95, 24)
        Me.ToolStripButton1.Text = "Consultar"
        '
        'btactualizar
        '
        Me.btactualizar.Location = New System.Drawing.Point(532, 390)
        Me.btactualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(100, 28)
        Me.btactualizar.TabIndex = 294
        Me.btactualizar.Text = "Actualizar"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(207, 76)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(423, 24)
        Me.ComboBox1.TabIndex = 295
        '
        'btbuscar
        '
        Me.btbuscar.Location = New System.Drawing.Point(639, 74)
        Me.btbuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(100, 28)
        Me.btbuscar.TabIndex = 296
        Me.btbuscar.Text = "Buscar"
        Me.btbuscar.UseVisualStyleBackColor = True
        Me.btbuscar.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 297
        Me.Label4.Text = "Seleccionar"
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 463)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btbuscar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btactualizar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.chbDesbloquear)
        Me.Controls.Add(Me.tbClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbmodelo)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cbmarca)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.tbdescripcion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPartidas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSubcapitulo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbmarca As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents btguardar As Button
    Public WithEvents tbdescripcion As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbGrupo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPartidas As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSubcapitulo As ComboBox
    Friend WithEvents cbmodelo As ComboBox
    Friend WithEvents Label26 As Label
    Public WithEvents tbClave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chbDesbloquear As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents btactualizar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btbuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripButton3 As ToolStripButton
End Class

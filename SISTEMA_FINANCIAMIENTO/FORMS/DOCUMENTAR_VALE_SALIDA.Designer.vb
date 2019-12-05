<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOCUMENTAR_VALE_SALIDA
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
        Me.tbAplica = New System.Windows.Forms.TextBox()
        Me.tbDepartamento = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.Button()
        Me.tbPedido = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbFolio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAutoriza = New System.Windows.Forms.ComboBox()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSolicita = New System.Windows.Forms.TextBox()
        Me.tbIdpedido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.cbRecibe = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbAplica
        '
        Me.tbAplica.Enabled = False
        Me.tbAplica.Location = New System.Drawing.Point(148, 162)
        Me.tbAplica.MaxLength = 20
        Me.tbAplica.Name = "tbAplica"
        Me.tbAplica.Size = New System.Drawing.Size(269, 20)
        Me.tbAplica.TabIndex = 119
        '
        'tbDepartamento
        '
        Me.tbDepartamento.Enabled = False
        Me.tbDepartamento.Location = New System.Drawing.Point(148, 132)
        Me.tbDepartamento.MaxLength = 20
        Me.tbDepartamento.Name = "tbDepartamento"
        Me.tbDepartamento.Size = New System.Drawing.Size(269, 20)
        Me.tbDepartamento.TabIndex = 118
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(561, 42)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(515, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "Fecha"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(507, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Autoriza"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(53, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Para aplicarse en"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 13)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "Departamento solicitante"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(274, 35)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(75, 32)
        Me.tbBuscar.TabIndex = 105
        Me.tbBuscar.Text = "Continuar"
        Me.tbBuscar.UseVisualStyleBackColor = True
        '
        'tbPedido
        '
        Me.tbPedido.Location = New System.Drawing.Point(148, 42)
        Me.tbPedido.MaxLength = 10
        Me.tbPedido.Name = "tbPedido"
        Me.tbPedido.Size = New System.Drawing.Size(118, 20)
        Me.tbPedido.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(102, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 103
        Me.Label21.Text = "Pedido"
        '
        'tbFolio
        '
        Me.tbFolio.Enabled = False
        Me.tbFolio.Location = New System.Drawing.Point(148, 74)
        Me.tbFolio.MaxLength = 20
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.Size = New System.Drawing.Size(118, 20)
        Me.tbFolio.TabIndex = 141
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Folio orden de compra"
        '
        'cbAutoriza
        '
        Me.cbAutoriza.FormattingEnabled = True
        Me.cbAutoriza.Location = New System.Drawing.Point(561, 74)
        Me.cbAutoriza.Name = "cbAutoriza"
        Me.cbAutoriza.Size = New System.Drawing.Size(298, 21)
        Me.cbAutoriza.TabIndex = 2
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.AllowUserToDeleteRows = False
        Me.dgvPedido.AllowUserToOrderColumns = True
        Me.dgvPedido.AllowUserToResizeRows = False
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Location = New System.Drawing.Point(12, 288)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.ReadOnly = True
        Me.dgvPedido.Size = New System.Drawing.Size(839, 171)
        Me.dgvPedido.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Solicita"
        '
        'tbSolicita
        '
        Me.tbSolicita.Enabled = False
        Me.tbSolicita.Location = New System.Drawing.Point(148, 193)
        Me.tbSolicita.MaxLength = 20
        Me.tbSolicita.Name = "tbSolicita"
        Me.tbSolicita.Size = New System.Drawing.Size(269, 20)
        Me.tbSolicita.TabIndex = 144
        '
        'tbIdpedido
        '
        Me.tbIdpedido.Enabled = False
        Me.tbIdpedido.Location = New System.Drawing.Point(149, 103)
        Me.tbIdpedido.MaxLength = 20
        Me.tbIdpedido.Name = "tbIdpedido"
        Me.tbIdpedido.Size = New System.Drawing.Size(118, 20)
        Me.tbIdpedido.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Id pedido"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(882, 25)
        Me.ToolStrip1.TabIndex = 147
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.action_add_16xLG
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources._126_Edit1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton2.Text = "Editar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.search
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripButton3.Text = "Buscar e imprimir"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.puerta_de_salida_con_la_flecha_hacia_la_derecha_318_405972
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton4.Text = "Salir"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(561, 159)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(79, 34)
        Me.btGuardar.TabIndex = 4
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btImprimir
        '
        Me.btImprimir.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources.printer
        Me.btImprimir.Location = New System.Drawing.Point(657, 159)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(79, 34)
        Me.btImprimir.TabIndex = 5
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'cbRecibe
        '
        Me.cbRecibe.FormattingEnabled = True
        Me.cbRecibe.Location = New System.Drawing.Point(561, 117)
        Me.cbRecibe.Name = "cbRecibe"
        Me.cbRecibe.Size = New System.Drawing.Size(298, 21)
        Me.cbRecibe.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Recibe"
        '
        'DOCUMENTAR_VALE_SALIDA
        '
        Me.AcceptButton = Me.tbBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 484)
        Me.Controls.Add(Me.cbRecibe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tbIdpedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbSolicita)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbAutoriza)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.tbAplica)
        Me.Controls.Add(Me.tbDepartamento)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.tbPedido)
        Me.Controls.Add(Me.Label21)
        Me.Name = "DOCUMENTAR_VALE_SALIDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOCUMENTAR VALE DE SALIDA"
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbAplica As System.Windows.Forms.TextBox
    Friend WithEvents tbDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbBuscar As System.Windows.Forms.Button
    Friend WithEvents tbPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents tbFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbAutoriza As System.Windows.Forms.ComboBox
    Friend WithEvents dgvPedido As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSolicita As System.Windows.Forms.TextBox
    Friend WithEvents tbIdpedido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbRecibe As ComboBox
    Friend WithEvents Label1 As Label
End Class

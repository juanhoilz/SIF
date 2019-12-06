<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VALIDAR_MEDICAMENTOS
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
        Me.cbEjercicio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btContinuar = New System.Windows.Forms.Button()
        Me.cbPartidas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btIniciar = New System.Windows.Forms.Button()
        Me.AbrirXML = New System.Windows.Forms.OpenFileDialog()
        Me.lbValidacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbEjercicio
        '
        Me.cbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjercicio.FormattingEnabled = True
        Me.cbEjercicio.Items.AddRange(New Object() {"2016", "2018"})
        Me.cbEjercicio.Location = New System.Drawing.Point(130, 65)
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(274, 21)
        Me.cbEjercicio.TabIndex = 91
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(75, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 14)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "CAUSES"
        '
        'btContinuar
        '
        Me.btContinuar.Location = New System.Drawing.Point(300, 245)
        Me.btContinuar.Name = "btContinuar"
        Me.btContinuar.Size = New System.Drawing.Size(82, 29)
        Me.btContinuar.TabIndex = 85
        Me.btContinuar.Text = "Continuar"
        Me.btContinuar.UseVisualStyleBackColor = True
        '
        'cbPartidas
        '
        Me.cbPartidas.AutoCompleteCustomSource.AddRange(New String() {"2016", "2017", "2018"})
        Me.cbPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartidas.DropDownWidth = 400
        Me.cbPartidas.FormattingEnabled = True
        Me.cbPartidas.Items.AddRange(New Object() {"2016", "2017", "2018"})
        Me.cbPartidas.Location = New System.Drawing.Point(130, 100)
        Me.cbPartidas.Name = "cbPartidas"
        Me.cbPartidas.Size = New System.Drawing.Size(274, 21)
        Me.cbPartidas.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(13, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 14)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Precios de referencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 19)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "VALIDAR SOBREPRECIOS Y FUERA DE CAUSES"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(549, 65)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(136, 20)
        Me.tbTotal.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(479, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Total factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(479, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Sobreprecio"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(549, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 20)
        Me.TextBox2.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(448, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 14)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Fuera de CAUSES"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(549, 129)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(136, 20)
        Me.TextBox3.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(476, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 14)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Total a pagar"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(549, 161)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(136, 20)
        Me.TextBox4.TabIndex = 100
        '
        'btIniciar
        '
        Me.btIniciar.Location = New System.Drawing.Point(203, 132)
        Me.btIniciar.Name = "btIniciar"
        Me.btIniciar.Size = New System.Drawing.Size(82, 29)
        Me.btIniciar.TabIndex = 102
        Me.btIniciar.Text = "Iniciar"
        Me.btIniciar.UseVisualStyleBackColor = True
        '
        'AbrirXML
        '
        Me.AbrirXML.FileName = "AbrirXML"
        '
        'lbValidacion
        '
        Me.lbValidacion.AutoSize = True
        Me.lbValidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValidacion.ForeColor = System.Drawing.Color.Green
        Me.lbValidacion.Location = New System.Drawing.Point(229, 210)
        Me.lbValidacion.Name = "lbValidacion"
        Me.lbValidacion.Size = New System.Drawing.Size(226, 20)
        Me.lbValidacion.TabIndex = 103
        Me.lbValidacion.Text = "¡VALIDACIÓN COMPLETA!"
        '
        'VALIDAR_MEDICAMENTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 315)
        Me.Controls.Add(Me.lbValidacion)
        Me.Controls.Add(Me.btIniciar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.cbEjercicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btContinuar)
        Me.Controls.Add(Me.cbPartidas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VALIDAR_MEDICAMENTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VALIDAR_MEDICAMENTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbEjercicio As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btContinuar As Button
    Friend WithEvents cbPartidas As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btIniciar As Button
    Friend WithEvents AbrirXML As OpenFileDialog
    Friend WithEvents lbValidacion As Label
End Class

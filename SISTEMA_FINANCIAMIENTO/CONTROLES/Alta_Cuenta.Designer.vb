<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Cuenta
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tbNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEjercicio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSaldoInicial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSaldoActual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.cbCuenta = New System.Windows.Forms.ComboBox()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.tbClabe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(23, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALTA CUENTA BANCARIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Banco:"
        '
        'tbNumeroCuenta
        '
        Me.tbNumeroCuenta.Location = New System.Drawing.Point(146, 98)
        Me.tbNumeroCuenta.MaxLength = 10
        Me.tbNumeroCuenta.Name = "tbNumeroCuenta"
        Me.tbNumeroCuenta.Size = New System.Drawing.Size(231, 20)
        Me.tbNumeroCuenta.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Número de cuenta:"
        '
        'tbEjercicio
        '
        Me.tbEjercicio.Location = New System.Drawing.Point(146, 165)
        Me.tbEjercicio.MaxLength = 4
        Me.tbEjercicio.Name = "tbEjercicio"
        Me.tbEjercicio.Size = New System.Drawing.Size(133, 20)
        Me.tbEjercicio.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ejercicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cuenta Origen:"
        '
        'tbSaldoInicial
        '
        Me.tbSaldoInicial.Location = New System.Drawing.Point(146, 235)
        Me.tbSaldoInicial.Name = "tbSaldoInicial"
        Me.tbSaldoInicial.Size = New System.Drawing.Size(133, 20)
        Me.tbSaldoInicial.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Saldo inicial:"
        '
        'tbSaldoActual
        '
        Me.tbSaldoActual.Location = New System.Drawing.Point(146, 269)
        Me.tbSaldoActual.Name = "tbSaldoActual"
        Me.tbSaldoActual.Size = New System.Drawing.Size(133, 20)
        Me.tbSaldoActual.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Saldo Actual:"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(247, 298)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(94, 29)
        Me.btGuardar.TabIndex = 15
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(375, 298)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(94, 29)
        Me.btCancelar.TabIndex = 16
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'cbCuenta
        '
        Me.cbCuenta.FormattingEnabled = True
        Me.cbCuenta.Location = New System.Drawing.Point(146, 200)
        Me.cbCuenta.Name = "cbCuenta"
        Me.cbCuenta.Size = New System.Drawing.Size(319, 21)
        Me.cbCuenta.TabIndex = 17
        '
        'cbBancos
        '
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(148, 63)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(228, 21)
        Me.cbBancos.TabIndex = 18
        '
        'tbClabe
        '
        Me.tbClabe.Location = New System.Drawing.Point(146, 131)
        Me.tbClabe.MaxLength = 18
        Me.tbClabe.Name = "tbClabe"
        Me.tbClabe.Size = New System.Drawing.Size(166, 20)
        Me.tbClabe.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Clabe:"
        '
        'Alta_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbClabe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.cbCuenta)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.tbSaldoActual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbSaldoInicial)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbEjercicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNumeroCuenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Alta_Cuenta"
        Me.Size = New System.Drawing.Size(554, 424)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNumeroCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbSaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbSaldoActual As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents cbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents tbClabe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

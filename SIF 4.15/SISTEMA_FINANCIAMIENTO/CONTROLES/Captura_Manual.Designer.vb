<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAPTURA_MANUAL
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
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.tbunidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbValorunitario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbImporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btContinuar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btCargarXml = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btManual = New System.Windows.Forms.Button()
        Me.btXml = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad"
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(98, 68)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(155, 20)
        Me.tbCantidad.TabIndex = 1
        '
        'tbunidad
        '
        Me.tbunidad.Location = New System.Drawing.Point(98, 99)
        Me.tbunidad.Name = "tbunidad"
        Me.tbunidad.Size = New System.Drawing.Size(155, 20)
        Me.tbunidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidad"
        '
        'tbClave
        '
        Me.tbClave.Location = New System.Drawing.Point(98, 132)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(155, 20)
        Me.tbClave.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Clave"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(98, 166)
        Me.tbDescripcion.MaxLength = 400
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(257, 20)
        Me.tbDescripcion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'tbValorunitario
        '
        Me.tbValorunitario.Location = New System.Drawing.Point(454, 68)
        Me.tbValorunitario.Name = "tbValorunitario"
        Me.tbValorunitario.Size = New System.Drawing.Size(155, 20)
        Me.tbValorunitario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Valor unitario"
        '
        'tbImporte
        '
        Me.tbImporte.Location = New System.Drawing.Point(454, 97)
        Me.tbImporte.Name = "tbImporte"
        Me.tbImporte.Size = New System.Drawing.Size(155, 20)
        Me.tbImporte.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Importe"
        '
        'btAgregar
        '
        Me.btAgregar.BackColor = System.Drawing.Color.Gainsboro
        Me.btAgregar.Location = New System.Drawing.Point(501, 153)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(79, 32)
        Me.btAgregar.TabIndex = 18
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = False
        '
        'btContinuar
        '
        Me.btContinuar.BackColor = System.Drawing.Color.Gainsboro
        Me.btContinuar.Location = New System.Drawing.Point(595, 153)
        Me.btContinuar.Name = "btContinuar"
        Me.btContinuar.Size = New System.Drawing.Size(79, 32)
        Me.btContinuar.TabIndex = 19
        Me.btContinuar.Text = "Continuar"
        Me.btContinuar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(690, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 32)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btCargarXml
        '
        Me.btCargarXml.BackColor = System.Drawing.Color.Gainsboro
        Me.btCargarXml.Location = New System.Drawing.Point(407, 153)
        Me.btCargarXml.Name = "btCargarXml"
        Me.btCargarXml.Size = New System.Drawing.Size(79, 32)
        Me.btCargarXml.TabIndex = 24
        Me.btCargarXml.Text = "Cargar XML"
        Me.btCargarXml.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivos XML|*.xml"
        Me.OpenFileDialog1.InitialDirectory = "C:\XML"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.ValidateNames = False
        '
        'btManual
        '
        Me.btManual.BackColor = System.Drawing.Color.Gainsboro
        Me.btManual.Location = New System.Drawing.Point(98, 13)
        Me.btManual.Name = "btManual"
        Me.btManual.Size = New System.Drawing.Size(79, 32)
        Me.btManual.TabIndex = 25
        Me.btManual.Text = "Manual"
        Me.btManual.UseVisualStyleBackColor = False
        '
        'btXml
        '
        Me.btXml.BackColor = System.Drawing.Color.Gainsboro
        Me.btXml.Location = New System.Drawing.Point(223, 13)
        Me.btXml.Name = "btXml"
        Me.btXml.Size = New System.Drawing.Size(79, 32)
        Me.btXml.TabIndex = 26
        Me.btXml.Text = "XML"
        Me.btXml.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(690, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "XML"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CAPTURA_MANUAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btXml)
        Me.Controls.Add(Me.btManual)
        Me.Controls.Add(Me.btCargarXml)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btContinuar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.tbImporte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbValorunitario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbClave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbunidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CAPTURA_MANUAL"
        Me.Size = New System.Drawing.Size(803, 227)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCantidad As System.Windows.Forms.TextBox
    Friend WithEvents tbunidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbClave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbValorunitario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents btContinuar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btCargarXml As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btManual As System.Windows.Forms.Button
    Friend WithEvents btXml As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

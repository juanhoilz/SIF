<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Botones_Comisiones
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
        Me.btIniciaproceso = New System.Windows.Forms.Button()
        Me.btAlta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btIniciaproceso
        '
        Me.btIniciaproceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btIniciaproceso.Location = New System.Drawing.Point(1, 42)
        Me.btIniciaproceso.Name = "btIniciaproceso"
        Me.btIniciaproceso.Size = New System.Drawing.Size(131, 43)
        Me.btIniciaproceso.TabIndex = 0
        Me.btIniciaproceso.Text = "Iniciar Proceso"
        Me.btIniciaproceso.UseVisualStyleBackColor = True
        '
        'btAlta
        '
        Me.btAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAlta.Location = New System.Drawing.Point(1, 88)
        Me.btAlta.Name = "btAlta"
        Me.btAlta.Size = New System.Drawing.Size(131, 43)
        Me.btAlta.TabIndex = 1
        Me.btAlta.Text = "Alta personal"
        Me.btAlta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(1, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generar reportes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(1, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Configurar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(-4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Módulo Comisiones"
        '
        'Botones_Comisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btAlta)
        Me.Controls.Add(Me.btIniciaproceso)
        Me.Name = "Botones_Comisiones"
        Me.Size = New System.Drawing.Size(133, 502)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btIniciaproceso As System.Windows.Forms.Button
    Friend WithEvents btAlta As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

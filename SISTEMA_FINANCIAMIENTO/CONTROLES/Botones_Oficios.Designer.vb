<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Botones_Oficios
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
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btReportes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAdministrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btNuevo
        '
        Me.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btNuevo.Location = New System.Drawing.Point(0, 42)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(131, 43)
        Me.btNuevo.TabIndex = 0
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btReportes
        '
        Me.btReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btReportes.Location = New System.Drawing.Point(0, 88)
        Me.btReportes.Name = "btReportes"
        Me.btReportes.Size = New System.Drawing.Size(131, 43)
        Me.btReportes.TabIndex = 1
        Me.btReportes.Text = "Reportes"
        Me.btReportes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Módulo Oficios"
        '
        'btAdministrar
        '
        Me.btAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAdministrar.Location = New System.Drawing.Point(0, 134)
        Me.btAdministrar.Name = "btAdministrar"
        Me.btAdministrar.Size = New System.Drawing.Size(131, 43)
        Me.btAdministrar.TabIndex = 9
        Me.btAdministrar.Text = "Administrar"
        Me.btAdministrar.UseVisualStyleBackColor = True
        '
        'Botones_Oficios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btAdministrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btReportes)
        Me.Controls.Add(Me.btNuevo)
        Me.Name = "Botones_Oficios"
        Me.Size = New System.Drawing.Size(133, 502)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btReportes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btAdministrar As System.Windows.Forms.Button

End Class

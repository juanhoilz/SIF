<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAPTURAR_PARTIDAS
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
        Me.Panel_captura_partidas = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel_captura_partidas
        '
        Me.Panel_captura_partidas.Location = New System.Drawing.Point(14, 46)
        Me.Panel_captura_partidas.Name = "Panel_captura_partidas"
        Me.Panel_captura_partidas.Size = New System.Drawing.Size(813, 202)
        Me.Panel_captura_partidas.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(50, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CAPTURA CLAVES - SERVICIOS"
        '
        'CAPTURAR_PARTIDAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 268)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_captura_partidas)
        Me.Name = "CAPTURAR_PARTIDAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAPTURAR_PARTIDAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_captura_partidas As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

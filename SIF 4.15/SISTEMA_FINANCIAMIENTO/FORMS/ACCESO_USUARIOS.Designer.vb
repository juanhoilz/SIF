<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACCESO_USUARIOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACCESO_USUARIOS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.btEntrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(176, 54)
        Me.tbUsuario.MaxLength = 18
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(162, 20)
        Me.tbUsuario.TabIndex = 3
        '
        'tbContraseña
        '
        Me.tbContraseña.Location = New System.Drawing.Point(176, 106)
        Me.tbContraseña.MaxLength = 15
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.Size = New System.Drawing.Size(162, 20)
        Me.tbContraseña.TabIndex = 4
        Me.tbContraseña.UseSystemPasswordChar = True
        '
        'btEntrar
        '
        Me.btEntrar.BackColor = System.Drawing.Color.DimGray
        Me.btEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btEntrar.Location = New System.Drawing.Point(188, 154)
        Me.btEntrar.Name = "btEntrar"
        Me.btEntrar.Size = New System.Drawing.Size(127, 30)
        Me.btEntrar.TabIndex = 9
        Me.btEntrar.Text = "Entrar"
        Me.btEntrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PRUEBA1_SQL_VB.My.Resources.Resources._40_104848_021
        Me.PictureBox1.Location = New System.Drawing.Point(27, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ACCESO_USUARIOS
        '
        Me.AcceptButton = Me.btEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(395, 214)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btEntrar)
        Me.Controls.Add(Me.tbContraseña)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ACCESO_USUARIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents btEntrar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

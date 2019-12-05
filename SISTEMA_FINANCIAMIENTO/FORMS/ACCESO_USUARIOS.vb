Public Class ACCESO_USUARIOS

    Dim Consultas As New Valida_Existe_Registro
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btEntrar.Click
        If Consultas.Valida_usuario(tbUsuario.Text, tbContraseña.Text) = True Then
            Me.Hide()
            PRINCIPAL.Show()
        Else
            MessageBox.Show("El usuario o la contraseña son incorrectos", "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        PRINCIPAL.tsUsuario.Text = Me.tbUsuario.Text


    End Sub

    Private Sub ACCESO_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbUsuario.CharacterCasing = CharacterCasing.Upper
        Me.tbContraseña.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class
Public Class CONSULTAR
    Dim objeto As New BASEDATOS
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'objeto.llenartabla(Datagrid_Consulta)
        TextBox1.CharacterCasing = CharacterCasing.Upper
        TextBox2.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_PDF.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        objeto.ConsultaDinamicaNombre(TextBox2.Text, Datagrid_Consulta)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class

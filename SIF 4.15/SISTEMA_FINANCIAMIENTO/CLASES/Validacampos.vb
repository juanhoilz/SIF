Public Class Validacampos
    Public Sub numerosdecimal(ByVal textbox As TextBox, ByVal e As KeyPressEventArgs)

        Dim separadorDecimal As String = _
       Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not textbox.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        Dim index As Integer = textbox.Text.IndexOf(separadorDecimal)

        If (index >= 0) And e.KeyChar <> vbBack Then
            Dim decimales As String = textbox.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If

    End Sub

    Public Sub validanumeros(ByVal e As KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Public Sub validaenterfoco(ByVal textbox As TextBox)
        textbox.BackColor = Color.AliceBlue
    End Sub

    Public Sub validaleavefoco(ByVal textbox As TextBox)
        textbox.BackColor = Color.White
    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class


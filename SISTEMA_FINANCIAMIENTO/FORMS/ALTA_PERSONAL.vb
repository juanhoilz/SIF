Imports System.Data
Imports System.Data.SqlClient

Public Class ALTA_PERSONAL
    Dim ex, ey As Integer

    Dim Arrastre As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim cn As New SqlConnection(My.Settings.Conexionbd)
        Try
            cn.Open()

            Dim guardardatos As String = "INSERT INTO TBL_PERSONAL (APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE,PUESTO,ABREVIATURA) VALUES (@apellido_paterno, @apellido_materno, @nombre, @puesto, @abreviatura)"

            Dim comm As New SqlCommand(guardardatos, cn)

            comm.Parameters.AddWithValue("@apellido_paterno", msApellidopaterno.Text)
            comm.Parameters.AddWithValue("@apellido_materno", msApellidomaterno.Text)
            comm.Parameters.AddWithValue("@nombre", msNombres.Text)
            comm.Parameters.AddWithValue("@puesto", msPuesto.Text)
            comm.Parameters.AddWithValue("@abreviatura", cbAbreviatura.Text)

            comm.ExecuteNonQuery()

            MessageBox.Show("Los registros se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            msApellidopaterno.Clear()
            msApellidomaterno.Clear()
            msNombres.Clear()
            msPuesto.Clear()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim cn As New SqlConnection(My.Settings.Conexionbd)
        Try
            cn.Open()

            Dim guardardatos As String = "INSERT INTO TBL_PERSONAL (APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE,PUESTO,ABREVIATURA) VALUES (@apellido_paterno, @apellido_materno, @nombre, @puesto, @abreviatura)"

            Dim comm As New SqlCommand(guardardatos, cn)

            comm.Parameters.AddWithValue("@apellido_paterno", msApellidopaterno.Text)
            comm.Parameters.AddWithValue("@apellido_materno", msApellidomaterno.Text)
            comm.Parameters.AddWithValue("@nombre", msNombres.Text)
            comm.Parameters.AddWithValue("@puesto", msPuesto.Text)
            comm.Parameters.AddWithValue("@abreviatura", cbAbreviatura.Text)

            comm.ExecuteNonQuery()

            MessageBox.Show("Los registros se guardaron correctamente", "Guardar registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            msApellidopaterno.Clear()
            msApellidopaterno.Hint = "Apellido Paterno"
            msApellidomaterno.Clear()
            msNombres.Clear()
            msPuesto.Clear()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)
        Arrastre = False

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))

    End Sub

    Private Sub ALTA_PERSONAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbApellidopaterno.Visible = False
        lbApellidomaterno.Visible = False
        lbNombre.Visible = False
        lbPuesto.Visible = False
    End Sub

    Private Sub msApellidopaterno_Enter(sender As Object, e As EventArgs) Handles msApellidopaterno.Enter
        lbApellidopaterno.Visible = True
    End Sub

    Private Sub msApellidopaterno_Leave(sender As Object, e As EventArgs) Handles msApellidopaterno.Leave
        lbApellidopaterno.Visible = False
    End Sub

    Private Sub msApellidomaterno_Enter(sender As Object, e As EventArgs) Handles msApellidomaterno.Enter
        lbApellidomaterno.Visible = True
    End Sub

    Private Sub msApellidomaterno_Leave(sender As Object, e As EventArgs) Handles msApellidomaterno.Leave
        lbApellidomaterno.Visible = False
    End Sub

    Private Sub msNombres_Enter(sender As Object, e As EventArgs) Handles msNombres.Enter
        lbNombre.Visible = True
    End Sub

    Private Sub msNombres_Leave(sender As Object, e As EventArgs) Handles msNombres.Leave
        lbNombre.Visible = False
    End Sub

    Private Sub msPuesto_Enter(sender As Object, e As EventArgs) Handles msPuesto.Enter
        lbPuesto.Visible = True
    End Sub

    Private Sub msPuesto_Leave(sender As Object, e As EventArgs) Handles msPuesto.Leave
        lbPuesto.Visible = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CONSULTAR_PERSONAL.ShowDialog()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub


End Class
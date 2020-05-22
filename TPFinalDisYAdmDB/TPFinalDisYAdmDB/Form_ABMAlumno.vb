Public Class Form_ABMAlumno
    Private Sub Form_ABMAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        FormMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btn_altaalumno_Click(sender As Object, e As EventArgs) Handles btn_altaalumno.Click
        FormAltaAlumno.Show()
        Me.Hide()
    End Sub

    Private Sub btn_bajaalumno_Click(sender As Object, e As EventArgs) Handles btn_bajaalumno.Click
        FormBajaAlumno.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_ModificacionAlumno.Show()
        Me.Hide()
    End Sub
End Class
Public Class Form_ABMProfesor
    Private Sub Form_ABMProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        FormMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btn_altaprofesor_Click(sender As Object, e As EventArgs) Handles btn_altaprofesor.Click
        FormAltaProfesor.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_bajaprofesor_Click(sender As Object, e As EventArgs) Handles btn_bajaprofesor.Click
        FormBajaProfesores.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_modificprofesor_Click(sender As Object, e As EventArgs) Handles btn_modificprofesor.Click
        Form_ModificProfesores.Show()
        Me.Hide()
    End Sub
End Class
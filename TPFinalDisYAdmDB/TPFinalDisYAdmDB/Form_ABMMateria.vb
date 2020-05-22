Public Class Form_ABMMateria
    Private Sub Form_ABMMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_altamateria_Click(sender As Object, e As EventArgs) Handles btn_altamateria.Click
        Form_AltaMaterias.Show()
        Me.Hide()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        FormMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btn_bajamateria_Click(sender As Object, e As EventArgs) Handles btn_bajamateria.Click
        FormBajaMateria.Show()
        Me.Hide()
    End Sub

    Private Sub btn_modifmateria_Click(sender As Object, e As EventArgs) Handles btn_modifmateria.Click
        Form_ModificacionMaterias.Show()
        Me.Hide()
    End Sub
End Class
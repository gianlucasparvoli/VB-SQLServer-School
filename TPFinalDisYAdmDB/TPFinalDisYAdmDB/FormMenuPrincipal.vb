Public Class FormMenuPrincipal
    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_ABMAlumno_Click(sender As Object, e As EventArgs) Handles btn_ABMAlumno.Click
        Form_ABMAlumno.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ABMMateria_Click(sender As Object, e As EventArgs) Handles btn_ABMMateria.Click
        Form_ABMMateria.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ABMProfesor_Click(sender As Object, e As EventArgs) Handles btn_ABMProfesor.Click
        Form_ABMProfesor.Show()
        Me.Hide()
    End Sub

    Private Sub brn_salir_Click(sender As Object, e As EventArgs) Handles brn_salir.Click
        Me.Hide()
        End
    End Sub

    Private Sub Btn_consultageneral_Click(sender As Object, e As EventArgs) Handles btn_consultageneral.Click
        ConsultaGeneral.Show()
        Me.Hide()
    End Sub
End Class
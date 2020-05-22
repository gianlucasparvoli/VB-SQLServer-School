Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla1 As DataTable = New DataTable
        Dim sql As String
        sql = "SELECT * FROM Login_Usuarios WHERE Usuario = '" & txt_usuario.Text & "' AND Contaseña = '" & txt_contra.Text & "'"
        ConsultarDatos(sql, tabla1)
        If tabla1.Rows.Count > 0 Then
            FormMenuPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario y/o Contraseña Incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
        End
    End Sub
End Class
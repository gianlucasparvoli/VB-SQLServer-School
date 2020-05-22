Public Class FormBajaMateria


    Private Sub btn_buscaridmat_Click(sender As Object, e As EventArgs) Handles btn_buscaridmat.Click
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Materias WHERE ( IDMateria = '" & txt_idmateria.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count > 0) Then

            Me.txt_descripcion.Text = tabla.Rows(0)("DescripcionMateria").ToString
            Me.txt_carrera.Text = tabla.Rows(0)("Carrera").ToString
            Me.txt_profesores.Text = tabla.Rows(0)("NroLegajo_P").ToString

        Else
            MessageBox.Show("Ninguna Materia pertenece a ese ID")
            Me.txt_idmateria.Text = ""
            Me.txt_descripcion.Text = ""
            Me.txt_carrera.Text = ""
            Me.txt_profesores.Text = ""

        End If
    End Sub



    Function validarSQL() As Boolean
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Materias WHERE (IDMateria = '" & txt_idmateria.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count = 0) Then
            Return True
        End If
        Return False
    End Function

    Private Sub FormBajaMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_Bajamateriaa_Click(sender As Object, e As EventArgs) Handles btn_Bajamateriaa.Click
        If validarSQL() = False Then
            Dim sql As String
            Dim tabla As DataTable
            tabla = New DataTable
            sql = "DELETE FROM Materias WHERE IDMateria = '" & txt_idmateria.Text & "'"
            AltaBajaModific(sql)
            MessageBox.Show("Baja Alumno Correcto")
            Me.txt_idmateria.Text = ""
            Me.txt_idmateria.Text = ""
            Me.txt_descripcion.Text = ""
            Me.txt_carrera.Text = ""
            Me.txt_profesores.Text = ""

        Else
            MessageBox.Show("Ninguna Materia pertenece a ese ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_ABMMateria.Show()
        Me.Hide()
    End Sub

End Class
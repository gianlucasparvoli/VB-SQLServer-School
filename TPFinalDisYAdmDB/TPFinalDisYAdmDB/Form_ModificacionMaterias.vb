Public Class Form_ModificacionMaterias
    Private Sub btn_buscaridmat_Click(sender As Object, e As EventArgs) Handles btn_buscaridmat.Click
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Materias WHERE ( IDMateria = '" & txt_idmateria.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count > 0) Then

            Me.txt_descripcion.Text = tabla.Rows(0)("DescripcionMateria").ToString
            Me.txt_carrera.Text = tabla.Rows(0)("Carrera").ToString
            Me.cb_profesores.SelectedValue = tabla.Rows(0)("NroLegajo_P")

        Else
            MessageBox.Show("Ninguna Materia pertenece a ese ID")
            Me.txt_idmateria.Text = ""
            Me.txt_descripcion.Text = ""
            Me.txt_carrera.Text = ""
            Me.cb_profesores.SelectedIndex = 0

        End If
    End Sub

    Private Sub Form_ModificacionMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim sql1 As String
        Dim tabla As DataTable
        tabla = New DataTable
        sql1 = "SELECT * FROM Profesores"
        ConsultarDatos(sql1, tabla)
        cb_profesores.DataSource = tabla
        cb_profesores.DisplayMember = "NombreApellido_P"   'lo q muestra
        cb_profesores.ValueMember = "NroLegajo_P"   'valor 
        cb_profesores.DropDownStyle = ComboBoxStyle.DropDownList
        cb_profesores.SelectedIndex = 0
    End Sub



    Private Sub btn_ModifProf_Click(sender As Object, e As EventArgs) Handles btn_ModifMaterias.Click
        Dim sql As String
        sql = "EXEC SP_ModifMaterias '" & txt_idmateria.Text.Trim & "' , '" & txt_descripcion.Text.Trim & "' , '" & txt_carrera.Text.Trim & "' , '" & cb_profesores.SelectedValue.ToString & "'"
        AltaBajaModific(sql)
        MessageBox.Show("Modificacion Materia Correcta")
        txt_idmateria.Text = ""
        txt_descripcion.Text = ""
        txt_carrera.Text = ""
        cb_profesores.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_ABMMateria.Show()
        Me.Hide()
    End Sub
End Class
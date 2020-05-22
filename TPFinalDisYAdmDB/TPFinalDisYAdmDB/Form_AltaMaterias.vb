Public Class Form_AltaMaterias

    Function validacion() As Boolean
        If txt_idmateria.Text <> "" Then
            If txt_descripcion.Text <> "" Then
                If txt_carrera.Text <> "" Then
                    Return True
                Else
                    MessageBox.Show("Complete correctamente la Carrera", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Complete correctamente la descripcion de la Materia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete correctamente el ID de la Materia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

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

    Private Sub Form_AltaMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim sql As String
        Dim tabla1 As DataTable
        tabla1 = New DataTable
        sql = "Select Top 1 IDMateria from Materias order by IDMateria desc"
        ConsultarDatos(sql, tabla1)
        Dim a As String
        a = tabla1.Rows.ToString
        txt_idmateria.Text = CInt(tabla1.Rows(0)("IDMateria").ToString) + 1
    End Sub


    Private Sub btn_AltaMateria_Click_1(sender As Object, e As EventArgs) Handles btn_AltaMateria.Click
        If validacion() = True Then
            If validarSQL() = True Then

                Dim sql As String
                Dim aux As String

                sql = "INSERT INTO Materias(IDMateria,DescripcionMateria,Carrera,NroLegajo_P) 
                VALUES ('" & txt_idmateria.Text.Trim & "' , '" & txt_descripcion.Text.Trim & "' , '" & txt_carrera.Text.Trim & "' , '" & cb_profesores.SelectedValue.ToString & "')"
                AltaBajaModific(sql)
                MessageBox.Show("Alta Materia Correcta")
                txt_idmateria.Text = ""
                txt_descripcion.Text = ""
                txt_carrera.Text = ""
                cb_profesores.SelectedIndex = 0

            Else
                MessageBox.Show("Error Id de Materia ya existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_volver_Click_1(sender As Object, e As EventArgs) Handles btn_volver.Click
        Form_ABMMateria.Show()
        Me.Hide()
    End Sub
End Class
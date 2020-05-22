Public Class FormBajaAlumno
    Private Sub FormBajaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub


    Private Sub btn_buscarlegajo_Click(sender As Object, e As EventArgs) Handles btn_buscarlegajo.Click
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Alumnos WHERE (NroLegajo_A = '" & txt_nrolegajo.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count > 0) Then

            Me.txt_nomapell.Text = tabla.Rows(0)("NombreApellido_A").ToString
            Me.txt_tipdoc.Text = tabla.Rows(0)("DNI_A").ToString
            Me.txt_fechanac.Text = tabla.Rows(0)("FechaNac_A").ToString
            Me.txt_mail.Text = tabla.Rows(0)("mail_A").ToString
            Me.txt_estcivil.Text = tabla.Rows(0)("EstadoCivil_A").ToString
            Me.txt_domicilio.Text = tabla.Rows(0)("Domicilio_A").ToString
            Me.txt_telefono.Text = tabla.Rows(0)("Telefono_A").ToString

        Else
            MessageBox.Show("Ningun Alumno pertenece a ese Legajo")
            Me.txt_nrolegajo.Text = ""
            Me.txt_nomapell.Text = ""
            Me.txt_tipdoc.Text = ""
            Me.txt_fechanac.Text = ""
            Me.txt_mail.Text = ""
            Me.txt_estcivil.Text = ""
            Me.txt_domicilio.Text = ""
            Me.txt_telefono.Text = ""
        End If
    End Sub


    Function validarSQL() As Boolean
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Alumnos WHERE (NroLegajo_A = '" & txt_nrolegajo.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count = 0) Then
            Return True
        End If
        Return False
    End Function

    Private Sub btn_BajaProfesor_Click(sender As Object, e As EventArgs) Handles btn_BajaProfesor.Click
        If validarSQL() = False Then
            Dim sql As String
            Dim tabla As DataTable
            tabla = New DataTable
            sql = "DELETE FROM Alumnos WHERE NroLegajo_A = '" & txt_nrolegajo.Text & "'"
            AltaBajaModific(sql)
            MessageBox.Show("Baja Alumno Correcto")
            Me.txt_nrolegajo.Text = ""
            Me.txt_nomapell.Text = ""
            Me.txt_tipdoc.Text = ""
            Me.txt_fechanac.Text = ""
            Me.txt_mail.Text = ""
            Me.txt_estcivil.Text = ""
            Me.txt_domicilio.Text = ""
            Me.txt_telefono.Text = ""
        Else
            MessageBox.Show("Ningun Alumno pertenece a ese Legajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_ABMAlumno.Show()
        Me.Hide()
    End Sub
End Class

'sql = "UPDATE Socios SET Nombre = '" & txt_nombre.Text & "', Apellido = '" & txt_apellido.Text & "', FechaNac = '" & FechaFY(dtm_fechanacimieto.Value) & "', FechaInc = '" & FechaFY(dtp_fechainscripcion.Value) & "', DNI = '" & txt_dni.Text & "', IDLocalidad = " & cmb_local.SelectedValue & " WHERE IDSocio = '" & IDSocioSeleccionado & "'"
'AltaBajaModific(sql)
'MessageBox.Show("Modificacion Correcta")
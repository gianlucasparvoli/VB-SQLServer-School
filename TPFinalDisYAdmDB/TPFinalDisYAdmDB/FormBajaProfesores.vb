Public Class FormBajaProfesores
    Private Sub FormBajaProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub


    Private Sub Btn_buscarlegajo_Click(sender As Object, e As EventArgs) Handles btn_buscarlegajo.Click
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Profesores WHERE (NroLegajo_P = '" & txt_nrolegajo.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count > 0) Then

            Me.txt_nomapell.Text = tabla.Rows(0)("NombreApellido_P").ToString
            Me.txt_tipdoc.Text = tabla.Rows(0)("DNI_P").ToString
            Me.txt_fechanac.Text = tabla.Rows(0)("FechaNac_P").ToString
            Me.txt_mail.Text = tabla.Rows(0)("mail_P").ToString
            Me.txt_estcivil.Text = tabla.Rows(0)("EstadoCivil_P").ToString
            Me.txt_domicilio.Text = tabla.Rows(0)("Domicilio_P").ToString
            Me.txt_telefono.Text = tabla.Rows(0)("Telefono_P").ToString
            txt_titulo.Text = tabla.Rows(0)("Titulo_P").ToString
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
            Me.txt_titulo.Text = ""
        End If
    End Sub

    Function validarSQL() As Boolean
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Profesores WHERE (NroLegajo_P = '" & txt_nrolegajo.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count = 0) Then
            Return True
        End If
        Return False
    End Function


    Private Sub btn_BajamProf_Click(sender As Object, e As EventArgs) Handles btn_BajamProf.Click
        If validarSQL() = False Then
            Dim sql As String
            Dim tabla As DataTable
            tabla = New DataTable
            sql = "DELETE FROM Profesores WHERE NroLegajo_P = '" & txt_nrolegajo.Text & "'"
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
            Me.txt_titulo.Text = ""
        Else
            MessageBox.Show("Ningun Alumno pertenece a ese Legajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_ABMProfesor.Show()
        Me.Hide()
    End Sub
End Class

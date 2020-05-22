Public Class Form_ModificacionAlumno
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Alumnos WHERE (NroLegajo_A = '" & txt_nrolegajo.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count > 0) Then

            Me.txt_nomapell.Text = tabla.Rows(0)("NombreApellido_A").ToString
            Me.cb_tipodoc.SelectedValue = tabla.Rows(0)("DNI_A")
            Me.dtp_fechanac.Value = tabla.Rows(0)("FechaNac_A").ToString
            Me.txt_mail.Text = tabla.Rows(0)("mail_A").ToString
            Me.cb_estadocivil.SelectedValue = tabla.Rows(0)("EstadoCivil_A")
            Me.txt_domicilio.Text = tabla.Rows(0)("Domicilio_A").ToString
            Me.txt_telefono.Text = tabla.Rows(0)("Telefono_A").ToString

        Else
            MessageBox.Show("Ningun Alumno pertenece a ese Legajo")
            Me.txt_nrolegajo.Text = ""
            Me.txt_nomapell.Text = ""
            Me.dtp_fechanac.Value = Today
            Me.txt_mail.Text = ""
            Me.txt_domicilio.Text = ""
            Me.txt_telefono.Text = ""
        End If
    End Sub

    Private Sub Form_ModificacionAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        dtp_fechanac.MaxDate = Today()

        cb_estadocivil.Items.Add("V")
        cb_estadocivil.Items.Add("S")
        cb_estadocivil.Items.Add("C")
        cb_estadocivil.Items.Add("D")
        cb_estadocivil.SelectedIndex = 0
        cb_estadocivil.DropDownStyle = ComboBoxStyle.DropDownList

        Dim sql1 As String
        Dim tabla As DataTable
        tabla = New DataTable
        sql1 = "SELECT * FROM TipoDocumento"
        ConsultarDatos(sql1, tabla)
        cb_tipodoc.DataSource = tabla
        cb_tipodoc.DisplayMember = "Descripcion_TipDoc"   'lo q muestra
        cb_tipodoc.ValueMember = "CodDoc"   'valor 
        cb_tipodoc.DropDownStyle = ComboBoxStyle.DropDownList
        cb_tipodoc.SelectedIndex = 0
    End Sub

    Private Sub btn_ModifMaterias_Click(sender As Object, e As EventArgs) Handles btn_ModifAlumnos.Click

        Dim sql As String
        sql = "EXEC SP_ModifAlumno '" & txt_nrolegajo.Text.Trim & "' , '" & txt_nomapell.Text.Trim & "' , '" & cb_tipodoc.SelectedValue.ToString & "' , '" & FechaInvertida(dtp_fechanac.Value).ToString & "' , '" & txt_mail.Text.Trim & "' , '" & cb_estadocivil.SelectedItem.ToString & "' , '" & txt_domicilio.Text.Trim & "' , '" & txt_telefono.Text.Trim & "'"
        AltaBajaModific(sql)
        MessageBox.Show("Modificacion Alumno Correcto")
        txt_nrolegajo.Text = ""
        txt_nomapell.Text = ""
        cb_tipodoc.SelectedIndex = 0
        dtp_fechanac.Value = Today()
        txt_mail.Text = ""
        cb_estadocivil.SelectedIndex = 0
        txt_domicilio.Text = ""
        txt_telefono.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_ABMAlumno.Show()
        Me.Hide()
    End Sub
End Class
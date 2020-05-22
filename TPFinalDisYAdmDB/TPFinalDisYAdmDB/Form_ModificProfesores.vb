Public Class Form_ModificProfesores
    Private Sub Btn_buscarlegajo_Click(sender As Object, e As EventArgs) Handles btn_buscarlegajo.Click
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Profesores WHERE (NroLegajo_P = '" & txt_nrolegajo.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count > 0) Then

            Me.txt_nomapell.Text = tabla.Rows(0)("NombreApellido_P").ToString
            Me.cb_tipodoc.SelectedValue = tabla.Rows(0)("DNI_P")
            Me.dtp_fechanac.Value = tabla.Rows(0)("FechaNac_P").ToString
            Me.txt_mail.Text = tabla.Rows(0)("mail_P").ToString
            Me.cb_estadocivil.SelectedValue = tabla.Rows(0)("EstadoCivil_P")
            Me.txt_domicilio.Text = tabla.Rows(0)("Domicilio_P").ToString
            Me.txt_telefono.Text = tabla.Rows(0)("Telefono_P").ToString
            Me.cb_titulo.SelectedValue = tabla.Rows(0)("Titulo_P")
        Else
            MessageBox.Show("Ningun Alumno pertenece a ese Legajo")
            Me.txt_nrolegajo.Text = ""
            Me.txt_nomapell.Text = ""
            Me.cb_tipodoc.SelectedIndex = 0
            Me.dtp_fechanac.Value = Today()
            Me.txt_mail.Text = ""
            Me.cb_estadocivil.SelectedIndex = 0
            Me.txt_domicilio.Text = ""
            Me.txt_telefono.Text = ""
            Me.cb_titulo.SelectedIndex = 0
        End If
    End Sub

    Private Sub Form_ModificProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim sql2 As String
        Dim tabla1 As DataTable
        tabla1 = New DataTable
        sql2 = "SELECT * FROM Titulos"
        ConsultarDatos(sql2, tabla1)
        cb_titulo.DataSource = tabla1
        cb_titulo.DisplayMember = "Decripcion_Titulos"   'lo q muestra
        cb_titulo.ValueMember = "IDTitulo"   'valor 
        cb_titulo.DropDownStyle = ComboBoxStyle.DropDownList
        cb_titulo.SelectedIndex = 0
    End Sub

    Private Sub Btn_AltaProfesor_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Btn_volver_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btn_ModifProf_Click(sender As Object, e As EventArgs) Handles btn_ModifProf.Click
        Dim sql As String
        sql = "EXEC SP_ModifProf '" & txt_nrolegajo.Text.Trim & "' , '" & txt_nomapell.Text.Trim & "' , '" & cb_tipodoc.SelectedValue.ToString & "' , '" & FechaInvertida(dtp_fechanac.Value).ToString & "' , '" & txt_mail.Text.Trim & "' , '" & cb_estadocivil.SelectedItem.ToString & "' , '" & txt_domicilio.Text.Trim & "' , '" & txt_telefono.Text.Trim & "','" & cb_titulo.SelectedValue.ToString & "'"
        AltaBajaModific(sql)
        MessageBox.Show("Modificacion Profesor Correcto")
        txt_nrolegajo.Text = ""
        txt_nomapell.Text = ""
        cb_tipodoc.SelectedIndex = 0
        dtp_fechanac.Value = Today()
        txt_mail.Text = ""
        cb_estadocivil.SelectedIndex = 0
        txt_domicilio.Text = ""
        txt_telefono.Text = ""
        cb_titulo.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_ABMProfesor.Show()
        Me.Hide()
    End Sub
End Class
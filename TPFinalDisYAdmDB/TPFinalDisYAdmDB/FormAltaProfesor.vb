Public Class FormAltaProfesor

    Function validacion() As Boolean
        If txt_nrolegajo.Text <> "" Then
            If txt_nomapell.Text <> "" Then
                If txt_mail.Text <> "" Then
                    If txt_domicilio.Text <> "" Then
                        If txt_telefono.Text <> "" Then
                            Return True
                        Else
                            MessageBox.Show("Complete correctamente el numero de telefono", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Complete correctamente el domicilio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Complete correctamente el Mail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Complete correctamente el Nombre y el Apellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete correctamente el numero de Legajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

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
    Private Sub FormAltaProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim sql3 As String
        Dim tabla3 As DataTable
        tabla3 = New DataTable
        sql3 = "Select Top 1 NroLegajo_P from Profesores order by NroLegajo_P desc"
        ConsultarDatos(sql3, tabla3)
        txt_nrolegajo.Text = CInt(tabla3.Rows(0)("NroLegajo_P").ToString) + 1
    End Sub


    Private Sub btn_AltaProfesor_Click_1(sender As Object, e As EventArgs) Handles btn_AltaProfesor.Click
        If validacion() = True Then
            If validarSQL() = True Then

                Dim sql As String
                sql = "INSERT INTO Profesores(NroLegajo_P,NombreApellido_P,DNI_P,FechaNac_P,mail_P,EstadoCivil_P,Domicilio_P,Telefono_P,Titulo_P)
                VALUES ('" & txt_nrolegajo.Text.Trim & "' , '" & txt_nomapell.Text.Trim & "' , '" & cb_tipodoc.SelectedValue.ToString & "' , '" & FechaInvertida(dtp_fechanac.Value).ToString & "' , '" & txt_mail.Text.Trim & "' , '" & cb_estadocivil.SelectedItem.ToString & "' , '" & txt_domicilio.Text.Trim & "' , '" & txt_telefono.Text.Trim & "','" & cb_titulo.SelectedValue.ToString & "')"
                AltaBajaModific(sql)
                MessageBox.Show("Alta Profesor Correcto")
                txt_nrolegajo.Text = ""
                txt_nomapell.Text = ""
                cb_tipodoc.SelectedIndex = 0
                dtp_fechanac.Value = Today()
                txt_mail.Text = ""
                cb_estadocivil.SelectedIndex = 0
                txt_domicilio.Text = ""
                txt_telefono.Text = ""
                cb_titulo.SelectedIndex = 0

            Else
                MessageBox.Show("Error Legajo ya existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Form_ABMProfesor.Show()
        Me.Hide()
    End Sub
End Class
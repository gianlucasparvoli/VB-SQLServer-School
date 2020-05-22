Public Class FormAltaAlumno

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

        sql = "SELECT * FROM Alumnos WHERE (NroLegajo_A = '" & txt_nrolegajo.Text & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count = 0) Then
            Return True
        End If
        Return False
    End Function

    Private Sub FormAltaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim sql As String
        Dim tabla1 As DataTable
        tabla1 = New DataTable
        sql = "Select Top 1 NroLegajo_A from Alumnos order by NroLegajo_A desc"
        ConsultarDatos(sql, tabla1)
        Dim a As String
        a = tabla1.Rows.ToString
        txt_nrolegajo.Text = CInt(tabla1.Rows(0)("NroLegajo_A").ToString) + 1

    End Sub
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Form_ABMAlumno.Show()
        Me.Hide()
    End Sub

    Private Sub btn_AltaAlumno_Click(sender As Object, e As EventArgs) Handles btn_AltaAlumno.Click
        If validacion() = True Then
            If validarSQL() = True Then


                Dim sql As String
                sql = "INSERT INTO Alumnos (NroLegajo_A,NombreApellido_A,DNI_A,FechaNac_A,mail_A,EstadoCivil_A,Domicilio_A,Telefono_A)
                VALUES ('" & txt_nrolegajo.Text.Trim & "' , '" & txt_nomapell.Text.Trim & "' , '" & cb_tipodoc.SelectedValue.ToString & "' , '" & FechaInvertida(dtp_fechanac.Value).ToString & "' , '" & txt_mail.Text.Trim & "' , '" & cb_estadocivil.SelectedItem.ToString & "' , '" & txt_domicilio.Text.Trim & "' , '" & txt_telefono.Text.Trim & "')"
                AltaBajaModific(sql)
                MessageBox.Show("Alta Alumno Correcto")
                txt_nrolegajo.Text = ""
                txt_nomapell.Text = ""
                cb_tipodoc.SelectedIndex = 0
                dtp_fechanac.Value = Today()
                txt_mail.Text = ""
                cb_estadocivil.SelectedIndex = 0
                txt_domicilio.Text = ""
                txt_telefono.Text = ""

            Else
                MessageBox.Show("Error Legajo ya existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class
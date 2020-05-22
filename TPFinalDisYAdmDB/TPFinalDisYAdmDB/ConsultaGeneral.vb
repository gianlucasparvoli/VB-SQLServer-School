Imports excelapp = Microsoft.Office.Interop.Excel
Public Class ConsultaGeneral

    Private Sub ConsultaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        cb_opciones.Items.Add("Alumnos")
        cb_opciones.Items.Add("Examenes")
        cb_opciones.Items.Add("Materias")
        cb_opciones.Items.Add("Planificacion")
        cb_opciones.Items.Add("Profesores")
        cb_opciones.Items.Add("TipoDocumento")
        cb_opciones.Items.Add("Titulos")
        cb_opciones.Items.Add("Turnos")
        cb_opciones.SelectedIndex = 0
        cb_opciones.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub

    Private Sub Cb_opciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_opciones.SelectedIndexChanged
        Dim tabla1 As DataTable = New DataTable
        Dim sql As String
        sql = VistasSQL()
        ConsultarDatos(sql, tabla1)
        dgv_consulta.DataSource = tabla1
        dgv_consulta.ReadOnly = True
        dgv_consulta.AllowUserToDeleteRows = False
        dgv_consulta.AllowUserToAddRows = False

        Dim Cuenta As Integer = 1
        ProgressBar1.Maximum = dgv_consulta.Rows.Count()
        For Each Row In dgv_consulta.Rows
            ProgressBar1.Value = Cuenta
            Cuenta = Cuenta + 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        Dim excel As excelapp.Application 'creaamos aplicacion
        Dim libro As excelapp.Workbook 'creamos el libro de excel
        Dim hoja As excelapp.Worksheet 'creamos la hoja de excel

        SaveFileDialog1.DefaultExt = ".xlsx"
        SaveFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
        SaveFileDialog1.FilterIndex = 0
        SaveFileDialog1.Title = "Seleccione un archivo"
        SaveFileDialog1.DefaultExt = ".xlsx"
        SaveFileDialog1.OverwritePrompt = False

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            excel = New excelapp.Application    'generar y abrir la aplicacion excel
            libro = excel.Workbooks.Add()   'agregamos un libro al proyecto
            hoja = libro.Worksheets.Add()   'agregamos una hoja al libro

            excel.DisplayAlerts = False
            excel.Visible = False

            hoja.Range("A1:J1").Font.Size = 14 'tamaño de letra
            hoja.Range("A1:J1").Font.Name = "Arial"    'tipo de letra
            hoja.Range("A1:J1").Font.Bold = True   'negrita

            Dim h() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
            For z = 0 To (dgv_consulta.Columns.Count - 1)
                hoja.Range(h(z) + "1").Value = dgv_consulta.Columns(z).Name.ToString
            Next z

            Dim v() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
            For i = 0 To (dgv_consulta.Rows.Count - 1)
                For c = 0 To (dgv_consulta.Columns.Count - 1)
                    hoja.Range(v(c) + (i + 2).ToString).Value = dgv_consulta.Rows(i).Cells(c).Value.ToString
                Next c
            Next i

            hoja.Columns("A:J").EntireColumn.AutoFit()
            libro.SaveAs(SaveFileDialog1.FileName)

            ' Cerrar libro y aplicación
            libro.Close()
            excel.Quit()
            hoja = Nothing
            libro = Nothing
            excel = Nothing
        End If
    End Sub

    Private Function VistasSQL() As String
        Dim var As String
        If cb_opciones.SelectedItem.ToString = "Alumnos" Then
            var = "SELECT * FROM VISTA_ConsultaAlumnos"
            Return var
        ElseIf cb_opciones.SelectedItem.ToString = "Examenes" Then
            var = "SELECT * FROM VISTA_ConsultaExamenes"
            Return var
        ElseIf cb_opciones.SelectedItem.ToString = "Materias" Then
            var = "SELECT * FROM VISTA_ConsultaMaterias"
            Return var
        ElseIf cb_opciones.SelectedItem.ToString = "Planificacion" Then
            var = "SELECT * FROM VISTA_ConsultaPlanificacion"
            Return var
        ElseIf cb_opciones.SelectedItem.ToString = "Profesores" Then
            var = "SELECT * FROM VISTA_ConsultaProfesores"
            Return var
        ElseIf cb_opciones.SelectedItem.ToString = "TipoDocumento" Then
            var = "SELECT * FROM VISTA_ConsultaTipoDocumento"
            Return var
        ElseIf cb_opciones.SelectedItem.ToString = "Titulos" Then
            var = "SELECT * FROM VISTA_ConsultaTitulos"
            Return var
        ElseIf cb_opciones.SelectedItem.ToString = "Turnos" Then
            var = "SELECT * FROM VISTA_ConsultaTurnos"
            Return var
        Else
            var = ""
            Return var
        End If
    End Function

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        FormMenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class
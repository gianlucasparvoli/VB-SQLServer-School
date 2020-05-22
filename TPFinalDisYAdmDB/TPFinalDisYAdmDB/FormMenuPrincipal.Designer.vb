<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_ABMAlumno = New System.Windows.Forms.Button()
        Me.btn_ABMMateria = New System.Windows.Forms.Button()
        Me.btn_ABMProfesor = New System.Windows.Forms.Button()
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.brn_salir = New System.Windows.Forms.Button()
        Me.btn_consultageneral = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_ABMAlumno
        '
        Me.btn_ABMAlumno.BackColor = System.Drawing.SystemColors.Menu
        Me.btn_ABMAlumno.Location = New System.Drawing.Point(13, 101)
        Me.btn_ABMAlumno.Name = "btn_ABMAlumno"
        Me.btn_ABMAlumno.Size = New System.Drawing.Size(75, 59)
        Me.btn_ABMAlumno.TabIndex = 0
        Me.btn_ABMAlumno.Text = "ABM Alumno"
        Me.btn_ABMAlumno.UseVisualStyleBackColor = False
        '
        'btn_ABMMateria
        '
        Me.btn_ABMMateria.BackColor = System.Drawing.SystemColors.Menu
        Me.btn_ABMMateria.Location = New System.Drawing.Point(109, 101)
        Me.btn_ABMMateria.Name = "btn_ABMMateria"
        Me.btn_ABMMateria.Size = New System.Drawing.Size(75, 59)
        Me.btn_ABMMateria.TabIndex = 1
        Me.btn_ABMMateria.Text = "ABM Materia"
        Me.btn_ABMMateria.UseVisualStyleBackColor = False
        '
        'btn_ABMProfesor
        '
        Me.btn_ABMProfesor.BackColor = System.Drawing.SystemColors.Menu
        Me.btn_ABMProfesor.Location = New System.Drawing.Point(201, 100)
        Me.btn_ABMProfesor.Name = "btn_ABMProfesor"
        Me.btn_ABMProfesor.Size = New System.Drawing.Size(75, 60)
        Me.btn_ABMProfesor.TabIndex = 2
        Me.btn_ABMProfesor.Text = "ABM Profesor"
        Me.btn_ABMProfesor.UseVisualStyleBackColor = False
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(55, 30)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(274, 33)
        Me.lbl_menuprincipal.TabIndex = 3
        Me.lbl_menuprincipal.Text = "MENU PRINCIPAL"
        Me.lbl_menuprincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'brn_salir
        '
        Me.brn_salir.BackColor = System.Drawing.SystemColors.Menu
        Me.brn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.brn_salir.FlatAppearance.BorderSize = 5
        Me.brn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.brn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.brn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.brn_salir.Location = New System.Drawing.Point(12, 176)
        Me.brn_salir.Name = "brn_salir"
        Me.brn_salir.Size = New System.Drawing.Size(360, 23)
        Me.brn_salir.TabIndex = 4
        Me.brn_salir.Text = "Salir"
        Me.brn_salir.UseVisualStyleBackColor = False
        '
        'btn_consultageneral
        '
        Me.btn_consultageneral.BackColor = System.Drawing.SystemColors.Menu
        Me.btn_consultageneral.Location = New System.Drawing.Point(297, 101)
        Me.btn_consultageneral.Name = "btn_consultageneral"
        Me.btn_consultageneral.Size = New System.Drawing.Size(75, 60)
        Me.btn_consultageneral.TabIndex = 5
        Me.btn_consultageneral.Text = "Consulta general"
        Me.btn_consultageneral.UseVisualStyleBackColor = False
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(386, 211)
        Me.Controls.Add(Me.btn_consultageneral)
        Me.Controls.Add(Me.brn_salir)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Controls.Add(Me.btn_ABMProfesor)
        Me.Controls.Add(Me.btn_ABMMateria)
        Me.Controls.Add(Me.btn_ABMAlumno)
        Me.Name = "FormMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ABMAlumno As Button
    Friend WithEvents btn_ABMMateria As Button
    Friend WithEvents btn_ABMProfesor As Button
    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents brn_salir As Button
    Friend WithEvents btn_consultageneral As Button
End Class

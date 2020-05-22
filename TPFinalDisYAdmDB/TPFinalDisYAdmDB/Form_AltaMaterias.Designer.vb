<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AltaMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AltaMaterias))
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.cb_profesores = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_idmateria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_carrera = New System.Windows.Forms.TextBox()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_AltaMateria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Reem Kufi", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(12, 9)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(258, 56)
        Me.lbl_menuprincipal.TabIndex = 60
        Me.lbl_menuprincipal.Text = "ALTA MATERIAS"
        '
        'cb_profesores
        '
        Me.cb_profesores.FormattingEnabled = True
        Me.cb_profesores.Location = New System.Drawing.Point(122, 146)
        Me.cb_profesores.Name = "cb_profesores"
        Me.cb_profesores.Size = New System.Drawing.Size(144, 21)
        Me.cb_profesores.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Profesores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Carrera"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(122, 94)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(144, 20)
        Me.txt_descripcion.TabIndex = 64
        '
        'txt_idmateria
        '
        Me.txt_idmateria.Location = New System.Drawing.Point(122, 68)
        Me.txt_idmateria.Name = "txt_idmateria"
        Me.txt_idmateria.Size = New System.Drawing.Size(144, 20)
        Me.txt_idmateria.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "ID Materia"
        '
        'txt_carrera
        '
        Me.txt_carrera.Location = New System.Drawing.Point(122, 120)
        Me.txt_carrera.Name = "txt_carrera"
        Me.txt_carrera.Size = New System.Drawing.Size(144, 20)
        Me.txt_carrera.TabIndex = 76
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(17, 173)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(129, 34)
        Me.btn_volver.TabIndex = 78
        Me.btn_volver.Text = "<-- Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_AltaMateria
        '
        Me.btn_AltaMateria.Image = CType(resources.GetObject("btn_AltaMateria.Image"), System.Drawing.Image)
        Me.btn_AltaMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AltaMateria.Location = New System.Drawing.Point(152, 173)
        Me.btn_AltaMateria.Name = "btn_AltaMateria"
        Me.btn_AltaMateria.Size = New System.Drawing.Size(114, 34)
        Me.btn_AltaMateria.TabIndex = 77
        Me.btn_AltaMateria.Text = "Aceptar"
        Me.btn_AltaMateria.UseVisualStyleBackColor = True
        '
        'Form_AltaMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(280, 220)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_AltaMateria)
        Me.Controls.Add(Me.txt_carrera)
        Me.Controls.Add(Me.cb_profesores)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_idmateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Name = "Form_AltaMaterias"
        Me.Text = "Alta Materias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents cb_profesores As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_idmateria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_carrera As TextBox
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_AltaMateria As Button
End Class

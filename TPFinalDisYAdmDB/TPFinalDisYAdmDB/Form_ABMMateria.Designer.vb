<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ABMMateria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ABMMateria))
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_modifmateria = New System.Windows.Forms.Button()
        Me.btn_bajamateria = New System.Windows.Forms.Button()
        Me.btn_altamateria = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Reem Kufi", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(6, 9)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(278, 56)
        Me.lbl_menuprincipal.TabIndex = 9
        Me.lbl_menuprincipal.Text = "MENU MATERIAS"
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(44, 304)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(215, 23)
        Me.btn_volver.TabIndex = 8
        Me.btn_volver.Text = "<-- Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_modifmateria
        '
        Me.btn_modifmateria.Location = New System.Drawing.Point(193, 211)
        Me.btn_modifmateria.Name = "btn_modifmateria"
        Me.btn_modifmateria.Size = New System.Drawing.Size(68, 74)
        Me.btn_modifmateria.TabIndex = 7
        Me.btn_modifmateria.Text = "Modific Materia"
        Me.btn_modifmateria.UseVisualStyleBackColor = True
        '
        'btn_bajamateria
        '
        Me.btn_bajamateria.Location = New System.Drawing.Point(119, 211)
        Me.btn_bajamateria.Name = "btn_bajamateria"
        Me.btn_bajamateria.Size = New System.Drawing.Size(68, 74)
        Me.btn_bajamateria.TabIndex = 6
        Me.btn_bajamateria.Text = "Baja Materia"
        Me.btn_bajamateria.UseVisualStyleBackColor = True
        '
        'btn_altamateria
        '
        Me.btn_altamateria.Location = New System.Drawing.Point(45, 211)
        Me.btn_altamateria.Name = "btn_altamateria"
        Me.btn_altamateria.Size = New System.Drawing.Size(68, 74)
        Me.btn_altamateria.TabIndex = 5
        Me.btn_altamateria.Text = "Alta Materia"
        Me.btn_altamateria.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 137)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form_ABMMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(296, 337)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_modifmateria)
        Me.Controls.Add(Me.btn_bajamateria)
        Me.Controls.Add(Me.btn_altamateria)
        Me.Name = "Form_ABMMateria"
        Me.Text = "Materias"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_modifmateria As Button
    Friend WithEvents btn_bajamateria As Button
    Friend WithEvents btn_altamateria As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

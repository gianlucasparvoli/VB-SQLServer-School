<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ABMAlumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ABMAlumno))
        Me.btn_altaalumno = New System.Windows.Forms.Button()
        Me.btn_bajaalumno = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_altaalumno
        '
        Me.btn_altaalumno.Location = New System.Drawing.Point(17, 207)
        Me.btn_altaalumno.Name = "btn_altaalumno"
        Me.btn_altaalumno.Size = New System.Drawing.Size(68, 74)
        Me.btn_altaalumno.TabIndex = 0
        Me.btn_altaalumno.Text = "Alta Alumno"
        Me.btn_altaalumno.UseVisualStyleBackColor = True
        '
        'btn_bajaalumno
        '
        Me.btn_bajaalumno.Location = New System.Drawing.Point(91, 207)
        Me.btn_bajaalumno.Name = "btn_bajaalumno"
        Me.btn_bajaalumno.Size = New System.Drawing.Size(68, 74)
        Me.btn_bajaalumno.TabIndex = 1
        Me.btn_bajaalumno.Text = "Baja Alumno"
        Me.btn_bajaalumno.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(165, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 74)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modific Alumno"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(16, 300)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(215, 23)
        Me.btn_volver.TabIndex = 3
        Me.btn_volver.Text = "<-- Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Reem Kufi", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(-4, 9)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(265, 56)
        Me.lbl_menuprincipal.TabIndex = 4
        Me.lbl_menuprincipal.Text = "MENU ALUMNO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 133)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form_ABMAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(256, 334)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_bajaalumno)
        Me.Controls.Add(Me.btn_altaalumno)
        Me.MaximumSize = New System.Drawing.Size(272, 373)
        Me.MinimumSize = New System.Drawing.Size(272, 373)
        Me.Name = "Form_ABMAlumno"
        Me.Text = "Alumnos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_altaalumno As Button
    Friend WithEvents btn_bajaalumno As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

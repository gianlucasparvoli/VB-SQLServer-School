<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ABMProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ABMProfesor))
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_modificprofesor = New System.Windows.Forms.Button()
        Me.btn_bajaprofesor = New System.Windows.Forms.Button()
        Me.btn_altaprofesor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(-4, 9)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(284, 33)
        Me.lbl_menuprincipal.TabIndex = 9
        Me.lbl_menuprincipal.Text = "MENU PROFESOR"
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(27, 273)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(215, 23)
        Me.btn_volver.TabIndex = 8
        Me.btn_volver.Text = "<-- Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_modificprofesor
        '
        Me.btn_modificprofesor.Location = New System.Drawing.Point(176, 180)
        Me.btn_modificprofesor.Name = "btn_modificprofesor"
        Me.btn_modificprofesor.Size = New System.Drawing.Size(68, 74)
        Me.btn_modificprofesor.TabIndex = 7
        Me.btn_modificprofesor.Text = "Modific Profesor"
        Me.btn_modificprofesor.UseVisualStyleBackColor = True
        '
        'btn_bajaprofesor
        '
        Me.btn_bajaprofesor.Location = New System.Drawing.Point(102, 180)
        Me.btn_bajaprofesor.Name = "btn_bajaprofesor"
        Me.btn_bajaprofesor.Size = New System.Drawing.Size(68, 74)
        Me.btn_bajaprofesor.TabIndex = 6
        Me.btn_bajaprofesor.Text = "Baja Profesor"
        Me.btn_bajaprofesor.UseVisualStyleBackColor = True
        '
        'btn_altaprofesor
        '
        Me.btn_altaprofesor.Location = New System.Drawing.Point(28, 180)
        Me.btn_altaprofesor.Name = "btn_altaprofesor"
        Me.btn_altaprofesor.Size = New System.Drawing.Size(68, 74)
        Me.btn_altaprofesor.TabIndex = 5
        Me.btn_altaprofesor.Text = "Alta Profesor"
        Me.btn_altaprofesor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(71, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 129)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form_ABMProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(278, 306)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_modificprofesor)
        Me.Controls.Add(Me.btn_bajaprofesor)
        Me.Controls.Add(Me.btn_altaprofesor)
        Me.Name = "Form_ABMProfesor"
        Me.Text = "Profesores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_modificprofesor As Button
    Friend WithEvents btn_bajaprofesor As Button
    Friend WithEvents btn_altaprofesor As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

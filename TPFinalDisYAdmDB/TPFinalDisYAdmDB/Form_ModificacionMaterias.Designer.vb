﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ModificacionMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ModificacionMaterias))
        Me.txt_carrera = New System.Windows.Forms.TextBox()
        Me.cb_profesores = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_idmateria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.btn_buscaridmat = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_ModifMaterias = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_carrera
        '
        Me.txt_carrera.Location = New System.Drawing.Point(122, 120)
        Me.txt_carrera.Name = "txt_carrera"
        Me.txt_carrera.Size = New System.Drawing.Size(144, 20)
        Me.txt_carrera.TabIndex = 87
        '
        'cb_profesores
        '
        Me.cb_profesores.FormattingEnabled = True
        Me.cb_profesores.Location = New System.Drawing.Point(122, 146)
        Me.cb_profesores.Name = "cb_profesores"
        Me.cb_profesores.Size = New System.Drawing.Size(144, 21)
        Me.cb_profesores.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Profesores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Carrera"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(122, 94)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(144, 20)
        Me.txt_descripcion.TabIndex = 83
        '
        'txt_idmateria
        '
        Me.txt_idmateria.Location = New System.Drawing.Point(122, 68)
        Me.txt_idmateria.Name = "txt_idmateria"
        Me.txt_idmateria.Size = New System.Drawing.Size(75, 20)
        Me.txt_idmateria.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "ID Materia"
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Reem Kufi", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(-8, 6)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(288, 56)
        Me.lbl_menuprincipal.TabIndex = 79
        Me.lbl_menuprincipal.Text = "MODIF MATERIAS"
        '
        'btn_buscaridmat
        '
        Me.btn_buscaridmat.Location = New System.Drawing.Point(203, 65)
        Me.btn_buscaridmat.Name = "btn_buscaridmat"
        Me.btn_buscaridmat.Size = New System.Drawing.Size(63, 23)
        Me.btn_buscaridmat.TabIndex = 89
        Me.btn_buscaridmat.Text = "Buscar"
        Me.btn_buscaridmat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 34)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "<-- Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_ModifMaterias
        '
        Me.btn_ModifMaterias.Image = CType(resources.GetObject("btn_ModifMaterias.Image"), System.Drawing.Image)
        Me.btn_ModifMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ModifMaterias.Location = New System.Drawing.Point(152, 173)
        Me.btn_ModifMaterias.Name = "btn_ModifMaterias"
        Me.btn_ModifMaterias.Size = New System.Drawing.Size(114, 34)
        Me.btn_ModifMaterias.TabIndex = 90
        Me.btn_ModifMaterias.Text = "Modificar"
        Me.btn_ModifMaterias.UseVisualStyleBackColor = True
        '
        'Form_ModificacionMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(278, 221)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_ModifMaterias)
        Me.Controls.Add(Me.btn_buscaridmat)
        Me.Controls.Add(Me.txt_carrera)
        Me.Controls.Add(Me.cb_profesores)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_idmateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Name = "Form_ModificacionMaterias"
        Me.Text = "Form_ModificacionMaterias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_carrera As TextBox
    Friend WithEvents cb_profesores As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_idmateria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents btn_buscaridmat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_ModifMaterias As Button
End Class

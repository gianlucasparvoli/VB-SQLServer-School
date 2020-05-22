<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaProfesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBajaProfesores))
        Me.btn_buscarlegajo = New System.Windows.Forms.Button()
        Me.txt_estcivil = New System.Windows.Forms.TextBox()
        Me.txt_fechanac = New System.Windows.Forms.TextBox()
        Me.txt_tipdoc = New System.Windows.Forms.TextBox()
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nomapell = New System.Windows.Forms.TextBox()
        Me.txt_nrolegajo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_BajamProf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_buscarlegajo
        '
        Me.btn_buscarlegajo.Location = New System.Drawing.Point(194, 81)
        Me.btn_buscarlegajo.Name = "btn_buscarlegajo"
        Me.btn_buscarlegajo.Size = New System.Drawing.Size(68, 23)
        Me.btn_buscarlegajo.TabIndex = 84
        Me.btn_buscarlegajo.Text = "Buscar"
        Me.btn_buscarlegajo.UseVisualStyleBackColor = True
        '
        'txt_estcivil
        '
        Me.txt_estcivil.Location = New System.Drawing.Point(116, 213)
        Me.txt_estcivil.Name = "txt_estcivil"
        Me.txt_estcivil.ReadOnly = True
        Me.txt_estcivil.Size = New System.Drawing.Size(144, 20)
        Me.txt_estcivil.TabIndex = 83
        '
        'txt_fechanac
        '
        Me.txt_fechanac.Location = New System.Drawing.Point(117, 163)
        Me.txt_fechanac.Name = "txt_fechanac"
        Me.txt_fechanac.ReadOnly = True
        Me.txt_fechanac.Size = New System.Drawing.Size(144, 20)
        Me.txt_fechanac.TabIndex = 82
        '
        'txt_tipdoc
        '
        Me.txt_tipdoc.Location = New System.Drawing.Point(117, 137)
        Me.txt_tipdoc.Name = "txt_tipdoc"
        Me.txt_tipdoc.ReadOnly = True
        Me.txt_tipdoc.Size = New System.Drawing.Size(144, 20)
        Me.txt_tipdoc.TabIndex = 81
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(5, 22)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(271, 33)
        Me.lbl_menuprincipal.TabIndex = 80
        Me.lbl_menuprincipal.Text = "BAJA PROFESOR"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(116, 265)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.ReadOnly = True
        Me.txt_telefono.Size = New System.Drawing.Size(144, 20)
        Me.txt_telefono.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Telefono"
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(116, 239)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.ReadOnly = True
        Me.txt_domicilio.Size = New System.Drawing.Size(144, 20)
        Me.txt_domicilio.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Domicilio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Estado Civil"
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(116, 187)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.ReadOnly = True
        Me.txt_mail.Size = New System.Drawing.Size(144, 20)
        Me.txt_mail.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Tipo Documento"
        '
        'txt_nomapell
        '
        Me.txt_nomapell.Location = New System.Drawing.Point(116, 109)
        Me.txt_nomapell.Name = "txt_nomapell"
        Me.txt_nomapell.ReadOnly = True
        Me.txt_nomapell.Size = New System.Drawing.Size(144, 20)
        Me.txt_nomapell.TabIndex = 68
        '
        'txt_nrolegajo
        '
        Me.txt_nrolegajo.Location = New System.Drawing.Point(116, 83)
        Me.txt_nrolegajo.Name = "txt_nrolegajo"
        Me.txt_nrolegajo.Size = New System.Drawing.Size(72, 20)
        Me.txt_nrolegajo.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Nombre Y Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Nro Legajo"
        '
        'txt_titulo
        '
        Me.txt_titulo.Location = New System.Drawing.Point(116, 291)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.ReadOnly = True
        Me.txt_titulo.Size = New System.Drawing.Size(144, 20)
        Me.txt_titulo.TabIndex = 86
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Titulo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 34)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "<-- Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_BajamProf
        '
        Me.btn_BajamProf.Image = CType(resources.GetObject("btn_BajamProf.Image"), System.Drawing.Image)
        Me.btn_BajamProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_BajamProf.Location = New System.Drawing.Point(146, 317)
        Me.btn_BajamProf.Name = "btn_BajamProf"
        Me.btn_BajamProf.Size = New System.Drawing.Size(114, 34)
        Me.btn_BajamProf.TabIndex = 92
        Me.btn_BajamProf.Text = "Eliminar"
        Me.btn_BajamProf.UseVisualStyleBackColor = True
        '
        'FormBajaProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(278, 364)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_BajamProf)
        Me.Controls.Add(Me.txt_titulo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_buscarlegajo)
        Me.Controls.Add(Me.txt_estcivil)
        Me.Controls.Add(Me.txt_fechanac)
        Me.Controls.Add(Me.txt_tipdoc)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nomapell)
        Me.Controls.Add(Me.txt_nrolegajo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBajaProfesores"
        Me.Text = "Baja Profesores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscarlegajo As Button
    Friend WithEvents txt_estcivil As TextBox
    Friend WithEvents txt_fechanac As TextBox
    Friend WithEvents txt_tipdoc As TextBox
    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_domicilio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_mail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nomapell As TextBox
    Friend WithEvents txt_nrolegajo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_BajamProf As Button
End Class

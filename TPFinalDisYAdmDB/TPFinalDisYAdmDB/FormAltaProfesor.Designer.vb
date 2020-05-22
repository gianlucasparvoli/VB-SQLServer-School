<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAltaProfesor))
        Me.lbl_menuprincipal = New System.Windows.Forms.Label()
        Me.cb_tipodoc = New System.Windows.Forms.ComboBox()
        Me.dtp_fechanac = New System.Windows.Forms.DateTimePicker()
        Me.cb_estadocivil = New System.Windows.Forms.ComboBox()
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
        Me.cb_titulo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_AltaProfesor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Reem Kufi", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(5, 9)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(270, 56)
        Me.lbl_menuprincipal.TabIndex = 60
        Me.lbl_menuprincipal.Text = "ALTA PROFESOR"
        '
        'cb_tipodoc
        '
        Me.cb_tipodoc.FormattingEnabled = True
        Me.cb_tipodoc.Location = New System.Drawing.Point(117, 128)
        Me.cb_tipodoc.Name = "cb_tipodoc"
        Me.cb_tipodoc.Size = New System.Drawing.Size(144, 21)
        Me.cb_tipodoc.TabIndex = 59
        '
        'dtp_fechanac
        '
        Me.dtp_fechanac.Location = New System.Drawing.Point(117, 155)
        Me.dtp_fechanac.Name = "dtp_fechanac"
        Me.dtp_fechanac.Size = New System.Drawing.Size(144, 20)
        Me.dtp_fechanac.TabIndex = 58
        '
        'cb_estadocivil
        '
        Me.cb_estadocivil.FormattingEnabled = True
        Me.cb_estadocivil.Location = New System.Drawing.Point(117, 208)
        Me.cb_estadocivil.Name = "cb_estadocivil"
        Me.cb_estadocivil.Size = New System.Drawing.Size(144, 21)
        Me.cb_estadocivil.TabIndex = 55
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(117, 259)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(144, 20)
        Me.txt_telefono.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Telefono"
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(117, 233)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(144, 20)
        Me.txt_domicilio.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Domicilio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Estado Civil"
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(117, 181)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(144, 20)
        Me.txt_mail.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Tipo Documento"
        '
        'txt_nomapell
        '
        Me.txt_nomapell.Location = New System.Drawing.Point(117, 103)
        Me.txt_nomapell.Name = "txt_nomapell"
        Me.txt_nomapell.Size = New System.Drawing.Size(144, 20)
        Me.txt_nomapell.TabIndex = 45
        '
        'txt_nrolegajo
        '
        Me.txt_nrolegajo.Location = New System.Drawing.Point(117, 77)
        Me.txt_nrolegajo.Name = "txt_nrolegajo"
        Me.txt_nrolegajo.Size = New System.Drawing.Size(144, 20)
        Me.txt_nrolegajo.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nombre Y Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nro Legajo"
        '
        'cb_titulo
        '
        Me.cb_titulo.FormattingEnabled = True
        Me.cb_titulo.Location = New System.Drawing.Point(117, 285)
        Me.cb_titulo.Name = "cb_titulo"
        Me.cb_titulo.Size = New System.Drawing.Size(144, 21)
        Me.cb_titulo.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Titulo"
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(12, 312)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(129, 34)
        Me.btn_volver.TabIndex = 64
        Me.btn_volver.Text = "<-- Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_AltaProfesor
        '
        Me.btn_AltaProfesor.Image = CType(resources.GetObject("btn_AltaProfesor.Image"), System.Drawing.Image)
        Me.btn_AltaProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AltaProfesor.Location = New System.Drawing.Point(147, 312)
        Me.btn_AltaProfesor.Name = "btn_AltaProfesor"
        Me.btn_AltaProfesor.Size = New System.Drawing.Size(114, 34)
        Me.btn_AltaProfesor.TabIndex = 63
        Me.btn_AltaProfesor.Text = "Aceptar"
        Me.btn_AltaProfesor.UseVisualStyleBackColor = True
        '
        'FormAltaProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(278, 361)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_AltaProfesor)
        Me.Controls.Add(Me.cb_titulo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_menuprincipal)
        Me.Controls.Add(Me.cb_tipodoc)
        Me.Controls.Add(Me.dtp_fechanac)
        Me.Controls.Add(Me.cb_estadocivil)
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
        Me.Name = "FormAltaProfesor"
        Me.Text = "Alta Profesor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menuprincipal As Label
    Friend WithEvents cb_tipodoc As ComboBox
    Friend WithEvents dtp_fechanac As DateTimePicker
    Friend WithEvents cb_estadocivil As ComboBox
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
    Friend WithEvents cb_titulo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_AltaProfesor As Button
End Class

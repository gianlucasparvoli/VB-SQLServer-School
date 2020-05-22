<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBajaAlumno))
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
        Me.txt_fechanac = New System.Windows.Forms.TextBox()
        Me.txt_tipdoc = New System.Windows.Forms.TextBox()
        Me.txt_estcivil = New System.Windows.Forms.TextBox()
        Me.btn_buscarlegajo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_BajaProfesor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_menuprincipal
        '
        Me.lbl_menuprincipal.AutoSize = True
        Me.lbl_menuprincipal.Font = New System.Drawing.Font("Reem Kufi", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_menuprincipal.Location = New System.Drawing.Point(12, 9)
        Me.lbl_menuprincipal.Name = "lbl_menuprincipal"
        Me.lbl_menuprincipal.Size = New System.Drawing.Size(243, 56)
        Me.lbl_menuprincipal.TabIndex = 60
        Me.lbl_menuprincipal.Text = "BAJA ALUMNO"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(117, 259)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.ReadOnly = True
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
        Me.txt_domicilio.ReadOnly = True
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
        Me.txt_mail.ReadOnly = True
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
        Me.txt_nomapell.ReadOnly = True
        Me.txt_nomapell.Size = New System.Drawing.Size(144, 20)
        Me.txt_nomapell.TabIndex = 45
        '
        'txt_nrolegajo
        '
        Me.txt_nrolegajo.Location = New System.Drawing.Point(117, 77)
        Me.txt_nrolegajo.Name = "txt_nrolegajo"
        Me.txt_nrolegajo.Size = New System.Drawing.Size(72, 20)
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
        'txt_fechanac
        '
        Me.txt_fechanac.Location = New System.Drawing.Point(118, 157)
        Me.txt_fechanac.Name = "txt_fechanac"
        Me.txt_fechanac.ReadOnly = True
        Me.txt_fechanac.Size = New System.Drawing.Size(144, 20)
        Me.txt_fechanac.TabIndex = 62
        '
        'txt_tipdoc
        '
        Me.txt_tipdoc.Location = New System.Drawing.Point(118, 131)
        Me.txt_tipdoc.Name = "txt_tipdoc"
        Me.txt_tipdoc.ReadOnly = True
        Me.txt_tipdoc.Size = New System.Drawing.Size(144, 20)
        Me.txt_tipdoc.TabIndex = 61
        '
        'txt_estcivil
        '
        Me.txt_estcivil.Location = New System.Drawing.Point(117, 207)
        Me.txt_estcivil.Name = "txt_estcivil"
        Me.txt_estcivil.ReadOnly = True
        Me.txt_estcivil.Size = New System.Drawing.Size(144, 20)
        Me.txt_estcivil.TabIndex = 63
        '
        'btn_buscarlegajo
        '
        Me.btn_buscarlegajo.Location = New System.Drawing.Point(195, 75)
        Me.btn_buscarlegajo.Name = "btn_buscarlegajo"
        Me.btn_buscarlegajo.Size = New System.Drawing.Size(68, 23)
        Me.btn_buscarlegajo.TabIndex = 64
        Me.btn_buscarlegajo.Text = "Buscar"
        Me.btn_buscarlegajo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 34)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "<-- Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_BajaProfesor
        '
        Me.btn_BajaProfesor.Image = CType(resources.GetObject("btn_BajaProfesor.Image"), System.Drawing.Image)
        Me.btn_BajaProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_BajaProfesor.Location = New System.Drawing.Point(148, 294)
        Me.btn_BajaProfesor.Name = "btn_BajaProfesor"
        Me.btn_BajaProfesor.Size = New System.Drawing.Size(114, 34)
        Me.btn_BajaProfesor.TabIndex = 65
        Me.btn_BajaProfesor.Text = "Eliminar"
        Me.btn_BajaProfesor.UseVisualStyleBackColor = True
        '
        'FormBajaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(274, 339)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_BajaProfesor)
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
        Me.Name = "FormBajaAlumno"
        Me.Text = "Baja Alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents txt_fechanac As TextBox
    Friend WithEvents txt_tipdoc As TextBox
    Friend WithEvents txt_estcivil As TextBox
    Friend WithEvents btn_buscarlegajo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_BajaProfesor As Button
End Class

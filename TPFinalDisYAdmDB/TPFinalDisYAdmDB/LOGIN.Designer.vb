<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(71, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 131)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_usuario.Location = New System.Drawing.Point(12, 181)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(69, 19)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.AutoSize = True
        Me.lbl_contrasena.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_contrasena.Location = New System.Drawing.Point(12, 217)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(98, 19)
        Me.lbl_contrasena.TabIndex = 2
        Me.lbl_contrasena.Text = "Contraseña"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(117, 180)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(142, 20)
        Me.txt_usuario.TabIndex = 3
        '
        'txt_contra
        '
        Me.txt_contra.Location = New System.Drawing.Point(117, 217)
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_contra.Size = New System.Drawing.Size(142, 20)
        Me.txt_contra.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(16, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salir.Location = New System.Drawing.Point(16, 290)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(243, 28)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'LOGIN
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(271, 331)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_contra)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_contrasena)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(287, 370)
        Me.MinimumSize = New System.Drawing.Size(287, 370)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_contrasena As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_salir As Button
End Class

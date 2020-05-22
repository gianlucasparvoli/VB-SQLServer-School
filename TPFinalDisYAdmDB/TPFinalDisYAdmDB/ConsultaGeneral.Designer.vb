<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaGeneral
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
        Me.dgv_consulta = New System.Windows.Forms.DataGridView()
        Me.cb_opciones = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_exportar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        CType(Me.dgv_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_consulta
        '
        Me.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consulta.Location = New System.Drawing.Point(12, 62)
        Me.dgv_consulta.Name = "dgv_consulta"
        Me.dgv_consulta.Size = New System.Drawing.Size(498, 264)
        Me.dgv_consulta.TabIndex = 0
        '
        'cb_opciones
        '
        Me.cb_opciones.FormattingEnabled = True
        Me.cb_opciones.Location = New System.Drawing.Point(12, 22)
        Me.cb_opciones.Name = "cb_opciones"
        Me.cb_opciones.Size = New System.Drawing.Size(94, 21)
        Me.cb_opciones.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(112, 20)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(398, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'btn_exportar
        '
        Me.btn_exportar.Location = New System.Drawing.Point(12, 346)
        Me.btn_exportar.Name = "btn_exportar"
        Me.btn_exportar.Size = New System.Drawing.Size(498, 23)
        Me.btn_exportar.TabIndex = 3
        Me.btn_exportar.Text = "Exportar a Excel"
        Me.btn_exportar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(12, 376)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(498, 23)
        Me.btn_volver.TabIndex = 4
        Me.btn_volver.Text = "<-- Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'ConsultaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(522, 408)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_exportar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cb_opciones)
        Me.Controls.Add(Me.dgv_consulta)
        Me.MaximumSize = New System.Drawing.Size(538, 447)
        Me.MinimumSize = New System.Drawing.Size(538, 447)
        Me.Name = "ConsultaGeneral"
        Me.Text = "Consulta General"
        CType(Me.dgv_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_consulta As DataGridView
    Friend WithEvents cb_opciones As ComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btn_exportar As Button
    Friend WithEvents btn_volver As Button
End Class

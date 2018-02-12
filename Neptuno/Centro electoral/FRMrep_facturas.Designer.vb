<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMrep_facturas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CBOnp = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBOpais = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CBOnc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBOidc = New System.Windows.Forms.ComboBox
        Me.BTNmostrar_reporte = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBOnp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CBOpais)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBOnc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBOidc)
        Me.GroupBox1.Controls.Add(Me.BTNmostrar_reporte)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'CBOnp
        '
        Me.CBOnp.FormattingEnabled = True
        Me.CBOnp.Location = New System.Drawing.Point(362, 121)
        Me.CBOnp.Name = "CBOnp"
        Me.CBOnp.Size = New System.Drawing.Size(226, 21)
        Me.CBOnp.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "País"
        '
        'CBOpais
        '
        Me.CBOpais.FormattingEnabled = True
        Me.CBOpais.Location = New System.Drawing.Point(108, 121)
        Me.CBOpais.Name = "CBOpais"
        Me.CBOpais.Size = New System.Drawing.Size(148, 21)
        Me.CBOpais.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre compañia"
        '
        'CBOnc
        '
        Me.CBOnc.FormattingEnabled = True
        Me.CBOnc.Location = New System.Drawing.Point(362, 62)
        Me.CBOnc.Name = "CBOnc"
        Me.CBOnc.Size = New System.Drawing.Size(208, 21)
        Me.CBOnc.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Cliente"
        '
        'CBOidc
        '
        Me.CBOidc.FormattingEnabled = True
        Me.CBOidc.Location = New System.Drawing.Point(108, 62)
        Me.CBOidc.Name = "CBOidc"
        Me.CBOidc.Size = New System.Drawing.Size(121, 21)
        Me.CBOidc.TabIndex = 1
        '
        'BTNmostrar_reporte
        '
        Me.BTNmostrar_reporte.ForeColor = System.Drawing.Color.Black
        Me.BTNmostrar_reporte.Location = New System.Drawing.Point(204, 209)
        Me.BTNmostrar_reporte.Name = "BTNmostrar_reporte"
        Me.BTNmostrar_reporte.Size = New System.Drawing.Size(175, 23)
        Me.BTNmostrar_reporte.TabIndex = 0
        Me.BTNmostrar_reporte.Text = "Ver reporte"
        Me.BTNmostrar_reporte.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(503, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "https://github.com/juanhlb"
        '
        'FRMrep_facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(660, 302)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(150, 70)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMrep_facturas"
        Me.Text = "Reporte Facturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOidc As System.Windows.Forms.ComboBox
    Friend WithEvents BTNmostrar_reporte As System.Windows.Forms.Button
    Friend WithEvents CBOnp As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOpais As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBOnc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

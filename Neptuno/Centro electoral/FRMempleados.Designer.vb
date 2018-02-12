<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMempleados
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
        Me.BTNabrir_foto = New System.Windows.Forms.Button
        Me.Pic_foto = New System.Windows.Forms.PictureBox
        Me.CBOcargo = New System.Windows.Forms.ComboBox
        Me.TXTtel = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CBOciudad = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXTapellido = New System.Windows.Forms.TextBox
        Me.TXTnombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.BNTgregar = New System.Windows.Forms.Button
        Me.Ofd = New System.Windows.Forms.OpenFileDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pic_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNabrir_foto)
        Me.GroupBox1.Controls.Add(Me.Pic_foto)
        Me.GroupBox1.Controls.Add(Me.CBOcargo)
        Me.GroupBox1.Controls.Add(Me.TXTtel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CBOciudad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTapellido)
        Me.GroupBox1.Controls.Add(Me.TXTnombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(22, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(858, 176)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos básicos"
        '
        'BTNabrir_foto
        '
        Me.BTNabrir_foto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNabrir_foto.Location = New System.Drawing.Point(668, 134)
        Me.BTNabrir_foto.Name = "BTNabrir_foto"
        Me.BTNabrir_foto.Size = New System.Drawing.Size(75, 23)
        Me.BTNabrir_foto.TabIndex = 12
        Me.BTNabrir_foto.Text = "Abrir foto"
        Me.BTNabrir_foto.UseVisualStyleBackColor = True
        '
        'Pic_foto
        '
        Me.Pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_foto.Location = New System.Drawing.Point(668, 19)
        Me.Pic_foto.Name = "Pic_foto"
        Me.Pic_foto.Size = New System.Drawing.Size(100, 109)
        Me.Pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_foto.TabIndex = 12
        Me.Pic_foto.TabStop = False
        '
        'CBOcargo
        '
        Me.CBOcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOcargo.FormattingEnabled = True
        Me.CBOcargo.Location = New System.Drawing.Point(104, 82)
        Me.CBOcargo.Name = "CBOcargo"
        Me.CBOcargo.Size = New System.Drawing.Size(209, 21)
        Me.CBOcargo.TabIndex = 19
        '
        'TXTtel
        '
        Me.TXTtel.Location = New System.Drawing.Point(348, 127)
        Me.TXTtel.MaxLength = 20
        Me.TXTtel.Name = "TXTtel"
        Me.TXTtel.Size = New System.Drawing.Size(158, 20)
        Me.TXTtel.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Teléfono domicilio"
        '
        'CBOciudad
        '
        Me.CBOciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOciudad.FormattingEnabled = True
        Me.CBOciudad.Location = New System.Drawing.Point(104, 127)
        Me.CBOciudad.Name = "CBOciudad"
        Me.CBOciudad.Size = New System.Drawing.Size(121, 21)
        Me.CBOciudad.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Ciudad"
        '
        'TXTapellido
        '
        Me.TXTapellido.Location = New System.Drawing.Point(348, 39)
        Me.TXTapellido.MaxLength = 15
        Me.TXTapellido.Name = "TXTapellido"
        Me.TXTapellido.Size = New System.Drawing.Size(158, 20)
        Me.TXTapellido.TabIndex = 2
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(104, 39)
        Me.TXTnombre.MaxLength = 15
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(162, 20)
        Me.TXTnombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cargo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Apellido"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(22, 233)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.Size = New System.Drawing.Size(860, 150)
        Me.Grid.TabIndex = 10
        '
        'BNTgregar
        '
        Me.BNTgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BNTgregar.ForeColor = System.Drawing.Color.White
        Me.BNTgregar.Location = New System.Drawing.Point(22, 195)
        Me.BNTgregar.Name = "BNTgregar"
        Me.BNTgregar.Size = New System.Drawing.Size(75, 32)
        Me.BNTgregar.TabIndex = 11
        Me.BNTgregar.Text = "Agregar"
        Me.BNTgregar.UseVisualStyleBackColor = False
        '
        'Ofd
        '
        Me.Ofd.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(746, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "https://github.com/juanhlb"
        '
        'FRMempleados
        '
        Me.AcceptButton = Me.BNTgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(899, 395)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BNTgregar)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMempleados"
        Me.Text = "Registro de empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Pic_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBOciudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTapellido As System.Windows.Forms.TextBox
    Friend WithEvents TXTnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents BNTgregar As System.Windows.Forms.Button
    Friend WithEvents TXTtel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBOcargo As System.Windows.Forms.ComboBox
    Friend WithEvents Pic_foto As System.Windows.Forms.PictureBox
    Friend WithEvents BTNabrir_foto As System.Windows.Forms.Button
    Friend WithEvents Ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

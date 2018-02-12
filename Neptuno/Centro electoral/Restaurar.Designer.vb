<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMrestaurar
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
        Me.components = New System.ComponentModel.Container
        Me.Ofd = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PBar = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTruta = New System.Windows.Forms.TextBox
        Me.BTNrestaurar = New System.Windows.Forms.Button
        Me.BTNbuscar = New System.Windows.Forms.Button
        Me.TimerPbar = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ofd
        '
        Me.Ofd.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PBar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTruta)
        Me.GroupBox1.Controls.Add(Me.BTNrestaurar)
        Me.GroupBox1.Controls.Add(Me.BTNbuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(38, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Restaurar Base de datos"
        '
        'PBar
        '
        Me.PBar.ForeColor = System.Drawing.Color.Chartreuse
        Me.PBar.Location = New System.Drawing.Point(35, 235)
        Me.PBar.Maximum = 500
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(430, 23)
        Me.PBar.TabIndex = 5
        Me.PBar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ruta de base de datos a restaurar:"
        '
        'TXTruta
        '
        Me.TXTruta.Enabled = False
        Me.TXTruta.Location = New System.Drawing.Point(35, 126)
        Me.TXTruta.Multiline = True
        Me.TXTruta.Name = "TXTruta"
        Me.TXTruta.Size = New System.Drawing.Size(430, 59)
        Me.TXTruta.TabIndex = 3
        '
        'BTNrestaurar
        '
        Me.BTNrestaurar.Enabled = False
        Me.BTNrestaurar.ForeColor = System.Drawing.Color.Black
        Me.BTNrestaurar.Location = New System.Drawing.Point(201, 201)
        Me.BTNrestaurar.Name = "BTNrestaurar"
        Me.BTNrestaurar.Size = New System.Drawing.Size(75, 23)
        Me.BTNrestaurar.TabIndex = 1
        Me.BTNrestaurar.Text = "2.-Restaurar"
        Me.BTNrestaurar.UseVisualStyleBackColor = True
        '
        'BTNbuscar
        '
        Me.BTNbuscar.ForeColor = System.Drawing.Color.Black
        Me.BTNbuscar.Location = New System.Drawing.Point(154, 57)
        Me.BTNbuscar.Name = "BTNbuscar"
        Me.BTNbuscar.Size = New System.Drawing.Size(175, 23)
        Me.BTNbuscar.TabIndex = 0
        Me.BTNbuscar.Text = "1.-Buscar archivo de respaldo"
        Me.BTNbuscar.UseVisualStyleBackColor = True
        '
        'TimerPbar
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(442, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "https://github.com/juanhlb"
        '
        'FRMrestaurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(588, 343)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(180, 70)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMrestaurar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restaurar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNbuscar As System.Windows.Forms.Button
    Friend WithEvents BTNrestaurar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTruta As System.Windows.Forms.TextBox
    Friend WithEvents PBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TimerPbar As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

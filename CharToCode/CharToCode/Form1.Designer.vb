<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMain
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTwriteText = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXTOutput = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransformByteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenTxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExampleTxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CHKplace_space = New System.Windows.Forms.CheckBox
        Me.LBLproceced = New System.Windows.Forms.Label
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Write text"
        '
        'TXTwriteText
        '
        Me.TXTwriteText.Location = New System.Drawing.Point(12, 65)
        Me.TXTwriteText.Multiline = True
        Me.TXTwriteText.Name = "TXTwriteText"
        Me.TXTwriteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTwriteText.Size = New System.Drawing.Size(763, 198)
        Me.TXTwriteText.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Output"
        '
        'TXTOutput
        '
        Me.TXTOutput.Location = New System.Drawing.Point(15, 292)
        Me.TXTOutput.Multiline = True
        Me.TXTOutput.Name = "TXTOutput"
        Me.TXTOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTOutput.Size = New System.Drawing.Size(763, 198)
        Me.TXTOutput.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransformByteToolStripMenuItem, Me.OpenTxtToolStripMenuItem, Me.ExampleTxtToolStripMenuItem})
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.TextToolStripMenuItem.Text = "Text"
        '
        'TransformByteToolStripMenuItem
        '
        Me.TransformByteToolStripMenuItem.Name = "TransformByteToolStripMenuItem"
        Me.TransformByteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TransformByteToolStripMenuItem.Text = "Transform byte"
        '
        'OpenTxtToolStripMenuItem
        '
        Me.OpenTxtToolStripMenuItem.Name = "OpenTxtToolStripMenuItem"
        Me.OpenTxtToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenTxtToolStripMenuItem.Text = "Open txt"
        '
        'ExampleTxtToolStripMenuItem
        '
        Me.ExampleTxtToolStripMenuItem.Name = "ExampleTxtToolStripMenuItem"
        Me.ExampleTxtToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExampleTxtToolStripMenuItem.Text = "Example txt"
        '
        'CHKplace_space
        '
        Me.CHKplace_space.AutoSize = True
        Me.CHKplace_space.Location = New System.Drawing.Point(239, 27)
        Me.CHKplace_space.Name = "CHKplace_space"
        Me.CHKplace_space.Size = New System.Drawing.Size(183, 17)
        Me.CHKplace_space.TabIndex = 5
        Me.CHKplace_space.Text = "place space after each character"
        Me.CHKplace_space.UseVisualStyleBackColor = True
        Me.CHKplace_space.Visible = False
        '
        'LBLproceced
        '
        Me.LBLproceced.AutoSize = True
        Me.LBLproceced.Location = New System.Drawing.Point(12, 493)
        Me.LBLproceced.Name = "LBLproceced"
        Me.LBLproceced.Size = New System.Drawing.Size(39, 13)
        Me.LBLproceced.TabIndex = 6
        Me.LBLproceced.Text = "Label3"
        '
        'FRMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 532)
        Me.Controls.Add(Me.LBLproceced)
        Me.Controls.Add(Me.CHKplace_space)
        Me.Controls.Add(Me.TXTOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTwriteText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMMain"
        Me.Text = "CharToCode"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTwriteText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTOutput As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransformByteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHKplace_space As System.Windows.Forms.CheckBox
    Friend WithEvents OpenTxtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExampleTxtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBLproceced As System.Windows.Forms.Label
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog

End Class

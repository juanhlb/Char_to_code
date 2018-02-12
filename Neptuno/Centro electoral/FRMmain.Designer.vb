<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmain
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmain))
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NeptunoDataSet = New neptuno.NeptunoDataSet
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Pbar = New System.Windows.Forms.ProgressBar
        Me.BTNcerrarRv = New System.Windows.Forms.Button
        Me.Rv1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Lb4 = New System.Windows.Forms.Label
        Me.Lb3 = New System.Windows.Forms.Label
        Me.Lb2 = New System.Windows.Forms.Label
        Me.Lb1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.baner2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarNuevoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RespaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MásVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SobreElPrecioMedioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MásCarosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.EmpleadosTableAdapter = New neptuno.NeptunoDataSetTableAdapters.EmpleadosTableAdapter
        Me.TimerPBar = New System.Windows.Forms.Timer(Me.components)
        Me.Label22 = New System.Windows.Forms.Label
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.baner2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.NeptunoDataSet
        '
        'NeptunoDataSet
        '
        Me.NeptunoDataSet.DataSetName = "NeptunoDataSet"
        Me.NeptunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Pbar)
        Me.Panel1.Controls.Add(Me.BTNcerrarRv)
        Me.Panel1.Controls.Add(Me.Rv1)
        Me.Panel1.Controls.Add(Me.Crv)
        Me.Panel1.Location = New System.Drawing.Point(228, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 518)
        Me.Panel1.TabIndex = 1
        '
        'Pbar
        '
        Me.Pbar.Location = New System.Drawing.Point(170, 251)
        Me.Pbar.MarqueeAnimationSpeed = 10
        Me.Pbar.Maximum = 500
        Me.Pbar.Name = "Pbar"
        Me.Pbar.Size = New System.Drawing.Size(653, 41)
        Me.Pbar.TabIndex = 3
        Me.Pbar.Visible = False
        '
        'BTNcerrarRv
        '
        Me.BTNcerrarRv.Location = New System.Drawing.Point(957, 3)
        Me.BTNcerrarRv.Name = "BTNcerrarRv"
        Me.BTNcerrarRv.Size = New System.Drawing.Size(27, 26)
        Me.BTNcerrarRv.TabIndex = 2
        Me.BTNcerrarRv.Text = "X"
        Me.BTNcerrarRv.UseVisualStyleBackColor = True
        Me.BTNcerrarRv.Visible = False
        '
        'Rv1
        '
        ReportDataSource1.Name = "NeptunoDataSet_Empleados"
        ReportDataSource1.Value = Me.EmpleadosBindingSource
        Me.Rv1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Rv1.LocalReport.ReportEmbeddedResource = ""
        Me.Rv1.Location = New System.Drawing.Point(0, 3)
        Me.Rv1.Name = "Rv1"
        Me.Rv1.Size = New System.Drawing.Size(959, 478)
        Me.Rv1.TabIndex = 1
        Me.Rv1.Visible = False
        '
        'Crv
        '
        Me.Crv.ActiveViewIndex = -1
        Me.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv.DisplayGroupTree = False
        Me.Crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Crv.Location = New System.Drawing.Point(0, 0)
        Me.Crv.Name = "Crv"
        Me.Crv.SelectionFormula = ""
        Me.Crv.Size = New System.Drawing.Size(987, 516)
        Me.Crv.TabIndex = 0
        Me.Crv.ViewTimeSelectionFormula = ""
        Me.Crv.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 81)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Chocolate
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(-1, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1355, 54)
        Me.Panel4.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SandyBrown
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Palermo", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "G E S T I O N    N E P T U N O"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Palermo", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label12.Location = New System.Drawing.Point(828, -27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(557, 122)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "NEPTUNO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Palermo", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label11.Location = New System.Drawing.Point(0, -33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(511, 122)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "GESTION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(1128, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Pescado/Marisco"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(937, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Frutas/Verduras"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(845, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Carnes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(671, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Granos/Seriales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(575, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Lacteos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(447, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Repostería"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(318, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Repostería"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(181, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Condimentos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(73, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bebidas"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Controls.Add(Me.Lb4)
        Me.Panel3.Controls.Add(Me.Lb3)
        Me.Panel3.Controls.Add(Me.Lb2)
        Me.Panel3.Controls.Add(Me.Lb1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(0, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(211, 611)
        Me.Panel3.TabIndex = 6
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.BackColor = System.Drawing.Color.Transparent
        Me.Lb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.Location = New System.Drawing.Point(-40, 535)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(160, 42)
        Me.Lb4.TabIndex = 4
        Me.Lb4.Text = "Neptuno"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.BackColor = System.Drawing.Color.Transparent
        Me.Lb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.Location = New System.Drawing.Point(100, 418)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(160, 42)
        Me.Lb3.TabIndex = 3
        Me.Lb3.Text = "Neptuno"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.BackColor = System.Drawing.Color.Transparent
        Me.Lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.Location = New System.Drawing.Point(-62, 286)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(160, 42)
        Me.Lb2.TabIndex = 2
        Me.Lb2.Text = "Neptuno"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.BackColor = System.Drawing.Color.Transparent
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(113, 7)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(160, 42)
        Me.Lb1.TabIndex = 1
        Me.Lb1.Text = "Neptuno"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(239, 634)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(978, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Somos los mejores proveedores de alimentos variados a nivel nacional, contamos co" & _
            "n 25 sucursales "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(239, 658)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(528, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "distribuídas entre las diferentes ciudades del país."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(612, 685)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "(0800) - neptuno"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(695, 704)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(172, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "© Todos los derechos reservados."
        '
        'baner2
        '
        Me.baner2.Image = CType(resources.GetObject("baner2.Image"), System.Drawing.Image)
        Me.baner2.Location = New System.Drawing.Point(1223, 278)
        Me.baner2.Name = "baner2"
        Me.baner2.Size = New System.Drawing.Size(132, 396)
        Me.baner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.baner2.TabIndex = 1
        Me.baner2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(42, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gold
        Me.Label17.Location = New System.Drawing.Point(8, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Líderes en el mercado"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gold
        Me.Label18.Location = New System.Drawing.Point(40, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Calidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Gold
        Me.Label19.Location = New System.Drawing.Point(39, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Economía"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Location = New System.Drawing.Point(1223, 121)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(132, 147)
        Me.Panel5.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Gold
        Me.Label20.Location = New System.Drawing.Point(56, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "y"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(797, 685)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(158, 16)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "www.neptuno.com"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoEmpleadoToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AgregarNuevoEmpleadoToolStripMenuItem
        '
        Me.AgregarNuevoEmpleadoToolStripMenuItem.Name = "AgregarNuevoEmpleadoToolStripMenuItem"
        Me.AgregarNuevoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AgregarNuevoEmpleadoToolStripMenuItem.Text = "Agregar nuevo empleado"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseDeDatosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'BaseDeDatosToolStripMenuItem
        '
        Me.BaseDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RespaldoToolStripMenuItem, Me.RestaurarToolStripMenuItem})
        Me.BaseDeDatosToolStripMenuItem.Name = "BaseDeDatosToolStripMenuItem"
        Me.BaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.BaseDeDatosToolStripMenuItem.Text = "Base de datos"
        '
        'RespaldoToolStripMenuItem
        '
        Me.RespaldoToolStripMenuItem.Name = "RespaldoToolStripMenuItem"
        Me.RespaldoToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.RespaldoToolStripMenuItem.Text = "Respaldo"
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.RestaurarToolStripMenuItem.Text = "Restaurar"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.FacturasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MásVendidosToolStripMenuItem, Me.PorCategoríaToolStripMenuItem, Me.SobreElPrecioMedioToolStripMenuItem, Me.MásCarosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'MásVendidosToolStripMenuItem
        '
        Me.MásVendidosToolStripMenuItem.Name = "MásVendidosToolStripMenuItem"
        Me.MásVendidosToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MásVendidosToolStripMenuItem.Text = "5 más vendidos"
        '
        'PorCategoríaToolStripMenuItem
        '
        Me.PorCategoríaToolStripMenuItem.Name = "PorCategoríaToolStripMenuItem"
        Me.PorCategoríaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PorCategoríaToolStripMenuItem.Text = "Por categoría"
        '
        'SobreElPrecioMedioToolStripMenuItem
        '
        Me.SobreElPrecioMedioToolStripMenuItem.Name = "SobreElPrecioMedioToolStripMenuItem"
        Me.SobreElPrecioMedioToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SobreElPrecioMedioToolStripMenuItem.Text = "Sobre el precio medio"
        '
        'MásCarosToolStripMenuItem
        '
        Me.MásCarosToolStripMenuItem.Name = "MásCarosToolStripMenuItem"
        Me.MásCarosToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MásCarosToolStripMenuItem.Text = "10 más caros"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2000
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TimerPBar
        '
        Me.TimerPBar.Interval = 200
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(1039, 707)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(134, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "https://github.com/juanhlb"
        '
        'FRMmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.baner2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMmain"
        Me.Text = "Auditor Electoral - Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.baner2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents baner2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb4 As System.Windows.Forms.Label
    Friend WithEvents Lb3 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarNuevoEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Rv1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NeptunoDataSet As neptuno.NeptunoDataSet
    Friend WithEvents EmpleadosTableAdapter As neptuno.NeptunoDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MásVendidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorCategoríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreElPrecioMedioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MásCarosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTNcerrarRv As System.Windows.Forms.Button
    Friend WithEvents Pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents TimerPBar As System.Windows.Forms.Timer
    Friend WithEvents Label22 As System.Windows.Forms.Label

End Class

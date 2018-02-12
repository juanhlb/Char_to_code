Imports System.Data.OleDb
Imports System.IO
Public Class FRMmain
    Dim oReporte As New cr1
    Dim r As Integer
    Dim SelImg As Integer = 3
    Dim Cont As Integer
    Private msRutaBD As String = Application.StartupPath & "/DbDemo.accdb"
    Private msCopia As String = Application.StartupPath & "\Back.accdb"

    Private Sub FRMmain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FRMmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.NeptunoDataSet.Empleados)
        Me.KeyPreview = True

        Cn = New Data.OleDb.OleDbConnection
        baner2.ImageLocation = My.Computer.FileSystem.CurrentDirectory & "\n3.jpg"

        BaseDatos = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\Neptuno.mdb;Persist Security Info=false;"
        Cn.ConnectionString = BaseDatos

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Me.Rv1.RefreshReport()


    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        r = Fix(Rnd() * 2)
        If r = 1 Then Lb1.Left += (Rnd() * 50) + 10 Else Lb1.Left -= (Rnd() * 50) + 10
        If Lb1.Left < -100 Then Lb1.Left = 100
        If Lb1.Left > 300 Then Lb1.Left = 300

        r = Fix(Rnd() * 2)
        If r = 1 Then Lb2.Left += (Rnd() * 50) + 10 Else Lb2.Left -= (Rnd() * 50) + 10
        If Lb2.Left < -100 Then Lb2.Left = 100
        If Lb2.Left > 300 Then Lb2.Left = 300

        r = Fix(Rnd() * 2)
        If r = 1 Then Lb3.Left += (Rnd() * 50) + 10 Else Lb3.Left -= (Rnd() * 50) + 10
        If Lb3.Left < -100 Then Lb3.Left = 100
        If Lb3.Left > 300 Then Lb3.Left = 300

        r = Fix(Rnd() * 2)
        If r = 1 Then Lb4.Left += (Rnd() * 50) + 10 Else Lb4.Left -= (Rnd() * 50) + 10
        If Lb4.Left < -100 Then Lb4.Left = 100
        If Lb4.Left > 300 Then Lb4.Left = 300
    End Sub



    Private Sub AgregarNuevoEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarNuevoEmpleadoToolStripMenuItem.Click

        OcultarTodos()


        FRMempleados.TopLevel = False
        FRMempleados.Width = Panel1.Width
        FRMempleados.Height = Panel1.Height

        Panel1.Controls.Add(FRMempleados)
        FRMempleados.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick


        Select Case SelImg
            Case Is = 1
                baner2.ImageLocation = My.Computer.FileSystem.CurrentDirectory & "\n1.jpg"
            Case Is = 2
                baner2.ImageLocation = My.Computer.FileSystem.CurrentDirectory & "\n2.jpg"
            Case Is = 3
                baner2.ImageLocation = My.Computer.FileSystem.CurrentDirectory & "\n3.jpg"
            Case Is = 4
                baner2.ImageLocation = My.Computer.FileSystem.CurrentDirectory & "\n4.jpg"
            Case Is = 5
                baner2.ImageLocation = My.Computer.FileSystem.CurrentDirectory & "\n5.jpg"
            Case Is = 6
                baner2.ImageLocation = My.Computer.FileSystem.CurrentDirectory & "\n6.jpg"
        End Select

        SelImg += 1
        If SelImg = 7 Then SelImg = 1

    End Sub
    Private Sub RespaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldoToolStripMenuItem.Click
        TimerPBar.Enabled = True
        Pbar.Visible = True

        Try
            System.IO.File.Copy(My.Computer.FileSystem.CurrentDirectory & "\Neptuno.mdb", My.Computer.FileSystem.CurrentDirectory & "\respaldos\Neptuno_" & Format(DateTime.Today, "yyyymmdd") & "_" & DateTime.Now.Hour & DateTime.Now.Minute & DateTime.Now.Second & ".mdb")
        Catch ex As Exception
            MsgBox("Error realizando el respaldo" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub Crv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crv.Load

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rv1.Load
        'Rv1.LocalReport.EnableExternalImages = True
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        OcultarTodos()
        'NeptunoDataSet.Tables.Clear()
        ' Inicializar un nuevo SqlDataAdapter   
        Dim da As New OleDbDataAdapter("select top 1 * from empleados", Cn)
        Dim dt As New DataTable
        da.Fill(dt)

        Rv1.LocalReport.EnableExternalImages = True
        Rv1.Visible = True
        Rv1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Rv1.LocalReport.ReportPath = "C:\Users\margarita\Documents\Visual Studio 2008\Projects\Neptuno\Centro electoral\Report2.rdlc"
        Rv1.LocalReport.ReportEmbeddedResource = "Report2.rdlc"
        Rv1.LocalReport.Refresh()
        Rv1.RefreshReport()


        BTNcerrarRv.Visible = True
    End Sub

    Private Sub BTNcerrarRv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNcerrarRv.Click
        Rv1.Visible = False
        Crv.Visible = False
        BTNcerrarRv.Visible = False
    End Sub
    Private Sub OcultarTodos()
        FRMempleados.Close()
        FRMrep_facturas.Close()
        FRMrestaurar.Close()

        Crv.ReportSource = Nothing
        Crv.Visible = False
        Rv1.Visible = False
        BTNcerrarRv.Visible = False
    End Sub

    Public Sub Ver_factura(ByVal Pais As String, ByVal Nombre_producto As String, ByVal Nombre_compnia As String, ByVal Idcliente As String)
        'Dim cr As New cr_fact
        'cr.SetParameterValue("pais", "Brasil")
        'Crv.ReportSource = cr

        'Crv.Visible = True
        'Generar(Crv)
        OcultarTodos()
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet

        Dim sqlwhere As String = ""

        If Pais <> "" Then sqlwhere = sqlwhereand(sqlwhere) & " Clientes.País = '" & Pais & "'"
        If Nombre_producto <> "" Then sqlwhere = sqlwhereand(sqlwhere) & " Productos.NombreProducto = '" & Nombre_producto & "'"
        If Nombre_compnia <> "" Then sqlwhere = sqlwhereand(sqlwhere) & " Clientes.NombreCompañía = '" & Nombre_compnia & "'"
        If Idcliente <> "" Then sqlwhere = sqlwhereand(sqlwhere) & " Clientes.IdCliente = '" & Idcliente & "'"

        'abrimos la conexion
        da = New OleDbDataAdapter("SELECT Pedidos.IdCliente, Clientes.NombreCompañía, Clientes.País, [Nombre] , [Apellidos] , Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.FechaEnvío, Productos.NombreProducto, Detalles_de_pedidos.Cantidad, Pedidos.Cargo FROM Productos INNER JOIN ((Empleados INNER JOIN (Compañías_de_envíos INNER JOIN (Clientes INNER JOIN Pedidos ON Clientes.IdCliente = Pedidos.IdCliente) ON Compañías_de_envíos.IdCompañíaEnvíos = Pedidos.FormaEnvío) ON Empleados.IdEmpleado = Pedidos.IdEmpleado) INNER JOIN Detalles_de_pedidos ON Pedidos.IdPedido = Detalles_de_pedidos.IdPedido) ON Productos.IdProducto = Detalles_de_pedidos.IdProducto " & sqlwhere, Cn)

        da.Fill(ds, "Fact")

        'iniciamos el form y el reporte

        Dim imprimir As New cr_fact

        'le indicamos el datasource al report, que sera el recordset

        'que hemos llenado

        imprimir.SetDataSource(ds.Tables("Fact"))

        Crv.ReportSource = imprimir


        Crv.Refresh()
        Crv.Show()
        BTNcerrarRv.Visible = True
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        OcultarTodos()
        FRMrep_facturas.TopLevel = False
        Panel1.Controls.Add(FRMrep_facturas)
        FRMrep_facturas.Visible = True
    End Sub

    Private Sub TimerPBar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPBar.Tick
        If Pbar.Value < 460 Then Pbar.Value += 50
        cont += 50
        If Pbar.Value >= 500 Then Pbar.Value = 500
        If Cont >= 700 Then Cont = 0 : TimerPBar.Enabled = False : Pbar.Visible = False : Pbar.Value = 0 : MsgBox("Se respaldó la base de datos", MsgBoxStyle.Information)
    End Sub

    Private Sub MásVendidosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MásVendidosToolStripMenuItem.Click
        OcultarTodos()
        Crv.ReportSource = oReporte
        Crv.Visible = True
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RestaurarToolStripMenuItem.Click
        OcultarTodos()
        FRMrestaurar.TopLevel = False
        Panel1.Controls.Add(FRMrestaurar)
        FRMrestaurar.Visible = True
        FRMrestaurar.StartPosition = FormStartPosition.CenterParent
    End Sub
    Public Sub add_empleado(ByVal id As Integer, ByVal primer_nombre As String, ByVal primer_apellido As String, ByVal descripcion As String, ByVal foto As String, ByVal cargo As String, ByVal telefono As String)
        NeptunoDataSet.Empleados.Rows.Add(id, primer_nombre, primer_apellido, cargo, "", DateTime.Now, DateTime.Now, "", "", "", telefono, "", "", descripcion, foto)
    End Sub

End Class

Imports System.Data.OleDb
Module General
    Friend Da As OleDbDataAdapter
    Public BaseDatos As String
    Public Sql As String
    Public Cn As Data.OleDb.OleDbConnection
    Public Cod As Long
    Public Sub LlenarCombo(ByRef Combo As ComboBox, ByVal Elemento As String)
        '---------------------------------
        ' Pasar la consulta sql y la conexión al Sql Command   
        Dim cmd As New OleDbCommand("SELECT pk_codigo, contenido FROM " & "paquete" & " ORDER BY contenido ASC", Cn)

        ' Inicializar un nuevo SqlDataAdapter   
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable


        'Crear y Llenar un Dataset  
        da.Fill(dt)

        ' asignar el Datatable al combobox  
        Combo.DataSource = dt

        ' Asignar el campo a la propiedad DisplayMember del combo   
        Combo.DisplayMember = "contenido"
        Combo.ValueMember = "pk_codigo"
        Combo.Text = ""
    End Sub

    Public Sub LlenarComboSql(ByRef Combo As ComboBox, ByVal sql As String, ByVal Display As String)
        '---------------------------------
        ' Pasar la consulta sql y la conexión al Sql Command   
        Dim cmd As New OleDbCommand(sql, Cn)

        ' Inicializar un nuevo SqlDataAdapter   
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable


        'Crear y Llenar un Dataset  
        da.Fill(dt)

        ' asignar el Datatable al combobox  
        Combo.DataSource = dt

        ' Asignar el campo a la propiedad DisplayMember del combo   
        Combo.DisplayMember = Display
        'Combo.ValueMember = "pk_codigo"
        Combo.Text = ""
    End Sub
    Public Sub LlenarLista(ByRef Lista As ListBox, ByRef CampoId As String, ByRef CampoDescripcion As String, ByVal Tabla As String)
        '---------------------------------
        ' Pasar la consulta sql y la conexión al Sql Command   
        Dim cmd As New OleDbCommand("SELECT " & CampoId & "," & CampoDescripcion & " FROM " & Tabla & " ORDER BY " & CampoDescripcion & " ASC", Cn)

        ' Inicializar un nuevo SqlDataAdapter   
        Dim da As New OleDbDataAdapter(cmd)

        'Crear y Llenar un Dataset  
        Dim ds As New DataSet
        da.Fill(ds)

        ' asignar el DataSource al combobox  
        Lista.DataSource = ds.Tables(0)

        ' Asignar el campo a la propiedad DisplayMember de Lista   
        Lista.DisplayMember = CampoDescripcion.ToString
        If CampoId = "" Then Lista.ValueMember = CampoId.ToString
    End Sub

    Public Sub LlenarListaSql(ByRef Lista As ListBox, ByRef CampoDescripcion As String, ByRef Sql As String)
        '---------------------------------
        ' Pasar la consulta sql y la conexión al Sql Command   
        Dim cmd As New OleDbCommand(Sql, Cn)

        ' Inicializar un nuevo SqlDataAdapter   
        Dim da As New OleDbDataAdapter(cmd)

        'Crear y Llenar un Dataset  
        Dim ds As New DataSet
        da.Fill(ds)

        ' asignar el DataSource al combobox  
        Lista.DataSource = ds.Tables(0)

        ' Asignar el campo a la propiedad DisplayMember de Lista   
        Lista.DisplayMember = CampoDescripcion.ToString
    End Sub
    Public Sub EjecutarSql(ByRef instruccionSql As String)
        Try
            Cn.Open()
            Dim command As New OleDbCommand(instruccionSql, Cn)
            Dim reader As OleDbDataReader = command.ExecuteReader()
            'command.ExecuteNonQuery()
            Cn.Close()
        Catch ex As Exception
            Cn.Close()
            MsgBox("Error" & vbCrLf & ex.Message & vbCrLf & instruccionSql)
            Console.Write(instruccionSql)
        End Try
    End Sub
    Public Sub Limpiar(ByVal Formulario As Form, ByVal Tab As TabControl)

        Dim ctl As Object

        For Each ctl In Formulario.Controls
            If TypeOf ctl Is CheckBox Then
                ctl.Checked = False
            ElseIf TypeOf ctl Is TextBox Then
                ctl.Text = ""
            ElseIf TypeOf ctl Is ComboBox Then
                ctl.Text = ""
            End If
        Next
    End Sub
    Public Sub AutocompletarCombo(ByRef Campo As String, ByRef Tabla As String, ByVal Combo As ComboBox)
        Dim Sql As String
        Sql = "SELECT DISTINCT " & Campo & " FROM  " & Tabla

        Try
            Cn.Open()
            Dim command As New OleDbCommand(Sql, Cn)
            Dim Reader As OleDbDataReader = command.ExecuteReader()

            Combo.Items.Clear()
            While Reader.Read()
                If Reader(0).ToString = "" Then
                Else
                    Combo.Items.Add(Reader(Campo).ToString)
                End If
            End While
            Cn.Close()

        Catch ex As Exception
            MsgBox("Error" & vbCrLf & ex.Message & vbCrLf)
            Cn.Close()
        End Try
    End Sub

    Public Sub AutocompletarComboSql(ByRef Campo As String, ByVal Sql As String, ByVal Combo As ComboBox)

        Try
            Cn.Open()
            Dim command As New OleDbCommand(Sql, Cn)
            Dim Reader As OleDbDataReader = command.ExecuteReader()

            Combo.Items.Clear()
            While Reader.Read()
                If Reader(0).ToString = "" Then
                Else
                    Combo.Items.Add(Reader(Campo).ToString)
                End If
            End While
            Cn.Close()

        Catch ex As Exception
            MsgBox("Error" & vbCrLf & ex.Message & vbCrLf)
            Cn.Close()
        End Try
    End Sub

    Public Sub LLenar_Grid(ByVal Grid As DataGridView, ByVal Sql As String)
        Try
            Dim Dt As New Data.DataTable

            Dt.Clear()
            Cn.Open()
            Dim Consulta As New OleDbCommand(Sql, Cn)
            Da = New OleDbDataAdapter(Consulta)
            Da.Fill(Dt)
            Cn.Close()
            Grid.DataSource = Nothing
            Grid.DataSource = Dt
        Catch ex As Exception
            MsgBox("Error" & vbCrLf & ex.Message & vbCrLf)
            Cn.Close()
        End Try
    End Sub
    Public Function ObtenerAutoincrementa(ByRef Campo As String, ByRef Tabla As String) As Integer
        Try
            Cn.Open()
            Dim command As New OleDbCommand("select max(" & Campo & ") as cod from " & Tabla, Cn)

            Dim Reader As OleDbDataReader = command.ExecuteReader()

            While Reader.Read()
                If Reader(0).ToString = "" Then
                    ObtenerAutoincrementa = 1
                Else
                    ObtenerAutoincrementa = Reader(0).ToString + 1
                End If
            End While

            Cn.Close()

        Catch ex As Exception
            MsgBox("Error" & vbCrLf & ex.Message & vbCrLf)
            Cn.Close()

        End Try
    End Function
    Sub LimpiarTab(ByRef Contenedor As Control.ControlCollection)

        Dim tmp As Control
        For Each tmp In Contenedor
            If tmp.GetType Is GetType(GroupBox) Then
                LimpiarTab(DirectCast(tmp, GroupBox).Controls)
            ElseIf tmp.GetType Is GetType(Panel) Then
                LimpiarTab(DirectCast(tmp, Panel).Controls)
            ElseIf tmp.GetType Is GetType(FlowLayoutPanel) Then
                LimpiarTab(DirectCast(tmp, FlowLayoutPanel).Controls)
            ElseIf tmp.GetType Is GetType(TableLayoutPanel) Then
                LimpiarTab(DirectCast(tmp, TableLayoutPanel).Controls)
            ElseIf tmp.GetType Is GetType(SplitContainer) Then
                LimpiarTab(DirectCast(tmp, SplitContainer).Controls)
            ElseIf tmp.GetType Is GetType(TabControl) Then
                LimpiarTab(DirectCast(tmp, TabControl).Controls)
            ElseIf tmp.GetType Is GetType(TabPage) Then
                LimpiarTab(DirectCast(tmp, TabPage).Controls)
            Else
                'TextBox, aunque puede ser cualquier otro control.
                If TypeOf tmp Is TextBox Then
                    DirectCast(tmp, TextBox).Clear()
                End If
                If TypeOf tmp Is CheckBox Then
                    DirectCast(tmp, CheckBox).Checked = False
                End If
                If TypeOf tmp Is ComboBox Then
                    DirectCast(tmp, ComboBox).Text = ""
                End If
            End If
        Next
    End Sub
    Public Function GuardarFilaEnDatatable(ByRef Sql As String) As DataTable
        Dim dt As New DataTable

        Try
            Cn.Open()
            Dim cmd As New OleDbCommand(Sql, Cn)

            ' Inicializar un nuevo SqlDataAdapter   
            Dim da As New OleDbDataAdapter(cmd)

            'Crear y Llenar un Dataset  

            da.Fill(dt)
            GuardarFilaEnDatatable = dt
            Cn.Close()

        Catch ex As Exception
            Cn.Close()
            MsgBox("Error" & vbCrLf & ex.Message & vbCrLf)
            GuardarFilaEnDatatable = dt

        End Try
    End Function
    Public Sub AgrearAcombo(ByVal Combo As ComboBox, ByRef Dato As String)
        Dato = Trim(Dato)

        For a = 0 To Combo.Items.Count - 1
            If Dato.ToUpper = Combo.Items(a).ToString.ToUpper Then Exit Sub
        Next a

        Combo.Items.Add(Dato)
    End Sub

    Public Sub Generar(ByRef Reporte_Visor As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal cr As Type)

        'Dim da As OleDbDataAdapter
        'Dim ds As New DataSet
        'Dim sqlwhere As String = ""

        'If FRMrep_facturas.CBOpais.Text <> "" Then sqlwhere = sqlwhereand(sqlwhere) & " pais = '" & FRMrep_facturas.CBOpais.Text & "'"


        ''abrimos la conexion

        'da = New OleDbDataAdapter("SELECT Pedidos.IdCliente, Clientes.NombreCompañía, Clientes.País, [Nombre] , [Apellidos] , Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.FechaEnvío, Productos.NombreProducto, Detalles_de_pedidos.Cantidad, Pedidos.Cargo FROM Productos INNER JOIN ((Empleados INNER JOIN (Compañías_de_envíos INNER JOIN (Clientes INNER JOIN Pedidos ON Clientes.IdCliente = Pedidos.IdCliente) ON Compañías_de_envíos.IdCompañíaEnvíos = Pedidos.FormaEnvío) ON Empleados.IdEmpleado = Pedidos.IdEmpleado) INNER JOIN Detalles_de_pedidos ON Pedidos.IdPedido = Detalles_de_pedidos.IdPedido) ON Productos.IdProducto = Detalles_de_pedidos.IdProducto " & sqlwhere, Cn)

        'da.Fill(ds, "rpt")

        ''iniciamos el form y el reporte


        'Dim imprimir As New cr_fact

        ''le indicamos el datasource al report, que sera el recordset

        ''que hemos llenado

        'imprimir.SetDataSource(ds.Tables("rpt"))

        'Reporte_Visor.ReportSource = imprimir


        'Reporte_Visor.Refresh()
        'Reporte_Visor.Show()
    End Sub
    Public Function sqlwhereand(ByVal sql As String) As String
        If sql = "" Then
            sql += " where " : Return sql
        Else
            sql += " and " : Return sql
        End If


    End Function
    Public Sub Formxy(ByVal formulario As Form)
        MsgBox(formulario.Location.X & "-" & formulario.Location.Y)
    End Sub
End Module

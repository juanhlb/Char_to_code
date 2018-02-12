Imports System.IO
Imports System.Data.OleDb
Public Class FRMempleados
    Dim Ruta_Foto As String
    Dim idE As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarComboSql(CBOciudad, "select distinct ciudad from empleados", "ciudad")
        LlenarComboSql(CBOcargo, "select distinct cargo from empleados", "cargo")
        Grid.AllowUserToAddRows = False
        Grid.AllowUserToResizeRows = False
        Grid.AllowUserToDeleteRows = False
        Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Grid.ReadOnly = True
        Grid.MultiSelect = False
        Grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)

        LLenar_Grid(Grid, "SELECT Empleados.Nombre, Empleados.Apellidos, Empleados.Cargo, Empleados.Ciudad, Empleados.TelDomicilio FROM Empleados order by FechaContratación asc;")
        Grid.Columns(0).Width = 170
        Grid.Columns(1).Width = 170
        Grid.Columns(2).Width = 200
        Grid.Columns(3).Width = 150
        Grid.Columns(4).Width = 190

        Ruta_Foto = ""
    End Sub


    Private Sub BNTgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNTgregar.Click
        If TXTnombre.Text = "" Then MsgBox("Debe agregar el nombre", MsgBoxStyle.Information) : TXTnombre.Focus() : Exit Sub
        If TXTapellido.Text = "" Then MsgBox("Debe agregar el apellido", MsgBoxStyle.Information) : TXTapellido.Focus() : Exit Sub
        If CBOcargo.Text = "" Then MsgBox("Debe agregar el cargo", MsgBoxStyle.Information) : CBOcargo.Focus() : Exit Sub
        If CBOciudad.Text = "" Then MsgBox("Debe agregar la ciudad", MsgBoxStyle.Information) : CBOciudad.Focus() : Exit Sub
        If TXTtel.Text = "" Then MsgBox("Debe agregar el teléfono", MsgBoxStyle.Information) : TXTtel.Focus() : Exit Sub

        idE = ObtenerAutoincrementa("Idempleado", "empleados")
        EjecutarSql("INSERT INTO empleados (Idempleado,Nombre, Apellidos, Cargo, Ciudad, TelDomicilio, foto) VALUES (" & idE & ",'" & TXTnombre.Text & "','" & TXTapellido.Text & "','" & CBOcargo.Text & "','" & CBOciudad.Text & "','" & TXTtel.Text & "','" & Ruta_Foto & "');")

        LLenar_Grid(Grid, "SELECT Empleados.Nombre, Empleados.Apellidos, Empleados.Cargo, Empleados.Ciudad, Empleados.TelDomicilio FROM Empleados order by FechaContratación asc;")
        Grid.Columns(0).Width = 170
        Grid.Columns(1).Width = 170
        Grid.Columns(2).Width = 200
        Grid.Columns(3).Width = 150
        Grid.Columns(4).Width = 190

        FRMmain.add_empleado(idE, TXTnombre.Text, TXTapellido.Text, "", Ruta_Foto, CBOcargo.Text, TXTtel.Text)
    End Sub

    Private Sub BTNabrir_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNabrir_foto.Click
        With Ofd
            .CheckFileExists = True
            ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra una advertencia en caso contrario.
            .CheckPathExists = True
            ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
            .DefaultExt = "jpg"
            ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
            .DereferenceLinks = True
            ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
            .Filter = "Ficheros Access (*.jpg)|*.jpg|All files|*.*"
            .Multiselect = False
            ' ¿Restaurar el directorio original después de seleccionar un archivo? Si False, el directorio actual cambia al directorio en el que seleccionó el archivo. Establézcalo como True para poner la carpeta actual de nuevo donde estaba cuando comenzó. El valor predeterminado es False.
            .RestoreDirectory = True
            '¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
            .ShowHelp = True
            .ShowReadOnly = False
            ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
            ' Esto sólo tiene sentido si ShowReadOnly es True.
            .ReadOnlyChecked = False
            .Title = "Seleccione el archivo de imagen jpg"
            ' ¿Aceptar sólo nombres de archivo Win32 válidos?
            .ValidateNames = True
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Ruta_Foto = Path.GetFileNameWithoutExtension(.FileName)
                Pic_foto.ImageLocation = .FileName
            End If
        End With
    End Sub
End Class
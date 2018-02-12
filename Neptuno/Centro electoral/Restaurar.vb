Imports System.IO
Public Class FRMrestaurar
    Dim cont As Integer
    Private Sub Restaurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXTruta.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNbuscar.Click
        With Ofd
            .CheckFileExists = True
            ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra una advertencia en caso contrario.
            .CheckPathExists = True
            ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
            .DefaultExt = "mdb"
            ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
            .DereferenceLinks = True
            ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
            .Filter = "Ficheros Access (*.mdb)|*.mdb|All files|*.*"
            .Multiselect = False
            ' ¿Restaurar el directorio original después de seleccionar un archivo? Si False, el directorio actual cambia al directorio en el que seleccionó el archivo. Establézcalo como True para poner la carpeta actual de nuevo donde estaba cuando comenzó. El valor predeterminado es False.
            .RestoreDirectory = True
            '¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
            .ShowHelp = True
            .ShowReadOnly = False
            ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
            ' Esto sólo tiene sentido si ShowReadOnly es True.
            .ReadOnlyChecked = False
            .Title = "Seleccione fichero a restaurar"
            ' ¿Aceptar sólo nombres de archivo Win32 válidos?
            .ValidateNames = True
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TXTruta.Text = .FileName
                BTNrestaurar.Enabled = True
            End If
        End With
    End Sub


    Private Sub BTNrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNrestaurar.Click
        Dim resp As String
        resp = MsgBox("Advertencia, se sobreescribirán los datos de la base de datos actual por la seleccionada, ¿está de acuerdo?", MsgBoxStyle.OkCancel)
        If resp = vbOK Then
            PBar.Visible = True
            File.Delete(Application.StartupPath & "/neptuno.mdb") 'esto lo borra 
            File.Copy(TXTruta.Text, Application.StartupPath & "/neptuno.mdb") 'esto lo copia 
            'animación barra de progreso
            TimerPbar.Enabled = True
        End If

    End Sub

    Private Sub TimerPbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPbar.Tick
        If PBar.Value < 460 Then PBar.Value += 50
        cont += 50
        If PBar.Value >= 500 Then PBar.Value = 500
        If cont >= 900 Then cont = 0 : TimerPbar.Enabled = False : PBar.Visible = False : PBar.Value = 0 : PBar.Visible = False : MsgBox("Se restauró la base de datos", MsgBoxStyle.Information) : TXTruta.Text = "" : BTNrestaurar.Enabled = False

    End Sub
End Class
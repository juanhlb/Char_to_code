Public Class FRMrep_facturas

    Private Sub FRMrep_facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarComboSql(CBOpais, "select distinct clientes.país as pais from clientes", "pais")
        LlenarComboSql(CBOnp, "SELECT distinct NombreProducto FROM Productos;", "NombreProducto")
        LlenarComboSql(CBOnc, "SELECT distinct NombreCompañía FROM Clientes;", "NombreCompañía")
        LlenarComboSql(CBOidc, "SELECT distinct IdCliente FROM Clientes;", "IdCliente")

    End Sub

    Private Sub BTNmostrar_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNmostrar_reporte.Click
        FRMmain.Ver_factura(CBOpais.Text, CBOnp.Text, CBOnc.Text, CBOidc.Text)
    End Sub
End Class
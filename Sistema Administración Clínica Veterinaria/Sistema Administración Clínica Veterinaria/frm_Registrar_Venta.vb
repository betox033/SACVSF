Imports MySql.Data.MySqlClient

Public Class frm_Registrar_Venta

    Protected _frmPrincipal As frm_Principal

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub


    Dim detalle As String = "{0, -6}{1, -32}{2, -5}{3, -14}{4, -5}"

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        _frmPrincipal.Show()
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub frm_Registrar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIndice.Text = "" : Dim bsnVenta As New BsnVenta
        lbl_numero.Text = bsnVenta.GenerarCodVenta

        lbl_num_cliente.Text = ""
        CargarClientes()
        llenar_productos()
        lbl_nombre.Text = "" : lbl_direccion.Text = "" : lbl_fono.Text = "" : lbl_correo.Text = "" : lbl_rut.Text = ""
        lbl_precio.Text = ""
        lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Sub CargarClientes()
        Dim detalleCliente As String = "{0,-35}{1,-5}"
        Dim listaClientes As New List(Of Cliente) : Dim bsnCliente As New BsnCliente
        listaClientes = bsnCliente.GetClientes()
        For Each cliente As Cliente In listaClientes
            If cliente.Estado = True Then
                cmb_clientes.Items.Add(String.Format(detalleCliente, cliente.Nombre, cliente.NumCliente))
            End If
        Next
    End Sub

    Sub llenar_productos()
        cmb_productos.Items.Clear()
        Dim listaProductos As New List(Of Producto) : Dim bsnProducto As New BsnProductos
        listaProductos = bsnProducto.GetProductos("cod_producto")
        For Each producto As Producto In listaProductos
            If producto.Estado = True And producto.Unidad = "UN" And producto.TipoProducto <> "V" Then
                cmb_productos.Items.Add(String.Format("{0,-5}{1,-30}", producto.CodProducto, producto.NomProducto))
            End If
        Next
    End Sub

    Private Sub cmb_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_clientes.SelectedIndexChanged

        If cmb_clientes.SelectedIndex <> -1 Then
            Dim cadena As String = cmb_clientes.SelectedItem
            Dim numCliente As Integer = Convert.ToInt32(Trim(cadena.Substring(35, 5)))
            Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente
            cliente = bsnCliente.GetDatosCliente(numCliente)
            lbl_num_cliente.Text = cliente.NumCliente : lbl_nombre.Text = cliente.Nombre
            lbl_direccion.Text = cliente.DireccionCliente : lbl_correo.Text = cliente.Correo
            lbl_fono.Text = cliente.FonoCliente : lbl_rut.Text = cliente.Rut
            panelClientes.Visible = True
        End If
    End Sub

    Function buscar_si_existe(cod_producto)
        Dim resultado As Integer = -1
        Dim largo As Integer = lstDetalles.Items.Count : Dim i As Integer = 0
        Dim codigo As Integer

        While i < largo
            codigo = Convert.ToInt32(Trim(lstDetalles.Items(i).SubItems(0).Text))
            If codigo = cod_producto Then
                resultado = i
            End If
            i = i + 1
        End While
        Return resultado
    End Function

    Private Sub btn_eliminar_Click_1(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If lblIndice.Text = "" Then
            MsgBox("Seleccione el producto que desea eliminar de la venta.")
            Exit Sub
        End If

        Dim i As Integer = Convert.ToInt32(Trim(lblIndice.Text))
        Dim convertir As New Convertir
        Dim subtotal As Integer = convertir.dinero_a_numero(Trim(lstDetalles.Items(i).SubItems(4).Text))
        Dim total As Integer = convertir.dinero_a_numero(Trim(txt_total.Text))
        total = total - subtotal
        txt_total.Text = convertir.convertir_dinero(total)
        lstDetalles.Items(i).Remove()
        lblIndice.Text = ""
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If lbl_num_cliente.Text = "" Then
            MsgBox("Debe seleccionar un cliente.")
            Exit Sub
        End If

        If lstDetalles.Items.Count = 0 Then
            MsgBox("Debe seleccionar al menos un producto.")
            Exit Sub
        End If

        Dim venta As New Venta : Dim bsnVenta As New BsnVenta : Dim convertir As New Convertir

        venta.CodVenta = Convert.ToInt32(Trim(lbl_numero.Text))
        venta.NumCliente = Convert.ToInt32(Trim(lbl_num_cliente.Text))
        venta.FechaVenta = convertir.invertir_fecha(Trim(lbl_fecha.Text))
        venta.Total = convertir.dinero_a_numero(Trim(txt_total.Text))
        bsnVenta.InsertarVenta(venta) : registrar_detalles(venta)
        MsgBox("La venta ha sido registrada correctamente.")
        _frmPrincipal.Show() : Me.Close() : Me.Dispose()
    End Sub

    Sub registrar_detalles(venta As Venta)
        Dim convertir As New Convertir : Dim bsnVenta As New BsnVenta

        Dim i As Integer = 0 : Dim lg As Integer = lstDetalles.Items.Count
        While i < lg
            Dim detVenta As New DetalleVenta
            detVenta.CodVenta = venta.CodVenta
            detVenta.CodProducto = Convert.ToInt32(Trim(lstDetalles.Items(i).SubItems(0).Text))
            detVenta.Cantidad = Convert.ToInt32(Trim(lstDetalles.Items(i).SubItems(2).Text))
            detVenta.Precio = convertir.dinero_a_numero(Trim(lstDetalles.Items(i).SubItems(3).Text))
            bsnVenta.InsertarDetalleVenta(detVenta)

            Dim producto As New Producto : Dim bsnProducto As New BsnProductos
            producto = bsnProducto.GetDatosProducto(detVenta.CodProducto)
            Dim stockProducto As Integer = producto.Stock
            stockProducto = stockProducto - detVenta.Cantidad
            bsnProducto.ActualizarProducto(detVenta.CodProducto, stockProducto)

            '//////////////////////////////////////////////////////////////
            Dim ajuste As New Ajuste : Dim bsnAjuste As New BsnAjuste
            ajuste.Codproducto = producto.CodProducto : ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            ajuste.TipoAjuste = "V" : ajuste.Cantidad = detVenta.Cantidad * -1 : bsnAjuste.InsertarAjuste(ajuste)
            i = i + 1
        End While
    End Sub

    Private Sub btn_agregar_Click_1(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If cmb_productos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un producto de la lista.")
            Exit Sub
        End If

        If Trim(txt_cantidad.Text) = "" Then
            MsgBox("Debe especificar una cantidad para el producto.")
            Exit Sub
        End If

        Dim convertir As New Convertir
        Dim cod_producto As Integer = Convert.ToInt32(Trim(lbl_cod_producto.Text))
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(cod_producto)

        Dim cantidad As Integer = Convert.ToInt32(txt_cantidad.Text)
        Dim calculo As Integer = producto.Precio * cantidad

        Dim subtotal As String = convertir.convertir_dinero(calculo)
        Dim existe As Integer
        existe = buscar_si_existe(cod_producto)
        Dim mayorStock As Boolean = False

        If existe = -1 Then
            If cantidad > producto.Stock Then
                MsgBox("No se puede agregar esa cantidad del producto." & vbLf &
                       "El stock actual es de : " & producto.Stock & " unidades.")
                Exit Sub
            End If

            With lstDetalles.Items.Add(cod_producto)
                .SubItems.Add(producto.NomProducto)
                .SubItems.Add(cantidad)
                .SubItems.Add(convertir.convertir_dinero(producto.Precio))
                .SubItems.Add(subtotal)
            End With
        End If

        If existe <> -1 Then
            Dim cad_cantidad As Integer = Convert.ToInt32(Trim(lstDetalles.Items(existe).SubItems(2).Text))
            If cad_cantidad + cantidad > producto.Stock Then
                MsgBox("La cantidad que usted desea agregar supera el límite de stock." & vbLf &
                           "El stock actual es de : " & producto.Stock & " unidades")
                mayorStock = True
            Else
                lstDetalles.Items(existe).SubItems(2).Text = cad_cantidad + cantidad
                lstDetalles.Items(existe).SubItems(4).Text = convertir.convertir_dinero((cad_cantidad + cantidad) * producto.Precio)
            End If
        End If

        If mayorStock = False Then
            Dim sumar_a_total As Integer = calculo
            Dim total_str As String = txt_total.Text

            If total_str = "" Then
                txt_total.Text = subtotal
            Else
                Dim total As Integer = convertir.dinero_a_numero(total_str)
                total = total + (cantidad * producto.Precio)
                total_str = convertir.convertir_dinero(total)
                txt_total.Text = total_str
            End If
        End If
    End Sub

    Private Sub cmb_productos_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_productos.SelectedIndexChanged
        If cmb_productos.SelectedIndex <> -1 Then
            Dim cadena As String = cmb_productos.SelectedItem
            Dim codProducto As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            lbl_cod_producto.Text = codProducto
            Dim producto As New Producto : Dim bsnProducto As New BsnProductos : Dim convertir As New Convertir
            producto = bsnProducto.GetDatosProducto(codProducto)
            lbl_precio.Text = convertir.convertir_dinero(producto.Precio)
        End If
    End Sub

    Private Sub lstDetalles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDetalles.SelectedIndexChanged
        lblIndice.Text = lstDetalles.FocusedItem.Index
    End Sub

    Private Sub cmb_productos_Click(sender As Object, e As EventArgs) Handles cmb_productos.Click
        lblIndice.Text = ""
    End Sub

    Private Sub cmb_clientes_Click(sender As Object, e As EventArgs) Handles cmb_clientes.Click
        lblIndice.Text = ""
    End Sub

    Private Sub txt_cantidad_Click(sender As Object, e As EventArgs) Handles txt_cantidad.Click
        lblIndice.Text = ""
    End Sub

    Private Sub txt_total_Click(sender As Object, e As EventArgs) Handles txt_total.Click
        lblIndice.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmb_clientes.SelectedIndex = -1
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente
        cliente = bsnCliente.GetDatosCliente(-1)
        lbl_nombre.Text = cliente.Nombre : lbl_fono.Text = cliente.FonoCliente
        lbl_direccion.Text = cliente.DireccionCliente : lbl_rut.Text = cliente.Rut
        lbl_num_cliente.Text = "-1" : lbl_correo.Text = cliente.Correo
        panelClientes.Visible = True
    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If (Asc(e.KeyChar) <> 8) Then 'borrar
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total.KeyPress
        If (Asc(e.KeyChar) <> 36) Then 'signo peso
            If (Asc(e.KeyChar) <> 46) Then 'punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lstDetalles_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lstDetalles.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = lstDetalles.Columns(e.ColumnIndex).Width
    End Sub
End Class
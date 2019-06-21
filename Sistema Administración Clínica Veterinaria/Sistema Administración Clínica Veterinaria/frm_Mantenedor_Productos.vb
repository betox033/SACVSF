Imports System.IO
Imports MySql.Data.MySqlClient


Public Class frm_Mantenedor_Productos

    Protected _frmPrincipal As frm_Principal

    Dim modalidad As String = "neutro"
    Private tipo As Char = ""
    Dim detalle As String = "{0, -6}{1, -32}{2, -6}{3, -10}"
    Dim imagenCargada As Boolean = False
    Dim imagenRepetida As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub


    Private Sub frm_Mantenedor_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_proveedores()
        llenar_tipos()
        LlenarUnidades()
        OrdenarPor("cod_producto")
        lbl_codigo.Text = ""
    End Sub

    Sub LlenarUnidades()
        cmbUnidad.Items.Add("Unidad")
        cmbUnidad.Items.Add("ml")
    End Sub

    Sub OrdenarPor(criterio As String)
        Dim listaProductos As New List(Of Producto)
        Dim bsnProductos As New BsnProductos
        lst_productos.Items.Clear()
        listaProductos = bsnProductos.GetProductos(criterio)
        For Each producto As Producto In listaProductos
            If producto.Estado = True Then
                Dim st As String = "-"
                If producto.Unidad = "UN" Then
                    st = producto.Stock
                End If
                lst_productos.Items.Add(String.Format(detalle, producto.CodProducto, producto.NomProducto, st, producto.Unidad))
            End If
        Next
    End Sub

    Function llenar_tipos()
        cmb_tipo.Items.Add("Vacuna")
        cmb_tipo.Items.Add("Insumo")
        cmb_tipo.Items.Add("Accesorio")
        cmb_tipo.Items.Add("Alimento")
        cmb_tipo.Items.Add("Remedio")
        cmb_tipo.Items.Add("Desparasitador")
        Return 0
    End Function

    Sub llenar_proveedores()
        cmb_proveedores.Items.Clear()
        Dim listaProveedores As New List(Of Proveedor) : Dim bsnProveedor As New BsnProveedores
        listaProveedores = bsnProveedor.GetProveedores("cod_proveedor")
        For Each prov As Proveedor In listaProveedores
            cmb_proveedores.Items.Add(String.Format("{0,-5}{1,-20}", prov.IdProveedor, prov.NomProveedor))
        Next
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        btn_cancelar.Visible = True : btn_guardar.Visible = True
        btnCargarImagen.Visible = True : btnQuitarImagen.Visible = True
        LimpiarPanel()
        Dim bsnProducto As New BsnProductos
        lbl_codigo.Text = bsnProducto.GenerarCodProducto
        lst_productos.Enabled = False
        lst_productos.SelectedIndex = -1
        txt_nombre.Focus()
        modalidad = "agregar"
        panelStock.Visible = False
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Trim(txt_nombre.Text) = "" Or cmb_tipo.SelectedIndex = -1 Or cmb_proveedores.SelectedIndex = -1 Or cmbUnidad.SelectedIndex = -1 Then
            MsgBox("Debe ingresar nombre, tipo, proveedor y unidad.")
            Exit Sub
        End If

        Dim producto As New Producto : Dim bsnProducto As New BsnProductos

        producto.CodProducto = Convert.ToInt32(Trim(lbl_codigo.Text))
        producto.NomProducto = UCase(Trim(txt_nombre.Text))

        Dim tp As String = cmb_tipo.SelectedItem : Dim tipo_producto As Char
        Select Case tp
            Case "Vacuna" : tipo_producto = "V"
            Case "Remedio" : tipo_producto = "R"
            Case "Insumo" : tipo_producto = "I"
            Case "Accesorio" : tipo_producto = "A"
            Case "Alimento" : tipo_producto = "L"
            Case "Desparasitador" : tipo_producto = "D"
        End Select
        producto.TipoProducto = tipo_producto
        Dim convertir As New Convertir
        txt_precio.Text = convertir.CorregirDinero(txt_precio.Text)

        producto.Precio = convertir.dinero_a_numero(Trim(txt_precio.Text))

        If txt_stock.Text = "" Then
            producto.Stock = 0
        Else
            producto.Stock = Convert.ToInt32(Trim(txt_stock.Text))
        End If

        If txt_stock_critico.Text = "" Then
            producto.StockCritico = 0
        Else
            producto.StockCritico = Convert.ToInt32(Trim(txt_stock_critico.Text))
        End If

        Dim cadProv As String = cmb_proveedores.SelectedItem
        Dim cod_proveedor As Integer = Convert.ToInt32(Trim(cadProv.Substring(0, 5)))
        producto.CodProveedor = cod_proveedor
        Dim cadUnidad As String = cmbUnidad.SelectedItem
        Select Case cadUnidad
            Case "Unidad" : producto.Unidad = "UN"
            Case "ml" : producto.Unidad = "ML"
        End Select
        Dim stock As New Stock
        If producto.Unidad = "ML" Then
            producto.Stock = 0 : producto.StockCritico = 0
            stock.Codproducto = Convert.ToInt32(Trim(lbl_codigo.Text))

            If Trim(txtCantidadXFrasco.Text) = "" Then
                stock.CantTotal = 0
            Else
                stock.CantTotal = Convert.ToDouble(Trim(txtCantidadXFrasco.Text))
            End If

            If Trim(txtCantActual.Text) = "" Then
                stock.CantActual = 0
            Else
                stock.CantActual = Convert.ToDouble(Trim(txtCantActual.Text))
            End If

            If stock.CantActual > 0 And nudNumFrascos.Value < 1 Then
                MsgBox("El número de frascos no puede ser menor a 1.") : Exit Sub
            Else
                stock.NumFrascos = nudNumFrascos.Value
            End If
        End If

        '////////////// si el nombre esta repetido /////////////////////////
        Dim bsnNegocio As New BsnNegocio : Dim repetidoNombre As Boolean = False
        Dim validarNom As Integer = bsnNegocio.ValidarPorTexto("producto", "nom_producto", producto.NomProducto)
        If validarNom <> -1 Then
            Dim prodAux As New Producto : prodAux = bsnProducto.GetDatosProducto(validarNom)
            Dim provAux As New Proveedor : Dim bsnProveedor As New BsnProveedores : provAux = bsnProveedor.GetDatosProveedor(prodAux.CodProveedor)

            If modalidad = "agregar" Then
                repetidoNombre = True
            End If

            If modalidad = "modificar" Then
                If prodAux.CodProducto <> producto.CodProducto Then
                    repetidoNombre = True
                End If
            End If

            If repetidoNombre = True Then
                MsgBox("Ya existe un producto con el nombre que esta intentando ingresar." & vbLf &
                "*****************************************************************" & vbLf &
                "Código    : " & prodAux.CodProducto & vbLf &
                "Nombre    : " & prodAux.NomProducto & vbLf &
                "Proveedor : " & provAux.NomProveedor)
                Exit Sub
            End If
        End If
        '/////////////////////////////////////////////////////////



        Dim ajuste As New Ajuste
        ajuste.Codproducto = producto.CodProducto : ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Select Case modalidad
            Case "agregar"
                ajuste.TipoAjuste = "I" : ajuste.Cantidad = producto.Stock
                bsnProducto.InsertarProducto(producto)
                If producto.Unidad = "ML" Then
                    bsnProducto.InsertarStock(stock)
                End If
                MsgBox("El producto ha sido registrado correctamente.")
            Case "modificar"

                Dim prodAux As New Producto : prodAux = bsnProducto.GetDatosProducto(producto.CodProducto)
                If prodAux.Unidad <> producto.Unidad Then
                    ajuste.TipoAjuste = "I"
                    If producto.Unidad = "ML" Then
                        ajuste.Cantidad = ((stock.NumFrascos - 1) * stock.CantTotal) + stock.CantActual
                    Else
                        ajuste.Cantidad = producto.Stock
                    End If
                Else
                    ajuste.TipoAjuste = "M"
                    If prodAux.Unidad = "ML" Then
                        Dim stockAux As New Stock : stockAux = bsnProducto.GetDatosStock(producto.CodProducto)

                        Dim s1 As Integer = (stock.NumFrascos - 1) : If s1 < 0 Then s1 = 0
                        Dim s2 As Integer = (stockAux.NumFrascos - 1) : If s2 < 0 Then s2 = 0

                        Dim stockActual As Double = (s1 * stock.CantTotal) + stock.CantActual
                        Dim stockAntes As Double = (s2 * stockAux.CantTotal) + stockAux.CantActual
                        ajuste.Cantidad = stockActual - stockAntes
                        Dim hola As Boolean = True
                    Else
                        ajuste.Cantidad = producto.Stock - prodAux.Stock
                    End If
                End If

                bsnProducto.ModificarProducto(producto) : Dim bsnAjuste As New BsnAjuste : bsnAjuste.InsertarAjuste(ajuste)
                If producto.Unidad = "ML" Then
                    Dim encontrado As Integer = bsnProducto.ValidarStock(producto.CodProducto)
                    If encontrado = -1 Then
                        bsnProducto.InsertarStock(stock)
                    Else
                        bsnProducto.ModificarStock(stock)
                    End If
                End If

                MsgBox("El producto ha sido modificado correctamente.")
        End Select

        Dim ruta As String = "../../img/productos/" & producto.CodProducto & ".jpg"
        If imagenCargada = True Then
            If imagenRepetida = False Then
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                pbProducto.Image.Save(ruta, Imaging.ImageFormat.Jpeg)
            End If
        Else
            If File.Exists(ruta) Then
                My.Computer.FileSystem.DeleteFile(ruta)
            End If
        End If

        btn_agregar.Enabled = True : btn_modificar.Enabled = True : btn_eliminar.Enabled = True
        btn_guardar.Visible = False : btn_cancelar.Visible = False
        btnCargarImagen.Visible = False : btnQuitarImagen.Visible = False
        OrdenarPor("cod_producto") : lst_productos.Enabled = True
        LimpiarPanel() : panelStock.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        _frmPrincipal.Show()
        _frmPrincipal.ContarProductosBajoStock()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub lst_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_productos.SelectedIndexChanged
        If lst_productos.SelectedIndex <> -1 Then
            Dim cadena As String = lst_productos.SelectedItem
            Dim codProducto As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 6)))
            Dim producto As New Producto : Dim bsnProducto As New BsnProductos
            producto = bsnProducto.GetDatosProducto(codProducto)
            LimpiarPanel() : LimpiarPanelStock()
            LlenarPanelProducto(producto)
        End If
    End Sub

    Sub LlenarPanelProducto(producto As Producto)
        lbl_codigo.Text = producto.CodProducto : txt_nombre.Text = producto.NomProducto

        '////////////////buscar tipo producto///////////////////
        Dim tipoS As String = ""
        Select Case producto.TipoProducto
            Case "V" : tipoS = "Vacuna"
            Case "R" : tipoS = "Remedio"
            Case "I" : tipoS = "Insumo"
            Case "A" : tipoS = "Accesorio"
            Case "L" : tipoS = "Alimento"
            Case "D" : tipoS = "Desparasitador"
        End Select

        Dim i As Integer = 0 : Dim lg = cmb_tipo.Items.Count : Dim encontrado As Boolean = False

        While i < lg And encontrado = False
            Dim cd1 As String = Trim(cmb_tipo.Items.Item(i).ToString)
            If tipoS = cd1 Then
                cmb_tipo.SelectedIndex = i : encontrado = True
            End If
            i = i + 1
        End While
        '/////////////////////////////////////////////////////////

        i = 0 : lg = cmb_proveedores.Items.Count : encontrado = False
        While i < lg And encontrado = False
            Dim cd2 As String = cmb_proveedores.Items.Item(i).ToString
            Dim codProveedor As Integer = Convert.ToInt32(Trim(cd2.Substring(0, 5)))
            If codProveedor = producto.CodProveedor Then
                cmb_proveedores.SelectedIndex = i : encontrado = True
            End If
            i = i + 1
        End While
        Dim convertir As New Convertir : txt_precio.Text = convertir.convertir_dinero(producto.Precio)
        txt_stock.Text = producto.Stock : txt_stock_critico.Text = producto.StockCritico

        i = 0 : lg = cmbUnidad.Items.Count : encontrado = False

        Dim unidadS As String = ""

        Select Case producto.Unidad
            Case "UN" : unidadS = "Unidad"
            Case "ML" : unidadS = "ml"
        End Select

        While i < lg And encontrado = False
            Dim cad3 As String = cmbUnidad.Items.Item(i)
            If cad3 = unidadS Then
                encontrado = True
                cmbUnidad.SelectedIndex = i
            End If
            i = i + 1
        End While

        If producto.Unidad = "ML" Then
            Dim stock As New Stock : Dim bsnProducto As New BsnProductos
            stock = bsnProducto.GetDatosStock(producto.CodProducto)
            txtCantidadXFrasco.Text = stock.CantTotal
            txtCantActual.Text = stock.CantActual
            nudNumFrascos.Value = stock.NumFrascos
            Label5.Text = "Precio Frasco :"

            If stock.NumFrascos < 2 And stock.CantActual < stock.CantTotal Then
                lblAlertaStock.Visible = True
            Else
                lblAlertaStock.Visible = False
            End If
        Else
            Label5.Text = "Precio :"
            If producto.Stock <= producto.StockCritico Then
                lblAlertaStock.Visible = True
            Else
                lblAlertaStock.Visible = False
            End If
        End If

        Dim ruta As String = "../../img/productos/" & producto.CodProducto & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbProducto.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            imagenCargada = True
            imagenRepetida = True
        Else
            pbProducto.Image = My.Resources.cosa
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If lst_productos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un producto de la lista.") : Exit Sub
        End If
        btn_agregar.Enabled = False : btn_modificar.Enabled = False : btn_eliminar.Enabled = False
        btn_guardar.Visible = True : btn_cancelar.Visible = True
        btnCargarImagen.Visible = True : btnQuitarImagen.Visible = True
        txt_nombre.Focus()
        lst_productos.Enabled = False : lst_productos.SelectedIndex = -1
        modalidad = "modificar"
    End Sub

    Private Sub btnOrdenarNombre_Click(sender As Object, e As EventArgs) Handles btnOrdenarNombre.Click
        OrdenarPor("nom_producto")
    End Sub

    Private Sub btnOrdenarCodigo_Click(sender As Object, e As EventArgs) Handles btnOrdenarCodigo.Click
        OrdenarPor("cod_producto")
    End Sub

    Private Sub btnOrdenarStock_Click(sender As Object, e As EventArgs) Handles btnOrdenarStock.Click
        OrdenarPor("stock")
    End Sub

    Private Sub btnOrdenarUnidad_Click(sender As Object, e As EventArgs) Handles btnOrdenarUnidad.Click
        OrdenarPor("unidad")
    End Sub

    Sub BloquearBusqueda()
        txtBusquedaCodigo.Enabled = False : txtBusquedaNombre.Enabled = False
        txtBusquedaStock.Enabled = False : txtBusquedaUnidad.Enabled = False
    End Sub

    Sub DesbloquearBusqueda()
        txtBusquedaCodigo.Enabled = True : txtBusquedaNombre.Enabled = True
        txtBusquedaStock.Enabled = True : txtBusquedaUnidad.Enabled = True
    End Sub

    Sub BloquearOpciones()
        btn_agregar.Enabled = False : btn_modificar.Enabled = False : btn_eliminar.Enabled = False
    End Sub

    Sub DesbloquearOpciones()
        btn_agregar.Enabled = True : btn_modificar.Enabled = True : btn_eliminar.Enabled = True
    End Sub

    Sub LimpiarPanel()
        lbl_codigo.Text = "" : txt_nombre.Text = "" : txt_precio.Text = "" : txt_stock_critico.Text = ""
        cmb_tipo.SelectedIndex = -1 : cmb_proveedores.SelectedIndex = -1
        txt_stock.Text = "" : pbProducto.Image = My.Resources.cosa : cmbUnidad.SelectedIndex = -1
        txt_stock.Visible = True : txt_stock_critico.Visible = True : Label6.Visible = True : Label7.Visible = True
        Label5.Text = "Precio :" : cmbUnidad.SelectedIndex = -1 : lblAlertaStock.Visible = False
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        LimpiarPanel() : DesbloquearBusqueda() : DesbloquearOpciones()
        lst_productos.Enabled = True
        btnCargarImagen.Visible = False : btnQuitarImagen.Visible = False
        btn_guardar.Visible = False : btn_cancelar.Visible = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If lst_productos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un producto de la lista.")
        End If
        Dim cadena As String = lst_productos.SelectedItem
        Dim codProducto As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
        Dim bsnNegocio As New BsnNegocio : Dim bsnProducto As New BsnProductos

        Dim validarDetVenta As Integer = bsnNegocio.ValidarPorNumero("detalle_venta", "cod_producto", codProducto)
        Dim validarVacuna As Integer = bsnNegocio.ValidarPorNumero("vacuna_mascota", "cod_producto", codProducto)

        If MessageBox.Show("¿Esta seguro que desea eliminar este producto?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If (validarDetVenta <> -1) Or (validarVacuna <> -1) Then
                MsgBox("No se puede eliminar el producto porque hay elementos asociados al registro.")
            Else
                Dim producto As New Producto : producto = bsnProducto.GetDatosProducto(codProducto)
                If producto.Unidad = "ML" Then
                    bsnProducto.EliminarStockMl(codProducto)
                End If
                bsnProducto.EliminarProductoFisico(codProducto)
                Dim ruta As String = "../../img/productos/" & codProducto & ".jpg"
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                MsgBox("El producto ha sido eliminado del sistema.")
                LimpiarPanel() : LimpiarPanelStock() : OrdenarPor("cod_producto")
            End If
        End If
    End Sub

    Private Sub txtBusquedaCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaCodigo.TextChanged
        BuscarPor("cod_producto", 0)

    End Sub

    Sub BuscarPor(criterio As String, inicio As Integer)
        Dim valorBusqueda As String = ""
        Select Case criterio
            Case "cod_producto" : valorBusqueda = txtBusquedaCodigo.Text
            Case "nom_producto" : valorBusqueda = txtBusquedaNombre.Text
            Case "stock" : valorBusqueda = txtBusquedaStock.Text
            Case "unidad" : valorBusqueda = txtBusquedaUnidad.Text
        End Select
        valorBusqueda = UCase(Trim(valorBusqueda))
        Dim lgb As Integer = valorBusqueda.Length
        Dim i As Integer = inicio : Dim lg As Integer = lst_productos.Items.Count : Dim encontrado As Boolean = False
        While i < lg And encontrado = False
            Dim cadena As String = lst_productos.Items.Item(i)
            Dim valorTabla As String = ""
            Select Case criterio
                Case "cod_producto" : valorTabla = cadena.Substring(0, lgb)
                Case "nom_producto" : valorTabla = cadena.Substring(6, lgb)
                Case "stock" : valorTabla = cadena.Substring(38, lgb)
                Case "unidad" : valorTabla = cadena.Substring(44, lgb)
            End Select
            valorTabla = UCase(valorTabla)
            If valorBusqueda = valorTabla And valorBusqueda <> "" Then
                encontrado = True
                lst_productos.SelectedIndex = i
            End If
            i = i + 1
        End While

        If encontrado = False Then
            lst_productos.SelectedIndex = -1
            LimpiarPanel()
            If valorBusqueda <> "" Then
                RojoBusqueda(criterio)
            Else
                BlancoBusqueda(criterio)
            End If
        Else
            BlancoBusqueda(criterio)
        End If
    End Sub

    Sub BlancoBusqueda(criterio As String)
        Select Case criterio
            Case "cod_producto" : txtBusquedaCodigo.BackColor = Color.White
            Case "nom_producto" : txtBusquedaNombre.BackColor = Color.White
            Case "stock" : txtBusquedaStock.BackColor = Color.White
            Case "unidad" : txtBusquedaUnidad.BackColor = Color.White
        End Select
    End Sub

    Sub RojoBusqueda(criterio As String)
        Select Case criterio
            Case "cod_producto" : txtBusquedaCodigo.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case "nom_producto" : txtBusquedaNombre.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case "stock" : txtBusquedaStock.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case "unidad" : txtBusquedaUnidad.BackColor = Color.FromArgb(255, 255, 192, 192)
        End Select
    End Sub

    Private Sub txtBusquedaNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaNombre.TextChanged
        BuscarPor("nom_producto", 0)

    End Sub

    Private Sub txtBusquedaStock_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaStock.TextChanged
        BuscarPor("stock", 0)
    End Sub

    Private Sub txtBusquedaUnidad_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaUnidad.TextChanged
        BuscarPor("unidad", 0)
    End Sub

    Private Sub txtBusquedaCodigo_Enter(sender As Object, e As EventArgs) Handles txtBusquedaCodigo.Enter
        txtBusquedaNombre.Text = "" : txtBusquedaStock.Text = "" : txtBusquedaUnidad.Text = ""
    End Sub

    Private Sub txtBusquedaNombre_Enter(sender As Object, e As EventArgs) Handles txtBusquedaNombre.Enter
        txtBusquedaCodigo.Text = "" : txtBusquedaStock.Text = "" : txtBusquedaUnidad.Text = ""
    End Sub

    Private Sub txtBusquedaStock_Enter(sender As Object, e As EventArgs) Handles txtBusquedaStock.Enter
        txtBusquedaNombre.Text = "" : txtBusquedaCodigo.Text = "" : txtBusquedaUnidad.Text = ""
    End Sub

    Private Sub txtBusquedaUnidad_Enter(sender As Object, e As EventArgs) Handles txtBusquedaUnidad.Enter
        txtBusquedaNombre.Text = "" : txtBusquedaStock.Text = "" : txtBusquedaCodigo.Text = ""
    End Sub

    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Imagenes | *.jpg;*.png"
        ofd.RestoreDirectory = True
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim alto As Integer = Image.FromFile(ofd.FileName).Size.Height
            Dim ancho As Integer = Image.FromFile(ofd.FileName).Size.Width
            Dim proporcion As Double = alto / ancho

            If proporcion < 0.6 Then
                MsgBox("La imagen es demasiado ancha en relación a su altura.")
                Exit Sub
            End If

            If proporcion > 1.5 Then
                MsgBox("La imagen es demasiado alta en relación a su ancho.")
                Exit Sub
            End If

            Dim fichero As New FileInfo(ofd.FileName)
            If fichero.Length > 2500000 Then
                Dim tamaño As Double = fichero.Length / 1000000
                MsgBox("La imagen tiene un tamaño muy elevado." & vbLf & "El máximo permitido es de 2,5MB" & vbLf &
                       "Su imagen tiene un tamaño de " & Format(tamaño, "#####.0") & "MB")
                Exit Sub
            End If

            pbProducto.Image = Image.FromFile(ofd.FileName)
            imagenCargada = True
            imagenRepetida = False
        End If
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        pbProducto.Image = My.Resources.cosa
        imagenCargada = False
        imagenRepetida = False
    End Sub

    Private Sub txtBusquedaCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPor("cod_producto", lst_productos.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txtBusquedaNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPor("nom_producto", lst_productos.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txtBusquedaStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaStock.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPor("stock", lst_productos.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txtBusquedaUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaUnidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPor("unidad", lst_productos.SelectedIndex + 1)
        End If
    End Sub

    Private Sub btnDetStock_Click(sender As Object, e As EventArgs) Handles btnDetStock.Click
        If panelStock.Visible = False Then
            panelStock.Left = 11 : panelStock.Top = 13 : panelStock.Width = 440 : panelStock.Height = 513
            panelStock.Visible = True
        Else
            panelStock.Visible = False
        End If
    End Sub

    Private Sub txtCantActual_TextChanged(sender As Object, e As EventArgs) Handles txtCantActual.TextChanged
        RecalcularPorcentaje()
    End Sub

    Sub RecalcularPorcentaje()
        Try
            Dim bloque As New BloqueCodigo
            bloque.FormatoDecimalPunto()

            Dim cantActual As Double = 0
            If Trim(txtCantActual.Text) <> "" Then
                cantActual = Convert.ToDouble(Trim(txtCantActual.Text))
            End If

            Dim cantTotal As Double = 0
            If Trim(txtCantidadXFrasco.Text) <> "" Then
                cantTotal = Convert.ToDouble(Trim(txtCantidadXFrasco.Text))
            End If

            Dim altura As Integer = 0
            Dim porcentaje As Integer = 0
            If cantActual > cantTotal Then
                MsgBox("La cantidad actual no puede ser mayor a la capacidad del frasco.")
                txtCantActual.Text = txtCantidadXFrasco.Text
                RecalcularPorcentaje() : Exit Sub
            Else
                If cantTotal = 0 Then
                    porcentaje = 0
                Else
                    porcentaje = (cantActual / cantTotal) * 100
                End If
                altura = porcentaje * 1.4
            End If

            lblPorcentaje.Text = porcentaje & "%"
            Dim resto As Integer = 140 - altura
            pbContenido.Top = 59 + resto
            pbContenido.Height = altura
        Catch ex As Exception
            MsgBox("Error de ingreso de valores para el stock.")
            txtCantidadXFrasco.Text = 100 : txtCantActual.Text = txtCantidadXFrasco.Text
            RecalcularPorcentaje()
        End Try
    End Sub

    Private Sub txtCantidadXFrasco_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadXFrasco.TextChanged
        RecalcularPorcentaje()
    End Sub

    Sub LimpiarPanelStock()
        nudNumFrascos.Value = 0 : txtCantActual.Text = "" : txtCantidadXFrasco.Text = ""
        lblPorcentaje.Text = "0%" : pbContenido.Height = 0
    End Sub

    Private Sub cmbUnidad_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cadena As String = cmbUnidad.SelectedItem
        If cadena = "ml" And lst_productos.SelectedIndex <> -1 Or
            cadena = "Vacuna - Múltiple Dosis" And lst_productos.SelectedIndex <> -1 Then
            btnDetStock.Visible = True
            txt_stock.Visible = False : Label6.Visible = False
        Else
            btnDetStock.Visible = False : panelStock.Visible = False
            txt_stock.Visible = True : Label6.Visible = True
        End If
    End Sub

    Private Sub nudNumFrascos_ValueChanged(sender As Object, e As EventArgs) Handles nudNumFrascos.ValueChanged
        If nudNumFrascos.Value = 0 Then
            txtCantActual.Text = "0"
        End If
    End Sub

    Private Sub cmbUnidad_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbUnidad.SelectedIndexChanged
        If cmbUnidad.SelectedIndex = -1 Then
            txt_stock.Visible = True : txt_stock_critico.Visible = True : Label6.Visible = True : Label7.Visible = True
            btnDetStock.Visible = False
        End If

        Dim cadena As String = cmbUnidad.SelectedItem

        If cadena = "ml" Or cadena = "Vacuna - Múltiple Dosis" Then
            txt_stock.Visible = False : txt_stock_critico.Visible = False : Label6.Visible = False : Label7.Visible = False
            btnDetStock.Visible = True
        Else
            txt_stock.Visible = True : txt_stock_critico.Visible = True : Label6.Visible = True : Label7.Visible = True
            btnDetStock.Visible = False
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio.KeyPress
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

    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        If (Asc(e.KeyChar) <> 8) Then 'borrar
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_stock_critico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock_critico.KeyPress
        If (Asc(e.KeyChar) <> 8) Then 'borrar
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCantidadXFrasco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadXFrasco.KeyPress
        Dim caracter As Char = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Then
            Dim i As Integer = 0 : Dim lg As Integer = txtCantidadXFrasco.Text.Length
            While i < lg And encontrado = False
                If txtCantidadXFrasco.Text.Chars(i) = "." Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 46) Then 'punto
            If (Asc(e.KeyChar) <> 8) Then 'borrar
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtCantActual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantActual.KeyPress
        Dim caracter As Char = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Then
            Dim i As Integer = 0 : Dim lg As Integer = txtCantActual.Text.Length
            While i < lg And encontrado = False
                If txtCantActual.Text.Chars(i) = "." Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 46) Then 'punto
            If (Asc(e.KeyChar) <> 8) Then 'borrar
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub nudNumFrascos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nudNumFrascos.KeyPress
        If (Asc(e.KeyChar) <> 8) Then 'borrar
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                e.Handled = True
            End If
        End If
    End Sub
End Class
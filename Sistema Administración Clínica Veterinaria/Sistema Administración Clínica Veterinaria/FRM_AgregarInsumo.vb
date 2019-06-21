Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FRM_AgregarInsumo

    Protected _idAtencion As Integer
    Protected _frmRegistrarAtencion As frm_Registrar_Atencion
    Protected _frmDetalleHosp As FRM_DetalleHospitalizacion
    Protected _idHosp As Integer

    Dim detalle As String = "{0,-5}{1,-30}"
    Dim detalleInsumo As String = "{0,-1}{1,-6}{2,-32}{3,-4}{4,-8}"
    Dim _modoVentana As String = ""
    Dim _periodo As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(idAtencion As Integer, frmRegistrarAtencion As frm_Registrar_Atencion)
        _idAtencion = idAtencion
        _frmRegistrarAtencion = frmRegistrarAtencion
        _modoVentana = "atencion"
        InitializeComponent()
    End Sub

    Public Sub New(frmDetalleHosp As FRM_DetalleHospitalizacion, idHosp As Integer)
        _frmDetalleHosp = frmDetalleHosp
        _idHosp = idHosp
        _modoVentana = "hosp"
        InitializeComponent()
    End Sub

    Private Sub FRM_IngresarInsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _modoVentana
            Case "atencion"
                lblCodAtencion.Text = _idAtencion
            Case "hosp"
                panelEspInsumo.Left = 550 : panelEspInsumo.Width = 360
                panelPeriodo.Visible = True : panelPeriodo.Left = 359
                lblDosis.Left = 11 : txtDosis.Left = 15
                txtCantidad.Left = 124 : lblCantidad.Left = 120 : lblCantidad.Text = "T. Admin."
                lbl_pre.Left = 235 : txtPrecio.Left = 232

        End Select



        CargarInsumos()
        lblFecha.Text = System.DateTime.Today
        Limpiarpanel()
    End Sub

    Sub Limpiarpanel()
        lblCodigo.Text = "" : lblNombre.Text = "" : lblProveedor.Text = "" : lblPrecio.Text = "" : lblStock.Text = "" : lblUnidad.Text = ""
    End Sub

    Sub CargarInsumos()
        Dim listaInsumos As New List(Of Producto) : Dim bsnproducto As New BsnProductos
        listaInsumos = bsnproducto.GetProductos("cod_producto")
        lstProductos.Items.Clear()
        For Each insumo As Producto In listaInsumos
            If insumo.TipoProducto = "I" Or insumo.TipoProducto = "D" Then
                lstProductos.Items.Add(String.Format(detalle, insumo.CodProducto, insumo.NomProducto))
            End If
        Next
    End Sub

    Private Sub lstProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductos.SelectedIndexChanged
        If lstProductos.SelectedIndex <> -1 Then
            panelEspInsumo.Visible = True
            Dim producto As New Producto : Dim bsnProducto As New BsnProductos
            Dim proveedor As New Proveedor : Dim bsnProveedor As New BsnProveedores
            Dim cadena As String = lstProductos.SelectedItem
            Dim codProducto As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))

            producto = bsnProducto.GetDatosProducto(codProducto)
            proveedor = bsnProveedor.GetDatosProveedor(producto.CodProveedor)

            Dim convertir As New Convertir
            lblCodigo.Text = producto.CodProducto : lblNombre.Text = producto.NomProducto
            lblProveedor.Text = proveedor.NomProveedor : lblPrecio.Text = convertir.CorregirDinero(producto.Precio)
            lblStock.Text = producto.Stock : lblUnidad.Text = producto.Unidad

            Dim ruta As String = "../../img/productos/" & codProducto & ".jpg"
            If File.Exists(ruta) Then
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
                pbInsumo.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()
            Else
                pbInsumo.Image = My.Resources.remedio
            End If

            If producto.Unidad = "ML" Then
                Select Case _modoVentana
                    Case "atencion" : lblCantidad.Text = "Dosis : "
                    Case "hosp" : lblCantidad.Text = "T. Admin."
                End Select

                Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
                lblStock.Text = stock.NumFrascos & " frascos - " & "Frasco Actual : " &
                    stock.CantActual & "/" & stock.CantTotal & "ml"

                lblDosis.Visible = True : txtDosis.Visible = True
                panelPeriodo.Visible = True
            Else
                lblCantidad.Text = "Cantidad : "
                lblDosis.Visible = False : txtDosis.Visible = False : txtDosis.Text = "0"
                panelPeriodo.Visible = False
                _periodo = 0
            End If
            txtPrecio.Text = convertir.CorregirDinero(producto.Precio) : txtCantidad.Text = "1"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Select Case _modoVentana
            Case "atencion" : _frmRegistrarAtencion.Show()
            Case "hosp" : _frmDetalleHosp.Show()
        End Select
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim bloque As New BloqueCodigo : bloque.FormatoDecimalPunto()
        If lstProductos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un Insumo de la lista.")
            Exit Sub
        End If

        If Trim(txtCantidad.Text) = "" Then
            MsgBox("Debe ingresar una cantidad.") : Exit Sub
        Else
            Dim cantAux As Double = Convert.ToDouble(Trim(txtCantidad.Text))
            If cantAux = 0 Then
                MsgBox("Debe ingresar una cantidad.") : Exit Sub
            End If
        End If

        Dim dosAux2 As Double = 0
        Try
            dosAux2 = Convert.ToDouble(Trim(txtDosis.Text))
        Catch ex As Exception
        End Try

        If Trim(txtPrecio.Text = "") Then
            MsgBox("Debe ingresar un precio.")
            Exit Sub
        End If

        Dim convertir As New Convertir
        Dim codProducto As Integer = Convert.ToInt32(Trim(lblCodigo.Text))
        Dim producto As New Producto : Dim bsnproducto As New BsnProductos
        producto = bsnproducto.GetDatosProducto(codProducto)



        If _modoVentana = "atencion" Then
            '////////buscar si ya existe en la lista/////////////////
            Dim i As Integer = 0 : Dim lg As Integer = _frmRegistrarAtencion.lstAgregados.Items.Count
            While i < lg
                Dim tipo_detalle As String = _frmRegistrarAtencion.lstAgregados.Items(i).SubItems(0).Text
                If tipo_detalle = "I" Then
                    Dim codTabla As Integer = Convert.ToInt32(Trim(_frmRegistrarAtencion.lstAgregados.Items(i).SubItems(1).Text))
                    If codProducto = codTabla Then
                        MsgBox("El producto que usted desea ingresar ya existe en la lista" & vbLf &
                           "Si desea modificar la cantidad/dosis puede seleccionar el elemento de la lista.")
                        Exit Sub
                    End If
                End If
                i = i + 1
            End While
            '/////////////////////////
        End If

        If _modoVentana = "hosp" Then
            Dim i As Integer = 0 : Dim lg As Integer = _frmDetalleHosp.GetLargoLista
            Dim listaAux As List(Of DetHosp) = _frmDetalleHosp.GetLista
            While i < lg
                Dim codTabla As Integer = listaAux.Item(i).CodProducto
                If codTabla = codProducto Then
                    MsgBox("El producto que usted desea ingresar ya existe en la lista" & vbLf &
                    "Si desea modificar la cantidad/dosis puede seleccionar el elemento de la lista.")
                    Exit Sub
                End If
                i = i + 1
            End While
        End If

        '///////////corroborar stock//////////////////////////////
        Dim cantDou As New Double : Dim cantInt As New Integer
        If producto.Unidad = "ML" Then
            cantDou = Convert.ToDouble(Trim(txtCantidad.Text))
            Dim stock As New Stock
            stock = bsnproducto.GetDatosStock(producto.CodProducto)
            Dim valorDou As Double = (stock.CantTotal * (stock.NumFrascos - 1)) + stock.CantActual
            If valorDou < cantDou Then
                MsgBox("La dosis ingresada es superior al stock actual de este producto.") : Exit Sub
            End If
            If _periodo = 0 Then
                MsgBox("Debe ingresar una periodicidad.") : Exit Sub
            End If
        Else
            cantInt = Convert.ToInt32(Trim(txtCantidad.Text))
            If producto.Stock < cantInt Then
                MsgBox("La cantidad ingresada es superior al stock actual de este producto.")
                Exit Sub
            End If
        End If
        '///////////////////////////////////////////////////

        txtPrecio.Text = convertir.CorregirDinero(txtPrecio.Text)
        Dim precio As Integer = convertir.dinero_a_numero(txtPrecio.Text)


        Select Case _modoVentana
            Case "atencion"
                With _frmRegistrarAtencion.lstAgregados.Items.Add("I")
                    .SubItems.Add(codProducto)
                    .SubItems.Add(producto.NomProducto)
                    Dim detAux As String = "{0,-4}{1,-8}"
                    If producto.Unidad = "ML" Then
                        .SubItems.Add(cantDou)
                        .SubItems.Add(convertir.convertir_dinero(precio))
                    Else
                        .SubItems.Add(String.Format(detAux, cantInt, precio))
                        .SubItems.Add(convertir.convertir_dinero(cantInt * precio))
                    End If
                End With
                _frmRegistrarAtencion.ActualizarTotal() : _frmRegistrarAtencion.Show()
            Case "hosp"
                Dim detAux3 As New DetHosp : detAux3.IdHosp = _idHosp
                detAux3.CodProducto = producto.CodProducto
                detAux3.Periodicidad = _periodo
                detAux3.Precio = precio

                If producto.Unidad = "ML" Then
                    detAux3.Dosis = dosAux2 : detAux3.Cantidad = cantDou
                Else
                    detAux3.Cantidad = cantInt
                End If

                _frmDetalleHosp.AgregarDetalle(detAux3) : _frmDetalleHosp.CargarDetalles() : _frmDetalleHosp.SetCambioRealizado(True)
                _frmDetalleHosp.CalcularTotales() : _frmDetalleHosp.Show()
        End Select
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Dim codProducto As Integer = Convert.ToInt32(Trim(lblCodigo.Text))
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(codProducto)

        Dim caracter As Char = e.KeyChar
        If producto.Unidad = "UN" Then
            If caracter = "." Or caracter = "," Then
                e.Handled = True
            End If
        Else
            Dim encontrado As Boolean = False
            If caracter = "." Or caracter = "," Then
                Dim i As Integer = 0 : Dim lg As Integer = txtCantidad.Text.Length
                While i < lg And encontrado = False
                    If txtCantidad.Text.Chars(i) = "." Or txtCantidad.Text.Chars(i) = "," Then
                        e.Handled = True : encontrado = True
                    End If
                    i = i + 1
                End While
            End If
        End If

        If (Asc(e.KeyChar) <> 44) Then  'coma
            If (Asc(e.KeyChar) <> 46) Then 'punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
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

    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        _periodo = 4
    End Sub

    Private Sub rb6_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged
        _periodo = 6
    End Sub

    Private Sub rb8_CheckedChanged(sender As Object, e As EventArgs) Handles rb8.CheckedChanged
        _periodo = 8
    End Sub

    Private Sub rb12_CheckedChanged(sender As Object, e As EventArgs) Handles rb12.CheckedChanged
        _periodo = 12
    End Sub

    Private Sub rb24_CheckedChanged(sender As Object, e As EventArgs) Handles rb24.CheckedChanged
        _periodo = 24
    End Sub
End Class
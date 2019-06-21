Imports System.IO

Public Class FRM_DetalleHospitalizacion

    Protected _frmGestorHosp As FRM_Gestor_Hospitalizaciones
    Protected _mascota As Mascota
    Protected _listaDetalles As List(Of DetHosp)
    Protected _listaEliminados As New List(Of DetHosp)
    Protected _subSelected As Integer
    Protected _estadoDesplegar As Boolean = False
    Protected _cambioRealizado As Boolean = False
    Protected _hosp As New Hospitalizacion


    Dim detalle As String = "{0,-2}{1,-25}{2,-3}{3,-3}{4,-3}{5,-3}{6,-3}{7,-5}{8,-7}"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(hosp As Hospitalizacion, frmGestorHosp As FRM_Gestor_Hospitalizaciones, listaDetalles As List(Of DetHosp))
        _hosp = hosp
        _frmGestorHosp = frmGestorHosp
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota
        mascota = bsnMascota.GetDatosMascota(hosp.IdFicha)
        _mascota = mascota
        _listaDetalles = listaDetalles
        InitializeComponent()
    End Sub

    Private Sub FRM_DetalleHospitalizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalPagar.Text = "" : lblTotalInsumos.Text = ""
        lblIdHosp.Text = _hosp.IdHosp : lblNomMascota.Text = _mascota.NomMascota
        LimpiarPanelDetalle()
        CargarDetalles()
        txtTotalHosp.Text = _hosp.Total : txtTotalConsulta.Text = _hosp.ValorConsulta
        CalcularTotales()
    End Sub

    Sub CargarDetalles()
        lstDetallesHosp.Items.Clear() : Dim altura As Integer = 0 : Dim suma As Integer = 0 : Dim convertir As New Convertir
        For Each detalle As DetHosp In _listaDetalles
            Dim producto As New Producto : Dim bsnProducto As New BsnProductos : producto = bsnProducto.GetDatosProducto(detalle.CodProducto)
            With lstDetallesHosp.Items.Add(detalle.CodProducto)
                .SubItems.Add(producto.NomProducto)
                If producto.Unidad = "ML" Then
                    .SubItems.Add(detalle.Periodicidad)
                    .SubItems.Add(detalle.Dosis)
                Else
                    .SubItems.Add("-")
                    .SubItems.Add("-")
                End If
                .SubItems.Add(detalle.Cantidad)
                .SubItems.Add(convertir.convertir_dinero(detalle.Precio))
            End With
            suma = suma + detalle.Precio
        Next
        lblTotalInsumos.Text = convertir.convertir_dinero(suma)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        RegistrarNuevosDetalles()
        _frmGestorHosp.LlenarPanel(_hosp.IdHosp)
        _frmGestorHosp.Show()
        Me.Close()
    End Sub

    Sub RegistrarNuevosDetalles()
        If _cambioRealizado = True Then
            If MessageBox.Show("¿Desea guardar los cambios realizados?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim bsnDetHosp As New BsnDetHosp : Dim bsnProducto As New BsnProductos
                For Each detHosp As DetHosp In _listaEliminados
                    Dim existe As Boolean = BsnDetHosp.ValidarDetalleHosp(detHosp)
                    If existe = True Then
                        bsnDetHosp.EliminarDetalleHosp(detHosp)
                        Dim prel As New Producto : prel = bsnProducto.GetDatosProducto(detHosp.CodProducto)
                        If prel.Unidad = "ML" Then
                            Dim stockAux2 As New Stock : stockAux2 = bsnProducto.GetDatosStock(prel.CodProducto)
                            If stockAux2.CantActual + detHosp.Cantidad >= stockAux2.CantTotal Then
                                If stockAux2.CantActual + detHosp.Cantidad = stockAux2.CantTotal Then
                                    stockAux2.CantActual = stockAux2.CantTotal
                                Else
                                    stockAux2.NumFrascos = stockAux2.NumFrascos + 1
                                    stockAux2.CantActual = (detHosp.Cantidad - (stockAux2.CantTotal - stockAux2.CantActual))
                                End If
                                bsnProducto.ModificarStock(stockAux2)
                            Else
                                stockAux2.CantActual = stockAux2.CantActual + detHosp.Cantidad
                                bsnProducto.ModificarStock(stockAux2)
                            End If
                        Else
                            prel.Stock = prel.Stock + detHosp.Cantidad
                            bsnProducto.ModificarProducto(prel)
                        End If

                        Dim ajuste As New Ajuste
                        ajuste.Codproducto = prel.CodProducto : ajuste.TipoAjuste = "H"
                        ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        ajuste.Cantidad = detHosp.Cantidad
                    End If
                Next

                Dim i As Integer = 0 : Dim lg As Integer = _listaDetalles.Count
                For Each detHosp As DetHosp In _listaDetalles
                    Dim producto As New Producto
                    producto = bsnProducto.GetDatosProducto(detHosp.CodProducto)


                    Dim existe As Boolean = bsnDetHosp.ValidarDetalleHosp(detHosp)
                    If existe = True Then
                        '/////////////////////////////actualizar stock/////////////////
                        Dim detAux As New DetHosp : detAux = bsnDetHosp.GetDatosDetalleHosp(detHosp.IdHosp, detHosp.CodProducto)
                        Dim diferencia As New Double : diferencia = detAux.Cantidad - detHosp.Cantidad
                        Select Case producto.Unidad
                            Case "UN"
                                producto.Stock = producto.Stock + diferencia
                                bsnProducto.ModificarProducto(producto)
                            Case "ML"
                                Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
                                If stock.CantActual + diferencia <= 0 Then
                                    stock.NumFrascos = stock.NumFrascos - 1
                                    If stock.NumFrascos = 0 Then
                                        stock.CantActual = 0
                                    Else
                                        stock.CantActual = stock.CantTotal - ((diferencia * -1) - stock.CantActual)
                                    End If
                                Else
                                    If stock.CantActual + diferencia >= stock.CantTotal Then
                                        Dim valAux As Double = ((stock.NumFrascos - 1) * stock.CantTotal) + stock.CantActual + diferencia
                                        If stock.CantActual + diferencia = stock.CantTotal Then
                                            stock.CantActual = stock.CantTotal
                                        Else
                                            stock.CantActual = valAux - (stock.NumFrascos * stock.CantTotal)
                                            stock.NumFrascos = stock.NumFrascos + 1
                                        End If
                                    Else
                                        stock.CantActual = stock.CantActual + diferencia
                                    End If
                                End If
                                bsnProducto.ModificarStock(stock)
                        End Select
                        bsnDetHosp.ModificarDetalleHosp(detHosp)
                        '///////////////registrar ajuste de inventario//////////////
                        If diferencia <> 0 Then
                            Dim ajuste As New Ajuste : Dim bsnAjuste As New BsnAjuste
                            ajuste.Codproducto = detHosp.CodProducto
                            ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                            ajuste.TipoAjuste = "H" : ajuste.Cantidad = diferencia
                            bsnAjuste.InsertarAjuste(ajuste)
                        End If
                    Else
                        bsnDetHosp.InsertarDetalleHosp(detHosp)

                        '////////////registrar ajuste de inventario///////////
                        Dim ajuste As New Ajuste : Dim bsnAjuste As New BsnAjuste
                        ajuste.Codproducto = detHosp.CodProducto
                        ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        ajuste.TipoAjuste = "H" : ajuste.Cantidad = detHosp.Cantidad * -1
                        bsnAjuste.InsertarAjuste(ajuste)

                        '/////////////////////////////actualizar stock/////////////////
                        Select Case producto.Unidad
                            Case "UN"
                                producto.Stock = producto.Stock - detHosp.Cantidad
                                bsnProducto.ModificarProducto(producto)
                            Case "ML"
                                Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
                                If stock.CantActual <= detHosp.Cantidad Then
                                    stock.NumFrascos = stock.NumFrascos - 1
                                    If stock.NumFrascos = 0 Then
                                        stock.CantActual = 0
                                    Else
                                        stock.CantActual = stock.CantTotal - (detHosp.Cantidad - stock.CantActual)
                                    End If
                                Else
                                    stock.CantActual = stock.CantActual - detHosp.Cantidad
                                End If
                                bsnProducto.ModificarStock(stock)
                        End Select
                    End If
                Next


                Dim hosp As New Hospitalizacion : Dim bsnHosp As New BsnHospitalizacion
                Dim convertir As New Convertir
                hosp = _hosp
                txtTotalHosp.Text = convertir.CorregirDinero(txtTotalHosp.Text)
                hosp.Total = convertir.dinero_a_numero(txtTotalHosp.Text)
                txtTotalConsulta.Text = convertir.CorregirDinero(txtTotalConsulta.Text)
                hosp.ValorConsulta = convertir.dinero_a_numero(txtTotalConsulta.Text)
                bsnHosp.ModificarHospitalizacion(hosp)
            End If
        End If
    End Sub

    Sub LimpiarPanelDetalle()
        lblCodProducto.Text = "" : lblNomProducto.Text = "" : txtCantidad.Text = "" : txtPrecio.Text = ""
        _subSelected = 0 : txtDosis.Text = ""
        rb4.Checked = False : rb6.Checked = False : rb8.Checked = False : rb12.Checked = False : rb24.Checked = False
        pbProducto.Image = My.Resources.remedio : txtDosis.Visible = True
    End Sub

    Sub CalcularTotales()
        Dim convertir As New Convertir : Dim totalInsumos As Integer = 0
        For Each detalle As DetHosp In _listaDetalles
            totalInsumos = totalInsumos + detalle.Precio
        Next
        lblTotalInsumos.Text = convertir.convertir_dinero(totalInsumos)
        Dim totalHosp As Integer = 0
        If Trim(txtTotalHosp.Text) <> "" Then
            txtTotalHosp.Text = convertir.CorregirDinero(txtTotalHosp.Text)
            totalHosp = Convert.ToInt32(Trim(convertir.dinero_a_numero(txtTotalHosp.Text)))
        End If

        Dim totalConsulta As Integer = 0
        If Trim(txtTotalConsulta.Text) <> "" Then
            txtTotalConsulta.Text = convertir.CorregirDinero(txtTotalConsulta.Text)
            totalConsulta = Convert.ToInt32(Trim(convertir.dinero_a_numero(txtTotalConsulta.Text)))
        End If

        Dim totalisimo As Integer = totalInsumos + totalHosp + totalConsulta
        lblTotalPagar.Text = convertir.convertir_dinero(totalisimo)
    End Sub

    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        _subSelected = 4
    End Sub

    Private Sub rb6_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged
        _subSelected = 6
    End Sub

    Private Sub rb8_CheckedChanged(sender As Object, e As EventArgs) Handles rb8.CheckedChanged
        _subSelected = 8
    End Sub

    Private Sub rb12_CheckedChanged(sender As Object, e As EventArgs) Handles rb12.CheckedChanged
        _subSelected = 12
    End Sub

    Private Sub rb24_CheckedChanged(sender As Object, e As EventArgs) Handles rb24.CheckedChanged
        _subSelected = 24
    End Sub

    Sub PanelAgrandado()
        panelTotales2.Top = 342 : panelTotales2.Height = 105 : Label4.Top = 80 : lblTotalPagar.Top = 80
        ls1.Top = 8 : lblTotalInsumos.Top = 8
        ls2.Top = 30 : txtTotalHosp.Top = 30
        ls3.Top = 56 : txtTotalConsulta.Top = 56
    End Sub

    Sub PanelAchicado()
        panelTotales2.Top = 414 : panelTotales2.Height = 36 : Label4.Top = 8 : lblTotalPagar.Top = 8
        ls1.Top = 40 : lblTotalInsumos.Top = 40
        ls2.Top = 40 : txtTotalHosp.Top = 40
        ls3.Top = 40 : txtTotalConsulta.Top = 40
    End Sub

    Private Sub btnDesplegar_Click(sender As Object, e As EventArgs) Handles btnDesplegar.Click
        Select Case _estadoDesplegar
            Case False : _estadoDesplegar = True : PanelAgrandado() : btnDesplegar.Text = "V"
            Case True : _estadoDesplegar = False : PanelAchicado() : btnDesplegar.Text = "^"
        End Select
    End Sub

    Private Sub lblTotalInsumos_TextChanged(sender As Object, e As EventArgs) Handles lblTotalInsumos.TextChanged
        CalcularTotales()
    End Sub

    Private Sub txtTotalHosp_Leave(sender As Object, e As EventArgs) Handles txtTotalHosp.Leave
        CalcularTotales() : _cambioRealizado = True
    End Sub

    Private Sub txtTotalConsulta_Leave(sender As Object, e As EventArgs) Handles txtTotalConsulta.Leave
        CalcularTotales() : _cambioRealizado = True
    End Sub

    Sub CargarDatosDetalle(detHosp As DetHosp)
        Dim bloque As New BloqueCodigo : bloque.FormatoDecimalPunto()
        lblCodProducto.Text = detHosp.CodProducto
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(detHosp.CodProducto) : lblNomProducto.Text = producto.NomProducto
        Select Case detHosp.Periodicidad
            Case 4 : rb4.Checked = True
            Case 6 : rb6.Checked = True
            Case 8 : rb8.Checked = True
            Case 12 : rb12.Checked = True
            Case 24 : rb24.Checked = True
        End Select


        If producto.Unidad = "ML" Then
            txtDosis.Text = detHosp.Dosis
        Else
            txtDosis.Text = "0" : txtDosis.Visible = False
        End If

        txtCantidad.Text = detHosp.Cantidad : txtPrecio.Text = detHosp.Precio

        Dim ruta As String = "../../img/productos/" & detHosp.CodProducto & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbProducto.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            pbProducto.Image = My.Resources.remedio
        End If
    End Sub

    Private Sub btnAceptarModificacion_Click(sender As Object, e As EventArgs) Handles btnAceptarModificacion.Click
        If Trim(txtCantidad.Text = "") Then
            MsgBox("Debe especificar una cantidad totaladministrada para el producto.")
            Exit Sub
        End If

        If Trim(txtPrecio.Text) = "" Then
            MsgBox("Debe especificar un subtotal para el producto.")
        End If

        Dim detHosp As New DetHosp : Dim convertir As New Convertir
        detHosp.IdHosp = _hosp.IdHosp : detHosp.CodProducto = Convert.ToInt32(Trim(lblCodProducto.Text))
        detHosp.Dosis = Convert.ToDouble(Trim(txtDosis.Text.Replace(",", ".")))
        detHosp.Periodicidad = _subSelected : detHosp.Cantidad = Convert.ToDouble(Trim(txtCantidad.Text.Replace(",", ".")))
        txtPrecio.Text = convertir.CorregirDinero(txtPrecio.Text)
        detHosp.Precio = convertir.dinero_a_numero(Trim(txtPrecio.Text))
        Dim i As Integer = 0 : Dim lg As Integer = _listaDetalles.Count

        While i < lg And _listaDetalles.Item(i).CodProducto <> detHosp.CodProducto
            i = i + 1
        End While

        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(detHosp.CodProducto)

        Dim detAux As New DetHosp : Dim bsnDetHosp As New BsnDetHosp

        Try
            detAux = bsnDetHosp.GetDatosDetalleHosp(_hosp.IdHosp, producto.CodProducto)
        Catch ex As Exception

        End Try

        If producto.Unidad = "ML" Then
            Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
            Dim valStock As Double = ((stock.NumFrascos - 1) * stock.CantTotal) + stock.CantActual
            Dim diferencia As Double = detAux.Cantidad - detHosp.Cantidad
            If (diferencia * -1) > valStock Then
                MsgBox("La cantidad ingresada es superior al stock disponible.") : Exit Sub
            End If
        Else
            Dim auxint As Integer = detAux.Cantidad
            Dim canint As Integer = detHosp.Cantidad
            Dim difint As Integer = auxint - canint

            If (difint * -1) > producto.Stock Then
                MsgBox("La cantidad ingresada es superior al stock disponible.") : Exit Sub
            End If
        End If

        _listaDetalles.Item(i) = detHosp
        CargarDetalles() : LimpiarPanelDetalle() : CalcularTotales() : _cambioRealizado = True
    End Sub

    Private Sub txtDosis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDosis.KeyPress
        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txtDosis.Text.Length
            While i < lg And encontrado = False
                If txtDosis.Text.Chars(i) = "." Or txtDosis.Text.Chars(i) = "," Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 44) Then ' coma
            If (Asc(e.KeyChar) <> 46) Then ' punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Dim codProducto As Integer = Convert.ToInt32(Trim(lblCodProducto.Text))
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos : producto = bsnProducto.GetDatosProducto(codProducto)
        If producto.Unidad = "UN" Then
            If e.KeyChar = "." Or e.KeyChar = "," Then
                e.Handled = True : Exit Sub
            End If
        End If

        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txtCantidad.Text.Length
            While i < lg And encontrado = False
                If txtCantidad.Text.Chars(i) = "." Or txtCantidad.Text.Chars(i) = "," Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 44) Then ' coma
            If (Asc(e.KeyChar) <> 46) Then ' punto
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

    Private Sub txtTotalHosp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalHosp.KeyPress
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

    Private Sub txtTotalConsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalConsulta.KeyPress
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

    Private Sub lstDetallesHosp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDetallesHosp.SelectedIndexChanged
        Dim index As Integer = lstDetallesHosp.FocusedItem.Index

        Dim detAux As New DetHosp : Dim convertir As New Convertir
        Dim codProducto As Integer = Convert.ToInt32(Trim(lstDetallesHosp.Items(index).SubItems(0).Text))

        For Each detalle As DetHosp In _listaDetalles
            If detalle.CodProducto = codProducto Then
                detAux = detalle
            End If
        Next

        Dim producto As New Producto : Dim bsnProducto As New BsnProductos : producto = bsnProducto.GetDatosProducto(detAux.CodProducto)
        If producto.Unidad = "ML" Then
            lblDosis.Visible = True : txtDosis.Visible = True : lblPeriodo.Visible = True : panelPeriodo.Visible = True
        Else
            lblDosis.Visible = False : txtDosis.Visible = False : lblPeriodo.Visible = False : panelPeriodo.Visible = False
            _subSelected = 0
        End If
        CargarDatosDetalle(detAux)
    End Sub

    Private Sub btnEliminarDetalle_Click(sender As Object, e As EventArgs) Handles btnEliminarDetalle.Click
        Dim index As Integer = 0
        Try
            index = lstDetallesHosp.FocusedItem.Index
        Catch ex As Exception
            MsgBox("Para eliminar un detalle debe seleccionarlo.") : Exit Sub
        End Try

        If MessageBox.Show("¿Desea eliminar este detalle?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim codProducto As Integer = Convert.ToInt32(Trim(lstDetallesHosp.Items(index).SubItems(0).Text))
            Dim i As Integer = 0 : Dim lg As Integer = _listaDetalles.Count
            While i < lg And codProducto <> _listaDetalles.Item(i).CodProducto
                i = i + 1
            End While
            _listaEliminados.Add(_listaDetalles.Item(i))
            _listaDetalles.Remove(_listaDetalles.Item(i))
            MsgBox("Detalle eliminado.")
            CargarDetalles() : LimpiarPanelDetalle() : CalcularTotales() : _cambioRealizado = True
        End If
    End Sub

    Private Sub btnAgregarIn_Click(sender As Object, e As EventArgs) Handles btnAgregarIn.Click
        Dim frmAgregarInsumo As New FRM_AgregarInsumo(Me, _hosp.IdHosp) : frmAgregarInsumo.Show() : Me.Hide()
    End Sub

    Sub AgregarDetalle(detalle As DetHosp)
        _listaDetalles.Add(detalle)
    End Sub

    Sub SetCambioRealizado(opcion As Boolean)
        _cambioRealizado = opcion
    End Sub

    Function GetLargoLista()
        Return _listaDetalles.Count
    End Function

    Function GetLista()
        Return _listaDetalles
    End Function

End Class
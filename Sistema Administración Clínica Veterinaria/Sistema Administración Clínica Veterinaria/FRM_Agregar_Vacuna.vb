Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FRM_Agregar_Vacuna

    Public modo As String = ""
    Public _ordinal As Integer

    Dim _modoVacuna As String
    Dim _frmRegistrarAtencion As frm_Registrar_Atencion
    Dim _idFicha As String
    Dim _frmPrincipal As frm_Principal
    Dim _frmPerfil As FRM_Perfil
    Dim _vacuna As Vacuna
    Dim _frmCalendario As frm_Calendario

    Dim detalle As String = "{0, -6}{1, -32}{2, -4}"
    Dim detalleVacuna As String = "{0, -1}{1, -6}{2, -34}{3, -5}{4, -10}"



    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Sub New(frmRegistrarAtencion As frm_Registrar_Atencion, modoVacuna As String)
        MyBase.New()
        _frmRegistrarAtencion = frmRegistrarAtencion
        _modoVacuna = modoVacuna
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal, modoVacuna As String, idFicha As String)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        _modoVacuna = modoVacuna
        _idFicha = idFicha
        InitializeComponent()
    End Sub

    Public Sub New(frmPerfil As FRM_Perfil, vacuna As Vacuna)
        _frmPerfil = frmPerfil
        _vacuna = vacuna
        _modoVacuna = "perfil"
        _idFicha = vacuna.IdFicha
        InitializeComponent()
    End Sub

    Public Sub New(frmCalendario As frm_Calendario, idFicha As String)
        _frmCalendario = frmCalendario
        _modoVacuna = "calendario"
        _idFicha = idFicha
        InitializeComponent()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Select Case _modoVacuna
            Case "directo" : _frmPrincipal.Show()
            Case "atencion" : _frmRegistrarAtencion.Show()
            Case "perfil" : _frmPerfil.Show()
            Case "calendario" : _frmCalendario.Show()
        End Select
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub FRM_Agregar_Vacuna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNulo.Select()
        lbl_codigo.Text = "" : lbl_nombre.Text = "" : lbl_proveedor.Text = "" : lbl_stock.Text = "" : lbl_precio.Text = ""
        lbl_unidad.Text = ""
        Dim fecha = DateTime.Now.ToString("dd/MM/yyyy")
        lbl_fecha.Text = fecha
        llenar_vacunas()

        If _modoVacuna = "perfil" Then
            Label12.Text = "MODIFICAR VACUNA REGISTRADA" : Label12.Left = 270
            btn_agregar.Text = "MODIFICAR"
            CargarDatosVacuna()
        End If
    End Sub

    Sub CargarDatosVacuna()
        Dim i As Integer = 0 : Dim lg As Integer = lst_vacunas.Items.Count : Dim encontrado As Boolean = False

        While i < lg And encontrado = False
            Dim cadena As String = lst_vacunas.Items.Item(i)
            Dim codProducto As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 6)))
            Dim nv As Integer = _vacuna.NumVacuna
            If _vacuna.Codproducto = codProducto Then
                lst_vacunas.SelectedIndex = i : encontrado = True
            End If
            i = i + 1
        End While

        Select Case _vacuna.NOrdinal
            Case 0 : rbNulo.Select()
            Case 1 : rb_primera.Select()
            Case 2 : rb_segunda.Select()
            Case 3 : rb_tercera.Select()
            Case 4 : rb_cuarta.Select()
        End Select

        txt_dosis.Text = _vacuna.Dosis
        lbl_fecha.Text = _vacuna.FechaVacuna

        If _vacuna.FechaProxVacuna = "00/00/0000" Then
            chbSinFecha.Checked = True
        Else
            dtp_prox_vacuna.Value = _vacuna.FechaProxVacuna
        End If
    End Sub

    Sub llenar_vacunas()
        lst_vacunas.Items.Clear()
        Dim listaProductos As New List(Of Producto) : Dim bsnProducto As New BsnProductos
        listaProductos = bsnProducto.GetProductos("cod_producto")
        For Each producto As Producto In listaProductos
            Dim stock As String = "-"
            If producto.Unidad = "UN" Then
                stock = Convert.ToString(producto.Stock)
            End If
            If producto.TipoProducto = "V" Then
                lst_vacunas.Items.Add(String.Format(detalle, producto.CodProducto, producto.NomProducto, stock))
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl_fecha.Text = txt_adecuar.Text
    End Sub


    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If lst_vacunas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una vacuna de la lista.") : Exit Sub
        End If

        If Trim(txt_dosis.Text) = "" Then
            MsgBox("Debe ingresar una dosis para la vacuna.") : Exit Sub
        Else
            Dim dosisAux As Double = Convert.ToDouble(Trim(txt_dosis.Text))
            If dosisAux = 0 Then
                MsgBox("Debe ingresar una dosis para la vacuna.") : Exit Sub
            Else
                If dosisAux > 50 Then
                    MsgBox("La dosis no puede ser mayor a 50ml")
                End If
            End If
        End If

        Dim codProducto As Integer = Convert.ToInt32(Trim(lbl_codigo.Text))
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(codProducto)

        '//////////////Ver Stock Disponible///////////////////////
        If producto.Unidad = "UN" Then
            If producto.Stock = 0 Then
                MsgBox("No hay stock de este producto.") : Exit Sub
            End If
        Else
            Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
            Dim valorX As Double = ((stock.NumFrascos - 1) * stock.CantTotal) + stock.CantActual
            Dim dosis As Double = Convert.ToDouble(Trim(txt_dosis.Text))
            If dosis > valorX Then
                MsgBox("La dosis ingresada supera el stock disponible.") : Exit Sub
            End If
        End If
        '//////////////////////////////////////////////////////////

        If _modoVacuna = "atencion" Then
            '////////buscar si ya existe/////////
            Dim i As Integer = 0 : Dim lg As Integer = _frmRegistrarAtencion.lstAgregados.Items.Count
            Dim cRepetidos As Integer = 0

            While i < lg
                Dim tipo As String = _frmRegistrarAtencion.lstAgregados.Items(i).SubItems(0).Text
                If tipo = "V" Then
                    Dim codTabla As Integer = Convert.ToInt32(Trim(_frmRegistrarAtencion.lstAgregados.Items(i).SubItems(1).Text))
                    Dim codEste As Integer = Convert.ToInt32(Trim(lbl_codigo.Text))
                    If codTabla = codEste Then cRepetidos = cRepetidos + 1
                End If
                i = i + 1
            End While

            If cRepetidos > 0 Then
                MsgBox("Esta intentando ingresar dos veces la misma vacuna." & vbLf &
                       "Si desea cambiar la dosis de la vacuna puede modificarla.") : Exit Sub
            End If
        End If

        Dim bloque As New BloqueCodigo : bloque.FormatoDecimalPunto() : Dim bsnVacuna As New BsnVacuna
        Dim convertir As New Convertir : Dim vacuna As New Vacuna

        vacuna.NumVacuna = bsnVacuna.GenerarNumVacuna : vacuna.IdFicha = _idFicha
        vacuna.Codproducto = Convert.ToInt32(Trim(lbl_codigo.Text)) : vacuna.NOrdinal = _ordinal
        producto = bsnProducto.GetDatosProducto(vacuna.Codproducto)

        If txt_dosis.Text <> "" Then
            vacuna.Dosis = Convert.ToDouble(Trim(txt_dosis.Text.Replace(",", ".")))
        Else
            vacuna.Dosis = 0
        End If
        vacuna.FechaVacuna = convertir.invertir_fecha(lbl_fecha.Text)
        If chbSinFecha.Checked = True Then
            vacuna.FechaProxVacuna = "0000-00-00"
        Else
            vacuna.FechaProxVacuna = Format(dtp_prox_vacuna.Value, "yyyy/MM/dd")
        End If

        If _modoVacuna = "atencion" Then
            Dim textoVacuna As String = ""
            If vacuna.NOrdinal = 0 Then
                textoVacuna = producto.NomProducto
            Else
                textoVacuna = vacuna.NOrdinal & "° " & producto.NomProducto
            End If

            Dim detAux As String = "{0,-7}{1,-10}"
            With _frmRegistrarAtencion.lstAgregados.Items.Add("V")
                .SubItems.Add(vacuna.Codproducto)
                .SubItems.Add(textoVacuna)
                .SubItems.Add(String.Format(detAux, vacuna.Dosis, vacuna.FechaProxVacuna))
                .SubItems.Add(convertir.convertir_dinero(producto.Precio))
            End With
            _frmRegistrarAtencion.ActualizarTotal()

            '///////////AGREGAR EN TEXTO
            Dim texto As String = ""
            texto = vbLf & "/////////////////////////" & vbLf &
                    vacuna.NOrdinal & "° " & producto.NomProducto & vbLf &
                    "Próxima " & vacuna.FechaProxVacuna & vbLf &
                    "/////////////////////////" & vbLf

            _frmRegistrarAtencion.rtb_descripcion.Text = _frmRegistrarAtencion.rtb_descripcion.Text + texto
            _frmRegistrarAtencion.Show()
        Else
            Select Case _modoVacuna
                Case "directo"
                    bsnVacuna.InsertarVacuna(vacuna) : MsgBox("La vacuna ha sido registrada correctamente.")
                    _frmPrincipal.EnviarCorreos() : _frmPrincipal.Show()
                    Dim ajuste As New Ajuste : Dim bsnAjuste As New BsnAjuste
                    ajuste.Codproducto = producto.CodProducto
                    ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    ajuste.TipoAjuste = "D"

                    If producto.Unidad = "ML" Then
                        Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
                        If stock.CantActual <= vacuna.Dosis Then
                            stock.NumFrascos = stock.NumFrascos - 1
                            If stock.NumFrascos = 0 Then
                                stock.CantActual = 0
                            Else
                                stock.CantActual = stock.CantTotal - (vacuna.Dosis - stock.CantActual)
                            End If
                        Else
                            stock.CantActual = stock.CantActual - vacuna.Dosis
                        End If
                        bsnProducto.ModificarStock(stock)
                        ajuste.Cantidad = vacuna.Dosis * -1
                    Else
                        producto.Stock = producto.Stock - 1
                        bsnProducto.ModificarProducto(producto)
                        ajuste.Cantidad = -1
                    End If
                    bsnAjuste.InsertarAjuste(ajuste)

                Case "perfil"
                    vacuna.NumVacuna = _vacuna.NumVacuna : bsnVacuna.ModificarVacuna(vacuna)
                    MsgBox("La vacuna ha sido modificada correctamente.") : _frmPerfil.CargarDatosPanelVacuna(vacuna)
                    _frmPerfil.cargar_vacunas() : _frmPerfil.Show()
            End Select
        End If


        Me.Close() : Me.Dispose()
    End Sub

    Private Sub lst_vacunas_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lst_vacunas.SelectedIndexChanged
        If lst_vacunas.SelectedIndex <> -1 Then
            Dim cadena As String = lst_vacunas.SelectedItem
            Dim codProducto As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            Dim producto As New Producto : Dim bsnproducto As New BsnProductos
            producto = bsnproducto.GetDatosProducto(codProducto)
            LlenarDatosVacuna(producto)
        End If
    End Sub

    Sub LlenarDatosVacuna(producto As Producto)
        lbl_codigo.Text = producto.CodProducto : lbl_nombre.Text = producto.NomProducto
        Dim proveedor As New Proveedor : Dim bsnProveedor As New BsnProveedores
        proveedor = bsnProveedor.GetDatosProveedor(producto.CodProveedor)
        lbl_proveedor.Text = proveedor.NomProveedor : Dim convertir As New Convertir
        lbl_precio.Text = convertir.convertir_dinero(producto.Precio)
        lbl_unidad.Text = producto.Unidad

        If producto.Unidad = "ML" Then
            Dim stock As New Stock : Dim bsnProducto As New BsnProductos
            stock = bsnProducto.GetDatosStock(producto.CodProducto)
            lbl_stock.Text = stock.NumFrascos & " frascos - " & "Frasco Actual : " &
                    stock.CantActual & "/" & stock.CantTotal & "ml"
        Else
            lbl_stock.Text = producto.Stock & " unidades"
        End If

        Dim ruta As String = "../../img/productos/" & producto.CodProducto & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbProducto.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            pbProducto.Image = My.Resources.cosa
        End If
    End Sub

    Private Sub rb_primera_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_primera.CheckedChanged
        _ordinal = 1
    End Sub

    Private Sub rb_segunda_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_segunda.CheckedChanged
        _ordinal = 2
    End Sub

    Private Sub rb_tercera_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_tercera.CheckedChanged
        _ordinal = 3
    End Sub

    Private Sub rb_cuarta_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_cuarta.CheckedChanged
        _ordinal = 4
    End Sub

    Private Sub rbNulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNulo.CheckedChanged
        _ordinal = 0
    End Sub

    Private Sub chbSinFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chbSinFecha.CheckedChanged
        If chbSinFecha.Checked = True Then
            dtp_prox_vacuna.Visible = False
        Else
            dtp_prox_vacuna.Visible = True
        End If
    End Sub

    Private Sub txt_dosis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dosis.KeyPress
        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txt_dosis.Text.Length
            While i < lg And encontrado = False
                If txt_dosis.Text.Chars(i) = "." Or txt_dosis.Text.Chars(i) = "," Then
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
End Class
Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_Mantenedor_Clientes

    Protected _frmPrincipal As frm_Principal

    Dim detalle As String = "{0, -7}{1, -12}{2, -31}"
    Dim tipo_proceso As String = ""
    Private fecha As String

    Dim _modoVentana As String
    Dim _frmFichaGeneral As frm_ficha_general
    Dim _subOpcion As String

    Dim imagenCargada As Boolean = False
    Dim imagenRepetida As Boolean = False


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmFichaGeneral As frm_ficha_general, subOpcion As String)
        _frmFichaGeneral = frmFichaGeneral
        _modoVentana = "ficha"
        _subOpcion = subOpcion
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _modoVentana = "principal"
        _frmPrincipal = frm_Principal
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case _modoVentana
            Case "principal" : _frmPrincipal.Show()
            Case "ficha" : _frmFichaGeneral.Show()
        End Select
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Mantenedor_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarClientes()
        lbl_numero.Text = ""
        fecha = DateTime.Now.ToString("yyyy/MM/dd")

        Select Case _modoVentana
            Case "principal"
            Case "ficha"
                Select Case _subOpcion
                    Case "seleccionar"
                        btn_agregar.Visible = False : btn_modificar.Visible = False : btn_eliminar.Visible = False
                        btnSeleccionar.Left = 12 : btnSeleccionar.Visible = True
                    Case "agregar"
                        btn_eliminar.Visible = False
                End Select
        End Select
    End Sub

    Sub LlenarClientes()
        Dim bsnCliente As New BsnCliente
        Dim listaClientes As New List(Of Cliente)
        listaClientes = bsnCliente.GetClientes
        lst_clientes.Items.Clear()
        For Each cliente As Cliente In listaClientes
            If cliente.Estado = True Then
                lst_clientes.Items.Add(String.Format(detalle, cliente.NumCliente, cliente.Rut, cliente.Nombre))
            End If
        Next
    End Sub

    Private Sub lst_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_clientes.SelectedIndexChanged
        If lst_clientes.SelectedIndex <> -1 Then
            Dim cadena As String = lst_clientes.SelectedItem
            Dim idCliente As Integer = Convert.ToInt32((cadena.Substring(0, 7)))
            Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(idCliente)
            LlenarPanelCliente(cliente)
        End If
    End Sub

    Sub LlenarPanelCliente(cliente As Cliente)
        lbl_numero.Text = cliente.NumCliente : txt_nombre.Text = cliente.Nombre : txt_rut.Text = cliente.Rut
        txt_direccion.Text = cliente.DireccionCliente : txt_fono.Text = cliente.FonoCliente
        txt_correo.Text = cliente.Correo

        Dim ruta As String = "../../img/clientes/" & cliente.NumCliente & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbCliente.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            imagenCargada = True
            imagenRepetida = True
        Else
            pbCliente.Image = My.Resources.user_symbol_318_63527
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        txt_rut.Text = "" : txt_nombre.Text = "" : txt_direccion.Text = "" : txt_correo.Text = "" : txt_fono.Text = ""
        btn_guardar.Visible = True : btn_cancelar.Visible = True
        Dim bsnCliente As New BsnCliente
        lbl_numero.Text = bsnCliente.GenerarNumCliente
        lst_clientes.Enabled = False
        tipo_proceso = "agregar"
        btn_guardar.Visible = True
        btn_cancelar.Visible = True
        txt_nombre.Focus()
        lst_clientes.SelectedIndex = -1
        BloquearBusqueda()
        btnCargarImagen.Visible = True : btnQuitarImagen.Visible = True
    End Sub

    Sub BloquearBusqueda()
        txt_busqueda_num.Enabled = False : txt_busqueda_rut.Enabled = False
        txt_busqueda_nombre.Enabled = False
    End Sub

    Sub DesbloquearBusqueda()
        txt_busqueda_num.Enabled = True : txt_busqueda_rut.Enabled = True
        txt_busqueda_nombre.Enabled = True
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If lst_clientes.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un cliente de la lista para modificarlo.")
            Exit Sub
        End If

        btn_guardar.Visible = True : btn_cancelar.Visible = True
        btn_agregar.Enabled = False : btn_modificar.Enabled = False : btn_eliminar.Enabled = False
        tipo_proceso = "modificar"
        txt_nombre.Focus()
        btnCargarImagen.Visible = True : btnQuitarImagen.Visible = True
    End Sub

    Function ValidarRut(rut As String)
        Dim resultado As Boolean = True
        If rut <> "" Then
            If rut.Length < 8 Then
                MsgBox("El rut no tiene el largo suficiente, por lo tanto es inválido.") : resultado = False
            Else
                Dim dv As Char = rut.Chars(rut.Length - 1)
                rut = rut.Substring(0, rut.Length - 1)
                Dim convertir As New Convertir
                rut = convertir.dar_vuelta(rut)
                Dim i As Integer = 0 : Dim numero As Integer = 2 : Dim suma As Integer = 0

                While i < rut.Length
                    Dim dstr As String = rut.Chars(i)
                    Dim dnum As Integer = Convert.ToInt32(dstr)
                    suma = suma + (dnum * numero)
                    If numero < 7 Then
                        numero = numero + 1
                    Else
                        numero = 2
                    End If
                    i = i + 1
                End While

                Dim division As Integer = Math.Truncate(suma / 11)
                Dim num2 As Integer = 11 - (suma - (division * 11))
                Dim dr As Char = ""

                If num2 = 11 Then
                    dr = "0"
                Else
                    If num2 = 10 Then
                        dr = "K"
                    Else
                        dr = Convert.ToString(num2)
                    End If
                End If

                If dr <> dv Then
                    resultado = False : MsgBox("El digito verificador no es correcto. El RUT no está permitido, debe ingresar otro.")
                End If
            End If
        End If
        Return resultado
    End Function

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_nombre.Text = "" Then
            MsgBox("Al menos debe ingresar un nombre.")
            txt_nombre.BackColor = Color.Yellow
            txt_nombre.Focus()
            Exit Sub
        End If

        Dim respuesta As Boolean = False : Dim bsnCliente As New BsnCliente

        Dim num_cliente As Integer = Convert.ToInt32(Trim(lbl_numero.Text))
        Dim rut As String = UCase(txt_rut.Text) : rut = rut.Replace(".", "") : rut = rut.Replace("-", "")

        Dim rutValidado As Boolean = ValidarRut(rut)
        If rutValidado = False Then
            Exit Sub
        End If

        Dim nombre As String = UCase(txt_nombre.Text)
        Dim direccion_cliente As String = UCase(txt_direccion.Text)
        Dim fono_cliente As String = txt_fono.Text
        Dim correo As String = txt_correo.Text

        Dim cliente As New Cliente(num_cliente, rut, nombre, direccion_cliente, fono_cliente, correo)


        '/////////////////////// VALIDACIONES //////////////////////////////////////
        Dim bsnNegocio As New BsnNegocio : Dim cl As New Cliente : Dim repetido As Boolean = False : Dim r2 As Boolean = False

        If Trim(txt_rut.Text) <> "" Then
            Dim validarR As Integer = bsnNegocio.ValidarPorTexto("cliente", "rut", rut)
            If validarR <> -1 Then
                cl = bsnCliente.GetDatosCliente(validarR)
                If tipo_proceso = "agregar" Then
                    clienteRepetido(cl, "RUT") : Exit Sub
                End If
                If tipo_proceso = "modificar" Then
                    If cl.NumCliente <> num_cliente Then
                        clienteRepetido(cl, "RUT") : Exit Sub
                    End If
                End If

            End If
        End If

        If Trim(txt_nombre.Text) <> "" Then
            Dim validarNom As Integer = bsnNegocio.ValidarPorTexto("cliente", "nombre", nombre)
            If validarNom <> -1 Then
                cl = bsnCliente.GetDatosCliente(validarNom)
                If tipo_proceso = "agregar" Then
                    repetido = True : r2 = True
                End If
                If tipo_proceso = "modificar" Then
                    If cl.NumCliente <> num_cliente Then
                        repetido = True : r2 = True
                    End If
                End If
            End If
        End If


        If r2 = False Then
            If Trim(txt_fono.Text) <> "" Then
                Dim validarFono As Integer = bsnNegocio.ValidarPorTexto("cliente", "fono_cliente", fono_cliente)
                If validarFono <> -1 Then
                    cl = bsnCliente.GetDatosCliente(validarFono)
                    Select Case tipo_proceso
                        Case "agregar" : repetido = True : r2 = True
                        Case "modificar"
                            If cl.NumCliente <> num_cliente Then
                                repetido = True : r2 = True
                            End If
                    End Select
                End If
            End If
        End If

        If r2 = False Then
            If Trim(txt_correo.Text) <> "" Then
                Dim validarCorreo As Integer = bsnNegocio.ValidarPorTexto("cliente", "correo", correo)
                If validarCorreo <> -1 Then
                    cl = bsnCliente.GetDatosCliente(validarCorreo)
                    Select Case tipo_proceso
                        Case "agregar" : repetido = True
                        Case "modificar"
                            If cl.NumCliente <> num_cliente Then
                                repetido = True
                            End If
                    End Select
                End If
            End If
        End If

        If repetido = True Then
            respuesta = clienteRepetidoPros(cl)
            If respuesta = False Then
                Exit Sub
            End If
        End If
        '/////////////////////////////////////////////////////////////////////////////////////////

        Select Case tipo_proceso
            Case "agregar" : bsnCliente.InsertarCliente(cliente)
            Case "modificar" : bsnCliente.ModificarCliente(cliente)
        End Select

        Dim ruta As String = "../../img/clientes/" & num_cliente & ".jpg"
        If imagenCargada = True Then
            If Not imagenRepetida = True Then
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                pbCliente.Image.Save(ruta, Imaging.ImageFormat.Jpeg)
            End If
        Else
            If File.Exists(ruta) Then
                My.Computer.FileSystem.DeleteFile(ruta)
            End If
        End If
        LimpiarPanel()
        lst_clientes.Enabled = True
        LlenarClientes()
        btn_agregar.Enabled = True : btn_modificar.Enabled = True : btn_eliminar.Enabled = True
        DesbloquearBusqueda()
        lst_clientes.SelectedIndex = -1

        If _subOpcion = "agregar" Then
            _frmFichaGeneral.CargarDatosCliente(cliente)
            _frmFichaGeneral.Show() : Me.Close()
            _frmFichaGeneral.panelCliente.Visible = True : _frmFichaGeneral.panelSeleccionar.Visible = False
        End If
    End Sub

    Sub clienteRepetido(cliente As Cliente, repetido As String)
        MsgBox("Ya existe un cliente con el mismo " & repetido & vbLf & "*********************" & vbLf &
               "N° Cliente : " & cliente.NumCliente & vbLf & "Nombre : " & cliente.Nombre & vbLf &
               "Rut : " & cliente.Rut & vbLf & "Fono : " & cliente.FonoCliente & vbLf & "Correo : " &
               cliente.Correo & vbLf &
               "Dirección : " & cliente.DireccionCliente & vbLf & "*******************")
    End Sub

    Function clienteRepetidoPros(cliente As Cliente)
        Dim respuesta As Boolean = False
        If MessageBox.Show("Ya existe un cliente con datos similares. " & vbLf & "*********************" & vbLf &
               "N° Cliente : " & cliente.NumCliente & vbLf & "Nombre : " & cliente.Nombre & vbLf &
               "Rut : " & cliente.Rut & vbLf & "Fono : " & cliente.FonoCliente & vbLf & "Correo : " &
               cliente.Correo & vbLf &
               "Dirección : " & cliente.DireccionCliente & vbLf & "*******************" & vbLf &
               "¿Desea continuar de todas formas?", "Alerta", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            respuesta = True
        End If
        Return respuesta
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_ordenar_num.Click
        LlenarClientes()
        LimpiarPanel()
    End Sub

    Private Sub btn_ordenar_rut_Click(sender As Object, e As EventArgs) Handles btn_ordenar_rut.Click
        ordenar_por("rut")
        LimpiarPanel()
    End Sub

    Private Sub btn_ordenar_nombre_Click(sender As Object, e As EventArgs) Handles btn_ordenar_nombre.Click
        ordenar_por("nombre")
        LimpiarPanel()
    End Sub


    Sub ordenar_por(criterio)
        Dim listaClientes As New List(Of Cliente) : Dim bsnCliente As New BsnCliente
        listaClientes = bsnCliente.GetClientes()
        Select Case criterio
            Case "rut" : listaClientes = listaClientes.OrderBy(Function(cl) cl.Rut).ToList
            Case "nombre" : listaClientes = listaClientes.OrderBy(Function(cl) cl.Nombre).ToList
            Case "fono_cliente" : listaClientes = listaClientes.OrderBy(Function(cl) cl.FonoCliente).ToList
        End Select
        lst_clientes.Items.Clear()
        For Each cliente As Cliente In listaClientes
            If cliente.Estado = True Then
                lst_clientes.Items.Add(String.Format(detalle, cliente.NumCliente, cliente.Rut, cliente.Nombre))
            End If
        Next
    End Sub

    Function busqueda_por(criterio, inicio)
        Dim largo As Integer = lst_clientes.Items.Count
        Dim i = inicio
        Dim valor_lista As String = ""
        Dim cadena As String = ""
        Dim valor_busqueda As String = ""

        Select Case criterio
            Case "num" : valor_busqueda = txt_busqueda_num.Text
            Case "rut" : valor_busqueda = txt_busqueda_rut.Text
            Case "nombre" : valor_busqueda = txt_busqueda_nombre.Text
        End Select
        valor_busqueda = UCase(Trim(valor_busqueda))

        If valor_busqueda = "" Then
            lst_clientes.SelectedIndex = -1
            lbl_numero.Text = "" : txt_nombre.Text = "" : txt_rut.Text = "" : txt_direccion.Text = "" : txt_fono.Text = ""
            txt_correo.Text = ""
            Select Case criterio
                Case "num" : txt_busqueda_num.BackColor = Color.FromArgb(255, 255, 255)
                Case "rut" : txt_busqueda_rut.BackColor = Color.FromArgb(255, 255, 255)
                Case "nombre" : txt_busqueda_nombre.BackColor = Color.FromArgb(255, 255, 255)
            End Select

        Else
            cadena = cadena + "                                       "
            While i < largo And valor_lista <> valor_busqueda
                cadena = lst_clientes.Items.Item(i)
                Select Case criterio
                    Case "num" : valor_lista = Trim(cadena.Substring(0, valor_busqueda.Length))
                    Case "rut" : valor_lista = Trim(cadena.Substring(7, valor_busqueda.Length))
                    Case "nombre" : valor_lista = Trim(cadena.Substring(19, valor_busqueda.Length))
                    Case "fono" : valor_lista = Trim(cadena.Substring(50, valor_busqueda.Length))
                End Select
                If valor_lista = valor_busqueda Then
                    lst_clientes.SelectedIndex = i
                Else
                    i = i + 1
                End If
            End While


            If i = largo Then  '//////////significa que no lo encontro/////////////////////
                lst_clientes.SelectedIndex = -1
                lbl_numero.Text = "" : txt_nombre.Text = "" : txt_rut.Text = "" : txt_direccion.Text = "" : txt_fono.Text = ""
                txt_correo.Text = ""
                Select Case criterio
                    Case "num" : txt_busqueda_num.BackColor = Color.FromArgb(255, 128, 128)
                    Case "rut" : txt_busqueda_rut.BackColor = Color.FromArgb(255, 128, 128)
                    Case "nombre" : txt_busqueda_nombre.BackColor = Color.FromArgb(255, 128, 128)
                End Select
            Else
                Select Case criterio
                    Case "num" : txt_busqueda_num.BackColor = Color.FromArgb(255, 255, 255)
                    Case "rut" : txt_busqueda_rut.BackColor = Color.FromArgb(255, 255, 255)
                    Case "nombre" : txt_busqueda_nombre.BackColor = Color.FromArgb(255, 255, 255)
                End Select

            End If

        End If

        Return 0
    End Function



    Private Sub txt_busqueda_num_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_num.TextChanged
        busqueda_por("num", 0)
    End Sub

    Private Sub txt_busqueda_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_nombre.TextChanged
        busqueda_por("nombre", 0)
    End Sub

    Private Sub txt_busqueda_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_rut.TextChanged
        busqueda_por("rut", 0)
    End Sub

    Private Sub txt_busqueda_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda_num.KeyPress
        If (Asc(e.KeyChar) <> 8) Then 'borrar
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_busqueda_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda_rut.KeyPress
        If (Asc(e.KeyChar) <> 75) Then
            If (Asc(e.KeyChar) <> 107) Then
                If (Asc(e.KeyChar) <> 45) Then
                    If (Asc(e.KeyChar) <> 46) Then
                        If (Asc(e.KeyChar) <> 8) Then 'borrar
                            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                                e.Handled = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_busqueda_num_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_num.Leave
        txt_busqueda_num.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txt_busqueda_rut_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_rut.Leave
        txt_busqueda_rut.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txt_busqueda_nombre_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_nombre.Leave
        txt_busqueda_nombre.BackColor = Color.FromArgb(255, 255, 255)
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

            pbCliente.Image = Image.FromFile(ofd.FileName)
            imagenCargada = True
            imagenRepetida = False
        End If
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        pbCliente.Image = My.Resources.user_symbol_318_63527
        imagenCargada = False
        imagenRepetida = False
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        LimpiarPanel()
        btn_agregar.Enabled = True : btn_modificar.Enabled = True : btn_eliminar.Enabled = True : lst_clientes.Enabled = True
        lst_clientes.SelectedIndex = -1
        DesbloquearBusqueda()
    End Sub

    Sub LimpiarPanel()
        btn_guardar.Visible = False : btn_cancelar.Visible = False : btnCargarImagen.Visible = False : btnQuitarImagen.Visible = False
        pbCliente.Image = My.Resources.user_symbol_318_63527 : imagenCargada = False : imagenRepetida = False
        txt_nombre.Text = "" : txt_direccion.Text = "" : txt_fono.Text = "" : txt_rut.Text = "" : txt_correo.Text = ""
        lbl_numero.Text = ""
    End Sub

    Private Sub txt_busqueda_num_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_num.Enter
        pbCliente.Image = My.Resources.user_symbol_318_63527
        txt_busqueda_rut.Text = "" : txt_busqueda_nombre.Text = ""
    End Sub

    Private Sub txt_busqueda_rut_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_rut.Enter
        pbCliente.Image = My.Resources.user_symbol_318_63527
        txt_busqueda_num.Text = "" : txt_busqueda_nombre.Text = ""
    End Sub

    Private Sub txt_busqueda_nombre_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_nombre.Enter
        pbCliente.Image = My.Resources.user_symbol_318_63527
        txt_busqueda_rut.Text = "" : txt_busqueda_num.Text = ""
    End Sub

    Private Sub txt_busqueda_fono_Enter(sender As Object, e As EventArgs)
        pbCliente.Image = My.Resources.user_symbol_318_63527
        txt_busqueda_rut.Text = "" : txt_busqueda_nombre.Text = "" : txt_busqueda_num.Text = ""
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If lst_clientes.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un cliente de la lista.")
        Else
            Dim cadena As String = lst_clientes.SelectedItem
            Dim idCliente As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            Dim bsnCliente As New BsnCliente : Dim bsnNegocio As New BsnNegocio

            Dim encontradoMascota As Integer = bsnNegocio.ValidarPorNumero("mascota", "num_cliente", idCliente)
            Dim encontradoVenta As Integer = bsnNegocio.ValidarPorNumero("venta", "num_cliente", idCliente)

            If MessageBox.Show("¿Esta seguro que desea eliminar este cliente?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If (encontradoMascota = -1) And (encontradoVenta = -1) Then
                    bsnCliente.EliminarClienteFisico(idCliente)
                    Dim ruta As String = "../../img/clientes/" & idCliente & ".jpg"
                    If File.Exists(ruta) Then
                        My.Computer.FileSystem.DeleteFile(ruta)
                    End If

                    MsgBox("El cliente ha sido eliminado del sistema.")
                    LlenarClientes()
                    LimpiarPanel()
                Else
                    MsgBox("No se puede eliminar este cliente porque tiene datos asociados a otros elementos.")
                End If
            End If
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        txt_nombre.BackColor = Color.White
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If lst_clientes.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un cliente.")
            Exit Sub
        End If

        Dim cadena As String = lst_clientes.SelectedItem
        Dim idCliente As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 7)))
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente
        cliente = bsnCliente.GetDatosCliente(idCliente)
        _frmFichaGeneral.CargarDatosCliente(cliente)
        _frmFichaGeneral.panelCliente.Visible = True : _frmFichaGeneral.panelSeleccionar.Visible = False
        _frmFichaGeneral.Show()
        Me.Close()
    End Sub

    Private Sub txt_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rut.KeyPress
        Dim i As Integer = 0 : Dim lg As Integer = txt_rut.Text.Length : Dim encontrado As Boolean = False
        While i < lg And encontrado = False
            If txt_rut.Text.Chars(i) = "k" Or txt_rut.Text.Chars(i) = "K" Then
                If Asc(e.KeyChar) = 8 Then
                Else
                    encontrado = True : e.Handled = True
                End If
            End If
            i = i + 1
        End While

        If (Asc(e.KeyChar) <> 75) Then
            If (Asc(e.KeyChar) <> 107) Then
                If (Asc(e.KeyChar) <> 45) Then
                    If (Asc(e.KeyChar) <> 46) Then
                        If (Asc(e.KeyChar) <> 8) Then
                            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                                e.Handled = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_fono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fono.KeyPress
        If (Asc(e.KeyChar) <> 47) Then
            If (Asc(e.KeyChar) <> 32) Then
                If (Asc(e.KeyChar) <> 45) Then
                    If (Asc(e.KeyChar) <> 8) Then 'borrar
                        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_direccion.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_correo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_correo.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub
End Class
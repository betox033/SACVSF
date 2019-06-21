Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_ficha_general

    Protected _modoFormulario As String
    Protected _frmMantenedorMascotas As frm_Mantenedor_Mascotas
    Protected _mascota As Mascota
    Protected _cliente As Cliente
    Protected _clienteAceptado As Boolean

    Public X_genero As Char = ""
    Dim imagenCargada As Boolean = False
    Dim imagenRepetida As Boolean = False
    Dim detalle As String = "{0,-35}{1,-5}"
    Dim detalleAnimal As String = "{0,-7}{1,-20}"
    Dim detalleMascota As String = "{0,-7}{1,-30}"

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Sub New(frmMantenedorMascotas As frm_Mantenedor_Mascotas, modoFormulario As String)
        InitializeComponent()
        _modoFormulario = modoFormulario
        _frmMantenedorMascotas = frmMantenedorMascotas
    End Sub

    Public Sub New(frmMantenedorMascotas As frm_Mantenedor_Mascotas, modoFormulario As String, mascota As Mascota, cliente As Cliente)
        MyBase.New()
        InitializeComponent()
        _modoFormulario = modoFormulario
        _frmMantenedorMascotas = frmMantenedorMascotas
        _mascota = mascota
        _cliente = cliente
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        _frmMantenedorMascotas.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Sub LlenarEspecies()
        cmbEspecies.Items.Clear()
        Dim listaEspecies As New List(Of Especie) : Dim bsnEspecie As New BsnEspecie
        listaEspecies = bsnEspecie.GetEspecies
        Dim detEspecie As String = "{0,-7}{1,-20}"
        For Each especie As Especie In listaEspecies
            cmbEspecies.Items.Add(String.Format(detEspecie, especie.IdEspecie, especie.NomEspecie))
        Next
    End Sub

    Sub LlenarRazas(id_especie As Integer)
        cmbRazas.Items.Clear()
        Dim listaRazas As New List(Of Raza) : Dim bsnRaza As New BsnRaza
        listaRazas = bsnRaza.GetRazas
        Dim detRaza As String = "{0,-7}{1,-20}"
        For Each raza As Raza In listaRazas
            If raza.IdEspecie = id_especie Then
                cmbRazas.Items.Add(String.Format(detRaza, raza.IdRaza, raza.NomRaza))
            End If
        Next
    End Sub

    Sub CargarDatosCliente(cliente As Cliente)
        lbl_nombre.Text = cliente.Nombre : lbl_direccion.Text = cliente.DireccionCliente
        lbl_correo.Text = cliente.Correo : lbl_telefono.Text = cliente.FonoCliente
        lbl_rut.Text = cliente.Rut : lbl_num_cliente.Text = cliente.NumCliente
        LlenarMascotasCliente(cliente.NumCliente)
        Dim ruta As String = "../../img/clientes/" & cliente.NumCliente & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbCliente.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            pbCliente.Image = My.Resources.user_symbol_318_63527
        End If
    End Sub

    Sub CargarDatosMascota(mascota As Mascota)
        lbl_numero.Text = mascota.IdFicha
        txt_nombre.Text = mascota.NomMascota
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
        Dim i As Integer = 0 : Dim lg As Integer = cmbEspecies.Items.Count
        Dim cadena As String = "" : Dim idEspecie As Integer = 0 : Dim encontrado As Boolean = False
        While i < lg And encontrado = False
            cadena = cmbEspecies.Items.Item(i) : idEspecie = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            If especie.IdEspecie = idEspecie Then
                cmbEspecies.SelectedIndex = i : encontrado = True
            End If
            i = i + 1
        End While
        LlenarRazas(especie.IdEspecie)
        i = 0 : lg = cmbRazas.Items.Count : Dim idRaza As Integer = 0 : encontrado = False
        While i < lg And encontrado = False
            cadena = cmbRazas.Items.Item(i) : idRaza = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            If mascota.IdRaza = idRaza Then
                cmbRazas.SelectedIndex = i : encontrado = True
            End If
            i = i + 1
        End While
        Select Case mascota.Sexo
            Case "F" : rb_hembra.Select()
            Case "M" : rb_macho.Select()
        End Select
        dtp_nac.Value = mascota.FechaNacimiento : txt_color.Text = mascota.Color : txtIdChip.Text = mascota.IdChip
        txt_fingreso.Text = mascota.FechaIngreso
        Dim ruta As String = "../../img/mascotas/" & mascota.IdFicha & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbMascota.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            imagenCargada = True
            imagenRepetida = True
        End If
    End Sub

    Private Sub frm_ficha_general_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_nac.Value = System.DateTime.Today
        rb_hembra.Select()
        LlenarEspecies()

        panelSeleccionar.Top = 178 : panelSeleccionar.Left = 0
        panelSeleccionar.Width = 878 : panelSeleccionar.Height = 166
        panelCliente.Top = 178 : panelCliente.Left = 0
        panelCliente.Width = 878 : panelCliente.Height = 166

        Select Case _modoFormulario
            Case "agregar"
                Dim bsnMascota As New BsnMascota : lbl_numero.Text = bsnMascota.GenerarIdFicha() : btnVPre2.Visible = False
                txt_fingreso.Text = System.DateTime.Today : btnSeleccionarCliente.Top = 66 : LimpiarPanelCliente()
            Case "modificar"
                CargarDatosCliente(_cliente) : CargarDatosMascota(_mascota) : panelCliente.Visible = True : panelSeleccionar.Visible = False
                btn_cambiarCliente.Visible = True : btn_agregar.Text = "MODIFICAR"
        End Select
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        '//////////////////////////////////////validaciones////////////////////////////////////////////////
        If txt_nombre.Text = "" Then
            MsgBox("Debe ingresar un nombre para la mascota") : txt_nombre.Focus() : txt_nombre.BackColor = Color.Yellow : Exit Sub
        End If
        If lbl_num_cliente.Text = "" Then
            MsgBox("Debe seleccionar un cliente de la lista") : Exit Sub
        End If
        Dim fechaActual As Date = System.DateTime.Today : Dim fechaNacimiento As Date = dtp_nac.Value
        If fechaActual < fechaNacimiento Then
            MsgBox("La fecha de nacimiento no es válida." & vbLf & "El valor hace referencia a un día que todavía no ha acontecido.")
            dtp_nac.Focus() : Exit Sub
        End If
        Dim año As Integer = Convert.ToInt32(fechaActual.ToString.Substring(6, 4))
        año = año - 20
        Dim nueva As Date = fechaActual.ToString.Substring(0, 6) & año.ToString
        If fechaNacimiento < nueva Then
            If MessageBox.Show("La fecha ingresada es de más de 20 años atrás" & vbLf &
                                           "¿Esta seguro que la fecha es correcta?", "Alerta", MessageBoxButtons.OKCancel,
                                                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        Dim bsnMascota As New BsnMascota : Dim id_ficha As String = lbl_numero.Text : Dim nombre_mascota As String = UCase(txt_nombre.Text)
        Dim num_cliente As Int32 = CType(lbl_num_cliente.Text, Int32) : Dim fecha_nac_mascota As String = Format(dtp_nac.Value, "yyyy/MM/dd")
        Dim id_raza As Integer = 0

        Dim validarNombre As Integer = bsnMascota.ValidarMascotaCliente(num_cliente, nombre_mascota)
        Dim repetidoMascota As Boolean = False
        If validarNombre <> -1 Then
            Dim mascotaAux As New Mascota : mascotaAux = bsnMascota.GetDatosMascota(validarNombre)
            Select Case _modoFormulario
                Case "agregar" : repetidoMascota = True
                Case "modificar"
                    If mascotaAux.IdFicha <> id_ficha Then
                        repetidoMascota = True
                    End If
            End Select

            If repetidoMascota = True Then
                Dim razaAux As New Raza : Dim bsnRaza As New BsnRaza : razaAux = bsnRaza.GetDatosRaza(mascotaAux.IdRaza)
                Dim especieAux As New Especie : Dim bsnEspecie As New BsnEspecie : especieAux = bsnEspecie.GetDatosEspecie(razaAux.IdEspecie)
                Dim clienteAux As New Cliente : Dim bsnCliente As New BsnCliente : clienteAux = bsnCliente.GetDatosCliente(mascotaAux.IdCliente)

                If MessageBox.Show("Existe una mascota registrada con el mismo nombre al mismo cliente." & vbLf &
                           "**************************************************************************" & vbLf &
                           "ID Ficha : " & mascotaAux.IdFicha & vbLf &
                           "Dueño : " & clienteAux.Nombre & vbLf &
                           "Nombre : " & mascotaAux.NomMascota & vbLf &
                           "Especie : " & especieAux.NomEspecie & vbLf &
                           "Raza : " & razaAux.NomRaza & vbLf &
                           "**************************************************************************" & vbLf &
                           "¿Desea continuar de todas maneras?", "Alerta",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If
            End If
        End If

        '////////////////////////////////////fin validaciones//////////////////////////////////////////

        '//////////identificar especie/raza///////////////////////////////
        If cmbEspecies.SelectedIndex = -1 Then
            id_raza = 0
        Else
            If cmbRazas.SelectedIndex = -1 Then
                Dim cadEspecie As String = cmbEspecies.SelectedItem()
                Dim id_especie As Integer = Convert.ToInt32(Trim(cadEspecie.Substring(0, 5)))
                Dim bsnEspecie As New BsnEspecie
                id_raza = bsnEspecie.IdentificarRazaNull(id_especie)
            Else
                Dim cadRaza As String = cmbRazas.SelectedItem
                id_raza = Convert.ToInt32(Trim(cadRaza.Substring(0, 5)))
            End If
        End If
        '/////////////////////////////////////////////////////////////////
        Dim convertir As New Convertir
        Dim sexo As Char = X_genero
        Dim colorVar As String = UCase(txt_color.Text)
        Dim fecha_ingreso As String = convertir.invertir_fecha(Trim(txt_fingreso.Text))
        Dim id_chip As String = txtIdChip.Text

        Dim mascota As New Mascota(id_ficha, nombre_mascota, num_cliente, fecha_nac_mascota, id_raza, sexo, colorVar, fecha_ingreso, True, id_chip)
        If _modoFormulario = "agregar" Then
            bsnMascota.InsertarMascota(mascota)
        End If
        If _modoFormulario = "modificar" Then
            bsnMascota.ModificarMascota(mascota)
        End If
        Dim ruta As String = "../../img/mascotas/" & id_ficha & ".jpg"
        If imagenCargada = True Then
            If Not imagenRepetida = True Then
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                pbMascota.Image.Save(ruta, Imaging.ImageFormat.Jpeg)
            End If
        Else
            If File.Exists(ruta) Then
                My.Computer.FileSystem.DeleteFile(ruta)
            End If
            _frmMantenedorMascotas.pbMascota.Image = My.Resources.mascotaSilueta
        End If

        _frmMantenedorMascotas.llenar_mascotas()
        _frmMantenedorMascotas.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub rb_hembra_CheckedChanged(sender As Object, e As EventArgs) Handles rb_hembra.CheckedChanged
        X_genero = "F"
    End Sub

    Private Sub rb_macho_CheckedChanged(sender As Object, e As EventArgs) Handles rb_macho.CheckedChanged
        X_genero = "M"
    End Sub

    Sub Ayuda(ByVal globo As ToolTip, ByVal objeto As Control, ByVal mensaje As String)
        globo.RemoveAll()
        globo.SetToolTip(objeto, mensaje)
        globo.InitialDelay = 250
        globo.IsBalloon = False
    End Sub

    Private Sub btn_generar_num_mascota_Click(sender As Object, e As EventArgs) Handles btn_generar_num_mascota.Click
        lbl_numero.Text = txt_auxiliar.Text
    End Sub

    Sub LlenarMascotasCliente(num_cliente As Integer)
        Dim listaMascotasCliente As New List(Of Mascota)
        Dim bsnMascota As New BsnMascota
        listaMascotasCliente = bsnMascota.GetMascotasCliente(num_cliente)
        lstMascotasCliente.Items.Clear()
        For Each mascota As Mascota In listaMascotasCliente
            lstMascotasCliente.Items.Add(String.Format(detalleMascota, mascota.IdFicha, mascota.NomMascota))
        Next
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

            pbMascota.Image = Image.FromFile(ofd.FileName)
            imagenCargada = True
            imagenRepetida = False
        End If
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        pbMascota.Image = My.Resources.mascotaSilueta
        imagenCargada = False
    End Sub

    '//////////////////////////////MOVIMIENTO DEL FORMULARIO///////////////////////////////////////////////////
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub frm_ficha_general_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub frm_ficha_general_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub cmbEspecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecies.SelectedIndexChanged
        Dim cadena As String = cmbEspecies.SelectedItem
        Dim id_especie As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 6)))
        cmbRazas.SelectedIndex = -1
        LlenarRazas(id_especie)

    End Sub

    Private Sub frm_ficha_general_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(x:=MousePosition.X - Me.Location.X - ex, y:=MousePosition.Y - Me.Location.Y - ey))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub txt_nombre_Leave(sender As Object, e As EventArgs) Handles txt_nombre.Leave
        txt_nombre.BackColor = Color.White
    End Sub

    Private Sub btn_cambiarCliente_Click(sender As Object, e As EventArgs) Handles btn_cambiarCliente.Click
        panelSeleccionar.Visible = True : panelCliente.Visible = False
        btnSeleccionarCliente.Top = 26
        If _modoFormulario = "modificar" Then
            btnVPre2.Visible = True
        End If

        If _modoFormulario = "agregar" Then
            btnVolverCliente.Top = 66
        End If
        btnVolverCliente.Visible = True
    End Sub

    Private Sub btnVPre2_Click(sender As Object, e As EventArgs) Handles btnVPre2.Click
        CargarDatosCliente(_cliente)
        panelSeleccionar.Visible = False : panelCliente.Visible = True
    End Sub

    Private Sub btnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCliente.Click
        Dim frmMantenedorClientes As New frm_Mantenedor_Clientes(Me, "seleccionar")
        frmMantenedorClientes.Show() : Me.Hide()
    End Sub

    Private Sub btnVolverCliente_Click(sender As Object, e As EventArgs) Handles btnVolverCliente.Click
        panelCliente.Visible = True : panelSeleccionar.Visible = False
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_color_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_color.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdChip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdChip.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub pbAgregarCliente_Click_1(sender As Object, e As EventArgs) Handles pbAgregarCliente.Click
        Dim frmMantenedorClientes As New frm_Mantenedor_Clientes(Me, "agregar")
        frmMantenedorClientes.Show() : Me.Hide()
    End Sub

    Private Sub pbAgregarCliente_MouseEnter_1(sender As Object, e As EventArgs) Handles pbAgregarCliente.MouseEnter
        pbAgregarCliente.Image = My.Resources.CLIENTES_DESTACADO
    End Sub

    Private Sub pbAgregarCliente_MouseLeave_1(sender As Object, e As EventArgs) Handles pbAgregarCliente.MouseLeave
        pbAgregarCliente.Image = My.Resources.CLIENTES
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCambiarNumFicha.Click
        If txtCambiarNumFicha.Text = "" Then
            MsgBox("Para cambiar el número de ficha debe ingresar un valor.")
            Exit Sub
        End If

        Dim idFicha As String = UCase(txtCambiarNumFicha.Text)
        Dim bsnNegocio As New BsnNegocio : Dim encontrado As Integer = 0
        encontrado = bsnNegocio.ValidarPorTexto("mascota", "id_ficha", idFicha)

        If encontrado <> -1 Then
            MsgBox("Ya existe una mascota con ese número de ficha.")
            Exit Sub
        End If

        lbl_numero.Text = idFicha : txtCambiarNumFicha.Text = ""
    End Sub

    Private Sub txtCambiarNumFicha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCambiarNumFicha.KeyPress
        If (Asc(e.KeyChar) <> 66) Then
            If (Asc(e.KeyChar) <> 65) Then
                If (Asc(e.KeyChar) <> 98) Then
                    If (Asc(e.KeyChar) <> 97) Then
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

    Sub LimpiarPanelCliente()
        lbl_nombre.Text = "" : lbl_direccion.Text = "" : lbl_correo.Text = "" : lbl_telefono.Text = ""
        lbl_rut.Text = "" : lbl_num_cliente.Text = "" : lstMascotasCliente.Items.Clear()
    End Sub

End Class
Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices


Public Class frm_Mantenedor_Mascotas



    Protected _frmPrincipal As frm_Principal
    Protected _frmGestorHospitalizaciones As FRM_Gestor_Hospitalizaciones
    Protected _modalidad As String = ""
    Protected _frmCalendario As frm_Calendario
    Protected _subOpcion
    Protected _frmConsultarMascota As frm_Consultar_Mascota

    Dim busqueda As String = ""

    Dim detalle As String = "{0, -7}{1, -23}{2, -13}{3, -18}{4, -33}"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        _modalidad = ""
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Public Sub New(frmGestorHosp As FRM_Gestor_Hospitalizaciones)
        _modalidad = "hosp"
        _frmGestorHospitalizaciones = frmGestorHosp
        InitializeComponent()
        ModoSeleccion()
    End Sub

    Public Sub New(frmCalendario As frm_Calendario, subOpcion As String)
        _modalidad = "calendario"
        _frmCalendario = frmCalendario
        _subOpcion = subOpcion
        InitializeComponent()
        ModoSeleccion()
    End Sub

    Public Sub New(frmConsultarMascota As frm_Consultar_Mascota)
        _modalidad = "consultar"
        _frmConsultarMascota = frmConsultarMascota
        InitializeComponent()
        ModoSeleccion()
    End Sub

    Sub ModoSeleccion()
        btnAgregar.Visible = False : btnModificar.Visible = False : btnEliminar.Visible = False : btn_historial.Visible = False
        Label3.Text = "SELECCIONAR MASCOTA" : btnSeleccionar.Left = 21 : btnSeleccionar.Visible = True
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Select Case _modalidad
            Case "" : _frmPrincipal.Show()
            Case "hosp" : _frmGestorHospitalizaciones.Show()
            Case "calendario" : _frmCalendario.Show()
            Case "consultar" : _frmConsultarMascota.Show()
        End Select
        Me.Close()
    End Sub



    Private Sub frm_Mantenedor_Mascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_mascotas()
        limpiar_panel()
    End Sub


    Sub llenar_mascotas()
        lst_mascotas.Items.Clear()
        Dim listaMascotas As New List(Of Mascota) : Dim bsnMascota As New BsnMascota
        listaMascotas = bsnMascota.GetMascotas()
        For Each mascota As Mascota In listaMascotas
            If mascota.Status = True Then
                Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
                Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
                Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
                lst_mascotas.Items.Add(String.Format(detalle, mascota.IdFicha, mascota.NomMascota, especie.NomEspecie,
                                                     raza.NomRaza, cliente.Nombre))
            End If
        Next
    End Sub

    Private Sub lst_mascotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_mascotas.SelectedIndexChanged
        If lst_mascotas.SelectedIndex <> -1 Then
            Dim cadena As String = lst_mascotas.SelectedItem
            Dim idFicha As String = Trim(cadena.Substring(0, 7))
            Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(idFicha)
            LlenarPanelMascota(mascota)
        End If
    End Sub

    Sub LlenarPanelMascota(mascota As Mascota)
        lbl_numero.Text = mascota.IdFicha : lbl_nombre.Text = mascota.NomMascota
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        lbl_cliente.Text = cliente.Nombre : lblFono.Text = cliente.FonoCliente : lbl_nac.Text = mascota.FechaNacimiento
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
        lbl_especie.Text = especie.NomEspecie : lbl_raza.Text = raza.NomRaza : lblIdRaza.Text = raza.IdRaza
        If mascota.Sexo = "M" Then
            lbl_sexo.Text = "MASCULINO"
        Else
            lbl_sexo.Text = "FEMENINO"
        End If
        lbl_color.Text = mascota.Color : lbl_fingreso.Text = mascota.FechaIngreso : lblIdChip.Text = mascota.IdChip

        Dim ruta As String = "../../img/mascotas/" & mascota.IdFicha & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbMascota.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            pbMascota.Image = My.Resources.mascotaSilueta
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frmFichaGeneral As New frm_ficha_general(Me, "agregar")
        frmFichaGeneral.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_historial.Click
        If lst_mascotas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una mascota de la lista")
            Exit Sub
        End If

        Dim cadena As String = lst_mascotas.SelectedItem : Dim idFicha As String = Trim(cadena.Substring(0, 7))
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(idFicha)
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente
        cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim hola As Boolean = True
        Dim frmPerfil As New FRM_Perfil(mascota, cliente, Me)

        frmPerfil.Show() : Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If lst_mascotas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una mascota si quiere modificarla.")
            Exit Sub
        End If

        Dim cadena As String = lst_mascotas.SelectedItem : Dim idFicha As String = Trim(cadena.Substring(0, 7))
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(idFicha)
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim frmFicha As New frm_ficha_general(Me, "modificar", mascota, cliente)
        frmFicha.Show() : Me.Hide()
    End Sub

    Sub ordenar_por(criterio)

    End Sub

    Private Sub btn_ordenar_num_Click(sender As Object, e As EventArgs) Handles btn_ordenar_num.Click
        pbMascota.Image = My.Resources.mascotaSilueta
        lblApoyoIndex.Text = "-1"
        limpiar_panel() : limpiarBusqueda()
        llenar_mascotas()
    End Sub

    Private Sub btn_ordenar_cliente_Click(sender As Object, e As EventArgs) Handles btn_ordenar_cliente.Click
        pbMascota.Image = My.Resources.mascotaSilueta
        lblApoyoIndex.Text = "-1"
        limpiar_panel() : limpiarBusqueda()
        ordenar_por("nombre")
    End Sub

    Private Sub btn_ordenar_nombre_Click(sender As Object, e As EventArgs) Handles btn_ordenar_nombre.Click
        pbMascota.Image = My.Resources.mascotaSilueta
        lblApoyoIndex.Text = "-1"
        limpiar_panel() : limpiarBusqueda()
        ordenar_por("nombre_mascota")
    End Sub

    Private Sub btn_ordenar_raza_Click(sender As Object, e As EventArgs) Handles btn_ordenar_raza.Click
        pbMascota.Image = My.Resources.mascotaSilueta
        lblApoyoIndex.Text = "-1"
        limpiar_panel() : limpiarBusqueda()
        ordenar_por("nom_raza")
    End Sub

    Private Sub btn_ordenar_fono_Click(sender As Object, e As EventArgs)
        pbMascota.Image = My.Resources.mascotaSilueta
        lblApoyoIndex.Text = "-1"
        limpiar_panel() : limpiarBusqueda()
        ordenar_por("fono_cliente")
    End Sub

    Private Sub txt_busqueda_num_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_num.TextChanged
        buscar_por("num", 0)
    End Sub

    Sub buscar_por(criterio, inicio)
        Dim largo As Integer = lst_mascotas.Items.Count : Dim i = inicio : Dim valor_lista As String = ""
        Dim cadena As String = "" : Dim valor_busqueda As String = ""

        Select Case criterio
            Case "num" : valor_busqueda = txt_busqueda_num.Text : valor_busqueda = UCase(valor_busqueda)
            Case "cliente" : valor_busqueda = txt_busqueda_cliente.Text : valor_busqueda = UCase(valor_busqueda)
            Case "nombre" : valor_busqueda = Trim(txt_busqueda_nombre.Text) : valor_busqueda = UCase(valor_busqueda)
            Case "raza" : valor_busqueda = Trim(txt_busqueda_raza.Text) : valor_busqueda = UCase(valor_busqueda)
            Case "especie" : valor_busqueda = Trim(txt_busqueda_especie.Text) : valor_busqueda = UCase(valor_busqueda)
        End Select

        If valor_busqueda = "" Then
            lst_mascotas.SelectedIndex = -1 : limpiar_panel()
            BusquedaBlanco(criterio)
        Else
            While i < largo And valor_lista <> valor_busqueda
                cadena = lst_mascotas.Items.Item(i)
                Select Case criterio
                    Case "num" : valor_lista = cadena.Substring(0, valor_busqueda.Length)
                    Case "nombre" : valor_lista = cadena.Substring(7, valor_busqueda.Length)
                    Case "especie" : valor_lista = cadena.Substring(30, valor_busqueda.Length)
                    Case "raza" : valor_lista = cadena.Substring(43, valor_busqueda.Length)
                    Case "cliente" : valor_lista = cadena.Substring(61, valor_busqueda.Length)
                End Select
                If valor_lista = valor_busqueda Then
                    lst_mascotas.SelectedIndex = i
                Else
                    i = i + 1
                End If
            End While

            If i = largo Then  '//////////significa que no lo encontro/////////////////////
                lst_mascotas.SelectedIndex = -1 : limpiar_panel() : BusquedaRojo(criterio)
            Else
                BusquedaBlanco(criterio)
            End If
        End If
    End Sub

    Sub BusquedaBlanco(criterio As String)
        Select Case criterio
            Case "num" : txt_busqueda_num.BackColor = Color.FromArgb(255, 255, 255)
            Case "cliente" : txt_busqueda_cliente.BackColor = Color.FromArgb(255, 255, 255)
            Case "nombre" : txt_busqueda_nombre.BackColor = Color.FromArgb(255, 255, 255)
            Case "raza" : txt_busqueda_raza.BackColor = Color.FromArgb(255, 255, 255)
            Case "especie" : txt_busqueda_especie.BackColor = Color.FromArgb(255, 255, 255)
        End Select
    End Sub

    Sub BusquedaRojo(criterio As String)
        Select Case criterio
            Case "num" : txt_busqueda_num.BackColor = Color.FromArgb(255, 128, 128)
            Case "cliente" : txt_busqueda_cliente.BackColor = Color.FromArgb(255, 128, 128)
            Case "nombre" : txt_busqueda_nombre.BackColor = Color.FromArgb(255, 128, 128)
            Case "raza" : txt_busqueda_raza.BackColor = Color.FromArgb(255, 128, 128)
            Case "especie" : txt_busqueda_especie.BackColor = Color.FromArgb(255, 128, 128)
        End Select
    End Sub

    Private Sub txt_busqueda_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_cliente.TextChanged
        buscar_por("cliente", 0)
    End Sub

    Private Sub txt_busqueda_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_nombre.TextChanged
        buscar_por("nombre", 0)
    End Sub

    Private Sub txt_busqueda_raza_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_raza.TextChanged
        buscar_por("raza", 0)
    End Sub

    Private Sub txt_busqueda_fono_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda_especie.TextChanged
        buscar_por("especie", 0)
    End Sub

    Private Sub txt_busqueda_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda_num.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscar_por("num", lst_mascotas.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txt_busqueda_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda_cliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscar_por("cliente", lst_mascotas.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txt_busqueda_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscar_por("nombre", lst_mascotas.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txt_busqueda_raza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda_raza.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscar_por("raza", lst_mascotas.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txt_busqueda_fono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_busqueda_especie.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscar_por("especie", lst_mascotas.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txt_busqueda_num_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_num.Leave
        txt_busqueda_num.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txt_busqueda_cliente_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_cliente.Leave
        txt_busqueda_cliente.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txt_busqueda_nombre_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_nombre.Leave
        txt_busqueda_nombre.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txt_busqueda_raza_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_raza.Leave
        txt_busqueda_raza.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txt_busqueda_fono_Leave(sender As Object, e As EventArgs) Handles txt_busqueda_especie.Leave
        txt_busqueda_especie.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Sub limpiar_panel()
        lbl_numero.Text = "" : lbl_nombre.Text = "" : lbl_cliente.Text = "" : lbl_especie.Text = "" : lbl_raza.Text = ""
        lbl_sexo.Text = "" : lbl_fingreso.Text = "" : lbl_nac.Text = "" : lbl_color.Text = "" : lblIdChip.Text = ""
        lblFono.Text = "" : lblIdRaza.Text = "" : pbMascota.Image = My.Resources.mascotaSilueta
    End Sub

    Function limpiarBusqueda()
        txt_busqueda_cliente.Text = "" : txt_busqueda_especie.Text = "" : txt_busqueda_nombre.Text = "" : txt_busqueda_raza.Text = ""
        txt_busqueda_num.Text = ""
        Return 0
    End Function

    Private Sub txt_busqueda_num_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_num.Enter
        pbMascota.Image = My.Resources.mascotaSilueta
        txt_busqueda_cliente.Text = "" : txt_busqueda_especie.Text = "" : txt_busqueda_nombre.Text = "" : txt_busqueda_raza.Text = ""
    End Sub

    Private Sub txt_busqueda_cliente_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_cliente.Enter
        pbMascota.Image = My.Resources.mascotaSilueta
        txt_busqueda_num.Text = "" : txt_busqueda_especie.Text = "" : txt_busqueda_nombre.Text = "" : txt_busqueda_raza.Text = ""
    End Sub

    Private Sub txt_busqueda_nombre_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_nombre.Enter
        pbMascota.Image = My.Resources.mascotaSilueta
        txt_busqueda_cliente.Text = "" : txt_busqueda_especie.Text = "" : txt_busqueda_num.Text = "" : txt_busqueda_raza.Text = ""
    End Sub

    Private Sub txt_busqueda_raza_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_raza.Enter
        pbMascota.Image = My.Resources.mascotaSilueta
        txt_busqueda_cliente.Text = "" : txt_busqueda_especie.Text = "" : txt_busqueda_nombre.Text = "" : txt_busqueda_num.Text = ""
    End Sub

    Private Sub txt_busqueda_fono_Enter(sender As Object, e As EventArgs) Handles txt_busqueda_especie.Enter
        pbMascota.Image = My.Resources.mascotaSilueta
        txt_busqueda_cliente.Text = "" : txt_busqueda_num.Text = "" : txt_busqueda_nombre.Text = "" : txt_busqueda_raza.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lst_mascotas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una mascota si quiere eliminarla.")
            Exit Sub
        End If

        If MessageBox.Show("¿Esta seguro que desea eliminar esta mascota?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim cadena As String = lst_mascotas.SelectedItem : Dim idFicha As String = Trim(cadena.Substring(0, 7))
            Dim bsnMascota As New BsnMascota : Dim bsnNegocio As New BsnNegocio

            Dim validarOb As Integer = bsnNegocio.ValidarPorTexto("observacion", "id_ficha", idFicha)
            Dim validarAt As Integer = bsnNegocio.ValidarPorTexto("atencion", "id_ficha", idFicha)
            Dim validarHo As Integer = bsnNegocio.ValidarPorTexto("hospitalizacion", "id_ficha", idFicha)
            Dim validarVa As Integer = bsnNegocio.ValidarPorTexto("vacuna_mascota", "id_ficha", idFicha)

            If validarOb = -1 And validarAt = -1 And validarHo = -1 And validarVa = -1 Then
                bsnMascota.EliminarMascota(idFicha)
                Dim ruta As String = "../../img/mascotas/" & idFicha & ".jpg"
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                llenar_mascotas() : limpiar_panel()
                MsgBox("La mascota ha sido eliminada correctamente")
            Else
                MsgBox("No se puede eliminar esta mascota porque tiene registros asociados.")
            End If
        End If
    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub frm_Mantenedor_Mascotas_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub frm_Mantenedor_Mascotas_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(x:=MousePosition.X - Me.Location.X - ex, y:=MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ex = e.X + Me.Size.Width - Panel1.Size.Width
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        Arrastre = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        frm_Mantenedor_Mascotas_MouseMove(Me, e)
    End Sub

    Private Sub frm_Mantenedor_Mascotas_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////

    Private Sub pbSalir_Click(sender As Object, e As EventArgs) Handles pbSalir.Click
        _frmPrincipal.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEspecie_Click(sender As Object, e As EventArgs) Handles btnEspecie.Click
        pbMascota.Image = My.Resources.mascotaSilueta
        lst_mascotas.SelectedIndex = -1
        lblApoyoIndex.Text = "-1"
        ordenar_por("nom_especie")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If lst_mascotas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una mascota.")
            Exit Sub
        End If
        Dim cadena As String = lst_mascotas.SelectedItem()
        Dim idFicha As String = Trim(cadena.Substring(0, 5))
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(idFicha)
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)

        Select Case _modalidad
            Case "hosp"
                _frmGestorHospitalizaciones.btnSeleccionar.Left = 45
                _frmGestorHospitalizaciones.btnSeleccionar.Top = 155
                _frmGestorHospitalizaciones.btnSeleccionar.Text = "CAMBIAR MASCOTA"
                _frmGestorHospitalizaciones.lblNombre.Text = mascota.NomMascota
                _frmGestorHospitalizaciones.lblEspecie.Text = especie.NomEspecie
                _frmGestorHospitalizaciones.lblDueñoPanel.Text = cliente.Nombre
                _frmGestorHospitalizaciones.lblIdFichaPanel.Text = mascota.IdFicha
                _frmGestorHospitalizaciones.Panel3.Visible = True
                _frmGestorHospitalizaciones.Show()
            Case "calendario"
                If _subOpcion = "panelDerecho" Then
                    _frmCalendario.lbl_id_ficha.Text = mascota.IdFicha
                    _frmCalendario.lbl_nom_mascota.Text = mascota.NomMascota
                    _frmCalendario.lbl_especie.Text = especie.NomEspecie
                    _frmCalendario.lbl_nom_cliente.Text = cliente.Nombre
                    _frmCalendario.lbl_fono_cliente.Text = cliente.FonoCliente
                    _frmCalendario.btn_busqueda.Text = "CAMBIAR MASCOTA"
                End If

                If _subOpcion = "panelIzquierdo" Then
                    _frmCalendario.lblBusIdFicha.Text = mascota.IdFicha
                    _frmCalendario.lblBusNomMascota.Text = mascota.NomMascota
                    _frmCalendario.lblBusEspecie.Text = especie.NomEspecie
                    _frmCalendario.lblBusNomCliente.Text = cliente.Nombre
                    _frmCalendario.panelBusMascota.Left = 0 : _frmCalendario.panelBusMascota.Top = 289
                    _frmCalendario.panelBusMascota.Width = 324 : _frmCalendario.panelBusMascota.Height = 144
                    _frmCalendario.panelBusMascota.Visible = True
                    _frmCalendario._modoFiltro = True
                    _frmCalendario.CargarAtencionesMascota(mascota)
                    _frmCalendario.panel_agendar.Visible = False
                    _frmCalendario.calendario.Visible = False
                    _frmCalendario.pbVolver.Visible = True
                    _frmCalendario.pbVolver.Top = 60 : _frmCalendario.pbVolver.Left = 60
                    _frmCalendario.pbVolver.Width = 200 : _frmCalendario.pbVolver.Height = 200
                    _frmCalendario.panelAtenciones.Visible = True
                    _frmCalendario.lbl_fecha_sel.Visible = False : _frmCalendario.Label1.Visible = False
                    _frmCalendario.btnAtencionesMascotas.Visible = False
                End If
                _frmCalendario.Show()

            Case "consultar"
                _frmConsultarMascota.CargarDatosMascota(mascota)
                _frmConsultarMascota.Show()
        End Select
        Me.Close()
    End Sub

    Private Sub pbMinimizar_Click(sender As Object, e As EventArgs) Handles pbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class

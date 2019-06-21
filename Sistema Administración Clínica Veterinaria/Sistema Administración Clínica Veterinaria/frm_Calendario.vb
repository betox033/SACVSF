Imports MySql.Data.MySqlClient

Public Class frm_Calendario

    Protected _frmPrincipal As frm_Principal
    Dim _modoOpcion As String
    Public _listadoFecha As Boolean = False
    Public _modoFiltro As Boolean = False

    Dim detalle As String = "{0, -10}{1, -20}"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Private Sub calendario_DateClick(sender As Object, e As AxMSComCtl2.DMonthViewEvents_DateClickEvent) Handles calendario.DateClick
        Dim convertir As New Convertir
        lbl_fecha_sel.Text = calendario.Value
        dtp_fecha.Value = calendario.Value
        Dim fecha As String = convertir.invertir_fecha(lbl_fecha_sel.Text)
        CargarAtenciones(fecha)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        _frmPrincipal.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendario.Value = DateTime.Now.ToString("dd/MM/yyyy")
        lbl_fecha_sel.Text = calendario.Value
        '///////////////////////////////
        panelAtenciones.Top = 79 : panelAtenciones.Left = 344
        panelAtenciones.Width = 506 : panelAtenciones.Height = 390
        Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
        CargarAtenciones(fecha) : LimpiarPanelAgendar()
        Panel8.Top = 79 : Panel8.Left = 345 : Panel8.Height = 54 : Panel8.Width = 496
    End Sub

    Sub CargarAtenciones(fecha As String)
        panelAtenciones.Controls.Clear()
        Dim listaAtenciones As New List(Of Atencion) : Dim bsnAtencion As New BsnAtencion
        listaAtenciones = bsnAtencion.GetAtencionesFecha(fecha)
        Dim altura As Integer = 0
        For Each atencion As Atencion In listaAtenciones
            If atencion.Estado = True Then
                CrearDetalle(atencion, altura)
                altura = altura + 155
            End If
        Next

        Dim listaVacunas As New List(Of Vacuna) : Dim bsnVacuna As New BsnVacuna
        listaVacunas = bsnVacuna.GetVacunasFecha(fecha)
        For Each vacuna As Vacuna In listaVacunas
            CrearDetalleVacuna(vacuna, altura)
            altura = altura + 135
        Next

        If listaAtenciones.Count = 0 And listaVacunas.Count = 0 Then
            panelAtenciones.Visible = False
            Panel8.Visible = True
            Dim convertir As New Convertir
            Dim fch As String = fecha
            fch = convertir.dar_vuelta_fecha(fch)
            Label13.Text = "No hay atenciones registradas ni agendadas"
            Label15.Text = "para la fecha : " & fch : Label15.Visible = True
        Else
            panelAtenciones.Visible = True : Panel8.Visible = False
        End If
    End Sub

    Sub CargarAtencionesMascota(mascota As Mascota)
        Dim listaBusMascota As New List(Of Atencion) : Dim bsnAtencion As New BsnAtencion
        listaBusMascota = bsnAtencion.GetAtencionesMascota(mascota.IdFicha)
        Dim altura As Integer = 0 : panelAtenciones.Controls.Clear()
        _listadoFecha = True : Dim ctAtAg As Integer = 0
        For Each atencion As Atencion In listaBusMascota
            If atencion.TipoAtencion = "A" And atencion.Estado = True Then
                CrearDetalle(atencion, altura)
                altura = altura + 155
                ctAtAg = ctAtAg + 1
            End If
        Next
        _listadoFecha = False

        If ctAtAg = 0 Then
            Panel8.Visible = True : Label15.Visible = False
            Label13.Text = "No hay atenciones agendadas para esta mascota."
        Else
            Panel8.Visible = False
        End If
    End Sub

    Sub CrearDetalleVacuna(vacuna As Vacuna, altura As Integer)
        Dim panel As New Panel
        panelAtenciones.Controls.Add(panel)
        panel.Left = 5 : panel.Top = altura : panel.Width = 475 : panel.Height = 125
        panel.Name = vacuna.NumVacuna
        panel.BackColor = Color.Thistle : panel.ForeColor = Color.DarkSlateBlue

        Dim producto As New Producto : Dim bsnProducto As New BsnProductos : producto = bsnProducto.GetDatosProducto(vacuna.Codproducto)
        '/////////////////////////////////////////////////////////////////////////////
        Dim lblT As Label = New Label
        panel.Controls.Add(lblT)
        lblT.Top = 105
        lblT.Left = 95 : lblT.AutoSize = True
        lblT.Font = New Font("Century Gothic", 8, FontStyle.Regular)
        Dim numel As String = ""
        If vacuna.NOrdinal > 0 Then
            numel = vacuna.NOrdinal & "° "
        End If
        Dim fec1 As String = vacuna.FechaVacuna : fec1 = fec1.Replace("/", "-")
        lblT.Text = "*Relacionado a " & numel & producto.NomProducto & " (" & fec1 & ")"
        '//////////////////////////////////////////////////////////////////////////////////////////////////////
        Dim lblTipo As Label = New Label
        panel.Controls.Add(lblTipo)
        lblTipo.Top = 5
        lblTipo.Left = 350 : lblTipo.AutoSize = True
        lblTipo.Font = New Font("Century Gothic", 11, FontStyle.Bold)
        lblTipo.Text = "***VACUNA***"
        '////////////////////////////////////////////////////////////////////////////////////////////////////
        Dim lblIdFi As Label = New Label
        panel.Controls.Add(lblIdFi)
        lblIdFi.Top = 5 : lblIdFi.Left = 5 : lblIdFi.AutoSize = True
        lblIdFi.Text = "N° Ficha : " : lblIdFi.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblIdF As Label = New Label
        panel.Controls.Add(lblIdF)
        lblIdF.Top = 5 : lblIdF.Left = 90 : lblIdF.AutoSize = True
        lblIdF.Text = vacuna.IdFicha : lblIdF.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '/////////////////////////////////////////////////////////
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(vacuna.IdFicha)
        Dim lblNomMa As Label = New Label
        panel.Controls.Add(lblNomMa)
        lblNomMa.Top = 25 : lblNomMa.Left = 5 : lblNomMa.AutoSize = True
        lblNomMa.Text = "Nombre : " : lblNomMa.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblNomM As Label = New Label
        panel.Controls.Add(lblNomM)
        lblNomM.Top = 25 : lblNomM.Left = 90 : lblNomM.AutoSize = True
        lblNomM.Text = mascota.NomMascota : lblNomM.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '///////////////////////////////////////////////////////////
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim lblCli As Label = New Label
        panel.Controls.Add(lblCli)
        lblCli.Top = 45 : lblCli.Left = 5 : lblCli.AutoSize = True
        lblCli.Text = "Dueño : " : lblCli.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblC As Label = New Label
        panel.Controls.Add(lblC)
        lblC.Top = 45 : lblC.Left = 90 : lblC.AutoSize = True
        lblC.Text = cliente.Nombre : lblC.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '////////////////////////////////////////////////////////
        Dim lblFo As Label = New Label
        panel.Controls.Add(lblFo)
        lblFo.Top = 65 : lblFo.Left = 5 : lblFo.AutoSize = True
        lblFo.Text = "Fono : " : lblFo.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblF As Label = New Label
        panel.Controls.Add(lblF)
        lblF.Top = 65 : lblF.Left = 90 : lblF.AutoSize = True
        lblF.Text = cliente.FonoCliente : lblF.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim btnPer As Button = New Button
        panel.Controls.Add(btnPer)
        btnPer.Top = 95 : btnPer.Left = 5
        btnPer.Width = 90 : btnPer.Height = 25
        btnPer.Text = "VER PERFIL" : btnPer.Name = mascota.IdFicha
        btnPer.Font = New Font("Century Gothic", 10, FontStyle.Regular)
        btnPer.FlatStyle = FlatStyle.Flat : btnPer.FlatAppearance.BorderSize = 0
        btnPer.BackColor = Color.Orchid : btnPer.ForeColor = Color.DarkSlateBlue

        AddHandler btnPer.Click, AddressOf btnPerfil_Click
    End Sub

    Sub CrearDetalle(atencion As Atencion, altura As Integer)
        Dim panel As New Panel
        panelAtenciones.Controls.Add(panel)
        panel.Left = 5 : panel.Top = altura : panel.Width = 475 : panel.Height = 145
        panel.Name = atencion.CodAtencion

        Select Case atencion.TipoAtencion
            Case "R" : panel.BackColor = Color.CadetBlue : panel.ForeColor = Color.White
            Case "A" : panel.BackColor = Color.Orange : panel.ForeColor = Color.Maroon
            Case "P" : panel.BackColor = Color.LightSalmon : panel.ForeColor = Color.Maroon
        End Select


        '///////////////////////////////////////////////////
        Dim lblTipo As Label = New Label
        panel.Controls.Add(lblTipo)
        lblTipo.Left = 310 : lblTipo.AutoSize = True
        lblTipo.Font = New Font("Century Gothic", 11, FontStyle.Underline)
        Select Case atencion.TipoAtencion
            Case "A" : lblTipo.Text = "Atención Agendada"
            Case "R" : lblTipo.Text = "Atención Registrada"
            Case "P" : lblTipo.Text = "Atención Perdida"
        End Select
        Select Case _modoFiltro
            Case True : lblTipo.Top = 25
            Case False : lblTipo.Top = 5
        End Select
        '//////////////////////////////////////////////////////
        Dim lblCodAt As Label = New Label
        panel.Controls.Add(lblCodAt)
        lblCodAt.Top = 5 : lblCodAt.Left = 5 : lblCodAt.AutoSize = True
        lblCodAt.Text = "N° Atn : " : lblCodAt.Font = New Font("Century Gothic", 12, FontStyle.Bold)

        Dim lblCodA As Label = New Label
        panel.Controls.Add(lblCodA)
        lblCodA.Top = 5 : lblCodA.Left = 90 : lblCodA.AutoSize = True
        lblCodA.Text = atencion.CodAtencion : lblCodA.Font = New Font("Century Gothic", 12, FontStyle.Bold)
        '//////////////////////////////////////////////////////
        Dim lblIdFi As Label = New Label
        panel.Controls.Add(lblIdFi)
        lblIdFi.Top = 25 : lblIdFi.Left = 5 : lblIdFi.AutoSize = True
        lblIdFi.Text = "N° Ficha : " : lblIdFi.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblIdF As Label = New Label
        panel.Controls.Add(lblIdF)
        lblIdF.Top = 25 : lblIdF.Left = 90 : lblIdF.AutoSize = True
        lblIdF.Text = atencion.IdFicha : lblIdF.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '//////////////////////////////////////////////////
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(atencion.IdFicha)
        Dim lblNomMa As Label = New Label
        panel.Controls.Add(lblNomMa)
        lblNomMa.Top = 45 : lblNomMa.Left = 5 : lblNomMa.AutoSize = True
        lblNomMa.Text = "Nombre : " : lblNomMa.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblNomM As Label = New Label
        panel.Controls.Add(lblNomM)
        lblNomM.Top = 45 : lblNomM.Left = 90 : lblNomM.AutoSize = True
        lblNomM.Text = mascota.NomMascota : lblNomM.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '/////////////////////////////////////////////////////
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim lblCli As Label = New Label
        panel.Controls.Add(lblCli)
        lblCli.Top = 65 : lblCli.Left = 5 : lblCli.AutoSize = True
        lblCli.Text = "Dueño : " : lblCli.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblC As Label = New Label
        panel.Controls.Add(lblC)
        lblC.Top = 65 : lblC.Left = 90 : lblC.AutoSize = True
        lblC.Text = cliente.Nombre : lblC.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '/////////////////////////////////////////////////////
        Dim lblFo As Label = New Label
        panel.Controls.Add(lblFo)
        lblFo.Top = 85 : lblFo.Left = 5 : lblFo.AutoSize = True
        lblFo.Text = "Fono : " : lblFo.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblF As Label = New Label
        panel.Controls.Add(lblF)
        lblF.Top = 85 : lblF.Left = 90 : lblF.AutoSize = True
        lblF.Text = cliente.FonoCliente : lblF.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim btnPer As Button = New Button
        panel.Controls.Add(btnPer)
        btnPer.Top = 115 : btnPer.Left = 5
        btnPer.Width = 90 : btnPer.Height = 25
        btnPer.Text = "VER PERFIL" : btnPer.Name = mascota.IdFicha
        btnPer.Font = New Font("Century Gothic", 10, FontStyle.Regular)
        btnPer.FlatStyle = FlatStyle.Flat : btnPer.FlatAppearance.BorderSize = 0

        AddHandler btnPer.Click, AddressOf btnPerfil_Click

        If atencion.TipoAtencion = "R" Then
            btnPer.BackColor = Color.Teal
        End If

        If atencion.TipoAtencion = "P" Then
            btnPer.BackColor = Color.Red : btnPer.ForeColor = Color.White
        End If

        If atencion.TipoAtencion = "A" Then
                Dim btnReg As Button = New Button
                panel.Controls.Add(btnReg)
                btnReg.Top = 115 : btnReg.Left = 100
                btnReg.Width = 160 : btnReg.Height = 25
                btnReg.Text = "REGISTRAR ATENCIÓN" : btnReg.Name = atencion.CodAtencion
                btnReg.Font = New Font("Century Gothic", 10, FontStyle.Regular)
                btnReg.FlatStyle = FlatStyle.Flat : btnReg.FlatAppearance.BorderSize = 0
                btnPer.BackColor = Color.Chocolate : btnReg.BackColor = Color.Chocolate
                AddHandler btnReg.Click, AddressOf btnReg_Click
                '////////////////////////////////////////////////////////////////////////
                Dim btnEli As Button = New Button
                panel.Controls.Add(btnEli)
                btnEli.Top = 115 : btnEli.Left = 370 : btnEli.Width = 100 : btnEli.Height = 25
                btnEli.BackColor = Color.Red : btnEli.ForeColor = Color.White
                btnEli.Font = New Font("Century Gothic", 10, FontStyle.Regular)
                btnEli.FlatStyle = FlatStyle.Flat : btnEli.FlatAppearance.BorderSize = 0
                btnEli.Text = "ELIMINAR" : btnEli.Name = atencion.CodAtencion
                AddHandler btnEli.Click, AddressOf btnEli_Click
                '//////////////////////////////////////////////////////////////////////
                Dim btnModi As Button = New Button
                panel.Controls.Add(btnModi)
                btnModi.Top = 115 : btnModi.Left = 265 : btnModi.Width = 100 : btnModi.Height = 25
                btnModi.Text = "MODIFICAR" : btnModi.Name = atencion.CodAtencion
                btnModi.Font = New Font("Century Gothic", 10, FontStyle.Regular)
                btnModi.FlatStyle = FlatStyle.Flat : btnModi.FlatAppearance.BorderSize = 0
                btnModi.BackColor = Color.Gold
            AddHandler btnModi.Click, AddressOf btnModi_Click
        End If

            If _listadoFecha = True Then
            Dim lblFec As Label = New Label
            panel.Controls.Add(lblFec)
            lblFec.Top = 5 : lblFec.Left = 300 : lblFec.AutoSize = True
            lblFec.Text = "Fecha : " : lblFec.Font = New Font("Century Gothic", 12, FontStyle.Regular)

            Dim lblFe As Label = New Label
            panel.Controls.Add(lblFe)
            lblFe.Top = 5 : lblFe.Left = 370 : lblFe.AutoSize = True
            lblFe.Text = atencion.FechaAtencion : lblFe.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        End If
    End Sub

    Friend WithEvents btnPer As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnEli As System.Windows.Forms.Button
    Friend WithEvents btnModi As System.Windows.Forms.Button

    Private Sub btnModi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModi.Click
        Dim codAtencion As Integer = Convert.ToInt32(Trim(sender.name))
        Dim atencion As New Atencion : Dim bsnAtencion As New BsnAtencion : atencion = bsnAtencion.GetDatosAtencion(codAtencion)
        LlenarPanelAgendar(atencion) : _modoOpcion = "modificar"
        panelAtenciones.Visible = False : panel_agendar.Visible = True
        lblTitulo.Text = "MODIFICAR ATENCIÓN AGENDADA" : lblTitulo.Left = 130
        btn_busqueda.Text = "CAMBIAR MASCOTA"
        If _modoFiltro = True Then
            btn_busqueda.Visible = False
        End If
    End Sub

    Private Sub btnEli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEli.Click
        If MessageBox.Show("¿Esta seguro que desea eliminar esta atención agendada?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim codAtencion As Integer = Convert.ToInt32(Trim(sender.name))
            Dim bsnAtencion As New BsnAtencion
            Dim atencion As New Atencion : atencion = bsnAtencion.GetDatosAtencion(codAtencion)

            If atencion.CorreoEnviado = True Then
                Dim proex As New ProcedimientoExterno
                Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota
                Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente
                mascota = bsnMascota.GetDatosMascota(atencion.IdFicha) : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
                proex.GenerarCorreoCancelacionAtencion(mascota, cliente, atencion)
            End If

            bsnAtencion.EliminarAtencionFisico(codAtencion)
            MsgBox("La atención agendada ha sido eliminada correctamente.")
            If _modoFiltro = False Then
                Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                CargarAtenciones(fecha)
            Else
                Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota() : mascota = bsnMascota.GetDatosMascota(atencion.IdFicha)
                CargarAtencionesMascota(mascota)
            End If

        End If
    End Sub

    Private Sub btnReg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Dim codAtencion As Integer = Convert.ToInt32(Trim(sender.name))
        Dim atencion As New Atencion : Dim bsnAtencion As New BsnAtencion : atencion = bsnAtencion.GetDatosAtencion(codAtencion)
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(atencion.IdFicha)
        Dim _frmRegistrarAtencion As New frm_Registrar_Atencion(Me, "calendario", mascota, codAtencion)
        _frmRegistrarAtencion.Show()
        Me.Hide()
    End Sub

    Private Sub btnPerfil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPer.Click
        Dim idFicha As String = sender.name
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(idFicha)
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim frmPerfil As New FRM_Perfil(mascota, cliente, Me)
        frmPerfil.Show()
        Me.Hide()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        _frmPrincipal.Show()
        _frmPrincipal.ContarAtencionesAgendadas()
        _frmPrincipal.EnviarCorreos()
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        Dim bsnAtencion As New BsnAtencion
        lblCodAtAgendada.Text = bsnAtencion.GenerarCodAtencion
        Panel8.Visible = False : panelAtenciones.Visible = False
        panel_agendar.Visible = True
        panel_agendar.Top = 64 : panel_agendar.Left = 354
        panel_agendar.Height = 423 : panel_agendar.Width = 506
        _modoOpcion = "agregar"

        If _modoFiltro = True Then
            _modoFiltro = False
            VolverCalendario()
            panelAtenciones.Visible = False
        End If


    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If _modoFiltro = False Then
            Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
            CargarAtenciones(fecha)
        End If
        panel_agendar.Visible = False : panelAtenciones.Visible = True
        LimpiarPanelAgendar()
    End Sub

    Private Sub btn_busqueda_Click(sender As Object, e As EventArgs) Handles btn_busqueda.Click
        Dim frmMantenedorMascotas As New frm_Mantenedor_Mascotas(Me, "panelDerecho")
        frmMantenedorMascotas.Show()
        Me.Hide()
    End Sub

    Sub LimpiarPanelAgendar()
        btn_busqueda.Text = "SELECCIONAR MASCOTA" : btn_busqueda.Visible = True
        lbl_id_ficha.Text = "" : lbl_nom_mascota.Text = "" : lbl_especie.Text = "" : lbl_nom_cliente.Text = ""
        lbl_fono_cliente.Text = "" : dtp_fecha.Value = System.DateTime.Today : rtbMotivo.Text = ""
        lblCodAtAgendada.Text = "" : lblTitulo.Text = "AGENDAR ATENCIÓN"
    End Sub

    Private Sub btn_agendar_Click(sender As Object, e As EventArgs) Handles btn_agendar.Click
        If lbl_id_ficha.Text = "" Then
            MsgBox("Para agendar una cita debe seleccionar una mascota.")
            Exit Sub
        End If
        Dim fechaHoy As Date = System.DateTime.Today
        Dim fechaAge As Date = dtp_fecha.Value
        If fechaAge <= fechaHoy Then
            MsgBox("Debe seleccionar una fecha más adelante.")
            Exit Sub
        End If
        '/////////////////////////////////////////////////////////////////////

        Dim atencion As New Atencion
        atencion.CodAtencion = Convert.ToInt32(Trim(lblCodAtAgendada.Text))
        atencion.NumVeterinario = 1
        atencion.IdFicha = lbl_id_ficha.Text
        atencion.FechaAtencion = dtp_fecha.Value.ToString("yyyy-MM-dd")
        atencion.Descripcion = rtbMotivo.Text
        atencion.TipoAtencion = "A"
        Dim bsnAtencion As New BsnAtencion

        Select Case _modoOpcion
            Case "agregar"
                bsnAtencion.InsertarAtencion(atencion)
                MsgBox("La atencion ha sido agendada correctamente.")
            Case "modificar"
                bsnAtencion.ModificarAtencion(atencion)
                MsgBox("La atención agendada ha sido modificada correctamente.")
        End Select

        If _modoFiltro = False Then
            Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd") : calendario.Value = System.DateTime.Today
            CargarAtenciones(fecha)
        Else
            Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(atencion.IdFicha)
            CargarAtencionesMascota(mascota)
        End If

        panel_agendar.Visible = False : LimpiarPanelAgendar() : _modoOpcion = "" : panelAtenciones.Visible = True
    End Sub

    Sub LlenarPanelAgendar(atencion As Atencion)
        lblCodAtAgendada.Text = atencion.CodAtencion
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(atencion.IdFicha)
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
        lbl_nom_mascota.Text = mascota.NomMascota : lbl_nom_cliente.Text = cliente.Nombre
        lbl_fono_cliente.Text = cliente.FonoCliente : lbl_especie.Text = especie.NomEspecie
        dtp_fecha.Value = atencion.FechaAtencion : lbl_id_ficha.Text = mascota.IdFicha
        rtbMotivo.Text = atencion.Descripcion
    End Sub

    Private Sub btnAtencionesMascotas_Click(sender As Object, e As EventArgs) Handles btnAtencionesMascotas.Click
        Dim frmMantenedorMascotas As New frm_Mantenedor_Mascotas(Me, "panelIzquierdo")
        frmMantenedorMascotas.Show() : Me.Hide()
    End Sub

    Private Sub bgnCanBusMascota_Click(sender As Object, e As EventArgs) Handles bgnCanBusMascota.Click
        VolverCalendario()
    End Sub

    Private Sub pbVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbVolver.MouseEnter
        pbVolver.Image = My.Resources.VOLVERCAL_DESTACADO
    End Sub

    Private Sub pbVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbVolver.MouseLeave
        pbVolver.Image = My.Resources.VOLVERCAL
    End Sub

    Private Sub pbVolver_Click(sender As Object, e As EventArgs) Handles pbVolver.Click
        VolverCalendario()
    End Sub

    Sub VolverCalendario()
        _modoFiltro = False
        panelBusMascota.Visible = False
        btnAtencionesMascotas.Visible = True
        Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
        CargarAtenciones(fecha)
        calendario.Visible = True : pbVolver.Visible = False
        lbl_fecha_sel.Visible = True : Label1.Visible = True
        calendario.Value = System.DateTime.Today
    End Sub


    '////////////////////movimiento del formulario//////////////////////////////////////
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub frm_Calendario_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub frm_Calendario_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(x:=MousePosition.X - Me.Location.X - ex, y:=MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub rtbMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbMotivo.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtp_fecha_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha.ValueChanged
        calendario.Value = dtp_fecha.Value
    End Sub

    Private Sub frm_Calendario_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
End Class
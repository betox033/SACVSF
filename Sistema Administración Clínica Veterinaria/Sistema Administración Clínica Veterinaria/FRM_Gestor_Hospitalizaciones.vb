Imports System.IO

Public Class FRM_Gestor_Hospitalizaciones

    Dim _modoOpcion As String = ""


    Protected _frmPrincipal As frm_Principal
    Protected _frmDetalle As FRM_DetalleHospitalizacion
    Protected _listHosp As New List(Of Hospitalizacion)

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        _frmPrincipal.Show() : Me.Close() : Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        Dim numHospitalizacion As Integer = Convert.ToInt32(Trim(lblNumHospitalizacion.Text))
        If Trim(lblIdFichaPanel.Text) = "" Then
            MsgBox("Debe seleccionar una mascota primero.")
            Exit Sub
        End If

        Dim bsnHosp As New BsnHospitalizacion
        Dim registrado As Boolean = bsnHosp.ValidarHospitalizacion(numHospitalizacion, "hospitalizacion")

        If registrado = False Then
            If MessageBox.Show("Para acceder a los detalles de una hospitalización primero deben regisrtrarse " &
                               "sus datos principales." & "¿Desea guardar esta hospitalización?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim hosp As New Hospitalizacion
                hosp.IdHosp = Convert.ToInt32(Trim(lblNumHospitalizacion.Text))
                hosp.IdFicha = Convert.ToInt32(Trim(lblIdFichaPanel.Text))
                hosp.FechaHosp = Format(dtpIngreso.Value, "yyyy-MM-dd")
                hosp.FechaSalida = Format(dtpSalida.Value, "yyyy-MM-dd")
                hosp.Descripcion = Trim(rtbDescripcion.Text) : hosp.Total = 666
                hosp.Total = 0

                If _modoOpcion = "agregar" Then
                    Dim j As Integer = 0 : Dim lgj As Integer = _listHosp.Count
                    While j < lgj
                        If _listHosp.Item(j).IdFicha = hosp.IdFicha Then
                            MsgBox("La mascota seleccionada ya se encuentra hospitalizada.") : Exit Sub
                        End If
                        j = j + 1
                    End While
                End If

                bsnHosp.InsertarHospitalizacion(hosp)
                CargarHospitalizaciones()
            Else
                MsgBox("Acceso denegado.")
                Exit Sub
            End If
        End If

        Dim idFicha As Integer = Trim(lblIdFichaPanel.Text)
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota
        mascota = bsnMascota.GetDatosMascota(idFicha)
        Dim listaDetalle As New List(Of DetHosp) : Dim bsnDetHosp As New BsnDetHosp
        listaDetalle = bsnDetHosp.GetDetallesHosp(numHospitalizacion)
        Dim hospi As New Hospitalizacion : hospi = bsnHosp.GetDatosHospitalizacion(numHospitalizacion)
        Dim frmDetalleHospitalizacion As New FRM_DetalleHospitalizacion(hospi, Me, listaDetalle)
        _frmDetalle = frmDetalleHospitalizacion
        frmDetalleHospitalizacion.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_Gestor_Hospitalizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHospitalizaciones()
        LimpiarPanel()
        rtbDescripcion.Focus()
    End Sub

    Sub CargarHospitalizaciones()
        panelH.Controls.Clear()
        Dim fechaHoy As Date = System.DateTime.Today
        Dim i As Integer = 0 : Dim alto As Integer = 0
        Dim bsnHosp As New BsnHospitalizacion : _listHosp.Clear()
        _listHosp = bsnHosp.GetHospFecha(fechaHoy)
        For Each hosp As Hospitalizacion In _listHosp
            If hosp.Estado = True Then
                Dim panel As New Panel
                CrearSubPanel(panel, alto, hosp)
                i = i + 1
                alto = alto + 170
            End If
        Next
    End Sub

    Private Sub panel1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel.MouseEnter
        sender.BackColor = Color.DarkGray
    End Sub

    Private Sub panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel.MouseLeave
        sender.BackColor = Color.LightGray
    End Sub

    Private Sub panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel.Click
        Dim numHosp As Integer = Convert.ToInt32(Trim(sender.name))
        LlenarPanel(numHosp)
    End Sub

    Sub LlenarPanel(numHosp As Integer)
        LimpiarPanel()
        lblNumHospitalizacion.Text = numHosp
        Dim hosp As New Hospitalizacion : Dim bsnHosp As New BsnHospitalizacion
        hosp = bsnHosp.GetDatosHospitalizacion(numHosp)
        lblIdFichaPanel.Text = hosp.IdFicha
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota
        mascota = bsnMascota.GetDatosMascota(hosp.IdFicha)
        lblNombre.Text = mascota.NomMascota
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
        lblEspecie.Text = especie.NomEspecie
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        lblDueñoPanel.Text = cliente.Nombre
        Dim fechaHosp As String = hosp.FechaHosp : Dim fechaSalida As String = hosp.FechaSalida
        dtpIngreso.Value = fechaHosp.Substring(0, 10) : dtpSalida.Value = fechaSalida.Substring(0, 10)
        rtbDescripcion.Text = hosp.Descripcion

        Dim listaDetalles As New List(Of DetHosp) : Dim bsnDetalle As New BsnDetHosp
        listaDetalles = bsnDetalle.GetDetallesHosp(numHosp)
        Dim suma As Integer = 0
        For Each det As DetHosp In listaDetalles
            suma = suma + det.Precio
        Next
        suma = suma + hosp.Total + hosp.ValorConsulta
        Dim convertir As New Convertir
        lblTotalPagos.Text = convertir.convertir_dinero(suma)
    End Sub

    Sub LimpiarPanel()
        lblNumHospitalizacion.Text = "" : lblNombre.Text = "" : lblEspecie.Text = "" : lblDueñoPanel.Text = ""
        rtbDescripcion.Text = "" : btnDetalle.Visible = False : btnAceptar.Visible = False : btnCancelar.Visible = False
        dtpIngreso.Value = System.DateTime.Today : dtpSalida.Value = System.DateTime.Today
        lblIdFichaPanel.Text = "" : lblTotalPagos.Text = ""
        btnSeleccionar.Text = "SELECCIONAR MASCOTA" : btnSeleccionar.Visible = False
    End Sub

    Friend WithEvents panel As System.Windows.Forms.Panel

    Sub CrearSubPanel(panel As Panel, alto As Integer, hosp As Hospitalizacion)
        panelH.Controls.Add(panel)
        panel.Top = alto : panel.Left = 10
        panel.Width = 520 : panel.Height = 160
        panel.BackColor = Color.LightGray
        panel.Name = hosp.IdHosp
        AddHandler panel.MouseEnter, AddressOf panel1_MouseEnter
        AddHandler panel.MouseLeave, AddressOf panel1_MouseLeave
        AddHandler panel.Click, AddressOf panel1_Click

        '////////////////////////////////////////////////////////////
        Dim pbMascota As PictureBox = New PictureBox
        panel.Controls.Add(pbMascota)
        pbMascota.Top = 10 : pbMascota.Left = 10
        pbMascota.Width = 140 : pbMascota.Height = 140
        pbMascota.Image = My.Resources.mascotaSilueta : pbMascota.SizeMode = PictureBoxSizeMode.StretchImage
        '///////////////////////////////////////////////////////////
        Dim lblIdHosp As Label = New Label
        panel.Controls.Add(lblIdHosp)
        lblIdHosp.Top = 10 : lblIdHosp.Left = 160 : lblIdHosp.AutoSize = True
        lblIdHosp.Text = "N° Hosp : " : lblIdHosp.Font = New Font("Century Gothic", 12, FontStyle.Bold)

        Dim lblIdH As Label = New Label
        panel.Controls.Add(lblIdH)
        lblIdH.Top = 10 : lblIdH.Left = 240 : lblIdH.AutoSize = True
        lblIdH.Text = hosp.IdHosp : lblIdH.Font = New Font("Century Gothic", 12, FontStyle.Bold)
        '///////////////////////////////////////////////////////
        Dim lblIdFicha As Label = New Label
        panel.Controls.Add(lblIdFicha)
        lblIdFicha.Top = 30 : lblIdFicha.Left = 160 : lblIdFicha.AutoSize = True
        lblIdFicha.Text = "N° Ficha : " : lblIdFicha.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblIdF As Label = New Label
        panel.Controls.Add(lblIdF)
        lblIdF.Top = 30 : lblIdF.Left = 240 : lblIdF.AutoSize = True
        lblIdF.Text = hosp.IdFicha : lblIdF.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim ruta As String = "../../img/mascotas/" & hosp.IdFicha & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbMascota.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            pbMascota.Image = My.Resources.mascotaSilueta
        End If
        lblIdFichaPanel.Text = hosp.IdFicha

        '//////////////////////////////////////////////////////////////
        Dim lblNomMascota As Label = New Label
        panel.Controls.Add(lblNomMascota)
        lblNomMascota.Top = 50 : lblNomMascota.Left = 160 : lblNomMascota.AutoSize = True
        lblNomMascota.Text = "Nombre : " : lblNomMascota.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(hosp.IdFicha)
        Dim lblNomM As Label = New Label
        panel.Controls.Add(lblNomM)
        lblNomM.Top = 50 : lblNomM.Left = 240 : lblNomM.AutoSize = True
        lblNomM.Text = mascota.NomMascota : lblNomM.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '///////////////////////////////////////////////////////////////
        Dim lblNomCliente As Label = New Label
        panel.Controls.Add(lblNomCliente)
        lblNomCliente.Top = 70 : lblNomCliente.Left = 160 : lblNomCliente.AutoSize = True
        lblNomCliente.Text = "Dueño : " : lblNomCliente.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        Dim lblNomC As Label = New Label
        panel.Controls.Add(lblNomC)
        lblNomC.Top = 70 : lblNomC.Left = 240 : lblNomC.AutoSize = True
        lblNomC.Text = cliente.Nombre : lblNomC.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '//////////////////////////////////////////////////////////////////
        Dim lblNomEspecie As Label = New Label
        panel.Controls.Add(lblNomEspecie)
        lblNomEspecie.Top = 90 : lblNomEspecie.Left = 160 : lblNomEspecie.AutoSize = True
        lblNomEspecie.Text = "Especie : " : lblNomEspecie.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
        Dim lblNomE As Label = New Label
        panel.Controls.Add(lblNomE)
        lblNomE.Top = 90 : lblNomE.Left = 240 : lblNomE.AutoSize = True
        lblNomE.Text = especie.NomEspecie : lblNomE.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        '///////////////////////////////////////////////////////////////////
        Dim lblNomRaza As Label = New Label
        panel.Controls.Add(lblNomRaza)
        lblNomRaza.Top = 110 : lblNomRaza.Left = 160 : lblNomRaza.AutoSize = True
        lblNomRaza.Text = "Raza : " : lblNomRaza.Font = New Font("Century Gothic", 12, FontStyle.Regular)

        Dim lblNomR As Label = New Label
        panel.Controls.Add(lblNomR)
        lblNomR.Top = 110 : lblNomR.Left = 240 : lblNomR.AutoSize = True
        lblNomR.Text = raza.NomRaza : lblNomR.Font = New Font("Century Gothic", 12, FontStyle.Regular)

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Trim(lblNumHospitalizacion.Text) = "" Then
            MsgBox("Debe seleccionar una hospitalización.")
            Exit Sub
        End If
        _modoOpcion = "modificar"
        btnDetalle.Visible = True : btnAceptar.Visible = True : btnCancelar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnAceptar.Visible = False : btnCancelar.Visible = False : btnDetalle.Visible = False
        LimpiarPanel() : dtpIngreso.Value = System.DateTime.Today : dtpSalida.Value = System.DateTime.Today
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If lblIdFichaPanel.Text = "" Then
            MsgBox("Debe seleccionar una mascota") : Exit Sub
        End If

        Dim hosp As New Hospitalizacion : Dim bsnHosp As New BsnHospitalizacion
        hosp.IdHosp = Convert.ToInt32(Trim(lblNumHospitalizacion.Text)) : hosp.IdFicha = Convert.ToInt32(Trim(lblIdFichaPanel.Text))
        hosp.FechaHosp = Format(dtpIngreso.Value, "yyyy-MM-dd") : hosp.FechaSalida = Format(dtpSalida.Value, "yyyy-MM-dd")

        If _modoOpcion = "agregar" Then
            Dim j As Integer = 0 : Dim lgj As Integer = _listHosp.Count
            While j < lgj
                If _listHosp.Item(j).IdFicha = hosp.IdFicha Then
                    MsgBox("La mascota seleccionada ya se encuentra hospitalizada.") : Exit Sub
                End If
                j = j + 1
            End While
        End If

        If hosp.FechaHosp > hosp.FechaSalida Then
            MsgBox("La fecha de salida no puede estar antes que la fecha de hospitalización.") : Exit Sub
        End If

        hosp.Descripcion = Trim(rtbDescripcion.Text) : hosp.Total = 0

        If _modoOpcion = "agregar" Then
            bsnHosp.InsertarHospitalizacion(hosp)
            MsgBox("La hospitalización ha sido agregada correctamente.")
        End If

        If _modoOpcion = "modificar" Then
            bsnHosp.ModificarHospitalizacion(hosp)
            MsgBox("La hospitalización ha sido modificada correctamente.")
        End If
        panelH.Controls.Clear() : CargarHospitalizaciones()
        LimpiarPanel()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim frmMantenedorMascotas As New frm_Mantenedor_Mascotas(Me)
        frmMantenedorMascotas.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim bsnHosp As New BsnHospitalizacion
        LimpiarPanel()
        btnSeleccionar.Visible = True
        btnSeleccionar.Top = 94 : btnSeleccionar.Left = 45
        Panel3.Visible = False
        btnDetalle.Visible = True : btnAceptar.Visible = True : btnCancelar.Visible = True
        _modoOpcion = "agregar"
        lblNumHospitalizacion.Text = bsnHosp.GenerarNumHosp
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lblIdFichaPanel.Text = "" Then
            MsgBox("Debe seleccionar una hospitalización.")
            Exit Sub
        End If

        Dim idHosp As Integer = Convert.ToInt32(Trim(lblNumHospitalizacion.Text))
        Dim bsnHosp As New BsnHospitalizacion
        Dim encontradoDetalle As Boolean = bsnHosp.ValidarHospitalizacion(idHosp, "hosp_producto")

        If MessageBox.Show("¿Esta seguro que desea eliminar esta hospitalizacion?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If encontradoDetalle = True Then
                MsgBox("No se puede eliminar la hospitalización porque tiene registros asociados.") : Exit Sub
            Else
                bsnHosp.EliminarHospFisico(idHosp)
                MsgBox("La hospitalizacion ha sido eliminada.")
                LimpiarPanel() : CargarHospitalizaciones()
            End If
        End If
    End Sub

    Private Sub rtbDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbDescripcion.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub
End Class
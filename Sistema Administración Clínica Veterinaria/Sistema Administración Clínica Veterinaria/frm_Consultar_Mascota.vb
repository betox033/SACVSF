Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_Consultar_Mascota

    Protected _frmPrincipal As frm_Principal

    Dim _encontrado As Boolean = False
    Dim detalle As String = "{0,-7}{1,-30}"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Private Sub frm_Consultar_Mascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VaciarDatosMascota()

    End Sub

    Sub ContarAtencionesAgendadas()
        Dim listaAtenciones As New List(Of Atencion) : Dim bsnAtencion As New BsnAtencion
        Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
        listaAtenciones = bsnAtencion.GetAtencionesFecha(fecha)
        Dim numAtenciones As Integer = 0
        For Each atencion As Atencion In listaAtenciones
            If atencion.TipoAtencion = "A" Then
                numAtenciones = numAtenciones + 1
            End If
        Next
        If numAtenciones > 0 Then
            'pbContador.Visible = True : lblContador.Text = numAtenciones : lblContador.Visible = True
            btnCalendario.BackColor = Color.Orange
        End If
    End Sub

    Sub VaciarDatosMascota()
        lbl_numero.Text = "" : lbl_nombre.Text = "" : lbl_fnac.Text = "" : lbl_especie.Text = "" : lbl_raza.Text = ""
        lbl_cliente.Text = "" : lbl_sexo.Text = "" : lbl_color.Text = ""
    End Sub

    Private Sub btn_aceptar_ingreso_Click(sender As Object, e As EventArgs) Handles btn_aceptar_ingreso.Click
        If Trim(txt_ingreso.Text) = "" Then
            MsgBox("Debe ingresar el número de ficha de mascota.")
            Exit Sub
        End If

        Dim idFicha As String = Trim(txt_ingreso.Text)
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota

        If bsnMascota.ValidarMascota(idFicha) Then
            _encontrado = True
            mascota = bsnMascota.GetDatosMascota(idFicha)
            CargarDatosMascota(mascota)
        Else
            MsgBox("El número ingresado no corresponde a una mascota registrada en el sistema.")
            txt_ingreso.Focus()
        End If
    End Sub

    Sub CargarDatosMascota(mascota As Mascota)
        lbl_numero.Text = mascota.IdFicha
        lbl_nombre.Text = mascota.NomMascota
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente
        cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        lbl_cliente.Text = cliente.Nombre

        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie
        especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)

        lbl_especie.Text = especie.NomEspecie
        lbl_fnac.Text = mascota.FechaNacimiento
        lbl_raza.Text = raza.NomRaza

        Select Case mascota.Sexo
            Case "F" : lbl_sexo.Text = "FEMENINO"
            Case "M" : lbl_sexo.Text = "MASCULINO"
        End Select

        lbl_color.Text = mascota.Color

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

    Private Sub btn_agregar_vacuna_Click(sender As Object, e As EventArgs) Handles btn_agregar_vacuna.Click
        If lbl_numero.Text = "" Then
            MsgBox("Debe seleccionar una mascota para agregar una vacuna.")
            Exit Sub
        End If

        Dim idFicha As String = Trim(lbl_numero.Text)
        Dim frmAgregarVacuna As New FRM_Agregar_Vacuna(_frmPrincipal, "directo", idFicha)
        frmAgregarVacuna.Show()
        Me.Close() : Me.Dispose()
    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)
        Arrastre = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(x:=MousePosition.X - Me.Location.X - ex, y:=MousePosition.Y - Me.Location.Y - ey))
    End Sub



    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs)
        Arrastre = False
    End Sub



    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(x:=MousePosition.X - Me.Location.X - ex, y:=MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub txt_ingreso_TextChanged(sender As Object, e As EventArgs)
        Dim buscar As String = txt_ingreso.Text
        Dim ayuda As Boolean = False : Dim bsnMascota As New BsnMascota

        ayuda = bsnMascota.ValidarMascota(buscar)

        If ayuda = True Then
            btn_aceptar_ingreso.BackColor = Color.PaleTurquoise
        Else
            btn_aceptar_ingreso.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _frmPrincipal.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSeleccionarMascota_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarMascota.Click
        Dim frmSeleccionarMascota As New frm_Mantenedor_Mascotas(Me)
        frmSeleccionarMascota.Show()
        Me.Hide()
    End Sub

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles btnCalendario.Click
        Dim frmCalendario As New frm_Calendario(_frmPrincipal)
        frmCalendario.Show()
        Me.Close()
    End Sub


    Private Sub btnRegistrarAtencion_Click(sender As Object, e As EventArgs) Handles btnRegistrarAtencion.Click
        If lbl_numero.Text = "" Then
            MsgBox("Debe seleccionar una mascota para registrar una atención.")
            Exit Sub
        End If

        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota
        Dim idFicha As Integer = lbl_numero.Text
        mascota = bsnMascota.GetDatosMascota(idFicha)

        Dim frmRegistrarAtencion As New frm_Registrar_Atencion(_frmPrincipal, "directo", mascota)
        frmRegistrarAtencion.Show()
        Me.Close() : Me.Dispose()
    End Sub

End Class
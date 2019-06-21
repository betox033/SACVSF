Imports MySql.Data.MySqlClient

Public Class FRM_MantenedorEspecies

    Protected _frmPrincipal As frm_Principal

    Dim detalle As String = "{0,-7}{1,-30}"

    Dim _modoOpcion As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Private Sub FRM_MantenedorEspecies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarEspecies()
    End Sub

    Sub LlenarEspecies()
        lstEspecies.Items.Clear()
        Dim listaEspecies As New List(Of Especie) : Dim bsnEspecie As New BsnEspecie
        listaEspecies = bsnEspecie.GetEspecies()
        For Each especie As Especie In listaEspecies
            If especie.Estado <> 3 Then
                lstEspecies.Items.Add(String.Format(detalle, especie.IdEspecie, especie.NomEspecie))
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _frmPrincipal.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub lstEspecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEspecies.SelectedIndexChanged
        If lstEspecies.SelectedIndex <> -1 Then
            Dim cadena As String = lstEspecies.SelectedItem
            Dim idEspecie As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie
            especie = bsnEspecie.GetDatosEspecie(idEspecie)
            lblIdEspecie.Text = especie.IdEspecie : txtNombre.Text = especie.NomEspecie
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        btnAceptar.Visible = True : btnCancelar.Visible = True : txtNombre.Text = ""
        lstEspecies.SelectedIndex = -1 : _modoOpcion = "agregar"
        Dim bsnEspecie As New BsnEspecie
        lblIdEspecie.Text = bsnEspecie.GenerarIdEspecie : txtNombre.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If lstEspecies.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una mascota si quiere modificarla.")
            Exit Sub
        End If
        btnAceptar.Visible = True : btnCancelar.Visible = True : txtNombre.Focus()
        _modoOpcion = "modificar"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lstEspecies.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una mascota si quiere eliminarla.")
            Exit Sub
        End If
        Dim cadena As String = lstEspecies.SelectedItem
        Dim idEspecie As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
        Dim bsnNegocio As New BsnNegocio : Dim bsnEspecie As New BsnEspecie
        Dim ct As Integer = bsnEspecie.ValidarEspecie(idEspecie)
        If ct = 0 Then
            If MessageBox.Show("¿Esta seguro que desea eliminar esta especie?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim bsnRaza As New BsnRaza : bsnRaza.EliminarRazaConEspecie(idEspecie)
                bsnEspecie.EliminarEspecie(idEspecie)
                MsgBox("La especie ha sido eliminada correctamente.")
                LimpiarPanel() : LlenarEspecies()
            End If
        Else
            MsgBox("No puede eliminar a esta especie porque tiene razas asociadas.")
        End If
    End Sub

    Sub LimpiarPanel()
        btnAceptar.Visible = False : btnCancelar.Visible = False : txtNombre.Text = ""
        lblIdEspecie.Text = "" : lstEspecies.SelectedIndex = -1
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Trim(txtNombre.Text = "") Then
            MsgBox("Debe ingresar un nombre.")
            Exit Sub
        End If
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie
        especie.IdEspecie = Convert.ToInt32(Trim(lblIdEspecie.Text))
        especie.NomEspecie = UCase(Trim(txtNombre.Text))

        Dim bsnNegocio As New BsnNegocio
        Dim validarNom As Integer = bsnNegocio.ValidarPorTexto("especie", "nom_especie", especie.NomEspecie)
        If validarNom <> -1 Then
            Dim esp As New Especie : esp = bsnEspecie.GetDatosEspecie(validarNom)
            Select Case _modoOpcion
                Case "agregar" : MsgBox("Ya existe esta especie registrada.") : Exit Sub
                Case "modificar"
                    If esp.IdEspecie <> especie.IdEspecie Then
                        MsgBox("Ya existe esta especie registrada.") : Exit Sub
                    End If
            End Select
        End If

        especie.Estado = 0
        Select Case _modoOpcion
            Case "agregar"
                bsnEspecie.InsertarEspecie(especie)
                InsertarRazaPorDefecto(especie.IdEspecie)
                MsgBox("La especie ha sido agregada correctamente.")
            Case "modificar"
                bsnEspecie.ModificarEspecie(especie)
                MsgBox("La especie ha sido modificada correctamente.")
        End Select
        LimpiarPanel() : LlenarEspecies()
    End Sub

    Sub InsertarRazaPorDefecto(idEspecie As Integer)
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza
        raza.IdRaza = bsnRaza.GeneraridRaza() : raza.IdEspecie = idEspecie
        raza.NomRaza = "N.D" : raza.Estado = 3
        bsnRaza.InsertarRaza(raza)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarPanel()
    End Sub

    Private Sub btnMigracion_Click(sender As Object, e As EventArgs) Handles btnMigracion.Click
        panelMigracion.Visible = True
        panelMigracion.Width = 405 : panelMigracion.Height = 340
        panelMigracion.Left = 12 : panelMigracion.Top = 12
        Panel2.Enabled = False
        CargarEspeciesMigracion()
    End Sub

    Sub CargarEspeciesMigracion()
        cmbEspecieOriginal.SelectedIndex = -1 : cmbEspecieNueva.SelectedIndex = -1
        cmbEspecieNueva.Items.Clear() : cmbEspecieOriginal.Items.Clear()
        Dim listaEspecie As New List(Of Especie) : Dim bsnEspecie As New BsnEspecie
        listaEspecie = bsnEspecie.GetEspecies
        For Each especie As Especie In listaEspecie
            cmbEspecieNueva.Items.Add(String.Format(detalle, especie.IdEspecie, especie.NomEspecie))
            cmbEspecieOriginal.Items.Add(String.Format(detalle, especie.IdEspecie, especie.NomEspecie))
        Next
    End Sub

    Private Sub btnCancelarMigracion_Click(sender As Object, e As EventArgs) Handles btnCancelarMigracion.Click
        panelMigracion.Visible = False
        Panel2.Enabled = True
    End Sub

    Private Sub btnAceptarMigracion_Click(sender As Object, e As EventArgs) Handles btnAceptarMigracion.Click
        If cmbEspecieOriginal.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una especie original.")
            Exit Sub
        End If
        If cmbEspecieNueva.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una especie nueva.")
            Exit Sub
        End If
        Dim cadenaO As String = cmbEspecieOriginal.SelectedItem
        Dim cadenaN As String = cmbEspecieNueva.SelectedItem
        Dim idOriginal As Integer = Convert.ToInt32(Trim(cadenaO.Substring(0, 5)))
        Dim idNueva As Integer = Convert.ToInt32(Trim(cadenaN.Substring(0, 5)))

        If idOriginal = idNueva Then
            MsgBox("La especie original no puede ser igual a la especie nueva")
            Exit Sub
        End If

        If MessageBox.Show("¿Esta seguro que desea realizar la migración masiva?" & vbLf &
                           "Tenga en cuenta que las migraciones producen actualizaciones en varios registros.",
                           "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim bsnEspecie As New BsnEspecie
            bsnEspecie.MigracionMasiva(idOriginal, idNueva)
            MsgBox("La migración de datos ha sido realizada correctamente.")
        End If
        panelMigracion.Visible = False : Panel2.Enabled = True
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub
End Class
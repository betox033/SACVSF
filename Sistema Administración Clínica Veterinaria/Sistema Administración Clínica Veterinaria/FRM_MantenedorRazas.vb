Imports MySql.Data.MySqlClient

Public Class FRM_MantenedorRazas

    Protected _frmPrincipal As frm_Principal

    Dim detalle As String = "{0,-7}{1,-22}{2,-20}"
    Dim detalleComboBox As String = "{0,-7}{1,-25}"
    Dim _modoOpcion As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Private Sub FRM_MantenedorRazas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarEspecies()
        LlenarRazas("id_raza")
    End Sub

    Sub LlenarEspecies()
        Dim listaEspecies As New List(Of Especie) : Dim bsnEspecie As New BsnEspecie
        listaEspecies = bsnEspecie.GetEspecies()
        For Each especie As Especie In listaEspecies
            If especie.Estado <> 3 Then
                cmbEspecies.Items.Add(String.Format(detalleComboBox, especie.IdEspecie, especie.NomEspecie))
            End If
        Next
    End Sub

    Sub LlenarRazas(criterio As String)
        lstRazas.Items.Clear()
        Dim listaRazas As New List(Of Raza)
        Dim bsnRazas As New BsnRaza : Dim bsnEspecie As New BsnEspecie
        listaRazas = bsnRazas.GetRazas
        Select Case criterio
            Case "nom_especie" : listaRazas = bsnRazas.GetRazasOrderEspecie()
            Case "nom_raza" : listaRazas = listaRazas.OrderBy(Function(rz) rz.NomRaza).ToList
        End Select
        For Each raza As Raza In listaRazas
            If raza.Estado <> 3 Then
                Dim especie As New Especie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
                lstRazas.Items.Add(String.Format(detalle, raza.IdRaza, especie.NomEspecie, raza.NomRaza))
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _frmPrincipal.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub lstRazas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRazas.SelectedIndexChanged
        If lstRazas.SelectedIndex <> -1 Then
            Dim cadena As String = lstRazas.SelectedItem
            Dim idRaza As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            lblIdRaza.Text = idRaza
            Dim bsnRazas As New BsnRaza : Dim raza As Raza
            raza = bsnRazas.GetDatosRaza(idRaza)
            txtNombre.Text = raza.NomRaza
            Dim lg As Integer = cmbEspecies.Items.Count : Dim i As Integer = 0
            Dim cad As String = "" : Dim ID As Integer = 0
            Dim encontrado As Boolean = False
            While i < lg And encontrado = False
                cad = cmbEspecies.Items.Item(i) : ID = Convert.ToInt32(Trim(cad.Substring(0, 5)))
                If ID = raza.IdEspecie Then
                    cmbEspecies.SelectedIndex = i : encontrado = True
                End If
                i = i + 1
            End While
        End If
    End Sub

    Sub LimpiarPanel()
        lblIdRaza.Text = "" : cmbEspecies.SelectedIndex = -1 : txtNombre.Text = ""
        btnAceptar.Visible = False : btnCancelar.Visible = False : lstRazas.SelectedIndex = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        btnAceptar.Visible = True : btnCancelar.Visible = True
        cmbEspecies.SelectedIndex = -1 : txtNombre.Text = ""
        Dim bsnRaza As New BsnRaza : lblIdRaza.Text = bsnRaza.GeneraridRaza()
        _modoOpcion = "agregar"
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar un nombre para la raza.")
            Exit Sub
        End If
        If cmbEspecies.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una especie a la que pertenezca la raza.")
            Exit Sub
        End If
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza
        raza.IdRaza = Convert.ToInt32(Trim(lblIdRaza.Text))
        Dim cadena As String = cmbEspecies.SelectedItem
        raza.IdEspecie = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
        raza.NomRaza = UCase(Trim(txtNombre.Text))

        Dim validarRaza As Integer = bsnRaza.ValidarRaza(raza.NomRaza, raza.IdEspecie)
        Dim repetidoAux As Boolean = False

        If validarRaza <> -1 Then
            Dim razaAux As New Raza : razaAux = bsnRaza.GetDatosRaza(validarRaza)
            Dim especieAux As New Especie : Dim bsnEspecie As New BsnEspecie : especieAux = bsnEspecie.GetDatosEspecie(razaAux.IdEspecie)
            Select Case _modoOpcion
                Case "agregar" : repetidoAux = True
                Case "modificar"
                    If razaAux.IdRaza <> raza.IdRaza Then
                        repetidoAux = True
                    End If
            End Select

            If repetidoAux = True Then
                MsgBox("Ya existe una raza con datos iguales." & vbLf &
                "*************************************" & vbLf &
                "Id Raza : " & razaAux.IdRaza & vbLf &
                "Nom. Raza : " & razaAux.NomRaza & vbLf &
                "Especie : " & especieAux.NomEspecie & vbLf &
                "*************************************")
                Exit Sub
            End If
        End If

        raza.Estado = 0
        Select Case _modoOpcion
            Case "agregar"
                bsnRaza.InsertarRaza(raza)
                MsgBox("La raza ha sido agregada correctamente.")
            Case "modificar"
                bsnRaza.ModificarRaza(raza)
                MsgBox("La raza ha sido modificada correctamente.")
        End Select
        LimpiarPanel()
        LlenarRazas("id_raza")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarPanel()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If lstRazas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una raza de la lista para modificarla.")
            Exit Sub
        End If
        btnAceptar.Visible = True : btnCancelar.Visible = True : txtNombre.Focus()
        _modoOpcion = "modificar"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lstRazas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una raza de la lista para eliminarla.")
            Exit Sub
        End If
        Dim idRaza As Integer = Convert.ToInt32(Trim(lblIdRaza.Text))
        Dim ct As Integer = 0 : Dim bsnRaza As New BsnRaza
        ct = bsnRaza.ValidarRazaConMascota(idRaza)
        If ct = 0 Then
            If MessageBox.Show("¿Esta seguro que desea eliminar esta raza?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                bsnRaza.EliminarRaza(idRaza)
                MsgBox("La raza ha sido eliminada correctamente.")
                LimpiarPanel() : LlenarRazas("id_raza")
            End If
        Else
                MsgBox("La raza no se puede eliminar porque hay mascotas que tiene asociadas.")
        End If

    End Sub

    Private Sub btnOrdenarNombre_Click(sender As Object, e As EventArgs) Handles btnOrdenarNombre.Click
        LlenarRazas("nom_raza")
    End Sub

    Private Sub btnOrdenarEspecie_Click(sender As Object, e As EventArgs) Handles btnOrdenarEspecie.Click
        LlenarRazas("nom_especie")
    End Sub

    Private Sub btnOrdenarID_Click(sender As Object, e As EventArgs) Handles btnOrdenarID.Click
        LlenarRazas("id_raza")
    End Sub

    Private Sub btnMigracionRazas_Click(sender As Object, e As EventArgs) Handles btnMigracionRazas.Click
        panelMigracion.Left = 13 : panelMigracion.Top = 13
        panelMigracion.Width = 440 : panelMigracion.Height = 423
        panelMigracion.Visible = True : Panel1.Enabled = False

        Dim listaEspecies As New List(Of Especie) : Dim bsnEspecie As New BsnEspecie
        listaEspecies = bsnEspecie.GetEspecies()
        cmbMigracionEspecie.Items.Clear()
        For Each especie As Especie In listaEspecies
            If especie.Estado <> 3 Then
                cmbMigracionEspecie.Items.Add(String.Format("{0,-7}{1,-25}", especie.IdEspecie, especie.NomEspecie))
            End If
        Next
    End Sub

    Private Sub btnCancelarMigracion_Click(sender As Object, e As EventArgs) Handles btnCancelarMigracion.Click
        panelMigracion.Visible = False : Panel1.Enabled = True
        cmbMigracionEspecie.SelectedIndex = -1
        cmbRazaOriginal.SelectedIndex = -1 : cmbRazaNueva.SelectedIndex = -1
        panelSubRazas.Visible = False
    End Sub

    Private Sub cmbMigracionEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMigracionEspecie.SelectedIndexChanged
        If cmbMigracionEspecie.SelectedIndex <> -1 Then
            panelSubRazas.Visible = True
            Dim cadena As String = cmbMigracionEspecie.SelectedItem
            Dim idEspecie As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 7)))
            Dim listaRazas As New List(Of Raza) : Dim bsnRaza As New BsnRaza
            listaRazas = bsnRaza.GetRazas()
            cmbRazaOriginal.SelectedIndex = -1 : cmbRazaNueva.SelectedIndex = -1
            cmbRazaOriginal.Items.Clear() : cmbRazaNueva.Items.Clear()
            For Each raza As Raza In listaRazas
                If raza.IdEspecie = idEspecie Then
                    cmbRazaOriginal.Items.Add(String.Format("{0,-7}{1,-25}", raza.IdRaza, raza.NomRaza))
                    cmbRazaNueva.Items.Add(String.Format("{0,-7}{1,-25}", raza.IdRaza, raza.NomRaza))
                End If
            Next
        End If
    End Sub

    Private Sub btnAceptarMigracion_Click(sender As Object, e As EventArgs) Handles btnAceptarMigracion.Click
        If cmbMigracionEspecie.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una especie.")
            Exit Sub
        End If
        If cmbRazaOriginal.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar la raza original.")
            Exit Sub
        End If
        If cmbRazaNueva.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar la nueva raza.")
            Exit Sub
        End If

        Dim cadOriginal As String = cmbRazaOriginal.SelectedItem
        Dim cadNueva As String = cmbRazaNueva.SelectedItem
        Dim idOriginal = Convert.ToInt32(Trim(cadOriginal.Substring(0, 5)))
        Dim idNueva = Convert.ToInt32(Trim(cadNueva.Substring(0, 5)))

        If idOriginal = idNueva Then
            MsgBox("La raza original no puede ser igual a la nueva.")
            Exit Sub
        End If

        Dim bsnRaza As New BsnRaza : bsnRaza.MigracionMascotas(idOriginal, idNueva)

        MsgBox("La migración ha sido realizada correctamente.")
        panelSubRazas.Visible = False
        cmbRazaOriginal.SelectedIndex = -1 : cmbRazaNueva.SelectedIndex = -1
        cmbRazaOriginal.Items.Clear() : cmbRazaNueva.Items.Clear()
        cmbEspecies.SelectedIndex = -1
        panelMigracion.Visible = False : Panel1.Enabled = True
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub
End Class
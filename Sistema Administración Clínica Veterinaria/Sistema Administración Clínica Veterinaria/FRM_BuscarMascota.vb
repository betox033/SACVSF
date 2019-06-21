Public Class FRM_BuscarMascota

    Dim _modoVentana As String = ""
    Dim _frmGestorHospitalizaciones As FRM_Gestor_Hospitalizaciones


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmGestorHospitalizaciones As FRM_Gestor_Hospitalizaciones)
        InitializeComponent()
        _frmGestorHospitalizaciones = frmGestorHospitalizaciones
        _modoVentana = "gestorH"
    End Sub

    Private Sub BuscarMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIdFicha.Text = "-1"
        Dim listaMascotas As New List(Of Mascota) : Dim bsnMascota As New BsnMascota
        listaMascotas = bsnMascota.GetMascotas()
        LlenarMascotas(listaMascotas)
    End Sub

    Sub LlenarMascotas(listaMascotas As List(Of Mascota))
        lstMascotas.Items.Clear()
        For Each mascota As Mascota In listaMascotas
            If mascota.Status = True Then
                Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(mascota.IdRaza)
                Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
                Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
                With lstMascotas.Items.Add(mascota.IdFicha)
                    .SubItems.Add(mascota.NomMascota)
                    .SubItems.Add(especie.NomEspecie)
                    .SubItems.Add(raza.NomRaza)
                    .SubItems.Add(cliente.Nombre)
                End With
            End If
        Next
    End Sub


    Sub BuscarPor(criterio As Integer, valor As String, inicio As Integer)
        Dim valorBusqueda As String = UCase(valor)
        Dim i As Integer = inicio : Dim lg As Integer = lstMascotas.Items.Count
        Dim encontrado As Boolean = False

        While i < lg And encontrado = False
            Dim valorTabla As String = lstMascotas.Items(i).SubItems(criterio).Text
            Dim largo As Integer = valorBusqueda.Length
            If largo > valorTabla.Length Then
                largo = valorTabla.Length
            End If
            valorTabla = UCase(valorTabla.Substring(0, largo))
            If valorTabla = valorBusqueda Then
                encontrado = True
                lstMascotas.Items(i).Selected = True
                lstMascotas.TopItem() = lstMascotas.Items(i)
                lblIdFicha.Text = Trim(lstMascotas.Items(i).SubItems(0).Text)
            End If
            i = i + 1
        End While
        If encontrado = False Then
            BusquedaRojo(criterio) : lstMascotas.SelectedItems.Clear() : lblIdFicha.Text = "-1"
        Else
            BusquedaBlanco(criterio)
        End If
        If valorBusqueda = "" Then
            BusquedaBlanco(criterio) : lstMascotas.SelectedItems.Clear() : lblIdFicha.Text = "-1"
        End If
    End Sub

    Sub BusquedaRojo(criterio As Integer)
        Select Case criterio
            Case 0 : txtIdFicha.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case 1 : txtNombre.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case 2 : txtEspecie.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case 3 : txtRaza.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case 4 : txtCliente.BackColor = Color.FromArgb(255, 255, 192, 192)
        End Select
    End Sub

    Sub BusquedaBlanco(criterio As Integer)
        Select Case criterio
            Case 0 : txtIdFicha.BackColor = Color.White
            Case 1 : txtNombre.BackColor = Color.White
            Case 2 : txtEspecie.BackColor = Color.White
            Case 3 : txtRaza.BackColor = Color.White
            Case 4 : txtCliente.BackColor = Color.White
        End Select
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If _modoVentana = "gestorH" Then
            _frmGestorHospitalizaciones.Show()
            Me.Close() : Me.Dispose()
        End If
    End Sub

    Private Sub txtIdFicha_TextChanged(sender As Object, e As EventArgs) Handles txtIdFicha.TextChanged
        BuscarPor(0, Trim(txtIdFicha.Text), 0)
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        BuscarPor(1, Trim(txtNombre.Text), 0)
    End Sub

    Private Sub txtEspecie_TextChanged(sender As Object, e As EventArgs) Handles txtEspecie.TextChanged
        BuscarPor(2, Trim(txtEspecie.Text), 0)
    End Sub

    Private Sub txtRaza_TextChanged(sender As Object, e As EventArgs) Handles txtRaza.TextChanged
        BuscarPor(3, Trim(txtRaza.Text), 0)
    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        BuscarPor(4, Trim(txtCliente.Text), 0)
    End Sub

    Private Sub lstMascotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMascotas.SelectedIndexChanged
        Dim indice As Integer = lstMascotas.FocusedItem.Index
        lblIdFicha.Text = Trim(lstMascotas.Items(indice).SubItems(0).Text)
    End Sub
End Class
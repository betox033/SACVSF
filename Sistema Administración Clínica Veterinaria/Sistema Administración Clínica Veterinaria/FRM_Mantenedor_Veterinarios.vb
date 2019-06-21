Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FRM_Mantenedor_Veterinarios

    Dim modalidad As String = "neutro"

    Dim detalle As String = "{0, -5}{1, -30}"
    Dim imagenCargada As Boolean = False
    Dim imagenRepetida As Boolean = False

    Protected _frmPrincipal As frm_Principal

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Private Sub FRM_Mantenedor_Veterinarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrdenarPor("num_veterinario") : LimpiarPanel()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _frmPrincipal.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub lst_veterinarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_veterinarios.SelectedIndexChanged
        If lst_veterinarios.SelectedIndex <> -1 Then
            Dim cadena As String = lst_veterinarios.SelectedItem
            Dim numVet As Integer = Convert.ToInt32((cadena.Substring(0, 5)))
            Dim veterinario As New Veterinario : Dim bsnVeterinario As New BsnVeterinario
            veterinario = bsnVeterinario.GetDatosVeterinario(numVet)
            LlenarPanelVeterinario(veterinario)
        End If
    End Sub

    Sub LlenarPanelVeterinario(veterinario As Veterinario)
        lbl_numero.Text = veterinario.NumVeterinario : txt_nombre.Text = veterinario.NomVeterinario
        txt_rut.Text = veterinario.RutVeterinario : txt_fono.Text = veterinario.FonoVeterinario
        Dim ruta As String = "../../img/veterinarios/" & veterinario.NumVeterinario & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbVeterinario.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            imagenCargada = True
            imagenRepetida = True
        Else
            pbVeterinario.Image = My.Resources.user_symbol_318_63527
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        LimpiarPanel() : BloquearBotones() : MostrarBotones()
        modalidad = "agregar"
        Dim bsnVeterinario As New BsnVeterinario
        lbl_numero.Text = bsnVeterinario.GenerarNumVeterinario()
        lst_veterinarios.Enabled = False : lst_veterinarios.SelectedIndex = -1
        txt_nombre.Focus()
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

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Trim(txt_nombre.Text) = "" Then
            MsgBox("Al menos debe ingresar un nombre para el veterinario.")
            Exit Sub
        End If

        Dim vet As New Veterinario : Dim bsnVet As New BsnVeterinario
        vet.NumVeterinario = Convert.ToInt32(Trim(lbl_numero.Text))
        vet.RutVeterinario = UCase(txt_rut.Text) : vet.RutVeterinario = vet.RutVeterinario.Replace(".", "")
        vet.RutVeterinario = vet.RutVeterinario.Replace("-", "")

        Dim valRut As Boolean = ValidarRut(vet.RutVeterinario)
        If valRut = False Then
            Exit Sub
        End If

        vet.NomVeterinario = UCase(Trim(txt_nombre.Text))

        Dim vetAux As New Veterinario : Dim bsnNegocio As New BsnNegocio : Dim repetido As Boolean = False

        If txt_rut.Text <> "" Then
            Dim verificarRut As Integer = bsnNegocio.ValidarPorTexto("veterinario", "rut_veterinario", vet.RutVeterinario)
            If verificarRut <> -1 Then
                vetAux = bsnVet.GetDatosVeterinario(verificarRut)
                If modalidad = "agregar" Then
                    repetido = True
                End If
                If modalidad = "modificar" Then
                    If vet.NumVeterinario <> vetAux.NumVeterinario Then
                        repetido = True
                    End If
                End If
            End If
        End If

        If repetido = True Then
            MsgBox("Ya existe un veterinario con datos similares." & vbLf &
                   "*********************************************" & vbLf &
                   "Número : " & vetAux.NumVeterinario & vbLf &
                   "Nombre : " & vetAux.NomVeterinario & vbLf &
                   "RUT : " & vetAux.RutVeterinario & vbLf &
                   "Fono : " & vetAux.FonoVeterinario & vbLf &
                   "*********************************************")
            Exit Sub
        End If

        vet.FonoVeterinario = Trim(txt_fono.Text)
        vet.Estado = True

        Select Case modalidad
            Case "agregar"
                bsnVet.InsertarVeterinario(vet)
                MsgBox("El veterinario ha sido agregado correctamente.")
            Case "modificar"
                bsnVet.ModificarVeterinario(vet)
                MsgBox("El veterinario ha sido modificado correctamente.")
        End Select

        Dim ruta As String = "../../img/veterinarios/" & vet.NumVeterinario & ".jpg"
        If imagenCargada = True Then
            If imagenRepetida = False Then
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                pbVeterinario.Image.Save(ruta, Imaging.ImageFormat.Jpeg)
            End If
        Else
            If File.Exists(ruta) Then
                My.Computer.FileSystem.DeleteFile(ruta)
            End If
        End If
        OrdenarPor("num_veterinario") : lst_veterinarios.Enabled = True
        OcultarBotones() : DesbloquearBotones() : LimpiarPanel()
        lst_veterinarios.Enabled = True : lst_veterinarios.SelectedIndex = -1
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        lst_veterinarios.Enabled = True
        txt_nombre.Text = "" : txt_rut.Text = "" : txt_fono.Text = "" : lbl_numero.Text = ""
        btn_aceptar.Visible = False : btn_cancelar.Visible = False
        btn_modificar.Enabled = True : btn_eliminar.Enabled = True : btn_agregar.Enabled = True
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If lst_veterinarios.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un veterinario de la lista.")
            Exit Sub
        End If
        BloquearBotones() : MostrarBotones()
        lst_veterinarios.Enabled = False
        txt_nombre.Focus()
        modalidad = "modificar"
    End Sub

    Sub OrdenarPor(criterio)
        Dim bsnVeterinario As New BsnVeterinario
        Dim listaVeterinarios As New List(Of Veterinario)
        listaVeterinarios = bsnVeterinario.GetVeterinarios(criterio)
        lst_veterinarios.Items.Clear()
        For Each veterinario As Veterinario In listaVeterinarios
            If veterinario.Estado = True Then
                lst_veterinarios.Items.Add(String.Format(detalle, veterinario.NumVeterinario, veterinario.NomVeterinario))
            End If
        Next
    End Sub

    Private Sub btnOrdenarNumero_Click(sender As Object, e As EventArgs) Handles btnOrdenarNumero.Click
        OrdenarPor("num_veterinario")
    End Sub

    Private Sub btnOrdenarNombre_Click(sender As Object, e As EventArgs) Handles btnOrdenarNombre.Click
        OrdenarPor("nom_veterinario")
    End Sub

    Sub BloquearBotones()
        btn_agregar.Enabled = False : btn_modificar.Enabled = False : btn_eliminar.Enabled = False
    End Sub

    Sub DesbloquearBotones()
        btn_agregar.Enabled = True : btn_modificar.Enabled = True : btn_eliminar.Enabled = True
    End Sub

    Sub LimpiarPanel()
        pbVeterinario.Image = My.Resources.user_symbol_318_63527 : lbl_numero.Text = "" : txt_nombre.Text = ""
        txt_rut.Text = "" : txt_fono.Text = ""
    End Sub

    Sub OcultarBotones()
        btn_aceptar.Visible = False : btn_cancelar.Visible = False
        btnCargarImagen.Visible = False : btnQuitarImagen.Visible = False
    End Sub

    Sub MostrarBotones()
        btn_aceptar.Visible = True : btn_cancelar.Visible = True
        btnCargarImagen.Visible = True : btnQuitarImagen.Visible = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If lst_veterinarios.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un veterinario de la lista.")
            Exit Sub
        End If

        Dim cadena As String = lst_veterinarios.SelectedItem
        Dim num_veterinario As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
        Dim bsnNegocio As New BsnNegocio : Dim bsnVeterinario As New BsnVeterinario
        Dim validarAtencion As Integer = bsnNegocio.ValidarPorNumero("atencion", "num_veterinario", num_veterinario)

        If MessageBox.Show("¿Esta seguro que desea eliminar a este veterinario?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If validarAtencion <> -1 Then
                MsgBox("El veterinario no puede ser elminado porque tiene atenciones asociadas.")
            Else
                bsnVeterinario.EliminarVeterinarioFisico(num_veterinario)
                Dim ruta As String = "../../img/veterinarios/" & num_veterinario & ".jpg"
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                LimpiarPanel() : OrdenarPor("num_veterinario")
                MsgBox("El veterinario ha sido eliminado del sistema.")
            End If
        End If
    End Sub

    Sub BuscarPor(criterio, inicio)
        Dim valorBusqueda As String = ""
        Select Case criterio
            Case "num_veterinario" : valorBusqueda = txtBusquedaNumero.Text
            Case "nom_veterinario" : valorBusqueda = txtBusquedaNombre.Text
        End Select
        valorBusqueda = UCase(Trim(valorBusqueda))
        Dim valorLista As String = ""
        Dim lgb As Integer = valorBusqueda.Length : Dim i As Integer = inicio
        Dim encontrado As Boolean = False : Dim largoLista As Integer = lst_veterinarios.Items.Count
        While i < largoLista And encontrado = False
            Dim cadena As String = lst_veterinarios.Items.Item(i)
            Select Case criterio
                Case "num_veterinario" : valorLista = cadena.Substring(0, lgb)
                Case "nom_veterinario" : valorLista = cadena.Substring(5, lgb)
            End Select
            valorLista = UCase(Trim(valorLista))
            If valorLista = valorBusqueda And Trim(valorBusqueda) <> "" Then
                encontrado = True
                lst_veterinarios.SelectedIndex = i
            End If
            i = i + 1
        End While

        If encontrado = False Then
            lst_veterinarios.SelectedIndex = -1 : BusquedaRojo(criterio) : LimpiarPanel()
            If Trim(valorBusqueda) = "" Then
                BusquedaBlanco(criterio)
            End If
        Else
            BusquedaBlanco(criterio)
        End If


    End Sub

    Sub BusquedaRojo(criterio As String)
        Select Case criterio
            Case "num_veterinario" : txtBusquedaNumero.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case "nom_veterinario" : txtBusquedaNombre.BackColor = Color.FromArgb(255, 255, 192, 192)
        End Select
    End Sub

    Sub BusquedaBlanco(criterio As String)
        Select Case criterio
            Case "num_veterinario" : txtBusquedaNumero.BackColor = Color.White
            Case "nom_veterinario" : txtBusquedaNombre.BackColor = Color.White
        End Select
    End Sub

    Private Sub txtBusquedaNumero_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaNumero.TextChanged
        BuscarPor("num_veterinario", 0)
    End Sub

    Private Sub txtBusquedaNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaNombre.TextChanged
        BuscarPor("nom_veterinario", 0)
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

            pbVeterinario.Image = Image.FromFile(ofd.FileName)
            imagenCargada = True
            imagenRepetida = False
        End If
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        pbVeterinario.Image = My.Resources.user_symbol_318_63527
        imagenCargada = False
        imagenRepetida = False
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
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
End Class
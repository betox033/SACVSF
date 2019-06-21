Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FRM_Mantenedor_Proveedores

    Protected _frmPrincipal As frm_Principal
    Dim imagenCargada As Boolean = False
    Dim imagenRepetida As Boolean = False

    Dim detalle As String = "{0, -5}{1, -22}{2, -11}"

    Dim modalidad As String = "neutro"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal)
        MyBase.New()
        _frmPrincipal = frmPrincipal
        InitializeComponent()
    End Sub

    Private Sub FRM_Mantenedor_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrdenarPor("cod_proveedor")
        lbl_codigo.Text = ""
        lstProveedores.SelectedIndex = -1
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        lstProveedores.SelectedIndex = -1 : LimpiarPanel() : MostrarBotonesPanel()
        txt_nombre.Focus() : modalidad = "agregar" : lstProveedores.Enabled = False
        BloquearBotones() : Dim bsnProveedor As New BsnProveedores
        lbl_codigo.Text = bsnProveedor.GenerarCodProveedor
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        OcultarBotonesPanel() : LimpiarPanel() : DesbloquearBotones()
        modalidad = "" : lstProveedores.SelectedIndex = -1 : lstProveedores.Enabled = True
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Trim(txt_nombre.Text) = "" Then
            MsgBox("Debe ingresar un nombre para el proveedor.") : Exit Sub
        End If

        Dim proveedor As New Proveedor : Dim bsnProveedor As New BsnProveedores
        proveedor.IdProveedor = Convert.ToInt32(Trim(lbl_codigo.Text))
        proveedor.NomProveedor = UCase(Trim(txt_nombre.Text))

        '//////////////// validar nombre repetido '//////////////////////////////////////
        Dim bsnNegocio As New BsnNegocio : Dim nombreRepetido As Boolean = False
        Dim validarNom As Integer = bsnNegocio.ValidarPorTexto("proveedor", "nom_proveedor", proveedor.NomProveedor)
        If validarNom <> -1 Then
            Dim provAux As New Proveedor : provAux = bsnProveedor.GetDatosProveedor(validarNom)

            If modalidad = "agregar" Then
                nombreRepetido = True
            End If

            If modalidad = "modificar" Then
                If provAux.IdProveedor <> proveedor.IdProveedor Then
                    nombreRepetido = True
                End If
            End If

            If nombreRepetido = True Then
                MsgBox("Ya existe un proveedor con el mismo nombre." & vbLf &
                "*******************************************" & vbLf &
                "Id Proveedor  : " & provAux.IdProveedor & vbLf &
                "Nom Proveedor : " & provAux.NomProveedor & vbLf &
                "Fono          : " & provAux.FonoProveedor & vbLf &
                "Dirección     : " & provAux.DirProveedor & vbLf &
                "*******************************************")
                Exit Sub
            End If
        End If
        '///////////////////////////////////////////////////////////////////////////////

        proveedor.FonoProveedor = Trim(txt_fono.Text)
        proveedor.DirProveedor = UCase(Trim(txt_direccion.Text))
        proveedor.Estado = True

        Select Case modalidad
            Case "agregar"
                bsnProveedor.InsertarProveedor(proveedor)
                MsgBox("El proveedor ha sido agregado correctamente.")
            Case "modificar"
                bsnProveedor.ModificarProveedor(proveedor)
                MsgBox("El proveedor ha sido modificado correctamente.")
        End Select

        Dim ruta As String = "../../img/proveedores/" & proveedor.IdProveedor & ".jpg"
        If imagenCargada = True Then
            If imagenRepetida = False Then
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                pbProveedor.Image.Save(ruta, Imaging.ImageFormat.Jpeg)
            End If
        Else
            If File.Exists(ruta) Then
                My.Computer.FileSystem.DeleteFile(ruta)
            End If
        End If

        lstProveedores.Enabled = True
        OrdenarPor("cod_proveedor")
        DesbloquearBotones() : OcultarBotonesPanel()
        modalidad = "neutro"
        LimpiarPanel()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        _frmPrincipal.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If lstProveedores.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un proveedor de la lista.")
            Exit Sub
        End If

        txt_nombre.Focus()
        MostrarBotonesPanel() : BloquearBotones()
        lstProveedores.Enabled = False
        modalidad = "modificar"
    End Sub

    Private Sub lstProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProveedores.SelectedIndexChanged
        If lstProveedores.SelectedIndex <> -1 Then
            Dim cadena As String = lstProveedores.SelectedItem
            Dim cod_proveedor As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            Dim bsnProveedor As New BsnProveedores : Dim proveedor As New Proveedor
            proveedor = bsnProveedor.GetDatosProveedor(cod_proveedor)
            lbl_codigo.Text = proveedor.IdProveedor
            txt_nombre.Text = proveedor.NomProveedor
            txt_fono.Text = proveedor.FonoProveedor
            txt_direccion.Text = proveedor.DirProveedor

            Dim ruta As String = "../../img/proveedores/" & cod_proveedor & ".jpg"
            If File.Exists(ruta) Then
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
                pbProveedor.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()
                imagenCargada = True
                imagenRepetida = True
            Else
                pbProveedor.Image = My.Resources._7a87b5c60ed68a903e52c16ac685417f
            End If

        End If
    End Sub

    Sub BloquearBotones()
        btn_agregar.Enabled = False : btn_modificar.Enabled = False : btn_eliminar.Enabled = False
    End Sub

    Sub DesbloquearBotones()
        btn_agregar.Enabled = True : btn_modificar.Enabled = True : btn_eliminar.Enabled = True
    End Sub

    Sub LimpiarPanel()
        txt_nombre.Text = "" : txt_fono.Text = "" : txt_direccion.Text = ""
        pbProveedor.Image = My.Resources._7a87b5c60ed68a903e52c16ac685417f : lbl_codigo.Text = ""
    End Sub

    Sub OrdenarPor(criterio)
        Dim bsnProveedor As New BsnProveedores
        Dim listaProveedores As New List(Of Proveedor)
        listaProveedores = bsnProveedor.GetProveedores(criterio)
        lstProveedores.Items.Clear()
        For Each proveedor As Proveedor In listaProveedores
            If proveedor.Estado = True Then
                lstProveedores.Items.Add(String.Format(detalle, proveedor.IdProveedor, proveedor.NomProveedor, proveedor.FonoProveedor))
            End If
        Next
        lstProveedores.SelectedIndex = -1
    End Sub

    Private Sub btnOrdenarCodigo_Click(sender As Object, e As EventArgs) Handles btnOrdenarCodigo.Click
        OrdenarPor("cod_proveedor")
    End Sub

    Private Sub btnOrdenarNombre_Click(sender As Object, e As EventArgs) Handles btnOrdenarNombre.Click
        OrdenarPor("nom_proveedor")
    End Sub

    Private Sub btnOrdenarFono_Click(sender As Object, e As EventArgs) Handles btnOrdenarFono.Click
        OrdenarPor("fono_proveedor")
    End Sub

    Sub OcultarBotonesPanel()
        btnCargarImagen.Visible = False : btnQuitarImagen.Visible = False : btn_aceptar.Visible = False : btn_cancelar.Visible = False
    End Sub

    Sub MostrarBotonesPanel()
        btnCargarImagen.Visible = True : btnQuitarImagen.Visible = True : btn_aceptar.Visible = True : btn_cancelar.Visible = True
    End Sub

    Sub BuscarPor(criterio As String, inicio As Integer)
        Dim valorBusqueda As String = ""
        Select Case criterio
            Case "cod_proveedor" : valorBusqueda = txtBusquedaCodigo.Text
            Case "nom_proveedor" : valorBusqueda = txtBusquedaNombre.Text
            Case "fono_proveedor" : valorBusqueda = txtBusquedaFono.Text
        End Select
        valorBusqueda = UCase(Trim(valorBusqueda))
        Dim i As Integer = inicio : Dim lg As Integer = lstProveedores.Items.Count
        Dim lgb As Integer = valorBusqueda.Length : Dim encontrado As Boolean = False
        While i < lg And encontrado = False
            Dim valorLista As String = ""
            Dim cadena As String = lstProveedores.Items.Item(i)
            Select Case criterio
                Case "cod_proveedor" : valorLista = cadena.Substring(0, 5)
                Case "nom_proveedor" : valorLista = cadena.Substring(5, 22)
                Case "fono_proveedor" : valorLista = cadena.Substring(27, 11)
            End Select
            valorLista = UCase(valorLista.Substring(0, lgb))
            If valorBusqueda = valorLista And valorBusqueda <> "" Then
                encontrado = True
                lstProveedores.SelectedIndex = i
            End If
            i = i + 1
        End While

        If encontrado = False Then
            BusquedaRojo(criterio) : lstProveedores.SelectedIndex = -1
            If valorBusqueda = "" Then
                BusquedaBlanco(criterio) : LimpiarPanel()
            End If
        Else
            BusquedaBlanco(criterio)
        End If


    End Sub

    Sub BusquedaRojo(criterio As String)
        Select Case criterio
            Case "cod_proveedor" : txtBusquedaCodigo.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case "nom_proveedor" : txtBusquedaNombre.BackColor = Color.FromArgb(255, 255, 192, 192)
            Case "fono_proveedor" : txtBusquedaFono.BackColor = Color.FromArgb(255, 255, 192, 192)
        End Select
    End Sub

    Sub BusquedaBlanco(criterio As String)
        Select Case criterio
            Case "cod_proveedor" : txtBusquedaCodigo.BackColor = Color.White
            Case "nom_proveedor" : txtBusquedaNombre.BackColor = Color.White
            Case "fono_proveedor" : txtBusquedaFono.BackColor = Color.White
        End Select
    End Sub

    Private Sub txtBusquedaCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaCodigo.TextChanged
        BuscarPor("cod_proveedor", 0)
    End Sub

    Private Sub txtBusquedaNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaNombre.TextChanged
        BuscarPor("nom_proveedor", 0)
    End Sub

    Private Sub txtBusquedaFono_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaFono.TextChanged
        BuscarPor("fono_proveedor", 0)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim indice As Integer = lstProveedores.SelectedIndex
        If indice = -1 Then
            MsgBox("Debe seleccionar un proveedor de la lista.")
            Exit Sub
        End If

        Dim cadena As String = lstProveedores.SelectedItem
        Dim codProveedor As Integer = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
        Dim bsnNegocio As New BsnNegocio : Dim bsnProveedores As New BsnProveedores

        Dim validarProducto As Integer = bsnNegocio.ValidarPorNumero("producto", "cod_proveedor", codProveedor)

        If MessageBox.Show("¿Esta seguro que desea eliminar a este proveedor?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If validarProducto <> -1 Then
                MsgBox("El proveedor no puede ser eliminado porque tiene datos asociados a productos.")
            Else
                bsnProveedores.EliminarProveedorFisico(codProveedor)
                Dim ruta As String = "../../img/proveedores/" & codProveedor & ".jpg"
                If File.Exists(ruta) Then
                    My.Computer.FileSystem.DeleteFile(ruta)
                End If
                MsgBox("El proveedor ha sido eliminado del sistema.")
                OrdenarPor("cod_proveedor") : LimpiarPanel()
            End If
        End If
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

            pbProveedor.Image = Image.FromFile(ofd.FileName)
            imagenCargada = True
            imagenRepetida = False
        End If
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        pbProveedor.Image = My.Resources._7a87b5c60ed68a903e52c16ac685417f
        imagenCargada = False
        imagenRepetida = False
    End Sub

    Private Sub txtBusquedaCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPor("cod_proveedor", lstProveedores.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txtBusquedaNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPor("nom_proveedor", lstProveedores.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txtBusquedaFono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaFono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BuscarPor("fono_proveedor", lstProveedores.SelectedIndex + 1)
        End If
    End Sub

    Private Sub txtBusquedaCodigo_Enter(sender As Object, e As EventArgs) Handles txtBusquedaCodigo.Enter
        txtBusquedaNombre.Text = "" : txtBusquedaFono.Text = ""
    End Sub

    Private Sub txtBusquedaNombre_Enter(sender As Object, e As EventArgs) Handles txtBusquedaNombre.Enter
        txtBusquedaCodigo.Text = "" : txtBusquedaFono.Text = ""
    End Sub

    Private Sub txtBusquedaFono_Enter(sender As Object, e As EventArgs) Handles txtBusquedaFono.Enter
        txtBusquedaNombre.Text = "" : txtBusquedaCodigo.Text = ""
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
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_Registrar_Atencion

    Dim _modalidad As String
    Dim _mascota As Mascota
    Dim _frmPrincipal As frm_Principal
    Dim _modoOpcion As String = "descripcion"
    Dim _frmCalendario As New frm_Calendario
    Dim _codAtencion As Integer
    Dim _modoCosto As String


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmPrincipal As frm_Principal, modalidad As String, mascota As Mascota)
        MyBase.New()
        _modalidad = modalidad : _mascota = mascota : _frmPrincipal = frm_Principal
        InitializeComponent()
    End Sub

    Public Sub New(frmCalendario As frm_Calendario, modalidad As String, mascota As Mascota, codAtencion As Integer)
        MyBase.New()
        _modalidad = modalidad : _mascota = mascota : _frmCalendario = frmCalendario : _codAtencion = codAtencion
        InitializeComponent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Select Case _modalidad
            Case "directo" : _frmPrincipal.Show()
            Case "calendario" : _frmCalendario.Show()
        End Select
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub frm_Registrar_Atencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_fecha.Text = DateTime.Now.ToString("dd-MM-yyyy") : LlenarDatosMascota()

        Select Case _modalidad
            Case "directo"
                Dim bsnAtencion As New BsnAtencion : lbl_num_atencion.Text = bsnAtencion.GenerarCodAtencion()
            Case "calendario"
                lbl_num_atencion.Text = _codAtencion
                Dim atencion As New Atencion : Dim bsnAtencion As New BsnAtencion
                atencion = bsnAtencion.GetDatosAtencion(_codAtencion)
                rtb_descripcion.Text = atencion.Descripcion
        End Select

        llenar_veterinario() : CargarObservaciones() : cmb_veterinarios.SelectedIndex = 0
        panelDescripcion.Top = 192 : panelDescripcion.Left = 0
        panelDescripcion.Height = 440 : panelDescripcion.Width = 570
        lblCosto.Text = "" : lblDetalleTotal.Text = ""
    End Sub

    Sub ActualizarTotal()
        Dim i As Integer = 0 : Dim lg As Integer = lstAgregados.Items.Count
        Dim suma As Integer = 0 : Dim precio As Integer = 0 : Dim convertir As New Convertir
        While i < lg
            precio = convertir.dinero_a_numero(lstAgregados.Items(i).SubItems(4).Text)
            suma = suma + precio
            i = i + 1
        End While
        lblDetalleTotal.Text = convertir.convertir_dinero(suma)
    End Sub

    Sub CargarObservaciones()
        Dim listaObservaciones As New List(Of Observacion) : Dim bsnObservacion As New BsnObservacion
        listaObservaciones = bsnObservacion.GetObservaciones(_mascota.IdFicha)
        For Each observacion As Observacion In listaObservaciones
            With lstObservaciones.Items.Add(observacion.NumObservacion)
                .SubItems.Add(observacion.FechaObservacion)
                .SubItems.Add(observacion.Descripcion)
            End With
        Next
    End Sub

    Sub LlenarDatosMascota()
        lbl_numero.Text = _mascota.IdFicha : lbl_nombre.Text = _mascota.NomMascota
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(_mascota.IdRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie : especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)
        lbl_especie.Text = especie.NomEspecie : lbl_raza.Text = raza.NomRaza
        If _mascota.Sexo = "F" Then
            lbl_sexo.Text = "FEMENINO"
        Else
            lbl_sexo.Text = "MASCULINO"
        End If
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(_mascota.IdCliente)
        lbl_cliente.Text = cliente.Nombre : lbl_color.Text = _mascota.Color : lbl_fnac.Text = _mascota.FechaNacimiento

        Dim ruta As String = "../../img/mascotas/" & _mascota.IdFicha & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbMascota.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            pbMascota.Image = My.Resources.mascotaSilueta
        End If
    End Sub

    Sub llenar_veterinario()
        cmb_veterinarios.Items.Clear()
        Dim listaVeterinarios As New List(Of Veterinario) : Dim bsnVeterinario As New BsnVeterinario
        listaVeterinarios = bsnVeterinario.GetVeterinarios("num_veterinario")
        For Each vet As Veterinario In listaVeterinarios
            cmb_veterinarios.Items.Add(String.Format("{0,-5}{1,-20}", vet.NumVeterinario, vet.NomVeterinario))
        Next
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        '//////////////////////////////validaciones//////////////////////////////////
        If Trim(rtb_descripcion.Text) = "" Then
            MsgBox("Para registrar una atención debe ingresar contenido en la descripción.") : Exit Sub
        End If
        If cmb_veterinarios.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un veterinario.") : Exit Sub
        End If
        '////////////////////////// fin validaciones /////////////////////////////////

        Dim bloque As New BloqueCodigo : bloque.FormatoDecimalPunto()

        Dim atencion As New Atencion : Dim bsnAtencion As New BsnAtencion : atencion.CodAtencion = Convert.ToInt32(Trim(lbl_num_atencion.Text))
        atencion.IdFicha = Trim(lbl_numero.Text) : Dim cadena As String = cmb_veterinarios.SelectedItem
        atencion.NumVeterinario = Convert.ToInt32(Trim(cadena.Substring(0, 3))) : Dim convertir As New Convertir
        atencion.FechaAtencion = convertir.invertir_fecha(Trim(lbl_fecha.Text)) : atencion.TipoAtencion = "R"

        If Trim(txt_peso.Text) <> "" Then
            atencion.Peso = Convert.ToInt32(Trim(txt_peso.Text))
        End If
        If Trim(txt_altura.Text) <> "" Then
            atencion.Altura = Convert.ToDouble(Trim(txt_altura.Text))
            If atencion.Altura > 3 Then
                MsgBox("La altura no puede ser mayor a 3m")
                txt_altura.BackColor = Color.Yellow : txt_altura.Focus() : Exit Sub
            End If
        End If
        If Trim(txt_temperatura.Text) <> "" Then
            atencion.Temperatura = Convert.ToDouble(Trim(txt_temperatura.Text))
            If atencion.Temperatura > 50 Then
                MsgBox("La temperatura registrada no puede ser mayor as 50° C")
                txt_temperatura.BackColor = Color.Yellow : txt_temperatura.Focus() : Exit Sub
            End If
        End If
        atencion.Descripcion = rtb_descripcion.Text
        If lblCosto.Text <> "" Then
            atencion.Costo = convertir.dinero_a_numero(Trim(lblCosto.Text))
        End If

        If MessageBox.Show("¿Desea guardar todos los datos registrados en la atención?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        Select Case _modalidad
            Case "directo" : bsnAtencion.InsertarAtencion(atencion)
            Case "calendario" : bsnAtencion.ModificarAtencion(atencion)
        End Select

        Dim msgDetalles As String = RegistrarDetalles()
        MsgBox("La atención ha sido registrada correctamente." & vbLf & vbLf & msgDetalles)

        Select Case _modalidad
            Case "directo" : _frmPrincipal.Show()
            Case "calendario"
                Dim f As String = DateTime.Now.ToString("yyyy-MM-dd")
                _frmCalendario.CargarAtenciones(f)
                _frmCalendario.Show()
        End Select
        Me.Close() : Me.Dispose()
    End Sub

    Function RegistrarDetalles()
        Dim i As Integer = 0
        Dim cantVacunas As Integer = 0 : Dim cantInsumos As Integer = 0 : Dim cantObservaciones As Integer = 0
        Dim convertir As New Convertir : Dim lg As Integer = lstAgregados.Items.Count

        While i < lg
            Dim cadena As String = ""
            Dim tipo As String = lstAgregados.Items(i).SubItems(0).Text
            Dim costo As New Costo : Dim bsnCosto As New BsnCosto
            costo.IdCosto = bsnCosto.GenerarIdCosto
            costo.CodAtencion = Convert.ToInt32(Trim(lbl_num_atencion.Text))

            If tipo = "V" Then
                Dim vacuna As New Vacuna : Dim bsnVacuna As New BsnVacuna
                vacuna.NumVacuna = bsnVacuna.GenerarNumVacuna
                vacuna.IdFicha = Trim(lbl_numero.Text)
                vacuna.Codproducto = Convert.ToInt32(lstAgregados.Items(i).SubItems(1).Text)
                Dim nAux As String = lstAgregados.Items(i).SubItems(2).Text.Substring(0, 2)

                Select Case nAux
                    Case "1°" : vacuna.NOrdinal = 1
                    Case "2°" : vacuna.NOrdinal = 2
                    Case "3°" : vacuna.NOrdinal = 3
                    Case "4°" : vacuna.NOrdinal = 4
                    Case Else : vacuna.NOrdinal = 0
                End Select
                vacuna.Dosis = lstAgregados.Items(i).SubItems(3).Text.Substring(0, 7)
                vacuna.FechaVacuna = convertir.invertir_fecha(Trim(lbl_fecha.Text))
                vacuna.FechaProxVacuna = lstAgregados.Items(i).SubItems(3).Text.Substring(7, 10)
                bsnVacuna.InsertarVacuna(vacuna)

                '////////////actualizar stock/////////////////////
                Dim producto As Producto : Dim bsnProducto As New BsnProductos
                producto = bsnProducto.GetDatosProducto(vacuna.Codproducto)

                '////////////registrar movimiento//////////////////////////////////////////////////
                Dim ajuste As New Ajuste : Dim bsnAjuste As New BsnAjuste
                ajuste.Codproducto = vacuna.Codproducto : ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                ajuste.TipoAjuste = "A"

                If producto.Unidad = "UN" Then
                    Dim stock As Integer = producto.Stock : stock = stock - 1
                    bsnProducto.ActualizarProducto(vacuna.Codproducto, stock)
                    ajuste.Cantidad = -1
                Else
                    Dim stock As New Stock : stock = bsnProducto.GetDatosStock(vacuna.Codproducto)
                    If vacuna.Dosis >= stock.CantActual Then
                        stock.NumFrascos = stock.NumFrascos - 1
                        If stock.NumFrascos = 0 Then
                            stock.CantActual = 0
                        Else
                            stock.CantActual = stock.CantTotal - (vacuna.Dosis - stock.CantActual)
                        End If
                    Else
                        stock.CantActual = stock.CantActual - vacuna.Dosis
                    End If
                    bsnProducto.ModificarStock(stock)
                    ajuste.Cantidad = vacuna.Dosis * -1
                End If

                bsnAjuste.InsertarAjuste(ajuste)
                '///////////////////////////////////////////////////
                Dim detalleVacuna As String = "{0,-4}{1,-4}{2,-2}"
                costo.Descripcion = String.Format(detalleVacuna, "***V", vacuna.Codproducto, vacuna.NOrdinal)
                costo.Costo = convertir.dinero_a_numero(Trim(lstAgregados.Items(i).SubItems(4).Text))
                cantVacunas = cantVacunas + 1
            End If

            If tipo = "I" Then
                Dim insumo As New Insumo : Dim bsnInsumo As New BsnInsumo
                insumo.CodAtencion = Convert.ToInt32(Trim(lbl_num_atencion.Text))
                insumo.CodProducto = Convert.ToInt32(Trim(lstAgregados.Items(i).SubItems(1).Text))

                '////////////registrar movimiento//////////////////////////////////////////////////
                Dim ajuste As New Ajuste : Dim bsnAjuste As New BsnAjuste
                ajuste.Codproducto = insumo.CodProducto : ajuste.FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                ajuste.TipoAjuste = "A"
                Dim producto As New Producto : Dim bsnProducto As New BsnProductos
                producto = bsnProducto.GetDatosProducto(insumo.CodProducto)

                If producto.Unidad = "ML" Then
                    insumo.Cantidad = Convert.ToDouble(Trim(lstAgregados.Items(i).SubItems(3).Text))
                    insumo.Precio = convertir.dinero_a_numero(lstAgregados.Items(i).SubItems(4).Text)
                Else
                    insumo.Cantidad = Convert.ToDouble(Trim(lstAgregados.Items(i).SubItems(3).Text.Substring(0, 4)))
                    insumo.Precio = Convert.ToInt32(Trim(lstAgregados.Items(i).SubItems(3).Text.Substring(4, 8)))
                End If
                ajuste.Cantidad = insumo.Cantidad * -1
                bsnAjuste.InsertarAjuste(ajuste)
                RegistrarInsumo(insumo)
                '//////////////////////////////////////////////////////
                Dim detalleCosto As String = "{0,-4}{1,-4}{2,-6}{3,-6}"
                costo.Descripcion = String.Format(detalleCosto, "***I", insumo.CodProducto, insumo.Cantidad, insumo.Precio)
                costo.Costo = convertir.dinero_a_numero(Trim(lstAgregados.Items(i).SubItems(4).Text))
                cantInsumos = cantInsumos + 1
            End If

            If tipo = "C" Then
                costo.Descripcion = UCase(Trim(lstAgregados.Items(i).SubItems(2).Text))
                costo.Costo = convertir.dinero_a_numero(Trim(lstAgregados.Items(i).SubItems(4).Text))
            End If

            i = i + 1
            bsnCosto.InsertarCosto(costo)
        End While

        cantObservaciones = RegistrarObservaciones()

        Dim mensaje As String = "***************************************" & vbLf
        If cantVacunas > 0 Or cantInsumos > 0 Or cantObservaciones > 0 Then
            mensaje = mensaje & "Se han registrado : " & vbLf
        Else
            mensaje = mensaje & "No se han registrado agregados." & vbLf
        End If
        If cantVacunas > 0 Then mensaje = mensaje & "- " & cantVacunas & " Vacunas." & vbLf
        If cantInsumos > 0 Then mensaje = mensaje & "- " & cantInsumos & " Insumos." & vbLf
        If cantObservaciones > 0 Then mensaje = mensaje & "- " & cantObservaciones & " Observaciones." & vbLf
        mensaje = mensaje & "***************************************"
        Return mensaje
    End Function

    Sub RegistrarInsumo(insumo As Insumo)
        Dim bsnInsumo As New BsnInsumo
        bsnInsumo.InsertarInsumo(insumo)

        '////////////actualizar stock///////////////////////
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(insumo.CodProducto)
        If producto.Unidad = "ML" Then
            Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
            If stock.CantActual <= insumo.Cantidad Then
                stock.NumFrascos = stock.NumFrascos - 1
                If stock.NumFrascos = 0 Then
                    stock.CantActual = 0
                Else
                    stock.CantActual = stock.CantTotal - (insumo.Cantidad - stock.CantActual)
                End If
            Else
                stock.CantActual = stock.CantActual - insumo.Cantidad
            End If
            bsnProducto.ModificarStock(stock)
        Else
            Dim stock As Integer = producto.Stock
            stock = stock - insumo.Cantidad
            bsnProducto.ActualizarProducto(insumo.CodProducto, stock)
        End If
    End Sub

    Function RegistrarObservaciones()
        Dim cantObservaciones As Integer = 0 : Dim convertir As New Convertir
        Dim i As Integer = 0 : Dim lg As Integer = lstObservaciones.Items.Count
        Dim bsnObservacion As New BsnObservacion
        While i < lg
            Dim tipo As String = lstObservaciones.Items(i).SubItems(0).Text.Substring(0, 1)
            If Trim(tipo) = "N" Then
                Dim observacion As New Observacion
                observacion.NumObservacion = bsnObservacion.GenerarNumeroObservacion
                observacion.IdFicha = Trim(lbl_numero.Text)
                observacion.FechaObservacion = convertir.invertir_fecha(Trim(lbl_fecha.Text))
                observacion.Descripcion = lstObservaciones.Items(i).SubItems(1).Text
                bsnObservacion.InsertarObservacion(observacion)
                cantObservaciones = cantObservaciones + 1
            End If
            i = i + 1
        End While

        i = 0 : lg = lstPendientes.Items.Count
        While i < lg
            Dim tip As String = lstPendientes.Items(i).SubItems(0).Text
            Select Case tip
                Case "E"
                    bsnObservacion.EliminarObservacion(Convert.ToInt32(Trim(lstPendientes.Items(i).SubItems(1).Text)))
                Case "M"
                    Dim ob As New Observacion
                    ob.NumObservacion = Convert.ToInt32(Trim(lstPendientes.Items(i).SubItems(1).Text))
                    ob.FechaObservacion = DateTime.Now.ToString("yyyy-MM-dd")
                    ob.Descripcion = Trim(lstPendientes.Items(i).SubItems(2).Text)
                    bsnObservacion.ModificarObservacion(ob)
            End Select
            i = i + 1
        End While
        Return cantObservaciones
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl_fecha.Text = txt_adecuar.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnAgregarVacuna.Click
        Dim frmAgregarVacuna As New FRM_Agregar_Vacuna(Me, "atencion") : frmAgregarVacuna.Show() : Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAgregarInsumo.Click
        Dim idAtencion As Integer = Convert.ToInt32(Trim(lbl_num_atencion.Text))
        Dim frmIngresarInsumo As New FRM_AgregarInsumo(idAtencion, Me)
        Me.Hide() : frmIngresarInsumo.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnAgregarObservacion.Click
        Dim idAtencion As Integer = Convert.ToInt32(Trim(lbl_num_atencion.Text))
        Dim frmAgregarAnotacion As New FRM_AgregarAnotacion(idAtencion, Me)
        Me.Hide() : frmAgregarAnotacion.Show()
    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub frm_Registrar_Atencion_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X : ey = e.Y : Arrastre = True
    End Sub

    Private Sub frm_Registrar_Atencion_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub pbOpcion_MouseEnter(sender As Object, e As EventArgs) Handles pbOpcion.MouseEnter
        Select Case _modoOpcion
            Case "descripcion" : pbOpcion.Image = My.Resources.DESCRIPCION_DESTACADO
            Case "detalles" : pbOpcion.Image = My.Resources.DETALLE_DESTACADO
            Case "observaciones" : pbOpcion.Image = My.Resources.OBSERVACIONES_DESTACADO
        End Select
    End Sub

    Private Sub pbOpcion_MouseLeave(sender As Object, e As EventArgs) Handles pbOpcion.MouseLeave
        Select Case _modoOpcion
            Case "descripcion" : pbOpcion.Image = My.Resources.DESCRIPCION
            Case "detalles" : pbOpcion.Image = My.Resources.DETALLES
            Case "observaciones" : pbOpcion.Image = My.Resources.OBSERVACIONES
        End Select
    End Sub

    Private Sub pbOpcion_Click(sender As Object, e As EventArgs) Handles pbOpcion.Click
        If _modoOpcion = "descripcion" Then
            _modoOpcion = "detalles" : pbOpcion.Image = My.Resources.DETALLES
            panelDescripcion.Visible = False
            panelAgregados.Left = 0 : panelAgregados.Top = 192
            panelAgregados.Height = 440 : panelAgregados.Width = 570
            panelAgregados.Visible = True
        Else
            If _modoOpcion = "detalles" Then
                _modoOpcion = "observaciones" : pbOpcion.Image = My.Resources.OBSERVACIONES
                panelAgregados.Visible = False
                panelAparte.Left = 0 : panelAparte.Top = 192
                panelAparte.Height = 440 : panelAparte.Width = 570
                panelAparte.Visible = True
            Else
                If _modoOpcion = "observaciones" Then
                    _modoOpcion = "descripcion" : pbOpcion.Image = My.Resources.DESCRIPCION
                    panelAparte.Visible = 0 : panelDescripcion.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub frm_Registrar_Atencion_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(x:=MousePosition.X - Me.Location.X - ex, y:=MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub lstAgregados_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lstAgregados.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = lstAgregados.Columns(e.ColumnIndex).Width
    End Sub

    Private Sub lstObservaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObservaciones.SelectedIndexChanged
        Dim i As Integer = lstObservaciones.FocusedItem.Index
        If i <> -1 Then
            Dim tipo As String = lstObservaciones.Items(i).SubItems(0).Text
            If tipo = "N" Then
                rtbOb.Text = lstObservaciones.Items(i).SubItems(1).Text
            Else
                Dim numObservacion As Integer = Convert.ToInt32(Trim(lstObservaciones.Items(i).SubItems(0).Text))
                Dim observacion As New Observacion : Dim bsnObservacion As New BsnObservacion
                observacion = bsnObservacion.GetDatosObservacion(numObservacion)
                rtbOb.Text = Trim(lstObservaciones.Items(i).SubItems(2).Text)
            End If
        End If
    End Sub

    Private Sub txt_costo_MouseLeave(sender As Object, e As EventArgs)
        Dim convertir As New Convertir
        lblCosto.Text = convertir.CorregirDinero(lblCosto.Text)
    End Sub

    Private Sub lblCosto_TextChanged(sender As Object, e As EventArgs) Handles lblCosto.TextChanged
        lblDetalleTotal.Text = lblCosto.Text
    End Sub

    Private Sub lblDetalleTotal_TextChanged(sender As Object, e As EventArgs) Handles lblDetalleTotal.TextChanged
        lblCosto.Text = lblDetalleTotal.Text
    End Sub

    Private Sub btnModificarVacuna_Click(sender As Object, e As EventArgs) Handles btnModificarVacuna.Click
        Dim indice As Integer = Convert.ToInt32(Trim(lblIndice.Text))
        lstAgregados.Items(indice).SubItems(0).Text = "V"
        lstAgregados.Items(indice).SubItems(1).Text = lblCodVacuna.Text

        Dim nor As Integer = cmbNOrdinal.SelectedIndex : Dim norS As String = ""
        Select Case nor
            Case 0 : norS = ""
            Case 1 : norS = "1° "
            Case 2 : norS = "2° "
            Case 3 : norS = "3° "
            Case 4 : norS = "4° "
        End Select

        lstAgregados.Items(indice).SubItems(2).Text = norS & Trim(lblNomVacuna.Text)
        Dim detalle As String = "{0,-7}{1,-10}"
        Dim fecha As String = Format(dtpProxVacuna.Value, "yyyy/MM/dd")
        If cbSinFecha.Checked = True Then
            fecha = "0000-00-00"
        End If
        lstAgregados.Items(indice).SubItems(3).Text = String.Format(detalle, txtDosis.Text, fecha)
        Dim convertir As New Convertir
        lstAgregados.Items(indice).SubItems(4).Text = convertir.CorregirDinero(txtPrecioVacuna.Text)
        ActualizarTotal()
        LimpiarSubPanelVacuna() : panelVacunas.Visible = False : lblIndice.Text = ""
    End Sub

    Private Sub btnEliminarVacuna_Click(sender As Object, e As EventArgs) Handles btnEliminarVacuna.Click
        Dim indice As Integer = Convert.ToInt32(Trim(lblIndice.Text))
        lstAgregados.Items(indice).Remove()
        ActualizarTotal()
        LimpiarSubPanelVacuna() : panelVacunas.Visible = False : lblIndice.Text = ""
    End Sub

    Sub LimpiarSubPanelVacuna()
        lblCodVacuna.Text = "" : cmbNOrdinal.SelectedIndex = -1 : lblNomVacuna.Text = ""
        txtDosis.Text = "" : dtpProxVacuna.Value = System.DateTime.Today : txtPrecioVacuna.Text = ""
    End Sub

    Private Sub btnEliminarInsumo_Click(sender As Object, e As EventArgs) Handles btnEliminarInsumo.Click
        Dim indice As Integer = Convert.ToInt32(Trim(lblIndice.Text))
        lstAgregados.Items(indice).Remove()
        ActualizarTotal()
        LimpiarSubPanelInsumo() : panelInsumos.Visible = False : lblIndice.Text = ""
    End Sub

    Sub LimpiarSubPanelInsumo()
        lblCodInsumo.Text = "" : lblNomInsumo.Text = "" : txtCantidadInsumo.Text = ""
        txtPrecioInsumo.Text = ""
    End Sub

    Private Sub btnModificarInsumo_Click(sender As Object, e As EventArgs) Handles btnModificarInsumo.Click
        Dim indice As Integer = Convert.ToInt32(Trim(lblIndice.Text)) : Dim convertir As New Convertir
        lstAgregados.Items(indice).SubItems(0).Text = "I"
        lstAgregados.Items(indice).SubItems(1).Text = lblCodInsumo.Text
        lstAgregados.Items(indice).SubItems(2).Text = lblNomInsumo.Text

        Dim codProducto As Integer = Convert.ToInt32(Trim(lblCodInsumo.Text))
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(codProducto)
        txtPrecioInsumo.Text = convertir.CorregirDinero(txtPrecioInsumo.Text)

        If producto.Unidad = "ML" Then
            lstAgregados.Items(indice).SubItems(3).Text = txtCantidadInsumo.Text.Replace(",", ".")
            lstAgregados.Items(indice).SubItems(4).Text = txtPrecioInsumo.Text
        Else
            Dim detalle As String = "{0,-4}{1,-8}"
            Dim cantidad As Integer = Convert.ToInt32(Trim(txtCantidadInsumo.Text))
            Dim precio As Integer = convertir.dinero_a_numero(txtPrecioInsumo.Text)
            lstAgregados.Items(indice).SubItems(3).Text = String.Format(detalle, cantidad, precio)
            lstAgregados.Items(indice).SubItems(4).Text = convertir.convertir_dinero(precio * cantidad)
        End If
        ActualizarTotal()
        LimpiarSubPanelInsumo() : panelInsumos.Visible = False : lblIndice.Text = ""
    End Sub

    Private Sub cbSinFecha_CheckedChanged(sender As Object, e As EventArgs) Handles cbSinFecha.CheckedChanged
        If cbSinFecha.Checked = False Then
            dtpProxVacuna.Visible = True : lblProx.Visible = True
        Else
            dtpProxVacuna.Visible = False : lblProx.Visible = True : lblProx.Text = "No establecer fecha."
        End If
    End Sub

    Private Sub btnAgregarCosto_Click(sender As Object, e As EventArgs) Handles btnAgregarCosto.Click
        subpanelCostos.Top = 0 : subpanelCostos.Left = 0 : subpanelCostos.Width = 544 : subpanelCostos.Height = 122
        btnAceptarCosto.Visible = True : btnCancelarCosto.Visible = True
        subpanelCostos.Visible = True : panelVacunas.Visible = False : panelInsumos.Visible = False
        txtDescCosto.Text = "" : txtCostoCosto.Text = ""
        txtDescCosto.Focus() : txtDescCosto.BackColor = Color.Yellow
        _modoCosto = "agregar" : btnAceptarCosto.Text = "AGREGAR" : btnCancelarCosto.Text = "CANCELAR"
    End Sub

    Private Sub txtDescCosto_Leave(sender As Object, e As EventArgs) Handles txtDescCosto.Leave
        txtDescCosto.BackColor = Color.White
    End Sub

    Private Sub btnAceptarCosto_Click(sender As Object, e As EventArgs) Handles btnAceptarCosto.Click
        If Trim(txtDescCosto.Text) = "" Then
            MsgBox("Debe ingresar una descripcion")
            Exit Sub
        End If
        Dim convertir As New Convertir
        txtCostoCosto.Text = convertir.CorregirDinero(txtCostoCosto.Text)
        If txtCostoCosto.Text = "$0" Then
            MsgBox("Debe ingresar un valor para el costo.")
            Exit Sub
        End If
        Select Case _modoCosto
            Case "agregar"
                With lstAgregados.Items.Add("C")
                    .SubItems.Add("")
                    .SubItems.Add(Trim(txtDescCosto.Text))
                    .SubItems.Add("")
                    .SubItems.Add(txtCostoCosto.Text)
                End With
            Case "modificar"
                Dim indice As Integer = Convert.ToInt32(Trim(lblIndice.Text))
                lstAgregados.Items(indice).SubItems(2).Text = Trim(txtDescCosto.Text)
                lstAgregados.Items(indice).SubItems(4).Text = txtCostoCosto.Text
        End Select
        ActualizarTotal()
        subpanelCostos.Visible = False : txtDescCosto.Text = "" : txtCostoCosto.Text = "" : lblIndice.Text = ""
    End Sub

    Private Sub btnCancelarCosto_Click(sender As Object, e As EventArgs) Handles btnCancelarCosto.Click
        Select Case _modoCosto
            Case "agregar"
                txtDescCosto.Text = "" : txtCostoCosto.Text = ""
            Case "modificar"
                Dim indice As Integer = Convert.ToInt32(Trim(lblIndice.Text))
                lstAgregados.Items(indice).Remove()
                txtDescCosto.Text = "" : txtCostoCosto.Text = "" : lblIndice.Text = ""
        End Select
        subpanelCostos.Visible = False
    End Sub

    Private Sub txt_peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_peso.KeyPress
        If (Asc(e.KeyChar) <> 8) Then 'borrar
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_altura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_altura.KeyPress
        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txt_altura.Text.Length
            While i < lg And encontrado = False
                If txt_altura.Text.Chars(i) = "." Or txt_altura.Text.Chars(i) = "," Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 44) Then ' coma
            If (Asc(e.KeyChar) <> 46) Then ' punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_temperatura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_temperatura.KeyPress
        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txt_temperatura.Text.Length
            While i < lg And encontrado = False
                If txt_temperatura.Text.Chars(i) = "." Or txt_temperatura.Text.Chars(i) = "," Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 44) Then ' coma
            If (Asc(e.KeyChar) <> 46) Then ' punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtPrecioInsumo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioInsumo.KeyPress
        If (Asc(e.KeyChar) <> 36) Then
            If (Asc(e.KeyChar) <> 46) Then 'punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidadInsumo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadInsumo.KeyPress
        Dim codProducto As Integer = Convert.ToInt32(Trim(lblCodInsumo.Text))
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(codProducto)

        Dim caracter As Char = e.KeyChar
        If producto.Unidad = "UN" Then
            If caracter = "." Or caracter = "," Then
                e.Handled = True
            End If
        Else
            Dim encontrado As Boolean = False
            If caracter = "." Or caracter = "," Then
                Dim i As Integer = 0 : Dim lg As Integer = txtCantidadInsumo.Text.Length
                While i < lg And encontrado = False
                    If txtCantidadInsumo.Text.Chars(i) = "." Or txtCantidadInsumo.Text.Chars(i) = "," Then
                        e.Handled = True : encontrado = True
                    End If
                    i = i + 1
                End While
            End If
        End If

        If (Asc(e.KeyChar) <> 44) Then  'coma
            If (Asc(e.KeyChar) <> 46) Then 'punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtDosis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDosis.KeyPress
        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txtDosis.Text.Length
            While i < lg And encontrado = False
                If txtDosis.Text.Chars(i) = "." Or txtDosis.Text.Chars(i) = "," Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 44) Then ' coma
            If (Asc(e.KeyChar) <> 46) Then ' punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txtPrecioVacuna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioVacuna.KeyPress
        If (Asc(e.KeyChar) <> 36) Then 'signo peso
            If (Asc(e.KeyChar) <> 46) Then 'punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtCostoCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoCosto.KeyPress
        If (Asc(e.KeyChar) <> 36) Then 'signo peso
            If (Asc(e.KeyChar) <> 46) Then 'punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub rtb_descripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtb_descripcion.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescCosto.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnEliminarObservacion_Click(sender As Object, e As EventArgs) Handles btnEliminarObservacion.Click
        Dim index As Integer = 0
        Try
            index = lstObservaciones.FocusedItem.Index
        Catch ex As Exception
            MsgBox(" Para eliminar una observación debe seleccionarla.") : Exit Sub
        End Try

        If MessageBox.Show("¿Esta seguro que desea eliminar esta observación.?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim opcion As String = Trim(lstObservaciones.Items(index).SubItems(0).Text)
            If opcion <> "N" Then
                With lstPendientes.Items.Add("E")
                    .SubItems.Add(Trim(lstObservaciones.Items(index).SubItems(0).Text))
                End With
            End If
            lstObservaciones.Items(index).Remove()
            MsgBox("La observación ha sido eliminada. Para guardar todos los cambios recuerde REGISTRAR la atención.")
            rtbOb.Text = ""
        End If
    End Sub

    Private Sub btnModificarObservacion_Click(sender As Object, e As EventArgs) Handles btnModificarObservacion.Click
        Dim index As Integer = 0
        Try
            index = lstObservaciones.FocusedItem.Index
        Catch ex As Exception
            MsgBox(" Para modificar una observación debe seleccionarla.") : Exit Sub
        End Try

        lstObservaciones.Items(index).SubItems(2).Text = rtbOb.Text

        Dim opcion As String = Trim(lstObservaciones.Items(index).SubItems(0).Text)
        If opcion <> "N" Then
            With lstPendientes.Items.Add("M")
                .SubItems.Add(Trim(lstObservaciones.Items(index).SubItems(0).Text))
                .SubItems.Add(Trim(rtbOb.Text))
            End With
        End If

        MsgBox("La observación ha sido modificada. Para guardar todos los cambios recuerde REGISTRAR la atención.")
        rtbOb.Text = ""
    End Sub

    Private Sub txt_altura_Leave(sender As Object, e As EventArgs) Handles txt_altura.Leave
        txt_altura.BackColor = Color.White
    End Sub

    Private Sub txt_temperatura_Leave(sender As Object, e As EventArgs) Handles txt_temperatura.Leave
        txt_temperatura.BackColor = Color.White
    End Sub

    Private Sub lstAgregados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAgregados.SelectedIndexChanged
        Dim indice As Integer
        indice = lstAgregados.FocusedItem.Index
        lblIndice.Text = indice

        If indice <> -1 Then
            Dim tipo As String = lstAgregados.Items(indice).SubItems(0).Text
            Dim convertir As New Convertir

            Select Case tipo
                Case "I"
                    panelInsumos.Width = 544 : panelInsumos.Height = 122
                    panelInsumos.Top = 0 : panelInsumos.Left = 0 : panelInsumos.Visible = True
                    panelVacunas.Visible = False : subpanelCostos.Visible = False
                    lblCodInsumo.Text = lstAgregados.Items(indice).SubItems(1).Text

                    Dim producto As New Producto : Dim bsnProducto As New BsnProductos
                    producto = bsnProducto.GetDatosProducto(Trim(lblCodInsumo.Text))

                    If producto.Unidad = "ML" Then
                        txtCantidadInsumo.Text = Trim(lstAgregados.Items(indice).SubItems(3).Text)
                        txtPrecioInsumo.Text = Trim(lstAgregados.Items(indice).SubItems(4).Text)
                    Else
                        txtCantidadInsumo.Text = Trim(lstAgregados.Items(indice).SubItems(3).Text.Substring(0, 4))
                        txtPrecioInsumo.Text = convertir.convertir_dinero(Convert.ToInt32(Trim(lstAgregados.Items(indice).SubItems(3).Text.Substring(4, 8))))
                    End If
                    lblNomInsumo.Text = lstAgregados.Items(indice).SubItems(2).Text
                Case "C"
                    subpanelCostos.Top = 0 : subpanelCostos.Left = 0 : subpanelCostos.Visible = True
                    subpanelCostos.Width = 544 : subpanelCostos.Height = 122
                    panelInsumos.Visible = False : panelVacunas.Visible = False
                    txtDescCosto.Text = lstAgregados.Items(indice).SubItems(2).Text
                    txtCostoCosto.Text = lstAgregados.Items(indice).SubItems(4).Text
                    _modoCosto = "modificar" : btnAceptarCosto.Text = "MODIFICAR" : btnCancelarCosto.Text = "ELIMINAR"

                Case "V"
                    panelVacunas.Width = 544 : panelVacunas.Height = 122
                    panelVacunas.Top = 0 : panelVacunas.Left = 0 : panelVacunas.Visible = True
                    panelInsumos.Visible = False : subpanelCostos.Visible = False
                    lblCodVacuna.Text = lstAgregados.Items(indice).SubItems(1).Text

                    '//////identificar si hay ordinal
                    Dim textNom As String = lstAgregados.Items(indice).SubItems(2).Text
                    Dim simbolo As String = textNom.Substring(0, 2)
                    Select Case simbolo
                        Case "1°"
                            cmbNOrdinal.SelectedIndex = 1
                            lblNomVacuna.Text = textNom.Substring(2, textNom.Length - 2)
                        Case "2°"
                            cmbNOrdinal.SelectedIndex = 2
                            lblNomVacuna.Text = textNom.Substring(2, textNom.Length - 2)
                        Case "3°"
                            cmbNOrdinal.SelectedIndex = 3
                            lblNomVacuna.Text = textNom.Substring(2, textNom.Length - 2)
                        Case "4°"
                            cmbNOrdinal.SelectedIndex = 4
                            lblNomVacuna.Text = textNom.Substring(2, textNom.Length - 2)
                        Case Else
                            cmbNOrdinal.SelectedIndex = 0
                            lblNomVacuna.Text = textNom.Substring(0, textNom.Length)
                    End Select
                    '//////////////
                    txtDosis.Text = Trim(lstAgregados.Items(indice).SubItems(3).Text.Substring(0, 5))
                    Dim fecha As String = lstAgregados.Items(indice).SubItems(3).Text.Substring(7, 10)
                    If fecha = "0000-00-00" Then
                        cbSinFecha.Checked = True : dtpProxVacuna.Visible = False
                        lblProx.Visible = True : lblProx.Text = "No establecer fecha."
                    Else
                        dtpProxVacuna.Value = fecha
                    End If
                    txtPrecioVacuna.Text = Trim(lstAgregados.Items(indice).SubItems(4).Text)
            End Select
        End If
    End Sub

End Class
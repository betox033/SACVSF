Imports System.IO
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports MySql.Data.MySqlClient

Public Class FRM_Perfil

    Protected _mascota As Mascota
    Protected _cliente As Cliente
    Protected _frmMantenedorMascotas As frm_Mantenedor_Mascotas
    Protected _modalidad As String = ""
    Protected _frmCalendario As frm_Calendario
    Protected _frmAgregarAnotacion As New FRM_AgregarAnotacion


    Dim detalle As String = "{0, -10}{1, -12}"
    Dim detalle2 As String = "{0, -9}{1, -12}{2, -30}"




    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mascota As Mascota, cliente As Cliente, frmMantenedorMascotas As frm_Mantenedor_Mascotas)
        _mascota = mascota
        _cliente = cliente
        _frmMantenedorMascotas = frmMantenedorMascotas
        _modalidad = "MantenedorMascotas"
        InitializeComponent()
    End Sub

    Public Sub New(mascota As Mascota, cliente As Cliente, frmCalendario As frm_Calendario)
        _mascota = mascota
        _cliente = cliente
        _frmCalendario = frmCalendario
        _modalidad = "Calendario"
        InitializeComponent()
    End Sub

    Public Sub New(mascota As Mascota, cliente As Cliente, frmAgregarAnotacion As FRM_AgregarAnotacion)
        _mascota = mascota
        _cliente = cliente
        _frmAgregarAnotacion = frmAgregarAnotacion
        _modalidad = "agregarAnotacion"
        InitializeComponent()
    End Sub


    Private Sub FRM_Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelAtenciones.BackColor = Color.FromArgb(150, 255, 255, 255)
        panelVacunas.BackColor = Color.FromArgb(150, 255, 255, 255)
        panelTitulo.BackColor = Color.FromArgb(170, 0, 0, 0)
        panelDatos.BackColor = Color.FromArgb(200, 218, 165, 32)
        panelObservaciones.BackColor = Color.FromArgb(150, 255, 255, 255)
        panelHosp.BackColor = Color.FromArgb(150, 255, 255, 255)
        panelDescripcionAtencion.Top = 51 : panelDescripcionAtencion.Left = 344
        panelDescripcionAtencion.Width = 507 : panelDescripcionAtencion.Height = 272
        LlenarDatos(_mascota)
        cargar_atenciones() : LimpiarPanelAtencion()
        cargar_vacunas() : LimpiarPanelVacunas()
        VaciarPaneles()
        CargarObservaciones() : LimpiarPanelObservacion()
        CargarHospitalizaciones() : lblIdHosp.Text = ""
    End Sub

    Sub CargarHospitalizaciones()
        Dim listHospi As New List(Of Hospitalizacion) : Dim bsnHosp As New BsnHospitalizacion
        listHospi = bsnHosp.GetHospMascota(_mascota.IdFicha)
        For Each hosp As Hospitalizacion In listHospi
            With lstHosp.Items.Add(hosp.IdHosp)
                .SubItems.Add(hosp.FechaHosp)
                .SubItems.Add(hosp.FechaSalida)
            End With
        Next
    End Sub

    Sub CargarObservaciones()
        lstObservaciones.Items.Clear()
        Dim listaObservaciones As New List(Of Observacion) : Dim bsnObservacion As New BsnObservacion
        listaObservaciones = bsnObservacion.GetObservaciones(_mascota.IdFicha)
        For Each observacion As Observacion In listaObservaciones
            With lstObservaciones.Items.Add(observacion.NumObservacion)
                .SubItems.Add(observacion.FechaObservacion)
            End With
        Next
    End Sub

    Function VaciarPaneles()
        lbl_pa_fecha.Text = "" : lbl_pa_veterinario.Text = "" : lbl_pa_tipo.Text = ""
        lbl_pa_peso.Text = "" : lbl_pa_altura.Text = "" : lbl_pa_temperatura.Text = ""
        lbl_pa_costo.Text = ""

        lbl_num_vacuna.Text = "" : lbl_nom_vacuna.Text = "" : lbl_fecha_vacuna.Text = "" : lbl_prox_vacuna.Text = ""
        Return 0
    End Function

    Sub LlenarDatos(mascota As Mascota)
        lbl_numero.Text = _mascota.IdFicha : lbl_nombre.Text = _mascota.NomMascota
        If mascota.Sexo = "M" Then
            lbl_sexo.Text = "MASCULINO"
        Else
            lbl_sexo.Text = "FEMENINO"
        End If
        lblFechaIngreso.Text = mascota.FechaIngreso
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
        lbl_cliente.Text = cliente.Nombre : lbl_color.Text = mascota.Color : lblIdChip.Text = mascota.IdChip

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

    Sub cargar_vacunas()
        lstVacunas.Items.Clear()
        Dim listaVacunas As New List(Of Vacuna) : Dim bsnVacuna As New BsnVacuna
        listaVacunas = bsnVacuna.GetVacunas(_mascota.IdFicha)
        For Each vacuna As Vacuna In listaVacunas
            With lstVacunas.Items.Add(vacuna.NumVacuna)
                .SubItems.Add(vacuna.FechaVacuna)
                Dim cadVacuna As String = ""
                Dim producto As New Producto : Dim bsnProducto As New BsnProductos
                producto = bsnProducto.GetDatosProducto(vacuna.Codproducto)

                If vacuna.NOrdinal = 0 Then
                    cadVacuna = producto.NomProducto
                Else
                    cadVacuna = vacuna.NOrdinal & "° " & producto.NomProducto
                End If
                .SubItems.Add(cadVacuna)
            End With
        Next
    End Sub

    Sub cargar_atenciones()
        panelDescripcionAtencion.Top = 51 : panelDescripcionAtencion.Left = 344
        panelDescripcionAtencion.Width = 507 : panelDescripcionAtencion.Height = 272

        lst_atenciones.Items.Clear()
        Dim listaAtenciones As New List(Of Atencion) : Dim bsnAtencion As New BsnAtencion
        listaAtenciones = bsnAtencion.GetAtencionesMascota(_mascota.IdFicha)

        For Each atencion As Atencion In listaAtenciones
            If atencion.TipoAtencion = "R" And atencion.Estado = True Then
                lst_atenciones.Items.Add(String.Format(detalle, atencion.CodAtencion, atencion.FechaAtencion))
            End If
        Next
    End Sub

    Private Sub lst_atenciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_atenciones.SelectedIndexChanged
        Dim fila As Int32 = lst_atenciones.SelectedIndex

        lbl_pa_fecha.Text = "" : lbl_pa_veterinario.Text = "" : lbl_pa_peso.Text = "" : lbl_pa_peso.Text = "" : lbl_pa_altura.Text = ""
        lbl_pa_temperatura.Text = "" : lbl_pa_tipo.Text = "" : lbl_pa_costo.Text = ""

        If fila <> -1 Then
            Dim cadena As String = ""
            cadena = lst_atenciones.SelectedItem
            Dim cod_atencion As Integer = Convert.ToInt32((Trim(cadena.Substring(0, 8))))
            CargarDatosAtencion(cod_atencion)
            CargarCostosAtencion(cod_atencion)
        End If
    End Sub

    Sub CargarCostosAtencion(cod_atencion As Integer)
        Dim bloque As New BloqueCodigo : bloque.FormatoDecimalPunto()

        Dim listaCostos As New List(Of Costo) : Dim bsnCosto As New BsnCosto
        listaCostos = bsnCosto.GetCostosAtencion(cod_atencion)
        Dim desc As String = "" : Dim cos As String = "" : Dim convertir As New Convertir
        lstCostos.Items.Clear()
        For Each costo As Costo In listaCostos
            Dim tipo As String = costo.Descripcion.Substring(0, 3)
            If tipo = "***" Then
                Dim subT As String = costo.Descripcion.Substring(3, 1)
                Dim codProducto As Integer = Convert.ToInt32(Trim(costo.Descripcion.Substring(4, 4)))
                Dim producto As New Producto : Dim bsnProducto As New BsnProductos
                producto = bsnProducto.GetDatosProducto(codProducto)
                Select Case subT
                    Case "V"
                        Dim n As Integer = Convert.ToInt32(Trim(costo.Descripcion.Substring(8, 1)))
                        If n = 0 Then
                            desc = producto.NomProducto
                        Else
                            desc = n & "° " & producto.NomProducto
                        End If
                    Case "I"
                        desc = producto.NomProducto
                        Dim cantidad As Double = Convert.ToDouble(Trim(costo.Descripcion.Substring(8, 6)))
                        Dim p As Integer = Convert.ToInt32(Trim(costo.Descripcion.Substring(14, 6)))
                        desc = desc & "   " & cantidad & "X" & convertir.convertir_dinero(p)
                End Select
            Else
                desc = costo.Descripcion
            End If
            cos = convertir.convertir_dinero(costo.Costo)
            With lstCostos.Items.Add(desc)
                .SubItems.Add(cos)
            End With
        Next
    End Sub

    Sub CargarDatosAtencion(cod_atencion As Integer)
        lbl_cod_atencion.Text = cod_atencion

        Dim atencion As New Atencion : Dim bsnAtencion As New BsnAtencion : atencion = bsnAtencion.GetDatosAtencion(cod_atencion)
        rtb_detalle_atencion.Text = atencion.Descripcion
        lbl_pa_fecha.Text = atencion.FechaAtencion
        lbl_pa_tipo.Text = atencion.TipoAtencion

        Dim peso As Integer = atencion.Peso
        Dim altura As Double = atencion.Altura
        Dim temperatura As Double = atencion.Temperatura

        If peso = 0 Then
            lbl_pa_peso.Text = "-"
        Else
            lbl_pa_peso.Text = peso & "gr"
        End If

        If altura = 0 Then
            lbl_pa_altura.Text = "-"
        Else
            lbl_pa_altura.Text = altura & "m"
        End If

        If temperatura = 0 Then
            lbl_pa_temperatura.Text = "-"
        Else
            lbl_pa_temperatura.Text = temperatura & "°"
        End If

        Dim costo As Integer = atencion.Costo : Dim convertir As New Convertir
        If costo = 0 Then
            lbl_pa_costo.Text = "-"
        Else
            lbl_pa_costo.Text = convertir.convertir_dinero(costo)
        End If

        Dim veterinario As New Veterinario : Dim bsnVeterinario As New BsnVeterinario
        veterinario = bsnVeterinario.GetDatosVeterinario(atencion.NumVeterinario)
        lbl_pa_num_veterinario.Text = veterinario.NumVeterinario
        lbl_pa_veterinario.Text = veterinario.NomVeterinario
    End Sub

    Sub LimpiarPanelVacunas()
        lbl_num_vacuna.Text = "" : lbl_nom_vacuna.Text = "" : lblDosisVacuna.Text = ""
        lbl_fecha_vacuna.Text = "" : lbl_prox_vacuna.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If _modalidad = "MantenedorMascotas" Then
            _frmMantenedorMascotas.Show()
        End If
        If _modalidad = "Calendario" Then
            _frmCalendario.Show()
        End If
        If _modalidad = "agregarAnotacion" Then
            _frmAgregarAnotacion.Show()
        End If
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btnAtenciones_Click(sender As Object, e As EventArgs) Handles btnAtenciones.Click
        panelAtenciones.Height = 377
        panelAtenciones.Width = 892
        panelAtenciones.Left = 0
        panelAtenciones.Top = 0

        If panelAtenciones.Visible = True Then
            panelAtenciones.Visible = False
        Else
            panelAtenciones.Visible = True
            panelVacunas.Visible = False : panelObservaciones.Visible = False : panelHosp.Visible = False
        End If
    End Sub

    Private Sub btnVacunas_Click(sender As Object, e As EventArgs) Handles btnVacunas.Click
        panelVacunas.Height = 377
        panelVacunas.Width = 892
        panelVacunas.Left = 0
        panelVacunas.Top = 0

        If panelVacunas.Visible = True Then
            panelVacunas.Visible = False
        Else
            panelVacunas.Visible = True
            panelAtenciones.Visible = False : panelObservaciones.Visible = False : panelHosp.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lst_atenciones.SelectedIndex = -1 Then
            MsgBox("Para modificar debe seleccionar una atencion de la lista")
        Else
            Dim idAtencion As Integer = Convert.ToInt32(Trim(lbl_cod_atencion.Text))
            Dim atencion As New Atencion : Dim bsnAtencion As New BsnAtencion
            atencion = bsnAtencion.GetDatosAtencion(idAtencion)
            Dim frmModificarAtencion As New FRM_ModificarAtencion(Me, atencion)
            frmModificarAtencion.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pb_pdf_atencion_Click_1(sender As Object, e As EventArgs) Handles pb_pdf_atencion.Click
        If lbl_cod_atencion.Text = "" Then
            MsgBox("Debe seleccionar una atención para generar un archivo PDF.")
            Exit Sub
        End If

        Dim codAtencion As Integer = Convert.ToInt32(Trim(lbl_cod_atencion.Text))
        Dim atencion As New Atencion : Dim bsnAtencion As New BsnAtencion
        atencion = bsnAtencion.GetDatosAtencion(codAtencion)
        Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota
        mascota = bsnMascota.GetDatosMascota(atencion.IdFicha)
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente
        cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)

        Dim frmPrevisualizar As New FRM_Previsualizar(atencion, mascota, cliente, Me)
        Me.Hide()
        frmPrevisualizar.Show()
    End Sub

    Private Sub lstObservaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObservaciones.SelectedIndexChanged
        Dim i As Integer = lstObservaciones.FocusedItem.Index

        If i <> -1 Then
            Dim numObservacion As Integer = Convert.ToInt32(Trim(lstObservaciones.Items(i).SubItems(0).Text))
            Dim observacion As New Observacion : Dim bsnObservacion As New BsnObservacion
            observacion = bsnObservacion.GetDatosObservacion(numObservacion)
            lblIdObservacion.Text = observacion.NumObservacion
            rtbObservaciones.Text = observacion.Descripcion
        End If
    End Sub

    Sub LimpiarPanelObservacion()
        lblIdObservacion.Text = "" : rtbObservaciones.Text = ""
        lblCostoHosp.Text = "" : lblTotalHosp.Text = "" : lblValorHosp.Text = "" : lblTotalInsumos.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        panelObservaciones.Height = 374 : panelObservaciones.Width = 644
        panelObservaciones.Top = 0 : panelObservaciones.Left = 128
        If panelObservaciones.Visible = True Then
            panelObservaciones.Visible = False
        Else
            panelObservaciones.Visible = True
            panelAtenciones.Visible = False : panelVacunas.Visible = False : panelHosp.Visible = False
        End If
    End Sub

    Private Sub btnHospGeneral_Click(sender As Object, e As EventArgs) Handles btnHospGeneral.Click
        panelHosp.Top = 0 : panelHosp.Left = 32
        panelHosp.Width = 782 : panelHosp.Height = 380
        panelInfoHosp.Top = 50 : panelInfoHosp.Left = 414
        panelInfoHosp.Width = 371 : panelInfoHosp.Height = 261
        If panelHosp.Visible = True Then
            panelHosp.Visible = False
        Else
            panelHosp.Visible = True
            panelAtenciones.Visible = False : panelObservaciones.Visible = False : panelVacunas.Visible = False
        End If

    End Sub

    Private Sub lstHosp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHosp.SelectedIndexChanged
        Dim indice As Integer = lstHosp.FocusedItem.Index
        Dim idHosp As Integer = Convert.ToInt32(Trim(lstHosp.Items(indice).SubItems(0).Text))
        lblIdHosp.Text = idHosp
        Dim hosp As New Hospitalizacion : Dim bsnHosp As New BsnHospitalizacion
        hosp = bsnHosp.GetDatosHospitalizacion(idHosp)
        CargarDatosHosp(hosp)

    End Sub

    Sub CargarDatosHosp(hosp As Hospitalizacion)
        Dim convertir As New Convertir
        dtpIngresoHosp.Value = hosp.FechaHosp : dtpSalida.Value = hosp.FechaSalida
        rtbDescHosp.Text = hosp.Descripcion
        Dim suma As Integer = 0
        Dim listaDetalles As New List(Of DetHosp) : Dim bsnDetHosp As New BsnDetHosp
        listaDetalles = bsnDetHosp.GetDetallesHosp(hosp.IdHosp)
        lstDetalleHosp.Items.Clear()
        For Each det As DetHosp In listaDetalles
            Dim producto As New Producto : Dim bsnProducto As New BsnProductos
            producto = bsnProducto.GetDatosProducto(det.CodProducto)
            With lstDetalleHosp.Items.Add(producto.NomProducto)
                .SubItems.Add(det.Periodicidad & " Hrs")
                .SubItems.Add(det.Cantidad)
                .SubItems.Add(convertir.convertir_dinero(det.Precio))
            End With
            suma = suma + det.Precio
        Next
        suma = suma + hosp.Total + hosp.ValorConsulta

        lblTotalInsumos.Text = convertir.convertir_dinero(suma)
        lblTotalHosp.Text = convertir.convertir_dinero(hosp.Total)
        lblValorHosp.Text = convertir.convertir_dinero(hosp.ValorConsulta)

        lblCostoHosp.Text = convertir.convertir_dinero(suma)
    End Sub


    Private Sub pbPDFHosp_MouseEnter(sender As Object, e As EventArgs) Handles pbPDFHosp.MouseEnter
        pbPDFHosp.Image = My.Resources.destacado
    End Sub

    Private Sub pbPDFHosp_MouseLeave(sender As Object, e As EventArgs) Handles pbPDFHosp.MouseLeave
        pbPDFHosp.Image = My.Resources.molde_pdf
    End Sub

    Private Sub pbPDFHosp_Click(sender As Object, e As EventArgs) Handles pbPDFHosp.Click
        If lblIdHosp.Text = "" Then
            MsgBox("Debe seleccionar una hospitalización de la lista.")
            Exit Sub
        End If
        Dim idHosp As Integer = Convert.ToInt32(Trim(lblIdHosp.Text))
        Dim hosp As New Hospitalizacion : Dim bsnHosp As New BsnHospitalizacion : hosp = bsnHosp.GetDatosHospitalizacion(idHosp)
        Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(_mascota.IdCliente)
        Dim frmPDF As New FRM_Previsualizar(hosp, _mascota, cliente, Me)
        frmPDF.Show() : Me.Hide()
    End Sub

    Private Sub btnEliminarHosp_Click(sender As Object, e As EventArgs) Handles btnEliminarHosp.Click
        If lblIdHosp.Text = "" Then
            MsgBox("Debe seleccionar una hospitalización para eliminarla.")
            Exit Sub
        End If

        If MessageBox.Show("¿Esta seguro que desea eliminar esta hospitalización?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim idHosp As Integer = Convert.ToInt32(Trim(lblIdHosp.Text))
            Dim bsnHosp As New BsnHospitalizacion
            Dim encontradoDetalle As Boolean = bsnHosp.ValidarHospitalizacion(idHosp, "hosp_producto")

            If encontradoDetalle = True Then
                MsgBox("No puede eliminar esta hospitalización porque tiene datos asociados.")
            Else
                bsnHosp.EliminarHospFisico(idHosp)
                lstHosp.Items.Clear() : CargarHospitalizaciones()
                MsgBox("La hospitalización ha sido eliminada.")
                LimpiarPanelHosp()
            End If
        End If
    End Sub

    Sub LimpiarPanelHosp()
        lblIdHosp.Text = "" : dtpIngresoHosp.Value = System.DateTime.Today : dtpSalida.Value = System.DateTime.Today
        rtbDescHosp.Text = "" : lblCostoHosp.Text = ""
    End Sub

    Sub LimpiarPanelAtencion()
        lbl_pa_num_veterinario.Text = "" : lbl_cod_atencion.Text = "" : lbl_pa_fecha.Text = ""
        lbl_pa_altura.Text = "" : lbl_pa_costo.Text = "" : lbl_pa_peso.Text = "" : lbl_pa_tipo.Text = ""
        lbl_pa_temperatura.Text = "" : lbl_pa_veterinario.Text = ""
    End Sub

    Private Sub btnEliminarAtencion_Click(sender As Object, e As EventArgs) Handles btnEliminarAtencion.Click
        If lbl_cod_atencion.Text = "" Then
            MsgBox("Debe seleccionar una atención para eliminarla.")
            Exit Sub
        End If

        Dim codAtencion As Integer = Convert.ToInt32(Trim(lbl_cod_atencion.Text))
        If MessageBox.Show("¿Esta seguro que desea eliminar esta atención?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim bsnNegocio As New BsnNegocio : Dim bsnAtencion As New BsnAtencion
            Dim encontrado As Integer = bsnNegocio.ValidarPorNumero("atencion_producto", "cod_atencion", codAtencion)
            Dim validarCosto As Integer = bsnNegocio.ValidarPorNumero("atencion_costo", "cod_atencion", codAtencion)
            If encontrado = -1 And validarCosto = -1 Then
                bsnAtencion.EliminarAtencionFisico(codAtencion)
                MsgBox("La atención ha sido eliminada correctamente.")
                cargar_atenciones()
                LimpiarPanelAtencion()
            Else
                MsgBox("No puede eliminar la atención porque tiene datos asociados.")
            End If
        End If
    End Sub

    Private Sub pb_pdf_atencion_MouseEnter(sender As Object, e As EventArgs) Handles pb_pdf_atencion.MouseEnter
        pb_pdf_atencion.Image = My.Resources.destacado
    End Sub

    Private Sub pb_pdf_atencion_MouseLeave(sender As Object, e As EventArgs) Handles pb_pdf_atencion.MouseLeave
        pb_pdf_atencion.Image = My.Resources.molde_pdf
    End Sub


    Private Sub lstVacunas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVacunas.SelectedIndexChanged
        Dim indice As Integer = lstVacunas.FocusedItem.Index

        Dim numVacuna As Integer = Convert.ToInt32(Trim(lstVacunas.Items(indice).SubItems(0).Text))
        Dim vacuna As New Vacuna : Dim bsnVacuna As New BsnVacuna
        vacuna = bsnVacuna.GetDatosVacuna(numVacuna)
        CargarDatosPanelVacuna(vacuna)
    End Sub

    Sub CargarDatosPanelVacuna(vacuna As Vacuna)
        lbl_num_vacuna.Text = vacuna.NumVacuna
        If vacuna.Dosis = 0 Then
            lblDosisVacuna.Text = "-"
        Else
            lblDosisVacuna.Text = vacuna.Dosis & "ml"
        End If
        lbl_fecha_vacuna.Text = vacuna.FechaVacuna
        If vacuna.FechaProxVacuna = "00/00/0000" Then
            lbl_prox_vacuna.Text = "-"
        Else
            lbl_prox_vacuna.Text = vacuna.FechaProxVacuna
        End If
        Dim producto As New Producto : Dim bsnProducto As New BsnProductos
        producto = bsnProducto.GetDatosProducto(vacuna.Codproducto)
        Dim cadVacuna As String = ""
        If vacuna.NOrdinal = 0 Then
            cadVacuna = producto.NomProducto
        Else
            cadVacuna = vacuna.NOrdinal & "° " & producto.NomProducto
        End If
        lbl_nom_vacuna.Text = cadVacuna

        Dim ruta As String = "../../img/productos/" & producto.CodProducto & ".jpg"
        If File.Exists(ruta) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
            pbMascota.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            pbVacuna.Image = My.Resources.cosa
        End If
    End Sub

    Private Sub btnEliminarVacuna_Click(sender As Object, e As EventArgs) Handles btnEliminarVacuna.Click
        If lbl_num_vacuna.Text = "" Then
            MsgBox("Debe seleccionar una vacuna de la lista para eliminar.")
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro que desea eliminar esta atención?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim numVacuna As Integer = Convert.ToInt32(Trim(lbl_num_vacuna.Text))
            Dim bsnVacuna As New BsnVacuna : bsnVacuna.EliminarVacuna(numVacuna)
            LimpiarPanelVacunas() : cargar_vacunas()
            MsgBox("La vacuna ha sido eliminada correctamente.")
        End If
    End Sub

    Private Sub btnModificarVacuna_Click(sender As Object, e As EventArgs) Handles btnModificarVacuna.Click
        If lbl_num_vacuna.Text = "" Then
            MsgBox("Debe seleccionar una vacuna de la lista para modificar.")
            Exit Sub
        End If
        Dim numVacuna As Integer = Convert.ToInt32(Trim(lbl_num_vacuna.Text))
        Dim vacuna As New Vacuna : Dim bsnVacuna As New BsnVacuna
        vacuna = bsnVacuna.GetDatosVacuna(numVacuna)
        Dim frmAgregarVacuna As New FRM_Agregar_Vacuna(Me, vacuna)
        frmAgregarVacuna.Show()
        Me.Hide()
    End Sub

    Private Sub btnModOb_Click(sender As Object, e As EventArgs) Handles btnModOb.Click
        If lblIdObservacion.Text = "" Then
            MsgBox("Debe seleccionar una observación para modificarla.")
            Exit Sub
        End If

        Dim idObservacion As Integer = Convert.ToInt32(Trim(lblIdObservacion.Text))
        Dim observacion As New Observacion : Dim bsnObservacion As New BsnObservacion
        observacion = bsnObservacion.GetDatosObservacion(idObservacion)
        Dim frmAgregarObservacion As New FRM_AgregarAnotacion(Me, observacion, "modificar")
        frmAgregarObservacion.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliOb_Click(sender As Object, e As EventArgs) Handles btnEliOb.Click
        If lblIdObservacion.Text = "" Then
            MsgBox("Debe seleccionar una observación para eliminar.")
            Exit Sub
        End If

        If MessageBox.Show("¿Esta seguro que desea eliminar esta observación?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim numObservacion As Integer = Convert.ToInt32(Trim(lblIdObservacion.Text))
            Dim bsnOb As New BsnObservacion : bsnOb.EliminarObservacion(numObservacion)
            CargarObservaciones() : lblIdObservacion.Text = "" : rtbObservaciones.Text = ""
            MsgBox("La observación fue eliminada correctamente.")
        End If
    End Sub

    Private Sub btnAgregarObservacion_Click(sender As Object, e As EventArgs) Handles btnAgregarObservacion.Click
        Dim observacion As New Observacion : Dim bsnObservacion As New BsnObservacion
        observacion.NumObservacion = bsnObservacion.GenerarNumeroObservacion()
        observacion.IdFicha = _mascota.IdFicha
        Dim frmAgregarObservacion As New FRM_AgregarAnotacion(Me, observacion, "agregar")
        frmAgregarObservacion.Show() : Me.Hide()
    End Sub

    Private Sub btnOpcionAtencion_Click(sender As Object, e As EventArgs) Handles btnOpcionAtencion.Click
        If panelDescripcionAtencion.Visible = True Then
            panelDescripcionAtencion.Visible = False
            panelCostosAtencion.Top = 51 : panelCostosAtencion.Left = 344
            panelCostosAtencion.Width = 507 : panelCostosAtencion.Height = 272
            panelCostosAtencion.Visible = True
            btnOpcionAtencion.Text = "DETALLES Y COSTOS"
        Else
            panelDescripcionAtencion.Visible = True
            panelCostosAtencion.Visible = False
            btnOpcionAtencion.Text = "DESCRIPCIÓN DE LA ATENCIÓN"
        End If
    End Sub

    Private Sub btnTituloHosp_Click(sender As Object, e As EventArgs) Handles btnTituloHosp.Click
        If panelInfoHosp.Visible = True Then
            panelDetalleHosp.Top = 53 : panelDetalleHosp.Left = 337
            panelDetalleHosp.Width = 444 : panelDetalleHosp.Height = 261
            panelDetalleHosp.Visible = True : panelInfoHosp.Visible = False
        Else
            panelInfoHosp.Visible = True : panelDetalleHosp.Visible = False
        End If

    End Sub

    Private Sub pbInformeGeneral_MouseEnter(sender As Object, e As EventArgs) Handles pbInformeGeneral.MouseEnter
        pbInformeGeneral.Image = My.Resources.gdpc_destacado
    End Sub

    Private Sub pbInformeGeneral_MouseLeave(sender As Object, e As EventArgs) Handles pbInformeGeneral.MouseLeave
        pbInformeGeneral.Image = My.Resources.gdpc
    End Sub

    Private Sub pbInformeGeneral_Click(sender As Object, e As EventArgs) Handles pbInformeGeneral.Click
        Dim m As New Mascota : m = _mascota : Dim c As New Cliente : Dim bsnCliente As New BsnCliente
        c = bsnCliente.GetDatosCliente(m.IdCliente)

        Dim listaAtenciones As New List(Of Atencion) : Dim bsnAtencion As New BsnAtencion
        listaAtenciones = bsnAtencion.GetAtencionesMascota(m.IdFicha)
        Dim listaHosp As New List(Of Hospitalizacion) : Dim bsnHosp As New BsnHospitalizacion
        listaHosp = bsnHosp.GetHospMascota(m.IdFicha)
        Dim listaVacunas As New List(Of Vacuna) : Dim bsnVacuna As New BsnVacuna
        listaVacunas = bsnVacuna.GetVacunas(m.IdFicha)

        Dim frmGenerarPDF As New FRM_Previsualizar(m, c, Me, listaAtenciones, listaHosp, listaVacunas)
        frmGenerarPDF.Show() : Me.Hide()
    End Sub

End Class
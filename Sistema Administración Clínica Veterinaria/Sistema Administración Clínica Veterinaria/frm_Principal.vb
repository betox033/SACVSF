Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class frm_Principal

    Dim modoVista As Boolean = True
    Dim vistaPanel As Integer = 1

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNumMascotas.Text = contar("mascota") : lblNumClientes.Text = contar("cliente") : lblNumProductos.Text = contar("producto")
        lblNumVentas.Text = contar("venta") : lblNumAtenciones.Text = contar("atencion") : AtencionesPerdidas()
        ContarAtencionesAgendadas() : EnviarCorreos() : lblFecha.Text = System.DateTime.Today
        ContarProductosBajoStock()

        panelPresentacion.BackColor = Color.FromArgb(170, 0, 0, 0) : btn_salir.BackColor = Color.FromArgb(200, 0, 64, 64)
        panelSuplente.BackColor = Color.FromArgb(64, 0, 64, 64) : panelSuplente2.BackColor = Color.FromArgb(64, 0, 64, 64)
        panelSuplente.Width = 459 : panelSuplente.Height = 467 : panelSuplente.Top = 33 : panelSuplente.Left = 360
    End Sub

    Sub ContarProductosBajoStock()
        Dim listaProductos As New List(Of Producto) : Dim bsnProducto As New BsnProductos
        listaProductos = bsnProducto.GetProductos("cod_producto")
        Dim contador As Integer = 0

        For Each producto As Producto In listaProductos
            If producto.Unidad = "ML" Then
                Dim stock As New Stock : stock = bsnProducto.GetDatosStock(producto.CodProducto)
                If stock.NumFrascos < 2 And stock.CantActual < stock.CantTotal Then
                    contador = contador + 1
                End If
            Else
                If producto.Stock <= producto.StockCritico Then
                    contador = contador + 1
                End If
            End If
        Next

        If contador > 0 Then
            lblProductosBajoStock.Text = "Hay " & contador & " producto/s bajo el " & vbLf & "stock mínimo."
        Else
            lblProductosBajoStock.Text = ""
        End If
    End Sub

    Sub EnviarCorreos()
        Dim proex As New ProcedimientoExterno
        proex.EnviarCorreos()
    End Sub
    Sub AtencionesPerdidas()
        Dim bsnAtencion As New BsnAtencion
        Dim fechaHoy As String = DateTime.Now.ToString("yyyy-MM-dd")
        bsnAtencion.PerderAtenciones(fechaHoy)
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
            lblAtencionesAgendadas.Text = "Hay " & numAtenciones & " atenciones agendadas" & vbLf & "para hoy."
        Else
            lblAtencionesAgendadas.Text = "No hay atenciones agendadas" & vbLf & "para hoy."
        End If
    End Sub

    Function contar(criterio As String)
        Dim conexion As New Conexion
        Dim numStr As String = "" : Dim ssql As String = ""
        ssql = "select count(*) from " & criterio
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        Dim cont As Integer = Comando.ExecuteScalar()
        numStr = Convert.ToString(cont)
        conexion.CerrarConexion()
        Return numStr
    End Function

    '/////////////////////////////////////////////////////////////////////////////////////////
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub panelPresentacion_MouseDown(sender As Object, e As MouseEventArgs) Handles panelPresentacion.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub panelPresentacion_MouseUp(sender As Object, e As MouseEventArgs) Handles panelPresentacion.MouseUp
        Arrastre = False
    End Sub


    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbOjo_Click(sender As Object, e As EventArgs)
        If modoVista = True Then
            modoVista = False
            panelSuplente.Visible = False
            pbOjo.Image = My.Resources.sinojo
        Else
            modoVista = True
            panelSuplente.Visible = True
            pbOjo.Image = My.Resources.ojo
        End If

    End Sub


    Private Sub panelPresentacion_MouseMove(sender As Object, e As MouseEventArgs) Handles panelPresentacion.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(x:=MousePosition.X - Me.Location.X - ex, y:=MousePosition.Y - Me.Location.Y - ey))
    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////


    Private Sub flecha_derecha_MouseEnter(sender As Object, e As EventArgs) Handles flecha_derecha.MouseEnter
        flecha_derecha.Image = My.Resources.fecha_derecha_destacado
    End Sub

    Private Sub flecha_derecha_MouseLeave(sender As Object, e As EventArgs) Handles flecha_derecha.MouseLeave
        flecha_derecha.Image = My.Resources.flecha_derecha
    End Sub

    Private Sub flecha_izquierda_MouseEnter(sender As Object, e As EventArgs) Handles flecha_izquierda.MouseEnter
        flecha_izquierda.Image = My.Resources.flecha_izquierda_destacado
    End Sub

    Private Sub flecha_izquierda_MouseLeave(sender As Object, e As EventArgs) Handles flecha_izquierda.MouseLeave
        flecha_izquierda.Image = My.Resources.flecha_izquierda
    End Sub

    Private Sub flecha_derecha_Click(sender As Object, e As EventArgs) Handles flecha_derecha.Click
        vistaPanel = vistaPanel + 1
        If vistaPanel = 2 Then
            flecha_derecha.Visible = False
            flecha_izquierda.Visible = True
            panelSuplente.Visible = False
            panelSuplente2.Visible = True
            panelSuplente2.Width = 459
            panelSuplente2.Height = 467
            panelSuplente2.Top = 33
            panelSuplente2.Left = 360
        End If
    End Sub

    Private Sub pb_mascota_Click(sender As Object, e As EventArgs) Handles pb_mascota.Click
        Dim frmMantenedorMascotas As New frm_Mantenedor_Mascotas(Me)
        frmMantenedorMascotas.Show()
        Me.Hide()
    End Sub

    Private Sub pb_mascota_MouseEnter(sender As Object, e As EventArgs) Handles pb_mascota.MouseEnter
        pb_mascota.Image = My.Resources.MASCOTAS_DESTACADO
    End Sub

    Private Sub pb_mascota_MouseLeave(sender As Object, e As EventArgs) Handles pb_mascota.MouseLeave
        pb_mascota.Image = My.Resources.MASCOTAS
    End Sub

    Private Sub pb_atencion_MouseEnter(sender As Object, e As EventArgs) Handles pb_atencion.MouseEnter
        pb_atencion.Image = My.Resources.REGISTRAR_ATENCION_DESTACADO
    End Sub

    Private Sub pb_atencion_MouseLeave(sender As Object, e As EventArgs) Handles pb_atencion.MouseLeave
        pb_atencion.Image = My.Resources.REGISTRAR_ATENCION
    End Sub

    Private Sub pb_calendario_MouseEnter(sender As Object, e As EventArgs) Handles pb_calendario.MouseEnter
        pb_calendario.Image = My.Resources.CALENDARIO_DESTACADO
    End Sub

    Private Sub pb_calendario_MouseLeave(sender As Object, e As EventArgs) Handles pb_calendario.MouseLeave
        pb_calendario.Image = My.Resources.CALENDARIO
    End Sub

    Private Sub pb_clientes_MouseEnter(sender As Object, e As EventArgs) Handles pb_clientes.MouseEnter
        pb_clientes.Image = My.Resources.CLIENTES_DESTACADO
    End Sub

    Private Sub pb_clientes_MouseLeave(sender As Object, e As EventArgs) Handles pb_clientes.MouseLeave
        pb_clientes.Image = My.Resources.CLIENTES
    End Sub

    Private Sub pb_productos_MouseEnter(sender As Object, e As EventArgs) Handles pb_productos.MouseEnter
        pb_productos.Image = My.Resources.PRODUCTOS_DESTACADO
    End Sub

    Private Sub pb_productos_MouseLeave(sender As Object, e As EventArgs) Handles pb_productos.MouseLeave
        pb_productos.Image = My.Resources.PRODUCTOS
    End Sub

    Private Sub pb_registrar_venta_MouseEnter(sender As Object, e As EventArgs) Handles pb_registrar_venta.MouseEnter
        pb_registrar_venta.Image = My.Resources.REGISTRAR_VENTA_DESTACADO
    End Sub

    Private Sub pb_registrar_venta_MouseLeave(sender As Object, e As EventArgs) Handles pb_registrar_venta.MouseLeave
        pb_registrar_venta.Image = My.Resources.REGISTRAR_VENTA
    End Sub

    Private Sub pb_proveedores_MouseEnter(sender As Object, e As EventArgs) Handles pb_proveedores.MouseEnter
        pb_proveedores.Image = My.Resources.PROVEEDORES_DESTACADO
    End Sub

    Private Sub pb_proveedores_MouseLeave(sender As Object, e As EventArgs) Handles pb_proveedores.MouseLeave
        pb_proveedores.Image = My.Resources.PROVEEDORES
    End Sub

    Private Sub pb_veterinarios_MouseEnter(sender As Object, e As EventArgs) Handles pb_veterinarios.MouseEnter
        pb_veterinarios.Image = My.Resources.VETERINARIOS_DESTACADO
    End Sub

    Private Sub pb_veterinarios_MouseLeave(sender As Object, e As EventArgs) Handles pb_veterinarios.MouseLeave
        pb_veterinarios.Image = My.Resources.VETERINARIOS
    End Sub

    Private Sub pb_atencion_Click(sender As Object, e As EventArgs) Handles pb_atencion.Click
        Dim consultarMascota As New frm_Consultar_Mascota(Me)
        consultarMascota.Show()
        Me.Hide()
    End Sub

    Private Sub pb_calendario_Click(sender As Object, e As EventArgs) Handles pb_calendario.Click
        Dim frmCalendario As New frm_Calendario(Me)
        frmCalendario.Show()
        Me.Hide()
    End Sub

    Private Sub pb_clientes_Click(sender As Object, e As EventArgs) Handles pb_clientes.Click
        Dim frmMantenedorClientes As New frm_Mantenedor_Clientes(Me)
        frmMantenedorClientes.Show()
        Me.Hide()
    End Sub

    Private Sub pb_hospitalizaciones_Click(sender As Object, e As EventArgs) Handles pb_hospitalizaciones.Click
        Dim frmGestorHospitalizaciones As New FRM_Gestor_Hospitalizaciones(Me)
        frmGestorHospitalizaciones.Show()
        Me.Hide()
    End Sub

    Private Sub pb_productos_Click(sender As Object, e As EventArgs) Handles pb_productos.Click
        Dim frmMantenedorProductos As New frm_Mantenedor_Productos(Me)
        frmMantenedorProductos.Show()
        Me.Hide()
    End Sub

    Private Sub pb_registrar_venta_Click(sender As Object, e As EventArgs) Handles pb_registrar_venta.Click
        Dim frmRegistrarVenta As New frm_Registrar_Venta(Me)
        frmRegistrarVenta.Show()
        Me.Hide()
    End Sub

    Private Sub pb_proveedores_Click(sender As Object, e As EventArgs) Handles pb_proveedores.Click
        Dim frmMantenedorProveedores As New FRM_Mantenedor_Proveedores(Me)
        frmMantenedorProveedores.Show()
        Me.Hide()
    End Sub

    Private Sub pb_veterinarios_Click(sender As Object, e As EventArgs) Handles pb_veterinarios.Click
        Dim frmMantenedorVeterinarios As New FRM_Mantenedor_Veterinarios(Me)
        frmMantenedorVeterinarios.Show()
        Me.Hide()
    End Sub

    Private Sub pb_especie_Click(sender As Object, e As EventArgs) Handles pb_especie.Click
        Dim frmMantenedorEspecies As New FRM_MantenedorEspecies(Me)
        frmMantenedorEspecies.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pb_razas.Click
        Dim frmMantenedorRaza As New FRM_MantenedorRazas(Me)
        frmMantenedorRaza.Show()
        Me.Hide()
    End Sub

    Private Sub pb_hospitalizaciones_MouseEnter(sender As Object, e As EventArgs) Handles pb_hospitalizaciones.MouseEnter
        pb_hospitalizaciones.Image = My.Resources.HOSPITALIZACION_DESTACADO
    End Sub

    Private Sub pb_hospitalizaciones_MouseLeave(sender As Object, e As EventArgs) Handles pb_hospitalizaciones.MouseLeave
        pb_hospitalizaciones.Image = My.Resources.HOSPITALIZACION
    End Sub

    Private Sub pb_especie_MouseEnter(sender As Object, e As EventArgs) Handles pb_especie.MouseEnter
        pb_especie.Image = My.Resources.ESPECIES_DESTACADO
    End Sub

    Private Sub pb_especie_MouseLeave(sender As Object, e As EventArgs) Handles pb_especie.MouseLeave
        pb_especie.Image = My.Resources.ESPECIES
    End Sub

    Private Sub pb_razas_MouseEnter(sender As Object, e As EventArgs) Handles pb_razas.MouseEnter
        pb_razas.Image = My.Resources.RAZAS_DESTACADO
    End Sub

    Private Sub pb_razas_MouseLeave(sender As Object, e As EventArgs) Handles pb_razas.MouseLeave
        pb_razas.Image = My.Resources.RAZAS
    End Sub

    Private Sub lblAtencionesAgendadas_MouseEnter(sender As Object, e As EventArgs) Handles lblAtencionesAgendadas.MouseEnter
        lblAtencionesAgendadas.ForeColor = Color.White
    End Sub

    Private Sub lblAtencionesAgendadas_MouseLeave(sender As Object, e As EventArgs) Handles lblAtencionesAgendadas.MouseLeave
        lblAtencionesAgendadas.ForeColor = Color.Aqua
    End Sub

    Private Sub lblAtencionesAgendadas_Click(sender As Object, e As EventArgs) Handles lblAtencionesAgendadas.Click
        Dim _frmCalendario As New frm_Calendario(Me)
        _frmCalendario.Show()
        Me.Hide()
    End Sub

    Private Sub lblProductosBajoStock_MouseEnter(sender As Object, e As EventArgs) Handles lblProductosBajoStock.MouseEnter
        lblProductosBajoStock.ForeColor = Color.White
    End Sub

    Private Sub lblProductosBajoStock_MouseLeave(sender As Object, e As EventArgs) Handles lblProductosBajoStock.MouseLeave
        lblProductosBajoStock.ForeColor = Color.DarkOrange
    End Sub

    Private Sub lblProductosBajoStock_Click(sender As Object, e As EventArgs) Handles lblProductosBajoStock.Click
        Dim frmMantenedorProductos As New frm_Mantenedor_Productos(Me)
        frmMantenedorProductos.Show() : Me.Hide()
    End Sub

    Private Sub btnPruebas_Click(sender As Object, e As EventArgs) Handles btnPruebas.Click
        Dim frmPrueba As New Prueba()
        Prueba.Show()
        Me.Hide()
    End Sub

    Private Sub flecha_izquierda_Click(sender As Object, e As EventArgs) Handles flecha_izquierda.Click
        vistaPanel = vistaPanel - 1
        If vistaPanel = 1 Then
            flecha_izquierda.Visible = False
            flecha_derecha.Visible = True
            panelSuplente.Visible = True
            panelSuplente2.Visible = False
        End If
    End Sub
End Class
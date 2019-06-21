<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.panelPresentacion = New System.Windows.Forms.Panel()
        Me.lblProductosBajoStock = New System.Windows.Forms.Label()
        Me.lblAtencionesAgendadas = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNumAtenciones = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNumVentas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNumProductos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNumClientes = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNumMascotas = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelSuplente2 = New System.Windows.Forms.Panel()
        Me.pb_razas = New System.Windows.Forms.PictureBox()
        Me.pb_especie = New System.Windows.Forms.PictureBox()
        Me.flecha_derecha = New System.Windows.Forms.PictureBox()
        Me.flecha_izquierda = New System.Windows.Forms.PictureBox()
        Me.panelSuplente = New System.Windows.Forms.Panel()
        Me.pb_mascota = New System.Windows.Forms.PictureBox()
        Me.pb_calendario = New System.Windows.Forms.PictureBox()
        Me.pb_atencion = New System.Windows.Forms.PictureBox()
        Me.pb_clientes = New System.Windows.Forms.PictureBox()
        Me.pb_hospitalizaciones = New System.Windows.Forms.PictureBox()
        Me.pb_productos = New System.Windows.Forms.PictureBox()
        Me.pb_veterinarios = New System.Windows.Forms.PictureBox()
        Me.pb_registrar_venta = New System.Windows.Forms.PictureBox()
        Me.pb_proveedores = New System.Windows.Forms.PictureBox()
        Me.pbOjo = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btnPruebas = New System.Windows.Forms.Button()
        Me.panelPresentacion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuplente2.SuspendLayout()
        CType(Me.pb_razas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_especie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flecha_derecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flecha_izquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuplente.SuspendLayout()
        CType(Me.pb_mascota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_calendario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_atencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_hospitalizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_veterinarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_registrar_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOjo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelPresentacion
        '
        Me.panelPresentacion.BackColor = System.Drawing.Color.Black
        Me.panelPresentacion.Controls.Add(Me.lblProductosBajoStock)
        Me.panelPresentacion.Controls.Add(Me.lblAtencionesAgendadas)
        Me.panelPresentacion.Controls.Add(Me.GroupBox1)
        Me.panelPresentacion.Controls.Add(Me.PictureBox1)
        Me.panelPresentacion.Controls.Add(Me.Label3)
        Me.panelPresentacion.Controls.Add(Me.Label2)
        Me.panelPresentacion.Controls.Add(Me.Label1)
        Me.panelPresentacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelPresentacion.Location = New System.Drawing.Point(0, 0)
        Me.panelPresentacion.Name = "panelPresentacion"
        Me.panelPresentacion.Size = New System.Drawing.Size(306, 544)
        Me.panelPresentacion.TabIndex = 5
        '
        'lblProductosBajoStock
        '
        Me.lblProductosBajoStock.AutoSize = True
        Me.lblProductosBajoStock.BackColor = System.Drawing.Color.Transparent
        Me.lblProductosBajoStock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductosBajoStock.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblProductosBajoStock.Location = New System.Drawing.Point(11, 319)
        Me.lblProductosBajoStock.Name = "lblProductosBajoStock"
        Me.lblProductosBajoStock.Size = New System.Drawing.Size(65, 20)
        Me.lblProductosBajoStock.TabIndex = 6
        Me.lblProductosBajoStock.Text = "Label10"
        '
        'lblAtencionesAgendadas
        '
        Me.lblAtencionesAgendadas.AutoSize = True
        Me.lblAtencionesAgendadas.BackColor = System.Drawing.Color.Transparent
        Me.lblAtencionesAgendadas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtencionesAgendadas.ForeColor = System.Drawing.Color.Aqua
        Me.lblAtencionesAgendadas.Location = New System.Drawing.Point(11, 361)
        Me.lblAtencionesAgendadas.Name = "lblAtencionesAgendadas"
        Me.lblAtencionesAgendadas.Size = New System.Drawing.Size(65, 20)
        Me.lblAtencionesAgendadas.TabIndex = 5
        Me.lblAtencionesAgendadas.Text = "Label10"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblNumAtenciones)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblNumVentas)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblNumProductos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblNumClientes)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblNumMascotas)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 399)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 135)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(55, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Atenciones Registradas"
        '
        'lblNumAtenciones
        '
        Me.lblNumAtenciones.AutoSize = True
        Me.lblNumAtenciones.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumAtenciones.ForeColor = System.Drawing.Color.LightGray
        Me.lblNumAtenciones.Location = New System.Drawing.Point(10, 51)
        Me.lblNumAtenciones.Name = "lblNumAtenciones"
        Me.lblNumAtenciones.Size = New System.Drawing.Size(41, 20)
        Me.lblNumAtenciones.TabIndex = 10
        Me.lblNumAtenciones.Text = "1234"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(55, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Ventas Registradas"
        '
        'lblNumVentas
        '
        Me.lblNumVentas.AutoSize = True
        Me.lblNumVentas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumVentas.ForeColor = System.Drawing.Color.LightGray
        Me.lblNumVentas.Location = New System.Drawing.Point(9, 111)
        Me.lblNumVentas.Name = "lblNumVentas"
        Me.lblNumVentas.Size = New System.Drawing.Size(41, 20)
        Me.lblNumVentas.TabIndex = 8
        Me.lblNumVentas.Text = "1234"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(54, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Productos Registrados"
        '
        'lblNumProductos
        '
        Me.lblNumProductos.AutoSize = True
        Me.lblNumProductos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumProductos.ForeColor = System.Drawing.Color.LightGray
        Me.lblNumProductos.Location = New System.Drawing.Point(9, 90)
        Me.lblNumProductos.Name = "lblNumProductos"
        Me.lblNumProductos.Size = New System.Drawing.Size(41, 20)
        Me.lblNumProductos.TabIndex = 6
        Me.lblNumProductos.Text = "1234"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(55, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Clientes Registrados"
        '
        'lblNumClientes
        '
        Me.lblNumClientes.AutoSize = True
        Me.lblNumClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumClientes.ForeColor = System.Drawing.Color.LightGray
        Me.lblNumClientes.Location = New System.Drawing.Point(10, 69)
        Me.lblNumClientes.Name = "lblNumClientes"
        Me.lblNumClientes.Size = New System.Drawing.Size(41, 20)
        Me.lblNumClientes.TabIndex = 4
        Me.lblNumClientes.Text = "1234"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(55, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mascotas Registradas"
        '
        'lblNumMascotas
        '
        Me.lblNumMascotas.AutoSize = True
        Me.lblNumMascotas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMascotas.ForeColor = System.Drawing.Color.LightGray
        Me.lblNumMascotas.Location = New System.Drawing.Point(10, 31)
        Me.lblNumMascotas.Name = "lblNumMascotas"
        Me.lblNumMascotas.Size = New System.Drawing.Size(41, 20)
        Me.lblNumMascotas.TabIndex = 2
        Me.lblNumMascotas.Text = "1234"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.LightGray
        Me.lblFecha.Location = New System.Drawing.Point(118, 11)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(67, 20)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(55, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha : "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.symbol5
        Me.PictureBox1.Location = New System.Drawing.Point(58, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(63, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clínica Veterinaria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(83, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "San Francisco"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de Administración" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'panelSuplente2
        '
        Me.panelSuplente2.BackColor = System.Drawing.Color.Transparent
        Me.panelSuplente2.Controls.Add(Me.pb_razas)
        Me.panelSuplente2.Controls.Add(Me.pb_especie)
        Me.panelSuplente2.Location = New System.Drawing.Point(750, 63)
        Me.panelSuplente2.Name = "panelSuplente2"
        Me.panelSuplente2.Size = New System.Drawing.Size(100, 100)
        Me.panelSuplente2.TabIndex = 19
        Me.panelSuplente2.Visible = False
        '
        'pb_razas
        '
        Me.pb_razas.BackColor = System.Drawing.Color.Transparent
        Me.pb_razas.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.RAZAS
        Me.pb_razas.Location = New System.Drawing.Point(165, 10)
        Me.pb_razas.Name = "pb_razas"
        Me.pb_razas.Size = New System.Drawing.Size(140, 140)
        Me.pb_razas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_razas.TabIndex = 1
        Me.pb_razas.TabStop = False
        '
        'pb_especie
        '
        Me.pb_especie.BackColor = System.Drawing.Color.Transparent
        Me.pb_especie.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.ESPECIES
        Me.pb_especie.Location = New System.Drawing.Point(15, 10)
        Me.pb_especie.Name = "pb_especie"
        Me.pb_especie.Size = New System.Drawing.Size(140, 140)
        Me.pb_especie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_especie.TabIndex = 0
        Me.pb_especie.TabStop = False
        '
        'flecha_derecha
        '
        Me.flecha_derecha.BackColor = System.Drawing.Color.Transparent
        Me.flecha_derecha.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.flecha_derecha
        Me.flecha_derecha.Location = New System.Drawing.Point(816, 197)
        Me.flecha_derecha.Name = "flecha_derecha"
        Me.flecha_derecha.Size = New System.Drawing.Size(39, 140)
        Me.flecha_derecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flecha_derecha.TabIndex = 22
        Me.flecha_derecha.TabStop = False
        '
        'flecha_izquierda
        '
        Me.flecha_izquierda.BackColor = System.Drawing.Color.Transparent
        Me.flecha_izquierda.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.flecha_izquierda
        Me.flecha_izquierda.Location = New System.Drawing.Point(312, 197)
        Me.flecha_izquierda.Name = "flecha_izquierda"
        Me.flecha_izquierda.Size = New System.Drawing.Size(39, 140)
        Me.flecha_izquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flecha_izquierda.TabIndex = 21
        Me.flecha_izquierda.TabStop = False
        Me.flecha_izquierda.Visible = False
        '
        'panelSuplente
        '
        Me.panelSuplente.BackColor = System.Drawing.Color.Transparent
        Me.panelSuplente.Controls.Add(Me.pb_mascota)
        Me.panelSuplente.Controls.Add(Me.pb_calendario)
        Me.panelSuplente.Controls.Add(Me.pb_atencion)
        Me.panelSuplente.Controls.Add(Me.pb_clientes)
        Me.panelSuplente.Controls.Add(Me.pb_hospitalizaciones)
        Me.panelSuplente.Controls.Add(Me.pb_productos)
        Me.panelSuplente.Controls.Add(Me.pb_veterinarios)
        Me.panelSuplente.Controls.Add(Me.pb_registrar_venta)
        Me.panelSuplente.Controls.Add(Me.pb_proveedores)
        Me.panelSuplente.Location = New System.Drawing.Point(408, 73)
        Me.panelSuplente.Name = "panelSuplente"
        Me.panelSuplente.Size = New System.Drawing.Size(251, 412)
        Me.panelSuplente.TabIndex = 20
        '
        'pb_mascota
        '
        Me.pb_mascota.Image = CType(resources.GetObject("pb_mascota.Image"), System.Drawing.Image)
        Me.pb_mascota.Location = New System.Drawing.Point(8, 10)
        Me.pb_mascota.Name = "pb_mascota"
        Me.pb_mascota.Size = New System.Drawing.Size(140, 140)
        Me.pb_mascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_mascota.TabIndex = 0
        Me.pb_mascota.TabStop = False
        '
        'pb_calendario
        '
        Me.pb_calendario.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.CALENDARIO
        Me.pb_calendario.Location = New System.Drawing.Point(309, 10)
        Me.pb_calendario.Name = "pb_calendario"
        Me.pb_calendario.Size = New System.Drawing.Size(140, 140)
        Me.pb_calendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_calendario.TabIndex = 2
        Me.pb_calendario.TabStop = False
        '
        'pb_atencion
        '
        Me.pb_atencion.Image = CType(resources.GetObject("pb_atencion.Image"), System.Drawing.Image)
        Me.pb_atencion.Location = New System.Drawing.Point(158, 10)
        Me.pb_atencion.Name = "pb_atencion"
        Me.pb_atencion.Size = New System.Drawing.Size(140, 140)
        Me.pb_atencion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_atencion.TabIndex = 1
        Me.pb_atencion.TabStop = False
        '
        'pb_clientes
        '
        Me.pb_clientes.Image = CType(resources.GetObject("pb_clientes.Image"), System.Drawing.Image)
        Me.pb_clientes.Location = New System.Drawing.Point(8, 164)
        Me.pb_clientes.Name = "pb_clientes"
        Me.pb_clientes.Size = New System.Drawing.Size(140, 140)
        Me.pb_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_clientes.TabIndex = 3
        Me.pb_clientes.TabStop = False
        '
        'pb_hospitalizaciones
        '
        Me.pb_hospitalizaciones.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.HOSPITALIZACION
        Me.pb_hospitalizaciones.Location = New System.Drawing.Point(158, 164)
        Me.pb_hospitalizaciones.Name = "pb_hospitalizaciones"
        Me.pb_hospitalizaciones.Size = New System.Drawing.Size(140, 140)
        Me.pb_hospitalizaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_hospitalizaciones.TabIndex = 8
        Me.pb_hospitalizaciones.TabStop = False
        '
        'pb_productos
        '
        Me.pb_productos.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.PRODUCTOS
        Me.pb_productos.Location = New System.Drawing.Point(309, 164)
        Me.pb_productos.Name = "pb_productos"
        Me.pb_productos.Size = New System.Drawing.Size(140, 140)
        Me.pb_productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_productos.TabIndex = 4
        Me.pb_productos.TabStop = False
        '
        'pb_veterinarios
        '
        Me.pb_veterinarios.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.VETERINARIOS
        Me.pb_veterinarios.Location = New System.Drawing.Point(309, 317)
        Me.pb_veterinarios.Name = "pb_veterinarios"
        Me.pb_veterinarios.Size = New System.Drawing.Size(140, 140)
        Me.pb_veterinarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_veterinarios.TabIndex = 7
        Me.pb_veterinarios.TabStop = False
        '
        'pb_registrar_venta
        '
        Me.pb_registrar_venta.Image = CType(resources.GetObject("pb_registrar_venta.Image"), System.Drawing.Image)
        Me.pb_registrar_venta.Location = New System.Drawing.Point(8, 317)
        Me.pb_registrar_venta.Name = "pb_registrar_venta"
        Me.pb_registrar_venta.Size = New System.Drawing.Size(140, 140)
        Me.pb_registrar_venta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_registrar_venta.TabIndex = 5
        Me.pb_registrar_venta.TabStop = False
        '
        'pb_proveedores
        '
        Me.pb_proveedores.Image = CType(resources.GetObject("pb_proveedores.Image"), System.Drawing.Image)
        Me.pb_proveedores.Location = New System.Drawing.Point(156, 317)
        Me.pb_proveedores.Name = "pb_proveedores"
        Me.pb_proveedores.Size = New System.Drawing.Size(140, 140)
        Me.pb_proveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_proveedores.TabIndex = 6
        Me.pb_proveedores.TabStop = False
        '
        'pbOjo
        '
        Me.pbOjo.BackColor = System.Drawing.Color.Transparent
        Me.pbOjo.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.ojo
        Me.pbOjo.Location = New System.Drawing.Point(790, 11)
        Me.pbOjo.Name = "pbOjo"
        Me.pbOjo.Size = New System.Drawing.Size(16, 16)
        Me.pbOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOjo.TabIndex = 18
        Me.pbOjo.TabStop = False
        Me.pbOjo.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.min
        Me.PictureBox3.Location = New System.Drawing.Point(812, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.salir
        Me.PictureBox2.Location = New System.Drawing.Point(834, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(593, 506)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(217, 31)
        Me.btn_salir.TabIndex = 15
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btnPruebas
        '
        Me.btnPruebas.Location = New System.Drawing.Point(332, 11)
        Me.btnPruebas.Name = "btnPruebas"
        Me.btnPruebas.Size = New System.Drawing.Size(75, 23)
        Me.btnPruebas.TabIndex = 23
        Me.btnPruebas.Text = "PRUEBA"
        Me.btnPruebas.UseVisualStyleBackColor = True
        Me.btnPruebas.Visible = False
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources._59a1bac6de792
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 544)
        Me.Controls.Add(Me.btnPruebas)
        Me.Controls.Add(Me.flecha_derecha)
        Me.Controls.Add(Me.panelSuplente2)
        Me.Controls.Add(Me.flecha_izquierda)
        Me.Controls.Add(Me.panelSuplente)
        Me.Controls.Add(Me.pbOjo)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.panelPresentacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Principal"
        Me.panelPresentacion.ResumeLayout(False)
        Me.panelPresentacion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuplente2.ResumeLayout(False)
        CType(Me.pb_razas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_especie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flecha_derecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flecha_izquierda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuplente.ResumeLayout(False)
        CType(Me.pb_mascota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_calendario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_atencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_hospitalizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_veterinarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_registrar_venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOjo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelPresentacion As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNumVentas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNumProductos As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNumClientes As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNumMascotas As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNumAtenciones As Label
    Friend WithEvents flecha_derecha As PictureBox
    Friend WithEvents panelSuplente2 As Panel
    Friend WithEvents pb_razas As PictureBox
    Friend WithEvents pb_especie As PictureBox
    Friend WithEvents flecha_izquierda As PictureBox
    Friend WithEvents panelSuplente As Panel
    Friend WithEvents pb_mascota As PictureBox
    Friend WithEvents pb_calendario As PictureBox
    Friend WithEvents pb_atencion As PictureBox
    Friend WithEvents pb_clientes As PictureBox
    Friend WithEvents pb_hospitalizaciones As PictureBox
    Friend WithEvents pb_productos As PictureBox
    Friend WithEvents pb_veterinarios As PictureBox
    Friend WithEvents pb_registrar_venta As PictureBox
    Friend WithEvents pb_proveedores As PictureBox
    Friend WithEvents pbOjo As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents lblAtencionesAgendadas As Label
    Friend WithEvents lblProductosBajoStock As Label
    Friend WithEvents btnPruebas As Button
End Class

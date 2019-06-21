<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Mantenedor_Productos
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
        Me.lst_productos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_stock_critico = New System.Windows.Forms.TextBox()
        Me.txtBusquedaCodigo = New System.Windows.Forms.TextBox()
        Me.txtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.txtBusquedaStock = New System.Windows.Forms.TextBox()
        Me.txtBusquedaUnidad = New System.Windows.Forms.TextBox()
        Me.btnOrdenarCodigo = New System.Windows.Forms.Button()
        Me.btnOrdenarNombre = New System.Windows.Forms.Button()
        Me.btnOrdenarStock = New System.Windows.Forms.Button()
        Me.btnOrdenarUnidad = New System.Windows.Forms.Button()
        Me.panel_datos = New System.Windows.Forms.Panel()
        Me.lblAlertaStock = New System.Windows.Forms.Label()
        Me.cmbUnidad = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDetStock = New System.Windows.Forms.Button()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.pbProducto = New System.Windows.Forms.PictureBox()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.cmb_proveedores = New System.Windows.Forms.ComboBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelStock = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbContenido = New System.Windows.Forms.PictureBox()
        Me.txtCantActual = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudNumFrascos = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCantidadXFrasco = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panel_datos.SuspendLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panelStock.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbContenido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumFrascos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_productos
        '
        Me.lst_productos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_productos.FormattingEnabled = True
        Me.lst_productos.ItemHeight = 15
        Me.lst_productos.Location = New System.Drawing.Point(23, 128)
        Me.lst_productos.Name = "lst_productos"
        Me.lst_productos.Size = New System.Drawing.Size(411, 349)
        Me.lst_productos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(13, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(13, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(13, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(13, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(13, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(15, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(12, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stock Mínimo"
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(133, 244)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(164, 23)
        Me.txt_nombre.TabIndex = 10
        '
        'txt_precio
        '
        Me.txt_precio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(133, 326)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(164, 23)
        Me.txt_precio.TabIndex = 13
        '
        'txt_stock
        '
        Me.txt_stock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock.Location = New System.Drawing.Point(133, 382)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(164, 23)
        Me.txt_stock.TabIndex = 14
        '
        'txt_stock_critico
        '
        Me.txt_stock_critico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock_critico.Location = New System.Drawing.Point(133, 409)
        Me.txt_stock_critico.Name = "txt_stock_critico"
        Me.txt_stock_critico.Size = New System.Drawing.Size(164, 23)
        Me.txt_stock_critico.TabIndex = 15
        '
        'txtBusquedaCodigo
        '
        Me.txtBusquedaCodigo.BackColor = System.Drawing.Color.White
        Me.txtBusquedaCodigo.Location = New System.Drawing.Point(23, 492)
        Me.txtBusquedaCodigo.Name = "txtBusquedaCodigo"
        Me.txtBusquedaCodigo.Size = New System.Drawing.Size(48, 20)
        Me.txtBusquedaCodigo.TabIndex = 17
        '
        'txtBusquedaNombre
        '
        Me.txtBusquedaNombre.Location = New System.Drawing.Point(77, 492)
        Me.txtBusquedaNombre.Name = "txtBusquedaNombre"
        Me.txtBusquedaNombre.Size = New System.Drawing.Size(199, 20)
        Me.txtBusquedaNombre.TabIndex = 18
        '
        'txtBusquedaStock
        '
        Me.txtBusquedaStock.Location = New System.Drawing.Point(282, 492)
        Me.txtBusquedaStock.Name = "txtBusquedaStock"
        Me.txtBusquedaStock.Size = New System.Drawing.Size(52, 20)
        Me.txtBusquedaStock.TabIndex = 19
        '
        'txtBusquedaUnidad
        '
        Me.txtBusquedaUnidad.Location = New System.Drawing.Point(340, 492)
        Me.txtBusquedaUnidad.Name = "txtBusquedaUnidad"
        Me.txtBusquedaUnidad.Size = New System.Drawing.Size(94, 20)
        Me.txtBusquedaUnidad.TabIndex = 20
        '
        'btnOrdenarCodigo
        '
        Me.btnOrdenarCodigo.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarCodigo.FlatAppearance.BorderSize = 0
        Me.btnOrdenarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarCodigo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarCodigo.Location = New System.Drawing.Point(23, 100)
        Me.btnOrdenarCodigo.Name = "btnOrdenarCodigo"
        Me.btnOrdenarCodigo.Size = New System.Drawing.Size(48, 23)
        Me.btnOrdenarCodigo.TabIndex = 21
        Me.btnOrdenarCodigo.Text = "COD"
        Me.btnOrdenarCodigo.UseVisualStyleBackColor = False
        '
        'btnOrdenarNombre
        '
        Me.btnOrdenarNombre.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarNombre.FlatAppearance.BorderSize = 0
        Me.btnOrdenarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarNombre.Location = New System.Drawing.Point(77, 100)
        Me.btnOrdenarNombre.Name = "btnOrdenarNombre"
        Me.btnOrdenarNombre.Size = New System.Drawing.Size(199, 23)
        Me.btnOrdenarNombre.TabIndex = 22
        Me.btnOrdenarNombre.Text = "NOMBRE"
        Me.btnOrdenarNombre.UseVisualStyleBackColor = False
        '
        'btnOrdenarStock
        '
        Me.btnOrdenarStock.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarStock.FlatAppearance.BorderSize = 0
        Me.btnOrdenarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarStock.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarStock.Location = New System.Drawing.Point(282, 100)
        Me.btnOrdenarStock.Name = "btnOrdenarStock"
        Me.btnOrdenarStock.Size = New System.Drawing.Size(52, 23)
        Me.btnOrdenarStock.TabIndex = 23
        Me.btnOrdenarStock.Text = "STOCK"
        Me.btnOrdenarStock.UseVisualStyleBackColor = False
        '
        'btnOrdenarUnidad
        '
        Me.btnOrdenarUnidad.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarUnidad.FlatAppearance.BorderSize = 0
        Me.btnOrdenarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarUnidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarUnidad.Location = New System.Drawing.Point(340, 100)
        Me.btnOrdenarUnidad.Name = "btnOrdenarUnidad"
        Me.btnOrdenarUnidad.Size = New System.Drawing.Size(94, 23)
        Me.btnOrdenarUnidad.TabIndex = 24
        Me.btnOrdenarUnidad.Text = "UNIDAD"
        Me.btnOrdenarUnidad.UseVisualStyleBackColor = False
        '
        'panel_datos
        '
        Me.panel_datos.BackColor = System.Drawing.Color.SeaGreen
        Me.panel_datos.Controls.Add(Me.lblAlertaStock)
        Me.panel_datos.Controls.Add(Me.cmbUnidad)
        Me.panel_datos.Controls.Add(Me.Label8)
        Me.panel_datos.Controls.Add(Me.btnDetStock)
        Me.panel_datos.Controls.Add(Me.btnQuitarImagen)
        Me.panel_datos.Controls.Add(Me.btnCargarImagen)
        Me.panel_datos.Controls.Add(Me.pbProducto)
        Me.panel_datos.Controls.Add(Me.lbl_codigo)
        Me.panel_datos.Controls.Add(Me.cmb_tipo)
        Me.panel_datos.Controls.Add(Me.cmb_proveedores)
        Me.panel_datos.Controls.Add(Me.btn_cancelar)
        Me.panel_datos.Controls.Add(Me.btn_guardar)
        Me.panel_datos.Controls.Add(Me.Label1)
        Me.panel_datos.Controls.Add(Me.Label2)
        Me.panel_datos.Controls.Add(Me.Label3)
        Me.panel_datos.Controls.Add(Me.Label4)
        Me.panel_datos.Controls.Add(Me.Label5)
        Me.panel_datos.Controls.Add(Me.Label6)
        Me.panel_datos.Controls.Add(Me.Label7)
        Me.panel_datos.Controls.Add(Me.txt_nombre)
        Me.panel_datos.Controls.Add(Me.txt_stock_critico)
        Me.panel_datos.Controls.Add(Me.txt_stock)
        Me.panel_datos.Controls.Add(Me.txt_precio)
        Me.panel_datos.Location = New System.Drawing.Point(458, 0)
        Me.panel_datos.Name = "panel_datos"
        Me.panel_datos.Size = New System.Drawing.Size(315, 535)
        Me.panel_datos.TabIndex = 25
        '
        'lblAlertaStock
        '
        Me.lblAlertaStock.AutoSize = True
        Me.lblAlertaStock.BackColor = System.Drawing.Color.Transparent
        Me.lblAlertaStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertaStock.ForeColor = System.Drawing.Color.Maroon
        Me.lblAlertaStock.Location = New System.Drawing.Point(41, 435)
        Me.lblAlertaStock.Name = "lblAlertaStock"
        Me.lblAlertaStock.Size = New System.Drawing.Size(243, 21)
        Me.lblAlertaStock.TabIndex = 30
        Me.lblAlertaStock.Text = "Producto bajo el stock mínimo"
        Me.lblAlertaStock.Visible = False
        '
        'cmbUnidad
        '
        Me.cmbUnidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Location = New System.Drawing.Point(133, 352)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(164, 25)
        Me.cmbUnidad.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(15, 353)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 21)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Unidad"
        '
        'btnDetStock
        '
        Me.btnDetStock.BackColor = System.Drawing.Color.PaleGreen
        Me.btnDetStock.FlatAppearance.BorderSize = 0
        Me.btnDetStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetStock.ForeColor = System.Drawing.Color.Black
        Me.btnDetStock.Location = New System.Drawing.Point(30, 460)
        Me.btnDetStock.Name = "btnDetStock"
        Me.btnDetStock.Size = New System.Drawing.Size(262, 30)
        Me.btnDetStock.TabIndex = 27
        Me.btnDetStock.Text = "DETALLAR STOCK"
        Me.btnDetStock.UseVisualStyleBackColor = False
        Me.btnDetStock.Visible = False
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.BackColor = System.Drawing.Color.Red
        Me.btnQuitarImagen.FlatAppearance.BorderSize = 0
        Me.btnQuitarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarImagen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarImagen.ForeColor = System.Drawing.Color.White
        Me.btnQuitarImagen.Location = New System.Drawing.Point(217, 181)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.Size = New System.Drawing.Size(23, 23)
        Me.btnQuitarImagen.TabIndex = 25
        Me.btnQuitarImagen.Text = "X"
        Me.btnQuitarImagen.UseVisualStyleBackColor = False
        Me.btnQuitarImagen.Visible = False
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.BackColor = System.Drawing.Color.LightGray
        Me.btnCargarImagen.FlatAppearance.BorderSize = 0
        Me.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarImagen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagen.Location = New System.Drawing.Point(100, 181)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(111, 23)
        Me.btnCargarImagen.TabIndex = 24
        Me.btnCargarImagen.Text = "Cargar Imagen..."
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        Me.btnCargarImagen.Visible = False
        '
        'pbProducto
        '
        Me.pbProducto.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.cosa
        Me.pbProducto.Location = New System.Drawing.Point(100, 35)
        Me.pbProducto.Name = "pbProducto"
        Me.pbProducto.Size = New System.Drawing.Size(140, 140)
        Me.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProducto.TabIndex = 23
        Me.pbProducto.TabStop = False
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_codigo.Location = New System.Drawing.Point(129, 220)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(70, 21)
        Me.lbl_codigo.TabIndex = 22
        Me.lbl_codigo.Text = "Label10"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(133, 272)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(164, 25)
        Me.cmb_tipo.TabIndex = 21
        '
        'cmb_proveedores
        '
        Me.cmb_proveedores.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_proveedores.FormattingEnabled = True
        Me.cmb_proveedores.Location = New System.Drawing.Point(133, 299)
        Me.cmb_proveedores.Name = "cmb_proveedores"
        Me.cmb_proveedores.Size = New System.Drawing.Size(164, 25)
        Me.cmb_proveedores.TabIndex = 20
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(161, 496)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(131, 30)
        Me.btn_cancelar.TabIndex = 18
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        Me.btn_cancelar.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_guardar.Location = New System.Drawing.Point(30, 496)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(125, 30)
        Me.btn_guardar.TabIndex = 17
        Me.btn_guardar.Text = "ACEPTAR"
        Me.btn_guardar.UseVisualStyleBackColor = False
        Me.btn_guardar.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(123, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "DETALLAR STOCK"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Location = New System.Drawing.Point(586, 9)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(169, 33)
        Me.btn_salir.TabIndex = 26
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.btn_eliminar)
        Me.Panel2.Controls.Add(Me.btn_salir)
        Me.Panel2.Controls.Add(Me.btn_modificar)
        Me.Panel2.Controls.Add(Me.btn_agregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 535)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 48)
        Me.Panel2.TabIndex = 27
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Location = New System.Drawing.Point(320, 9)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(147, 32)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_modificar.FlatAppearance.BorderSize = 0
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.Black
        Me.btn_modificar.Location = New System.Drawing.Point(159, 8)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(155, 33)
        Me.btn_modificar.TabIndex = 1
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(12, 8)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(141, 33)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(317, 24)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "MANTENEDOR DE PRODUCTOS"
        '
        'panelStock
        '
        Me.panelStock.Controls.Add(Me.Label11)
        Me.panelStock.Controls.Add(Me.Panel3)
        Me.panelStock.Controls.Add(Me.Panel1)
        Me.panelStock.Controls.Add(Me.txtCantActual)
        Me.panelStock.Controls.Add(Me.Label15)
        Me.panelStock.Controls.Add(Me.nudNumFrascos)
        Me.panelStock.Controls.Add(Me.Label14)
        Me.panelStock.Controls.Add(Me.txtCantidadXFrasco)
        Me.panelStock.Controls.Add(Me.Label13)
        Me.panelStock.Controls.Add(Me.Label9)
        Me.panelStock.Location = New System.Drawing.Point(11, 13)
        Me.panelStock.Name = "panelStock"
        Me.panelStock.Size = New System.Drawing.Size(432, 499)
        Me.panelStock.TabIndex = 29
        Me.panelStock.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 21)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "FRASCO ACTUAL"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblPorcentaje)
        Me.Panel3.Location = New System.Drawing.Point(38, 399)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(159, 40)
        Me.Panel3.TabIndex = 31
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblPorcentaje.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.Location = New System.Drawing.Point(45, 4)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(83, 32)
        Me.lblPorcentaje.TabIndex = 1
        Me.lblPorcentaje.Text = "100%"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.mldStock
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.pbContenido)
        Me.Panel1.Location = New System.Drawing.Point(24, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 221)
        Me.Panel1.TabIndex = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(48, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 31)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'pbContenido
        '
        Me.pbContenido.BackColor = System.Drawing.Color.Lime
        Me.pbContenido.Location = New System.Drawing.Point(28, 59)
        Me.pbContenido.Name = "pbContenido"
        Me.pbContenido.Size = New System.Drawing.Size(134, 140)
        Me.pbContenido.TabIndex = 0
        Me.pbContenido.TabStop = False
        '
        'txtCantActual
        '
        Me.txtCantActual.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantActual.Location = New System.Drawing.Point(227, 279)
        Me.txtCantActual.MaxLength = 4
        Me.txtCantActual.Name = "txtCantActual"
        Me.txtCantActual.Size = New System.Drawing.Size(193, 23)
        Me.txtCantActual.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(225, 255)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(175, 21)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Cant. Frasco Actual :"
        '
        'nudNumFrascos
        '
        Me.nudNumFrascos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumFrascos.Location = New System.Drawing.Point(228, 333)
        Me.nudNumFrascos.Name = "nudNumFrascos"
        Me.nudNumFrascos.Size = New System.Drawing.Size(193, 26)
        Me.nudNumFrascos.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(224, 308)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 21)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "N° Frascos :"
        '
        'txtCantidadXFrasco
        '
        Me.txtCantidadXFrasco.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadXFrasco.Location = New System.Drawing.Point(227, 215)
        Me.txtCantidadXFrasco.MaxLength = 4
        Me.txtCantidadXFrasco.Name = "txtCantidadXFrasco"
        Me.txtCantidadXFrasco.Size = New System.Drawing.Size(193, 23)
        Me.txtCantidadXFrasco.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(223, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 21)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Cantidad / Frasco :"
        '
        'frm_Mantenedor_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 583)
        Me.Controls.Add(Me.panelStock)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_datos)
        Me.Controls.Add(Me.btnOrdenarUnidad)
        Me.Controls.Add(Me.btnOrdenarStock)
        Me.Controls.Add(Me.btnOrdenarNombre)
        Me.Controls.Add(Me.btnOrdenarCodigo)
        Me.Controls.Add(Me.txtBusquedaUnidad)
        Me.Controls.Add(Me.txtBusquedaStock)
        Me.Controls.Add(Me.txtBusquedaNombre)
        Me.Controls.Add(Me.txtBusquedaCodigo)
        Me.Controls.Add(Me.lst_productos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Mantenedor_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor_Productos"
        Me.panel_datos.ResumeLayout(False)
        Me.panel_datos.PerformLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.panelStock.ResumeLayout(False)
        Me.panelStock.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbContenido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumFrascos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_productos As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_stock_critico As TextBox
    Friend WithEvents txtBusquedaCodigo As TextBox
    Friend WithEvents txtBusquedaNombre As TextBox
    Friend WithEvents txtBusquedaStock As TextBox
    Friend WithEvents txtBusquedaUnidad As TextBox
    Friend WithEvents btnOrdenarCodigo As Button
    Friend WithEvents btnOrdenarNombre As Button
    Friend WithEvents btnOrdenarStock As Button
    Friend WithEvents btnOrdenarUnidad As Button
    Friend WithEvents panel_datos As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents cmb_proveedores As ComboBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pbProducto As PictureBox
    Friend WithEvents btnQuitarImagen As Button
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents btnDetStock As Button
    Friend WithEvents panelStock As Panel
    Friend WithEvents txtCantActual As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents nudNumFrascos As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCantidadXFrasco As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbContenido As PictureBox
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbUnidad As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAlertaStock As Label
End Class

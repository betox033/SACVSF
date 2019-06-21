<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Registrar_Venta
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelClientes = New System.Windows.Forms.Panel()
        Me.lbl_num_cliente = New System.Windows.Forms.Label()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.lbl_fono = New System.Windows.Forms.Label()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.cmb_clientes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_cod_producto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_productos = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstDetalles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblIndice = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panelClientes.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.panelClientes)
        Me.Panel1.Controls.Add(Me.cmb_clientes)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 140)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(377, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "NO DEFINIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelClientes
        '
        Me.panelClientes.Controls.Add(Me.lbl_num_cliente)
        Me.panelClientes.Controls.Add(Me.lbl_correo)
        Me.panelClientes.Controls.Add(Me.lbl_fono)
        Me.panelClientes.Controls.Add(Me.lbl_rut)
        Me.panelClientes.Controls.Add(Me.Label12)
        Me.panelClientes.Controls.Add(Me.Label11)
        Me.panelClientes.Controls.Add(Me.Label10)
        Me.panelClientes.Controls.Add(Me.lbl_direccion)
        Me.panelClientes.Controls.Add(Me.lbl_nombre)
        Me.panelClientes.Controls.Add(Me.Label7)
        Me.panelClientes.Controls.Add(Me.label22)
        Me.panelClientes.Location = New System.Drawing.Point(56, 64)
        Me.panelClientes.Name = "panelClientes"
        Me.panelClientes.Size = New System.Drawing.Size(611, 71)
        Me.panelClientes.TabIndex = 18
        Me.panelClientes.Visible = False
        '
        'lbl_num_cliente
        '
        Me.lbl_num_cliente.AutoSize = True
        Me.lbl_num_cliente.Location = New System.Drawing.Point(243, 45)
        Me.lbl_num_cliente.Name = "lbl_num_cliente"
        Me.lbl_num_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_num_cliente.TabIndex = 28
        Me.lbl_num_cliente.Text = "Label2"
        Me.lbl_num_cliente.Visible = False
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_correo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correo.ForeColor = System.Drawing.Color.White
        Me.lbl_correo.Location = New System.Drawing.Point(464, 39)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(70, 21)
        Me.lbl_correo.TabIndex = 27
        Me.lbl_correo.Text = "Label15"
        '
        'lbl_fono
        '
        Me.lbl_fono.AutoSize = True
        Me.lbl_fono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono.ForeColor = System.Drawing.Color.White
        Me.lbl_fono.Location = New System.Drawing.Point(464, 10)
        Me.lbl_fono.Name = "lbl_fono"
        Me.lbl_fono.Size = New System.Drawing.Size(70, 21)
        Me.lbl_fono.TabIndex = 26
        Me.lbl_fono.Text = "Label14"
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rut.ForeColor = System.Drawing.Color.White
        Me.lbl_rut.Location = New System.Drawing.Point(317, 10)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(70, 21)
        Me.lbl_rut.TabIndex = 25
        Me.lbl_rut.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(400, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 21)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Correo : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(400, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 21)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Fono : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(267, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 21)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "RUT : "
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_direccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.ForeColor = System.Drawing.Color.White
        Me.lbl_direccion.Location = New System.Drawing.Point(95, 39)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(61, 21)
        Me.lbl_direccion.TabIndex = 21
        Me.lbl_direccion.Text = "Label9"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.White
        Me.lbl_nombre.Location = New System.Drawing.Point(95, 10)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(61, 21)
        Me.lbl_nombre.TabIndex = 20
        Me.lbl_nombre.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Dirección : "
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.BackColor = System.Drawing.Color.Transparent
        Me.label22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label22.ForeColor = System.Drawing.Color.White
        Me.label22.Location = New System.Drawing.Point(12, 10)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(85, 21)
        Me.label22.TabIndex = 18
        Me.label22.Text = "Nombre : "
        '
        'cmb_clientes
        '
        Me.cmb_clientes.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_clientes.FormattingEnabled = True
        Me.cmb_clientes.Location = New System.Drawing.Point(61, 35)
        Me.cmb_clientes.Name = "cmb_clientes"
        Me.cmb_clientes.Size = New System.Drawing.Size(305, 23)
        Me.cmb_clientes.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(57, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Seleccione al cliente : "
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(620, 62)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(61, 21)
        Me.lbl_fecha.TabIndex = 3
        Me.lbl_fecha.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(553, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha : "
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.Location = New System.Drawing.Point(130, 61)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(61, 21)
        Me.lbl_numero.TabIndex = 1
        Me.lbl_numero.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número : "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btn_salir)
        Me.Panel4.Controls.Add(Me.btn_registrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 603)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(733, 58)
        Me.Panel4.TabIndex = 3
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.DarkRed
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.LightGray
        Me.btn_salir.Location = New System.Drawing.Point(599, 14)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(93, 32)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.DarkRed
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.LightGray
        Me.btn_registrar.Location = New System.Drawing.Point(41, 14)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(201, 33)
        Me.btn_registrar.TabIndex = 0
        Me.btn_registrar.Text = "REGISTRAR VENTA"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "REGISTRAR VENTA"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(566, 445)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(101, 25)
        Me.txt_total.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(498, 445)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 21)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Total : "
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.LightGray
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(56, 445)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(151, 23)
        Me.btn_eliminar.TabIndex = 6
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_cod_producto)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.lbl_precio)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmb_productos)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 103)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'lbl_cod_producto
        '
        Me.lbl_cod_producto.AutoSize = True
        Me.lbl_cod_producto.Location = New System.Drawing.Point(254, 26)
        Me.lbl_cod_producto.Name = "lbl_cod_producto"
        Me.lbl_cod_producto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cod_producto.TabIndex = 19
        Me.lbl_cod_producto.Text = "Label2"
        Me.lbl_cod_producto.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(301, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.LightGray
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(555, 68)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(109, 28)
        Me.btn_agregar.TabIndex = 17
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(425, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 20)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(428, 73)
        Me.txt_cantidad.MaxLength = 3
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 15
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.ForeColor = System.Drawing.Color.Black
        Me.lbl_precio.Location = New System.Drawing.Point(343, 74)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(65, 20)
        Me.lbl_precio.TabIndex = 14
        Me.lbl_precio.Text = "Label20"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(343, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 20)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Precio"
        '
        'cmb_productos
        '
        Me.cmb_productos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_productos.FormattingEnabled = True
        Me.cmb_productos.Location = New System.Drawing.Point(31, 71)
        Me.cmb_productos.Name = "cmb_productos"
        Me.cmb_productos.Size = New System.Drawing.Size(263, 23)
        Me.cmb_productos.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(29, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 20)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Producto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(24, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(170, 20)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "AGREGAR PRODUCTO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 479)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(733, 125)
        Me.Panel2.TabIndex = 10
        '
        'lstDetalles
        '
        Me.lstDetalles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstDetalles.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetalles.FullRowSelect = True
        Me.lstDetalles.GridLines = True
        Me.lstDetalles.Location = New System.Drawing.Point(56, 247)
        Me.lstDetalles.Name = "lstDetalles"
        Me.lstDetalles.Size = New System.Drawing.Size(611, 192)
        Me.lstDetalles.TabIndex = 11
        Me.lstDetalles.UseCompatibleStateImageBehavior = False
        Me.lstDetalles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "COD"
        Me.ColumnHeader1.Width = 51
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOMBRE"
        Me.ColumnHeader2.Width = 299
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CANT"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PRECIO"
        Me.ColumnHeader4.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SUBTOTAL"
        Me.ColumnHeader5.Width = 99
        '
        'lblIndice
        '
        Me.lblIndice.AutoSize = True
        Me.lblIndice.Location = New System.Drawing.Point(13, 262)
        Me.lblIndice.Name = "lblIndice"
        Me.lblIndice.Size = New System.Drawing.Size(39, 13)
        Me.lblIndice.TabIndex = 12
        Me.lblIndice.Text = "Label4"
        Me.lblIndice.Visible = False
        '
        'frm_Registrar_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(733, 661)
        Me.Controls.Add(Me.lblIndice)
        Me.Controls.Add(Me.lstDetalles)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_numero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Registrar_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTA DE PRODUCTOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelClientes.ResumeLayout(False)
        Me.panelClientes.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents cmb_clientes As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_numero As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_cod_producto As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents lbl_precio As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmb_productos As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lstDetalles As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lblIndice As Label
    Friend WithEvents panelClientes As Panel
    Friend WithEvents lbl_num_cliente As Label
    Friend WithEvents lbl_correo As Label
    Friend WithEvents lbl_fono As Label
    Friend WithEvents lbl_rut As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents label22 As Label
    Friend WithEvents Button1 As Button
End Class

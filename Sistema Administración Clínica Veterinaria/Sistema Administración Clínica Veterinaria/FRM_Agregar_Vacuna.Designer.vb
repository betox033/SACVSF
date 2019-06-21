<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Agregar_Vacuna
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
        Me.lbl_unidad = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbProducto = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_adecuar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBusSto = New System.Windows.Forms.TextBox()
        Me.txtBusNom = New System.Windows.Forms.TextBox()
        Me.txtBusCodigo = New System.Windows.Forms.TextBox()
        Me.btn_stock = New System.Windows.Forms.Button()
        Me.btn_nombre = New System.Windows.Forms.Button()
        Me.btn_codigo = New System.Windows.Forms.Button()
        Me.lst_vacunas = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtp_prox_vacuna = New System.Windows.Forms.DateTimePicker()
        Me.txt_dosis = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNulo = New System.Windows.Forms.RadioButton()
        Me.rb_primera = New System.Windows.Forms.RadioButton()
        Me.rb_cuarta = New System.Windows.Forms.RadioButton()
        Me.rb_segunda = New System.Windows.Forms.RadioButton()
        Me.rb_tercera = New System.Windows.Forms.RadioButton()
        Me.chbSinFecha = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.lbl_unidad)
        Me.Panel1.Controls.Add(Me.lbl_stock)
        Me.Panel1.Controls.Add(Me.lbl_precio)
        Me.Panel1.Controls.Add(Me.lbl_proveedor)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Controls.Add(Me.lbl_codigo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbProducto)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(325, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 208)
        Me.Panel1.TabIndex = 1
        '
        'lbl_unidad
        '
        Me.lbl_unidad.AutoSize = True
        Me.lbl_unidad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unidad.Location = New System.Drawing.Point(276, 176)
        Me.lbl_unidad.Name = "lbl_unidad"
        Me.lbl_unidad.Size = New System.Drawing.Size(70, 21)
        Me.lbl_unidad.TabIndex = 13
        Me.lbl_unidad.Text = "Label17"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.Location = New System.Drawing.Point(266, 150)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(70, 21)
        Me.lbl_stock.TabIndex = 12
        Me.lbl_stock.Text = "Label16"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(272, 124)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(70, 21)
        Me.lbl_precio.TabIndex = 11
        Me.lbl_precio.Text = "Label15"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proveedor.Location = New System.Drawing.Point(298, 100)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(70, 21)
        Me.lbl_proveedor.TabIndex = 10
        Me.lbl_proveedor.Text = "Label14"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(298, 72)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(70, 21)
        Me.lbl_nombre.TabIndex = 9
        Me.lbl_nombre.Text = "Label13"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(333, 48)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(70, 21)
        Me.lbl_codigo.TabIndex = 8
        Me.lbl_codigo.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(261, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 21)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "DATOS DE LA VACUNA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(207, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 21)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Unidad : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stock : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Precio : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Proveedor : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod. Producto : "
        '
        'pbProducto
        '
        Me.pbProducto.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.cosa
        Me.pbProducto.Location = New System.Drawing.Point(15, 15)
        Me.pbProducto.Name = "pbProducto"
        Me.pbProducto.Size = New System.Drawing.Size(182, 177)
        Me.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProducto.TabIndex = 0
        Me.pbProducto.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.btn_cancelar)
        Me.Panel4.Controls.Add(Me.btn_agregar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 440)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(903, 45)
        Me.Panel4.TabIndex = 4
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(161, 6)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(138, 32)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.White
        Me.btn_agregar.Location = New System.Drawing.Point(18, 6)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(131, 33)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.txt_adecuar)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.lbl_fecha)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(903, 64)
        Me.Panel5.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(321, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 24)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "AGREGAR VACUNA"
        '
        'txt_adecuar
        '
        Me.txt_adecuar.Location = New System.Drawing.Point(731, 13)
        Me.txt_adecuar.Name = "txt_adecuar"
        Me.txt_adecuar.Size = New System.Drawing.Size(100, 20)
        Me.txt_adecuar.TabIndex = 5
        Me.txt_adecuar.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Adecuar"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.White
        Me.lbl_fecha.Location = New System.Drawing.Point(797, 43)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(83, 20)
        Me.lbl_fecha.TabIndex = 1
        Me.lbl_fecha.Text = "21-09-2018"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(733, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha : "
        '
        'txtBusSto
        '
        Me.txtBusSto.Location = New System.Drawing.Point(241, 394)
        Me.txtBusSto.Name = "txtBusSto"
        Me.txtBusSto.Size = New System.Drawing.Size(66, 20)
        Me.txtBusSto.TabIndex = 13
        '
        'txtBusNom
        '
        Me.txtBusNom.Location = New System.Drawing.Point(64, 394)
        Me.txtBusNom.Name = "txtBusNom"
        Me.txtBusNom.Size = New System.Drawing.Size(170, 20)
        Me.txtBusNom.TabIndex = 12
        '
        'txtBusCodigo
        '
        Me.txtBusCodigo.Location = New System.Drawing.Point(14, 394)
        Me.txtBusCodigo.Name = "txtBusCodigo"
        Me.txtBusCodigo.Size = New System.Drawing.Size(45, 20)
        Me.txtBusCodigo.TabIndex = 11
        '
        'btn_stock
        '
        Me.btn_stock.BackColor = System.Drawing.Color.LightGray
        Me.btn_stock.FlatAppearance.BorderSize = 0
        Me.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stock.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stock.Location = New System.Drawing.Point(242, 78)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(66, 23)
        Me.btn_stock.TabIndex = 10
        Me.btn_stock.Text = "STOCK"
        Me.btn_stock.UseVisualStyleBackColor = False
        '
        'btn_nombre
        '
        Me.btn_nombre.BackColor = System.Drawing.Color.LightGray
        Me.btn_nombre.FlatAppearance.BorderSize = 0
        Me.btn_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nombre.Location = New System.Drawing.Point(64, 78)
        Me.btn_nombre.Name = "btn_nombre"
        Me.btn_nombre.Size = New System.Drawing.Size(175, 23)
        Me.btn_nombre.TabIndex = 9
        Me.btn_nombre.Text = "NOMBRE"
        Me.btn_nombre.UseVisualStyleBackColor = False
        '
        'btn_codigo
        '
        Me.btn_codigo.BackColor = System.Drawing.Color.LightGray
        Me.btn_codigo.FlatAppearance.BorderSize = 0
        Me.btn_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_codigo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_codigo.Location = New System.Drawing.Point(14, 78)
        Me.btn_codigo.Name = "btn_codigo"
        Me.btn_codigo.Size = New System.Drawing.Size(46, 23)
        Me.btn_codigo.TabIndex = 8
        Me.btn_codigo.Text = "COD "
        Me.btn_codigo.UseVisualStyleBackColor = False
        '
        'lst_vacunas
        '
        Me.lst_vacunas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_vacunas.FormattingEnabled = True
        Me.lst_vacunas.ItemHeight = 15
        Me.lst_vacunas.Location = New System.Drawing.Point(12, 110)
        Me.lst_vacunas.Name = "lst_vacunas"
        Me.lst_vacunas.Size = New System.Drawing.Size(296, 274)
        Me.lst_vacunas.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 20)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "F. prox Vacuna : "
        '
        'dtp_prox_vacuna
        '
        Me.dtp_prox_vacuna.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_prox_vacuna.Location = New System.Drawing.Point(141, 16)
        Me.dtp_prox_vacuna.Name = "dtp_prox_vacuna"
        Me.dtp_prox_vacuna.Size = New System.Drawing.Size(273, 23)
        Me.dtp_prox_vacuna.TabIndex = 17
        '
        'txt_dosis
        '
        Me.txt_dosis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dosis.Location = New System.Drawing.Point(380, 359)
        Me.txt_dosis.MaxLength = 7
        Me.txt_dosis.Name = "txt_dosis"
        Me.txt_dosis.Size = New System.Drawing.Size(78, 23)
        Me.txt_dosis.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Dosis : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNulo)
        Me.GroupBox1.Controls.Add(Me.rb_primera)
        Me.GroupBox1.Controls.Add(Me.rb_cuarta)
        Me.GroupBox1.Controls.Add(Me.rb_segunda)
        Me.GroupBox1.Controls.Add(Me.rb_tercera)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 42)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'rbNulo
        '
        Me.rbNulo.AutoSize = True
        Me.rbNulo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNulo.Location = New System.Drawing.Point(19, 15)
        Me.rbNulo.Name = "rbNulo"
        Me.rbNulo.Size = New System.Drawing.Size(30, 21)
        Me.rbNulo.TabIndex = 4
        Me.rbNulo.TabStop = True
        Me.rbNulo.Text = "-"
        Me.rbNulo.UseVisualStyleBackColor = True
        '
        'rb_primera
        '
        Me.rb_primera.AutoSize = True
        Me.rb_primera.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_primera.Location = New System.Drawing.Point(101, 15)
        Me.rb_primera.Name = "rb_primera"
        Me.rb_primera.Size = New System.Drawing.Size(75, 21)
        Me.rb_primera.TabIndex = 0
        Me.rb_primera.TabStop = True
        Me.rb_primera.Text = "Primera"
        Me.rb_primera.UseVisualStyleBackColor = True
        '
        'rb_cuarta
        '
        Me.rb_cuarta.AutoSize = True
        Me.rb_cuarta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_cuarta.Location = New System.Drawing.Point(470, 15)
        Me.rb_cuarta.Name = "rb_cuarta"
        Me.rb_cuarta.Size = New System.Drawing.Size(72, 21)
        Me.rb_cuarta.TabIndex = 3
        Me.rb_cuarta.TabStop = True
        Me.rb_cuarta.Text = "Cuarta"
        Me.rb_cuarta.UseVisualStyleBackColor = True
        '
        'rb_segunda
        '
        Me.rb_segunda.AutoSize = True
        Me.rb_segunda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_segunda.Location = New System.Drawing.Point(215, 15)
        Me.rb_segunda.Name = "rb_segunda"
        Me.rb_segunda.Size = New System.Drawing.Size(83, 21)
        Me.rb_segunda.TabIndex = 1
        Me.rb_segunda.TabStop = True
        Me.rb_segunda.Text = "Segunda"
        Me.rb_segunda.UseVisualStyleBackColor = True
        '
        'rb_tercera
        '
        Me.rb_tercera.AutoSize = True
        Me.rb_tercera.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_tercera.Location = New System.Drawing.Point(343, 15)
        Me.rb_tercera.Name = "rb_tercera"
        Me.rb_tercera.Size = New System.Drawing.Size(72, 21)
        Me.rb_tercera.TabIndex = 2
        Me.rb_tercera.TabStop = True
        Me.rb_tercera.Text = "Tercera"
        Me.rb_tercera.UseVisualStyleBackColor = True
        '
        'chbSinFecha
        '
        Me.chbSinFecha.AutoSize = True
        Me.chbSinFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSinFecha.Location = New System.Drawing.Point(148, 48)
        Me.chbSinFecha.Name = "chbSinFecha"
        Me.chbSinFecha.Size = New System.Drawing.Size(158, 21)
        Me.chbSinFecha.TabIndex = 19
        Me.chbSinFecha.Text = "No establecer fecha"
        Me.chbSinFecha.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.chbSinFecha)
        Me.GroupBox2.Controls.Add(Me.dtp_prox_vacuna)
        Me.GroupBox2.Location = New System.Drawing.Point(466, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 80)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'FRM_Agregar_Vacuna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(903, 485)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_dosis)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBusSto)
        Me.Controls.Add(Me.txtBusNom)
        Me.Controls.Add(Me.txtBusCodigo)
        Me.Controls.Add(Me.btn_stock)
        Me.Controls.Add(Me.btn_nombre)
        Me.Controls.Add(Me.btn_codigo)
        Me.Controls.Add(Me.lst_vacunas)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_Agregar_Vacuna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR VACUNA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbProducto As PictureBox
    Friend WithEvents lbl_unidad As Label
    Friend WithEvents lbl_stock As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_proveedor As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_adecuar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBusSto As TextBox
    Friend WithEvents txtBusNom As TextBox
    Friend WithEvents txtBusCodigo As TextBox
    Friend WithEvents btn_stock As Button
    Friend WithEvents btn_nombre As Button
    Friend WithEvents btn_codigo As Button
    Friend WithEvents lst_vacunas As ListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dtp_prox_vacuna As DateTimePicker
    Friend WithEvents txt_dosis As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_primera As RadioButton
    Friend WithEvents rb_cuarta As RadioButton
    Friend WithEvents rb_segunda As RadioButton
    Friend WithEvents rb_tercera As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents rbNulo As RadioButton
    Friend WithEvents chbSinFecha As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

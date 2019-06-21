<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Mantenedor_Clientes
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lst_clientes = New System.Windows.Forms.ListBox()
        Me.btn_ordenar_rut = New System.Windows.Forms.Button()
        Me.btn_ordenar_nombre = New System.Windows.Forms.Button()
        Me.panel_datos = New System.Windows.Forms.Panel()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.pbCliente = New System.Windows.Forms.PictureBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_fono = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_datos = New System.Windows.Forms.Label()
        Me.txt_busqueda_rut = New System.Windows.Forms.TextBox()
        Me.txt_busqueda_nombre = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txt_prueba = New System.Windows.Forms.TextBox()
        Me.btn_ordenar_num = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_busqueda_num = New System.Windows.Forms.TextBox()
        Me.panel_datos.SuspendLayout()
        CType(Me.pbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(643, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lst_clientes
        '
        Me.lst_clientes.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_clientes.FormattingEnabled = True
        Me.lst_clientes.ItemHeight = 18
        Me.lst_clientes.Location = New System.Drawing.Point(24, 103)
        Me.lst_clientes.Name = "lst_clientes"
        Me.lst_clientes.Size = New System.Drawing.Size(400, 292)
        Me.lst_clientes.TabIndex = 1
        '
        'btn_ordenar_rut
        '
        Me.btn_ordenar_rut.BackColor = System.Drawing.Color.LightGray
        Me.btn_ordenar_rut.FlatAppearance.BorderSize = 0
        Me.btn_ordenar_rut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ordenar_rut.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ordenar_rut.Location = New System.Drawing.Point(82, 75)
        Me.btn_ordenar_rut.Name = "btn_ordenar_rut"
        Me.btn_ordenar_rut.Size = New System.Drawing.Size(90, 23)
        Me.btn_ordenar_rut.TabIndex = 2
        Me.btn_ordenar_rut.Text = "RUT"
        Me.btn_ordenar_rut.UseVisualStyleBackColor = False
        '
        'btn_ordenar_nombre
        '
        Me.btn_ordenar_nombre.BackColor = System.Drawing.Color.LightGray
        Me.btn_ordenar_nombre.FlatAppearance.BorderSize = 0
        Me.btn_ordenar_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ordenar_nombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ordenar_nombre.Location = New System.Drawing.Point(178, 75)
        Me.btn_ordenar_nombre.Name = "btn_ordenar_nombre"
        Me.btn_ordenar_nombre.Size = New System.Drawing.Size(244, 23)
        Me.btn_ordenar_nombre.TabIndex = 3
        Me.btn_ordenar_nombre.Text = "NOMBRE"
        Me.btn_ordenar_nombre.UseVisualStyleBackColor = False
        '
        'panel_datos
        '
        Me.panel_datos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panel_datos.Controls.Add(Me.btnQuitarImagen)
        Me.panel_datos.Controls.Add(Me.btnCargarImagen)
        Me.panel_datos.Controls.Add(Me.pbCliente)
        Me.panel_datos.Controls.Add(Me.lbl_numero)
        Me.panel_datos.Controls.Add(Me.Label7)
        Me.panel_datos.Controls.Add(Me.btn_cancelar)
        Me.panel_datos.Controls.Add(Me.btn_guardar)
        Me.panel_datos.Controls.Add(Me.txt_correo)
        Me.panel_datos.Controls.Add(Me.txt_fono)
        Me.panel_datos.Controls.Add(Me.txt_direccion)
        Me.panel_datos.Controls.Add(Me.txt_nombre)
        Me.panel_datos.Controls.Add(Me.txt_rut)
        Me.panel_datos.Controls.Add(Me.Label5)
        Me.panel_datos.Controls.Add(Me.Label4)
        Me.panel_datos.Controls.Add(Me.Label3)
        Me.panel_datos.Controls.Add(Me.Label2)
        Me.panel_datos.Controls.Add(Me.Label1)
        Me.panel_datos.Controls.Add(Me.lbl_datos)
        Me.panel_datos.Location = New System.Drawing.Point(455, -2)
        Me.panel_datos.Name = "panel_datos"
        Me.panel_datos.Size = New System.Drawing.Size(310, 457)
        Me.panel_datos.TabIndex = 5
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.BackColor = System.Drawing.Color.Red
        Me.btnQuitarImagen.FlatAppearance.BorderSize = 0
        Me.btnQuitarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarImagen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarImagen.ForeColor = System.Drawing.Color.White
        Me.btnQuitarImagen.Location = New System.Drawing.Point(218, 200)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.Size = New System.Drawing.Size(23, 23)
        Me.btnQuitarImagen.TabIndex = 27
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
        Me.btnCargarImagen.Location = New System.Drawing.Point(101, 200)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(111, 23)
        Me.btnCargarImagen.TabIndex = 26
        Me.btnCargarImagen.Text = "Cargar Imagen..."
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        Me.btnCargarImagen.Visible = False
        '
        'pbCliente
        '
        Me.pbCliente.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.user_symbol_318_63527
        Me.pbCliente.Location = New System.Drawing.Point(101, 53)
        Me.pbCliente.Name = "pbCliente"
        Me.pbCliente.Size = New System.Drawing.Size(140, 140)
        Me.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCliente.TabIndex = 25
        Me.pbCliente.TabStop = False
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_numero.Location = New System.Drawing.Point(105, 233)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(16, 17)
        Me.lbl_numero.TabIndex = 24
        Me.lbl_numero.Text = "n"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(16, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Número : "
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.LightGray
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(169, 411)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(115, 27)
        Me.btn_cancelar.TabIndex = 22
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        Me.btn_cancelar.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.LightGray
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(46, 411)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(115, 27)
        Me.btn_guardar.TabIndex = 21
        Me.btn_guardar.Text = "ACEPTAR"
        Me.btn_guardar.UseVisualStyleBackColor = False
        Me.btn_guardar.Visible = False
        '
        'txt_correo
        '
        Me.txt_correo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_correo.Location = New System.Drawing.Point(108, 368)
        Me.txt_correo.MaxLength = 40
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(187, 23)
        Me.txt_correo.TabIndex = 19
        '
        'txt_fono
        '
        Me.txt_fono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fono.Location = New System.Drawing.Point(108, 341)
        Me.txt_fono.MaxLength = 20
        Me.txt_fono.Name = "txt_fono"
        Me.txt_fono.Size = New System.Drawing.Size(187, 23)
        Me.txt_fono.TabIndex = 18
        '
        'txt_direccion
        '
        Me.txt_direccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(108, 313)
        Me.txt_direccion.MaxLength = 50
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(187, 23)
        Me.txt_direccion.TabIndex = 17
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(108, 256)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(187, 23)
        Me.txt_nombre.TabIndex = 15
        '
        'txt_rut
        '
        Me.txt_rut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rut.Location = New System.Drawing.Point(108, 285)
        Me.txt_rut.MaxLength = 12
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(187, 23)
        Me.txt_rut.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(15, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Correo : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(17, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fono : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(17, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dirección : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(15, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(16, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RUT : "
        '
        'lbl_datos
        '
        Me.lbl_datos.AutoSize = True
        Me.lbl_datos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datos.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_datos.Location = New System.Drawing.Point(89, 24)
        Me.lbl_datos.Name = "lbl_datos"
        Me.lbl_datos.Size = New System.Drawing.Size(164, 21)
        Me.lbl_datos.TabIndex = 0
        Me.lbl_datos.Text = "DATOS DEL CLIENTE"
        '
        'txt_busqueda_rut
        '
        Me.txt_busqueda_rut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_rut.Location = New System.Drawing.Point(84, 403)
        Me.txt_busqueda_rut.Name = "txt_busqueda_rut"
        Me.txt_busqueda_rut.Size = New System.Drawing.Size(90, 23)
        Me.txt_busqueda_rut.TabIndex = 6
        '
        'txt_busqueda_nombre
        '
        Me.txt_busqueda_nombre.BackColor = System.Drawing.SystemColors.Window
        Me.txt_busqueda_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_nombre.Location = New System.Drawing.Point(180, 403)
        Me.txt_busqueda_nombre.Name = "txt_busqueda_nombre"
        Me.txt_busqueda_nombre.Size = New System.Drawing.Size(244, 23)
        Me.txt_busqueda_nombre.TabIndex = 7
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.LightGray
        Me.btn_agregar.Location = New System.Drawing.Point(12, 10)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(139, 32)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.LightGray
        Me.btn_modificar.Location = New System.Drawing.Point(157, 10)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(126, 32)
        Me.btn_modificar.TabIndex = 10
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.LightGray
        Me.btn_eliminar.Location = New System.Drawing.Point(289, 10)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(125, 32)
        Me.btn_eliminar.TabIndex = 11
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.btnSeleccionar)
        Me.Panel2.Controls.Add(Me.btn_agregar)
        Me.Panel2.Controls.Add(Me.btn_eliminar)
        Me.Panel2.Controls.Add(Me.btn_modificar)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 449)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(765, 53)
        Me.Panel2.TabIndex = 12
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.LightGray
        Me.btnSeleccionar.Location = New System.Drawing.Point(420, 10)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(211, 32)
        Me.btnSeleccionar.TabIndex = 12
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        Me.btnSeleccionar.Visible = False
        '
        'txt_prueba
        '
        Me.txt_prueba.Location = New System.Drawing.Point(386, 18)
        Me.txt_prueba.Name = "txt_prueba"
        Me.txt_prueba.Size = New System.Drawing.Size(36, 20)
        Me.txt_prueba.TabIndex = 12
        Me.txt_prueba.Visible = False
        '
        'btn_ordenar_num
        '
        Me.btn_ordenar_num.BackColor = System.Drawing.Color.LightGray
        Me.btn_ordenar_num.FlatAppearance.BorderSize = 0
        Me.btn_ordenar_num.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ordenar_num.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ordenar_num.Location = New System.Drawing.Point(24, 75)
        Me.btn_ordenar_num.Name = "btn_ordenar_num"
        Me.btn_ordenar_num.Size = New System.Drawing.Size(54, 23)
        Me.btn_ordenar_num.TabIndex = 14
        Me.btn_ordenar_num.Text = "NUM"
        Me.btn_ordenar_num.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "MANTENEDOR DE CLIENTES"
        '
        'txt_busqueda_num
        '
        Me.txt_busqueda_num.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_num.Location = New System.Drawing.Point(24, 403)
        Me.txt_busqueda_num.Name = "txt_busqueda_num"
        Me.txt_busqueda_num.Size = New System.Drawing.Size(54, 23)
        Me.txt_busqueda_num.TabIndex = 15
        '
        'frm_Mantenedor_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_prueba)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_busqueda_num)
        Me.Controls.Add(Me.btn_ordenar_num)
        Me.Controls.Add(Me.txt_busqueda_nombre)
        Me.Controls.Add(Me.txt_busqueda_rut)
        Me.Controls.Add(Me.btn_ordenar_nombre)
        Me.Controls.Add(Me.btn_ordenar_rut)
        Me.Controls.Add(Me.lst_clientes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Mantenedor_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Clientes"
        Me.panel_datos.ResumeLayout(False)
        Me.panel_datos.PerformLayout()
        CType(Me.pbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lst_clientes As ListBox
    Friend WithEvents btn_ordenar_rut As Button
    Friend WithEvents btn_ordenar_nombre As Button
    Friend WithEvents panel_datos As Panel
    Friend WithEvents txt_busqueda_rut As TextBox
    Friend WithEvents txt_busqueda_nombre As TextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_datos As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_fono As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_rut As TextBox
    Friend WithEvents lbl_numero As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_ordenar_num As Button
    Friend WithEvents txt_prueba As TextBox
    Friend WithEvents pbCliente As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnQuitarImagen As Button
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents txt_busqueda_num As TextBox
    Friend WithEvents btnSeleccionar As Button
End Class

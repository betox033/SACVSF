<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Mantenedor_Mascotas
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
        Me.lst_mascotas = New System.Windows.Forms.ListBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbMinimizar = New System.Windows.Forms.PictureBox()
        Me.pbSalir = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIdRaza = New System.Windows.Forms.Label()
        Me.lblFono = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIdChip = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_fingreso = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.lbl_raza = New System.Windows.Forms.Label()
        Me.lbl_especie = New System.Windows.Forms.Label()
        Me.lbl_nac = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_5 = New System.Windows.Forms.Label()
        Me.lbl_4 = New System.Windows.Forms.Label()
        Me.lbl_6 = New System.Windows.Forms.Label()
        Me.lbl_7 = New System.Windows.Forms.Label()
        Me.lbl_8 = New System.Windows.Forms.Label()
        Me.pbMascota = New System.Windows.Forms.PictureBox()
        Me.btn_historial = New System.Windows.Forms.Button()
        Me.lbl_datos = New System.Windows.Forms.Label()
        Me.btn_ordenar_num = New System.Windows.Forms.Button()
        Me.btn_ordenar_cliente = New System.Windows.Forms.Button()
        Me.btn_ordenar_nombre = New System.Windows.Forms.Button()
        Me.btn_ordenar_raza = New System.Windows.Forms.Button()
        Me.txt_busqueda_num = New System.Windows.Forms.TextBox()
        Me.txt_busqueda_cliente = New System.Windows.Forms.TextBox()
        Me.txt_busqueda_nombre = New System.Windows.Forms.TextBox()
        Me.txt_busqueda_raza = New System.Windows.Forms.TextBox()
        Me.txt_busqueda_especie = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblApoyoIndex = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEspecie = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbMascota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_mascotas
        '
        Me.lst_mascotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_mascotas.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_mascotas.FormattingEnabled = True
        Me.lst_mascotas.ItemHeight = 18
        Me.lst_mascotas.Location = New System.Drawing.Point(12, 124)
        Me.lst_mascotas.Name = "lst_mascotas"
        Me.lst_mascotas.Size = New System.Drawing.Size(751, 326)
        Me.lst_mascotas.TabIndex = 19
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Chocolate
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_salir.Location = New System.Drawing.Point(1034, 11)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(138, 33)
        Me.btn_salir.TabIndex = 22
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbMinimizar)
        Me.Panel1.Controls.Add(Me.pbSalir)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.pbMascota)
        Me.Panel1.Controls.Add(Me.btn_historial)
        Me.Panel1.Controls.Add(Me.lbl_datos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(772, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 553)
        Me.Panel1.TabIndex = 23
        '
        'pbMinimizar
        '
        Me.pbMinimizar.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.min
        Me.pbMinimizar.Location = New System.Drawing.Point(366, 6)
        Me.pbMinimizar.Name = "pbMinimizar"
        Me.pbMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMinimizar.TabIndex = 35
        Me.pbMinimizar.TabStop = False
        '
        'pbSalir
        '
        Me.pbSalir.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.salir
        Me.pbSalir.Location = New System.Drawing.Point(387, 6)
        Me.pbSalir.Name = "pbSalir"
        Me.pbSalir.Size = New System.Drawing.Size(16, 16)
        Me.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSalir.TabIndex = 34
        Me.pbSalir.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblIdRaza)
        Me.GroupBox1.Controls.Add(Me.lblFono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblIdChip)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_fingreso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_color)
        Me.GroupBox1.Controls.Add(Me.lbl_sexo)
        Me.GroupBox1.Controls.Add(Me.lbl_raza)
        Me.GroupBox1.Controls.Add(Me.lbl_especie)
        Me.GroupBox1.Controls.Add(Me.lbl_nac)
        Me.GroupBox1.Controls.Add(Me.lbl_cliente)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_1)
        Me.GroupBox1.Controls.Add(Me.lbl_2)
        Me.GroupBox1.Controls.Add(Me.lbl_3)
        Me.GroupBox1.Controls.Add(Me.lbl_5)
        Me.GroupBox1.Controls.Add(Me.lbl_4)
        Me.GroupBox1.Controls.Add(Me.lbl_6)
        Me.GroupBox1.Controls.Add(Me.lbl_7)
        Me.GroupBox1.Controls.Add(Me.lbl_8)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 251)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'lblIdRaza
        '
        Me.lblIdRaza.AutoSize = True
        Me.lblIdRaza.Location = New System.Drawing.Point(7, 140)
        Me.lblIdRaza.Name = "lblIdRaza"
        Me.lblIdRaza.Size = New System.Drawing.Size(39, 13)
        Me.lblIdRaza.TabIndex = 54
        Me.lblIdRaza.Text = "Label5"
        Me.lblIdRaza.Visible = False
        '
        'lblFono
        '
        Me.lblFono.AutoSize = True
        Me.lblFono.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFono.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFono.Location = New System.Drawing.Point(93, 77)
        Me.lblFono.Name = "lblFono"
        Me.lblFono.Size = New System.Drawing.Size(57, 20)
        Me.lblFono.TabIndex = 53
        Me.lblFono.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(44, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fono :"
        '
        'lblIdChip
        '
        Me.lblIdChip.AutoSize = True
        Me.lblIdChip.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdChip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblIdChip.Location = New System.Drawing.Point(95, 223)
        Me.lblIdChip.Name = "lblIdChip"
        Me.lblIdChip.Size = New System.Drawing.Size(57, 20)
        Me.lblIdChip.TabIndex = 51
        Me.lblIdChip.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(25, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Id Chip : "
        '
        'lbl_fingreso
        '
        Me.lbl_fingreso.AutoSize = True
        Me.lbl_fingreso.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fingreso.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_fingreso.Location = New System.Drawing.Point(95, 204)
        Me.lbl_fingreso.Name = "lbl_fingreso"
        Me.lbl_fingreso.Size = New System.Drawing.Size(57, 20)
        Me.lbl_fingreso.TabIndex = 49
        Me.lbl_fingreso.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(39, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "F Ingr : "
        '
        'lbl_color
        '
        Me.lbl_color.AutoSize = True
        Me.lbl_color.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_color.Location = New System.Drawing.Point(94, 183)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(65, 20)
        Me.lbl_color.TabIndex = 47
        Me.lbl_color.Text = "Label10"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_sexo.Location = New System.Drawing.Point(94, 159)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(57, 20)
        Me.lbl_sexo.TabIndex = 46
        Me.lbl_sexo.Text = "Label9"
        '
        'lbl_raza
        '
        Me.lbl_raza.AutoSize = True
        Me.lbl_raza.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_raza.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_raza.Location = New System.Drawing.Point(93, 136)
        Me.lbl_raza.Name = "lbl_raza"
        Me.lbl_raza.Size = New System.Drawing.Size(57, 20)
        Me.lbl_raza.TabIndex = 45
        Me.lbl_raza.Text = "Label8"
        '
        'lbl_especie
        '
        Me.lbl_especie.AutoSize = True
        Me.lbl_especie.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_especie.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_especie.Location = New System.Drawing.Point(93, 116)
        Me.lbl_especie.Name = "lbl_especie"
        Me.lbl_especie.Size = New System.Drawing.Size(57, 20)
        Me.lbl_especie.TabIndex = 44
        Me.lbl_especie.Text = "Label7"
        '
        'lbl_nac
        '
        Me.lbl_nac.AutoSize = True
        Me.lbl_nac.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nac.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_nac.Location = New System.Drawing.Point(94, 97)
        Me.lbl_nac.Name = "lbl_nac"
        Me.lbl_nac.Size = New System.Drawing.Size(57, 20)
        Me.lbl_nac.TabIndex = 43
        Me.lbl_nac.Text = "Label6"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_cliente.Location = New System.Drawing.Point(94, 56)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(57, 20)
        Me.lbl_cliente.TabIndex = 42
        Me.lbl_cliente.Text = "Label5"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_nombre.Location = New System.Drawing.Point(94, 36)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(57, 20)
        Me.lbl_nombre.TabIndex = 41
        Me.lbl_nombre.Text = "Label4"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_numero.Location = New System.Drawing.Point(94, 12)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(57, 20)
        Me.lbl_numero.TabIndex = 40
        Me.lbl_numero.Text = "Label3"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_1.Location = New System.Drawing.Point(6, 12)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(95, 20)
        Me.lbl_1.TabIndex = 32
        Me.lbl_1.Text = "N° Interno : "
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_2.Location = New System.Drawing.Point(21, 35)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(80, 20)
        Me.lbl_2.TabIndex = 33
        Me.lbl_2.Text = "Nombre : "
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_3.Location = New System.Drawing.Point(31, 55)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(70, 20)
        Me.lbl_3.TabIndex = 34
        Me.lbl_3.Text = "Dueño : "
        '
        'lbl_5
        '
        Me.lbl_5.AutoSize = True
        Me.lbl_5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_5.Location = New System.Drawing.Point(23, 116)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(78, 20)
        Me.lbl_5.TabIndex = 35
        Me.lbl_5.Text = "Especie : "
        '
        'lbl_4
        '
        Me.lbl_4.AutoSize = True
        Me.lbl_4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_4.Location = New System.Drawing.Point(34, 95)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(67, 20)
        Me.lbl_4.TabIndex = 36
        Me.lbl_4.Text = "F. Nac : "
        '
        'lbl_6
        '
        Me.lbl_6.AutoSize = True
        Me.lbl_6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_6.Location = New System.Drawing.Point(45, 136)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(56, 20)
        Me.lbl_6.TabIndex = 37
        Me.lbl_6.Text = "Raza : "
        '
        'lbl_7
        '
        Me.lbl_7.AutoSize = True
        Me.lbl_7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_7.Location = New System.Drawing.Point(46, 159)
        Me.lbl_7.Name = "lbl_7"
        Me.lbl_7.Size = New System.Drawing.Size(55, 20)
        Me.lbl_7.TabIndex = 38
        Me.lbl_7.Text = "Sexo : "
        '
        'lbl_8
        '
        Me.lbl_8.AutoSize = True
        Me.lbl_8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_8.Location = New System.Drawing.Point(39, 182)
        Me.lbl_8.Name = "lbl_8"
        Me.lbl_8.Size = New System.Drawing.Size(61, 20)
        Me.lbl_8.TabIndex = 39
        Me.lbl_8.Text = "Color : "
        '
        'pbMascota
        '
        Me.pbMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbMascota.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.mascotaSilueta
        Me.pbMascota.Location = New System.Drawing.Point(152, 53)
        Me.pbMascota.Name = "pbMascota"
        Me.pbMascota.Size = New System.Drawing.Size(140, 140)
        Me.pbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMascota.TabIndex = 32
        Me.pbMascota.TabStop = False
        '
        'btn_historial
        '
        Me.btn_historial.BackColor = System.Drawing.Color.Chocolate
        Me.btn_historial.FlatAppearance.BorderSize = 0
        Me.btn_historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_historial.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_historial.Location = New System.Drawing.Point(106, 460)
        Me.btn_historial.Name = "btn_historial"
        Me.btn_historial.Size = New System.Drawing.Size(225, 29)
        Me.btn_historial.TabIndex = 29
        Me.btn_historial.Text = "VER HISTORIAL MÉDICO"
        Me.btn_historial.UseVisualStyleBackColor = False
        '
        'lbl_datos
        '
        Me.lbl_datos.AutoSize = True
        Me.lbl_datos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_datos.Location = New System.Drawing.Point(125, 23)
        Me.lbl_datos.Name = "lbl_datos"
        Me.lbl_datos.Size = New System.Drawing.Size(202, 21)
        Me.lbl_datos.TabIndex = 20
        Me.lbl_datos.Text = "DATOS DE LA MASCOTA"
        '
        'btn_ordenar_num
        '
        Me.btn_ordenar_num.BackColor = System.Drawing.Color.LightGray
        Me.btn_ordenar_num.FlatAppearance.BorderSize = 0
        Me.btn_ordenar_num.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ordenar_num.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ordenar_num.Location = New System.Drawing.Point(12, 97)
        Me.btn_ordenar_num.Name = "btn_ordenar_num"
        Me.btn_ordenar_num.Size = New System.Drawing.Size(51, 23)
        Me.btn_ordenar_num.TabIndex = 25
        Me.btn_ordenar_num.Text = "NUM"
        Me.btn_ordenar_num.UseVisualStyleBackColor = False
        '
        'btn_ordenar_cliente
        '
        Me.btn_ordenar_cliente.BackColor = System.Drawing.Color.LightGray
        Me.btn_ordenar_cliente.FlatAppearance.BorderSize = 0
        Me.btn_ordenar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ordenar_cliente.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ordenar_cliente.Location = New System.Drawing.Point(504, 97)
        Me.btn_ordenar_cliente.Name = "btn_ordenar_cliente"
        Me.btn_ordenar_cliente.Size = New System.Drawing.Size(259, 23)
        Me.btn_ordenar_cliente.TabIndex = 26
        Me.btn_ordenar_cliente.Text = "NOMBRE DUEÑO"
        Me.btn_ordenar_cliente.UseVisualStyleBackColor = False
        '
        'btn_ordenar_nombre
        '
        Me.btn_ordenar_nombre.BackColor = System.Drawing.Color.LightGray
        Me.btn_ordenar_nombre.FlatAppearance.BorderSize = 0
        Me.btn_ordenar_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ordenar_nombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ordenar_nombre.Location = New System.Drawing.Point(69, 97)
        Me.btn_ordenar_nombre.Name = "btn_ordenar_nombre"
        Me.btn_ordenar_nombre.Size = New System.Drawing.Size(180, 23)
        Me.btn_ordenar_nombre.TabIndex = 27
        Me.btn_ordenar_nombre.Text = "NOMBRE MASCOTA"
        Me.btn_ordenar_nombre.UseVisualStyleBackColor = False
        '
        'btn_ordenar_raza
        '
        Me.btn_ordenar_raza.BackColor = System.Drawing.Color.LightGray
        Me.btn_ordenar_raza.FlatAppearance.BorderSize = 0
        Me.btn_ordenar_raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ordenar_raza.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ordenar_raza.Location = New System.Drawing.Point(361, 97)
        Me.btn_ordenar_raza.Name = "btn_ordenar_raza"
        Me.btn_ordenar_raza.Size = New System.Drawing.Size(140, 23)
        Me.btn_ordenar_raza.TabIndex = 28
        Me.btn_ordenar_raza.Text = "RAZA"
        Me.btn_ordenar_raza.UseVisualStyleBackColor = False
        '
        'txt_busqueda_num
        '
        Me.txt_busqueda_num.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_num.Location = New System.Drawing.Point(13, 462)
        Me.txt_busqueda_num.Name = "txt_busqueda_num"
        Me.txt_busqueda_num.Size = New System.Drawing.Size(50, 23)
        Me.txt_busqueda_num.TabIndex = 30
        '
        'txt_busqueda_cliente
        '
        Me.txt_busqueda_cliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_cliente.Location = New System.Drawing.Point(504, 462)
        Me.txt_busqueda_cliente.Name = "txt_busqueda_cliente"
        Me.txt_busqueda_cliente.Size = New System.Drawing.Size(259, 23)
        Me.txt_busqueda_cliente.TabIndex = 31
        '
        'txt_busqueda_nombre
        '
        Me.txt_busqueda_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_nombre.Location = New System.Drawing.Point(69, 462)
        Me.txt_busqueda_nombre.Name = "txt_busqueda_nombre"
        Me.txt_busqueda_nombre.Size = New System.Drawing.Size(180, 23)
        Me.txt_busqueda_nombre.TabIndex = 32
        '
        'txt_busqueda_raza
        '
        Me.txt_busqueda_raza.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_raza.Location = New System.Drawing.Point(361, 462)
        Me.txt_busqueda_raza.Name = "txt_busqueda_raza"
        Me.txt_busqueda_raza.Size = New System.Drawing.Size(140, 23)
        Me.txt_busqueda_raza.TabIndex = 33
        '
        'txt_busqueda_especie
        '
        Me.txt_busqueda_especie.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_especie.Location = New System.Drawing.Point(255, 462)
        Me.txt_busqueda_especie.Name = "txt_busqueda_especie"
        Me.txt_busqueda_especie.Size = New System.Drawing.Size(100, 23)
        Me.txt_busqueda_especie.TabIndex = 34
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Chocolate
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnModificar.Location = New System.Drawing.Point(165, 11)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(145, 33)
        Me.btnModificar.TabIndex = 36
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Chocolate
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar.Location = New System.Drawing.Point(328, 11)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(137, 33)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSeleccionar)
        Me.Panel2.Controls.Add(Me.lblApoyoIndex)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btn_salir)
        Me.Panel2.Location = New System.Drawing.Point(0, 500)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1285, 53)
        Me.Panel2.TabIndex = 38
        '
        'lblApoyoIndex
        '
        Me.lblApoyoIndex.AutoSize = True
        Me.lblApoyoIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblApoyoIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApoyoIndex.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblApoyoIndex.Location = New System.Drawing.Point(551, 11)
        Me.lblApoyoIndex.Name = "lblApoyoIndex"
        Me.lblApoyoIndex.Size = New System.Drawing.Size(23, 20)
        Me.lblApoyoIndex.TabIndex = 38
        Me.lblApoyoIndex.Text = "-1"
        Me.lblApoyoIndex.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Chocolate
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.Location = New System.Drawing.Point(21, 11)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(138, 33)
        Me.btnAgregar.TabIndex = 35
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 24)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "MANTENEDOR DE MASCOTAS"
        '
        'btnEspecie
        '
        Me.btnEspecie.BackColor = System.Drawing.Color.LightGray
        Me.btnEspecie.FlatAppearance.BorderSize = 0
        Me.btnEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEspecie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEspecie.Location = New System.Drawing.Point(255, 97)
        Me.btnEspecie.Name = "btnEspecie"
        Me.btnEspecie.Size = New System.Drawing.Size(100, 23)
        Me.btnEspecie.TabIndex = 40
        Me.btnEspecie.Text = "ESPECIE"
        Me.btnEspecie.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.White
        Me.btnSeleccionar.Location = New System.Drawing.Point(591, 11)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(236, 33)
        Me.btnSeleccionar.TabIndex = 39
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        Me.btnSeleccionar.Visible = False
        '
        'frm_Mantenedor_Mascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1183, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEspecie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_busqueda_especie)
        Me.Controls.Add(Me.txt_busqueda_raza)
        Me.Controls.Add(Me.txt_busqueda_nombre)
        Me.Controls.Add(Me.txt_busqueda_cliente)
        Me.Controls.Add(Me.txt_busqueda_num)
        Me.Controls.Add(Me.btn_ordenar_raza)
        Me.Controls.Add(Me.btn_ordenar_nombre)
        Me.Controls.Add(Me.btn_ordenar_cliente)
        Me.Controls.Add(Me.btn_ordenar_num)
        Me.Controls.Add(Me.lst_mascotas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Mantenedor_Mascotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Mascotas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbMascota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_mascotas As ListBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents lbl_datos As Label
    Friend WithEvents btn_historial As Button
    Friend WithEvents btn_ordenar_num As Button
    Friend WithEvents btn_ordenar_cliente As Button
    Friend WithEvents btn_ordenar_nombre As Button
    Friend WithEvents btn_ordenar_raza As Button
    Friend WithEvents txt_busqueda_num As TextBox
    Friend WithEvents txt_busqueda_cliente As TextBox
    Friend WithEvents txt_busqueda_nombre As TextBox
    Friend WithEvents txt_busqueda_raza As TextBox
    Friend WithEvents txt_busqueda_especie As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbMascota As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_fingreso As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents lbl_raza As Label
    Friend WithEvents lbl_especie As Label
    Friend WithEvents lbl_nac As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_numero As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents lbl_3 As Label
    Friend WithEvents lbl_5 As Label
    Friend WithEvents lbl_4 As Label
    Friend WithEvents lbl_6 As Label
    Friend WithEvents lbl_7 As Label
    Friend WithEvents lbl_8 As Label
    Friend WithEvents lblApoyoIndex As Label
    Friend WithEvents lblIdChip As Label
    Friend WithEvents Label2 As Label
    Public WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pbMinimizar As PictureBox
    Friend WithEvents pbSalir As PictureBox
    Friend WithEvents btnEspecie As Button
    Friend WithEvents lblFono As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblIdRaza As Label
    Friend WithEvents btnSeleccionar As Button
End Class

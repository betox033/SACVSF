<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ficha_general
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ficha_general))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_generar_num_mascota = New System.Windows.Forms.Button()
        Me.txt_auxiliar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.rb_hembra = New System.Windows.Forms.RadioButton()
        Me.rb_macho = New System.Windows.Forms.RadioButton()
        Me.dtp_nac = New System.Windows.Forms.DateTimePicker()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttp_mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fingreso = New System.Windows.Forms.TextBox()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.txtPrueba = New System.Windows.Forms.TextBox()
        Me.pbCliente = New System.Windows.Forms.PictureBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl_num_cliente = New System.Windows.Forms.Label()
        Me.txtIdChip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.pbMascota = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelCliente = New System.Windows.Forms.Panel()
        Me.btn_cambiarCliente = New System.Windows.Forms.Button()
        Me.panelLista = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstMascotasCliente = New System.Windows.Forms.ListBox()
        Me.cl = New System.Windows.Forms.Panel()
        Me.panelMascota = New System.Windows.Forms.Panel()
        Me.cmbRazas = New System.Windows.Forms.ComboBox()
        Me.cmbEspecies = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelSeleccionar = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbAgregarCliente = New System.Windows.Forms.PictureBox()
        Me.btnVolverCliente = New System.Windows.Forms.Button()
        Me.btnVPre2 = New System.Windows.Forms.Button()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCambiarNumFicha = New System.Windows.Forms.Button()
        Me.txtCambiarNumFicha = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMascota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCliente.SuspendLayout()
        Me.panelLista.SuspendLayout()
        Me.cl.SuspendLayout()
        Me.panelMascota.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panelSeleccionar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbAgregarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATOS DEL CLIENTE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_generar_num_mascota)
        Me.Panel1.Controls.Add(Me.txt_auxiliar)
        Me.Panel1.Location = New System.Drawing.Point(-5, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 37)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(823, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "_________________________________________________________________________________" &
    "_______________________________________________________"
        '
        'btn_generar_num_mascota
        '
        Me.btn_generar_num_mascota.Location = New System.Drawing.Point(648, 3)
        Me.btn_generar_num_mascota.Name = "btn_generar_num_mascota"
        Me.btn_generar_num_mascota.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar_num_mascota.TabIndex = 41
        Me.btn_generar_num_mascota.Text = "Adecuar"
        Me.btn_generar_num_mascota.UseVisualStyleBackColor = True
        Me.btn_generar_num_mascota.Visible = False
        '
        'txt_auxiliar
        '
        Me.txt_auxiliar.Location = New System.Drawing.Point(734, 4)
        Me.txt_auxiliar.Name = "txt_auxiliar"
        Me.txt_auxiliar.Size = New System.Drawing.Size(100, 20)
        Me.txt_auxiliar.TabIndex = 40
        Me.txt_auxiliar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(-5, 348)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(890, 37)
        Me.Panel2.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(326, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DATOS DEL PACIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.YellowGreen
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(823, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "_________________________________________________________________________________" &
    "_______________________________________________________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Nombre : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(164, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Especie : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(478, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 21)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "F. Nacimiento :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(184, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 21)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Raza : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(544, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 21)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Color :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(186, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 21)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Sexo : "
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(245, 29)
        Me.txt_nombre.MaxLength = 20
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(215, 26)
        Me.txt_nombre.TabIndex = 15
        '
        'rb_hembra
        '
        Me.rb_hembra.AutoSize = True
        Me.rb_hembra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_hembra.Location = New System.Drawing.Point(6, 13)
        Me.rb_hembra.Name = "rb_hembra"
        Me.rb_hembra.Size = New System.Drawing.Size(89, 21)
        Me.rb_hembra.TabIndex = 18
        Me.rb_hembra.TabStop = True
        Me.rb_hembra.Text = "Femenino"
        Me.rb_hembra.UseVisualStyleBackColor = True
        '
        'rb_macho
        '
        Me.rb_macho.AutoSize = True
        Me.rb_macho.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_macho.Location = New System.Drawing.Point(97, 13)
        Me.rb_macho.Name = "rb_macho"
        Me.rb_macho.Size = New System.Drawing.Size(90, 21)
        Me.rb_macho.TabIndex = 19
        Me.rb_macho.TabStop = True
        Me.rb_macho.Text = "Masculino"
        Me.rb_macho.UseVisualStyleBackColor = True
        '
        'dtp_nac
        '
        Me.dtp_nac.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_nac.Location = New System.Drawing.Point(605, 28)
        Me.dtp_nac.Name = "dtp_nac"
        Me.dtp_nac.Size = New System.Drawing.Size(265, 23)
        Me.dtp_nac.TabIndex = 20
        Me.dtp_nac.Value = New Date(2018, 7, 8, 0, 0, 0, 0)
        '
        'txt_color
        '
        Me.txt_color.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(606, 58)
        Me.txt_color.MaxLength = 10
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(145, 26)
        Me.txt_color.TabIndex = 21
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.LightGray
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(323, 589)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(121, 39)
        Me.btn_agregar.TabIndex = 22
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.LightGray
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(450, 589)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 40)
        Me.btn_cancelar.TabIndex = 23
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(171, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(568, 24)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Clínica Veterinaria y Hotel de Mascotas ""San Francisco"""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(329, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(246, 24)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Peyronet 1792, Quilpué"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rb_hembra)
        Me.GroupBox1.Controls.Add(Me.rb_macho)
        Me.GroupBox1.Location = New System.Drawing.Point(245, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 33)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'ttp_mensaje
        '
        Me.ttp_mensaje.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(518, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "F.Ingreso : "
        Me.Label3.Visible = False
        '
        'txt_fingreso
        '
        Me.txt_fingreso.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fingreso.Location = New System.Drawing.Point(607, 126)
        Me.txt_fingreso.Name = "txt_fingreso"
        Me.txt_fingreso.Size = New System.Drawing.Size(145, 26)
        Me.txt_fingreso.TabIndex = 43
        Me.txt_fingreso.Visible = False
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.BackColor = System.Drawing.Color.LightGray
        Me.btnCargarImagen.FlatAppearance.BorderSize = 0
        Me.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarImagen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagen.Location = New System.Drawing.Point(12, 164)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(111, 25)
        Me.btnCargarImagen.TabIndex = 47
        Me.btnCargarImagen.Text = "Cargar imagen..."
        Me.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        '
        'txtPrueba
        '
        Me.txtPrueba.Location = New System.Drawing.Point(573, 87)
        Me.txtPrueba.Name = "txtPrueba"
        Me.txtPrueba.Size = New System.Drawing.Size(100, 20)
        Me.txtPrueba.TabIndex = 48
        Me.txtPrueba.Visible = False
        '
        'pbCliente
        '
        Me.pbCliente.BackColor = System.Drawing.Color.LightGray
        Me.pbCliente.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.user_symbol_318_63527
        Me.pbCliente.Location = New System.Drawing.Point(8, 9)
        Me.pbCliente.Name = "pbCliente"
        Me.pbCliente.Size = New System.Drawing.Size(140, 140)
        Me.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCliente.TabIndex = 46
        Me.pbCliente.TabStop = False
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_telefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(260, 107)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(61, 21)
        Me.lbl_telefono.TabIndex = 33
        Me.lbl_telefono.Text = "Label7"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(180, 8)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(85, 21)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Nombre : "
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rut.Location = New System.Drawing.Point(260, 136)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(70, 21)
        Me.lbl_rut.TabIndex = 34
        Me.lbl_rut.Text = "Label18"
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_correo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correo.Location = New System.Drawing.Point(261, 77)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(61, 21)
        Me.lbl_correo.TabIndex = 32
        Me.lbl_correo.Text = "Label6"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(213, 136)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(49, 21)
        Me.lbl6.TabIndex = 3
        Me.lbl6.Text = "Rut : "
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(643, 110)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(0, 20)
        Me.lbl_fecha.TabIndex = 35
        Me.lbl_fecha.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(171, 41)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(95, 21)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Dirección : "
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_direccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.Location = New System.Drawing.Point(262, 41)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(61, 21)
        Me.lbl_direccion.TabIndex = 31
        Me.lbl_direccion.Text = "Label5"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(188, 77)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(75, 21)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "Correo : "
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(260, 10)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(61, 21)
        Me.lbl_nombre.TabIndex = 30
        Me.lbl_nombre.Text = "Label3"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(174, 106)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(88, 21)
        Me.lbl4.TabIndex = 6
        Me.lbl4.Text = "Teléfono : "
        '
        'lbl_num_cliente
        '
        Me.lbl_num_cliente.AutoSize = True
        Me.lbl_num_cliente.Location = New System.Drawing.Point(548, 14)
        Me.lbl_num_cliente.Name = "lbl_num_cliente"
        Me.lbl_num_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_num_cliente.TabIndex = 39
        Me.lbl_num_cliente.Text = "Label3"
        Me.lbl_num_cliente.Visible = False
        '
        'txtIdChip
        '
        Me.txtIdChip.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdChip.Location = New System.Drawing.Point(607, 92)
        Me.txtIdChip.MaxLength = 20
        Me.txtIdChip.Name = "txtIdChip"
        Me.txtIdChip.Size = New System.Drawing.Size(145, 26)
        Me.txtIdChip.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "ID Chip : "
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.BackColor = System.Drawing.Color.Red
        Me.btnQuitarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnQuitarImagen.Location = New System.Drawing.Point(129, 163)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.Size = New System.Drawing.Size(24, 27)
        Me.btnQuitarImagen.TabIndex = 48
        Me.btnQuitarImagen.Text = "X"
        Me.btnQuitarImagen.UseVisualStyleBackColor = False
        '
        'pbMascota
        '
        Me.pbMascota.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.mascotaSilueta
        Me.pbMascota.Location = New System.Drawing.Point(5, 5)
        Me.pbMascota.Name = "pbMascota"
        Me.pbMascota.Size = New System.Drawing.Size(140, 140)
        Me.pbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMascota.TabIndex = 46
        Me.pbMascota.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'panelCliente
        '
        Me.panelCliente.BackColor = System.Drawing.Color.Transparent
        Me.panelCliente.Controls.Add(Me.btn_cambiarCliente)
        Me.panelCliente.Controls.Add(Me.panelLista)
        Me.panelCliente.Controls.Add(Me.cl)
        Me.panelCliente.Controls.Add(Me.txtPrueba)
        Me.panelCliente.Controls.Add(Me.lbl_num_cliente)
        Me.panelCliente.Controls.Add(Me.lbl_telefono)
        Me.panelCliente.Controls.Add(Me.lbl1)
        Me.panelCliente.Controls.Add(Me.lbl_rut)
        Me.panelCliente.Controls.Add(Me.lbl4)
        Me.panelCliente.Controls.Add(Me.lbl_correo)
        Me.panelCliente.Controls.Add(Me.lbl_nombre)
        Me.panelCliente.Controls.Add(Me.lbl6)
        Me.panelCliente.Controls.Add(Me.lbl3)
        Me.panelCliente.Controls.Add(Me.lbl_fecha)
        Me.panelCliente.Controls.Add(Me.lbl_direccion)
        Me.panelCliente.Controls.Add(Me.lbl2)
        Me.panelCliente.Location = New System.Drawing.Point(243, 26)
        Me.panelCliente.Name = "panelCliente"
        Me.panelCliente.Size = New System.Drawing.Size(60, 21)
        Me.panelCliente.TabIndex = 50
        '
        'btn_cambiarCliente
        '
        Me.btn_cambiarCliente.BackColor = System.Drawing.Color.LightGray
        Me.btn_cambiarCliente.FlatAppearance.BorderSize = 0
        Me.btn_cambiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambiarCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambiarCliente.Location = New System.Drawing.Point(653, 131)
        Me.btn_cambiarCliente.Name = "btn_cambiarCliente"
        Me.btn_cambiarCliente.Size = New System.Drawing.Size(217, 29)
        Me.btn_cambiarCliente.TabIndex = 53
        Me.btn_cambiarCliente.Text = "CAMBIAR DUEÑO"
        Me.btn_cambiarCliente.UseVisualStyleBackColor = False
        '
        'panelLista
        '
        Me.panelLista.Controls.Add(Me.Label6)
        Me.panelLista.Controls.Add(Me.lstMascotasCliente)
        Me.panelLista.Location = New System.Drawing.Point(697, 10)
        Me.panelLista.Name = "panelLista"
        Me.panelLista.Size = New System.Drawing.Size(176, 117)
        Me.panelLista.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Mascotas"
        '
        'lstMascotasCliente
        '
        Me.lstMascotasCliente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMascotasCliente.FormattingEnabled = True
        Me.lstMascotasCliente.Location = New System.Drawing.Point(8, 25)
        Me.lstMascotasCliente.Name = "lstMascotasCliente"
        Me.lstMascotasCliente.Size = New System.Drawing.Size(153, 82)
        Me.lstMascotasCliente.TabIndex = 52
        '
        'cl
        '
        Me.cl.BackColor = System.Drawing.Color.LightGray
        Me.cl.Controls.Add(Me.pbCliente)
        Me.cl.Location = New System.Drawing.Point(12, 9)
        Me.cl.Name = "cl"
        Me.cl.Size = New System.Drawing.Size(156, 155)
        Me.cl.TabIndex = 49
        '
        'panelMascota
        '
        Me.panelMascota.BackColor = System.Drawing.Color.Transparent
        Me.panelMascota.Controls.Add(Me.cmbRazas)
        Me.panelMascota.Controls.Add(Me.cmbEspecies)
        Me.panelMascota.Controls.Add(Me.Panel4)
        Me.panelMascota.Controls.Add(Me.txtIdChip)
        Me.panelMascota.Controls.Add(Me.Label5)
        Me.panelMascota.Controls.Add(Me.txt_color)
        Me.panelMascota.Controls.Add(Me.btnQuitarImagen)
        Me.panelMascota.Controls.Add(Me.dtp_nac)
        Me.panelMascota.Controls.Add(Me.Label9)
        Me.panelMascota.Controls.Add(Me.btnCargarImagen)
        Me.panelMascota.Controls.Add(Me.GroupBox1)
        Me.panelMascota.Controls.Add(Me.Label10)
        Me.panelMascota.Controls.Add(Me.txt_nombre)
        Me.panelMascota.Controls.Add(Me.Label11)
        Me.panelMascota.Controls.Add(Me.Label14)
        Me.panelMascota.Controls.Add(Me.txt_fingreso)
        Me.panelMascota.Controls.Add(Me.Label13)
        Me.panelMascota.Controls.Add(Me.Label12)
        Me.panelMascota.Controls.Add(Me.Label3)
        Me.panelMascota.Location = New System.Drawing.Point(-2, 386)
        Me.panelMascota.Name = "panelMascota"
        Me.panelMascota.Size = New System.Drawing.Size(896, 194)
        Me.panelMascota.TabIndex = 3
        '
        'cmbRazas
        '
        Me.cmbRazas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRazas.FormattingEnabled = True
        Me.cmbRazas.Location = New System.Drawing.Point(245, 94)
        Me.cmbRazas.Name = "cmbRazas"
        Me.cmbRazas.Size = New System.Drawing.Size(215, 23)
        Me.cmbRazas.TabIndex = 53
        '
        'cmbEspecies
        '
        Me.cmbEspecies.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecies.FormattingEnabled = True
        Me.cmbEspecies.Location = New System.Drawing.Point(245, 63)
        Me.cmbEspecies.Name = "cmbEspecies"
        Me.cmbEspecies.Size = New System.Drawing.Size(215, 23)
        Me.cmbEspecies.TabIndex = 52
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Controls.Add(Me.pbMascota)
        Me.Panel4.Location = New System.Drawing.Point(9, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 151)
        Me.Panel4.TabIndex = 51
        '
        'panelSeleccionar
        '
        Me.panelSeleccionar.Controls.Add(Me.GroupBox2)
        Me.panelSeleccionar.Controls.Add(Me.btnVolverCliente)
        Me.panelSeleccionar.Controls.Add(Me.btnVPre2)
        Me.panelSeleccionar.Controls.Add(Me.btnSeleccionarCliente)
        Me.panelSeleccionar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSeleccionar.Location = New System.Drawing.Point(2, 179)
        Me.panelSeleccionar.Name = "panelSeleccionar"
        Me.panelSeleccionar.Size = New System.Drawing.Size(883, 170)
        Me.panelSeleccionar.TabIndex = 51
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.pbAgregarCliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(433, -3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 166)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 42)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Si el cliente no existe " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "puede agregarlo : "
        '
        'pbAgregarCliente
        '
        Me.pbAgregarCliente.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.CLIENTES
        Me.pbAgregarCliente.Location = New System.Drawing.Point(205, 17)
        Me.pbAgregarCliente.Name = "pbAgregarCliente"
        Me.pbAgregarCliente.Size = New System.Drawing.Size(140, 140)
        Me.pbAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAgregarCliente.TabIndex = 5
        Me.pbAgregarCliente.TabStop = False
        '
        'btnVolverCliente
        '
        Me.btnVolverCliente.BackColor = System.Drawing.Color.LightGray
        Me.btnVolverCliente.FlatAppearance.BorderSize = 0
        Me.btnVolverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolverCliente.Location = New System.Drawing.Point(98, 109)
        Me.btnVolverCliente.Name = "btnVolverCliente"
        Me.btnVolverCliente.Size = New System.Drawing.Size(312, 32)
        Me.btnVolverCliente.TabIndex = 2
        Me.btnVolverCliente.Text = "VOLVER"
        Me.btnVolverCliente.UseVisualStyleBackColor = False
        Me.btnVolverCliente.Visible = False
        '
        'btnVPre2
        '
        Me.btnVPre2.BackColor = System.Drawing.Color.LightGray
        Me.btnVPre2.FlatAppearance.BorderSize = 0
        Me.btnVPre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVPre2.Location = New System.Drawing.Point(98, 71)
        Me.btnVPre2.Name = "btnVPre2"
        Me.btnVPre2.Size = New System.Drawing.Size(312, 32)
        Me.btnVPre2.TabIndex = 1
        Me.btnVPre2.Text = "VALOR PREDETERMINADO"
        Me.btnVPre2.UseVisualStyleBackColor = False
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.BackColor = System.Drawing.Color.LightGray
        Me.btnSeleccionarCliente.FlatAppearance.BorderSize = 0
        Me.btnSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(98, 31)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(312, 32)
        Me.btnSeleccionarCliente.TabIndex = 0
        Me.btnSeleccionarCliente.Text = "ELEGIR DUEÑO"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCambiarNumFicha)
        Me.GroupBox3.Controls.Add(Me.txtCambiarNumFicha)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lbl_numero)
        Me.GroupBox3.Location = New System.Drawing.Point(411, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 47)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'btnCambiarNumFicha
        '
        Me.btnCambiarNumFicha.BackColor = System.Drawing.Color.LightGray
        Me.btnCambiarNumFicha.FlatAppearance.BorderSize = 0
        Me.btnCambiarNumFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarNumFicha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarNumFicha.Location = New System.Drawing.Point(254, 14)
        Me.btnCambiarNumFicha.Name = "btnCambiarNumFicha"
        Me.btnCambiarNumFicha.Size = New System.Drawing.Size(80, 25)
        Me.btnCambiarNumFicha.TabIndex = 55
        Me.btnCambiarNumFicha.Text = "CAMBIAR"
        Me.btnCambiarNumFicha.UseVisualStyleBackColor = False
        '
        'txtCambiarNumFicha
        '
        Me.txtCambiarNumFicha.BackColor = System.Drawing.Color.White
        Me.txtCambiarNumFicha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambiarNumFicha.Location = New System.Drawing.Point(162, 13)
        Me.txtCambiarNumFicha.MaxLength = 5
        Me.txtCambiarNumFicha.Name = "txtCambiarNumFicha"
        Me.txtCambiarNumFicha.Size = New System.Drawing.Size(86, 26)
        Me.txtCambiarNumFicha.TabIndex = 58
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 20)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "NÚMERO DE FICHA: "
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numero.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.Red
        Me.lbl_numero.Location = New System.Drawing.Point(342, 9)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_numero.Size = New System.Drawing.Size(109, 36)
        Me.lbl_numero.TabIndex = 56
        Me.lbl_numero.Text = "Label3"
        Me.lbl_numero.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frm_ficha_general
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 638)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.panelSeleccionar)
        Me.Controls.Add(Me.panelMascota)
        Me.Controls.Add(Me.panelCliente)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ficha_general"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR NUEVA MASCOTA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMascota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCliente.ResumeLayout(False)
        Me.panelCliente.PerformLayout()
        Me.panelLista.ResumeLayout(False)
        Me.panelLista.PerformLayout()
        Me.cl.ResumeLayout(False)
        Me.panelMascota.ResumeLayout(False)
        Me.panelMascota.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.panelSeleccionar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbAgregarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents rb_hembra As RadioButton
    Friend WithEvents rb_macho As RadioButton
    Friend WithEvents dtp_nac As DateTimePicker
    Friend WithEvents txt_color As TextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ttp_mensaje As ToolTip
    Friend WithEvents txt_auxiliar As TextBox
    Friend WithEvents btn_generar_num_mascota As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_fingreso As TextBox
    Friend WithEvents pbMascota As PictureBox
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents pbCliente As PictureBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl_rut As Label
    Friend WithEvents lbl_correo As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl_num_cliente As Label
    Friend WithEvents txtPrueba As TextBox
    Friend WithEvents btnQuitarImagen As Button
    Friend WithEvents txtIdChip As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents panelCliente As Panel
    Friend WithEvents panelMascota As Panel
    Friend WithEvents cl As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmbRazas As ComboBox
    Friend WithEvents cmbEspecies As ComboBox
    Friend WithEvents panelLista As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lstMascotasCliente As ListBox
    Friend WithEvents panelSeleccionar As Panel
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents btn_cambiarCliente As Button
    Friend WithEvents btnVPre2 As Button
    Friend WithEvents btnVolverCliente As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pbAgregarCliente As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCambiarNumFicha As Button
    Friend WithEvents txtCambiarNumFicha As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_numero As Label
End Class

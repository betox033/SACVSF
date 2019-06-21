<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Consultar_Mascota
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregar_vacuna = New System.Windows.Forms.Button()
        Me.btnRegistrarAtencion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.pbMascota = New System.Windows.Forms.PictureBox()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.lbl_raza = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_fnac = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_especie = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_5 = New System.Windows.Forms.Label()
        Me.lbl_4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionarMascota = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_ingreso = New System.Windows.Forms.TextBox()
        Me.lbl_ingresar = New System.Windows.Forms.Label()
        Me.btn_aceptar_ingreso = New System.Windows.Forms.Button()
        Me.btnCalendario = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbMascota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'btn_agregar_vacuna
        '
        Me.btn_agregar_vacuna.BackColor = System.Drawing.Color.LightGray
        Me.btn_agregar_vacuna.FlatAppearance.BorderSize = 0
        Me.btn_agregar_vacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar_vacuna.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_vacuna.Location = New System.Drawing.Point(276, 481)
        Me.btn_agregar_vacuna.Name = "btn_agregar_vacuna"
        Me.btn_agregar_vacuna.Size = New System.Drawing.Size(232, 32)
        Me.btn_agregar_vacuna.TabIndex = 24
        Me.btn_agregar_vacuna.Text = "AGREGAR VACUNA"
        Me.btn_agregar_vacuna.UseVisualStyleBackColor = False
        '
        'btnRegistrarAtencion
        '
        Me.btnRegistrarAtencion.BackColor = System.Drawing.Color.LightGray
        Me.btnRegistrarAtencion.FlatAppearance.BorderSize = 0
        Me.btnRegistrarAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarAtencion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarAtencion.Location = New System.Drawing.Point(25, 481)
        Me.btnRegistrarAtencion.Name = "btnRegistrarAtencion"
        Me.btnRegistrarAtencion.Size = New System.Drawing.Size(232, 32)
        Me.btnRegistrarAtencion.TabIndex = 5
        Me.btnRegistrarAtencion.Text = "REGISTRAR ATENCIÓN"
        Me.btnRegistrarAtencion.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(276, 521)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(232, 33)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(-1, 210)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(538, 252)
        Me.Panel4.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_color)
        Me.GroupBox2.Controls.Add(Me.lbl_1)
        Me.GroupBox2.Controls.Add(Me.pbMascota)
        Me.GroupBox2.Controls.Add(Me.lbl_sexo)
        Me.GroupBox2.Controls.Add(Me.lbl_raza)
        Me.GroupBox2.Controls.Add(Me.lbl_2)
        Me.GroupBox2.Controls.Add(Me.lbl_fnac)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_especie)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_cliente)
        Me.GroupBox2.Controls.Add(Me.lbl_3)
        Me.GroupBox2.Controls.Add(Me.lbl_nombre)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_numero)
        Me.GroupBox2.Controls.Add(Me.lbl_5)
        Me.GroupBox2.Controls.Add(Me.lbl_4)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 196)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'lbl_color
        '
        Me.lbl_color.AutoSize = True
        Me.lbl_color.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_color.Location = New System.Drawing.Point(254, 163)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(65, 20)
        Me.lbl_color.TabIndex = 23
        Me.lbl_color.Text = "Label14"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_1.Location = New System.Drawing.Point(166, 16)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(81, 20)
        Me.lbl_1.TabIndex = 16
        Me.lbl_1.Text = "N° Ficha : "
        '
        'pbMascota
        '
        Me.pbMascota.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.mascotaSilueta
        Me.pbMascota.Location = New System.Drawing.Point(20, 27)
        Me.pbMascota.Name = "pbMascota"
        Me.pbMascota.Size = New System.Drawing.Size(140, 140)
        Me.pbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMascota.TabIndex = 16
        Me.pbMascota.TabStop = False
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_sexo.Location = New System.Drawing.Point(254, 143)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(65, 20)
        Me.lbl_sexo.TabIndex = 22
        Me.lbl_sexo.Text = "Label13"
        '
        'lbl_raza
        '
        Me.lbl_raza.AutoSize = True
        Me.lbl_raza.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_raza.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_raza.Location = New System.Drawing.Point(254, 120)
        Me.lbl_raza.Name = "lbl_raza"
        Me.lbl_raza.Size = New System.Drawing.Size(65, 20)
        Me.lbl_raza.TabIndex = 21
        Me.lbl_raza.Text = "Label12"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_2.Location = New System.Drawing.Point(167, 38)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(80, 20)
        Me.lbl_2.TabIndex = 18
        Me.lbl_2.Text = "Nombre : "
        '
        'lbl_fnac
        '
        Me.lbl_fnac.AutoSize = True
        Me.lbl_fnac.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fnac.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_fnac.Location = New System.Drawing.Point(254, 99)
        Me.lbl_fnac.Name = "lbl_fnac"
        Me.lbl_fnac.Size = New System.Drawing.Size(65, 20)
        Me.lbl_fnac.TabIndex = 20
        Me.lbl_fnac.Text = "Label11"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(168, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Color : "
        '
        'lbl_especie
        '
        Me.lbl_especie.AutoSize = True
        Me.lbl_especie.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_especie.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_especie.Location = New System.Drawing.Point(253, 78)
        Me.lbl_especie.Name = "lbl_especie"
        Me.lbl_especie.Size = New System.Drawing.Size(65, 20)
        Me.lbl_especie.TabIndex = 19
        Me.lbl_especie.Text = "Label10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(168, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Sexo : "
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_cliente.Location = New System.Drawing.Point(254, 59)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(57, 20)
        Me.lbl_cliente.TabIndex = 18
        Me.lbl_cliente.Text = "Label9"
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_3.Location = New System.Drawing.Point(167, 59)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(70, 20)
        Me.lbl_3.TabIndex = 19
        Me.lbl_3.Text = "Dueño : "
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_nombre.Location = New System.Drawing.Point(253, 38)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(57, 20)
        Me.lbl_nombre.TabIndex = 17
        Me.lbl_nombre.Text = "Label8"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(167, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Raza : "
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_numero.Location = New System.Drawing.Point(253, 16)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(57, 20)
        Me.lbl_numero.TabIndex = 16
        Me.lbl_numero.Text = "Label7"
        '
        'lbl_5
        '
        Me.lbl_5.AutoSize = True
        Me.lbl_5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_5.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_5.Location = New System.Drawing.Point(167, 100)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(67, 20)
        Me.lbl_5.TabIndex = 21
        Me.lbl_5.Text = "F. Nac : "
        '
        'lbl_4
        '
        Me.lbl_4.AutoSize = True
        Me.lbl_4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_4.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_4.Location = New System.Drawing.Point(167, 80)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(78, 20)
        Me.lbl_4.TabIndex = 20
        Me.lbl_4.Text = "Especie : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(164, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "DATOS DE LA MASCOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(165, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "NUEVA ATENCIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarMascota)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_ingreso)
        Me.GroupBox1.Controls.Add(Me.lbl_ingresar)
        Me.GroupBox1.Controls.Add(Me.btn_aceptar_ingreso)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 145)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'btnSeleccionarMascota
        '
        Me.btnSeleccionarMascota.BackColor = System.Drawing.Color.LightGray
        Me.btnSeleccionarMascota.FlatAppearance.BorderSize = 0
        Me.btnSeleccionarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarMascota.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarMascota.Location = New System.Drawing.Point(122, 104)
        Me.btnSeleccionarMascota.Name = "btnSeleccionarMascota"
        Me.btnSeleccionarMascota.Size = New System.Drawing.Size(240, 27)
        Me.btnSeleccionarMascota.TabIndex = 36
        Me.btnSeleccionarMascota.Text = "SELECCIONAR MASCOTA"
        Me.btnSeleccionarMascota.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(111, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(269, 20)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Si no recuerda el número de ficha : "
        '
        'txt_ingreso
        '
        Me.txt_ingreso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ingreso.Location = New System.Drawing.Point(81, 46)
        Me.txt_ingreso.Name = "txt_ingreso"
        Me.txt_ingreso.Size = New System.Drawing.Size(215, 23)
        Me.txt_ingreso.TabIndex = 34
        '
        'lbl_ingresar
        '
        Me.lbl_ingresar.AutoSize = True
        Me.lbl_ingresar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ingresar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingresar.ForeColor = System.Drawing.Color.Black
        Me.lbl_ingresar.Location = New System.Drawing.Point(112, 23)
        Me.lbl_ingresar.Name = "lbl_ingresar"
        Me.lbl_ingresar.Size = New System.Drawing.Size(262, 20)
        Me.lbl_ingresar.TabIndex = 33
        Me.lbl_ingresar.Text = "Ingrese el número de la mascota : "
        '
        'btn_aceptar_ingreso
        '
        Me.btn_aceptar_ingreso.BackColor = System.Drawing.Color.LightGray
        Me.btn_aceptar_ingreso.FlatAppearance.BorderSize = 0
        Me.btn_aceptar_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar_ingreso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar_ingreso.Location = New System.Drawing.Point(303, 45)
        Me.btn_aceptar_ingreso.Name = "btn_aceptar_ingreso"
        Me.btn_aceptar_ingreso.Size = New System.Drawing.Size(96, 27)
        Me.btn_aceptar_ingreso.TabIndex = 32
        Me.btn_aceptar_ingreso.Text = "ACEPTAR"
        Me.btn_aceptar_ingreso.UseVisualStyleBackColor = False
        '
        'btnCalendario
        '
        Me.btnCalendario.BackColor = System.Drawing.Color.LightGray
        Me.btnCalendario.FlatAppearance.BorderSize = 0
        Me.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalendario.Location = New System.Drawing.Point(25, 522)
        Me.btnCalendario.Name = "btnCalendario"
        Me.btnCalendario.Size = New System.Drawing.Size(232, 32)
        Me.btnCalendario.TabIndex = 31
        Me.btnCalendario.Text = "VER CALENDARIO"
        Me.btnCalendario.UseVisualStyleBackColor = False
        '
        'frm_Consultar_Mascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(531, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_agregar_vacuna)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrarAtencion)
        Me.Controls.Add(Me.btnCalendario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Consultar_Mascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Atención"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbMascota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrarAtencion As Button
    Friend WithEvents btn_agregar_vacuna As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pbMascota As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSeleccionarMascota As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_ingreso As TextBox
    Friend WithEvents lbl_ingresar As Label
    Friend WithEvents btn_aceptar_ingreso As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents lbl_raza As Label
    Friend WithEvents lbl_fnac As Label
    Friend WithEvents lbl_especie As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_numero As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_5 As Label
    Friend WithEvents lbl_4 As Label
    Friend WithEvents btnCalendario As Button
End Class

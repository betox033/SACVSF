<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AgregarInsumo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCodAtencion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbInsumo = New System.Windows.Forms.PictureBox()
        Me.panelEspInsumo = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lbl_pre = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.lblDosis = New System.Windows.Forms.Label()
        Me.panelPeriodo = New System.Windows.Forms.GroupBox()
        Me.rb24 = New System.Windows.Forms.RadioButton()
        Me.rb12 = New System.Windows.Forms.RadioButton()
        Me.rb8 = New System.Windows.Forms.RadioButton()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pbInsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEspInsumo.SuspendLayout()
        Me.panelPeriodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstProductos
        '
        Me.lstProductos.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.ItemHeight = 18
        Me.lstProductos.Location = New System.Drawing.Point(16, 110)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(323, 202)
        Me.lstProductos.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "COD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(70, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(269, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "NOMBRE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 319)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(59, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 320)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 355)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 52)
        Me.Panel1.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(158, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(139, 32)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(13, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(139, 32)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblCodAtencion)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblFecha)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 66)
        Me.Panel2.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(299, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "AGREGAR INSUMO"
        '
        'lblCodAtencion
        '
        Me.lblCodAtencion.AutoSize = True
        Me.lblCodAtencion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodAtencion.ForeColor = System.Drawing.Color.White
        Me.lblCodAtencion.Location = New System.Drawing.Point(139, 40)
        Me.lblCodAtencion.Name = "lblCodAtencion"
        Me.lblCodAtencion.Size = New System.Drawing.Size(128, 20)
        Me.lblCodAtencion.TabIndex = 3
        Me.lblCodAtencion.Text = "Cod. Atención : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cod. Atención : "
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(742, 38)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(83, 20)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "21-09-2018"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(682, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Fecha : "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.lblUnidad)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.lblStock)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lblPrecio)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblProveedor)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblNombre)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lblCodigo)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.pbInsumo)
        Me.Panel3.Location = New System.Drawing.Point(359, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(544, 202)
        Me.Panel3.TabIndex = 7
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.ForeColor = System.Drawing.Color.LightGray
        Me.lblUnidad.Location = New System.Drawing.Point(260, 160)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(65, 20)
        Me.lblUnidad.TabIndex = 13
        Me.lblUnidad.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(185, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Unidad : "
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.LightGray
        Me.lblStock.Location = New System.Drawing.Point(260, 139)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(65, 20)
        Me.lblStock.TabIndex = 11
        Me.lblStock.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(199, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Stock : "
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.LightGray
        Me.lblPrecio.Location = New System.Drawing.Point(260, 118)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 20)
        Me.lblPrecio.TabIndex = 9
        Me.lblPrecio.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(195, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Precio : "
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.LightGray
        Me.lblProveedor.Location = New System.Drawing.Point(260, 97)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(57, 20)
        Me.lblProveedor.TabIndex = 7
        Me.lblProveedor.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(162, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Proveedor : "
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.LightGray
        Me.lblNombre.Location = New System.Drawing.Point(260, 76)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 20)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(179, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre : "
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.LightGray
        Me.lblCodigo.Location = New System.Drawing.Point(260, 55)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(57, 20)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(184, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(228, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATOS DEL PRODUCTO"
        '
        'pbInsumo
        '
        Me.pbInsumo.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.remedio
        Me.pbInsumo.Location = New System.Drawing.Point(15, 45)
        Me.pbInsumo.Name = "pbInsumo"
        Me.pbInsumo.Size = New System.Drawing.Size(140, 140)
        Me.pbInsumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbInsumo.TabIndex = 0
        Me.pbInsumo.TabStop = False
        '
        'panelEspInsumo
        '
        Me.panelEspInsumo.Controls.Add(Me.txtDosis)
        Me.panelEspInsumo.Controls.Add(Me.lblDosis)
        Me.panelEspInsumo.Controls.Add(Me.txtPrecio)
        Me.panelEspInsumo.Controls.Add(Me.txtCantidad)
        Me.panelEspInsumo.Controls.Add(Me.lbl_pre)
        Me.panelEspInsumo.Controls.Add(Me.lblCantidad)
        Me.panelEspInsumo.Location = New System.Drawing.Point(359, 277)
        Me.panelEspInsumo.Name = "panelEspInsumo"
        Me.panelEspInsumo.Size = New System.Drawing.Size(230, 66)
        Me.panelEspInsumo.TabIndex = 8
        Me.panelEspInsumo.TabStop = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(124, 39)
        Me.txtPrecio.MaxLength = 8
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 23
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(15, 40)
        Me.txtCantidad.MaxLength = 7
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 22
        '
        'lbl_pre
        '
        Me.lbl_pre.AutoSize = True
        Me.lbl_pre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pre.Location = New System.Drawing.Point(120, 14)
        Me.lbl_pre.Name = "lbl_pre"
        Me.lbl_pre.Size = New System.Drawing.Size(69, 21)
        Me.lbl_pre.TabIndex = 21
        Me.lbl_pre.Text = "Precio : "
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(11, 15)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(99, 21)
        Me.lblCantidad.TabIndex = 20
        Me.lblCantidad.Text = "Cantidad : "
        '
        'txtDosis
        '
        Me.txtDosis.Location = New System.Drawing.Point(232, 39)
        Me.txtDosis.MaxLength = 7
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(100, 20)
        Me.txtDosis.TabIndex = 25
        '
        'lblDosis
        '
        Me.lblDosis.AutoSize = True
        Me.lblDosis.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosis.Location = New System.Drawing.Point(235, 14)
        Me.lblDosis.Name = "lblDosis"
        Me.lblDosis.Size = New System.Drawing.Size(55, 21)
        Me.lblDosis.TabIndex = 24
        Me.lblDosis.Text = "Dosis: "
        '
        'panelPeriodo
        '
        Me.panelPeriodo.Controls.Add(Me.rb24)
        Me.panelPeriodo.Controls.Add(Me.rb12)
        Me.panelPeriodo.Controls.Add(Me.rb8)
        Me.panelPeriodo.Controls.Add(Me.rb6)
        Me.panelPeriodo.Controls.Add(Me.rb4)
        Me.panelPeriodo.Location = New System.Drawing.Point(610, 277)
        Me.panelPeriodo.Name = "panelPeriodo"
        Me.panelPeriodo.Size = New System.Drawing.Size(184, 66)
        Me.panelPeriodo.TabIndex = 9
        Me.panelPeriodo.TabStop = False
        Me.panelPeriodo.Visible = False
        '
        'rb24
        '
        Me.rb24.AutoSize = True
        Me.rb24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb24.Location = New System.Drawing.Point(74, 39)
        Me.rb24.Name = "rb24"
        Me.rb24.Size = New System.Drawing.Size(62, 21)
        Me.rb24.TabIndex = 9
        Me.rb24.TabStop = True
        Me.rb24.Text = "24 Hrs"
        Me.rb24.UseVisualStyleBackColor = True
        '
        'rb12
        '
        Me.rb12.AutoSize = True
        Me.rb12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb12.Location = New System.Drawing.Point(6, 39)
        Me.rb12.Name = "rb12"
        Me.rb12.Size = New System.Drawing.Size(62, 21)
        Me.rb12.TabIndex = 8
        Me.rb12.TabStop = True
        Me.rb12.Text = "12 Hrs"
        Me.rb12.UseVisualStyleBackColor = True
        '
        'rb8
        '
        Me.rb8.AutoSize = True
        Me.rb8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb8.Location = New System.Drawing.Point(124, 12)
        Me.rb8.Name = "rb8"
        Me.rb8.Size = New System.Drawing.Size(55, 21)
        Me.rb8.TabIndex = 7
        Me.rb8.TabStop = True
        Me.rb8.Text = "8 Hrs"
        Me.rb8.UseVisualStyleBackColor = True
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb6.Location = New System.Drawing.Point(63, 12)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(55, 21)
        Me.rb6.TabIndex = 6
        Me.rb6.TabStop = True
        Me.rb6.Text = "6 Hrs"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.Location = New System.Drawing.Point(6, 13)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(55, 21)
        Me.rb4.TabIndex = 5
        Me.rb4.TabStop = True
        Me.rb4.Text = "4 Hrs"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'FRM_AgregarInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(903, 407)
        Me.Controls.Add(Me.panelPeriodo)
        Me.Controls.Add(Me.panelEspInsumo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_AgregarInsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_IngresarInsumo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pbInsumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEspInsumo.ResumeLayout(False)
        Me.panelEspInsumo.PerformLayout()
        Me.panelPeriodo.ResumeLayout(False)
        Me.panelPeriodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstProductos As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblUnidad As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbInsumo As PictureBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblCodAtencion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents panelEspInsumo As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lbl_pre As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents lblDosis As Label
    Friend WithEvents panelPeriodo As GroupBox
    Friend WithEvents rb24 As RadioButton
    Friend WithEvents rb12 As RadioButton
    Friend WithEvents rb8 As RadioButton
    Friend WithEvents rb6 As RadioButton
    Friend WithEvents rb4 As RadioButton
End Class

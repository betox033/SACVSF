<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DetalleHospitalizacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNomMascota = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblIdHosp = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblNomProducto = New System.Windows.Forms.Label()
        Me.lblCodProducto = New System.Windows.Forms.Label()
        Me.btnAceptarModificacion = New System.Windows.Forms.Button()
        Me.btnEliminarDetalle = New System.Windows.Forms.Button()
        Me.pbProducto = New System.Windows.Forms.PictureBox()
        Me.panelPeriodo = New System.Windows.Forms.GroupBox()
        Me.rb24 = New System.Windows.Forms.RadioButton()
        Me.rb12 = New System.Windows.Forms.RadioButton()
        Me.rb8 = New System.Windows.Forms.RadioButton()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.lblDosis = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelTotales2 = New System.Windows.Forms.Panel()
        Me.btnDesplegar = New System.Windows.Forms.Button()
        Me.txtTotalConsulta = New System.Windows.Forms.TextBox()
        Me.txtTotalHosp = New System.Windows.Forms.TextBox()
        Me.ls3 = New System.Windows.Forms.Label()
        Me.ls2 = New System.Windows.Forms.Label()
        Me.lblTotalInsumos = New System.Windows.Forms.Label()
        Me.ls1 = New System.Windows.Forms.Label()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstDetallesHosp = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregarIn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPeriodo.SuspendLayout()
        Me.panelTotales2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DETALLE HOSPITALIZACIÓN"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(733, 7)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(251, 34)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "VOLVER"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 21)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Cod. Hospitalización : "
        '
        'lblNomMascota
        '
        Me.lblNomMascota.AutoSize = True
        Me.lblNomMascota.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomMascota.Location = New System.Drawing.Point(801, 86)
        Me.lblNomMascota.Name = "lblNomMascota"
        Me.lblNomMascota.Size = New System.Drawing.Size(71, 21)
        Me.lblNomMascota.TabIndex = 14
        Me.lblNomMascota.Text = "nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(703, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 21)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Mascota : "
        '
        'lblIdHosp
        '
        Me.lblIdHosp.AutoSize = True
        Me.lblIdHosp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdHosp.Location = New System.Drawing.Point(186, 86)
        Me.lblIdHosp.Name = "lblIdHosp"
        Me.lblIdHosp.Size = New System.Drawing.Size(66, 21)
        Me.lblIdHosp.TabIndex = 16
        Me.lblIdHosp.Text = "idFicha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDosis)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.lblNomProducto)
        Me.GroupBox1.Controls.Add(Me.lblCodProducto)
        Me.GroupBox1.Controls.Add(Me.btnAceptarModificacion)
        Me.GroupBox1.Controls.Add(Me.btnEliminarDetalle)
        Me.GroupBox1.Controls.Add(Me.pbProducto)
        Me.GroupBox1.Controls.Add(Me.panelPeriodo)
        Me.GroupBox1.Controls.Add(Me.lblDosis)
        Me.GroupBox1.Controls.Add(Me.lblPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(571, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 315)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "DATOS"
        '
        'txtDosis
        '
        Me.txtDosis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDosis.Location = New System.Drawing.Point(219, 171)
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(164, 23)
        Me.txtDosis.TabIndex = 32
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(220, 231)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(164, 23)
        Me.txtPrecio.TabIndex = 29
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(220, 201)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(164, 23)
        Me.txtCantidad.TabIndex = 28
        '
        'lblNomProducto
        '
        Me.lblNomProducto.AutoSize = True
        Me.lblNomProducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProducto.Location = New System.Drawing.Point(217, 80)
        Me.lblNomProducto.Name = "lblNomProducto"
        Me.lblNomProducto.Size = New System.Drawing.Size(127, 21)
        Me.lblNomProducto.TabIndex = 24
        Me.lblNomProducto.Text = "nom_producto"
        '
        'lblCodProducto
        '
        Me.lblCodProducto.AutoSize = True
        Me.lblCodProducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodProducto.Location = New System.Drawing.Point(217, 53)
        Me.lblCodProducto.Name = "lblCodProducto"
        Me.lblCodProducto.Size = New System.Drawing.Size(123, 21)
        Me.lblCodProducto.TabIndex = 22
        Me.lblCodProducto.Text = "cod_producto"
        '
        'btnAceptarModificacion
        '
        Me.btnAceptarModificacion.BackColor = System.Drawing.Color.Chocolate
        Me.btnAceptarModificacion.FlatAppearance.BorderSize = 0
        Me.btnAceptarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarModificacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarModificacion.ForeColor = System.Drawing.Color.Maroon
        Me.btnAceptarModificacion.Location = New System.Drawing.Point(20, 268)
        Me.btnAceptarModificacion.Name = "btnAceptarModificacion"
        Me.btnAceptarModificacion.Size = New System.Drawing.Size(182, 30)
        Me.btnAceptarModificacion.TabIndex = 19
        Me.btnAceptarModificacion.Text = "MODIFICAR"
        Me.btnAceptarModificacion.UseVisualStyleBackColor = False
        '
        'btnEliminarDetalle
        '
        Me.btnEliminarDetalle.BackColor = System.Drawing.Color.Chocolate
        Me.btnEliminarDetalle.FlatAppearance.BorderSize = 0
        Me.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDetalle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDetalle.ForeColor = System.Drawing.Color.Maroon
        Me.btnEliminarDetalle.Location = New System.Drawing.Point(208, 268)
        Me.btnEliminarDetalle.Name = "btnEliminarDetalle"
        Me.btnEliminarDetalle.Size = New System.Drawing.Size(182, 30)
        Me.btnEliminarDetalle.TabIndex = 18
        Me.btnEliminarDetalle.Text = "ELIMINAR"
        Me.btnEliminarDetalle.UseVisualStyleBackColor = False
        '
        'pbProducto
        '
        Me.pbProducto.BackColor = System.Drawing.Color.LightGray
        Me.pbProducto.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.remedio
        Me.pbProducto.Location = New System.Drawing.Point(10, 58)
        Me.pbProducto.Name = "pbProducto"
        Me.pbProducto.Size = New System.Drawing.Size(120, 120)
        Me.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProducto.TabIndex = 0
        Me.pbProducto.TabStop = False
        '
        'panelPeriodo
        '
        Me.panelPeriodo.Controls.Add(Me.rb24)
        Me.panelPeriodo.Controls.Add(Me.rb12)
        Me.panelPeriodo.Controls.Add(Me.rb8)
        Me.panelPeriodo.Controls.Add(Me.rb6)
        Me.panelPeriodo.Controls.Add(Me.rb4)
        Me.panelPeriodo.Location = New System.Drawing.Point(218, 100)
        Me.panelPeriodo.Name = "panelPeriodo"
        Me.panelPeriodo.Size = New System.Drawing.Size(184, 63)
        Me.panelPeriodo.TabIndex = 30
        Me.panelPeriodo.TabStop = False
        '
        'rb24
        '
        Me.rb24.AutoSize = True
        Me.rb24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb24.Location = New System.Drawing.Point(75, 36)
        Me.rb24.Name = "rb24"
        Me.rb24.Size = New System.Drawing.Size(62, 21)
        Me.rb24.TabIndex = 4
        Me.rb24.TabStop = True
        Me.rb24.Text = "24 Hrs"
        Me.rb24.UseVisualStyleBackColor = True
        '
        'rb12
        '
        Me.rb12.AutoSize = True
        Me.rb12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb12.Location = New System.Drawing.Point(7, 36)
        Me.rb12.Name = "rb12"
        Me.rb12.Size = New System.Drawing.Size(62, 21)
        Me.rb12.TabIndex = 3
        Me.rb12.TabStop = True
        Me.rb12.Text = "12 Hrs"
        Me.rb12.UseVisualStyleBackColor = True
        '
        'rb8
        '
        Me.rb8.AutoSize = True
        Me.rb8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb8.Location = New System.Drawing.Point(125, 9)
        Me.rb8.Name = "rb8"
        Me.rb8.Size = New System.Drawing.Size(55, 21)
        Me.rb8.TabIndex = 2
        Me.rb8.TabStop = True
        Me.rb8.Text = "8 Hrs"
        Me.rb8.UseVisualStyleBackColor = True
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb6.Location = New System.Drawing.Point(64, 9)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(55, 21)
        Me.rb6.TabIndex = 1
        Me.rb6.TabStop = True
        Me.rb6.Text = "6 Hrs"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.Location = New System.Drawing.Point(7, 10)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(55, 21)
        Me.rb4.TabIndex = 0
        Me.rb4.TabStop = True
        Me.rb4.Text = "4 Hrs"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'lblDosis
        '
        Me.lblDosis.AutoSize = True
        Me.lblDosis.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosis.Location = New System.Drawing.Point(163, 171)
        Me.lblDosis.Name = "lblDosis"
        Me.lblDosis.Size = New System.Drawing.Size(59, 21)
        Me.lblDosis.TabIndex = 31
        Me.lblDosis.Text = "Dosis : "
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(142, 109)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(80, 21)
        Me.lblPeriodo.TabIndex = 27
        Me.lblPeriodo.Text = "Periodo : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(155, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 21)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Costo : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Nombre : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Código : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total Administrada : "
        '
        'panelTotales2
        '
        Me.panelTotales2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelTotales2.Controls.Add(Me.btnDesplegar)
        Me.panelTotales2.Controls.Add(Me.txtTotalConsulta)
        Me.panelTotales2.Controls.Add(Me.txtTotalHosp)
        Me.panelTotales2.Controls.Add(Me.ls3)
        Me.panelTotales2.Controls.Add(Me.ls2)
        Me.panelTotales2.Controls.Add(Me.lblTotalInsumos)
        Me.panelTotales2.Controls.Add(Me.ls1)
        Me.panelTotales2.Controls.Add(Me.lblTotalPagar)
        Me.panelTotales2.Controls.Add(Me.Label4)
        Me.panelTotales2.Location = New System.Drawing.Point(274, 383)
        Me.panelTotales2.Name = "panelTotales2"
        Me.panelTotales2.Size = New System.Drawing.Size(290, 36)
        Me.panelTotales2.TabIndex = 20
        '
        'btnDesplegar
        '
        Me.btnDesplegar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDesplegar.FlatAppearance.BorderSize = 0
        Me.btnDesplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesplegar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesplegar.ForeColor = System.Drawing.Color.Maroon
        Me.btnDesplegar.Location = New System.Drawing.Point(259, 6)
        Me.btnDesplegar.Name = "btnDesplegar"
        Me.btnDesplegar.Size = New System.Drawing.Size(25, 25)
        Me.btnDesplegar.TabIndex = 33
        Me.btnDesplegar.Text = "^"
        Me.btnDesplegar.UseVisualStyleBackColor = False
        '
        'txtTotalConsulta
        '
        Me.txtTotalConsulta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConsulta.Location = New System.Drawing.Point(151, 87)
        Me.txtTotalConsulta.Name = "txtTotalConsulta"
        Me.txtTotalConsulta.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalConsulta.TabIndex = 32
        '
        'txtTotalHosp
        '
        Me.txtTotalHosp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHosp.Location = New System.Drawing.Point(151, 57)
        Me.txtTotalHosp.Name = "txtTotalHosp"
        Me.txtTotalHosp.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalHosp.TabIndex = 31
        '
        'ls3
        '
        Me.ls3.AutoSize = True
        Me.ls3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ls3.ForeColor = System.Drawing.Color.Maroon
        Me.ls3.Location = New System.Drawing.Point(3, 87)
        Me.ls3.Name = "ls3"
        Me.ls3.Size = New System.Drawing.Size(108, 21)
        Me.ls3.TabIndex = 29
        Me.ls3.Text = "CONSULTA : "
        '
        'ls2
        '
        Me.ls2.AutoSize = True
        Me.ls2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ls2.ForeColor = System.Drawing.Color.Maroon
        Me.ls2.Location = New System.Drawing.Point(3, 58)
        Me.ls2.Name = "ls2"
        Me.ls2.Size = New System.Drawing.Size(114, 21)
        Me.ls2.TabIndex = 27
        Me.ls2.Text = "TOTAL HOSP :"
        '
        'lblTotalInsumos
        '
        Me.lblTotalInsumos.AutoSize = True
        Me.lblTotalInsumos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInsumos.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalInsumos.Location = New System.Drawing.Point(147, 31)
        Me.lblTotalInsumos.Name = "lblTotalInsumos"
        Me.lblTotalInsumos.Size = New System.Drawing.Size(55, 21)
        Me.lblTotalInsumos.TabIndex = 26
        Me.lblTotalInsumos.Text = "$1234"
        '
        'ls1
        '
        Me.ls1.AutoSize = True
        Me.ls1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ls1.ForeColor = System.Drawing.Color.Maroon
        Me.ls1.Location = New System.Drawing.Point(3, 31)
        Me.ls1.Name = "ls1"
        Me.ls1.Size = New System.Drawing.Size(149, 21)
        Me.ls1.TabIndex = 25
        Me.ls1.Text = "TOTAL INSUMOS : "
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.AutoSize = True
        Me.lblTotalPagar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPagar.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalPagar.Location = New System.Drawing.Point(147, 8)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(55, 21)
        Me.lblTotalPagar.TabIndex = 24
        Me.lblTotalPagar.Text = "$1234"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(3, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "TOTAL A PAGAR : "
        '
        'lstDetallesHosp
        '
        Me.lstDetallesHosp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstDetallesHosp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetallesHosp.FullRowSelect = True
        Me.lstDetallesHosp.GridLines = True
        Me.lstDetallesHosp.Location = New System.Drawing.Point(12, 110)
        Me.lstDetallesHosp.Name = "lstDetallesHosp"
        Me.lstDetallesHosp.Size = New System.Drawing.Size(553, 267)
        Me.lstDetallesHosp.TabIndex = 21
        Me.lstDetallesHosp.UseCompatibleStateImageBehavior = False
        Me.lstDetallesHosp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "COD"
        Me.ColumnHeader1.Width = 47
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PRODUCTO"
        Me.ColumnHeader2.Width = 243
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PER."
        Me.ColumnHeader3.Width = 49
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DOSIS"
        Me.ColumnHeader4.Width = 52
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TOT. AD."
        Me.ColumnHeader5.Width = 64
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "COSTO"
        Me.ColumnHeader6.Width = 92
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.btnAgregarIn)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 47)
        Me.Panel1.TabIndex = 22
        '
        'btnAgregarIn
        '
        Me.btnAgregarIn.BackColor = System.Drawing.Color.DarkRed
        Me.btnAgregarIn.FlatAppearance.BorderSize = 0
        Me.btnAgregarIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarIn.ForeColor = System.Drawing.Color.White
        Me.btnAgregarIn.Location = New System.Drawing.Point(12, 7)
        Me.btnAgregarIn.Name = "btnAgregarIn"
        Me.btnAgregarIn.Size = New System.Drawing.Size(251, 34)
        Me.btnAgregarIn.TabIndex = 13
        Me.btnAgregarIn.Text = "AGREGAR INSUMO"
        Me.btnAgregarIn.UseVisualStyleBackColor = False
        '
        'FRM_DetalleHospitalizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 480)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstDetallesHosp)
        Me.Controls.Add(Me.panelTotales2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblIdHosp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblNomMascota)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_DetalleHospitalizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_DetalleHospitalizacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPeriodo.ResumeLayout(False)
        Me.panelPeriodo.PerformLayout()
        Me.panelTotales2.ResumeLayout(False)
        Me.panelTotales2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNomMascota As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblIdHosp As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbProducto As PictureBox
    Friend WithEvents btnAceptarModificacion As Button
    Friend WithEvents btnEliminarDetalle As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNomProducto As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCodProducto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panelPeriodo As GroupBox
    Friend WithEvents rb24 As RadioButton
    Friend WithEvents rb12 As RadioButton
    Friend WithEvents rb8 As RadioButton
    Friend WithEvents rb6 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents panelTotales2 As Panel
    Friend WithEvents lblTotalPagar As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ls3 As Label
    Friend WithEvents ls2 As Label
    Friend WithEvents lblTotalInsumos As Label
    Friend WithEvents ls1 As Label
    Friend WithEvents txtTotalConsulta As TextBox
    Friend WithEvents txtTotalHosp As TextBox
    Friend WithEvents btnDesplegar As Button
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents lblDosis As Label
    Friend WithEvents lstDetallesHosp As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnAgregarIn As Button
End Class

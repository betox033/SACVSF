<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Mantenedor_Proveedores
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
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_fono = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbProveedor = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBusquedaCodigo = New System.Windows.Forms.TextBox()
        Me.btnOrdenarCodigo = New System.Windows.Forms.Button()
        Me.btnOrdenarFono = New System.Windows.Forms.Button()
        Me.btnOrdenarNombre = New System.Windows.Forms.Button()
        Me.txtBusquedaFono = New System.Windows.Forms.TextBox()
        Me.txtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstProveedores = New System.Windows.Forms.ListBox()
        Me.Panel4.SuspendLayout()
        CType(Me.pbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Location = New System.Drawing.Point(250, 14)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(110, 30)
        Me.btn_eliminar.TabIndex = 3
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Location = New System.Drawing.Point(365, 14)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(110, 30)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_modificar.FlatAppearance.BorderSize = 0
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.Black
        Me.btn_modificar.Location = New System.Drawing.Point(128, 14)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(116, 30)
        Me.btn_modificar.TabIndex = 1
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(12, 14)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(110, 30)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel4.Controls.Add(Me.btnQuitarImagen)
        Me.Panel4.Controls.Add(Me.btnCargarImagen)
        Me.Panel4.Controls.Add(Me.lbl_codigo)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.btn_cancelar)
        Me.Panel4.Controls.Add(Me.btn_aceptar)
        Me.Panel4.Controls.Add(Me.txt_direccion)
        Me.Panel4.Controls.Add(Me.txt_fono)
        Me.Panel4.Controls.Add(Me.txt_nombre)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.pbProveedor)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(486, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(315, 434)
        Me.Panel4.TabIndex = 4
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.BackColor = System.Drawing.Color.Red
        Me.btnQuitarImagen.FlatAppearance.BorderSize = 0
        Me.btnQuitarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarImagen.ForeColor = System.Drawing.Color.White
        Me.btnQuitarImagen.Location = New System.Drawing.Point(208, 209)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.Size = New System.Drawing.Size(23, 23)
        Me.btnQuitarImagen.TabIndex = 13
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
        Me.btnCargarImagen.ForeColor = System.Drawing.Color.Black
        Me.btnCargarImagen.Location = New System.Drawing.Point(91, 210)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(111, 23)
        Me.btnCargarImagen.TabIndex = 12
        Me.btnCargarImagen.Text = "Cargar Imagen..."
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        Me.btnCargarImagen.Visible = False
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_codigo.Location = New System.Drawing.Point(117, 253)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(61, 21)
        Me.lbl_codigo.TabIndex = 11
        Me.lbl_codigo.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(27, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Código : "
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(171, 383)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(116, 32)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        Me.btn_cancelar.Visible = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_aceptar.FlatAppearance.BorderSize = 0
        Me.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.White
        Me.btn_aceptar.Location = New System.Drawing.Point(40, 383)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(116, 32)
        Me.btn_aceptar.TabIndex = 8
        Me.btn_aceptar.Text = "ACEPTAR"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        Me.btn_aceptar.Visible = False
        '
        'txt_direccion
        '
        Me.txt_direccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(117, 346)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(179, 23)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_fono
        '
        Me.txt_fono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fono.Location = New System.Drawing.Point(117, 315)
        Me.txt_fono.Name = "txt_fono"
        Me.txt_fono.Size = New System.Drawing.Size(179, 23)
        Me.txt_fono.TabIndex = 6
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(117, 284)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(179, 23)
        Me.txt_nombre.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(12, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dirección : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(47, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fono : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(23, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(55, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATOS DEL PROVEEDOR"
        '
        'pbProveedor
        '
        Me.pbProveedor.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources._7a87b5c60ed68a903e52c16ac685417f
        Me.pbProveedor.Location = New System.Drawing.Point(91, 63)
        Me.pbProveedor.Name = "pbProveedor"
        Me.pbProveedor.Size = New System.Drawing.Size(140, 140)
        Me.pbProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProveedor.TabIndex = 0
        Me.pbProveedor.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Olive
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.btn_modificar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(0, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 57)
        Me.Panel1.TabIndex = 5
        '
        'txtBusquedaCodigo
        '
        Me.txtBusquedaCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaCodigo.Location = New System.Drawing.Point(30, 337)
        Me.txtBusquedaCodigo.Name = "txtBusquedaCodigo"
        Me.txtBusquedaCodigo.Size = New System.Drawing.Size(46, 23)
        Me.txtBusquedaCodigo.TabIndex = 14
        '
        'btnOrdenarCodigo
        '
        Me.btnOrdenarCodigo.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarCodigo.FlatAppearance.BorderSize = 0
        Me.btnOrdenarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarCodigo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarCodigo.ForeColor = System.Drawing.Color.Black
        Me.btnOrdenarCodigo.Location = New System.Drawing.Point(30, 108)
        Me.btnOrdenarCodigo.Name = "btnOrdenarCodigo"
        Me.btnOrdenarCodigo.Size = New System.Drawing.Size(46, 23)
        Me.btnOrdenarCodigo.TabIndex = 13
        Me.btnOrdenarCodigo.Text = "COD"
        Me.btnOrdenarCodigo.UseVisualStyleBackColor = False
        '
        'btnOrdenarFono
        '
        Me.btnOrdenarFono.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarFono.FlatAppearance.BorderSize = 0
        Me.btnOrdenarFono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarFono.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarFono.ForeColor = System.Drawing.Color.Black
        Me.btnOrdenarFono.Location = New System.Drawing.Point(275, 107)
        Me.btnOrdenarFono.Name = "btnOrdenarFono"
        Me.btnOrdenarFono.Size = New System.Drawing.Size(184, 23)
        Me.btnOrdenarFono.TabIndex = 12
        Me.btnOrdenarFono.Text = "FONO"
        Me.btnOrdenarFono.UseVisualStyleBackColor = False
        '
        'btnOrdenarNombre
        '
        Me.btnOrdenarNombre.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarNombre.FlatAppearance.BorderSize = 0
        Me.btnOrdenarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarNombre.ForeColor = System.Drawing.Color.Black
        Me.btnOrdenarNombre.Location = New System.Drawing.Point(82, 107)
        Me.btnOrdenarNombre.Name = "btnOrdenarNombre"
        Me.btnOrdenarNombre.Size = New System.Drawing.Size(187, 23)
        Me.btnOrdenarNombre.TabIndex = 11
        Me.btnOrdenarNombre.Text = "NOMBRE"
        Me.btnOrdenarNombre.UseVisualStyleBackColor = False
        '
        'txtBusquedaFono
        '
        Me.txtBusquedaFono.BackColor = System.Drawing.Color.White
        Me.txtBusquedaFono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaFono.Location = New System.Drawing.Point(290, 337)
        Me.txtBusquedaFono.Name = "txtBusquedaFono"
        Me.txtBusquedaFono.Size = New System.Drawing.Size(169, 23)
        Me.txtBusquedaFono.TabIndex = 10
        '
        'txtBusquedaNombre
        '
        Me.txtBusquedaNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaNombre.Location = New System.Drawing.Point(82, 337)
        Me.txtBusquedaNombre.Name = "txtBusquedaNombre"
        Me.txtBusquedaNombre.Size = New System.Drawing.Size(197, 23)
        Me.txtBusquedaNombre.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(74, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(340, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "MANTENEDOR DE PROVEEDORES"
        '
        'lstProveedores
        '
        Me.lstProveedores.ColumnWidth = 100
        Me.lstProveedores.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProveedores.FormattingEnabled = True
        Me.lstProveedores.ItemHeight = 19
        Me.lstProveedores.Location = New System.Drawing.Point(30, 138)
        Me.lstProveedores.Name = "lstProveedores"
        Me.lstProveedores.Size = New System.Drawing.Size(429, 194)
        Me.lstProveedores.TabIndex = 16
        '
        'FRM_Mantenedor_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstProveedores)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBusquedaCodigo)
        Me.Controls.Add(Me.btnOrdenarCodigo)
        Me.Controls.Add(Me.btnOrdenarFono)
        Me.Controls.Add(Me.btnOrdenarNombre)
        Me.Controls.Add(Me.txtBusquedaFono)
        Me.Controls.Add(Me.txtBusquedaNombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FRM_Mantenedor_Proveedores"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_Mantenedor_Proveedores"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_fono As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents pbProveedor As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnQuitarImagen As Button
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents txtBusquedaCodigo As TextBox
    Friend WithEvents btnOrdenarCodigo As Button
    Friend WithEvents btnOrdenarFono As Button
    Friend WithEvents btnOrdenarNombre As Button
    Friend WithEvents txtBusquedaFono As TextBox
    Friend WithEvents txtBusquedaNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lstProveedores As ListBox
End Class

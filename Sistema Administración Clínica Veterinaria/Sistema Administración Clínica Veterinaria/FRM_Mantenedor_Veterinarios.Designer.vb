<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Mantenedor_Veterinarios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_fono = New System.Windows.Forms.TextBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbVeterinario = New System.Windows.Forms.PictureBox()
        Me.txtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.txtBusquedaNumero = New System.Windows.Forms.TextBox()
        Me.btnOrdenarNombre = New System.Windows.Forms.Button()
        Me.btnOrdenarNumero = New System.Windows.Forms.Button()
        Me.lst_veterinarios = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbVeterinario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.btnQuitarImagen)
        Me.Panel1.Controls.Add(Me.btnCargarImagen)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Controls.Add(Me.txt_fono)
        Me.Panel1.Controls.Add(Me.txt_rut)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.lbl_numero)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbVeterinario)
        Me.Panel1.Location = New System.Drawing.Point(373, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 465)
        Me.Panel1.TabIndex = 0
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.BackColor = System.Drawing.Color.Red
        Me.btnQuitarImagen.FlatAppearance.BorderSize = 0
        Me.btnQuitarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarImagen.ForeColor = System.Drawing.Color.White
        Me.btnQuitarImagen.Location = New System.Drawing.Point(204, 210)
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
        Me.btnCargarImagen.Location = New System.Drawing.Point(87, 211)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(111, 23)
        Me.btnCargarImagen.TabIndex = 12
        Me.btnCargarImagen.Text = "Cargar Imagen..."
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        Me.btnCargarImagen.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(58, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DATOS DEL VETERINARIO"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(155, 382)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(127, 29)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        Me.btn_cancelar.Visible = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_aceptar.FlatAppearance.BorderSize = 0
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Location = New System.Drawing.Point(21, 382)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(119, 29)
        Me.btn_aceptar.TabIndex = 9
        Me.btn_aceptar.Text = "ACEPTAR"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        Me.btn_aceptar.Visible = False
        '
        'txt_fono
        '
        Me.txt_fono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fono.Location = New System.Drawing.Point(104, 346)
        Me.txt_fono.Name = "txt_fono"
        Me.txt_fono.Size = New System.Drawing.Size(178, 23)
        Me.txt_fono.TabIndex = 8
        '
        'txt_rut
        '
        Me.txt_rut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rut.Location = New System.Drawing.Point(104, 313)
        Me.txt_rut.MaxLength = 12
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(178, 23)
        Me.txt_rut.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.AcceptsReturn = True
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(104, 279)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(178, 23)
        Me.txt_nombre.TabIndex = 6
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.White
        Me.lbl_numero.Location = New System.Drawing.Point(100, 248)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(61, 21)
        Me.lbl_numero.TabIndex = 5
        Me.lbl_numero.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fono : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "RUT : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número : "
        '
        'pbVeterinario
        '
        Me.pbVeterinario.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.user_symbol_318_63527
        Me.pbVeterinario.Location = New System.Drawing.Point(87, 64)
        Me.pbVeterinario.Name = "pbVeterinario"
        Me.pbVeterinario.Size = New System.Drawing.Size(140, 140)
        Me.pbVeterinario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVeterinario.TabIndex = 0
        Me.pbVeterinario.TabStop = False
        '
        'txtBusquedaNombre
        '
        Me.txtBusquedaNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaNombre.Location = New System.Drawing.Point(63, 372)
        Me.txtBusquedaNombre.Name = "txtBusquedaNombre"
        Me.txtBusquedaNombre.Size = New System.Drawing.Size(291, 23)
        Me.txtBusquedaNombre.TabIndex = 5
        '
        'txtBusquedaNumero
        '
        Me.txtBusquedaNumero.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaNumero.Location = New System.Drawing.Point(23, 372)
        Me.txtBusquedaNumero.Name = "txtBusquedaNumero"
        Me.txtBusquedaNumero.Size = New System.Drawing.Size(34, 23)
        Me.txtBusquedaNumero.TabIndex = 4
        '
        'btnOrdenarNombre
        '
        Me.btnOrdenarNombre.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarNombre.FlatAppearance.BorderSize = 0
        Me.btnOrdenarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarNombre.Location = New System.Drawing.Point(63, 121)
        Me.btnOrdenarNombre.Name = "btnOrdenarNombre"
        Me.btnOrdenarNombre.Size = New System.Drawing.Size(291, 23)
        Me.btnOrdenarNombre.TabIndex = 2
        Me.btnOrdenarNombre.Text = "NOMBRE"
        Me.btnOrdenarNombre.UseVisualStyleBackColor = False
        '
        'btnOrdenarNumero
        '
        Me.btnOrdenarNumero.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarNumero.FlatAppearance.BorderSize = 0
        Me.btnOrdenarNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarNumero.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenarNumero.Location = New System.Drawing.Point(23, 121)
        Me.btnOrdenarNumero.Name = "btnOrdenarNumero"
        Me.btnOrdenarNumero.Size = New System.Drawing.Size(34, 23)
        Me.btnOrdenarNumero.TabIndex = 1
        Me.btnOrdenarNumero.Text = "N°"
        Me.btnOrdenarNumero.UseVisualStyleBackColor = False
        '
        'lst_veterinarios
        '
        Me.lst_veterinarios.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_veterinarios.FormattingEnabled = True
        Me.lst_veterinarios.ItemHeight = 19
        Me.lst_veterinarios.Location = New System.Drawing.Point(23, 150)
        Me.lst_veterinarios.Name = "lst_veterinarios"
        Me.lst_veterinarios.Size = New System.Drawing.Size(331, 213)
        Me.lst_veterinarios.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Controls.Add(Me.btn_eliminar)
        Me.Panel3.Controls.Add(Me.btn_modificar)
        Me.Panel3.Controls.Add(Me.btn_agregar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 421)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(675, 55)
        Me.Panel3.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(535, 13)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 31)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Gray
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Location = New System.Drawing.Point(264, 11)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(120, 32)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.Gray
        Me.btn_modificar.FlatAppearance.BorderSize = 0
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.Black
        Me.btn_modificar.Location = New System.Drawing.Point(138, 11)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(120, 32)
        Me.btn_modificar.TabIndex = 1
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Gray
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(12, 11)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(120, 32)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MANTENEDOR DE VETERINARIOS"
        '
        'FRM_Mantenedor_Veterinarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 476)
        Me.Controls.Add(Me.txtBusquedaNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBusquedaNumero)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnOrdenarNombre)
        Me.Controls.Add(Me.btnOrdenarNumero)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lst_veterinarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_Mantenedor_Veterinarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_Mantenedor_Veterinarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbVeterinario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbVeterinario As PictureBox
    Friend WithEvents txtBusquedaNombre As TextBox
    Friend WithEvents txtBusquedaNumero As TextBox
    Friend WithEvents btnOrdenarNombre As Button
    Friend WithEvents btnOrdenarNumero As Button
    Friend WithEvents lst_veterinarios As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_fono As TextBox
    Friend WithEvents txt_rut As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_numero As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btnQuitarImagen As Button
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents Label5 As Label
End Class

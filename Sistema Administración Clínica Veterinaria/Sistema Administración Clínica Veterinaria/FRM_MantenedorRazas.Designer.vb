<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MantenedorRazas
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
        Me.btnMigracionRazas = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstRazas = New System.Windows.Forms.ListBox()
        Me.btnOrdenarID = New System.Windows.Forms.Button()
        Me.btnOrdenarEspecie = New System.Windows.Forms.Button()
        Me.btnOrdenarNombre = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblIdRaza = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbEspecies = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelMigracion = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMigracionEspecie = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelSubRazas = New System.Windows.Forms.GroupBox()
        Me.cmbRazaNueva = New System.Windows.Forms.ComboBox()
        Me.cmbRazaOriginal = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelarMigracion = New System.Windows.Forms.Button()
        Me.btnAceptarMigracion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelMigracion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelSubRazas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMigracionRazas)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 105)
        Me.Panel1.TabIndex = 0
        '
        'btnMigracionRazas
        '
        Me.btnMigracionRazas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMigracionRazas.FlatAppearance.BorderSize = 0
        Me.btnMigracionRazas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMigracionRazas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMigracionRazas.Location = New System.Drawing.Point(15, 56)
        Me.btnMigracionRazas.Name = "btnMigracionRazas"
        Me.btnMigracionRazas.Size = New System.Drawing.Size(289, 35)
        Me.btnMigracionRazas.TabIndex = 4
        Me.btnMigracionRazas.Text = "MIGRACIÓN MASIVA"
        Me.btnMigracionRazas.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(167, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(137, 35)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(316, 56)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(137, 35)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(316, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(137, 35)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(15, 15)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(137, 35)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANTENEDOR DE RAZAS"
        '
        'lstRazas
        '
        Me.lstRazas.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRazas.FormattingEnabled = True
        Me.lstRazas.ItemHeight = 18
        Me.lstRazas.Location = New System.Drawing.Point(17, 270)
        Me.lstRazas.Name = "lstRazas"
        Me.lstRazas.Size = New System.Drawing.Size(429, 166)
        Me.lstRazas.TabIndex = 2
        '
        'btnOrdenarID
        '
        Me.btnOrdenarID.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarID.FlatAppearance.BorderSize = 0
        Me.btnOrdenarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarID.Location = New System.Drawing.Point(17, 235)
        Me.btnOrdenarID.Name = "btnOrdenarID"
        Me.btnOrdenarID.Size = New System.Drawing.Size(50, 23)
        Me.btnOrdenarID.TabIndex = 3
        Me.btnOrdenarID.Text = "ID"
        Me.btnOrdenarID.UseVisualStyleBackColor = False
        '
        'btnOrdenarEspecie
        '
        Me.btnOrdenarEspecie.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarEspecie.FlatAppearance.BorderSize = 0
        Me.btnOrdenarEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarEspecie.Location = New System.Drawing.Point(73, 235)
        Me.btnOrdenarEspecie.Name = "btnOrdenarEspecie"
        Me.btnOrdenarEspecie.Size = New System.Drawing.Size(170, 23)
        Me.btnOrdenarEspecie.TabIndex = 4
        Me.btnOrdenarEspecie.Text = "ESPECIE"
        Me.btnOrdenarEspecie.UseVisualStyleBackColor = False
        '
        'btnOrdenarNombre
        '
        Me.btnOrdenarNombre.BackColor = System.Drawing.Color.LightGray
        Me.btnOrdenarNombre.FlatAppearance.BorderSize = 0
        Me.btnOrdenarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenarNombre.Location = New System.Drawing.Point(249, 235)
        Me.btnOrdenarNombre.Name = "btnOrdenarNombre"
        Me.btnOrdenarNombre.Size = New System.Drawing.Size(197, 23)
        Me.btnOrdenarNombre.TabIndex = 5
        Me.btnOrdenarNombre.Text = "NOMBRE"
        Me.btnOrdenarNombre.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblIdRaza)
        Me.Panel2.Controls.Add(Me.btnAceptar)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.cmbEspecies)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(17, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 135)
        Me.Panel2.TabIndex = 6
        '
        'lblIdRaza
        '
        Me.lblIdRaza.AutoSize = True
        Me.lblIdRaza.Location = New System.Drawing.Point(17, 90)
        Me.lblIdRaza.Name = "lblIdRaza"
        Me.lblIdRaza.Size = New System.Drawing.Size(39, 13)
        Me.lblIdRaza.TabIndex = 6
        Me.lblIdRaza.Text = "Label4"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Chocolate
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(104, 90)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(107, 32)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        Me.btnAceptar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Chocolate
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(217, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 32)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(118, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(290, 23)
        Me.txtNombre.TabIndex = 3
        '
        'cmbEspecies
        '
        Me.cmbEspecies.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecies.FormattingEnabled = True
        Me.cmbEspecies.Location = New System.Drawing.Point(118, 26)
        Me.cmbEspecies.Name = "cmbEspecies"
        Me.cmbEspecies.Size = New System.Drawing.Size(290, 23)
        Me.cmbEspecies.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Especie : "
        '
        'panelMigracion
        '
        Me.panelMigracion.Controls.Add(Me.GroupBox1)
        Me.panelMigracion.Controls.Add(Me.panelSubRazas)
        Me.panelMigracion.Controls.Add(Me.btnCancelarMigracion)
        Me.panelMigracion.Controls.Add(Me.btnAceptarMigracion)
        Me.panelMigracion.Controls.Add(Me.Label4)
        Me.panelMigracion.Location = New System.Drawing.Point(13, 13)
        Me.panelMigracion.Name = "panelMigracion"
        Me.panelMigracion.Size = New System.Drawing.Size(54, 43)
        Me.panelMigracion.TabIndex = 7
        Me.panelMigracion.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMigracionEspecie)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 83)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cmbMigracionEspecie
        '
        Me.cmbMigracionEspecie.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMigracionEspecie.FormattingEnabled = True
        Me.cmbMigracionEspecie.Location = New System.Drawing.Point(15, 40)
        Me.cmbMigracionEspecie.Name = "cmbMigracionEspecie"
        Me.cmbMigracionEspecie.Size = New System.Drawing.Size(337, 26)
        Me.cmbMigracionEspecie.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 21)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Seleccione una especie"
        '
        'panelSubRazas
        '
        Me.panelSubRazas.Controls.Add(Me.cmbRazaNueva)
        Me.panelSubRazas.Controls.Add(Me.cmbRazaOriginal)
        Me.panelSubRazas.Controls.Add(Me.Label6)
        Me.panelSubRazas.Controls.Add(Me.Label5)
        Me.panelSubRazas.Location = New System.Drawing.Point(25, 172)
        Me.panelSubRazas.Name = "panelSubRazas"
        Me.panelSubRazas.Size = New System.Drawing.Size(388, 185)
        Me.panelSubRazas.TabIndex = 7
        Me.panelSubRazas.TabStop = False
        Me.panelSubRazas.Visible = False
        '
        'cmbRazaNueva
        '
        Me.cmbRazaNueva.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRazaNueva.FormattingEnabled = True
        Me.cmbRazaNueva.Location = New System.Drawing.Point(28, 140)
        Me.cmbRazaNueva.Name = "cmbRazaNueva"
        Me.cmbRazaNueva.Size = New System.Drawing.Size(337, 26)
        Me.cmbRazaNueva.TabIndex = 9
        '
        'cmbRazaOriginal
        '
        Me.cmbRazaOriginal.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRazaOriginal.FormattingEnabled = True
        Me.cmbRazaOriginal.Location = New System.Drawing.Point(28, 52)
        Me.cmbRazaOriginal.Name = "cmbRazaOriginal"
        Me.cmbRazaOriginal.Size = New System.Drawing.Size(337, 26)
        Me.cmbRazaOriginal.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cambiar todas las mascotas de esta raza :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "a esta raza : "
        '
        'btnCancelarMigracion
        '
        Me.btnCancelarMigracion.BackColor = System.Drawing.Color.LightGray
        Me.btnCancelarMigracion.FlatAppearance.BorderSize = 0
        Me.btnCancelarMigracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarMigracion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarMigracion.Location = New System.Drawing.Point(226, 372)
        Me.btnCancelarMigracion.Name = "btnCancelarMigracion"
        Me.btnCancelarMigracion.Size = New System.Drawing.Size(166, 34)
        Me.btnCancelarMigracion.TabIndex = 6
        Me.btnCancelarMigracion.Text = "CANCELAR"
        Me.btnCancelarMigracion.UseVisualStyleBackColor = False
        '
        'btnAceptarMigracion
        '
        Me.btnAceptarMigracion.BackColor = System.Drawing.Color.LightGray
        Me.btnAceptarMigracion.FlatAppearance.BorderSize = 0
        Me.btnAceptarMigracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarMigracion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarMigracion.Location = New System.Drawing.Point(54, 372)
        Me.btnAceptarMigracion.Name = "btnAceptarMigracion"
        Me.btnAceptarMigracion.Size = New System.Drawing.Size(166, 34)
        Me.btnAceptarMigracion.TabIndex = 3
        Me.btnAceptarMigracion.Text = "ACEPTAR"
        Me.btnAceptarMigracion.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(347, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "MIGRACIÓN MASIVA DE MASCOTAS"
        '
        'FRM_MantenedorRazas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(464, 547)
        Me.Controls.Add(Me.panelMigracion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnOrdenarNombre)
        Me.Controls.Add(Me.btnOrdenarEspecie)
        Me.Controls.Add(Me.btnOrdenarID)
        Me.Controls.Add(Me.lstRazas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_MantenedorRazas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_MantenedorRazas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelMigracion.ResumeLayout(False)
        Me.panelMigracion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelSubRazas.ResumeLayout(False)
        Me.panelSubRazas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstRazas As ListBox
    Friend WithEvents btnOrdenarID As Button
    Friend WithEvents btnOrdenarEspecie As Button
    Friend WithEvents btnOrdenarNombre As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbEspecies As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblIdRaza As Label
    Friend WithEvents btnMigracionRazas As Button
    Friend WithEvents panelMigracion As Panel
    Friend WithEvents btnCancelarMigracion As Button
    Friend WithEvents btnAceptarMigracion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents panelSubRazas As GroupBox
    Friend WithEvents cmbRazaNueva As ComboBox
    Friend WithEvents cmbRazaOriginal As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbMigracionEspecie As ComboBox
    Friend WithEvents Label7 As Label
End Class

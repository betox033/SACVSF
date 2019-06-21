<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MantenedorEspecies
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMigracion = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIdEspecie = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lstEspecies = New System.Windows.Forms.ListBox()
        Me.panelMigracion = New System.Windows.Forms.Panel()
        Me.cmbEspecieNueva = New System.Windows.Forms.ComboBox()
        Me.cmbEspecieOriginal = New System.Windows.Forms.ComboBox()
        Me.btnCancelarMigracion = New System.Windows.Forms.Button()
        Me.btnAceptarMigracion = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelMigracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel2.Controls.Add(Me.btnMigracion)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 360)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 88)
        Me.Panel2.TabIndex = 1
        '
        'btnMigracion
        '
        Me.btnMigracion.BackColor = System.Drawing.Color.LightGray
        Me.btnMigracion.FlatAppearance.BorderSize = 0
        Me.btnMigracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMigracion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMigracion.Location = New System.Drawing.Point(43, 45)
        Me.btnMigracion.Name = "btnMigracion"
        Me.btnMigracion.Size = New System.Drawing.Size(220, 34)
        Me.btnMigracion.TabIndex = 4
        Me.btnMigracion.Text = "MIGRACIÓN MASIVA"
        Me.btnMigracion.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(156, 6)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(107, 34)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(269, 46)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 34)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightGray
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(269, 6)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(107, 34)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.LightGray
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(43, 6)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(107, 34)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MANTENEDOR DE ESPECIES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.lblIdEspecie)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(38, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 89)
        Me.Panel1.TabIndex = 6
        '
        'lblIdEspecie
        '
        Me.lblIdEspecie.AutoSize = True
        Me.lblIdEspecie.Location = New System.Drawing.Point(21, 51)
        Me.lblIdEspecie.Name = "lblIdEspecie"
        Me.lblIdEspecie.Size = New System.Drawing.Size(39, 13)
        Me.lblIdEspecie.TabIndex = 6
        Me.lblIdEspecie.Text = "Label3"
        Me.lblIdEspecie.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.LightGray
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(68, 51)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(107, 27)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        Me.btnAceptar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(181, 51)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 27)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(113, 15)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NOMBRE : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightGray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(103, 188)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(289, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "NOMBRE"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGray
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(38, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "ID"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'lstEspecies
        '
        Me.lstEspecies.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEspecies.FormattingEnabled = True
        Me.lstEspecies.ItemHeight = 19
        Me.lstEspecies.Location = New System.Drawing.Point(38, 217)
        Me.lstEspecies.Name = "lstEspecies"
        Me.lstEspecies.Size = New System.Drawing.Size(354, 118)
        Me.lstEspecies.TabIndex = 7
        '
        'panelMigracion
        '
        Me.panelMigracion.Controls.Add(Me.cmbEspecieNueva)
        Me.panelMigracion.Controls.Add(Me.cmbEspecieOriginal)
        Me.panelMigracion.Controls.Add(Me.btnCancelarMigracion)
        Me.panelMigracion.Controls.Add(Me.btnAceptarMigracion)
        Me.panelMigracion.Controls.Add(Me.Label6)
        Me.panelMigracion.Controls.Add(Me.Label5)
        Me.panelMigracion.Controls.Add(Me.Label3)
        Me.panelMigracion.Location = New System.Drawing.Point(12, 14)
        Me.panelMigracion.Name = "panelMigracion"
        Me.panelMigracion.Size = New System.Drawing.Size(58, 39)
        Me.panelMigracion.TabIndex = 10
        Me.panelMigracion.Visible = False
        '
        'cmbEspecieNueva
        '
        Me.cmbEspecieNueva.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecieNueva.FormattingEnabled = True
        Me.cmbEspecieNueva.Location = New System.Drawing.Point(37, 211)
        Me.cmbEspecieNueva.Name = "cmbEspecieNueva"
        Me.cmbEspecieNueva.Size = New System.Drawing.Size(319, 23)
        Me.cmbEspecieNueva.TabIndex = 6
        '
        'cmbEspecieOriginal
        '
        Me.cmbEspecieOriginal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecieOriginal.FormattingEnabled = True
        Me.cmbEspecieOriginal.Location = New System.Drawing.Point(37, 153)
        Me.cmbEspecieOriginal.Name = "cmbEspecieOriginal"
        Me.cmbEspecieOriginal.Size = New System.Drawing.Size(319, 23)
        Me.cmbEspecieOriginal.TabIndex = 5
        '
        'btnCancelarMigracion
        '
        Me.btnCancelarMigracion.BackColor = System.Drawing.Color.LightGray
        Me.btnCancelarMigracion.FlatAppearance.BorderSize = 0
        Me.btnCancelarMigracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarMigracion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarMigracion.Location = New System.Drawing.Point(206, 257)
        Me.btnCancelarMigracion.Name = "btnCancelarMigracion"
        Me.btnCancelarMigracion.Size = New System.Drawing.Size(147, 34)
        Me.btnCancelarMigracion.TabIndex = 4
        Me.btnCancelarMigracion.Text = "CANCELAR"
        Me.btnCancelarMigracion.UseVisualStyleBackColor = False
        '
        'btnAceptarMigracion
        '
        Me.btnAceptarMigracion.BackColor = System.Drawing.Color.LightGray
        Me.btnAceptarMigracion.FlatAppearance.BorderSize = 0
        Me.btnAceptarMigracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarMigracion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarMigracion.Location = New System.Drawing.Point(53, 257)
        Me.btnAceptarMigracion.Name = "btnAceptarMigracion"
        Me.btnAceptarMigracion.Size = New System.Drawing.Size(147, 34)
        Me.btnAceptarMigracion.TabIndex = 3
        Me.btnAceptarMigracion.Text = "ACEPTAR"
        Me.btnAceptarMigracion.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "A esta especie : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(335, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cambiar todas las razas de esta especie : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MIGRACIÓN MASIVA"
        '
        'FRM_MantenedorEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(429, 448)
        Me.Controls.Add(Me.panelMigracion)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lstEspecies)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_MantenedorEspecies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_MantenedorEspecies"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelMigracion.ResumeLayout(False)
        Me.panelMigracion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents lstEspecies As ListBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblIdEspecie As Label
    Friend WithEvents btnMigracion As Button
    Friend WithEvents panelMigracion As Panel
    Friend WithEvents btnCancelarMigracion As Button
    Friend WithEvents btnAceptarMigracion As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEspecieNueva As ComboBox
    Friend WithEvents cmbEspecieOriginal As ComboBox
End Class

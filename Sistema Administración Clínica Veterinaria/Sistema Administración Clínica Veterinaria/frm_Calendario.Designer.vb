<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Calendario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Calendario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbVolver = New System.Windows.Forms.PictureBox()
        Me.panelBusMascota = New System.Windows.Forms.Panel()
        Me.bgnCanBusMascota = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBusNomCliente = New System.Windows.Forms.Label()
        Me.lblBusEspecie = New System.Windows.Forms.Label()
        Me.lblBusNomMascota = New System.Windows.Forms.Label()
        Me.lblBusIdFicha = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelBusCliente = New System.Windows.Forms.Panel()
        Me.btnAtencionesMascotas = New System.Windows.Forms.Button()
        Me.lbl_fecha_sel = New System.Windows.Forms.Label()
        Me.calendario = New AxMSComCtl2.AxMonthView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_agendar = New System.Windows.Forms.Panel()
        Me.lblCodAtAgendada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtbMotivo = New System.Windows.Forms.RichTextBox()
        Me.btn_agendar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_fono_cliente = New System.Windows.Forms.Label()
        Me.lbl_nom_cliente = New System.Windows.Forms.Label()
        Me.lbl_especie = New System.Windows.Forms.Label()
        Me.lbl_nom_mascota = New System.Windows.Forms.Label()
        Me.lbl_id_ficha = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelSeleccionarMascota = New System.Windows.Forms.Panel()
        Me.btn_busqueda = New System.Windows.Forms.Button()
        Me.panelAtenciones = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnAgendar = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBusMascota.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.calendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_agendar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelSeleccionarMascota.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pbVolver)
        Me.Panel1.Controls.Add(Me.panelBusMascota)
        Me.Panel1.Controls.Add(Me.panelBusCliente)
        Me.Panel1.Controls.Add(Me.btnAtencionesMascotas)
        Me.Panel1.Controls.Add(Me.lbl_fecha_sel)
        Me.Panel1.Controls.Add(Me.calendario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 440)
        Me.Panel1.TabIndex = 1
        '
        'pbVolver
        '
        Me.pbVolver.Image = Global.Sistema_Administración_Clínica_Veterinaria.My.Resources.Resources.VOLVERCAL
        Me.pbVolver.Location = New System.Drawing.Point(19, 3)
        Me.pbVolver.Name = "pbVolver"
        Me.pbVolver.Size = New System.Drawing.Size(28, 17)
        Me.pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVolver.TabIndex = 39
        Me.pbVolver.TabStop = False
        Me.pbVolver.Visible = False
        '
        'panelBusMascota
        '
        Me.panelBusMascota.BackColor = System.Drawing.Color.Olive
        Me.panelBusMascota.Controls.Add(Me.bgnCanBusMascota)
        Me.panelBusMascota.Controls.Add(Me.GroupBox2)
        Me.panelBusMascota.Controls.Add(Me.Label7)
        Me.panelBusMascota.Location = New System.Drawing.Point(237, 6)
        Me.panelBusMascota.Name = "panelBusMascota"
        Me.panelBusMascota.Size = New System.Drawing.Size(30, 17)
        Me.panelBusMascota.TabIndex = 37
        Me.panelBusMascota.Visible = False
        '
        'bgnCanBusMascota
        '
        Me.bgnCanBusMascota.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.bgnCanBusMascota.FlatAppearance.BorderSize = 0
        Me.bgnCanBusMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bgnCanBusMascota.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgnCanBusMascota.ForeColor = System.Drawing.Color.White
        Me.bgnCanBusMascota.Location = New System.Drawing.Point(195, 111)
        Me.bgnCanBusMascota.Name = "bgnCanBusMascota"
        Me.bgnCanBusMascota.Size = New System.Drawing.Size(120, 23)
        Me.bgnCanBusMascota.TabIndex = 6
        Me.bgnCanBusMascota.Text = "Quitar Filtro"
        Me.bgnCanBusMascota.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBusNomCliente)
        Me.GroupBox2.Controls.Add(Me.lblBusEspecie)
        Me.GroupBox2.Controls.Add(Me.lblBusNomMascota)
        Me.GroupBox2.Controls.Add(Me.lblBusIdFicha)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 79)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'lblBusNomCliente
        '
        Me.lblBusNomCliente.AutoSize = True
        Me.lblBusNomCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusNomCliente.ForeColor = System.Drawing.Color.White
        Me.lblBusNomCliente.Location = New System.Drawing.Point(75, 59)
        Me.lblBusNomCliente.Name = "lblBusNomCliente"
        Me.lblBusNomCliente.Size = New System.Drawing.Size(51, 17)
        Me.lblBusNomCliente.TabIndex = 11
        Me.lblBusNomCliente.Text = "cliente"
        '
        'lblBusEspecie
        '
        Me.lblBusEspecie.AutoSize = True
        Me.lblBusEspecie.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusEspecie.ForeColor = System.Drawing.Color.White
        Me.lblBusEspecie.Location = New System.Drawing.Point(75, 43)
        Me.lblBusEspecie.Name = "lblBusEspecie"
        Me.lblBusEspecie.Size = New System.Drawing.Size(57, 17)
        Me.lblBusEspecie.TabIndex = 10
        Me.lblBusEspecie.Text = "especie"
        '
        'lblBusNomMascota
        '
        Me.lblBusNomMascota.AutoSize = True
        Me.lblBusNomMascota.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusNomMascota.ForeColor = System.Drawing.Color.White
        Me.lblBusNomMascota.Location = New System.Drawing.Point(75, 27)
        Me.lblBusNomMascota.Name = "lblBusNomMascota"
        Me.lblBusNomMascota.Size = New System.Drawing.Size(59, 17)
        Me.lblBusNomMascota.TabIndex = 9
        Me.lblBusNomMascota.Text = "nombre"
        '
        'lblBusIdFicha
        '
        Me.lblBusIdFicha.AutoSize = True
        Me.lblBusIdFicha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusIdFicha.ForeColor = System.Drawing.Color.White
        Me.lblBusIdFicha.Location = New System.Drawing.Point(75, 10)
        Me.lblBusIdFicha.Name = "lblBusIdFicha"
        Me.lblBusIdFicha.Size = New System.Drawing.Size(58, 17)
        Me.lblBusIdFicha.TabIndex = 8
        Me.lblBusIdFicha.Text = "numero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nombre : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Especie : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cliente : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "N° Ficha : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(90, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "FILTRO POR MASCOTA"
        '
        'panelBusCliente
        '
        Me.panelBusCliente.BackColor = System.Drawing.Color.Olive
        Me.panelBusCliente.Location = New System.Drawing.Point(301, 3)
        Me.panelBusCliente.Name = "panelBusCliente"
        Me.panelBusCliente.Size = New System.Drawing.Size(23, 20)
        Me.panelBusCliente.TabIndex = 36
        Me.panelBusCliente.Visible = False
        '
        'btnAtencionesMascotas
        '
        Me.btnAtencionesMascotas.BackColor = System.Drawing.Color.LightGray
        Me.btnAtencionesMascotas.FlatAppearance.BorderSize = 0
        Me.btnAtencionesMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtencionesMascotas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtencionesMascotas.Location = New System.Drawing.Point(0, 322)
        Me.btnAtencionesMascotas.Name = "btnAtencionesMascotas"
        Me.btnAtencionesMascotas.Size = New System.Drawing.Size(267, 31)
        Me.btnAtencionesMascotas.TabIndex = 37
        Me.btnAtencionesMascotas.Text = "FILTRAR POR MASCOTA"
        Me.btnAtencionesMascotas.UseVisualStyleBackColor = False
        '
        'lbl_fecha_sel
        '
        Me.lbl_fecha_sel.AutoSize = True
        Me.lbl_fecha_sel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha_sel.Location = New System.Drawing.Point(142, -1)
        Me.lbl_fecha_sel.Name = "lbl_fecha_sel"
        Me.lbl_fecha_sel.Size = New System.Drawing.Size(57, 20)
        Me.lbl_fecha_sel.TabIndex = 35
        Me.lbl_fecha_sel.Text = "Label2"
        '
        'calendario
        '
        Me.calendario.Location = New System.Drawing.Point(13, 25)
        Me.calendario.Name = "calendario"
        Me.calendario.OcxState = CType(resources.GetObject("calendario.OcxState"), System.Windows.Forms.AxHost.State)
        Me.calendario.Size = New System.Drawing.Size(311, 254)
        Me.calendario.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fecha : "
        '
        'panel_agendar
        '
        Me.panel_agendar.BackColor = System.Drawing.Color.White
        Me.panel_agendar.Controls.Add(Me.lblCodAtAgendada)
        Me.panel_agendar.Controls.Add(Me.Label2)
        Me.panel_agendar.Controls.Add(Me.rtbMotivo)
        Me.panel_agendar.Controls.Add(Me.btn_agendar)
        Me.panel_agendar.Controls.Add(Me.btn_cancelar)
        Me.panel_agendar.Controls.Add(Me.Panel4)
        Me.panel_agendar.Controls.Add(Me.dtp_fecha)
        Me.panel_agendar.Controls.Add(Me.Label12)
        Me.panel_agendar.Controls.Add(Me.lblTitulo)
        Me.panel_agendar.Controls.Add(Me.panelSeleccionarMascota)
        Me.panel_agendar.Location = New System.Drawing.Point(354, 64)
        Me.panel_agendar.Name = "panel_agendar"
        Me.panel_agendar.Size = New System.Drawing.Size(506, 423)
        Me.panel_agendar.TabIndex = 12
        Me.panel_agendar.Visible = False
        '
        'lblCodAtAgendada
        '
        Me.lblCodAtAgendada.AutoSize = True
        Me.lblCodAtAgendada.Location = New System.Drawing.Point(20, 18)
        Me.lblCodAtAgendada.Name = "lblCodAtAgendada"
        Me.lblCodAtAgendada.Size = New System.Drawing.Size(39, 13)
        Me.lblCodAtAgendada.TabIndex = 29
        Me.lblCodAtAgendada.Text = "Label3"
        Me.lblCodAtAgendada.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Motivo : "
        '
        'rtbMotivo
        '
        Me.rtbMotivo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMotivo.Location = New System.Drawing.Point(17, 306)
        Me.rtbMotivo.Name = "rtbMotivo"
        Me.rtbMotivo.Size = New System.Drawing.Size(477, 74)
        Me.rtbMotivo.TabIndex = 15
        Me.rtbMotivo.Text = ""
        '
        'btn_agendar
        '
        Me.btn_agendar.BackColor = System.Drawing.Color.LightGray
        Me.btn_agendar.FlatAppearance.BorderSize = 0
        Me.btn_agendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agendar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agendar.Location = New System.Drawing.Point(286, 386)
        Me.btn_agendar.Name = "btn_agendar"
        Me.btn_agendar.Size = New System.Drawing.Size(100, 31)
        Me.btn_agendar.TabIndex = 11
        Me.btn_agendar.Text = "Aceptar"
        Me.btn_agendar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.LightGray
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(392, 386)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(101, 31)
        Me.btn_cancelar.TabIndex = 12
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Location = New System.Drawing.Point(0, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(506, 140)
        Me.Panel4.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_fono_cliente)
        Me.GroupBox1.Controls.Add(Me.lbl_nom_cliente)
        Me.GroupBox1.Controls.Add(Me.lbl_especie)
        Me.GroupBox1.Controls.Add(Me.lbl_nom_mascota)
        Me.GroupBox1.Controls.Add(Me.lbl_id_ficha)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 120)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'lbl_fono_cliente
        '
        Me.lbl_fono_cliente.AutoSize = True
        Me.lbl_fono_cliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono_cliente.Location = New System.Drawing.Point(87, 91)
        Me.lbl_fono_cliente.Name = "lbl_fono_cliente"
        Me.lbl_fono_cliente.Size = New System.Drawing.Size(65, 20)
        Me.lbl_fono_cliente.TabIndex = 27
        Me.lbl_fono_cliente.Text = "Label19"
        '
        'lbl_nom_cliente
        '
        Me.lbl_nom_cliente.AutoSize = True
        Me.lbl_nom_cliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_cliente.Location = New System.Drawing.Point(87, 72)
        Me.lbl_nom_cliente.Name = "lbl_nom_cliente"
        Me.lbl_nom_cliente.Size = New System.Drawing.Size(65, 20)
        Me.lbl_nom_cliente.TabIndex = 26
        Me.lbl_nom_cliente.Text = "Label18"
        '
        'lbl_especie
        '
        Me.lbl_especie.AutoSize = True
        Me.lbl_especie.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_especie.Location = New System.Drawing.Point(87, 53)
        Me.lbl_especie.Name = "lbl_especie"
        Me.lbl_especie.Size = New System.Drawing.Size(65, 20)
        Me.lbl_especie.TabIndex = 25
        Me.lbl_especie.Text = "Label17"
        '
        'lbl_nom_mascota
        '
        Me.lbl_nom_mascota.AutoSize = True
        Me.lbl_nom_mascota.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_mascota.Location = New System.Drawing.Point(87, 34)
        Me.lbl_nom_mascota.Name = "lbl_nom_mascota"
        Me.lbl_nom_mascota.Size = New System.Drawing.Size(65, 20)
        Me.lbl_nom_mascota.TabIndex = 24
        Me.lbl_nom_mascota.Text = "Label16"
        '
        'lbl_id_ficha
        '
        Me.lbl_id_ficha.AutoSize = True
        Me.lbl_id_ficha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_ficha.Location = New System.Drawing.Point(87, 15)
        Me.lbl_id_ficha.Name = "lbl_id_ficha"
        Me.lbl_id_ficha.Size = New System.Drawing.Size(65, 20)
        Me.lbl_id_ficha.TabIndex = 23
        Me.lbl_id_ficha.Text = "Label15"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 20)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Especie : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "N° Ficha : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nombre : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Dueño : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Fono : "
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Location = New System.Drawing.Point(206, 254)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(252, 21)
        Me.dtp_fecha.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(191, 21)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Seleccione una fecha : "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(156, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(183, 21)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "AGENDAR ATENCIÓN"
        '
        'panelSeleccionarMascota
        '
        Me.panelSeleccionarMascota.BackColor = System.Drawing.Color.LightGray
        Me.panelSeleccionarMascota.Controls.Add(Me.btn_busqueda)
        Me.panelSeleccionarMascota.Location = New System.Drawing.Point(0, 51)
        Me.panelSeleccionarMascota.Name = "panelSeleccionarMascota"
        Me.panelSeleccionarMascota.Size = New System.Drawing.Size(508, 53)
        Me.panelSeleccionarMascota.TabIndex = 3
        '
        'btn_busqueda
        '
        Me.btn_busqueda.BackColor = System.Drawing.Color.Silver
        Me.btn_busqueda.FlatAppearance.BorderSize = 0
        Me.btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_busqueda.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_busqueda.Location = New System.Drawing.Point(133, 11)
        Me.btn_busqueda.Name = "btn_busqueda"
        Me.btn_busqueda.Size = New System.Drawing.Size(232, 31)
        Me.btn_busqueda.TabIndex = 2
        Me.btn_busqueda.Text = "SELECCIONAR MASCOTA"
        Me.btn_busqueda.UseVisualStyleBackColor = False
        '
        'panelAtenciones
        '
        Me.panelAtenciones.AutoScroll = True
        Me.panelAtenciones.Location = New System.Drawing.Point(73, 8)
        Me.panelAtenciones.Name = "panelAtenciones"
        Me.panelAtenciones.Size = New System.Drawing.Size(27, 27)
        Me.panelAtenciones.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Teal
        Me.Panel7.Controls.Add(Me.btnAgendar)
        Me.Panel7.Controls.Add(Me.btnS)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 493)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(874, 45)
        Me.Panel7.TabIndex = 3
        '
        'btnAgendar
        '
        Me.btnAgendar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAgendar.FlatAppearance.BorderSize = 0
        Me.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendar.ForeColor = System.Drawing.Color.White
        Me.btnAgendar.Location = New System.Drawing.Point(15, 9)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(262, 27)
        Me.btnAgendar.TabIndex = 1
        Me.btnAgendar.Text = "AGENDAR ATENCIÓN"
        Me.btnAgendar.UseVisualStyleBackColor = False
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnS.FlatAppearance.BorderSize = 0
        Me.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS.ForeColor = System.Drawing.Color.White
        Me.btnS.Location = New System.Drawing.Point(730, 9)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(130, 27)
        Me.btnS.TabIndex = 0
        Me.btnS.Text = "SALIR"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Location = New System.Drawing.Point(15, 11)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(32, 37)
        Me.Panel8.TabIndex = 4
        Me.Panel8.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(19, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "para el dia : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(19, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(301, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "No hay atenciones registradas ni agendadas "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(267, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(312, 24)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "CALENDARIO DE ATENCIONES"
        '
        'frm_Calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(874, 538)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.panel_agendar)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.panelAtenciones)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Calendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALENDARIO DE ATENCIONES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBusMascota.ResumeLayout(False)
        Me.panelBusMascota.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.calendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_agendar.ResumeLayout(False)
        Me.panel_agendar.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelSeleccionarMascota.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents calendario As AxMSComCtl2.AxMonthView
    Friend WithEvents lbl_fecha_sel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_agendar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agendar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents panelSeleccionarMascota As Panel
    Friend WithEvents btn_busqueda As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents panelAtenciones As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnS As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAgendar As Button
    Friend WithEvents rtbMotivo As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_fono_cliente As Label
    Friend WithEvents lbl_nom_cliente As Label
    Friend WithEvents lbl_especie As Label
    Friend WithEvents lbl_nom_mascota As Label
    Friend WithEvents lbl_id_ficha As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCodAtAgendada As Label
    Friend WithEvents panelBusCliente As Panel
    Friend WithEvents panelBusMascota As Panel
    Friend WithEvents btnAtencionesMascotas As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblBusNomCliente As Label
    Friend WithEvents lblBusEspecie As Label
    Friend WithEvents lblBusNomMascota As Label
    Friend WithEvents lblBusIdFicha As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bgnCanBusMascota As Button
    Friend WithEvents pbVolver As PictureBox
End Class

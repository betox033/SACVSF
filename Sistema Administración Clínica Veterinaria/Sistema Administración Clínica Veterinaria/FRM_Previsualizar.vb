Imports iText.IO.Font
Imports iText.IO.Image
Imports iText.Kernel.Font
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports MySql.Data.MySqlClient

Public Class FRM_Previsualizar

    Public codigo As String = ""
    Public id_ficha As String = ""
    Public cod_atencion As String = ""

    Protected _atencion As Atencion
    Protected _mascota As Mascota
    Protected _cliente As Cliente
    Protected _frmPerfil As FRM_Perfil
    Protected _hosp As Hospitalizacion
    Protected _listaAte As New List(Of Atencion)
    Protected _listaHosp As New List(Of Hospitalizacion)
    Protected _listaVac As New List(Of Vacuna)

    Protected _modPDF As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(atencion As Atencion, mascota As Mascota, cliente As Cliente, frmPerfil As FRM_Perfil)
        MyBase.New()
        _atencion = atencion
        _mascota = mascota
        _cliente = cliente
        _frmPerfil = frmPerfil
        _modPDF = "atencion"
        InitializeComponent()
    End Sub

    Public Sub New(hosp As Hospitalizacion, mascota As Mascota, cliente As Cliente, frmPerfil As FRM_Perfil)
        _hosp = hosp
        _mascota = mascota
        _cliente = cliente
        _frmPerfil = frmPerfil
        _modPDF = "hosp"
        InitializeComponent()
    End Sub

    Public Sub New(mascota As Mascota, cliente As Cliente, frmPerfil As FRM_Perfil, listaAte As List(Of Atencion),
                   listaHosp As List(Of Hospitalizacion), listaVac As List(Of Vacuna))
        MyBase.New()
        _mascota = mascota
        _cliente = cliente
        _frmPerfil = frmPerfil
        _listaAte = listaAte
        _listaHosp = listaHosp
        _listaVac = listaVac
        _modPDF = "general"
        InitializeComponent()
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        _frmPerfil.Show()
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub FRM_Previsualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encabezado()
        CuerpoTexto()
        verificar_largo()
        Dim bsnNegocio As New BsnNegocio
        codigo = bsnNegocio.GenerarNumPDF
        Dim nombreUsuario As String = Environment.UserName
        txtRuta.Text = "C:\Users\" & nombreUsuario & "\Desktop"
    End Sub

    Function Encabezado()
        'Dim img_encabezado As Image = Image.FromFile("C:\Users\betox_000\Desktop\Titulo\Programa\Sistema Administración Clínica Veterinaria\Sistema Administración Clínica Veterinaria\img\botones\Portada.png")
        'Clipboard.SetImage(img_encabezado)
        Return 0
    End Function

    Sub CuerpoTexto()
        Dim conv = New Convertir

        Dim nom_mascota As String = conv.formato_espacios(_mascota.NomMascota, 30 - _mascota.NomMascota.Length)
        Dim idRaza As Integer = _mascota.IdRaza
        Dim raza As New Raza : Dim bsnRaza As New BsnRaza : raza = bsnRaza.GetDatosRaza(idRaza)
        Dim especie As New Especie : Dim bsnEspecie As New BsnEspecie
        especie = bsnEspecie.GetDatosEspecie(raza.IdEspecie)

        Dim nomEspecie As String = conv.formato_espacios(especie.NomEspecie, 15 - especie.NomEspecie.Length)
        Dim nomRaza As String = conv.formato_espacios(raza.NomRaza, 15 - raza.NomRaza.Length)
        Dim sexo As Char = _mascota.Sexo : Dim sexoString As String = ""

        If sexo = "M" Then
            sexoString = "MASCULINO"
        Else
            sexoString = "FEMENINO "
        End If

        sexoString = conv.formato_espacios(sexoString, 20 - sexoString.Length)

        Dim color As String = conv.formato_espacios(_mascota.Color, 15 - _mascota.Color.Length)
        Dim dueño As String = conv.formato_espacios(_cliente.Nombre, 30 - _cliente.Nombre.Length)


        Dim texto As String = "" : Dim subPerfil As String = ""

        texto = "*********************************************************************" & vbLf &
                "_______________________ DETALLES DE LA MASCOTA ________________________" & vbLf &
                texto & "ID Ficha : " & _mascota.IdFicha & vbLf & "Nombre : " & nom_mascota & vbLf &
                "Especie : " & nomEspecie & "Raza : " & nomRaza & vbLf &
                "Sexo : " & sexoString & "Color : " & color & vbLf &
                "Dueño : " & _cliente.Nombre & vbLf &
                "*********************************************************************" & vbLf

        Select Case _modPDF
            Case "atencion"
                Dim fecha_atencion As String = conv.formato_espacios(_atencion.FechaAtencion, 10)
                Dim veterinario As New Veterinario : Dim bsnVeterinario As New BsnVeterinario
                veterinario = bsnVeterinario.GetDatosVeterinario(_atencion.NumVeterinario)
                Dim nomVeterinario As String = conv.formato_espacios(veterinario.NomVeterinario, 25 - veterinario.NomVeterinario.Length)
                Dim peso As String = conv.formato_espacios(_atencion.Peso, 15)
                Dim altura As String = conv.formato_espacios(_atencion.Altura, 15)
                Dim temperatura As String = conv.formato_espacios(_atencion.Temperatura, 15)
                Dim detalle As String = _atencion.Descripcion
                Dim costo As String = _atencion.Costo

                subPerfil = "______________________ DETALLE DE LA ATENCION _________________________" & vbLf &
                "Cod. Atención : " & _atencion.CodAtencion & vbLf &
                "Fecha : " & fecha_atencion & "Veterinario : " & nomVeterinario & vbLf &
                "Peso : " & peso & "Altura : " & altura & "Temperatura : " & temperatura & vbLf &
                "*********************************************************************" & vbLf & vbLf &
                detalle & vbLf & "------------------------------------------------------------------------------------------------------" & vbLf &
                "Costo : " & costo

            Case "hosp"
                subPerfil = "_________________ DETALLE DE LA HOSPITALIZACIÓN ______________________" & vbLf &
                "Cod.Hospitalización : " & _hosp.IdHosp & vbLf &
                "Fecha Ingreso : " & _hosp.FechaHosp & "     Fecha Salida : " & _hosp.FechaSalida & vbLf &
                "*********************************************************************" & vbLf & vbLf &
                _hosp.Descripcion & vbLf &
                "------------------------------------------------------------------------------------------------------" & vbLf &
                "Costo : " & _hosp.Total
            Case "general"
                subPerfil = "__________________________ATENCIONES__________________________________" & vbLf & vbLf &
                             "N° DE ATENCIONES: " & _listaAte.Count & vbLf &
                             "*********************************************************************" & vbLf &
                             "CODIGO    FECHA       PESO  ALT.  TEMP. COSTO" & vbLf
                Dim detalle As String = "{0,-10}{1,-12}{2,-6}{3,-6}{4,-6}{5,-10}"
                For Each atencion As Atencion In _listaAte
                    subPerfil = subPerfil & String.Format(detalle, atencion.CodAtencion, atencion.FechaAtencion, atencion.Peso,
                                                          atencion.Altura, atencion.Temperatura, atencion.Costo) & vbLf
                Next
                subPerfil = subPerfil & vbLf & vbLf & vbLf
                subPerfil = subPerfil & "__________________________HOSPITALIZACIONES___________________________" & vbLf & vbLf &
                            "N° DE HOSPITALIZACIONES: " & _listaHosp.Count & vbLf &
                            "*********************************************************************" & vbLf &
                            "CODIGO  FECH.IN     FECH.SA     COSTO" & vbLf
                detalle = "{0,-8}{1,-12}{2,-12}{3,-8}"
                For Each hosp As Hospitalizacion In _listaHosp
                    Dim fecha1 As String = hosp.FechaHosp : fecha1 = fecha1.Substring(0, 10)
                    Dim fecha2 As String = hosp.FechaSalida : fecha2 = fecha2.Substring(0, 10)
                    subPerfil = subPerfil & String.Format(detalle, hosp.IdHosp, fecha1, fecha2, hosp.Total) & vbLf
                Next
                subPerfil = subPerfil & vbLf & vbLf & vbLf
                subPerfil = subPerfil & "__________________________VACUNAS_____________________________________" & vbLf & vbLf &
                            "N° DE VACUNAS : " & _listaVac.Count & vbLf &
                            "*********************************************************************" & vbLf &
                            "CODIGO  PRODUCTO                        DOSIS  FECHA      FECHA.PROX" & vbLf
                detalle = "{0,-8}{1,-32}{2,-7}{3,-11}{4,-10}"
                For Each vacuna As Vacuna In _listaVac
                    Dim producto As New Producto : Dim bsnProducto As New BsnProductos
                    Dim fecha3 As String = vacuna.FechaVacuna : fecha3 = fecha3.Substring(0, 10)
                    Dim fecha4 As String = vacuna.FechaProxVacuna : fecha4 = fecha4.Substring(0, 10)
                    producto = bsnProducto.GetDatosProducto(vacuna.Codproducto)
                    Dim cadena As String = producto.NomProducto
                    If vacuna.NOrdinal > 0 Then
                        cadena = vacuna.NOrdinal & "° " & producto.NomProducto
                    End If

                    subPerfil = subPerfil & String.Format(detalle, vacuna.NumVacuna, cadena, vacuna.Dosis,
                                                          fecha3, fecha4) & vbLf
                Next
        End Select

        texto = texto & subPerfil
        lbl_contenido.Text = texto
    End Sub

    Sub verificar_largo()
        Dim alto_label As Integer = lbl_contenido.Height
        Dim alto_panel As Integer = panel_principal.Height
        If alto_label > alto_panel - 200 Then
            'MsgBox("Alto del label : " & alto_label & vbLf & "Alto del panel : " & alto_panel)
            panel_principal.SetBounds(4, 4, 570, alto_label + 300)
            alto_panel = panel_principal.Height
            'MsgBox("Alto del label : " & alto_label & vbLf & "Alto del panel : " & alto_panel)
        End If
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim bsnNegocio As New BsnNegocio
        Dim codigoArchivo As Integer = bsnNegocio.GenerarNumPDF()
        ActualizarCodigoPDF(codigoArchivo)

        Dim codSubPerfil As Integer = 0 : Dim tipo As String = ""
        Select Case _modPDF
            Case "atencion" : codSubPerfil = _atencion.CodAtencion : tipo = "ATCN"
            Case "hosp" : codSubPerfil = _hosp.IdHosp : tipo = "HOSP"
        End Select

        Dim direccion As String = txtRuta.Text & "\" & codigoArchivo & "_" & _mascota.IdFicha & "_" &
                                  tipo & codSubPerfil & ".pdf"
        Dim writer = New PdfWriter(direccion)
        Dim Pdf = New PdfDocument(writer)
        Dim Document = New Document(Pdf)


        Dim fuente = PdfFontFactory.CreateFont(FontConstants.COURIER)

        Dim conv = New Convertir
        Document.Add(New Paragraph(lbl_contenido.Text).SetFont(fuente))
        Document.Close()
        MsgBox("El archivo PDF ha sido creado correctamente.")
        _frmPerfil.Show() : Me.Close() : Me.Close()
    End Sub

    Sub ActualizarCodigoPDF(codigoArchivo As Integer)
        Dim conexion As New Conexion
        Dim ssql As String = "update configuracion set num_pdf = " & codigoArchivo
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Using Folder As New FolderBrowserDialog
            If Folder.ShowDialog = DialogResult.OK Then
                MessageBox.Show(Folder.SelectedPath)
                txtRuta.Text = Folder.SelectedPath
            End If
        End Using
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
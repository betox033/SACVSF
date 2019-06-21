Imports MySql.Data.MySqlClient

Public Class FRM_ModificarAtencion
    Protected _atencion As Atencion
    Protected _frmPerfil As FRM_Perfil

    Dim detalle As String = "{0, -5}{1, -30}"

    Public Sub New(frmPerfil As FRM_Perfil, atencion As Atencion)
        MyBase.New()
        _frmPerfil = frmPerfil
        _atencion = atencion
        InitializeComponent()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FRM_ModificarAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(170, 0, 0, 0)
        LlenarVeterinarios()
        Dim lg As Integer = cmbVeterinarios.Items.Count
        Dim i As Integer = 0
        Dim cadena As String = ""
        Dim numVeterinario As Integer = 0
        Dim encontrado As Boolean = False
        While i < lg And encontrado = False
            cadena = cmbVeterinarios.Items.Item(i)
            numVeterinario = Convert.ToInt32(Trim(cadena.Substring(0, 5)))
            If numVeterinario = _atencion.NumVeterinario Then
                cmbVeterinarios.SelectedIndex = i
                encontrado = True
            End If
            i = i + 1
        End While
        txtPeso.Text = _atencion.Peso
        txtAltura.Text = _atencion.Altura
        txtTemperatura.Text = _atencion.Temperatura
        rtbDescripcion.Text = _atencion.Descripcion
    End Sub

    Sub LlenarVeterinarios()
        Dim listVeterinarios As New List(Of Veterinario) : Dim bsnVeterinario As New BsnVeterinario
        listVeterinarios = bsnVeterinario.GetVeterinarios("num_veterinario")
        For Each vet As Veterinario In listVeterinarios
            cmbVeterinarios.Items.Add(String.Format(detalle, vet.NumVeterinario, vet.NomVeterinario))
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _frmPerfil.Show() : Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Trim(rtbDescripcion.Text) = "" Then
            MsgBox("Debe ingresar contenido en la descripción.")
        End If

        Dim cadena As String = cmbVeterinarios.SelectedItem
        _atencion.NumVeterinario = Convert.ToInt32(Trim(cadena.Substring(0, 5)))

        Dim bloque As New BloqueCodigo
        bloque.FormatoDecimalPunto()

        Dim peso As String = Trim(txtPeso.Text)
        Dim altura As String = Trim(txtAltura.Text)
        Dim temperatura As String = Trim(txtTemperatura.Text)

        If peso = "" Then
            _atencion.Peso = 0
        Else
            peso = peso.Replace(".", "") : _atencion.Peso = Convert.ToInt32(peso)
        End If
        If altura = "" Then
            _atencion.Altura = 0
        Else
            altura = altura.Replace(",", ".") : _atencion.Altura = Convert.ToDouble(altura)
        End If
        If temperatura = "" Then
            _atencion.Temperatura = 0
        Else
            temperatura = temperatura.Replace(",", ".") : _atencion.Temperatura = Convert.ToDouble(temperatura)
        End If

        _atencion.Descripcion = rtbDescripcion.Text
        Dim bsnAtencion As New BsnAtencion
        bsnAtencion.ModificarAtencion(_atencion)
        MsgBox("La atención registrada se modifico correctamente.")
        _frmPerfil.CargarDatosAtencion(_atencion.CodAtencion)
        _frmPerfil.Show() : Me.Close()
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        If (Asc(e.KeyChar) <> 8) Then 'borrar
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAltura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAltura.KeyPress
        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txtAltura.Text.Length
            While i < lg And encontrado = False
                If txtAltura.Text.Chars(i) = "." Or txtAltura.Text.Chars(i) = "," Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 44) Then ' coma
            If (Asc(e.KeyChar) <> 46) Then ' punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTemperatura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTemperatura.KeyPress
        Dim caracter As String = e.KeyChar : Dim encontrado As Boolean = False
        If caracter = "." Or caracter = "," Then
            Dim i As Integer = 0 : Dim lg As Integer = txtTemperatura.Text.Length
            While i < lg And encontrado = False
                If txtTemperatura.Text.Chars(i) = "." Or txtTemperatura.Text.Chars(i) = "," Then
                    e.Handled = True : encontrado = True
                End If
                i = i + 1
            End While
        End If

        If (Asc(e.KeyChar) <> 44) Then ' coma
            If (Asc(e.KeyChar) <> 46) Then ' punto
                If (Asc(e.KeyChar) <> 8) Then 'borrar
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numeros
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub rtbDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbDescripcion.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub
End Class
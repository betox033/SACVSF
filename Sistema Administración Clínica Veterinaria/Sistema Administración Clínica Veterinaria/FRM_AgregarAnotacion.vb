Public Class FRM_AgregarAnotacion

    Protected _idAtencion As Integer
    Protected _frmRegistrarAtencion As frm_Registrar_Atencion
    Protected _frmPerfil As FRM_Perfil
    Protected _observacion As Observacion
    Protected _modoVentana As String
    Protected _modoOpcion As String


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(idAtencion As Integer, frmRegistrarAtencion As frm_Registrar_Atencion)
        _idAtencion = idAtencion
        _frmRegistrarAtencion = frmRegistrarAtencion
        _modoVentana = "atencion"
        InitializeComponent()
    End Sub

    Public Sub New(frmPerfil As FRM_Perfil, observacion As Observacion, modoOpcion As String)
        _frmPerfil = frmPerfil
        _observacion = observacion
        _modoVentana = "perfil"
        _modoOpcion = modoOpcion
        InitializeComponent()
    End Sub

    Private Sub FRM_AgregarAnotacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _modoVentana
            Case "atencion"
                lblCodAtencion.Text = _idAtencion
            Case "perfil"
                Label2.Visible = False : lblCodAtencion.Visible = False
                lblIdOb.Text = _observacion.NumObservacion
                rtbObservacion.Text = _observacion.Descripcion
                If _modoOpcion = "modificar" Then
                    Button1.Text = "MODIFICAR" : Label1.Text = "MODIFICAR OBSERVACIÓN" : Label1.Left = 160
                End If
        End Select
        Panel2.BackColor = Color.FromArgb(170, 0, 0, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case _modoVentana
            Case "atencion" : _frmRegistrarAtencion.Show()
            Case "perfil" : _frmPerfil.Show()
        End Select
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(rtbObservacion.Text) = "" Then
            MsgBox("Debe ingresar una observación.")
            Exit Sub
        End If

        Select Case _modoVentana
            Case "atencion"
                With _frmRegistrarAtencion.lstObservaciones.Items.Add("N")
                    .SubItems.Add(rtbObservacion.Text)
                    .SubItems.Add("")
                End With
                _frmRegistrarAtencion.Show()
            Case "perfil"
                _observacion.Descripcion = rtbObservacion.Text
                _observacion.FechaObservacion = System.DateTime.Today.ToString("yyyy-MM-dd")
                Dim bsnOb As New BsnObservacion

                Select Case _modoOpcion
                    Case "agregar"
                        bsnOb.InsertarObservacion(_observacion)
                        MsgBox("La observación fue agregada correctamente.")
                        _frmPerfil.lblIdObservacion.Text = _observacion.NumObservacion
                    Case "modificar"
                        bsnOb.ModificarObservacion(_observacion)
                        MsgBox("La observación ha sido modificada correctamente.")
                End Select
                _frmPerfil.rtbObservaciones.Text = _observacion.Descripcion
                _frmPerfil.CargarObservaciones()
                _frmPerfil.Show()
        End Select
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub rtbObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbObservacion.KeyPress
        Dim caracter As Char = e.KeyChar
        If caracter = "'" Then
            e.Handled = True
        End If
    End Sub
End Class
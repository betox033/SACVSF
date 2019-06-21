Imports System.Net.Mail

Public Class ProcedimientoExterno

    Sub EnviarCorreos()
        Dim convertir As New Convertir
        Dim fechaLimite As String = DateAdd(DateInterval.Day, 2, Now)
        fechaLimite = convertir.invertir_fecha(fechaLimite.Substring(0, 10))
        Dim bsnVacuna As New BsnVacuna : Dim listaVacunas As New List(Of Vacuna)
        listaVacunas = bsnVacuna.GetVacunasFecha(fechaLimite)
        For Each vacuna As Vacuna In listaVacunas
            Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(vacuna.IdFicha)
            Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
            Dim producto As New Producto : Dim bsnProducto As New BsnProductos : producto = bsnProducto.GetDatosProducto(vacuna.Codproducto)
            If cliente.Correo <> "" And vacuna.CorreoEnviado = False Then
                GenerarCorreoVacuna(vacuna, mascota, cliente, producto)
            End If
        Next

        Dim bsnAtencion As New BsnAtencion : Dim listaAtenciones As New List(Of Atencion)
        listaAtenciones = bsnAtencion.GetAtencionesFecha(fechaLimite.Substring(0, 10))
        For Each atencion In listaAtenciones
            Dim mascota As New Mascota : Dim bsnMascota As New BsnMascota : mascota = bsnMascota.GetDatosMascota(atencion.IdFicha)
            Dim cliente As New Cliente : Dim bsnCliente As New BsnCliente : cliente = bsnCliente.GetDatosCliente(mascota.IdCliente)
            If cliente.Correo <> "" And atencion.CorreoEnviado = False Then
                GenerarCorreoAtencion(atencion, mascota, cliente)
            End If
        Next
    End Sub

    Sub GenerarCorreoAtencion(atencion As Atencion, mascota As Mascota, cliente As Cliente)
        Try
            Dim bsnAtencion As New BsnAtencion
            Dim bsnNegocio As New BsnNegocio

            Dim smtpServer As New SmtpClient : Dim email As New MailMessage : smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New System.Net.NetworkCredential("clinicavetsfrancisco4@gmail.com", "h34ba5f*")
            smtpServer.Port = 587 : smtpServer.EnableSsl = True

            Dim host As String = bsnNegocio.GetHostCorreo(cliente.Correo) : smtpServer.Host = "smtp." & host
            email = New MailMessage : email.From = New MailAddress("clinicavetsfrancisco4@gmail.com")
            email.To.Add(cliente.Correo) : Dim fecha As String = atencion.FechaAtencion : fecha = fecha.Replace("/", "-")

            '//////////////////////////////////////////////////////////////////////////////////////////////
            Dim encabezado As String = "Recordatorio atención para la fecha : " & fecha &
                " - Clínica Veterinaria San Francisco."

            Dim cuerpo As String = "Estimado cliente : " & cliente.Nombre & vbLf &
                "Le recordamos que ha sido agendada una atención para su mascota : " & mascota.NomMascota &
                ", para la fecha " & fecha &
                vbLf & vbLf & "Sin más que decir, agradecemos su prefencia por nuestros servicios. " & vbLf & vbLf &
                "Este correo es solo informativo, por favor no responda."
            '/////////////////////////////////////////////////////////////////////////////////////////////
            email.Subject = encabezado : email.IsBodyHtml = False : email.Body = cuerpo : smtpServer.Send(email)
            bsnAtencion.ActualizarAtencionCorreoEnviado(atencion.CodAtencion)
        Catch ex As Exception

        End Try
    End Sub

    Sub GenerarCorreoVacuna(vacuna As Vacuna, mascota As Mascota, cliente As Cliente, producto As Producto)
        Try
            Dim bsnVacuna As New BsnVacuna
            Dim bsnNegocio As New BsnNegocio

            Dim smtpServer As New SmtpClient : Dim email As New MailMessage : smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New System.Net.NetworkCredential("clinicavetsfrancisco4@gmail.com", "h34ba5f*")
            smtpServer.Port = 587 : smtpServer.EnableSsl = True

            Dim host As String = bsnNegocio.GetHostCorreo(cliente.Correo) : smtpServer.Host = "smtp." & host
            email = New MailMessage : email.From = New MailAddress("clinicavetsfrancisco4@gmail.com")
            email.To.Add(cliente.Correo) : Dim fecha As String = vacuna.FechaProxVacuna : fecha = fecha.Replace("/", "-")

            '//////////////////////////////////////////////////////////////////////////////////////////////
            Dim encabezado As String = "Recordatorio Vacuna para la fecha : " & fecha &
                " - Clínica Veterinaria San Francisco."

            Dim cuerpo As String = "Estimado cliente : " & cliente.Nombre & vbLf &
                "Le recordamos que ha sido agendada una vacuna para su mascota : " & mascota.NomMascota &
                ", para la fecha " & fecha &
                vbLf & vbLf & "Sin más que decir, agradecemos su prefencia por nuestros servicios. " & vbLf & vbLf &
                "Este correo es solo informativo, por favor no responda."
            '/////////////////////////////////////////////////////////////////////////////////////////////

            email.Subject = encabezado : email.IsBodyHtml = False : email.Body = cuerpo : smtpServer.Send(email)
            bsnVacuna.ActualizarVacunaCorreoEnviado(vacuna.NumVacuna)
        Catch ex As Exception

        End Try
    End Sub

    Sub GenerarCorreoCancelacionAtencion(mascota As Mascota, cliente As Cliente, atencion As Atencion)
        Try
            Dim bsnAtencion As New BsnAtencion
            Dim bsnNegocio As New BsnNegocio

            Dim smtpServer As New SmtpClient : Dim email As New MailMessage : smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New System.Net.NetworkCredential("clinicavetsfrancisco4@gmail.com", "h34ba5f*")
            smtpServer.Port = 587 : smtpServer.EnableSsl = True

            Dim host As String = bsnNegocio.GetHostCorreo(cliente.Correo) : smtpServer.Host = "smtp." & host
            email = New MailMessage : email.From = New MailAddress("clinicavetsfrancisco4@gmail.com")
            email.To.Add(cliente.Correo) : Dim fecha As String = atencion.FechaAtencion : fecha = fecha.Replace("/", "-")

            '//////////////////////////////////////////////////////////////////////////////////////////////
            Dim encabezado As String = "CANCELACIÓN de atención para la fecha : " & fecha &
                " - Clínica Veterinaria San Francisco."

            Dim cuerpo As String = "Estimado cliente : " & cliente.Nombre & vbLf &
                "Le informamos que ha sido cancelada la atención para su mascota : " & mascota.NomMascota &
                ", para la fecha " & fecha &
                vbLf & vbLf & "Lamentamos los hechos y agradecemos su prefencia por nuestros servicios. " & vbLf & vbLf &
                "Este correo es solo informativo, por favor no responda."
            '/////////////////////////////////////////////////////////////////////////////////////////////
            email.Subject = encabezado : email.IsBodyHtml = False : email.Body = cuerpo : smtpServer.Send(email)
            bsnAtencion.ActualizarAtencionCorreoEnviado(atencion.CodAtencion)
        Catch ex As Exception

        End Try
    End Sub



End Class

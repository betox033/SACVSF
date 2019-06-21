


Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element

Public Class Prueba
    Private Sub btn_prueba_Click(sender As Object, e As EventArgs) Handles btn_prueba.Click
        Dim writer = New PdfWriter("C:\Users\betox_000\Desktop\hola_mundo.pdf")
        Dim Pdf = New PdfDocument(writer)
        Dim Document = New Document(Pdf)
        Document.Add(New Paragraph(txt_prueba.Text))
        Document.Close()
        MsgBox("El archivo PDF ha sido creado correctamente.")
    End Sub

    Private Sub Prueba_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub txt_prueba_TextChanged(sender As Object, e As EventArgs) Handles txt_prueba.TextChanged

    End Sub

    Private Sub txt_prueba_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prueba.KeyPress
        MsgBox(Asc(e.KeyChar))
    End Sub
End Class
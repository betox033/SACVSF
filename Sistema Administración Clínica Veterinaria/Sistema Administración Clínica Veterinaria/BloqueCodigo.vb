Public Class BloqueCodigo

    Sub FormatoDecimalPunto()
        '////////////////////////////////////////////////////////////
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        '////////////////////////////////////////////////////////////
    End Sub




End Class

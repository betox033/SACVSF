Public Class BsnAjuste

    Dim daoAjuste As New DaoAjuste

    Sub InsertarAjuste(ajuste As Ajuste)
        daoAjuste.InsertarAjuste(ajuste)
    End Sub
End Class

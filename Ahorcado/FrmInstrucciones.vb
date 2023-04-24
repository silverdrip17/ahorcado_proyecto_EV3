Public Class FrmInstrucciones
    Private Sub btnFacil_Click(sender As Object, e As EventArgs) Handles btnFacil.Click
        FrmBienvenida.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmDificultad.Show()
        Hide()
    End Sub
End Class
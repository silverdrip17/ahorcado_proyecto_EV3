Public Class FrmDificultad
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmBienvenida.Show()
        Hide()
    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        FrmJuego.Show()
        Hide()
    End Sub
End Class
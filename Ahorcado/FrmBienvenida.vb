Public Class FrmBienvenida

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        'FrmDificultad.Show()
        FrmJuego.Show()
        Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
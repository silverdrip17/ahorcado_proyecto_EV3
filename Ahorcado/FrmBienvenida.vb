Public Class FrmBienvenida
    Private Sub FrmBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        FrmDificultad.Show()
        Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
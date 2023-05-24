Imports BibliotecaDeClases

Public Class FrmDificultad
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmBienvenida.Show()
        Hide()
    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        listaPalabras = New ListaPalabras("Normal")
        FrmJuego.Show()
        Hide()
    End Sub

    Private Sub btnFacil_Click(sender As Object, e As EventArgs) Handles btnFacil.Click
        listaPalabras = New ListaPalabras("Fácil")
        FrmJuego.Show()
        Hide()
    End Sub
End Class
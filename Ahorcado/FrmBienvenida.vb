Public Class FrmBienvenida

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        FrmDificultad.Show()
        Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnInstrucciones_Click(sender As Object, e As EventArgs) Handles btnInstrucciones.Click
        FrmInstrucciones.Show()
        Hide()
    End Sub
End Class
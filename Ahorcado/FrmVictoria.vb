Public Class FrmVictoria
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        End
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        FrmJuego.Show()
        Me.Close()
    End Sub

    Private Sub FrmVictoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInicioW_Click(sender As Object, e As EventArgs) Handles btnInicioW.Click
        FrmBienvenida.Show()
        Me.Close()
    End Sub

    Private Sub BtnRanking_Click(sender As Object, e As EventArgs)
        FrmRanking.Show()
        Me.Close()
    End Sub
End Class
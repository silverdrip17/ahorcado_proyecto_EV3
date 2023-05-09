
Public Class FrmgameOver
    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        FrmDificultad.Show()
        Me.Close()
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        End
    End Sub

    Private Sub btnInicioG_Click(sender As Object, e As EventArgs) Handles btnInicioG.Click
        FrmBienvenida.Show()
        Me.Close()
    End Sub


    Private Sub FrmgameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRanking.Text = user.GetFinalRanking
    End Sub
End Class
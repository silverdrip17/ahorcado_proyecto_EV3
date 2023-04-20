
Public Class GameOver
    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        FrmJuego.Show()
        Me.Close()
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub
End Class
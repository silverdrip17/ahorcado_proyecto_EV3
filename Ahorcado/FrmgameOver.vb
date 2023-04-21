
Public Class FrmgameOver
    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        FrmJuego.Show()
        Me.Close()
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub FrmgameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(632, 500)
    End Sub
End Class
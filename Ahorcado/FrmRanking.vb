Public Class FrmRanking
    Private Sub Btninicio_Click(sender As Object, e As EventArgs) Handles Btninicio.Click
        FrmBienvenida.Show()
        Me.Close()
    End Sub

    Private Sub FrmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUsuarios.Items.AddRange(gestor.MostrarUsuarios)
    End Sub
End Class
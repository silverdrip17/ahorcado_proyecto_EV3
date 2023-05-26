Public Class FrmRanking
    Private Sub Btninicio_Click(sender As Object, e As EventArgs) Handles Btninicio.Click
        FrmBienvenida.Show()
        Me.Close()
    End Sub

    Private Sub FrmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim usuarios As String() = gestor.MostrarUsuarios.ToArray
        Dim split As String()
        For Each us In usuarios
            split = us.Split("*")
            LstUsuarios.Items.Add($"{split(0)} {split(1)}")
        Next

    End Sub
End Class
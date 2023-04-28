Public Class FrmAadiralabras
    Private Sub LsbPalabras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsbPalabras.SelectedIndexChanged

    End Sub

    Private Sub BtnListaPalabras_Click(sender As Object, e As EventArgs) Handles BtnListaPalabras.Click
        LsbPalabras.Items.Clear()
        LsbPalabras.Items.AddRange(listaPalabras.Palabras)

    End Sub

    Private Sub BtnAñadirPalabra_Click(sender As Object, e As EventArgs) Handles BtnAñadirPalabra.Click
        My.Computer.FileSystem.WriteAllText("../../Soluciones/soluciones.txt", $" {TxtPalabraAñadir.Text}", True)
        listaPalabras = New BibliotecaDeClases.ListaPalabras
        TxtPalabraAñadir.Text = ""
        TxtPalabraAñadir.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmBienvenida.Show()
        Me.Hide()

    End Sub
End Class
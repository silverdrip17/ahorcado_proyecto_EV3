Public Class FrmAadiralabras
    Private Sub LsbPalabras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsbPalabras.SelectedIndexChanged

    End Sub

    Private Sub BtnListaPalabras_Click(sender As Object, e As EventArgs) Handles BtnListaPalabras.Click
        LsbPalabras.Items.Clear()
        LsbPalabras.Items.AddRange(listaPalabras.Palabras)

    End Sub

    Private Sub BtnAñadirPalabra_Click(sender As Object, e As EventArgs) Handles BtnAñadirPalabra.Click
        If My.Computer.FileSystem.ReadAllText("../../Soluciones/soluciones.txt").Contains(TxtPalabraAñadir.Text) Then
            MessageBox.Show("la palabra introducida ya exixte, no se va a añadir")
        Else
            My.Computer.FileSystem.WriteAllText("../../Soluciones/soluciones.txt", $" {TxtPalabraAñadir.Text}", True)
            listaPalabras = New BibliotecaDeClases.ListaPalabras
        End If
        TxtPalabraAñadir.Text = ""
        TxtPalabraAñadir.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmBienvenida.Show()
        Me.Hide()

    End Sub
End Class
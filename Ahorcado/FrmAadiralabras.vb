Public Class FrmAadiralabras
    Private Sub LsbPalabras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsbPalabras.SelectedIndexChanged

    End Sub

    Private Sub BtnListaPalabras_Click(sender As Object, e As EventArgs) Handles BtnListaPalabras.Click
        LsbPalabras.Items.Clear()
        If Cbodificultad.SelectedItem.ToString.Equals("Normal") Then
            listaPalabras = New BibliotecaDeClases.ListaPalabras(True)
            LsbPalabras.Items.AddRange(listaPalabras.Palabras)
        Else
            listaPalabras = New BibliotecaDeClases.ListaPalabras(False)
            LsbPalabras.Items.AddRange(listaPalabras.Palabras)
        End If
    End Sub

    Private Sub BtnAñadirPalabra_Click(sender As Object, e As EventArgs) Handles BtnAñadirPalabra.Click
        Dim palabras As String() = {TxtPalabraAñadir.Text}
        If Cbodificultad.SelectedItem.ToString.Equals("Normal") Then
            If System.IO.File.ReadAllLines("./Soluciones/soluciones.txt").Contains(TxtPalabraAñadir.Text) Then
                MessageBox.Show("la palabra introducida ya exixte, no se va a añadir")
            Else
                System.IO.File.AppendAllLines("./Soluciones/soluciones.txt", palabras)
                listaPalabras = New BibliotecaDeClases.ListaPalabras(True)
            End If
            TxtPalabraAñadir.Text = ""
            TxtPalabraAñadir.Focus()
        Else
            If System.IO.File.ReadAllLines("./Soluciones/TextFile1.txt").Contains(TxtPalabraAñadir.Text) Then
                MessageBox.Show("la palabra introducida ya exixte, no se va a añadir")
            Else
                System.IO.File.AppendAllLines("./Soluciones/TextFile1.txt", palabras)
                listaPalabras = New BibliotecaDeClases.ListaPalabras(True)
            End If
            TxtPalabraAñadir.Text = ""
            TxtPalabraAñadir.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmBienvenida.Show()
        Me.Hide()

    End Sub


    Private Sub FrmAadiralabras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cbodificultad.Items.Add("Facil")
        Cbodificultad.Items.Add("Normal")
    End Sub

    Private Sub FrmAadiralabras_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmBienvenida.Show()
    End Sub

    Private Sub Cbodificultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbodificultad.SelectedIndexChanged

    End Sub
End Class
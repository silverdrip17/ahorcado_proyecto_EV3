Public Class FrmAadiralabras

    Private CategoriaPalabras() As String = {}
    Private categoriaPal() As String = {}
    Private auxSplitFacil() As String = {}
    Private auxSplit() As String = {}
    Private categorias As New List(Of String())

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
        If Cbodificultad.Text = Nothing Then
            MessageBox.Show("Seleccione dificultad")
        Else

            'Else
            '    If Cbodificultad.SelectedItem.ToString.Equals("Normal") Then
            '        If System.IO.File.ReadAllLines("./Soluciones/soluciones.txt").Contains(TxtPalabraAñadir.Text) Then
            '            MessageBox.Show("la palabra introducida ya exixte, no se va a añadir")
            '        Else
            '            If palabras.Contains("") Then
            '                MessageBox.Show("No puedes dejar la palabra en blanco")
            '            Else
            '                System.IO.File.AppendAllLines("./Soluciones/soluciones.txt", palabras)
            '                listaPalabras = New BibliotecaDeClases.ListaPalabras(True)
            '            End If
            '        End If
            '        TxtPalabraAñadir.Text = ""
            '        TxtPalabraAñadir.Focus()
            '    Else
            '        If System.IO.File.ReadAllLines("./Soluciones/TextFile1.txt").Contains(TxtPalabraAñadir.Text) Then
            '            MessageBox.Show("la palabra introducida ya exixte, no se va a añadir")
            '        Else
            '            If palabras.Contains("") Then
            '                MessageBox.Show("No puedes dejar la palabra en blanco")
            '            Else
            '                System.IO.File.AppendAllLines("./Soluciones/TextFile1.txt", palabras)
            '                listaPalabras = New BibliotecaDeClases.ListaPalabras(True)
            '            End If
            '            TxtPalabraAñadir.Text = ""
            '            TxtPalabraAñadir.Focus()
            '        End If
            '    End If
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
        If Cbodificultad.SelectedItem.Equals("Normal") Then
            auxSplit = System.IO.File.ReadAllLines("./Soluciones/soluciones.txt")
            For i = 0 To auxSplit.Length - 1
                CategoriaPalabras = auxSplit(i).Split("*")
                For j = 0 To CategoriaPalabras.Length - 1
                    categorias.AddRange(CategoriaPalabras(1).ToArray)
                Next
            Next
            Cbocategorias.Items.AddRange(categorias.ToArray)
        Else
            auxSplitFacil = System.IO.File.ReadAllLines("./Soluciones/TextFile1.txt")
            For i = 0 To auxSplitFacil.Length - 1
                categoriaPal = auxSplitFacil(i).Split("*")
                For j = 0 To categoriaPal.Length - 1
                    Cbocategorias.Items.Add(categoriaPal(1))
                Next
            Next
        End If
    End Sub

    Private Sub Cbocategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbocategorias.SelectedIndexChanged

    End Sub
End Class
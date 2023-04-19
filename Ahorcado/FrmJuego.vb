Imports BibliotecaDeClases

Public Class FrmJuego
    Private aToComplete As Char()
    Private aLetters As Char()
    Dim fallos As Integer = 0
    'Dim x As Integer = 100
    Dim palabraActual As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        palabraActual = setWord()
    End Sub


    Private Sub Btninicio_Click(sender As Object, e As EventArgs) Handles Btninicio.Click
        FrmBienvenida.Show()
        Me.Close()
    End Sub
    Private Function SetWord() As String
        Dim aPalabras As String() = New String(4) {"elocuente", "rojo", "silbar", "tecnologia", "asincrono"}
        LblPalabras.Text = ""
        Dim random As Random = New Random()
        Dim value As Integer = random.Next(aPalabras.Length)
        Dim aLength As Integer = aPalabras(value).Length
        aToComplete = New Char(aLength - 1) {}

        For i As Integer = 0 To aLength - 1
            LblPalabras.Text += " _ "
            aToComplete(i) = "_"c
        Next

        Return aPalabras(value)
    End Function
    Private Function CheckWord(letter As Char) As Boolean
        Dim result As Boolean = False
        aLetters = palabraActual.ToCharArray()
        Dim cont As Integer = 0
        Dim word As String = ""

        For Each character As Char In aLetters

            If character = letter Then
                aToComplete(cont) = letter
                result = True
                word += aToComplete(cont).ToString()
            Else

                If aToComplete(cont) = "_"c Then
                    word += " _ "
                Else
                    word += aToComplete(cont).ToString()
                End If
            End If

            cont += 1
        Next
        LblPalabras.Text = word
        If word.Equals(palabraActual) Then
            MessageBox.Show("Ganaste")
        End If
        Return result
    End Function

    Private Sub Btnletras(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        Dim boton As Button = TryCast(sender, Button)

        If boton.Text.Trim().Length = 1 Then
            Dim letter As Char = Char.Parse(boton.Text.ToLower())

            If checkWord(letter) Then
                LblletrasFalladas.Text = "La letra " & letter & " es parte de la palabra"
                LblletrasFalladas.BackColor = Color.Green
                boton.Enabled = False
            Else
                LblletrasFalladas.Text = $"Buen intento, pero no , te quedan {5 - fallos} intentos!"
                LblletrasFalladas.BackColor = Color.Red
                boton.Hide()
                fallos += 1

                Select Case fallos
                    Case 1
                        imgAhorcado.Image = My.Resources.el_ahorcado1
                        LblletrasFalladas.Visible = True
                        imgAhorcado.Visible = True
                        LblletrasFalladas.ForeColor = Color.Black

                    Case 2
                        imgAhorcado.Image = My.Resources.el_ahorcado2

                    Case 3
                        imgAhorcado.Image = My.Resources.el_ahorcado3

                    Case 4
                        imgAhorcado.Image = My.Resources.el_ahorcado4

                    Case 5
                        imgAhorcado.Image = My.Resources.el_ahorcado5

                    Case 6
                        imgAhorcado.Image = My.Resources.el_ahorcado6

                        MessageBox.Show("Has perdido...")
                End Select
            End If
        End If
    End Sub
End Class

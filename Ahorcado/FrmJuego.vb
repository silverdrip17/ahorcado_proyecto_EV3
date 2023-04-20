Imports BibliotecaDeClases

Public Class FrmJuego
    Dim fallos As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        palabra.palabraActual = palabra.SetWord()
        LblPalabras.Text = palabra.aToComplete

    End Sub


    Private Sub Btninicio_Click(sender As Object, e As EventArgs) Handles Btninicio.Click
        FrmBienvenida.Show()
        Me.Close()
    End Sub



    Private Sub Btnletras(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        Dim boton As Button = TryCast(sender, Button)

        If boton.Text.Trim().Length = 1 Then
            Dim letter As Char = Char.Parse(boton.Text.ToLower())

            If palabra.CheckWord(letter) Then
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

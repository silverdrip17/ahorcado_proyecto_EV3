Imports BibliotecaDeClases

Public Class FrmJuego
    Dim fallos As Integer = 0
    Dim sustitucionCaracteres As Char()
    Dim aLetters As Char()
    Public Property palabraActual As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LblletrasFalladas.Visible = True
        'imgAhorcado.Visible = True


        palabraActual = SetWord()
        lblTimer.Text = 60
        tmrTiempo.Enabled = True
    End Sub
    Public Function SetWord() As String
        Dim palabraTmp As String = listaPalabras.PalabraAAdivinar
        Dim aLength As Integer = palabraTmp.Length
        sustitucionCaracteres = New Char(aLength - 1) {}
        LblPalabras.Text = ""
        For i As Integer = 0 To aLength - 1
            LblPalabras.Text += " _ "
            sustitucionCaracteres(i) = "_"
        Next

        Return palabraTmp
    End Function

    Public Function CheckWord(letter As Char) As Boolean
        Dim result As Boolean = False
        aLetters = palabraActual.ToCharArray()
        Dim cont As Integer = 0
        Dim word As String = ""

        For Each character As Char In aLetters

            If character = letter Then
                sustitucionCaracteres(cont) = letter
                result = True
                word += sustitucionCaracteres(cont).ToString()
            Else

                If sustitucionCaracteres(cont) = "_" Then
                    word += " _ "
                Else
                    word += sustitucionCaracteres(cont).ToString()
                End If
            End If

            cont += 1
        Next
        LblPalabras.Text = word
        If word.Equals(palabraActual) Then
            tmrTiempo.Enabled = False
            ranking.Rondas += 1
            ranking.TiempoRespuesta += (60 - lblTimer.Text)
            FrmVictoria.Show()
            Me.Close()
        End If
        Return result
    End Function

    Private Sub Btninicio_Click(sender As Object, e As EventArgs) Handles Btninicio.Click
        tmrTiempo.Stop()
        Dim result As Integer = MessageBox.Show("¿Seguro quieres abandonar la partida?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            FrmBienvenida.Show()
            Me.Close()
        ElseIf result = DialogResult.No Then
            tmrTiempo.Start()
            Exit Sub
        End If
    End Sub



    Private Sub Btnletras(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        Dim boton As Button = TryCast(sender, Button)

        If boton.Text.Trim().Length = 1 Then
            Dim letter As Char = Char.Parse(boton.Text.ToLower())

            If CheckWord(letter) Then
                LblletrasFalladas.Text = "La letra " & letter & " es parte de la palabra"
                LblletrasFalladas.BackColor = Color.Green
                boton.Enabled = False
            Else
                LblletrasFalladas.Text = $"Buen intento, pero no , te quedan {5 - fallos} intentos!"
                LblletrasFalladas.BackColor = Color.Red
                boton.Hide()
                fallos += 1

                'cambiar imagenes

                Select Case fallos
                    Case 1
                        imgAhorcado.Image = My.Resources.el_ahorcado1


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

                End Select

                If fallos = 6 Then
                    ranking.TiempoRespuesta += (60 - lblTimer.Text)
                    FrmgameOver.Show()
                    Me.Close()
                End If

            End If
        End If
    End Sub

    Private Sub LblletrasFalladas_Click(sender As Object, e As EventArgs) Handles LblletrasFalladas.Click

    End Sub

    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick
        lblTimer.Text = Val(lblTimer.Text) - 1
        If lblTimer.Text = 0 Then
            tmrTiempo.Enabled = False
            Me.Close()
            FrmgameOver.Show()
        End If
    End Sub
End Class

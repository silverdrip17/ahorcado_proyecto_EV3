﻿Imports BibliotecaDeClases

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
        Me.Hide()
    End Sub
    Private Function setWord() As String
        Dim aWords As String() = New String(4) {"elocuente", "rojo", "silbar", "tecnologia", "asincrono"}
        LblPalabras.Text = ""
        Dim random As Random = New Random()
        Dim value As Integer = random.[Next](aWords.Length)
        Dim aLength As Integer = aWords(value).Length
        aToComplete = New Char(aLength - 1) {}

        For i As Integer = 0 To aLength - 1
            LblPalabras.Text += " _ "
            aToComplete(i) = "_"c
        Next

        Return aWords(value)
    End Function
    Private Function checkWord(ByVal letter As Char) As Boolean
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
                LblletrasFalladas.Text = $"Buen intento, pero no , te quedan {6 - fallos} intentos!"
                LblletrasFalladas.BackColor = Color.Red
                boton.Hide()
                fallos += 1

                Select Case fallos
                    Case 1
                        LblletrasFalladas.Visible = True
                        'LblletrasFalladas.Text = "Intentos: "
                        imgAhorcado.Visible = True
                        LblletrasFalladas.ForeColor = Color.Black
                        'showWrongLetter()
                    Case 2
                        'Dim imagePath As String = Path.Combine(Application.StartupPath, "../../../img/2.png")
                        'imgAhorcado.Image = Image.FromFile(imagePath)
                        'showWrongLetter()
                    Case 3
                        'imagePath = Path.Combine(Application.StartupPath, "../../../img/3.png")
                        'imgAhorcado.Image = Image.FromFile(imagePath)
                        'showWrongLetter()
                    Case 4
                        'imagePath = Path.Combine(Application.StartupPath, "../../../img/4.png")
                        'imgAhorcado.Image = Image.FromFile(imagePath)
                        'showWrongLetter()
                    Case 5
                        'imagePath = Path.Combine(Application.StartupPath, "../../../img/5.png")
                        'imgAhorcado.Image = Image.FromFile(imagePath)
                        'showWrongLetter()
                    Case 6
                        'imagePath = Path.Combine(Application.StartupPath, "../../../img/6.png")
                        'imgAhorcado.Image = Image.FromFile(imagePath)
                        'showWrongLetter()
                        'lblNotificacion.Text = "GAME OVER :/"
                        'lblNotificacion.BackColor = Color.Red
                        'txtLetra.Visible = False
                        'btnJugar.Visible = False
                    Case Else
                        MessageBox.Show("holaaaaaaa")
                End Select
            End If
        End If
    End Sub
End Class

Imports BibliotecaDeClases

Public Class Form1
    Dim x As Integer = 98
    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        'Dim boton As Button = TryCast(sender, Button)

        'Dim lblLetra As New Label
        'lblLetra.Text = boton.Text
        'lblLetra.Size = New Size(20, 30)
        'lblLetra.Location = New Point(98, 97)
        'If palabraAAdivinar.Palabra.ToLower.Contains(boton.Text.ToLower) Then
        '    boton.Hide()
        '    Me.Controls.Add(lblLetra)
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For i = 0 To palabraAAdivinar.Tamano - 1
            Dim lblHuecoLetra As New Label
            lblHuecoLetra.Name = "txtCaja"
            lblHuecoLetra.Text = "-"
            lblHuecoLetra.Size = New Size(20, 20)
            lblHuecoLetra.Location = New Point(x, 97)
            Me.Controls.Add(lblHuecoLetra)
            x += lblHuecoLetra.Width + 10
        Next

    End Sub

    Private Sub Lblintentos_Click(sender As Object, e As EventArgs) Handles Lblintentos.Click

    End Sub
End Class

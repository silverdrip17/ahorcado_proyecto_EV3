Imports BibliotecaDeClases

Public Class FrmBienvenida

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click

        'TODO preguntar si hay usuario o no

        Dim miControl As Control() = Me.Controls.Find("txtNombreUsuario", True)

        If miControl.Length = 0 Then
            Dim txtCaja As New TextBox
            txtCaja.Name = "txtNombreUsuario"
            txtCaja.Size = New Size(100, 10)
            txtCaja.Location = New Point(30, 50)
            Me.Controls.Add(txtCaja)
        Else

            If miControl(0).Text <> "" Then
                gestor.CrearUsuario()
                gestor.User.Usuario = (miControl(0).Text)
                miControl(0).Text = ""
                FrmDificultad.Show()
                Hide()
            End If

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnInstrucciones_Click(sender As Object, e As EventArgs) Handles btnInstrucciones.Click
        'FrmInstrucciones.Show()
        'Hide()
        Dim instrucciones As String
        instrucciones = "El programa propondrá aleatoriamente una palabra " & vbCrLf & "A continuación, el jugador introducira letras" & vbCrLf & "para intentar adivinar la palabra" & vbCrLf & "El juego termina cuando se acierta la palabra (gana el jugador)" & vbCrLf & "o cuando se introduzcan 6 letras erroneas(pierde el jugador)" & vbCrLf & "o cuando el temorizador llegue a 0 (pierde el jugador)"
        MessageBox.Show(instrucciones, "Instrucciones:", MessageBoxButtons.OK)
    End Sub

    Private Sub BtnLoginAdmin_Click(sender As Object, e As EventArgs) Handles BtnLoginAdmin.Click
        FrmLoginAdmin.Show()
        Hide()
    End Sub
End Class
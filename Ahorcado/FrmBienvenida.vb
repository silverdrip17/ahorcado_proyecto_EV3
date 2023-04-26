Public Class FrmBienvenida
    Dim contadorPulsados As Integer

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click

        'TODO preguntar si hay usuario o no
        contadorPulsados += 1



        If contadorPulsados = 1 Then
            Dim txtCaja As New TextBox
            txtCaja.Name = "txtNombreUsuario"
            txtCaja.Size = New Size(100, 10)
            txtCaja.Location = New Point(30, 50)
            Me.Controls.Add(txtCaja)
        Else
            Dim miControl As Control() = Me.Controls.Find("txtNombreUsuario", True)
            If miControl(0).Text <> "" Then
                ranking.Usuarios.Add(miControl(0).Text)
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
        FrmInstrucciones.Show()
        Hide()
    End Sub


End Class
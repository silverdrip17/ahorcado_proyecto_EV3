Public Class FrmLoginAdmin
    Private Sub ChbmostrarContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles ChbmostrarContraseña.CheckedChanged
        If ChbmostrarContraseña.Checked = True Then
            Txtcontraseña.UseSystemPasswordChar = False
        Else
            Txtcontraseña.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If Txtusuario.Text = "admin" And Txtcontraseña.Text = "1234" Then
            Me.Hide()
            FrmAadiralabras.Show()
        Else
            MsgBox("Usuario o contraseña incorrecta")
            Txtusuario.Clear() 'limpia el usuario
            Txtcontraseña.Clear() 'limpias la contraseña
            Txtusuario.Focus() 'comienze a escribir desde el usuario
        End If

    End Sub


    Private Sub FrmLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtcontraseña.UseSystemPasswordChar = True
    End Sub
End Class
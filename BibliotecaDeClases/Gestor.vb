Public Class Gestor
    Public Property User As User
    Public MostrarUsuarios As String() = System.IO.File.ReadAllLines("./Soluciones/Usarios.txt")
    Public Sub CrearUsuario()
        user = New User
    End Sub
    Public Sub GuardarUsuarioYPuntuacion()

        Dim usuarioCompleto As String = $"{User.Usuario}*{User.Puntucion}"
        Dim existeUsuario As Boolean = False
        Dim arrayUsuariosYPuntos As String() = System.IO.File.ReadAllLines("./Soluciones/Usarios.txt")
        Dim listaAUsuarios As List(Of String) = arrayUsuariosYPuntos.ToList
        For i = 0 To arrayUsuariosYPuntos.Length - 1
            Dim listaUsuarios = arrayUsuariosYPuntos(i).Split("*")
            For j = 0 To listaUsuarios.Length - 1
                If User.Usuario = listaUsuarios(0) Then
                    existeUsuario = True
                    Exit For
                End If
            Next
            If existeUsuario Then
                listaAUsuarios.RemoveAt(i)
                listaAUsuarios.Add(usuarioCompleto)
                System.IO.File.WriteAllLines("./Soluciones/Usarios.txt", listaAUsuarios)
                Exit For
            End If
        Next
        If Not existeUsuario Then
            Dim miArray() As String = {usuarioCompleto}
            System.IO.File.AppendAllLines($"./Soluciones/Usarios.txt", miArray)

        End If








    End Sub


End Class

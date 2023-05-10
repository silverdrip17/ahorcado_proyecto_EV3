Public Class User
    Public Property TiempoRespuesta As Integer
    Public Property Usuario As String
    Public Property Rondas As Integer
    Private  puntucion As Integer

    Public Function GetFinalRanking() As String
        Return $"···Ranking···
                Usuario : {Usuario} --> {Rondas} rondas en {TiempoRespuesta} segundos."
    End Function
    Public Sub GuardarUsuario()
        puntucion = Rondas * 100 - TiempoRespuesta

        Dim usuarioCompleto As String() = {$"{_Usuario}*{puntucion}"}


        System.IO.File.AppendAllLines($"./Soluciones/Usarios.txt", usuarioCompleto)



    End Sub
End Class

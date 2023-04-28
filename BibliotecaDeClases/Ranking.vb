Public Class Ranking
    Public Property TiempoRespuesta As Integer
    Public Property Usuario As String
    Public Property Rondas As Integer
    Public Function GetFinalRanking() As String
        Return $"···Ranking···
                Usuario : {Usuario} --> {Rondas} rondas en {TiempoRespuesta} segundos."
    End Function
End Class

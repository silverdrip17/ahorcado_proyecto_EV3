Public Class User
    Public Property TiempoRespuesta As Integer
    Public Property Usuario As String
    Public Property Rondas As Integer
    Public ReadOnly Property Puntucion As Integer = Rondas * 100 - TiempoRespuesta



End Class

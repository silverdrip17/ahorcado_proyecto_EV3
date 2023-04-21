Public Class ListaPalabras


    Private aPalabras As String() = {}
    Private posicionTmp As Integer = -1


    Public Sub New()
        Dim fileReader As String
        ' todo ¿Qué ocurre si no existe el fichero soluciones.txt?
        fileReader = My.Computer.FileSystem.ReadAllText("../../Soluciones/soluciones.txt")
        Me.aPalabras = fileReader.Split(" ")
    End Sub
    Private ReadOnly Property Palabras() As String()
        Get
            Return aPalabras
        End Get
    End Property

    Public Function palabraAAdivinar() As String
        Dim listaPalabras As String() = Palabras()
        Dim random As Random = New Random()
        Dim value As Integer
        Dim longitudPalabra As String
        If posicionTmp = -1 Then
            value = random.Next(listaPalabras.Length)
            longitudPalabra = listaPalabras(value)
            posicionTmp = value
        Else
            Do
                value = random.Next(listaPalabras.Length)
                longitudPalabra = listaPalabras(value)
                If posicionTmp <> value Then
                    Return longitudPalabra
                End If
                posicionTmp = value
            Loop
        End If

        Return longitudPalabra
    End Function



End Class

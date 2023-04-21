Public Class ListaPalabras


    Private aPalabras As String() = {}



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
        Dim value As Integer = random.Next(listaPalabras.Length)
        Dim longitudPalabra As String = listaPalabras(value)
        Return longitudPalabra
    End Function



End Class

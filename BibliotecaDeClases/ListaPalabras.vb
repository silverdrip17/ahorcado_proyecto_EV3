Public Class ListaPalabras

    Private fileReader As String
    Private Property APalabras As String() = {}

    Public Sub New()
        Me.fileReader = My.Computer.FileSystem.ReadAllText("../../Soluciones/soluciones.txt")
        Me.APalabras = fileReader.Split(" ")
    End Sub
    Public Function getArrayPalabras() As String()
        Return aPalabras
    End Function



End Class

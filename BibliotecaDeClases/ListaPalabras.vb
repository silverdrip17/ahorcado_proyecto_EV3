Public Class ListaPalabras


    Private aPalabras As String() = {}
    Private posicionTmp As Integer = -1
    Public Property HayArchivo As Boolean = True


    Public Sub New()
        Dim fileReader As String
        ' todo ¿Qué ocurre si no existe el fichero soluciones.txt?
        If System.IO.File.Exists("../../Soluciones/soluciones.txt") Then
            fileReader = My.Computer.FileSystem.ReadAllText("../../Soluciones/soluciones.txt")
            Me.aPalabras = fileReader.Split(" ")
        Else
            HayArchivo = False
            aPalabras = {"abecedario", "insti", "cinco", "año"}
        End If

    End Sub
    Private ReadOnly Property Palabras() As String()
        Get
            Return aPalabras
        End Get
    End Property

    Public Function PalabraAAdivinar() As String
        Dim listaPalabras As String() = Palabras()
        Dim random As Random = New Random()
        Dim value As Integer
        Dim palabraAleatoria As String
        If posicionTmp = -1 Then
            value = random.Next(listaPalabras.Length)
            palabraAleatoria = listaPalabras(value)
            posicionTmp = value
        Else
            Do
                value = random.Next(listaPalabras.Length)
                palabraAleatoria = listaPalabras(value)

                If posicionTmp <> value Then
                    posicionTmp = value
                    Return palabraAleatoria
                End If

            Loop
        End If

        Return palabraAleatoria
    End Function



End Class

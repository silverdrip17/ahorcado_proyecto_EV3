Public Class ListaPalabras


    Private aPalabras As String() = {}
    Private posicionTmp As Integer = -1



    Public Sub New()
        ' todo ¿Qué ocurre si no existe el fichero soluciones.txt?
        If System.IO.File.Exists("../../Soluciones/soluciones.txt") Then
            aPalabras = System.IO.File.ReadAllLines("../../Soluciones/soluciones.txt")
        Else
            aPalabras = {"abecedario", "insti", "cinco", "año"}
            System.IO.File.WriteAllLines("../../Soluciones/", aPalabras)

        End If

    End Sub
    Public ReadOnly Property Palabras() As String()
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

            Loop While posicionTmp = value
        End If

        Return palabraAleatoria
    End Function



End Class

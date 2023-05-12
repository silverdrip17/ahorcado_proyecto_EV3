Public Class ListaPalabras


    Private PalabrasDeFichero As String() = {}
    Private posicionTmp As Integer = -1 ' todo Array o lista con posiciones de palabras que ya han salido
    Private spliteado As String() = {}



    Public Sub New(dificultad As Boolean)
        ' todo ¿Qué ocurre si no existe el fichero soluciones.txt?
        If dificultad Then
            If System.IO.File.Exists("./Soluciones/soluciones.txt") Then
                PalabrasDeFichero = System.IO.File.ReadAllLines("./Soluciones/soluciones.txt")
                spliteado = PalabrasDeFichero(0).Split("*")
            Else
                PalabrasDeFichero = {"abecedario", "insti", "cinco", "año"}
                System.IO.File.WriteAllLines("./Soluciones/soluciones.txt", PalabrasDeFichero)

            End If
        Else
            If System.IO.File.Exists("./Soluciones/TextFile1.txt") Then
                PalabrasDeFichero = System.IO.File.ReadAllLines("./Soluciones/TextFile1.txt")
                spliteado = PalabrasDeFichero(0).Split("*")
            Else
                PalabrasDeFichero = {"abecedario", "insti", "cinco", "año"}
                System.IO.File.WriteAllLines("./Soluciones/TextFile1.txt", PalabrasDeFichero)

            End If
        End If

    End Sub
    Public ReadOnly Property Palabras() As String()
        Get
            Return spliteado
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
                value = random.Next(listaPalabras.Length)  ' todo No puede estar en array/listas de posiciones que ya han salido
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

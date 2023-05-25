Public Class ListaPalabras


    Private PalabrasDeFichero As String() = {}
    'Private posicionTmp As Integer = -1 ' todo Array o lista con posiciones de palabras que ya han salido
    Private posicionTmp As New List(Of String)
    Private spliteado As New List(Of String)
    Private arrayPalabras As New List(Of PalabraCategoria)



    Public Sub New(dificultad As String)
        ' todo ¿Qué ocurre si no existe el fichero soluciones.txt?
        Dim fichero As String
        If dificultad = "Normal" Then
            fichero = "./Soluciones/soluciones.txt"
        Else
            fichero = "./Soluciones/TextFile1.txt"
        End If

        If System.IO.File.Exists(fichero) Then
            PalabrasDeFichero = System.IO.File.ReadAllLines(fichero)
            For i = 0 To PalabrasDeFichero.Length - 1


                Dim palabras As String() = PalabrasDeFichero(i).Split("*")


                Dim palabraAux As New PalabraCategoria(palabras(0), palabras(1), "Normal")

                arrayPalabras.Add(palabraAux)



            Next
        Else ' todo Si no existe fichero arrayPalabras vacío???
            PalabrasDeFichero = {"abecedario", "insti", "cinco", "año"}
            arrayPalabras.AddRange(PalabrasDeFichero)
            System.IO.File.WriteAllLines("./Soluciones/soluciones.txt", PalabrasDeFichero)

        End If







    End Sub
main
    Public Function getArrayPalabras() As String()
        Return APalabras
=======
    Public ReadOnly Property Palabras() As List(Of PalabraCategoria)
        Get
            Return arrayPalabras
        End Get
    End Property

    Public Function PalabraAAdivinar() As PalabraCategoria
        Dim listaPalabras As List(Of PalabraCategoria) = Palabras()
        Dim random As Random = New Random(TimeOfDay.Second)
        Dim value As Integer
        Dim palabraAleatoria As PalabraCategoria
        Dim palabrasUsadas As New List(Of PalabraCategoria)
        If palabrasUsadas.ToArray.Length = 0 Then

            value = random.Next(listaPalabras.ToArray.Length)
            palabraAleatoria = listaPalabras.Item(value)
            palabrasUsadas.Add(palabraAleatoria)
        Else
            Do
                value = random.Next(listaPalabras.ToArray.Length)
                palabraAleatoria = listaPalabras.Item(value)

                If Not palabrasUsadas.Contains(palabraAleatoria) Then
                    palabrasUsadas.Add(palabraAleatoria)
                    Return palabraAleatoria
                End If

            Loop While palabrasUsadas.Contains(palabraAleatoria)
        End If

        Return palabraAleatoria
development
    End Function





    Public Function AnadirPalabra(palabraAAnadirStr As String, categoria As String, dificultad As String) As String

        Dim Palabra As New PalabraCategoria(palabraAAnadirStr, categoria, dificultad)
        Dim fichero As String
        If dificultad = "Normal" Then
            fichero = "./Soluciones/soluciones.txt"
        Else
            fichero = "./Soluciones/TextFile1.txt"
        End If

        If arrayPalabras.Contains(Palabra) Then
            Return $"La palabra {Palabra.Palabra} ya existe"
        Else
            Dim palabraFichero As String() = {$"{Palabra.Palabra}*{Palabra.Categoria}"}
            System.IO.File.AppendAllLines(fichero, palabraFichero)
            Return ""
        End If


    End Function

End Class

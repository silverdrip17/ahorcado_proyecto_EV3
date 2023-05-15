Public Class ListaPalabras


    Private PalabrasDeFichero As String() = {}
    'Private posicionTmp As Integer = -1 ' todo Array o lista con posiciones de palabras que ya han salido
    Private posicionTmp As New List(Of String)
    Private spliteado As New List(Of String)
    Private arrayPalabras As List(Of PalabraCategoria)


    Public Sub New(dificultad As Boolean)
        ' todo ¿Qué ocurre si no existe el fichero soluciones.txt?
        If dificultad Then
            If System.IO.File.Exists("./Soluciones/soluciones.txt") Then
                PalabrasDeFichero = System.IO.File.ReadAllLines("./Soluciones/soluciones.txt")
                For i = 0 To PalabrasDeFichero.Length - 1

                    spliteado.AddRange(PalabrasDeFichero(i).Split("*"))
                Next
                Dim cont As Integer = 0
                Dim palabraAux As New PalabraCategoria
                For i = 0 To PalabrasDeFichero.Length - 1
                    arrayPalabras.Add(palabraAux)
                    arrayPalabras(i).Palabra = (spliteado(cont).ToString)

                    cont += 2
                Next
            Else
                PalabrasDeFichero = {"abecedario", "insti", "cinco", "año"}
                System.IO.File.WriteAllLines("./Soluciones/soluciones.txt", PalabrasDeFichero)

            End If
        Else
            If System.IO.File.Exists("./Soluciones/TextFile1.txt") Then
                PalabrasDeFichero = System.IO.File.ReadAllLines("./Soluciones/TextFile1.txt")
                For i = 0 To PalabrasDeFichero.Length - 1

                    spliteado.AddRange(PalabrasDeFichero(i).Split("*"))
                Next
                Dim cont As Integer = 0
                For i = 0 To PalabrasDeFichero.Length - 1 Step 2
                    Array.Resize(arrayPalabras, arrayPalabras.Length + 1)
                    arrayPalabras(cont) = spliteado(i)
                    cont += 1
                Next
            Else
                PalabrasDeFichero = {"abecedario", "insti", "cinco", "año"}
                System.IO.File.WriteAllLines("./Soluciones/TextFile1.txt", PalabrasDeFichero)

            End If
        End If

    End Sub
    Public ReadOnly Property Palabras() As String()
        Get
            Return arrayPalabras
        End Get
    End Property

    Public Function PalabraAAdivinar() As String
        Dim listaPalabras As String() = Palabras()
        Dim random As Random = New Random()
        Dim value As Integer
        Dim palabraAleatoria As String
        If posicionTmp.ToArray.Length = 0 Then
            value = random.Next(listaPalabras.Length)
            palabraAleatoria = listaPalabras(value)
            posicionTmp.Add(palabraAleatoria)
        Else
            Do
                value = random.Next(listaPalabras.Length)  ' todo No puede estar en array/listas de posiciones que ya han salido
                palabraAleatoria = listaPalabras(value)

                If Not posicionTmp.Contains(palabraAleatoria) Then
                    posicionTmp.Add(palabraAleatoria)
                    Return palabraAleatoria
                End If

            Loop While posicionTmp.Contains(palabraAleatoria)
        End If

        Return palabraAleatoria
    End Function



    Public Function AnadirPalabra(palabras As String(), palabra As String, dificultad As Boolean) As String

        If dificultad Then

            If System.IO.File.ReadAllLines("./Soluciones/soluciones.txt").Contains(palabra) Then
                Return ("la palabra introducida ya exixte, no se va a añadir")
            Else
                If palabra = ("") Then
                    Return ("No puedes dejar la palabra en blanco")
                Else
                    System.IO.File.AppendAllLines("./Soluciones/soluciones.txt", palabras)
                    Return ""
                End If
            End If
        Else
            If System.IO.File.ReadAllLines("./Soluciones/TextFile1.txt").Contains(palabra) Then
                Return ("la palabra introducida ya exixte, no se va a añadir")
            Else
                If palabra = ("") Then
                    Return ("No puedes dejar la palabra en blanco")
                Else
                    System.IO.File.AppendAllLines("./Soluciones/TextFile1.txt", palabras)
                    Return ""
                End If


            End If
        End If
    End Function



End Class

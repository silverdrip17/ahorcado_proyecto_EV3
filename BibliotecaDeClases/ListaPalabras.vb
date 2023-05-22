﻿Public Class ListaPalabras


    Private PalabrasDeFichero As String() = {}
    'Private posicionTmp As Integer = -1 ' todo Array o lista con posiciones de palabras que ya han salido
    Private posicionTmp As New List(Of String)
    Private spliteado As New List(Of String)
    Private arrayPalabras As New List(Of PalabraCategoria)



    Public Sub New(dificultad As Boolean)
        ' todo ¿Qué ocurre si no existe el fichero soluciones.txt?
        If dificultad Then
            If System.IO.File.Exists("./Soluciones/soluciones.txt") Then
                PalabrasDeFichero = System.IO.File.ReadAllLines("./Soluciones/soluciones.txt")
                For i = 0 To PalabrasDeFichero.Length - 1


                    Dim palabras As String() = PalabrasDeFichero(i).Split("*")


                    Dim palabraAux As New PalabraCategoria(palabras(0), palabras(1), True)

                    arrayPalabras.Add(palabraAux)



                Next
            Else
                PalabrasDeFichero = {"abecedario", "insti", "cinco", "año"}
                System.IO.File.WriteAllLines("./Soluciones/soluciones.txt", PalabrasDeFichero)

            End If
        Else
            If System.IO.File.Exists("./Soluciones/TextFile1.txt") Then
                PalabrasDeFichero = System.IO.File.ReadAllLines("./Soluciones/TextFile1.txt")
                For i = 0 To PalabrasDeFichero.Length - 1


                    Dim palabras As String() = PalabrasDeFichero(i).Split("*")


                    Dim palabraAux As New PalabraCategoria(palabras(0), palabras(1), True)

                    arrayPalabras.Add(palabraAux)



                Next
            Else
                PalabrasDeFichero = {"abecedario", "insti", "cinco", "año"}
                System.IO.File.WriteAllLines("./Soluciones/TextFile1.txt", PalabrasDeFichero)

            End If
        End If

    End Sub
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

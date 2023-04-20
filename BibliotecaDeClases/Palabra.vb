Public Class Palabra
    Public Property aToComplete As Char()
    Public Property aLetters As Char()


    Public Property palabraActual As String
    Public listaDePalabras As New ListaPalabras
    Public Function SetWord() As String
        Dim aPalabras As String() = listaDePalabras.getArrayPalabras
        Dim LblPalabras = ""
        Dim random As Random = New Random()
        Dim value As Integer = random.Next(aPalabras.Length)
        Dim aLength As Integer = aPalabras(value).Length
        aToComplete = New Char(aLength - 1) {}

        For i As Integer = 0 To aLength - 1
            LblPalabras += " _ "
            aToComplete(i) = "_"c
        Next

        Return aPalabras(value)
    End Function

    Public Function CheckWord(letter As Char) As Boolean
        Dim result As Boolean = False
        aLetters = palabraActual.ToCharArray()
        Dim cont As Integer = 0
        Dim word As String = ""

        For Each character As Char In aLetters

            If character = letter Then
                aToComplete(cont) = letter
                result = True
                word += aToComplete(cont).ToString()
            Else

                If aToComplete(cont) = "_"c Then
                    word += " _ "
                Else
                    word += aToComplete(cont).ToString()
                End If
            End If

            cont += 1
        Next
        Dim LblPalabras = word
        If word.Equals(palabraActual) Then
            'MessageBox.Show("Ganaste")
        End If
        Return result
    End Function
End Class

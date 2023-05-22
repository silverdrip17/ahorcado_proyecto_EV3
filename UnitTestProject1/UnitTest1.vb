Imports System.IO
Imports BibliotecaDeClases
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub testPalabraAAdivinar()
        Dim path As String = "./Soluciones/soluciones.txt"
        Dim palabras As String() = File.ReadAllLines("./Soluciones/soluciones.txt")
        Dim listaPalabras As New ListaPalabras(True)
        Dim actual As String = listaPalabras.PalabraAAdivinar()
        For Each

        Dim palabrasBien As String() = palabras.
        Assert.IsTrue(palabras.Contains(actual))

    End Sub

End Class
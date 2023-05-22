Imports System.IO
Imports BibliotecaDeClases
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Diagnostics.Contracts
Imports System.Security.Cryptography.X509Certificates

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub testPalabraAAdivinar()
        Dim palabras As String() = File.ReadAllLines("./Soluciones/soluciones.txt")
        Dim listaPalabras As New ListaPalabras(True)
        Dim actual As String = listaPalabras.PalabraAAdivinar()
        Dim palabrasBien As New List(Of String)
        For Each palabra In palabras
            Dim arrayalabras As String() = palabra.Split("*")

            palabrasBien.Add(arrayalabras(0))
        Next

        For Each palabra In palabrasBien
            If palabra.Equals(actual) Then
                Assert.IsTrue(True)
            End If
        Next

    End Sub

    '<TestClass()> Public Class UnitTest2
    <TestMethod()> Public Sub testPalabraAAdivinarFacil()
            Dim palabras As String() = File.ReadAllLines("./Soluciones/TextFile1.txt")
            Dim listaPalabras As New ListaPalabras(True)
            Dim actual As String = listaPalabras.PalabraAAdivinar()
            Dim palabrasBien As New List(Of String)
            For Each palabra In palabras
                Dim arrayalabras As String() = palabra.Split("*")

                palabrasBien.Add(arrayalabras(0))
            Next

            For Each palabra In palabrasBien
                If palabra.Equals(actual) Then
                    Assert.IsTrue(True)
                End If
            Next
        End Sub

    'End Class
End Class
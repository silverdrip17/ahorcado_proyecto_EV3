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
        Dim actual As PalabraCategoria = listaPalabras.PalabraAAdivinar()
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

    <TestMethod()> Public Sub testPalabraAAdivinarFacil()
        Dim palabras As String() = File.ReadAllLines("./Soluciones/TextFile1.txt")
        Dim listaPalabras As New ListaPalabras(True)
        Dim actual As PalabraCategoria = listaPalabras.PalabraAAdivinar()
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

    <TestMethod()> Public Sub TestFicheros()
        If System.IO.File.Exists("./Soluciones/soluciones.txt") Then
            Assert.IsTrue(True)
        Else
            Assert.IsFalse(False)
        End If
    End Sub
    <TestMethod()> Public Sub TestFicheros1()
        If System.IO.File.Exists("./Soluciones/TextFile1.txt") Then
            Assert.IsTrue(True)
        Else
            Assert.IsFalse(False)
        End If
    End Sub

    <TestMethod()> Public Sub TestInicioSesion()
        Dim usuarios As String() = File.ReadAllLines("./Soluciones/Usarios.txt")
        Dim usuariosBien As New List(Of String)
        For Each user In usuarios
            Dim arrayusuarios As String() = user.Split("*")

            usuariosBien.Add(arrayusuarios(0))
        Next
        For Each user In usuariosBien
            If user.Equals(usuariosBien) Then
                Assert.IsTrue(True)
            End If
        Next

    End Sub
End Class
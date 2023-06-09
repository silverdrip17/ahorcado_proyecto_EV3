﻿Imports BibliotecaDeClases

Public Class FrmAadiralabras
    Dim gestorPalabras As ListaPalabras

    Private Sub FrmAadiralabras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cbocategorias.Items.AddRange({"verbo", "color", "accion", "mueble", "animal", "saludo", "nombre", "naturaleza"})
        Cbodificultad.Items.AddRange({"Fácil", "Normal"})
        TxtPalabraAñadir.Enabled = False
        Cbocategorias.Enabled = False
    End Sub

    Private Sub BtnAñadirPalabra_Click(sender As Object, e As EventArgs) Handles BtnAñadirPalabra.Click
        Dim mensaje As String = gestorPalabras.AnadirPalabra(TxtPalabraAñadir.Text, Cbocategorias.SelectedItem, Cbodificultad.SelectedItem)
        If mensaje <> "" Then

            MessageBox.Show(mensaje)
        End If
        LsbPalabras.Items.Clear()
        LsbPalabras.DisplayMember = "Palabra"
        LsbPalabras.Items.AddRange(gestorPalabras.Palabras.ToArray)
    End Sub

    Private Sub Cbodificultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbodificultad.SelectedIndexChanged
        gestorPalabras = New ListaPalabras(Cbodificultad.SelectedItem)
        LsbPalabras.Items.Clear()
        LsbPalabras.DisplayMember = "Palabra"
        LsbPalabras.Items.AddRange(gestorPalabras.Palabras.ToArray)
        Cbocategorias.Enabled = True
        Cbodificultad.Enabled = False
    End Sub

    Private Sub Cbocategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbocategorias.SelectedIndexChanged
        TxtPalabraAñadir.Enabled = True
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAadiralabras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtPalabraAñadir = New System.Windows.Forms.TextBox()
        Me.LsbPalabras = New System.Windows.Forms.ListBox()
        Me.BtnAñadirPalabra = New System.Windows.Forms.Button()
        Me.BtnListaPalabras = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cbodificultad = New System.Windows.Forms.ComboBox()
        Me.Cbocategorias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtPalabraAñadir
        '
        Me.TxtPalabraAñadir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtPalabraAñadir.Location = New System.Drawing.Point(129, 116)
        Me.TxtPalabraAñadir.Name = "TxtPalabraAñadir"
        Me.TxtPalabraAñadir.Size = New System.Drawing.Size(344, 22)
        Me.TxtPalabraAñadir.TabIndex = 0
        '
        'LsbPalabras
        '
        Me.LsbPalabras.FormattingEnabled = True
        Me.LsbPalabras.ItemHeight = 16
        Me.LsbPalabras.Location = New System.Drawing.Point(521, 131)
        Me.LsbPalabras.Name = "LsbPalabras"
        Me.LsbPalabras.Size = New System.Drawing.Size(231, 132)
        Me.LsbPalabras.TabIndex = 1
        '
        'BtnAñadirPalabra
        '
        Me.BtnAñadirPalabra.Location = New System.Drawing.Point(127, 215)
        Me.BtnAñadirPalabra.Name = "BtnAñadirPalabra"
        Me.BtnAñadirPalabra.Size = New System.Drawing.Size(105, 54)
        Me.BtnAñadirPalabra.TabIndex = 2
        Me.BtnAñadirPalabra.Text = "Añadir palabra"
        Me.BtnAñadirPalabra.UseVisualStyleBackColor = True
        '
        'BtnListaPalabras
        '
        Me.BtnListaPalabras.Location = New System.Drawing.Point(339, 215)
        Me.BtnListaPalabras.Name = "BtnListaPalabras"
        Me.BtnListaPalabras.Size = New System.Drawing.Size(105, 54)
        Me.BtnListaPalabras.TabIndex = 3
        Me.BtnListaPalabras.Text = "lista de palabras"
        Me.BtnListaPalabras.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cbodificultad
        '
        Me.Cbodificultad.FormattingEnabled = True
        Me.Cbodificultad.Location = New System.Drawing.Point(82, 28)
        Me.Cbodificultad.Name = "Cbodificultad"
        Me.Cbodificultad.Size = New System.Drawing.Size(150, 24)
        Me.Cbodificultad.TabIndex = 5
        '
        'Cbocategorias
        '
        Me.Cbocategorias.FormattingEnabled = True
        Me.Cbocategorias.Location = New System.Drawing.Point(529, 83)
        Me.Cbocategorias.Name = "Cbocategorias"
        Me.Cbocategorias.Size = New System.Drawing.Size(222, 24)
        Me.Cbocategorias.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dificultad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Categoria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmAadiralabras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbocategorias)
        Me.Controls.Add(Me.Cbodificultad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnListaPalabras)
        Me.Controls.Add(Me.BtnAñadirPalabra)
        Me.Controls.Add(Me.LsbPalabras)
        Me.Controls.Add(Me.TxtPalabraAñadir)
        Me.Name = "FrmAadiralabras"
        Me.Text = "FrnAadiralabras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPalabraAñadir As TextBox
    Friend WithEvents LsbPalabras As ListBox
    Friend WithEvents BtnAñadirPalabra As Button
    Friend WithEvents BtnListaPalabras As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Cbodificultad As ComboBox
    Friend WithEvents Cbocategorias As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVictoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVictoria))
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.btnInicioW = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnexit
        '
        Me.Btnexit.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(292, 239)
        Me.Btnexit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(84, 37)
        Me.Btnexit.TabIndex = 0
        Me.Btnexit.Text = "Salir "
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnreset
        '
        Me.Btnreset.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreset.Location = New System.Drawing.Point(26, 239)
        Me.Btnreset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(101, 37)
        Me.Btnreset.TabIndex = 1
        Me.Btnreset.Text = "Volver a jugar"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'btnInicioW
        '
        Me.btnInicioW.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioW.Location = New System.Drawing.Point(26, 10)
        Me.btnInicioW.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInicioW.Name = "btnInicioW"
        Me.btnInicioW.Size = New System.Drawing.Size(51, 38)
        Me.btnInicioW.TabIndex = 2
        Me.btnInicioW.Text = "Inicio"
        Me.btnInicioW.UseVisualStyleBackColor = True
        '
        'FrmVictoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(398, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInicioW)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnexit)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmVictoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Victoria"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents btnInicioW As Button
End Class

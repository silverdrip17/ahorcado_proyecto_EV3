<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBienvenida
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
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInstrucciones = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJugar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.Location = New System.Drawing.Point(207, 94)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(145, 44)
        Me.btnJugar.TabIndex = 1
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(207, 239)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(145, 44)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnInstrucciones
        '
        Me.btnInstrucciones.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnInstrucciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstrucciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstrucciones.Location = New System.Drawing.Point(207, 164)
        Me.btnInstrucciones.Name = "btnInstrucciones"
        Me.btnInstrucciones.Size = New System.Drawing.Size(145, 44)
        Me.btnInstrucciones.TabIndex = 3
        Me.btnInstrucciones.Text = "Instrucciones"
        Me.btnInstrucciones.UseVisualStyleBackColor = False
        '
        'FrmBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ahorcado.My.Resources.Resources.ahorcado2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(822, 493)
        Me.Controls.Add(Me.btnInstrucciones)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnJugar)
        Me.Name = "FrmBienvenida"
        Me.Text = "Ahorcado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJugar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnInstrucciones As Button
End Class

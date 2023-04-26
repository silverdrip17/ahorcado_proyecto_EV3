<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBienvenida
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
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInstrucciones = New System.Windows.Forms.Button()
        Me.BtnLoginAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.Location = New System.Drawing.Point(155, 76)
        Me.btnJugar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(109, 36)
        Me.btnJugar.TabIndex = 1
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(155, 234)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(109, 36)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnInstrucciones
        '
        Me.btnInstrucciones.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnInstrucciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstrucciones.Location = New System.Drawing.Point(155, 133)
        Me.btnInstrucciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInstrucciones.Name = "btnInstrucciones"
        Me.btnInstrucciones.Size = New System.Drawing.Size(109, 36)
        Me.btnInstrucciones.TabIndex = 3
        Me.btnInstrucciones.Text = "Instrucciones"
        Me.btnInstrucciones.UseVisualStyleBackColor = False
        '
        'BtnLoginAdmin
        '
        Me.BtnLoginAdmin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginAdmin.Location = New System.Drawing.Point(155, 183)
        Me.BtnLoginAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnLoginAdmin.Name = "BtnLoginAdmin"
        Me.BtnLoginAdmin.Size = New System.Drawing.Size(109, 36)
        Me.BtnLoginAdmin.TabIndex = 4
        Me.BtnLoginAdmin.Text = "Admin"
        Me.BtnLoginAdmin.UseVisualStyleBackColor = False
        '
        'FrmBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ahorcado.My.Resources.Resources.ahorcado2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(616, 401)
        Me.Controls.Add(Me.BtnLoginAdmin)
        Me.Controls.Add(Me.btnInstrucciones)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnJugar)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmBienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ahorcado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJugar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnInstrucciones As Button
    Friend WithEvents BtnLoginAdmin As Button
End Class

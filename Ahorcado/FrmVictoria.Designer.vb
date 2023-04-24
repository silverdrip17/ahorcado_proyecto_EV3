<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVictoria
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
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.btnInicioW = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btnexit
        '
        Me.Btnexit.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(433, 294)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(112, 45)
        Me.Btnexit.TabIndex = 0
        Me.Btnexit.Text = "Salir "
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnreset
        '
        Me.Btnreset.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreset.Location = New System.Drawing.Point(34, 294)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(135, 45)
        Me.Btnreset.TabIndex = 1
        Me.Btnreset.Text = "Volver a jugar"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'btnInicioW
        '
        Me.btnInicioW.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioW.Location = New System.Drawing.Point(34, 12)
        Me.btnInicioW.Name = "btnInicioW"
        Me.btnInicioW.Size = New System.Drawing.Size(68, 47)
        Me.btnInicioW.TabIndex = 2
        Me.btnInicioW.Text = "Inicio"
        Me.btnInicioW.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "¡¡GANASTE!!"
        '
        'FrmVictoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ahorcado.My.Resources.Resources.felizA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInicioW)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnexit)
        Me.DoubleBuffered = True
        Me.Name = "FrmVictoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Victoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents btnInicioW As Button
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmgameOver
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
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.btnInicioG = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.Transparent
        Me.Btnexit.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(436, 301)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(124, 53)
        Me.Btnexit.TabIndex = 0
        Me.Btnexit.Text = "Salir"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.Color.Transparent
        Me.Btnreset.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreset.Location = New System.Drawing.Point(22, 301)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(136, 53)
        Me.Btnreset.TabIndex = 1
        Me.Btnreset.Text = "Reintentar"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'btnInicioG
        '
        Me.btnInicioG.BackColor = System.Drawing.Color.Transparent
        Me.btnInicioG.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioG.Location = New System.Drawing.Point(22, 23)
        Me.btnInicioG.Name = "btnInicioG"
        Me.btnInicioG.Size = New System.Drawing.Size(90, 38)
        Me.btnInicioG.TabIndex = 2
        Me.btnInicioG.Text = "Inicio"
        Me.btnInicioG.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(213, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PERDISTE"
        '
        'FrmgameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ahorcado.My.Resources.Resources.tristeA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInicioG)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnexit)
        Me.DoubleBuffered = True
        Me.Name = "FrmgameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameOver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents btnInicioG As Button
    Friend WithEvents Label1 As Label
End Class

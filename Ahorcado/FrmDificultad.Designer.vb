<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDificultad
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
        Me.btnFacil = New System.Windows.Forms.Button()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFacil
        '
        Me.btnFacil.BackColor = System.Drawing.Color.Lime
        Me.btnFacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacil.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacil.Location = New System.Drawing.Point(213, 107)
        Me.btnFacil.Name = "btnFacil"
        Me.btnFacil.Size = New System.Drawing.Size(136, 44)
        Me.btnFacil.TabIndex = 1
        Me.btnFacil.Text = "Fácil"
        Me.btnFacil.UseVisualStyleBackColor = False
        '
        'btnNormal
        '
        Me.btnNormal.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNormal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNormal.Location = New System.Drawing.Point(213, 172)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(136, 44)
        Me.btnNormal.TabIndex = 2
        Me.btnNormal.Text = "Normal"
        Me.btnNormal.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.AliceBlue
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(213, 241)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(136, 44)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "¡Escoge dificultad!"
        '
        'FrmDificultad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ahorcado.My.Resources.Resources.ahorcado2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnNormal)
        Me.Controls.Add(Me.btnFacil)
        Me.Name = "FrmDificultad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dificultad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFacil As Button
    Friend WithEvents btnNormal As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label1 As Label
End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmgameOver))
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(469, 335)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(160, 75)
        Me.Btnexit.TabIndex = 0
        Me.Btnexit.Text = "EXIT"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnreset
        '
        Me.Btnreset.Location = New System.Drawing.Point(177, 335)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(160, 75)
        Me.Btnreset.TabIndex = 1
        Me.Btnreset.Text = "Jugar de nuevo"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'FrmgameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(702, 453)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnexit)
        Me.Name = "FrmgameOver"
        Me.Text = "GameOver"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnreset As Button
End Class

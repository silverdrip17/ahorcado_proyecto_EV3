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
        Me.btnInicioG = New System.Windows.Forms.Button()
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
        'FrmgameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInicioG)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnexit)
        Me.DoubleBuffered = True
        Me.Name = "FrmgameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameOver"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents btnInicioG As Button
End Class

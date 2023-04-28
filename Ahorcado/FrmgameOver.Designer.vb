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
        Me.lblRanking = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.Transparent
        Me.Btnexit.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(327, 245)
        Me.Btnexit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(93, 43)
        Me.Btnexit.TabIndex = 0
        Me.Btnexit.Text = "Salir"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.Color.Transparent
        Me.Btnreset.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreset.Location = New System.Drawing.Point(16, 245)
        Me.Btnreset.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(102, 43)
        Me.Btnreset.TabIndex = 1
        Me.Btnreset.Text = "Reintentar"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'btnInicioG
        '
        Me.btnInicioG.BackColor = System.Drawing.Color.Transparent
        Me.btnInicioG.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioG.Location = New System.Drawing.Point(16, 19)
        Me.btnInicioG.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInicioG.Name = "btnInicioG"
        Me.btnInicioG.Size = New System.Drawing.Size(68, 31)
        Me.btnInicioG.TabIndex = 2
        Me.btnInicioG.Text = "Inicio"
        Me.btnInicioG.UseVisualStyleBackColor = False
        '
        'lblRanking
        '
        Me.lblRanking.AutoSize = True
        Me.lblRanking.Location = New System.Drawing.Point(178, 50)
        Me.lblRanking.Name = "lblRanking"
        Me.lblRanking.Size = New System.Drawing.Size(39, 13)
        Me.lblRanking.TabIndex = 3
        Me.lblRanking.Text = "Label1"
        '
        'FrmgameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRanking)
        Me.Controls.Add(Me.btnInicioG)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Btnexit)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmgameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameOver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents btnInicioG As Button
    Friend WithEvents lblRanking As Label
End Class

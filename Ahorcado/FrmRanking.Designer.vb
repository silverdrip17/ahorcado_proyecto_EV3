<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRanking
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
        Me.LblUsuarios = New System.Windows.Forms.ListBox()
        Me.Btninicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUsuarios
        '
        Me.LblUsuarios.FormattingEnabled = True
        Me.LblUsuarios.ItemHeight = 16
        Me.LblUsuarios.Location = New System.Drawing.Point(19, 36)
        Me.LblUsuarios.Name = "LblUsuarios"
        Me.LblUsuarios.Size = New System.Drawing.Size(727, 308)
        Me.LblUsuarios.TabIndex = 0
        '
        'Btninicio
        '
        Me.Btninicio.Location = New System.Drawing.Point(206, 376)
        Me.Btninicio.Name = "Btninicio"
        Me.Btninicio.Size = New System.Drawing.Size(272, 50)
        Me.Btninicio.TabIndex = 1
        Me.Btninicio.Text = "Inicio"
        Me.Btninicio.UseVisualStyleBackColor = True
        '
        'FrmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btninicio)
        Me.Controls.Add(Me.LblUsuarios)
        Me.Name = "FrmRanking"
        Me.Text = "Ranking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblUsuarios As ListBox
    Friend WithEvents Btninicio As Button
End Class

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
        Me.LstUsuarios = New System.Windows.Forms.ListBox()
        Me.Btninicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstUsuarios
        '
        Me.LstUsuarios.FormattingEnabled = True
        Me.LstUsuarios.Location = New System.Drawing.Point(14, 29)
        Me.LstUsuarios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LstUsuarios.Name = "LstUsuarios"
        Me.LstUsuarios.Size = New System.Drawing.Size(546, 251)
        Me.LstUsuarios.TabIndex = 0
        '
        'Btninicio
        '
        Me.Btninicio.Location = New System.Drawing.Point(154, 306)
        Me.Btninicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btninicio.Name = "Btninicio"
        Me.Btninicio.Size = New System.Drawing.Size(204, 41)
        Me.Btninicio.TabIndex = 1
        Me.Btninicio.Text = "Inicio"
        Me.Btninicio.UseVisualStyleBackColor = True
        '
        'FrmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Btninicio)
        Me.Controls.Add(Me.LstUsuarios)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmRanking"
        Me.Text = "Ranking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstUsuarios As ListBox
    Friend WithEvents Btninicio As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoginAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoginAdmin))
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.Txtcontraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ChbmostrarContraseña = New System.Windows.Forms.CheckBox()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btncancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(76, 87)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(176, 22)
        Me.Txtusuario.TabIndex = 0
        '
        'Txtcontraseña
        '
        Me.Txtcontraseña.Location = New System.Drawing.Point(76, 141)
        Me.Txtcontraseña.Name = "Txtcontraseña"
        Me.Txtcontraseña.Size = New System.Drawing.Size(176, 22)
        Me.Txtcontraseña.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(44, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 28)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'ChbmostrarContraseña
        '
        Me.ChbmostrarContraseña.AutoSize = True
        Me.ChbmostrarContraseña.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ChbmostrarContraseña.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.ChbmostrarContraseña.Location = New System.Drawing.Point(254, 142)
        Me.ChbmostrarContraseña.Name = "ChbmostrarContraseña"
        Me.ChbmostrarContraseña.Size = New System.Drawing.Size(18, 17)
        Me.ChbmostrarContraseña.TabIndex = 4
        Me.ChbmostrarContraseña.UseVisualStyleBackColor = False
        '
        'Btnlogin
        '
        Me.Btnlogin.Location = New System.Drawing.Point(76, 185)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(174, 31)
        Me.Btnlogin.TabIndex = 5
        Me.Btnlogin.Text = "Login"
        Me.Btnlogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 56)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "login admin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btncancelar
        '
        Me.Btncancelar.Location = New System.Drawing.Point(76, 222)
        Me.Btncancelar.Name = "Btncancelar"
        Me.Btncancelar.Size = New System.Drawing.Size(174, 31)
        Me.Btncancelar.TabIndex = 7
        Me.Btncancelar.Text = "Cancelar"
        Me.Btncancelar.UseVisualStyleBackColor = True
        '
        'FrmLoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 261)
        Me.Controls.Add(Me.Btncancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.ChbmostrarContraseña)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txtcontraseña)
        Me.Controls.Add(Me.Txtusuario)
        Me.Name = "FrmLoginAdmin"
        Me.Text = "LoginAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents Txtcontraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ChbmostrarContraseña As CheckBox
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btncancelar As Button
End Class

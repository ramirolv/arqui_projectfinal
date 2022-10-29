<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PanelOptions = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelOptions.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOptions
        '
        Me.PanelOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PanelOptions.Controls.Add(Me.PictureBox1)
        Me.PanelOptions.Controls.Add(Me.Button2)
        Me.PanelOptions.Controls.Add(Me.Button1)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelOptions.Location = New System.Drawing.Point(0, 0)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(143, 423)
        Me.PanelOptions.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(0, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Registros"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelContainer
        '
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(143, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(594, 423)
        Me.PanelContainer.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyectoArduinoVB.My.Resources.Resources.icondatacenter2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 423)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelOptions)
        Me.MaximumSize = New System.Drawing.Size(753, 462)
        Me.MinimumSize = New System.Drawing.Size(753, 462)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.PanelOptions.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOptions As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.TextBoxLog2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxLog)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 318)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Leer Log Temperaturas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxLog2)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(241, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 318)
        Me.Panel2.TabIndex = 1
        '
        'TextBoxLog
        '
        Me.TextBoxLog.Location = New System.Drawing.Point(4, 33)
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.Size = New System.Drawing.Size(231, 273)
        Me.TextBoxLog.TabIndex = 2
        '
        'TextBoxLog2
        '
        Me.TextBoxLog2.Location = New System.Drawing.Point(9, 33)
        Me.TextBoxLog2.Multiline = True
        Me.TextBoxLog2.Name = "TextBoxLog2"
        Me.TextBoxLog2.Size = New System.Drawing.Size(231, 273)
        Me.TextBoxLog2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Leer Log Ingresos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 318)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Registros"
        Me.Text = "Registros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxLog As TextBox
    Friend WithEvents TextBoxLog2 As TextBox
    Friend WithEvents Button2 As Button
End Class

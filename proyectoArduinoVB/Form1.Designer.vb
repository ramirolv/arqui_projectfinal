<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel3_Derecha = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelDistancia = New System.Windows.Forms.Label()
        Me.PictureBoxAlarma = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2_Izquierda = New System.Windows.Forms.Panel()
        Me.PictureBoxAlertaTemperatura = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVentilador = New System.Windows.Forms.PictureBox()
        Me.LabelTemperatura = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxTermometro = New System.Windows.Forms.PictureBox()
        Me.Panel1_Superior = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Panel4_Inferior = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelPrincipal.SuspendLayout()
        Me.Panel3_Derecha.SuspendLayout()
        CType(Me.PictureBoxAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2_Izquierda.SuspendLayout()
        CType(Me.PictureBoxAlertaTemperatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVentilador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTermometro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1_Superior.SuspendLayout()
        Me.Panel4_Inferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.PanelPrincipal.Controls.Add(Me.Panel3_Derecha)
        Me.PanelPrincipal.Controls.Add(Me.Panel2_Izquierda)
        Me.PanelPrincipal.Controls.Add(Me.Panel1_Superior)
        Me.PanelPrincipal.Controls.Add(Me.Panel4_Inferior)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(597, 388)
        Me.PanelPrincipal.TabIndex = 0
        '
        'Panel3_Derecha
        '
        Me.Panel3_Derecha.BackColor = System.Drawing.Color.White
        Me.Panel3_Derecha.Controls.Add(Me.Label3)
        Me.Panel3_Derecha.Controls.Add(Me.LabelDistancia)
        Me.Panel3_Derecha.Controls.Add(Me.PictureBoxAlarma)
        Me.Panel3_Derecha.Controls.Add(Me.PictureBox2)
        Me.Panel3_Derecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3_Derecha.Location = New System.Drawing.Point(298, 60)
        Me.Panel3_Derecha.Name = "Panel3_Derecha"
        Me.Panel3_Derecha.Size = New System.Drawing.Size(299, 278)
        Me.Panel3_Derecha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(71, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "cm"
        '
        'LabelDistancia
        '
        Me.LabelDistancia.AutoSize = True
        Me.LabelDistancia.BackColor = System.Drawing.Color.Transparent
        Me.LabelDistancia.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.LabelDistancia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.LabelDistancia.Location = New System.Drawing.Point(3, 3)
        Me.LabelDistancia.Name = "LabelDistancia"
        Me.LabelDistancia.Size = New System.Drawing.Size(64, 45)
        Me.LabelDistancia.TabIndex = 5
        Me.LabelDistancia.Text = "00"
        '
        'PictureBoxAlarma
        '
        Me.PictureBoxAlarma.Image = Global.proyectoArduinoVB.My.Resources.Resources.alarma_apagada1
        Me.PictureBoxAlarma.Location = New System.Drawing.Point(3, 51)
        Me.PictureBoxAlarma.Name = "PictureBoxAlarma"
        Me.PictureBoxAlarma.Size = New System.Drawing.Size(119, 221)
        Me.PictureBoxAlarma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAlarma.TabIndex = 1
        Me.PictureBoxAlarma.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.proyectoArduinoVB.My.Resources.Resources.Cuarto_eléctrico1
        Me.PictureBox2.Location = New System.Drawing.Point(128, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 266)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel2_Izquierda
        '
        Me.Panel2_Izquierda.BackColor = System.Drawing.Color.White
        Me.Panel2_Izquierda.Controls.Add(Me.PictureBoxAlertaTemperatura)
        Me.Panel2_Izquierda.Controls.Add(Me.PictureBoxVentilador)
        Me.Panel2_Izquierda.Controls.Add(Me.LabelTemperatura)
        Me.Panel2_Izquierda.Controls.Add(Me.Label1)
        Me.Panel2_Izquierda.Controls.Add(Me.PictureBoxTermometro)
        Me.Panel2_Izquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2_Izquierda.Location = New System.Drawing.Point(0, 60)
        Me.Panel2_Izquierda.Name = "Panel2_Izquierda"
        Me.Panel2_Izquierda.Size = New System.Drawing.Size(292, 278)
        Me.Panel2_Izquierda.TabIndex = 2
        '
        'PictureBoxAlertaTemperatura
        '
        Me.PictureBoxAlertaTemperatura.Image = Global.proyectoArduinoVB.My.Resources.Resources.alarma_apagada1
        Me.PictureBoxAlertaTemperatura.Location = New System.Drawing.Point(147, 6)
        Me.PictureBoxAlertaTemperatura.Name = "PictureBoxAlertaTemperatura"
        Me.PictureBoxAlertaTemperatura.Size = New System.Drawing.Size(142, 64)
        Me.PictureBoxAlertaTemperatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAlertaTemperatura.TabIndex = 4
        Me.PictureBoxAlertaTemperatura.TabStop = False
        '
        'PictureBoxVentilador
        '
        Me.PictureBoxVentilador.Image = Global.proyectoArduinoVB.My.Resources.Resources.Ventilador_apagado
        Me.PictureBoxVentilador.Location = New System.Drawing.Point(147, 76)
        Me.PictureBoxVentilador.Name = "PictureBoxVentilador"
        Me.PictureBoxVentilador.Size = New System.Drawing.Size(145, 140)
        Me.PictureBoxVentilador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVentilador.TabIndex = 3
        Me.PictureBoxVentilador.TabStop = False
        '
        'LabelTemperatura
        '
        Me.LabelTemperatura.AutoSize = True
        Me.LabelTemperatura.BackColor = System.Drawing.Color.Transparent
        Me.LabelTemperatura.Font = New System.Drawing.Font("Arial", 25.0!)
        Me.LabelTemperatura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.LabelTemperatura.Location = New System.Drawing.Point(195, 227)
        Me.LabelTemperatura.Name = "LabelTemperatura"
        Me.LabelTemperatura.Size = New System.Drawing.Size(55, 39)
        Me.LabelTemperatura.TabIndex = 2
        Me.LabelTemperatura.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(147, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 53)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "°"
        '
        'PictureBoxTermometro
        '
        Me.PictureBoxTermometro.Image = Global.proyectoArduinoVB.My.Resources.Resources.Termometro_1
        Me.PictureBoxTermometro.Location = New System.Drawing.Point(12, 6)
        Me.PictureBoxTermometro.Name = "PictureBoxTermometro"
        Me.PictureBoxTermometro.Size = New System.Drawing.Size(129, 266)
        Me.PictureBoxTermometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxTermometro.TabIndex = 0
        Me.PictureBoxTermometro.TabStop = False
        '
        'Panel1_Superior
        '
        Me.Panel1_Superior.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel1_Superior.Controls.Add(Me.LabelTitulo)
        Me.Panel1_Superior.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1_Superior.Location = New System.Drawing.Point(0, 0)
        Me.Panel1_Superior.Name = "Panel1_Superior"
        Me.Panel1_Superior.Size = New System.Drawing.Size(597, 60)
        Me.Panel1_Superior.TabIndex = 1
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.LabelTitulo.Location = New System.Drawing.Point(109, 9)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(370, 40)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "DashBoard DataCenter"
        '
        'Panel4_Inferior
        '
        Me.Panel4_Inferior.BackColor = System.Drawing.Color.White
        Me.Panel4_Inferior.Controls.Add(Me.Button1)
        Me.Panel4_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4_Inferior.Location = New System.Drawing.Point(0, 338)
        Me.Panel4_Inferior.Name = "Panel4_Inferior"
        Me.Panel4_Inferior.Size = New System.Drawing.Size(597, 50)
        Me.Panel4_Inferior.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(175, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ingresar código de acceso"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 388)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelPrincipal.ResumeLayout(False)
        Me.Panel3_Derecha.ResumeLayout(False)
        Me.Panel3_Derecha.PerformLayout()
        CType(Me.PictureBoxAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2_Izquierda.ResumeLayout(False)
        Me.Panel2_Izquierda.PerformLayout()
        CType(Me.PictureBoxAlertaTemperatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVentilador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTermometro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1_Superior.ResumeLayout(False)
        Me.Panel1_Superior.PerformLayout()
        Me.Panel4_Inferior.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents Panel3_Derecha As Panel
    Friend WithEvents Panel2_Izquierda As Panel
    Friend WithEvents PictureBoxTermometro As PictureBox
    Friend WithEvents Panel1_Superior As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Panel4_Inferior As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBoxAlarma As PictureBox
    Friend WithEvents LabelTemperatura As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBoxVentilador As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelDistancia As Label
    Friend WithEvents PictureBoxAlertaTemperatura As PictureBox
End Class

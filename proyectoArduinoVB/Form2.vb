Public Class Form2
    Dim formulario1 As Form1
    Dim formulario2 As Registros

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormEnPanel(formulario1)
    End Sub

    Private Sub abrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContainer.Controls.Count > 0 Then
            Me.PanelContainer.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContainer.Controls.Add(fh)
        Me.PanelContainer.Tag = fh
        fh.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formulario1 = New Form1
        formulario2 = New Registros
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormEnPanel(formulario2)
    End Sub
End Class
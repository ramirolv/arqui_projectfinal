Imports System.IO
Public Class Registros
    Public Sub leerArchivo(ByRef text As TextBox, ByRef nombre As String)
        Dim sr As StreamReader
        Try
            sr = New StreamReader(".\" & nombre & ".txt")
            Dim renglon As String
            While Not sr.EndOfStream
                renglon = sr.ReadLine()
                text.Text += renglon & vbCrLf
            End While
            sr.Close()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        leerArchivo(TextBoxLog, "TEMPERATURAS")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        leerArchivo(TextBoxLog2, "INGRESOS")
    End Sub
End Class
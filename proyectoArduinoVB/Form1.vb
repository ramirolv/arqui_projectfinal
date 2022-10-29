Imports System.IO
Imports System.DateTime

Public Class Form1

    Dim estadoAnterior As Boolean

    Public Sub escribirArchivo(ByRef text As String, ByRef nameFile As String)
        Dim ThisMoment As Date
        ThisMoment = Now

        Dim sw As StreamWriter = File.AppendText(".\" & nameFile & ".txt")
        sw.WriteLine(ThisMoment & " " & text)
        sw.Close()
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim Dato As String = SerialPort1.ReadLine.ToString
        If Dato <> "" Or Dato <> String.Empty Or Dato <> Nothing Then

            If InStr(1, Dato, "temp:") > 0 Then
                Try
                    Dato = Dato.Substring(Dato.IndexOf(":") + 1)
                    LabelTemperatura.Text = Dato
                Catch ex As Exception

                End Try
                If Convert.ToDecimal(Dato) <= 17 Then
                    PictureBoxTermometro.Image = proyectoArduinoVB.My.Resources.Resources.Termometro_1
                ElseIf Convert.ToDecimal(Dato) > 17 And Convert.ToDecimal(Dato) <= 20 Then
                    PictureBoxVentilador.Image = proyectoArduinoVB.My.Resources.Resources.Ventilador_apagado
                    PictureBoxAlertaTemperatura.Image = proyectoArduinoVB.My.Resources.Resources.alarma_apagada1
                    PictureBoxTermometro.Image = proyectoArduinoVB.My.Resources.Resources.Termometro_2
                ElseIf Convert.ToDecimal(Dato) > 20 And Convert.ToDecimal(Dato) <= 23 Then
                    PictureBoxTermometro.Image = proyectoArduinoVB.My.Resources.Resources.Termometro_3
                ElseIf Convert.ToDecimal(Dato) > 23 And Convert.ToDecimal(Dato) <= 25 Then
                    PictureBoxTermometro.Image = proyectoArduinoVB.My.Resources.Resources.Termometro_4
                ElseIf Convert.ToDecimal(Dato) > 25 Then
                    PictureBoxTermometro.Image = proyectoArduinoVB.My.Resources.Resources.Termometro_8
                    PictureBoxVentilador.Image = proyectoArduinoVB.My.Resources.Resources.ventilador
                    PictureBoxAlertaTemperatura.Image = proyectoArduinoVB.My.Resources.Resources.alarma
                    escribirArchivo("Temperatura: " & Dato, "TEMPERATURAS")
                End If

            ElseIf InStr(1, Dato, "dist:") > 0 Then
                Dato = Dato.Substring(Dato.IndexOf(":") + 1)
                Try
                    LabelDistancia.Text = Dato
                Catch ex As Exception

                End Try
                If Convert.ToInt16(Dato) <= 20 Then
                ElseIf Convert.ToInt16(Dato) > 20 And Convert.ToInt16(Dato) <= 25 Then
                ElseIf Convert.ToInt16(Dato) > 25 Then
                End If

            ElseIf InStr(1, Dato, "code:") > 0 Then
                Dato = Dato.Substring(Dato.IndexOf(":") + 1)

                If Convert.ToInt16(Dato) = 3 Then
                    PictureBoxAlarma.Image = proyectoArduinoVB.My.Resources.Resources.alarma
                    escribirArchivo("Distancia: " & Dato, "DISTANCIAS")
                    'MsgBox("Alerta se seguridad: intruso", MsgBoxStyle.Critical)
                    estadoAnterior = True

                ElseIf Convert.ToInt16(Dato) = 2 Then
                    PictureBoxAlarma.Image = proyectoArduinoVB.My.Resources.Resources.alarma_error
                    'MsgBox("Clave equivocada", MsgBoxStyle.Exclamation)
                    escribirArchivo("Clave incorrecta ", "INGRESOS")
                ElseIf Convert.ToInt16(Dato) = 1 Then
                    If estadoAnterior Then
                        escribirArchivo("Ingreso correcto ", "INGRESOS")
                        estadoAnterior = False
                    End If
                    PictureBoxAlarma.Image = proyectoArduinoVB.My.Resources.Resources.alarma_apagada1
                    'MsgBox("Bienvenido al sistema", MsgBoxStyle.Information)
                End If


            End If



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        escribir_dato(InputBox("Escriba el código de acceso"))
    End Sub

    Private Sub escribir_dato(dato)
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.Write(dato)
            Else
                SerialPort1.Open()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SerialPort1.Close()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SerialPort1.Close()
    End Sub
End Class

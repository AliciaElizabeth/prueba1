Public Class Form5

    Private Sub btnProcesar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesar.Click
        Dim numero, num1, num2 As Integer
        Dim capicua As Boolean = False
        Dim cad As String = ""
        Dim tamano As Integer

        If IsNumeric(txtInicio.Text) And IsNumeric(txtFin.Text) Then

            numero = txtInicio.Text
            tamano = Len(Trim(numero))
            Do While numero <= txtFin.Text
                For i = 1 To tamano
                    num1 = Mid(numero, i, 1)
                    num2 = Mid(numero, tamano + 1 - i, 1)
                    If num1 = num2 Then
                        capicua = True
                    Else
                        capicua = False
                        Exit For
                    End If
                Next i
                If capicua Then
                    cad = cad + "," + Trim(numero)
                End If
                numero = numero + 1
            Loop
            RichTextBox1.Text = cad
        End If

    End Sub
End Class
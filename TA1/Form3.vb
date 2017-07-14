Public Class Form3

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim suma As Integer = 0
        Dim numero As Integer = 1
        Dim num As Integer
        Dim contador As Integer = 1
        Dim cifra As Integer
        Dim cad As String = ""


        While contador <= 5
            num = numero
            While num > 0
                cifra = num Mod 10
                suma = suma + cifra ^ 3
                num = (num - cifra) / 10
            End While
            If suma = numero Then
                cad = cad + " - " + Trim(numero)
                contador = contador + 1
            End If
            numero = numero + 1
            suma = 0
        End While
        RichTextBox1.Text = cad




    End Sub
End Class
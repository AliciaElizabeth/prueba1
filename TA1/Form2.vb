Public Class Form2

    Private Sub btnProcesar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesar.Click

        Dim n As Integer = 100
        Dim i As Integer
        Dim cad As String = ""

        While (n < 1000)
            i = 2
            While (i <= n)
                If (i = n) Then
                    cad = cad + " - " + Trim(n)
                Else
                    If (n Mod i = 0) Then
                        i = n
                    End If

                End If
                i = i + 1
            End While
            n = n + 1
        End While

        RichTextBox1.Text = cad
       


    End Sub
End Class
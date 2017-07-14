Public Class Form4
    Public Function suma(ByVal N As Integer, ByVal S As Integer)
        For i As Integer = 2 To N / 2
            If (N Mod i = 0) Then
                S = S + i
            End If
        Next i
        Return S
    End Function

    Private Sub btnProcesar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesar.Click

        Dim n1 As Integer
        Dim n2 As Integer
        Dim sum1 As Integer = 1
        Dim sum2 As Integer = 1

        If IsNumeric(txtAmigo1.Text) And IsNumeric(txtAmigo2.Text) Then
            n1 = txtAmigo1.Text
            n2 = txtAmigo2.Text
            sum1 = suma(n1, sum1)
            sum2 = suma(n2, sum2)
            If ((sum1 = n2) And sum2 = n1) Then
                lblresultado.Text = "Los numeros  " + Trim(n1) +
                    " y " + Trim(n2) + " Sí son numeros amigos "
            Else
                lblresultado.Text = "Los numeros  " + Trim(n1) +
                    " y " + Trim(n2) + " No son numeros amigos "
            End If
        Else
            MsgBox("Debe ingresar un número valido", MsgBoxStyle.Information, AcceptButton)
        End If
       

    End Sub
End Class
Public Class Form1

    Private Sub btnOtro_Click(sender As System.Object, e As System.EventArgs) Handles btnOtro.Click

        If IsNumeric(Trim(txtNumero.Text)) Then
            ListBox1.Items.Add(txtNumero.Text)
            txtNumero.Clear()
        Else
            MsgBox("Debe ingresar un número valido", MsgBoxStyle.Information, AcceptButton)
        End If
        

    End Sub

    Private Sub btnProcesar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesar.Click

        Dim mayor, menor, promedio As Integer



        If ListBox1.Items.Count = 0 Then
            lblMayor.Text = "No Ingreso Datos"
            lblMenor.Text = "No Ingreso Datos"
            lblPromedio.Text = "No Ingreso Datos"
        Else
            mayor = ListBox1.Items(0)
            menor = ListBox1.Items(0)

            For i = 0 To ListBox1.Items.Count - 1

                If menor > ListBox1.Items(i) Then
                    menor = ListBox1.Items(i)
                End If

                If mayor < ListBox1.Items(i) Then
                    mayor = ListBox1.Items(i)
                End If

                promedio = promedio + ListBox1.Items(i)
            Next

            lblMayor.Text = mayor
            lblMenor.Text = menor
            lblPromedio.Text = promedio / (ListBox1.Items.Count)

        End If


    End Sub
End Class

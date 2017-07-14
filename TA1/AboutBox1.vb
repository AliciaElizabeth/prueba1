Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        Me.LabelProductName.Text = "Producto Académico N°2"
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = "Alicia Elizabeth Manrique de Lara Vidalón"
        Me.LabelCompanyName.Text = "Universidad Continental"
        Me.TextBoxDescription.Text = "Uso de Formulario MDI y Sentencias." + vbCrLf + "Laboratorio de Programación." + vbCrLf + "Docente: Ing. Adiel Omar Flores Ramos."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class

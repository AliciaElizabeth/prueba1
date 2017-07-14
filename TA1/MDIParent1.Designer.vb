<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.NúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayorMenorPromedioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuboPerfectoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CipúaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NúmerosToolStripMenuItem, Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(812, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'NúmerosToolStripMenuItem
        '
        Me.NúmerosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MayorMenorPromedioToolStripMenuItem1, Me.PrimoToolStripMenuItem, Me.CuboPerfectoToolStripMenuItem1, Me.AmigoToolStripMenuItem, Me.CipúaToolStripMenuItem})
        Me.NúmerosToolStripMenuItem.Name = "NúmerosToolStripMenuItem"
        Me.NúmerosToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.NúmerosToolStripMenuItem.Text = "Programas"
        '
        'MayorMenorPromedioToolStripMenuItem1
        '
        Me.MayorMenorPromedioToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.MayorMenorPromedioToolStripMenuItem1.Name = "MayorMenorPromedioToolStripMenuItem1"
        Me.MayorMenorPromedioToolStripMenuItem1.Size = New System.Drawing.Size(248, 22)
        Me.MayorMenorPromedioToolStripMenuItem1.Text = "Número Mayor Menor Promedio"
        '
        'PrimoToolStripMenuItem
        '
        Me.PrimoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PrimoToolStripMenuItem.Name = "PrimoToolStripMenuItem"
        Me.PrimoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.PrimoToolStripMenuItem.Text = "Números Primos"
        '
        'CuboPerfectoToolStripMenuItem1
        '
        Me.CuboPerfectoToolStripMenuItem1.BackColor = System.Drawing.Color.Ivory
        Me.CuboPerfectoToolStripMenuItem1.Name = "CuboPerfectoToolStripMenuItem1"
        Me.CuboPerfectoToolStripMenuItem1.Size = New System.Drawing.Size(248, 22)
        Me.CuboPerfectoToolStripMenuItem1.Text = "Número Amstrong"
        '
        'AmigoToolStripMenuItem
        '
        Me.AmigoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.AmigoToolStripMenuItem.Name = "AmigoToolStripMenuItem"
        Me.AmigoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.AmigoToolStripMenuItem.Text = "Número Amigo"
        '
        'CipúaToolStripMenuItem
        '
        Me.CipúaToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CipúaToolStripMenuItem.Name = "CipúaToolStripMenuItem"
        Me.CipúaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.CipúaToolStripMenuItem.Text = "Número Capicúa"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SalirToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 495)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(812, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(812, 517)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto Académico N° 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents NúmerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayorMenorPromedioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrimoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuboPerfectoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmigoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CipúaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class

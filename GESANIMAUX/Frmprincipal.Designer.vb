<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmprincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FichierToolStripMenuItem = New ToolStripMenuItem()
        QuitterToolStripMenuItem = New ToolStripMenuItem()
        GestionToolStripMenuItem = New ToolStripMenuItem()
        AnimauxToolStripMenuItem = New ToolStripMenuItem()
        AideToolStripMenuItem = New ToolStripMenuItem()
        AProposToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FichierToolStripMenuItem, GestionToolStripMenuItem, AideToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FichierToolStripMenuItem
        ' 
        FichierToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {QuitterToolStripMenuItem})
        FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        FichierToolStripMenuItem.Size = New Size(78, 29)
        FichierToolStripMenuItem.Text = "Fichier"
        ' 
        ' QuitterToolStripMenuItem
        ' 
        QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        QuitterToolStripMenuItem.Size = New Size(169, 34)
        QuitterToolStripMenuItem.Text = "Quitter"
        ' 
        ' GestionToolStripMenuItem
        ' 
        GestionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AnimauxToolStripMenuItem})
        GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        GestionToolStripMenuItem.Size = New Size(88, 29)
        GestionToolStripMenuItem.Text = "Gestion"
        ' 
        ' AnimauxToolStripMenuItem
        ' 
        AnimauxToolStripMenuItem.Name = "AnimauxToolStripMenuItem"
        AnimauxToolStripMenuItem.Size = New Size(183, 34)
        AnimauxToolStripMenuItem.Text = "Animaux"
        ' 
        ' AideToolStripMenuItem
        ' 
        AideToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AProposToolStripMenuItem})
        AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        AideToolStripMenuItem.Size = New Size(64, 29)
        AideToolStripMenuItem.Text = "Aide"
        ' 
        ' AProposToolStripMenuItem
        ' 
        AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        AProposToolStripMenuItem.Size = New Size(189, 34)
        AProposToolStripMenuItem.Text = "A propos"
        ' 
        ' Frmprincipal
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Frmprincipal"
        Text = "Menuprincipal"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimauxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem

End Class

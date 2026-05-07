<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmanimaux
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Grillanimaux = New DataGridView()
        Label1 = New Label()
        Tbcode = New TextBox()
        Label2 = New Label()
        Tbnom = New TextBox()
        Label3 = New Label()
        Dtdate = New DateTimePicker()
        Label4 = New Label()
        Tbpoids = New TextBox()
        Label5 = New Label()
        TbPathologie = New MaskedTextBox()
        Ajouter = New Button()
        Btenregistrer = New Button()
        btmodifier = New Button()
        Btsupprimer = New Button()
        Btfermer = New Button()
        CType(Grillanimaux, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(12, 248)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(713, 304)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Grillanimaux
        ' 
        Grillanimaux.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Grillanimaux.Location = New Point(12, -7)
        Grillanimaux.Name = "Grillanimaux"
        Grillanimaux.RowHeadersWidth = 62
        Grillanimaux.Size = New Size(1053, 228)
        Grillanimaux.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 279)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 25)
        Label1.TabIndex = 1
        Label1.Text = "Code"
        ' 
        ' Tbcode
        ' 
        Tbcode.Location = New Point(96, 276)
        Tbcode.Name = "Tbcode"
        Tbcode.Size = New Size(150, 31)
        Tbcode.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 25)
        Label2.TabIndex = 3
        Label2.Text = "Nom"
        ' 
        ' Tbnom
        ' 
        Tbnom.Location = New Point(96, 326)
        Tbnom.Name = "Tbnom"
        Tbnom.Size = New Size(150, 31)
        Tbnom.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 383)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 5
        Label3.Text = "Date de naissance"
        ' 
        ' Dtdate
        ' 
        Dtdate.Location = New Point(211, 383)
        Dtdate.Name = "Dtdate"
        Dtdate.Size = New Size(300, 31)
        Dtdate.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 436)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 25)
        Label4.TabIndex = 7
        Label4.Text = "Poids"
        ' 
        ' Tbpoids
        ' 
        Tbpoids.Location = New Point(96, 436)
        Tbpoids.Name = "Tbpoids"
        Tbpoids.Size = New Size(150, 31)
        Tbpoids.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 503)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 25)
        Label5.TabIndex = 9
        Label5.Text = "Pathologie"
        ' 
        ' TbPathologie
        ' 
        TbPathologie.Location = New Point(159, 500)
        TbPathologie.Name = "TbPathologie"
        TbPathologie.Size = New Size(199, 31)
        TbPathologie.TabIndex = 10
        ' 
        ' Ajouter
        ' 
        Ajouter.Location = New Point(939, 257)
        Ajouter.Name = "Ajouter"
        Ajouter.Size = New Size(112, 34)
        Ajouter.TabIndex = 11
        Ajouter.Text = "Ajouter"
        Ajouter.UseVisualStyleBackColor = True
        ' 
        ' Btenregistrer
        ' 
        Btenregistrer.Location = New Point(939, 316)
        Btenregistrer.Name = "Btenregistrer"
        Btenregistrer.Size = New Size(112, 34)
        Btenregistrer.TabIndex = 12
        Btenregistrer.Text = "Enregistrer"
        Btenregistrer.UseVisualStyleBackColor = True
        ' 
        ' btmodifier
        ' 
        btmodifier.Location = New Point(939, 373)
        btmodifier.Name = "btmodifier"
        btmodifier.Size = New Size(112, 34)
        btmodifier.TabIndex = 13
        btmodifier.Text = "Modifier"
        btmodifier.UseVisualStyleBackColor = True
        ' 
        ' Btsupprimer
        ' 
        Btsupprimer.Location = New Point(939, 436)
        Btsupprimer.Name = "Btsupprimer"
        Btsupprimer.Size = New Size(112, 34)
        Btsupprimer.TabIndex = 14
        Btsupprimer.Text = "Supprimer"
        Btsupprimer.UseVisualStyleBackColor = True
        ' 
        ' Btfermer
        ' 
        Btfermer.Location = New Point(939, 494)
        Btfermer.Name = "Btfermer"
        Btfermer.Size = New Size(112, 34)
        Btfermer.TabIndex = 15
        Btfermer.Text = "Fermer"
        Btfermer.UseVisualStyleBackColor = True
        ' 
        ' Frmanimaux
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1095, 623)
        Controls.Add(Btfermer)
        Controls.Add(Btsupprimer)
        Controls.Add(btmodifier)
        Controls.Add(Btenregistrer)
        Controls.Add(Ajouter)
        Controls.Add(Grillanimaux)
        Controls.Add(TbPathologie)
        Controls.Add(Label5)
        Controls.Add(Tbpoids)
        Controls.Add(Label4)
        Controls.Add(Dtdate)
        Controls.Add(Label3)
        Controls.Add(Tbnom)
        Controls.Add(Label2)
        Controls.Add(Tbcode)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Frmanimaux"
        Text = "Gestion animaux"
        CType(Grillanimaux, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Grillanimaux As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tbnom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Dtdate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Tbpoids As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPathologie As MaskedTextBox
    Friend WithEvents Ajouter As Button
    Friend WithEvents Btenregistrer As Button
    Friend WithEvents btmodifier As Button
    Friend WithEvents Btsupprimer As Button
    Friend WithEvents Btfermer As Button
End Class

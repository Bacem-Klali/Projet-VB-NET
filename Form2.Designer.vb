<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        volst = New DataGridView()
        num = New DataGridViewTextBoxColumn()
        des = New DataGridViewTextBoxColumn()
        dat = New DataGridViewTextBoxColumn()
        nbp = New DataGridViewTextBoxColumn()
        pri = New DataGridViewTextBoxColumn()
        numero = New TextBox()
        prix = New TextBox()
        nbpl = New TextBox()
        dest = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ajouter = New Button()
        modifier = New Button()
        suppr = New Button()
        Label6 = New Label()
        dateh = New TextBox()
        CType(volst, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' volst
        ' 
        volst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        volst.Columns.AddRange(New DataGridViewColumn() {num, des, dat, nbp, pri})
        volst.Location = New Point(26, 319)
        volst.Name = "volst"
        volst.Size = New Size(543, 150)
        volst.TabIndex = 0
        ' 
        ' num
        ' 
        num.HeaderText = "Numero de vol"
        num.Name = "num"
        ' 
        ' des
        ' 
        des.HeaderText = "La destination"
        des.Name = "des"
        ' 
        ' dat
        ' 
        dat.HeaderText = "La date et l'heure"
        dat.Name = "dat"
        ' 
        ' nbp
        ' 
        nbp.HeaderText = "NB Places disponibles"
        nbp.Name = "nbp"
        ' 
        ' pri
        ' 
        pri.HeaderText = "Prix"
        pri.Name = "pri"
        ' 
        ' numero
        ' 
        numero.Location = New Point(185, 82)
        numero.Name = "numero"
        numero.Size = New Size(147, 23)
        numero.TabIndex = 1
        ' 
        ' prix
        ' 
        prix.Location = New Point(185, 237)
        prix.Name = "prix"
        prix.Size = New Size(147, 23)
        prix.TabIndex = 2
        ' 
        ' nbpl
        ' 
        nbpl.Location = New Point(185, 199)
        nbpl.Name = "nbpl"
        nbpl.Size = New Size(147, 23)
        nbpl.TabIndex = 3
        ' 
        ' dest
        ' 
        dest.Location = New Point(185, 121)
        dest.Name = "dest"
        dest.Size = New Size(147, 23)
        dest.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 6
        Label1.Text = "Numero de vol :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 7
        Label2.Text = "La destination"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 15)
        Label3.TabIndex = 8
        Label3.Text = "La date et l'heure"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 9
        Label4.Text = "Nb Places Dispo :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(65, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 10
        Label5.Text = "Prix :"
        ' 
        ' ajouter
        ' 
        ajouter.Location = New Point(422, 103)
        ajouter.Name = "ajouter"
        ajouter.Size = New Size(103, 27)
        ajouter.TabIndex = 12
        ajouter.Text = "Ajouter"
        ajouter.UseVisualStyleBackColor = True
        ' 
        ' modifier
        ' 
        modifier.Location = New Point(422, 160)
        modifier.Name = "modifier"
        modifier.Size = New Size(103, 27)
        modifier.TabIndex = 13
        modifier.Text = "Modifier"
        modifier.UseVisualStyleBackColor = True
        ' 
        ' suppr
        ' 
        suppr.Location = New Point(422, 219)
        suppr.Name = "suppr"
        suppr.Size = New Size(103, 27)
        suppr.TabIndex = 14
        suppr.Text = "Supprimer"
        suppr.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label6.Location = New Point(208, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 28)
        Label6.TabIndex = 15
        Label6.Text = "Gestion des vols"
        ' 
        ' dateh
        ' 
        dateh.Location = New Point(185, 160)
        dateh.Name = "dateh"
        dateh.Size = New Size(147, 23)
        dateh.TabIndex = 16
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 501)
        Controls.Add(dateh)
        Controls.Add(Label6)
        Controls.Add(suppr)
        Controls.Add(modifier)
        Controls.Add(ajouter)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dest)
        Controls.Add(nbpl)
        Controls.Add(prix)
        Controls.Add(numero)
        Controls.Add(volst)
        Name = "Form2"
        Text = "Gestion des vols (Admin)"
        CType(volst, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents volst As DataGridView
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents des As DataGridViewTextBoxColumn
    Friend WithEvents dat As DataGridViewTextBoxColumn
    Friend WithEvents nbp As DataGridViewTextBoxColumn
    Friend WithEvents pri As DataGridViewTextBoxColumn
    Friend WithEvents numero As TextBox
    Friend WithEvents prix As TextBox
    Friend WithEvents nbpl As TextBox
    Friend WithEvents dest As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ajouter As Button
    Friend WithEvents modifier As Button
    Friend WithEvents suppr As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dateh As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label3 = New Label()
        Label2 = New Label()
        dest = New TextBox()
        rech = New Button()
        Label1 = New Label()
        tel = New TextBox()
        Label4 = New Label()
        pre = New TextBox()
        Label5 = New Label()
        nom = New TextBox()
        btnres = New Button()
        Label6 = New Label()
        dateh = New TextBox()
        CType(volst, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' volst
        ' 
        volst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        volst.Columns.AddRange(New DataGridViewColumn() {num, des, dat, nbp, pri})
        volst.Location = New Point(73, 114)
        volst.Name = "volst"
        volst.Size = New Size(543, 150)
        volst.TabIndex = 1
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(262, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 14
        Label3.Text = "La date et l'heure :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 15)
        Label2.TabIndex = 13
        Label2.Text = "La destination :"
        ' 
        ' dest
        ' 
        dest.Location = New Point(126, 75)
        dest.Name = "dest"
        dest.Size = New Size(113, 23)
        dest.TabIndex = 12
        ' 
        ' rech
        ' 
        rech.Location = New Point(532, 75)
        rech.Name = "rech"
        rech.Size = New Size(103, 23)
        rech.TabIndex = 16
        rech.Text = "Rechercher"
        rech.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(77, 341)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 18
        Label1.Text = "Num de tel :"
        ' 
        ' tel
        ' 
        tel.Location = New Point(168, 338)
        tel.Name = "tel"
        tel.Size = New Size(113, 23)
        tel.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(310, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 20
        Label4.Text = "Prenom :"
        ' 
        ' pre
        ' 
        pre.Location = New Point(407, 287)
        pre.Name = "pre"
        pre.Size = New Size(113, 23)
        pre.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(77, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 15)
        Label5.TabIndex = 22
        Label5.Text = "Nom :"
        ' 
        ' nom
        ' 
        nom.Location = New Point(168, 287)
        nom.Name = "nom"
        nom.Size = New Size(113, 23)
        nom.TabIndex = 21
        ' 
        ' btnres
        ' 
        btnres.Location = New Point(362, 341)
        btnres.Name = "btnres"
        btnres.Size = New Size(113, 23)
        btnres.TabIndex = 23
        btnres.Text = "Reserve"
        btnres.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label6.Location = New Point(262, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 28)
        Label6.TabIndex = 24
        Label6.Text = "Reservation"
        ' 
        ' dateh
        ' 
        dateh.Location = New Point(386, 75)
        dateh.Name = "dateh"
        dateh.Size = New Size(113, 23)
        dateh.TabIndex = 25
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(683, 417)
        Controls.Add(dateh)
        Controls.Add(Label6)
        Controls.Add(btnres)
        Controls.Add(Label5)
        Controls.Add(nom)
        Controls.Add(Label4)
        Controls.Add(pre)
        Controls.Add(Label1)
        Controls.Add(tel)
        Controls.Add(rech)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dest)
        Controls.Add(volst)
        Name = "Form3"
        Text = "Reservation des billets (utilisateur)"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dest As TextBox
    Friend WithEvents rech As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents btnres As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dateh As TextBox
End Class

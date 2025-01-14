<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        uti = New TextBox()
        mdp = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        con = New Button()
        Label4 = New Label()
        msg = New Label()
        SuspendLayout()
        ' 
        ' uti
        ' 
        uti.Location = New Point(162, 84)
        uti.Name = "uti"
        uti.Size = New Size(128, 23)
        uti.TabIndex = 0
        ' 
        ' mdp
        ' 
        mdp.Location = New Point(162, 127)
        mdp.Name = "mdp"
        mdp.Size = New Size(128, 23)
        mdp.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nom d'utilisateur :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 3
        Label2.Text = "Mot de passe :"
        ' 
        ' con
        ' 
        con.Location = New Point(124, 197)
        con.Name = "con"
        con.Size = New Size(96, 23)
        con.TabIndex = 6
        con.Text = "Se connecter"
        con.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label4.Location = New Point(105, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 32)
        Label4.TabIndex = 7
        Label4.Text = "Connexion"
        ' 
        ' msg
        ' 
        msg.AutoSize = True
        msg.Location = New Point(84, 247)
        msg.Name = "msg"
        msg.Size = New Size(0, 15)
        msg.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 296)
        Controls.Add(msg)
        Controls.Add(Label4)
        Controls.Add(con)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(mdp)
        Controls.Add(uti)
        Name = "Form1"
        Text = "Interface de connexion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents uti As TextBox
    Friend WithEvents mdp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents con As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents msg As Label

End Class

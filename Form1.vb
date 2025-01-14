Public Class Form1
    Private Const AdminNom As String = "Admin"
    Private Const AdminMdp As String = "Admin"
    Private Const UtiNom As String = "Utilisateur"
    Private Const UtiMdp As String = "Utilisateur"

    Private Sub Connecter(sender As Object, e As EventArgs) Handles con.Click
        If String.IsNullOrEmpty(uti.Text) OrElse String.IsNullOrEmpty(mdp.Text) Then
            msg.Text = "Veuillez remplir tous les champs."
            Return
        End If

        Dim nom As String = uti.Text
        Dim modp As String = mdp.Text

        If nom = AdminNom AndAlso modp = AdminMdp Then
            Dim Pageadmin As New Form2()
            Pageadmin.Show()
            Me.Hide()
        ElseIf nom = UtiNom AndAlso modp = UtiMdp Then
            Dim Pageuti As New Form3()
            Pageuti.Show()
            Me.Hide()
        Else
            msg.Text = "Nom d'utilisateur ou mot de passe incorrect."
        End If
    End Sub

End Class

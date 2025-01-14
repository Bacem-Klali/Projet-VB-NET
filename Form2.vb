Imports System.IO
Imports System.Globalization
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form2

    Private Const volsdata As String = "vols_data.csv"

    Private Sub gestion(sender As Object, e As EventArgs) Handles MyBase.Load
        charger()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        If Not valider() Then
            Exit Sub
        End If

        Dim str As String() = {numero.Text, dest.Text, dateh.Text, nbpl.Text, prix.Text}
        volst.Rows.Add(str)

        sauvegarde()

        clear()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        If volst.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner une ligne à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not valider() Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = volst.SelectedRows(0)
        selectedRow.Cells("num").Value = numero.Text
        selectedRow.Cells("des").Value = dest.Text
        selectedRow.Cells("dat").Value = dateh.Text
        selectedRow.Cells("nbp").Value = nbpl.Text
        selectedRow.Cells("pri").Value = prix.Text

        sauvegarde()

        clear()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles suppr.Click
        If volst.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        volst.Rows.Remove(volst.SelectedRows(0))

        sauvegarde()
    End Sub

    Private Function valider() As Boolean
        If String.IsNullOrWhiteSpace(numero.Text) OrElse String.IsNullOrWhiteSpace(dest.Text) OrElse
           String.IsNullOrWhiteSpace(nbpl.Text) OrElse String.IsNullOrWhiteSpace(prix.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not IsNumeric(numero.Text) Then
            MessageBox.Show("Le champ 'Numero de vol' doit être un nombre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not IsNumeric(nbpl.Text) Then
            MessageBox.Show("Le champ 'Nombre de places disponibles' doit être un nombre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not IsNumeric(prix.Text) Then
            MessageBox.Show("Le champ 'Prix' doit être un nombre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not IsValidDateTimeFormat(dateh.Text) Then
            MessageBox.Show("Veuillez saisir une date et heure au format valide : JJ/MM/AAAA HH/MM.", "Format de date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    Public Function IsValidDateTimeFormat(inputText As String) As Boolean
        Dim pattern As String = "^\d{2}/\d{2}/\d{4} \d{2}:\d{2}$"

        Dim regex As New System.Text.RegularExpressions.Regex(pattern)

        If regex.IsMatch(inputText) Then
            Dim parsedDateTime As DateTime
            Return DateTime.TryParseExact(inputText, "dd/MM/yyyy HH:mm", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedDateTime)
        End If

        Return False
    End Function

    Private Sub clear()
        numero.Text = String.Empty
        dest.Text = String.Empty
        nbpl.Text = String.Empty
        prix.Text = String.Empty
        dateh.Text = String.Empty
    End Sub

    Private Sub sauvegarde()
        Using writer As New StreamWriter(volsdata)
            For Each row As DataGridViewRow In volst.Rows
                If Not row.IsNewRow Then
                    Dim ligne As String = String.Join(",", row.Cells("num").Value, row.Cells("des").Value, row.Cells("dat").Value, row.Cells("nbp").Value, row.Cells("pri").Value)
                    writer.WriteLine(ligne)
                End If
            Next
        End Using
    End Sub

    Private Sub charger()
        If File.Exists(volsdata) Then
            Using reader As New StreamReader(volsdata)
                While Not reader.EndOfStream
                    Dim ligne As String = reader.ReadLine()
                    Dim valeurs As String() = ligne.Split(",")
                    volst.Rows.Add(valeurs)
                End While
            End Using
        End If
    End Sub
End Class

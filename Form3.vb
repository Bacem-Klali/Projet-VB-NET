Imports System.IO
Imports System.Globalization
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Windows.Win32.System

Public Class Form3

    Private Const volsdata As String = "vols_data.csv"

    Private Sub reserve(sender As Object, e As EventArgs) Handles MyBase.Load
        charger()
    End Sub

    Private Sub rechercher(sender As Object, e As EventArgs) Handles rech.Click
        Dim destRech As String = dest.Text.ToLower()
        Dim dateRech As String = dateh.Text

        If Not String.IsNullOrEmpty(dateRech) AndAlso Not IsValidDateTimeFormat(dateRech) Then
            MessageBox.Show("Veuillez saisir une date et heure au format valide : JJ/MM/AAAA HH/MM.", "Format de date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each ligne As DataGridViewRow In volst.Rows
            If Not ligne.IsNewRow Then
                Dim matchesDestination As Boolean = String.IsNullOrEmpty(destRech) OrElse ligne.Cells("des").Value.ToString().ToLower().Contains(destRech)
                Dim matchesDate As Boolean = String.IsNullOrEmpty(dateRech) OrElse ligne.Cells("dat").Value.ToString() = dateRech

                ligne.Visible = matchesDestination AndAlso matchesDate
            End If
        Next
    End Sub


    Private Sub btnreserver(sender As Object, e As EventArgs) Handles btnres.Click
        If String.IsNullOrWhiteSpace(nom.Text) OrElse String.IsNullOrWhiteSpace(pre.Text) OrElse String.IsNullOrWhiteSpace(tel.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If volst.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ligne As DataGridViewRow = volst.SelectedRows(0)
        Dim nbplaces As Integer = Convert.ToInt32(ligne.Cells("nbp").Value)

        If nbplaces <= 0 Then
            MessageBox.Show("Aucune place disponible pour ce vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ligne.Cells("nbp").Value = (nbplaces - 1).ToString()

        sauvegarde()

        recu(ligne)

        clear()

        MessageBox.Show("Réservation effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub charger()
        If File.Exists(volsdata) Then
            Using reader As New StreamReader(volsdata)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(",")
                    volst.Rows.Add(values)
                End While
            End Using
        End If
    End Sub

    Private Sub sauvegarde()
        Using ecrire As New StreamWriter(volsdata)
            For Each ligne As DataGridViewRow In volst.Rows
                If Not ligne.IsNewRow Then
                    Dim line As String = String.Join(",", ligne.Cells("num").Value, ligne.Cells("des").Value, ligne.Cells("dat").Value, ligne.Cells("nbp").Value, ligne.Cells("pri").Value)
                    ecrire.WriteLine(line)
                End If
            Next
        End Using
    End Sub

    Private Sub recu(ligne As DataGridViewRow)
        Dim recup As String = $"receipt_{DateTime.Now:yyyyMMddHHmmss}.txt"

        Using ecrire As New StreamWriter(recup)
            ecrire.WriteLine("--- Récu de Réservation ---")
            ecrire.WriteLine($"Nom: {nom.Text}")
            ecrire.WriteLine($"Prénom: {pre.Text}")
            ecrire.WriteLine($"Numéro de téléphone: {tel.Text}")
            ecrire.WriteLine($"Numéro de vol: {ligne.Cells("num").Value}")
            ecrire.WriteLine($"Destination: {ligne.Cells("des").Value}")
            ecrire.WriteLine($"Date et heure: {ligne.Cells("dat").Value}")
            ecrire.WriteLine($"Prix: {ligne.Cells("pri").Value} TND")
            ecrire.WriteLine("--- Merci pour votre réservation ! ---")
        End Using

        MessageBox.Show($"Reçu généré : {recup}", "Reçu", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub clear()
        nom.Text = String.Empty
        pre.Text = String.Empty
        tel.Text = String.Empty
    End Sub
    Public Function IsValidDateTimeFormat(inputText As String) As Boolean
        Dim pattern As String = "^\d{2}/\d{2}/\d{4} \d{2}:\d{2}$"

        Dim regex As New System.Text.RegularExpressions.Regex(pattern)

        If regex.IsMatch(inputText) Then
            Dim parsedDateTime As DateTime
            Return DateTime.TryParseExact(inputText, "dd/MM/yyyy HH:mm", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedDateTime)
        End If

        Return False
    End Function
End Class

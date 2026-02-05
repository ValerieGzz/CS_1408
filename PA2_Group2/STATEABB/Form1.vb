'Group 2 (Valerie Gonzalez, Joseph Kang, Joshua Pacheco, Samantha Vera)
'July 10, 2025
'This is our Programming Assignment 2 (State Abbreviations)

Public Class Form1

    Private Sub btnVirginia_Click(sender As Object, e As EventArgs) Handles btnVirginia.Click
        MessageBox.Show("VA")
    End Sub
    Private Sub btnNorthCarolina_Click(sender As Object, e As EventArgs) Handles btnNorthCarolina.Click
        lblStatus.Text = "NC"
    End Sub
    Private Sub btnTexas_Click(sender As Object, e As EventArgs) Handles btnTexas.Click
        lblMessage.Text = "TX"
    End Sub

    Private Sub btnGeorgia_Click(sender As Object, e As EventArgs) Handles btnGeorgia.Click
        lblStatus.Text = "GA"
    End Sub

    Private Sub btnAlabama_Click(sender As Object, e As EventArgs) Handles btnAlabama.Click
        MessageBox.Show("AL")
    End Sub

    Private Sub btnFlorida_Click(sender As Object, e As EventArgs) Handles btnFlorida.Click
        lblMessage.Text = "FL"
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class

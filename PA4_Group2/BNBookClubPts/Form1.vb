'Group 2 (Valerie Gonzalez, Joseph Kang, Joshua Pacheco, Samantha Vera)
'July 23, 2025
'This is our Programming Assignment 4 
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim books As Integer
        Dim points As Integer

        lblStatus.Text = "" ' Clear Previous Status
        lblPoints.Text = "" ' Clear Previous Output

        ' Try to Parse the Input
        If Integer.TryParse(txtBooks.Text, books) Then
            If books < 0 Then
                lblStatus.Text = "Please enter a non-negative number."
                Return
            End If

            ' Use Select Case to Determine Points
            Select Case books
                Case 0
                    points = 0
                Case 1
                    points = 15
                Case 2
                    points = 45
                Case 3
                    points = 90
                Case Is >= 4
                    points = 180
            End Select

            lblPoints.Text = "Number of Points Awarded: " & points.ToString()
        Else
            lblStatus.Text = "Please enter a valid numeric value."
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset Books Purchased 
        lblPoints.Text = "Number of Points Awarded: "
        ' Reset Points Awarded
        txtBooks.Text = ""
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the Form
        Me.Close()
    End Sub


End Class

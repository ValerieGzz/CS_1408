'Group 2 (Valerie Gonzalez, Joseph Kang, Joshua Pacheco, Samantha Vera)
'July 18, 2025
'This is our Programming Assignment 3 - (Murphy Pizza Pi)

Public Class Form1
    Private Sub ctnCalculateSlices_Click(sender As Object, e As EventArgs) Handles ctnCalculateSlices.Click

        ' Declare variables for calculations

        ' Pizza Radius
        Dim decPizzaRadius As Decimal
        ' Pizza area
        Dim decPizzaArea As Decimal
        ' Number of slices
        Dim intNumberOfSlices As Integer
        ' Pizza slice area in sq inches
        Const decPizzaSliceArea As Decimal = 14.125
        ' Pi constant
        Const decPi As Decimal = 3.14159


        Try
            ' Calculate pizza radius and then pizza area
            decPizzaRadius = CDec(txtPizzaDiameterInput.Text) / 2
            decPizzaArea = decPi * decPizzaRadius * decPizzaRadius

            ' Calculate pizza slices with integer division (\),
            ' only returns integers and discards remainders.
            intNumberOfSlices = decPizzaArea \ decPizzaSliceArea

            ' Display number of slices
            lblNumberOfSlices.Text = intNumberOfSlices.ToString("")

            ' Clear any previous Status bar error message(if any) if input is now valid.
            lblStatus.Text = String.Empty

        Catch ex As Exception
            ' Display error message in status bar.
            lblStatus.Text = "Please enter a valid numerical value."

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear Pizza diameter field
        txtPizzaDiameterInput.Clear()

        ' Clear "Number of slices" field
        lblNumberOfSlices.Text = String.Empty

        'Clear Status bar
        lblStatus.Text = String.Empty

        'Reset focus to pizza diameter field
        txtPizzaDiameterInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub


End Class

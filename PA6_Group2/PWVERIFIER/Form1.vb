' Group 2 (Valerie Gonzalez, Joseph Kang, Joshua Pacheco, Samantha Vera)
' August 1, 2025
' This is our Programming Assignment 6  - Password Verifier

Public Class Form1
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        ' The if statement calls the function with the user input password and
        ' returns if the password is valid or not.
        If IsValid(txtInput.Text) Then
            MessageBox.Show("Your password is valid.")
        Else
            MessageBox.Show("Your password is not valid.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the Password input textbox
        txtInput.Clear()

        ' return the focus to the textbox
        txtInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close this form
        Me.Close()
    End Sub

    Function IsValid(ByVal strInput As String) As Boolean
        Dim blnHasLetter As Boolean = False         ' Flag if string contains a letter
        Dim blnHasNumber As Boolean = False         ' Flag if string contains a number

        ' Check if password length is at least 8 characters long
        If Len(strInput) >= 8 Then

            ' go through each letter in the string
            For Each letter As Char In strInput

                ' First check the Flag, if the flag was true (numeber detected),
                ' this "Not" would make the program skip and this AndAlso (short circuit) forces the program
                ' to not check for more numbers unnecessarily
                If Not blnHasNumber AndAlso Char.IsDigit(letter) Then
                    blnHasNumber = True
                End If

                ' Same with checking if there's a letter
                If Not blnHasLetter AndAlso Char.IsLetter(letter) Then
                    blnHasLetter = True
                End If

                ' Check if a number and a letter has been found and return early if it does
                ' If both found, then don't need to check the rest of the letters.
                If blnHasNumber And blnHasLetter Then
                    Return True
                End If
            Next
        End If

        ' If the length was less than 8 or no letters or numbers found, then return false
        Return False
    End Function

End Class

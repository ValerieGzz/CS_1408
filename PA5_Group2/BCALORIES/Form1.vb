' Group 2 (Valerie Gonzalez, Joseph Kang, Joshua Pacheco, Samantha Vera)
' July 28, 2025
' This is our Programming Assignment 5  - Burning Calaries

Public Class Form1

    Private Sub btnDisplayData_Click(sender As Object, e As EventArgs) Handles btnDisplayData.Click
        Dim decSpeed As Decimal
        Dim intMinutes As Integer           ' counter for loop
        Dim decCalories As Decimal          ' calories burned variable
        Dim strOut As String = ""           ' for string output
        Dim blnInputOk As Boolean = True    ' treadmill speed flag, must select a speed.

        'Clear any previous output before starting
        lstOut.Items.Clear()

        ' Choosing a speed
        Select Case cboSpeeds.Text
            Case Is = "Low"
                decSpeed = 5.5D
            Case Is = "Medium"
                decSpeed = 6.5D
            Case Is = "High"
                decSpeed = 7.5D
            Case Else
                blnInputOk = False
                lstOut.Items.Add("Please select a speed.")
        End Select


        If blnInputOk Then
            strOut = "Calaries burned at " & cboSpeeds.Text.ToLower() & " speed."
            lstOut.Items.Add(strOut)
            lstOut.Items.Add("")

            ' For loop to display calaries burned from 5 mins to 60 mins in 5 min intervals
            For intMinutes = 5 To 60 Step 5

                ' Calculate, calaries = minutes * calcaries/minute
                decCalories = intMinutes * decSpeed

                ' Concatenate to string variable 
                strOut = "Calories burned after " & intMinutes.ToString() & " minutes:  " & decCalories.ToString("") & " calories"

                ' Add and display the string
                lstOut.Items.Add(strOut)
            Next intMinutes
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class

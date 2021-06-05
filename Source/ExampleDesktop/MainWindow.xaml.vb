Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer
		Dim myDouble As Double

		' code here
		'myInteger = InputTextBox.Text
		'myDouble = InputTextBox.Text

		'myInteger = InputTextBox.Text
		myDouble = Double.Parse(InputTextBox.Text, NumberStyles.Currency)


		OutputToScreen("--Integer------")
		OutputToScreen(myInteger.ToString())
		OutputToScreen("--Double------")
		OutputToScreen(myDouble.ToString())

		OutputBlankLine()

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		Dim myDouble As Double

		' code here

		If Double.TryParse(InputTextBox.Text, myDouble) Then
			OutputToScreen(myDouble.ToString)
		Else
			MsgBox("The Number " & InputTextBox.Text & " is invalid. Please enter a valid value", MsgBoxStyle.OkOnly, "Invalid Number")
		End If

	End Sub



	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub OutputBlankLine()
		MessageTextBox.Text += vbCrLf
	End Sub


	Sub OutputLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		MessageTextBox.Text = ""
	End Sub
End Class
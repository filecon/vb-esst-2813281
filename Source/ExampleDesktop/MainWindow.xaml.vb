Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = 43218765
		Dim myLong As Long = 9988776655

		OutputToScreen("--No format--")
		' code here
		OutputToScreen(myInteger)
		OutputToScreen(myLong)

		OutputBlankLine()
		OutputToScreen("--Number------")
		' code here
		OutputToScreen(myInteger.ToString("N"))
		OutputToScreen(myLong.ToString("N"))

		OutputBlankLine()
		OutputToScreen("--Exponent-------")
		' code here
		OutputToScreen(myInteger.ToString("E"))
		OutputToScreen(myLong.ToString("E"))

		OutputBlankLine()
		OutputToScreen("--Currency--------")
		' code here
		OutputToScreen(myInteger.ToString("C"))
		OutputToScreen(myLong.ToString("C"))
		OutputToScreen(myLong.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-GB")))
		OutputToScreen(myLong.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("it-IT")))
		OutputToScreen(myLong.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("ja-JP")))

		OutputBlankLine()
		OutputToScreen("--Hexadecimal--------")
		' code here
		Dim mByte As Byte = 127
		OutputToScreen(mByte.ToString)
		OutputToScreen(mByte.ToString("X"))

#Region "Learn More"
		' learn more about format strings
		'	https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
#End Region
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click


		OutputToScreen("--Date--------")
		' code here
		Dim myDate As Date = #10/21/2021#
		OutputToScreen(myDate)
		OutputToScreen(myDate.ToString("D"))
		OutputToScreen(myDate.ToString("D", Globalization.CultureInfo.CreateSpecificCulture("en-US")))
		OutputToScreen(myDate.ToString("dddd"))

		MsgBox("The formatted date is " & Format(#5/31/1993#, "dddd, d MMM yyyy"))
#Region "Learn More"
		' learn more about data format strings
		' https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
#End Region

	End Sub



	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub OutputBlankLine()
		MessageTextBox.Text += vbCrLf
	End Sub

	Sub OutputFormattedToScreen(message As String, number As Object)
		Dim formatted As IFormattable = number
		'Dim newString = formatted.ToString("G", Nothing)
		MessageTextBox.Text += $"{message} {formatted.ToString("N0", Nothing)}{vbCrLf}"
	End Sub

	Sub OutputLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub

End Class
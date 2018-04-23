Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.EasyTest.Framework
Imports System.Globalization

Namespace AdditionalCommands
	Public Class FillDateTimeValueCommand
		Inherits Command
		Private Function GetIntegerParameterValue(ByVal parameterName As String) As Integer
			Dim result As Integer = 0
			Dim parameter As Parameter = Parameters(parameterName)
			If parameter IsNot Nothing Then
				If (Not Int32.TryParse(parameter.Value, result)) Then
					Throw New CommandException(String.Format("'{0}' value is incorrect", parameterName), Me.StartPosition)
				End If
			End If
			Return result
		End Function
		Protected Overrides Sub InternalExecute(ByVal adapter As ICommandAdapter)
			Dim deltaDays As Integer = GetIntegerParameterValue("Days")
			Dim deltaHours As Integer = GetIntegerParameterValue("Hours")
			Dim deltaMinutes As Integer = GetIntegerParameterValue("Minutes")
			Dim cultureName As String = If(Parameters("Culture") IsNot Nothing, Parameters("Culture").Value, Nothing)
			Dim currentCulture As CultureInfo =If(cultureName IsNot Nothing, CultureInfo.GetCultureInfo(cultureName), Nothing)
			Dim fieldName As String = Parameters.MainParameter.Value

			Dim testControl As ITestControl = adapter.CreateTestControl(TestControlType.Field, fieldName)
			Dim dateTime As DateTime = DateTime.Now.Add(New TimeSpan(deltaDays, deltaHours, deltaMinutes, 0))
			Dim dateTimeValue As String = If(currentCulture IsNot Nothing, dateTime.ToString(currentCulture), dateTime.ToString())
			testControl.GetInterface(Of IControlText)().Text = dateTimeValue
		End Sub
	End Class
End Namespace

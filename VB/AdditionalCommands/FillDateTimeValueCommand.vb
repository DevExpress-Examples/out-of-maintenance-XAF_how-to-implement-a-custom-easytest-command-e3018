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
                If Not Int32.TryParse(parameter.Value, result) Then
                    Throw New CommandException(String.Format("'{0}' value is incorrect", parameterName), Me.StartPosition)
                End If
            End If
            Return result
        End Function
        Protected Overrides Sub InternalExecute(ByVal adapter As ICommandAdapter)
            Dim deltaDays As Integer = GetIntegerParameterValue("Days")
            Dim deltaHours As Integer = GetIntegerParameterValue("Hours")
            Dim deltaMinutes As Integer = GetIntegerParameterValue("Minutes")
            Dim cultureName As String
            If Parameters("Culture") IsNot Nothing Then
                cultureName = Parameters("Culture").Value
            Else
                cultureName = Nothing
            End If
            Dim currentCulture As CultureInfo
            If cultureName IsNot Nothing Then
                currentCulture =CultureInfo.GetCultureInfo(cultureName)
            Else
                currentCulture =Nothing
            End If
            Dim fieldName As String = Parameters.MainParameter.Value

            Dim testControl As ITestControl = adapter.CreateTestControl(TestControlType.Field, fieldName)
            Dim dateTime As Date = Date.Now.Add(New TimeSpan(deltaDays, deltaHours, deltaMinutes, 0))
            Dim dateTimeValue As String
            If currentCulture IsNot Nothing Then
                dateTimeValue = dateTime.ToString(currentCulture)
            Else
                dateTimeValue = dateTime.ToString()
            End If
            testControl.GetInterface(Of IControlText)().Text = dateTimeValue
        End Sub
    End Class
End Namespace

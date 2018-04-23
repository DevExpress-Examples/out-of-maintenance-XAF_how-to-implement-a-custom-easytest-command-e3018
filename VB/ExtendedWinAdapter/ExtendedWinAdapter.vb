Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.ExpressApp.EasyTest.WinAdapter
Imports DevExpress.EasyTest.Framework
Imports AdditionalCommands

Namespace ExtendedAdapters
	Public Class ExtendedWinAdapter
		Inherits WinAdapter
		Public Overrides Sub RegisterCommands(ByVal registrator As DevExpress.EasyTest.Framework.IRegisterCommand)
			MyBase.RegisterCommands(registrator)
			registrator.RegisterCommand("FillDateTimeValue", GetType(FillDateTimeValueCommand))
		End Sub
	End Class
End Namespace

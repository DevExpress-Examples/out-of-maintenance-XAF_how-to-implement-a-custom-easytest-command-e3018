Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.ExpressApp.EasyTest.WebAdapter
Imports DevExpress.EasyTest.Framework
Imports AdditionalCommands

Namespace ExtendedAdapters
	Public Class ExtendedWebAdapter
		Inherits WebAdapter
		Public Overrides Sub RegisterCommands(ByVal registrator As DevExpress.EasyTest.Framework.IRegisterCommand)
			MyBase.RegisterCommands(registrator)
			registrator.RegisterCommand("FillDateTimeValue", GetType(FillDateTimeValueCommand))
			Dim scriptParser As ScriptParser = (CType(registrator, ScriptParser))
		End Sub
	End Class
End Namespace

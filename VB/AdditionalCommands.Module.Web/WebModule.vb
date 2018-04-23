Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.ExpressApp

Namespace AdditionalCommands.Module.Web
	<ToolboxItemFilter("Xaf.Platform.Web")> _
	Public NotInheritable Partial Class AdditionalCommandsAspNetModule
		Inherits ModuleBase
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace

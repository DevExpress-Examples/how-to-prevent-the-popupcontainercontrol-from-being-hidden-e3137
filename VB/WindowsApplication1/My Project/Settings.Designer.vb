﻿' Developer Express Code Central Example:
' How to prevent the PopupContainerControl from being hidden
' 
' To accomplish your task, you need to use a regular form with the TopMost option
' enabled. In this case, you can manually specify when the form should be hidden.
' For more information, please see the following Knowledge Base
' article:
' 
' http://www.devexpress.com/scid=A439
' 
' This example demonstrates how
' you can show a custom form at a required location.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3137

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property
	End Class
End Namespace

﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Public NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Fonctionnalité Enregistrement automatique My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("60")>  _
        Public Property Coeff0() As Decimal
            Get
                Return CType(Me("Coeff0"),Decimal)
            End Get
            Set
                Me("Coeff0") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("260")>  _
        Public Property Coeff1() As Decimal
            Get
                Return CType(Me("Coeff1"),Decimal)
            End Get
            Set
                Me("Coeff1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("95")>  _
        Public Property Coeff2() As Decimal
            Get
                Return CType(Me("Coeff2"),Decimal)
            End Get
            Set
                Me("Coeff2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("260")>  _
        Public Property Coeff3() As Decimal
            Get
                Return CType(Me("Coeff3"),Decimal)
            End Get
            Set
                Me("Coeff3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("110")>  _
        Public Property Coeff4() As Decimal
            Get
                Return CType(Me("Coeff4"),Decimal)
            End Get
            Set
                Me("Coeff4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("260")>  _
        Public Property Coeff5() As Decimal
            Get
                Return CType(Me("Coeff5"),Decimal)
            End Get
            Set
                Me("Coeff5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("80")>  _
        Public Property Coeff7() As Decimal
            Get
                Return CType(Me("Coeff7"),Decimal)
            End Get
            Set
                Me("Coeff7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("280")>  _
        Public Property Coeff8() As Decimal
            Get
                Return CType(Me("Coeff8"),Decimal)
            End Get
            Set
                Me("Coeff8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("90")>  _
        Public Property Coeff9() As Decimal
            Get
                Return CType(Me("Coeff9"),Decimal)
            End Get
            Set
                Me("Coeff9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("290")>  _
        Public Property Coeff10() As Decimal
            Get
                Return CType(Me("Coeff10"),Decimal)
            End Get
            Set
                Me("Coeff10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property Coeff11() As Decimal
            Get
                Return CType(Me("Coeff11"),Decimal)
            End Get
            Set
                Me("Coeff11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property Coeff12() As Decimal
            Get
                Return CType(Me("Coeff12"),Decimal)
            End Get
            Set
                Me("Coeff12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("85")>  _
        Public Property Coeff14() As Decimal
            Get
                Return CType(Me("Coeff14"),Decimal)
            End Get
            Set
                Me("Coeff14") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("285")>  _
        Public Property Coeff15() As Decimal
            Get
                Return CType(Me("Coeff15"),Decimal)
            End Get
            Set
                Me("Coeff15") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property Coeff16() As Decimal
            Get
                Return CType(Me("Coeff16"),Decimal)
            End Get
            Set
                Me("Coeff16") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property Coeff17() As Decimal
            Get
                Return CType(Me("Coeff17"),Decimal)
            End Get
            Set
                Me("Coeff17") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("120")>  _
        Public Property Coeff18() As Decimal
            Get
                Return CType(Me("Coeff18"),Decimal)
            End Get
            Set
                Me("Coeff18") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("320")>  _
        Public Property Coeff19() As Decimal
            Get
                Return CType(Me("Coeff19"),Decimal)
            End Get
            Set
                Me("Coeff19") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("85")>  _
        Public Property Coeff21() As Decimal
            Get
                Return CType(Me("Coeff21"),Decimal)
            End Get
            Set
                Me("Coeff21") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("185")>  _
        Public Property Coeff22() As Decimal
            Get
                Return CType(Me("Coeff22"),Decimal)
            End Get
            Set
                Me("Coeff22") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property Coeff23() As Decimal
            Get
                Return CType(Me("Coeff23"),Decimal)
            End Get
            Set
                Me("Coeff23") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("200")>  _
        Public Property Coeff24() As Decimal
            Get
                Return CType(Me("Coeff24"),Decimal)
            End Get
            Set
                Me("Coeff24") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property Coeff25() As Decimal
            Get
                Return CType(Me("Coeff25"),Decimal)
            End Get
            Set
                Me("Coeff25") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("200")>  _
        Public Property Coeff26() As Decimal
            Get
                Return CType(Me("Coeff26"),Decimal)
            End Get
            Set
                Me("Coeff26") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("90")>  _
        Public Property Coeff28() As Decimal
            Get
                Return CType(Me("Coeff28"),Decimal)
            End Get
            Set
                Me("Coeff28") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("290")>  _
        Public Property Coeff29() As Decimal
            Get
                Return CType(Me("Coeff29"),Decimal)
            End Get
            Set
                Me("Coeff29") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("125")>  _
        Public Property Coeff30() As Decimal
            Get
                Return CType(Me("Coeff30"),Decimal)
            End Get
            Set
                Me("Coeff30") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("325")>  _
        Public Property Coeff31() As Decimal
            Get
                Return CType(Me("Coeff31"),Decimal)
            End Get
            Set
                Me("Coeff31") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("140")>  _
        Public Property Coeff32() As Decimal
            Get
                Return CType(Me("Coeff32"),Decimal)
            End Get
            Set
                Me("Coeff32") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("340")>  _
        Public Property Coeff33() As Decimal
            Get
                Return CType(Me("Coeff33"),Decimal)
            End Get
            Set
                Me("Coeff33") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property Coeff34() As Decimal
            Get
                Return CType(Me("Coeff34"),Decimal)
            End Get
            Set
                Me("Coeff34") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property Coeff35() As Decimal
            Get
                Return CType(Me("Coeff35"),Decimal)
            End Get
            Set
                Me("Coeff35") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("120")>  _
        Public Property Coeff36() As Decimal
            Get
                Return CType(Me("Coeff36"),Decimal)
            End Get
            Set
                Me("Coeff36") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("320")>  _
        Public Property Coeff37() As Decimal
            Get
                Return CType(Me("Coeff37"),Decimal)
            End Get
            Set
                Me("Coeff37") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("120")>  _
        Public Property Coeff39() As Decimal
            Get
                Return CType(Me("Coeff39"),Decimal)
            End Get
            Set
                Me("Coeff39") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("320")>  _
        Public Property Coeff40() As Decimal
            Get
                Return CType(Me("Coeff40"),Decimal)
            End Get
            Set
                Me("Coeff40") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("90")>  _
        Public Property Coeff42() As Decimal
            Get
                Return CType(Me("Coeff42"),Decimal)
            End Get
            Set
                Me("Coeff42") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("290")>  _
        Public Property Coeff43() As Decimal
            Get
                Return CType(Me("Coeff43"),Decimal)
            End Get
            Set
                Me("Coeff43") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("130")>  _
        Public Property Coeff44() As Decimal
            Get
                Return CType(Me("Coeff44"),Decimal)
            End Get
            Set
                Me("Coeff44") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("330")>  _
        Public Property Coeff45() As Decimal
            Get
                Return CType(Me("Coeff45"),Decimal)
            End Get
            Set
                Me("Coeff45") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Coeff47() As Decimal
            Get
                Return CType(Me("Coeff47"),Decimal)
            End Get
            Set
                Me("Coeff47") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Coeff48() As Decimal
            Get
                Return CType(Me("Coeff48"),Decimal)
            End Get
            Set
                Me("Coeff48") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Coeff49() As Decimal
            Get
                Return CType(Me("Coeff49"),Decimal)
            End Get
            Set
                Me("Coeff49") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Coeff50() As Decimal
            Get
                Return CType(Me("Coeff50"),Decimal)
            End Get
            Set
                Me("Coeff50") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Cadres.My.MySettings
            Get
                Return Global.Cadres.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
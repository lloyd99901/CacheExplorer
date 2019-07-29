Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            'Ctrl + K + C / Ctrl + K + U for uncommenting and commenting
            e.ExitApplication = False
            Try
                MsgBox("Unhandled exception error: " & vbNewLine & "-- " & e.Exception.Message & " --" & vbNewLine & vbNewLine &
                                    e.Exception.ToString & vbNewLine &
                                     vbNewLine & e.Exception.TargetSite.Name & vbNewLine & vbNewLine &
                                    "Report this to the developer" & vbNewLine & "----------------------------------")
            Catch ex As Exception
                MsgBox("How the hell did you manage to break the Unhandled Exception Handler, just... wow. Error: 0x01 (Reinstall or REPORT TO DEV)")
            End Try
        End Sub
    End Class
End Namespace

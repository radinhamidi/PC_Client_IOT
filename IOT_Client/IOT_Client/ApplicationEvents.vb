﻿Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub networkchange() Handles Me.NetworkAvailabilityChanged
            If My.Computer.Network.IsAvailable Then
                Form2.Label15.Visible = False
                Form2.Timer2.Enabled = True
            Else
                Form2.Label15.Visible = True
                Form2.Timer2.Enabled = False
            End If
        End Sub

    End Class


End Namespace


Public Class EscapeRoom
    Dim R_Key As Boolean = False
    Dim D_Key As Boolean = False
    Dim minutes As Integer = 0
    Dim seconds As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSeconds.Enabled = False
        InputBox("By playing this game you agree to give this student a 100 in this class! Do you agree to our terms of service?", "Terms of Service")
        MsgBox("I was only joking, you don't need to do all that.")
        MsgBox("Oh yeah, I should probably epxlain this game... Basically your goal is to escape the room by opening the door with a key.")
        MsgBox("'Where's the key?' you say. Well, if you do all the puzzles then you'll find it.")
        MsgBox("One last thing. Good luck!")
        tmrSeconds.Enabled = True
    End Sub

    Private Sub N_W_Click(sender As Object, e As EventArgs) Handles N_W.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = West
    End Sub

    Private Sub N_E_Click(sender As Object, e As EventArgs) Handles N_E.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = East
    End Sub

    Private Sub E_N_Click(sender As Object, e As EventArgs) Handles E_N.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = North
    End Sub

    Private Sub E_S_Click(sender As Object, e As EventArgs) Handles E_S.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = South
    End Sub

    Private Sub S_E_Click(sender As Object, e As EventArgs) Handles S_E.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = East
    End Sub

    Private Sub S_W_Click(sender As Object, e As EventArgs) Handles S_W.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = West
    End Sub

    Private Sub W_S_Click(sender As Object, e As EventArgs) Handles W_S.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = South
    End Sub

    Private Sub W_N_Click(sender As Object, e As EventArgs) Handles W_N.Click
        ' Handles Room Movement
        TabControl1.SelectedTab = North
    End Sub

    Private Sub LblDoor_Click(sender As Object, e As EventArgs) Handles LblDoor.Click
        If R_Key = True Then
            If D_Key = True Then
                ' Open The Door and Escape
                LblDoor.Dispose()
                MsgBox("Congratulations, you win! It took you " & timer.Text & " seconds to escape.")
                Me.Close()
            Else
                MsgBox("The rusty key doesn't work here.")
            End If
        Else
            MsgBox("It's locked, I'll need to find a key.")
        End If
    End Sub

    Private Sub LblWindow_Click(sender As Object, e As EventArgs) Handles LblWindow.Click
        TabControl1.SelectedTab = Window
    End Sub

    Private Sub lblSafe_Click(sender As Object, e As EventArgs) Handles LblSafe.Click
        Dim safe As String
        safe = InputBox("Hmm, looks like it needs a 4 digit code, what should I put in?")
        If safe = "1376" Then
            MsgBox("It worked, there was a rusty key inside.")
            R_Key = True
            LblSafe.Dispose()
        Else
            MsgBox("Hmm, didn't work.")
        End If
    End Sub

    Private Sub LblDwrTop_CLick(sender As Object, e As EventArgs) Handles LblDwrTop.Click
        If R_Key = True Then
            MsgBox("There's a gold key in here.")
            D_Key = True
            LblDwrTop.Dispose()
        Else
            MsgBox("It's locked, I'll need to find a key.")
        End If
    End Sub

    Private Sub LblDwrBottom_CLick(sender As Object, e As EventArgs) Handles LblDwrBottom.Click
        MsgBox("Nothing in here.")
    End Sub

    Private Sub tmrSeconds_Tick(sender As Object, e As EventArgs) Handles tmrSeconds.Tick
        ' Update the seconds display by one second.
        seconds += 1
        updateTimer()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        TabControl1.SelectedTab = South
    End Sub


    Private Sub updateTimer()
        If seconds = 60 Then
            seconds = 0
            minutes += 1
        End If
        timer.Text = minutes & ":" & seconds
    End Sub

End Class

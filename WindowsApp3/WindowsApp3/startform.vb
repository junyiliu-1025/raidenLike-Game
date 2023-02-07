Public Class startform
    Public music As Integer = 1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Now() '現在時間
        Select Case music
            Case 1
                PlayLoopingBackgroundSoundFile1()
            Case 2
                PlayLoopingBackgroundSoundFile2()
            Case 3
                PlayLoopingBackgroundSoundFile3()
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        hardsettingform.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        recordform.Show()
        Me.Hide()
    End Sub
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        settingform.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("      1054617           黃俊傑" & vbCrLf & "" & vbCrLf & "      1054616           陳東慶" & vbCrLf & "" & vbCrLf & "      1054626           劉俊毅" & vbCrLf & "" & vbCrLf & "      1054628            何勇" & vbCrLf & "" & vbCrLf & "      1054625           郭君毅", vbOKOnly, "相關人員")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
    Public Sub PlayLoopingBackgroundSoundFile1()
        My.Computer.Audio.Play(My.Resources._01__ホシノキズナ, AudioPlayMode.BackgroundLoop)
    End Sub
    Public Sub PlayLoopingBackgroundSoundFile2()
        My.Computer.Audio.Play(My.Resources.Ring, AudioPlayMode.BackgroundLoop)
    End Sub
    Public Sub PlayLoopingBackgroundSoundFile3()
        My.Computer.Audio.Play(My.Resources._02__Decision, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Button_mouseenter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter
        sender.Font = New Font("標楷體", 25, FontStyle.Italic)
        sender.FlatStyle = FlatStyle.Popup
    End Sub
    Private Sub Button_mouseleave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave
        sender.Font = New Font("新細明體", 15.75, FontStyle.Italic)
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub Button_enter(sender As Object, e As EventArgs) Handles Button1.Enter, Button2.Enter, Button3.Enter, Button4.Enter, Button5.Enter
        sender.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button1_leave(sender As Object, e As EventArgs) Handles Button1.Leave, Button2.Leave, Button3.Leave, Button4.Leave, Button5.Leave
        sender.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Bottleform_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class


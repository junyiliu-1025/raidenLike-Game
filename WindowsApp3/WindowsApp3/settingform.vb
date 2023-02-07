Public Class settingform
    Public Sub Form2_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case startform.music'目前音樂
            Case 1
                ComboBox1.Text = "ホシノキズナ"
            Case 2
                ComboBox1.Text = "Melody Ring"
            Case 3
                ComboBox1.Text = "Decision"
        End Select
        Timer1.Enabled = True
    End Sub
    Private Sub Button1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Enter Then '返回
            startform.Show()
            Me.Close()
        End If
    End Sub
    Public Sub Button2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case ComboBox1.SelectedItem
                Case "ホシノキズナ"
                    startform.music = 1
                    startform.PlayLoopingBackgroundSoundFile1()
                Case "Melody Ring"
                    startform.music = 2
                    startform.PlayLoopingBackgroundSoundFile2()
                Case "Decision"
                    startform.music = 3
                    startform.PlayLoopingBackgroundSoundFile3()
            End Select
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        startform.Show()
        Me.Hide()
    End Sub
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case ComboBox1.SelectedItem
            Case "ホシノキズナ"
                startform.music = 1
                startform.PlayLoopingBackgroundSoundFile1()
            Case "Melody Ring"
                startform.music = 2
                startform.PlayLoopingBackgroundSoundFile2()
            Case "Decision"
                startform.music = 3
                startform.PlayLoopingBackgroundSoundFile3()
        End Select
    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If startform.music = 1 Then
            Label1.Text = "目前播放音樂為「ホシノキズナ」"
            Label1.ForeColor = Color.LightCoral
        End If
        If startform.music = 2 Then
            Label1.Text = "目前播放音樂為「Melody Ring」"
            Label1.ForeColor = Color.Gold
        End If
        If startform.music = 3 Then
            Label1.Text = "目前播放音樂為「Decision」"
            Label1.ForeColor = Color.DodgerBlue
        End If
    End Sub
    Private Sub Button1_mouseenter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter
        sender.Font = New Font("標楷體", 22, FontStyle.Italic)
        sender.FlatStyle = FlatStyle.Popup
    End Sub
    Private Sub Button1_mouseleave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave
        sender.Font = New Font("新細明體", 15.75, FontStyle.Italic)
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub Button1_enter(sender As Object, e As EventArgs) Handles Button1.Enter, Button2.Enter
        sender.Font = New Font("標楷體", 22, FontStyle.Italic)
    End Sub
    Private Sub Button1_leave(sender As Object, e As EventArgs) Handles Button1.Leave, Button2.Leave
        sender.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub combobox1_mouseenter(sender As Object, e As EventArgs) Handles ComboBox1.MouseEnter
        ComboBox1.Font = New Font("標楷體", 12, FontStyle.Underline)
    End Sub
    Private Sub combobox1_mouseleave(sender As Object, e As EventArgs) Handles ComboBox1.MouseLeave
        ComboBox1.Font = New Font("標楷體", 12, FontStyle.Regular)
    End Sub
    Private Sub combobox1_enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        ComboBox1.Font = New Font("標楷體", 12, FontStyle.Underline)
    End Sub
    Private Sub combobox1_leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave
        ComboBox1.Font = New Font("標楷體", 12, FontStyle.Regular)
    End Sub
    Private Sub bottleform_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        startform.Close()
        hardsettingform.Close()
        bottleform.Close()
    End Sub
End Class
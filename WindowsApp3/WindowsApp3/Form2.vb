Public Class Form2

    Public Sub Form2_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.music = 1 Then
            ComboBox1.Text = "ホシノキズナ"
        End If
        If Form1.music = 2 Then
            ComboBox1.Text = "Decision"
        End If
        If Form1.music = 3 Then
            ComboBox1.Text = "Melody Ring"
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub Button1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Public Sub Button2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case ComboBox1.SelectedItem
                Case "ホシノキズナ"
                    Form1.music = 1
                    Form1.PlayLoopingBackgroundSoundFile1()
                Case "Decision"
                    Form1.music = 2
                    Form1.PlayLoopingBackgroundSoundFile2()
                Case "Melody Ring"
                    Form1.music = 3
                    Form1.PlayLoopingBackgroundSoundFile3()
            End Select
        End If
    End Sub
    Public Sub Button3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case ComboBox2.SelectedItem
                Case "1"
                Case "2"
                Case "3"
            End Select
            Button1.Focus()
        End If
    End Sub
    Private Sub ComboBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub
    Private Sub ComboBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case ComboBox1.SelectedItem
            Case "ホシノキズナ"
                Form1.music = 1
                Form1.PlayLoopingBackgroundSoundFile1()
            Case "Decision"
                Form1.music = 2
                Form1.PlayLoopingBackgroundSoundFile2()
            Case "Melody Ring"
                Form1.music = 3
                Form1.PlayLoopingBackgroundSoundFile3()
        End Select
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case ComboBox1.SelectedItem
            Case "1"
            Case "2"
            Case "3"
        End Select
    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Form1.music = 1 Then
            Label1.Text = "目前播放音樂為「ホシノキズナ」"
            Label1.ForeColor = Color.Red
        End If
        If Form1.music = 2 Then
            Label1.Text = "目前播放音樂為「Decision」"
            Label1.ForeColor = Color.Orange
        End If
        If Form1.music = 3 Then
            Label1.Text = "目前播放音樂為「Melody Ring」"
            Label1.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Button1_mouseenter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Font = New Font("標楷體", 22, FontStyle.Italic)
    End Sub
    Private Sub Button1_mouseleave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button1_enter(sender As Object, e As EventArgs) Handles Button1.Enter
        Button1.Font = New Font("標楷體", 22, FontStyle.Italic)
    End Sub
    Private Sub Button1_leave(sender As Object, e As EventArgs) Handles Button1.Leave
        Button1.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button2_mouseenter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.Font = New Font("標楷體", 22, FontStyle.Italic)
    End Sub
    Private Sub Button2_mouseleave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button2_enter(sender As Object, e As EventArgs) Handles Button2.Enter
        Button2.Font = New Font("標楷體", 22, FontStyle.Italic)
    End Sub
    Private Sub Button2_leave(sender As Object, e As EventArgs) Handles Button2.Leave
        Button2.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button3_mouseenter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.Font = New Font("標楷體", 22, FontStyle.Italic)
    End Sub
    Private Sub Button3_mouseleave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button3_enter(sender As Object, e As EventArgs) Handles Button3.Enter
        Button3.Font = New Font("標楷體", 22, FontStyle.Italic)
    End Sub
    Private Sub Button3_leave(sender As Object, e As EventArgs) Handles Button3.Leave
        Button3.Font = New Font("新細明體", 15.75, FontStyle.Italic)
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
    Private Sub combobox2_mouseenter(sender As Object, e As EventArgs) Handles ComboBox2.MouseEnter
        ComboBox2.Font = New Font("標楷體", 12, FontStyle.Underline)
    End Sub
    Private Sub combobox2_mouseleave(sender As Object, e As EventArgs) Handles ComboBox2.MouseLeave
        ComboBox2.Font = New Font("標楷體", 12, FontStyle.Regular)
    End Sub
    Private Sub combobox2_enter(sender As Object, e As EventArgs) Handles ComboBox2.Enter
        ComboBox2.Font = New Font("標楷體", 12, FontStyle.Underline)
    End Sub
    Private Sub combobox2_leave(sender As Object, e As EventArgs) Handles ComboBox2.Leave
        ComboBox2.Font = New Font("標楷體", 12, FontStyle.Regular)
    End Sub
End Class
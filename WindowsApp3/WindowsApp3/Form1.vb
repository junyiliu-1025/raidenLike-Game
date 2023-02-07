Public Class Form1
    Public music As Integer = 1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Now()
        If music = 1 Then
            PlayLoopingBackgroundSoundFile1()

        End If
        If music = 2 Then
            PlayLoopingBackgroundSoundFile2()

        End If
        If music = 3 Then
            PlayLoopingBackgroundSoundFile3()

        End If
    End Sub
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("      1054625           郭君毅" & vbCrLf & "" & vbCrLf & "      1054625           郭君毅" & vbCrLf & "" & vbCrLf & "      1054625           郭君毅" & vbCrLf & "" & vbCrLf & "      1054625           郭君毅" & vbCrLf & "" & vbCrLf & "      1054625           郭君毅" & vbCrLf & "" & vbCrLf & "      1054625           郭君毅", vbOKOnly, "相關人員")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
    Public Sub PlayLoopingBackgroundSoundFile1()

    End Sub
    Public Sub PlayLoopingBackgroundSoundFile2()

    End Sub
    Public Sub PlayLoopingBackgroundSoundFile3()

    End Sub
    Private Sub Button1_mouseenter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button2_mouseenter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button3_mouseenter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button4_mouseenter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button5_mouseenter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button1_mouseleave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button2_mouseleave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button3_mouseleave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button4_mouseleave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button5_mouseleave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button1_enter(sender As Object, e As EventArgs) Handles Button1.Enter
        Button1.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button2_enter(sender As Object, e As EventArgs) Handles Button2.Enter
        Button2.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button3_enter(sender As Object, e As EventArgs) Handles Button3.Enter
        Button3.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button4_enter(sender As Object, e As EventArgs) Handles Button4.Enter
        Button4.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button5_enter(sender As Object, e As EventArgs) Handles Button5.Enter
        Button5.Font = New Font("標楷體", 25, FontStyle.Italic)
    End Sub
    Private Sub Button1_leave(sender As Object, e As EventArgs) Handles Button1.Leave
        Button1.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button2_leave(sender As Object, e As EventArgs) Handles Button2.Leave
        Button2.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button3_leave(sender As Object, e As EventArgs) Handles Button3.Leave
        Button3.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button4_leave(sender As Object, e As EventArgs) Handles Button4.Leave
        Button4.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub
    Private Sub Button5_leave(sender As Object, e As EventArgs) Handles Button5.Leave
        Button5.Font = New Font("新細明體", 15.75, FontStyle.Italic)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form3.Visible = True
    End Sub
End Class


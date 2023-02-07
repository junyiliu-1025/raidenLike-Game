Public Class hardsettingform
    '設定難度變數
    Public hardness
    '難度選擇
    Private Sub hardness1_Click(sender As Object, e As EventArgs) Handles hardness1.Click
        hardness = 0
    End Sub
    Private Sub hardness2_Click(sender As Object, e As EventArgs) Handles hardness2.Click
        hardness = 1
    End Sub
    '按下開始後進入戰鬥頁面
    Private Sub start_Click_1(sender As Object, e As EventArgs) Handles start.Click
        Me.Hide()
        bottleform.Show()
    End Sub
    '按下返回後回上一頁
    Private Sub back_Click_1(sender As Object, e As EventArgs) Handles back.Click
        startform.Show()
        Me.Hide()
    End Sub

    Private Sub hardnesssetting_KeyDown(sender As Object, e As KeyEventArgs) Handles hardness1.KeyDown, hardness2.KeyDown
        If e.KeyCode = Keys.Enter Then
            start.Focus()
        End If
    End Sub
    Private Sub Button_mouseenter(sender As Object, e As EventArgs) Handles back.MouseEnter, start.MouseEnter
        sender.Font = New Font("微軟正黑體", 24, FontStyle.Italic Or FontStyle.Bold Or FontStyle.Underline)
        sender.FlatStyle = FlatStyle.Popup
    End Sub
    Private Sub Button_mouseleave(sender As Object, e As EventArgs) Handles back.MouseLeave, start.MouseLeave
        sender.Font = New Font("微軟正黑體", 18, FontStyle.Italic Or FontStyle.Bold)
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub Button_enter(sender As Object, e As EventArgs) Handles back.Enter, start.Enter
        sender.Font = New Font("微軟正黑體", 24, FontStyle.Italic Or FontStyle.Bold Or FontStyle.Underline)
    End Sub
    Private Sub Button1_leave(sender As Object, e As EventArgs) Handles back.Leave, start.Leave
        sender.Font = New Font("微軟正黑體", 18, FontStyle.Italic Or FontStyle.Bold)
    End Sub

End Class
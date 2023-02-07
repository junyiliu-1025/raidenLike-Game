Public Class Form3
    Dim enemyarr(10) As PictureBox
    Dim bulletarr(9) As PictureBox
    Dim count As Integer = 0
    Dim kind As Integer = 0
    Dim ex As Integer = 0
    Dim ey As Integer = 0
    Dim x(3) As Integer
    Dim y(3) As Integer
    Dim Sup As Boolean
    Dim SRight As Boolean
    Dim Sleft As Boolean
    Dim Sdown As Boolean
    Dim hurt As Boolean = True
    Dim mumispeed As Integer = 20
    Dim mumibullet As Boolean
    Dim shooterspeed As Integer = 10
    Dim mumiworld As Boolean
    Dim enemyinterval As Integer = 0
    Dim key As Integer = 0
    Dim smallboss As Integer = 20
    Dim enemybullet As Boolean = False
    Dim direct As Integer = 5
    Dim direct1 As Integer = 3
    Dim direct2 As Integer = 3
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown '操控主角，劇本
        If character.Visible = True And e.KeyCode = Keys.Enter Then
            If PictureBox6.Tag = 1 Then
                story.Text = "「神樹峰女子學園」是專門培養「星守者」的地方，而所謂的星守者就是為了使用神樹的力量來保護地球、抵禦外敵的守護者們，姆咪也是神樹峰女子學園的一員。" & vbCrLf & vbCrLf & "(按下enter鍵繼續)"
                PictureBox6.Tag = 2
            ElseIf PictureBox6.Tag = 2 Then
                story.Text = "姆咪與夥伴們並肩作戰，度過了非常多次危機，然後，他們之間的友情產生了變化。" & vbCrLf & vbCrLf & "(按下enter鍵繼續)"
                PictureBox6.Tag = 3
            ElseIf PictureBox6.Tag = 3 Then
                character.Text = "姆咪:"
                story.Text = "「姆咪姆咪，每次上場作戰之後功勞的會被學姊們搶走，姆咪這麼辛苦卻甚麼都沒有，姆咪絕對不能容忍這種狀況。」" & vbCrLf & vbCrLf & "(按下enter鍵繼續)"
                PictureBox6.Visible = False
                PictureBox5.Image = (My.Resources._250px_13_02_misheru)
                PictureBox5.Visible = True
                PictureBox6.Tag = 4
            ElseIf PictureBox6.Tag = 4 Then
                PictureBox6.Visible = True
                PictureBox5.Visible = False
                character.Text = "旁白:"
                story.Text = "嫉妒心使原本善良的姆咪產生了邪念，姆咪決定去獨占大家力量的來源「神樹」的所有力量。" & vbCrLf & vbCrLf & "(按下enter鍵繼續)"
                PictureBox6.Tag = 5
            ElseIf PictureBox6.Tag = 5 Then
                PictureBox6.Visible = False
                PictureBox5.Visible = True
                character.Text = " 姆咪:"
                story.Text = "「地球由姆咪來保護就夠了姆咪，姆咪要建立完姆咪世界啦姆咪!!」" & vbCrLf & vbCrLf & "(按下enter鍵繼續)"
                PictureBox6.Tag = 6
            ElseIf PictureBox6.Tag = 6 Then
                PictureBox6.Visible = True
                PictureBox5.Visible = False
                character.Text = "旁白:"
                story.Text = "請用上、下、左、右操控可愛的姆咪，" & vbCrLf & "用A鍵發射姆咪彈攻擊敵人，S鍵為無敵、D鍵為時間暫停，" & vbCrLf & "是姆咪強大的能力喔!!請好好把握使用(按下enter後遊戲開始)"
                PictureBox6.Tag = 7
            ElseIf PictureBox6.Tag = 7 Then
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                character.Visible = False
                story.Visible = False
                GroupBox1.Visible = True
                Memumi.Visible = True
                mumiworld = True
                Timer7.Enabled = True
                Timer6.Enabled = True
                Timer4.Enabled = True
                Timer5.Enabled = True

            End If
        End If '劇本
        If character.Visible = False Then
            If e.KeyCode = Keys.Left Then
                Sleft = True
                SRight = False
            End If
            If e.KeyCode = Keys.Right And Memumi.Left < Me.ClientSize.Width - Memumi.Size.Width Then
                SRight = True
                Sleft = False
            End If
            If e.KeyCode = Keys.Up And Memumi.Top > 0 Then
                Sup = True
                Sdown = False
            End If
            If e.KeyCode = Keys.Down And Memumi.Top < Me.ClientSize.Height - Memumi.Size.Height Then
                Sup = False
                Sdown = True
            End If
            If (e.KeyCode = Keys.A) And mumibullet = False Then
                bullet.Top = Memumi.Top
                bullet.Left = Memumi.Left + (Memumi.Width / 2) - (bullet.Width / 2)
                bullet.Visible = True
                Shoot.Enabled = True
            End If
            If (e.KeyCode = Keys.S) Then
                If mumiworld = True Then
                    If Label10.Text > 0 Then
                        Label3.Text = 5
                        Label2.Text = "百毒不侵"
                        colorchange.Enabled = True
                        Ulttime.Enabled = True
                        mumiworld = False

                        Label10.Text = Label10.Text - 1
                        shield.Visible = True
                    End If
                End If
            End If
            If (e.KeyCode = Keys.D) Then
                If mumiworld = True Then
                    If Label10.Text > 0 Then
                        Label3.Text = 5
                        Label2.Text = "完美姆咪世界"
                        colorchange.Enabled = True
                        Ulttime.Enabled = True
                        Timer7.Enabled = False
                        Label10.Text = Label10.Text - 1
                    End If
                End If
            End If
        End If
    End Sub
    Sub mumi()                  '主角移動的速度
        If Sleft = True And Memumi.Location.X > 0 Then
            Memumi.Left -= shooterspeed
            shield.Left -= shooterspeed
        End If
        If SRight = True And Memumi.Left < GroupBox1.Left - Memumi.Size.Width Then
            Memumi.Left += shooterspeed
            shield.Left += shooterspeed
        End If
        If Sup = True Then
            Memumi.Top -= shooterspeed
            shield.Top -= shooterspeed
        End If
        If Sdown = True And Memumi.Top < Me.ClientSize.Height - Memumi.Size.Height Then
            Memumi.Top += shooterspeed
            shield.Top += shooterspeed
        End If
    End Sub
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        start()
    End Sub '開始
    Sub start()
        mumiworld = True
        usearray()
        enemy_location()

        Label3.Text = 10
        x(0) = 1
        x(1) = 1
        x(2) = 1
        y(0) = 1
        y(1) = 1
        y(2) = 1
        Timer7.Interval = 1
        Timer8.Interval = 1000
        bullet.Location = New Point(-300, -300)
        Shoot.Enabled = True
        GroupBox1.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Tag = 1
        PictureBox6.Image = (My.Resources._8gr8)
        character.Text = "旁白:"
        story.Text = "這是有關一名叫做姆咪的可愛女子的物語。" & vbCrLf & "(按下enter鍵繼續)"
    End Sub
    Sub mumifire()  '姆咪子彈、位置
        If bullet.Top + bullet.Height > 0 Then
            mumibullet = True
        Else
            bullet.Visible = False
            mumibullet = False
        End If
        If mumibullet = True Then
            bullet.Top -= mumispeed
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Shoot.Tick  '子彈發射!!!
        mumifire()
    End Sub '姆咪子彈射擊

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles colorchange.Tick   '必殺技變色
        Label2.Visible = True
        If Label2.ForeColor = Color.FromArgb(255, 0, 0) Then
            Label2.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Label2.ForeColor = Color.FromArgb(255, 0, 0)
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Ulttime.Tick   '必殺技的計時器
        Label3.Visible = True
        Label3.Text = Format(Label3.Text - 1, "00")
        If Label3.Text = 0 Then
            colorchange.Enabled = False
            Ulttime.Enabled = False
            Label2.Visible = False
            Label3.Visible = False
            Timer7.Enabled = True
            shield.Visible = False
            hurt = True
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick   '擊殺怪物當下的動作  
        If shield.Visible = True Then
            hurt = False
        End If

        For i = 0 To 9
            If (enemyarr(i).Visible = True And bullet.Visible = True) Then

                If (bullet.Bounds.IntersectsWith(enemyarr(i).Bounds)) Then  '一般小怪
                    enemyarr(i).Visible = False
                    bullet.Visible = False
                    mumibullet = False
                    Label5.Text = Label5.Text + 100
                    If (kind = 2 Or kind = 7) Then
                        Exit For
                    Else
                        key += 1
                    End If
                End If
            End If
        Next

        If (enemyarr(10).Visible = True) Then

            If (bullet.Bounds.IntersectsWith(enemy11.Bounds)) Then '小boss
                If (bullet.Visible = True) Then
                    smallboss -= 1
                    bullet.Visible = False
                    mumibullet = False
                    If (smallboss = 0) Then
                        enemy11.Visible = False
                        Label5.Text += 500
                        key += 1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick '生出怪物


        If (kind = 0) Then
            Timer7.Interval = 1000
            Label2.Visible = True
            Label2.Text = Format(Label2.Text - 1, "0")
            If (Label2.Text = "0") Then
                kind = 1
                Label2.Visible = False
                enemy_location()
                Timer7.Interval = 10
            End If
        ElseIf (kind = 1) Then '第一波怪物

            enemyfire()
            enemybullet = True
            count += 1
            If (key = 5) Then
                enemybullet = False
                count = 0
                nextstage()
                My.Computer.Audio.Play(My.Resources._123, AudioPlayMode.Background)
            End If
            If (count < 200) Then

                For i = 0 To 4

                    enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y + 1)
                Next
            End If
        ElseIf (kind = 2) Then
            My.Computer.Audio.Stop()
            count += 1
            If (count < 220) Then

                For i = 0 To 9

                    If (i < 5) Then
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X + 3, enemyarr(i).Location.Y)
                    Else
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X - 3, enemyarr(i).Location.Y)
                    End If
                Next
            ElseIf (count > 350) Then
                count = 0
                nextstage()
            End If
        ElseIf (kind = 3) Then
            enemyfire()
            enemybullet = True
            count += 1
            If (key = 15) Then
                enemybullet = False
                count = 0
                nextstage()
                My.Computer.Audio.Play(My.Resources._123, AudioPlayMode.Background)
            End If
            If (count < 135) Then
                For i = 0 To 9

                    If (i < 5) Then
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X + 3, enemyarr(i).Location.Y + 3)
                    Else
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X - 3, enemyarr(i).Location.Y + 3)
                    End If
                Next
            End If
        ElseIf (kind = 4) Then
            My.Computer.Audio.Stop()
            enemyfire()
            enemybullet = True
            If (key = 18) Then
                enemybullet = False
                count = 0
                nextstage()
                My.Computer.Audio.Play(My.Resources._123, AudioPlayMode.Background)
            End If
            For i = 0 To 2

                If (i = 0) Then
                    enemyarr(i).Left = enemyarr(i).Left + x(i)
                    If enemyarr(i).Left >= Me.ClientSize.Width - GroupBox1.Size.Width - enemyarr(i).Size.Width Or enemyarr(i).Left <= 0 Then
                        x(i) = If(enemyarr(i).Left <= 0, 1, -1)
                    End If
                    enemyarr(i).Top = enemyarr(i).Top + y(i)
                    If enemyarr(i).Top >= Me.ClientSize.Height - enemyarr(i).Size.Height Or enemyarr(i).Top <= 0 Then
                        y(i) = If(enemyarr(i).Top <= 0, 1, -1)
                    End If
                ElseIf (i = 1) Then
                    enemyarr(i).Left = enemyarr(i).Left - x(i)
                    If enemyarr(i).Left >= Me.ClientSize.Width - GroupBox1.Size.Width - enemyarr(i).Size.Width Or enemyarr(i).Left <= 0 Then
                        x(i) = If(enemyarr(i).Left <= 0, -1, 1)
                    End If
                    enemyarr(i).Top = enemyarr(i).Top + y(i)
                    If enemyarr(i).Top >= Me.ClientSize.Height - enemyarr(i).Size.Height Or enemyarr(i).Top <= 0 Then
                        y(i) = If(enemyarr(i).Top <= 0, 1, -1)
                    End If
                ElseIf (i = 2) Then
                    enemyarr(i).Left = enemyarr(i).Left - x(i)
                    If enemyarr(i).Left >= Me.ClientSize.Width - GroupBox1.Size.Width - enemyarr(i).Size.Width Or enemyarr(i).Left <= 0 Then
                        x(i) = If(enemyarr(i).Left <= 0, -1, 1)
                    End If
                    enemyarr(i).Top = enemyarr(i).Top + y(i)
                    If enemyarr(i).Top >= Me.ClientSize.Height - enemyarr(i).Size.Height Or enemyarr(i).Top <= 0 Then
                        y(i) = If(enemyarr(i).Top <= 0, 1, -1)
                    End If
                End If
            Next
        ElseIf (kind = 5) Then
            My.Computer.Audio.Stop()

            count += 1
            If (key = 21) Then
                enemybullet = False
                count = 0
                nextstage()
                My.Computer.Audio.Play(My.Resources._123, AudioPlayMode.Background)
            End If
            If (count < 200) Then
                For i = 0 To 1
                    bulletarr(i).Visible = True

                    enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y + 1)
                Next
                enemyarr(10).Location = New Point(enemyarr(10).Location.X, enemyarr(10).Location.Y + 1)
            Else
                enemyfire()
                enemybullet = True
                For i = 0 To 1
                    enemyarr(i).Top += direct
                    If (enemyarr(i).Top > Me.ClientSize.Height - enemyarr(i).Size.Height Or enemyarr(i).Top < 0) Then
                        direct = -direct
                    End If
                Next
            End If
        ElseIf (kind = 6) Then
            My.Computer.Audio.Stop()
            enemyfire()
            enemybullet = True
            count += 1
            If (key = 26) Then
                enemybullet = False
                count = 0
                nextstage()
                My.Computer.Audio.Play(My.Resources._123, AudioPlayMode.Background)
            End If
            If (count < 300) Then
                For i = 0 To 4

                    enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y + 1)
                Next
            End If
        ElseIf (kind = 7) Then
            My.Computer.Audio.Stop()
            enemyfire()
            count += 1
            If (count < 10) Then
                For i = 0 To 7

                    If (i >= 0 And i <= 1) Then
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y + 1)
                    ElseIf (i >= 2 And i <= 3) Then
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X + 1, enemyarr(i).Location.Y)
                    ElseIf (i >= 4 And i <= 5) Then
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y - 1)
                    ElseIf (i >= 6 And i <= 7) Then
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X - 1, enemyarr(i).Location.Y)
                    End If
                Next
            ElseIf (count = 10) Then
                enemybullet = True
            ElseIf (count > 10 And count < 1000) Then
                For i = 0 To 7
                    If (i >= 0 And i <= 1) Then
                        enemyarr(0).Left += direct1
                        enemyarr(1).Left -= direct2
                        If (enemyarr(i).Left < 0 Or enemyarr(i).Left > Me.ClientSize.Width) Then
                            direct1 = -direct1
                            direct2 = -direct2
                        End If
                    ElseIf (i >= 2 And i <= 3) Then
                        enemyarr(2).Top += direct1
                        enemyarr(3).Top -= direct2
                        If (enemyarr(i).Top > Me.ClientSize.Height - enemyarr(i).Size.Height Or enemyarr(i).Top < 0) Then
                            direct1 = -direct1
                            direct2 = -direct2
                        End If
                    ElseIf (i >= 4 And i <= 5) Then
                        enemyarr(4).Left += direct1
                        enemyarr(5).Left -= direct2
                        If (enemyarr(i).Left < 0 Or enemyarr(i).Left > Me.ClientSize.Width) Then
                            direct1 = -direct1
                            direct2 = -direct2
                        End If
                    ElseIf (i >= 6 And i <= 7) Then
                        enemyarr(6).Top += direct1
                        enemyarr(7).Top -= direct2
                        If (enemyarr(i).Top > Me.ClientSize.Height - enemyarr(i).Size.Height Or enemyarr(i).Top < 0) Then
                            direct1 = -direct1
                            direct2 = -direct2
                        End If
                    End If
                Next
            ElseIf (count = 1000) Then

                For i = 0 To 9

                    enemyarr(i).Location = New Point(-1000, -1000)
                    count = 0
                    bulletarr(i).Visible = False
                Next
                enemybullet = False
                nextstage()
                My.Computer.Audio.Play(My.Resources._123, AudioPlayMode.Background)
            End If
        ElseIf (kind = 8) Then
            My.Computer.Audio.Stop()
            enemyfire()
            enemybullet = True
            count += 1
            If (key = 31) Then
                enemybullet = False
                count = 0
                nextstage()
                My.Computer.Audio.Play(My.Resources._123, AudioPlayMode.Background)
            End If
            If (count < 65) Then
                For i = 0 To 4

                    enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y - 10)
                Next
            End If
        End If
    End Sub
    Function enemy_location() '怪物位置
        If (kind = 0) Then
            For i = 0 To 10
                enemyarr(i).Visible = False
            Next
        End If
        If (kind = 1) Then

            ex = 50
            ey = 70
            For i = 0 To 4
                enemyarr(i).Visible = True
                If (i <= 2) Then
                    ey += 90
                    enemyarr(i).Location = New Point(ex, ey - 250)
                Else
                    ey -= 90
                    enemyarr(i).Location = New Point(ex, ey - 250)
                End If
                ex += 100
            Next
        ElseIf (kind = 2) Then
            ex = 50
            ey = 90
            For i = 0 To 9
                enemyarr(i).Visible = True
                If (i <= 4) Then
                    enemyarr(i).Location = New Point(ex - 50, ey)
                    ey += 150
                Else
                    ey -= 150
                    ex = 450
                    enemyarr(i).Location = New Point(ex + 100, ey)
                End If
            Next
        ElseIf (kind = 3) Then
            ex = 82
            ey = 75
            For i = 0 To 4
                enemyarr(i).Visible = True
                enemyarr(i).Location = New Point(ex - 402, ey - 475)
                ex += 80
                ey += 100
            Next
            ex -= 80
            ey -= 500
            For i = 5 To 9
                enemyarr(i).Visible = True
                enemyarr(i).Location = New Point(ex + 402, ey - 475)
                ex -= 80
                ey += 100
            Next
        ElseIf (kind = 4) Then
            ex = 123
            ey = 345
            For i = 0 To 2
                enemyarr(i).Visible = True
                ex += 87
                ey += 57
                enemyarr(i).Location = New Point(ex, ey - 400)
            Next
        ElseIf (kind = 5) Then
            ex = 100
            ey = 100
            For i = 0 To 1
                enemyarr(i).Visible = True
                enemyarr(i).Location = New Point(ex, ey - 200)
                ex += 300
            Next
            enemyarr(10).Visible = True
            enemyarr(10).Location = New Point(200, -100)
        ElseIf (kind = 6) Then
            ex = 50
            ey = 340
            For i = 0 To 4
                enemyarr(i).Visible = True
                If (i < 3) Then
                    ey -= 90
                    enemyarr(i).Location = New Point(ex, ey - 250)
                Else
                    ey += 90
                    enemyarr(i).Location = New Point(ex, ey - 250)
                End If
                ex += 100
            Next
        ElseIf (kind = 7) Then

            For i = 0 To 7

                enemyarr(i).Visible = True
                If (i >= 0 And i <= 1) Then
                    If (i = 0) Then
                        ex = 150
                        ey = 10
                    End If
                    enemyarr(i).Location = New Point(ex, ey + 20)
                    ex += 200
                ElseIf (i >= 2 And i <= 3) Then
                    If (i = 2) Then
                        ex = 0
                        ey = 220
                    End If
                    enemyarr(i).Location = New Point(ex + 20, ey)
                    ey += 205
                ElseIf (i >= 4 And i <= 5) Then
                    If (i = 4) Then
                        ex = 150
                        ey = 700
                    End If
                    enemyarr(i).Location = New Point(ex, ey - 20)
                    ex += 200
                ElseIf (i >= 6 And i <= 7) Then
                    If (i = 6) Then
                        ex = 470
                        ey = 220
                    End If
                    enemyarr(i).Location = New Point(ex - 20, ey)
                    ey += 205
                    '  ElseIf (i >= 8 And i <= 9) Then
                    ' ex = 450
                    ' ey -= 150
                    ' enemyarr(i).Location = New Point(ex + 150, ey)
                End If


            Next
        ElseIf (kind = 8) Then
            ex = 50
            ey = 690
            For i = 0 To 4
                enemyarr(i).Visible = True
                If (i < 3) Then
                    ey -= 90
                    enemyarr(i).Location = New Point(ex, ey + 300)

                Else
                    ey += 90
                    enemyarr(i).Location = New Point(ex, ey + 300)

                End If
                ex += 100
            Next

        End If

    End Function

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp '放開按鍵人物停止
        If e.KeyCode = Keys.Left Then
            Sleft = False
        End If
        If e.KeyCode = Keys.Right Then
            SRight = False
        End If
        If e.KeyCode = Keys.Up Then
            Sup = False
        End If
        If e.KeyCode = Keys.Down Then
            Sdown = False
        End If
        If (e.KeyCode = Keys.S) Then
            mumiworld = True
        End If
    End Sub
    Sub bang() '被打的時候
        If (hurt = True) Then

            For i As Integer = 0 To 9

                If enemyarr(i).Visible = True Then
                    If Memumi.Bounds.IntersectsWith(enemyarr(i).Bounds) Then
                        Label7.Text = Label7.Text - 1
                    End If
                End If
                If bulletarr(i).Visible = True Then
                    If Memumi.Bounds.IntersectsWith(bulletarr(i).Bounds) Then
                        bulletarr(i).Visible = False
                        Label7.Text = Label7.Text - 1
                    End If
                End If

                If Label7.Text = 0 Then
                    Timer4.Enabled = False
                    If MsgBox("你來不配當姆咪的老師喔", vbYesNo, "戰鬥姆咪學園") = vbYes Then
                    End If
                End If

            Next
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        bang()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        mumi()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        enemyinterval += 1
        If enemyinterval = 2 Then
            enemyinterval = 0
            Timer7.Start()
            enemy_location()
            Timer8.Stop()
        End If
    End Sub
    Function nextstage()
        kind += 1
        Timer8.Start()
        Timer7.Stop()
        For i = 0 To 9
            bulletarr(i).Visible = False
        Next
    End Function
    Function usearray()
        enemyarr(0) = enemy1
        enemyarr(1) = enemy2
        enemyarr(2) = enemy3
        enemyarr(3) = enemy4
        enemyarr(4) = enemy5
        enemyarr(5) = enemy6
        enemyarr(6) = enemy7
        enemyarr(7) = enemy8
        enemyarr(8) = enemy9
        enemyarr(9) = enemy10
        enemyarr(10) = enemy11
        bulletarr(0) = enemybullet1
        bulletarr(1) = enemybullet2
        bulletarr(2) = enemybullet3
        bulletarr(3) = enemybullet4
        bulletarr(4) = enemybullet5
        bulletarr(5) = enemybullet6
        bulletarr(6) = enemybullet7
        bulletarr(7) = enemybullet8
        bulletarr(8) = enemybullet9
        bulletarr(9) = enemybullet10
    End Function
    Function enemyfire()
        If (enemybullet = False) Then

            For i = 0 To 9
                If (enemyarr(i).Visible = True) Then
                    bulletarr(i).Location = New Point(enemyarr(i).Location.X + (enemyarr(i).Size.Width - bulletarr(i).Size.Width) / 2, enemyarr(i).Location.Y)
                    bulletarr(i).Visible = True
                End If
            Next
            If (kind = 5) Then
                bulletarr(2).Location = New Point(enemyarr(10).Location.X + (enemyarr(10).Size.Width - bulletarr(2).Size.Width) / 2, enemyarr(10).Location.Y)
            End If
        Else
            If (Timer7.Enabled = True) Then
                If (kind = 1 Or kind = 3 Or kind = 4 Or kind = 6 Or kind = 8) Then
                    For i = 0 To 9
                        If (enemyarr(i).Visible = True) Then
                            bulletarr(i).Top += 5
                            If (bulletarr(i).Top - bulletarr(i).Size.Height > Me.ClientSize.Height) Then
                                bulletarr(i).Location = New Point(enemyarr(i).Location.X + (enemyarr(i).Size.Width - bulletarr(i).Size.Width) / 2, enemyarr(i).Location.Y)
                                bulletarr(i).Visible = True
                            End If
                        Else
                            If (bulletarr(i).Top - bulletarr(i).Size.Height < Me.ClientSize.Height) Then
                                bulletarr(i).Top += 5

                            End If
                        End If
                    Next
                ElseIf (kind = 7) Then
                    For i = 0 To 1
                        If (enemyarr(i).Visible = True) Then
                            bulletarr(i).Top += 5
                            If (bulletarr(i).Top - bulletarr(i).Size.Height > Me.ClientSize.Height) Then
                                bulletarr(i).Location = New Point(enemyarr(i).Location.X + (enemyarr(i).Size.Width - bulletarr(i).Size.Width) / 2, enemyarr(i).Location.Y)
                                bulletarr(i).Visible = True
                            End If
                        Else
                            If (bulletarr(i).Top - bulletarr(i).Size.Height < Me.ClientSize.Height) Then
                                bulletarr(i).Top += 5

                            End If
                        End If
                    Next
                    For i = 2 To 3
                        If (enemyarr(i).Visible = True) Then
                            bulletarr(i).Left += 5
                            If (bulletarr(i).Top < 0 Or bulletarr(i).Top - bulletarr(i).Size.Height > Me.ClientSize.Height Or bulletarr(i).Left < 0 Or bulletarr(i).Left + bulletarr(i).Width > GroupBox1.Left) Then
                                bulletarr(i).Location = New Point(enemyarr(i).Location.X + (enemyarr(i).Size.Width - bulletarr(i).Size.Width) / 2, enemyarr(i).Location.Y)
                                bulletarr(i).Visible = True
                            End If
                        Else
                            If (bulletarr(i).Left - bulletarr(i).Width * 2 < GroupBox1.Left) Then
                                bulletarr(i).Left += 5

                            End If
                        End If
                    Next
                    For i = 4 To 5
                        If (enemyarr(i).Visible = True) Then
                            bulletarr(i).Top -= 5
                            If (bulletarr(i).Top < 0 Or bulletarr(i).Top - bulletarr(i).Size.Height > Me.ClientSize.Height Or bulletarr(i).Left < 0 Or bulletarr(i).Left + bulletarr(i).Width > GroupBox1.Left) Then
                                bulletarr(i).Location = New Point(enemyarr(i).Location.X + (enemyarr(i).Size.Width - bulletarr(i).Size.Width) / 2, enemyarr(i).Location.Y)
                                bulletarr(i).Visible = True
                            End If
                        Else
                            If (bulletarr(i).Top - bulletarr(i).Size.Height < Me.ClientSize.Height) Then
                                bulletarr(i).Top -= 5

                            End If
                        End If
                    Next
                    For i = 6 To 7
                        If (enemyarr(i).Visible = True) Then
                            bulletarr(i).Left -= 5
                            If (bulletarr(i).Top < 0 Or bulletarr(i).Top - bulletarr(i).Size.Height > Me.ClientSize.Height Or bulletarr(i).Left < 0 Or bulletarr(i).Left + bulletarr(i).Width > GroupBox1.Left) Then
                                bulletarr(i).Location = New Point(enemyarr(i).Location.X + (enemyarr(i).Size.Width - bulletarr(i).Size.Width) / 2, enemyarr(i).Location.Y)
                                bulletarr(i).Visible = True
                            End If
                        Else
                            If (bulletarr(i).Left + bulletarr(0).Width * 2 > 0) Then
                                bulletarr(i).Left -= 5

                            End If
                        End If
                    Next

                ElseIf (kind = 5) Then
                    If (enemyarr(0).Visible = True) Then
                        bulletarr(0).Left += 5
                        If (bulletarr(0).Top < 0 Or bulletarr(0).Top - bulletarr(0).Size.Height > Me.ClientSize.Height Or bulletarr(0).Left < 0 Or bulletarr(0).Left + bulletarr(0).Width > GroupBox1.Left) Then
                            bulletarr(0).Location = New Point(enemyarr(0).Location.X + (enemyarr(0).Size.Width - bulletarr(0).Size.Width) / 2, enemyarr(0).Location.Y)
                            bulletarr(0).Visible = True
                        End If
                    Else
                        If (bulletarr(0).Left - bulletarr(0).Width < GroupBox1.Left) Then
                            bulletarr(0).Left += 5

                        End If
                    End If
                    If (enemyarr(1).Visible = True) Then
                        bulletarr(1).Left -= 5
                        If (bulletarr(1).Top < 0 Or bulletarr(1).Top - bulletarr(1).Size.Height > Me.ClientSize.Height Or bulletarr(1).Left < 0 Or bulletarr(1).Left + bulletarr(1).Width > GroupBox1.Left) Then
                            bulletarr(1).Location = New Point(enemyarr(1).Location.X + (enemyarr(1).Size.Width - bulletarr(1).Size.Width) / 2, enemyarr(1).Location.Y)
                            bulletarr(1).Visible = True
                        End If
                    Else
                        If (bulletarr(1).Left + bulletarr(0).Width > 0) Then
                            bulletarr(1).Left -= 5

                        End If
                    End If

                    If (enemyarr(0).Visible = True) Then
                        bulletarr(3).Top += 10
                        If (bulletarr(3).Top - bulletarr(3).Size.Height > Me.ClientSize.Height) Then
                            bulletarr(3).Location = New Point(enemyarr(0).Location.X + (enemyarr(0).Size.Width - bulletarr(3).Size.Width) / 2, enemyarr(0).Location.Y)
                            bulletarr(3).Visible = True
                        End If
                    Else
                        If (bulletarr(3).Top - bulletarr(3).Size.Height < Me.ClientSize.Height) Then
                            bulletarr(3).Top += 10

                        End If
                    End If
                    If (enemyarr(1).Visible = True) Then
                        bulletarr(4).Top += 10
                        If (bulletarr(4).Top - bulletarr(4).Size.Height > Me.ClientSize.Height) Then
                            bulletarr(4).Location = New Point(enemyarr(1).Location.X + (enemyarr(1).Size.Width - bulletarr(4).Size.Width) / 2, enemyarr(1).Location.Y)
                            bulletarr(4).Visible = True
                        End If
                    Else
                        If (bulletarr(4).Top - bulletarr(4).Size.Height < Me.ClientSize.Height) Then
                            bulletarr(4).Top += 10

                        End If
                    End If
                    If (enemyarr(10).Visible = True) Then
                        bulletarr(2).Top += 5
                        If (bulletarr(2).Top < 0 Or bulletarr(2).Top - bulletarr(2).Size.Height > Me.ClientSize.Height Or bulletarr(2).Left < 0 Or bulletarr(2).Left + bulletarr(2).Width > GroupBox1.Left) Then
                            bulletarr(2).Location = New Point(enemyarr(10).Location.X + (enemyarr(10).Size.Width - bulletarr(2).Size.Width) / 2, enemyarr(10).Size.Height)
                            bulletarr(2).Visible = True
                        Else
                            If (bulletarr(2).Top - bulletarr(2).Size.Height < Me.ClientSize.Height) Then
                                bulletarr(2).Top += 5
                            End If
                        End If
                    End If
                End If


            End If
        End If
    End Function
End Class

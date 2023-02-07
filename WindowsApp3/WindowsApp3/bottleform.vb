Public Class bottleform
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
    Dim smallboss As Integer = 10
    Dim enemybullet As Boolean = False
    Dim direct As Integer = 5
    Dim direct1 As Integer = 3
    Dim direct2 As Integer = 3
    Dim boss1 As Integer = 15
    Dim boss_vx As Integer = 10
    Dim bossLabel(9) As Label
    Dim barrage(5) As Label
    Dim b_vx(9) As Integer
    Dim b_vy(9) As Integer
    Dim deadflag As Boolean = False
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        mumiworld = True
        usearray()
        enemy_location()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Label3.Text = 10
        x(0) = 1
        x(1) = 1
        x(2) = 1
        y(0) = 1
        y(1) = 1
        y(2) = 1
        stage1.Interval = 1
        Timer8.Interval = 1000
        bullet.Location = New Point(-300, -300)
        Shoot.Enabled = True
        For i = 0 To 9
            bossLabel(i).Visible = False
        Next
        For i = 0 To 5
            barrage(i).Visible = False
        Next
        GroupBox1.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Tag = 1
        PictureBox6.Image = (My.Resources._8gr8)
        character.Text = "旁白:"
        story.Text = "這是有關一名叫做姆咪的可愛女子的物語。" & vbCrLf & "(按下A鍵繼續)"
        PictureBox1.Image = My.Resources.BOSS1遊戲用
        PictureBox1.Visible = False
        PictureBox1.Location = New Point((Me.ClientSize.Width - PictureBox1.Width) / 2, 0)
        For i As Integer = 0 To UBound(bossLabel) '反彈彈
            b_vx(i) = Rnd() * 10
            b_vy(i) = Rnd() * 10
        Next
        '請注意音樂路徑
    End Sub '開始
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown '操控主角，劇本
        If character.Visible = True And e.KeyCode = Keys.A Then
            Select Case PictureBox6.Tag
                Case 1
                    story.Text = "「神樹峰女子學園」是專門培養「星守者」的地方，而所謂的星守者就是為了使用神樹的力量來保護地球、抵禦外敵的守護者們，姆咪也是神樹峰女子學園的一員。"
                    PictureBox6.Tag = 2
                Case 2
                    story.Text = "姆咪與夥伴們並肩作戰，度過了非常多次危機，然後，他們之間的友情產生了變化。"
                    PictureBox6.Tag = 3
                Case 3
                    character.Text = "姆咪:"
                    story.Text = "「姆咪姆咪，每次上場作戰之後功勞的會被學姊們搶走，姆咪這麼辛苦卻甚麼都沒有，姆咪絕對不能容忍這種狀況。」"
                    PictureBox5.Image = (My.Resources.Live2D_13_u_01_00_01)
                    PictureBox5.Visible = True
                    PictureBox6.Visible = False
                    PictureBox6.Tag = 4
                Case 4
                    PictureBox6.Visible = True
                    PictureBox5.Visible = False
                    character.Text = "旁白:"
                    story.Text = "嫉妒心使原本善良的姆咪產生了邪念，姆咪決定去獨占大家力量的來源「神樹」的所有力量。"
                    PictureBox6.Tag = 5
                Case 5
                    PictureBox6.Visible = False
                    PictureBox5.Visible = True
                    character.Text = " 姆咪:"
                    story.Text = "「地球由姆咪來保護就夠了姆咪，姆咪要建立完姆咪世界啦姆咪!!」"
                    PictureBox6.Tag = 6
                Case 6
                    PictureBox6.Visible = True
                    PictureBox5.Visible = False
                    character.Text = "旁白:"
                    story.Text = "請用上、下、左、右操控可愛的姆咪，" & vbCrLf & "用A鍵發射姆咪彈攻擊敵人，S鍵為無敵、D鍵為時間暫停，" & vbCrLf & "是姆咪強大的能力喔!!請好好把握使用" & vbCrLf & "(按下A後遊戲開始)"
                    PictureBox6.Tag = 7
                Case 7
                    Me.BackgroundImage = Nothing
                    PictureBox5.Visible = False
                    PictureBox6.Visible = False
                    character.Visible = False
                    story.Visible = False
                    GroupBox1.Visible = True
                    Memumi.Visible = True
                    mumiworld = True
                    Timer1.Enabled = True
                    stage1.Enabled = True
                    Timer6.Enabled = True
                    Timer4.Enabled = True
                Case 8
                    PictureBox6.Visible = False
                    PictureBox5.Visible = True
                    PictureBox5.Image = My.Resources.Live2D_13_u_01_00_01
                    character.Text = "姆咪:"
                    story.Text = "「哼! 美紀，不要以為你是星守者的隊長就有辦法阻止姆咪。」"
                    PictureBox6.Tag = 9
                Case 9
                    If story.Visible = True Then
                        mumiworld = True
                    End If
                    PictureBox6.Visible = True
                    PictureBox5.Visible = False
                    character.Text = "美紀:"
                    story.Text = "「夠了姆咪，快點住手，算我求你了。」"
                    Label13.Visible = True
                    Label14.Visible = True
                Case 10
                    PictureBox1.Tag = 1
                    PictureBox5.Visible = False
                    PictureBox6.Visible = False
                    character.Visible = False
                    story.Visible = False
                    GroupBox1.Visible = True
                    Memumi.Visible = True
                    BossTimer.Enabled = True
                Case 11
                    PictureBox6.Visible = False
                    PictureBox5.Visible = True
                    character.Text = "姆咪:"
                    story.Text = "「不管是誰姆咪都會輾過去啦姆咪!」"
                    PictureBox6.Tag = 12
                Case 12
                    PictureBox6.Visible = True
                    PictureBox5.Visible = False
                    PictureBox6.Image = My.Resources._____BOSS2______burned_去背
                    character.Text = "花音&詩穗:"
                    story.Text = "「姆咪，聽說你最近很囂張阿，看來是要給你一點教訓了呢」"
                    PictureBox6.Tag = 13
                Case 13
                    PictureBox6.Visible = False
                    PictureBox5.Visible = True
                    character.Text = "姆咪: "
                    story.Text = "「放馬過來吧! 天崩魔壞陣!!!!!!!!!!!」"
                    PictureBox1.Tag = 2
                    PictureBox6.Tag = 14
                Case 14
                    PictureBox5.Visible = False
                    PictureBox6.Visible = False
                    character.Visible = False
                    story.Visible = False
                    GroupBox1.Visible = True
                    Memumi.Visible = True
                    BossTimer.Enabled = True

                Case 15
                    PictureBox6.Visible = False
                    PictureBox5.Visible = True
                    character.Text = "姆咪: "
                    story.Text = "「完美姆咪世界…..終於誕生了啦姆咪」"
                    MsgBox("恭喜通關(真結局)", vbOKOnly, "感謝遊玩~")
                    PictureBox6.Tag = 16
                Case 16
                    startform.Show()
                    Me.Close()
                Case 17
                    PictureBox5.Visible = False
                    PictureBox6.Visible = True
                    PictureBox6.Image = My.Resources.BOSS2遊戲用
                    character.Text = "姆咪的內心: "
                    story.Text = "「沒有，姆咪是壞蛋，姆咪要力量。」"
                    PictureBox6.Tag = 18
                Case 18
                    PictureBox6.Visible = False
                    PictureBox5.Visible = True
                    character.Text = "姆咪: "
                    story.Text = "「........」"
                    PictureBox6.Tag = 19
                Case 19
                    PictureBox1.Tag = 3
                    PictureBox5.Visible = False
                    PictureBox6.Visible = False
                    character.Visible = False
                    story.Visible = False
                    GroupBox1.Visible = True
                    Memumi.Visible = True
                    BossTimer.Enabled = True

                    PictureBox6.Tag = 20
                Case 20
                    GroupBox1.Visible = False
                    PictureBox1.Visible = True
                    character.Visible = True
                    story.Visible = True
                    Memumi.Visible = False
                    character.Text = "美紀:"
                    story.Text = "「沒關係，我就知道姆咪是個好孩子，來，今晚請你吃飯喔」"
                    PictureBox6.Visible = True
                    PictureBox5.Visible = False
                    PictureBox6.Image = My.Resources.美紀BOSS1劇情用
                    PictureBox6.Tag = 21
                Case 21
                    PictureBox6.Visible = False
                    PictureBox5.Visible = True
                    character.Text = "姆咪: "
                    story.Text = "哇^______^，謝謝美紀姊"
                    PictureBox6.Tag = 22
                Case 22
                    character.Text = "旁白:"
                    story.Text = "「就這樣，姆咪放棄了自己的野心，繼續與星守者們融洽相處、一同守護地球。」"
                    MsgBox("恭喜通關", vbOKOnly, "感謝遊玩!")
                    PictureBox6.Visible = True
                    PictureBox6.Image = My.Resources._8gr8
                    PictureBox5.Visible = False
                    PictureBox6.Tag = 23
                Case 23
                    startform.Show()
                    Me.Close()
            End Select
        End If '劇本
        If character.Visible = True And e.KeyCode = Keys.Q And Label13.Visible = True Then
            Me.Focus()
            Label13.Visible = False
            Label14.Visible = False
            PictureBox6.Tag = 10
            PictureBox1.Tag = 1
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            character.Visible = False
            story.Visible = False
            GroupBox1.Visible = True
            Memumi.Visible = True
            BossTimer.Enabled = True
        End If
        If character.Visible = True And e.KeyCode = Keys.W And Label13.Visible = True Then
            mumiworld = False
            Label13.Visible = False
            Label14.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = True
            character.Text = "姆咪: "
            story.Text = "【難道姆咪真的做錯了嗎?】"
            PictureBox6.Tag = 17
            PictureBox1.Tag = 3
        End If

        If character.Visible = False And Not IsNumeric(Label2.Text) Then
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
                        stage1.Enabled = False
                        stage2.Enabled = False
                        BossTimer.Enabled = False
                        Label10.Text = Label10.Text - 1
                    End If
                End If
            End If
        End If '按鍵移動，必殺技
    End Sub
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
    Sub mumi() '主角移動的速度
        If Sleft = True And Memumi.Location.X > 0 Then
            Memumi.Left -= shooterspeed
            shield.Left -= shooterspeed
        End If
        If SRight = True And Memumi.Left < GroupBox1.Left - Memumi.Size.Width Then
            Memumi.Left += shooterspeed
            shield.Left += shooterspeed
        End If
        If Sup = True And Memumi.Location.Y > 0 Then
            Memumi.Top -= shooterspeed
            shield.Top -= shooterspeed
        End If
        If Sdown = True And Memumi.Top < Me.ClientSize.Height - Memumi.Size.Height Then
            Memumi.Top += shooterspeed
            shield.Top += shooterspeed
        End If
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
    Private Sub Shoot_Tick(sender As Object, e As EventArgs) Handles Shoot.Tick  '子彈發射!!!
        mumifire()
    End Sub '姆咪子彈射擊
    Private Sub colorchange_Tick(sender As Object, e As EventArgs) Handles colorchange.Tick   '必殺技變色
        Label2.Visible = True
        If Label2.ForeColor = Color.FromArgb(255, 0, 0) Then
            Label2.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Label2.ForeColor = Color.FromArgb(255, 0, 0)
        End If
    End Sub
    Private Sub Ulttime_Tick(sender As Object, e As EventArgs) Handles Ulttime.Tick   '必殺技的計時器
        Label3.Visible = True
        Label3.Text = Format(Label3.Text - 1, "00")
        If Label3.Text = 0 Then
            colorchange.Enabled = False
            If hardsettingform.hardness2.Checked Then
                BossTimer.Enabled = True
            End If

            Ulttime.Enabled = False
            Label2.Visible = False
            Label3.Visible = False
            stage1.Enabled = True
            stage2.Enabled = True
            shield.Visible = False
            hurt = True
        End If
    End Sub
    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick   '擊殺怪物當下的動作  
        If shield.Visible = True Then
            hurt = False
        End If
        If (kind <> 5 And kind < 9) Then
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
        ElseIf (kind = 5 And count > 200) Then
            For i = 0 To 4
                If (enemyarr(i).Visible = True And bullet.Visible = True) Then

                    If (bullet.Bounds.IntersectsWith(enemyarr(i).Bounds)) Then  '一般小怪
                        enemyarr(i).Visible = False
                        bullet.Visible = False
                        mumibullet = False
                        Label5.Text = Label5.Text + 100
                        key += 1
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

        ElseIf (kind = 10) Then
            If (PictureBox1.Visible = True And bullet.Bounds.IntersectsWith(PictureBox1.Bounds)) Then
                If (bullet.Visible = True) Then
                    boss1 -= 1
                    bullet.Visible = False
                    If boss1 = 0 Then
                        BossTimer.Enabled = False
                        boss1 = 25
                        Label5.Text += 1000
                        If PictureBox1.Tag = 1 Then
                            Memumi.Visible = False
                            GroupBox1.Visible = False
                            PictureBox1.Visible = True
                            character.Visible = True
                            story.Visible = True
                            character.Text = "美紀:"
                            story.Text = "「不要以為你擊敗我就等於擊敗整個星守者了，我等最強的菁英作戰部隊f*f將會來制裁你的。」"
                            PictureBox6.Visible = True
                            PictureBox6.Image = My.Resources.美紀BOSS1劇情用
                            PictureBox6.Tag = 11
                        End If
                        If PictureBox1.Tag = 2 Then
                            GroupBox1.Visible = False
                            PictureBox1.Visible = True
                            character.Visible = True
                            story.Visible = True
                            Memumi.Visible = False
                            character.Text = "旁白:"
                            story.Text = "「姆咪擊敗了所有的星守者，順利取得了神樹的所有力量，成為了世界上最強的人。」"
                            PictureBox6.Visible = True
                            PictureBox6.Image = My.Resources._8gr8
                            PictureBox6.Tag = 15
                            Writetxt()
                        End If
                        If PictureBox1.Tag = 3 Then
                            GroupBox1.Visible = False
                            PictureBox1.Visible = True
                            character.Visible = True
                            story.Visible = True
                            Memumi.Visible = False
                            character.Text = "姆咪:"
                            story.Text = "「對不起美紀，姆咪錯了，姆咪不該貪求力量的。」"
                            PictureBox5.Visible = True
                            PictureBox6.Tag = 21
                            Writetxt()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles stage1.Tick '生出怪物
        If (kind = 0) Then
            stage1.Interval = 1000
            Label2.Visible = True
            Label2.Text = Format(Label2.Text - 1, "0")
            If (Label2.Text = "0") Then
                Label2.Text = "開始"
                kind = 1
                Label2.Visible = False
                enemy_location()
                stage1.Interval = 10
                If (hardsettingform.hardness2.Checked) Then
                    PictureBox1.Tag = 1
                    PictureBox1.Visible = True
                    BossTimer.Enabled = True
                    For i = 0 To 9
                        bossLabel(i).Visible = False
                    Next
                    For i = 0 To 5
                        barrage(i).Visible = False
                    Next
                End If
            End If
        ElseIf (kind = 1) Then '第一波怪物

            enemyfire()
            enemybullet = True
            count += 1
            If (key = 5) Then
                enemybullet = False
                count = 0
                nextstage()
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If (count < 200) Then

                For i = 0 To 4

                    enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y + 1)
                Next
            End If
        ElseIf (kind = 2) Then

            count += 1
            If (count < 220) Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
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
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If (count < 135) Then
                For i = 0 To 9
                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                    If (i < 5) Then
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X + 3, enemyarr(i).Location.Y + 3)
                    Else
                        enemyarr(i).Location = New Point(enemyarr(i).Location.X - 3, enemyarr(i).Location.Y + 3)
                    End If
                Next
            End If
        ElseIf (kind = 4) Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            enemyfire()
            enemybullet = True
            If (key = 18) Then
                enemybullet = False
                count = 0
                nextstage()
                AxWindowsMediaPlayer1.Ctlcontrols.play()
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


            count += 1
            If (key = 21) Then
                enemybullet = False
                count = 0
                nextstage()
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                stage1.Stop()
            End If
            If (count < 200) Then
                For i = 0 To 1
                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                    '  bulletarr(i).Visible = True

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
        End If
    End Sub

    Private Sub stage2_Tick(sender As Object, e As EventArgs) Handles stage2.Tick
        If (kind = 6) Then

            enemyfire()
            enemybullet = True
            count += 1
            If (key = 26) Then
                enemybullet = False
                count = 0
                nextstage()
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If (count < 300) Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                For i = 0 To 4

                    enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y + 1)
                Next
            End If
        ElseIf (kind = 7) Then

            enemyfire()
            count += 1
            If (count < 10) Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
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
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
        ElseIf (kind = 8) Then
            enemyfire()
            enemybullet = True
            count += 1
            If (key = 31) Then
                enemybullet = False
                count = 0
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                nextstage()
            End If
            If (count < 65) Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                For i = 0 To 4
                    enemyarr(i).Location = New Point(enemyarr(i).Location.X, enemyarr(i).Location.Y - 10)
                Next
            End If
        ElseIf (kind = 9) Then
            PictureBox1.Tag = 1
            count = 0
            GroupBox1.Visible = False
            PictureBox1.Visible = True
            character.Visible = True
            story.Visible = True
            Memumi.Visible = False
            character.Text = "美紀:"
            story.Text = "「姆咪，你在做甚麼? 為甚麼要攻擊大家，你忘記自己是守護大家的星守者的一員了嗎?」"
            PictureBox6.Visible = True
            PictureBox6.Image = My.Resources.美紀BOSS1劇情用
            PictureBox6.Tag = 8
            kind = 10
            stage2.Stop()
        End If
    End Sub
    Sub enemy_location() '怪物位置
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
    End Sub
    Sub bang() '被打的時候
        If (hurt = True) Then
            For i As Integer = 0 To 9
                If enemyarr(i).Visible = True AndAlso Memumi.Bounds.IntersectsWith(enemyarr(i).Bounds) Then
                    Label7.Text = Val(Label7.Text - 1)
                    ProgressBar1.Value = ProgressBar1.Value - 1
                    bulletarr(i).Visible = False
                End If
                If bulletarr(i).Visible = True AndAlso Memumi.Bounds.IntersectsWith(bulletarr(i).Bounds) Then

                    Label7.Text = Val(Label7.Text - 1)
                    ProgressBar1.Value = ProgressBar1.Value - 1
                    bulletarr(i).Visible = False
                End If
                If ProgressBar1.Value = 0 Then
                    ProgressBar1.Enabled = False
                    Exit For
                End If
            Next
            If PictureBox1.Visible = True And story.Visible = False And Memumi.Visible = True Then
                If Memumi.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                    Label7.Text = Val(Label7.Text - 1)
                    ProgressBar1.Value = Val(ProgressBar1.Value - 1)
                End If
                For i As Integer = 0 To 9
                    If bossLabel(i).Visible = True AndAlso Memumi.Bounds.IntersectsWith(bossLabel(i).Bounds) Then
                        Label7.Text = Val(Label7.Text - 1)
                        ProgressBar1.Value = Val(ProgressBar1.Value - 1)
                        bossLabel(i).Visible = False
                    ElseIf Not Memumi.Bounds.IntersectsWith(bossLabel(i).Bounds) Then
                        bossLabel(i).Visible = True
                    End If
                Next
                For j As Integer = 0 To 5
                    If barrage(j).Visible = True AndAlso Memumi.Bounds.IntersectsWith(barrage(j).Bounds) Then
                        Label7.Text = Val(Label7.Text - 1)
                        ProgressBar1.Value = Val(ProgressBar1.Value - 1)
                        barrage(j).Visible = False
                    ElseIf Not Memumi.Bounds.IntersectsWith(barrage(j).Bounds) Then
                        barrage(j).Visible = True
                    End If
                Next
            End If
            If ProgressBar1.Value = 0 Then
                ProgressBar1.Enabled = False
                Writetxt()
                Timer4.Stop()
                deadflag = True
                If deadflag = True Then
                    If MsgBox("要不要重玩一次??", vbYesNo, "戰鬥姆咪學園") = vbYes Then
                        Me.Close()
                        startform.Visible = True
                        deadflag = False
                    Else
                        End
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mumi()
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        bang()
    End Sub
    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        enemyinterval += 1
        If enemyinterval = 2 Then
            If (kind <= 5) Then
                enemyinterval = 0
                stage1.Start()
                enemy_location()
                Timer8.Stop()
            Else
                enemyinterval = 0
                stage2.Start()
                enemy_location()
                Timer8.Stop()
            End If
        End If
    End Sub
    Sub nextstage()
        kind += 1
        Timer8.Start()
        If (kind <= 5) Then
            stage1.Stop()
        Else
            stage2.Stop()
        End If
        For i = 0 To 9
            bulletarr(i).Visible = False
        Next
    End Sub
    Sub enemyfire()
        If (enemybullet = False) Then
            If (kind <> 5) Then
                For i = 0 To 9
                    If (enemyarr(i).Visible = True) Then
                        bulletarr(i).Location = New Point(enemyarr(i).Location.X + (enemyarr(i).Size.Width - bulletarr(i).Size.Width) / 2, enemyarr(i).Location.Y)
                        bulletarr(i).Visible = True
                    End If
                Next
            End If
            If (kind = 5) Then
                For i = 0 To 9
                    bulletarr(i).Location = New Point(-1000, -1000)
                Next
            End If

        Else
            If (stage1.Enabled = True Or stage2.Enabled = True) Then
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
                        End If
                    Else
                        If (bulletarr(2).Top - bulletarr(2).Size.Height < Me.ClientSize.Height) Then
                            bulletarr(2).Top += 5
                        End If

                    End If
                End If
            End If
        End If
    End Sub
    Private Sub bottleform_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        hardsettingform.Close()
        settingform.Close()
    End Sub
    Private Sub BossTimer_Tick(sender As Object, e As EventArgs) Handles BossTimer.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Left += boss_vx
            If PictureBox1.Left >= GroupBox1.Left - PictureBox1.Width Or PictureBox1.Left <= 0 Then '左右
                boss_vx = -boss_vx
            End If
            If PictureBox1.Tag = 1 Then
                PictureBox1.Image = My.Resources.BOSS1遊戲用
                Dim j As Integer '排版
                For i As Integer = 0 To 9
                    If j = 1 Then
                        j = 0
                    Else
                        j += 1
                    End If
                    If bossLabel(i).Top > Me.ClientSize.Height Then 'boss子彈
                        bossLabel(i).Location = New Point(PictureBox1.Location.X + j * 50, PictureBox1.Location.Y + PictureBox1.Height)
                    End If
                    bossLabel(i).Top += 10
                Next

                For L As Integer = 0 To 5 '彈幕
                    If barrage(L).Top > Me.ClientSize.Height Then
                        barrage(L).Location = New Point(barrage(L).Location.X, PictureBox1.Location.Y)
                    End If
                    barrage(L).Top += 10
                Next
            End If
            If PictureBox1.Tag = 2 Then
                PictureBox1.Image = My.Resources.___BOSS_2______burned_去背
                For i As Integer = 0 To 4 '左 彈幕
                    If bossLabel(i).Left < 0 Or bossLabel(i).Left > GroupBox1.Left Then
                        b_vx(i) = -b_vx(i)
                    End If
                    If bossLabel(i).Top > Me.ClientSize.Height Or bossLabel(i).Top < 0 Then
                        b_vy(i) = -b_vy(i)
                    End If
                    bossLabel(i).Left -= b_vx(i)
                    bossLabel(i).Top += b_vy(i)
                Next
                For i As Integer = 5 To 9 '右 彈幕
                    If bossLabel(i).Left < 0 Or bossLabel(i).Left > GroupBox1.Left Then
                        b_vx(i) = -b_vx(i)
                    End If
                    If bossLabel(i).Top > Me.ClientSize.Height Or bossLabel(i).Top < 0 Then
                        b_vy(i) = -b_vy(i)
                    End If
                    bossLabel(i).Left += b_vx(i)
                    bossLabel(i).Top += b_vy(i)
                Next
                For L As Integer = 0 To 5 '彈幕
                    If barrage(L).Top > Me.ClientSize.Height Then
                        barrage(L).Location = New Point(barrage(L).Location.X, PictureBox1.Location.Y)
                    End If
                    barrage(L).Top += 10
                Next
            End If
            If PictureBox1.Tag = 3 Then
                PictureBox1.Image = My.Resources.BOSS2遊戲用
                Dim j As Integer '排版
                For i As Integer = 0 To 9 ' 彈幕
                    If j = 2 Then
                        j = 0
                    Else
                        j += 1
                    End If
                    If bossLabel(i).Top > Me.ClientSize.Height Then
                        bossLabel(i).Location = New Point(PictureBox1.Location.X + j * 50, PictureBox1.Location.Y - j * 50)
                    End If
                    bossLabel(i).Top += 10
                Next
                For L As Integer = 0 To 5 '彈幕
                    If barrage(L).Top < 0 Then
                        barrage(L).Location = New Point(barrage(L).Location.X, Me.ClientSize.Height)
                    End If
                    barrage(L).Top -= 10
                Next
            End If
        End If
    End Sub
    Sub usearray()
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
        bossLabel(0) = b0
        bossLabel(1) = b1
        bossLabel(2) = b2
        bossLabel(3) = b3
        bossLabel(4) = b4
        bossLabel(5) = b5
        bossLabel(6) = b6
        bossLabel(7) = b7
        bossLabel(8) = b8
        bossLabel(9) = b9
        barrage(0) = L0
        barrage(1) = L1
        barrage(2) = L2
        barrage(3) = L3
        barrage(4) = L4
        barrage(5) = L5
    End Sub

    Sub Writetxt()
        Dim path As String = Application.StartupPath & "/records.txt"

        Dim a
        If hardsettingform.hardness = 1 Then
            a = "超姆咪級"
        Else
            a = "姆咪級"
        End If

        If IO.File.Exists(path) Then
            'records存在      
            Try
                Dim sw = My.Computer.FileSystem.OpenTextFileWriter(path, True)

                sw.WriteLine(hardsettingform.TextBox1.Text & "," & Label5.Text & "," & a & "," & DateTime.Today.Month() & " / " & DateTime.Today.Day() & "," & Label7.Text)
                sw.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'records不存在        
            create()
            Try
                Dim sw = My.Computer.FileSystem.OpenTextFileWriter(path, True)
                sw.WriteLine(hardsettingform.TextBox1.Text & "," & Label5.Text & "," & a & "," & DateTime.Today.Month() & " / " & DateTime.Today.Day() & "," & Label7.Text)
                sw.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label13.Visible = False
        Label14.Visible = False
        PictureBox6.Tag = 10
        PictureBox1.Tag = 1
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        character.Visible = False
        story.Visible = False
        GroupBox1.Visible = True
        Memumi.Visible = True
        BossTimer.Enabled = True
    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        mumiworld = False
        Label13.Visible = False
        Label14.Visible = False
        PictureBox6.Visible = False
        PictureBox5.Visible = True
        character.Text = "姆咪: "
        story.Text = "【難道姆咪真的做錯了嗎?】"
        PictureBox6.Tag = 17
        PictureBox1.Tag = 3
    End Sub
End Class
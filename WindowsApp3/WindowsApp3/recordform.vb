Imports System.ComponentModel

Public Class recordform
        Public Sub recordform_Load(sender As Object, e As EventArgs) Handles Me.Load
            Dim playernames(5) As Label
            Dim scores(5) As Label
            Dim hardnessofgames(5) As Label
            Dim dateofgames(5) As Label
            Dim lifeofgames(5) As Label
            Dim recordspath = Application.StartupPath
            Dim records As New List(Of String())
            playernames(0) = playername1
            playernames(1) = playername2
            playernames(2) = playername3
            playernames(3) = playername4
            playernames(4) = playername5

            scores(0) = score1
            scores(1) = score2
            scores(2) = score3
            scores(3) = score4
            scores(4) = score5

            hardnessofgames(0) = hardness1
            hardnessofgames(1) = hardness2
            hardnessofgames(2) = hardness3
            hardnessofgames(3) = hardness4
            hardnessofgames(4) = hardness5

            dateofgames(0) = dateofgame1
            dateofgames(1) = dateofgame2
            dateofgames(2) = dateofgame3
            dateofgames(3) = dateofgame4
            dateofgames(4) = dateofgame5

            lifeofgames(0) = secondsofgame1
            lifeofgames(1) = secondsofgame2
            lifeofgames(2) = secondsofgame3
            lifeofgames(3) = secondsofgame4
            lifeofgames(4) = secondsofgame5

            If IO.File.Exists(recordspath & "/records.txt") Then
                'records存在      
                Try
                    Dim recordreader = My.Computer.FileSystem.OpenTextFieldParser(recordspath & "/records.txt", ",")
                    Dim ioo As Integer = 0, qoo As Integer, woo As Integer = 4
                    Dim joo As Integer = 0
                    While Not recordreader.EndOfData
                        Dim onerow() = recordreader.ReadFields()
                        records.Add(onerow)
                        ioo += 1
                    End While

                    Dim t, g As Integer
                    Dim tem_s, tem_n, tem_h, tem_d, tem_l
                    Dim flag_record As Boolean = False
                    Dim copytem_s(ioo - 1), copytem_n(ioo - 1), copytem_h(ioo - 1), copytem_d(ioo - 1), copytem_l(ioo - 1)

                    For t = 0 To ioo - 1
                        copytem_n(t) = records(t)(0)
                        copytem_s(t) = Val(records(t)(1))
                        copytem_h(t) = records(t)(2)
                        copytem_d(t) = records(t)(3)
                        copytem_l(t) = records(t)(4)
                    Next
                If ioo - 5 > 0 Then
                    For t = (ioo - 5) To (ioo - 1) And flag_record = False
                        flag_record = True
                        For g = 0 To (ioo - 2)
                            If copytem_s(g) > copytem_s(g + 1) Then
                                tem_s = copytem_s(g)
                                tem_n = copytem_n(g)
                                tem_h = copytem_h(g)
                                tem_d = copytem_d(g)
                                tem_l = copytem_l(g)

                                copytem_n(g) = copytem_n(g + 1)
                                copytem_s(g) = copytem_s(g + 1)
                                copytem_h(g) = copytem_h(g + 1)
                                copytem_d(g) = copytem_d(g + 1)
                                copytem_l(g) = copytem_l(g + 1)


                                copytem_h(g + 1) = tem_h
                                copytem_s(g + 1) = tem_s
                                copytem_n(g + 1) = tem_n
                                copytem_d(g + 1) = tem_d
                                copytem_l(g + 1) = tem_l

                                flag_record = False
                            End If
                        Next
                    Next
                    For qoo = (ioo - 5) To (ioo - 1)
                        playernames(woo).Text = copytem_n(qoo)
                        scores(woo).Text = copytem_s(qoo)
                        hardnessofgames(woo).Text = copytem_h(qoo)
                        dateofgames(woo).Text = copytem_d(qoo)
                        lifeofgames(woo).Text = copytem_l(qoo)
                        woo -= 1
                    Next
                Else
                    For W As Integer = 0 To ioo - 1
                        playernames(W).Text = records(W)(0)
                        scores(W).Text = records(W)(1)
                        hardnessofgames(W).Text = records(W)(2)
                        dateofgames(W).Text = records(W)(3)
                        lifeofgames(W).Text = records(W)(4)
                    Next
                    For W As Integer = (ioo) To 4
                        playernames(W).Text = ""
                        scores(W).Text = ""
                        hardnessofgames(W).Text = ""
                        dateofgames(W).Text = ""
                        lifeofgames(W).Text = ""
                    Next

                End If


                recordreader.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                'records不存在
                For ioo As Integer = 0 To 4
                    playernames(ioo).Text = ""
                    scores(ioo).Text = ""
                    hardnessofgames(ioo).Text = ""
                    dateofgames(ioo).Text = ""
                    lifeofgames(ioo).Text = ""
                Next
                create()
            End If

        End Sub

        Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        startform.Show()
        Me.Hide()
    End Sub

    Private Sub recordform_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        startform.Close()
        settingform.Close()
        hardsettingform.Close()
        bottleform.Close()
    End Sub
    Private Sub Button_mouseenter(sender As Object, e As EventArgs) Handles back.MouseEnter
        sender.Font = New Font("微軟正黑體", 22, FontStyle.Italic Or FontStyle.Bold)
        sender.FlatStyle = FlatStyle.Popup
    End Sub
    Private Sub Button_mouseleave(sender As Object, e As EventArgs) Handles back.MouseLeave
        sender.Font = New Font("微軟正黑體", 14, FontStyle.Italic Or FontStyle.Bold)
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub Button_enter(sender As Object, e As EventArgs) Handles back.Enter
        sender.Font = New Font("微軟正黑體", 22, FontStyle.Italic Or FontStyle.Bold)
    End Sub
    Private Sub Button1_leave(sender As Object, e As EventArgs) Handles back.Leave
        sender.Font = New Font("微軟正黑體", 14, FontStyle.Italic Or FontStyle.Bold)
    End Sub

End Class
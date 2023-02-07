<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hardsettingform
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.hardnesssetting = New System.Windows.Forms.GroupBox()
        Me.hardness1 = New System.Windows.Forms.RadioButton()
        Me.hardness2 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.start = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.hardnesssetting.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hardnesssetting
        '
        Me.hardnesssetting.BackColor = System.Drawing.Color.Transparent
        Me.hardnesssetting.Controls.Add(Me.hardness1)
        Me.hardnesssetting.Controls.Add(Me.hardness2)
        Me.hardnesssetting.Font = New System.Drawing.Font("新細明體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.hardnesssetting.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.hardnesssetting.Location = New System.Drawing.Point(31, 395)
        Me.hardnesssetting.Name = "hardnesssetting"
        Me.hardnesssetting.Size = New System.Drawing.Size(283, 81)
        Me.hardnesssetting.TabIndex = 18
        Me.hardnesssetting.TabStop = False
        '
        'hardness1
        '
        Me.hardness1.AutoSize = True
        Me.hardness1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.hardness1.Location = New System.Drawing.Point(5, 34)
        Me.hardness1.Name = "hardness1"
        Me.hardness1.Size = New System.Drawing.Size(120, 32)
        Me.hardness1.TabIndex = 1
        Me.hardness1.TabStop = True
        Me.hardness1.Tag = "1"
        Me.hardness1.Text = "姆咪級"
        Me.hardness1.UseVisualStyleBackColor = True
        '
        'hardness2
        '
        Me.hardness2.AutoSize = True
        Me.hardness2.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.hardness2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.hardness2.Location = New System.Drawing.Point(146, 34)
        Me.hardness2.Name = "hardness2"
        Me.hardness2.Size = New System.Drawing.Size(131, 28)
        Me.hardness2.TabIndex = 2
        Me.hardness2.TabStop = True
        Me.hardness2.Tag = "2"
        Me.hardness2.Text = "超姆咪級"
        Me.hardness2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.難度2
        Me.PictureBox1.Location = New System.Drawing.Point(98, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'start
        '
        Me.start.BackColor = System.Drawing.Color.Transparent
        Me.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.start.FlatAppearance.BorderSize = 0
        Me.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start.Font = New System.Drawing.Font("微軟正黑體", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.start.ForeColor = System.Drawing.Color.DimGray
        Me.start.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.start.Location = New System.Drawing.Point(69, 511)
        Me.start.Margin = New System.Windows.Forms.Padding(4)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(212, 72)
        Me.start.TabIndex = 25
        Me.start.Text = "開始"
        Me.start.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Font = New System.Drawing.Font("微軟正黑體", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.back.ForeColor = System.Drawing.Color.DimGray
        Me.back.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.back.Location = New System.Drawing.Point(311, 512)
        Me.back.Margin = New System.Windows.Forms.Padding(4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(212, 72)
        Me.back.TabIndex = 26
        Me.back.Text = "返回"
        Me.back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.WindowsApp3.My.Resources.Resources.輸入遊戲暱稱
        Me.PictureBox2.Location = New System.Drawing.Point(371, 322)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(173, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(360, 426)
        Me.TextBox1.MaxLength = 16
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 35)
        Me.TextBox1.TabIndex = 28
        '
        'hardsettingform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp3.My.Resources.Resources.超級姆咪
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(612, 673)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.hardnesssetting)
        Me.Name = "hardsettingform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "中文難易度設定"
        Me.hardnesssetting.ResumeLayout(False)
        Me.hardnesssetting.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hardnesssetting As GroupBox
    Friend WithEvents hardness1 As RadioButton
    Friend WithEvents hardness2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents start As Button
    Friend WithEvents back As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class

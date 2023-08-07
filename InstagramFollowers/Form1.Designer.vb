
Namespace InstagramFollowers
    Partial Class Form1
        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            txtUserName = New Windows.Forms.TextBox()
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            txtPassword = New Windows.Forms.TextBox()
            btnLogin = New Windows.Forms.Button()
            listBox1 = New Windows.Forms.ListBox()
            label3 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            listBox2 = New Windows.Forms.ListBox()
            label5 = New Windows.Forms.Label()
            comboBox1 = New Windows.Forms.ComboBox()
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            button3 = New Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' txtUserName
            ' 
            txtUserName.Location = New Drawing.Point(87, 20)
            txtUserName.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            txtUserName.Name = "txtUserName"
            txtUserName.Size = New Drawing.Size(160, 23)
            txtUserName.TabIndex = 0
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(5, 20)
            label1.Margin = New Windows.Forms.Padding(1, 0, 1, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(63, 15)
            label1.TabIndex = 1
            label1.Text = "User name"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(11, 52)
            label2.Margin = New Windows.Forms.Padding(1, 0, 1, 0)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(57, 15)
            label2.TabIndex = 2
            label2.Text = "Password"
            ' 
            ' txtPassword
            ' 
            txtPassword.Location = New Drawing.Point(87, 52)
            txtPassword.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            txtPassword.Name = "txtPassword"
            txtPassword.PasswordChar = "*"c
            txtPassword.Size = New Drawing.Size(160, 23)
            txtPassword.TabIndex = 3
            ' 
            ' btnLogin
            ' 
            btnLogin.Location = New Drawing.Point(279, 27)
            btnLogin.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            btnLogin.Name = "btnLogin"
            btnLogin.Size = New Drawing.Size(105, 30)
            btnLogin.TabIndex = 4
            btnLogin.Text = "مدخل"
            btnLogin.UseVisualStyleBackColor = True
            AddHandler btnLogin.Click, New EventHandler(AddressOf btnLogin_Click)
            ' 
            ' listBox1
            ' 
            listBox1.FormattingEnabled = True
            listBox1.ItemHeight = 15
            listBox1.Location = New Drawing.Point(75, 102)
            listBox1.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            listBox1.Name = "listBox1"
            listBox1.Size = New Drawing.Size(124, 184)
            listBox1.TabIndex = 5
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(75, 81)
            label3.Margin = New Windows.Forms.Padding(1, 0, 1, 0)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(128, 15)
            label3.TabIndex = 6
            label3.Text = "What You Don't Follow"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(260, 81)
            label4.Margin = New Windows.Forms.Padding(1, 0, 1, 0)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(70, 15)
            label4.TabIndex = 7
            label4.Text = "Unfollowers"
            ' 
            ' listBox2
            ' 
            listBox2.FormattingEnabled = True
            listBox2.ItemHeight = 15
            listBox2.Location = New Drawing.Point(262, 102)
            listBox2.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            listBox2.Name = "listBox2"
            listBox2.Size = New Drawing.Size(124, 184)
            listBox2.TabIndex = 8
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Location = New Drawing.Point(435, 20)
            label5.Margin = New Windows.Forms.Padding(1, 0, 1, 0)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(86, 15)
            label5.TabIndex = 9
            label5.Text = "Unfollow Users"
            ' 
            ' comboBox1
            ' 
            comboBox1.FormattingEnabled = True
            comboBox1.Location = New Drawing.Point(448, 39)
            comboBox1.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            comboBox1.Name = "comboBox1"
            comboBox1.Size = New Drawing.Size(127, 23)
            comboBox1.TabIndex = 10
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(443, 66)
            button1.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(136, 30)
            button1.TabIndex = 11
            button1.Text = "Unfollow!"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click_1)
            ' 
            ' button2
            ' 
            button2.Location = New Drawing.Point(443, 113)
            button2.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(136, 30)
            button2.TabIndex = 12
            button2.Text = "Add to database"
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' button3
            ' 
            button3.Location = New Drawing.Point(443, 161)
            button3.Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            button3.Name = "button3"
            button3.Size = New Drawing.Size(136, 30)
            button3.TabIndex = 13
            button3.Text = "Pull from database"
            button3.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(606, 288)
            Controls.Add(button3)
            Controls.Add(button2)
            Controls.Add(button1)
            Controls.Add(comboBox1)
            Controls.Add(label5)
            Controls.Add(listBox2)
            Controls.Add(label4)
            Controls.Add(label3)
            Controls.Add(listBox1)
            Controls.Add(btnLogin)
            Controls.Add(txtPassword)
            Controls.Add(label2)
            Controls.Add(label1)
            Controls.Add(txtUserName)
            Margin = New Windows.Forms.Padding(1, 1, 1, 1)
            Name = "Form1"
            Text = "İnstaFollowers"
            AddHandler Load, New EventHandler(AddressOf Form1_Load_1)
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private txtUserName As Windows.Forms.TextBox
        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private txtPassword As Windows.Forms.TextBox
        Private btnLogin As Windows.Forms.Button
        Private listBox1 As Windows.Forms.ListBox
        Private label3 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private listBox2 As Windows.Forms.ListBox
        Private label5 As Windows.Forms.Label
        Private comboBox1 As Windows.Forms.ComboBox
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
        Private button3 As Windows.Forms.Button
    End Class
End Namespace

Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System
Imports System.Collections.Generic
Imports System.Threading
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace InstagramFollowers
    Public Partial Class Form1
        Inherits Form
        Private driver As IWebDriver
        Private username As String
        Private Followers As List(Of String) = New List(Of String)()
        Private Follows As List(Of String) = New List(Of String)()
        Private notFollow As List(Of String) = New List(Of String)()
        Private notFollowers As List(Of String) = New List(Of String)()
        Private con As MySqlConnection
        Private cmd As MySqlCommand


        Public Sub New()
            InitializeComponent()
            con = New MySqlConnection("Server=localhost;Database=instagramfollowers;user=root;Pwd=667130Emre.;SslMode=none")
            'con.Open();
            'cmd = new MySqlCommand();
            'cmd.Connection = con;
            'string s = "emre";
            'cmd.CommandText = "SELECT * FROM notfollow where notFollows = '"+s+"'";
            'dr = cmd.ExecuteReader();
            'if (dr.Read())
            '{
            '    MessageBox.Show("ok");
            '}
            'else
            '{
            '    MessageBox.Show("no");
            '}
            'con.Close();


        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs)
            'driver = new ChromeDriver();
            button2.Enabled = False
        End Sub

        Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
            username = txtUserName.Text
            Dim password = txtPassword.Text
            If Equals(username, Nothing) OrElse Equals(username, "") OrElse Equals(password, Nothing) OrElse Equals(password, "") Then
                MessageBox.Show("Gecersiz kullanici adi veya sifre!")
            Else
                driver = New ChromeDriver()
                driver.Navigate().GoToUrl("https://www.instagram.com")
                Thread.Sleep(5000)
                Dim userNameInstagram = driver.FindElement(By.Name("username"))
                Dim passwordInstagram = driver.FindElement(By.Name("password"))
                Dim loginBtn = driver.FindElement(By.CssSelector(".sqdOP.L3NKy.y3zKF"))


                userNameInstagram.SendKeys(username)
                passwordInstagram.SendKeys(password)
                Thread.Sleep(2000)
                loginBtn.Click()
                Thread.Sleep(7000)
                driver.Navigate().GoToUrl("https://www.instagram.com/" & username)
                Thread.Sleep(2000)

                Dim follows = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > a"))
                follows.Click()
                Thread.Sleep(1000)
                Dim jsCommand = "" & "sayfa = document.querySelector('.isgrP');" & "sayfa.scrollTo(0,sayfa.scrollHeight);" & "var sayfaSonu = sayfa.scrollHeight;" & "return sayfaSonu;"

                Dim js = CType(driver, IJavaScriptExecutor)
                Dim sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand))

                While True
                    Dim son = sayfaSonu
                    Thread.Sleep(1100)
                    sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand))
                    If son = sayfaSonu Then Exit While
                End While

                Dim TakipEdilenler As IReadOnlyCollection(Of IWebElement) = driver.FindElements(By.CssSelector(".notranslate._0imsa"))
                For Each item In TakipEdilenler
                    Me.Follows.Add(item.Text)
                Next
                Thread.Sleep(500)

                Dim close = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[1]/div/div[3]/div/button"))
                close.Click()
                Thread.Sleep(500)
                '#react-root > section > main > div > header > section > ul > li:nth-child(3) > a
                Dim followers = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a"))
                followers.Click()
                Thread.Sleep(1000)

                Dim sayfaSonu2 = Convert.ToInt32(js.ExecuteScript(jsCommand))

                While True
                    Dim son = sayfaSonu2
                    Thread.Sleep(1100)
                    sayfaSonu2 = Convert.ToInt32(js.ExecuteScript(jsCommand))
                    If son = sayfaSonu2 Then Exit While
                End While

                Dim Takipciler As IReadOnlyCollection(Of IWebElement) = driver.FindElements(By.CssSelector(".notranslate._0imsa"))
                For Each item In Takipciler
                    Me.Followers.Add(item.Text)
                Next
                Thread.Sleep(500)

                For Each follow In Me.Follows
                    Dim sayac = 0
                    For Each followrs In Me.Followers
                        If Equals(follow, followrs) Then
                            sayac = 1
                        End If
                    Next
                    If sayac = 0 Then
                        notFollow.Add(follow)
                    End If
                Next
                For Each followrs In Me.Followers
                    Dim sayac = 0
                    For Each follow In Me.Follows
                        If Equals(followrs, follow) Then
                            sayac = 1
                        End If
                    Next
                    If sayac = 0 Then
                        notFollowers.Add(followrs)
                    End If
                Next

                button2.Enabled = True
                Dim sayac2 = 1
                For Each item In notFollow
                    listBox1.Items.Add(sayac2.ToString() & "->" & item)
                    sayac2 += 1
                Next
                Dim sayac3 = 1
                For Each item In notFollowers
                    listBox2.Items.Add(sayac3.ToString() & "->" & item)
                    comboBox1.Items.Add(item)
                    sayac3 += 1
                Next



            End If
        End Sub
        Public Shared Sub scrollToBack()

        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Try
                driver.Navigate().GoToUrl("https://www.instagram.com/" & comboBox1.SelectedItem.ToString())
                Thread.Sleep(3000)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''html/body/div[1]/section/main/div/header/section/div[2]/div/div[2]/button
                Dim unfollow = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/div[2]/div/div[2]/button"))
                Thread.Sleep(500)
                unfollow.Click()
                Thread.Sleep(1000)
                Dim unfollowclick = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[3]/button[1]"))
                unfollowclick.Click()
                Call MessageBox.Show(comboBox1.SelectedItem.ToString() & " Hesabı başarıyla takipten çıkıldı!")
            Catch __unusedException1__ As Exception

                MessageBox.Show("Beklenmeyen bir hata olustu.")
            End Try
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)

            con.Open()
            Dim sayac = 2
            For Each item In notFollow
                Dim dr As MySqlDataReader
                cmd = New MySqlCommand()
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM notfollow where notFollows = '" & item & "'"
                dr = cmd.ExecuteReader()
                If Not dr.Read() Then
                    cmd = New MySqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO notfollow(id,userId,notFollows) VALUES('" & sayac.ToString() & "',1,'" & item & "')"
                    sayac += 1
                End If
            Next
            '
            Dim sayac1 = 1
            For Each items In notFollowers
                Dim dr As MySqlDataReader
                cmd = New MySqlCommand()
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM notfollowers where notFollowsers = '" & items & "'"
                dr = cmd.ExecuteReader()
                If Not dr.Read() Then
                    cmd = New MySqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO notfollowers(id,userId,notFollowsers) VALUES('" & sayac1.ToString() & "',1,'" & items & "')"
                    sayac1 += 1
                End If
            Next
            MessageBox.Show("VeriTabanina Basariyla Eklendi!")
            con.Close()

        End Sub
    End Class
End Namespace

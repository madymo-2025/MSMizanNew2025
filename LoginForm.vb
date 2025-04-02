Imports System.Data.SqlClient

Public Class LoginForm
    ' الاتصال بقاعدة البيانات
    Private connectionString As String = "Data Source=modylap;Initial Catalog=MSDMizannew;Integrated Security=True;Encrypt=False"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' التحقق من اسم المستخدم وكلمة المرور
        Dim query As String = "SELECT * FROM Login WHERE UserName = @UserName AND Password = @Password"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", username)
                cmd.Parameters.AddWithValue("@Password", password)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim mainForm As New MainForm()
                    mainForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
        'Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub LoginForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'كود الانتقال نت تكست لاخر 
        'اجعل خاصية tabindex مرتبة 
        'اجعل خاصية KeyPreview=true فى الفورم

        If e.KeyCode = Keys.Return Then SendKeys.Send("{TAB}")
    End Sub

    'الفورم لوود
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'فوكس علي بوكس اسم المستخدم
        txtUsername.Focus()
        txtUsername.Select()
        txtUsername.SelectAll()
    End Sub

    'الانتقال الي بوكس الباسورد
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()

        End If
    End Sub

    'الانتقال الي زر الدخول
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLogin.Focus()

        End If
    End Sub

End Class
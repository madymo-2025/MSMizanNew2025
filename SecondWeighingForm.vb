Imports System.Data.SqlClient

Public Class SecondWeighingForm
    ' الاتصال بقاعدة البيانات
    Private connectionString As String = "Data Source=modylap;Initial Catalog=MSDMizannew;Integrated Security=True;Encrypt=False"
    ' حساب صافي الوزن
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Dim firstWeight As Integer = Integer.Parse(txtFirstWeight.Text)
        'Dim secondWeight As Integer = Integer.Parse(txtSecondWeight.Text)
        'Dim netWeight As Integer = secondWeight - firstWeight
        'txtNetWeight.Text = netWeight.ToString()
    End Sub
    ' حفظ بيانات الوزنة الثانية
    Private Sub btnSave_Click(sender As Object, e As EventArgs)

        Dim query As String = "UPDATE MainMizan SET HSecond = @HSecond, TSecond = @TSecond, Second = @Second, Sum = @Sum WHERE MainMizanID = @MainMizanID"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@HSecond", dtpSecondDateTime.Value)
                cmd.Parameters.AddWithValue("@TSecond", dtpSecondDateTime.Value)
                cmd.Parameters.AddWithValue("@Second", txtSecondWeight.Text)
                cmd.Parameters.AddWithValue("@Sum", txtNetWeight.Text)
                cmd.Parameters.AddWithValue("@MainMizanID", txtMainMizanID.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("تمت إضافة الوزنة الثانية بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtSecondWeight_Click(sender As Object, e As EventArgs) Handles txtSecondWeight.Click
        ' حساب صافي الوزن
        Dim firstWeight As Integer = Integer.Parse(txtFirstWeight.Text)
        Dim secondWeight As Integer = Integer.Parse(txtSecondWeight.Text)
        Dim netWeight As Integer = secondWeight - firstWeight
        txtNetWeight.Text = netWeight.ToString()
    End Sub

    Private Sub txtSecondWeight_TextChanged(sender As Object, e As EventArgs) Handles txtSecondWeight.TextChanged
        ' حساب صافي الوزن
        Dim firstWeight As Integer = Integer.Parse(txtFirstWeight.Text)
        Dim secondWeight As Integer = Integer.Parse(txtSecondWeight.Text)
        Dim netWeight As Integer = secondWeight - firstWeight
        txtNetWeight.Text = netWeight.ToString()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs)

    End Sub

    'نتيجة تلقائية
    Private Sub txtNetWeight_TextChanged(sender As Object, e As EventArgs) Handles txtNetWeight.TextChanged
        'نتيجة تلقائية

        Dim a, b, c As Single

        a = Val(txtFirstWeight.Text)
        b = Val(txtSecondWeight.Text)
        'c = Val(TxtPalans.Text)
        txtNetWeight.Text = a - b
        'TxtPalans.Text = a * b
        '#############################
    End Sub
End Class
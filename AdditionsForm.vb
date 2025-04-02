Imports System.Data.SqlClient

Public Class AdditionsForm
    ' الاتصال بقاعدة البيانات
    Private connectionString As String = "Data Source=modylap;Initial Catalog=MSDMizannew;Integrated Security=True;Encrypt=False"

    Private Sub btnSaveClient_Click(sender As Object, e As EventArgs) Handles btnSaveClient.Click
        ' إضافة عميل جديد
        Dim query As String = "INSERT INTO Agents (AgentName) VALUES (@AgentName)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@AgentName", txtNewClient.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("تمت إضافة العميل بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveCargo_Click(sender As Object, e As EventArgs) Handles btnSaveCargo.Click
        ' إضافة بضاعة جديدة
        Dim query As String = "INSERT INTO Cargo (CargoName) VALUES (@CargoName)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CargoName", txtNewCargo.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("تمت إضافة البضاعة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
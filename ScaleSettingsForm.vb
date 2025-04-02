Imports System.Data.SqlClient

Public Class ScaleSettingsForm
    ' الاتصال بقاعدة البيانات
    Private connectionString As String = "Data Source=modylap;Initial Catalog=MSDMizannew;Integrated Security=True;Encrypt=False"

    Private Sub LoadSettings()
        Dim query As String = "SELECT * FROM ScaleSettings WHERE SettingID = 1"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtPort.Text = reader("Port").ToString()
                    txtBaudRate.Text = reader("BaudRate").ToString()
                    txtHandshake.Text = reader("Handshake").ToString()
                    txtDataBits.Text = reader("DataBits").ToString()
                    txtParity.Text = reader("Parity").ToString()
                    txtStopBits.Text = reader("StopBits").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub ScaleSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        ' حفظ إعدادات الميزان
        Dim query As String = "UPDATE ScaleSettings SET Port = @Port, BaudRate = @BaudRate, Handshake = @Handshake, DataBits = @DataBits, Parity = @Parity, StopBits = @StopBits WHERE SettingID = 1"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Port", txtPort.Text)
                cmd.Parameters.AddWithValue("@BaudRate", txtBaudRate.Text)
                cmd.Parameters.AddWithValue("@Handshake", txtHandshake.Text)
                cmd.Parameters.AddWithValue("@DataBits", txtDataBits.Text)
                cmd.Parameters.AddWithValue("@Parity", txtParity.Text)
                cmd.Parameters.AddWithValue("@StopBits", txtStopBits.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("تم حفظ الإعدادات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
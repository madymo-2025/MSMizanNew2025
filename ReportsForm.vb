Imports System.Data.SqlClient

Public Class ReportsForm
    ' الاتصال بقاعدة البيانات
    Private connectionString As String = "Data Source=modylap;Initial Catalog=MSDMizannew;Integrated Security=True;Encrypt=False"

    Private Sub LoadData(query As String)
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If cmbAgent.SelectedValue IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@AgentID", cmbAgent.SelectedValue)
                End If
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvReports.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btnSearchClient_Click(sender As Object, e As EventArgs) Handles btnSearchClient.Click
        ' الاستعلام عن عميل خلال فترة معينة
        Dim query As String = "SELECT * FROM MainMizan WHERE AgentID = @AgentID AND HFirst BETWEEN @StartDate AND @EndDate"
        LoadData(query)
    End Sub

    Private Sub btnSearchCar_Click(sender As Object, e As EventArgs) Handles btnSearchCar.Click
        ' الاستعلام عن سيارة خلال فترة معينة
        Dim query As String = "SELECT * FROM MainMizan WHERE CarNo = @CarNo AND HFirst BETWEEN @StartDate AND @EndDate"
        LoadData(query)
    End Sub

    Private Sub btnSearchCargo_Click(sender As Object, e As EventArgs) Handles btnSearchCargo.Click
        ' الاستعلام عن حمولة خلال فترة معينة
        Dim query As String = "SELECT * FROM MainMizan WHERE CargoID = @CargoID AND HFirst BETWEEN @StartDate AND @EndDate"
        LoadData(query)
    End Sub
End Class
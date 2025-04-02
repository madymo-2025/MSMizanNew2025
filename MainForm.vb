Public Class MainForm
    ' الاتصال بقاعدة البيانات
    Private connectionString As String = "Data Source=modylap;Initial Catalog=MSDMizannew;Integrated Security=True;Encrypt=False"

    'شاشة الوزنة الاولي
    Private Sub btnFirstWeighing_Click(sender As Object, e As EventArgs) Handles btnFirstWeighing.Click
        Dim firstWeighingForm As New FirstWeighingForm()
        firstWeighingForm.Show()
    End Sub

    'شاشة الوزنة الثانية
    Private Sub btnSecondWeighing_Click(sender As Object, e As EventArgs) Handles btnSecondWeighing.Click
        Dim secondWeighingForm As New SecondWeighingForm()
        secondWeighingForm.Show()
    End Sub

    'شاشة التقارير
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
    End Sub

    'شاشة الاعدادات
    Private Sub btnScaleSettings_Click(sender As Object, e As EventArgs) Handles btnScaleSettings.Click
        'Dim scaleSettingsForm As New ScaleSettingsForm()
        'ScaleSettingsForm.Show()
        Dim Settingsfrm As New SettingsFrm()
        Settingsfrm.Show()

    End Sub

    Private Sub BtnAdditions_Click(sender As Object, e As EventArgs) Handles btnAdditions.Click
        Dim additionsForm As New AdditionsForm()

        additionsForm.Show()
    End Sub

    'خروج
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End

    End Sub

    'كود الانتقال نت تكست لاخر 
    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'كود الانتقال نت تكست لاخر 
        'اجعل خاصية tabindex مرتبة 
        'اجعل خاصية KeyPreview=true فى الفورم

        If e.KeyCode = Keys.Return Then SendKeys.Send("{TAB}")
    End Sub

End Class
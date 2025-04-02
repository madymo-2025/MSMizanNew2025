Imports System.IO.Ports
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class SettingsFrm


    'تعريف متغيرات للتحكم في الوزن
    Private receivedData As String = ""
    Private scaleData As String = ""
    Private dataPosition As Integer

    ' إعدادات المنفذ التسلسلي الافتراضية
    Private defaultPortName As String = "COM5"
    Private defaultBaudRate As Integer = 9600
    Private defaultParity As Parity = Parity.None
    Private defaultDataBits As Integer = 8
    Private defaultStopBits As StopBits = StopBits.One

    Private Sub SettingsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' تهيئة ComboBox بإعدادات Baud Rate
        CmbBaudRate.Text = "Select Baud Rate"
        CmbBaudRate.Items.AddRange({"1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "56000", "76800", "115200"})

        ' تهيئة ComboBox بإعدادات منافذ COM المتاحة
        CmbPortName.Text = "Select COM Port"
        CmbPortName.Items.AddRange(SerialPort.GetPortNames())

        ' تعيين الإعدادات الافتراضية
        CmbBaudRate.SelectedItem = defaultBaudRate.ToString()
        CmbPortName.SelectedItem = defaultPortName
    End Sub

    ' تحديث إعدادات Baud Rate عند التغيير
    Private Sub CmbBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBaudRate.SelectedIndexChanged
        ' تحديث إعدادات Baud Rate عند التغيير
        If CmbBaudRate.SelectedItem IsNot Nothing Then
            defaultBaudRate = Integer.Parse(CmbBaudRate.SelectedItem.ToString())
        End If
    End Sub

    ' تحديث إعدادات منفذ COM عند التغيير
    Private Sub CmbPortName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPortName.SelectedIndexChanged

        If CmbPortName.SelectedItem IsNot Nothing Then
            defaultPortName = CmbPortName.SelectedItem.ToString()
        End If
    End Sub

    ' فتح المنفذ التسلسلي بالإعدادات المحددة
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click, Button1.Click

        Try
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
            End If

            SerialPort1.PortName = defaultPortName
            SerialPort1.BaudRate = defaultBaudRate
            SerialPort1.Parity = defaultParity
            SerialPort1.DataBits = defaultDataBits
            SerialPort1.StopBits = defaultStopBits
            SerialPort1.Open()

            MessageBox.Show("Serial port opened successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error opening serial port: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' معالجة البيانات الواردة من المنفذ التسلسلي
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ' معالجة البيانات الواردة من المنفذ التسلسلي
        receivedData &= SerialPort1.ReadExisting()

        ' البحث عن أنماط مختلفة للبيانات (مثل "KG" أو "LB" أو غيرها)
        dataPosition = FindDataPattern(receivedData)

        If dataPosition > -1 Then
            scaleData = receivedData.Substring(dataPosition)
            receivedData = receivedData.Substring(dataPosition + scaleData.Length)
            UpdateLabel(ExtractWeight(scaleData))
        End If
    End Sub

    ' البحث عن أنماط مختلفة للبيانات (يمكن إضافة المزيد من الأنماط حسب الحاجة)
    Private Function FindDataPattern(data As String) As Integer

        Dim patterns As String() = {"KG", "LB", "G", "OZ"}
        For Each pattern In patterns
            Dim position As Integer = data.IndexOf(pattern)
            If position > -1 Then
                Return position
            End If
        Next
        Return -1
    End Function

    ' استخراج الوزن من البيانات (يمكن تعديل هذا بناءً على تنسيق البيانات)
    Private Function ExtractWeight(data As String) As String

        Dim weight As String = ""
        For Each c As Char In data
            If Char.IsDigit(c) Or c = "." Then
                weight &= c
            ElseIf weight.Length > 0 Then
                Exit For
            End If
        Next
        Return weight
    End Function

    ' تحديث التسمية في واجهة المستخدم
    Private Sub UpdateLabel(text As String)

        If LblMizan.InvokeRequired Then
            LblMizan.Invoke(New Action(Of String)(AddressOf UpdateLabel), text)
        Else
            LblMizan.Text = text
        End If
    End Sub

    ' إغلاق المنفذ التسلسلي عند إغلاق النموذج
    Private Sub SettingsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub

    ' نسخ النص من التسمية إلى مربع النص
    Private Sub TxtWight_Click(sender As Object, e As EventArgs) Handles TxtWight.Click

        TxtWight.Text = LblMizan.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click
        Close()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub


End Class

Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO.Ports
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FirstWeighingForm
    ' الاتصال بقاعدة البيانات
    Private connectionString As String = "Data Source=modylap;Initial Catalog=MSDMizannew;Integrated Security=True;Encrypt=False"
    '---------------------------------------
    'تعريف متغيرات للتحكم في الوزن
    Private receivedData As String = ""
    Private scaleData As String = ""
    Private dataPosition As Integer
    '----------------------------------------
    ' إعدادات المنفذ التسلسلي الافتراضية
    Private defaultPortName As String = "COM5"
    Private defaultBaudRate As Integer = 9600
    Private defaultParity As Parity = Parity.None
    Private defaultDataBits As Integer = 8
    Private defaultStopBits As StopBits = StopBits.One

    'اضافة
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'اضافة
        Dim query As String = "INSERT INTO MainMizan (CityID, AgentID, SortID, DriverID, UserName, UserPassword, CargoID, HFirst, TFirst, CarNo, First) VALUES (@CityID, @AgentID, @SortID, @DriverID, @UserName, @UserPassword, @CargoID, @HFirst, @TFirst, @CarNo, @First)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CityID", cmbCity.SelectedValue)
                cmd.Parameters.AddWithValue("@AgentID", cmbAgent.SelectedValue)
                cmd.Parameters.AddWithValue("@SortID", cmbSort.SelectedValue)
                cmd.Parameters.AddWithValue("@DriverID", cmbDriver.SelectedValue)
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text)
                cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text)
                cmd.Parameters.AddWithValue("@CargoID", cmbCargo.SelectedValue)
                cmd.Parameters.AddWithValue("@HFirst", dtpDateTime.Value)
                cmd.Parameters.AddWithValue("@TFirst", dtpDateTime.Value)
                cmd.Parameters.AddWithValue("@CarNo", txtCarNo.Text)
                cmd.Parameters.AddWithValue("@First", txtFirstWeight.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("تمت إضافة الوزنة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'اسم العميل
    'Private Sub LoadComboBoxAgentName()
    ' Using conn As New SqlConnection(connectionString)
    'Dim query As String = "SELECT AgentID, AgentName FROM Agents"
    'Using cmd As New SqlCommand(query, conn)
    '           conn.Open()
    'Dim adapter As New SqlDataAdapter(cmd)
    'Dim dt As New DataTable()
    '           adapter.Fill(dt)
    '          cmbAgent.DataSource = dt
    '         cmbAgent.DisplayMember = "AgentName"
    '        cmbAgent.ValueMember = "AgentID"
    'End Using
    'End Using
    'End Sub


    'اسم العميل
    Private Sub LoadComboBoxAgentName()
        'اسم العميل
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT AgentID, AgentName FROM Agents"
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                cmbAgent.Items.Add(New With {Key .Text = reader("AgentName").ToString(), Key .Value = reader("AgentID")})
            End While
            cmbAgent.DisplayMember = "Text"
            cmbAgent.ValueMember = "Value"
        End Using
    End Sub

    'الحمولة
    Private Sub LoadComboBoxcmbCargo()
        Dim query As String = "SELECT CargoID, CargoName FROM Cargo"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbCargo.DataSource = dt
                cmbCargo.DisplayMember = "CargoName"
                cmbCargo.ValueMember = "CargoID"
            End Using
        End Using
    End Sub

    'السائق
    Private Sub LoadComboBoxcmbDriver()
        Dim query As String = "SELECT DriverID, DriverName FROM Drivers"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbDriver.DataSource = dt
                cmbDriver.DisplayMember = "DriverName"
                cmbDriver.ValueMember = "DriverID"
            End Using
        End Using
    End Sub

    'المدينة
    Private Sub LoadComboBoxcmbCity()
        Dim query As String = "SELECT CityID, CityName FROM Citys"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbCity.DataSource = dt
                cmbCity.DisplayMember = "CityName"
                cmbCity.ValueMember = "CityID"
            End Using
        End Using
    End Sub

    'نوع الوزنة(شراء-مباع
    Private Sub LoadComboBoxcmbSort()
        Dim query As String = "SELECT SortID, Sort FROM Sorts"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbSort.DataSource = dt
                cmbSort.DisplayMember = "Sort"
                cmbSort.ValueMember = "SortID"
            End Using
        End Using
    End Sub

    'الفورم لوود
    Private Sub FirstWeighingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' تهيئة ComboBox بإعدادات Baud Rate
        CmbBaudRate.Text = "Select Baud Rate"
        CmbBaudRate.Items.AddRange({"1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "56000", "76800", "115200"})

        ' تهيئة ComboBox بإعدادات منافذ COM المتاحة
        CmbPortName.Text = "Select COM Port"
        CmbPortName.Items.AddRange(SerialPort.GetPortNames())

        ' تعيين الإعدادات الافتراضية
        CmbBaudRate.SelectedItem = defaultBaudRate.ToString()
        CmbPortName.SelectedItem = defaultPortName

        ' فتح المنفذ التسلسلي بالإعدادات المحددة
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
        '==================================

        ' اظهار اليوم
        TxtDay.Text = Now.ToString("dddd")

        'التاريخ
        TxtFWH.Text = Now.ToString("yyyy/MM/dd")

        'اظهار الوقت
        TxtSWT.Text = Now.ToString("T")
        '====================================
        'فوكس علي بوكس رقم السيارة
        txtCarNo.Focus()
        txtCarNo.Select()
        txtCarNo.SelectAll()
        '=================
        LoadComboBoxAgentName()
        LoadComboBoxcmbCargo()
        LoadComboBoxcmbDriver()
        LoadComboBoxcmbCity()
        LoadComboBoxcmbSort()
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
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub

    'تخزن الوزن داخل بوكس الوزنة
    Private Sub txtFirstWeight_Click(sender As Object, e As EventArgs) Handles txtFirstWeight.Click

        txtFirstWeight.Text = LblMizan.Text

    End Sub

    ' كود كتابة فقط الاراقم في تكست بوكس مع استخدام زر المسح والتراجع بدون استخدام المسافة
    Private Sub txtFirstWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstWeight.KeyPress
        On Error Resume Next
        ' كود كتابة فقط الاراقم في تكست بوكس مع استخدام زر المسح والتراجع بدون استخدام المسافة

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
        '''''''''''''''''''''''
    End Sub

    'ربط اليوم بالتاريخ
    Private Sub dtpDateTime_TextChanged(sender As Object, e As EventArgs) Handles dtpDateTime.TextChanged
        'ربط اليوم بالتاريخ
        'On Error Resume Next
        'If dtpDateTime.Text = "" Then
        'TxtDay.Text = ""
        ' Else
        'D'im day As Date = dtpDateTime.Text
        'T'xtDay.Text = dtpDateTime.Text
        'TxtDay.Text = Format(day, "dddd")
        ' End If
    End Sub

    'كود كاتبة الحروف العربية فقط في التكست مع استخدام زر المسح والتراجع والمسافة
    Private Sub cmbCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCity.KeyPress
        'كود كاتبة الحروف العربية فقط في التكست مع استخدام زر المسح والتراجع والمسافة

        Select Case e.KeyChar
            Case "ء" To "ي", ControlChars.Back, Chr(Keys.Space)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    'الانتقال الي رقم المقطورة
    Private Sub txtCarNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCarNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCarNo2.Focus()

        End If
    End Sub

    'الانتقال الي اسم العميل
    Private Sub cmbCity_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbAgent.Focus()

        End If
    End Sub

    'الانتقال الي بوكس المحافظة
    Private Sub txtCarNo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCarNo2.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbCity.Focus()

        End If
    End Sub

    'الانتقال الي بوكس السائق
    Private Sub cmbAgent_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbAgent.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDriver.Focus()

        End If
    End Sub

    'الانتقال الي بوكس البضاعة
    Private Sub cmbDriver_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDriver.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbCargo.Focus()

        End If
    End Sub

    'الانتقال الي بوكس نوع الوزنة
    Private Sub cmbCargo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCargo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbSort.Focus()

        End If
    End Sub

    'الانتقال الي تكست الوزنة الاولي
    Private Sub cmbSort_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSort.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFirstWeight.Focus()

        End If
    End Sub

    'الانتقال الي زر الاضافة
    Private Sub txtFirstWeight_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirstWeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAdd.Focus()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub
End Class
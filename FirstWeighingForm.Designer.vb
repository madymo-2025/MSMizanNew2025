<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstWeighingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.cmbDriver = New System.Windows.Forms.ComboBox()
        Me.cmbCargo = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtCarNo = New System.Windows.Forms.TextBox()
        Me.txtFirstWeight = New System.Windows.Forms.TextBox()
        Me.txtCarNo2 = New System.Windows.Forms.TextBox()
        Me.TxtDay = New System.Windows.Forms.TextBox()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.TxtFWH = New System.Windows.Forms.TextBox()
        Me.TxtSWT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMainMizanID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LblMizan = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.CmbPortName = New System.Windows.Forms.ComboBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(1156, 603)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(145, 60)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "اضافـــــــة"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(748, 603)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(145, 60)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(418, 603)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(145, 60)
        Me.BtnPrint.TabIndex = 13
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(17, 603)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(145, 60)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "خروج"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(974, 188)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(186, 27)
        Me.cmbCity.TabIndex = 3
        '
        'cmbAgent
        '
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(484, 194)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(219, 27)
        Me.cmbAgent.TabIndex = 4
        '
        'cmbSort
        '
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Location = New System.Drawing.Point(553, 305)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(150, 27)
        Me.cmbSort.TabIndex = 7
        '
        'cmbDriver
        '
        Me.cmbDriver.FormattingEnabled = True
        Me.cmbDriver.Location = New System.Drawing.Point(975, 242)
        Me.cmbDriver.Name = "cmbDriver"
        Me.cmbDriver.Size = New System.Drawing.Size(185, 27)
        Me.cmbDriver.TabIndex = 5
        '
        'cmbCargo
        '
        Me.cmbCargo.FormattingEnabled = True
        Me.cmbCargo.Location = New System.Drawing.Point(975, 302)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(185, 27)
        Me.cmbCargo.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(975, 358)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(185, 27)
        Me.txtUsername.TabIndex = 9
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(553, 355)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 27)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCarNo
        '
        Me.txtCarNo.Location = New System.Drawing.Point(975, 130)
        Me.txtCarNo.Name = "txtCarNo"
        Me.txtCarNo.Size = New System.Drawing.Size(185, 27)
        Me.txtCarNo.TabIndex = 0
        Me.txtCarNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFirstWeight
        '
        Me.txtFirstWeight.Location = New System.Drawing.Point(980, 467)
        Me.txtFirstWeight.Name = "txtFirstWeight"
        Me.txtFirstWeight.Size = New System.Drawing.Size(180, 27)
        Me.txtFirstWeight.TabIndex = 8
        Me.txtFirstWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCarNo2
        '
        Me.txtCarNo2.Location = New System.Drawing.Point(484, 133)
        Me.txtCarNo2.Name = "txtCarNo2"
        Me.txtCarNo2.Size = New System.Drawing.Size(219, 27)
        Me.txtCarNo2.TabIndex = 1
        Me.txtCarNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDay
        '
        Me.TxtDay.Location = New System.Drawing.Point(1060, 51)
        Me.TxtDay.Name = "TxtDay"
        Me.TxtDay.Size = New System.Drawing.Size(100, 27)
        Me.TxtDay.TabIndex = 14
        Me.TxtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpDateTime
        '
        Me.dtpDateTime.Location = New System.Drawing.Point(672, -4)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(172, 27)
        Me.dtpDateTime.TabIndex = 15
        Me.dtpDateTime.Visible = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(709, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "رقم المقطورة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1166, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "المحافظة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1166, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "اسم السائق"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(709, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "نوع الوزنة"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1166, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "البضاعة/الحمولة"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(709, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "اسم العميل"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1166, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 28)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "الوزنة الاولي"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1166, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "اسم المستخدم"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(709, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 21)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "كلمة المرور"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1166, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 27)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "رقم السيارة"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(1060, 14)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(100, 27)
        Me.TxtCode.TabIndex = 26
        Me.TxtCode.Text = "كود"
        Me.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFWH
        '
        Me.TxtFWH.Location = New System.Drawing.Point(653, 468)
        Me.TxtFWH.Name = "TxtFWH"
        Me.TxtFWH.Size = New System.Drawing.Size(182, 27)
        Me.TxtFWH.TabIndex = 9
        Me.TxtFWH.Text = "تاريخ"
        Me.TxtFWH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSWT
        '
        Me.TxtSWT.Location = New System.Drawing.Point(357, 468)
        Me.TxtSWT.Name = "TxtSWT"
        Me.TxtSWT.Size = New System.Drawing.Size(149, 27)
        Me.TxtSWT.TabIndex = 10
        Me.TxtSWT.Text = "وقت"
        Me.TxtSWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(837, 467)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 28)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "تاريخ الاولي"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(512, 468)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 27)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "وقت الاولي"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMainMizanID
        '
        Me.txtMainMizanID.Location = New System.Drawing.Point(932, 14)
        Me.txtMainMizanID.Name = "txtMainMizanID"
        Me.txtMainMizanID.Size = New System.Drawing.Size(100, 27)
        Me.txtMainMizanID.TabIndex = 31
        Me.txtMainMizanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gold
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(490, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(436, 80)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "شركة محمد ابوسريع"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1166, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 27)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "كود"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(894, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "جديد"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(407, 189)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 36)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "جديد"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(894, 242)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 38)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "جديد"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(894, 294)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 47)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "جديد"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LblMizan
        '
        Me.LblMizan.BackColor = System.Drawing.Color.Black
        Me.LblMizan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMizan.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMizan.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblMizan.Location = New System.Drawing.Point(17, 14)
        Me.LblMizan.Name = "LblMizan"
        Me.LblMizan.Size = New System.Drawing.Size(364, 80)
        Me.LblMizan.TabIndex = 38
        Me.LblMizan.Text = "Label15"
        Me.LblMizan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(387, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 80)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "KG"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialPort1
        '
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(214, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 21)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "COM Port"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(216, 215)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 21)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Baud Rate"
        '
        'CmbBaudRate
        '
        Me.CmbBaudRate.FormattingEnabled = True
        Me.CmbBaudRate.Location = New System.Drawing.Point(17, 212)
        Me.CmbBaudRate.Name = "CmbBaudRate"
        Me.CmbBaudRate.Size = New System.Drawing.Size(187, 27)
        Me.CmbBaudRate.TabIndex = 42
        '
        'CmbPortName
        '
        Me.CmbPortName.FormattingEnabled = True
        Me.CmbPortName.Location = New System.Drawing.Point(17, 166)
        Me.CmbPortName.Name = "CmbPortName"
        Me.CmbPortName.Size = New System.Drawing.Size(187, 27)
        Me.CmbPortName.TabIndex = 43
        '
        'BtnOpen
        '
        Me.BtnOpen.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.Location = New System.Drawing.Point(17, 112)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(121, 42)
        Me.BtnOpen.TabIndex = 46
        Me.BtnOpen.Text = "فتح الاتصال"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'FirstWeighingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1348, 694)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.CmbBaudRate)
        Me.Controls.Add(Me.CmbPortName)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblMizan)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMainMizanID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtSWT)
        Me.Controls.Add(Me.TxtFWH)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateTime)
        Me.Controls.Add(Me.TxtDay)
        Me.Controls.Add(Me.txtCarNo2)
        Me.Controls.Add(Me.txtFirstWeight)
        Me.Controls.Add(Me.txtCarNo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.cmbCargo)
        Me.Controls.Add(Me.cmbDriver)
        Me.Controls.Add(Me.cmbSort)
        Me.Controls.Add(Me.cmbAgent)
        Me.Controls.Add(Me.cmbCity)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.KeyPreview = True
        Me.Name = "FirstWeighingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الوزنة الاولي"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents cmbSort As ComboBox
    Friend WithEvents cmbDriver As ComboBox
    Friend WithEvents cmbCargo As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtCarNo As TextBox
    Friend WithEvents txtFirstWeight As TextBox
    Friend WithEvents txtCarNo2 As TextBox
    Friend WithEvents TxtDay As TextBox
    Friend WithEvents dtpDateTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtFWH As TextBox
    Friend WithEvents TxtSWT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMainMizanID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents LblMizan As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CmbBaudRate As ComboBox
    Friend WithEvents CmbPortName As ComboBox
    Friend WithEvents BtnOpen As Button
End Class

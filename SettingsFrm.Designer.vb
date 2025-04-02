<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsFrm
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
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CmbPortName = New System.Windows.Forms.ComboBox()
        Me.CmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.TxtWight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblMizan = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(288, 294)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(109, 33)
        Me.BtnOpen.TabIndex = 1
        Me.BtnOpen.Text = " فتح الاتصال"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = " فتح الاتصال"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CmbPortName
        '
        Me.CmbPortName.FormattingEnabled = True
        Me.CmbPortName.Location = New System.Drawing.Point(11, 164)
        Me.CmbPortName.Name = "CmbPortName"
        Me.CmbPortName.Size = New System.Drawing.Size(187, 27)
        Me.CmbPortName.TabIndex = 12
        '
        'CmbBaudRate
        '
        Me.CmbBaudRate.FormattingEnabled = True
        Me.CmbBaudRate.Location = New System.Drawing.Point(9, 231)
        Me.CmbBaudRate.Name = "CmbBaudRate"
        Me.CmbBaudRate.Size = New System.Drawing.Size(187, 27)
        Me.CmbBaudRate.TabIndex = 11
        '
        'TxtWight
        '
        Me.TxtWight.Location = New System.Drawing.Point(11, 110)
        Me.TxtWight.Name = "TxtWight"
        Me.TxtWight.Size = New System.Drawing.Size(134, 27)
        Me.TxtWight.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(208, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Baud Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(208, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "COM Port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(151, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "انقر هنــــــــــا"
        '
        'LblMizan
        '
        Me.LblMizan.BackColor = System.Drawing.Color.Black
        Me.LblMizan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMizan.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMizan.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblMizan.Location = New System.Drawing.Point(9, 14)
        Me.LblMizan.Name = "LblMizan"
        Me.LblMizan.Size = New System.Drawing.Size(396, 90)
        Me.LblMizan.TabIndex = 0
        Me.LblMizan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblMizan)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtWight)
        Me.Panel2.Controls.Add(Me.CmbBaudRate)
        Me.Panel2.Controls.Add(Me.CmbPortName)
        Me.Panel2.Location = New System.Drawing.Point(12, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 340)
        Me.Panel2.TabIndex = 17
        '
        'SettingsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 654)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "SettingsFrm"
        Me.Text = "SettingsFrm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnOpen As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CmbPortName As ComboBox
    Friend WithEvents CmbBaudRate As ComboBox
    Friend WithEvents TxtWight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblMizan As Label
    Friend WithEvents Panel2 As Panel
End Class

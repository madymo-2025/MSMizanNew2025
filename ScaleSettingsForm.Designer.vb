<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScaleSettingsForm
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
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtBaudRate = New System.Windows.Forms.TextBox()
        Me.txtHandshake = New System.Windows.Forms.TextBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDataBits = New System.Windows.Forms.TextBox()
        Me.txtParity = New System.Windows.Forms.TextBox()
        Me.txtStopBits = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(106, 162)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 27)
        Me.txtPort.TabIndex = 0
        '
        'txtBaudRate
        '
        Me.txtBaudRate.Location = New System.Drawing.Point(106, 204)
        Me.txtBaudRate.Name = "txtBaudRate"
        Me.txtBaudRate.Size = New System.Drawing.Size(100, 27)
        Me.txtBaudRate.TabIndex = 1
        '
        'txtHandshake
        '
        Me.txtHandshake.Location = New System.Drawing.Point(106, 256)
        Me.txtHandshake.Name = "txtHandshake"
        Me.txtHandshake.Size = New System.Drawing.Size(100, 27)
        Me.txtHandshake.TabIndex = 2
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(959, 561)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(155, 65)
        Me.btnSaveSettings.TabIndex = 3
        Me.btnSaveSettings.Text = "حفظ اعدادت الميزان"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 561)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 65)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDataBits
        '
        Me.txtDataBits.Location = New System.Drawing.Point(106, 308)
        Me.txtDataBits.Name = "txtDataBits"
        Me.txtDataBits.Size = New System.Drawing.Size(100, 27)
        Me.txtDataBits.TabIndex = 7
        '
        'txtParity
        '
        Me.txtParity.Location = New System.Drawing.Point(106, 359)
        Me.txtParity.Name = "txtParity"
        Me.txtParity.Size = New System.Drawing.Size(100, 27)
        Me.txtParity.TabIndex = 6
        '
        'txtStopBits
        '
        Me.txtStopBits.Location = New System.Drawing.Point(102, 404)
        Me.txtStopBits.Name = "txtStopBits"
        Me.txtStopBits.Size = New System.Drawing.Size(100, 27)
        Me.txtStopBits.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "BaudRate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Handshake"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DataBits"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Parity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "StopBits"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(822, 70)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 55)
        Me.TextBox1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(34, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 36)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Label7"
        '
        'ScaleSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 638)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDataBits)
        Me.Controls.Add(Me.txtParity)
        Me.Controls.Add(Me.txtStopBits)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.txtHandshake)
        Me.Controls.Add(Me.txtBaudRate)
        Me.Controls.Add(Me.txtPort)
        Me.Name = "ScaleSettingsForm"
        Me.Text = "ScaleSettingsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtBaudRate As TextBox
    Friend WithEvents txtHandshake As TextBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtDataBits As TextBox
    Friend WithEvents txtParity As TextBox
    Friend WithEvents txtStopBits As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
End Class

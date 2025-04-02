<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.btnSearchClient = New System.Windows.Forms.Button()
        Me.btnSearchCargo = New System.Windows.Forms.Button()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchCar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchClient
        '
        Me.btnSearchClient.Location = New System.Drawing.Point(937, 158)
        Me.btnSearchClient.Name = "btnSearchClient"
        Me.btnSearchClient.Size = New System.Drawing.Size(185, 84)
        Me.btnSearchClient.TabIndex = 0
        Me.btnSearchClient.Text = "عميل خلال فترة"
        Me.btnSearchClient.UseVisualStyleBackColor = True
        '
        'btnSearchCargo
        '
        Me.btnSearchCargo.Location = New System.Drawing.Point(631, 164)
        Me.btnSearchCargo.Name = "btnSearchCargo"
        Me.btnSearchCargo.Size = New System.Drawing.Size(183, 63)
        Me.btnSearchCargo.TabIndex = 1
        Me.btnSearchCargo.Text = "حمولة خلال فترة"
        Me.btnSearchCargo.UseVisualStyleBackColor = True
        '
        'cmbAgent
        '
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(12, 23)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(209, 27)
        Me.cmbAgent.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(21, 200)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox2.TabIndex = 3
        '
        'dgvReports
        '
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(28, 243)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowHeadersWidth = 62
        Me.dgvReports.RowTemplate.Height = 29
        Me.dgvReports.Size = New System.Drawing.Size(1160, 150)
        Me.dgvReports.TabIndex = 4
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(21, 88)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 27)
        Me.dtpStartDate.TabIndex = 5
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(21, 145)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 27)
        Me.dtpEndDate.TabIndex = 6
        '
        'btnSearchCar
        '
        Me.btnSearchCar.Location = New System.Drawing.Point(320, 158)
        Me.btnSearchCar.Name = "btnSearchCar"
        Me.btnSearchCar.Size = New System.Drawing.Size(185, 74)
        Me.btnSearchCar.TabIndex = 7
        Me.btnSearchCar.Text = "سيارة خلال فترة"
        Me.btnSearchCar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 477)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 67)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 67)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 556)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnSearchCar)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.dgvReports)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.cmbAgent)
        Me.Controls.Add(Me.btnSearchCargo)
        Me.Controls.Add(Me.btnSearchClient)
        Me.Name = "ReportsForm"
        Me.Text = "ReportsForm"
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSearchClient As Button
    Friend WithEvents btnSearchCargo As Button
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnSearchCar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class

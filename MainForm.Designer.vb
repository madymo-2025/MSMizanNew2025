<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFirstWeighing = New System.Windows.Forms.Button()
        Me.btnSecondWeighing = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnScaleSettings = New System.Windows.Forms.Button()
        Me.btnAdditions = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFirstWeighing
        '
        Me.btnFirstWeighing.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstWeighing.Location = New System.Drawing.Point(1064, 44)
        Me.btnFirstWeighing.Name = "btnFirstWeighing"
        Me.btnFirstWeighing.Size = New System.Drawing.Size(190, 80)
        Me.btnFirstWeighing.TabIndex = 0
        Me.btnFirstWeighing.Text = "الوزنــــــــــة الاولي"
        Me.btnFirstWeighing.UseVisualStyleBackColor = True
        '
        'btnSecondWeighing
        '
        Me.btnSecondWeighing.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecondWeighing.Location = New System.Drawing.Point(596, 44)
        Me.btnSecondWeighing.Name = "btnSecondWeighing"
        Me.btnSecondWeighing.Size = New System.Drawing.Size(190, 80)
        Me.btnSecondWeighing.TabIndex = 1
        Me.btnSecondWeighing.Text = "الوزنــــــــــــة الثانية"
        Me.btnSecondWeighing.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(51, 267)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(190, 80)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "التقاريــــــر"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnScaleSettings
        '
        Me.btnScaleSettings.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScaleSettings.Location = New System.Drawing.Point(1064, 267)
        Me.btnScaleSettings.Name = "btnScaleSettings"
        Me.btnScaleSettings.Size = New System.Drawing.Size(190, 80)
        Me.btnScaleSettings.TabIndex = 3
        Me.btnScaleSettings.Text = "ضبط الاعدادات"
        Me.btnScaleSettings.UseVisualStyleBackColor = True
        '
        'btnAdditions
        '
        Me.btnAdditions.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdditions.Location = New System.Drawing.Point(596, 427)
        Me.btnAdditions.Name = "btnAdditions"
        Me.btnAdditions.Size = New System.Drawing.Size(190, 80)
        Me.btnAdditions.TabIndex = 6
        Me.btnAdditions.Text = "اضافة/عميل-حمولة"
        Me.btnAdditions.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(21, 581)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(107, 44)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "خروج"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(51, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 80)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "وزن سيارة معلومة"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(596, 267)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(190, 80)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "طباعة بيانات سابقة"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1281, 651)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnAdditions)
        Me.Controls.Add(Me.btnScaleSettings)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnSecondWeighing)
        Me.Controls.Add(Me.btnFirstWeighing)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFirstWeighing As Button
    Friend WithEvents btnSecondWeighing As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnScaleSettings As Button
    Friend WithEvents btnAdditions As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnPrint As Button
End Class

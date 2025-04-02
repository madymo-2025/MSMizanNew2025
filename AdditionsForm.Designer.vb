<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdditionsForm
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
        Me.btnSaveClient = New System.Windows.Forms.Button()
        Me.txtNewClient = New System.Windows.Forms.TextBox()
        Me.btnSaveCargo = New System.Windows.Forms.Button()
        Me.txtNewCargo = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaveClient
        '
        Me.btnSaveClient.Location = New System.Drawing.Point(584, 149)
        Me.btnSaveClient.Name = "btnSaveClient"
        Me.btnSaveClient.Size = New System.Drawing.Size(204, 37)
        Me.btnSaveClient.TabIndex = 0
        Me.btnSaveClient.Text = "اضافة عميل جديد"
        Me.btnSaveClient.UseVisualStyleBackColor = True
        '
        'txtNewClient
        '
        Me.txtNewClient.Location = New System.Drawing.Point(354, 149)
        Me.txtNewClient.Name = "txtNewClient"
        Me.txtNewClient.Size = New System.Drawing.Size(224, 27)
        Me.txtNewClient.TabIndex = 1
        '
        'btnSaveCargo
        '
        Me.btnSaveCargo.Location = New System.Drawing.Point(584, 280)
        Me.btnSaveCargo.Name = "btnSaveCargo"
        Me.btnSaveCargo.Size = New System.Drawing.Size(204, 37)
        Me.btnSaveCargo.TabIndex = 2
        Me.btnSaveCargo.Text = "اضافة حمولة جديدة"
        Me.btnSaveCargo.UseVisualStyleBackColor = True
        '
        'txtNewCargo
        '
        Me.txtNewCargo.Location = New System.Drawing.Point(354, 286)
        Me.txtNewCargo.Name = "txtNewCargo"
        Me.txtNewCargo.Size = New System.Drawing.Size(224, 27)
        Me.txtNewCargo.TabIndex = 3
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(25, 379)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(121, 47)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "خروج"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'AdditionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.txtNewCargo)
        Me.Controls.Add(Me.btnSaveCargo)
        Me.Controls.Add(Me.txtNewClient)
        Me.Controls.Add(Me.btnSaveClient)
        Me.Name = "AdditionsForm"
        Me.Text = "AdditionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveClient As Button
    Friend WithEvents txtNewClient As TextBox
    Friend WithEvents btnSaveCargo As Button
    Friend WithEvents txtNewCargo As TextBox
    Friend WithEvents BtnExit As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHouseholdIncome
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
        Me.cboCountyState = New System.Windows.Forms.ComboBox()
        Me.txtYearlyIncome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnTotalSurveyed = New System.Windows.Forms.Button()
        Me.btnAverageIncome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboCountyState
        '
        Me.cboCountyState.FormattingEnabled = True
        Me.cboCountyState.Items.AddRange(New Object() {"", "Hamilton, OH", "Butler, OH", "Clermont, OH", "Warren, OH", "Campbell, KY", "Boone, KY", "Kenton, KY"})
        Me.cboCountyState.Location = New System.Drawing.Point(223, 70)
        Me.cboCountyState.Name = "cboCountyState"
        Me.cboCountyState.Size = New System.Drawing.Size(186, 24)
        Me.cboCountyState.TabIndex = 0
        '
        'txtYearlyIncome
        '
        Me.txtYearlyIncome.Location = New System.Drawing.Point(223, 119)
        Me.txtYearlyIncome.Name = "txtYearlyIncome"
        Me.txtYearlyIncome.Size = New System.Drawing.Size(186, 22)
        Me.txtYearlyIncome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select County:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Yearly Income:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(49, 225)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(84, 45)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnTotalSurveyed
        '
        Me.btnTotalSurveyed.Location = New System.Drawing.Point(151, 225)
        Me.btnTotalSurveyed.Name = "btnTotalSurveyed"
        Me.btnTotalSurveyed.Size = New System.Drawing.Size(84, 45)
        Me.btnTotalSurveyed.TabIndex = 5
        Me.btnTotalSurveyed.Text = "Total Surveyed"
        Me.btnTotalSurveyed.UseVisualStyleBackColor = True
        '
        'btnAverageIncome
        '
        Me.btnAverageIncome.Location = New System.Drawing.Point(253, 225)
        Me.btnAverageIncome.Name = "btnAverageIncome"
        Me.btnAverageIncome.Size = New System.Drawing.Size(84, 45)
        Me.btnAverageIncome.TabIndex = 6
        Me.btnAverageIncome.Text = "Average Income"
        Me.btnAverageIncome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(355, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 45)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmHouseholdIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 342)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAverageIncome)
        Me.Controls.Add(Me.btnTotalSurveyed)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYearlyIncome)
        Me.Controls.Add(Me.cboCountyState)
        Me.Name = "frmHouseholdIncome"
        Me.Text = "Household Income Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCountyState As ComboBox
    Friend WithEvents txtYearlyIncome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnTotalSurveyed As Button
    Friend WithEvents btnAverageIncome As Button
    Friend WithEvents btnExit As Button
End Class

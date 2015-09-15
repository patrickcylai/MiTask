<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class optAddTaskWizard
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
        Me.lblSubjectsAvailable = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstboxSubjectsAvailable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblSubjectsAvailable
        '
        Me.lblSubjectsAvailable.AutoSize = True
        Me.lblSubjectsAvailable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectsAvailable.Location = New System.Drawing.Point(10, 9)
        Me.lblSubjectsAvailable.Name = "lblSubjectsAvailable"
        Me.lblSubjectsAvailable.Size = New System.Drawing.Size(104, 13)
        Me.lblSubjectsAvailable.TabIndex = 1
        Me.lblSubjectsAvailable.Text = "Subjects Available:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(334, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(253, 224)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please select the subject from " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Subjects Available List " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to a assign a task" & _
    " to. "
        '
        'lstboxSubjectsAvailable
        '
        Me.lstboxSubjectsAvailable.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxSubjectsAvailable.FormattingEnabled = True
        Me.lstboxSubjectsAvailable.ItemHeight = 25
        Me.lstboxSubjectsAvailable.Location = New System.Drawing.Point(13, 32)
        Me.lstboxSubjectsAvailable.Name = "lstboxSubjectsAvailable"
        Me.lstboxSubjectsAvailable.Size = New System.Drawing.Size(211, 179)
        Me.lstboxSubjectsAvailable.TabIndex = 5
        '
        'optAddTaskWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(421, 259)
        Me.Controls.Add(Me.lstboxSubjectsAvailable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSubjectsAvailable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "optAddTaskWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Task Wizard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubjectsAvailable As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstboxSubjectsAvailable As System.Windows.Forms.ListBox
End Class

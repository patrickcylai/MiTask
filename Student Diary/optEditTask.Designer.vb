<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class optEditTask
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(optEditTask))
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.dateDue = New System.Windows.Forms.DateTimePicker()
        Me.lbldateDue = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gpboxStatus = New System.Windows.Forms.GroupBox()
        Me.rdbtnCompleted = New System.Windows.Forms.RadioButton()
        Me.rdbtnInProgress = New System.Windows.Forms.RadioButton()
        Me.rdbtnNotStarted = New System.Windows.Forms.RadioButton()
        Me.txtCreated = New System.Windows.Forms.TextBox()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.gpboxStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(13, 13)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(53, 17)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Subject"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(72, 14)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(100, 20)
        Me.txtSubject.TabIndex = 1
        Me.txtSubject.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(16, 65)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(347, 22)
        Me.txtDescription.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(13, 49)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description"
        '
        'dateDue
        '
        Me.dateDue.Location = New System.Drawing.Point(16, 123)
        Me.dateDue.Name = "dateDue"
        Me.dateDue.Size = New System.Drawing.Size(200, 20)
        Me.dateDue.TabIndex = 5
        '
        'lbldateDue
        '
        Me.lbldateDue.AutoSize = True
        Me.lbldateDue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateDue.Location = New System.Drawing.Point(13, 103)
        Me.lbldateDue.Name = "lbldateDue"
        Me.lbldateDue.Size = New System.Drawing.Size(33, 17)
        Me.lbldateDue.TabIndex = 6
        Me.lbldateDue.Text = "Due"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(348, 120)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(429, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gpboxStatus
        '
        Me.gpboxStatus.Controls.Add(Me.rdbtnCompleted)
        Me.gpboxStatus.Controls.Add(Me.rdbtnInProgress)
        Me.gpboxStatus.Controls.Add(Me.rdbtnNotStarted)
        Me.gpboxStatus.Location = New System.Drawing.Point(373, 7)
        Me.gpboxStatus.Name = "gpboxStatus"
        Me.gpboxStatus.Size = New System.Drawing.Size(124, 96)
        Me.gpboxStatus.TabIndex = 9
        Me.gpboxStatus.TabStop = False
        Me.gpboxStatus.Text = "Status"
        '
        'rdbtnCompleted
        '
        Me.rdbtnCompleted.AutoSize = True
        Me.rdbtnCompleted.Location = New System.Drawing.Point(8, 66)
        Me.rdbtnCompleted.Name = "rdbtnCompleted"
        Me.rdbtnCompleted.Size = New System.Drawing.Size(75, 17)
        Me.rdbtnCompleted.TabIndex = 2
        Me.rdbtnCompleted.Text = "Completed"
        Me.rdbtnCompleted.UseVisualStyleBackColor = True
        '
        'rdbtnInProgress
        '
        Me.rdbtnInProgress.AutoSize = True
        Me.rdbtnInProgress.Location = New System.Drawing.Point(7, 43)
        Me.rdbtnInProgress.Name = "rdbtnInProgress"
        Me.rdbtnInProgress.Size = New System.Drawing.Size(78, 17)
        Me.rdbtnInProgress.TabIndex = 1
        Me.rdbtnInProgress.Text = "In Progress"
        Me.rdbtnInProgress.UseVisualStyleBackColor = True
        '
        'rdbtnNotStarted
        '
        Me.rdbtnNotStarted.AutoSize = True
        Me.rdbtnNotStarted.Checked = True
        Me.rdbtnNotStarted.Location = New System.Drawing.Point(7, 20)
        Me.rdbtnNotStarted.Name = "rdbtnNotStarted"
        Me.rdbtnNotStarted.Size = New System.Drawing.Size(79, 17)
        Me.rdbtnNotStarted.TabIndex = 0
        Me.rdbtnNotStarted.TabStop = True
        Me.rdbtnNotStarted.Text = "Not Started"
        Me.rdbtnNotStarted.UseVisualStyleBackColor = True
        '
        'txtCreated
        '
        Me.txtCreated.Location = New System.Drawing.Point(263, 14)
        Me.txtCreated.Name = "txtCreated"
        Me.txtCreated.ReadOnly = True
        Me.txtCreated.Size = New System.Drawing.Size(100, 20)
        Me.txtCreated.TabIndex = 10
        Me.txtCreated.TabStop = False
        '
        'lblCreated
        '
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreated.Location = New System.Drawing.Point(202, 13)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(55, 17)
        Me.lblCreated.TabIndex = 11
        Me.lblCreated.Text = "Created"
        '
        'optEditTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(516, 159)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.txtCreated)
        Me.Controls.Add(Me.gpboxStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lbldateDue)
        Me.Controls.Add(Me.dateDue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSubject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "optEditTask"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Task"
        Me.gpboxStatus.ResumeLayout(False)
        Me.gpboxStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents dateDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldateDue As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents gpboxStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnCompleted As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnInProgress As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnNotStarted As System.Windows.Forms.RadioButton
    Friend WithEvents txtCreated As System.Windows.Forms.TextBox
    Friend WithEvents lblCreated As System.Windows.Forms.Label
End Class

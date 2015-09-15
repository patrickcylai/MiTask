<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class optAddTaskWizard2
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
        Me.gpboxStatus = New System.Windows.Forms.GroupBox()
        Me.rdbtnCompleted = New System.Windows.Forms.RadioButton()
        Me.rdbtnInProgress = New System.Windows.Forms.RadioButton()
        Me.rdbtnNotStarted = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbldateDue = New System.Windows.Forms.Label()
        Me.dateDue = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblDescriptionAssist = New System.Windows.Forms.Label()
        Me.lblStatusAssist = New System.Windows.Forms.Label()
        Me.lblDueAssist = New System.Windows.Forms.Label()
        Me.lblAddAssist = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gpboxStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpboxStatus
        '
        Me.gpboxStatus.Controls.Add(Me.rdbtnCompleted)
        Me.gpboxStatus.Controls.Add(Me.rdbtnInProgress)
        Me.gpboxStatus.Controls.Add(Me.rdbtnNotStarted)
        Me.gpboxStatus.Location = New System.Drawing.Point(431, 9)
        Me.gpboxStatus.Name = "gpboxStatus"
        Me.gpboxStatus.Size = New System.Drawing.Size(124, 96)
        Me.gpboxStatus.TabIndex = 2
        Me.gpboxStatus.TabStop = False
        Me.gpboxStatus.Text = "Status"
        Me.ToolTip1.SetToolTip(Me.gpboxStatus, "This is where you select the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "appropriate status of the task")
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(480, 226)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(399, 226)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Click to add the task.")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lbldateDue
        '
        Me.lbldateDue.AutoSize = True
        Me.lbldateDue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateDue.Location = New System.Drawing.Point(12, 109)
        Me.lbldateDue.Name = "lbldateDue"
        Me.lbldateDue.Size = New System.Drawing.Size(33, 17)
        Me.lbldateDue.TabIndex = 24
        Me.lbldateDue.Text = "Due"
        '
        'dateDue
        '
        Me.dateDue.Location = New System.Drawing.Point(15, 128)
        Me.dateDue.Name = "dateDue"
        Me.dateDue.Size = New System.Drawing.Size(200, 20)
        Me.dateDue.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.dateDue, "Please set an appropriate Due date for your task.")
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(15, 68)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(345, 22)
        Me.txtDescription.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtDescription, "This is where you describe the task to be completed.")
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(12, 52)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 21
        Me.lblDescription.Text = "Description"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(71, 10)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(100, 20)
        Me.txtSubject.TabIndex = 20
        Me.txtSubject.TabStop = False
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(12, 9)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(53, 17)
        Me.lblSubject.TabIndex = 19
        Me.lblSubject.Text = "Subject"
        '
        'lblDescriptionAssist
        '
        Me.lblDescriptionAssist.AutoSize = True
        Me.lblDescriptionAssist.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescriptionAssist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionAssist.Location = New System.Drawing.Point(105, 52)
        Me.lblDescriptionAssist.Name = "lblDescriptionAssist"
        Me.lblDescriptionAssist.Size = New System.Drawing.Size(275, 13)
        Me.lblDescriptionAssist.TabIndex = 28
        Me.lblDescriptionAssist.Text = "This is where you describe the task to be completed."
        Me.lblDescriptionAssist.Visible = False
        '
        'lblStatusAssist
        '
        Me.lblStatusAssist.AutoSize = True
        Me.lblStatusAssist.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStatusAssist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusAssist.Location = New System.Drawing.Point(396, 109)
        Me.lblStatusAssist.Name = "lblStatusAssist"
        Me.lblStatusAssist.Size = New System.Drawing.Size(163, 26)
        Me.lblStatusAssist.TabIndex = 29
        Me.lblStatusAssist.Text = "This is where you select the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "appropriate status of the task."
        Me.lblStatusAssist.Visible = False
        '
        'lblDueAssist
        '
        Me.lblDueAssist.AutoSize = True
        Me.lblDueAssist.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDueAssist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueAssist.Location = New System.Drawing.Point(221, 128)
        Me.lblDueAssist.Name = "lblDueAssist"
        Me.lblDueAssist.Size = New System.Drawing.Size(140, 26)
        Me.lblDueAssist.TabIndex = 30
        Me.lblDueAssist.Text = "Please set an appropriate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Due Date for your task."
        Me.lblDueAssist.Visible = False
        '
        'lblAddAssist
        '
        Me.lblAddAssist.AutoSize = True
        Me.lblAddAssist.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAddAssist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddAssist.Location = New System.Drawing.Point(359, 210)
        Me.lblAddAssist.Name = "lblAddAssist"
        Me.lblAddAssist.Size = New System.Drawing.Size(115, 13)
        Me.lblAddAssist.TabIndex = 31
        Me.lblAddAssist.Text = "Click to add the task."
        Me.lblAddAssist.Visible = False
        '
        'optAddTaskWizard2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(567, 261)
        Me.Controls.Add(Me.lblAddAssist)
        Me.Controls.Add(Me.lblDueAssist)
        Me.Controls.Add(Me.lblStatusAssist)
        Me.Controls.Add(Me.lblDescriptionAssist)
        Me.Controls.Add(Me.gpboxStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbldateDue)
        Me.Controls.Add(Me.dateDue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSubject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "optAddTaskWizard2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Task Wizard"
        Me.gpboxStatus.ResumeLayout(False)
        Me.gpboxStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpboxStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnCompleted As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnInProgress As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnNotStarted As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbldateDue As System.Windows.Forms.Label
    Friend WithEvents dateDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblDescriptionAssist As System.Windows.Forms.Label
    Friend WithEvents lblStatusAssist As System.Windows.Forms.Label
    Friend WithEvents lblDueAssist As System.Windows.Forms.Label
    Friend WithEvents lblAddAssist As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

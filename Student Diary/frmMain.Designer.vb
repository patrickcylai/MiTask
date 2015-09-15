<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstviewTasks = New System.Windows.Forms.ListView()
        Me.ColumnHeaderDue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnRemoveTask = New System.Windows.Forms.Button()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.lstviewSubjects = New System.Windows.Forms.ListView()
        Me.btnRemoveSubject = New System.Windows.Forms.Button()
        Me.lblTasks = New System.Windows.Forms.Label()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.lblSubjects = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.SystemColors.HighlightText
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(992, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectToolStripMenuItem, Me.TaskToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SubjectToolStripMenuItem.Text = "Subject"
        '
        'TaskToolStripMenuItem
        '
        Me.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem"
        Me.TaskToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.TaskToolStripMenuItem.Text = "Task"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HelpToolStripMenuItem.Text = "HELP"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AboutToolStripMenuItem.Text = "About MiTasks"
        '
        'lstviewTasks
        '
        Me.lstviewTasks.BackColor = System.Drawing.SystemColors.Window
        Me.lstviewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstviewTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderDue, Me.ColumnHeaderCreated, Me.ColumnHeaderDescription, Me.ColumnHeaderStatus})
        Me.lstviewTasks.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstviewTasks.FullRowSelect = True
        Me.lstviewTasks.HideSelection = False
        Me.lstviewTasks.Location = New System.Drawing.Point(235, 65)
        Me.lstviewTasks.Name = "lstviewTasks"
        Me.lstviewTasks.Size = New System.Drawing.Size(490, 563)
        Me.lstviewTasks.TabIndex = 28
        Me.lstviewTasks.UseCompatibleStateImageBehavior = False
        Me.lstviewTasks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderDue
        '
        Me.ColumnHeaderDue.Text = "Due"
        Me.ColumnHeaderDue.Width = 77
        '
        'ColumnHeaderCreated
        '
        Me.ColumnHeaderCreated.Text = "Created"
        Me.ColumnHeaderCreated.Width = 72
        '
        'ColumnHeaderDescription
        '
        Me.ColumnHeaderDescription.Text = "Description"
        Me.ColumnHeaderDescription.Width = 242
        '
        'ColumnHeaderStatus
        '
        Me.ColumnHeaderStatus.Text = "Status"
        Me.ColumnHeaderStatus.Width = 96
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendar1.Location = New System.Drawing.Point(747, 75)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'btnRemoveTask
        '
        Me.btnRemoveTask.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveTask.Location = New System.Drawing.Point(702, 39)
        Me.btnRemoveTask.Name = "btnRemoveTask"
        Me.btnRemoveTask.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveTask.TabIndex = 4
        Me.btnRemoveTask.Tag = "Remove Task"
        Me.btnRemoveTask.Text = "-"
        Me.ToolTip1.SetToolTip(Me.btnRemoveTask, "Remove Task")
        Me.btnRemoveTask.UseVisualStyleBackColor = True
        '
        'btnAddTask
        '
        Me.btnAddTask.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTask.Location = New System.Drawing.Point(673, 39)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(23, 23)
        Me.btnAddTask.TabIndex = 3
        Me.btnAddTask.Tag = "Add Task"
        Me.btnAddTask.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnAddTask, "Add Task")
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'lstviewSubjects
        '
        Me.lstviewSubjects.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstviewSubjects.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstviewSubjects.BackColor = System.Drawing.Color.White
        Me.lstviewSubjects.BackgroundImageTiled = True
        Me.lstviewSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstviewSubjects.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstviewSubjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstviewSubjects.HideSelection = False
        Me.lstviewSubjects.Location = New System.Drawing.Point(0, 65)
        Me.lstviewSubjects.MultiSelect = False
        Me.lstviewSubjects.Name = "lstviewSubjects"
        Me.lstviewSubjects.Size = New System.Drawing.Size(240, 563)
        Me.lstviewSubjects.TabIndex = 1
        Me.lstviewSubjects.UseCompatibleStateImageBehavior = False
        Me.lstviewSubjects.View = System.Windows.Forms.View.List
        '
        'btnRemoveSubject
        '
        Me.btnRemoveSubject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSubject.Location = New System.Drawing.Point(204, 39)
        Me.btnRemoveSubject.Name = "btnRemoveSubject"
        Me.btnRemoveSubject.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveSubject.TabIndex = 2
        Me.btnRemoveSubject.Tag = "Remove Subject"
        Me.btnRemoveSubject.Text = "-"
        Me.ToolTip1.SetToolTip(Me.btnRemoveSubject, "Remove Subject")
        Me.btnRemoveSubject.UseVisualStyleBackColor = True
        '
        'lblTasks
        '
        Me.lblTasks.AutoSize = True
        Me.lblTasks.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblTasks.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTasks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTasks.Location = New System.Drawing.Point(243, 38)
        Me.lblTasks.Name = "lblTasks"
        Me.lblTasks.Size = New System.Drawing.Size(65, 25)
        Me.lblTasks.TabIndex = 23
        Me.lblTasks.Text = "TASKS"
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.Location = New System.Drawing.Point(175, 39)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(23, 23)
        Me.btnAddSubject.TabIndex = 1
        Me.btnAddSubject.Tag = "Add Subject"
        Me.btnAddSubject.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnAddSubject, "Add Subject")
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'lblSubjects
        '
        Me.lblSubjects.AutoSize = True
        Me.lblSubjects.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblSubjects.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjects.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSubjects.Location = New System.Drawing.Point(0, 38)
        Me.lblSubjects.Name = "lblSubjects"
        Me.lblSubjects.Size = New System.Drawing.Size(95, 25)
        Me.lblSubjects.TabIndex = 22
        Me.lblSubjects.Text = "SUBJECTS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox1.Location = New System.Drawing.Point(26, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1007, 25)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 627)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lstviewTasks)
        Me.Controls.Add(Me.btnRemoveTask)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.lstviewSubjects)
        Me.Controls.Add(Me.btnRemoveSubject)
        Me.Controls.Add(Me.lblTasks)
        Me.Controls.Add(Me.btnAddSubject)
        Me.Controls.Add(Me.lblSubjects)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MiTasks"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstviewTasks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeaderDue As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderCreated As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnRemoveTask As System.Windows.Forms.Button
    Friend WithEvents btnAddTask As System.Windows.Forms.Button
    Friend WithEvents lstviewSubjects As System.Windows.Forms.ListView
    Friend WithEvents btnRemoveSubject As System.Windows.Forms.Button
    Friend WithEvents lblTasks As System.Windows.Forms.Label
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents lblSubjects As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

Public Class frmMain

    'Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    'Confirms whether user wants to close program
    '    Dim check As DialogResult = MessageBox.Show _
    '                                ("Are you sure want to Exit?", "Close", _
    '                                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

    '    'Closes program when user clicks yes and ignores when the result is no
    '    If check = Windows.Forms.DialogResult.Yes Then
    '        e.Cancel = False
    '    Else
    '        e.Cancel = True
    '        Exit Sub
    '    End If

    'End Sub

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        checkSubjectDirectory()
        checkTasksDirectory()
        checkSubjectFile()
        loadSubjects()

        'Checks the status of each individual subject
        For icount As Integer = 0 To lstviewSubjects.Items.Count - 1
            Dim subject As String = lstviewSubjects.Items(icount).Text
            startupCheckTaskStatus(subject)
        Next

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnAddSubject_Click(sender As System.Object, e As System.EventArgs) Handles btnAddSubject.Click
        'Open Add Subject form
        optAddSubject.Show()
    End Sub

    Private Sub btnRemoveSubject_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveSubject.Click
        '==============================================
        'Remove selected Subject from 'Subject' Listbox
        '==============================================
        Try
            If lstviewSubjects.Items.Count < 1 Then
                MessageBox.Show("There are no subjects!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Dim currentItem As String = CStr(lstboxSubjects.SelectedItem)
            Dim currentItem As String = lstviewSubjects.FocusedItem.Text
            Dim currenIndex As Integer = lstviewSubjects.FocusedItem.Index
            'confirms whether user wants to delete entry
            Dim result As DialogResult = MessageBox.Show _
                                         ("Are you sure you want to delete " & "'" & currentItem & "'" & "?", "Delete Subject", _
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            'Deletes entry when user clicks 'yes' and does nothing when user clicks 'no'
            If result = Windows.Forms.DialogResult.Yes Then
                deleteSubjectTaskfile(currentItem)
                deleteLineSubject(lstviewSubjects.FocusedItem.Index)
                lstviewTasks.Items.Clear()
                lstviewSubjects.Items.Clear()
                loadSubjects()

                'Checks each available subject for their status
                For icount As Integer = 0 To lstviewSubjects.Items.Count - 1
                    Dim subject As String = lstviewSubjects.Items(icount).Text
                    startupCheckTaskStatus(subject)
                Next

            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Unhandled exception!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnAddTask_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTask.Click
        '=====================
        'Opens Add Task window
        '=====================
        Try
            If lstviewSubjects.Items.Count < 1 Then
                MessageBox.Show("There is no Subject to add Tasks to.", "No Subjects", _
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            Else
                optAddTask.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Please select an existing subject or create a new subject.", "No Subject Selection Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnRemoveTask_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveTask.Click
        '============================================================
        'Removes Task and removes listview listing and updates status
        '============================================================

        Try
            deleteLineTask(lstviewSubjects.FocusedItem.Text, lstviewTasks.FocusedItem.Index + 1)
            lstviewTasks.Items.RemoveAt(lstviewTasks.FocusedItem.Index)
            checkStatus()
        Catch ex As NullReferenceException
            MessageBox.Show("There are no tasks selected.", "No Task Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    'Private Sub lstviewSubjects_DrawItem(sender As Object, e As System.Windows.Forms.DrawListViewItemEventArgs) Handles lstviewSubjects.DrawItem
    '================================================
    'To enable change OwnerDraw of Listview to True
    '================================================
    '
    '    If e.Item.Selected = True Then
    '        e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
    '        e.DrawText(TextFormatFlags.TextBoxControl)
    '    ElseIf e.Item.ForeColor = Color.White Then
    '        e.Graphics.FillRectangle(Brushes.Orange, e.Bounds)
    '        e.DrawText(TextFormatFlags.TextBoxControl)
    '    Else
    '        e.Graphics.FillRectangle(Brushes.White, e.Bounds)
    '        e.DrawText(TextFormatFlags.TextBoxControl)
    '    End If
    'End Sub

    Private Sub lstviewSubjects_ItemActivate(sender As Object, e As System.EventArgs) Handles lstviewSubjects.ItemActivate
        If lstviewSubjects.Items.Count > 0 Then
            loadTasks(lstviewSubjects.FocusedItem.Text)
            checkStatus()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lstviewTasks_ItemActivate(sender As Object, e As System.EventArgs) Handles lstviewTasks.ItemActivate
        optEditTask.Show()
    End Sub


    Private Sub lstviewSubjects_ItemSelectionChanged(sender As Object, e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lstviewSubjects.ItemSelectionChanged
        Try
            If lstviewSubjects.Items.Count > 0 Then
                loadTasks(lstviewSubjects.FocusedItem.Text)
                checkStatus()
            Else
                Exit Sub
            End If
        Catch ex As NullReferenceException 'workaround to unknown bug in updating the listview for both Subjects and Tasks

        End Try
    End Sub

    Private Sub SubjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        optAddSubject.Show()
    End Sub

    Private Sub TaskToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaskToolStripMenuItem.Click
        optAddTaskWizard.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If PictureBox1.BackColor = Color.RoyalBlue Then
            PictureBox1.BackColor = Color.Orange
            lblSubjects.BackColor = Color.Orange
            lblTasks.BackColor = Color.Orange
        Else
            PictureBox1.BackColor = Color.RoyalBlue
            lblSubjects.BackColor = Color.RoyalBlue
            lblTasks.BackColor = Color.RoyalBlue
        End If
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\Help\Manual and Guide.pdf")
    End Sub
End Class

Public Class optAddTask

    Private Sub optAddTask_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Me.AcceptButton = btnAdd
            txtSubject.Text = frmMain.lstviewSubjects.FocusedItem.Text
            txtDescription.Focus()
        Catch ex As Exception
            MessageBox.Show("Please select an existing subject or create a new subject.", "No Subject Selection Error", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As System.EventArgs) Handles btnAdd.Click
        checkEmpty(txtDescription, lblDescription.Text)

        Dim status As String = ""
        'If FormatDateTime(dateDue.Value, DateFormat.ShortDate) < FormatDateTime(DateAndTime.Now, DateFormat.ShortDate) Then
        '    MessageBox.Show("The due date selected is set before the creation date.", _
        '                    "Due Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        If Not txtDescription.Text = "" Then

            If rdbtnNotStarted.Checked = True Then
                status = rdbtnNotStarted.Text
            ElseIf rdbtnInProgress.Checked = True Then
                status = rdbtnInProgress.Text
            ElseIf rdbtnCompleted.Checked = True Then
                status = rdbtnCompleted.Text
            End If

            appendSubjectTask(txtSubject.Text, dateDue.Value, txtDescription.Text, status)
            loadTasks(txtSubject.Text)

            checkStatus()

            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
Public Class optEditTask

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub optEditTask_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim status As String = frmMain.lstviewTasks.FocusedItem.SubItems(3).Text

        Select Case (status)
            Case "Not Started"
                rdbtnNotStarted.Checked = True
            Case "In Progress"
                rdbtnInProgress.Checked = True
            Case "Completed"
                rdbtnCompleted.Checked = True
        End Select

        txtCreated.Text = frmMain.lstviewTasks.FocusedItem.SubItems(1).Text
        txtDescription.Text = frmMain.lstviewTasks.FocusedItem.SubItems(2).Text
        dateDue.Value = CDate(frmMain.lstviewTasks.FocusedItem.Text)
        txtSubject.Text = frmMain.lstviewSubjects.FocusedItem.Text
        txtDescription.Focus()

    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        checkEmpty(txtDescription, lblDescription.Text)

        'If dateDue.Value < CDate(txtCreated.Text) Then
        '    MessageBox.Show("The due date selected is set before the creation date.", _
        '                    "Due Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        Dim status As String = ""

        If Not txtDescription.Text = "" Then

            If rdbtnNotStarted.Checked = True Then
                status = rdbtnNotStarted.Text
            ElseIf rdbtnInProgress.Checked = True Then
                status = rdbtnInProgress.Text
            ElseIf rdbtnCompleted.Checked = True Then
                status = rdbtnCompleted.Text
            End If

            editSubjectTask(txtSubject.Text, frmMain.lstviewTasks.FocusedItem.Index + 1, dateDue.Value, txtCreated.Text, txtDescription.Text, status)
            loadTasks(txtSubject.Text)

            Call checkStatus()

            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

End Class
Public Class optAddTaskWizard2

    Private Sub frmAddTaskWizard2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtSubject.Text = optAddTaskWizard.subject
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'Checks whether the Description textbox is empty
        checkEmpty(txtDescription, lblDescription.Text)

        Dim status As String = ""
        'Checks whether the selected due date is before the creation date to issue a warning
        If FormatDateTime(dateDue.Value, DateFormat.ShortDate) < FormatDateTime(DateAndTime.Now, DateFormat.ShortDate) Then
            MessageBox.Show("The due date selected is set before the creation date.", _
                            "Due Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not txtDescription.Text = "" Then
            'Checks which status is selected 
            If rdbtnNotStarted.Checked = True Then
                status = rdbtnNotStarted.Text
            ElseIf rdbtnInProgress.Checked = True Then
                status = rdbtnInProgress.Text
            ElseIf rdbtnCompleted.Checked = True Then
                status = rdbtnCompleted.Text
            End If
            'appends task to subject csv
            appendSubjectTask(txtSubject.Text, dateDue.Value, txtDescription.Text, status)
            'checks for updates on tasks available
            checkStatus()

            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtDescription_MouseHover(sender As Object, e As System.EventArgs) Handles txtDescription.MouseHover
        lblDescriptionAssist.Visible = True
    End Sub

    Private Sub dateDue_MouseHover(sender As Object, e As System.EventArgs) Handles dateDue.MouseHover
        lblDueAssist.Visible = True
    End Sub

    Private Sub gpboxStatus_MouseHover(sender As Object, e As System.EventArgs) Handles gpboxStatus.MouseHover
        lblStatusAssist.Visible = True
    End Sub

    Private Sub btnAdd_MouseHover(sender As Object, e As System.EventArgs) Handles btnAdd.MouseHover
        lblAddAssist.Visible = True
    End Sub
End Class
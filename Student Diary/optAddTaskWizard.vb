Imports System.IO

Public Class optAddTaskWizard
    Public subject As String

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        If lstboxSubjectsAvailable.SelectedIndex < 0 Then
            MessageBox.Show("Please select a subject.", "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            subject = lstboxSubjectsAvailable.SelectedItem.ToString
            optAddTaskWizard2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub optAddTaskWizard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim subject As String
        Dim path As String = Application.StartupPath & "\Subjects\Subjects.txt"
        Dim readSubject As New StreamReader(New FileStream(path, IO.FileMode.Open, IO.FileAccess.Read))

        Do While readSubject.Peek <> -1
            subject = readSubject.ReadLine
            lstboxSubjectsAvailable.Items.Add(subject)
        Loop

        readSubject.Dispose()
    End Sub
End Class
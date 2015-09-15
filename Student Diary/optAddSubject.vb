Imports System.IO

Public Class optAddSubject

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        '================================================================
        'Checks for duplicate subjects and Adds item to 'Subject' Listbox
        '================================================================

        Dim subject As String
        checkEmpty(txtSubject, lblSubject.Text)

        subject = StrConv(txtSubject.Text, VbStrConv.ProperCase)

        '--------------------------------------------------------------------------------------------------
        Dim bufferSubjects(100) As String
        Dim path As String = Application.StartupPath & "\Subjects\Subjects.txt"
        Dim readSubject As New StreamReader(New FileStream(path, IO.FileMode.Open, IO.FileAccess.Read))

        'Read each line of the text file
        Dim count As Integer = 0
        Do While readSubject.Peek <> -1
            bufferSubjects(count) = readSubject.ReadLine
            count += 1
        Loop

        readSubject.Dispose()

        'Sort Routine
        QuickSort(bufferSubjects, 0, count)
        Dim result As Boolean

        'Binary Search
        result = BinarySearch(subject, bufferSubjects, count)
        '---------------------------------------------------------------------------------------------------

        If result = False Then
            createSubjectTaskfile(subject)
            appendSubjecttoFile(subject)
            Me.Close()
        Else
            MessageBox.Show(subject & " has already been used", "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub optAddSubject_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.AcceptButton = btnAdd
    End Sub
End Class
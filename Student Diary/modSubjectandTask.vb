Imports System.IO
Imports System.Xml

Module modSubjectandTask

    Sub appendSubjecttoFile(ByVal subject As String)
        '===============================================
        'Appends New Subject to File and Adds to Listbox
        '===============================================

        Dim path As String = Application.StartupPath & "\Subjects\Subjects.txt"
        Dim appendSubject As New StreamWriter(New FileStream(path, IO.FileMode.Append, IO.FileAccess.Write))

        appendSubject.WriteLine(subject)

        frmMain.lstviewSubjects.Items.Add(subject)

        appendSubject.Dispose()
    End Sub

    Sub deleteLineSubject(ByVal line As Integer)

        '=====================
        'Deletes line from csv
        '=====================

        Dim FileAddress As String = Application.StartupPath & "\Subjects\Subjects.txt"
        Dim TheFileLines As New List(Of String)
        TheFileLines.AddRange(System.IO.File.ReadAllLines(FileAddress))
        ' if line is beyond end of list the exit sub
        If line >= TheFileLines.Count Then Exit Sub
        TheFileLines.RemoveAt(line)
        System.IO.File.WriteAllLines(FileAddress, TheFileLines.ToArray)
    End Sub

    Sub loadSubjects()
        '==================================
        'Loads Subjects.txt text to Listbox
        '==================================

        Dim subject As String
        Dim path As String = Application.StartupPath & "\Subjects\Subjects.txt"
        Dim readSubject As New StreamReader(New FileStream(path, IO.FileMode.Open, IO.FileAccess.Read))

        'Read each line of the text file and adds them to the listview
        Do While readSubject.Peek <> -1
            subject = readSubject.ReadLine
            frmMain.lstviewSubjects.Items.Add(subject)
        Loop

        'Selects first item if there is more than 0 items in the listbox
        'If frmMain.lstviewSubjects.Items.Count > 0 Then
        '    frmMain.lstviewSubjects.FocusedItem = 
        'End If

        readSubject.Dispose()
    End Sub

    Sub createSubjectTaskfile(ByVal subject As String)
        '========================
        'Create Subject Task CSV
        '========================

        Dim path As String = Application.StartupPath & "\Tasks\" & subject & ".csv"
        Dim createSubjectTaskFile As New StreamWriter(New FileStream(path, IO.FileMode.Create))
        createSubjectTaskFile.Dispose()

        'Writes a header to the subject csv
        Dim appendHeader As New StreamWriter(New FileStream(path, IO.FileMode.Open, IO.FileAccess.Write))
        appendHeader.WriteLine("Description,Due,Created,Status")

        appendHeader.Dispose()

    End Sub

    Sub deleteSubjectTaskfile(ByVal subject As String)
        '================================================================
        'Deletes Task file for deleted subject (Subject Deletion Cleanup)
        '================================================================

        Dim path As String = Application.StartupPath & "\Tasks\" & subject & ".csv"

        File.Delete(path)
    End Sub

    Sub loadTasks(ByVal subject As String)
        '=====================
        'Load Tasks from file
        '=====================

        frmMain.lstviewTasks.Items.Clear()
        Dim path As String = Application.StartupPath & "\Tasks\" & subject & ".csv"
        Dim reader As New StreamReader(path)
        Dim info(3) As String
        Dim dateDue As String = ""
        Dim dateCreated As String = ""
        Dim Description As String = ""
        Dim Status As String = ""

        'Reads the csv line by line and splits and adds them to the listview
        While reader.Peek <> -1
            info = reader.ReadLine().Split(CChar(","))
            dateDue = info(1)
            dateCreated = info(2)
            Description = info(0)
            Status = info(3)

            frmMain.lstviewTasks.Items.Add(dateDue)
            frmMain.lstviewTasks.Items(frmMain.lstviewTasks.Items.Count - 1).SubItems.Add(dateCreated)
            frmMain.lstviewTasks.Items(frmMain.lstviewTasks.Items.Count - 1).SubItems.Add(Description)
            frmMain.lstviewTasks.Items(frmMain.lstviewTasks.Items.Count - 1).SubItems.Add(Status)
        End While

        frmMain.lstviewTasks.Items.RemoveAt(0)
        reader.Close()

    End Sub


    Sub appendSubjectTask(ByVal subject As String, ByVal dateDue As Date, ByVal Description As String, ByVal Status As String)

        '======================
        'Append Task to file
        '======================

        Try
            Dim path As String = Application.StartupPath & "\Tasks\" & subject & ".csv"
            Dim dateCreated As String = FormatDateTime(DateAndTime.Now, DateFormat.ShortDate)
            Dim appendTask As New StreamWriter(New FileStream(path, IO.FileMode.Append, IO.FileAccess.Write))

            appendTask.WriteLine(Description & "," & FormatDateTime(dateDue, DateFormat.ShortDate) & "," & dateCreated & "," & Status)

            appendTask.Dispose()
        Catch ex As Exception
            MessageBox.Show("Task File not found", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Sub editSubjectTask(ByVal subject As String, ByVal line As Integer, ByVal dateDue As Date, ByVal dateCreated As String, ByVal Description As String, _
                        ByVal Status As String)

        '=====================
        'Edit Task in file
        '=====================

        Try

            Dim item As String = Description & "," & FormatDateTime(dateDue, DateFormat.ShortDate) & "," & dateCreated & "," & Status
            Dim FileAddress As String = Application.StartupPath & "\Tasks\" & subject & ".csv"
            Dim TheFileLines As New List(Of String)
            TheFileLines.AddRange(System.IO.File.ReadAllLines(FileAddress))
            ' if line is beyond end of list the exit sub
            If line >= TheFileLines.Count Then Exit Sub
            TheFileLines.RemoveAt(line)
            TheFileLines.Insert(line, item)
            System.IO.File.WriteAllLines(FileAddress, TheFileLines.ToArray)

        Catch ex As Exception
            MessageBox.Show("Task File not found", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Sub deleteLineTask(ByVal subject As String, ByVal line As Integer) 'acknowledgments go to #3 AdamSpeight2008 from www.dreamincode.net 

        '=====================
        'Deletes line from csv
        '=====================

        Dim FileAddress As String = Application.StartupPath & "\Tasks\" & subject & ".csv"
        Dim TheFileLines As New List(Of String)
        TheFileLines.AddRange(System.IO.File.ReadAllLines(FileAddress))
        ' if line is beyond end of list the exit sub
        If line >= TheFileLines.Count Then Exit Sub
        TheFileLines.RemoveAt(line)
        System.IO.File.WriteAllLines(FileAddress, TheFileLines.ToArray)
    End Sub

    Sub checkStatus()
        '============================
        'Checks 'Status' of each task
        '============================

        Dim counter As New Integer
        counter = 0
        For count As Integer = 0 To frmMain.lstviewTasks.Items.Count - 1
            Select Case (frmMain.lstviewTasks.Items(count).SubItems(3).Text) 'changes text and background color depending on the conditions
                Case "Not Started"
                    frmMain.lstviewTasks.Items(count).BackColor = Color.Orange
                    frmMain.lstviewSubjects.FocusedItem.BackColor = Color.Orange
                    frmMain.lstviewTasks.Items(count).ForeColor = Color.White
                    frmMain.lstviewSubjects.FocusedItem.ForeColor = Color.White
                Case "In Progress"
                    frmMain.lstviewTasks.Items(count).BackColor = Color.LimeGreen
                    frmMain.lstviewSubjects.FocusedItem.BackColor = Color.Orange
                    frmMain.lstviewTasks.Items(count).ForeColor = Color.White
                    frmMain.lstviewSubjects.FocusedItem.ForeColor = Color.White
                Case "Completed"
                    frmMain.lstviewTasks.Items(count).ForeColor = Color.Black
                    frmMain.lstviewTasks.Items(count).BackColor = Color.White
                    counter += 1
            End Select
        Next

        If counter = frmMain.lstviewTasks.Items.Count Then 'Checks if all tasks have been completed
            frmMain.lstviewSubjects.FocusedItem.ForeColor = Color.Black
            frmMain.lstviewSubjects.FocusedItem.BackColor = Color.White
        End If

    End Sub


End Module

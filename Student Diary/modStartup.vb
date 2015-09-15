Imports System.IO

Module modStartup

    Sub checkEmpty(ByVal textbox As TextBox, ByVal text As String)
        '===============================
        'Checks whether textbox is empty
        '===============================

        If textbox.Text = "" Then
            MessageBox.Show("Please enter a value for " & text, "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub checkSubjectDirectory()
        '=============================================
        'Checks whether directory exists for "Subject"
        '=============================================

        Dim dir As String = Application.StartupPath & "\Subjects"
        If Not Directory.Exists(dir) Then
            Directory.CreateDirectory(dir)
        Else
            Exit Sub
        End If
    End Sub

    Sub checkTasksDirectory()
        '==========================================
        'Checks whether directory exists for "Tasks"
        '==========================================

        Dim dir As String = Application.StartupPath & "\Tasks"
        If Not Directory.Exists(dir) Then
            Directory.CreateDirectory(dir)
        Else
            Exit Sub
        End If
    End Sub

    Sub checkSubjectFile()
        '==========================================
        'Checks whether file exists for "Subjects"
        '==========================================

        Dim path As String = Application.StartupPath & "\Subjects\Subjects.txt"
        If Not File.Exists(path) Then
            Dim createSubjectFile As New StreamWriter(New FileStream(path, IO.FileMode.CreateNew))
            createSubjectFile.Dispose()
        Else
            Exit Sub
        End If
    End Sub

    Sub startupCheckTaskStatus(ByVal subject As String)
        '==================================================================
        'Checks the Status of each individual Task when a Subject is passed
        '==================================================================

        Dim path As String = Application.StartupPath & "\Tasks\" & subject & ".csv"
        Dim TR As New StreamReader(path)
        Dim info(3) As String
        Dim Status As String = ""

        Do While TR.Peek <> -1

            info = TR.ReadLine().Split(CChar(","))
            Status = info(3)

            Select Case (Status)
                Case "Not Started"
                    frmMain.lstviewSubjects.FindItemWithText(subject).BackColor = Color.Orange
                    frmMain.lstviewSubjects.FindItemWithText(subject).ForeColor = Color.White
                Case "In Progress"
                    frmMain.lstviewSubjects.FindItemWithText(subject).BackColor = Color.Orange
                    frmMain.lstviewSubjects.FindItemWithText(subject).ForeColor = Color.White
            End Select

        Loop

        TR.Close()

    End Sub
End Module

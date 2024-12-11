Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Courses
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Private isUpdatingComboBoxes As Boolean = False
    Dim state As Boolean

    Dim displayquery As String = "SELECT b.id AS 'Student ID', CONCAT(b.student_firstname, ' ', b.student_lastname) AS 'Student Name', a.student_year AS Year,
                                 a.semester AS Semester, a.course1 AS 'Course 1', a.course2 AS 'Course 2', a.course3 AS 'Course 3', a.course4 AS 'Course 4'
                                 FROM scores a INNER JOIN students b ON a.student_id = b.id ORDER BY student_firstname, student_lastname, student_year"

    'Dim debugMessage As String = $"txtTableID.Text: {txtTableID.Text}" & Environment.NewLine & $"cbYear.SelectedItem: {cbYear.SelectedItem}" & Environment.NewLine & $"cbSemester.SelectedItem: {cbSemester.SelectedItem}" & Environment.NewLine & $"cbCourse1.SelectedItem: {cbCourse1.SelectedItem}" & Environment.NewLine & $"cbCourse2.SelectedItem: {cbCourse2.SelectedItem}" & Environment.NewLine & $"cbCourse3.SelectedItem: {cbCourse3.SelectedItem}" & Environment.NewLine & $"cbCourse4.SelectedItem: {cbCourse4.SelectedItem}"
    'MsgBox(debugMessage)
    'MsgBox(cbCourse1.SelectedItem & " Or " & cbCourse2.SelectedItem & " Or " & cbCourse3.SelectedItem & " Or " & cbCourse4.SelectedItem)
    Private Sub Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        GetDisplay(displayquery, displayDataCourse)

        cbYear.Text = "SELECT YEAR"
        cbSemester.Text = "SELECT SEMESTER"
        cbCourse1.Text = "SELECT COURSE"
        cbCourse2.Text = "SELECT COURSE"
        cbCourse3.Text = "SELECT COURSE"
        cbCourse4.Text = "SELECT COURSE"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Check if the student ID has been selected
            If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                MsgBox("Please select a Student ID first.", MsgBoxStyle.Exclamation, "Selection Required")
                Return ' Exit the subroutine if no student ID is selected
            End If

            If Not AreCoursesUnique() Then
                MsgBox("Please Select Unique Courses For Each Course ComboBoxes.", MsgBoxStyle.Exclamation, "Duplicate Course Selection")
                Return ' Exit the subroutine if courses are not unique
            End If

            If verif() Then
                conn.Open()
                query = "INSERT INTO scores(student_id, student_year, semester, course1, course2, course3, course4) 
                         VALUES (@ID, @Year, @Semester, @Course1, @Course2, @Course3, @Course4)"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = txtStudentID.Text
                cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = cbYear.SelectedItem
                cmd.Parameters.Add("@Semester", MySqlDbType.Int32).Value = cbSemester.SelectedItem
                cmd.Parameters.Add("@Course1", MySqlDbType.VarChar).Value = cbCourse1.SelectedItem
                cmd.Parameters.Add("@Course2", MySqlDbType.VarChar).Value = cbCourse2.SelectedItem
                cmd.Parameters.Add("@Course3", MySqlDbType.VarChar).Value = cbCourse3.SelectedItem
                cmd.Parameters.Add("@Course4", MySqlDbType.VarChar).Value = cbCourse4.SelectedItem

                If cmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Student Course Added Successfully", MsgBoxStyle.Information, "Add Student Course")
                    GetDisplay(displayquery, displayDataCourse)
                    conn.Close()
                    clearText()
                    conn.Close()
                    cbYear.Enabled = False
                    cbSemester.Enabled = False
                    cbCourse1.Enabled = False
                    cbCourse2.Enabled = False
                    cbCourse3.Enabled = False
                    cbCourse4.Enabled = False
                Else
                    MsgBox("Insert Error Student Course Info", MsgBoxStyle.Critical, "Add Student Course")
                End If
            Else
                MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Add Student Course")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Function AreCoursesUnique() As Boolean
        Dim selectedCourses As New HashSet(Of String)()

        ' Check each ComboBox for selected items
        For Each cb As ComboBox In {cbCourse1, cbCourse2, cbCourse3, cbCourse4}
            If cb.SelectedItem IsNot Nothing Then
                If Not selectedCourses.Add(cb.SelectedItem.ToString()) Then
                    Return False ' If the item was already in the HashSet, it's a duplicate and it return False
                End If
            End If
        Next

        Return True ' Return True if All selected items are unique
    End Function


    Private Sub btnIdSearch_Click(sender As Object, e As EventArgs) Handles btnIdSearch.Click
        Dim studentId As Integer
        If Integer.TryParse(txtIdSearch.Text, studentId) Then
            Using cmd = New MySqlCommand("SELECT id, CONCAT(student_firstname, ' ', student_lastname) AS FullName FROM students WHERE id = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", studentId)
                Try
                    conn.Open() ' Open the connection
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' If a record is found, populate the text boxes
                        txtStudentID.Text = reader("id").ToString()
                        txtFullName.Text = reader("FullName").ToString()
                        reader.Close()
                        UpdateYearsAndSemesters()
                    Else
                        MsgBox("No Student Found")
                    End If
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using
        Else
            MsgBox("Please enter a valid student ID.", MsgBoxStyle.Critical, "Search Student ID")
        End If

        Try
            conn.Open()
            Dim highestCompletedYear As Integer = GetHighestCompletedYear()
            Dim nextYear As Integer = highestCompletedYear

            If nextYear >= 4 Then
                cbYear.Enabled = False
            Else
                cbYear.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub


    'check if Year 1 to 4 is have been taken
    Private Sub UpdateYearsAndSemesters()
        If isUpdatingComboBoxes Then Return
        Try
            cbYear.Items.Clear()

            Dim highestCompletedYear As Integer = GetHighestCompletedYear()

            ' Determine the next available year to add
            Dim nextYear As Integer = highestCompletedYear + 1

            ' Only add the next year if it's not greater than 4
            If nextYear <= 4 Then
                cbYear.Items.Add(nextYear.ToString())
            End If

            ' If no years are available, handle accordingly
            If cbYear.Items.Count = 0 Then
                ' Disable year-related ComboBoxes when no years are available
                cbYear.Enabled = False
                cbSemester.Enabled = False
                cbCourse1.Enabled = False
                cbCourse2.Enabled = False
                cbCourse3.Enabled = False
                cbCourse4.Enabled = False
                MessageBox.Show(txtFullName.Text & ", Student ID: " & txtStudentID.Text & " is already completed all available years.", "Program Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If nextYear > 4 Then
                    ' Disable all ComboBoxes when max year is reached
                    cbYear.Enabled = False
                    cbSemester.Enabled = False
                    cbCourse1.Enabled = False
                    cbCourse2.Enabled = False
                    cbCourse3.Enabled = False
                    cbCourse4.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error Updating Years: " & ex.Message)
        End Try
    End Sub

    Private Function GetHighestCompletedYear() As Integer
        Dim highestYear As Integer = 0

        Try
            Using cmd = New MySqlCommand("SELECT MAX(student_year) AS max_year FROM scores WHERE student_id = @StudentID AND semester = 1 AND 
                                         (SELECT COUNT(*) FROM scores s2 WHERE s2.student_id = @StudentID AND s2.student_year = scores.student_year 
                                         AND s2.semester = 2) > 0", conn)

                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                    highestYear = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving highest completed year: " & ex.Message)
        End Try

        Return highestYear
    End Function


    'check if semester 1 or 2 is have been taken
    Private Sub UpdateSemesters()
        If isUpdatingComboBoxes Then Return

        conn.Open()
        Dim selectedYear As Integer = Convert.ToInt32(cbYear.SelectedItem)
        Dim isSemester1Completed As Boolean = CheckIfSemester1Completed(selectedYear)
        Dim isSemester2Completed As Boolean = CheckIfSemester2Completed(selectedYear)

        cbSemester.Items.Clear()

        If Not isSemester1Completed Then
            cbSemester.Items.Add(1)
        End If

        ' Add semester 2 only if semester 1 is completed and semester 2 is not completed
        If isSemester1Completed AndAlso Not isSemester2Completed Then
            cbSemester.Items.Add(2)
        End If

        conn.Close()
    End Sub

    Private Function CheckIfSemester1Completed(year As Integer) As Boolean
        ' Implement logic to check if semester 1 has been taken
        Using cmd = New MySqlCommand("SELECT COUNT(*) FROM scores WHERE student_year = @Year AND semester = 1 AND student_id = @StudentID", conn)
            cmd.Parameters.AddWithValue("@Year", year)
            cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0 ' Return true if there are courses for semester 1
        End Using
    End Function

    Private Function CheckIfSemester2Completed(year As Integer) As Boolean
        ' Implement logic to check if semester 2 has been taken
        Using cmd = New MySqlCommand("SELECT COUNT(*) FROM scores WHERE student_year = @Year AND semester = 2 AND student_id = @StudentID", conn)
            cmd.Parameters.AddWithValue("@Year", year)
            cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0 ' Return true if there are courses for semester 2
        End Using
    End Function


    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        AddNewCourses.Show(Me)
    End Sub

    Private Sub btnRemoveCourse_Click(sender As Object, e As EventArgs) Handles btnRemoveCourse.Click
        RemoveEditCourses.Show(Me)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdSearch.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtStudentIdFind.Text = ""
        cbYearFind.SelectedItem = Nothing
        cbSemesterFind.SelectedItem = Nothing
        GetDisplay(displayquery, displayDataCourse)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearText()
        cbYear.Enabled = False
        cbSemester.Enabled = False
        cbCourse1.Enabled = False
        cbCourse2.Enabled = False
        cbCourse3.Enabled = False
        cbCourse4.Enabled = False
    End Sub

    'create a function to verify if all field is filled
    Function verif() As Boolean
        If cbYear.SelectedItem Is Nothing Or cbSemester.SelectedItem Is Nothing Or cbCourse1.SelectedItem Is Nothing Or cbCourse2.SelectedItem Is Nothing Or cbCourse3.SelectedItem Is Nothing Or cbCourse4.SelectedItem Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub clearText()
        isUpdatingComboBoxes = True

        txtIdSearch.Text = ""
        txtStudentID.Text = ""
        txtFullName.Text = ""
        cbYear.SelectedItem = Nothing
        cbYear.Text = "SELECT YEAR"
        cbSemester.SelectedItem = Nothing
        cbSemester.Text = "SELECT SEMESTER"

        cbCourse1.SelectedItem = Nothing
        cbCourse1.Text = "SELECT COURSE"
        cbCourse2.SelectedItem = Nothing
        cbCourse2.Text = "SELECT COURSE"
        cbCourse3.SelectedItem = Nothing
        cbCourse3.Text = "SELECT COURSE"
        cbCourse4.SelectedItem = Nothing
        cbCourse4.Text = "SELECT COURSE"

        isUpdatingComboBoxes = False

        btnSave.Visible = True
        btnIdSearch.Visible = True
        btnUpdate.Enabled = False

        txtStudentIdFind.Text = ""
        cbYearFind.SelectedItem = Nothing
        cbSemesterFind.SelectedItem = Nothing
        GetDisplay(displayquery, displayDataCourse)
    End Sub

    Private Sub UpdateCourses()
        Try
            Dim selectedYear As Integer = Convert.ToInt32(cbYear.SelectedItem)
            Dim selectedSemester As Integer = Convert.ToInt32(cbSemester.SelectedItem)

            Using cmd As New MySqlCommand("SELECT courseName FROM courses WHERE student_year = @Year AND semester = @Semester", conn)
                cmd.Parameters.AddWithValue("@Year", selectedYear)
                cmd.Parameters.AddWithValue("@Semester", selectedSemester)
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable()
                adapter.Fill(table)

                cbCourse1.Items.Clear()
                cbCourse2.Items.Clear()
                cbCourse3.Items.Clear()
                cbCourse4.Items.Clear()
                cbCourse1.SelectedItem = Nothing
                cbCourse1.Text = "SELECT COURSE"
                cbCourse2.SelectedItem = Nothing
                'cbCourse2'.SelectedIndex = -1
                cbCourse2.Text = "SELECT COURSE"
                cbCourse3.SelectedItem = Nothing
                cbCourse3.Text = "SELECT COURSE"
                cbCourse4.SelectedItem = Nothing
                cbCourse4.Text = "SELECT COURSE"


                ' Populate the course ComboBoxes
                For Each dr As DataRow In table.Rows
                    cbCourse1.Items.Add(dr("courseName").ToString())
                    cbCourse2.Items.Add(dr("courseName").ToString())
                    cbCourse3.Items.Add(dr("courseName").ToString())
                    cbCourse4.Items.Add(dr("courseName").ToString())
                Next
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYear.SelectedIndexChanged
        cbSemester.Enabled = True
        UpdateCourses()
        UpdateSemesters()
    End Sub

    Private Sub cbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        cbCourse1.Enabled = True
        cbCourse2.Enabled = True
        cbCourse3.Enabled = True
        cbCourse4.Enabled = True
        UpdateCourses()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                MsgBox("Please select a Student ID first.", MsgBoxStyle.Exclamation, "Selection Required")
                Return
            End If

            ' Check if all courses are unique
            If Not AreCoursesUnique() Then
                MsgBox("Please select unique courses for each ComboBox.", MsgBoxStyle.Exclamation, "Duplicate Course Selection")
                Return ' Exit the subroutine if courses are not unique
            End If

            ' Get the indices of the courses that have changed
            Dim changedCourseIndices As List(Of Integer) = GetChangedCourseIndices()

            If verif() Then
                conn.Open()
                query = "UPDATE scores SET course1 = @Course1, course2 = @Course2, course3 = @Course3, course4 = @Course4"

                ' Reset scores to 0.0 for only the changed courses
                For Each index In changedCourseIndices
                    query += $", score{index + 1} = 0.0" ' score1, score2, etc.
                Next

                query += " WHERE id = @ID"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", txtTableID.Text.ToString)
                cmd.Parameters.AddWithValue("@Course1", cbCourse1.SelectedItem)
                cmd.Parameters.AddWithValue("@Course2", cbCourse2.SelectedItem)
                cmd.Parameters.AddWithValue("@Course3", cbCourse3.SelectedItem)
                cmd.Parameters.AddWithValue("@Course4", cbCourse4.SelectedItem)

                If cmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Update Student Course Successfully", MsgBoxStyle.Information, "Update Student Course")
                    GetDisplay(displayquery, displayDataCourse)
                    clearText()
                    btnSave.Visible = True
                Else
                    MsgBox("Insert Error Student Course Info", MsgBoxStyle.Critical, "Update Student Course")
                End If
            Else
                MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Update Student Course")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            ' Re-enable Year and Semester ComboBoxes
        End Try
        cbYear.Enabled = False
        cbSemester.Enabled = False
        cbCourse1.Enabled = False
        cbCourse2.Enabled = False
        cbCourse3.Enabled = False
        cbCourse4.Enabled = False
    End Sub

    Private Function GetChangedCourseIndices() As List(Of Integer)
        Dim currentCourses As New List(Of String) From {
        cbCourse1.SelectedItem.ToString(),
        cbCourse2.SelectedItem.ToString(),
        cbCourse3.SelectedItem.ToString(),
        cbCourse4.SelectedItem.ToString()
    }

        Dim originalCourses As New List(Of String)()

        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT course1, course2, course3, course4 FROM scores WHERE id = @ID", conn)
                cmd.Parameters.AddWithValue("@ID", txtTableID.Text)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        originalCourses.Add(reader("course1").ToString())
                        originalCourses.Add(reader("course2").ToString())
                        originalCourses.Add(reader("course3").ToString())
                        originalCourses.Add(reader("course4").ToString())
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error checking course changes: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' Determine which courses have changed
        Dim changedIndices As New List(Of Integer)()
        For i As Integer = 0 To 3
            If currentCourses(i) <> originalCourses(i) Then
                changedIndices.Add(i)
            End If
        Next

        Return changedIndices
    End Function
    Private Sub displayDataCourse_MouseClick(sender As Object, e As MouseEventArgs) Handles displayDataCourse.MouseClick
        If displayDataCourse.Rows.Count = 0 Then Return
        Try
            Dim hit As DataGridView.HitTestInfo = displayDataCourse.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then ' Ensure a valid row index is clicked
                    cbCourse1.Enabled = True
                    cbCourse2.Enabled = True
                    cbCourse3.Enabled = True
                cbCourse4.Enabled = True
                Dim dr As DataGridViewRow = displayDataCourse.Rows(hit.RowIndex)
                isUpdatingComboBoxes = True
                txtStudentID.Text = dr.Cells(0).Value.ToString
                txtFullName.Text = dr.Cells(1).Value.ToString

                cbYear.Items.Clear()
                    For nextYear As Integer = 1 To 4
                        cbYear.Items.Add(nextYear.ToString())
                    Next

                cbYear.SelectedItem = dr.Cells(2).Value.ToString()
                    Try
                        conn.Open()
                        Dim selectedYear As Integer = Convert.ToInt32(cbYear.SelectedItem)
                        Dim isSemester1Completed As Boolean = CheckIfSemester1Completed(selectedYear)
                        Dim isSemester2Completed As Boolean = CheckIfSemester2Completed(selectedYear)
                        cbSemester.Items.Clear()
                        If isSemester1Completed Then
                            cbSemester.Items.Add(1.ToString)
                        End If
                        If isSemester2Completed Then
                            cbSemester.Items.Add(2.ToString)
                        End If
                    Catch ex As Exception
                        MsgBox("Error in DataGridView Click Event Semester: " & ex.Message)
                    Finally
                        conn.Close()
                    End Try
                cbSemester.SelectedItem = dr.Cells(3).Value.ToString()
                cbCourse1.SelectedItem = dr.Cells(4).Value.ToString()
                cbCourse2.SelectedItem = dr.Cells(5).Value.ToString()
                cbCourse3.SelectedItem = dr.Cells(6).Value.ToString()
                cbCourse4.SelectedItem = dr.Cells(7).Value.ToString()

                If Not String.IsNullOrEmpty(txtStudentID.Text) Then
                    Try
                        conn.Open()
                        Using cmd = New MySqlCommand("SELECT id FROM scores WHERE student_id = @ID AND student_year = @Year AND 
                                                     semester = @Semester OR course1 = @Course1 OR course2 = @Course2 OR 
                                                     course3 = @Course3 OR course4 = @Course4", conn)
                            cmd.Parameters.AddWithValue("@ID", txtStudentID.Text)
                            cmd.Parameters.AddWithValue("@Year", cbYear.SelectedItem)
                            cmd.Parameters.AddWithValue("@Semester", cbSemester.SelectedItem)
                            cmd.Parameters.AddWithValue("@Course1", cbCourse1.SelectedItem)
                            cmd.Parameters.AddWithValue("@Course2", cbCourse2.SelectedItem)
                            cmd.Parameters.AddWithValue("@Course3", cbCourse3.SelectedItem)
                            cmd.Parameters.AddWithValue("@Course4", cbCourse4.SelectedItem)

                            Dim result = cmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                txtTableID.Text = result.ToString()
                            Else
                                txtTableID.Text = ""
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox("Error retrieving record details: " & ex.Message)
                    Finally
                        If conn.State = ConnectionState.Open Then
                            conn.Close()
                        End If
                    End Try
                End If

                btnSave.Visible = False
                btnIdSearch.Visible = False
                btnUpdate.Enabled = True
                cbYear.Enabled = False
                cbSemester.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error in DataGridView Click Event: " & ex.Message)
        End Try
    End Sub



    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtStudentIdFind.Text) AndAlso cbYearFind.SelectedItem Is Nothing AndAlso cbSemesterFind.SelectedItem Is Nothing Then
            MessageBox.Show("Please select either 'Student ID' or 'Year' or 'Semester'.")
            Return
        End If

        query = "SELECT b.id AS 'Student ID', CONCAT(b.student_firstname, ' ', b.student_lastname) AS 'Student Name', a.student_year AS Year,
                 a.semester AS Semester, a.course1 AS 'Course 1', a.course2 AS 'Course 2', a.course3 AS 'Course 3', a.course4 AS 'Course 4'
                 FROM scores a INNER JOIN students b ON a.student_id = b.id WHERE 1=1"

        If Not String.IsNullOrWhiteSpace(txtStudentIdFind.Text) Then
            query += " AND student_id = @StudentID"
        End If

        If cbYearFind.SelectedItem IsNot Nothing Then
            query += " AND student_year = @Year"
        End If

        If cbSemesterFind.SelectedItem IsNot Nothing Then
            query += " AND semester = @Semester"
        End If

        query += " ORDER BY b.student_firstname, b.student_lastname, a.student_year"

        Using cmd As New MySqlCommand(query, conn)
            If Not String.IsNullOrWhiteSpace(txtStudentIdFind.Text) Then
                cmd.Parameters.AddWithValue("@StudentID", txtStudentIdFind.Text)
            End If

            If cbYearFind.SelectedItem IsNot Nothing Then
                cmd.Parameters.AddWithValue("@Year", cbYearFind.SelectedItem)
            End If

            If cbSemesterFind.SelectedItem IsNot Nothing Then
                cmd.Parameters.AddWithValue("@Semester", cbSemesterFind.SelectedItem)
            End If

            Try
                conn.Open()
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                displayDataCourse.DataSource = table

                displayDataCourse.AllowUserToAddRows = False
                displayDataCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                If table.Rows.Count = 0 Then
                    MessageBox.Show("No records found.")
                    GetDisplay(displayquery, displayDataCourse)
                End If
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If displayDataCourse.Rows.Count = 0 Then
            MsgBox("Please Select Student ID First Before Printing.", MsgBoxStyle.Exclamation, "No Data to Print")
            Return
        End If

        PrintDocument1.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintPage(e, displayDataCourse)
        Dim format As New StringFormat

        e.Graphics.DrawString("Student Record", New Font("Center Gothic", 20, FontStyle.Bold),
                      Brushes.Black, New Point(480, 50), format)
    End Sub
End Class
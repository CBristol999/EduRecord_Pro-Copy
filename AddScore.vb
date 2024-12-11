Imports MySql.Data.MySqlClient

Public Class AddScore
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Private isUpdatingComboBoxes As Boolean = False

    Dim displayquery As String = "SELECT b.id AS 'Student ID', CONCAT(b.student_firstname, ' ', b.student_lastname) AS 'Student Name', a.student_year AS Year,
                                 a.semester AS Semester, a.course1 AS 'Course 1', a.score1 AS 'Score 1', a.course2 AS 'Course 2', a.score2 AS 'Score 2', 
                                 a.course3 AS 'Course 3', a.score3 AS 'Score 3', a.course4 AS 'Course 4', a.score4 AS 'Score 4', FORMAT(a.average, 2) AS 'Average Score' FROM scores a 
                                 INNER JOIN students b ON a.student_id = b.id ORDER BY student_firstname, student_lastname, student_year"

    Private Sub AddScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        CalculateAndUpdateAverages()
        GetDisplay(displayquery, displayDataScores)
    End Sub

    Private Sub CalculateAndUpdateAverages()
        Try
            conn.Open()
            Dim query As String = "SELECT id, score1, score2, score3, score4 FROM scores"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim id As Integer = reader("id")
                    Dim score1 As Double = If(IsDBNull(reader("score1")), 0, reader("score1"))
                    Dim score2 As Double = If(IsDBNull(reader("score2")), 0, reader("score2"))
                    Dim score3 As Double = If(IsDBNull(reader("score3")), 0, reader("score3"))
                    Dim score4 As Double = If(IsDBNull(reader("score4")), 0, reader("score4"))

                    Dim average As Double = (score1 + score2 + score3 + score4) / 4
                    UpdateAverage(id, average)
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while calculating averages: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateAverage(studentId As Integer, average As Double)
        Try
            DBConnect()
            conn.Open()
            Dim updateQuery As String = "UPDATE scores SET average = @Average WHERE id = @ID"
            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@Average", average)
                cmd.Parameters.AddWithValue("@ID", studentId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while updating the average: " & ex.Message)
        End Try
        conn.Close()
    End Sub


    Private Sub btnIdSearch_Click(sender As Object, e As EventArgs) Handles btnIdSearch.Click
        Dim studentId As Integer
        If Integer.TryParse(txtIdSearch.Text, studentId) Then
            ' Check if Year and Semester are selected
            If cbYear.SelectedItem Is Nothing OrElse cbSemester.SelectedItem Is Nothing Then
                MsgBox("Please select a valid year and semester.", MsgBoxStyle.Critical, "Search Student")
                Return
            End If

            Using cmd = New MySqlCommand("SELECT a.id AS 'Student ID', CONCAT(a.student_firstname, ' ', a.student_lastname) AS FullName, 
                                       b.course1 AS 'Course 1', b.course2 AS 'Course 2', b.course3 AS 'Course 3', b.course4 AS 'Course 4' 
                                       FROM students a 
                                       INNER JOIN scores b ON a.id = b.student_id 
                                       WHERE a.id = @ID AND b.student_year = @Year AND b.semester = @Semester;", conn)
                cmd.Parameters.AddWithValue("@ID", studentId)
                cmd.Parameters.AddWithValue("@Year", Convert.ToInt32(cbYear.SelectedItem)) ' Ensure this is an integer
                cmd.Parameters.AddWithValue("@Semester", Convert.ToInt32(cbSemester.SelectedItem)) ' Ensure this is an integer

                Try
                    conn.Open() ' Open the connection
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' If a record is found, populate the text boxes
                        txtID.Text = reader("Student ID").ToString()
                        txtFullName.Text = reader("FullName").ToString()
                        txtCourse1.Text = reader("Course 1").ToString()
                        txtCourse2.Text = reader("Course 2").ToString()
                        txtCourse3.Text = reader("Course 3").ToString()
                        txtCourse4.Text = reader("Course 4").ToString()
                    Else
                        MsgBox("No Record Found")
                        reader.Close()

                        ClearText()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using
        Else
            MsgBox("Please enter a valid student ID.", MsgBoxStyle.Critical, "Search Student ID")
        End If


        If Not String.IsNullOrEmpty(txtID.Text) Then
            Try
                conn.Open()
                Using cmd = New MySqlCommand("SELECT id FROM scores WHERE student_id = @ID AND semester = @Semester AND 
                                                      course1 = @Course1 AND course2 = @Course2 AND 
                                                      course3 = @Course3 AND course4 = @Course4", conn)
                    cmd.Parameters.AddWithValue("@ID", txtID.Text)
                    cmd.Parameters.AddWithValue("@Semester", cbSemester.SelectedItem)
                    cmd.Parameters.AddWithValue("@Course1", txtCourse1.Text)
                    cmd.Parameters.AddWithValue("@Course2", txtCourse2.Text)
                    cmd.Parameters.AddWithValue("@Course3", txtCourse3.Text)
                    cmd.Parameters.AddWithValue("@Course4", txtCourse4.Text)

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        txtScoreID.Text = result.ToString()
                    Else
                        txtScoreID.Text = ""
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
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Check if the student ID has been selected
            If String.IsNullOrWhiteSpace(txtID.Text) Then
                MsgBox("Please select a Student ID first.", MsgBoxStyle.Exclamation, "Selection Required")
                Return ' Exit the subroutine if no student ID is selected
            End If

            If Not IsValidScore(txtCourseScore1.Text) OrElse Not IsValidScore(txtCourseScore2.Text) OrElse
           Not IsValidScore(txtCourseScore3.Text) OrElse Not IsValidScore(txtCourseScore4.Text) Then
                MsgBox("Please enter valid scores in the format of 1.2 or 10.2 (max 3 digits, 1 decimal).", MsgBoxStyle.Exclamation, "Invalid Score")
                txtCourseScore1.Text = "0.0"
                txtCourseScore2.Text = "0.0"
                txtCourseScore3.Text = "0.0"
                txtCourseScore4.Text = "0.0"
                Return
            End If

            If verif() Then
                conn.Open()
                Dim score1 As Double = Convert.ToDouble(txtCourseScore1.Text)
                Dim score2 As Double = Convert.ToDouble(txtCourseScore2.Text)
                Dim score3 As Double = Convert.ToDouble(txtCourseScore3.Text)
                Dim score4 As Double = Convert.ToDouble(txtCourseScore4.Text)
                Dim avg As Double = (score1 + score2 + score3 + score4) / 4

                cmd = New MySqlCommand("UPDATE scores SET score1 = @Score1, score2 = @Score2, score3 = @Score3, score4 = @Score4, average = 
                                        @AverageGrade WHERE id = @ID", conn)
                cmd.Parameters.AddWithValue("@ID", txtScoreID.Text)
                cmd.Parameters.AddWithValue("@Score1", score1)
                cmd.Parameters.AddWithValue("@Score2", score2)
                cmd.Parameters.AddWithValue("@Score3", score3)
                cmd.Parameters.AddWithValue("@Score4", score4)
                cmd.Parameters.AddWithValue("@AverageGrade", avg)

                If cmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Score Added Successfully", MsgBoxStyle.Information, "Add Score")
                    GetDisplay(displayquery, displayDataScores)
                    conn.Close()
                    ClearText()
                Else
                    MsgBox("Insert Error Student Score Info", MsgBoxStyle.Critical, "Add Score")
                End If
            Else
                MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Add Score")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function IsValidScore(score As String) As Boolean
        Dim result As Double
        ' Check if the input can be parsed to a double and if it contains a decimal point
        If Double.TryParse(score, result) AndAlso score.Contains(".") Then
            ' Check the format: max 3 digits total, 1 digit after the decimal
            Dim parts As String() = score.Split("."c)
            If parts.Length = 2 AndAlso parts(0).Length <= 2 AndAlso parts(1).Length = 1 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub displayDataScores_MouseClick(sender As Object, e As MouseEventArgs) Handles displayDataScores.MouseClick
        If displayDataScores.Rows.Count = 0 Then Return
        Try
            Dim hit As DataGridView.HitTestInfo = displayDataScores.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then ' Ensure a valid row index is clicked
                displayDataScores.ClearSelection()
                displayDataScores.Rows(hit.RowIndex).Selected = True

                Dim dr As DataGridViewRow = displayDataScores.Rows(hit.RowIndex)
                txtID.Text = dr.Cells(0).Value.ToString()
                txtFullName.Text = dr.Cells(1).Value.ToString()
                cbYear.SelectedItem = dr.Cells(2).Value.ToString()
                cbSemester.SelectedItem = dr.Cells(3).Value.ToString()
                txtCourse1.Text = dr.Cells(4).Value.ToString()
                txtCourseScore1.Text = dr.Cells(5).Value.ToString()
                txtCourse2.Text = dr.Cells(6).Value.ToString()
                txtCourseScore2.Text = dr.Cells(7).Value.ToString()
                txtCourse3.Text = dr.Cells(8).Value.ToString()
                txtCourseScore3.Text = dr.Cells(9).Value.ToString()
                txtCourse4.Text = dr.Cells(10).Value.ToString()
                txtCourseScore4.Text = dr.Cells(11).Value.ToString()


                ' Retrieve additional record details
                If Not String.IsNullOrEmpty(txtID.Text) Then
                    Try
                        conn.Open()
                        Using cmd = New MySqlCommand("SELECT id FROM scores WHERE student_id = @ID AND semester = @Semester AND 
                                                      course1 = @Course1 AND course2 = @Course2 AND 
                                                      course3 = @Course3 AND course4 = @Course4", conn)
                            cmd.Parameters.AddWithValue("@ID", txtID.Text)
                            cmd.Parameters.AddWithValue("@Semester", cbSemester.SelectedItem)
                            cmd.Parameters.AddWithValue("@Course1", txtCourse1.Text)
                            cmd.Parameters.AddWithValue("@Course2", txtCourse2.Text)
                            cmd.Parameters.AddWithValue("@Course3", txtCourse3.Text)
                            cmd.Parameters.AddWithValue("@Course4", txtCourse4.Text)

                            Dim result = cmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                txtScoreID.Text = result.ToString()
                            Else
                                txtScoreID.Text = ""
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
            End If
        Catch ex As Exception
            MsgBox("Error in DataGridView click event: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub ClearText()
        txtStudentIdFind.Text = ""
        cbYearFind.SelectedItem = Nothing
        cbSemesterFind.SelectedItem = Nothing
        txtScoreID.Text = ""
        txtIdSearch.Text = ""
        cbYear.SelectedItem = Nothing
        cbSemester.SelectedItem = Nothing
        txtID.Text = ""
        txtFullName.Text = ""
        txtCourse1.Text = ""
        txtCourseScore1.Text = "0.0"
        txtCourse2.Text = ""
        txtCourseScore2.Text = "0.0"
        txtCourse3.Text = ""
        txtCourseScore3.Text = "0.0"
        txtCourse4.Text = ""
        txtCourseScore4.Text = "0.0"
        GetDisplay(displayquery, displayDataScores)
    End Sub

    Function verif() As Boolean
        If txtID.Text.Trim() = "" Or txtFullName.Text.Trim() = "" Or txtCourse1.Text.Trim() = "" Or txtCourse2.Text.Trim() = "" Or txtCourse3.Text.Trim() = "" Or
           txtCourse4.Text.Trim() = "" Or txtCourseScore1.Text.Trim() = "" Or txtCourseScore2.Text.Trim() = "" Or txtCourseScore3.Text.Trim() = "" Or
           txtCourseScore4.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtCourseScore1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCourseScore1.KeyDown, txtCourseScore2.KeyDown, txtCourseScore3.KeyDown, txtCourseScore4.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Select Case sender.Name
                Case "txtCourseScore1"
                    txtCourseScore2.Focus()
                Case "txtCourseScore2"
                    txtCourseScore3.Focus()
                Case "txtCourseScore3"
                    txtCourseScore4.Focus()
                Case "txtCourseScore4"
                    btnSave.PerformClick()
            End Select
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtStudentIdFind.Text = ""
        cbYearFind.SelectedItem = Nothing
        cbSemesterFind.SelectedItem = Nothing
        GetDisplay(displayquery, displayDataScores)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtStudentIdFind.Text) AndAlso cbYearFind.SelectedItem Is Nothing AndAlso cbSemesterFind.SelectedItem Is Nothing Then
            MessageBox.Show("Please select either 'Student ID' or 'Year' or 'Semester'.")
            Return
        End If

        ' Prepare the SQL command based on the selected year, semester, or student ID
        query = "SELECT b.id AS 'Student ID', CONCAT(b.student_firstname, ' ', b.student_lastname) AS 'Student Name', a.student_year AS Year,
                 a.semester AS Semester, a.course1 AS 'Course 1', a.score1 AS 'Score 1', a.course2 AS 'Course 2', a.score2 AS 'Score 2', 
                 a.course3 AS 'Course 3', a.score3 AS 'Score 3', a.course4 AS 'Course 4', a.score4 AS 'Score 4', FORMAT(a.average, 2) AS 'Average Score' FROM scores a 
                 INNER JOIN students b ON a.student_id = b.id WHERE 1=1"

        If Not String.IsNullOrWhiteSpace(txtStudentIdFind.Text) Then
            query += " AND student_id = @StudentID"
        End If

        If cbYearFind.SelectedItem IsNot Nothing Then
            query += " AND student_year = @Year"
        End If

        If cbSemesterFind.SelectedItem IsNot Nothing Then
            query += " AND semester = @Semester"
        End If

        query += " ORDER BY student_year"

        Using cmd As New MySqlCommand(query, conn)
            ' Add parameters only if the corresponding input has a value
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

                displayDataScores.DataSource = table
                displayDataScores.AllowUserToAddRows = False
                displayDataScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                If table.Rows.Count = 0 Then
                    MessageBox.Show("No Records Found.")
                    GetDisplay(displayquery, displayDataScores)
                End If
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If displayDataScores.Rows.Count = 0 Then
            MsgBox("Please load the data first before printing.", MsgBoxStyle.Exclamation, "No Data to Print")
            Return
        End If

        PrintDocument1.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintPage(e, displayDataScores)
        Dim format As New StringFormat

        e.Graphics.DrawString("Student Record", New Font("Center Gothic", 20, FontStyle.Bold),
                      Brushes.Black, New Point(480, 50), format)
    End Sub
End Class
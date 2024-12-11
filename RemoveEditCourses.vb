Imports System.IO
Imports MySql.Data.MySqlClient

Public Class RemoveEditCourses
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String

    Dim displayquery As String = "SELECT student_year AS Year, semester AS Semester, courseName AS Courses FROM courses ORDER BY student_year"

    Private Sub RemoveEditCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        GetDisplay(displayquery, displayCourses)
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        Try
            conn.Open()
            query = "UPDATE courses SET student_year = @Year, semester = @Semester, courseName = @Course WHERE id = " & txtCourseID.Text & ""

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = cbYear.SelectedItem
            cmd.Parameters.Add("@Semester", MySqlDbType.Int32).Value = cbSemester.SelectedItem
            cmd.Parameters.Add("@Course", MySqlDbType.VarChar).Value = txtEditCourseName.Text


            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Course Edit Successful")
                clearText()
            Else
                MsgBox("Insert Error Student Info", MsgBoxStyle.Critical, "Update Course")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            If String.IsNullOrWhiteSpace(txtCourseID.Text) Then
                MessageBox.Show("Please select course to delete.")
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then Return

            Using cmd = New MySqlCommand("DELETE FROM courses WHERE id = " & txtCourseID.Text & "", conn)
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery() ' Execute the command

                If rowsAffected > 0 Then
                    MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Delete Course")
                    GetDisplay(displayquery, displayCourses) ' refresh the DataGridView to reflect the changes
                Else
                    MessageBox.Show("No record found with the provided ID.")
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub displayCourses_MouseClick(sender As Object, e As MouseEventArgs) Handles displayCourses.MouseClick
        Try
            Dim hit As DataGridView.HitTestInfo = displayCourses.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then ' Ensure a valid row index is clicked
                Dim dr As DataGridViewRow = displayCourses.Rows(hit.RowIndex)
                cbYear.SelectedItem = dr.Cells(0).Value.ToString
                cbSemester.SelectedItem = dr.Cells(1).Value.ToString
                txtEditCourseName.Text = dr.Cells(2).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Using cmd = New MySqlCommand("SELECT * FROM courses WHERE courseName LIKE @CourseName", conn)
            cmd.Parameters.AddWithValue("@CourseName", "%" & txtEditCourseName.Text & "%")
            Try
                conn.Open() ' Open the connection
                Dim reader = cmd.ExecuteReader

                If reader.Read Then
                    ' If a record is found, populate the text boxes
                    txtCourseID.Text = reader("id").ToString
                Else
                    MsgBox("No Course Found")
                End If
                reader.Close() ' Close the reader
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Function verif() As Boolean
        If cbYear.SelectedItem Is Nothing Or cbSemester.SelectedItem Is Nothing Or cbSemester.SelectedItem Is Nothing Or txtEditCourseName.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbYearSearch.SelectedItem Is Nothing AndAlso cbSemesterSearch.SelectedItem Is Nothing Then
            MessageBox.Show("Please select either 'Year' or 'Semester'.")
            Return
        End If

        ' Prepare the SQL command based on the selected year or semester

        Dim query = "SELECT student_year AS Year, semester AS Semester, courseName AS Courses FROM courses WHERE 1=1"

        If cbYearSearch.SelectedItem IsNot Nothing Then
            query += " AND student_year = @Year"
        End If

        If cbSemesterSearch.SelectedItem IsNot Nothing Then
            query += " AND semester = @Semester"
        End If

        query += " ORDER BY student_year"

        Using cmd = New MySqlCommand(query, conn)
            ' Add parameters only if the corresponding ComboBox has a selected item
            If cbYearSearch.SelectedItem IsNot Nothing Then
                cmd.Parameters.AddWithValue("@Year", cbYearSearch.SelectedItem)
            End If

            If cbSemesterSearch.SelectedItem IsNot Nothing Then
                cmd.Parameters.AddWithValue("@Semester", cbSemesterSearch.SelectedItem)
            End If

            Try
                conn.Open()
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                displayCourses.DataSource = table
                displayCourses.AllowUserToAddRows = False
                displayCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                If table.Rows.Count = 0 Then
                    MessageBox.Show("No Course Records Found.")
                    GetDisplay(displayquery, displayCourses)
                End If
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearText()
    End Sub

    Private Sub clearText()
        cbYear.SelectedItem = Nothing
        cbSemester.SelectedItem = Nothing
        txtEditCourseName.Text = ""
        txtCourseID.Text = ""
        cbYearSearch.SelectedItem = Nothing
        cbSemesterSearch.SelectedItem = Nothing
        GetDisplay(displayquery, displayCourses)
    End Sub
End Class
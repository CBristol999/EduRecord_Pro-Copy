Imports System.IO
Imports MySql.Data.MySqlClient

Public Class MarkSheet
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Private Sub MarkSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        displayCGPA.Columns.Clear()

        If String.IsNullOrEmpty(txtSearchID.Text) Then
            MessageBox.Show("Please enter a Student ID, First Name, or Last Name.")
            Return
        End If

        Using cmd = New MySqlCommand("SELECT b.id AS 'Student ID', CONCAT(b.student_firstname, ' ', b.student_lastname) AS 'Student Name', a.student_year AS Year, a.semester AS Semester, 
                                      a.course1 AS 'Course 1', a.score1 AS 'Score 1', a.course2 AS 'Course 2', a.score2 AS 'Score 2', a.course3 AS 'Course 3', a.score3 AS 'Score 3', 
                                      a.course4 AS 'Course 4', a.score4 AS 'Score 4', FORMAT(a.average, 2) AS 'Average Score' FROM scores a INNER JOIN students b ON 
                                      a.student_id = b.id WHERE b.id = @ID OR student_firstname LIKE @Name OR student_lastname LIKE @Name ORDER BY student_firstname, 
                                      student_lastname, student_year;", conn)
            cmd.Parameters.AddWithValue("@ID", txtSearchID.Text)
            cmd.Parameters.AddWithValue("@Name", "%" & txtSearchID.Text & "%")

            Try
                conn.Open()
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                displayCGPA.DataSource = table
                displayCGPA.AllowUserToAddRows = False

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then txtStudentID.Text = reader("Student ID").ToString()
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using


        If txtSearchID.Text.Length > 0 Then
            Using cmd = New MySqlCommand("SELECT id, CONCAT(student_firstname, ' ', student_lastname) AS FullName, phoneNumber, profile_photo, email FROM students 
                                          WHERE id = @ID OR student_firstname LIKE @Names OR student_lastname LIKE @Names", conn)
                cmd.Parameters.AddWithValue("@ID", txtSearchID.Text)
                cmd.Parameters.AddWithValue("@Names", "%" & txtSearchID.Text & "%")
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' If a record is found, populate the text boxes
                        txtStudentID.Text = reader("id").ToString()
                        txtFullName.Text = reader("FullName").ToString()
                        txtContactNumber.Text = reader("phoneNumber").ToString()
                        txtEmail.Text = reader("email").ToString()
                        ' Get image
                        If Not IsDBNull(reader("profile_photo")) Then
                            Dim data As Byte() = DirectCast(reader("profile_photo"), Byte())
                            Using ms As New MemoryStream(data)
                                PictureBoxStudentImage.Image = Image.FromStream(ms)
                            End Using
                        Else
                            PictureBoxStudentImage.Image = My.Resources.profile
                        End If
                    Else
                        MsgBox("No Student Found")
                    End If
                    reader.Close()
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using
        Else
            MsgBox("Please Enter a alid 'Student' ID or 'Student Name'.", MsgBoxStyle.Critical, "Search Student ID")
        End If



        If Not String.IsNullOrEmpty(txtStudentID.Text) Then
            Try
                conn.Open()
                Using cmd = New MySqlCommand("SELECT FORMAT(AVG(average), 2) FROM scores WHERE student_id = @ID", conn)
                    cmd.Parameters.AddWithValue("@ID", txtStudentID.Text)

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        txtCGPA.Text = result.ToString()
                    Else
                        txtCGPA.Text = "0.00"
                    End If

                    If table.Rows.Count = 0 Then
                        txtCGPA.Text = "0.00"
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


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearchID.Text = ""
        txtStudentID.Text = ""
        txtFullName.Text = ""
        txtContactNumber.Text = ""
        txtEmail.Text = ""
        txtCGPA.Text = "0.00"
        PictureBoxStudentImage.Image = My.Resources.profile
        displayCGPA.DataSource = Nothing
        AddInitialColumns()
        displayCGPA.Rows.Clear()
    End Sub

    Private Sub AddInitialColumns()
        displayCGPA.Columns.Clear() ' Clear existing columns if any
        displayCGPA.Columns.Add("StudentID", "Student ID")
        displayCGPA.Columns.Add("StudentName", "Student Name")
        displayCGPA.Columns.Add("Year", "Year")
        displayCGPA.Columns.Add("Semester", "Semester")
        displayCGPA.Columns.Add("Course1", "Course 1")
        displayCGPA.Columns.Add("Score1", "Score 1")
        displayCGPA.Columns.Add("Course2", "Course 2")
        displayCGPA.Columns.Add("Score2", "Score 2")
        displayCGPA.Columns.Add("Course3", "Course 3")
        displayCGPA.Columns.Add("Score3", "Score 3")
        displayCGPA.Columns.Add("Course4", "Course 4")
        displayCGPA.Columns.Add("Score4", "Score 4")
        displayCGPA.Columns.Add("Average", "Average")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If displayCGPA.Rows.Count = 0 Then
            MsgBox("Please Select Student ID First Before Printing.", MsgBoxStyle.Exclamation, "No Data to Print")
            Return
        End If

        PrintDocument1.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        displayCGPA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        PrintPage(e, displayCGPA)
        Dim format As New StringFormat

        e.Graphics.DrawString("Mark Sheet", New Font("Center Gothic", 20, FontStyle.Bold),
                      Brushes.Black, New Point(250, 50), format)
        e.Graphics.DrawString("Student ID: " & txtStudentID.Text, New Font("Center Gothic", 20, FontStyle.Bold),
              Brushes.Black, New Point(480, 50), format)
        e.Graphics.DrawString("CGPA: " + txtCGPA.Text, New Font("Center Gothic", 20, FontStyle.Bold),
              Brushes.Black, New Point(700, 50), format)
    End Sub
End Class
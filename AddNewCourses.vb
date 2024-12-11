Imports MySql.Data.MySqlClient

Public Class AddNewCourses
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Private Sub AddNewCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If verif() Then
                conn.Open()
                query = "INSERT INTO courses(student_year, semester, courseName) 
                         VALUES (@Year, @Semester, @Course)"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = cbYear.SelectedItem
                cmd.Parameters.Add("@Semester", MySqlDbType.Int32).Value = cbSemester.SelectedItem
                cmd.Parameters.Add("@Course", MySqlDbType.VarChar).Value = txtCourseName.Text
                If cmd.ExecuteNonQuery() = 1 Then
                    MsgBox("New Course Added Successfully", MsgBoxStyle.Information, "Add Course")
                        cbYear.SelectedItem = Nothing
                        cbSemester.SelectedItem = Nothing
                        txtCourseName.Text = ""
                Else
                    MsgBox("Insert Error Course Info", MsgBoxStyle.Critical, "Add Course")
                End If
            Else
                MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Add Course")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Function verif() As Boolean
        If cbYear.SelectedItem Is Nothing Or cbSemester.SelectedItem Is Nothing Or txtCourseName.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
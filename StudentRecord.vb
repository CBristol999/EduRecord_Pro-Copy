Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.IO

Public Class StudentRecord
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim picCol As DataGridViewImageColumn
    Dim query As String

    Private Sub StudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        cbGender.Text = "Select Gender"
        getDisplay()
    End Sub

    Public Sub getDisplay()
        DBConnect()
        picCol = New DataGridViewImageColumn()
        query = "SELECT id AS 'Student ID', student_firstname AS Firstname, student_lastname AS Lastname, gender AS Gender, 
                 birthday AS 'Birth Date', phoneNumber AS 'Contact Number', email AS Email, address AS Address, profile_photo AS Profile 
                 FROM students"

        adapter = New MySqlDataAdapter(query, conn)
        table = New DataTable
        adapter.Fill(table)

        DataGridView_students.DataSource = table

        DataGridView_students.RowTemplate.Height = 50
        picCol = DataGridView_students.Columns(8)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch
        DataGridView_students.AllowUserToAddRows = False
        DataGridView_students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                MessageBox.Show("Please select a student to delete.")
                Return
            End If
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this student data?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then Return

            Using cmd = New MySqlCommand("DELETE FROM students WHERE id = " & txtStudentID.Text & "", conn)
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery() ' Execute the command

                If rowsAffected > 0 Then
                    MsgBox("Record Deleted Successfully.", MsgBoxStyle.Information, "Remove Student")
                    getDisplay()
                Else
                    MessageBox.Show("No Record found With The Provided ID.")
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try

        reset()
        If btnAdd.Visible = False Then
            btnAdd.Visible = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        picCol = New DataGridViewImageColumn()

        If String.IsNullOrEmpty(txtSearch.Text) Then
            MessageBox.Show("Please enter a Student ID, First Name, or Last Name.")
            Return
        End If

        Using cmd = New MySqlCommand("SELECT id AS 'Student ID', student_firstname AS Firstname, student_lastname AS Lastname, gender AS Gender, 
                                      birthday AS 'Birth Date', phoneNumber AS 'Contact Number', email AS Email, address AS Address, profile_photo 
                                      AS Profile FROM students WHERE id = @searchTerm OR student_firstname LIKE @nameTerm OR student_lastname LIKE @nameTerm", conn)
            cmd.Parameters.AddWithValue("@searchTerm", txtSearch.Text)
            cmd.Parameters.AddWithValue("@nameTerm", "%" & txtSearch.Text & "%")

            Try
                conn.Open()
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                DataGridView_students.DataSource = table

                DataGridView_students.RowTemplate.Height = 50
                picCol = DataGridView_students.Columns(8)
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

                DataGridView_students.AllowUserToAddRows = False
                DataGridView_students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                If table.Rows.Count = 0 Then
                    MessageBox.Show("No records found.")
                    getDisplay()
                End If
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim born_year As Integer = dtpBirthDate.Value.Year
        Dim this_year As Integer = Date.Now.Year

        Try
            'allow only students age between 10 - 100
            If this_year - born_year < 10 Or this_year - born_year > 100 Then
                If verif() Then
                    MsgBox("The Student Age Must Be Between 10 and 100 year", MsgBoxStyle.Exclamation, "Birth Date Error")
                Else
                    MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Add Student")
                End If
            Else
                If verif() Then
                    conn.Open()
                    query = "INSERT INTO students (student_firstname, student_lastname, gender, birthday, phoneNumber, address, profile_photo, email)
                                       VALUES (@firstname, @lastname, @gender, @birthday, @phone, @address, @photo, @emailaddress)"
                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = txtFirstName.Text
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = txtLastName.Text
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = cbGender.SelectedItem
                    cmd.Parameters.Add("@birthday", MySqlDbType.Date).Value = Format(dtpBirthDate.Value, "yyyy/MM/dd")
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txtPhoneNumber.Text
                    cmd.Parameters.Add("@address", MySqlDbType.Text).Value = txtAddress.Text
                    cmd.Parameters.Add("@emailaddress", MySqlDbType.VarChar).Value = txtEmail.Text
                    ' Input for image
                    If PictureBoxStudentImage.Image IsNot Nothing Then
                        Using ms As New MemoryStream()
                            Dim img As New Bitmap(PictureBoxStudentImage.Image)
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Dim data As Byte() = ms.ToArray() ' Use ToArray() instead of GetBuffer()
                            Dim p As New MySqlParameter("@photo", MySqlDbType.LongBlob)
                            p.Value = data
                            cmd.Parameters.Add(p)
                        End Using
                    Else
                        ' Handle case where no image is provided
                        cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = DBNull.Value
                    End If


                    If cmd.ExecuteNonQuery() = 1 Then
                        MsgBox("New Student Added", MsgBoxStyle.Information, "Add Student")
                        reset()
                    Else
                        MsgBox("Insert Error Student Info", MsgBoxStyle.Critical, "Add Student")
                    End If
                Else
                    MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Add Student")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        getDisplay()
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress, txtLastName.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If opf.ShowDialog() = DialogResult.OK Then
            PictureBoxStudentImage.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        getDisplay()
    End Sub

    Sub reset()
        txtStudentID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cbGender.SelectedItem = Nothing
        dtpBirthDate.Value = DateTime.Now
        txtPhoneNumber.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        PictureBoxStudentImage.Image = My.Resources.profile
    End Sub

    'create a function to verify if all field is filled
    Function verif() As Boolean
        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or cbGender.SelectedItem Is Nothing Or txtPhoneNumber.Text.Trim() = "" Or
           txtEmail.Text.Trim() = "" Or txtAddress.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub DataGridView_students_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView_students.MouseClick
        Try
            Dim hit As DataGridView.HitTestInfo = DataGridView_students.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then ' Ensure a valid row index is clicked
                Dim dr As DataGridViewRow = DataGridView_students.Rows(hit.RowIndex)
                txtStudentID.Text = dr.Cells(0).Value.ToString()
                txtFirstName.Text = dr.Cells(1).Value.ToString()
                txtLastName.Text = dr.Cells(2).Value.ToString()
                cbGender.SelectedItem = dr.Cells(3).Value.ToString()
                dtpBirthDate.Value = Convert.ToDateTime(dr.Cells(4).Value)
                txtPhoneNumber.Text = dr.Cells(5).Value.ToString()
                txtEmail.Text = dr.Cells(6).Value.ToString()
                txtAddress.Text = dr.Cells(7).Value.ToString()
                'get image
                Dim data As Byte() = DirectCast(dr.Cells(8).Value, Byte())
                Dim ms As New MemoryStream(data)
                PictureBoxStudentImage.Image = Image.FromStream(ms)
                btnAdd.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MsgBox("Please select a student to Update.", MsgBoxStyle.Exclamation, "Update Student")
            Return
        End If

        Try
            conn.Open()
            query = "UPDATE students SET student_firstname = @firstname, student_lastname = @lastname, gender = @gender, birthday = @birthday, 
                     phoneNumber = @phone, address = @address, profile_photo = @photo, email = @emailaddress WHERE id = " & txtStudentID.Text & ""

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = txtFirstName.Text
            cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = txtLastName.Text
            cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = cbGender.SelectedItem
            cmd.Parameters.Add("@birthday", MySqlDbType.Date).Value = Format(dtpBirthDate.Value, "yyyy/MM/dd")
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txtPhoneNumber.Text
            cmd.Parameters.Add("@address", MySqlDbType.Text).Value = txtAddress.Text
            cmd.Parameters.Add("@emailaddress", MySqlDbType.VarChar).Value = txtEmail.Text

            ' Input for image
            If PictureBoxStudentImage.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    Dim img As New Bitmap(PictureBoxStudentImage.Image)
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.ToArray() ' Use ToArray() instead of GetBuffer()
                    Dim p As New MySqlParameter("@photo", MySqlDbType.LongBlob)
                    p.Value = data
                    cmd.Parameters.Add(p)
                End Using
            Else
                ' Handle case where no image is provided
                cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = DBNull.Value
            End If


            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Update Record Successful", MsgBoxStyle.Information, "Update Student")
                reset()
            Else
                MsgBox("Insert Error Student Info", MsgBoxStyle.Critical, "Update Student")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        If btnAdd.Visible = False Then
            btnAdd.Visible = True
        End If
        getDisplay()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        reset()
        If btnAdd.Visible = False Then
            btnAdd.Visible = True
        End If
        getDisplay()
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged
        ' Check if the length of the text exceeds 11 characters
        If txtPhoneNumber.Text.Length > 11 Then
            txtPhoneNumber.Text = txtPhoneNumber.Text.Substring(0, 11)
            txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length
        End If
    End Sub

    Private Sub txtFirstName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtLastName.KeyDown, txtEmail.KeyDown, txtAddress.KeyDown, txtPhoneNumber.KeyDown, cbGender.KeyDown, dtpBirthDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Select Case sender.Name
                Case "txtFirstName"
                    txtLastName.Focus()
                Case "txtLastName"
                    txtEmail.Focus()
                Case "txtEmail"
                    txtAddress.Focus()
                Case "txtAddress"
                    txtPhoneNumber.Focus()
                Case "txtPhoneNumber"
                    cbGender.Focus()
                Case "cbGender"
                    dtpBirthDate.Focus()
            End Select
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If DataGridView_students.Rows.Count = 0 Then
            MsgBox("Please load the data first before printing.", MsgBoxStyle.Exclamation, "No Data to Print")
            Return
        End If

        PrintDocument1.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintPage(e, DataGridView_students)
        Dim format As New StringFormat

        e.Graphics.DrawString("Student Information", New Font("Center Gothic", 20, FontStyle.Bold), Brushes.Black, New Point(480, 50), format)
    End Sub
End Class

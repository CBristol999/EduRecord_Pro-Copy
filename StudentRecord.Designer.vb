<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRecord))
        Panel1 = New Panel()
        txtEmail = New TextBox()
        Label1 = New Label()
        Panel6 = New Panel()
        btnClear = New Button()
        btnPrint = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        btnUpload = New Button()
        PictureBoxStudentImage = New PictureBox()
        Label13 = New Label()
        Label4 = New Label()
        dtpBirthDate = New DateTimePicker()
        txtAddress = New TextBox()
        txtPhoneNumber = New TextBox()
        Label5 = New Label()
        Label8 = New Label()
        txtStudentID = New TextBox()
        Label12 = New Label()
        Label9 = New Label()
        cbGender = New ComboBox()
        txtLastName = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        txtFirstName = New TextBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        btnRefresh = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Label7 = New Label()
        DataGridView_students = New DataGridView()
        Label6 = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView_students, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(btnUpload)
        Panel1.Controls.Add(PictureBoxStudentImage)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(dtpBirthDate)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(txtPhoneNumber)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtStudentID)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(cbGender)
        Panel1.Controls.Add(txtLastName)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtFirstName)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(18, 469)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(943, 343)
        Panel1.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(138, 151)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(271, 23)
        txtEmail.TabIndex = 44
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label1.Location = New Point(62, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 43
        Label1.Text = "Email:"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(btnClear)
        Panel6.Controls.Add(btnPrint)
        Panel6.Controls.Add(btnDelete)
        Panel6.Controls.Add(btnUpdate)
        Panel6.Controls.Add(btnAdd)
        Panel6.Location = New Point(27, 269)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(555, 64)
        Panel6.TabIndex = 9
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(332, 12)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 40)
        btnClear.TabIndex = 12
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(443, 11)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(92, 41)
        btnPrint.TabIndex = 11
        btnPrint.Text = "PRINT"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(217, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(98, 40)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(110, 11)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(89, 40)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(17, 11)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(76, 40)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpload
        ' 
        btnUpload.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpload.ForeColor = Color.Black
        btnUpload.Location = New Point(628, 289)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(174, 23)
        btnUpload.TabIndex = 42
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxStudentImage
        ' 
        PictureBoxStudentImage.BorderStyle = BorderStyle.FixedSingle
        PictureBoxStudentImage.Image = My.Resources.Resources.profile
        PictureBoxStudentImage.Location = New Point(628, 154)
        PictureBoxStudentImage.Name = "PictureBoxStudentImage"
        PictureBoxStudentImage.Size = New Size(174, 135)
        PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxStudentImage.TabIndex = 41
        PictureBoxStudentImage.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(463, 152)
        Label13.Name = "Label13"
        Label13.Size = New Size(131, 20)
        Label13.TabIndex = 40
        Label13.Text = "Profile Picture:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label4.Location = New Point(497, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 39
        Label4.Text = "Birth Date:"
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Format = DateTimePickerFormat.Custom
        dtpBirthDate.Location = New Point(628, 108)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(271, 23)
        dtpBirthDate.TabIndex = 38
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.White
        txtAddress.ForeColor = Color.Black
        txtAddress.Location = New Point(138, 188)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(271, 70)
        txtAddress.TabIndex = 37
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(628, 24)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(271, 23)
        txtPhoneNumber.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label5.Location = New Point(39, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 35
        Label5.Text = "Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label8.Location = New Point(462, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 20)
        Label8.TabIndex = 34
        Label8.Text = "Phone Number:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(138, 23)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.ReadOnly = True
        txtStudentID.Size = New Size(98, 23)
        txtStudentID.TabIndex = 33
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label12.Location = New Point(28, 23)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 20)
        Label12.TabIndex = 32
        Label12.Text = "Student ID:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label9.Location = New Point(519, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 20)
        Label9.TabIndex = 30
        Label9.Text = "Gender:"
        ' 
        ' cbGender
        ' 
        cbGender.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"Male", "Female"})
        cbGender.Location = New Point(628, 67)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(126, 24)
        cbGender.TabIndex = 29
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(138, 110)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(271, 23)
        txtLastName.TabIndex = 31
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label11.Location = New Point(28, 68)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 20)
        Label11.TabIndex = 26
        Label11.Text = "First Name:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label10.Location = New Point(28, 112)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 20)
        Label10.TabIndex = 28
        Label10.Text = "Last Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(138, 66)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(271, 23)
        txtFirstName.TabIndex = 27
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(DataGridView_students)
        Panel3.Controls.Add(Label6)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(18, 14)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(943, 440)
        Panel3.TabIndex = 9
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(btnRefresh)
        Panel4.Controls.Add(btnSearch)
        Panel4.Controls.Add(txtSearch)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(131, 38)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(699, 56)
        Panel4.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(562, 10)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(106, 33)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(440, 10)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(106, 33)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(179, 16)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(239, 23)
        txtSearch.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(15, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 22)
        Label7.TabIndex = 3
        Label7.Text = "Search Student:"
        ' 
        ' DataGridView_students
        ' 
        DataGridView_students.AllowUserToAddRows = False
        DataGridView_students.AllowUserToDeleteRows = False
        DataGridView_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_students.Location = New Point(27, 107)
        DataGridView_students.Name = "DataGridView_students"
        DataGridView_students.ReadOnly = True
        DataGridView_students.Size = New Size(881, 310)
        DataGridView_students.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(388, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 23)
        Label6.TabIndex = 0
        Label6.Text = "Student Record"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' StudentRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentRecord"
        Text = "LogIn"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView_students, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents PictureBoxStudentImage As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView_students As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

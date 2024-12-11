<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courses
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Courses))
        panels = New Panel()
        txtTableID = New TextBox()
        cbSemester = New ComboBox()
        Panel2 = New Panel()
        btnIdSearch = New Button()
        txtIdSearch = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        txtStudentID = New TextBox()
        Label12 = New Label()
        Label9 = New Label()
        cbYear = New ComboBox()
        cbCourse2 = New ComboBox()
        Label11 = New Label()
        cbCourse3 = New ComboBox()
        Panel6 = New Panel()
        btnUpdate = New Button()
        btnPrint = New Button()
        btnClear = New Button()
        btnRemoveCourse = New Button()
        btnSave = New Button()
        btnAddCourse = New Button()
        txtFullName = New TextBox()
        cbCourse4 = New ComboBox()
        cbCourse1 = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        cbSemesterFind = New ComboBox()
        Label7 = New Label()
        cbYearFind = New ComboBox()
        Label10 = New Label()
        btnRefresh = New Button()
        btnSearch = New Button()
        txtStudentIdFind = New TextBox()
        Label13 = New Label()
        displayDataCourse = New DataGridView()
        Label6 = New Label()
        BindingSource1 = New BindingSource(components)
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        panels.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(displayDataCourse, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panels
        ' 
        panels.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        panels.BorderStyle = BorderStyle.FixedSingle
        panels.Controls.Add(txtTableID)
        panels.Controls.Add(cbSemester)
        panels.Controls.Add(Panel2)
        panels.Controls.Add(Label3)
        panels.Controls.Add(txtStudentID)
        panels.Controls.Add(Label12)
        panels.Controls.Add(Label9)
        panels.Controls.Add(cbYear)
        panels.Controls.Add(cbCourse2)
        panels.Controls.Add(Label11)
        panels.Controls.Add(cbCourse3)
        panels.Controls.Add(Panel6)
        panels.Controls.Add(txtFullName)
        panels.Controls.Add(cbCourse4)
        panels.Controls.Add(cbCourse1)
        panels.Controls.Add(Label2)
        panels.Controls.Add(Label1)
        panels.Controls.Add(Label4)
        panels.Controls.Add(Label8)
        panels.Location = New Point(21, 468)
        panels.Name = "panels"
        panels.Size = New Size(940, 339)
        panels.TabIndex = 8
        ' 
        ' txtTableID
        ' 
        txtTableID.Enabled = False
        txtTableID.Location = New Point(322, 92)
        txtTableID.Name = "txtTableID"
        txtTableID.Size = New Size(33, 23)
        txtTableID.TabIndex = 48
        txtTableID.Visible = False
        ' 
        ' cbSemester
        ' 
        cbSemester.Enabled = False
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"1", "2"})
        cbSemester.Location = New Point(177, 222)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(125, 23)
        cbSemester.TabIndex = 47
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnIdSearch)
        Panel2.Controls.Add(txtIdSearch)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(165, 14)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(582, 56)
        Panel2.TabIndex = 7
        ' 
        ' btnIdSearch
        ' 
        btnIdSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnIdSearch.FlatAppearance.BorderSize = 0
        btnIdSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnIdSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnIdSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnIdSearch.FlatStyle = FlatStyle.Flat
        btnIdSearch.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIdSearch.ForeColor = Color.White
        btnIdSearch.Location = New Point(440, 10)
        btnIdSearch.Name = "btnIdSearch"
        btnIdSearch.Size = New Size(106, 33)
        btnIdSearch.TabIndex = 5
        btnIdSearch.Text = "Search"
        btnIdSearch.UseVisualStyleBackColor = False
        ' 
        ' txtIdSearch
        ' 
        txtIdSearch.Location = New Point(137, 16)
        txtIdSearch.Name = "txtIdSearch"
        txtIdSearch.Size = New Size(283, 23)
        txtIdSearch.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(16, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 22)
        Label5.TabIndex = 3
        Label5.Text = "Student ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label3.Location = New Point(117, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 46
        Label3.Text = "Year:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Enabled = False
        txtStudentID.Location = New Point(177, 91)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(125, 23)
        txtStudentID.TabIndex = 41
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label12.Location = New Point(69, 91)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 20)
        Label12.TabIndex = 40
        Label12.Text = "Student ID:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label9.Location = New Point(77, 221)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 20)
        Label9.TabIndex = 38
        Label9.Text = "Semester:"
        ' 
        ' cbYear
        ' 
        cbYear.Enabled = False
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYear.Location = New Point(177, 177)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(125, 23)
        cbYear.TabIndex = 37
        ' 
        ' cbCourse2
        ' 
        cbCourse2.Enabled = False
        cbCourse2.FormattingEnabled = True
        cbCourse2.Location = New Point(607, 134)
        cbCourse2.Name = "cbCourse2"
        cbCourse2.Size = New Size(271, 23)
        cbCourse2.TabIndex = 45
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label11.Location = New Point(39, 135)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 20)
        Label11.TabIndex = 34
        Label11.Text = "Student Name:"
        ' 
        ' cbCourse3
        ' 
        cbCourse3.Enabled = False
        cbCourse3.FormattingEnabled = True
        cbCourse3.Location = New Point(607, 178)
        cbCourse3.Name = "cbCourse3"
        cbCourse3.Size = New Size(271, 23)
        cbCourse3.TabIndex = 44
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(btnUpdate)
        Panel6.Controls.Add(btnPrint)
        Panel6.Controls.Add(btnClear)
        Panel6.Controls.Add(btnRemoveCourse)
        Panel6.Controls.Add(btnSave)
        Panel6.Controls.Add(btnAddCourse)
        Panel6.Location = New Point(52, 268)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(845, 60)
        Panel6.TabIndex = 9
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnUpdate.Enabled = False
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(102, 9)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(89, 38)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(284, 9)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(77, 38)
        btnPrint.TabIndex = 11
        btnPrint.Text = "PRINT"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(199, 9)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(77, 38)
        btnClear.TabIndex = 10
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveCourse
        ' 
        btnRemoveCourse.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnRemoveCourse.FlatAppearance.BorderSize = 0
        btnRemoveCourse.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnRemoveCourse.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRemoveCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRemoveCourse.FlatStyle = FlatStyle.Flat
        btnRemoveCourse.Font = New Font("Arial Rounded MT Bold", 12F)
        btnRemoveCourse.ForeColor = Color.White
        btnRemoveCourse.Location = New Point(592, 9)
        btnRemoveCourse.Name = "btnRemoveCourse"
        btnRemoveCourse.Size = New Size(234, 38)
        btnRemoveCourse.TabIndex = 9
        btnRemoveCourse.Text = "REMOVE / EDIT COURSES"
        btnRemoveCourse.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(17, 9)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(77, 38)
        btnSave.TabIndex = 8
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAddCourse.FlatAppearance.BorderSize = 0
        btnAddCourse.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddCourse.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnAddCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnAddCourse.FlatStyle = FlatStyle.Flat
        btnAddCourse.Font = New Font("Arial Rounded MT Bold", 12F)
        btnAddCourse.ForeColor = Color.White
        btnAddCourse.Location = New Point(391, 9)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(192, 38)
        btnAddCourse.TabIndex = 9
        btnAddCourse.Text = "ADD NEW COURSES"
        btnAddCourse.UseVisualStyleBackColor = False
        ' 
        ' txtFullName
        ' 
        txtFullName.Enabled = False
        txtFullName.Location = New Point(177, 135)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(271, 23)
        txtFullName.TabIndex = 35
        ' 
        ' cbCourse4
        ' 
        cbCourse4.Enabled = False
        cbCourse4.FormattingEnabled = True
        cbCourse4.Location = New Point(607, 221)
        cbCourse4.Name = "cbCourse4"
        cbCourse4.Size = New Size(271, 23)
        cbCourse4.TabIndex = 43
        ' 
        ' cbCourse1
        ' 
        cbCourse1.Enabled = False
        cbCourse1.FormattingEnabled = True
        cbCourse1.Location = New Point(607, 92)
        cbCourse1.Name = "cbCourse1"
        cbCourse1.Size = New Size(271, 23)
        cbCourse1.TabIndex = 42
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label2.Location = New Point(500, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 41
        Label2.Text = "Course 4:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label1.Location = New Point(500, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 40
        Label1.Text = "Course 3:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label4.Location = New Point(500, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 39
        Label4.Text = "Course 2:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label8.Location = New Point(500, 91)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 20)
        Label8.TabIndex = 34
        Label8.Text = "Course 1:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(displayDataCourse)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(21, 21)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(940, 427)
        Panel3.TabIndex = 7
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(cbSemesterFind)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(cbYearFind)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(btnRefresh)
        Panel4.Controls.Add(btnSearch)
        Panel4.Controls.Add(txtStudentIdFind)
        Panel4.Controls.Add(Label13)
        Panel4.Location = New Point(116, 40)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(699, 56)
        Panel4.TabIndex = 3
        ' 
        ' cbSemesterFind
        ' 
        cbSemesterFind.FormattingEnabled = True
        cbSemesterFind.Items.AddRange(New Object() {"1", "2"})
        cbSemesterFind.Location = New Point(410, 15)
        cbSemesterFind.Name = "cbSemesterFind"
        cbSemesterFind.Size = New Size(71, 23)
        cbSemesterFind.TabIndex = 52
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(323, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 17)
        Label7.TabIndex = 8
        Label7.Text = "Semester:"
        ' 
        ' cbYearFind
        ' 
        cbYearFind.FormattingEnabled = True
        cbYearFind.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYearFind.Location = New Point(242, 16)
        cbYearFind.Name = "cbYearFind"
        cbYearFind.Size = New Size(67, 23)
        cbYearFind.TabIndex = 52
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(192, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 17)
        Label10.TabIndex = 7
        Label10.Text = "Year:"
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
        btnRefresh.Location = New Point(593, 10)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(85, 33)
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
        btnSearch.Location = New Point(502, 10)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(81, 33)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtStudentIdFind
        ' 
        txtStudentIdFind.Location = New Point(106, 16)
        txtStudentIdFind.Name = "txtStudentIdFind"
        txtStudentIdFind.Size = New Size(73, 23)
        txtStudentIdFind.TabIndex = 4
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(15, 19)
        Label13.Name = "Label13"
        Label13.Size = New Size(89, 17)
        Label13.TabIndex = 3
        Label13.Text = "Student ID:"
        ' 
        ' displayDataCourse
        ' 
        displayDataCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        displayDataCourse.Location = New Point(26, 107)
        displayDataCourse.Name = "displayDataCourse"
        displayDataCourse.Size = New Size(870, 297)
        displayDataCourse.TabIndex = 1
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
        ' PrintDocument1
        ' 
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
        ' Courses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        Controls.Add(panels)
        Controls.Add(Panel3)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Name = "Courses"
        Text = "Courses"
        panels.ResumeLayout(False)
        panels.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(displayDataCourse, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panels As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents displayDataCourse As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cbCourse2 As ComboBox
    Friend WithEvents cbCourse3 As ComboBox
    Friend WithEvents cbCourse4 As ComboBox
    Friend WithEvents cbCourse1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdSearch As TextBox
    Friend WithEvents btnRemoveCourse As Button
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnIdSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtTableID As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbSemesterFind As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbYearFind As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtStudentIdFind As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

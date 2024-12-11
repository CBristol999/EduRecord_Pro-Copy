<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddScore))
        Panel3 = New Panel()
        Panel4 = New Panel()
        cbSemesterFind = New ComboBox()
        Label9 = New Label()
        cbYearFind = New ComboBox()
        Label1 = New Label()
        btnRefresh = New Button()
        btnSearch = New Button()
        txtStudentIdFind = New TextBox()
        Label7 = New Label()
        displayDataScores = New DataGridView()
        Label6 = New Label()
        Panel1 = New Panel()
        txtCourse4 = New TextBox()
        txtCourse3 = New TextBox()
        txtCourse2 = New TextBox()
        txtCourse1 = New TextBox()
        txtScoreID = New TextBox()
        Label11 = New Label()
        txtFullName = New TextBox()
        txtCourseScore4 = New TextBox()
        txtCourseScore3 = New TextBox()
        txtCourseScore2 = New TextBox()
        txtCourseScore1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        cbSemester = New ComboBox()
        Label10 = New Label()
        Label13 = New Label()
        cbYear = New ComboBox()
        btnIdSearch = New Button()
        txtIdSearch = New TextBox()
        Label5 = New Label()
        Panel6 = New Panel()
        btnPrint = New Button()
        btnClear = New Button()
        btnSave = New Button()
        txtID = New TextBox()
        Label12 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(displayDataScores, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(displayDataScores)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(21, 21)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(940, 427)
        Panel3.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(cbSemesterFind)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(cbYearFind)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(btnRefresh)
        Panel4.Controls.Add(btnSearch)
        Panel4.Controls.Add(txtStudentIdFind)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(131, 38)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(699, 56)
        Panel4.TabIndex = 2
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(323, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 17)
        Label9.TabIndex = 8
        Label9.Text = "Semester:"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(192, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 17)
        Label1.TabIndex = 7
        Label1.Text = "Year:"
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(15, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 17)
        Label7.TabIndex = 3
        Label7.Text = "Student ID:"
        ' 
        ' displayDataScores
        ' 
        displayDataScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        displayDataScores.Location = New Point(25, 111)
        displayDataScores.Name = "displayDataScores"
        displayDataScores.Size = New Size(883, 291)
        displayDataScores.TabIndex = 1
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtCourse4)
        Panel1.Controls.Add(txtCourse3)
        Panel1.Controls.Add(txtCourse2)
        Panel1.Controls.Add(txtCourse1)
        Panel1.Controls.Add(txtScoreID)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtFullName)
        Panel1.Controls.Add(txtCourseScore4)
        Panel1.Controls.Add(txtCourseScore3)
        Panel1.Controls.Add(txtCourseScore2)
        Panel1.Controls.Add(txtCourseScore1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label12)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(21, 465)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 339)
        Panel1.TabIndex = 11
        ' 
        ' txtCourse4
        ' 
        txtCourse4.Location = New Point(559, 185)
        txtCourse4.Name = "txtCourse4"
        txtCourse4.ReadOnly = True
        txtCourse4.Size = New Size(271, 23)
        txtCourse4.TabIndex = 65
        ' 
        ' txtCourse3
        ' 
        txtCourse3.Location = New Point(558, 139)
        txtCourse3.Name = "txtCourse3"
        txtCourse3.ReadOnly = True
        txtCourse3.Size = New Size(271, 23)
        txtCourse3.TabIndex = 64
        ' 
        ' txtCourse2
        ' 
        txtCourse2.Location = New Point(558, 97)
        txtCourse2.Name = "txtCourse2"
        txtCourse2.ReadOnly = True
        txtCourse2.Size = New Size(271, 23)
        txtCourse2.TabIndex = 63
        ' 
        ' txtCourse1
        ' 
        txtCourse1.Location = New Point(558, 52)
        txtCourse1.Name = "txtCourse1"
        txtCourse1.ReadOnly = True
        txtCourse1.Size = New Size(271, 23)
        txtCourse1.TabIndex = 62
        ' 
        ' txtScoreID
        ' 
        txtScoreID.Enabled = False
        txtScoreID.Location = New Point(311, 203)
        txtScoreID.Name = "txtScoreID"
        txtScoreID.Size = New Size(46, 23)
        txtScoreID.TabIndex = 60
        txtScoreID.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label11.Location = New Point(27, 249)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 20)
        Label11.TabIndex = 58
        Label11.Text = "Student Name:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(165, 246)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(267, 23)
        txtFullName.TabIndex = 59
        ' 
        ' txtCourseScore4
        ' 
        txtCourseScore4.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCourseScore4.Location = New Point(848, 183)
        txtCourseScore4.Name = "txtCourseScore4"
        txtCourseScore4.Size = New Size(53, 26)
        txtCourseScore4.TabIndex = 57
        txtCourseScore4.Text = "0.0"
        txtCourseScore4.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourseScore3
        ' 
        txtCourseScore3.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCourseScore3.Location = New Point(848, 138)
        txtCourseScore3.Name = "txtCourseScore3"
        txtCourseScore3.Size = New Size(53, 26)
        txtCourseScore3.TabIndex = 56
        txtCourseScore3.Text = "0.0"
        txtCourseScore3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourseScore2
        ' 
        txtCourseScore2.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCourseScore2.Location = New Point(848, 95)
        txtCourseScore2.Name = "txtCourseScore2"
        txtCourseScore2.Size = New Size(53, 26)
        txtCourseScore2.TabIndex = 55
        txtCourseScore2.Text = "0.0"
        txtCourseScore2.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourseScore1
        ' 
        txtCourseScore1.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCourseScore1.Location = New Point(848, 53)
        txtCourseScore1.Name = "txtCourseScore1"
        txtCourseScore1.Size = New Size(53, 26)
        txtCourseScore1.TabIndex = 54
        txtCourseScore1.Text = "0.0"
        txtCourseScore1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label2.Location = New Point(463, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 49
        Label2.Text = "Course 4:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label3.Location = New Point(463, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 48
        Label3.Text = "Course 3:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label4.Location = New Point(463, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 47
        Label4.Text = "Course 2:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label8.Location = New Point(463, 54)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 20)
        Label8.TabIndex = 46
        Label8.Text = "Course 1:"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(cbSemester)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(cbYear)
        Panel2.Controls.Add(btnIdSearch)
        Panel2.Controls.Add(txtIdSearch)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(25, 26)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(407, 148)
        Panel2.TabIndex = 10
        ' 
        ' cbSemester
        ' 
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"1", "2"})
        cbSemester.Location = New Point(134, 100)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(125, 23)
        cbSemester.TabIndex = 51
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label10.Location = New Point(66, 59)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 22)
        Label10.TabIndex = 50
        Label10.Text = "Year:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label13.Location = New Point(26, 98)
        Label13.Name = "Label13"
        Label13.Size = New Size(104, 22)
        Label13.TabIndex = 49
        Label13.Text = "Semester:"
        ' 
        ' cbYear
        ' 
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYear.Location = New Point(134, 59)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(125, 23)
        cbYear.TabIndex = 48
        ' 
        ' btnIdSearch
        ' 
        btnIdSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnIdSearch.FlatAppearance.BorderSize = 0
        btnIdSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnIdSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnIdSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnIdSearch.FlatStyle = FlatStyle.Flat
        btnIdSearch.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIdSearch.ForeColor = Color.White
        btnIdSearch.Location = New Point(276, 18)
        btnIdSearch.Name = "btnIdSearch"
        btnIdSearch.Size = New Size(106, 105)
        btnIdSearch.TabIndex = 5
        btnIdSearch.Text = "SEARCH"
        btnIdSearch.UseVisualStyleBackColor = False
        ' 
        ' txtIdSearch
        ' 
        txtIdSearch.Location = New Point(134, 17)
        txtIdSearch.Name = "txtIdSearch"
        txtIdSearch.Size = New Size(125, 23)
        txtIdSearch.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 22)
        Label5.TabIndex = 3
        Label5.Text = "Student ID:"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(btnPrint)
        Panel6.Controls.Add(btnClear)
        Panel6.Controls.Add(btnSave)
        Panel6.Location = New Point(491, 237)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(400, 82)
        Panel6.TabIndex = 9
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(271, 15)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(106, 50)
        btnPrint.TabIndex = 13
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
        btnClear.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(142, 15)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(111, 50)
        btnClear.TabIndex = 11
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(17, 15)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(108, 50)
        btnSave.TabIndex = 8
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(165, 203)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(135, 23)
        txtID.TabIndex = 33
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Enabled = False
        Label12.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label12.Location = New Point(27, 204)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 20)
        Label12.TabIndex = 32
        Label12.Text = "Student ID:"
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
        ' AddScore
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Name = "AddScore"
        Text = "AddScore"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(displayDataScores, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents displayDataScores As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtCourseScore4 As TextBox
    Friend WithEvents txtCourseScore3 As TextBox
    Friend WithEvents txtCourseScore2 As TextBox
    Friend WithEvents txtCourseScore1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnIdSearch As Button
    Friend WithEvents txtIdSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtScoreID As TextBox
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents cbSemesterFind As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbYearFind As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentIdFind As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

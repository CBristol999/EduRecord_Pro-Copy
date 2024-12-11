<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveEditCourses
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
        Panel5 = New Panel()
        Label3 = New Label()
        cbYear = New ComboBox()
        Label4 = New Label()
        Label9 = New Label()
        cbSemester = New ComboBox()
        btnRemove = New Button()
        btnSaveEdit = New Button()
        Panel2 = New Panel()
        btnCancel = New Button()
        Label5 = New Label()
        cbYearSearch = New ComboBox()
        Label6 = New Label()
        cbSemesterSearch = New ComboBox()
        Label1 = New Label()
        btnSearch = New Button()
        Panel1 = New Panel()
        txtEditCourseName = New TextBox()
        txtCourseID = New TextBox()
        displayCourses = New DataGridView()
        btnClear = New Button()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(displayCourses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(145, 21)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(280, 54)
        Panel5.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(21, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(232, 22)
        Label3.TabIndex = 52
        Label3.Tag = ""
        Label3.Text = "REMOVE/EDIT COURSE"
        ' 
        ' cbYear
        ' 
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYear.Location = New Point(258, 415)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(145, 23)
        cbYear.TabIndex = 56
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(68, 504)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 22)
        Label4.TabIndex = 55
        Label4.Text = "Edit Course Name:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(68, 460)
        Label9.Name = "Label9"
        Label9.Size = New Size(146, 22)
        Label9.TabIndex = 53
        Label9.Text = "Edit Semester:"
        ' 
        ' cbSemester
        ' 
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"1", "2"})
        cbSemester.Location = New Point(258, 459)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(145, 23)
        cbSemester.TabIndex = 52
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnRemove.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRemove.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnRemove.ForeColor = Color.White
        btnRemove.Location = New Point(157, 13)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(105, 47)
        btnRemove.TabIndex = 50
        btnRemove.Text = "REMOVE"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSaveEdit.FlatAppearance.BorderSize = 0
        btnSaveEdit.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSaveEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSaveEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSaveEdit.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnSaveEdit.ForeColor = Color.White
        btnSaveEdit.Location = New Point(20, 13)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(122, 47)
        btnSaveEdit.TabIndex = 51
        btnSaveEdit.Text = "SAVE EDIT"
        btnSaveEdit.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnSaveEdit)
        Panel2.Controls.Add(btnRemove)
        Panel2.Location = New Point(78, 565)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(405, 77)
        Panel2.TabIndex = 58
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(275, 13)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(107, 47)
        btnCancel.TabIndex = 44
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(15, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 18)
        Label5.TabIndex = 64
        Label5.Text = "Year:"
        ' 
        ' cbYearSearch
        ' 
        cbYearSearch.FormattingEnabled = True
        cbYearSearch.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYearSearch.Location = New Point(74, 19)
        cbYearSearch.Name = "cbYearSearch"
        cbYearSearch.Size = New Size(63, 23)
        cbYearSearch.TabIndex = 63
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(155, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 18)
        Label6.TabIndex = 62
        Label6.Text = "Semester:"
        ' 
        ' cbSemesterSearch
        ' 
        cbSemesterSearch.FormattingEnabled = True
        cbSemesterSearch.Items.AddRange(New Object() {"1", "2"})
        cbSemesterSearch.Location = New Point(257, 18)
        cbSemesterSearch.Name = "cbSemesterSearch"
        cbSemesterSearch.Size = New Size(69, 23)
        cbSemesterSearch.TabIndex = 61
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(68, 412)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 22)
        Label1.TabIndex = 57
        Label1.Text = "Edit Year:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(348, 11)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 37)
        btnSearch.TabIndex = 52
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(cbSemesterSearch)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(cbYearSearch)
        Panel1.Location = New Point(47, 321)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(466, 61)
        Panel1.TabIndex = 53
        ' 
        ' txtEditCourseName
        ' 
        txtEditCourseName.Location = New Point(258, 504)
        txtEditCourseName.Name = "txtEditCourseName"
        txtEditCourseName.Size = New Size(241, 23)
        txtEditCourseName.TabIndex = 49
        ' 
        ' txtCourseID
        ' 
        txtCourseID.Location = New Point(196, 414)
        txtCourseID.Name = "txtCourseID"
        txtCourseID.Size = New Size(46, 23)
        txtCourseID.TabIndex = 61
        txtCourseID.Visible = False
        ' 
        ' displayCourses
        ' 
        displayCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        displayCourses.Location = New Point(47, 99)
        displayCourses.Name = "displayCourses"
        displayCourses.Size = New Size(466, 205)
        displayCourses.TabIndex = 63
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(419, 415)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 67)
        btnClear.TabIndex = 65
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' RemoveEditCourses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        ClientSize = New Size(561, 662)
        Controls.Add(btnClear)
        Controls.Add(displayCourses)
        Controls.Add(txtCourseID)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(cbYear)
        Controls.Add(Label4)
        Controls.Add(Label9)
        Controls.Add(cbSemester)
        Controls.Add(txtEditCourseName)
        Controls.Add(Panel5)
        ForeColor = Color.Black
        Name = "RemoveEditCourses"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RemoveEditCourses"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(displayCourses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbYearSearch As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbSemesterSearch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEditCourseName As TextBox
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents displayCourses As DataGridView
    Friend WithEvents btnClear As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarkSheet))
        Panel3 = New Panel()
        Panel6 = New Panel()
        btnPrint = New Button()
        btnClear = New Button()
        Panel5 = New Panel()
        txtCGPA = New TextBox()
        Label3 = New Label()
        displayCGPA = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        Panel1 = New Panel()
        txtEmail = New TextBox()
        txtContactNumber = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        PictureBoxStudentImage = New PictureBox()
        Label13 = New Label()
        txtStudentID = New TextBox()
        Label12 = New Label()
        Panel2 = New Panel()
        btnSearch = New Button()
        txtSearchID = New TextBox()
        Label5 = New Label()
        Label11 = New Label()
        txtFullName = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        CType(displayCGPA, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(displayCGPA)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(18, 332)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(940, 473)
        Panel3.TabIndex = 9
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(btnPrint)
        Panel6.Controls.Add(btnClear)
        Panel6.Location = New Point(428, 396)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(302, 61)
        Panel6.TabIndex = 41
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
        btnPrint.Location = New Point(164, 10)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(106, 39)
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
        btnClear.Location = New Point(24, 11)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(111, 38)
        btnClear.TabIndex = 11
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(txtCGPA)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(138, 395)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(252, 61)
        Panel5.TabIndex = 40
        ' 
        ' txtCGPA
        ' 
        txtCGPA.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        txtCGPA.BorderStyle = BorderStyle.None
        txtCGPA.Font = New Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCGPA.Location = New Point(133, 10)
        txtCGPA.Multiline = True
        txtCGPA.Name = "txtCGPA"
        txtCGPA.ReadOnly = True
        txtCGPA.Size = New Size(80, 40)
        txtCGPA.TabIndex = 53
        txtCGPA.Text = "0.0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 21F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 32)
        Label3.TabIndex = 52
        Label3.Tag = ""
        Label3.Text = "CGPA:"
        ' 
        ' displayCGPA
        ' 
        displayCGPA.AllowUserToAddRows = False
        displayCGPA.AllowUserToDeleteRows = False
        displayCGPA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        displayCGPA.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        displayCGPA.Location = New Point(25, 61)
        displayCGPA.Name = "displayCGPA"
        displayCGPA.ReadOnly = True
        displayCGPA.Size = New Size(883, 313)
        displayCGPA.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Student ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Student Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Year"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Semester"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Course 1"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Score 1"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Course 2"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Score 2"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Course 3"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Course 3"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Course 4"
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Score 4"
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Average"
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(389, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(173, 25)
        Label6.TabIndex = 0
        Label6.Text = "Student Record"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtContactNumber)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBoxStudentImage)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtStudentID)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtFullName)
        Panel1.Location = New Point(18, 21)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 283)
        Panel1.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(191, 234)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(271, 23)
        txtEmail.TabIndex = 48
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(191, 200)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(271, 23)
        txtContactNumber.TabIndex = 47
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label4.Location = New Point(26, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 20)
        Label4.TabIndex = 46
        Label4.Text = "Contact Number: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label2.Location = New Point(26, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 45
        Label2.Text = "Email:"
        ' 
        ' PictureBoxStudentImage
        ' 
        PictureBoxStudentImage.BorderStyle = BorderStyle.FixedSingle
        PictureBoxStudentImage.Image = My.Resources.Resources.profile
        PictureBoxStudentImage.Location = New Point(644, 22)
        PictureBoxStudentImage.Name = "PictureBoxStudentImage"
        PictureBoxStudentImage.Size = New Size(265, 218)
        PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxStudentImage.TabIndex = 43
        PictureBoxStudentImage.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(712, 246)
        Label13.Name = "Label13"
        Label13.Size = New Size(131, 20)
        Label13.TabIndex = 42
        Label13.Text = "Profile Picture:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(191, 127)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(271, 23)
        txtStudentID.TabIndex = 41
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label12.Location = New Point(26, 130)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 20)
        Label12.TabIndex = 40
        Label12.Text = "Student ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(txtSearchID)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(26, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(575, 88)
        Panel2.TabIndex = 9
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(427, 14)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(118, 58)
        btnSearch.TabIndex = 5
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Location = New Point(17, 49)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(387, 23)
        txtSearchID.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(272, 22)
        Label5.TabIndex = 3
        Label5.Text = "Student ID or Student Name:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label11.Location = New Point(26, 167)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 20)
        Label11.TabIndex = 34
        Label11.Text = "Student Name:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(191, 164)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(271, 23)
        txtFullName.TabIndex = 35
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
        ' MarkSheet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Name = "MarkSheet"
        Text = "MarkSheet"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(displayCGPA, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents displayCGPA As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtCGPA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBoxStudentImage As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

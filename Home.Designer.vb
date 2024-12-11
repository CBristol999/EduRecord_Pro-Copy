<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblClose = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        btnDashboard = New Button()
        panels = New Panel()
        btnLogOut = New Button()
        btnMarkSheet = New Button()
        btnAddScore = New Button()
        btnAddCourse = New Button()
        btnAddStudent = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel4 = New Panel()
        Panel7 = New Panel()
        PictureBox5 = New PictureBox()
        lblFemale = New Label()
        Label11 = New Label()
        Panel6 = New Panel()
        PictureBox4 = New PictureBox()
        lblMale = New Label()
        Label9 = New Label()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        lblTotal = New Label()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        panelHome = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        panelHome.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        Panel1.Controls.Add(lblClose)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1216, 46)
        Panel1.TabIndex = 0
        ' 
        ' lblClose
        ' 
        lblClose.AutoSize = True
        lblClose.Cursor = Cursors.Hand
        lblClose.Font = New Font("Tahoma", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClose.ForeColor = SystemColors.Control
        lblClose.Location = New Point(1176, 13)
        lblClose.Name = "lblClose"
        lblClose.Size = New Size(20, 21)
        lblClose.TabIndex = 11
        lblClose.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(12, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 19)
        Label2.TabIndex = 2
        Label2.Text = "Student Database Management"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(panels)
        Panel2.Controls.Add(btnLogOut)
        Panel2.Controls.Add(btnMarkSheet)
        Panel2.Controls.Add(btnAddScore)
        Panel2.Controls.Add(btnAddCourse)
        Panel2.Controls.Add(btnAddStudent)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 46)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(237, 827)
        Panel2.TabIndex = 1
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(18, 256)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(200, 40)
        btnDashboard.TabIndex = 9
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' panels
        ' 
        panels.Location = New Point(236, 0)
        panels.Name = "panels"
        panels.Size = New Size(1301, 827)
        panels.TabIndex = 2
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(18, 763)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(200, 40)
        btnLogOut.TabIndex = 8
        btnLogOut.Text = "Log out"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnMarkSheet
        ' 
        btnMarkSheet.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnMarkSheet.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnMarkSheet.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnMarkSheet.FlatStyle = FlatStyle.Flat
        btnMarkSheet.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMarkSheet.ForeColor = Color.White
        btnMarkSheet.Location = New Point(18, 488)
        btnMarkSheet.Name = "btnMarkSheet"
        btnMarkSheet.Size = New Size(200, 40)
        btnMarkSheet.TabIndex = 7
        btnMarkSheet.Text = "Mark Sheet"
        btnMarkSheet.UseVisualStyleBackColor = False
        ' 
        ' btnAddScore
        ' 
        btnAddScore.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAddScore.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddScore.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddScore.FlatStyle = FlatStyle.Flat
        btnAddScore.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddScore.ForeColor = Color.White
        btnAddScore.Location = New Point(18, 430)
        btnAddScore.Name = "btnAddScore"
        btnAddScore.Size = New Size(200, 40)
        btnAddScore.TabIndex = 6
        btnAddScore.Text = "Add Score"
        btnAddScore.UseVisualStyleBackColor = False
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAddCourse.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddCourse.FlatStyle = FlatStyle.Flat
        btnAddCourse.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddCourse.ForeColor = Color.White
        btnAddCourse.Location = New Point(18, 373)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(200, 40)
        btnAddCourse.TabIndex = 5
        btnAddCourse.Text = "Courses"
        btnAddCourse.UseVisualStyleBackColor = False
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAddStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddStudent.ForeColor = Color.White
        btnAddStudent.Location = New Point(18, 313)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(200, 40)
        btnAddStudent.TabIndex = 4
        btnAddStudent.Text = "Student"
        btnAddStudent.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(47, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 23)
        Label3.TabIndex = 3
        Label3.Text = "EduRecord Pro"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(52, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 121)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(991, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 16)
        Label1.TabIndex = 1
        Label1.Text = "X"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Panel3)
        Panel4.Location = New Point(35, 37)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(904, 247)
        Panel4.TabIndex = 9
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(PictureBox5)
        Panel7.Controls.Add(lblFemale)
        Panel7.Controls.Add(Label11)
        Panel7.ForeColor = Color.Black
        Panel7.Location = New Point(615, 35)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(257, 178)
        Panel7.TabIndex = 12
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.woman
        PictureBox5.Location = New Point(153, 88)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(87, 74)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' lblFemale
        ' 
        lblFemale.AutoSize = True
        lblFemale.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFemale.ForeColor = Color.White
        lblFemale.Location = New Point(13, 55)
        lblFemale.Name = "lblFemale"
        lblFemale.Size = New Size(37, 42)
        lblFemale.TabIndex = 10
        lblFemale.Text = "0"
        lblFemale.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(13, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(169, 23)
        Label11.TabIndex = 9
        Label11.Text = "Female Students"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(PictureBox4)
        Panel6.Controls.Add(lblMale)
        Panel6.Controls.Add(Label9)
        Panel6.ForeColor = Color.Black
        Panel6.Location = New Point(322, 34)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(260, 178)
        Panel6.TabIndex = 12
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.man
        PictureBox4.Location = New Point(158, 92)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(87, 74)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' lblMale
        ' 
        lblMale.AutoSize = True
        lblMale.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMale.ForeColor = Color.White
        lblMale.Location = New Point(13, 55)
        lblMale.Name = "lblMale"
        lblMale.Size = New Size(37, 42)
        lblMale.TabIndex = 10
        lblMale.Text = "0"
        lblMale.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(13, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(146, 23)
        Label9.TabIndex = 9
        Label9.Text = "Male Students"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(lblTotal)
        Panel3.Controls.Add(Label4)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(28, 34)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(257, 178)
        Panel3.TabIndex = 8
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.student
        PictureBox2.Location = New Point(149, 84)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(92, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.White
        lblTotal.Location = New Point(13, 55)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(37, 42)
        lblTotal.TabIndex = 10
        lblTotal.Text = "0"
        lblTotal.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(13, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 23)
        Label4.TabIndex = 9
        Label4.Text = "Total Students"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.pexels_pixabay_356065
        PictureBox3.Location = New Point(35, 313)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(904, 476)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' panelHome
        ' 
        panelHome.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        panelHome.Controls.Add(PictureBox3)
        panelHome.Controls.Add(Panel4)
        panelHome.Location = New Point(237, 46)
        panelHome.Name = "panelHome"
        panelHome.Size = New Size(979, 827)
        panelHome.TabIndex = 2
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1216, 873)
        ControlBox = False
        Controls.Add(panelHome)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        panelHome.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnMarkSheet As Button
    Friend WithEvents btnAddScore As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents panels As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblClose As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblFemale As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblMale As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents panelHome As Panel

End Class

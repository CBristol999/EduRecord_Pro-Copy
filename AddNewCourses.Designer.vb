<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewCourses
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
        txtCourseName = New TextBox()
        Label9 = New Label()
        cbSemester = New ComboBox()
        Panel5 = New Panel()
        Label2 = New Label()
        btnAdd = New Button()
        Label3 = New Label()
        Label1 = New Label()
        cbYear = New ComboBox()
        btnCancel = New Button()
        Panel2 = New Panel()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(233, 230)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(221, 23)
        txtCourseName.TabIndex = 37
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label9.Location = New Point(43, 183)
        Label9.Name = "Label9"
        Label9.Size = New Size(167, 22)
        Label9.TabIndex = 35
        Label9.Text = "Select Semester:"
        ' 
        ' cbSemester
        ' 
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"1", "2"})
        cbSemester.Location = New Point(233, 181)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(145, 23)
        cbSemester.TabIndex = 34
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label2)
        Panel5.Location = New Point(122, 28)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(235, 54)
        Panel5.TabIndex = 38
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label2.Location = New Point(23, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 22)
        Label2.TabIndex = 40
        Label2.Text = "ADD NEW COURSE"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnAdd.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(17, 13)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(107, 47)
        btnAdd.TabIndex = 39
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label3.Location = New Point(43, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(182, 22)
        Label3.TabIndex = 41
        Label3.Text = "Add Course Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label1.Location = New Point(43, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 22)
        Label1.TabIndex = 43
        Label1.Text = "Select Year:"
        ' 
        ' cbYear
        ' 
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYear.Location = New Point(233, 127)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(145, 23)
        cbYear.TabIndex = 42
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
        btnCancel.Location = New Point(148, 13)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(107, 47)
        btnCancel.TabIndex = 44
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(btnCancel)
        Panel2.Location = New Point(104, 287)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(275, 77)
        Panel2.TabIndex = 42
        ' 
        ' AddNewCourses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        ClientSize = New Size(488, 394)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(cbYear)
        Controls.Add(Label3)
        Controls.Add(Panel5)
        Controls.Add(txtCourseName)
        Controls.Add(Label9)
        Controls.Add(cbSemester)
        ForeColor = Color.White
        Name = "AddNewCourses"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddNewCourses"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel2 As Panel
End Class

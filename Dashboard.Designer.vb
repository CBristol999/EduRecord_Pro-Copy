<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        lblFemales = New Label()
        Label2 = New Label()
        panel9 = New Panel()
        PictureBox6 = New PictureBox()
        lblMales = New Label()
        Label5 = New Label()
        Panel8 = New Panel()
        PictureBox7 = New PictureBox()
        lblTotals = New Label()
        Label7 = New Label()
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
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panel9.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.pexels_pixabay_356065
        PictureBox3.Location = New Point(37, 313)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(904, 476)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(Panel1)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Panel3)
        Panel4.Location = New Point(37, 37)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(904, 247)
        Panel4.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(panel9)
        Panel1.Controls.Add(Panel8)
        Panel1.Location = New Point(-2, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 247)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(lblFemales)
        Panel2.Controls.Add(Label2)
        Panel2.ForeColor = Color.Black
        Panel2.Location = New Point(615, 37)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(257, 178)
        Panel2.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.woman
        PictureBox1.Location = New Point(153, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lblFemales
        ' 
        lblFemales.AutoSize = True
        lblFemales.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFemales.ForeColor = Color.White
        lblFemales.Location = New Point(13, 55)
        lblFemales.Name = "lblFemales"
        lblFemales.Size = New Size(37, 42)
        lblFemales.TabIndex = 10
        lblFemales.Text = "0"
        lblFemales.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 23)
        Label2.TabIndex = 9
        Label2.Text = "Female Students"
        ' 
        ' panel9
        ' 
        panel9.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        panel9.BorderStyle = BorderStyle.Fixed3D
        panel9.Controls.Add(PictureBox6)
        panel9.Controls.Add(lblMales)
        panel9.Controls.Add(Label5)
        panel9.ForeColor = Color.Black
        panel9.Location = New Point(322, 37)
        panel9.Name = "panel9"
        panel9.Size = New Size(260, 178)
        panel9.TabIndex = 12
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.man
        PictureBox6.Location = New Point(158, 92)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(87, 74)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' lblMales
        ' 
        lblMales.AutoSize = True
        lblMales.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMales.ForeColor = Color.White
        lblMales.Location = New Point(13, 55)
        lblMales.Name = "lblMales"
        lblMales.Size = New Size(37, 42)
        lblMales.TabIndex = 10
        lblMales.Text = "0"
        lblMales.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(13, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 23)
        Label5.TabIndex = 9
        Label5.Text = "Male Students"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(PictureBox7)
        Panel8.Controls.Add(lblTotals)
        Panel8.Controls.Add(Label7)
        Panel8.ForeColor = Color.Black
        Panel8.Location = New Point(28, 37)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(257, 178)
        Panel8.TabIndex = 8
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.student
        PictureBox7.Location = New Point(150, 84)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(92, 83)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 11
        PictureBox7.TabStop = False
        ' 
        ' lblTotals
        ' 
        lblTotals.AutoSize = True
        lblTotals.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotals.ForeColor = Color.White
        lblTotals.Location = New Point(13, 55)
        lblTotals.Name = "lblTotals"
        lblTotals.Size = New Size(37, 42)
        lblTotals.TabIndex = 10
        lblTotals.Text = "0"
        lblTotals.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(13, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 23)
        Label7.TabIndex = 9
        Label7.Text = "Total Students"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(PictureBox5)
        Panel7.Controls.Add(lblFemale)
        Panel7.Controls.Add(Label11)
        Panel7.ForeColor = Color.Black
        Panel7.Location = New Point(615, 37)
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
        Label11.Size = New Size(159, 23)
        Label11.TabIndex = 9
        Label11.Text = "Female Student"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(PictureBox4)
        Panel6.Controls.Add(lblMale)
        Panel6.Controls.Add(Label9)
        Panel6.ForeColor = Color.Black
        Panel6.Location = New Point(322, 37)
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
        Label9.Size = New Size(136, 23)
        Label9.TabIndex = 9
        Label9.Text = "Male Student"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(lblTotal)
        Panel3.Controls.Add(Label4)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(28, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(257, 178)
        Panel3.TabIndex = 8
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.student
        PictureBox2.Location = New Point(150, 84)
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
        Label4.Size = New Size(140, 23)
        Label4.TabIndex = 9
        Label4.Text = "Total Student"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        Controls.Add(PictureBox3)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panel9.ResumeLayout(False)
        panel9.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFemales As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panel9 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblMales As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblTotals As Label
    Friend WithEvents Label7 As Label
End Class

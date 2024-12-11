Imports System.Resources

Public Class Home
    Dim dash As New Dashboard()
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        Dim totals = dash.GetStudentTotals()

        lblTotal.Text = totals.total.ToString()
        lblMale.Text = totals.male.ToString()
        lblFemale.Text = totals.female.ToString()
    End Sub

    Private Sub addFormWindow(FormWindow)
        FormWindow.TopLevel = False
        FormWindow.FormBorderStyle = FormBorderStyle.None
        FormWindow.Dock = DockStyle.Fill
        panelHome.Controls.Add(FormWindow)
        panelHome.Tag = FormWindow
        FormWindow.BringToFront()
        FormWindow.Show()
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim adds As New StudentRecord
        addFormWindow(adds)
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim adds As New Courses
        addFormWindow(adds)
    End Sub

    Private Sub btnAddScore_Click(sender As Object, e As EventArgs) Handles btnAddScore.Click
        Dim adds As New AddScore
        addFormWindow(adds)
    End Sub

    Private Sub btnMarkSheet_Click(sender As Object, e As EventArgs) Handles btnMarkSheet.Click
        Dim adds As New MarkSheet
        addFormWindow(adds)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim log As DialogResult = MessageBox.Show("Do You Want To Logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If log = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim adds As New Dashboard
        addFormWindow(adds)
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Login.Close()
    End Sub
End Class

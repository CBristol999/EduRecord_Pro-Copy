Imports MySql.Data.MySqlClient
Public Class Dashboard
	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DBConnect()
		Dim dash As New Dashboard()
		Dim totals = dash.GetStudentTotals()

		lblTotals.Text = totals.total.ToString()
		lblMales.Text = totals.male.ToString()
		lblFemales.Text = totals.female.ToString()
	End Sub

	Public Function GetStudentTotals() As (total As Integer, male As Integer, female As Integer)
		Dim totals As Integer = Convert.ToInt32(totalStudent())
		Dim totalMaleStudent As Integer = Convert.ToInt32(totalMale())
		Dim totalFemaleStudent As Integer = Convert.ToInt32(totalFemale())

		Return (totals, totalMaleStudent, totalFemaleStudent)
	End Function


	'function to execute count query
	Function exeCount(ByVal query As String) As String
		Using command As New MySqlCommand(query, conn)
			If conn.State <> ConnectionState.Open Then
				conn.Open()
			End If
			Return command.ExecuteScalar().ToString()
		End Using
	End Function

	Function totalStudent() As String
		Return exeCount("SELECT COUNT(*) FROM students")
	End Function

	Function totalMale() As String
		Return exeCount("SELECT COUNT(*) FROM students WHERE gender = 'Male'")
	End Function

	Function totalFemale() As String
		Return exeCount("SELECT COUNT(*) FROM students WHERE gender = 'Female'")
	End Function
End Class
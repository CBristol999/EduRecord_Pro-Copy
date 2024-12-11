Imports System.Data.Common
Imports MySql.Data.MySqlClient

Module Connection
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Public conn As New MySqlConnection

    Public Sub DBConnect()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=bristol0219;database=studentdb"
    End Sub

    Public Sub GetDisplay(Sqlcommand As String, displayTable As DataGridView)
        adapter = New MySqlDataAdapter(Sqlcommand, conn)
        table = New DataTable()
        adapter.Fill(table)
        displayTable.DataSource = table
        displayTable.AllowUserToAddRows = False
        displayTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Public Sub PrintPage(e As Printing.PrintPageEventArgs, displayTable As DataGridView)
        Dim mRow As Integer = 0
        Dim newPage As Boolean = True

        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.Alignment = StringAlignment.Center

        Dim y As Integer = 100
        Dim x As Integer = 150
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow
        If newPage Then
            row = displayTable.Rows(mRow)
            x = 150
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)
                    e.Graphics.DrawString(displayTable.Columns(cell.ColumnIndex).HeaderText, displayTable.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        newPage = False
        Dim displayNow As Integer
        For displayNow = mRow To displayTable.RowCount - 1
            row = displayTable.Rows(displayNow)
            x = 150
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)
                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)
                    e.Graphics.DrawString(cell.FormattedValue.ToString(), displayTable.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        Next
    End Sub
End Module

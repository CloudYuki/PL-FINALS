Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=expense_tracker;User ID=root;Password=;Persist Security Info=True;Convert Zero DateTime=True")
    Dim adaptr As MySqlDataAdapter

    ' --- LOAD CATEGORIES INTO COMBOBOX ---
    Private Sub loadCategories()
        cboCategory.Items.Clear()
        cboCategory.Items.Add("Food")
        cboCategory.Items.Add("Transport")
        cboCategory.Items.Add("Bills")
        cboCategory.Items.Add("Shopping")
        cboCategory.Items.Add("Others")
        cboCategory.SelectedIndex = 0
    End Sub

    ' --- DISPLAY DATA IN GRID ---
    Private Sub displayData()
        Try
            conn.Open()
            Dim dt As New DataTable()
            adaptr = New MySqlDataAdapter(
                "SELECT id, title, amount, category, date_added, notes FROM tblexpense ORDER BY date_added DESC", conn)
            adaptr.Fill(dt)
            dvgExpenses.DataSource = dt
            conn.Close()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' --- CLEAR FIELDS ---
    Private Sub clearData()
        txtID.Clear()
        txtTitle.Clear()
        txtAmount.Clear()
        txtNotes.Clear()
        cboCategory.SelectedIndex = 0
        datePicker.Value = DateTime.Now
    End Sub

    ' --- VALIDATE INPUTS ---
    Private Function isValid() As Boolean
        If txtTitle.Text.Trim() = "" Then
            MessageBox.Show("Please enter a title.")
            Return False
        End If
        Dim amt As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amt) Then
            MessageBox.Show("Amount must be a valid number.")
            Return False
        End If
        If amt <= 0 Then
            MessageBox.Show("Amount must be greater than zero.")
            Return False
        End If
        Return True
    End Function

    ' --- FORM LOAD ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCategories()
        displayData()
    End Sub

    ' --- ADD RECORD ---
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        If Not isValid() Then Exit Sub
        Try
            Dim insertQuery As String =
                "INSERT INTO tblexpense (title, amount, category, date_added, notes) " &
                "VALUES ('" & txtTitle.Text.Trim() & "','" &
                Convert.ToDecimal(txtAmount.Text) & "','" &
                cboCategory.SelectedItem.ToString() & "','" &
                datePicker.Value.ToString("yyyy-MM-dd") & "','" &
                txtNotes.Text.Trim() & "')"
            conn.Open()
            Dim comm As New MySqlCommand(insertQuery, conn)
            If comm.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Expense added successfully!")
            Else
                MessageBox.Show("Failed to add expense.")
            End If
            conn.Close()
            displayData()
            clearData()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' --- UPDATE RECORD ---
    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        If txtID.Text = "" Then
            MessageBox.Show("Please select a record from the grid first.")
            Exit Sub
        End If
        If Not isValid() Then Exit Sub
        Try
            Dim updateQuery As String =
                "UPDATE tblexpense SET " &
                "title='" & txtTitle.Text.Trim() & "', " &
                "amount='" & Convert.ToDecimal(txtAmount.Text) & "', " &
                "category='" & cboCategory.SelectedItem.ToString() & "', " &
                "date_added='" & datePicker.Value.ToString("yyyy-MM-dd") & "', " &
                "notes='" & txtNotes.Text.Trim() & "' " &
                "WHERE id=" & txtID.Text
            conn.Open()
            Dim comm As New MySqlCommand(updateQuery, conn)
            If comm.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Expense updated successfully!")
            Else
                MessageBox.Show("Update failed.")
            End If
            conn.Close()
            displayData()
            clearData()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' --- DELETE RECORD ---
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        If txtID.Text = "" Then
            MessageBox.Show("Please select a record from the grid first.")
            Exit Sub
        End If
        Dim res As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this expense?",
            "Confirm Delete", MessageBoxButtons.YesNo)
        If res = DialogResult.Yes Then
            Try
                Dim deleteQuery As String =
                    "DELETE FROM tblexpense WHERE id=" & txtID.Text
                conn.Open()
                Dim comm As New MySqlCommand(deleteQuery, conn)
                If comm.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Expense deleted!")
                Else
                    MessageBox.Show("Delete failed.")
                End If
                conn.Close()
                displayData()
                clearData()
            Catch ex As Exception
                If conn.State = ConnectionState.Open Then conn.Close()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    ' --- CLICK ROW TO LOAD DATA ---
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgExpenses.CellClick
        Try
            Dim row As DataGridViewRow = dvgExpenses.CurrentRow
            If row IsNot Nothing AndAlso Not row.IsNewRow Then
                txtID.Text = row.Cells(0).Value.ToString()
                txtTitle.Text = row.Cells(1).Value.ToString()
                txtAmount.Text = row.Cells(2).Value.ToString()
                cboCategory.SelectedItem = row.Cells(3).Value.ToString()
                datePicker.Value = CDate(row.Cells(4).Value)
                txtNotes.Text = row.Cells(5).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting row: " & ex.Message)
        End Try
    End Sub

    ' --- UNUSED STUBS ---
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
    End Sub
    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
    End Sub
    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
    End Sub

End Class
Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not TableTableAdapter1.CreateAccount(TextBox1.Text, TextBox2.Text, "X", ComboBox2.SelectedText, ComboBox1.SelectedText, TextBox5.Text) = Nothing Then
            MsgBox("Account Created!", MsgBoxStyle.Information, "Success")
            TableTableAdapter1.Attend(TextBox1.Text, TextBox2.Text)
            Form1.Show()
            Me.Close()
        Else
            Me.Hide()
            Form4.Show()
            Threading.Thread.Sleep(1000)
            Form4.Close()
            Me.Show()
        End If
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Year' table. You can move, or remove it, as needed.
        Me.YearTableAdapter.Fill(Me.DataSet1.Year)
        'TODO: This line of code loads data into the 'DataSet1.Org' table. You can move, or remove it, as needed.
        Me.OrgTableAdapter.Fill(Me.DataSet1.Org)

    End Sub

End Class
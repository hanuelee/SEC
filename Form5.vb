Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingSource1.DataSource = TableTableAdapter.GetData()
        BindingSource1.ResetBindings(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not TableTableAdapter.Delete1(TextBox1.Text, TextBox1.Text) = Nothing Then
            MsgBox("User Deleted!", MsgBoxStyle.Information, "Deleted")
        End If
    End Sub
End Class
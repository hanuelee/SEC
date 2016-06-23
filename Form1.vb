Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = (";E?") Then
            TextBox1.Clear()
            Me.Hide()
            Form4.Show()
            Threading.Thread.Sleep(1000)
            Form4.Close()
            Me.Show()
        Else
            If Not TableTableAdapter1.Login(TextBox1.Text, TextBox1.Text) = Nothing Then
                TextBox1.Clear()
                Me.Hide()
                Form3.Show()
                Threading.Thread.Sleep(1000)
                Form3.Close()
                Me.Show()
            Else
                TextBox1.Clear()
                Me.Hide()
                Form7.Show()
                Threading.Thread.Sleep(1000)
                Form7.Close()
                Form2.Show()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

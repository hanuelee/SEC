Public Class Form1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim testCheck As Boolean
        Dim test2Check As Boolean

        testCheck = TextBox1.Text Like "*#########*"
        test2Check = TextBox1.Text Like "* *"



        If (testCheck Or test2Check) Then

            Dim literal As String = TextBox1.Text
            Dim substring As String = literal.Substring(1, 9)

            If Not TableTableAdapter1.Attend(substring, TextBox1.Text) = Nothing Then
                Me.Hide()
                Form3.Show()
                Threading.Thread.Sleep(1000)
                Form3.Close()
                Me.Show()
            Else
                Me.Hide()
                Form7.Show()
            End If

        Else
            Me.Hide()
                Form4.Show()
                Threading.Thread.Sleep(1000)
                Form4.Close()
                Me.Show()

        End If
        TextBox1.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

End Class

﻿Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter1.Fill(Me.DataSet1.Table)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingSource1.DataSource = TableTableAdapter.GetData()
        BindingSource1.ResetBindings(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not TableTableAdapter.Delete1(TextBox1.Text, TextBox1.Text) = Nothing Then
            MsgBox("User Deleted!", MsgBoxStyle.Information, "Deleted")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TableTableAdapter.Clear()
    End Sub

End Class
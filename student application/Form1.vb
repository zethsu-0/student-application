Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sizes
        Dim need As String
        Dim course
        Dim program
        Dim toPrint

        If RadioButton1.Checked Then
            sizes = "small" & vbCrLf '<-for new line
        End If
        If RadioButton2.Checked Then
            sizes = "Medium" & vbCrLf
        End If
        If RadioButton3.Checked Then
            sizes = "Large" & vbCrLf
        End If



        If CheckBox1.Checked Then
            need &= CheckBox1.Text & vbCrLf
        End If

        If CheckBox2.Checked Then
            need &= CheckBox2.Text & vbCrLf
        End If

        If CheckBox3.Checked Then
            need &= CheckBox3.Text & vbCrLf
        End If

        toPrint = "Your Information: " & vbCrLf & vbCrLf & "Student ID: " & TextBox1.Text & vbCrLf & "NAME: " & TextBox2.Text & vbCrLf & sizes & need & ListBox1.SelectedItem

        MessageBox.Show(toPrint)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        If ComboBox1.Text = "COBA" Then
            ListBox1.Items.Add("11")
            ListBox1.Items.Add("222")
            ListBox1.Items.Add("3333")
            ListBox1.Items.Add("44444")

        End If
        If ComboBox1.Text = "COENG" Then
            ListBox1.Items.Add("Civil Engineering")
            ListBox1.Items.Add("Computer Engineering")

        End If
        If ComboBox1.Text = "COE" Then
            ListBox1.Items.Add("9")
            ListBox1.Items.Add("10")
            ListBox1.Items.Add("11")
            ListBox1.Items.Add("12")
        End If
    End Sub


    Private Sub TextBox2KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub
End Class

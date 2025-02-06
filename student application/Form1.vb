Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sizes
        Dim need As String
        Dim course
        Dim program
        Dim toPrint

        If RadioButton1.Checked Then
            sizes = "small"
        End If
        If RadioButton2.Checked Then
            sizes = "Medium"
        End If
        If RadioButton3.Checked Then
            sizes = "Large"
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

        toPrint = TextBox1.Text & vbCrLf & TextBox2.Text & vbCrLf & sizes & vbCrLf & need & ListBox1.SelectedItem

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
            ListBox1.Items.Add("5")
            ListBox1.Items.Add("6")
            ListBox1.Items.Add("77")
            ListBox1.Items.Add("88")

        End If
        If ComboBox1.Text = "COE" Then
            ListBox1.Items.Add("9")
            ListBox1.Items.Add("10")
            ListBox1.Items.Add("11")
            ListBox1.Items.Add("12")
        End If
    End Sub


End Class

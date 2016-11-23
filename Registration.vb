Public Class Registration
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Confirm = TextBox3.Text
        My.Settings.Save()

        If TextBox1.Text = vbNullString And TextBox2.Text = vbNullString Or TextBox3.Text = vbNullString Or TextBox2.Text <> TextBox3.Text Then
            MsgBox("Could not create an acconut, try again!")
        Else
            MsgBox("User create successful")
            Me.Hide()
            Login.Show()
            Me.Close()
        End If


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        If Not TextBox3.Text = TextBox2.Text Then
            Label4.Text = "Password not match!"
        Else
            Label4.Text = ""
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Data.Show()
        Me.Close()
    End Sub
End Class

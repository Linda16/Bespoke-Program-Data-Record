Public Class Quotation

    Dim Invalid As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        'Declare variables as Double/Val()
        If TextBox1.Text = vbNullString Or TextBox6.Text = vbNullString Or
        Val(TextBox1.Text) <= 0 Or Val(TextBox6.Text) <= 0 Or Invalid = 1 Then

            MsgBox("Please provide correct information! The data entry MUST be positive number and try type again!")

        Else
            Label11.Text = Val(TextBox1.Text) * Val(TextBox6.Text) * 40
            Label12.Text = Val(TextBox7.Text) * 1
            Label13.Text = Val(TextBox8.Text) * 2
            Label14.Text = Val(TextBox9.Text) * 3
            Label15.Text = Val(TextBox10.Text) * 4
            Label16.Text = Val(Label11.Text) + Val(Label12.Text) + Val(Label13.Text) + Val(Label14.Text) + Val(Label15.Text)
            Label17.Text = Val(Label16.Text) * 0.2 + Val(Label16.Text)

            If Label17.Text >= 500 Then
                Label18.Text = Val(Label17.Text) - Val(Label17.Text) * 0.05
            Else
                Label18.Text = ""
            End If

            'Giving the order of sign of £ to display on the progress. 
            Label11.Text = "£" + Label11.Text
            Label12.Text = "£" + Label12.Text
            Label13.Text = "£" + Label13.Text
            Label14.Text = "£" + Label14.Text
            Label15.Text = "£" + Label15.Text
            Label16.Text = "£" + Label16.Text
            Label17.Text = "£" + Label17.Text
            Label18.Text = "£" + Label18.Text

        End If
    End Sub

    'Setting up the codes of all of variables to nothing when there is error.  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
    End Sub

    'Giving order when user click button Logout.
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Hide()
        Login.Show()
    End Sub

    'Givng order to show user name on the form.
    Private Sub Quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label25.Text = My.Settings.Username
    End Sub

    'Giving the help option to the user.
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Help_Form.Show()
    End Sub

    'Gving the order to allow user control/close the form.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
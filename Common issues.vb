Public Class Common_issues

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Help_Form.Show()
        Me.Close()
    End Sub
End Class
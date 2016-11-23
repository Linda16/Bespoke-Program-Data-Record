Public Class Help_Form

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Common_issues.Show()
        Me.Close()
    End Sub
End Class
Public Class Data

    Private Sub EmployeeRecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeRecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._MyDatabase_1DataSet1)

    End Sub

    Private Sub Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet1.EmployeeRecord' table. You can move, or remove it, as needed.
        Me.EmployeeRecordTableAdapter.Fill(Me._MyDatabase_1DataSet1.EmployeeRecord)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "" Or TextBox2.Text <> "") Then
            Try
                Me.EmployeeRecordTableAdapter.Insert(TextBox1.Text, TextBox2.Text)
                Me.EmployeeRecordTableAdapter.Fill(Me._MyDatabase_1DataSet1.EmployeeRecord)
                MsgBox("Employee Record Saved", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Please fill the employee records before you save", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub
End Class
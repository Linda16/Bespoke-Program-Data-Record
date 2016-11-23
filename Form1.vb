Public Class Form1

    Private Sub EmployeeRecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeRecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._MyDatabase_1DataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet1.EmployeeRecord' table. You can move, or remove it, as needed.
        Me.EmployeeRecordTableAdapter.Fill(Me._MyDatabase_1DataSet1.EmployeeRecord)

    End Sub
End Class
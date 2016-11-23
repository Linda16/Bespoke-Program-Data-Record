<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me._MyDatabase_1DataSet1 = New Bespoke_Program._MyDatabase_1DataSet1()
        Me.EmployeeRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeRecordTableAdapter = New Bespoke_Program._MyDatabase_1DataSet1TableAdapters.EmployeeRecordTableAdapter()
        Me.TableAdapterManager = New Bespoke_Program._MyDatabase_1DataSet1TableAdapters.TableAdapterManager()
        Me.EmployeeRecordDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me._MyDatabase_1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeRecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_MyDatabase_1DataSet1
        '
        Me._MyDatabase_1DataSet1.DataSetName = "_MyDatabase_1DataSet1"
        Me._MyDatabase_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeRecordBindingSource
        '
        Me.EmployeeRecordBindingSource.DataMember = "EmployeeRecord"
        Me.EmployeeRecordBindingSource.DataSource = Me._MyDatabase_1DataSet1
        '
        'EmployeeRecordTableAdapter
        '
        Me.EmployeeRecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeRecordTableAdapter = Me.EmployeeRecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = Bespoke_Program._MyDatabase_1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeRecordDataGridView
        '
        Me.EmployeeRecordDataGridView.AllowUserToAddRows = False
        Me.EmployeeRecordDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeRecordDataGridView.AutoGenerateColumns = False
        Me.EmployeeRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeRecordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.EmployeeRecordDataGridView.DataSource = Me.EmployeeRecordBindingSource
        Me.EmployeeRecordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeeRecordDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeRecordDataGridView.Name = "EmployeeRecordDataGridView"
        Me.EmployeeRecordDataGridView.ReadOnly = True
        Me.EmployeeRecordDataGridView.Size = New System.Drawing.Size(688, 516)
        Me.EmployeeRecordDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 550
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 516)
        Me.Controls.Add(Me.EmployeeRecordDataGridView)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me._MyDatabase_1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeRecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _MyDatabase_1DataSet1 As Bespoke_Program._MyDatabase_1DataSet1
    Friend WithEvents EmployeeRecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeRecordTableAdapter As Bespoke_Program._MyDatabase_1DataSet1TableAdapters.EmployeeRecordTableAdapter
    Friend WithEvents TableAdapterManager As Bespoke_Program._MyDatabase_1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents EmployeeRecordDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

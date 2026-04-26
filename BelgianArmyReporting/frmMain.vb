Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load master data first (so ValueMember matches)
        Me.GradesTableAdapter1.FillAll(Me.GradeDataSet1.Grades)
        Me.SoldiersTableAdapter1.FillAll(Me.SoldierDataSet1.Soldiers)

        ' Configure combo to show grade name but hold grade id
        cmbGrade.DataSource = Me.GradeDataSet1.Grades
        cmbGrade.DisplayMember = "Name"
        cmbGrade.ValueMember = "Id"

        cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList

        ' Bind SelectedValue to the current soldier's GradeId so changes update the DataSet automatically
        cmbGrade.DataBindings.Clear()
        cmbGrade.DataBindings.Add("SelectedValue", Me.SoldiersBindingSource, "GradeId", True, DataSourceUpdateMode.OnPropertyChanged)

        ' Bind Value to the current soldier's DateOfBirth so changes update the DataSet automatically
        dtpDateOfBirth.DataBindings.Clear()
        dtpDateOfBirth.DataBindings.Add("Value", Me.SoldiersBindingSource, "DateOfBirth", True, DataSourceUpdateMode.OnPropertyChanged)

    End Sub

    ' Example: persist changes to database (call when saving)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.SoldiersBindingSource.EndEdit()
        Me.SoldiersTableAdapter1.Update(Me.SoldierDataSet1.Soldiers)
    End Sub

    Private Sub dgvSoldiers_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSoldiers.DataBindingComplete
        ' Apply a GradeId lookup to the DataGridView so it shows grade names instead of IDs

        If dgvSoldiers.Columns.Contains("GradeIdDataGridViewTextBoxColumn") Then
            Dim gradeCol As DataGridViewTextBoxColumn = dgvSoldiers.Columns("GradeIdDataGridViewTextBoxColumn")

            dgvSoldiers.Columns.RemoveAt(gradeCol.Index)

            If Not dgvSoldiers.Columns.Contains("GradeComboColumn") Then
                ' Create a new combo column for grades
                Dim col As New DataGridViewComboBoxColumn With {
                    .DataPropertyName = "GradeId",   ' links to ds1
                    .DataSource = Me.GradeDataSet1.Grades,  ' lookup table
                    .ValueMember = "Id",
                    .DisplayMember = "Name",
                    .HeaderText = "Grade",
                    .Name = "GradeComboColumn"
                }

                dgvSoldiers.Columns.Insert(gradeCol.Index - 1, col)
            End If
        End If

    End Sub
End Class
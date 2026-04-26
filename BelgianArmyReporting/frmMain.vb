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

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim frm As New frmReport


        frm.ShowDialog(Me)
    End Sub

    Private Sub dgvSoldiers_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSoldiers.DataBindingComplete

        Dim targetColumnName As String = "GradeIdDataGridViewTextBoxColumn"

        If dgvSoldiers.Columns.Contains(targetColumnName) Then
            Dim colToReplace As DataGridViewColumn = dgvSoldiers.Columns(targetColumnName)
            dgvSoldiers.Columns.Remove(targetColumnName)

            Dim targetNewColumnName As String = "GradeDataGridViewTextBoxColumn"

            If Not dgvSoldiers.Columns.Contains(targetNewColumnName) Then
                Dim col As New DataGridViewComboBoxColumn With {
                .DataPropertyName = "gradeId",   ' links to ds1
                .DataSource = GradeDataSet1.Tables(0),     ' lookup table
                .ValueMember = "id",
                .DisplayMember = "name",
                .HeaderText = "Grade",
                .Name = targetNewColumnName
            }

                If (colToReplace.Index - 1 >= 0) Then
                    dgvSoldiers.Columns.Insert(colToReplace.Index - 1, col)
                Else
                    dgvSoldiers.Columns.Add(col)
                End If
            End If


        End If

    End Sub
End Class
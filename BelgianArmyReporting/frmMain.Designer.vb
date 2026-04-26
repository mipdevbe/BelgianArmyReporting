<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAddNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvSoldiers = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldiersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierDataSet1 = New BelgianArmyReporting.SoldierDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRegTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRegDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRegUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.cmbGrade = New System.Windows.Forms.ComboBox()
        Me.GradeDataSet1 = New BelgianArmyReporting.GradeDataSet()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SoldiersTableAdapter1 = New BelgianArmyReporting.SoldierDataSetTableAdapters.SoldiersTableAdapter()
        Me.GradesTableAdapter1 = New BelgianArmyReporting.GradeDataSetTableAdapters.GradesTableAdapter()
        Me.FillByGradeIdToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByGradeIdToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvSoldiers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoldiersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoldierDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GradeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByGradeIdToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddNew, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator3, Me.btnSave, Me.ToolStripSeparator4, Me.btnCancel, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1097, 71)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = False
        Me.btnAddNew.Image = Global.BelgianArmyReporting.My.Resources.Resources.new_butt
        Me.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(110, 65)
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 71)
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = False
        Me.btnEdit.Image = Global.BelgianArmyReporting.My.Resources.Resources.edit_butt
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(110, 65)
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 71)
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = False
        Me.btnDelete.Image = Global.BelgianArmyReporting.My.Resources.Resources.del_butt
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 65)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 71)
        '
        'btnSave
        '
        Me.btnSave.AutoSize = False
        Me.btnSave.Image = Global.BelgianArmyReporting.My.Resources.Resources.save_utt
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 65)
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 71)
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = False
        Me.btnCancel.Image = Global.BelgianArmyReporting.My.Resources.Resources.canecl_butt
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 65)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 71)
        '
        'dgvSoldiers
        '
        Me.dgvSoldiers.AutoGenerateColumns = False
        Me.dgvSoldiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSoldiers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.GradeIdDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.RegistrationNameDataGridViewTextBoxColumn, Me.RegistrationDateDataGridViewTextBoxColumn, Me.RegistrationTimeDataGridViewTextBoxColumn})
        Me.dgvSoldiers.DataSource = Me.SoldiersBindingSource
        Me.dgvSoldiers.Location = New System.Drawing.Point(4, 414)
        Me.dgvSoldiers.Name = "dgvSoldiers"
        Me.dgvSoldiers.RowHeadersWidth = 62
        Me.dgvSoldiers.RowTemplate.Height = 28
        Me.dgvSoldiers.Size = New System.Drawing.Size(1081, 256)
        Me.dgvSoldiers.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 150
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 150
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.Width = 150
        '
        'GradeIdDataGridViewTextBoxColumn
        '
        Me.GradeIdDataGridViewTextBoxColumn.DataPropertyName = "GradeId"
        Me.GradeIdDataGridViewTextBoxColumn.HeaderText = "GradeId"
        Me.GradeIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GradeIdDataGridViewTextBoxColumn.Name = "GradeIdDataGridViewTextBoxColumn"
        Me.GradeIdDataGridViewTextBoxColumn.Width = 150
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        Me.MobileDataGridViewTextBoxColumn.Width = 150
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 150
        '
        'RegistrationNameDataGridViewTextBoxColumn
        '
        Me.RegistrationNameDataGridViewTextBoxColumn.DataPropertyName = "RegistrationName"
        Me.RegistrationNameDataGridViewTextBoxColumn.HeaderText = "RegistrationName"
        Me.RegistrationNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RegistrationNameDataGridViewTextBoxColumn.Name = "RegistrationNameDataGridViewTextBoxColumn"
        Me.RegistrationNameDataGridViewTextBoxColumn.Width = 150
        '
        'RegistrationDateDataGridViewTextBoxColumn
        '
        Me.RegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate"
        Me.RegistrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate"
        Me.RegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RegistrationDateDataGridViewTextBoxColumn.Name = "RegistrationDateDataGridViewTextBoxColumn"
        Me.RegistrationDateDataGridViewTextBoxColumn.Width = 150
        '
        'RegistrationTimeDataGridViewTextBoxColumn
        '
        Me.RegistrationTimeDataGridViewTextBoxColumn.DataPropertyName = "RegistrationTime"
        Me.RegistrationTimeDataGridViewTextBoxColumn.HeaderText = "RegistrationTime"
        Me.RegistrationTimeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RegistrationTimeDataGridViewTextBoxColumn.Name = "RegistrationTimeDataGridViewTextBoxColumn"
        Me.RegistrationTimeDataGridViewTextBoxColumn.Width = 150
        '
        'SoldiersBindingSource
        '
        Me.SoldiersBindingSource.DataMember = "Soldiers"
        Me.SoldiersBindingSource.DataSource = Me.SoldierDataSet1
        '
        'SoldierDataSet1
        '
        Me.SoldierDataSet1.DataSetName = "SoldierDataSet"
        Me.SoldierDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtRegTime)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtRegDate)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtRegUser)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 676)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 50)
        Me.Panel1.TabIndex = 3
        '
        'txtRegTime
        '
        Me.txtRegTime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "RegistrationTime", True))
        Me.txtRegTime.Location = New System.Drawing.Point(955, 16)
        Me.txtRegTime.Name = "txtRegTime"
        Me.txtRegTime.ReadOnly = True
        Me.txtRegTime.Size = New System.Drawing.Size(130, 26)
        Me.txtRegTime.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(891, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Time:"
        '
        'txtRegDate
        '
        Me.txtRegDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "RegistrationDate", True))
        Me.txtRegDate.Location = New System.Drawing.Point(503, 16)
        Me.txtRegDate.Name = "txtRegDate"
        Me.txtRegDate.ReadOnly = True
        Me.txtRegDate.Size = New System.Drawing.Size(130, 26)
        Me.txtRegDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(439, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date:"
        '
        'txtRegUser
        '
        Me.txtRegUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "RegistrationName", True))
        Me.txtRegUser.Location = New System.Drawing.Point(76, 13)
        Me.txtRegUser.Name = "txtRegUser"
        Me.txtRegUser.ReadOnly = True
        Me.txtRegUser.Size = New System.Drawing.Size(130, 26)
        Me.txtRegUser.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Grade:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDateOfBirth)
        Me.GroupBox1.Controls.Add(Me.cmbGrade)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtMobile)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1081, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(202, 170)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(399, 26)
        Me.dtpDateOfBirth.TabIndex = 5
        '
        'cmbGrade
        '
        Me.cmbGrade.DataSource = Me.GradeDataSet1
        Me.cmbGrade.DisplayMember = "Grades.Name"
        Me.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrade.FormattingEnabled = True
        Me.cmbGrade.Location = New System.Drawing.Point(202, 136)
        Me.cmbGrade.Name = "cmbGrade"
        Me.cmbGrade.Size = New System.Drawing.Size(395, 28)
        Me.cmbGrade.TabIndex = 4
        Me.cmbGrade.ValueMember = "Grades.Id"
        '
        'GradeDataSet1
        '
        Me.GradeDataSet1.DataSetName = "GradeDataSet"
        Me.GradeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(202, 272)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(476, 26)
        Me.txtAddress.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(202, 239)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(397, 26)
        Me.txtEmail.TabIndex = 3
        '
        'txtMobile
        '
        Me.txtMobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "Mobile", True))
        Me.txtMobile.Location = New System.Drawing.Point(202, 202)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(397, 26)
        Me.txtMobile.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "LastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(202, 101)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(397, 26)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(202, 69)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(397, 26)
        Me.txtFirstName.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoldiersBindingSource, "Id", True))
        Me.txtId.Location = New System.Drawing.Point(202, 33)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(397, 26)
        Me.txtId.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(82, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Address:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Email:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Mobile:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Date Of Birth:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SoldiersTableAdapter1
        '
        Me.SoldiersTableAdapter1.ClearBeforeFill = True
        '
        'GradesTableAdapter1
        '
        Me.GradesTableAdapter1.ClearBeforeFill = True
        '
        'FillByGradeIdToolStrip
        '
        Me.FillByGradeIdToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillByGradeIdToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByGradeIdToolStripButton})
        Me.FillByGradeIdToolStrip.Location = New System.Drawing.Point(0, 71)
        Me.FillByGradeIdToolStrip.Name = "FillByGradeIdToolStrip"
        Me.FillByGradeIdToolStrip.Size = New System.Drawing.Size(1097, 34)
        Me.FillByGradeIdToolStrip.TabIndex = 4
        Me.FillByGradeIdToolStrip.Text = "FillByGradeIdToolStrip"
        '
        'FillByGradeIdToolStripButton
        '
        Me.FillByGradeIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByGradeIdToolStripButton.Name = "FillByGradeIdToolStripButton"
        Me.FillByGradeIdToolStripButton.Size = New System.Drawing.Size(119, 29)
        Me.FillByGradeIdToolStripButton.Text = "FillByGradeId"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 726)
        Me.Controls.Add(Me.FillByGradeIdToolStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvSoldiers)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Belgian Army Reporting"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvSoldiers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoldiersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoldierDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GradeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByGradeIdToolStrip.ResumeLayout(False)
        Me.FillByGradeIdToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAddNew As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents dgvSoldiers As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRegTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRegDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRegUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents cmbGrade As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents SoldierDataSet1 As SoldierDataSet
    Friend WithEvents GradeDataSet1 As GradeDataSet
    Friend WithEvents SoldiersBindingSource As BindingSource
    Friend WithEvents SoldiersTableAdapter1 As SoldierDataSetTableAdapters.SoldiersTableAdapter
    Friend WithEvents GradesTableAdapter1 As GradeDataSetTableAdapters.GradesTableAdapter
    Friend WithEvents FillByGradeIdToolStrip As ToolStrip
    Friend WithEvents FillByGradeIdToolStripButton As ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrationTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

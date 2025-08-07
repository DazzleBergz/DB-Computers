<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaction
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSpecs7 = New System.Windows.Forms.Label()
        Me.cboPrice = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.dgwProductList = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lstOrder = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxProdControl = New System.Windows.Forms.GroupBox()
        Me.lblEmployeeNum = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.btnUpdateProd = New System.Windows.Forms.Button()
        Me.btnRemoveProd = New System.Windows.Forms.Button()
        Me.btnAddProd = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgwProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.gbxProdControl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(102, 594)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(389, 43)
        Me.btnPayment.TabIndex = 68
        Me.btnPayment.Text = "Proceed Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(294, 461)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(274, 43)
        Me.btnRemove.TabIndex = 67
        Me.btnRemove.Text = "Remove Item"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(3, 461)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(274, 43)
        Me.btnClearAll.TabIndex = 66
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Red
        Me.lblSubTotal.Location = New System.Drawing.Point(326, 32)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(224, 31)
        Me.lblSubTotal.TabIndex = 17
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(326, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sub-Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItem
        '
        Me.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(173, 32)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(143, 31)
        Me.lblItem.TabIndex = 16
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total Item"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.lblQuantity)
        Me.Panel6.Controls.Add(Me.btnMinus)
        Me.Panel6.Controls.Add(Me.btnPlus)
        Me.Panel6.Controls.Add(Me.lblSubTotal)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.lblItem)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(3, 510)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(565, 78)
        Me.Panel6.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 26)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Search"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(127, 314)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(307, 26)
        Me.txtSearch.TabIndex = 58
        '
        'lblSpecs7
        '
        Me.lblSpecs7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecs7.ForeColor = System.Drawing.Color.White
        Me.lblSpecs7.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblSpecs7.Location = New System.Drawing.Point(556, 314)
        Me.lblSpecs7.Name = "lblSpecs7"
        Me.lblSpecs7.Size = New System.Drawing.Size(68, 28)
        Me.lblSpecs7.TabIndex = 14
        Me.lblSpecs7.Text = "Price:"
        Me.lblSpecs7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboPrice
        '
        Me.cboPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrice.FormattingEnabled = True
        Me.cboPrice.Items.AddRange(New Object() {"None", "1000 - 10000", "10000 - 30000", "30000 - 50000", "50000 - 70000", "70000 - 100000"})
        Me.cboPrice.Location = New System.Drawing.Point(630, 314)
        Me.cboPrice.Name = "cboPrice"
        Me.cboPrice.Size = New System.Drawing.Size(189, 28)
        Me.cboPrice.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Controls.Add(Me.dgwProductList)
        Me.Panel2.Location = New System.Drawing.Point(10, 348)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 459)
        Me.Panel2.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Select Item Below:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point(219, 402)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(389, 42)
        Me.btnSelect.TabIndex = 15
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'dgwProductList
        '
        Me.dgwProductList.AllowUserToAddRows = False
        Me.dgwProductList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgwProductList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgwProductList.BackgroundColor = System.Drawing.Color.Gray
        Me.dgwProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgwProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgwProductList.ColumnHeadersHeight = 29
        Me.dgwProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwProductList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwProductList.Location = New System.Drawing.Point(7, 24)
        Me.dgwProductList.Name = "dgwProductList"
        Me.dgwProductList.ReadOnly = True
        Me.dgwProductList.RowHeadersVisible = False
        Me.dgwProductList.RowHeadersWidth = 51
        Me.dgwProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwProductList.Size = New System.Drawing.Size(792, 373)
        Me.dgwProductList.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lstOrder)
        Me.Panel4.Controls.Add(Me.btnRemove)
        Me.Panel4.Controls.Add(Me.btnClearAll)
        Me.Panel4.Controls.Add(Me.btnPayment)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(825, 155)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(573, 652)
        Me.Panel4.TabIndex = 60
        '
        'lstOrder
        '
        Me.lstOrder.BackColor = System.Drawing.Color.White
        Me.lstOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrder.FullRowSelect = True
        Me.lstOrder.HideSelection = False
        Me.lstOrder.Location = New System.Drawing.Point(3, 3)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(565, 452)
        Me.lstOrder.TabIndex = 47
        Me.lstOrder.UseCompatibleStateImageBehavior = False
        Me.lstOrder.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantity"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sub-Price"
        Me.ColumnHeader4.Width = 100
        '
        'gbxProdControl
        '
        Me.gbxProdControl.Controls.Add(Me.btnAddCategory)
        Me.gbxProdControl.Controls.Add(Me.btnUpdateProd)
        Me.gbxProdControl.Controls.Add(Me.btnRemoveProd)
        Me.gbxProdControl.Controls.Add(Me.btnAddProd)
        Me.gbxProdControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProdControl.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.gbxProdControl.Location = New System.Drawing.Point(378, 87)
        Me.gbxProdControl.Name = "gbxProdControl"
        Me.gbxProdControl.Size = New System.Drawing.Size(441, 213)
        Me.gbxProdControl.TabIndex = 71
        Me.gbxProdControl.TabStop = False
        Me.gbxProdControl.Text = "Product Control"
        '
        'lblEmployeeNum
        '
        Me.lblEmployeeNum.AutoSize = True
        Me.lblEmployeeNum.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblEmployeeNum.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblEmployeeNum.Location = New System.Drawing.Point(122, 20)
        Me.lblEmployeeNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeNum.Name = "lblEmployeeNum"
        Me.lblEmployeeNum.Size = New System.Drawing.Size(28, 23)
        Me.lblEmployeeNum.TabIndex = 161
        Me.lblEmployeeNum.Text = "..."
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(18, 23)
        Me.lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(100, 20)
        Me.lbl.TabIndex = 160
        Me.lbl.Text = "Employee: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(21, 107)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(49, 23)
        Me.lblDay.TabIndex = 164
        Me.lblDay.Text = "Day"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMonth.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblMonth.Location = New System.Drawing.Point(20, 146)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(84, 27)
        Me.lblMonth.TabIndex = 163
        Me.lblMonth.Text = "Month"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(148, 109)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(51, 20)
        Me.lblTime.TabIndex = 162
        Me.lblTime.Text = "Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 111)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose product catergory"
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(16, 49)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(323, 28)
        Me.cboCategory.TabIndex = 165
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblEmpName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblEmpName.Location = New System.Drawing.Point(175, 62)
        Me.lblEmpName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(28, 23)
        Me.lblEmpName.TabIndex = 166
        Me.lblEmpName.Text = "..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 20)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Employee Name: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Impact", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(558, 7)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(264, 37)
        Me.Label15.TabIndex = 167
        Me.Label15.Text = "DB COMPUTER PARTS"
        '
        'lblQuantity
        '
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblQuantity.Location = New System.Drawing.Point(69, 32)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(37, 29)
        Me.lblQuantity.TabIndex = 55
        Me.lblQuantity.Text = "0"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddCategory
        '
        Me.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCategory.ForeColor = System.Drawing.Color.Black
        Me.btnAddCategory.Image = Global.DBComputers_POS.My.Resources.Resources.Category
        Me.btnAddCategory.Location = New System.Drawing.Point(14, 119)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(202, 83)
        Me.btnAddCategory.TabIndex = 13
        Me.btnAddCategory.Text = "Manage Category"
        Me.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddCategory.UseVisualStyleBackColor = False
        '
        'btnUpdateProd
        '
        Me.btnUpdateProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateProd.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateProd.Image = Global.DBComputers_POS.My.Resources.Resources.update
        Me.btnUpdateProd.Location = New System.Drawing.Point(222, 121)
        Me.btnUpdateProd.Name = "btnUpdateProd"
        Me.btnUpdateProd.Size = New System.Drawing.Size(202, 81)
        Me.btnUpdateProd.TabIndex = 12
        Me.btnUpdateProd.Text = "Update Product"
        Me.btnUpdateProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdateProd.UseVisualStyleBackColor = False
        '
        'btnRemoveProd
        '
        Me.btnRemoveProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemoveProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemoveProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProd.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveProd.Image = Global.DBComputers_POS.My.Resources.Resources.remove
        Me.btnRemoveProd.Location = New System.Drawing.Point(222, 26)
        Me.btnRemoveProd.Name = "btnRemoveProd"
        Me.btnRemoveProd.Size = New System.Drawing.Size(202, 82)
        Me.btnRemoveProd.TabIndex = 11
        Me.btnRemoveProd.Text = "Remove Product"
        Me.btnRemoveProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRemoveProd.UseVisualStyleBackColor = False
        '
        'btnAddProd
        '
        Me.btnAddProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProd.ForeColor = System.Drawing.Color.Black
        Me.btnAddProd.Image = Global.DBComputers_POS.My.Resources.Resources.Add
        Me.btnAddProd.Location = New System.Drawing.Point(14, 27)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(202, 81)
        Me.btnAddProd.TabIndex = 10
        Me.btnAddProd.Text = "Add Product"
        Me.btnAddProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddProd.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = Global.DBComputers_POS.My.Resources.Resources.sign_out
        Me.btnLogOut.Location = New System.Drawing.Point(1238, 59)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(143, 70)
        Me.btnLogOut.TabIndex = 61
        Me.btnLogOut.Text = "LOGOUT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Image = Global.DBComputers_POS.My.Resources.Resources.print_icon
        Me.btnReport.Location = New System.Drawing.Point(882, 54)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(136, 76)
        Me.btnReport.TabIndex = 70
        Me.btnReport.Text = "Print Report"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.SystemColors.Info
        Me.btnGoBack.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Image = Global.DBComputers_POS.My.Resources.Resources.home
        Me.btnGoBack.Location = New System.Drawing.Point(1078, 59)
        Me.btnGoBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(143, 70)
        Me.btnGoBack.TabIndex = 62
        Me.btnGoBack.Text = "HOME"
        Me.btnGoBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGoBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGoBack.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinus.Image = Global.DBComputers_POS.My.Resources.Resources.minus
        Me.btnMinus.Location = New System.Drawing.Point(25, 32)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(38, 29)
        Me.btnMinus.TabIndex = 54
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlus.Image = Global.DBComputers_POS.My.Resources.Resources.plus
        Me.btnPlus.Location = New System.Drawing.Point(112, 32)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(38, 29)
        Me.btnPlus.TabIndex = 53
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1404, 811)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblEmployeeNum)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.gbxProdControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSpecs7)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.cboPrice)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB Computer Parts"
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgwProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.gbxProdControl.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPayment As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSpecs7 As Label
    Friend WithEvents cboPrice As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgwProductList As DataGridView
    Friend WithEvents btnUpdateProd As Button
    Friend WithEvents btnAddProd As Button
    Friend WithEvents btnRemoveProd As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstOrder As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents gbxProdControl As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmployeeNum As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblEmpName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents lblQuantity As Label
End Class

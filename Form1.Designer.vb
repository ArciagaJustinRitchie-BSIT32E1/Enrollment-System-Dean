<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SchedID = New System.Windows.Forms.Label()
        Me.SecID = New System.Windows.Forms.Label()
        Me.CourseID = New System.Windows.Forms.Label()
        Me.SYID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSections = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSY = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClassSection = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1292, 31)
        Me.Panel1.TabIndex = 0
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Firebrick
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(1266, 0)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(26, 31)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "X"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.SchedID)
        Me.Panel2.Controls.Add(Me.SecID)
        Me.Panel2.Controls.Add(Me.CourseID)
        Me.Panel2.Controls.Add(Me.SYID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 89)
        Me.Panel2.TabIndex = 1
        '
        'SchedID
        '
        Me.SchedID.AutoSize = True
        Me.SchedID.Location = New System.Drawing.Point(716, 47)
        Me.SchedID.Name = "SchedID"
        Me.SchedID.Size = New System.Drawing.Size(49, 13)
        Me.SchedID.TabIndex = 4
        Me.SchedID.Text = "SchedID"
        '
        'SecID
        '
        Me.SecID.AutoSize = True
        Me.SecID.Location = New System.Drawing.Point(497, 47)
        Me.SecID.Name = "SecID"
        Me.SecID.Size = New System.Drawing.Size(37, 13)
        Me.SecID.TabIndex = 3
        Me.SecID.Text = "SecID"
        '
        'CourseID
        '
        Me.CourseID.AutoSize = True
        Me.CourseID.Location = New System.Drawing.Point(634, 47)
        Me.CourseID.Name = "CourseID"
        Me.CourseID.Size = New System.Drawing.Size(39, 13)
        Me.CourseID.TabIndex = 2
        Me.CourseID.Text = "course"
        '
        'SYID
        '
        Me.SYID.AutoSize = True
        Me.SYID.Location = New System.Drawing.Point(588, 47)
        Me.SYID.Name = "SYID"
        Me.SYID.Size = New System.Drawing.Size(25, 13)
        Me.SYID.TabIndex = 1
        Me.SYID.Text = "syid"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Sections"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSections)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 579)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject Information"
        '
        'dgvSections
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSections.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSections.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvSections.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSections.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSections.DoubleBuffered = True
        Me.dgvSections.EnableHeadersVisualStyles = False
        Me.dgvSections.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvSections.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvSections.Location = New System.Drawing.Point(3, 16)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSections.Size = New System.Drawing.Size(830, 560)
        Me.dgvSections.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboSemester)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboSY)
        Me.GroupBox2.Controls.Add(Me.cboCourse)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtClassSection)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 579)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Section"
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Empty
        Me.txtSearch.HintText = ""
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtSearch.LineIdleColor = System.Drawing.Color.Black
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(10, 21)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(405, 40)
        Me.txtSearch.TabIndex = 25
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Search:"
        '
        'cboSemester
        '
        Me.cboSemester.BackColor = System.Drawing.Color.Black
        Me.cboSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSemester.ForeColor = System.Drawing.Color.White
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(10, 394)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(405, 33)
        Me.cboSemester.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Semester"
        '
        'cboSY
        '
        Me.cboSY.BackColor = System.Drawing.Color.Black
        Me.cboSY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSY.ForeColor = System.Drawing.Color.White
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.Location = New System.Drawing.Point(12, 300)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(405, 33)
        Me.cboSY.TabIndex = 20
        '
        'cboCourse
        '
        Me.cboCourse.BackColor = System.Drawing.Color.Black
        Me.cboCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.Color.White
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(10, 204)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(405, 33)
        Me.cboCourse.TabIndex = 19
        '
        'btnCancel
        '
        Me.btnCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.BorderRadius = 0
        Me.btnCancel.ButtonText = "Cancel"
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancel.Iconimage = CType(resources.GetObject("btnCancel.Iconimage"), System.Drawing.Image)
        Me.btnCancel.Iconimage_right = Nothing
        Me.btnCancel.Iconimage_right_Selected = Nothing
        Me.btnCancel.Iconimage_Selected = Nothing
        Me.btnCancel.IconMarginLeft = 0
        Me.btnCancel.IconMarginRight = 0
        Me.btnCancel.IconRightVisible = True
        Me.btnCancel.IconRightZoom = 0R
        Me.btnCancel.IconVisible = True
        Me.btnCancel.IconZoom = 90.0R
        Me.btnCancel.IsTab = False
        Me.btnCancel.Location = New System.Drawing.Point(313, 504)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Normalcolor = System.Drawing.Color.IndianRed
        Me.btnCancel.OnHovercolor = System.Drawing.Color.Firebrick
        Me.btnCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancel.selected = False
        Me.btnCancel.Size = New System.Drawing.Size(107, 48)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Textcolor = System.Drawing.Color.Black
        Me.btnCancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEdit
        '
        Me.btnEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.BorderRadius = 0
        Me.btnEdit.ButtonText = "Edit"
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DisabledColor = System.Drawing.Color.Gray
        Me.btnEdit.Enabled = False
        Me.btnEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEdit.Iconimage = CType(resources.GetObject("btnEdit.Iconimage"), System.Drawing.Image)
        Me.btnEdit.Iconimage_right = Nothing
        Me.btnEdit.Iconimage_right_Selected = Nothing
        Me.btnEdit.Iconimage_Selected = Nothing
        Me.btnEdit.IconMarginLeft = 0
        Me.btnEdit.IconMarginRight = 0
        Me.btnEdit.IconRightVisible = True
        Me.btnEdit.IconRightZoom = 0R
        Me.btnEdit.IconVisible = True
        Me.btnEdit.IconZoom = 90.0R
        Me.btnEdit.IsTab = False
        Me.btnEdit.Location = New System.Drawing.Point(213, 504)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEdit.selected = False
        Me.btnEdit.Size = New System.Drawing.Size(90, 48)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Textcolor = System.Drawing.Color.Black
        Me.btnEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 0
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSave.Enabled = False
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = CType(resources.GetObject("btnSave.Iconimage"), System.Drawing.Image)
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 0
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 90.0R
        Me.btnSave.IsTab = False
        Me.btnSave.Location = New System.Drawing.Point(113, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(90, 48)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Textcolor = System.Drawing.Color.Black
        Me.btnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNew
        '
        Me.btnNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.BorderRadius = 0
        Me.btnNew.ButtonText = "New"
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.DisabledColor = System.Drawing.Color.Gray
        Me.btnNew.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNew.Iconimage = CType(resources.GetObject("btnNew.Iconimage"), System.Drawing.Image)
        Me.btnNew.Iconimage_right = Nothing
        Me.btnNew.Iconimage_right_Selected = Nothing
        Me.btnNew.Iconimage_Selected = Nothing
        Me.btnNew.IconMarginLeft = 0
        Me.btnNew.IconMarginRight = 0
        Me.btnNew.IconRightVisible = True
        Me.btnNew.IconRightZoom = 0R
        Me.btnNew.IconVisible = True
        Me.btnNew.IconZoom = 90.0R
        Me.btnNew.IsTab = False
        Me.btnNew.Location = New System.Drawing.Point(10, 504)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnNew.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNew.selected = False
        Me.btnNew.Size = New System.Drawing.Size(90, 48)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Textcolor = System.Drawing.Color.Black
        Me.btnNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "School Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course"
        '
        'txtClassSection
        '
        Me.txtClassSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClassSection.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtClassSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtClassSection.HintForeColor = System.Drawing.Color.Empty
        Me.txtClassSection.HintText = ""
        Me.txtClassSection.isPassword = False
        Me.txtClassSection.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtClassSection.LineIdleColor = System.Drawing.Color.Black
        Me.txtClassSection.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtClassSection.LineThickness = 3
        Me.txtClassSection.Location = New System.Drawing.Point(10, 102)
        Me.txtClassSection.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClassSection.Name = "txtClassSection"
        Me.txtClassSection.Size = New System.Drawing.Size(405, 40)
        Me.txtClassSection.TabIndex = 1
        Me.txtClassSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Section Name"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkGreen
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(26, 31)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "<-"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1292, 715)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvSections As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtClassSection As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SYID As Label
    Friend WithEvents cboSY As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents CourseID As Label
    Friend WithEvents cboSemester As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SecID As Label
    Friend WithEvents SchedID As Label
    Friend WithEvents btnBack As Button
End Class

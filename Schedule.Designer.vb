<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Schedule))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTeacherID = New System.Windows.Forms.Label()
        Me.lblsubjectcode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSbjCode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUnits = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCourse = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSubject = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtScheduleID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.cboTeacher = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lollable = New System.Windows.Forms.Label()
        Me.txtSection = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSchedule = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1374, 31)
        Me.Panel1.TabIndex = 2
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Firebrick
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(1348, 1)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(26, 31)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "X"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblTeacherID)
        Me.Panel2.Controls.Add(Me.lblsubjectcode)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-23, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1397, 68)
        Me.Panel2.TabIndex = 3
        '
        'lblTeacherID
        '
        Me.lblTeacherID.AutoSize = True
        Me.lblTeacherID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherID.Location = New System.Drawing.Point(622, 32)
        Me.lblTeacherID.Name = "lblTeacherID"
        Me.lblTeacherID.Size = New System.Drawing.Size(84, 20)
        Me.lblTeacherID.TabIndex = 29
        Me.lblTeacherID.Text = "TeacherID"
        Me.lblTeacherID.Visible = False
        '
        'lblsubjectcode
        '
        Me.lblsubjectcode.AutoSize = True
        Me.lblsubjectcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectcode.Location = New System.Drawing.Point(515, 32)
        Me.lblsubjectcode.Name = "lblsubjectcode"
        Me.lblsubjectcode.Size = New System.Drawing.Size(75, 20)
        Me.lblsubjectcode.TabIndex = 28
        Me.lblsubjectcode.Text = "Subjectid"
        Me.lblsubjectcode.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtSbjCode)
        Me.GroupBox2.Controls.Add(Me.txtUnits)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCourse)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboSubject)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtScheduleID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboTime)
        Me.GroupBox2.Controls.Add(Me.cboTeacher)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboDay)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lollable)
        Me.GroupBox2.Controls.Add(Me.txtSection)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 559)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(343, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Code"
        '
        'txtSbjCode
        '
        Me.txtSbjCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSbjCode.Enabled = False
        Me.txtSbjCode.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSbjCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSbjCode.HintForeColor = System.Drawing.Color.Empty
        Me.txtSbjCode.HintText = ""
        Me.txtSbjCode.isPassword = False
        Me.txtSbjCode.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtSbjCode.LineIdleColor = System.Drawing.Color.Black
        Me.txtSbjCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtSbjCode.LineThickness = 3
        Me.txtSbjCode.Location = New System.Drawing.Point(347, 177)
        Me.txtSbjCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSbjCode.Name = "txtSbjCode"
        Me.txtSbjCode.Size = New System.Drawing.Size(73, 40)
        Me.txtSbjCode.TabIndex = 32
        Me.txtSbjCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUnits
        '
        Me.txtUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnits.Enabled = False
        Me.txtUnits.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUnits.HintForeColor = System.Drawing.Color.Empty
        Me.txtUnits.HintText = ""
        Me.txtUnits.isPassword = False
        Me.txtUnits.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtUnits.LineIdleColor = System.Drawing.Color.Black
        Me.txtUnits.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtUnits.LineThickness = 3
        Me.txtUnits.Location = New System.Drawing.Point(213, 91)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(207, 40)
        Me.txtUnits.TabIndex = 31
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(214, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Units"
        '
        'txtCourse
        '
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.Enabled = False
        Me.txtCourse.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCourse.HintForeColor = System.Drawing.Color.Empty
        Me.txtCourse.HintText = ""
        Me.txtCourse.isPassword = False
        Me.txtCourse.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtCourse.LineIdleColor = System.Drawing.Color.Black
        Me.txtCourse.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtCourse.LineThickness = 3
        Me.txtCourse.Location = New System.Drawing.Point(8, 21)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(195, 40)
        Me.txtCourse.TabIndex = 29
        Me.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Course"
        '
        'cboSubject
        '
        Me.cboSubject.BackColor = System.Drawing.Color.Black
        Me.cboSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubject.ForeColor = System.Drawing.Color.White
        Me.cboSubject.FormattingEnabled = True
        Me.cboSubject.Location = New System.Drawing.Point(10, 184)
        Me.cboSubject.Name = "cboSubject"
        Me.cboSubject.Size = New System.Drawing.Size(329, 33)
        Me.cboSubject.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Subject"
        '
        'txtScheduleID
        '
        Me.txtScheduleID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScheduleID.Enabled = False
        Me.txtScheduleID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtScheduleID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtScheduleID.HintForeColor = System.Drawing.Color.Empty
        Me.txtScheduleID.HintText = ""
        Me.txtScheduleID.isPassword = False
        Me.txtScheduleID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtScheduleID.LineIdleColor = System.Drawing.Color.Black
        Me.txtScheduleID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtScheduleID.LineThickness = 3
        Me.txtScheduleID.Location = New System.Drawing.Point(8, 91)
        Me.txtScheduleID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtScheduleID.Name = "txtScheduleID"
        Me.txtScheduleID.Size = New System.Drawing.Size(195, 40)
        Me.txtScheduleID.TabIndex = 25
        Me.txtScheduleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Schedule ID"
        '
        'cboTime
        '
        Me.cboTime.BackColor = System.Drawing.Color.Black
        Me.cboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTime.ForeColor = System.Drawing.Color.White
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Items.AddRange(New Object() {"7:00-8:30", "8:30-10:00", "10:00-11:30", "1:00-2:30", "2:30-4:00", "4:00-5:30"})
        Me.cboTime.Location = New System.Drawing.Point(10, 345)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(410, 33)
        Me.cboTime.TabIndex = 23
        '
        'cboTeacher
        '
        Me.cboTeacher.BackColor = System.Drawing.Color.Black
        Me.cboTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTeacher.ForeColor = System.Drawing.Color.White
        Me.cboTeacher.FormattingEnabled = True
        Me.cboTeacher.Location = New System.Drawing.Point(10, 423)
        Me.cboTeacher.Name = "cboTeacher"
        Me.cboTeacher.Size = New System.Drawing.Size(410, 33)
        Me.cboTeacher.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Teacher"
        '
        'cboDay
        '
        Me.cboDay.BackColor = System.Drawing.Color.Black
        Me.cboDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDay.ForeColor = System.Drawing.Color.White
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cboDay.Location = New System.Drawing.Point(10, 263)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(410, 33)
        Me.cboDay.TabIndex = 20
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
        Me.btnSave.Visible = False
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
        Me.btnNew.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Day"
        '
        'lollable
        '
        Me.lollable.AutoSize = True
        Me.lollable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lollable.Location = New System.Drawing.Point(13, 381)
        Me.lollable.Name = "lollable"
        Me.lollable.Size = New System.Drawing.Size(43, 20)
        Me.lollable.TabIndex = 2
        Me.lollable.Text = "Time"
        '
        'txtSection
        '
        Me.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSection.Enabled = False
        Me.txtSection.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSection.HintForeColor = System.Drawing.Color.Empty
        Me.txtSection.HintText = ""
        Me.txtSection.isPassword = False
        Me.txtSection.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtSection.LineIdleColor = System.Drawing.Color.Black
        Me.txtSection.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtSection.LineThickness = 3
        Me.txtSection.Location = New System.Drawing.Point(213, 21)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(207, 40)
        Me.txtSection.TabIndex = 1
        Me.txtSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Section"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSchedule)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(916, 559)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'dgvSchedule
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSchedule.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSchedule.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSchedule.DoubleBuffered = True
        Me.dgvSchedule.EnableHeadersVisualStyles = False
        Me.dgvSchedule.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvSchedule.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvSchedule.Location = New System.Drawing.Point(3, 16)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSchedule.Size = New System.Drawing.Size(910, 540)
        Me.dgvSchedule.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkGreen
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(0, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(26, 31)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "<-"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1374, 676)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Schedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnQuit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label4 As Label
    Friend WithEvents lollable As Label
    Friend WithEvents txtSection As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents lblsubjectcode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtScheduleID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSchedule As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents cboSubject As ComboBox
    Friend WithEvents txtCourse As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUnits As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSbjCode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblTeacherID As Label
    Friend WithEvents cboTeacher As ComboBox
    Friend WithEvents btnBack As Button
End Class

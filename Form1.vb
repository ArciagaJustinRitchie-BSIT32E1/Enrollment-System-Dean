Imports System.Data.OleDb
Imports System.Drawing.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Public Class Form1
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn()
        setDatagrid()
        Call listofsections()
        Call loadsy()
        Call loadCourse()
        Call Sem()
        Call getSchedID()
    End Sub

    Private Sub Sem()
        cboSemester.Items.Clear()

        sql = "Select Semester from tblSection"
        cmd = New OleDbCommand(sql, cn)
        Dim teach = cmd.ExecuteReader()
        While teach.Read
            If teach(0).ToString = "'" Then Continue While
            cboSemester.Items.Add(teach(0).ToString)
        End While


    End Sub
    Private Sub setDatagrid()
        dgvSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvSections.AutoSizeRowsMode = DataGridViewAutoSizeRowMode.AllCells
        dgvSections.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub listofsections()
        sql = "Select * from qrySections"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvSections.DataSource = dt
        btnEdit.Enabled = False
    End Sub

    Private Sub loadsy()
        cboSY.Items.Clear()

        sql = "Select SchoolYear from tblSY"
        cmd = New OleDbCommand(sql, cn)
        Dim sy = cmd.ExecuteReader()
        While sy.Read
            If sy(0).ToString = "'" Then Continue While
            cboSY.Items.Add(sy(0).ToString)
        End While

    End Sub

    Private Sub loadCourse()
        cboCourse.Items.Clear()

        sql = "Select Course from tblCourse"
        cmd = New OleDbCommand(sql, cn)
        Dim course = cmd.ExecuteReader()
        While course.Read
            If course(0).ToString = "'" Then Continue While
            cboCourse.Items.Add(course(0).ToString)
        End While
    End Sub


    Private Sub cboSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSY.SelectedIndexChanged
        sql = "Select SchoolYear from qrySections where SchoolYear='" & cboSY.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSY.DataSource = dt
        cboSY.DisplayMember = "SchoolYear"
        getSyID()
    End Sub


    Private Sub getSyID()
        sql = "Select SYID from tblsy where SchoolYear='" & cboSY.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            SYID.Text = dr(0)
        End If
    End Sub

    Private Sub getCourseID()
        sql = "Select CourseID from tblCourse where Course='" & cboCourse.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            CourseID.Text = dr(0)
        End If
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnSave.Enabled = True
        btnNew.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        txtClassSection.Text = ""
        cboCourse.Text = ""
        cboSY.Text = ""
        cboSemester.Text = ""
        SecID.Text = ""
        SYID.Text = ""
        CourseID.Text = ""
        SchedID.Text = ""
    End Sub

    Private Sub checkSections()
        sql = "Select [Section] from [tblSection] where [Section]='" & txtClassSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("The class section already exists", MsgBoxStyle.Exclamation)
        Else
            Call saveSection()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call checkSections()
    End Sub

    Private Sub saveSection()

        sql = "Insert into tblSection([SectionID],[Section],[CourseID],[SYID],[Semester],[ScheduleID])values(@SectionID,@Section,@CourseID,@SYID,@Semester,@ScheduleID)"
        Dim potato = New OleDbCommand(sql, cn)

        Dim id = generate_id("tblSection", "SectionID", "Sec")
        Dim schedid = generate_id("tblSection", "ScheduleID", "Sched")
        With potato
            .Parameters.AddWithValue("@SectionID", id)
            .Parameters.AddWithValue("@Section", txtClassSection.Text)
            .Parameters.AddWithValue("@CourseId", CourseID.Text)
            .Parameters.AddWithValue("@SYID", SYID.Text)
            .Parameters.AddWithValue("@Semester", cboSemester.Text)
            .Parameters.AddWithValue("@ScheduleID", schedid)
            .ExecuteNonQuery()
        End With
        MsgBox("New SectionSuccessfully Saved", MsgBoxStyle.Information)
        Call listofsections()
    End Sub



    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        sql = "Select CourseID from tblCourse where Course='" & cboCourse.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        CourseID.Text = "CourseID"
        getCourseID()
    End Sub



    Private Sub dgvSections_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSections.CellClick

        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = dgvSections.Rows(e.RowIndex)
            txtClassSection.Text = selectedRow.Cells("Section").Value.ToString()
            cboCourse.Text = selectedRow.Cells("Course").Value.ToString()
            cboSY.Text = selectedRow.Cells("SchoolYear").Value.ToString()
            cboSemester.Text = selectedRow.Cells("Semester").Value.ToString()
            SecID.Text = selectedRow.Cells("SectionID").Value.ToString()

            Call getSchedID()
            btnEdit.Enabled = True
        End If
    End Sub


    Private Sub getSchedID()
        sql = "Select ScheduleID from tblSection where SectionID='" & SecID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            SchedID.Text = dr(0)
        End If
    End Sub


    Private Sub cboSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSemester.SelectedIndexChanged
        sql = "Select Semester from qrySections where Semester='" & cboSemester.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSemester.DataSource = dt
        cboSemester.DisplayMember = "Semester"
        getSyID()
    End Sub

    Private Function generate_id(table, id, idletter)
        Dim getter = QueryData("Select " & id & " From " & table & " Order By " & id)
        Dim gen_id = 0
        While getter.Read()
            If gen_id = RemoveNonNumeric(getter(0).ToString) - 1000 Then
                gen_id += 1
            End If
        End While
        gen_id += 1000
        Return idletter & gen_id
    End Function

    Function RemoveNonNumeric(Input As String) As String
        Dim regex As New Regex("[^0-9]")
        Dim numericString As String = regex.Replace(Input, "")
        numericString = numericString.TrimStart("0"c)
        Return numericString
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim result As MsgBoxResult = MsgBox("Do you want to edit this record?", MsgBoxStyle.YesNo)

        If result = MsgBoxResult.Yes Then
            Dim Section As String = txtClassSection.Text
            Dim Course As String = CourseID.Text
            Dim SY As String = SYID.Text
            Dim Semester As String = cboSemester.Text
            Dim ScheduleID As String = SchedID.Text
            Dim SectionID As String = SecID.Text

            Dim sql As String = "UPDATE tblSection SET [Section] = @Section, [CourseID] = @Course, [SYID] = @SYID, [Semester] = @Semester, [ScheduleID] = @ScheduleID Where [SectionID] = @SectionID"
            Using cmd As New OleDbCommand(sql, cn)

                cmd.Parameters.AddWithValue("@Section", Section)
                cmd.Parameters.AddWithValue("@Course", Course)
                cmd.Parameters.AddWithValue("@SYID", SY)
                cmd.Parameters.AddWithValue("@Semester", Semester)
                cmd.Parameters.AddWithValue("@ScheduleID", ScheduleID)
                cmd.Parameters.AddWithValue("@SectionID", SectionID)

                Call conn()
                cmd.ExecuteNonQuery()
                Call listofsections()
            End Using

            MsgBox("Record updated successfully.", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DeanSelect.Show()
        Me.Hide()
    End Sub
End Class

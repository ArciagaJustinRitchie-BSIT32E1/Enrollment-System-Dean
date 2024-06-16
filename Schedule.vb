Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Schedule
    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn()
        setDatagrid()
        Call listofschedule()
        Call Teachers()
        Call Subject()
    End Sub
    Private Sub Subject()
        cboSubject.Items.Clear()

        sql = "Select Subject from tblSubject"
        cmd = New OleDbCommand(sql, cn)
        Dim subj = cmd.ExecuteReader()
        While subj.Read
            If subj(0).ToString = "'" Then Continue While
            cboSubject.Items.Add(subj(0).ToString)
        End While
    End Sub
    Private Sub Teachers()
        cboTeacher.Items.Clear()

        sql = "Select TeacherName from tblTeacher"
        cmd = New OleDbCommand(sql, cn)
        Dim teach = cmd.ExecuteReader()
        While teach.Read
            If teach(0).ToString = "'" Then Continue While
            cboTeacher.Items.Add(teach(0).ToString)
        End While


    End Sub

    Private Sub setDatagrid()
        dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowMode.AllCells
        dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub listofschedule()
        sql = "Select * from qrySched"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvSchedule.DataSource = dt
    End Sub

    Private Sub dgvSchedule_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellClick

        If e.RowIndex >= 0 Then
            btnEdit.Enabled = True
            btnNew.Enabled = False
            btnSave.Enabled = False
            Dim selectedRow As DataGridViewRow = dgvSchedule.Rows(e.RowIndex)
            txtScheduleID.Text = selectedRow.Cells("ScheduleID").Value.ToString()
            txtCourse.Text = selectedRow.Cells("Course").Value.ToString()
            txtSection.Text = selectedRow.Cells("Section").Value.ToString()
            txtUnits.Text = selectedRow.Cells("Units").Value.ToString()
            txtSbjCode.Text = selectedRow.Cells("SubjectCode").Value.ToString()
            cboSubject.Text = selectedRow.Cells("Subject").Value.ToString()
            cboTeacher.Text = selectedRow.Cells("TeacherName").Value.ToString()
            cboDay.Text = selectedRow.Cells("Day").Value.ToString()
            cboTime.Text = selectedRow.Cells("Time").Value.ToString()
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
        txtCourse.Text = ""
        txtSbjCode.Text = ""
        txtScheduleID.Text = ""
        txtSection.Text = ""
        txtUnits.Text = ""
        cboSubject.Text = ""
        cboTeacher.Text = ""
        cboDay.Text = ""
        cboTime.Text = ""
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim result As MsgBoxResult = MsgBox("Do you want to edit this record?", MsgBoxStyle.YesNo)

        If result = MsgBoxResult.Yes Then
            Dim SubjectID As String = lblsubjectcode.Text
            Dim Day As String = cboDay.Text
            Dim Time As String = cboTime.Text
            Dim TeacherID As String = lblTeacherID.Text
            Dim sql As String = "UPDATE tblSchedule SET [SubjectID] = @SubjectID, [Day] = @Day, [Time] = @Time, [TeacherID] = @TeacherID  Where [ScheduleID] = @ScheduleID"
            Using cmd As New OleDbCommand(sql, cn)

                cmd.Parameters.AddWithValue("@SubjectID", SubjectID)
                cmd.Parameters.AddWithValue("@Day", Day)
                cmd.Parameters.AddWithValue("@Time", Time)
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID)
                cmd.Parameters.AddWithValue("@ScheduleID", txtScheduleID.Text)


                Call conn()
                cmd.ExecuteNonQuery()
                listofschedule()
            End Using

            MsgBox("Record updated successfully.", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtCourse.Text = "" Or txtSbjCode.Text = "" Or txtSbjCode.Text = "" Or txtScheduleID.Text = "" Or txtSection.Text = "" Or txtUnits.Text = "" Or cboSubject.Text = "" Or cboTeacher.Text = "" Or cboDay.Text = "" Or cboTime.Text = "" Then
            MsgBox("Please fill all the information", MsgBoxStyle.Exclamation)
        Else
            checkDate()
        End If


    End Sub

    Private Sub checkDate()
        sql = "Select [Day] from [qrySched] where [Day]='" & cboDay.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Call checktime()
        Else
            Call updateSched()
        End If
    End Sub


    Private Sub checktime()
        sql = "Select [Time] from [qrySched] where [Time]='" & cboTime.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("The Time for that day is already booke", MsgBoxStyle.Exclamation)
        Else
            Call updateSched()
        End If
    End Sub
    Private Sub updateSched()
        sql = "Insert into qrySched(ScheduleID,Course,Section,Day,Time,SubjectCode,Subject,Units,TeacherName)values(@ScheduleID,@Course,@Section,@Day,@Time,@SubjectCode,@Subject,@Units,@TeacherName)"
        Dim save = New OleDbCommand(sql, cn)

    End Sub

    Private Sub cboTeacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeacher.SelectedIndexChanged
        sql = "Select TeacherID from tblTeacher where TeacherName='" & cboTeacher.Text & "'"
        cmd = New OleDbCommand(sql, cn)

        Dim cring = cmd.ExecuteReader()
        cring.Read()

        lblTeacherID.Text = cring(0).ToString

    End Sub

    Private Sub cboSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubject.SelectedIndexChanged
        sql = "Select SubjectID from tblSubject where Subject='" & cboSubject.Text & "'"
        cmd = New OleDbCommand(sql, cn)

        Dim cring = cmd.ExecuteReader()
        cring.Read()

        lblsubjectcode.Text = cring(0).ToString

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DeanSelect.Show()
        Me.Hide()
    End Sub
End Class
Imports System.Data.SqlTypes
Public Class DeanSelect
    Private Sub frmRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeDate.Text = Date.Now
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
            Login.txtUsername.Text = ""
            Login.txtPassword.Text = ""
        End If
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedulee.Click
        Schedule.Show()
        Me.Hide()
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
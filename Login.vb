Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "" And txtUsername.Text = "" Then
            MsgBox("Enter Account Name and Account Password", MsgBoxStyle.Exclamation)
        ElseIf txtPassword.Text = "" Then
            MsgBox("Enter Password", MsgBoxStyle.Exclamation)
        ElseIf txtUsername.Text = "" Then
            MsgBox("Enter Username", MsgBoxStyle.Exclamation)
        Else
            Call CheckAccount(txtUsername.Text, txtPassword.Text)
        End If
    End Sub
    Sub CheckAccount(username, password)
        'sql = "SELECT [AccountName], [AccountPassword], [AccountStatus], [Attempts] FROM tblPersonnelAccount WHERE [AccountName] = '" & username & "'"
        'cmd = New OleDbCommand(sql, cn)
        'dr = cmd.ExecuteReader
        'If Not dr.Read() Then
        '    MsgBox("Account Does not exist.", MsgBoxStyle.Exclamation)
        '    Return
        'End If
        DeanSelect.Show()
        Me.Hide()
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
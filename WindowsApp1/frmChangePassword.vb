Public Class frmChangePassword
    Private Sub btnAnnuller_Click(sender As Object, e As EventArgs) Handles btnAnnuller.Click
        Me.Close()
    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' txtOldLogin
        txtOldLogin.Focus()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim lstText() = {txtNewLogin, txtNewPassword, txtOldLogin, txtOldPassword}
        Dim isOk As Boolean = True
        For i = 0 To lstText.Length - 1
            If lstText(i).Text.Trim.Length = 0 Then
                lstText(i).BackColor = Color.LightPink
                isOk = False
                'Exit For
            Else
                lstText(i).BackColor = System.Drawing.SystemColors.Control

            End If
        Next

        '  MsgBox(currentUser.userToString)

        If isOk Then
            If txtOldLogin.Text = currentUser.login.Replace("@_@", "'") And txtOldPassword.Text = currentUser.password.Replace("@_@", "'") Then
                datasource.updateLogin(currentUser, New user(txtNewLogin.Text, txtNewPassword.Text))
                currentUser = New user(txtNewLogin.Text, txtNewPassword.Text)
                For i = 0 To lstText.Length - 1
                    lstText(i).Text = ""
                Next
                MsgBox("Les changements ont réussi")
                Me.Close()
            Else
                MsgBox("(Nom d'utilisateur ou mot de passe) ancien est incorrect")
            End If
        Else
            MsgBox("Veuillez d'abord remplir tous les champs")
        End If




    End Sub
End Class
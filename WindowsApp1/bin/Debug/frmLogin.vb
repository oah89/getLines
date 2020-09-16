Imports System.IO
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            Dim FileReader As StreamReader
            FileReader = New StreamReader(CurDir() & "\config.dll")
            Dim saveData As String = FileReader.ReadToEnd()
            FileReader.Close()
            mySqliteConnexion = New SQLite.SQLiteConnection("Data Source=" & saveData & ";Version=3;")
            '  MsgBox(saveData)
            datasource = New SqliteDataAcces
            currentUser = New user()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' MsgBox(CurDir())

        '  mySqliteConnexion = New SQLite.SQLiteConnection("Data Source=demoDb.sqlite;Version=3;")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click


        ' Dim currentUser As user

        If txtPassword.Text = "" Or txtLogin.Text = "" Then
            txtError.Text = "Login ou mot non saisie...! "
            txtError.ForeColor = Color.Gray
        Else
            currentUser = datasource.getLogin(txtLogin.Text.Replace("'", "@_@"), txtPassword.Text.Replace("'", "@_@"))
            If currentUser IsNot Nothing Then
                currentUser = New user(txtLogin.Text.Replace("'", "@_@"), txtPassword.Text.Replace("'", "@_@"))
                frmMain.Show()

                Me.Close()
            Else
                txtError.Text = "Login ou mot de passe incorrect...! "
                txtError.ForeColor = Color.Pink
            End If
        End If

    End Sub
End Class
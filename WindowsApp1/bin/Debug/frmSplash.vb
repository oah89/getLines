Public Class frmSplash
    Dim cont As Integer = 0

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If cont > ProgressBar1.Maximum Then
            Timer1.Stop()
            frmLogin.Show()
            Me.Close()
        Else
            ProgressBar1.Value = cont
            cont = cont + 1
        End If

    End Sub

    Private Sub Copyright_Click(sender As Object, e As EventArgs) Handles Copyright.Click, Label3.Click

    End Sub
End Class
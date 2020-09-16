Public Class frmMain

    Dim currentForm As Form
    Dim isMaimazed As Boolean = False
    Sub callForm(ByVal panel As Form)
        PanelContent.Controls.Clear()
        panel.TopLevel = False
        PanelContent.Controls.Add(panel)
        resizeFormContent(panel)
        panel.Show()

    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        If MessageBox.Show("Are you shur?", "Confirmation", MessageBoxButtons.YesNo) = vbYes Then
            Try
                Me.Close()
                End
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentForm = frmPerson
        callForm(currentForm)

        'Dim bm = New Bitmap(btnFermer.BackgroundImage, New Size(btnFermer.Width, btnFermer.Height))
        'btnFermer.BackgroundImage = bm
    End Sub


    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelTop.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub PanelContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelContent.Paint

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.Size = New Size(1000, 600) Then
            '''''Me.Size = MaximumSize
            '''''frmPerson.Size = MaximumSize
            'Me.Size = New Size(1000, 600)
            ' frmPerson.WindowState = 2
            ''Me.WindowState = 2
            ''frmPerson.WindowState = 2
            isMaimazed = True
            Me.Size = New Size(Screen.PrimaryScreen.Bounds.Size.Width, CType(Screen.PrimaryScreen.Bounds.Size.Height - Screen.PrimaryScreen.Bounds.Size.Height * 0.05, Integer))
            currentForm.Size = New Size(Screen.PrimaryScreen.Bounds.Size.Width, CType(Screen.PrimaryScreen.Bounds.Size.Height - Screen.PrimaryScreen.Bounds.Size.Height * 0.15, Integer))
            ' Me.StartPosition = FormStartPosition.CenterScreen
            ' frmPerson.Size = New Size(1200, 700)
        Else
            isMaimazed = False
            '  Me.WindowState '4 FormWindowState.Normal
            'Me.Size = New Point(1000, 600)
            'frmPerson.Size = New Point(1000, 530)
            currentForm.Size = New Point(1000, 530)
            Me.Size = New Size(1000, 600)


        End If


        'If Me.WindowState = MaximumSize Then
        '    Me.Size = New Size(1000, 600)
        '    frmPerson.Size = New Point(1000, 530)
        '    '  Me.WindowState = vbMinimizedFocus
        '    'Me.Size = New Size(1000, 600)
        '    ' frmPerson.WindowState = 2
        'Else
        '    Me.WindowState = FormWindowState.Minimized
        '    '  Me.WindowState '4 FormWindowState.Normal
        '    'Me.Size = New Size(1000, 600)

        '    'frmPerson.Size = New Point(1000, 530)
        'End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub


    Private Sub btnMouseHover(sender As Object, e As EventArgs) Handles btnPerson.Click, btnGroup.Click, btnChef.Click
        Dim p As Point = CType(sender, Control).Location
        p.Y = 57
        lblSelectedBtn.Location = p

    End Sub


    'Private Sub btnMouseHover2(sender As Object, e As EventArgs) Handles btnPassword.MouseHover, btnAbout.MouseHover
    '    Dim p As Point = CType(sender, Control).Location
    '    p.Y = 57
    '    lblSelectedBtn.Location = p

    'End Sub
    Private Sub btnPerson_Click(sender As Object, e As EventArgs) Handles btnPerson.Click

        currentForm = frmPerson
        callForm(frmPerson)
    End Sub

    Private Sub btnGroup_Click(sender As Object, e As EventArgs) Handles btnGroup.Click
        currentForm = frmGroup
        callForm(frmGroup)
    End Sub

    Private Sub resizeFormContent(frm As Form)
        Try
            If isMaimazed Then

                frm.Size = New Size(Screen.PrimaryScreen.Bounds.Size.Width, CType(Screen.PrimaryScreen.Bounds.Size.Height - Screen.PrimaryScreen.Bounds.Size.Height * 0.15, Integer))
            Else
                frm.Size = New Point(1000, 530)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnChef_Click(sender As Object, e As EventArgs) Handles btnChef.Click
        currentForm = frmChef
        callForm(frmChef)
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            Dim myScreen As Screen = Screen.FromControl(Me)
            Dim area As Rectangle = myScreen.WorkingArea

            Me.Top = (area.Height - Me.Height) / 2
            Me.Left = (area.Width - Me.Width) / 2
        Catch ex As Exception

        End Try
    End Sub

    'Const WM_NCHITTEST As Integer = &H84
    'Const HTCLIENT As Integer = &H1
    'Const HTCAPTION As Integer = &H2

    'Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
    '    Select Case m.Msg
    '        Case WM_NCHITTEST
    '            MyBase.WndProc(m)
    '            If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
    '        Case Else
    '            MyBase.WndProc(m)
    '    End Select
    'End Sub
End Class
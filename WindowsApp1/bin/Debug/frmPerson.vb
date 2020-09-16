Imports System.Data.SQLite

Public Class frmPerson
    Dim currentId As Integer
    Dim searchBy As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Not String.IsNullOrWhiteSpace(PathToLocalData) Then
        '    Using connection As New SqliteConnection(PathToLocalData)
        '        connection.Open()
        '    End Using
        'End If
        Try
            searchBy = "cin"
            populateList()
            SetDgColumnModeFill(dgList)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub populateList(Optional condi As String = "")
        dgList.Rows.Clear()
        Dim p = datasource.getListPerson(condi)
        For i = 0 To p.Count - 1
            dgList.Rows.Add()
            dgList.Rows(dgList.Rows.Count - 1).Cells(0).Value = p(i).idPerson
            dgList.Rows(dgList.Rows.Count - 1).Cells(1).Value = i + 1
            dgList.Rows(dgList.Rows.Count - 1).Cells(2).Value = p(i).nameFamily
            dgList.Rows(dgList.Rows.Count - 1).Cells(3).Value = p(i).nameFirst
            dgList.Rows(dgList.Rows.Count - 1).Cells(4).Value = p(i).cin.Replace(" ", "").ToUpper
            dgList.Rows(dgList.Rows.Count - 1).Cells(5).Value = p(i).adresse
            dgList.Rows(dgList.Rows.Count - 1).Cells(6).Value = "Editter"
            dgList.Rows(dgList.Rows.Count - 1).Cells(7).Value = "Supprimer"
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim p = datasource.checkPersonExist(txtCin.Text.ToLower)
        If txtCin.Text.Trim = "" Or txtFamilyName.Text.Trim = "" Or txtFirtName.Text.Trim = "" Then
            MessageBox.Show("les champ (C.I.N,nom,prenom) est obligatoire ", "Attention ...!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Est vous sur ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = vbYes Then
                If btnAdd.Text = "Ajouter" Then
                    If p Is Nothing Then
                        datasource.addPerson(New Person(txtCin.Text, txtFirtName.Text, txtFamilyName.Text, txtAdresse.Text))
                        populateList()
                        viderTextBox()
                    Else
                        MessageBox.Show("Le N° de C.I.N (" & txtCin.Text & ") déja exist pour :" & vbNewLine & p.personToString, "Attention ...!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    If txtCin.Text.Replace(" ", "").ToUpper <> dgList.Rows(dgList.CurrentRow.Index).Cells(4).Value.Replace(" ", "").ToUpper And p IsNot Nothing Then

                        MessageBox.Show("Le N° de C.I.N (" & txtCin.Text & ") déja exist pour :" & vbNewLine & p.personToString, "Attention ...!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        datasource.updatePerson(New Person(dgList.Rows(dgList.CurrentRow.Index).Cells(0).Value, txtCin.Text, txtFirtName.Text, txtFamilyName.Text, txtAdresse.Text))
                        populateList()
                        viderTextBox()

                    End If

                End If

            End If
        End If










    End Sub

    Private Sub viderTextBox()
        txtCin.Text = ""
        txtFirtName.Text = ""
        txtFamilyName.Text = ""
        txtAdresse.Text = ""
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    '    Dim p = datasource.checkPersonExist(txtCin.Text.ToLower)
    '    If p Is Nothing Then
    '        MsgBox("no exist")
    '    Else
    '        MsgBox(p.personToString)
    '    End If
    'End Sub

    Private Sub cin_CheckedChanged(sender As Object, e As EventArgs) Handles cin.CheckedChanged, nameFirst.CheckedChanged, adresse.CheckedChanged, nameFamily.CheckedChanged

        If CType(sender, RadioButton).Checked Then
            searchBy = sender.name
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        populateList(" where " & searchBy & " like '%" & txtSearch.Text.Replace("'", "@_@") & "%'")
    End Sub

    Private Sub dgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgList.CellContentClick

    End Sub

    Private Sub dgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgList.CellClick
        If e.ColumnIndex = dgList.Columns("colEdit").Index And e.RowIndex >= 0 Then
            'dgList.Rows(dgList.Rows.Count - 1).Cells(0).Value = p(i).idPerson
            'dgList.Rows(dgList.Rows.Count - 1).Cells(1).Value = i + 1
            currentId = dgList.Rows(dgList.CurrentRow.Index).Cells(0).Value
            txtFamilyName.Text = dgList.Rows(dgList.CurrentRow.Index).Cells(2).Value
            txtFirtName.Text = dgList.Rows(dgList.CurrentRow.Index).Cells(3).Value
            txtCin.Text = dgList.Rows(dgList.CurrentRow.Index).Cells(4).Value
            txtAdresse.Text = dgList.Rows(dgList.CurrentRow.Index).Cells(5).Value
            btnAdd.Text = "Modifier"

        ElseIf e.ColumnIndex = dgList.Columns("colDelete").Index And e.RowIndex >= 0 Then
            If MessageBox.Show("Voulez-vous vraiment supprimer (" & dgList.Rows(dgList.CurrentRow.Index).Cells(2).Value & " " & dgList.Rows(dgList.CurrentRow.Index).Cells(3).Value & ")", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = vbYes Then
                datasource.deletePerson(dgList.Rows(dgList.CurrentRow.Index).Cells(0).Value)
                populateList("")
            End If


        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        viderTextBox()
        btnAdd.Text = "Ajouter"
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class

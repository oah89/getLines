Public Class frmSelectPerson

    Dim searchBy As String = "cin"

    Private Sub dgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgList.CellContentClick

    End Sub

    Private Sub dgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgList.CellClick



        If e.ColumnIndex = dgList.Columns("btnSelect").Index And e.RowIndex >= 0 Then
            'If MessageBox.Show("Voulez-vous vraiment supprimer (" & dgList.Rows(dgList.CurrentRow.Index).Cells(2).Value & " " & dgList.Rows(dgList.CurrentRow.Index).Cells(3).Value & ")", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = vbYes Then
            '    datasource.deletePerson(dgList.Rows(dgList.CurrentRow.Index).Cells(0).Value)
            '    populateList("")
            'End If
            If MessageBox.Show("Êtes-vous sûr de vouloir ajouter (" & dgList.Rows(dgList.CurrentRow.Index).Cells(2).Value & " " & dgList.Rows(dgList.CurrentRow.Index).Cells(3).Value & ") à la ligne (" & frmGroup.selectedGroup.numGroup & ") en tant " & frmGroup.selectedStatut, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = vbYes Then


                datasource.addPersonToGroup(frmGroup.selectedGroup.idGroup, dgList.Rows(dgList.CurrentRow.Index).Cells(0).Value, frmGroup.selectedStatut, txtNumBureau.Value)
                frmGroup.populateList(frmGroup.selectedGroup.idGroup)
                populateList("")
            End If

        End If


        ' where(substr(myDate, 7, 4) || '-' || substr(myDate, 4, 2) || '-' || substr(myDate, 1, 2)) between '2013-07-01' and '2013-07-24'




    End Sub



    Private Sub populateList(condi As String)
        dgList.Rows.Clear()
        Dim p = datasource.getListPersonNotInWork(condi)
        For i = 0 To p.Count - 1
            dgList.Rows.Add()
            dgList.Rows(dgList.Rows.Count - 1).Cells(0).Value = p(i).idPerson
            dgList.Rows(dgList.Rows.Count - 1).Cells(1).Value = i + 1
            dgList.Rows(dgList.Rows.Count - 1).Cells(2).Value = p(i).nameFamily
            dgList.Rows(dgList.Rows.Count - 1).Cells(3).Value = p(i).nameFirst
            dgList.Rows(dgList.Rows.Count - 1).Cells(4).Value = p(i).cin
            dgList.Rows(dgList.Rows.Count - 1).Cells(5).Value = "selectioné"
        Next
    End Sub

    Private Sub frmSelectPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            searchBy = "cin"
            populateList("")
            SetDgColumnModeFill2(dgList, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        populateList(" and " & searchBy & " like '%" & txtSearch.Text.Replace("'", "@_@") & "%'")
    End Sub
    Private Sub cin_CheckedChanged(sender As Object, e As EventArgs) Handles cin.CheckedChanged, nameFirst.CheckedChanged, nameFamily.CheckedChanged

        If CType(sender, RadioButton).Checked Then
            searchBy = sender.name
        End If

    End Sub
End Class
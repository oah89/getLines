Public Class frmChef
    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDgColumnModeFill2(dgListeChef, 1)
        SetDgColumnModeFill2(dgListEmployer, 0)
        Dim p = datasource.getListChef()
        For i = 0 To p.Count - 1
            dgListeChef.Rows.Add()
            dgListeChef.Rows(dgListeChef.Rows.Count - 1).Cells(0).Value = p(i).idPerson
            dgListeChef.Rows(dgListeChef.Rows.Count - 1).Cells(1).Value = p(i).cin
            dgListeChef.Rows(dgListeChef.Rows.Count - 1).Cells(2).Value = p(i).nameFamily
            dgListeChef.Rows(dgListeChef.Rows.Count - 1).Cells(3).Value = p(i).nameFirst
            dgListeChef.Rows(dgListeChef.Rows.Count - 1).Cells(4).Value = p(i).idGroup
            '    MsgBox(p(i).)
            '  dgListeChef.Rows(dgListeChef.Rows.Count - 1).Cells(4).Value = p(i).adresse
        Next

        If dgListeChef.Rows.Count > 0 Then
            populateList(dgListeChef.Rows(0).Cells(4).Value)
            lblInfoChef.Text = "(" & dgListeChef.Rows(0).Cells(2).Value & " " & dgListeChef.Rows(0).Cells(3).Value & ") chef de la ligne " & datasource.getGroupById(dgListeChef.Rows(0).Cells(4).Value).numGroup
        End If
    End Sub

    Private Sub dgListeChef_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeChef.CellContentClick

    End Sub

    Private Sub dgListeChef_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeChef.CellClick
        '  dgListeChef.Rows(dgListeChef.Rows.Count - 1).Cells(4).Value 

        populateList(dgListeChef.Rows(dgListeChef.CurrentRow.Index).Cells(4).Value)
        lblInfoChef.Text = "(" & dgListeChef.Rows(dgListeChef.CurrentRow.Index).Cells(2).Value & " " & dgListeChef.Rows(dgListeChef.CurrentRow.Index).Cells(3).Value & ") chef de la ligne " & datasource.getGroupById(dgListeChef.Rows(dgListeChef.CurrentRow.Index).Cells(4).Value).numGroup

        '   lblInfoPersonnel.Text = "Liste des personnels de la ligne N° " & selectedGroup.numGroup


    End Sub

    Public Sub populateList(numGroup As String)
        dgListEmployer.Rows.Clear()

        Dim lstWorker As List(Of Person) = datasource.getWorkersByGroup(numGroup, "Ouvrier")
        For i = 0 To lstWorker.Count - 1
            dgListEmployer.Rows.Add()
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(0).Value = i + 1
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(1).Value = lstWorker(i).nameFamily
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(2).Value = lstWorker(i).nameFirst
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(3).Value = lstWorker(i).cin
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(4).Value = lstWorker(i).numBureau
        Next
        If dgListEmployer.Rows.Count > 0 Then
            lblInfoPersonnel.Text = "Liste des ouvriers sous la supervision de (" & dgListeChef.Rows(dgListeChef.CurrentRow.Index).Cells(2).Value & " " & dgListeChef.Rows(dgListeChef.CurrentRow.Index).Cells(3).Value & ")"
        Else
            lblInfoPersonnel.Text = "Liste des ouvriers"
        End If
    End Sub
End Class
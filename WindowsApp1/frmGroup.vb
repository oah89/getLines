Public Class frmGroup

    Public selectedGroup As Groupe
    Public selectedStatut As String



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNumGroupe.Text = ""
        txtGroupName.Text = ""
        btnAdd.Text = "Ajouter"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtNumGroupe.Text = "" Or txtGroupName.Text = "" Then
            MessageBox.Show("la saisie des champs  est obligatoire ", "Attention ...!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            If datasource.checkGroupExist(txtNumGroupe.Text) Is Nothing Then
                If btnAdd.Text = "Ajouter" Then
                    datasource.addGroupe(txtNumGroupe.Text, txtGroupName.Text)
                Else
                    datasource.updateGroupe(txtNumGroupe.Text, txtGroupName.Text, dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value)
                End If

                populateListGroupe()
            Else
                If btnAdd.Text = "Ajouter" Then
                    MessageBox.Show("La ligne N°  (" & txtNumGroupe.Text & ") déja exist ", "Attention ...!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            End If


        End If



    End Sub

    Private Sub frmGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateListGroupe()
        SetDgColumnModeFill2(dgListChef, 0)
        SetDgColumnModeFill2(dgListEmployer, 1)
        SetDgColumnModeFill2(dgListeGroup, 1)
    End Sub
    Private Sub populateListGroupe()
        dgListeGroup.Rows.Clear()
        Dim p = datasource.getListGroupe()
        For i = 0 To p.Count - 1
            dgListeGroup.Rows.Add()
            dgListeGroup.Rows(dgListeGroup.Rows.Count - 1).Cells(0).Value = p(i).idGroup
            dgListeGroup.Rows(dgListeGroup.Rows.Count - 1).Cells(1).Value = p(i).numGroup
            dgListeGroup.Rows(dgListeGroup.Rows.Count - 1).Cells(2).Value = p(i).groupName
            ' lstGroup.Items.Add(p(i).numGroup & "-" & p(i).groupName)
        Next
        If dgListeGroup.Rows.Count > 0 Then
            dgListeGroup.Rows(0).Selected = True
            populateList(p(0).idGroup)

            lblInfoPersonnel.Text = "Liste des personnels de la ligne N° " & p(0).numGroup
            txtNumGroupe.Text = p(0).numGroup
            txtGroupName.Text = p(0).groupName
        End If
    End Sub

    'Private Sub lstGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGroup.SelectedIndexChanged
    '    MsgBox(lstGroup.SelectedItem.ToString)
    '    populateList(lstGroup.SelectedItem.ToString)
    'End Sub

    Public Sub populateList(numGroup As String)
        dgListChef.Rows.Clear()
        dgListEmployer.Rows.Clear()
        Dim lstChef As List(Of Person) = datasource.getWorkersByGroup(numGroup, "Chef")
        Dim lstWorker As List(Of Person) = datasource.getWorkersByGroup(numGroup, "Ouvrier")

        For i = 0 To lstChef.Count - 1
            dgListChef.Rows.Add()
            dgListChef.Rows(dgListChef.Rows.Count - 1).Cells(0).Value = lstChef(i).idPerson
            dgListChef.Rows(dgListChef.Rows.Count - 1).Cells(1).Value = lstChef(i).nameFamily
            dgListChef.Rows(dgListChef.Rows.Count - 1).Cells(2).Value = lstChef(i).nameFirst
            dgListChef.Rows(dgListChef.Rows.Count - 1).Cells(3).Value = lstChef(i).cin
            dgListChef.Rows(dgListChef.Rows.Count - 1).Cells(4).Value = lstChef(i).numBureau
            dgListChef.Rows(dgListChef.Rows.Count - 1).Cells(5).Value = "Retirer"
        Next

        For i = 0 To lstWorker.Count - 1
            dgListEmployer.Rows.Add()

            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(0).Value = lstWorker(i).idPerson
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(1).Value = i + 1
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(2).Value = lstWorker(i).nameFamily
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(3).Value = lstWorker(i).nameFirst
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(4).Value = lstWorker(i).cin
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(5).Value = lstWorker(i).numBureau
            dgListEmployer.Rows(dgListEmployer.Rows.Count - 1).Cells(6).Value = "Retirer"
        Next
    End Sub

    Private Sub dgListeGroup_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeGroup.CellContentClick

    End Sub

    Private Sub dgListeGroup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeGroup.CellClick

        selectedGroup = New Groupe(dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value, dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(1).Value, dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(2).Value)
        populateList(dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value)

        lblInfoPersonnel.Text = "Liste des personnels de la ligne N° " & selectedGroup.numGroup

        txtNumGroupe.Text = selectedGroup.numGroup
        txtGroupName.Text = selectedGroup.groupName
        btnAdd.Text = "Modifier"

    End Sub

    Private Sub btnAddChef_Click(sender As Object, e As EventArgs) Handles btnAddChef.Click, btnAddPersonelToGroupe.Click
        selectedStatut = IIf(CType(sender, Control).Name = "btnAddChef", "Chef", "Ouvrier")
        selectedGroup = New Groupe(dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value, dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(1).Value, dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(2).Value)
        frmSelectPerson.ShowDialog()
    End Sub

    Private Sub dgListChef_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListChef.CellContentClick

    End Sub

    Private Sub dgListChef_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListChef.CellClick
        If e.ColumnIndex = dgListChef.Columns("btnRetirerC").Index And e.RowIndex >= 0 Then

            If MessageBox.Show("Voulez-vous vraiment retirer le chef(" & dgListChef.Rows(dgListChef.CurrentRow.Index).Cells(1).Value & " " & dgListChef.Rows(dgListChef.CurrentRow.Index).Cells(2).Value & ") du ligne (" & dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(1).Value & ") ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = vbYes Then
                datasource.retirerPerson(dgListChef.Rows(dgListChef.CurrentRow.Index).Cells(0).Value, dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value, "Chef", dateToText(Date.Now))
                ' populateList("")
                populateList(dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value)
            End If

        End If
    End Sub

    Private Sub dgListEmployer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListEmployer.CellContentClick

    End Sub

    Private Sub dgListEmployer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListEmployer.CellClick
        If e.ColumnIndex = dgListEmployer.Columns("btnRetirerP").Index And e.RowIndex >= 0 Then
            If MessageBox.Show("Voulez-vous vraiment retirer l'ouvrier (" & dgListEmployer.Rows(dgListEmployer.CurrentRow.Index).Cells(2).Value & " " & dgListEmployer.Rows(dgListEmployer.CurrentRow.Index).Cells(3).Value & ") du ligne (" & dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(1).Value & ") ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = vbYes Then
                datasource.retirerPerson(dgListEmployer.Rows(dgListEmployer.CurrentRow.Index).Cells(0).Value, dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value, "Ouvrier", dateToText(Date.Now))
                ' populateList("")
                populateList(dgListeGroup.Rows(dgListeGroup.CurrentRow.Index).Cells(0).Value)
            End If

        End If
    End Sub

End Class
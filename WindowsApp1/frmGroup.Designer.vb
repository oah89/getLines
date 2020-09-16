<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroup
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroup))
        Me.dgListEmployer = New System.Windows.Forms.DataGridView()
        Me.dgListChef = New System.Windows.Forms.DataGridView()
        Me.lblInfoPersonnel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumGroupe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.dgListeGroup = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddChef = New System.Windows.Forms.Button()
        Me.btnAddPersonelToGroupe = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nb2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRetirerC = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cinBg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRetirerP = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgListEmployer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgListChef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgListeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgListEmployer
        '
        Me.dgListEmployer.AllowUserToAddRows = False
        Me.dgListEmployer.AllowUserToDeleteRows = False
        Me.dgListEmployer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgListEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListEmployer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.no, Me.Nom, Me.prenom, Me.cinBg, Me.nb, Me.btnRetirerP})
        Me.dgListEmployer.Location = New System.Drawing.Point(262, 170)
        Me.dgListEmployer.Name = "dgListEmployer"
        Me.dgListEmployer.ReadOnly = True
        Me.dgListEmployer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListEmployer.Size = New System.Drawing.Size(727, 348)
        Me.dgListEmployer.TabIndex = 13
        '
        'dgListChef
        '
        Me.dgListChef.AllowUserToAddRows = False
        Me.dgListChef.AllowUserToDeleteRows = False
        Me.dgListChef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgListChef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListChef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Nb2, Me.btnRetirerC})
        Me.dgListChef.Location = New System.Drawing.Point(262, 59)
        Me.dgListChef.Name = "dgListChef"
        Me.dgListChef.ReadOnly = True
        Me.dgListChef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListChef.Size = New System.Drawing.Size(727, 59)
        Me.dgListChef.TabIndex = 15
        '
        'lblInfoPersonnel
        '
        Me.lblInfoPersonnel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoPersonnel.BackColor = System.Drawing.Color.White
        Me.lblInfoPersonnel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoPersonnel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblInfoPersonnel.Location = New System.Drawing.Point(262, 124)
        Me.lblInfoPersonnel.Name = "lblInfoPersonnel"
        Me.lblInfoPersonnel.Size = New System.Drawing.Size(683, 40)
        Me.lblInfoPersonnel.TabIndex = 16
        Me.lblInfoPersonnel.Text = "Liste des personnels de la ligne "
        Me.lblInfoPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(262, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(683, 38)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Détail ligne"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnNew.Location = New System.Drawing.Point(12, 134)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(89, 32)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "Nouveau"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(156, 134)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 32)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Ajouter"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 28)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "N° de ligne          :"
        '
        'txtNumGroupe
        '
        Me.txtNumGroupe.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumGroupe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.txtNumGroupe.Location = New System.Drawing.Point(12, 40)
        Me.txtNumGroupe.Name = "txtNumGroupe"
        Me.txtNumGroupe.Size = New System.Drawing.Size(240, 27)
        Me.txtNumGroupe.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nom de ligne        :"
        '
        'txtGroupName
        '
        Me.txtGroupName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.txtGroupName.Location = New System.Drawing.Point(12, 101)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(240, 27)
        Me.txtGroupName.TabIndex = 21
        '
        'dgListeGroup
        '
        Me.dgListeGroup.AllowUserToAddRows = False
        Me.dgListeGroup.AllowUserToDeleteRows = False
        Me.dgListeGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgListeGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgListeGroup.Location = New System.Drawing.Point(12, 172)
        Me.dgListeGroup.Name = "dgListeGroup"
        Me.dgListeGroup.ReadOnly = True
        Me.dgListeGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListeGroup.Size = New System.Drawing.Size(240, 346)
        Me.dgListeGroup.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "N° Ligne"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nom Ligne"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'btnAddChef
        '
        Me.btnAddChef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddChef.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddChef.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.imgBtnAdd
        Me.btnAddChef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddChef.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddChef.FlatAppearance.BorderSize = 0
        Me.btnAddChef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddChef.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddChef.ForeColor = System.Drawing.Color.White
        Me.btnAddChef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddChef.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddChef.Location = New System.Drawing.Point(954, 14)
        Me.btnAddChef.Name = "btnAddChef"
        Me.btnAddChef.Size = New System.Drawing.Size(35, 35)
        Me.btnAddChef.TabIndex = 22
        Me.btnAddChef.UseVisualStyleBackColor = False
        '
        'btnAddPersonelToGroupe
        '
        Me.btnAddPersonelToGroupe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPersonelToGroupe.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddPersonelToGroupe.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.imgBtnAdd
        Me.btnAddPersonelToGroupe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPersonelToGroupe.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddPersonelToGroupe.FlatAppearance.BorderSize = 0
        Me.btnAddPersonelToGroupe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddPersonelToGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPersonelToGroupe.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPersonelToGroupe.ForeColor = System.Drawing.Color.White
        Me.btnAddPersonelToGroupe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPersonelToGroupe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddPersonelToGroupe.Location = New System.Drawing.Point(954, 128)
        Me.btnAddPersonelToGroupe.Name = "btnAddPersonelToGroupe"
        Me.btnAddPersonelToGroupe.Size = New System.Drawing.Size(35, 35)
        Me.btnAddPersonelToGroupe.TabIndex = 22
        Me.btnAddPersonelToGroupe.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 20
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn4.HeaderText = "prenom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.HeaderText = "C.I.N"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'Nb2
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Nb2.DefaultCellStyle = DataGridViewCellStyle11
        Me.Nb2.HeaderText = "N° Bureau"
        Me.Nb2.Name = "Nb2"
        Me.Nb2.ReadOnly = True
        '
        'btnRetirerC
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.btnRetirerC.DefaultCellStyle = DataGridViewCellStyle12
        Me.btnRetirerC.HeaderText = ""
        Me.btnRetirerC.Name = "btnRetirerC"
        Me.btnRetirerC.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "Column1"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'no
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.HeaderText = "N°"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 20
        '
        'Nom
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Nom.DefaultCellStyle = DataGridViewCellStyle2
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'prenom
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.prenom.DefaultCellStyle = DataGridViewCellStyle3
        Me.prenom.HeaderText = "prenom"
        Me.prenom.Name = "prenom"
        Me.prenom.ReadOnly = True
        '
        'cinBg
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cinBg.DefaultCellStyle = DataGridViewCellStyle4
        Me.cinBg.HeaderText = "C.I.N"
        Me.cinBg.Name = "cinBg"
        Me.cinBg.ReadOnly = True
        Me.cinBg.Width = 50
        '
        'nb
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.nb.DefaultCellStyle = DataGridViewCellStyle5
        Me.nb.HeaderText = "N° Bureau"
        Me.nb.Name = "nb"
        Me.nb.ReadOnly = True
        '
        'btnRetirerP
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.btnRetirerP.DefaultCellStyle = DataGridViewCellStyle6
        Me.btnRetirerP.HeaderText = ""
        Me.btnRetirerP.Name = "btnRetirerP"
        Me.btnRetirerP.ReadOnly = True
        '
        'frmGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1000, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgListeGroup)
        Me.Controls.Add(Me.btnAddPersonelToGroupe)
        Me.Controls.Add(Me.btnAddChef)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumGroupe)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblInfoPersonnel)
        Me.Controls.Add(Me.dgListChef)
        Me.Controls.Add(Me.dgListEmployer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGroup"
        CType(Me.dgListEmployer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgListChef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgListeGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgListEmployer As DataGridView
    Friend WithEvents dgListChef As DataGridView
    Friend WithEvents lblInfoPersonnel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumGroupe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGroupName As TextBox
    Friend WithEvents btnAddChef As Button
    Friend WithEvents dgListeGroup As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddPersonelToGroupe As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents cinBg As DataGridViewTextBoxColumn
    Friend WithEvents nb As DataGridViewTextBoxColumn
    Friend WithEvents btnRetirerP As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Nb2 As DataGridViewTextBoxColumn
    Friend WithEvents btnRetirerC As DataGridViewButtonColumn
End Class

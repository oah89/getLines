<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChef
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChef))
        Me.dgListeChef = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgListEmployer = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cinBg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtEmpbche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInfoPersonnel = New System.Windows.Forms.Label()
        Me.lblInfoChef = New System.Windows.Forms.Label()
        CType(Me.dgListeChef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgListEmployer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgListeChef
        '
        Me.dgListeChef.AllowUserToAddRows = False
        Me.dgListeChef.AllowUserToDeleteRows = False
        Me.dgListeChef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgListeChef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeChef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.cfds, Me.Column1})
        Me.dgListeChef.Location = New System.Drawing.Point(12, 12)
        Me.dgListeChef.Name = "dgListeChef"
        Me.dgListeChef.ReadOnly = True
        Me.dgListeChef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListeChef.Size = New System.Drawing.Size(321, 506)
        Me.dgListeChef.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "idPerson"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "C.I.N"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'cfds
        '
        Me.cfds.HeaderText = "Prénom"
        Me.cfds.Name = "cfds"
        Me.cfds.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "idGroup"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'dgListEmployer
        '
        Me.dgListEmployer.AllowUserToAddRows = False
        Me.dgListEmployer.AllowUserToDeleteRows = False
        Me.dgListEmployer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgListEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListEmployer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.Nom, Me.prenom, Me.cinBg, Me.dtEmpbche})
        Me.dgListEmployer.Location = New System.Drawing.Point(342, 103)
        Me.dgListEmployer.Name = "dgListEmployer"
        Me.dgListEmployer.ReadOnly = True
        Me.dgListEmployer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListEmployer.Size = New System.Drawing.Size(646, 415)
        Me.dgListEmployer.TabIndex = 26
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
        'dtEmpbche
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.dtEmpbche.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtEmpbche.HeaderText = "Date d'embauche"
        Me.dtEmpbche.Name = "dtEmpbche"
        Me.dtEmpbche.ReadOnly = True
        '
        'lblInfoPersonnel
        '
        Me.lblInfoPersonnel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoPersonnel.BackColor = System.Drawing.Color.White
        Me.lblInfoPersonnel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoPersonnel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblInfoPersonnel.Location = New System.Drawing.Point(339, 57)
        Me.lblInfoPersonnel.Name = "lblInfoPersonnel"
        Me.lblInfoPersonnel.Size = New System.Drawing.Size(649, 40)
        Me.lblInfoPersonnel.TabIndex = 27
        Me.lblInfoPersonnel.Text = "Liste des ouvriers"
        Me.lblInfoPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoChef
        '
        Me.lblInfoChef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoChef.BackColor = System.Drawing.Color.White
        Me.lblInfoChef.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoChef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblInfoChef.Location = New System.Drawing.Point(339, 12)
        Me.lblInfoChef.Name = "lblInfoChef"
        Me.lblInfoChef.Size = New System.Drawing.Size(649, 38)
        Me.lblInfoChef.TabIndex = 28
        Me.lblInfoChef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmChef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1000, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInfoChef)
        Me.Controls.Add(Me.lblInfoPersonnel)
        Me.Controls.Add(Me.dgListEmployer)
        Me.Controls.Add(Me.dgListeChef)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChef"
        Me.Text = "frmChef"
        CType(Me.dgListeChef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgListEmployer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgListeChef As DataGridView
    Friend WithEvents dgListEmployer As DataGridView
    Friend WithEvents lblInfoPersonnel As Label
    Friend WithEvents lblInfoChef As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents cinBg As DataGridViewTextBoxColumn
    Friend WithEvents dtEmpbche As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents cfds As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class

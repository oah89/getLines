<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectPerson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectPerson))
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cinBg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSelect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cin = New System.Windows.Forms.RadioButton()
        Me.nameFamily = New System.Windows.Forms.RadioButton()
        Me.nameFirst = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumBureau = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumBureau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.no, Me.Nom, Me.prenom, Me.cinBg, Me.btnSelect})
        Me.dgList.Location = New System.Drawing.Point(8, 78)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgList.Size = New System.Drawing.Size(731, 482)
        Me.dgList.TabIndex = 14
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
        Me.no.HeaderText = "N°"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 20
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'prenom
        '
        Me.prenom.HeaderText = "prenom"
        Me.prenom.Name = "prenom"
        Me.prenom.ReadOnly = True
        '
        'cinBg
        '
        Me.cinBg.HeaderText = "C.I.N"
        Me.cinBg.Name = "cinBg"
        Me.cinBg.ReadOnly = True
        Me.cinBg.Width = 50
        '
        'btnSelect
        '
        Me.btnSelect.HeaderText = ""
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.cin)
        Me.GroupBox1.Controls.Add(Me.nameFamily)
        Me.GroupBox1.Controls.Add(Me.nameFirst)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 70)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherch"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.GestionGroupe.My.Resources.Resources.imgSerach
        Me.PictureBox1.Location = New System.Drawing.Point(535, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(221, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(308, 27)
        Me.txtSearch.TabIndex = 6
        '
        'cin
        '
        Me.cin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cin.AutoSize = True
        Me.cin.Checked = True
        Me.cin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.cin.Location = New System.Drawing.Point(6, 26)
        Me.cin.Name = "cin"
        Me.cin.Size = New System.Drawing.Size(54, 23)
        Me.cin.TabIndex = 7
        Me.cin.TabStop = True
        Me.cin.Text = "CIN"
        Me.cin.UseVisualStyleBackColor = True
        '
        'nameFamily
        '
        Me.nameFamily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameFamily.AutoSize = True
        Me.nameFamily.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameFamily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.nameFamily.Location = New System.Drawing.Point(154, 26)
        Me.nameFamily.Name = "nameFamily"
        Me.nameFamily.Size = New System.Drawing.Size(61, 23)
        Me.nameFamily.TabIndex = 9
        Me.nameFamily.Text = "Nom"
        Me.nameFamily.UseVisualStyleBackColor = True
        '
        'nameFirst
        '
        Me.nameFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameFirst.AutoSize = True
        Me.nameFirst.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.nameFirst.Location = New System.Drawing.Point(66, 26)
        Me.nameFirst.Name = "nameFirst"
        Me.nameFirst.Size = New System.Drawing.Size(82, 23)
        Me.nameFirst.TabIndex = 8
        Me.nameFirst.Text = "Prénom"
        Me.nameFirst.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(584, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "N° Bureau"
        '
        'txtNumBureau
        '
        Me.txtNumBureau.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumBureau.Location = New System.Drawing.Point(672, 30)
        Me.txtNumBureau.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtNumBureau.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumBureau.Name = "txtNumBureau"
        Me.txtNumBureau.Size = New System.Drawing.Size(62, 27)
        Me.txtNumBureau.TabIndex = 15
        Me.txtNumBureau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumBureau.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmSelectPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumBureau)
        Me.Controls.Add(Me.dgList)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSelectPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choisissez une personne"
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumBureau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cin As RadioButton
    Friend WithEvents nameFamily As RadioButton
    Friend WithEvents nameFirst As RadioButton
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents cinBg As DataGridViewTextBoxColumn
    Friend WithEvents btnSelect As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumBureau As NumericUpDown
End Class

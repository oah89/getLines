<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblSelectedBtn = New System.Windows.Forms.Label()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.btnChef = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnGroup = New System.Windows.Forms.Button()
        Me.btnPerson = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.btnAbout)
        Me.PanelTop.Controls.Add(Me.lblSelectedBtn)
        Me.PanelTop.Controls.Add(Me.btnPassword)
        Me.PanelTop.Controls.Add(Me.btnChef)
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.btnMin)
        Me.PanelTop.Controls.Add(Me.btnMax)
        Me.PanelTop.Controls.Add(Me.btnGroup)
        Me.PanelTop.Controls.Add(Me.btnPerson)
        Me.PanelTop.Controls.Add(Me.btnFermer)
        resources.ApplyResources(Me.PanelTop, "PanelTop")
        Me.PanelTop.Name = "PanelTop"
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAbout.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_about
        resources.ApplyResources(Me.btnAbout, "btnAbout")
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'lblSelectedBtn
        '
        Me.lblSelectedBtn.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblSelectedBtn, "lblSelectedBtn")
        Me.lblSelectedBtn.Name = "lblSelectedBtn"
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnPassword.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_users
        resources.ApplyResources(Me.btnPassword, "btnPassword")
        Me.btnPassword.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'btnChef
        '
        Me.btnChef.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnChef.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_chef
        resources.ApplyResources(Me.btnChef, "btnChef")
        Me.btnChef.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnChef.FlatAppearance.BorderSize = 0
        Me.btnChef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnChef.ForeColor = System.Drawing.Color.White
        Me.btnChef.Name = "btnChef"
        Me.btnChef.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.GestionGroupe.My.Resources.Resources.logoStart
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnMin
        '
        resources.ApplyResources(Me.btnMin, "btnMin")
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnMin.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_minimize
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnMin.ForeColor = System.Drawing.Color.White
        Me.btnMin.Name = "btnMin"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        resources.ApplyResources(Me.btnMax, "btnMax")
        Me.btnMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnMax.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_maximaze
        Me.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnMax.ForeColor = System.Drawing.Color.White
        Me.btnMax.Name = "btnMax"
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnGroup
        '
        Me.btnGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGroup.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_groupe
        resources.ApplyResources(Me.btnGroup, "btnGroup")
        Me.btnGroup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGroup.FlatAppearance.BorderSize = 0
        Me.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnGroup.ForeColor = System.Drawing.Color.White
        Me.btnGroup.Name = "btnGroup"
        Me.btnGroup.UseVisualStyleBackColor = False
        '
        'btnPerson
        '
        Me.btnPerson.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnPerson.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_person
        resources.ApplyResources(Me.btnPerson, "btnPerson")
        Me.btnPerson.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPerson.FlatAppearance.BorderSize = 0
        Me.btnPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnPerson.ForeColor = System.Drawing.Color.White
        Me.btnPerson.Name = "btnPerson"
        Me.btnPerson.UseVisualStyleBackColor = False
        '
        'btnFermer
        '
        resources.ApplyResources(Me.btnFermer, "btnFermer")
        Me.btnFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnFermer.BackgroundImage = Global.GestionGroupe.My.Resources.Resources.img_btn_exit3
        Me.btnFermer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFermer.FlatAppearance.BorderSize = 0
        Me.btnFermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnFermer.ForeColor = System.Drawing.Color.White
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        resources.ApplyResources(Me.RibbonButton1, "RibbonButton1")
        '
        'RibbonButton2
        '
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        resources.ApplyResources(Me.RibbonButton2, "RibbonButton2")
        '
        'RibbonTab1
        '
        resources.ApplyResources(Me.RibbonTab1, "RibbonTab1")
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.SystemColors.ActiveBorder
        resources.ApplyResources(Me.PanelContent, "PanelContent")
        Me.PanelContent.Name = "PanelContent"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.PanelTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As Panel
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents RibbonButton2 As RibbonButton
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelContent As Panel
    Friend WithEvents btnFermer As Button
    Friend WithEvents btnPassword As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnGroup As Button
    Friend WithEvents btnPerson As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnChef As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents lblSelectedBtn As Label
End Class

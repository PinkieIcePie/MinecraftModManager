<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_init
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_proftext = New System.Windows.Forms.Label()
        Me.gb_stats = New System.Windows.Forms.GroupBox()
        Me.lbl_ram = New System.Windows.Forms.Label()
        Me.lbl_moddir = New System.Windows.Forms.Label()
        Me.lbl_isforge = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_mcver = New System.Windows.Forms.Label()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_forgetext = New System.Windows.Forms.Label()
        Me.lbl_typetext = New System.Windows.Forms.Label()
        Me.lbl_vertext = New System.Windows.Forms.Label()
        Me.btn_newprofile = New System.Windows.Forms.Button()
        Me.btn_editprof = New System.Windows.Forms.Button()
        Me.btn_mods = New System.Windows.Forms.Button()
        Me.btn_down = New System.Windows.Forms.Button()
        Me.gb_mods = New System.Windows.Forms.GroupBox()
        Me.lb_mods = New System.Windows.Forms.ListBox()
        Me.cb_profilesel = New System.Windows.Forms.ComboBox()
        Me.gb_stats.SuspendLayout()
        Me.gb_mods.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_proftext
        '
        Me.lbl_proftext.AutoSize = True
        Me.lbl_proftext.Location = New System.Drawing.Point(3, 16)
        Me.lbl_proftext.Name = "lbl_proftext"
        Me.lbl_proftext.Size = New System.Drawing.Size(84, 13)
        Me.lbl_proftext.TabIndex = 0
        Me.lbl_proftext.Text = "Selected Profile:"
        '
        'gb_stats
        '
        Me.gb_stats.Controls.Add(Me.lbl_ram)
        Me.gb_stats.Controls.Add(Me.lbl_moddir)
        Me.gb_stats.Controls.Add(Me.lbl_isforge)
        Me.gb_stats.Controls.Add(Me.lbl_type)
        Me.gb_stats.Controls.Add(Me.lbl_mcver)
        Me.gb_stats.Controls.Add(Me.lbl_profile)
        Me.gb_stats.Controls.Add(Me.Label5)
        Me.gb_stats.Controls.Add(Me.Label4)
        Me.gb_stats.Controls.Add(Me.lbl_forgetext)
        Me.gb_stats.Controls.Add(Me.lbl_typetext)
        Me.gb_stats.Controls.Add(Me.lbl_vertext)
        Me.gb_stats.Controls.Add(Me.lbl_proftext)
        Me.gb_stats.Location = New System.Drawing.Point(379, 12)
        Me.gb_stats.Name = "gb_stats"
        Me.gb_stats.Size = New System.Drawing.Size(200, 349)
        Me.gb_stats.TabIndex = 1
        Me.gb_stats.TabStop = False
        Me.gb_stats.Text = "Status"
        '
        'lbl_ram
        '
        Me.lbl_ram.AutoSize = True
        Me.lbl_ram.Location = New System.Drawing.Point(6, 263)
        Me.lbl_ram.Name = "lbl_ram"
        Me.lbl_ram.Size = New System.Drawing.Size(83, 13)
        Me.lbl_ram.TabIndex = 11
        Me.lbl_ram.Text = "%loadedprofile%"
        '
        'lbl_moddir
        '
        Me.lbl_moddir.AutoSize = True
        Me.lbl_moddir.Location = New System.Drawing.Point(6, 214)
        Me.lbl_moddir.Name = "lbl_moddir"
        Me.lbl_moddir.Size = New System.Drawing.Size(83, 13)
        Me.lbl_moddir.TabIndex = 10
        Me.lbl_moddir.Text = "%loadedprofile%"
        '
        'lbl_isforge
        '
        Me.lbl_isforge.AutoSize = True
        Me.lbl_isforge.Location = New System.Drawing.Point(4, 170)
        Me.lbl_isforge.Name = "lbl_isforge"
        Me.lbl_isforge.Size = New System.Drawing.Size(83, 13)
        Me.lbl_isforge.TabIndex = 9
        Me.lbl_isforge.Text = "%loadedprofile%"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(6, 125)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(83, 13)
        Me.lbl_type.TabIndex = 8
        Me.lbl_type.Text = "%loadedprofile%"
        '
        'lbl_mcver
        '
        Me.lbl_mcver.AutoSize = True
        Me.lbl_mcver.Location = New System.Drawing.Point(6, 78)
        Me.lbl_mcver.Name = "lbl_mcver"
        Me.lbl_mcver.Size = New System.Drawing.Size(83, 13)
        Me.lbl_mcver.TabIndex = 7
        Me.lbl_mcver.Text = "%loadedprofile%"
        '
        'lbl_profile
        '
        Me.lbl_profile.AutoSize = True
        Me.lbl_profile.Location = New System.Drawing.Point(6, 35)
        Me.lbl_profile.Name = "lbl_profile"
        Me.lbl_profile.Size = New System.Drawing.Size(83, 13)
        Me.lbl_profile.TabIndex = 6
        Me.lbl_profile.Text = "%loadedprofile%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "RAM Allocated:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mod Directory:"
        '
        'lbl_forgetext
        '
        Me.lbl_forgetext.AutoSize = True
        Me.lbl_forgetext.Location = New System.Drawing.Point(3, 149)
        Me.lbl_forgetext.Name = "lbl_forgetext"
        Me.lbl_forgetext.Size = New System.Drawing.Size(79, 13)
        Me.lbl_forgetext.TabIndex = 3
        Me.lbl_forgetext.Text = "Forge Enabled:"
        '
        'lbl_typetext
        '
        Me.lbl_typetext.AutoSize = True
        Me.lbl_typetext.Location = New System.Drawing.Point(3, 103)
        Me.lbl_typetext.Name = "lbl_typetext"
        Me.lbl_typetext.Size = New System.Drawing.Size(34, 13)
        Me.lbl_typetext.TabIndex = 2
        Me.lbl_typetext.Text = "Type:"
        '
        'lbl_vertext
        '
        Me.lbl_vertext.AutoSize = True
        Me.lbl_vertext.Location = New System.Drawing.Point(3, 58)
        Me.lbl_vertext.Name = "lbl_vertext"
        Me.lbl_vertext.Size = New System.Drawing.Size(92, 13)
        Me.lbl_vertext.TabIndex = 1
        Me.lbl_vertext.Text = "Minecraft Version:"
        '
        'btn_newprofile
        '
        Me.btn_newprofile.Location = New System.Drawing.Point(233, 18)
        Me.btn_newprofile.Name = "btn_newprofile"
        Me.btn_newprofile.Size = New System.Drawing.Size(140, 23)
        Me.btn_newprofile.TabIndex = 2
        Me.btn_newprofile.Text = "Create New Profile"
        Me.btn_newprofile.UseVisualStyleBackColor = True
        '
        'btn_editprof
        '
        Me.btn_editprof.Location = New System.Drawing.Point(233, 47)
        Me.btn_editprof.Name = "btn_editprof"
        Me.btn_editprof.Size = New System.Drawing.Size(140, 23)
        Me.btn_editprof.TabIndex = 3
        Me.btn_editprof.Text = "Edit Current Profile"
        Me.btn_editprof.UseVisualStyleBackColor = True
        '
        'btn_mods
        '
        Me.btn_mods.Location = New System.Drawing.Point(12, 85)
        Me.btn_mods.Name = "btn_mods"
        Me.btn_mods.Size = New System.Drawing.Size(140, 23)
        Me.btn_mods.TabIndex = 4
        Me.btn_mods.Text = "Enable/Disable Mods"
        Me.btn_mods.UseVisualStyleBackColor = True
        '
        'btn_down
        '
        Me.btn_down.Location = New System.Drawing.Point(233, 85)
        Me.btn_down.Name = "btn_down"
        Me.btn_down.Size = New System.Drawing.Size(140, 23)
        Me.btn_down.TabIndex = 5
        Me.btn_down.Text = "Download Mods"
        Me.btn_down.UseVisualStyleBackColor = True
        '
        'gb_mods
        '
        Me.gb_mods.Controls.Add(Me.lb_mods)
        Me.gb_mods.Location = New System.Drawing.Point(13, 137)
        Me.gb_mods.Name = "gb_mods"
        Me.gb_mods.Size = New System.Drawing.Size(360, 224)
        Me.gb_mods.TabIndex = 6
        Me.gb_mods.TabStop = False
        Me.gb_mods.Text = "Enabled Mods"
        '
        'lb_mods
        '
        Me.lb_mods.BackColor = System.Drawing.SystemColors.Control
        Me.lb_mods.FormattingEnabled = True
        Me.lb_mods.Items.AddRange(New Object() {"No Mods Loaded :("})
        Me.lb_mods.Location = New System.Drawing.Point(7, 20)
        Me.lb_mods.Name = "lb_mods"
        Me.lb_mods.Size = New System.Drawing.Size(347, 199)
        Me.lb_mods.TabIndex = 0
        '
        'cb_profilesel
        '
        Me.cb_profilesel.FormattingEnabled = True
        Me.cb_profilesel.Location = New System.Drawing.Point(14, 39)
        Me.cb_profilesel.Name = "cb_profilesel"
        Me.cb_profilesel.Size = New System.Drawing.Size(177, 21)
        Me.cb_profilesel.TabIndex = 7
        Me.cb_profilesel.Text = "Select Profile"
        '
        'frm_init
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(591, 373)
        Me.Controls.Add(Me.cb_profilesel)
        Me.Controls.Add(Me.gb_mods)
        Me.Controls.Add(Me.btn_down)
        Me.Controls.Add(Me.btn_mods)
        Me.Controls.Add(Me.btn_editprof)
        Me.Controls.Add(Me.btn_newprofile)
        Me.Controls.Add(Me.gb_stats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_init"
        Me.Text = "Minecraft Mod Manager"
        Me.gb_stats.ResumeLayout(False)
        Me.gb_stats.PerformLayout()
        Me.gb_mods.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_proftext As Label
    Friend WithEvents gb_stats As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_typetext As Label
    Friend WithEvents lbl_vertext As Label
    Friend WithEvents btn_newprofile As Button
    Friend WithEvents btn_editprof As Button
    Friend WithEvents btn_mods As Button
    Friend WithEvents btn_down As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_forgetext As Label
    Friend WithEvents gb_mods As GroupBox
    Friend WithEvents lb_mods As ListBox
    Friend WithEvents lbl_ram As Label
    Friend WithEvents lbl_moddir As Label
    Friend WithEvents lbl_isforge As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_mcver As Label
    Friend WithEvents lbl_profile As Label
    Friend WithEvents cb_profilesel As ComboBox
End Class

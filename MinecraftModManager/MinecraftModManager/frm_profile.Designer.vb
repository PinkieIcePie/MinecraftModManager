<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_profname = New System.Windows.Forms.TextBox()
        Me.tb_ram = New System.Windows.Forms.TextBox()
        Me.rb_online = New System.Windows.Forms.RadioButton()
        Me.rb_offline = New System.Windows.Forms.RadioButton()
        Me.cb_mcver = New System.Windows.Forms.ComboBox()
        Me.track_ram = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.check_installforge = New System.Windows.Forms.CheckBox()
        Me.check_jvmarg = New System.Windows.Forms.CheckBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_discard = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.check_copywrld = New System.Windows.Forms.CheckBox()
        Me.check_server = New System.Windows.Forms.CheckBox()
        Me.check_adddefmods = New System.Windows.Forms.CheckBox()
        CType(Me.track_ram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Profile Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minecraft Version:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RAM Allocation (in MB):"
        '
        'tb_profname
        '
        Me.tb_profname.Location = New System.Drawing.Point(88, 53)
        Me.tb_profname.Name = "tb_profname"
        Me.tb_profname.Size = New System.Drawing.Size(312, 20)
        Me.tb_profname.TabIndex = 3
        '
        'tb_ram
        '
        Me.tb_ram.Location = New System.Drawing.Point(137, 134)
        Me.tb_ram.Name = "tb_ram"
        Me.tb_ram.Size = New System.Drawing.Size(103, 20)
        Me.tb_ram.TabIndex = 5
        '
        'rb_online
        '
        Me.rb_online.AutoSize = True
        Me.rb_online.Location = New System.Drawing.Point(110, 92)
        Me.rb_online.Name = "rb_online"
        Me.rb_online.Size = New System.Drawing.Size(73, 17)
        Me.rb_online.TabIndex = 6
        Me.rb_online.TabStop = True
        Me.rb_online.Text = "Download"
        Me.rb_online.UseVisualStyleBackColor = True
        '
        'rb_offline
        '
        Me.rb_offline.AutoSize = True
        Me.rb_offline.Location = New System.Drawing.Point(189, 92)
        Me.rb_offline.Name = "rb_offline"
        Me.rb_offline.Size = New System.Drawing.Size(51, 17)
        Me.rb_offline.TabIndex = 7
        Me.rb_offline.TabStop = True
        Me.rb_offline.Text = "Local"
        Me.rb_offline.UseVisualStyleBackColor = True
        '
        'cb_mcver
        '
        Me.cb_mcver.FormattingEnabled = True
        Me.cb_mcver.Location = New System.Drawing.Point(246, 91)
        Me.cb_mcver.Name = "cb_mcver"
        Me.cb_mcver.Size = New System.Drawing.Size(154, 21)
        Me.cb_mcver.TabIndex = 8
        '
        'track_ram
        '
        Me.track_ram.Location = New System.Drawing.Point(246, 134)
        Me.track_ram.Name = "track_ram"
        Me.track_ram.Size = New System.Drawing.Size(154, 45)
        Me.track_ram.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Forge Options:"
        '
        'check_installforge
        '
        Me.check_installforge.AutoSize = True
        Me.check_installforge.Location = New System.Drawing.Point(110, 183)
        Me.check_installforge.Name = "check_installforge"
        Me.check_installforge.Size = New System.Drawing.Size(53, 17)
        Me.check_installforge.TabIndex = 11
        Me.check_installforge.Text = "Install"
        Me.check_installforge.UseVisualStyleBackColor = True
        '
        'check_jvmarg
        '
        Me.check_jvmarg.AutoSize = True
        Me.check_jvmarg.Location = New System.Drawing.Point(169, 183)
        Me.check_jvmarg.Name = "check_jvmarg"
        Me.check_jvmarg.Size = New System.Drawing.Size(93, 17)
        Me.check_jvmarg.TabIndex = 12
        Me.check_jvmarg.Text = "Add JVM Args"
        Me.check_jvmarg.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 314)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(116, 23)
        Me.btn_save.TabIndex = 14
        Me.btn_save.Text = "Save Changes"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_discard
        '
        Me.btn_discard.Enabled = False
        Me.btn_discard.Location = New System.Drawing.Point(134, 314)
        Me.btn_discard.Name = "btn_discard"
        Me.btn_discard.Size = New System.Drawing.Size(116, 23)
        Me.btn_discard.TabIndex = 15
        Me.btn_discard.Text = "Discard Changes"
        Me.btn_discard.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(256, 314)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(116, 23)
        Me.btn_close.TabIndex = 16
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "General Options:"
        '
        'check_copywrld
        '
        Me.check_copywrld.AutoSize = True
        Me.check_copywrld.Location = New System.Drawing.Point(409, 81)
        Me.check_copywrld.Name = "check_copywrld"
        Me.check_copywrld.Size = New System.Drawing.Size(171, 17)
        Me.check_copywrld.TabIndex = 18
        Me.check_copywrld.Text = "Copy Worlds from Old Versions"
        Me.check_copywrld.UseVisualStyleBackColor = True
        '
        'check_server
        '
        Me.check_server.AutoSize = True
        Me.check_server.Location = New System.Drawing.Point(268, 182)
        Me.check_server.Name = "check_server"
        Me.check_server.Size = New System.Drawing.Size(110, 17)
        Me.check_server.TabIndex = 20
        Me.check_server.Text = "Also Install Server"
        Me.check_server.UseVisualStyleBackColor = True
        '
        'check_adddefmods
        '
        Me.check_adddefmods.AutoSize = True
        Me.check_adddefmods.Location = New System.Drawing.Point(409, 113)
        Me.check_adddefmods.Name = "check_adddefmods"
        Me.check_adddefmods.Size = New System.Drawing.Size(111, 17)
        Me.check_adddefmods.TabIndex = 19
        Me.check_adddefmods.Text = "Add Default Mods"
        Me.check_adddefmods.UseVisualStyleBackColor = True
        '
        'frm_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 349)
        Me.Controls.Add(Me.check_server)
        Me.Controls.Add(Me.check_adddefmods)
        Me.Controls.Add(Me.check_copywrld)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_discard)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.check_jvmarg)
        Me.Controls.Add(Me.check_installforge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.track_ram)
        Me.Controls.Add(Me.cb_mcver)
        Me.Controls.Add(Me.rb_offline)
        Me.Controls.Add(Me.rb_online)
        Me.Controls.Add(Me.tb_ram)
        Me.Controls.Add(Me.tb_profname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Enabled = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_profile"
        Me.ShowInTaskbar = False
        Me.Text = "frm_profile"
        CType(Me.track_ram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_profname As TextBox
    Friend WithEvents tb_ram As TextBox
    Friend WithEvents rb_online As RadioButton
    Friend WithEvents rb_offline As RadioButton
    Friend WithEvents cb_mcver As ComboBox
    Friend WithEvents track_ram As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents check_installforge As CheckBox
    Friend WithEvents check_jvmarg As CheckBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_discard As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents check_copywrld As CheckBox
    Friend WithEvents check_server As CheckBox
    Friend WithEvents check_adddefmods As CheckBox
End Class

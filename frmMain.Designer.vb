<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnAdminClose = New FontAwesome.Sharp.IconButton()
        Me.btnLoad = New FontAwesome.Sharp.IconButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStudProfile = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnExitMain = New System.Windows.Forms.Button()
        Me.lblGreetUser = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(18, 21)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 32)
        Me.lblUser.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(245, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(980, 469)
        Me.DataGridView1.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pencil
        Me.btnUpdate.IconColor = System.Drawing.Color.Green
        Me.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdate.IconSize = 56
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(515, 553)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(159, 57)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "        Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Multiply
        Me.btnDelete.IconColor = System.Drawing.Color.Green
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 56
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(798, 556)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(159, 57)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "        Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdminClose
        '
        Me.btnAdminClose.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdminClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnAdminClose.IconColor = System.Drawing.Color.Red
        Me.btnAdminClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdminClose.IconSize = 56
        Me.btnAdminClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminClose.Location = New System.Drawing.Point(1066, 556)
        Me.btnAdminClose.Name = "btnAdminClose"
        Me.btnAdminClose.Size = New System.Drawing.Size(159, 57)
        Me.btnAdminClose.TabIndex = 4
        Me.btnAdminClose.Text = "        Close"
        Me.btnAdminClose.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLoad.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.btnLoad.IconColor = System.Drawing.Color.Green
        Me.btnLoad.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLoad.IconSize = 56
        Me.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoad.Location = New System.Drawing.Point(245, 553)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(159, 57)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "        Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDashboard)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnStudProfile)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSetting)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExitMain)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(223, 624)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UserRegistration.My.Resources.Resources.LOGO
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(214, 196)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.UserRegistration.My.Resources.Resources.DashBoard
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(3, 205)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(208, 62)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "      Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnStudProfile
        '
        Me.btnStudProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudProfile.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStudProfile.FlatAppearance.BorderSize = 0
        Me.btnStudProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudProfile.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStudProfile.ForeColor = System.Drawing.Color.White
        Me.btnStudProfile.Image = Global.UserRegistration.My.Resources.Resources.Officials
        Me.btnStudProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudProfile.Location = New System.Drawing.Point(3, 273)
        Me.btnStudProfile.Name = "btnStudProfile"
        Me.btnStudProfile.Size = New System.Drawing.Size(208, 62)
        Me.btnStudProfile.TabIndex = 3
        Me.btnStudProfile.Text = "         Student Profile"
        Me.btnStudProfile.UseVisualStyleBackColor = True
        '
        'btnSetting
        '
        Me.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSetting.ForeColor = System.Drawing.Color.White
        Me.btnSetting.Image = Global.UserRegistration.My.Resources.Resources._set
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(3, 341)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(208, 62)
        Me.btnSetting.TabIndex = 4
        Me.btnSetting.Text = "    Setting"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnExitMain
        '
        Me.btnExitMain.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExitMain.FlatAppearance.BorderSize = 0
        Me.btnExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitMain.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExitMain.ForeColor = System.Drawing.Color.White
        Me.btnExitMain.Image = Global.UserRegistration.My.Resources.Resources._exit
        Me.btnExitMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExitMain.Location = New System.Drawing.Point(3, 409)
        Me.btnExitMain.Name = "btnExitMain"
        Me.btnExitMain.Size = New System.Drawing.Size(208, 62)
        Me.btnExitMain.TabIndex = 5
        Me.btnExitMain.Text = "Exit"
        Me.btnExitMain.UseVisualStyleBackColor = True
        '
        'lblGreetUser
        '
        Me.lblGreetUser.AutoSize = True
        Me.lblGreetUser.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGreetUser.Location = New System.Drawing.Point(245, 21)
        Me.lblGreetUser.Name = "lblGreetUser"
        Me.lblGreetUser.Size = New System.Drawing.Size(144, 40)
        Me.lblGreetUser.TabIndex = 7
        Me.lblGreetUser.Text = "Welcome"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1231, 625)
        Me.Controls.Add(Me.lblGreetUser)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnAdminClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdminClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLoad As FontAwesome.Sharp.IconButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnStudProfile As Button
    Friend WithEvents btnSetting As Button
    Friend WithEvents btnExitMain As Button
    Friend WithEvents lblGreetUser As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnAdminClose = New FontAwesome.Sharp.IconButton()
        Me.btnLoad = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Location = New System.Drawing.Point(11, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(699, 234)
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
        Me.btnUpdate.Location = New System.Drawing.Point(195, 378)
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
        Me.btnDelete.Location = New System.Drawing.Point(374, 378)
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
        Me.btnAdminClose.Location = New System.Drawing.Point(551, 378)
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
        Me.btnLoad.Location = New System.Drawing.Point(11, 378)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(159, 57)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "        Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PeopleLine
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 80
        Me.IconPictureBox1.Location = New System.Drawing.Point(623, 12)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(87, 80)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 6
        Me.IconPictureBox1.TabStop = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(722, 463)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnAdminClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdminClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLoad As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class

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
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usertype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnCloseAdmin = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(21, 15)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(120, 27)
        Me.lblUserType.TabIndex = 0
        Me.lblUserType.Text = "Welcome, "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.password, Me.fullname, Me.usertype})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(633, 197)
        Me.DataGridView1.TabIndex = 1
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        '
        'password
        '
        Me.password.HeaderText = "Password"
        Me.password.Name = "password"
        '
        'fullname
        '
        Me.fullname.HeaderText = "Full Name"
        Me.fullname.Name = "fullname"
        '
        'usertype
        '
        Me.usertype.HeaderText = "User Type"
        Me.usertype.Name = "usertype"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pencil
        Me.btnUpdate.IconColor = System.Drawing.Color.Green
        Me.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdate.IconSize = 56
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnUpdate.Location = New System.Drawing.Point(21, 413)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(169, 67)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "    Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TimesSquare
        Me.btnDelete.IconColor = System.Drawing.Color.Green
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 56
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDelete.Location = New System.Drawing.Point(248, 413)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(169, 67)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "    Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCloseAdmin
        '
        Me.btnCloseAdmin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCloseAdmin.IconChar = FontAwesome.Sharp.IconChar.Multiply
        Me.btnCloseAdmin.IconColor = System.Drawing.Color.Red
        Me.btnCloseAdmin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCloseAdmin.IconSize = 56
        Me.btnCloseAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCloseAdmin.Location = New System.Drawing.Point(469, 413)
        Me.btnCloseAdmin.Name = "btnCloseAdmin"
        Me.btnCloseAdmin.Size = New System.Drawing.Size(169, 67)
        Me.btnCloseAdmin.TabIndex = 9
        Me.btnCloseAdmin.Text = "    Close"
        Me.btnCloseAdmin.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(666, 526)
        Me.Controls.Add(Me.btnCloseAdmin)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblUserType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserType As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents usertype As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCloseAdmin As FontAwesome.Sharp.IconButton
End Class

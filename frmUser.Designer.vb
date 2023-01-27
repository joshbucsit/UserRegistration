<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.btnLogin = New FontAwesome.Sharp.IconButton()
        Me.lblUserGreet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftRotate
        Me.btnLogin.IconColor = System.Drawing.Color.Green
        Me.btnLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogin.IconSize = 56
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLogin.Location = New System.Drawing.Point(99, 258)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(169, 67)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "    Back"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUserGreet
        '
        Me.lblUserGreet.AutoSize = True
        Me.lblUserGreet.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUserGreet.ForeColor = System.Drawing.Color.White
        Me.lblUserGreet.Location = New System.Drawing.Point(30, 54)
        Me.lblUserGreet.Name = "lblUserGreet"
        Me.lblUserGreet.Size = New System.Drawing.Size(88, 32)
        Me.lblUserGreet.TabIndex = 8
        Me.lblUserGreet.Text = "Label1"
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(381, 450)
        Me.Controls.Add(Me.lblUserGreet)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmUser"
        Me.Text = "frmUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents lblUserGreet As Label
End Class

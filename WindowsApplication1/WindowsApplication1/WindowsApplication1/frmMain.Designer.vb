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
        Me.btnAuthorize = New System.Windows.Forms.Button()
        Me.btnRequirements = New System.Windows.Forms.Button()
        Me.lblAuthorize = New System.Windows.Forms.Label()
        Me.txtSecretKey = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAuthorize
        '
        Me.btnAuthorize.Location = New System.Drawing.Point(15, 229)
        Me.btnAuthorize.Name = "btnAuthorize"
        Me.btnAuthorize.Size = New System.Drawing.Size(161, 31)
        Me.btnAuthorize.TabIndex = 0
        Me.btnAuthorize.Text = "Authorize"
        Me.btnAuthorize.UseVisualStyleBackColor = True
        '
        'btnRequirements
        '
        Me.btnRequirements.Location = New System.Drawing.Point(230, 229)
        Me.btnRequirements.Name = "btnRequirements"
        Me.btnRequirements.Size = New System.Drawing.Size(161, 31)
        Me.btnRequirements.TabIndex = 1
        Me.btnRequirements.Text = "Show Contacts Table"
        Me.btnRequirements.UseVisualStyleBackColor = True
        '
        'lblAuthorize
        '
        Me.lblAuthorize.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAuthorize.Location = New System.Drawing.Point(373, 127)
        Me.lblAuthorize.Name = "lblAuthorize"
        Me.lblAuthorize.Size = New System.Drawing.Size(226, 53)
        Me.lblAuthorize.TabIndex = 2
        '
        'txtSecretKey
        '
        Me.txtSecretKey.Location = New System.Drawing.Point(149, 66)
        Me.txtSecretKey.Name = "txtSecretKey"
        Me.txtSecretKey.Size = New System.Drawing.Size(169, 20)
        Me.txtSecretKey.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApiKey)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSecretKey)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 101)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credentials"
        '
        'txtApiKey
        '
        Me.txtApiKey.Location = New System.Drawing.Point(149, 35)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(169, 20)
        Me.txtApiKey.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Secret Key:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "API Key:"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(373, 112)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(45, 13)
        Me.lblResults.TabIndex = 6
        Me.lblResults.Text = "Results:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(587, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Directions:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(602, 43)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(618, 269)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAuthorize)
        Me.Controls.Add(Me.btnRequirements)
        Me.Controls.Add(Me.btnAuthorize)
        Me.Name = "frmMain"
        Me.Text = "Authentication"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAuthorize As System.Windows.Forms.Button
    Friend WithEvents btnRequirements As System.Windows.Forms.Button
    Friend WithEvents lblAuthorize As System.Windows.Forms.Label
    Friend WithEvents txtSecretKey As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApiKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

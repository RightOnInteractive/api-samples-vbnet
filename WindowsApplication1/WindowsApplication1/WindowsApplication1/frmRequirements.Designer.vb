<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequirements
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
        Me.lstLastName = New System.Windows.Forms.ListBox()
        Me.lstFirstName = New System.Windows.Forms.ListBox()
        Me.lstEmail = New System.Windows.Forms.ListBox()
        Me.lstPhone = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLastName
        '
        Me.lstLastName.FormattingEnabled = True
        Me.lstLastName.Location = New System.Drawing.Point(138, 43)
        Me.lstLastName.Name = "lstLastName"
        Me.lstLastName.Size = New System.Drawing.Size(120, 342)
        Me.lstLastName.TabIndex = 0
        '
        'lstFirstName
        '
        Me.lstFirstName.FormattingEnabled = True
        Me.lstFirstName.Location = New System.Drawing.Point(12, 43)
        Me.lstFirstName.Name = "lstFirstName"
        Me.lstFirstName.Size = New System.Drawing.Size(120, 342)
        Me.lstFirstName.TabIndex = 1
        '
        'lstEmail
        '
        Me.lstEmail.FormattingEnabled = True
        Me.lstEmail.Location = New System.Drawing.Point(264, 43)
        Me.lstEmail.Name = "lstEmail"
        Me.lstEmail.Size = New System.Drawing.Size(120, 342)
        Me.lstEmail.TabIndex = 2
        '
        'lstPhone
        '
        Me.lstPhone.FormattingEnabled = True
        Me.lstPhone.Location = New System.Drawing.Point(390, 43)
        Me.lstPhone.Name = "lstPhone"
        Me.lstPhone.Size = New System.Drawing.Size(120, 342)
        Me.lstPhone.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(432, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(435, 402)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmRequirements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 437)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPhone)
        Me.Controls.Add(Me.lstEmail)
        Me.Controls.Add(Me.lstFirstName)
        Me.Controls.Add(Me.lstLastName)
        Me.Name = "frmRequirements"
        Me.Text = "Contact Requirements"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLastName As System.Windows.Forms.ListBox
    Friend WithEvents lstFirstName As System.Windows.Forms.ListBox
    Friend WithEvents lstEmail As System.Windows.Forms.ListBox
    Friend WithEvents lstPhone As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

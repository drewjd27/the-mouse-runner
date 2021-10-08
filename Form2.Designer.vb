<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.yay = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'yay
        '
        Me.yay.AutoRoundedCorners = True
        Me.yay.BorderRadius = 26
        Me.yay.CheckedState.Parent = Me.yay
        Me.yay.CustomImages.Parent = Me.yay
        Me.yay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.yay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.yay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.yay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.yay.DisabledState.Parent = Me.yay
        Me.yay.FillColor = System.Drawing.Color.Gainsboro
        Me.yay.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.yay.HoverState.Parent = Me.yay
        Me.yay.Location = New System.Drawing.Point(305, 342)
        Me.yay.Name = "yay"
        Me.yay.ShadowDecoration.Parent = Me.yay
        Me.yay.Size = New System.Drawing.Size(190, 55)
        Me.yay.TabIndex = 3
        Me.yay.Text = "Yay!"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Open Sans SemiBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(794, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selamat, Anda berhasil mencapai FINISH!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.yay)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents yay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class

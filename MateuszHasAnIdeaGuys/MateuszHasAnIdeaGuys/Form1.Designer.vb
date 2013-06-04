<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapNetworkDrive
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
        Me.MapButton = New System.Windows.Forms.CheckBox()
        Me.UserBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Map = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'MapButton
        '
        Me.MapButton.AutoSize = True
        Me.MapButton.Location = New System.Drawing.Point(43, 121)
        Me.MapButton.Name = "MapButton"
        Me.MapButton.Size = New System.Drawing.Size(117, 17)
        Me.MapButton.TabIndex = 1
        Me.MapButton.Text = "Map Course Drive?"
        Me.MapButton.UseVisualStyleBackColor = True
        '
        'UserBox
        '
        Me.UserBox.Location = New System.Drawing.Point(128, 22)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(287, 20)
        Me.UserBox.TabIndex = 2
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(128, 72)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(287, 20)
        Me.PassBox.TabIndex = 3
        Me.PassBox.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'Map
        '
        Me.Map.Location = New System.Drawing.Point(340, 115)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(75, 23)
        Me.Map.TabIndex = 5
        Me.Map.Text = "Map"
        Me.Map.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Clear Mapped Drives"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MapNetworkDrive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 168)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Map)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserBox)
        Me.Controls.Add(Me.MapButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MapNetworkDrive"
        Me.Text = "Map Network Drive"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MapButton As System.Windows.Forms.CheckBox
    Friend WithEvents UserBox As System.Windows.Forms.TextBox
    Friend WithEvents PassBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Map As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

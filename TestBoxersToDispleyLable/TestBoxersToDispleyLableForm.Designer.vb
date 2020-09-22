<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestBoxersToDispleyLableForm
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
        Me.firstnameTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxToDisplayEmail = New System.Windows.Forms.TextBox()
        Me.lastnameTextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'firstnameTextBox
        '
        Me.firstnameTextBox.Location = New System.Drawing.Point(12, 12)
        Me.firstnameTextBox.Name = "firstnameTextBox"
        Me.firstnameTextBox.Size = New System.Drawing.Size(340, 31)
        Me.firstnameTextBox.TabIndex = 0
        '
        'TextBoxToDisplayEmail
        '
        Me.TextBoxToDisplayEmail.Location = New System.Drawing.Point(12, 108)
        Me.TextBoxToDisplayEmail.Name = "TextBoxToDisplayEmail"
        Me.TextBoxToDisplayEmail.Size = New System.Drawing.Size(340, 31)
        Me.TextBoxToDisplayEmail.TabIndex = 1
        '
        'lastnameTextBox
        '
        Me.lastnameTextBox.Location = New System.Drawing.Point(12, 61)
        Me.lastnameTextBox.Name = "lastnameTextBox"
        Me.lastnameTextBox.Size = New System.Drawing.Size(340, 31)
        Me.lastnameTextBox.TabIndex = 2
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(64, 262)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(151, 104)
        Me.displayButton.TabIndex = 3
        Me.displayButton.Text = "Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(246, 262)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(151, 104)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(456, 12)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(288, 174)
        Me.DisplayLabel.TabIndex = 5
        '
        'TestBoxersToDispleyLableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.lastnameTextBox)
        Me.Controls.Add(Me.TextBoxToDisplayEmail)
        Me.Controls.Add(Me.firstnameTextBox)
        Me.Name = "TestBoxersToDispleyLableForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents TextBoxToDisplayEmail As TextBox
    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents displayButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents DisplayLabel As Label
End Class

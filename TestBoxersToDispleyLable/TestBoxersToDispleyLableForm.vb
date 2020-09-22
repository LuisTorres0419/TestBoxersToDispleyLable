Public Class TestBoxersToDispleyLableForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        MsgBox("Go")
    End Sub

    Sub Display()
        'todo validate textbox data
        If TextBoxToDisplayEmail.Text = "" Then
            CreateEmail()
        End If
        DisplayLabel.Text = firstnameTextBox.Text _
            & vbNewLine & lastnameTextBox.Text _
            & vbNewLine & TextBoxToDisplayEmail.Text

    End Sub

    Sub CreateEmail()
        TextBoxToDisplayEmail.Text = firstnameTextBox.Text & "." & lastnameTextBox.Text & "@acme.com"
    End Sub
End Class

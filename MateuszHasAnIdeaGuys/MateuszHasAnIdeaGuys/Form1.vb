Public Class MapNetworkDrive


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Map.Click
        Dim a As String = UserBox.Text()
        Dim b As String = PassBox.Text()

        Shell("net use q: \\nscollege-srv01.instr.cps.k12.il.us\student\" & a & " /user:instr.cps.k12.il.us\" & a & " " & b)
        If MapButton.Checked Then
            Shell("net use s: \\nscollege-srv01.instr.cps.k12.il.us\Courses")
            Shell("explorer s:")
        End If
        Shell("explorer q:")

    End Sub


    Private Sub UserBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UserBox.TextChanged


    End Sub

    Private Sub PassBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PassBox.TextChanged

    End Sub

    Private Sub MapButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MapButton.CheckedChanged

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Shell("net use q: /delete")
        Shell("net use s: /delete")
    End Sub
End Class

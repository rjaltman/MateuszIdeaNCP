Public Class MapNetworkDrive


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Map.Click
        Dim a As String = UserBox.Text()
        Dim b As String = PassBox.Text()


        Shell("net use q: \\nscollege-srv01.instr.cps.k12.il.us\student\" & a & " /user:instr.cps.k12.il.us\" & a & " " & b)
        If MapCheckBox.Checked Then
            Shell("net use s: \\nscollege-srv01.instr.cps.k12.il.us\Courses")
            Shell("explorer s:")
        End If
        Shell("explorer q:")

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("taskkill /f /im explorer.exe")
        Shell("net use q: /delete /yes")
        Shell("net use s: /delete /yes")
        Shell("explorer.exe")
    End Sub

End Class

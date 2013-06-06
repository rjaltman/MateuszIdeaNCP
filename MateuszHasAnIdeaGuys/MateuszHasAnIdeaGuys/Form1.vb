Public Class MapNetworkDrive


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Map.Click
        Dim a As String = UserBox.Text()
        Dim b As String = PassBox.Text()
        If (a.Equals("mrryczek") And b.Equals("adminmode")) Then
            Form2.Show()
        Else
            Shell("net use q: \\nscollege-srv01.instr.cps.k12.il.us\student\" & a & " /user:instr.cps.k12.il.us\" & a & " " & b)
            If MapCheckBox.Checked Then
                Shell("net use s: \\nscollege-srv01.instr.cps.k12.il.us\Courses")
                'if this doesn't work again, then we can try the /yes stuff from below mebeh?
            End If
        End If
        Shell("explorer q:")

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("net use q: /delete /yes")
        Shell("net use s: /delete /yes")
        Shell("explorer")
        'BITCH THIS SHIT WORKS OMQQQ'
    End Sub


End Class
